Imports System
Public Class frmPagos
    Dim codCliente As Integer
    Dim codProveedor As Integer
    Dim accion As String
    Dim cerrar As Boolean
    Dim codPago As Integer
    Public estadoAbono As Integer
    Public ultimoReciboAbonado As Integer
    Dim tipoPersona As Integer
    Public objCheque As New Cheque

    Private Sub frmPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.estadoAbono = 0

            Dim objCondicionVenta As New CondicionVenta

            Me.cargarComboBanco()

            If Me.tipoPersona = 1 Then

                Dim oDataSet As New DataSet
                Dim objPago As New Pagos

                oDataSet = objPago.buscarPagosXid(codPago)
                llenarComboCondicionVenta()
                cboCondVenta.SelectedIndex = 0

                If oDataSet.Tables(0).Rows.Count > 0 Then


                    Me.txtReciboNumero.Text = Me.generarNumeroRecibo(oDataSet.Tables(0).Rows(0).Item("idPago"))
                    codCliente = oDataSet.Tables(0).Rows(0).Item("idCliente")
                    Dim oDataSetCliente As New DataSet
                    Dim objCliente As New Clientes
                    oDataSetCliente = objCliente.buscarCliente(codCliente)
                    txtRazonSocialCliente.Text = oDataSetCliente.Tables(0).Rows(0).Item("nombre") & " " & oDataSetCliente.Tables(0).Rows(0).Item("apellido")
                    Me.txtImporte.Text = oDataSet.Tables(0).Rows(0).Item("importe")
                    Me.cboCondVenta.Text = objCondicionVenta.buscarCondicionVenta(oDataSet.Tables(0).Rows(0).Item("idCondicion_venta")).Tables(0).Rows(0).Item("descripcion")
                End If

                If cboCondVenta.Text = "Cheque" Then
                        btnEditarMedioPago.Enabled = True
                    Else
                        btnEditarMedioPago.Enabled = False
                    End If

                If cboCondVenta.Text = "Cheque" Then
                        Dim oDataSetCheque As New DataSet
                        oDataSetCheque = objCheque.buscarChequesXidPago(codPago)
                        If oDataSetCheque.Tables(0).Rows.Count > 0 Then
                            objCheque.emisor = oDataSetCheque.Tables(0).Rows(0).Item("emisor")
                            objCheque.fecha = oDataSetCheque.Tables(0).Rows(0).Item("fecha")
                            objCheque.idBanco = oDataSetCheque.Tables(0).Rows(0).Item("idBanco")
                            objCheque.idCheque = oDataSetCheque.Tables(0).Rows(0).Item("Id")
                            objCheque.idPago = oDataSetCheque.Tables(0).Rows(0).Item("idPago")
                            objCheque.monto = oDataSetCheque.Tables(0).Rows(0).Item("monto")
                            objCheque.nroCheque = oDataSetCheque.Tables(0).Rows(0).Item("nroCheque")
                            objCheque.vtoCheque = oDataSetCheque.Tables(0).Rows(0).Item("vencimiento")
                            txtObservaciones.Text = "Datos del Cheque: " & vbNewLine & "Emisor: " & oDataSetCheque.Tables(0).Rows(0).Item("emisor") & vbNewLine & "Fecha Vto: " & FormatDateTime(oDataSetCheque.Tables(0).Rows(0).Item("vencimiento"), DateFormat.ShortDate) & vbNewLine & "Importe: $ " & oDataSetCheque.Tables(0).Rows(0).Item("monto")

                        End If
                    End If


                If oDataSet.Tables(0).Rows.Count > 0 Then
                    tssBorrar.Enabled = True
                    tssModificar.Enabled = True
                    tssNuevo.Enabled = False
                    txtImporte.Enabled = False
                    btnImprimir.Enabled = True
                    Me.btnCancelar.Enabled = True
                    btnGuardar.Enabled = False
                    cboCondVenta.Enabled = False
                Else
                    tssBorrar.Enabled = False
                    tssModificar.Enabled = False
                    tssNuevo.Enabled = False
                    txtImporte.Enabled = True
                    btnImprimir.Enabled = True
                    Me.btnCancelar.Enabled = True
                    btnGuardar.Enabled = True
                    cboCondVenta.Enabled = True
                End If

            Else

                llenarComboCondicionVenta()

                Dim oDataSet As New DataSet
                Dim objProveedores As New Proveedores
                If codPago <> 0 Then

                    oDataSet = objProveedores.buscarPagosProveedoresXid(codPago)

                    Me.dtpFechaAlta.Text = oDataSet.Tables(0).Rows(0).Item("fecha_pago")
                    Me.txtReciboNumero.Text = Me.generarNumeroRecibo(oDataSet.Tables(0).Rows(0).Item("idPago"))
                    codProveedor = oDataSet.Tables(0).Rows(0).Item("idProveedor")
                    Dim oDataSetProveedor As New DataSet
                    Dim objProveedor As New Proveedores
                    oDataSetProveedor = objProveedor.buscarProveedor(codProveedor)
                    txtRazonSocialCliente.Text = oDataSetProveedor.Tables(0).Rows(0).Item("razon_social")
                    Me.txtImporte.Text = oDataSet.Tables(0).Rows(0).Item("importe")

                    Me.cboCondVenta.Text = objCondicionVenta.buscarCondicionVenta(oDataSet.Tables(0).Rows(0).Item("idCondicion_venta")).Tables(0).Rows(0).Item("descripcion")
                    If cboCondVenta.Text = "Cheque" Then
                        btnEditarMedioPago.Enabled = True
                    Else
                        btnEditarMedioPago.Enabled = False
                    End If

                    If cboCondVenta.Text = "Cheque" Then
                        Dim oDataSetCheque As New DataSet
                        oDataSetCheque = objCheque.buscarChequesXidPago(codPago)
                        If oDataSetCheque.Tables(0).Rows.Count > 0 Then
                            objCheque.emisor = oDataSetCheque.Tables(0).Rows(0).Item("emisor")
                            objCheque.fecha = oDataSetCheque.Tables(0).Rows(0).Item("fecha")
                            objCheque.idBanco = oDataSetCheque.Tables(0).Rows(0).Item("idBanco")
                            objCheque.idCheque = oDataSetCheque.Tables(0).Rows(0).Item("Id")
                            objCheque.idPago = oDataSetCheque.Tables(0).Rows(0).Item("idPago")
                            objCheque.monto = oDataSetCheque.Tables(0).Rows(0).Item("monto")
                            objCheque.nroCheque = oDataSetCheque.Tables(0).Rows(0).Item("nroCheque")
                            objCheque.vtoCheque = oDataSetCheque.Tables(0).Rows(0).Item("vencimiento")
                            txtObservaciones.Text = "Datos del Cheque: " & vbNewLine & "Emisor: " & oDataSetCheque.Tables(0).Rows(0).Item("emisor") & vbNewLine & "Fecha Vto: " & FormatDateTime(oDataSetCheque.Tables(0).Rows(0).Item("vencimiento"), DateFormat.ShortDate) & vbNewLine & "Importe: $ " & oDataSetCheque.Tables(0).Rows(0).Item("monto")

                        End If
                    End If

                    '
                End If
                tssBorrar.Enabled = True
                tssModificar.Enabled = True
                tssNuevo.Enabled = False
                txtImporte.Enabled = True
                btnImprimir.Enabled = True
                Me.btnCancelar.Enabled = True
                btnGuardar.Enabled = True
                cboCondVenta.Enabled = True

            End If

        Catch ex As Exception

        End Try


    End Sub

    Public Sub New(ByVal idCliente As Integer, ByVal montoAbonar As Double, ByVal tipoPersona As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        llenarComboCondicionVenta()
        Me.llenarComboTarjetas()
        Me.tipoPersona = tipoPersona
        If tipoPersona = 1 Then


            codCliente = idCliente
            Dim oDataSetCliente As New DataSet
            Dim objCliente As New Clientes
            oDataSetCliente = objCliente.buscarCliente(codCliente)
            txtRazonSocialCliente.Text = oDataSetCliente.Tables(0).Rows(0).Item("nombre") & " " & oDataSetCliente.Tables(0).Rows(0).Item("apellido")
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            Me.generarNumeroRecibo()
            Me.tssBarraVentas.Enabled = False
            Me.btnImprimir.Enabled = False
            Me.btnBuscarCliente.Enabled = False
            accion = "nuevo"
            cerrar = True
            Me.txtImporte.Focus()
            '.Text = CDec(FormatNumber(Replace(String.Format(montoAbonar, "{0:#.#}"), ".", ","), 2))
            txtImporte.Text = Replace(FormatNumber(montoAbonar, 2), ".", "")

        Else

            Dim objProveedores As New Proveedores
            Dim odataset As New DataSet
            codProveedor = idCliente


            odataset = objProveedores.buscarProveedoresXid(codProveedor)
            Me.codProveedor = odataset.Tables(0).Rows(0).Item("idProveedor")
            txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("razon_social")
            Me.generarNumeroRecibo()
            Me.tssBarraVentas.Enabled = False
            Me.btnImprimir.Enabled = False
            Me.btnBuscarCliente.Enabled = False
            accion = "nuevo"
            cerrar = True
            Me.txtImporte.Focus()
            txtImporte.Text = Replace(FormatNumber(montoAbonar, 2), ".", "")


        End If
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        Me.inicializarControles()
        Me.llenarComboTarjetas()
        cerrar = False
    End Sub

    Private Sub generarNumeroRecibo()
        Dim oDataSet As New DataSet
        Dim objPagos As New Pagos
        Dim objProveedor As New Proveedores
        Dim i As Integer
        Dim cadena As String
        Dim nroNR As Integer
        Dim ultimoIdPago As Integer
        If tipoPersona = 1 Then
            oDataSet = objPagos.ultimoPago
        Else
            oDataSet = objPagos.ultimoPagoProveedor
        End If

        If oDataSet.Tables(0).Rows(0).Item(0).ToString = "" Then
            ultimoIdPago = 0
        Else

            ultimoIdPago = oDataSet.Tables(0).Rows(0).Item(0)

        End If
        nroNR = ultimoIdPago + 1
        cadena = ""
        i = oDataSet.Tables(0).Rows(0).Item(0).ToString.Length
        While i < 7
            cadena = cadena.ToString & "0"
            i = i + 1
        End While
        Me.txtReciboNumero.Text = "0001" & cadena & nroNR
        ultimoReciboAbonado = nroNR
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

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.tipoPersona = 1 Then
            'tipo persona cliente
            Dim objPago As New Pagos
            objPago.fecha_pago = dtpFechaAlta.Text
            objPago.idCliente = codCliente
            objPago.importe = CDbl(Me.txtImporte.Text)
            objPago.importe = Replace(Me.txtImporte.Text, ".", ",")
            objPago.idCondicion_venta = cboCondVenta.SelectedValue
            If accion = "nuevo" Then
                If cboCondVenta.Text = "" Then
                    MsgBox("Seleccione la opción de pago")
                    Exit Sub
                End If
                If cboCondVenta.Text = "Cheque" Then

                    If objCheque.emisor = Nothing Then
                        MsgBox("no se encuentran datos registrados del cheque")
                        Exit Sub
                    Else
                        If objPago.ultimoPago.Tables(0).Rows(0).Item(0).ToString = "" Then
                            ultimoReciboAbonado = 0
                        Else

                            ultimoReciboAbonado = objPago.ultimoPago.Tables(0).Rows(0).Item(0)
                        End If

                        objCheque.idPago = 1 + ultimoReciboAbonado
                        objCheque.enCartera = True
                        objCheque.idCliente = codCliente
                        objCheque.registrarCheque(objCheque)
                    End If

                End If
                objPago.nuevoPago(objPago)
                ultimoReciboAbonado = objPago.ultimoPago.Tables(0).Rows(0).Item(0)

                Dim frmRecibo As New frmRecibo(ultimoReciboAbonado)
                frmRecibo.ShowDialog()
                If cerrar = True Then
                    Me.estadoAbono = 1
                    Me.Close()
                    Me.btnImprimir.Enabled = True
                    Me.btnGuardar.Enabled = False
                    Me.btnCancelar.Enabled = False

                    Me.lblMensaje.Text = "El pago se realizó con éxito." & vbNewLine & "Puede imprimir el comprobante y regresar a la gestión de cta. cte"
                Else
                    Me.inicializarControles()
                End If

            ElseIf accion = "modificar" Then
                If MsgBox("La siguiente acción modificará el pago" & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then

                    objPago.idPago = codPago

                    objPago.modificarPago(objPago)
                    objCheque.borrarChequeXPago(codPago)
                    If cboCondVenta.Text = "Cheque" Then
                        If objCheque.emisor = Nothing Then
                            MsgBox("no se encuentran datos registrados del cheque")
                        Else
                            objCheque.idPago = codPago
                            objCheque.enCartera = True
                            objCheque.registrarCheque(objCheque)
                        End If

                    End If
                    Me.inicializarControles()
                    Dim frmRecibo As New frmRecibo(codPago)
                    frmRecibo.ShowDialog()
                    Me.Close()
                End If
            End If

        Else
            'tipo persona proveedor
            Dim objPago As New Pagos
            objPago.fecha_pago = dtpFechaAlta.Text
            objPago.idProveedor = codProveedor
            objPago.importe = CDbl(Me.txtImporte.Text)
            objPago.importe = Replace(Me.txtImporte.Text, ".", ",")

            objPago.idCondicion_venta = cboCondVenta.SelectedValue
            If accion = "nuevo" Then
                objPago.nuevoPagoProveedores(objPago)
                ultimoReciboAbonado = objPago.ultimoPagoProveedor.Tables(0).Rows(0).Item(0)
                'Dim frmRecibo As New frmRecibo(ultimoReciboAbonado)
                'frmRecibo.ShowDialog()
                If cerrar = True Then
                    Me.estadoAbono = 1
                    Me.Close()
                    Me.btnImprimir.Enabled = True
                    Me.btnGuardar.Enabled = False
                    Me.btnCancelar.Enabled = False
                    Me.lblMensaje.Text = "El pago se realizó con éxito." & vbNewLine & "Puede imprimir el comprobante y regresar a la gestión de cta. cte"
                Else
                    Me.inicializarControles()
                End If

            ElseIf accion = "modificar" Then
                If MsgBox("La siguiente acción modificará el pago" & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then

                    objPago.idPago = codPago
                    'objPago.idCliente = codCliente

                    objPago.modificarPagoProveedor(objPago)
                    Me.inicializarControles()
                    'Dim frmRecibo As New frmRecibo(codPago)
                    'frmRecibo.ShowDialog()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If cerrar = True Then
            Me.Close()
        Else
            inicializarControles()
            Me.Close()
        End If

    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click

        If Me.tipoPersona = 1 Then
            'tipo persona Cliente

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
                Me.codCliente = odataset.Tables(0).Rows(0).Item("idCLiente")
                txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("nombre") & " " & odataset.Tables(0).Rows(0).Item("apellido")
                Me.txtRazonSocialCliente.Focus()

            End If
        Else
            'tipo persona proveedor
            Dim frmBuscarProveedores As New frmBuscarProveedor
            Dim objProveedores As New Proveedores
            Dim odataset As New DataSet
            frmBuscarProveedores.ShowDialog()
            If frmBuscarProveedores.idProveedorBusqueda <> 0 Then

                Dim idProveedor As Integer

                idProveedor = frmBuscarProveedores.idProveedorBusqueda
                odataset = objProveedores.buscarProveedoresXid(idProveedor)
                Me.codProveedor = odataset.Tables(0).Rows(0).Item("idProveedor")
                txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("razon_social")
            End If
        End If
    End Sub

    Private Sub inicializarControles()
        Me.tssNuevo.Enabled = True
        Me.tssModificar.Enabled = False
        Me.tssConsultar.Enabled = True
        Me.tssBorrar.Enabled = False

        Me.btnBuscarCliente.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btnImprimir.Enabled = False

        Me.txtImporte.Enabled = False
        Me.txtRazonSocialCliente.Enabled = False
        Me.txtReciboNumero.Enabled = False
        Me.txtRecargo.Visible = False

        Me.txtImporte.Text = ""
        Me.txtRazonSocialCliente.Text = ""
        Me.txtReciboNumero.Text = ""
        Me.txtRecargo.Text = ""
        Me.dtpFechaAlta.Enabled = False

        Me.Label16.Visible = False
    End Sub

    Private Sub tssNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssNuevo.Click
        accion = "nuevo"
        Me.habilitarControles()
        Me.generarNumeroRecibo()
        Me.generarNumeroRecibo()
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


        Me.txtImporte.Enabled = True
        Me.txtRazonSocialCliente.Enabled = True
        Me.txtReciboNumero.Enabled = True

        Me.txtRazonSocialCliente.Enabled = True


        Me.dtpFechaAlta.Enabled = True

        cboCondVenta.Enabled = True
        btnEditarMedioPago.Enabled = True

        Me.btnBuscarCliente.Focus()
    End Sub

    Private Sub tssCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssCerrar.Click
        Me.Close()
    End Sub

    Private Sub tssConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssConsultar.Click
        If Me.tipoPersona = 1 Then
            Dim frmBuscarPagos As New frmBuscarPagos
            frmBuscarPagos.ShowDialog()
            Me.codPago = frmBuscarPagos.idPago
            If codPago <> 0 Then

                Me.buscarPago()
            Else

            End If
        End If
    End Sub

    Private Sub buscarPago()
        If Me.tipoPersona = 1 Then
            Dim oDataSet As New DataSet
            Dim objPago As New Pagos

            oDataSet = objPago.buscarPagosXid(codPago)

            Me.dtpFechaAlta.Text = oDataSet.Tables(0).Rows(0).Item("fecha_pago")
            Me.txtReciboNumero.Text = Me.generarNumeroRecibo(oDataSet.Tables(0).Rows(0).Item("idPago"))
            codCliente = oDataSet.Tables(0).Rows(0).Item("idCliente")
            Dim oDataSetCliente As New DataSet
            Dim objCliente As New Clientes
            oDataSetCliente = objCliente.buscarCliente(codCliente)
            txtRazonSocialCliente.Text = oDataSetCliente.Tables(0).Rows(0).Item("nombre") & " " & oDataSetCliente.Tables(0).Rows(0).Item("apellido")
            Me.txtImporte.Text = oDataSet.Tables(0).Rows(0).Item("importe")

            tssBorrar.Enabled = True
            tssModificar.Enabled = True
            tssNuevo.Enabled = False

            Me.btnCancelar.Enabled = True
        Else
            'proveedor
        End If
    End Sub

    Private Sub tssBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBorrar.Click
        If MsgBox("La siguiente acción eliminará el Pago " & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
            If Me.tipoPersona = 1 Then
                Dim objPagos As New Pagos
                objPagos.borrarPago(codPago)
                objCheque.borrarChequeXPago(codPago)
            Else
                'Proveedores
                Dim objPagosProveedores As New Pagos
                objPagosProveedores.borrarPagoProveedor(codPago)
            End If
            Me.inicializarControles()
        End If
    End Sub

    Private Sub tssModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssModificar.Click
        Me.accion = "modificar"
        Me.habilitarControles()
    End Sub

    Public Sub New(ByVal idPago As Integer, ByVal tipoPersona As Integer)
        Me.tipoPersona = tipoPersona
        Dim objCondicionVenta As New CondicionVenta

        If Me.tipoPersona = 1 Then
            ' Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent()
            Dim oDataSet As New DataSet
            Dim objPago As New Pagos
            codPago = idPago
            oDataSet = objPago.buscarPagosXid(idPago)

            Me.dtpFechaAlta.Text = oDataSet.Tables(0).Rows(0).Item("fecha_pago")
            Me.txtReciboNumero.Text = Me.generarNumeroRecibo(oDataSet.Tables(0).Rows(0).Item("idPago"))
            codCliente = oDataSet.Tables(0).Rows(0).Item("idCliente")
            Dim oDataSetCliente As New DataSet
            Dim objCliente As New Clientes
            oDataSetCliente = objCliente.buscarCliente(codCliente)
            txtRazonSocialCliente.Text = oDataSetCliente.Tables(0).Rows(0).Item("nombre") & " " & oDataSetCliente.Tables(0).Rows(0).Item("apellido")
            Me.txtImporte.Text = oDataSet.Tables(0).Rows(0).Item("importe")


            'buscar cheques por pagos

            Me.cboCondVenta.Text = objCondicionVenta.buscarCondicionVenta(oDataSet.Tables(0).Rows(0).Item("idCondicion_venta")).Tables(0).Rows(0).Item("descripcion")
            If cboCondVenta.Text = "Cheque" Then
                btnEditarMedioPago.Enabled = True
            Else
                btnEditarMedioPago.Enabled = False
            End If


            If cboCondVenta.Text = "Cheque" Then
                Dim oDataSetCheque As New DataSet
                oDataSetCheque = objCheque.buscarChequesXidPago(codPago)
                If oDataSetCheque.Tables(0).Rows.Count > 0 Then
                    objCheque.emisor = oDataSetCheque.Tables(0).Rows(0).Item("emisor")
                    objCheque.fecha = oDataSetCheque.Tables(0).Rows(0).Item("fecha")
                    objCheque.idBanco = oDataSetCheque.Tables(0).Rows(0).Item("idBanco")
                    objCheque.idCheque = oDataSetCheque.Tables(0).Rows(0).Item("Id")
                    objCheque.idVenta = oDataSetCheque.Tables(0).Rows(0).Item("idVenta")
                    objCheque.monto = oDataSetCheque.Tables(0).Rows(0).Item("monto")
                    objCheque.nroCheque = oDataSetCheque.Tables(0).Rows(0).Item("nroCheque")
                    objCheque.vtoCheque = oDataSetCheque.Tables(0).Rows(0).Item("vencimiento")
                    txtObservaciones.Text = "Datos del Cheque: " & vbNewLine & "Emisor: " & oDataSetCheque.Tables(0).Rows(0).Item("emisor") & vbNewLine & "Fecha Vto: " & FormatDateTime(oDataSetCheque.Tables(0).Rows(0).Item("vencimiento"), DateFormat.ShortDate) & vbNewLine & "Importe: $ " & oDataSetCheque.Tables(0).Rows(0).Item("monto")

                End If
            End If

            '


            tssBorrar.Enabled = True
            tssModificar.Enabled = True
            tssNuevo.Enabled = False
            txtImporte.Enabled = False
            btnImprimir.Enabled = True
            Me.btnCancelar.Enabled = True
            btnGuardar.Enabled = False

        Else
            'Proveedores
            InitializeComponent()
            Dim oDataSet As New DataSet
            Dim objProveedores As New Proveedores
            codPago = idPago
            oDataSet = objProveedores.buscarPagosProveedoresXid(idPago)

            Me.dtpFechaAlta.Text = oDataSet.Tables(0).Rows(0).Item("fecha_pago")
            Me.txtReciboNumero.Text = Me.generarNumeroRecibo(oDataSet.Tables(0).Rows(0).Item("idPago"))
            codProveedor = oDataSet.Tables(0).Rows(0).Item("idProveedor")
            Dim oDataSetProveedor As New DataSet
            Dim objProveedor As New Proveedores
            oDataSetProveedor = objProveedor.buscarProveedor(codProveedor)
            txtRazonSocialCliente.Text = oDataSetProveedor.Tables(0).Rows(0).Item("razon_social")
            Me.txtImporte.Text = oDataSet.Tables(0).Rows(0).Item("importe")

            tssBorrar.Enabled = True
            tssModificar.Enabled = True
            tssNuevo.Enabled = False
            txtImporte.Enabled = False
            btnImprimir.Enabled = True
            Me.btnCancelar.Enabled = True
            btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim frmRecibo As New frmRecibo(codPago)
        frmRecibo.ShowDialog()
    End Sub


    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
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

    Private Sub cboCondVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCondVenta.SelectedIndexChanged
        'If accion = "" Then
        'Else
        '    If cboCondVenta.Text = "Tarjeta" Then
        '        'Me.cboTipoTarjeta.Enabled = True
        '        'Me.txtNroCupon.Enabled = True
        '        btnEditarMedioPago.Enabled = False
        '    ElseIf cboCondVenta.Text = "Cheque" Then
        '        btnEditarMedioPago.Enabled = True


        '    Else
        '        'Me.cboTipoTarjeta.Enabled = False
        '        'Me.txtNroCupon.Enabled = False
        '        'Me.txtRecargo.Text = 0
        '        'Me.cboTipoTarjeta.SelectedIndex = -1
        '        'Me.txtNroCupon.Text = ""
        '        Me.txtObservaciones.Text = ""
        '        btnEditarMedioPago.Enabled = False
        '    End If
        'End If
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
                'Me.Label16.Visible = True
                Me.txtNroCupon.Visible = True
                Me.cboBanco.Visible = False
                Me.cboBanco.SelectedIndex = -1
                Me.btnEditarMedioPago.Enabled = False
                Me.txtObservaciones.Text = ""
                'Me.txtRecargo.Visible = True
            ElseIf cboCondVenta.Text = "Cheque" Then
                btnEditarMedioPago.Enabled = True
                Me.cboTipoTarjeta.Visible = False
                Me.Label32.Visible = False
                Me.Label28.Visible = False
                Me.txtNroCupon.Visible = False
                Me.cboBanco.Visible = False
                Me.txtRecargo.Visible = False
                Me.Label16.Visible = False
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
                Me.txtRecargo.Visible = False
                Me.Label16.Visible = False
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
                Me.txtRecargo.Visible = False
                Me.Label16.Visible = False
            End If
        End If
    End Sub

    Private Sub btnEditarMedioPago_Click(sender As Object, e As EventArgs) Handles btnEditarMedioPago.Click
        Try
            If objCheque.emisor <> "" Then

                Dim frmRegistrarCheque As New frmRegistrarCheque(objCheque)
                frmRegistrarCheque.objCheque = objCheque
                frmRegistrarCheque.ShowDialog()
                objCheque = frmRegistrarCheque.objCheque
                txtObservaciones.Text = "Datos del Cheque: " & vbNewLine & "Emisor: " & objCheque.emisor & vbNewLine & "Fecha Vto: " & FormatDateTime(objCheque.vtoCheque, DateFormat.ShortDate) & vbNewLine & "Importe: $ " & objCheque.monto
                txtImporte.Text = objCheque.monto
                'MsgBox(objCheque.idPago)
            Else
                Dim frmRegistrarCheque As New frmRegistrarCheque
                frmRegistrarCheque.ShowDialog()
                objCheque = frmRegistrarCheque.objCheque
                If objCheque.monto.ToString = "0" Then
                    cboCondVenta.SelectedIndex = 0
                End If
                txtObservaciones.Text = "Datos del Cheque: " & vbNewLine & "Emisor: " & objCheque.emisor & vbNewLine & "Fecha Vto: " & FormatDateTime(objCheque.vtoCheque, DateFormat.ShortDate) & vbNewLine & "Importe: $ " & objCheque.monto
                txtImporte.Text = objCheque.monto
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub llenarComboCondicionVenta()
        Dim objCondicionVenta As New CondicionVenta
        Dim oDataSet As New DataSet
        oDataSet = objCondicionVenta.buscarCondicionVenta
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboCondVenta.DataSource = oDataSet.Tables(0)
            Me.cboCondVenta.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboCondVenta.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboCondVenta.SelectedIndex = 0
        End If
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

    Private Sub cboTipoTarjeta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoTarjeta.SelectedIndexChanged
        Try
            Dim objVentas As New Ventas
            Dim oDataSet As New DataSet
            oDataSet = objVentas.buscarTarjetasVenta(Me.cboTipoTarjeta.SelectedValue)
            Me.txtRecargo.Text = Replace(oDataSet.Tables(0).Rows(0).Item("porcRecargo"), ".", ",")
        Catch ex As Exception

        End Try
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

End Class