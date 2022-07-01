Public Class frmBuscarPresupuesto
    Public idVenta As Integer
    Private Sub frmBuscarPresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Me.buscarVentas()
        ElseIf chkTodos.Checked = False Then
            'cboCliente.Enabled = True
            lstVentas.Rows.Clear()
            btnBuscar.Enabled = True
        End If
    End Sub

    Private Function calcularTotalXfactura(ByVal idFactura As Integer) As Double

        Dim objVentas As New Ventas
        Dim odataset As New DataSet
        Dim odatasetarticulo As New DataSet
        Dim objArticulo As New Articulos
        Dim acumuladorMonto As Double
        Dim i As Integer
        acumuladorMonto = 0
        i = 0
        odataset = objVentas.buscarDetalleFacturaXventa(idFactura)

        While i < odataset.Tables(0).Rows.Count
            odatasetarticulo = objArticulo.buscarArticulo(odataset.Tables(0).Rows(i).Item("idArticulo"))
            acumuladorMonto = acumuladorMonto + (odataset.Tables(0).Rows(i).Item("cantidad") * (Me.calcularPrecioVenta(odatasetarticulo.Tables(0).Rows(0).Item("costo"), odatasetarticulo.Tables(0).Rows(0).Item("iva"), odatasetarticulo.Tables(0).Rows(0).Item("descuento"), odatasetarticulo.Tables(0).Rows(0).Item("utilidad"))))

            i = i + 1
        End While
        Return acumuladorMonto

    End Function

    Private Function calcularPrecioVenta(ByVal costo As String, ByVal iva As String, ByVal descuento As String, ByVal utilidad As String) As Double
        Dim precioVenta As Double
        Dim conIva As Double
        Dim conUtilidad As Double
        conIva = (costo * (1 + (iva / 100)))
        conUtilidad = conIva * (1 + (utilidad / 100))
        precioVenta = conUtilidad
        If descuento <> "" And descuento <> "0" Then
            precioVenta = precioVenta - ((precioVenta * descuento / 100))
        End If
        Return precioVenta
    End Function

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

    Private Sub buscarVentas()
        Dim objVentas As New Ventas
        Dim objCliente As New Clientes
        Dim objCondicionVenta As New CondicionVenta
        Dim odataset As New DataSet
        Dim odatasetCliente As New DataSet
        Dim objAfip As New AFIP
        Dim oDataSetAfip As New DataSet
        Dim tipoComprobante As String
        'Dim nombreCliente, apellidoCliente As String
        Dim odatasetClienteEncontrado As New DataSet
        Dim totalSinDescuentoPorFC As Double

        lstVentas.Rows.Clear()

        If chkTodos.Checked = True Then
            odataset = objVentas.buscarTodosLosPresupuestos
        Else
            'odataset = objVentas.buscarVentasXcliente(cboCliente.SelectedValue)
            Dim frmBuscarCliente As New frmBuscarCliente
            frmBuscarCliente.ShowDialog()
            If frmBuscarCliente.idClienteBusqueda <> 0 Then
                odataset = objVentas.buscarPresupuestoXcliente(frmBuscarCliente.idClienteBusqueda)
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
                lstVentas.Rows(i).Cells(0).Value = Me.generarNumeroFactura(odataset.Tables(0).Rows(i).Item("idVenta").ToString)
                lstVentas.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item("descripcion").ToString
                lstVentas.Rows(i).Cells(2).Value = FormatDateTime(odataset.Tables(0).Rows(i).Item("fecha_venta").ToString, DateFormat.ShortDate)
                'lstVentas.Rows(i).Cells(2).Value = odataset.Tables(0).Rows(i).Item("idCondicion_venta").ToString
                'lstVentas.Rows(i).Cells(3).Value = objCondicionVenta.buscarCondicionVenta(odataset.Tables(0).Rows(i).Item("idCondicion_venta")).Tables(0).Rows(0).Item("descripcion")
                lstVentas.Rows(i).Cells(3).Value = odataset.Tables(0).Rows(i).Item("CondVenta").ToString
                lstVentas.Rows(i).Cells(4).Value = odataset.Tables(0).Rows(i).Item("nombreCliente").ToString
                lstVentas.Rows(i).Cells(5).Value = odataset.Tables(0).Rows(i).Item("monto").ToString



                lstVentas.Rows(i).Cells(6).Value = odataset.Tables(0).Rows(i).Item("idVenta").ToString

                i = i + 1
            End While
        Else
            MsgBox("No se encuentran ventas para el Cliente buscado", MsgBoxStyle.Information, "CIBERLAN")
        End If
    End Sub
    Private Function calcularDescuentos(ByRef odataset As DataSet, ByVal total As Double, ByVal i As Integer) As Double
        Dim montoDescuento As Double
        montoDescuento = total * (Replace(odataset.Tables(0).Rows(i).Item("descuento_venta"), ",", ".") / 100)
        total = total - montoDescuento

        Return total
    End Function

    Private Function calcularRecargos(ByRef odataset As DataSet, ByVal total As Double, ByVal i As Integer) As Double
        Dim montoRecargo As Double
        montoRecargo = total * (Replace(odataset.Tables(0).Rows(i).Item("recargo_venta"), ",", ".") / 100)
        total = total + montoRecargo

        Return total
    End Function

    Private Sub cboCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCliente.SelectedIndexChanged
        Me.buscarVentas()
    End Sub

    Private Sub lstVentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstVentas.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lstVentas.RowCount = 0 Then
                idVenta = 0
            Else
                idVenta = CInt(lstVentas.CurrentRow.Cells(5).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If lstVentas.RowCount = 0 Then
            idVenta = 0
        Else
            idVenta = CInt(lstVentas.CurrentRow.Cells(6).Value.ToString)
        End If
        'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        idVenta = 0
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        buscarVentas()


    End Sub
End Class