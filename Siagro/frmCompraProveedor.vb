Public Class frmCompraProveedor

    Dim codProveedor As Integer
    Dim accion As String
    Dim cerrar As Boolean
    Dim codCompra As Integer
    Public estadoAbono As Integer
    Public ultimoReciboAbonado As Integer

    Public Sub New(ByVal idProveedor As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.llenarComboComprobantes()
        Dim objProveedores As New Proveedores
        Dim odataset As New DataSet
        Dim objAfip As New AFIP
        codProveedor = idProveedor

        odataset = objProveedores.buscarProveedoresXid(codProveedor)
        Me.codProveedor = odataset.Tables(0).Rows(0).Item("idProveedor")
        txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("razon_social")
        ' Me.cboComprobantes.Text = objAfip.buscarComprobantesCompraXid(odataset.Tables(0).Rows(0).Item("idComprobante")).Tables(0).Rows(0).Item("Descripcion")

        Me.tssBarraVentas.Enabled = False
        'Me.btnImprimir.Enabled = False
        'Me.btnBuscarCliente.Enabled = False
        accion = "nuevo"
        cerrar = True
        Me.txtReciboNumero.Focus()

    End Sub
    Public Sub New(ByVal idProveedor As Integer, ByVal idCompra As Integer)
        InitializeComponent()
        Dim oDataSet As New DataSet
        Dim objProveedores As New Proveedores
        Dim objAfip As New AFIP
        Me.llenarComboComprobantes()
        codCompra = idCompra
        oDataSet = objProveedores.buscarComprasPorID(idCompra)

        Me.dtpFechaAlta.Text = oDataSet.Tables(0).Rows(0).Item("fecha")
        Me.txtReciboNumero.Text = oDataSet.Tables(0).Rows(0).Item("NumeroComprobante")
        codProveedor = oDataSet.Tables(0).Rows(0).Item("idProveedor")
        Dim oDataSetProveedor As New DataSet
        Dim objProveedor As New Proveedores
        oDataSetProveedor = objProveedor.buscarProveedor(codProveedor)
        txtRazonSocialCliente.Text = oDataSetProveedor.Tables(0).Rows(0).Item("razon_social")
        Me.txtImporte.Text = oDataSet.Tables(0).Rows(0).Item("monto")
        MsgBox(objAfip.buscarComprobantesCompraXid(oDataSet.Tables(0).Rows(0).Item("idComprobante")).Tables(0).Rows(0).Item("Descripcion"))
        Me.cboComprobantes.Text = objAfip.buscarComprobantesCompraXid(oDataSet.Tables(0).Rows(0).Item("idComprobante")).Tables(0).Rows(0).Item("Descripcion")

        tssBorrar.Enabled = True
        tssModificar.Enabled = True
        tssNuevo.Enabled = False
        txtImporte.Enabled = False
        ' btnImprimir.Enabled = True
        Me.btnCancelar.Enabled = True
        btnGuardar.Enabled = False
    End Sub


    Private Sub frmCompraProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.estadoAbono = 0

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objProveedores As New Proveedores
        objProveedores.fecha = dtpFechaAlta.Text
        objProveedores.idProveedor = codProveedor
        objProveedores.comprobanteCompra = Me.txtReciboNumero.Text
        objProveedores.monto = Replace(Me.txtImporte.Text, ".", ",")
        objProveedores.idComprobante = cboComprobantes.SelectedValue

        If accion = "nuevo" Then
            objProveedores.nuevaCompra(objProveedores)
            'ultimoReciboAbonado = objPago.ultimoPago.Tables(0).Rows(0).Item(0)
            'Dim frmRecibo As New frmRecibo(ultimoReciboAbonado)
            'frmRecibo.ShowDialog()
            If cerrar = True Then
                Me.estadoAbono = 1
                Me.Close()
                'Me.btnImprimir.Enabled = True
                Me.btnGuardar.Enabled = False
                Me.btnCancelar.Enabled = False
                'Me.lblMensaje.Text = "El pago se realizó con éxito." & vbNewLine & "Puede imprimir el comprobante y regresar a la gestión de cta. cte"
            Else
                Me.inicializarControles()
            End If

        ElseIf accion = "modificar" Then
            If MsgBox("La siguiente acción modificará la compra" & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then

                objProveedores.idCompraProveedores = codCompra
                objProveedores.comprobanteCompra = Me.txtReciboNumero.Text
                'objPago.idCliente = codCliente

                objProveedores.modificarCompra(objProveedores)
                Me.inicializarControles()
                'Dim frmRecibo As New frmRecibo(codCompra)
                'frmRecibo.ShowDialog()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub inicializarControles()
        Me.tssNuevo.Enabled = True
        Me.tssModificar.Enabled = False
        Me.tssConsultar.Enabled = True
        Me.tssBorrar.Enabled = False

        'Me.btnBuscarCliente.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnGuardar.Enabled = False
        'Me.btnImprimir.Enabled = False


        Me.txtImporte.Enabled = False
        Me.txtRazonSocialCliente.Enabled = False
        Me.txtReciboNumero.Enabled = False

        Me.txtImporte.Text = ""
        Me.txtRazonSocialCliente.Text = ""
        Me.txtReciboNumero.Text = ""

        Me.dtpFechaAlta.Enabled = False
    End Sub

    Private Sub tssModificar_Click(sender As Object, e As EventArgs) Handles tssModificar.Click
        Me.accion = "modificar"
        Me.habilitarControles()
    End Sub

    Private Sub habilitarControles()
        Me.tssNuevo.Enabled = False
        Me.tssModificar.Enabled = False
        Me.tssConsultar.Enabled = False
        Me.tssBorrar.Enabled = False

        'Me.btnBuscarCliente.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnGuardar.Enabled = True
        'Me.btnImprimir.Enabled = False


        Me.txtImporte.Enabled = True
        Me.txtRazonSocialCliente.Enabled = True
        Me.txtReciboNumero.Enabled = True

        Me.txtRazonSocialCliente.Enabled = True


        Me.dtpFechaAlta.Enabled = True


        'Me.btnBuscarCliente.Focus()
    End Sub

    Private Sub tssCerrar_Click(sender As Object, e As EventArgs) Handles tssCerrar.Click
        Me.Close()
    End Sub

    Private Sub tssBorrar_Click(sender As Object, e As EventArgs) Handles tssBorrar.Click
        Dim objProveedor As New Proveedores


        If MsgBox("La siguiente acción eliminará la compra" & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then

            Me.inicializarControles()
            objProveedor.borrarCompraProveedores(codCompra)
            'Dim frmRecibo As New frmRecibo(codCompra)
            'frmRecibo.ShowDialog()
            Me.Close()
        End If
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
End Class