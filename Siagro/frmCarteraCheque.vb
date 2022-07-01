Public Class frmCarteraCheque
    Dim objCheques As New Cheque
    Dim oDataSet As New DataSet
    Private Sub opTodosCheques_CheckedChanged(sender As Object, e As EventArgs) Handles opTodosCheques.CheckedChanged
        If opClientes.Checked = True Then
            Me.txtCodCliente.Enabled = True
            Me.txtRazonSocialCliente.Enabled = True
            Me.btnBuscarCliente.Enabled = True

            Me.txtCodCliente.Text = ""
            Me.txtRazonSocialCliente.Text = ""

        Else
            Me.txtCodCliente.Enabled = False
            Me.txtRazonSocialCliente.Enabled = False
            Me.btnBuscarCliente.Enabled = False

            Me.txtCodCliente.Text = ""
            Me.txtRazonSocialCliente.Text = ""
        End If
    End Sub

    Private Sub OpFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles OpFiltro.CheckedChanged
        If OpFiltro.Checked = True Then
            Me.opFecha.Enabled = True
            Me.opClientes.Enabled = True
            Me.opEnCartera.Enabled = True
        Else
            Me.opFecha.Enabled = False
            Me.opClientes.Enabled = False
            Me.opEnCartera.Enabled = False
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        lstCheques.Rows.Clear()
        If opTodosCheques.Checked = True Then
            ' para todos los clientes sin filtro
            lstCheques.Rows.Clear()
            oDataSet = objCheques.buscarCheques
            llenarGrilla(oDataSet)
        Else
            Dim cadena As String

            If opClientes.Checked = True Then
                cadena = "select * from Cheques where idCliente =  " & Me.txtCodCliente.Text.ToString
                If opFecha.Checked = True Then
                    cadena = cadena & " and vencimiento between Format(#" & FormatDateTime(dtpFechaDesde.Value, DateFormat.ShortDate) & "#,'mm/dd/yyyy')  and format(#" & FormatDateTime(Me.dtpFechaHasta.Value, DateFormat.ShortDate) & "#,'mm/dd/yyyy') "
                End If
                If opEnCartera.Checked = True Then
                    cadena = cadena & " and enCartera = true"
                End If
            End If

            If opEnCartera.Checked = True Then
                cadena = "select * from Cheques where enCartera = true"
                If opFecha.Checked = True Then
                    cadena = cadena & " and vencimiento between Format(#" & FormatDateTime(dtpFechaDesde.Value, DateFormat.ShortDate) & "#,'mm/dd/yyyy')  and format(#" & FormatDateTime(Me.dtpFechaHasta.Value, DateFormat.ShortDate) & "#,'mm/dd/yyyy') "
                End If
                If opClientes.Checked = True Then
                    cadena = cadena & " and idCliente =  " & Me.txtCodCliente.Text.ToString
                End If
            End If

            If opFecha.Checked = True Then
                cadena = "select * from Cheques where vencimiento between  Format(#" & FormatDateTime(dtpFechaDesde.Value, DateFormat.ShortDate) & "#,'mm/dd/yyyy')  and format(#" & FormatDateTime(Me.dtpFechaHasta.Value, DateFormat.ShortDate) & "#,'mm/dd/yyyy') "
                If opEnCartera.Checked = True Then
                    cadena = cadena & " and enCartera = true"
                End If
                If opClientes.Checked = True Then
                    cadena = cadena & " and idCliente =  " & Me.txtCodCliente.Text.ToString
                End If

            End If

            lstCheques.Rows.Clear()
            oDataSet = objCheques.buscarChequesXparametros(cadena)
            llenarGrilla(oDataSet)
            'MsgBox("Fede, por ahora esto no está listo jajaja")
        End If

    End Sub

    Private Sub llenarGrilla(ByVal oDataSet As DataSet)
        lstCheques.Rows.Clear()
        Dim objVentas As New Ventas
        Dim objPagos As New Pagos
        Dim oDataSetVentas As New DataSet
        Dim oDataSetPagos As New DataSet
        Dim objCliente As New Clientes
        Dim oDataSetClientes As New DataSet

        If oDataSet.Tables(0).Rows.Count = 0 Then
            Exit Sub
        End If


        Dim i As Integer = 0
        While oDataSet.Tables(0).Rows.Count > i
            lstCheques.Rows.Add()
            lstCheques.Rows(i).Cells(0).Value = oDataSet.Tables(0).Rows(i).Item("Id").ToString
            lstCheques.Rows(i).Cells(1).Value = oDataSet.Tables(0).Rows(i).Item("nroCheque")
            lstCheques.Rows(i).Cells(2).Value = oDataSet.Tables(0).Rows(i).Item("Emisor")
            lstCheques.Rows(i).Cells(3).Value = FormatDateTime(oDataSet.Tables(0).Rows(i).Item("vencimiento").ToString, DateFormat.ShortDate)
            If oDataSet.Tables(0).Rows(i).Item("idVenta").ToString <> 0 Then
                oDataSetVentas = objVentas.buscarVentasXidVenta(oDataSet.Tables(0).Rows(i).Item("idVenta"))
                lstCheques.Rows(i).Cells(4).Value = "CN - " & Me.generarNumeroFactura(oDataSet.Tables(0).Rows(i).Item("idVenta").ToString)
                oDataSetClientes = objCliente.buscarClientesXid(oDataSet.Tables(0).Rows(i).Item("idCliente"))

            ElseIf oDataSet.Tables(0).Rows(i).Item("idPago").ToString <> 0 Then
                oDataSetPagos = objPagos.buscarPagosXid(oDataSet.Tables(0).Rows(i).Item("idPago"))
                lstCheques.Rows(i).Cells(4).Value = "RN: - " & Me.generarNumeroFactura(oDataSet.Tables(0).Rows(i).Item("idPago").ToString)

                oDataSetClientes = objCliente.buscarClientesXid(oDataSet.Tables(0).Rows(i).Item("idCliente"))
                'oDataSetClientes = objCliente.buscarCliente(objPagos.buscarPagosXid("idPago").Tables(0).Rows(0).Item("idCliente"))
            End If

            If oDataSetClientes.Tables(0).Rows.Count > 0 Then
                lstCheques.Rows(i).Cells(5).Value = oDataSetClientes.Tables(0).Rows(0).Item("nombre") & " " & oDataSetClientes.Tables(0).Rows(0).Item("apellido")
            Else
                lstCheques.Rows(i).Cells(5).Value = "Sin Especificar"
            End If
            lstCheques.Rows(i).Cells(6).Value = FormatCurrency(oDataSet.Tables(0).Rows(i).Item("monto"), 2)
            lstCheques.Rows(i).Cells(7).Value = oDataSet.Tables(0).Rows(i).Item("enCartera")
            lstCheques.Rows(i).Cells(8).Value = IIf(oDataSet.Tables(0).Rows(i).Item("destinatario").ToString = "", "...", oDataSet.Tables(0).Rows(i).Item("Destinatario"))
            i = i + 1
        End While
    End Sub

    Private Function generarNumeroFactura(ByVal idFactura As Integer) As String
        Dim oDataSet As New DataSet
        Dim objVentas As New Ventas
        Dim i As Integer
        Dim cadena As String
        Dim nroNV As Integer
        Dim numeroFacturaConvertido As String
        nroNV = idFactura

        cadena = ""
        i = nroNV.ToString.Length
        While i < 7
            cadena = cadena.ToString & "0"
            i = i + 1
        End While
        numeroFacturaConvertido = "0001 - " & cadena & nroNV
        Return numeroFacturaConvertido

    End Function

    Private Sub lstCheques_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles lstCheques.CellEndEdit
        'If MessageBox.Show("Se registrará egreso de cheque en cartera ¿Desea continuar?", "SISTEMA PARA HOSPITALES PÚBLICOS DE GESTIÓN DESCENTRALIZADA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
        '    'If lstCheques.CurrentRow.Cells(6).Value = Nothing Then
        '    'montoDebito = Nothing
        '    'Else
        '    'montoDebito = lstDetalleProducido.CurrentRow.Cells(6).Value.ToString
        '    'montoDebito = Replace(lstDetalleProducido.CurrentRow.Cells(6).Value.ToString, ".", ",")
        '    Dim objCheque As New Cheque
        '    objCheque.idCheque = lstCheques.CurrentRow.Cells(0).Value.ToString
        '    objCheque.enCartera = lstCheques.CurrentRow.Cells(6).Value.ToString
        '    MsgBox(lstCheques.CurrentRow.Cells(6).Value.ToString)
        '    objCheque.modificarChequeEncartera(objCheque)

        '    '   End If

        'Else
        '    'lstCheques.CurrentRow.Cells(6).Value = valorCelda

        '    'End If
        'End If
        ''llenarGrilla(oDataSet)
    End Sub

    Private Sub lstCheques_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lstCheques.CellContentClick
        If MessageBox.Show("Se registrará egreso de cheque en cartera ¿Desea continuar?", "SISTEMA DE GESTIÓN DE STOCK Y VENTAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            Dim objCheque As New Cheque
            objCheque.destinatario = ""
            If lstCheques.CurrentRow.Cells(7).Value = True Then
                objCheque.enCartera = False
                objCheque.destinatario = InputBox("Ingrese el destinatario del cheque", "Registro de destinatario")
            ElseIf lstCheques.CurrentRow.Cells(7).Value = False Then
                objCheque.enCartera = True
                objCheque.destinatario = "..."
            End If
            objCheque.idCheque = lstCheques.CurrentRow.Cells(0).Value.ToString
            If objCheque.destinatario <> "" AndAlso objCheque.destinatario IsNot Nothing Then
                objCheque.registrarDestinatario(objCheque)
            End If
            objCheque.modificarChequeEncartera(objCheque)

        Else

        End If
        lstCheques.Rows.Clear()
        oDataSet = objCheques.buscarCheques
        llenarGrilla(oDataSet)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub frmCarteraCheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opTodosCheques.Checked = True
        opClientes.Enabled = False
        opEnCartera.Enabled = False
        opFecha.Enabled = False
        OpFiltro.Checked = False
        dtpFechaDesde.Enabled = False
        dtpFechaHasta.Enabled = False
    End Sub

    Private Sub opClientes_CheckedChanged(sender As Object, e As EventArgs) Handles opClientes.CheckedChanged
        If opClientes.Checked = True Then
            txtCodCliente.Enabled = True
            txtRazonSocialCliente.Enabled = True
            btnBuscarCliente.Enabled = True
        ElseIf opClientes.Checked = False Then
            txtCodCliente.Enabled = False
            txtRazonSocialCliente.Enabled = False
            btnBuscarCliente.Enabled = False
        End If
    End Sub

    Private Sub opFecha_CheckedChanged(sender As Object, e As EventArgs) Handles opFecha.CheckedChanged
        If opFecha.Checked = False Then
            dtpFechaDesde.Enabled = False
            dtpFechaHasta.Enabled = False
        ElseIf opFecha.Checked = True Then
            dtpFechaDesde.Enabled = True
            dtpFechaHasta.Enabled = True
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click

        Dim objCliente As New Clientes
        Dim odataset As New DataSet

        Dim min As Integer = 0

        Dim frmBuscarCliente As New frmBuscarCliente
        frmBuscarCliente.ShowDialog()
        If frmBuscarCliente.idClienteBusqueda <> 0 Then

            Dim idCliente As Integer
            idCliente = frmBuscarCliente.idClienteBusqueda
            odataset = objCliente.buscarClientesXid(idCliente)
            Me.txtCodCliente.Text = odataset.Tables(0).Rows(0).Item("idCLiente")
            txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("nombre") & " " & odataset.Tables(0).Rows(0).Item("apellido")
        End If
    End Sub
End Class