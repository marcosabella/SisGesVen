Imports System.ComponentModel
Public Class frmPresupuestos
    Private precioArticuloSeleccionado, ivaArticuloSeleccionado, utilidad, descuento As Double
    Dim accion As String
    Dim stock As Integer
    Dim idVentaFN As Integer
    Dim codigoArticuloDeVenta As Integer
    Dim dolar As Double = 0
    Dim esPrecioDolar As Boolean = False
    Dim objCheque As New Cheque
    Dim idPresupuesto As Integer


    Private Sub frmPresupuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        codigoArticuloDeVenta = 0
        ' obtenerCotizacion()
    End Sub

    Private Sub obtenerCotizacion()
        Dim objVentas As New Ventas
        Dim oDataSet As New DataSet
        'oDataSet = objVentas.ultimaCotización
        If oDataSet.Tables(0).Rows.Count > 0 Then

            Me.lblDolar.Text = " Dolar: $" & oDataSet.Tables(0).Rows(0).Item("monto")
            dolar = oDataSet.Tables(0).Rows(0).Item("monto")
        Else
            'Me.cotizacionDolar()
            Me.lblDolar.Text = " Dolar sin cotización"
        End If

    End Sub

    Private Function obtenerCotizacionXproducto(ByVal tipoDolar As String) As Double
        Dim objVentas As New Ventas
        Dim oDataSet As New DataSet
        Dim montoDolar As Double
        oDataSet = objVentas.ultimaCotización(tipoDolar)
        montoDolar = oDataSet.Tables(0).Rows(0).Item("monto")
        Return CDec(montoDolar)

    End Function

    Private Sub inicializarControles()
        codigoArticuloDeVenta = 0
        Me.tssNuevo.Enabled = True
        Me.tssModificar.Enabled = False
        Me.tssConsultar.Enabled = True
        Me.tssBorrar.Enabled = False

        Me.btnBuscarCliente.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btnImprimir.Enabled = False
        Me.btnImprimirDetalle.Enabled = False
        Me.btnMandarMail.Enabled = False
        Me.btnNuevoCliente.Enabled = False
        Me.btnEditarMedioPago.Enabled = False
        Me.btnConfirmar.Enabled = False
        Me.lstArticulos.Enabled = False
        Me.lstOpcionales.Enabled = False

        Me.txtCantidad.Enabled = False
        'Me.txtVendedor.Enabled = False
        Me.txtCodCliente.Enabled = False
        Me.txtCodigoArticulo.Enabled = False
        ' Me.txtCuit.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.txtFechaVto.Enabled = False
        Me.txtIva.Enabled = False
        Me.txtRazonSocialCliente.Enabled = False
        Me.txtSubTotal.Enabled = False
        Me.txtTotal.Enabled = False
        Me.txtDescuento.Enabled = False
        Me.txtRecargo.Enabled = False
        Me.txtFacturaNumero.Enabled = False
        Me.txtNroCupon.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtDatosCheques.Enabled = False
        Me.dtpFechaAlta.Enabled = False

        Me.cboCondVenta.Enabled = False
        'Me.cboIva.Enabled = False
        Me.cboComprobantes.Enabled = False
        Me.cboTipoTarjeta.Enabled = False

        ' Me.cboIva.SelectedIndex = -1
        Me.cboCondVenta.SelectedIndex = 1
        Me.cboCondVenta.Enabled = False
        Me.cboComprobantes.SelectedIndex = -1
        Me.cboTipoTarjeta.SelectedIndex = -1
        Me.txtCantidad.Text = ""
        'Me.txtVendedor.Text = ""
        Me.txtCodCliente.Text = ""
        Me.txtNroCupon.Text = ""
        Me.txtCodigoArticulo.Text = ""
        ' Me.txtCuit.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtFechaVto.Text = ""
        Me.txtIva.Text = ""
        Me.txtRazonSocialCliente.Text = ""
        Me.txtSubTotal.Text = ""
        Me.txtTotal.Text = ""
        Me.txtDescuento.Text = ""
        Me.txtRecargo.Text = ""
        Me.txtFacturaNumero.Text = ""
        Me.txtObservaciones.Text = ""
        Me.txtDatosCheques.Text = ""
        Me.txtSubTotal.Text = ""
        Me.txtIva.Text = ""
        Me.txtDescuento.Text = ""
        Me.txtRecargo.Text = ""
        Me.txtTotal.Text = ""
        Me.idVentaFN = 0
        Me.alerta.Clear()
        Me.lstArticulos.Rows.Clear()
        Me.lstOpcionales.Rows.Clear()
        Me.accion = ""
        objCheque = objCheque.inicializar(objCheque)
    End Sub

    Private Sub txtCodigoArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtCodigoArticulo.Text = "" Then
                Dim frmBuscarArticulos As New frmBuscarArticulos
                frmBuscarArticulos.ShowDialog()
                Me.txtCodigoArticulo.Text = frmBuscarArticulos.codigoArticulo
                Me.llenarCampoArticulo(Me.txtCodigoArticulo.Text)
            Else
                'Me.llenarCampoArticuloCodigoBarras(Me.txtCodigoArticulo.Text)
                Me.llenarCampoArticulo(Me.txtCodigoArticulo.Text)
            End If
        End If
        If e.KeyCode = Keys.N Then

            Dim frmNuevoProductoVarios As New frmNuevoProductoVario
            frmNuevoProductoVarios.ShowDialog()
            Me.txtCodigoArticulo.Text = frmNuevoProductoVarios.ultimoCodigoCreado
            Me.llenarCampoArticulo(Me.txtCodigoArticulo.Text)
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click

        Dim objCliente As New Clientes
        Dim odataset As New DataSet

        Dim min As Integer = 0

        Dim frmBuscarCliente As New frmBuscarCliente
        frmBuscarCliente.ShowDialog()
        If frmBuscarCliente.idClienteBusqueda <> 0 Then
            ' Me.inicializarControles()
            Dim idCliente As Integer
            idCliente = frmBuscarCliente.idClienteBusqueda
            odataset = objCliente.buscarClientesXid(idCliente)
            Me.txtCodCliente.Text = odataset.Tables(0).Rows(0).Item("idCLiente")
            txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("nombre") & " " & odataset.Tables(0).Rows(0).Item("apellido")
            Me.txtCodigoArticulo.Focus()

        End If
    End Sub

    Private Sub btnNuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCliente.Click
        Dim frmNuevoCliente As New frmCliente("nuevoCliente")

        frmNuevoCliente.ShowDialog()


        If frmNuevoCliente.nuevoCliente = 1 Then
            Dim objCliente As New Clientes
            Dim odataset As New DataSet
            odataset = objCliente.buscarCliente(objCliente.buscarUltimoCliente().Tables(0).Rows(0).Item(0))
            Me.txtCodCliente.Text = odataset.Tables(0).Rows(0).Item("idCliente")
            txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("nombre") & " " & odataset.Tables(0).Rows(0).Item("apellido")
        End If

    End Sub

    Private Sub calcularFechaVencimiento()
        Dim fechaVencimiento As Date
        fechaVencimiento = DateAdd(DateInterval.Day, 30, dtpFechaAlta.Value)
        Me.txtFechaVto.Text = FormatDateTime(fechaVencimiento, DateFormat.ShortDate)
    End Sub

    Private Sub llenarCampoArticulo(ByVal codigoArticulo As String)
        Dim objArticulo As New Articulos
        Dim oDataSet As New DataSet

        If codigoArticulo.Length = 13 Then
            oDataSet = objArticulo.buscarArticulo(codigoArticulo)
        Else
            oDataSet = objArticulo.buscarArticuloXcodigo(codigoArticulo)
        End If


        If oDataSet.Tables(0).Rows.Count > 0 Then
            codigoArticuloDeVenta = oDataSet.Tables(0).Rows(0).Item("idArticulo")
            Me.txtDescripcion.Text = oDataSet.Tables(0).Rows(0).Item("descripcion")
            Me.precioArticuloSeleccionado = FormatNumber(oDataSet.Tables(0).Rows(0).Item("costo") + (oDataSet.Tables(0).Rows(0).Item("costo") * (oDataSet.Tables(0).Rows(0).Item("utilidad") / 100)), 2)
            Me.precioArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado - (Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("descuento") / 100)), 2)
            Me.ivaArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("iva") / 100), 2)

            If oDataSet.Tables(0).Rows(0).Item("moneda") = "U$D" Then
                Me.precioArticuloSeleccionado = (FormatNumber(Me.precioArticuloSeleccionado - (Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("descuento") / 100)), 2)) * dolar
                esPrecioDolar = True
            Else
                esPrecioDolar = False
            End If

            Me.stock = oDataSet.Tables(0).Rows(0).Item("stock")
            Me.txtCantidad.Focus()
        End If

    End Sub

    Private Sub llenarCampoArticuloCodigoBarras(ByVal codigoArticulo As String)
        Dim objArticulo As New Articulos
        Dim oDataSet As New DataSet

        oDataSet = objArticulo.buscarArticuloCodigoBarras(codigoArticulo)
        If oDataSet.Tables(0).Rows.Count > 0 Then
            codigoArticuloDeVenta = oDataSet.Tables(0).Rows(0).Item("idArticulo")
            Me.txtDescripcion.Text = oDataSet.Tables(0).Rows(0).Item("descripcion")
            Me.precioArticuloSeleccionado = FormatNumber(oDataSet.Tables(0).Rows(0).Item("costo") + (oDataSet.Tables(0).Rows(0).Item("costo") * (oDataSet.Tables(0).Rows(0).Item("utilidad") / 100)), 2)
            Me.precioArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado - (Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("descuento") / 100)), 2)
            Me.ivaArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("iva") / 100), 2)

            If oDataSet.Tables(0).Rows(0).Item("moneda") = "U$D" Then
                Me.precioArticuloSeleccionado = (FormatNumber(Me.precioArticuloSeleccionado - (Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("descuento") / 100)), 2)) * dolar
                esPrecioDolar = True
            Else
                esPrecioDolar = False
            End If


            Me.stock = oDataSet.Tables(0).Rows(0).Item("stock")
            Me.txtCantidad.Focus()
        End If

    End Sub

    Private Function calcularPrecioVenta(ByVal costo As String, ByVal iva As String, ByVal descuento As String, ByVal utilidad As String) As Double
        Dim precioVenta As Double
        Dim conIva As Double
        Dim conUtilidad As Double
        conIva = FormatNumber((costo * (1 + (iva / 100))), 2)
        conUtilidad = FormatNumber(conIva * (1 + (utilidad / 100)), 2)
        FormatNumber(precioVenta = conUtilidad, 2)
        If descuento <> "" And descuento <> "0" Then
            FormatNumber(precioVenta = precioVenta - (precioVenta * (descuento / 100)), 2)
        End If
        Return precioVenta
    End Function

    Private Sub txtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
        Dim objArticulo As New Articulos
        Dim moneda As String
        If esPrecioDolar = True Then
            moneda = "U$D "
        Else
            moneda = "$ "
        End If

        Dim objVenta As New Ventas
        Dim montoDolar As Double
        Dim idDolar As Integer
        'obtener moneda del articulo
        moneda = objArticulo.buscarArticuloXcodigo(Me.txtCodigoArticulo.Text).Tables(0).Rows(0).Item("moneda")
        'If moneda = "U$D BLUE" Then
        'MsgBox(moneda)

        If moneda <> "AR$" Then
            If IsDBNull(objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)) Then
                montoDolar = InputBox("Ingrese el monto de la divisa", "Ingrese el monto de la divisa")
                ' lstArticulos.Rows(i).Cells(5).Value = "S/C"
                objVenta.tipoDolar = moneda
                objVenta.precioDolar = Replace(montoDolar, ".", ",")
                objVenta.registrarPrecioDolar(objVenta)

            Else
                montoDolar = objVenta.cotizaciónXid(objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)).Tables(0).Rows(0).Item("monto")
                idDolar = objVenta.cotizaciónXid(objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)).Tables(0).Rows(0).Item("id")

                'lstArticulos.Rows(i).Cells(5).Value = "$ " & CStr(montoDolar)
            End If
        Else
            montoDolar = 1
            'lstArticulos.Rows(i).Cells(5).Value = "$ " & CStr(montoDolar)

        End If
        'End If

        If e.KeyCode = Keys.Enter Then

            If Me.txtCantidad.Text = "" Then
                'If 1 <= Me.stock Then
                'Else
                Me.lstArticulos.Rows.Add()
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(0).Value = codigoArticuloDeVenta
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(2).Value = Me.txtDescripcion.Text
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value = Me.ivaArticuloSeleccionado

                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(1).Value = "1"
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(3).Value = Me.precioArticuloSeleccionado
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value = (Me.precioArticuloSeleccionado + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value) * montoDolar
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(6).Value = (Me.precioArticuloSeleccionado + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value) * montoDolar
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(7).Value = montoDolar.ToString

                objArticulo.idArticulo = codigoArticuloDeVenta
                'objArticulo.restarStockArticulo(objArticulo, 1)
                'Else
                'MsgBox("El artículo no contiene el stock que usted a ingrasado. Solo dispone de: " & Me.stock & " artículos",, "SISTEMAS GESTIÓN DE VENTAS Y STOCK")
                Me.txtCantidad.Focus()
                '    Exit Sub
                'End If

            Else
                ' If Me.txtCantidad.Text <= Me.stock Then
                Me.lstArticulos.Rows.Add()
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(0).Value = codigoArticuloDeVenta
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(2).Value = Me.txtDescripcion.Text
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value = Me.ivaArticuloSeleccionado

                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(1).Value = Me.txtCantidad.Text
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(3).Value = Me.precioArticuloSeleccionado
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value = (Me.precioArticuloSeleccionado + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value) * montoDolar
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(6).Value = (lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value) * Me.txtCantidad.Text
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(7).Value = montoDolar.ToString

                objArticulo.idArticulo = codigoArticuloDeVenta
                'objArticulo.restarStockArticulo(objArticulo, Me.txtCantidad.Text)
                'Else
                'MsgBox("El artículo no contiene el stock que usted a ingrasado. Solo dispone de: " & Me.stock & " artículos",, "SISTEMAS GESTIÓN DE VENTAS Y STOCK")
                'Me.txtCantidad.Focus()
                '    Exit Sub
                'End If

            End If

            'If oDataSet.Tables(0).Rows(i).Item("precio") = "Consultar" Then

            Me.txtCantidad.Text = ""
            Me.txtDescripcion.Text = ""
            Me.txtCodigoArticulo.Text = ""
            Me.sumarPrecios()
            Me.txtCodigoArticulo.Focus()
        End If

    End Sub

    Private Sub sumarPrecios()
        Dim i As Integer = 0
        Dim iva, total, subtotal As Double
        While i < Me.lstArticulos.Rows.Count
            iva = FormatNumber((CDbl(Me.lstArticulos.Rows(i).Cells(4).Value) * Me.lstArticulos.Rows(i).Cells(1).Value) + iva, 2)
            total = FormatNumber(CDbl(Me.lstArticulos.Rows(i).Cells(6).Value) + total, 2)
            i = i + 1
        End While
        Me.txtSubTotal.Text = FormatNumber(total - iva, 2)
        Me.txtIva.Text = FormatNumber(iva, 2)
        subtotal = (CDbl(Me.txtSubTotal.Text) + CDbl(Me.txtIva.Text))
        Me.txtIva.Text = 0
        Me.txtSubTotal.Text = "$ " & FormatNumber(subtotal, 2)
        Me.txtTotal.Text = "$ " & FormatNumber(total, 2)

        Me.calcularDescuentos()
        Me.calcularRecargos()
    End Sub

    Private Sub lstArticulos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstArticulos.KeyDown
        Dim objArticulo As New Articulos
        If e.KeyCode = Keys.Delete Then
            If lstArticulos.Rows.Count > 0 Then
                If MsgBox("Desea eliminar Item?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                    objArticulo.idArticulo = CInt(lstArticulos.CurrentRow.Cells(0).Value.ToString)
                    objArticulo.sumarStockArticulo(objArticulo, CInt(lstArticulos.CurrentRow.Cells(1).Value.ToString))
                    lstArticulos.Rows.Remove(lstArticulos.CurrentRow())
                    If lstArticulos.Rows.Count > 0 Then
                        Me.sumarPrecios()

                    Else
                        Me.txtSubTotal.Text = ""
                        Me.txtIva.Text = ""
                        Me.txtTotal.Text = ""
                    End If
                End If
                Me.txtCodigoArticulo.Focus()
            End If
        End If
    End Sub

    Private Sub tssCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssCerrar.Click
        Me.Close()
    End Sub

    Private Sub habilitarControles()
        Me.tssNuevo.Enabled = False
        Me.tssModificar.Enabled = False
        Me.tssConsultar.Enabled = False
        Me.tssBorrar.Enabled = False

        Me.btnBuscarCliente.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.btnImprimir.Enabled = False
        Me.btnMandarMail.Enabled = False
        Me.btnImprimirDetalle.Enabled = False
        Me.btnNuevoCliente.Enabled = True
        Me.btnConfirmar.Enabled = False

        Me.lstArticulos.Enabled = True
        Me.lstOpcionales.Enabled = True

        Me.txtCantidad.Enabled = True
        Me.txtCodCliente.Enabled = True
        Me.txtCodigoArticulo.Enabled = True
        'Me.txtCuit.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtFechaVto.Enabled = True
        Me.txtIva.Enabled = True
        Me.txtRazonSocialCliente.Enabled = True
        Me.txtSubTotal.Enabled = True
        Me.txtTotal.Enabled = True
        Me.txtDescuento.Enabled = True
        Me.txtRecargo.Enabled = True
        Me.txtFacturaNumero.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.dtpFechaAlta.Enabled = True
        Me.txtDatosCheques.Enabled = True

        'Me.cboCondVenta.Enabled = True
        'Me.cboIva.Enabled = True
        Me.cboComprobantes.Enabled = True


        alerta.Clear()
        Me.btnBuscarCliente.Focus()

        Me.cboComprobantes.Enabled = False
    End Sub

    Private Sub tssNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssNuevo.Click
        Me.habilitarControles()
        '333 NUMERO DE COMPROBANTE DE PRESUPUESTO
        Me.cboComprobantes.SelectedValue = 333
        idPresupuesto = 0
        Me.generarNumeroFactura()
        accion = "nuevo"
        Me.calcularFechaVencimiento()
        'Dim odataset As New DataSet
        'Dim objCliente As New Clientes
        'odataset = objCliente.buscarClientesXid(1)
        'Me.txtCodCliente.Text = odataset.Tables(0).Rows(0).Item("idCLiente")
        'txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("nombre") & " " & odataset.Tables(0).Rows(0).Item("apellido")
        cboCondVenta.SelectedIndex = 0
        Me.txtCodigoArticulo.Focus()

    End Sub

    Private Sub generarNumeroFactura()
        Dim oDataSet As New DataSet
        Dim objVentas As New Ventas
        oDataSet = objVentas.ultimaVenta(333)
        Dim i As Integer
        Dim cadena As String
        Dim nroNV As Integer
        Dim ultimoIdNotaVenta As Integer
        'oDataSet = objVentas.ultimaVenta

        If oDataSet.Tables(0).Rows(0).Item(0).ToString = "" Then
            ultimoIdNotaVenta = 0
        Else

            ultimoIdNotaVenta = oDataSet.Tables(0).Rows(0).Item(0)

        End If
        nroNV = ultimoIdNotaVenta + 1
        cadena = ""
        'i = oDataSet.Tables(0).Rows(0).Item(0).ToString.Length
        i = nroNV.ToString.Length

        While i < 8
            cadena = cadena.ToString & "0"
            i = i + 1
        End While
        Me.txtFacturaNumero.Text = "0001" & cadena & nroNV
        'modificacion ultima
        idVentaFN = nroNV
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
        While i < 8
            cadena = cadena.ToString & "0"
            i = i + 1
        End While
        numeroFacturaConvertido = "0001 - " & cadena & nroNV
        Return numeroFacturaConvertido

    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'reestablecer el stock
        Dim objVentas As New Ventas
        Dim objArticulo As New Articulos
        Dim i As Integer
        i = 0

        While i < Me.lstArticulos.Rows.Count

            objArticulo.idArticulo = CInt(lstArticulos.Rows(i).Cells(0).Value.ToString)
            ' objArticulo.sumarStockArticulo(objArticulo, CInt(lstArticulos.Rows(i).Cells(1).Value.ToString))

            i = i + 1

        End While

        Me.inicializarControles()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim objVentas As New Ventas
        Dim estadoValidacion As Integer
        alerta.Clear()
        estadoValidacion = 0

        If Me.txtRazonSocialCliente.Text = "" Then
            estadoValidacion = 1
            alerta.SetError(Me.txtRazonSocialCliente, "Ingrese el nombre del cliente")

        End If
        If lstArticulos.Rows.Count = 0 Then
            estadoValidacion = 1
            alerta.SetError(Me.lstArticulos, "Ingrese los artículos")
        End If
        If cboCondVenta.SelectedIndex = -1 Then
            estadoValidacion = 1
            alerta.SetError(Me.cboCondVenta, "Seleccione condición de venta")
        End If
        If cboCondVenta.Text = "Tarjeta" Then
            If cboTipoTarjeta.SelectedIndex = -1 Then
                estadoValidacion = 1
                alerta.SetError(Me.cboTipoTarjeta, "Seleccione tipo tarjeta")
            End If
        End If



        If estadoValidacion = 0 Then
            objVentas.fecha_venta = Me.dtpFechaAlta.Text
            objVentas.idCondicion_venta = Me.cboCondVenta.SelectedValue
            objVentas.idComprobante = Me.cboComprobantes.SelectedValue
            objVentas.idCliente = Me.txtCodCliente.Text
            objVentas.observaciones = Me.txtObservaciones.Text
            If Me.txtDescuento.Text = "" Then
                objVentas.descuento_venta = 0
            Else
                objVentas.descuento_venta = Me.txtDescuento.Text
            End If
            If Me.txtRecargo.Text = "" Then
                objVentas.recargo_venta = 0
            Else
                objVentas.recargo_venta = Me.txtRecargo.Text
            End If
            objVentas.monto = FormatNumber(CDbl(txtTotal.Text), 2)
            If accion = "nuevo" Then
                If objVentas.nuevaVenta(objVentas) = True Then
                    Dim oDataSet As New DataSet
                    oDataSet = objVentas.ultimaVenta
                    Me.guardarDetalleVenta(oDataSet.Tables(0).Rows(0).Item(0))
                    If lstOpcionales.Rows.Count > 1 Then
                        Me.guardarOpcionalesPresupuesto(oDataSet.Tables(0).Rows(0).Item(0))
                    End If
                    If cboCondVenta.Text = "Tarjeta" Then
                            Me.guardarTarjetaPorVenta(oDataSet.Tables(0).Rows(0).Item(0))

                        End If
                        If cboCondVenta.Text = "Cheque" Then

                            If objCheque.emisor = Nothing Then
                                MsgBox("no se encuentran datos registrados del cheque")
                            Else
                                objCheque.idVenta = oDataSet.Tables(0).Rows(0).Item(0)
                                objCheque.enCartera = True
                                objCheque.registrarCheque(objCheque)
                            End If

                        End If

                    'If MsgBox("¿Desea Imprimir comprobante? ", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then

                    '    Dim frmReporte As New frmPresupuesto(oDataSet.Tables(0).Rows(0).Item(0), False)
                    '    frmReporte.ShowDialog()
                    'End If
                    'If MsgBox("¿Desea enviar por mail comprobante? ", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then

                    '    Dim frmReporte As New frmPresupuesto(oDataSet.Tables(0).Rows(0).Item(0), True)
                    '    frmReporte.ShowDialog()
                    'End If

                    ''Dim frmOpcionImprimiramil As New frmOpcionImprimirMail(oDataSet.Tables(0).Rows(0).Item(0), "presupuesto", Me.txtCodCliente.Text)
                    'frmOpcionImprimiramil.ShowDialog()



                End If
                ElseIf accion = "modificar" Then
                If MsgBox("La siguiente acción modificará la venta" & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                    objVentas.idVenta = idVentaFN
                    objVentas.modificarVenta(objVentas)
                    objVentas.borrarDetalleVenta(idVentaFN)
                    objVentas.borrarOpcionalesVenta(idVentaFN)
                    objVentas.borrarTarjetaPorVemta(idVentaFN)
                    objCheque.borrarChequeXVenta(idVentaFN)
                    Me.guardarDetalleVenta(idVentaFN)

                    If lstOpcionales.Rows.Count > 1 Then
                        Me.guardarOpcionalesPresupuesto(idVentaFN)
                    End If

                    If cboCondVenta.Text = "Tarjeta" Then

                        Me.guardarTarjetaPorVenta(idVentaFN)

                    End If
                    If cboCondVenta.Text = "Cheque" Then
                        If objCheque.emisor = Nothing Then
                            MsgBox("no se encuentran datos registrados del cheque")
                        Else
                            objCheque.idVenta = idVentaFN
                            objCheque.enCartera = True
                            objCheque.registrarCheque(objCheque)
                        End If

                    End If
                    'If MsgBox("¿Desea Imprimir comprobante de venta? ", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then

                    '    Dim frmReporte As New frmPresupuesto(idVentaFN, False)
                    '    frmReporte.ShowDialog()
                    'End If
                    'If MsgBox("¿Desea enviar por mail comprobante? ", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then

                    '    Dim frmReporte As New frmPresupuesto(idVentaFN, True)
                    '    frmReporte.ShowDialog()
                    'End If
                    'Dim frmOpcionImprimiramil As New frmOpcionImprimirMail(idVentaFN, "presupuesto", Me.txtCodCliente.Text)
                    'frmOpcionImprimiramil.ShowDialog()

                End If
            End If
        Else
            Exit Sub
        End If

        'Me.inicializarControles()
        Me.btnCancelar.Enabled = True
        Me.tssNuevo.Enabled = False
        Me.tssBorrar.Enabled = True
        Me.tssModificar.Enabled = True
        Me.btnImprimir.Enabled = True
        Me.btnImprimirDetalle.Enabled = True
        Me.btnMandarMail.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnConfirmar.Enabled = True
        GroupBox1.Enabled = False
        'grupoGrilla.Enabled = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub guardarDetalleVenta(ByVal idVenta As Integer)
        Dim objVentas As New Ventas
        Dim i As Integer
        i = 0


        objVentas.idDetalle_venta = idVenta

        While i < Me.lstArticulos.Rows.Count
            objVentas.idArticulo = Me.lstArticulos.Rows(i).Cells(0).Value.ToString
            objVentas.cantidad = Me.lstArticulos.Rows(i).Cells(1).Value.ToString
            objVentas.precioUnitario = Me.lstArticulos.Rows(i).Cells(5).Value.ToString
            objVentas.cotizacion = Me.lstArticulos.Rows(i).Cells(7).Value.ToString
            objVentas.nuevoDetalleVenta(objVentas)
            i = i + 1

        End While

    End Sub

    Private Sub tssConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssConsultar.Click
        Dim frmbuscarVentas As New frmBuscarPresupuesto
        frmbuscarVentas.ShowDialog()
        ' MsgBox(frmbuscarVentas.idVenta)
        If frmbuscarVentas.idVenta = 0 Then
            Exit Sub
        Else
            Me.buscarVenta(frmbuscarVentas.idVenta)
            Me.idPresupuesto = frmbuscarVentas.idVenta
            Me.btnCancelar.Enabled = True
            Me.tssNuevo.Enabled = False
            Me.tssBorrar.Enabled = True
            Me.tssModificar.Enabled = True
            Me.btnImprimir.Enabled = True
            Me.btnImprimirDetalle.Enabled = True
            Me.btnMandarMail.Enabled = True
            Me.btnConfirmar.Enabled = True
        End If

    End Sub

    Private Sub buscarVenta(ByVal idVenta As Integer)
        Dim objVentas As New Ventas
        Dim objCliente As New Clientes
        Dim objArticulo As New Articulos
        Dim objCondicionVenta As New CondicionVenta
        Dim objAfip As New AFIP
        Dim oDataSetVentas As New DataSet
        Dim oDataSetCliente As New DataSet
        Dim oDataSetTarjetas As New DataSet
        oDataSetVentas = objVentas.buscarVentasXidVenta(idVenta)

        Me.dtpFechaAlta.Text = oDataSetVentas.Tables(0).Rows(0).Item("fecha_venta")
        Me.calcularFechaVencimiento()
        Me.txtFacturaNumero.Text = (Me.generarNumeroFactura(oDataSetVentas.Tables(0).Rows(0).Item("idVenta")))

        oDataSetCliente = objCliente.buscarCliente(oDataSetVentas.Tables(0).Rows(0).Item("idCliente"))
        Me.txtCodCliente.Text = oDataSetCliente.Tables(0).Rows(0).Item("idCLiente")
        txtRazonSocialCliente.Text = oDataSetCliente.Tables(0).Rows(0).Item("nombre") & " " & oDataSetCliente.Tables(0).Rows(0).Item("apellido")
        Me.cboCondVenta.Text = objCondicionVenta.buscarCondicionVenta(oDataSetVentas.Tables(0).Rows(0).Item("idCondicion_venta")).Tables(0).Rows(0).Item("descripcion")
        If cboCondVenta.Text = "Cheque" Then
            btnEditarMedioPago.Enabled = True
        Else
            btnEditarMedioPago.Enabled = False
        End If
        Me.cboComprobantes.Text = objAfip.buscarComprobantesCompraXid(oDataSetVentas.Tables(0).Rows(0).Item("idComprobante")).Tables(0).Rows(0).Item("Descripcion")
        Me.txtDescuento.Text = oDataSetVentas.Tables(0).Rows(0).Item("descuento_venta")

        oDataSetTarjetas = objVentas.buscarTarjetasVentaPorIDVenta(idVenta)

        If oDataSetTarjetas.Tables(0).Rows.Count = 0 Then
        Else

            cboTipoTarjeta.Text = objVentas.buscarTarjetasVenta(oDataSetTarjetas.Tables(0).Rows(0).Item("idTarjeta")).Tables(0).Rows(0).Item("descripcion").ToString
            Me.txtNroCupon.Text = oDataSetTarjetas.Tables(0).Rows(0).Item("cuponNumero")
        End If
        Me.txtRecargo.Text = oDataSetVentas.Tables(0).Rows(0).Item("recargo_venta")
        If oDataSetVentas.Tables(0).Rows(0).Item("observaciones").ToString <> "" Then
            Me.txtObservaciones.Text = oDataSetVentas.Tables(0).Rows(0).Item("observaciones")
        End If
        Me.llenarGrillaVentas(idVenta)
        Me.llenarGrillaOpcionales(idVenta)
        If cboCondVenta.Text = "Cheque" Then
            Dim oDataSetCheque As New DataSet
            oDataSetCheque = objCheque.buscarChequesXidVenta(idVenta)
            If oDataSetCheque.Tables(0).Rows.Count > 0 Then
                objCheque.emisor = oDataSetCheque.Tables(0).Rows(0).Item("emisor")
                objCheque.fecha = oDataSetCheque.Tables(0).Rows(0).Item("fecha")
                objCheque.idBanco = oDataSetCheque.Tables(0).Rows(0).Item("idBanco")
                objCheque.idCheque = oDataSetCheque.Tables(0).Rows(0).Item("Id")
                objCheque.idVenta = oDataSetCheque.Tables(0).Rows(0).Item("idVenta")
                objCheque.monto = oDataSetCheque.Tables(0).Rows(0).Item("monto")
                objCheque.nroCheque = oDataSetCheque.Tables(0).Rows(0).Item("nroCheque")
                objCheque.vtoCheque = oDataSetCheque.Tables(0).Rows(0).Item("vencimiento")
                txtDatosCheques.Text = "Datos del Cheque: " & vbTab & "Emisor: " & oDataSetCheque.Tables(0).Rows(0).Item("emisor") & vbTab & "Fecha Vto: " & FormatDateTime(oDataSetCheque.Tables(0).Rows(0).Item("vencimiento"), DateFormat.ShortDate) & vbTab & "Importe: $ " & oDataSetCheque.Tables(0).Rows(0).Item("monto")

            End If
        End If
        idVentaFN = idVenta
        idPresupuesto = idVenta
    End Sub

    Private Sub llenarGrillaVentas(ByVal idVenta As Integer)
        Dim objventas As New Ventas
        Dim objVenta As New Ventas
        Dim objArticulo As New Articulos
        Dim i As Integer
        i = 0
        Dim oDataSetDetalle As New DataSet
        Dim oDataSetArticulo As New DataSet
        Dim moneda As String
        Dim montoDolar As Double
        lstArticulos.Rows.Clear()
        lstArticulos.Columns(6).DefaultCellStyle.Format = "C2"
        lstArticulos.Columns(5).DefaultCellStyle.Format = "C2"

        oDataSetDetalle = objventas.buscarDetalleFacturaXventa(idVenta)

        '        If oDataSetDetalle.Tables(0).Rows.Count > 0 Then
        '            While i < oDataSetDetalle.Tables(0).Rows.Count

        '                'oDataSetArticulo = objArticulo.buscarArticulo(oDataSetDetalle.Tables(0).Rows(i).Item("idArticulo"))
        '                oDataSetArticulo = objArticulo.buscarArticuloXcodigo(oDataSetDetalle.Tables(0).Rows(i).Item("idArticulo"))
        '                Me.precioArticuloSeleccionado = FormatNumber(oDataSetArticulo.Tables(0).Rows(0).Item("costo") + (oDataSetArticulo.Tables(0).Rows(0).Item("costo") * (oDataSetArticulo.Tables(0).Rows(0).Item("utilidad") / 100)), 2)
        '                Me.precioArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado - (Me.precioArticuloSeleccionado * (oDataSetArticulo.Tables(0).Rows(0).Item("descuento") / 100)), 2)
        '                Me.ivaArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado * (oDataSetArticulo.Tables(0).Rows(0).Item("iva") / 100), 2)


        '                Me.lstArticulos.Rows.Add()
        '                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(0).Value = oDataSetArticulo.Tables(0).Rows(0).Item("idArticulo")


        '#Region "busco cotización"
        '                Dim moneda As String
        '                Dim objVenta As New Ventas
        '                Dim montoDolar As Double
        '                moneda = objArticulo.buscarArticuloXcodigo(oDataSetArticulo.Tables(0).Rows(0).Item("idArticulo")).Tables(0).Rows(0).Item("moneda")
        '                'If moneda = "U$D BLUE" Then

        '                If moneda <> "AR$" Then
        '                    If IsDBNull(objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)) Then
        '                        montoDolar = InputBox("Ingrese el monto de la divisa", "Ingrese el monto de la divisa")
        '                        ' lstArticulos.Rows(i).Cells(5).Value = "S/C"
        '                        objVenta.tipoDolar = moneda
        '                        objVenta.precioDolar = Replace(montoDolar, ".", ",")
        '                        objVenta.registrarPrecioDolar(objVenta)

        '                    Else
        '                        montoDolar = objVenta.cotizaciónXid(objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)).Tables(0).Rows(0).Item("monto")
        '                        'lstArticulos.Rows(i).Cells(5).Value = "$ " & CStr(montoDolar)
        '                    End If
        '                Else
        '                    montoDolar = 1
        '                    'lstArticulos.Rows(i).Cells(5).Value = "$ " & CStr(montoDolar)

        '                End If


        '#End Region

        '                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(2).Value = oDataSetArticulo.Tables(0).Rows(0).Item("descripcion")
        '                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value = Me.ivaArticuloSeleccionado
        '                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(1).Value = oDataSetDetalle.Tables(0).Rows(i).Item("cantidad")
        '                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(3).Value = FormatNumber(Me.precioArticuloSeleccionado, 2)
        '                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value = FormatNumber(FormatNumber((Me.precioArticuloSeleccionado + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value), 2) * montoDolar, 2)
        '                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(6).Value = FormatNumber((lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value) * oDataSetDetalle.Tables(0).Rows(i).Item("cantidad"), 2)

        '                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(7).Value = oDataSetDetalle.Tables(0).Rows(i).Item("cotizacion")


        '                Me.sumarPrecios()
        '                i = i + 1
        '            End While
        '        End If


        If oDataSetDetalle.Tables(0).Rows.Count > 0 Then
            While i < oDataSetDetalle.Tables(0).Rows.Count

                'oDataSetArticulo = objArticulo.buscarArticulo(oDataSetDetalle.Tables(0).Rows(i).Item("idArticulo"))
                oDataSetArticulo = objArticulo.buscarArticuloXcodigo(oDataSetDetalle.Tables(0).Rows(i).Item("idArticulo"))
                'Me.precioArticuloSeleccionado = FormatNumber(oDataSetArticulo.Tables(0).Rows(0).Item("costo") + (oDataSetArticulo.Tables(0).Rows(0).Item("costo") * (oDataSetArticulo.Tables(0).Rows(0).Item("utilidad") / 100)), 2)
                'Me.precioArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado - (Me.precioArticuloSeleccionado * (oDataSetArticulo.Tables(0).Rows(0).Item("descuento") / 100)), 2)
                'Me.ivaArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado * (oDataSetArticulo.Tables(0).Rows(0).Item("iva") / 100), 2)

                '
                'Me.precioArticuloSeleccionado = (oDataSet.Tables(0).Rows(0).Item("costo") * (1 + (oDataSet.Tables(0).Rows(0).Item("iva") / 100))) * (1 + (oDataSet.Tables(0).Rows(0).Item("utilidad") / 100))
                Me.precioArticuloSeleccionado = (oDataSetArticulo.Tables(0).Rows(0).Item("costo") * (1 + (oDataSetArticulo.Tables(0).Rows(0).Item("iva") / 100))) * (1 + (oDataSetArticulo.Tables(0).Rows(0).Item("utilidad") / 100))

                '
                '
                'Me.ivaArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("iva") / 100), 2)
                Me.ivaArticuloSeleccionado = precioArticuloSeleccionado / 1.21
                '
                Me.precioArticuloSeleccionado = Me.precioArticuloSeleccionado - Me.ivaArticuloSeleccionado



                Me.lstArticulos.Rows.Add()
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(0).Value = oDataSetArticulo.Tables(0).Rows(0).Item("idArticulo")


#Region "busco cotización"
                moneda = objArticulo.buscarArticuloXcodigo(oDataSetArticulo.Tables(0).Rows(0).Item("idArticulo")).Tables(0).Rows(0).Item("moneda")
                'If moneda = "U$D BLUE" Then

                If moneda <> "AR$" Then
                    If IsDBNull(objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)) Then
                        montoDolar = InputBox("Ingrese el monto de la divisa", "Ingrese el monto de la divisa")
                        ' lstArticulos.Rows(i).Cells(5).Value = "S/C"
                        objVenta.tipoDolar = moneda
                        objVenta.precioDolar = Replace(montoDolar, ".", ",")
                        objVenta.registrarPrecioDolar(objVenta)

                    Else
                        montoDolar = objVenta.cotizaciónXid(objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)).Tables(0).Rows(0).Item("monto")
                        'lstArticulos.Rows(i).Cells(5).Value = "$ " & CStr(montoDolar)
                    End If
                Else
                    montoDolar = 1
                    'lstArticulos.Rows(i).Cells(5).Value = "$ " & CStr(montoDolar)

                End If


#End Region



                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(2).Value = oDataSetArticulo.Tables(0).Rows(0).Item("descripcion")
                'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value = FormatNumber(Me.ivaArticuloSeleccionado * montoDolar, 2)
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(1).Value = oDataSetDetalle.Tables(0).Rows(i).Item("cantidad")
                'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(3).Value = FormatNumber(Me.precioArticuloSeleccionado * montoDolar, 2)
                'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value = FormatNumber((Me.precioArticuloSeleccionado * montoDolar) + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value, 2)
                'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(6).Value = FormatNumber((lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value) * oDataSetDetalle.Tables(0).Rows(i).Item("cantidad"), 2)
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(7).Value = oDataSetDetalle.Tables(0).Rows(i).Item("cotizacion")



                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value = FormatNumber(Me.precioArticuloSeleccionado * montoDolar, 2)
                'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(1).Value = Me.txtCantidad.Text
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(3).Value = FormatNumber(Me.ivaArticuloSeleccionado * montoDolar, 2)
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value = FormatNumber((Me.ivaArticuloSeleccionado * montoDolar) + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value, 2)
                'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(6).Value = FormatNumber((Me.ivaArticuloSeleccionado * montoDolar) + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value, 2)
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(6).Value = FormatNumber((lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value) * oDataSetDetalle.Tables(0).Rows(i).Item("cantidad"), 2)





                Me.sumarPrecios()
                i = i + 1
            End While
        End If
    End Sub

    Private Sub llenarComboCondicionVenta()
        Dim objCondicionVenta As New CondicionVenta
        Dim oDataSet As New DataSet
        oDataSet = objCondicionVenta.buscarCondicionVenta
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboCondVenta.DataSource = oDataSet.Tables(0)
            Me.cboCondVenta.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboCondVenta.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboCondVenta.SelectedIndex = -1
        End If
    End Sub

    Private Sub tssModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssModificar.Click
        accion = "modificar"
        Me.habilitarControles()
        If Me.cboCondVenta.Text = "Tarjeta" Then
            Me.cboTipoTarjeta.Enabled = True
        Else
            Me.cboTipoTarjeta.Enabled = False
        End If

    End Sub

    Private Sub tssBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBorrar.Click
        If MsgBox("La siguiente acción eliminará la venta " & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
            Dim objVenta As New Ventas
            objVenta.borrarVenta(idVentaFN)
            objVenta.borrarDetalleVenta(idVentaFN)
            Me.inicializarControles()
        End If

    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        Me.calcularFechaVencimiento()
        Me.llenarComboCondicionVenta()
        Me.llenarComboComprobantes()
        Me.llenarComboTarjetas()
        Me.inicializarControles()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ByVal idVenta As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        Me.calcularFechaVencimiento()
        Me.llenarComboCondicionVenta()
        Me.llenarComboTarjetas()
        idVentaFN = idVenta
        Me.buscarVenta(idVenta)
        Me.tssNuevo.Enabled = False
        Me.tssModificar.Enabled = False
        Me.tssConsultar.Enabled = False
        Me.tssBorrar.Enabled = False

        Me.btnBuscarCliente.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btnImprimir.Enabled = True
        Me.btnImprimirDetalle.Enabled = True
        Me.btnNuevoCliente.Enabled = False

        Me.lstArticulos.Enabled = False

        Me.txtCantidad.Enabled = False
        'Me.txtVendedor.Enabled = False
        Me.txtCodCliente.Enabled = False
        Me.txtCodigoArticulo.Enabled = False
        'Me.txtCuit.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.txtFechaVto.Enabled = False
        Me.txtIva.Enabled = False
        Me.txtRazonSocialCliente.Enabled = False
        Me.txtSubTotal.Enabled = False
        Me.txtTotal.Enabled = False
        Me.txtDescuento.Enabled = False
        Me.txtRecargo.Enabled = False
        Me.txtFacturaNumero.Enabled = False
        'Me.txtObservaciones.Enabled = False
        Me.txtNroCupon.Enabled = False
        Me.dtpFechaAlta.Enabled = False

        Me.cboCondVenta.Enabled = False
        ' Me.cboIva.Enabled = False
        Me.cboComprobantes.Enabled = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cboTipoTarjeta.Enabled = False
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frmReporte As New frmPresupuesto(idVentaFN, False, 0)
        frmReporte.ShowDialog()
    End Sub


    Private Sub txtDescuento_Validated(ByVal sender As Object, ByVal e As System.EventArgs)

        sumarPrecios()
    End Sub

    Private Sub calcularDescuentos()
        Dim montoDescuento As Double
        If Me.txtDescuento.Text = "0" Or Me.txtDescuento.Text = "" Then
            Me.txtTotal.Text = FormatNumber(CDbl(Me.txtSubTotal.Text) + CDbl(Me.txtIva.Text), 2)
        Else
            montoDescuento = Me.txtTotal.Text * (Replace(Me.txtDescuento.Text, ".", ",") / 100)
            Me.txtTotal.Text = "$ " & FormatNumber(Me.txtTotal.Text - montoDescuento, 2)
        End If
    End Sub

    Private Sub calcularRecargos()
        Dim montoRecargo As Double

        If Me.txtDescuento.Text = "0" Or Me.txtDescuento.Text = "" Then

            If Me.txtRecargo.Text = "0" Or Me.txtRecargo.Text = "" Then
                Me.txtTotal.Text = "$ " & FormatNumber(CDbl(Me.txtSubTotal.Text) + CDbl(Me.txtIva.Text), 2)
            Else
                montoRecargo = Me.txtTotal.Text * (Replace(Me.txtRecargo.Text, ".", ",") / 100)
                Me.txtTotal.Text = "$ " & FormatNumber(Me.txtTotal.Text + montoRecargo, 2)
            End If

        Else
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnImprimirDetalle.Click
        Dim frmReporte As New frmDetalleVenta(idVentaFN)
        frmReporte.ShowDialog()
    End Sub

    Private Sub llenarComboComprobantes()
        Dim objAFIP As New AFIP
        Dim oDataSet As New DataSet
        oDataSet = objAFIP.buscarComprobantesCompra
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboComprobantes.DataSource = oDataSet.Tables(0)
            Me.cboComprobantes.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboComprobantes.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboComprobantes.SelectedIndex = -1
        End If
    End Sub

    Private Sub cboComprobantes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboComprobantes.SelectedValueChanged
        Try
            If accion = "nuevo" Then
                Me.generarNumeroFactura()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtRecargo_Validated(sender As Object, e As EventArgs)
        sumarPrecios()
    End Sub


    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        ElseIf e.KeyChar = "-" Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescuento_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        ElseIf e.KeyChar = "-" Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRecargo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        ElseIf e.KeyChar = "-" Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        sumarPrecios()
    End Sub

    Private Sub cboTipoTarjeta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoTarjeta.SelectedIndexChanged
        Try
            Dim objVentas As New Ventas
            Dim oDataSet As New DataSet
            oDataSet = objVentas.buscarTarjetasVenta(Me.cboTipoTarjeta.SelectedValue)
            Me.txtRecargo.Text = Replace(oDataSet.Tables(0).Rows(0).Item("porcRecargo"), ".", ",")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtRecargo_TextChanged(sender As Object, e As EventArgs) Handles txtRecargo.TextChanged
        sumarPrecios()
    End Sub
    Private Sub llenarComboTarjetas()
        Dim objVentas As New Ventas
        Dim oDataSet As New DataSet
        oDataSet = objVentas.buscarTarjetasVenta
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboTipoTarjeta.DataSource = oDataSet.Tables(0)
            Me.cboTipoTarjeta.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboTipoTarjeta.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboTipoTarjeta.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnEditarMedioPago_Click(sender As Object, e As EventArgs) Handles btnEditarMedioPago.Click
        Try
            If objCheque.emisor <> "" Then
                Dim frmRegistrarCheque As New frmRegistrarCheque(objCheque)

            Else
                Dim frmRegistrarCheque As New frmRegistrarCheque
            End If
            frmRegistrarCheque.ShowDialog()
            objCheque = frmRegistrarCheque.objCheque
            txtDatosCheques.Text = "Datos del Cheque: " & vbTab & "Emisor: " & objCheque.emisor & vbTab & "Fecha Vto: " & FormatDateTime(objCheque.vtoCheque, DateFormat.ShortDate) & vbTab & "Importe: $ " & objCheque.monto

        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub btnMandarMail_Click(sender As Object, e As EventArgs) Handles btnMandarMail.Click
        Dim frmReporte As New frmPresupuesto(idVentaFN, True, txtCodCliente.Text)

        frmReporte.ShowDialog()
    End Sub

    Private Sub lstOpcionales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lstOpcionales.CellContentClick

    End Sub

    Private Sub cboCondVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCondVenta.SelectedIndexChanged
        If accion = "" Then
        Else
            If cboCondVenta.Text = "Tarjeta" Then
                Me.cboTipoTarjeta.Enabled = True
                Me.txtNroCupon.Enabled = True
                btnEditarMedioPago.Enabled = False
            ElseIf cboCondVenta.Text = "Cheque" Then
                btnEditarMedioPago.Enabled = True

            Else
                Me.cboTipoTarjeta.Enabled = False
                Me.txtNroCupon.Enabled = False
                Me.txtRecargo.Text = 0
                Me.cboTipoTarjeta.SelectedIndex = -1
                Me.txtNroCupon.Text = ""
                Me.txtObservaciones.Text = ""
                btnEditarMedioPago.Enabled = False
            End If
        End If

    End Sub

    Private Sub txtCodigoArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoArticulo.TextChanged

    End Sub

    Private Sub guardarTarjetaPorVenta(ByVal idVenta As Integer)
        Dim objVentas As New Ventas

        If Me.txtNroCupon.Text = "" Then
            objVentas.nuevaTarjetaPorVenta(Me.cboTipoTarjeta.SelectedValue, 0, idVenta, "0")
        Else
            objVentas.nuevaTarjetaPorVenta(Me.cboTipoTarjeta.SelectedValue, 0, idVenta, Me.txtNroCupon.Text)
        End If


    End Sub

    Private Sub frmVentas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.habilitarControles()
            Me.cboComprobantes.SelectedValue = 333
            Me.generarNumeroFactura()
            accion = "nuevo"
            Me.calcularFechaVencimiento()
            Dim odataset As New DataSet
            Dim objCliente As New Clientes
            odataset = objCliente.buscarClientesXid(1)
            Me.txtCodCliente.Text = odataset.Tables(0).Rows(0).Item("idCLiente")
            txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("nombre") & " " & odataset.Tables(0).Rows(0).Item("apellido")
            cboCondVenta.SelectedIndex = 0
            Me.txtCodigoArticulo.Focus()
        ElseIf e.KeyCode = Keys.F5 Then
            'reestablecer el stock
            Dim objVentas As New Ventas
            Dim objArticulo As New Articulos
            Dim i As Integer
            i = 0


            'objVentas.idDetalle_venta = idVenta

            While i < Me.lstArticulos.Rows.Count
                'objVentas.idArticulo = Me.lstArticulos.Rows(i).Cells(0).Value.ToString
                'objVentas.cantidad = Me.lstArticulos.Rows(i).Cells(1).Value.ToString
                'objVentas.nuevoDetalleVenta(objVentas)
                objArticulo.idArticulo = CInt(lstArticulos.Rows(i).Cells(0).Value.ToString)
                objArticulo.sumarStockArticulo(objArticulo, CInt(lstArticulos.Rows(i).Cells(1).Value.ToString))

                i = i + 1

            End While



            Me.inicializarControles()
        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim frmVentas As New frmVentas(idPresupuesto, True)
        frmVentas.ShowDialog()
    End Sub

    Private Sub lstOpcionales_KeyDown(sender As Object, e As KeyEventArgs) Handles lstOpcionales.KeyDown
        Try
            Dim codigoArticulo As Integer
            Dim frmBuscarArticulos As New frmBuscarArticulos
            Dim oDataSet As New DataSet
            Dim objArticulo As New Articulos
            Dim descripcion As String
            Me.lstOpcionales.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            Dim li_index As Integer
            If e.KeyCode = Keys.Delete Then
                e.Handled = True
                li_index = CType(sender, DataGridView).CurrentRow.Index
                lstOpcionales.Rows.RemoveAt(li_index)
            End If

            If e.KeyCode = Keys.Enter Then


                frmBuscarArticulos.ShowDialog()
                codigoArticulo = frmBuscarArticulos.codigoArticulo
                oDataSet = objArticulo.buscarArticulo(codigoArticulo)

                If oDataSet.Tables(0).Rows.Count > 0 Then
                    codigoArticulo = oDataSet.Tables(0).Rows(0).Item("idArticulo")
                    descripcion = oDataSet.Tables(0).Rows(0).Item("descripcion")
                    Me.precioArticuloSeleccionado = FormatNumber(oDataSet.Tables(0).Rows(0).Item("costo") + (oDataSet.Tables(0).Rows(0).Item("costo") * (oDataSet.Tables(0).Rows(0).Item("utilidad") / 100)), 2)
                    Me.precioArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado - (Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("descuento") / 100)), 2)
                    Me.ivaArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("iva") / 100), 2)
                End If


                Dim moneda As String
                Dim objVenta As New Ventas
                Dim montoDolar As Double
                Dim idDolar As Integer
                'obtener moneda del articulo
                moneda = objArticulo.buscarArticuloXcodigo(codigoArticulo).Tables(0).Rows(0).Item("moneda")

                If moneda <> "AR$" Then
                    If IsDBNull(objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)) Then
                        montoDolar = InputBox("Ingrese el monto de la divisa", "Ingrese el monto de la divisa")
                        ' lstArticulos.Rows(i).Cells(5).Value = "S/C"
                        objVenta.tipoDolar = moneda
                        objVenta.precioDolar = Replace(montoDolar, ".", ",")
                        objVenta.registrarPrecioDolar(objVenta)

                    Else
                        montoDolar = objVenta.cotizaciónXid(objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)).Tables(0).Rows(0).Item("monto")
                        idDolar = objVenta.cotizaciónXid(objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)).Tables(0).Rows(0).Item("id")

                        'lstArticulos.Rows(i).Cells(5).Value = "$ " & CStr(montoDolar)
                    End If
                Else
                    montoDolar = 1
                    'lstArticulos.Rows(i).Cells(5).Value = "$ " & CStr(montoDolar)

                End If
                'End If

                Me.lstOpcionales.Rows.Add()
                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(0).Value = codigoArticulo
                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(2).Value = descripcion
                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(4).Value = Me.ivaArticuloSeleccionado

                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(1).Value = "1"
                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(3).Value = Me.precioArticuloSeleccionado
                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(5).Value = (Me.precioArticuloSeleccionado + lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(4).Value) * montoDolar
                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(6).Value = (Me.precioArticuloSeleccionado + lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(4).Value) * montoDolar
                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(7).Value = montoDolar.ToString
                lstOpcionales.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
                ' Me.lstOpcionales.Rows.Add()
            End If





        Catch ex As Exception

        End Try
    End Sub

    Private Sub guardarOpcionalesPresupuesto(ByVal idVenta As Integer)
        Dim objVentas As New Ventas
        Dim i As Integer
        i = 0


        objVentas.idDetalle_venta = idVenta
        'MsgBox(lstOpcionales.Rows.Count)
        While i < (Me.lstOpcionales.Rows.Count - 1)
            'MsgBox(lstOpcionales.Rows(i).Cells(0).Value)
            If lstOpcionales.Rows(i).Cells(0).Value.ToString <> Nothing Then
                objVentas.idArticulo = Me.lstOpcionales.Rows(i).Cells(0).Value.ToString
                objVentas.cantidad = Me.lstOpcionales.Rows(i).Cells(1).Value.ToString
                objVentas.precioUnitario = Me.lstOpcionales.Rows(i).Cells(5).Value.ToString
                objVentas.cotizacion = Me.lstOpcionales.Rows(i).Cells(7).Value.ToString
                objVentas.nuevOpcionales(objVentas)
            End If
            i = i + 1

        End While

    End Sub

    Private Sub llenarGrillaOpcionales(ByVal idVenta As Integer)
        Dim objventas As New Ventas
        Dim objArticulo As New Articulos
        Dim i As Integer
        i = 0
        Dim oDataSetDetalle As New DataSet
        Dim oDataSetArticulo As New DataSet

        lstOpcionales.Rows.Clear()

        oDataSetDetalle = objventas.buscarOpcionalesXPresupuesto(idVenta)

        If oDataSetDetalle.Tables(0).Rows.Count > 0 Then
            While i < oDataSetDetalle.Tables(0).Rows.Count

                'oDataSetArticulo = objArticulo.buscarArticulo(oDataSetDetalle.Tables(0).Rows(i).Item("idArticulo"))
                oDataSetArticulo = objArticulo.buscarArticuloXcodigo(oDataSetDetalle.Tables(0).Rows(i).Item("idArticulo"))
                Me.precioArticuloSeleccionado = FormatNumber(oDataSetArticulo.Tables(0).Rows(0).Item("costo") + (oDataSetArticulo.Tables(0).Rows(0).Item("costo") * (oDataSetArticulo.Tables(0).Rows(0).Item("utilidad") / 100)), 2)
                Me.precioArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado - (Me.precioArticuloSeleccionado * (oDataSetArticulo.Tables(0).Rows(0).Item("descuento") / 100)), 2)
                Me.ivaArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado * (oDataSetArticulo.Tables(0).Rows(0).Item("iva") / 100), 2)

                Dim moneda As String

                Dim montoDolar As Double

                montoDolar = oDataSetDetalle.Tables(0).Rows(0).Item("cotizacion")



                Me.lstOpcionales.Rows.Add()
                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(0).Value = oDataSetArticulo.Tables(0).Rows(0).Item("idArticulo")





                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(2).Value = oDataSetArticulo.Tables(0).Rows(0).Item("descripcion")
                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(4).Value = Me.ivaArticuloSeleccionado
                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(1).Value = oDataSetDetalle.Tables(0).Rows(i).Item("cantidad")
                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(3).Value = FormatNumber(Me.precioArticuloSeleccionado, 2)
                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(5).Value = FormatNumber(FormatNumber((Me.precioArticuloSeleccionado + lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(4).Value), 2) * montoDolar, 2)
                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(6).Value = FormatNumber((lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(5).Value) * oDataSetDetalle.Tables(0).Rows(i).Item("cantidad"), 2)

                lstOpcionales.Rows(lstOpcionales.Rows.Count - 2).Cells(7).Value = oDataSetDetalle.Tables(0).Rows(i).Item("cotizacion")


                'Me.sumarPrecios()
                i = i + 1
            End While
        End If

    End Sub

End Class