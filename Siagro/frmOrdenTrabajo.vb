Public Class frmOrdenTrabajo
    Dim accion As String
    Dim stock As Integer
    Dim idOT As Integer
    Private precioArticuloSeleccionado, ivaArticuloSeleccionado, utilidad, descuento As Double
    Dim codigoArticuloDeVenta As Integer
    Dim codigoModeloCerca, codigoModeloLejos, codigoReparaciones As Integer
    Dim codigoOS As Integer

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.inicializarControles()
        Me.llenarComboCondicionVenta()
        Me.llenarComboTarjetas()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ByVal idOTP As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'Me.calcularFechaVencimiento()
        Me.llenarComboCondicionVenta()
        Me.llenarComboTarjetas()
        idOT = idOTP
        Me.buscarOT(idOT)
        bloquearControles()
        Me.tssNuevo.Enabled = False
        Me.tssModificar.Enabled = False
        Me.tssConsultar.Enabled = False
        Me.tssBorrar.Enabled = False

        'Me.btnBuscarCliente.Enabled = False
        'Me.btnCancelar.Enabled = False
        'Me.btnGuardar.Enabled = False
        Me.btnImprimir.Enabled = True
        ''Me.btnImprimirDetalle.Enabled = True
        'Me.btnNuevoCliente.Enabled = False

        ''Me.lstArticulos.Enabled = False

        ''Me.txtCantidad.Enabled = False
        ''Me.txtVendedor.Enabled = False
        'Me.txtCodCliente.Enabled = False
        ''Me.txtCodigoArticulo.Enabled = False
        ''Me.txtCuit.Enabled = False
        ''Me.txtDescripcion.Enabled = False
        ''Me.txtFechaVto.Enabled = False
        ''Me.txtIva.Enabled = False
        'Me.txtRazonSocialCliente.Enabled = False
        'Me.txtSubTotal.Enabled = False
        'Me.txtTotal.Enabled = False
        'Me.txtDescuento.Enabled = False
        ''Me.txtRecargo.Enabled = False
        ''Me.txtFacturaNumero.Enabled = False
        ''Me.txtObservaciones.Enabled = False
        'Me.txtNroCupon.Enabled = False
        ''Me.dtpFechaAlta.Enabled = False

        'Me.cboCondVenta.Enabled = False
        '' Me.cboIva.Enabled = False
        ''Me.cboComprobantes.Enabled = False
        '' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'Me.cboTipoTarjeta.Enabled = False
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
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

        End If
    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
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

    Private Sub frmOrdenTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboTipoTarjeta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoTarjeta.SelectedIndexChanged
        Try
            Dim objVentas As New Ventas
            Dim oDataSet As New DataSet
            oDataSet = objVentas.buscarTarjetasVenta(Me.cboTipoTarjeta.SelectedValue)
            Me.txtDescuento.Text = oDataSet.Tables(0).Rows(0).Item("porcRecargo")
        Catch ex As Exception

        End Try

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

    Private Sub guardarTarjetaPorVenta(ByVal idVenta As Integer)
        Dim objVentas As New Ventas


        objVentas.nuevaTarjetaPorVenta(Me.cboTipoTarjeta.SelectedValue, idVenta, 0, Me.txtNroCupon.Text)


    End Sub

    Private Sub tssNuevo_Click(sender As Object, e As EventArgs) Handles tssNuevo.Click
        accion = "nuevo"
        Me.habilitarControles()
        ultimaOT()

    End Sub

    Private Sub btnBuscarCristalesCerca_Click(sender As Object, e As EventArgs) Handles btnBuscarCristalesCerca.Click
        Dim frmBuscarArticulos As New frmBuscarArticulos(1)
        frmBuscarArticulos.ShowDialog()
        'Me.txtCodigoCristalCerca.Text = frmBuscarArticulos.codigoArticulo
        If frmBuscarArticulos.codigoArticulo = 0 Then
        Else


            'MsgBox(txtCodigoCristalLejos.Text.ToString)
            If txtCodigoCristalCerca.Text.ToString = Nothing Then
                Me.txtCodigoCristalCerca.Text = frmBuscarArticulos.codigoArticulo
                Me.llenarCampoArticulo(txtCodigoCristalCerca.Text, "cristal cerca")

            Else
                Dim objArticulo As New Articulos
                objArticulo.idArticulo = Me.txtCodigoCristalLejos.Text
                objArticulo.sumarStockArticulo(objArticulo, 1)
                Me.txtCodigoCristalCerca.Text = frmBuscarArticulos.codigoArticulo
                Me.llenarCampoArticulo(txtCodigoCristalCerca.Text, "cristal cerca")
            End If

        End If
    End Sub

    Private Sub btnBuscarModeloLejos_Click(sender As Object, e As EventArgs) Handles btnBuscarModeloLejos.Click
        Dim frmBuscarArticulos As New frmBuscarArticulos(2)
        frmBuscarArticulos.ShowDialog()


        If frmBuscarArticulos.codigoArticulo = 0 Then
        Else


            'MsgBox(txtCodigoCristalLejos.Text.ToString)
            If codigoModeloLejos = Nothing Then
                Me.codigoModeloLejos = frmBuscarArticulos.codigoArticulo
                Me.llenarCampoArticulo(codigoModeloLejos, "modelo lejos")


            Else
                Dim objArticulo As New Articulos
                objArticulo.idArticulo = Me.txtCodigoCristalLejos.Text
                objArticulo.sumarStockArticulo(objArticulo, 1)
                Me.codigoModeloLejos = frmBuscarArticulos.codigoArticulo
                Me.llenarCampoArticulo(codigoModeloLejos, "modelo lejos")

            End If
        End If

    End Sub

    Private Sub buscarModeloCerca_Click(sender As Object, e As EventArgs) Handles btnbuscarModeloCerca.Click
        Dim frmBuscarArticulos As New frmBuscarArticulos(2)
        frmBuscarArticulos.ShowDialog()

        If frmBuscarArticulos.codigoArticulo = 0 Then
        Else


            'MsgBox(txtCodigoCristalLejos.Text.ToString)
            If codigoModeloCerca = Nothing Then
                Me.codigoModeloCerca = frmBuscarArticulos.codigoArticulo
                Me.llenarCampoArticulo(codigoModeloCerca, "modelo cerca")


            Else
                Dim objArticulo As New Articulos
                objArticulo.idArticulo = Me.txtCodigoCristalLejos.Text
                objArticulo.sumarStockArticulo(objArticulo, 1)
                Me.codigoModeloCerca = frmBuscarArticulos.codigoArticulo
                Me.llenarCampoArticulo(codigoModeloCerca, "modelo cerca")


            End If
        End If
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        sumarPrecios()
    End Sub

    Private Sub btnBuscarCristalesLejos_Click(sender As Object, e As EventArgs) Handles btnBuscarCristalesLejos.Click
        Dim frmBuscarArticulos As New frmBuscarArticulos(1)
        frmBuscarArticulos.ShowDialog()

        If frmBuscarArticulos.codigoArticulo = 0 Then
        Else
            'MsgBox(txtCodigoCristalLejos.Text.ToString)
            If txtCodigoCristalLejos.Text.ToString = Nothing Then
                Me.txtCodigoCristalLejos.Text = frmBuscarArticulos.codigoArticulo
                Me.llenarCampoArticulo(txtCodigoCristalLejos.Text, "cristal lejos")

            Else
                Dim objArticulo As New Articulos
                objArticulo.idArticulo = Me.txtCodigoCristalLejos.Text
                objArticulo.sumarStockArticulo(objArticulo, 1)
                Me.txtCodigoCristalLejos.Text = frmBuscarArticulos.codigoArticulo
                Me.llenarCampoArticulo(txtCodigoCristalLejos.Text, "cristal lejos")
            End If
            sumarPrecios()
        End If
    End Sub

    Private Sub btnLimpiarCristalesLejos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCristalesLejos.Click
        Dim objArticulo As New Articulos
        objArticulo.idArticulo = Me.txtCodigoCristalLejos.Text
        objArticulo.sumarStockArticulo(objArticulo, 1)
        Me.txtCodigoCristalLejos.Text = ""
        Me.txtDescripcionCristalLejos.Text = ""
        Me.txtPrecioCristalLejos.Text = 0
        sumarPrecios()
        Dim i As Integer
        i = cboDescOS.SelectedValue
        cboDescOS.SelectedIndex = -1
        cboDescOS.SelectedValue = i
    End Sub

    Private Sub btnLimpiarCristalesCerca_Click(sender As Object, e As EventArgs) Handles btnLimpiarCristalesCerca.Click
        Dim objArticulo As New Articulos
        objArticulo.idArticulo = Me.txtCodigoCristalCerca.Text
        objArticulo.sumarStockArticulo(objArticulo, 1)
        Me.txtCodigoCristalCerca.Text = ""
        Me.txtDescripcionCristalCerca.Text = ""
        Me.txtPrecioCristalCerca.Text = 0
        sumarPrecios()
        Dim i As Integer
        i = cboDescOS.SelectedValue
        cboDescOS.SelectedIndex = -1
        cboDescOS.SelectedValue = i
    End Sub

    Private Sub btnLimpiarArmazonLejos_Click(sender As Object, e As EventArgs) Handles btnLimpiarArmazonLejos.Click
        Dim objArticulo As New Articulos
        objArticulo.idArticulo = codigoModeloLejos
        objArticulo.sumarStockArticulo(objArticulo, 1)
        Me.codigoModeloLejos = Nothing
        Me.txtModeloLejos.Text = ""
        Me.txtMarcaLejos.Text = ""
        Me.txtPrecioArmazonLejos.Text = 0
        sumarPrecios()
        Dim i As Integer
        i = cboDescOS.SelectedValue
        cboDescOS.SelectedIndex = -1
        cboDescOS.SelectedValue = i
    End Sub

    Private Sub btnLimpiarArmazonCerca_Click(sender As Object, e As EventArgs) Handles btnLimpiarArmazonCerca.Click
        Dim objArticulo As New Articulos
        objArticulo.idArticulo = codigoModeloCerca
        objArticulo.sumarStockArticulo(objArticulo, 1)
        Me.codigoModeloCerca = Nothing
        Me.txtModeloCerca.Text = ""
        Me.txtMarcaCerca.Text = ""
        Me.txtPrecioArmazonCerca.Text = 0
        sumarPrecios()
        Dim i As Integer
        i = cboDescOS.SelectedValue
        cboDescOS.SelectedIndex = -1
        cboDescOS.SelectedValue = i
    End Sub

    Private Sub btnLimparReparaciones_Click(sender As Object, e As EventArgs) Handles btnLimparReparaciones.Click
        Dim objArticulo As New Articulos
        objArticulo.idArticulo = codigoReparaciones
        objArticulo.sumarStockArticulo(objArticulo, 1)
        Me.codigoReparaciones = Nothing
        Me.txtReparaciones.Text = ""
        Me.txtPrecioReparaciones.Text = 0
        sumarPrecios()
        Dim i As Integer
        i = cboDescOS.SelectedValue
        cboDescOS.SelectedIndex = -1
        cboDescOS.SelectedValue = i
    End Sub

    Private Sub btnLimpiarOS_Click(sender As Object, e As EventArgs) Handles btnLimpiarOS.Click
        codigoOS = Nothing
        txtObraSocial.Text = ""
        cboDescOS.DataSource = Nothing
        cboDescOS.SelectedIndex = -1
        sumarPrecios()
    End Sub

    Private Sub btnBuscarReparaciones_Click(sender As Object, e As EventArgs) Handles btnBuscarReparaciones.Click
        Dim frmBuscarArticulos As New frmBuscarArticulos(3)
        frmBuscarArticulos.ShowDialog()

        If frmBuscarArticulos.codigoArticulo = 0 Then
        Else


            'MsgBox(txtCodigoCristalLejos.Text.ToString)
            If codigoReparaciones = Nothing Then
                Me.codigoReparaciones = frmBuscarArticulos.codigoArticulo
                Me.llenarCampoArticulo(codigoReparaciones, "reparaciones")


            Else
                Dim objArticulo As New Articulos
                objArticulo.idArticulo = Me.txtCodigoCristalLejos.Text
                objArticulo.sumarStockArticulo(objArticulo, 1)
                Me.codigoReparaciones = frmBuscarArticulos.codigoArticulo
                Me.llenarCampoArticulo(codigoReparaciones, "reparaciones")


            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim objArticulo As New Articulos
        objArticulo.idArticulo = codigoReparaciones
        objArticulo.sumarStockArticulo(objArticulo, 1)
        If Me.txtCodigoCristalLejos.Text <> "" Then
            objArticulo.idArticulo = Me.txtCodigoCristalLejos.Text
            objArticulo.sumarStockArticulo(objArticulo, 1)
        End If
        If Me.txtCodigoCristalCerca.Text <> "" Then
            objArticulo.idArticulo = Me.txtCodigoCristalCerca.Text.ToString
            objArticulo.sumarStockArticulo(objArticulo, 1)
        End If
        If accion = "" Then
            objArticulo.idArticulo = codigoModeloLejos
            objArticulo.sumarStockArticulo(objArticulo, 1)
            objArticulo.idArticulo = codigoModeloCerca
            objArticulo.sumarStockArticulo(objArticulo, 1)
        End If
        inicializarControles()
        accion = ""
        alerta.Clear()
    End Sub

    Private Sub llenarCampoArticulo(ByVal codigoArticulo As String, ByVal campo As String)
        Dim objArticulo As New Articulos
        Dim oDataSet As New DataSet

        oDataSet = objArticulo.buscarArticulo(codigoArticulo)
        If oDataSet.Tables(0).Rows.Count > 0 Then
            Me.stock = oDataSet.Tables(0).Rows(0).Item("stock")
            If accion = "" Then
                stock = 1
            End If
            'If 1 <= Me.stock Then
            Me.precioArticuloSeleccionado = FormatNumber(oDataSet.Tables(0).Rows(0).Item("costo") + (oDataSet.Tables(0).Rows(0).Item("costo") * (oDataSet.Tables(0).Rows(0).Item("utilidad") / 100)), 2)
                Me.precioArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado - (Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("descuento") / 100)), 2)
                Me.ivaArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("iva") / 100), 2)

                If campo = "cristal lejos" Then
                    Me.txtDescripcionCristalLejos.Text = oDataSet.Tables(0).Rows(0).Item("descripcion")
                    Me.txtCodigoCristalLejos.Text = oDataSet.Tables(0).Rows(0).Item("idArticulo")
                    Me.txtPrecioCristalLejos.Text = Me.precioArticuloSeleccionado + Me.ivaArticuloSeleccionado
                ElseIf campo = "cristal cerca" Then
                    Me.txtDescripcionCristalCerca.Text = oDataSet.Tables(0).Rows(0).Item("descripcion")
                    Me.txtCodigoCristalCerca.Text = oDataSet.Tables(0).Rows(0).Item("idArticulo")
                    Me.txtPrecioCristalCerca.Text = Me.precioArticuloSeleccionado + Me.ivaArticuloSeleccionado
                ElseIf campo = "modelo lejos" Then
                    Dim objMarca As New Marca
                    Me.txtModeloLejos.Text = oDataSet.Tables(0).Rows(0).Item("descripcion")
                    Me.codigoModeloLejos = oDataSet.Tables(0).Rows(0).Item("idArticulo")
                    Me.txtPrecioArmazonLejos.Text = Me.precioArticuloSeleccionado + Me.ivaArticuloSeleccionado
                    Me.txtMarcaLejos.Text = objMarca.buscarMarca(oDataSet.Tables(0).Rows(0).Item("idMarca")).Tables(0).Rows(0).Item("descripcion")
                ElseIf campo = "modelo cerca" Then
                    Dim objMarca As New Marca
                    Me.txtModeloCerca.Text = oDataSet.Tables(0).Rows(0).Item("descripcion")
                    Me.codigoModeloCerca = oDataSet.Tables(0).Rows(0).Item("idArticulo")
                    Me.txtPrecioArmazonCerca.Text = Me.precioArticuloSeleccionado + Me.ivaArticuloSeleccionado
                    Me.txtMarcaCerca.Text = objMarca.buscarMarca(oDataSet.Tables(0).Rows(0).Item("idMarca")).Tables(0).Rows(0).Item("descripcion")
                ElseIf campo = "reparaciones" Then
                    Dim objMarca As New Marca
                    Me.txtReparaciones.Text = oDataSet.Tables(0).Rows(0).Item("descripcion")
                    Me.codigoReparaciones = oDataSet.Tables(0).Rows(0).Item("idArticulo")
                    Me.txtPrecioReparaciones.Text = Me.precioArticuloSeleccionado + Me.ivaArticuloSeleccionado

                End If
                objArticulo.idArticulo = codigoArticulo
                objArticulo.restarStockArticulo(objArticulo, 1)
            'Else
            '    MsgBox("El artículo no contiene el stock que usted a ingrasado. Solo dispone de: " & Me.stock & " artículos",, "SISTEMAS GESTIÓN DE VENTAS Y STOCK")

            '    Exit Sub
            'End If
        End If
        Me.sumarPrecios()
    End Sub

    Private Sub sumarPrecios()
        Dim i As Integer = 0
        Dim iva, total, subtotal As Double


        'subtotal = CDbl(Me.txtPrecioCristalLejos.Text.ToString) + CDbl(txtPrecioCristalCerca.Text.ToString) + CDbl(Me.txtPrecioArmazonCerca.Text.ToString) + CDbl(Me.txtPrecioArmazonLejos.Text.ToString) + CDbl(Me.txtPrecioReparaciones.Text.ToString)
        'Me.txtSubTotal.Text = FormatNumber(total - iva, 2)
        'Me.txtSubTotal.Text = "$ " & FormatNumber(subtotal, 2)


        If cboDescOS.SelectedIndex = -1 Then
            subtotal = CDbl(Me.txtPrecioCristalLejos.Text.ToString) + CDbl(txtPrecioCristalCerca.Text.ToString) + CDbl(Me.txtPrecioArmazonCerca.Text.ToString) + CDbl(Me.txtPrecioArmazonLejos.Text.ToString) + CDbl(Me.txtPrecioReparaciones.Text.ToString)
            Me.txtSubTotal.Text = "$" & FormatNumber(total - iva, 2)
            Me.txtSubTotal.Text = "$" & FormatNumber(subtotal, 2)
            Me.txtTotal.Text = "$" & FormatNumber(subtotal, 2)
        Else
            Dim montoDescuento As Double
            subtotal = CDbl(Me.txtPrecioCristalLejos.Text.ToString) + CDbl(txtPrecioCristalCerca.Text.ToString) + CDbl(Me.txtPrecioArmazonCerca.Text.ToString) + CDbl(Me.txtPrecioArmazonLejos.Text.ToString) + CDbl(Me.txtPrecioReparaciones.Text.ToString)
            Me.txtSubTotal.Text = "$" & FormatNumber(total - iva, 2)
            Me.txtSubTotal.Text = "$" & FormatNumber(subtotal, 2)
            Me.txtTotal.Text = "$" & FormatNumber(CDbl(Me.txtTotalDescOS.Text), 2)
            montoDescuento = Me.txtSubTotal.Text * (Replace(Me.cboDescOS.Text, ",", ".") / 100)
            Me.txtTotalDescOS.Text = "$" & FormatNumber(Me.txtSubTotal.Text - montoDescuento, 2)
            Me.txtTotal.Text = "$" & FormatNumber(CDbl(Me.txtTotalDescOS.Text), 2)
        End If

        Me.calcularDescuentosRecargos()

    End Sub

    Private Sub tssCerrar_Click(sender As Object, e As EventArgs) Handles tssCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarObraSocial_Click(sender As Object, e As EventArgs) Handles btnBuscarObraSocial.Click
        Dim objOS As New ObraSocial
        Dim odataset As New DataSet

        Dim min As Integer = 0

        Dim frmbuscarOS As New frmBuscarObraSocial
        frmbuscarOS.ShowDialog()
        If frmbuscarOS.idBusquedaOS <> 0 Then
            ' Me.inicializarControles()
            Dim idOS As Integer
            idOS = frmbuscarOS.idBusquedaOS
            odataset = objOS.buscarObraSocialXID(idOS)
            Me.codigoOS = odataset.Tables(0).Rows(0).Item(0)
            txtObraSocial.Text = odataset.Tables(0).Rows(0).Item("descripcion")
            llenarComboDescuentoPorOS(idOS)
            sumarPrecios()
        End If
    End Sub

    Private Sub calcularDescuentosRecargos()
        Dim montoDescuento As Double
        If cboDescOS.SelectedIndex = -1 Then
            If Me.txtDescuento.Text = "0" Or Me.txtDescuento.Text = "" Then
                Me.txtTotal.Text = "$" & FormatNumber(CDbl(Me.txtSubTotal.Text), 2)
            Else
                montoDescuento = Me.txtTotal.Text * (Replace(Me.txtDescuento.Text, ",", ".") / 100)
                Me.txtTotal.Text = "$" & FormatNumber(Me.txtTotal.Text + montoDescuento, 2)
            End If
        Else
            'con descuento de obra social
            If Me.txtDescuento.Text = "0" Or Me.txtDescuento.Text = "" Then
                Me.txtTotal.Text = "$" & FormatNumber(CDbl(Me.txtTotalDescOS.Text), 2)
            Else
                montoDescuento = Me.txtTotal.Text * (Replace(Me.txtDescuento.Text, ",", ".") / 100)
                Me.txtTotal.Text = "$" & FormatNumber(Me.txtTotal.Text + montoDescuento, 2)
            End If
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objOT As New OrdenTrabajo
        Dim estadoValidacion As Integer
        alerta.Clear()
        estadoValidacion = 0

        If Me.txtRazonSocialCliente.Text = "" Then
            estadoValidacion = 1
            alerta.SetError(Me.btnBuscarCliente, "Ingrese el nombre del cliente")

        End If
        'If lstArticulos.Rows.Count = 0 Then
        '    estadoValidacion = 1
        '    alerta.SetError(Me.lstArticulos, "Ingrese los artículos")
        'End If
        If cboCondVenta.SelectedIndex = -1 Then
            estadoValidacion = 1
            alerta.SetError(Me.cboCondVenta, "Seleccione condición de venta")
            alerta.SetIconAlignment(Me.cboCondVenta, ErrorIconAlignment.MiddleLeft)
        End If




        If estadoValidacion = 0 Then
            objOT.cercaOD = txtCercaOD.Text
            objOT.cercaOI = txtCercaOI.Text
            objOT.dr = txtDr.Text
            objOT.fechaEntrega = FormatDateTime(dtpFechaEntrega.Value, DateFormat.ShortDate)
            objOT.fechaRecepcion = FormatDateTime(dtpFechaRecepcion.Value, DateFormat.ShortDate)
            objOT.fechaReceta = FormatDateTime(dtpFechaReceta.Value, DateFormat.ShortDate)
            objOT.idArmazonCerca = codigoModeloCerca
            objOT.idArmazonLejos = codigoModeloLejos
            objOT.idCliente = txtCodCliente.Text
            objOT.idCondVenta = cboCondVenta.SelectedValue
            If txtCodigoCristalCerca.Text = "" Then
                objOT.idCristalCerca = 0
            Else
                objOT.idCristalCerca = txtCodigoCristalCerca.Text
            End If
            If txtCodigoCristalLejos.Text = "" Then
                objOT.idCristalLejos = 0
            Else
                objOT.idCristalLejos = txtCodigoCristalLejos.Text
            End If

            objOT.idOS = codigoOS
            objOT.idReparacion = codigoReparaciones
            objOT.lejosOD = txtLejosOD.Text
            objOT.lejosOI = txtLejosOI.Text
            objOT.idDescuentoOS = cboDescOS.SelectedValue
            objOT.descRecargo = txtDescuento.Text
            objOT.importe = txtTotal.Text
            If accion = "nuevo" Then
                If objOT.nuevaOT(objOT) = True Then
                    Dim oDataSet As New DataSet
                    oDataSet = objOT.ultimaOrden

                    If cboCondVenta.Text = "Tarjeta" Then
                        Me.guardarTarjetaPorVenta(oDataSet.Tables(0).Rows(0).Item(0))

                    End If

                    If MsgBox("¿Desea Imprimir de Orden de Trabajo? ", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                        'Dim objVenta As New Ventas
                        'objVenta.borrarVenta(idVentaFN)
                        'objVenta.borrarDetalleVenta(idVentaFN)
                        'Me.inicializarControles()
                        'Dim frmReporte As New frmDetalleVenta(idVentaFN)
                        'frmReporte.ShowDialog()
                        Dim frmReporte As New frmComprobanteOrdenTrabajo(oDataSet.Tables(0).Rows(0).Item(0))
                        frmReporte.ShowDialog()
                    End If

                    If cboCondVenta.Text = "Cta. Cte" Then

                        If MsgBox("¿Desea registrar entrega? ", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                            'Dim objVenta As New Ventas
                            'objVenta.borrarVenta(idVentaFN)
                            'objVenta.borrarDetalleVenta(idVentaFN)
                            Me.inicializarControles()
                            Dim frmRegistroPago As New frmPagos(objOT.idCliente, "0", 1)
                            frmRegistroPago.ShowDialog()
                            'Dim frmReporte As New frmDetalleVenta(idVentaFN)
                            'frmReporte.ShowDialog()
                        End If
                    End If


                End If
                ElseIf accion = "modificar" Then
                If MsgBox("La siguiente acción modificará la Orden de Trabajo" & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                    Dim objVentas As New Ventas
                    objOT.idOT = idOT
                    objOT.modificarOT(objOT)
                    objVentas.borrarTarjetaPorOT(idOT)

                    If cboCondVenta.Text = "Tarjeta" Then
                        Me.guardarTarjetaPorVenta(idOT)
                    End If

                    If MsgBox("¿Desea Imprimir Orden de Trabajo? ", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                        'Dim objVenta As New Ventas
                        'objVenta.borrarVenta(idVentaFN)
                        'objVenta.borrarDetalleVenta(idVentaFN)
                        Dim frmReporte As New frmComprobanteOrdenTrabajo(idOT)
                        frmReporte.ShowDialog()
                        Me.inicializarControles()
                        'Dim frmReporte As New frmDetalleVenta(idVentaFN)
                        'frmReporte.ShowDialog()
                    End If
                End If
            End If
        Else
            Exit Sub
        End If

        Me.inicializarControles()
    End Sub

    Private Sub tssConsultar_Click(sender As Object, e As EventArgs) Handles tssConsultar.Click
        Dim frmBuscarOT As New frmBuscarOT
        frmBuscarOT.ShowDialog()
        ' MsgBox(frmbuscarVentas.idVenta)
        If frmBuscarOT.idOT = 0 Then
            Exit Sub
        Else
            Me.buscarOT(frmBuscarOT.idOT)
            idOT = frmBuscarOT.idOT
            Me.btnCancelar.Enabled = True
            Me.tssNuevo.Enabled = False
            Me.tssBorrar.Enabled = True
            Me.tssModificar.Enabled = True
            Me.btnImprimir.Enabled = True
            'Me.btnImprimirDetalle.Enabled = True
        End If
    End Sub

    Private Sub cboCondVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCondVenta.SelectedIndexChanged
        If accion = "" Then
        Else
            If cboCondVenta.Text = "Tarjeta" Then
                Me.cboTipoTarjeta.Enabled = True
                Me.txtNroCupon.Enabled = True
            Else
                Me.cboTipoTarjeta.Enabled = False
                Me.txtNroCupon.Enabled = False
                Me.txtDescuento.Text = 0
                Me.cboTipoTarjeta.SelectedIndex = -1
                Me.txtNroCupon.Text = ""
            End If
        End If

    End Sub

    Private Sub tssModificar_Click(sender As Object, e As EventArgs) Handles tssModificar.Click
        habilitarControles()
        accion = "modificar"
    End Sub

    Private Sub inicializarControles()
        Me.txtCodigoCristalLejos.Text = ""
        Me.txtDescripcionCristalLejos.Text = ""
        Me.txtPrecioCristalLejos.Text = 0

        Me.txtCodigoCristalCerca.Text = ""
        Me.txtDescripcionCristalCerca.Text = ""
        Me.txtPrecioCristalCerca.Text = 0

        Me.codigoModeloLejos = Nothing
        Me.txtModeloLejos.Text = ""
        Me.txtMarcaLejos.Text = ""
        Me.txtPrecioArmazonLejos.Text = 0

        Me.codigoModeloCerca = Nothing
        Me.txtModeloCerca.Text = ""
        Me.txtMarcaCerca.Text = ""
        Me.txtPrecioArmazonCerca.Text = 0

        Me.codigoReparaciones = Nothing
        Me.txtReparaciones.Text = ""
        Me.txtPrecioReparaciones.Text = 0

        codigoOS = Nothing
        txtObraSocial.Text = ""
        cboDescOS.SelectedIndex = -1

        cboCondVenta.SelectedIndex = -1
        cboTipoTarjeta.SelectedIndex = -1
        txtNroCupon.Text = ""
        txtSubTotal.Text = ""
        txtTotalDescOS.Text = ""
        txtTotal.Text = ""
        txtDescuento.Text = ""

        txtOrdenNumero.Text = ""
        txtCodCliente.Text = ""
        txtRazonSocialCliente.Text = ""

        txtLejosOD.Text = ""
        txtLejosOI.Text = ""
        txtCercaOD.Text = ""
        txtCercaOI.Text = ""
        txtDr.Text = ""
        accion = ""
        alerta.Clear()
        bloquearControles()
    End Sub

    Private Sub cboDescOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDescOS.SelectedIndexChanged

        Try
            Dim montoDescuento As Double
            If Me.cboDescOS.SelectedIndex = -1 Then
                Me.txtTotal.Text = FormatNumber(CDbl(Me.txtSubTotal.Text), 2)
                Me.txtTotalDescOS.Text = ""
            Else
                montoDescuento = Me.txtSubTotal.Text * (Replace(Me.cboDescOS.Text, ",", ".") / 100)
                Me.txtTotalDescOS.Text = "$ " & FormatNumber(Me.txtSubTotal.Text - montoDescuento, 2)
                Me.txtTotal.Text = FormatNumber(CDbl(Me.txtTotalDescOS.Text), 2)
            End If
            sumarPrecios()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tssBorrar_Click(sender As Object, e As EventArgs) Handles tssBorrar.Click
        If MsgBox("La siguiente acción eliminará la Orden de Trabajo " & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
            Dim objOT As New OrdenTrabajo
            Dim objVenta As New Ventas
            objOT.borrarOT(idOT)
            objVenta.borrarTarjetaPorOT(idOT)
            Me.inicializarControles()
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim frmReporte As New frmComprobanteOrdenTrabajo(idOT)
        frmReporte.ShowDialog()
    End Sub

    Private Sub bloquearControles()

        Me.txtCodigoCristalLejos.Enabled = False
        Me.txtDescripcionCristalLejos.Enabled = False
        Me.txtPrecioCristalLejos.Enabled = False

        Me.txtCodigoCristalCerca.Enabled = False
        Me.txtDescripcionCristalCerca.Enabled = False
        Me.txtPrecioCristalCerca.Enabled = False


        Me.txtModeloLejos.Enabled = False
        Me.txtMarcaLejos.Enabled = False
        Me.txtPrecioArmazonLejos.Enabled = False

        Me.txtModeloCerca.Enabled = False
        Me.txtMarcaCerca.Enabled = False
        Me.txtPrecioArmazonCerca.Enabled = False


        Me.txtReparaciones.Enabled = False
        Me.txtPrecioReparaciones.Enabled = False


        txtObraSocial.Enabled = False
        cboDescOS.Enabled = False

        cboCondVenta.Enabled = False
        cboTipoTarjeta.Enabled = False
        txtNroCupon.Enabled = False
        txtSubTotal.Enabled = False
        txtTotalDescOS.Enabled = False
        txtTotal.Enabled = False
        txtDescuento.Enabled = False

        txtOrdenNumero.Enabled = False
        txtRazonSocialCliente.Enabled = False
        txtCodCliente.Enabled = False


        txtLejosOD.Enabled = False
        txtLejosOI.Enabled = False
        txtCercaOD.Enabled = False
        txtCercaOI.Enabled = False
        txtDr.Enabled = False

        Me.tssNuevo.Enabled = True
        Me.tssModificar.Enabled = False
        Me.tssConsultar.Enabled = True
        Me.tssBorrar.Enabled = False

        Me.btnBuscarCliente.Enabled = False
        btnBuscarCristalesCerca.Enabled = False
        btnBuscarCristalesLejos.Enabled = False
        btnBuscarModeloLejos.Enabled = False
        btnBuscarObraSocial.Enabled = False
        btnbuscarModeloCerca.Enabled = False
        btnBuscarReparaciones.Enabled = False

        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnImprimir.Enabled = False
        btnLimparReparaciones.Enabled = False
        btnLimpiarArmazonCerca.Enabled = False
        btnLimpiarArmazonLejos.Enabled = False
        btnLimpiarCristalesCerca.Enabled = False
        btnLimpiarCristalesLejos.Enabled = False
        btnLimpiarOS.Enabled = False
        btnNuevoCliente.Enabled = False
        dtpFechaEntrega.Enabled = False
        dtpFechaRecepcion.Enabled = False
        dtpFechaReceta.Enabled = False

    End Sub

    Private Sub habilitarControles()
        Me.txtCodigoCristalLejos.Enabled = True
        Me.txtDescripcionCristalLejos.Enabled = True
        Me.txtPrecioCristalLejos.Enabled = True

        Me.txtCodigoCristalCerca.Enabled = True
        Me.txtDescripcionCristalCerca.Enabled = True
        Me.txtPrecioCristalCerca.Enabled = True


        Me.txtModeloLejos.Enabled = True
        Me.txtMarcaLejos.Enabled = True
        Me.txtPrecioArmazonLejos.Enabled = True

        Me.txtModeloCerca.Enabled = True
        Me.txtMarcaCerca.Enabled = True
        Me.txtPrecioArmazonCerca.Enabled = True


        Me.txtReparaciones.Enabled = True
        Me.txtPrecioReparaciones.Enabled = True


        txtObraSocial.Enabled = True
        cboDescOS.Enabled = True

        cboCondVenta.Enabled = True
        cboTipoTarjeta.Enabled = True
        txtNroCupon.Enabled = True
        txtSubTotal.Enabled = True
        txtTotalDescOS.Enabled = True
        txtTotal.Enabled = True
        txtDescuento.Enabled = True

        txtOrdenNumero.Enabled = True
        txtRazonSocialCliente.Enabled = True
        txtCodCliente.Enabled = True

        txtLejosOD.Enabled = True
        txtLejosOI.Enabled = True
        txtCercaOD.Enabled = True
        txtCercaOI.Enabled = True
        txtDr.Enabled = True

        Me.tssNuevo.Enabled = False
        Me.tssModificar.Enabled = False
        Me.tssConsultar.Enabled = False
        Me.tssBorrar.Enabled = False

        Me.btnBuscarCliente.Enabled = True
        btnBuscarCristalesCerca.Enabled = True
        btnBuscarCristalesLejos.Enabled = True
        btnBuscarModeloLejos.Enabled = True
        btnBuscarObraSocial.Enabled = True
        btnbuscarModeloCerca.Enabled = True
        btnBuscarReparaciones.Enabled = True

        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        btnImprimir.Enabled = False
        btnLimparReparaciones.Enabled = True
        btnLimpiarArmazonCerca.Enabled = True
        btnLimpiarArmazonLejos.Enabled = True
        btnLimpiarCristalesCerca.Enabled = True
        btnLimpiarCristalesLejos.Enabled = True
        btnLimpiarOS.Enabled = True
        btnNuevoCliente.Enabled = True
        dtpFechaEntrega.Enabled = True
        dtpFechaRecepcion.Enabled = True
        dtpFechaReceta.Enabled = True
    End Sub

    Private Sub ultimaOT()
        Dim oDataSet As New DataSet
        Dim objOT As New OrdenTrabajo
        oDataSet = objOT.ultimaOrden

        Dim ultimoIdNotaVenta As Integer
        'oDataSet = objVentas.ultimaVenta

        If oDataSet.Tables(0).Rows(0).Item(0).ToString = "" Then
            ultimoIdNotaVenta = 0
        Else
            ultimoIdNotaVenta = oDataSet.Tables(0).Rows(0).Item(0)
        End If
        txtOrdenNumero.Text = ultimoIdNotaVenta + 1
    End Sub


    Private Sub buscarOT(ByVal idOT As Integer)
        Dim objVentas As New Ventas
        Dim objOT As New OrdenTrabajo
        Dim oDataSet As New DataSet
        Dim objCliente As New Clientes
        Dim objArticulo As New Articulos
        Dim objCondicionVenta As New CondicionVenta
        Dim objAfip As New AFIP
        Dim oDataSetVentas As New DataSet
        Dim oDataSetCliente As New DataSet
        Dim oDataSetTarjetas As New DataSet
        Dim oDataSetOS As New DataSet
        Dim objOS As New ObraSocial

        oDataSet = objOT.BuscarOrdenesXid(idOT)
        Me.txtOrdenNumero.Text = idOT
        oDataSetCliente = objCliente.buscarCliente(oDataSet.Tables(0).Rows(0).Item("idCliente"))
        Me.txtCodCliente.Text = oDataSetCliente.Tables(0).Rows(0).Item("idCLiente")
        txtRazonSocialCliente.Text = oDataSetCliente.Tables(0).Rows(0).Item("nombre") & " " & oDataSetCliente.Tables(0).Rows(0).Item("apellido")
        Me.cboCondVenta.Text = objCondicionVenta.buscarCondicionVenta(oDataSet.Tables(0).Rows(0).Item("idCondVenta")).Tables(0).Rows(0).Item("descripcion")

        oDataSetTarjetas = objVentas.buscarTarjetasVentaPorIDOrden(idOT)
        If oDataSetTarjetas.Tables(0).Rows.Count = 0 Then
        Else

            cboTipoTarjeta.Text = objVentas.buscarTarjetasVenta(oDataSetTarjetas.Tables(0).Rows(0).Item("idTarjeta")).Tables(0).Rows(0).Item("descripcion").ToString
            Me.txtNroCupon.Text = oDataSetTarjetas.Tables(0).Rows(0).Item("cuponNumero")
        End If

        txtCercaOD.Text = oDataSet.Tables(0).Rows(0).Item("cercaOD")
        txtCercaOI.Text = oDataSet.Tables(0).Rows(0).Item("cercaOI")
        txtLejosOD.Text = oDataSet.Tables(0).Rows(0).Item("lejosOD")
        txtLejosOI.Text = oDataSet.Tables(0).Rows(0).Item("lejosOI")
        txtDr.Text = oDataSet.Tables(0).Rows(0).Item("dr")
        dtpFechaReceta.Value = oDataSet.Tables(0).Rows(0).Item("fechaReceta")


        If oDataSet.Tables(0).Rows(0).Item("idCristalLejos") = 0 Then
        Else
            Me.txtCodigoCristalLejos.Text = oDataSet.Tables(0).Rows(0).Item("idCristalLejos")
            Me.llenarCampoArticulo(txtCodigoCristalLejos.Text, "cristal lejos")
        End If

        If oDataSet.Tables(0).Rows(0).Item("idCristalCerca") = 0 Then
        Else
            Me.txtCodigoCristalCerca.Text = oDataSet.Tables(0).Rows(0).Item("idCristalCerca")
            Me.llenarCampoArticulo(txtCodigoCristalCerca.Text, "cristal cerca")
        End If

        If oDataSet.Tables(0).Rows(0).Item("idArmazonCerca") = 0 Then
        Else
            Me.codigoModeloCerca = oDataSet.Tables(0).Rows(0).Item("idArmazonCerca")
            Me.llenarCampoArticulo(codigoModeloCerca, "modelo cerca")
        End If

        If oDataSet.Tables(0).Rows(0).Item("idArmazonLejos") = 0 Then
        Else
            Me.codigoModeloLejos = oDataSet.Tables(0).Rows(0).Item("idArmazonLejos")
            Me.llenarCampoArticulo(codigoModeloLejos, "modelo lejos")
        End If

        If oDataSet.Tables(0).Rows(0).Item("idReparacion") = 0 Then
        Else
            Me.codigoReparaciones = oDataSet.Tables(0).Rows(0).Item("idReparacion")
            Me.llenarCampoArticulo(codigoReparaciones, "reparaciones")
        End If

        oDataSetOS = objOS.buscarObraSocialXID(oDataSet.Tables(0).Rows(0).Item("idObraSocial"))
        If oDataSetOS.Tables(0).Rows.Count > 0 Then
            'objOS.buscarObraSocialXID(oDataSet.Tables(0).Rows(0).Item("idOS"))
            Me.codigoOS = oDataSetOS.Tables(0).Rows(0).Item(0)
            txtObraSocial.Text = oDataSetOS.Tables(0).Rows(0).Item("descripcion")
            'MsgBox(oDataSet.Tables(0).Rows(0).Item("idDescuentoOS"))
        End If
        llenarComboDescuentoPorOS(oDataSet.Tables(0).Rows(0).Item("idObraSocial"))
        cboDescOS.SelectedValue = oDataSet.Tables(0).Rows(0).Item("idDescuentoOS")
        Me.txtDescuento.Text = oDataSet.Tables(0).Rows(0).Item("descRecargo")
        Me.txtTotal.Text = "$" & FormatNumber(oDataSet.Tables(0).Rows(0).Item("importe"), 2)

        'calcularDescuentosRecargos()
    End Sub

    Private Sub llenarComboDescuentoPorOS(ByVal idOS As Integer)
        Dim objOS As New ObraSocial
        Dim oDataSet As New DataSet
        oDataSet = objOS.buscarDescuentoXOS(idOS)
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboDescOS.DataSource = oDataSet.Tables(0)
            Me.cboDescOS.DisplayMember = oDataSet.Tables(0).Columns(2).Caption.ToString
            Me.cboDescOS.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboDescOS.SelectedIndex = -1
        End If
    End Sub

End Class