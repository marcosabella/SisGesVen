Imports System.ComponentModel
Imports System.IO
Imports System.Xml
Imports System.Globalization


Public Class frmVentas
    Private precioArticuloSeleccionado, ivaArticuloSeleccionado, utilidad, descuento As Double
    Dim accion As String
    Dim stock As Integer
    Dim idVentaFN As Integer
    Dim idVentaAfip As Integer
    Dim codigoArticuloDeVenta As Integer
    Dim dolar As Double = 0
    Dim esPrecioDolar As Boolean = False
    Dim objCheque As New Cheque
    Dim cuitCliente As String
    'Dim WSAA = CreateObject("WSAA")
    'Dim WSFEv1 = CreateObject("WSFEv1")
    Dim token As String
    Dim sign As String
    Dim TA As String
    Dim cms As String
    Dim seObtuvoCae As Boolean
    Dim totalFacturaAfip As String
    Dim totalIvaAfip As String
    Dim totalNetoAfip As String

    Dim cae As String
    Dim vtoCae As String
    Dim numeroComporbante As Integer

    Dim presupuesto As Boolean
    Dim idPresupuesto As Integer


    Private Sub frmVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        codigoArticuloDeVenta = 0
        'obtenerCotizacion()
        Me.cboCondVenta.SelectedIndex = -1
        Me.cargarComboBanco()
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

    Private Sub inicializarControles()
        codigoArticuloDeVenta = 0
        seObtuvoCae = False
        Me.tssNuevo.Enabled = True
        Me.tssModificar.Enabled = False
        Me.tssConsultar.Enabled = True
        Me.tssBorrar.Enabled = False
        Me.btnMandarMail.Enabled = False

        Me.btnBuscarCliente.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btnImprimir.Enabled = False
        Me.btnImprimirDetalle.Enabled = False
        Me.btnNuevoCliente.Enabled = False
        Me.btnEditarMedioPago.Enabled = False
        Me.btnAFIP.Enabled = False


        Me.lstArticulos.Enabled = False

        lstArticulos.ReadOnly = False
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
        Me.cboCondVenta.SelectedIndex = -1
        Me.cboComprobantes.SelectedIndex = -1
        Me.cboTipoTarjeta.SelectedIndex = -1
        Me.cboBanco.SelectedIndex = -1
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
        Me.accion = ""
        objCheque = objCheque.inicializar(objCheque)

        Me.cboTipoTarjeta.Visible = False
        Me.Label32.Visible = False
        Me.Label28.Visible = False
        Me.txtNroCupon.Visible = False
        Me.cboBanco.Visible = False
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
        'Dim frmBuscarCliente As New frmBuscarNombre("buscarCliente")
        'frmBuscarCliente.ShowDialog()
        Dim objCliente As New Clientes
        Dim odataset As New DataSet
        'If frmBuscarCliente.codigo = 0 Then
        '    Exit Sub
        'Else
        '    odataset = objCliente.buscarClientesXid(frmBuscarCliente.codigo)
        '    Me.txtCodCliente.Text = odataset.Tables(0).Rows(0).Item("idCLiente")
        '    txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("razon_social")
        '    Me.txtCodigoArticulo.Focus()
        'End If

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


            If odataset.Tables(0).Rows(0).Item("cuit").ToString <> "0" Or odataset.Tables(0).Rows(0).Item("cuit").ToString <> "00000000000" Then
                cuitCliente = odataset.Tables(0).Rows(0).Item("cuit")
            Else

            End If
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
            '
            'Me.precioArticuloSeleccionado = (oDataSet.Tables(0).Rows(0).Item("costo") * (1 + (oDataSet.Tables(0).Rows(0).Item("iva") / 100))) * (1 + (oDataSet.Tables(0).Rows(0).Item("utilidad") / 100))
            Me.precioArticuloSeleccionado = (oDataSet.Tables(0).Rows(0).Item("costo") * (1 + (oDataSet.Tables(0).Rows(0).Item("iva") / 100))) * (1 + (oDataSet.Tables(0).Rows(0).Item("utilidad") / 100))

            '
            '
            'Me.ivaArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("iva") / 100), 2)
            Me.ivaArticuloSeleccionado = precioArticuloSeleccionado / 1.21
            '
            Me.precioArticuloSeleccionado = Me.precioArticuloSeleccionado - Me.ivaArticuloSeleccionado
            If oDataSet.Tables(0).Rows(0).Item("moneda") = "U$D" Then
                'Me.precioArticuloSeleccionado = (FormatNumber(Me.precioArticuloSeleccionado - (Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("descuento") / 100)), 2)) * dolar
                Me.precioArticuloSeleccionado = Me.precioArticuloSeleccionado * dolar
                Me.ivaArticuloSeleccionado = ivaArticuloSeleccionado * dolar
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
        'conIva = FormatNumber((costo * (1 + (iva / 100))), 2)
        'conUtilidad = FormatNumber(conIva * (1 + (utilidad / 100)), 2)
        'FormatNumber(precioVenta = conUtilidad, 2)
        'If descuento <> "" And descuento <> "0" Then
        '    FormatNumber(precioVenta = precioVenta - (precioVenta * (descuento / 100)), 2)
        'End If
        conIva = costo * (1 + (iva / 100))
        conUtilidad = conIva * (1 + (utilidad / 100))
        precioVenta = conUtilidad
        If descuento <> "" And descuento <> "0" Then
            precioVenta = precioVenta - (precioVenta * (descuento / 100))
        End If
        Return precioVenta
    End Function

    Private Sub txtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
        'Dim objArticulo As New Articulos
        'Dim moneda As String
        'If esPrecioDolar = True Then
        '    moneda = "U$D "
        'Else
        '    moneda = "$ "
        'End If
        'If e.KeyCode = Keys.Enter Then

        '    If Me.txtCantidad.Text = "" Then
        '        If 1 <= Me.stock Then
        '            'Else
        '            Me.lstArticulos.Rows.Add()
        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(0).Value = codigoArticuloDeVenta
        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(2).Value = Me.txtDescripcion.Text
        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value = Me.ivaArticuloSeleccionado

        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(1).Value = "1"
        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(3).Value = Me.precioArticuloSeleccionado
        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value = (Me.precioArticuloSeleccionado + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value)
        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(6).Value = (Me.precioArticuloSeleccionado + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value)
        '            objArticulo.idArticulo = codigoArticuloDeVenta
        '            objArticulo.restarStockArticulo(objArticulo, 1)
        '        Else
        '            MsgBox("El artículo no contiene el stock que usted a ingrasado. Solo dispone de: " & Me.stock & " artículos",, "SISTEMAS GESTIÓN DE VENTAS Y STOCK")
        '            Me.txtCantidad.Focus()
        '            Exit Sub
        '        End If

        '    Else
        '        If Me.txtCantidad.Text <= Me.stock Then
        '            Me.lstArticulos.Rows.Add()
        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(0).Value = codigoArticuloDeVenta
        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(2).Value = Me.txtDescripcion.Text
        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value = Me.ivaArticuloSeleccionado

        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(1).Value = Me.txtCantidad.Text
        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(3).Value = Me.precioArticuloSeleccionado
        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value = (Me.precioArticuloSeleccionado + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value)
        '            lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(6).Value = (lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value) * Me.txtCantidad.Text
        '            objArticulo.idArticulo = codigoArticuloDeVenta
        '            objArticulo.restarStockArticulo(objArticulo, Me.txtCantidad.Text)
        '        Else
        '            MsgBox("El artículo no contiene el stock que usted a ingrasado. Solo dispone de: " & Me.stock & " artículos",, "SISTEMAS GESTIÓN DE VENTAS Y STOCK")
        '            Me.txtCantidad.Focus()
        '            Exit Sub
        '        End If

        '    End If
        Dim objArticulo As New Articulos
        Dim moneda As String
        If esPrecioDolar = True Then
            moneda = "U$D "
        Else
            moneda = "$ "
        End If

        Dim objVenta As New Ventas
        Dim montoDolar As Double

        'obtener moneda del articulo
        moneda = objArticulo.buscarArticuloXcodigo(Me.txtCodigoArticulo.Text).Tables(0).Rows(0).Item("moneda")
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
        'End If

        If e.KeyCode = Keys.Enter Then

            If Me.txtCantidad.Text = "" Then
                'If 1 <= Me.stock Then
                'Else
                Me.lstArticulos.Rows.Add()
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(0).Value = codigoArticuloDeVenta
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(2).Value = Me.txtDescripcion.Text
                'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value = FormatNumber(Me.ivaArticuloSeleccionado * montoDolar, 2)

                'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(1).Value = "1"
                'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(3).Value = FormatNumber(Me.precioArticuloSeleccionado * montoDolar, 2)
                'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value = FormatNumber((Me.precioArticuloSeleccionado * montoDolar) + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value, 2)
                'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(6).Value = FormatNumber((Me.precioArticuloSeleccionado * montoDolar) + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value, 2)

                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value = FormatNumber(Me.precioArticuloSeleccionado * montoDolar, 2)
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(1).Value = "1"
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(3).Value = FormatNumber(Me.ivaArticuloSeleccionado * montoDolar, 2)
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value = FormatNumber((Me.ivaArticuloSeleccionado * montoDolar) + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value, 2)
                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(6).Value = FormatNumber((Me.ivaArticuloSeleccionado * montoDolar) + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value, 2)


                lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(7).Value = montoDolar.ToString

                objArticulo.idArticulo = codigoArticuloDeVenta
                'objArticulo.restarStockArticulo(objArticulo, 1)
                'Else
                'MsgBox("El artículo no contiene el stock que usted a ingrasado. Solo dispone de: " & Me.stock & " artículos",, "SISTEMAS GESTIÓN DE VENTAS Y STOCK")
                Me.txtCantidad.Focus()
                '    Exit Sub
                'End If

            Else
                If Me.txtCantidad.Text <= Me.stock Then
                    Me.lstArticulos.Rows.Add()
                    lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(0).Value = codigoArticuloDeVenta
                    lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(2).Value = Me.txtDescripcion.Text
                    'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value = FormatNumber(Me.ivaArticuloSeleccionado * montoDolar, 2)

                    'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(1).Value = Me.txtCantidad.Text
                    'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(3).Value = FormatNumber(Me.precioArticuloSeleccionado * montoDolar, 2)
                    'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value = FormatNumber((Me.precioArticuloSeleccionado * montoDolar) + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value, 2)
                    'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(6).Value = FormatNumber((lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value) * Me.txtCantidad.Text, 2)
                    lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(7).Value = montoDolar.ToString

                    'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value = FormatNumber(Me.ivaArticuloSeleccionado * montoDolar, 2)

                    'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(1).Value = "1"
                    'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(3).Value = FormatNumber(Me.precioArticuloSeleccionado * montoDolar, 2)
                    'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value = FormatNumber((Me.precioArticuloSeleccionado * montoDolar) + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value, 2)
                    'lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(6).Value = FormatNumber((Me.precioArticuloSeleccionado * montoDolar) + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value, 2)

                    lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value = FormatNumber(Me.precioArticuloSeleccionado * montoDolar, 2)
                    lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(1).Value = Me.txtCantidad.Text
                    lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(3).Value = FormatNumber(Me.ivaArticuloSeleccionado * montoDolar, 2)
                    lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(5).Value = FormatNumber((Me.ivaArticuloSeleccionado * montoDolar) + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value, 2)
                    lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(6).Value = FormatNumber(((Me.ivaArticuloSeleccionado * montoDolar) + lstArticulos.Rows(lstArticulos.Rows.Count - 1).Cells(4).Value) * Me.txtCantidad.Text, 2)



                    objArticulo.idArticulo = codigoArticuloDeVenta
                    'objArticulo.restarStockArticulo(objArticulo, Me.txtCantidad.Text)
                Else
                    MsgBox("El artículo no contiene el stock que usted a ingrasado. Solo dispone de: " & Me.stock & " artículos",, "SISTEMAS GESTIÓN DE VENTAS Y STOCK")
                    Me.txtCantidad.Focus()
                    Exit Sub
                End If

            End If

            'If oDataSet.Tables(0).Rows(i).Item("precio") = "Consultar" Then

            Me.txtCantidad.Text = ""
            Me.txtDescripcion.Text = ""
            Me.txtCodigoArticulo.Text = ""
            Me.sumarPrecios()
            Me.txtCodigoArticulo.Focus()
        End If

        'If oDataSet.Tables(0).Rows(i).Item("precio") = "Consultar" Then

        'Me.txtCantidad.Text = ""
        '    Me.txtDescripcion.Text = ""
        '    Me.txtCodigoArticulo.Text = ""
        '    Me.sumarPrecios()
        '    Me.txtCodigoArticulo.Focus()
        'End If

    End Sub

    Private Sub sumarPrecios()
        Dim i As Integer = 0
        Dim iva, total, subtotal As Double

        Dim totalDescuento As Double

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

        totalDescuento = Me.calcularDescuentos()
        If totalDescuento <> 0 Then
            total = totalDescuento
        End If

        Me.calcularRecargos()

        totalFacturaAfip = String.Format(total, "#.#0")
        totalIvaAfip = FormatNumber(totalFacturaAfip - FormatNumber((totalFacturaAfip / 1.21), 2), 2)
        totalIvaAfip = String.Format(totalIvaAfip, "#.#0")
        totalNetoAfip = totalFacturaAfip - totalIvaAfip

        totalIvaAfip = totalFacturaAfip - totalNetoAfip

        'totalFacturaAfip = FormatNumber(CDbl(totalFacturaAfip), 2)
        'totalFacturaAfip = Replace(totalFacturaAfip, ",", ".")
        lblTotalIvaAfip.Text = totalIvaAfip
        lblTotalNetoAfip.Text = totalNetoAfip



        'Me.calcularDescuentos()
        'Me.calcularRecargos()
    End Sub

    Private Sub lstArticulos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstArticulos.KeyDown
        Dim objArticulo As New Articulos
        If e.KeyCode = Keys.Delete Then
            If lstArticulos.Rows.Count > 0 And (accion = "modificar" Or accion = "nuevo") Then
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

        GroupBox1.Enabled = True
        grupoGrilla.Enabled = True
        GroupBox2.Enabled = True



        Me.btnBuscarCliente.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.btnImprimir.Enabled = False
        Me.btnImprimirDetalle.Enabled = False
        Me.btnNuevoCliente.Enabled = True
        Me.btnAFIP.Enabled = True

        Me.lstArticulos.Enabled = True

        lstArticulos.ReadOnly = False
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

        Me.cboCondVenta.Enabled = True
        'Me.cboIva.Enabled = True
        Me.cboComprobantes.Enabled = True


        alerta.Clear()
        Me.btnBuscarCliente.Focus()
    End Sub

    Private Sub tssNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssNuevo.Click
        Me.habilitarControles()
        Me.cboComprobantes.SelectedValue = 121
        Me.generarNumeroFactura()
        accion = "nuevo"
        Me.calcularFechaVencimiento()
        Dim odataset As New DataSet
        Dim objCliente As New Clientes
        odataset = objCliente.buscarClientesXid(1)
        'Me.txtCodCliente.Text = odataset.Tables(0).Rows(0).Item("idCLiente")
        'txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("nombre") & " " & odataset.Tables(0).Rows(0).Item("apellido")
        cboCondVenta.SelectedIndex = -1
        Me.txtCodigoArticulo.Focus()

    End Sub

    Private Sub generarNumeroFactura()
        Dim oDataSet As New DataSet
        Dim objVentas As New Ventas
        oDataSet = objVentas.ultimaVenta(cboComprobantes.SelectedValue)
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
        If cboCondVenta.Text = "Transferencia" Then
            If cboBanco.SelectedIndex = -1 Then
                estadoValidacion = 1
                alerta.SetError(Me.cboBanco, "Seleccione el banco")
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
                    idVentaFN = oDataSet.Tables(0).Rows(0).Item(0)

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

                    If cboCondVenta.Text = "Transferencia" Then
                        Me.guardarTransferenciaPorVenta(oDataSet.Tables(0).Rows(0).Item(0))
                    End If

                End If
            ElseIf accion = "modificar" Then
                If MsgBox("La siguiente acción modificará la venta" & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                    objVentas.idVenta = idVentaFN
                    objVentas.modificarVenta(objVentas)
                    objVentas.borrarDetalleVenta(idVentaFN)
                    objVentas.borrarTarjetaPorVemta(idVentaFN)
                    objCheque.borrarChequeXVenta(idVentaFN)
                    objVentas.borrarTransferenciaPorVenta(idVentaFN)
                    Me.guardarDetalleVenta(idVentaFN)

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
                    If cboCondVenta.Text = "Transferencia" Then
                        Me.guardarTransferenciaPorVenta(idVentaFN)
                    End If

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
        GroupBox1.Enabled = False
        grupoGrilla.Enabled = False
        GroupBox2.Enabled = False

        If seObtuvoCae = True Then
            btnAFIP.Enabled = False
        Else
            btnAFIP.Enabled = True
        End If
    End Sub

    Private Sub guardarDetalleVenta(ByVal idVenta As Integer)
        Dim objVentas As New Ventas
        Dim i As Integer
        i = 0
        Dim objArticulo As New Articulos

        objVentas.idDetalle_venta = idVenta

        While i < Me.lstArticulos.Rows.Count
            objVentas.idArticulo = Me.lstArticulos.Rows(i).Cells(0).Value.ToString
            objVentas.cantidad = Me.lstArticulos.Rows(i).Cells(1).Value.ToString
            objVentas.cantidad = Replace(Me.lstArticulos.Rows(i).Cells(1).Value.ToString, ".", ",")
            objVentas.precioUnitario = Me.lstArticulos.Rows(i).Cells(5).Value.ToString
            objVentas.cotizacion = Me.lstArticulos.Rows(i).Cells(7).Value.ToString
            objVentas.nuevoDetalleVenta(objVentas)
            'objArticulo.idArticulo = objVentas.idArticulo
            'objArticulo.restarStockArticulo(objArticulo, objVentas.cantidad)

            i = i + 1

        End While

    End Sub

    Private Sub tssConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssConsultar.Click
        If Me.txtCodCliente.Text.ToString <> "" Then
            Dim frmbuscarVentas As New frmBuscarVentas(CInt(Me.txtCodCliente.Text.ToString))
        Else
            Dim frmbuscarVentas As New frmBuscarVentas(0)
        End If

        frmBuscarVentas.ShowDialog()

        If frmbuscarVentas.idVenta = 0 Then
            Exit Sub
        Else
            idVentaAfip = 0
            idVentaFN = 0
            lblCae.Text = ""
            lblVtoCae.Text = ""
            txtDatosCheques.Text = ""
            Me.buscarVenta(frmbuscarVentas.idVenta)
            Me.btnCancelar.Enabled = True
            Me.tssNuevo.Enabled = False
            Me.tssBorrar.Enabled = True
            Me.tssModificar.Enabled = True
            Me.btnImprimir.Enabled = True
            Me.btnImprimirDetalle.Enabled = True
            Me.btnMandarMail.Enabled = True
            If seObtuvoCae = True Then
                btnAFIP.Enabled = False
            Else
                btnAFIP.Enabled = True
            End If
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

        If presupuesto = False Then
            Me.dtpFechaAlta.Text = oDataSetVentas.Tables(0).Rows(0).Item("fecha_venta")
        ElseIf presupuesto = True Then
            Me.dtpFechaAlta.Value = Now
        End If
        Me.calcularFechaVencimiento()

        oDataSetCliente = objCliente.buscarCliente(oDataSetVentas.Tables(0).Rows(0).Item("idCliente"))
        Me.txtCodCliente.Text = oDataSetCliente.Tables(0).Rows(0).Item("idCLiente")

        cuitCliente = oDataSetCliente.Tables(0).Rows(0).Item("cuit")
        txtRazonSocialCliente.Text = oDataSetCliente.Tables(0).Rows(0).Item("nombre") & " " & oDataSetCliente.Tables(0).Rows(0).Item("apellido")
        Me.cboCondVenta.Text = objCondicionVenta.buscarCondicionVenta(oDataSetVentas.Tables(0).Rows(0).Item("idCondicion_venta")).Tables(0).Rows(0).Item("descripcion")
        If oDataSetVentas.Tables(0).Rows(0).Item("observaciones").ToString <> "" Then
            Me.txtObservaciones.Text = oDataSetVentas.Tables(0).Rows(0).Item("observaciones")
        End If

        ''
        If presupuesto = False Then
            Me.cboCondVenta.Text = objCondicionVenta.buscarCondicionVenta(oDataSetVentas.Tables(0).Rows(0).Item("idCondicion_venta")).Tables(0).Rows(0).Item("descripcion")
        ElseIf presupuesto = True Then
            Me.cboCondVenta.SelectedIndex = 0
        End If
        ''

        If cboCondVenta.Text = "Cheque" Then
            btnEditarMedioPago.Enabled = True
        Else
            btnEditarMedioPago.Enabled = False
        End If

        ''
        If presupuesto = False Then
            Me.cboComprobantes.Text = objAfip.buscarComprobantesCompraXid(oDataSetVentas.Tables(0).Rows(0).Item("idComprobante")).Tables(0).Rows(0).Item("Descripcion")

        ElseIf presupuesto = True Then
            Me.cboComprobantes.SelectedValue = 121
            Me.generarNumeroFactura()
            accion = "nuevo"
            Me.calcularFechaVencimiento()
            cboCondVenta.SelectedIndex = 0
            Me.txtCodigoArticulo.Focus()
        End If
        ''

        Me.txtDescuento.Text = oDataSetVentas.Tables(0).Rows(0).Item("descuento_venta")
        'Me.txtObservaciones.Text = oDataSetVentas.Tables(0).Rows(0).Item("observaciones").ToString

        oDataSetTarjetas = objVentas.buscarTarjetasVentaPorIDVenta(idVenta)

        If oDataSetTarjetas.Tables(0).Rows.Count = 0 Then
        Else
            cboTipoTarjeta.Text = objVentas.buscarTarjetasVenta(oDataSetTarjetas.Tables(0).Rows(0).Item("idTarjeta")).Tables(0).Rows(0).Item("descripcion").ToString
            Me.txtNroCupon.Text = oDataSetTarjetas.Tables(0).Rows(0).Item("cuponNumero")

        End If
        Me.txtRecargo.Text = oDataSetVentas.Tables(0).Rows(0).Item("recargo_venta")

        If cboCondVenta.Text = "Tarjeta" Then
            Me.txtNroCupon.Visible = True
            Me.Label32.Visible = True
            cboTipoTarjeta.Visible = True
            Label28.Visible = True
        End If

        Me.llenarGrillaVentas(idVenta)

        If cboCondVenta.Text = "Cheque" Then
            Dim oDataSetCheque As New DataSet
            oDataSetCheque = objCheque.buscarChequesXidVenta(idVenta)
            If oDataSetCheque.Tables(0).Rows.Count > 0 Then
                objCheque.emisor = oDataSetCheque.Tables(0).Rows(0).Item("emisor")
                objCheque.fecha = oDataSetCheque.Tables(0).Rows(0).Item("fecha")
                objCheque.idBanco = oDataSetCheque.Tables(0).Rows(0).Item("idBanco")
                objCheque.idCheque = oDataSetCheque.Tables(0).Rows(0).Item("Id")
                objCheque.idVenta = oDataSetCheque.Tables(0).Rows(0).Item("idVenta")
                objCheque.monto = CDec(oDataSetCheque.Tables(0).Rows(0).Item("monto"))
                objCheque.nroCheque = oDataSetCheque.Tables(0).Rows(0).Item("nroCheque")
                objCheque.vtoCheque = oDataSetCheque.Tables(0).Rows(0).Item("vencimiento")
                txtObservaciones.Text = "Datos del Cheque: " & vbTab & "Emisor: " & oDataSetCheque.Tables(0).Rows(0).Item("emisor") & vbTab & "Fecha Vto: " & FormatDateTime(oDataSetCheque.Tables(0).Rows(0).Item("vencimiento"), DateFormat.ShortDate) & vbTab & "Importe: $ " & oDataSetCheque.Tables(0).Rows(0).Item("monto")

            End If
        ElseIf cboCondVenta.Text = "Transferencia" Then
            Dim oDataSetTransferencia As New DataSet
            oDataSetTransferencia = objVentas.buscarTransferenciaVentaPorIDVenta(idVenta)
            If oDataSetTransferencia.Tables(0).Rows.Count > 0 Then
                cboBanco.Text = oDataSetTransferencia.Tables(0).Rows(0).Item("nombre")
                Me.cboBanco.Visible = True
                Me.Label32.Visible = True
            End If
        End If

        ''
        If oDataSetVentas.Tables(0).Rows(0).Item("observaciones").ToString <> "" Then
            If presupuesto = False Then
                Me.txtObservaciones.Text = oDataSetVentas.Tables(0).Rows(0).Item("observaciones")
            Else
                Me.txtObservaciones.Text = oDataSetVentas.Tables(0).Rows(0).Item("observaciones") & " - Asociado a presupuesto N°: " & idPresupuesto
            End If
        Else
            If presupuesto = True Then
                Me.txtObservaciones.Text = "Asociado a presupuesto N°: " & generarNumeroFactura(idPresupuesto)

            End If
        End If
        ''

        oDataSetVentas = objAfip.buscarCaeXfactura(idVenta)
        If oDataSetVentas.Tables(0).Rows.Count > 0 Then
            Me.lblCae.Text = oDataSetVentas.Tables(0).Rows(0).Item("cae")
            Me.lblVtoCae.Text = oDataSetVentas.Tables(0).Rows(0).Item("vtoCae")
            Me.txtDatosCheques.Text = "CAE: " & oDataSetVentas.Tables(0).Rows(0).Item("cae") & " - Vencimiento: " & oDataSetVentas.Tables(0).Rows(0).Item("vtoCae") & " - Comprobante número: " & generarNumeroFactura(oDataSetVentas.Tables(0).Rows(0).Item("idVentaAfip"), "0003")
            Me.txtFacturaNumero.Text = (Me.generarNumeroFactura(oDataSetVentas.Tables(0).Rows(0).Item("idVentaAfip"), "0003"))
            seObtuvoCae = True
            idVentaAfip = oDataSetVentas.Tables(0).Rows(0).Item("idVentaAfip")
            idVentaFN = idVenta
        Else
            If presupuesto = False Then
                Me.txtFacturaNumero.Text = (Me.generarNumeroFactura(idVenta))
                idVentaFN = idVenta
            Else
                Me.generarNumeroFactura()
            End If
        End If


    End Sub

    Private Sub llenarGrillaVentas(ByVal idVenta As Integer)
        Dim objventas As New Ventas
        Dim objArticulo As New Articulos
        Dim i As Integer
        i = 0
        Dim oDataSetDetalle As New DataSet
        Dim oDataSetArticulo As New DataSet
        Dim moneda As String
        Dim montoDolar As Double
        Dim objVenta As New Ventas

        lstArticulos.Rows.Clear()

        oDataSetDetalle = objventas.buscarDetalleFacturaXventa(idVenta)

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
        lstArticulos.Enabled = True
        lstArticulos.ReadOnly = True
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
        Me.llenarComboComprobantes()
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

    Public Sub New(ByVal idVenta As Integer, ByVal edita As Boolean, ByVal estado As String)
        If edita = True Then


            ' Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent()
            Me.calcularFechaVencimiento()
            Me.llenarComboCondicionVenta()
            Me.llenarComboTarjetas()
            Me.llenarComboComprobantes()
            idVentaFN = idVenta
            Me.buscarVenta(idVenta)
            Me.tssNuevo.Enabled = False
            Me.tssModificar.Enabled = True
            Me.tssConsultar.Enabled = False
            Me.tssBorrar.Enabled = False

            Me.btnBuscarCliente.Enabled = False
            Me.btnCancelar.Enabled = True
            Me.btnGuardar.Enabled = False
            Me.btnImprimir.Enabled = True
            Me.btnImprimirDetalle.Enabled = True
            Me.btnNuevoCliente.Enabled = False

            Me.lstArticulos.Enabled = True

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
        End If
    End Sub

    Public Sub New(ByVal idVenta As Integer, ByVal presupuesto As Boolean)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        Me.calcularFechaVencimiento()
        Me.llenarComboCondicionVenta()
        Me.llenarComboTarjetas()
        Me.llenarComboComprobantes()
        idVentaFN = idVenta
        idPresupuesto = idVenta
        Me.presupuesto = presupuesto
        Me.buscarVenta(idVenta)
        Me.tssNuevo.Enabled = False
        Me.tssModificar.Enabled = False
        Me.tssConsultar.Enabled = False
        Me.tssBorrar.Enabled = False

        Me.btnBuscarCliente.Enabled = False
        Me.btnCancelar.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.btnImprimir.Enabled = False
        Me.btnImprimirDetalle.Enabled = False
        Me.btnNuevoCliente.Enabled = False
        Me.btnAFIP.Enabled = False
        Me.btnMandarMail.Enabled = False

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

        Me.cboCondVenta.Enabled = True
        ' Me.cboIva.Enabled = False
        Me.cboComprobantes.Enabled = True
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cboTipoTarjeta.Enabled = False

        cboCondVenta.SelectedIndex = 1


    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        'Dim objAfip As New AFIP
        'Dim oDataSet As New DataSet
        'oDataSet = objAfip.buscarCodComprobante(cboComprobantes.SelectedValue)

        'generarTempVentas(idVentaFN)

        'Dim frmReporte As New frmComprobanteVenta(idVentaFN, False, txtCodCliente.Text, lblCae.Text, lblVtoCae.Text, cboComprobantes.SelectedValue, oDataSet.Tables(0).Rows(0).Item("codComprobante"), idVentaAfip)
        'frmReporte.ShowDialog()
        Dim objAfip As New AFIP

        Dim frmReporte As New frmComprobanteVenta(cboComprobantes.SelectedValue)
        generarTempVentas(idVentaFN)

        frmReporte.ShowDialog()
    End Sub


    Private Sub txtDescuento_Validated(ByVal sender As Object, ByVal e As System.EventArgs)

        sumarPrecios()
    End Sub

    Private Function calcularDescuentos() As Double
        Dim montoDescuento As Double
        Dim montoDecuentoReturn As Double
        Dim montoDescuentoIva As Double
        If Me.txtDescuento.Text = "0" Or Me.txtDescuento.Text = "" Then
            Me.txtTotal.Text = FormatNumber(CDbl(Me.txtSubTotal.Text) + CDbl(Me.txtIva.Text), 2)
            Return 0
        Else
            montoDescuento = Me.txtTotal.Text * (Replace(Me.txtDescuento.Text, ".", ",") / 100)
            'montoDescuentoIva = totalIvaAfip * (Replace(Me.txtDescuento.Text, ".", ",") / 100)
            ' Me.txtTotal.Text = "$ " & FormatNumber(Me.txtTotal.Text - montoDescuento, 2)
            montoDecuentoReturn = FormatNumber(Me.txtTotal.Text - montoDescuento, 2)
            Me.txtTotal.Text = "$ " & FormatNumber(montoDecuentoReturn, 2)
            Return FormatNumber(montoDecuentoReturn, 2)
            'totalFacturaAfip = String.Format(Val(totalFacturaAfip) - Val(montoDescuento), "#.#0")
            'totalFacturaAfip = String.Format(Val(totalFacturaAfip), "#.#0")
            'totalIvaAfip = String.Format(Val(totalIvaAfip) - Val(montoDescuentoIva), "#.#0")
            'totalIvaAfip = String.Format(Val(totalIvaAfip), "#.#0")
        End If
    End Function

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
            If cboComprobantes.SelectedValue > 3 Then
                lstArticulos.Columns(3).Visible = False
                lstArticulos.Columns(4).Visible = False
            Else
                lstArticulos.Columns(3).Visible = True
                lstArticulos.Columns(4).Visible = True

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
            txtObservaciones.Text = "Datos del Cheque: " & vbTab & "Emisor: " & objCheque.emisor & vbTab & "Fecha Vto: " & FormatDateTime(objCheque.vtoCheque, DateFormat.ShortDate) & vbTab & "Importe: $ " & objCheque.monto

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMandarMail_Click(sender As Object, e As EventArgs) Handles btnMandarMail.Click
        'Dim objAfip As New AFIP
        'Dim oDataSet As New DataSet
        'oDataSet = objAfip.buscarCodComprobante(cboComprobantes.SelectedValue)
        'Dim frmReporte As New frmComprobanteVenta(idVentaFN, True, txtCodCliente.Text, lblCae.Text, lblVtoCae.Text, cboComprobantes.SelectedValue, oDataSet.Tables(0).Rows(0).Item("codComprobante"), idVentaAfip)
        Dim objAfip As New AFIP
        Dim oDataSet As New DataSet
        oDataSet = objAfip.buscarCodComprobante(cboComprobantes.SelectedValue)

        generarTempVentas(idVentaFN)

        Dim frmReporte As New frmComprobanteVentaMail(cboComprobantes.SelectedValue)

        frmReporte.ShowDialog()
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAFIP.Click



        Dim objAFIP As New AFIP
        Dim oDataSet As New DataSet

        Autenticar(leerTXT("ta.txt"))

        btnAFIP.Enabled = False

    End Sub

    Private Sub cboCondVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCondVenta.SelectedIndexChanged
        If accion = "" Then
        Else
            If cboCondVenta.Text = "Tarjeta" Then
                Me.cboTipoTarjeta.Enabled = True
                Me.txtNroCupon.Enabled = True
                btnEditarMedioPago.Enabled = False
                Me.cboTipoTarjeta.Visible = True
                Me.Label32.Visible = True
                Me.Label32.Text = "Tarjeta"
                Me.Label28.Visible = True
                Me.txtNroCupon.Visible = True
                Me.cboBanco.Visible = False
                Me.cboBanco.SelectedIndex = -1
                Me.btnEditarMedioPago.Enabled = False
                Me.txtObservaciones.Text = ""
            ElseIf cboCondVenta.Text = "Cheque" Then
                btnEditarMedioPago.Enabled = True
                Me.cboTipoTarjeta.Visible = False
                Me.Label32.Visible = False
                Me.Label28.Visible = False
                Me.txtNroCupon.Visible = False
                Me.cboBanco.Visible = False
            ElseIf cboCondVenta.Text = "Transferencia" Then
                Me.cboTipoTarjeta.Visible = False
                Me.Label32.Visible = True
                Me.Label32.Text = "Banco"
                Me.Label28.Visible = False
                Me.txtNroCupon.Visible = False
                Me.cboBanco.Visible = True
                Me.cboBanco.SelectedIndex = -1
                Me.btnEditarMedioPago.Enabled = False
                Me.txtObservaciones.Text = ""
            Else
                Me.cboTipoTarjeta.Enabled = False
                Me.txtNroCupon.Enabled = False
                Me.txtRecargo.Text = 0
                Me.cboTipoTarjeta.SelectedIndex = -1
                Me.txtNroCupon.Text = ""
                Me.txtObservaciones.Text = ""
                btnEditarMedioPago.Enabled = False
                Me.cboTipoTarjeta.Visible = False
                Me.Label32.Visible = False
                Me.Label28.Visible = False
                Me.txtNroCupon.Visible = False
                Me.cboBanco.Visible = False
                Me.txtObservaciones.Text = ""
            End If
        End If

    End Sub

    Private Sub guardarTarjetaPorVenta(ByVal idVenta As Integer)
        Dim objVentas As New Ventas

        If Me.txtNroCupon.Text = "" Then
            objVentas.nuevaTarjetaPorVenta(Me.cboTipoTarjeta.SelectedValue, 0, idVenta, "0")
        Else
            objVentas.nuevaTarjetaPorVenta(Me.cboTipoTarjeta.SelectedValue, 0, idVenta, Me.txtNroCupon.Text)
        End If


    End Sub

    Private Sub txtTotalFacturaAfip_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub frmVentas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.habilitarControles()
            Me.cboComprobantes.SelectedValue = 121
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
            While i < Me.lstArticulos.Rows.Count
                objArticulo.idArticulo = CInt(lstArticulos.Rows(i).Cells(0).Value.ToString)
                objArticulo.sumarStockArticulo(objArticulo, CInt(lstArticulos.Rows(i).Cells(1).Value.ToString))

                i = i + 1

            End While



            Me.inicializarControles()
        End If
    End Sub

#Region "AFIP"


    Function Autenticar(ByVal TA As String) As String
        ' Procedimiento para autenticar con AFIP y reutilizar el ticket de acceso
        ' Llamar antes de utilizar WSAA.Token y WSAA.Sign (WSAA debe estar definido a nivel de módulo)

        Try
            Dim ok, expiracion, solicitar, token, sign

            Dim tra As String
            Dim fechaExpiracion As String
            Dim pathCRT As String
            Dim pathKEY As String

            Dim objAFIP As New AFIP
            ' Dim xd As New XmlDocument()

            '  xd.LoadXml(TA)


            pathCRT = My.Application.Info.DirectoryPath & "\RUBEN5_62c34bd22c9c6d0f.crt"
            'pathCRT = My.Application.Info.DirectoryPath & "\certHomo.crt"

            pathKEY = My.Application.Info.DirectoryPath & "\arco.key"
            'Dim ta As String



            ' cargar ticket de acceso previo (si no se mantiene WSAA instanciado en memoria)
            If TA <> "" Then
                ok = WSAA.AnalizarXml(TA) '

            End If


            ' revisar si el ticket es válido y no ha expirado:
            expiracion = WSAA.ObtenerTagXml("expirationTime")
            'Debug.Print "Fecha Expiracion ticket: ", expiracion
            If IsDBNull(expiracion) Then
                solicitar = True                           ' solicitud inicial
            Else
                solicitar = WSAA.Expirado(expiracion)      ' chequear solicitud previa
            End If

            If solicitar Then
                ' Generar un Ticket de Requerimiento de Acceso (TRA)

                tra = WSAA.CreateTRA("wsfe", 2400)

                ' Generar el mensaje firmado (CMS)
                cms = WSAA.SignTRA(tra, pathCRT, pathKEY) ' Generar el mensaje firmado (CMS) 
                'MsgBox(cms)
                'ok = WSAA.Conectar("", "https://wsaahomo.afip.gov.ar/ws/services/LoginCms?wsdl", "") ' Homologacion

                'ok = WSAA.Conectar("", "https://wsaa.afip.gov.ar/ws/services/LoginCms?wsdl", "") ' producción

                TA = WSAA.CallWSAA(cms, "https://wsaa.afip.gov.ar/ws/services/LoginCms")

                'MsgBox(TA)
                ' Llamar al web service para autenticar
                'TA = WSAA.LoginCMS(cms)


                'generarTXT(TA, "ta.txt")
                'generarTXT(token, "token.txt")
                'generarTXT(sign, "sign.txt")
            Else
                'Debug.Print "no expirado!", "Reutilizando!"
            End If

            token = WSAA.ObtenerTagXml("token")
            sign = WSAA.ObtenerTagXml("sign")
            generarTXT(TA, "ta.txt")
            generarTXT(token, "token.txt")
            generarTXT(sign, "sign.txt")
            'objAFIP.modificarTA(TA, token, sign)


            obtenerCae()
        Catch ex As Exception
            'MsgBox("Error de conexión con servidor de AFIP ")
            MsgBox("No se ha podido obtemer Código de Autorización Electrónica CAE" & vbNewLine & WSFEv1.ErrMsg & vbNewLine & WSFEv1.Obs)
            btnAFIP.Enabled = True
        End Try

    End Function

    Private Sub obtenerCae()

        'Set WSFE = CreateObject("WSFE")
        'Dim WSFEv1 = CreateObject("WSFEv1")

        Dim objAFIP As New AFIP
        Dim oDataSet As New DataSet

        '  oDataSet = objAFIP.TA
        'token = oDataSet.Tables(0).Rows(0).Item("token")
        'sign = oDataSet.Tables(0).Rows(0).Item("sign")

        token = leerTXT("token.txt")
        sign = leerTXT("sign.txt")

        ' Setear tocken y sing de autorización (pasos previos)
        'WSFEv1.Token = Trim(token)
        'WSFEv1.Sign = Trim(sign)
        ' CUIT del emisor (debe estar registrado en la AFIP)
        WSFEv1.SetTicketAcceso(leerTXT("ta.txt"))

        'MsgBox(WSFEv1.Token)
        'MsgBox(WSFEv1.Sign)
        WSFEv1.Cuit = "20111732311"

        ' Conectar al Servicio Web de Facturación (servidor de homologación)
        'Dim ok = WSFEv1.Conectar("https://wswhomo.afip.gov.ar/wsfev1/service.asmx")

        Dim ok = WSFEv1.Conectar("", "https://servicios1.afip.gov.ar/wsfev1/service.asmx", "")


        ' Llamo a un servicio “tonto”, para obtener el estado (opcional)
        If WSFEv1.Dummy = False Then
            MsgBox("Los servidores de AFIP se encuentran momentaneamente fuera de servicio." & vbNewLine & "Por favor, intente nuevamente es unos minutos", MsgBoxStyle.Information)
            Exit Sub
        End If




        'Dim tipo_documento As Integer = 80
        'Dim cuit_cliente As String = CStr(cuitCliente)
        Dim cuit_cliente As String

        Dim tipo_documento As Integer
        Dim dni As String
        dni = Replace(CStr(cuitCliente), "-", "")
        dni = Trim(Replace(dni, "_", " "))
        'MsgBox(dni)
        If dni.Length = 11 Then
            tipo_documento = 80
            cuit_cliente = Replace(CStr(cuitCliente), "-", "")
        Else
            tipo_documento = 96
            cuit_cliente = CStr(dni)
        End If


        Dim tipo_comprobante As Integer = cboComprobantes.SelectedValue
        Dim PuntoVenta As Integer = 3
        Dim numero_factura As Integer = (WSFEv1.CompUltimoAutorizado(tipo_comprobante, PuntoVenta)) + 1

        Dim total_factura As String = Replace(totalFacturaAfip, ",", ".") ' CStr(totalFacturaAfip)
        Dim total_IVA As String = Replace(Replace(FormatNumber(totalIvaAfip), ".", ""), ",", ".") ' CStr(totalIvaAfip)
        Dim total_neto As String = Replace(totalNetoAfip, ",", ".") ' CStr(totalFacturaAfip - totalIvaAfip)
        Dim total_neto1 As String = Replace(total_neto, ",", ".")

        Dim total_conceptos As String = "0.00"
        Dim percepciones_IB As String = "0.00"
        Dim total_exento As String = "0.00"
        Dim fecha_factura As String = Format(dtpFechaAlta.Value, "yyyyMMdd")

        'comprobante no discrimina iva
        'If tipo_comprobante > 3 Then
        '    total_IVA = "0.00"
        '    total_neto = Replace(totalFacturaAfip, ",", ".")
        '    total_neto1 = Replace(totalFacturaAfip, ",", ".")
        'End If


        ' Creo una factura (internamente, no se llama al !WebService):
        ok = WSFEv1.CrearFactura(1, tipo_documento, cuit_cliente, tipo_comprobante, PuntoVenta, numero_factura, numero_factura, total_factura, total_conceptos, total_neto1, total_IVA, percepciones_IB, total_exento, fecha_factura, "", "", "", "PES", "1.00")


        'asocio comprobantes: nota de credito y debito

        If tipo_comprobante = 3 Or tipo_comprobante = 2 Or tipo_comprobante = 7 Or tipo_comprobante = 8 Then
            Dim comprobanteAsociado As Integer
            If tipo_comprobante = 2 Or tipo_comprobante = 3 Then
                comprobanteAsociado = 1
            ElseIf tipo_comprobante = 7 Or tipo_comprobante = 8 Then
                comprobanteAsociado = 6
            End If
            WSFEv1.AgregarCmpAsoc(comprobanteAsociado, PuntoVenta, numero_factura, cuitCliente, fecha_factura)

        End If

        '

        'If tipo_comprobante < 4 Then
        WSFEv1.AgregarIva(5, total_neto, total_IVA)
        ' End If


        lblCae.Text = WSFEv1.CAESolicitar

        'MsgBox(WSFEv1.Resultado)
        If WSFEv1.Resultado <> "A" Then
            MsgBox("No se ha podido obtener Código de Autorización Electrónica CAE" & vbNewLine & WSFEv1.ErrMsg & vbNewLine & WSFEv1.Obs)
            ' MsgBox(WSFEv1.Obs & WSFEv1.ErrMsg)
            Exit Sub
        Else
            ' MsgBox("CAE: " & WSFEv1.CAESolicitar & " Vencimiento: " & WSFEv1.Vencimiento & " " & WSFEv1.Obs & WSFEv1.ErrMsg)

            lblVtoCae.Text = WSFEv1.Vencimiento
            numeroComporbante = numero_factura
            Me.txtDatosCheques.Text = "CAE: " & lblCae.Text & " - Vencimiento: " & lblVtoCae.Text & " - Comprobante número: " & generarNumeroFactura(numero_factura, "0003") & WSFEv1.Obs & " " & WSFEv1.ErrMsg & " " & WSFEv1.Resultado
            objAFIP.insetarCaeXfactura(lblCae.Text, lblVtoCae.Text, idVentaFN, numero_factura)
            Me.txtFacturaNumero.Text = generarNumeroFactura(numero_factura)
            'idVentaFN = numero_factura
            idVentaAfip = numero_factura
            seObtuvoCae = True
        End If


        Exit Sub



    End Sub

    Public Sub generarTXT(ByVal texto As String, ByVal archivo As String)
        Try
            Dim ruta As String = My.Application.Info.DirectoryPath & "\" & archivo
            Dim escritor As StreamWriter

            If System.IO.File.Exists(ruta) = True Then
                System.IO.File.Delete(ruta)
            End If

            escritor = File.AppendText(ruta)
            ' System.IO.File.WriteAllText(ruta, String.Empty)

            escritor.Write(texto)
            escritor.Flush()
            escritor.Close()
            'MessageBox.Show("Escritura realizada con éxito")
        Catch ex As Exception
            MessageBox.Show("Escritura realizada incorrectamente")
        End Try
    End Sub

    Private Function leerTXT(ByVal archivo As String) As String

        Dim fic As String = My.Application.Info.DirectoryPath & "\" & archivo
        Dim texto As String

        Dim sr As New System.IO.StreamReader(fic)
        texto = sr.ReadToEnd()
        sr.Close()
        Return texto

    End Function

#End Region




    Private Function generarNumeroFactura(ByVal idFactura As Integer, ByVal puntoVenta As String) As String
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
        numeroFacturaConvertido = puntoVenta & " - " & cadena & nroNV
        Return numeroFacturaConvertido

    End Function

    Private Sub generarTempVentas(ByVal idVenta As Integer)
        Dim objTempVentas As New TempVentas

        Dim objVentas As New Ventas
        Dim objCliente As New Clientes
        Dim objArticulo As New Articulos
        Dim objCondicionVenta As New CondicionVenta
        Dim objAfip As New AFIP
        Dim oDataSetVentas As New DataSet
        Dim oDataSetCliente As New DataSet
        Dim oDataSetTarjetas As New DataSet

        objTempVentas.borrarVenta(idVentaFN)
        objTempVentas.borrarDetalleVenta(idVentaFN)

        oDataSetVentas = objVentas.buscarVentasXidVenta(idVenta)

        objTempVentas.fecha_venta = oDataSetVentas.Tables(0).Rows(0).Item("fecha_venta")
        objTempVentas.idCliente = oDataSetVentas.Tables(0).Rows(0).Item("idCLiente")
        objTempVentas.idCondicion_venta = oDataSetVentas.Tables(0).Rows(0).Item("idCondicion_venta")
        objTempVentas.observaciones = oDataSetVentas.Tables(0).Rows(0).Item("observaciones")
        objTempVentas.idComprobante = oDataSetVentas.Tables(0).Rows(0).Item("idComprobante")
        objTempVentas.descuento_venta = oDataSetVentas.Tables(0).Rows(0).Item("descuento_venta")
        objTempVentas.monto = oDataSetVentas.Tables(0).Rows(0).Item("monto")
        objTempVentas.numeroComprobante = Me.txtFacturaNumero.Text
        objTempVentas.recargo_venta = oDataSetVentas.Tables(0).Rows(0).Item("recargo_venta")
        objTempVentas.numVenta = idVenta

        objTempVentas.nuevaVenta(objTempVentas)

        'detalle venta

        Dim i As Integer
        i = 0

        objTempVentas.idDetalle_venta = idVenta

        While i < Me.lstArticulos.Rows.Count
            objTempVentas.idArticulo = Me.lstArticulos.Rows(i).Cells(0).Value.ToString
            objTempVentas.cantidad = Me.lstArticulos.Rows(i).Cells(1).Value.ToString
            objTempVentas.cantidad = Replace(Me.lstArticulos.Rows(i).Cells(1).Value.ToString, ".", ",")
            objTempVentas.precioUnitario = Me.lstArticulos.Rows(i).Cells(5).Value.ToString
            objTempVentas.cotizacion = Me.lstArticulos.Rows(i).Cells(7).Value.ToString
            objTempVentas.nuevoDetalleVenta(objTempVentas)

            i = i + 1

        End While

        'detalle venta
    End Sub

    Private Sub cargarComboBanco()
        Dim objBanco As New Banco
        Dim oDataSet As New DataSet
        oDataSet = objBanco.buscarBancosPropios
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboBanco.DataSource = oDataSet.Tables(0)
            Me.cboBanco.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboBanco.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboBanco.SelectedIndex = -1
        End If
    End Sub

    Private Sub guardarTransferenciaPorVenta(ByVal idVenta As Integer)
        Dim objVentas As New Ventas


        objVentas.nuevaTransferenciaPorVenta(Me.cboBanco.SelectedValue, idVenta)



    End Sub
End Class