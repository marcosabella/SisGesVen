Public Class frmBuscarPagos
    Public idPago As Integer
    Private Sub frmBuscarPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkTodos.Checked = False
        Me.llenarComboCliente()
    End Sub

    Private Sub llenarComboCliente()
        Dim objCliente As New Clientes
        Dim odataset As New DataSet
        'Dim i As Integer
        odataset = objCliente.buscarClientes()
        Dim nombreCliente As String
        If odataset.Tables(0).Rows.Count <> 0 Then
            'nombreCliente = odataset.Tables(0).Columns(2).Caption.ToString & " " & odataset.Tables(0).Columns(3).Caption.ToString
            Me.cboCliente.DisplayMember = odataset.Tables(0).Columns(2).Caption.ToString
            Me.cboCliente.ValueMember = odataset.Tables(0).Columns(0).Caption.ToString
            Me.cboCliente.DataSource = odataset.Tables(0)
            Me.cboCliente.SelectedIndex = -1

        End If

    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If chkTodos.Checked = True Then
            cboCliente.Enabled = False
            Me.cboCliente.SelectedIndex = -1
            Me.buscarPagos()
        ElseIf chkTodos.Checked = False Then
            cboCliente.Enabled = True
        End If
    End Sub
    Private Sub cboCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCliente.SelectedIndexChanged
        Me.buscarPagos()
    End Sub



    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        idPago = 0
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If lstPagos.RowCount = 0 Then
            idPago = 0
        Else
            idPago = CInt(lstPagos.CurrentRow.Cells(0).Value.ToString)
        End If
        'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
        Me.Close()
    End Sub

    Private Sub lstPagos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstPagos.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lstPagos.RowCount = 0 Then
                idPago = 0
            Else
                idPago = CInt(lstPagos.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        End If
    End Sub

    Private Sub buscarPagos()
        Dim objPagos As New Pagos
        Dim objCliente As New Clientes
        Dim objCondicionVenta As New CondicionVenta
        Dim odataset As New DataSet
        lstPagos.Rows.Clear()

        'If chkTodos.Checked = True Then
        '    odataset = objVentas.buscarTodasLasVentas
        'Else
        If cboCliente.Text = "" Then
            Exit Sub
        End If

        odataset = objPagos.buscarPagosXcliente(cboCliente.SelectedValue)
        'End If
        If odataset.Tables(0).Rows.Count > 0 Then

            Dim i As Integer = 0
            While odataset.Tables(0).Rows.Count > i
                lstPagos.Rows.Add()
                lstPagos.Rows(i).Cells(2).Value = Me.generarNumeroRecibo(odataset.Tables(0).Rows(i).Item("idPago").ToString)
                lstPagos.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item("fecha_pago").ToString
                'lstVentas.Rows(i).Cells(2).Value = odataset.Tables(0).Rows(i).Item("idCondicion_venta").ToString
                'lstPagos.Rows(i).Cells(2).Value = objCondicionVenta.buscarCondicionVenta(odataset.Tables(0).Rows(i).Item("idCondicion_venta")).Tables(0).Rows(0).Item("descripcion")

                'lstPagos.Rows(i).Cells(3).Value = objCliente.buscarCliente(odataset.Tables(0).Rows(i).Item("idCliente")).Tables(0).Rows(0).Item("razon_social")
                lstPagos.Rows(i).Cells(3).Value = " $ " & FormatNumber((odataset.Tables(0).Rows(i).Item("importe").ToString), 2)
                lstPagos.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item("idPago").ToString

                i = i + 1
            End While
        End If
    End Sub

    Private Function generarNumeroRecibo(ByVal idRecibo As Integer) As String
        Dim oDataSet As New DataSet
        Dim objPagos As New Pagos
        Dim i As Integer
        Dim cadena As String
        Dim nroNR As Integer
        Dim numeroReciboConvertido As String
        nroNR = idRecibo

        cadena = ""
        i = nroNR.ToString.Length
        While i < 7
            cadena = cadena.ToString & "0"
            i = i + 1
        End While
        numeroReciboConvertido = "0001 - " & cadena & nroNR
        Return numeroReciboConvertido

    End Function
End Class