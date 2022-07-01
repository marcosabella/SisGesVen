Public Class frmArticulo
    Dim accion As String
    Dim idProveedor As Integer

    Private Sub btnIngresoMercaderia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresoMercaderia.Click
        Dim frmIngresoMercaderia As New frmIngresoMercaderia
        frmIngresoMercaderia.ShowDialog()
        If Me.txtStock.Text = "" Then
            Me.txtStock.Text = frmIngresoMercaderia.ingresoMercaderia
        Else
            Me.txtStock.Text = CInt(Me.txtStock.Text.ToString) + frmIngresoMercaderia.ingresoMercaderia

        End If
    End Sub

    Private Sub btnBuscarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProveedor.Click
        Dim frmBuscarProveedor As New frmBuscarProveedor
        Dim min As Integer = 0
        Dim objProveedor As New Proveedores
        Dim odataset As New DataSet

        frmBuscarProveedor.ShowDialog()
        If frmBuscarProveedor.idProveedorBusqueda <> 0 Then
            idProveedor = frmBuscarProveedor.idProveedorBusqueda
            odataset = objProveedor.buscarProveedor(idProveedor)
            Me.txtCodProveedor.Text = odataset.Tables(0).Rows(0).Item("idProveedor")
            txtRazonSocialProveedor.Text = odataset.Tables(0).Rows(0).Item("razon_social")
        End If
    End Sub

    Private Sub btnBuscarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProducto.Click
        Me.buscarArticulo()
    End Sub

    Private Sub btnNuevoProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoProveedor.Click
        Dim frmProveedor As New frmProveedores("nuevoProveedor")
        frmProveedor.ShowDialog()
        If frmProveedor.nuevoProveedor = 1 Then
            Dim objProveedor As New Proveedores
            Dim odataset As New DataSet
            odataset = objProveedor.buscarProveedor(objProveedor.buscarUltimoProveedor().Tables(0).Rows(0).Item(0))
            Me.txtCodProveedor.Text = odataset.Tables(0).Rows(0).Item("idProveedor")
            txtRazonSocialProveedor.Text = odataset.Tables(0).Rows(0).Item("razon_social")
        End If

    End Sub

    Private Sub buscarArticulo()
        Dim objArticulo As New Articulos
        Dim oDataSet As New DataSet
        Dim precioVenta As Double
        Dim objProveedor As New Proveedores
        Dim frmBuscarArticulo As New frmBuscarArticulos
        Dim objMarca As New Marca
        Dim objRubro As New Rubro
        frmBuscarArticulo.ShowDialog()
        oDataSet = objArticulo.buscarArticuloXcodigo(frmBuscarArticulo.codigoArticulo)
        'MsgBox(frmBuscarArticulo.codigoArticulo)
        If frmBuscarArticulo.codigoArticulo = 0 Then
            Exit Sub
        End If


        If oDataSet.Tables(0).Rows.Count > 0 Then
            Me.txtCodProducto.Text = oDataSet.Tables(0).Rows(0).Item("idArticulo").ToString
            If oDataSet.Tables(0).Rows(0).Item("codigo_barras").ToString <> "" Then
                Me.txtCodigoBarras.Text = oDataSet.Tables(0).Rows(0).Item("codigo_barras").ToString
                lblEan.Text = Generar_EAN13(Me.txtCodigoBarras.Text)
            End If
            Me.txtDescripcionProducto.Text = oDataSet.Tables(0).Rows(0).Item("descripcion").ToString
                Me.txtCostoProducto.Text = oDataSet.Tables(0).Rows(0).Item("costo").ToString
                Me.txtUtilidad.Text = oDataSet.Tables(0).Rows(0).Item("utilidad".ToString)
            Me.txtIva.Text = oDataSet.Tables(0).Rows(0).Item("iva").ToString
            'Me.cboIva.Text = Me.txtIva.Text.ToString

            Me.txtDescuento.Text = oDataSet.Tables(0).Rows(0).Item("descuento").ToString
            Me.txtStock.Text = oDataSet.Tables(0).Rows(0).Item("stock").ToString
                Me.txtComentario.Text = (oDataSet.Tables(0).Rows(0).Item("comentario").ToString)
            precioVenta = Me.calcularPrecioVenta(Me.txtCostoProducto.Text.ToString, Replace(Me.txtIva.Text, ".", ","), Me.txtDescuento.Text.ToString, Me.txtUtilidad.Text.ToString)
            Me.txtPrecioVenta.Text = FormatNumber(precioVenta, 2)
                Me.txtCodProveedor.Text = oDataSet.Tables(0).Rows(0).Item("idProveedor").ToString
                Me.txtRazonSocialProveedor.Text = objProveedor.buscarProveedor(oDataSet.Tables(0).Rows(0).Item("idProveedor").ToString).Tables(0).Rows(0).Item("razon_social")
                Me.cboRubro.Text = objRubro.buscarRubro(oDataSet.Tables(0).Rows(0).Item("idRubro").ToString).Tables(0).Rows(0).Item("descripcion")
                Me.cboMarca.Text = objMarca.buscarMarca(oDataSet.Tables(0).Rows(0).Item("idMarca").ToString).Tables(0).Rows(0).Item("descripcion")
                Me.cboMoneda.Text = oDataSet.Tables(0).Rows(0).Item("moneda").ToString
            End If
            Me.tssCerrar.Enabled = True
        Me.tssConsultar.Enabled = True
        Me.tssBorrar.Enabled = True
        Me.tssModificar.Enabled = True
        Me.tssNuevo.Enabled = False
        Me.tssModificarPrecios.Enabled = False
        Me.btnBuscarProducto.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = True
        Me.btnImprimir.Enabled = True
        Me.bloquearControles()
    End Sub

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

    Private Sub inicializarControles()
        Me.tssBorrar.Enabled = False
        Me.tssConsultar.Enabled = True
        Me.tssModificar.Enabled = False
        Me.tssNuevo.Enabled = True
        Me.tssModificarPrecios.Enabled = True
        Me.alerta.Clear()
        Me.btnBuscarProducto.Enabled = False
        Me.btnBuscarProveedor.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btnImprimir.Enabled = False
        Me.btnIngresoMercaderia.Enabled = False
        Me.btnNuevaMarca.Enabled = False
        Me.btnNuevoProveedor.Enabled = False
        Me.btnNuevoRubro.Enabled = False
        Me.btnNuevoRubro.Enabled = False
        Me.btnGenerarEAN.Enabled = False
        'Me.txtCodigoBarras.Enabled = False
        'Me.txtCodProducto.Enabled = False
        'Me.txtCodProveedor.Enabled = False
        'Me.txtComentario.Enabled = False
        'Me.txtCostoProducto.Enabled = False
        'Me.txtDescripcionProducto.Enabled = False
        'Me.txtDescuento.Enabled = False
        'Me.txtIva.Enabled = False
        'Me.txtPrecioVenta.Enabled = False
        'Me.txtRazonSocialProveedor.Enabled = False
        'Me.txtStock.Enabled = False
        'Me.txtUtilidad.Enabled = False

        Me.txtCodigoBarras.Text = ""
        Me.txtCodProducto.Text = ""
        Me.txtCodProveedor.Text = ""
        Me.txtComentario.Text = ""
        Me.txtCostoProducto.Text = ""
        Me.txtDescripcionProducto.Text = ""
        Me.txtDescuento.Text = ""
        Me.txtIva.Text = ""
        Me.txtPrecioVenta.Text = ""
        Me.txtRazonSocialProveedor.Text = ""
        Me.txtStock.Text = ""
        Me.txtUtilidad.Text = ""

        Me.cboMarca.SelectedIndex = -1
        Me.cboRubro.SelectedIndex = -1
        Me.cboMoneda.SelectedIndex = -1
        'Me.cboIva.SelectedIndex = -1

        Me.cboMoneda.Enabled = False
        Me.cboMarca.Enabled = False
        Me.cboRubro.Enabled = False

        Me.btnActualizar.Enabled = False
        bloquearControles()
        txtCodProducto.Focus()
    End Sub

    Private Sub frmArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.inicializarControles()
        Me.cargarComboRubro()
        Me.cargarComboMarca()
    End Sub

    Private Sub tssConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssConsultar.Click
        Me.buscarArticulo()

    End Sub

    Private Sub tssCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.inicializarControles()
        Me.btnGenerarEAN.Enabled = False
    End Sub

    Private Sub tssBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBorrar.Click
        Dim objArticulo As New Articulos
        If MsgBox("La siguiente acción eliminará el artículo " & Me.txtDescripcionProducto.Text & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
            objArticulo.borrarArticulos(Me.txtCodProducto.Text)
            Me.inicializarControles()
        Else


        End If
    End Sub

    Private Sub tssModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssModificar.Click
        Me.habilitarControles()
        Me.accion = "modificar"
        desbloquearControles()
    End Sub

    Private Sub habilitarControles()
        Me.tssBorrar.Enabled = False
        Me.tssConsultar.Enabled = False
        Me.tssModificar.Enabled = False
        Me.tssNuevo.Enabled = False
        Me.tssModificarPrecios.Enabled = False
        Me.btnBuscarProducto.Enabled = True
        Me.btnBuscarProveedor.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.btnImprimir.Enabled = True
        Me.btnIngresoMercaderia.Enabled = True
        Me.btnNuevaMarca.Enabled = True
        Me.btnNuevoProveedor.Enabled = True
        Me.btnNuevoRubro.Enabled = True
        Me.btnNuevoRubro.Enabled = True
        Me.btnGenerarEAN.Enabled = True

        Me.txtCodigoBarras.Enabled = True
        Me.txtCodProducto.Enabled = True
        Me.txtCodProveedor.Enabled = True
        Me.txtComentario.Enabled = True
        Me.txtCostoProducto.Enabled = True
        Me.txtDescripcionProducto.Enabled = True
        Me.txtDescuento.Enabled = True
        Me.txtIva.Enabled = True
        Me.txtPrecioVenta.Enabled = True
        Me.txtRazonSocialProveedor.Enabled = True
        Me.txtStock.Enabled = True
        Me.txtUtilidad.Enabled = True


        Me.cboMarca.Enabled = True
        Me.cboRubro.Enabled = True
        Me.cboMoneda.Enabled = True
        'Me.cboIva.Enabled = True


        Me.btnActualizar.Enabled = True

        Me.txtDescripcionProducto.Focus()
    End Sub

    Private Sub tssNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssNuevo.Click
        Dim odataSet As New DataSet
        Dim objArticulo As New Articulos
        Dim objProveedor As New Proveedores

        odataSet = objArticulo.buscarUltimoCodArticulo
        If odataSet.Tables(0).Rows(0).Item(0).ToString = "" Then
            txtCodProducto.Text = 1
        Else
            txtCodProducto.Text = objArticulo.buscarUltimoCodArticulo.Tables(0).Rows(0).Item(0) + 1
        End if
        Me.accion = "nuevo"
        Me.habilitarControles()
        desbloquearControles()

        odataSet = objProveedor.buscarProveedor(1)
        Me.txtCodProveedor.Text = odataSet.Tables(0).Rows(0).Item("idProveedor")
        txtRazonSocialProveedor.Text = odataSet.Tables(0).Rows(0).Item("razon_social")

        cboMarca.SelectedValue = 1
        cboRubro.SelectedValue = 1

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim estadoAlerta As Integer
        alerta.Clear()
        estadoAlerta = 0
        If Me.txtDescripcionProducto.Text = "" Then
            alerta.SetError(Me.txtDescripcionProducto, "Ingrese la descripción del producto")
            estadoAlerta = 1
        End If
        If Me.cboMarca.Text = "" Then
                alerta.SetError(Me.btnNuevaMarca, "Seleccione la marca del artículo")
                estadoAlerta = 1
            End If
            If Me.cboRubro.Text = "" Then
                alerta.SetError(Me.cboRubro, "Seleccione el rubro del artículo")
                estadoAlerta = 1
            End If
            If Me.txtCodProveedor.Text = "" Then
                alerta.SetError(Me.btnBuscarProveedor, "Ingrese el proveedor")
                estadoAlerta = 1
            End If
            If Me.txtCostoProducto.Text = "" Then
                alerta.SetError(Me.txtCostoProducto, "Ingrese el costo del producto")
                estadoAlerta = 1
            End If
        If Me.txtIva.Text = "" Then
            alerta.SetError(Me.txtIva, "Ingrese el IVA del producto")
            estadoAlerta = 1
        End If
        If Me.txtStock.Text = "" Then
                alerta.SetError(Me.txtStock, "Ingrese el stock del producto")
                estadoAlerta = 1
            End If
            If Me.txtUtilidad.Text = "" Then
                alerta.SetError(Me.txtUtilidad, "Ingrese el % de utilidad del producto")
                estadoAlerta = 1
            End If
        If Me.cboMoneda.Text = "" Then
            alerta.SetError(Me.cboMoneda, "Seleccione el tipo de moneda")
            estadoAlerta = 1
        End If
        If estadoAlerta = 1 Then
                Exit Sub
            End If
        If estadoAlerta = 0 Then
            alerta.Clear()
        End If
        Dim objArticulo As New Articulos
        Dim odataset As New DataSet
        If Me.txtDescuento.Text = "" Then
            Me.txtDescuento.Text = 0
        End If
        'If Me.txtIva.Text = "" Then
        ' Me.txtIva.Text = 0
        'End If
        If Me.txtIva.Text = "" Then
            Me.txtIva.Text = 0
        End If
        If Me.txtUtilidad.Text = "" Then
            Me.txtUtilidad.Text = 0
        End If
        If Me.txtCodigoBarras.Text = "" Then
            Me.txtCodigoBarras.Text = "0"
        End If
        objArticulo.codigo_barras = Me.txtCodigoBarras.Text
        objArticulo.comentario = Me.txtComentario.Text.ToString
        'objArticulo.costo = Me.txtCostoProducto.Text.ToString
        objArticulo.costo = Replace(Me.txtCostoProducto.Text, ".", ",")
        objArticulo.descripcion = Me.txtDescripcionProducto.Text.ToString
        objArticulo.descuento = CDbl(Me.txtDescuento.Text.ToString)
        objArticulo.idProveedor = Me.txtCodProveedor.Text
        objArticulo.iva = Replace(Me.txtIva.Text, ".", ",")
        objArticulo.stock = Me.txtStock.Text.ToString
        objArticulo.utilidad = Replace(Me.txtUtilidad.Text, ".", ",")
        objArticulo.idMarca = Me.cboMarca.SelectedValue
        objArticulo.idRubro = Me.cboRubro.SelectedValue
        objArticulo.moneda = Me.cboMoneda.Text

        If accion = "modificar" Then

            objArticulo.idArticulo = Me.txtCodProducto.Text
            If MsgBox("La siguiente acción modificará el cliente: " & Me.txtDescripcionProducto.Text & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                objArticulo.modificarArticulo(objArticulo)
            End If
        Else

            If MsgBox("La siguiente acción dará de alta al artículo: " & Me.txtDescripcionProducto.Text & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                objArticulo.nuevoArticulo(objArticulo)
            End If
        End If
        Me.inicializarControles()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim estadoAlerta As Integer
        estadoAlerta = 0
        alerta.Clear()

        If Me.txtCostoProducto.Text = "" Then
            alerta.SetError(Me.txtCostoProducto, "Ingrese el costo del producto")
            estadoAlerta = 1
        End If
        If Me.txtIva.Text = "" Then
            alerta.SetError(Me.txtIva, "Ingrese el IVA del producto")
            estadoAlerta = 1
        End If

        If Me.txtUtilidad.Text = "" Then
            alerta.SetError(Me.txtUtilidad, "Ingrese el % de utilidad del producto")
            estadoAlerta = 1
        End If

        If estadoAlerta = 1 Then
            Exit Sub
        End If
        If estadoAlerta = 0 Then
            alerta.Clear()
            Me.txtPrecioVenta.Text = FormatNumber(Me.calcularPrecioVenta(Replace(Me.txtCostoProducto.Text, ".", ","), Replace(Me.txtIva.Text, ".", ","), Replace(Me.txtDescuento.Text, ".", ","), Replace(Me.txtUtilidad.Text, ".", ",")), 2)

        End If




    End Sub

    Private Sub cargarComboRubro()
        Dim objRubro As New Rubro
        Dim oDataSet As New DataSet
        oDataSet = objRubro.buscarRubrosLista
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboRubro.DataSource = oDataSet.Tables(0)
            Me.cboRubro.DisplayMember = oDataSet.Tables(0).Columns(2).Caption.ToString
            Me.cboRubro.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboRubro.SelectedIndex = -1
        End If
    End Sub

    Private Sub cargarComboMarca()
        Dim objMarca As New Marca
        Dim oDataSet As New DataSet
        oDataSet = objMarca.buscarMarcasLista
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboMarca.DataSource = oDataSet.Tables(0)
            Me.cboMarca.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboMarca.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboMarca.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnNuevoRubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoRubro.Click
        Dim frmRubro As New frmMarcaRubro("Rubro")
        frmRubro.ShowDialog()
        cboRubro.DataSource = Nothing
        Me.cargarComboRubro()
    End Sub

    Private Sub btnNuevaMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaMarca.Click
        Dim frmMarca As New frmMarcaRubro("Marca")
        frmMarca.ShowDialog()
        cboMarca.DataSource = Nothing
        Me.cargarComboMarca()
    End Sub

    Private Sub txtCostoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostoProducto.KeyPress
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

    Private Sub txtIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIva.KeyPress
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

    Private Sub txtUtilidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUtilidad.KeyPress
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

    Private Sub txtDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescuento.KeyPress
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

    Private Sub bloquearControles()


        Me.txtCodigoBarras.ReadOnly = True
        Me.txtCodProducto.ReadOnly = True
        Me.txtCodProveedor.ReadOnly = True
        Me.txtComentario.ReadOnly = True
        Me.txtCostoProducto.ReadOnly = True
        Me.txtDescripcionProducto.ReadOnly = True
        Me.txtDescuento.ReadOnly = True
        Me.txtIva.ReadOnly = True
        Me.txtPrecioVenta.ReadOnly = True
        Me.txtRazonSocialProveedor.ReadOnly = True
        Me.txtStock.ReadOnly = True
        Me.txtUtilidad.ReadOnly = True

        Me.cboMoneda.Enabled = False
        Me.cboMarca.Enabled = False
        Me.cboRubro.Enabled = False
        'Me.cboIva.Enabled = False



    End Sub

    Private Sub desbloquearControles()
        Me.txtCodigoBarras.ReadOnly = False
        Me.txtCodProducto.ReadOnly = True
        Me.txtCodProveedor.ReadOnly = True
        Me.txtComentario.ReadOnly = False
        Me.txtCostoProducto.ReadOnly = False
        Me.txtDescripcionProducto.ReadOnly = False
        Me.txtDescuento.ReadOnly = False
        Me.txtIva.ReadOnly = False
        Me.txtPrecioVenta.ReadOnly = True
        Me.txtRazonSocialProveedor.ReadOnly = True
        Me.txtStock.ReadOnly = True
        Me.txtUtilidad.ReadOnly = False
        Me.cboMoneda.Enabled = True
        Me.cboMarca.Enabled = True
        Me.cboRubro.Enabled = True
        'Me.cboIva.Enabled = True
    End Sub

    Private Sub btnGenerarEAN_Click(sender As Object, e As EventArgs) Handles btnGenerarEAN.Click
        Me.txtCodigoBarras.Text = generarNumeroCodigoBarras(Me.txtCodProducto.Text)
        lblEan.Text = Generar_EAN13(Me.txtCodigoBarras.Text)
    End Sub

    Private Function generarNumeroCodigoBarras(ByVal idOT As Integer) As String

        Dim i As Integer
        Dim cadena As String
        Dim nroNV As Integer
        Dim cadenaReturn As String

        cadena = ""
        i = idOT.ToString.Length
        While i < 12
            cadena = cadena.ToString & "0"
            i = i + 1
        End While
        cadenaReturn = cadena & idOT

        Dim codigo As String
        codigo = cadenaReturn
        'genero numero ean
        Dim first, checksum As Integer
        Dim code, code13 As String
        Dim tableA As Boolean
        i = 0





        ' Evaluar los dígitos del código
        If Len(Codigo) = 12 Then
            code = Codigo
        ElseIf Len(Codigo) = 13 Then
            code = Strings.Left(Codigo, 12)
        Else
            code = ""
        End If

        ' VerIficar los dígitos del código
        For i = 1 To Len(code)
            If Asc(Mid(code, i, 1)) < 48 Or Asc(Mid(code, i, 1)) > 57 Then
                code = ""
                Exit For
            End If
        Next

        ' Chequea los 12 dígitos y cálcula el digito de control
        If Len(code) = 12 Then
            For i = 12 To 1 Step -2
                checksum = checksum + Val(Mid(code, i, 1))
            Next
            checksum = checksum * 3
            For i = 11 To 1 Step -2
                checksum = checksum + Val(Mid(code, i, 1))
            Next
            code = code & CStr(((10 - checksum Mod 10) Mod 10))

        End If
        cadenaReturn = code
        Return cadenaReturn
    End Function

    Function Generar_EAN13(Codigo As String) As String
        ' Esta función permite generar el código de barras para mostrarlo con la fuente EAN13.TTF
        ' - Parametros : código de 12 o 13 dígitos
        ' - Retorno: retorna una cadena que permite representar generar el código de barras con la fuente EAN13.TTF
        '            retorna una cadena vacía si no se puede representar el código de barras

        Dim i, first, checksum As Integer
        Dim code, code13 As String
        Dim tableA As Boolean






        ' Evaluar los dígitos del código
        If Len(Codigo) = 12 Then
            code = Codigo
        ElseIf Len(Codigo) = 13 Then
            code = Strings.Left(Codigo, 12)
        Else
            code = ""
        End If

        ' VerIficar los dígitos del código
        For i = 1 To Len(code)
            If Asc(Mid(code, i, 1)) < 48 Or Asc(Mid(code, i, 1)) > 57 Then
                code = ""
                Exit For
            End If
        Next

        ' Chequea los 12 dígitos y cálcula el digito de control
        If Len(code) = 12 Then
            For i = 12 To 1 Step -2
                checksum = checksum + Val(Mid(code, i, 1))
            Next
            checksum = checksum * 3
            For i = 11 To 1 Step -2
                checksum = checksum + Val(Mid(code, i, 1))
            Next
            code = code & CStr(((10 - checksum Mod 10) Mod 10))

            ' Si el código inicial tenía 13 dígitos comprueba si el nuevo código generado
            ' es igual y en caso contrario no se generar ningún código

            If Len(Codigo) = 13 And Codigo <> code Then
                code = ""
            End If

        End If

        ' Chequea los 13 dígitos
        If Len(code) = 13 Then
            ' Los primeros 2 dígitos que suelen corresponder al código del país
            code13 = Strings.Left(code, 1) & Chr(65 + Val(Mid(code, 2, 1)))
            first = Val(Strings.Left(code, 1))

            ' Generar los códigos del primer bloque de dígitos
            For i = 3 To 7
                tableA = False
                Select Case i
                    Case 3
                        Select Case first
                            Case 0 To 3
                                tableA = True
                        End Select
                    Case 4
                        Select Case first
                            Case 0, 4, 7, 8
                                tableA = True
                        End Select
                    Case 5
                        Select Case first
                            Case 0, 1, 4, 5, 9
                                tableA = True
                        End Select
                    Case 6
                        Select Case first
                            Case 0, 2, 5, 6, 7
                                tableA = True
                        End Select
                    Case 7
                        Select Case first
                            Case 0, 3, 6, 8, 9
                                tableA = True
                        End Select
                End Select
                If tableA Then
                    code13 = code13 & Chr(65 + Val(Mid(code, i, 1)))
                Else
                    code13 = code13 & Chr(75 + Val(Mid(code, i, 1)))
                End If
            Next

            ' Añadir el separador de los bloques
            code13 = code13 & "*"

            ' Generar los códigos del segundo bloque de dígitos
            For i = 8 To 13
                code13 = code13 & Chr(97 + Val(Mid(code, i, 1)))
            Next

            ' Añadir la marca final
            code13 = code13 & "+"
        End If
        'code13 = "0000000000001"
        Generar_EAN13 = code13

    End Function

    Private Sub txtCodigoBarras_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoBarras.TextChanged
        If Me.txtCodigoBarras.Text = "" Then
            btnGenerarEAN.Enabled = True
            lblEan.Text = ""
        Else
            Me.btnGenerarEAN.Enabled = False
        End If
    End Sub

    Private Sub txtCodigoBarras_Validated(sender As Object, e As EventArgs) Handles txtCodigoBarras.Validated
        lblEan.Text = Generar_EAN13(Me.txtCodigoBarras.Text)
    End Sub

    Private Sub tssModificarPrecios_Click(sender As Object, e As EventArgs) Handles tssModificarPrecios.Click
        Dim frmModificarPrecios As New frmModificarPrecios
        frmModificarPrecios.ShowDialog()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim frmEtiquetas As New frmEtiquetasCodigo(CInt(Me.txtCodProducto.Text))
        frmEtiquetas.ShowDialog()
    End Sub
End Class