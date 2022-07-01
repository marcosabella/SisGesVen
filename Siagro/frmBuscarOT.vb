Public Class frmBuscarOT
    Public idOT As Integer
    Private Sub frmBuscarOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkTodos.Checked = False
    End Sub
    Private Sub llenarComboCliente()
        Dim objCliente As New Clientes
        Dim odataset As New DataSet
        Dim i As Integer
        odataset = objCliente.buscarClientes()

        If odataset.Tables(0).Rows.Count <> 0 Then

            Me.cboCliente.DisplayMember = odataset.Tables(0).Columns(2).Caption.ToString
            Me.cboCliente.ValueMember = odataset.Tables(0).Columns(0).Caption.ToString
            Me.cboCliente.DataSource = odataset.Tables(0)
            Me.cboCliente.SelectedIndex = -1

        End If

    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If chkTodos.Checked = True Then
            cboCliente.Enabled = False
            'Me.cboCliente.SelectedIndex = -1
            txtCodCliente.Text = ""
            txtRazonSocialCliente.Text = ""
            btnBuscar.Enabled = False
            Me.buscarOT()
        ElseIf chkTodos.Checked = False Then
            'cboCliente.Enabled = True
            lstVentas.Rows.Clear()
            btnBuscar.Enabled = True
        End If
    End Sub


    Private Sub buscarOT()
        Dim objOT As New OrdenTrabajo
        Dim objCliente As New Clientes
        'Dim objCondicionVenta As New CondicionVenta
        Dim odataset As New DataSet
        Dim odatasetCliente As New DataSet
        'Dim objAfip As New AFIP
        'Dim oDataSetAfip As New DataSet
        'Dim tipoComprobante As String
        'Dim nombreCliente, apellidoCliente As String
        Dim odatasetClienteEncontrado As New DataSet
        'Dim totalSinDescuentoPorFC As Double

        lstVentas.Rows.Clear()

        If chkTodos.Checked = True Then
            odataset = objOT.BuscarTodasOrdenes
        Else

            Dim frmBuscarCliente As New frmBuscarCliente
            frmBuscarCliente.ShowDialog()
            If frmBuscarCliente.idClienteBusqueda <> 0 Then
                odataset = objOT.BuscarOrdenesXidClienteParaGrilla(frmBuscarCliente.idClienteBusqueda)
                If odataset.Tables(0).Rows.Count > 0 Then
                    odatasetCliente = objCliente.buscarClientesXid(frmBuscarCliente.idClienteBusqueda)
                    Me.txtCodCliente.Text = odatasetCliente.Tables(0).Rows(0).Item("idCLiente")
                    txtRazonSocialCliente.Text = odatasetCliente.Tables(0).Rows(0).Item("nombre") & " " & odatasetCliente.Tables(0).Rows(0).Item("apellido")
                End If
                'Me.txtCodigoArticulo.Focus()
            Else
                Exit Sub
            End If
        End If

        If odataset.Tables(0).Rows.Count > 0 Then

            Dim i As Integer = 0
            While odataset.Tables(0).Rows.Count > i
                'tipoComprobante = objAfip.buscarComprobantesCompraXid(odataset.Tables(0).Rows(0).Item("idComprobante")).Tables(0).Rows(0).Item("Descripcion")

                lstVentas.Rows.Add()
                lstVentas.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item("idOT").ToString
                lstVentas.Rows(i).Cells(2).Value = FormatDateTime(odataset.Tables(0).Rows(i).Item("fechaRecepcion").ToString, DateFormat.ShortDate)
                lstVentas.Rows(i).Cells(3).Value = FormatDateTime(odataset.Tables(0).Rows(i).Item("fechaEntrega").ToString, DateFormat.ShortDate)
                lstVentas.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item("nombreCliente").ToString
                lstVentas.Rows(i).Cells(4).Value = odataset.Tables(0).Rows(i).Item("idOT").ToString

                i = i + 1
            End While
        Else
            MsgBox("No se encuentran ventas para el Cliente buscado", MsgBoxStyle.Information, "OPTICA SANTA LUCIA")
        End If
    End Sub


    Private Sub cboCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCliente.SelectedIndexChanged
        Me.buscarOT()
    End Sub


    Private Sub lstVentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstVentas.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lstVentas.RowCount = 0 Then
                idOT = 0
            Else
                idOT = CInt(lstVentas.CurrentRow.Cells(4).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If lstVentas.RowCount = 0 Then
            idOT = 0
        Else
            idOT = CInt(lstVentas.CurrentRow.Cells(4).Value.ToString)
        End If
        'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        idOT = 0
        Me.Close()
    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        buscarOT()




    End Sub
End Class