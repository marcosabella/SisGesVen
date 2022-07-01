Public Class frmCliente
    Dim accion As String
    Dim codigoActividad As Integer
    Dim idCliente As Integer
    Public nuevoCliente As Integer
    Dim estadoCliente As String

    Private Sub tssBtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmBuscarActividad As New frmBuscarActividades
        frmBuscarActividad.ShowDialog()
        Dim objAFIP As New AFIP
        If frmBuscarActividad.codigoActividad <> 0 Then
            ' Me.txtActividadAFIP.Text = objAFIP.buscarActividadXcodigo(frmBuscarActividad.codigoActividad).Tables(0).Rows(0).Item(1).ToString
            Me.codigoActividad = frmBuscarActividad.codigoActividad
            'Me.btnAgregarActividad.Focus()
        End If
    End Sub

    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AFIPDataSet.Localidades' Puede moverla o quitarla según sea necesario.
        If estadoCliente = "nuevoCliente" Then

        Else
            Me.bloquearControles()
            Me.inicializarControles()
        End If

        'Me.llenarComboProvincias()
        Me.llenarComboLocalidad()
        Me.llenarComboIva()
        ' cargo la lista de items para el autocomplete dle combobox



    End Sub

    'Private Sub llenarComboProvincias()
    '    Dim objAFIP As New AFIP
    '    Dim oDataSet As New DataSet
    '    oDataSet = objAFIP.buscarProvincias
    '    If oDataSet.Tables(0).Rows.Count <> 0 Then
    '        Me.cboProvincias.DataSource = oDataSet.Tables(0)
    '        Me.cboProvincias.DisplayMember = oDataSet.Tables(0).Columns(2).Caption.ToString
    '        Me.cboProvincias.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
    '        Me.cboProvincias.SelectedIndex = -1
    '    End If
    'End Sub

    Private Sub llenarComboLocalidad()


        Dim objAFIP As New AFIP
        'Dim oDataSet As New DataSet
        'Dim coleccion As New AutoCompleteStringCollection()

        'oDataSet = objAFIP.buscarLocalidad

        'If oDataSet.Tables(0).Rows.Count <> 0 Then
        '    Me.cboLocalidad.DataSource = oDataSet.Tables(0)
        '    Me.cboLocalidad.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
        '    Me.cboLocalidad.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
        '    'Me.cboProvincias.SelectedIndex = -1
        'End If

        ''recorrer y cargar los items para el autocompletado
        'For Each row As DataRow In oDataSet.Tables(0).Rows
        '    coleccion.Add(Convert.ToString(row("Nombre")))
        'Next

        'cboLocalidad.AutoCompleteCustomSource = coleccion
        'cboLocalidad.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'cboLocalidad.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Me.cboLocalidad.SelectedIndex = -1

        Dim objLocalidades As New Localidades
        Dim oDataSet As New DataSet
        Dim coleccion As New AutoCompleteStringCollection()

        oDataSet = objLocalidades.buscarLocalidad

        'If oDataSet.Tables(0).Rows.Count <> 0 Then
        '    Me.cboLocalidad.DataSource = oDataSet.Tables(0)
        '    Me.cboLocalidad.DisplayMember = oDataSet.Tables(0).Columns(2).Caption.ToString
        '    Me.cboLocalidad.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
        '    'Me.cboProvincias.SelectedIndex = -1
        'End If

        'recorrer y cargar los items para el autocompletado
        For Each row As DataRow In oDataSet.Tables(0).Rows
            coleccion.Add(Convert.ToString(row("Nombre")))
        Next
        Me.txtLocalidad.AutoCompleteCustomSource = coleccion
        'cboLocalidad.AutoCompleteCustomSource = coleccion
        'cboLocalidad.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'cboLocalidad.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Me.cboLocalidad.SelectedIndex = -1

    End Sub

    Private Sub llenarComboIva()
        Dim objAFIP As New AFIP
        Dim oDataSet As New DataSet


        oDataSet = objAFIP.buscarCondIva



        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboIva.DataSource = oDataSet.Tables(0)
            Me.cboIva.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboIva.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            'Me.cboProvincias.SelectedIndex = -1
        End If


        Me.cboIva.SelectedIndex = -1
    End Sub

    Private Sub cboLocalidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLocalidad.SelectedIndexChanged
        Try
            Dim objAfip As New AFIP
            Dim idPartido As Integer
            Dim idProvincia As Integer
            idPartido = objAfip.buscarLocalidadXid(cboLocalidad.SelectedValue).Tables(0).Rows(0).Item("idPartido")
            idProvincia = objAfip.buscarLocalidadXid(cboLocalidad.SelectedValue).Tables(0).Rows(0).Item("idProvincia")
            Me.txtPartido.Text = objAfip.buscarDptoXLocalidad(idPartido).Tables(0).Rows(0).Item("Nombre").ToString
            Me.txtProvincia.Text = objAfip.buscarProvinciasXid(idProvincia).Tables(0).Rows(0).Item("Nombre").ToString
            Me.txtCodigoPostal.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub inicializarControles()
        alerta.Clear()
        grupoNombre.Enabled = False
        grupoDomicilio.Enabled = False
        grupoFiscal.Enabled = False
        Me.lstDomicilio.Rows.Clear()
        ' grupoActividades.Enabled = False
        ' grupoBanco.Enabled = False
        ' grupoFiscal.Enabled = False
        ' grupoResponsables.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.tssBtnConsultar.Enabled = True
        Me.tssBtnEliminar.Enabled = False
        Me.tssBtnModificar.Enabled = False
        Me.tssBtnNuevo.Enabled = True
        Me.btnAgregarDomicilio.Enabled = False
        Me.btnEliminarDomicilio.Enabled = False
        ' Me.txtActividadAFIP.Text = ""
        Me.txtApellido.Text = ""
        Me.txtApellidoMaterno.Text = ""
        Me.txtCalle.Text = ""
        ' Me.txtCBU.Text = ""
        Me.txtCodigoPostal.Text = ""
        Me.txtCuit.Text = ""
        ' Me.txtDniResponsable.Text = ""
        Me.txtDpto.Text = ""
        Me.txtManzana.Text = ""
        Me.txtNombre.Text = ""
        ' Me.txtNombreResponsable.Text = ""
        Me.txtNumero.Text = ""
        Me.txtPartido.Text = ""
        Me.txtPiso.Text = ""
        Me.txtProvincia.Text = ""
        Me.txtSector.Text = ""
        Me.txtTorre.Text = ""
        Me.dtpFecha.Value = Now
        Me.txtLocalidad.Text = ""
        Me.txtMail.Text = ""
        'Me.cboLocalidad.SelectedIndex = -1
        'Me.cboMes.SelectedIndex = -1
        ' Me.cboPais.SelectedIndex = -1
        Me.cboIva.SelectedIndex = -1
        'Me.lstCBU.Rows.Clear()
        'Me.lstResponsable.Rows.Clear()
        'Me.lstDomicilio.Rows.Clear()
        ' Me.lstActividad.Rows.Clear()


        Me.accion = ""
    End Sub

    Private Sub activarControles()
        grupoNombre.Enabled = True
        grupoDomicilio.Enabled = True
        'grupoActividades.Enabled = True
        'grupoBanco.Enabled = True
        grupoFiscal.Enabled = True
        'grupoResponsables.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.tssBtnConsultar.Enabled = False
        Me.tssBtnEliminar.Enabled = False
        Me.tssBtnModificar.Enabled = False
        Me.tssBtnNuevo.Enabled = False
        Me.pestanas.SelectedIndex = 0
        Me.opFísica.Checked = True
        ' Me.opPrincipal.Checked = True
        Me.opFiscal.Checked = True
        Me.txtNombre.Focus()

        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = True
        Me.tssBtnConsultar.Enabled = True
        Me.tssBtnEliminar.Enabled = True
        Me.tssBtnModificar.Enabled = True
        Me.tssBtnNuevo.Enabled = False

        ' Me.txtActividadAFIP.ReadOnly = False
        Me.txtApellido.ReadOnly = False
        Me.txtApellidoMaterno.ReadOnly = False
        Me.txtCalle.ReadOnly = False
        ' Me.txtCBU.ReadOnly = False
        Me.txtCodigoPostal.ReadOnly = False
        Me.txtCuit.ReadOnly = False
        ' Me.txtDniResponsable.ReadOnly = False
        Me.txtDpto.ReadOnly = False
        Me.txtManzana.ReadOnly = False
        Me.txtNombre.ReadOnly = False
        ' Me.txtNombreResponsable.ReadOnly = False
        Me.txtNumero.ReadOnly = False
        Me.txtPartido.ReadOnly = False
        Me.txtPiso.ReadOnly = False
        Me.txtProvincia.ReadOnly = False
        Me.txtSector.ReadOnly = False
        Me.txtTorre.ReadOnly = False
        Me.dtpFecha.Enabled = True
        Me.cboLocalidad.Enabled = True
        Me.cboIva.Enabled = True
        Me.txtMail.ReadOnly = False
        ' Me.cboMes.Enabled = True
        ' Me.cboPais.Enabled = True

        Me.opFiscal.Enabled = True
        Me.opFísica.Enabled = True
        Me.opJurídica.Enabled = True
        Me.opOtro.Enabled = True
        ' Me.opPrincipal.Enabled = True
        ' Me.opSecundaria.Enabled = True
        Me.btnAgregarDomicilio.Enabled = True
        Me.btnEliminarDomicilio.Enabled = True

        Me.txtLocalidad.Enabled = True        'Me.ckEmpresa.Enabled = True
    End Sub

    Private Sub bloquearControles()
        grupoNombre.Enabled = True
        grupoDomicilio.Enabled = True
        ' grupoActividades.Enabled = True
        'grupoBanco.Enabled = True
        grupoFiscal.Enabled = True
        ' grupoResponsables.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = True
        Me.tssBtnConsultar.Enabled = True
        Me.tssBtnEliminar.Enabled = True
        Me.tssBtnModificar.Enabled = True
        Me.tssBtnNuevo.Enabled = False

        ' Me.txtActividadAFIP.ReadOnly = True
        Me.txtApellido.ReadOnly = True
        Me.txtApellidoMaterno.ReadOnly = True
        Me.txtCalle.ReadOnly = True
        Me.txtMail.ReadOnly = True
        ' Me.txtCBU.ReadOnly = True
        Me.txtCodigoPostal.ReadOnly = True
        Me.txtCuit.ReadOnly = True
        ' Me.txtDniResponsable.ReadOnly = True
        Me.txtDpto.ReadOnly = True
        Me.txtManzana.ReadOnly = True
        Me.txtNombre.ReadOnly = True
        ' Me.txtNombreResponsable.ReadOnly = True
        Me.txtNumero.ReadOnly = True
        Me.txtPartido.ReadOnly = True
        Me.txtPiso.ReadOnly = True
        Me.txtProvincia.ReadOnly = True
        Me.txtSector.ReadOnly = True
        Me.txtTorre.ReadOnly = True
        Me.dtpFecha.Enabled = False
        Me.cboLocalidad.Enabled = False
        'Me.cboMes.Enabled = False
        Me.cboIva.Enabled = False
        ' Me.cboPais.Enabled = False

        Me.opFiscal.Enabled = False
        Me.opFísica.Enabled = False
        Me.opJurídica.Enabled = False
        Me.opOtro.Enabled = False
        ' Me.opPrincipal.Enabled = False
        ' Me.opSecundaria.Enabled = False

        Me.dtpFecha.Enabled = False

        ' Me.ckEmpresa.Enabled = False

        ' Me.btnAgregarActividad.Enabled = False
        'Me.btnAgregarCBU.Enabled = False
        Me.btnAgregarDomicilio.Enabled = False
        'Me.btnAgregarResponsable.Enabled = False
        'Me.btnBorrarActividad.Enabled = False
        ' Me.btnBorrarCBU.Enabled = False
        ' Me.btnBorrarResponsable.Enabled = False
        Me.btnEliminarDomicilio.Enabled = False
        ' Me.btnBuscarActividad.Enabled = False
        Me.txtLocalidad.Enabled = False

    End Sub

    Private Sub desbloquearControles()
        'grupoNombre.Enabled = True
        'grupoDomicilio.Enabled = True
        'grupoActividades.Enabled = True
        'grupoBanco.Enabled = True
        'grupoFiscal.Enabled = True
        'grupoResponsables.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.tssBtnConsultar.Enabled = False
        Me.tssBtnEliminar.Enabled = False
        Me.tssBtnModificar.Enabled = False
        Me.tssBtnNuevo.Enabled = False

        ' Me.txtActividadAFIP.ReadOnly = False
        Me.txtApellido.ReadOnly = False
        Me.txtApellidoMaterno.ReadOnly = False
        Me.txtCalle.ReadOnly = False
        ' Me.txtCBU.ReadOnly = False
        Me.txtCodigoPostal.ReadOnly = False
        Me.txtCuit.ReadOnly = False
        'Me.txtDniResponsable.ReadOnly = False
        Me.txtDpto.ReadOnly = False
        Me.txtManzana.ReadOnly = False
        Me.txtNombre.ReadOnly = False
        ' Me.txtNombreResponsable.ReadOnly = False
        Me.txtMail.ReadOnly = False
        Me.txtNumero.ReadOnly = False
        Me.txtPartido.ReadOnly = False
        Me.txtPiso.ReadOnly = False
        Me.txtProvincia.ReadOnly = False
        Me.txtSector.ReadOnly = False
        Me.txtTorre.ReadOnly = False
        Me.dtpFecha.Enabled = False
        Me.cboLocalidad.Enabled = True
        ' Me.cboMes.Enabled = True
        Me.cboIva.Enabled = True
        ' Me.cboPais.Enabled = True

        Me.opFiscal.Enabled = True
        Me.opFísica.Enabled = True
        Me.opJurídica.Enabled = True
        Me.opOtro.Enabled = True
        ''Me.opPrincipal.Enabled = True
        ' Me.opSecundaria.Enabled = True

        dtpFecha.Enabled = True

        'Me.ckEmpresa.Enabled = True

        'Me.btnAgregarActividad.Enabled = True
        ' Me.btnAgregarCBU.Enabled = True
        Me.btnAgregarDomicilio.Enabled = True
        ' Me.btnAgregarResponsable.Enabled = True
        ' Me.btnBorrarActividad.Enabled = True
        ' Me.btnBorrarCBU.Enabled = True
        ' Me.btnBorrarResponsable.Enabled = True
        Me.btnEliminarDomicilio.Enabled = True
        ' Me.btnBuscarActividad.Enabled = True
        Me.txtLocalidad.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If estadoCliente = "nuevoCliente" Then
            Me.Close()
        End If
        Me.bloquearControles()
        Me.inicializarControles()

    End Sub

    Private Sub tssBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBtnNuevo.Click

        Me.inicializarControles()
        Me.activarControles()
        Me.tssBtnNuevo.Enabled = False
        Me.tssBtnEliminar.Enabled = False
        Me.tssBtnModificar.Enabled = False
        Me.tssBtnConsultar.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.accion = "nuevo"
        Me.txtCuit.Text = "00000000000"
        Me.cboIva.SelectedIndex = 1
    End Sub

    Private Sub opFísica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opFísica.CheckedChanged
        If opFísica.Checked = True Then
            Me.txtApellido.Enabled = True
            Me.txtApellidoMaterno.Enabled = True
            Me.lblFecha.Text = "Fecha Nacimiento"
        ElseIf opJurídica.Enabled = True Then
            Me.txtApellido.Enabled = False
            Me.txtApellidoMaterno.Enabled = True
            Me.lblFecha.Text = "Fecha Alta"
        End If
        Me.txtNombre.Focus()

    End Sub

    Private Sub opJurídica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opJurídica.CheckedChanged
        If opFísica.Checked = True Then
            Me.txtApellido.Enabled = True
            Me.txtApellidoMaterno.Enabled = True
            Me.lblFecha.Text = "Fecha Nacimiento"
        ElseIf opJurídica.Enabled = True Then
            Me.txtApellido.Enabled = False
            Me.txtApellidoMaterno.Enabled = True
            Me.lblFecha.Text = "Fecha Alta"
        End If
        Me.txtNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim estadoAlerta As Integer
        estadoAlerta = 0
        alerta.Clear()

        If Me.txtNombre.Text = "" Then
            alerta.SetError(Me.txtNombre, "Ingrese el nombre del cliente")
            estadoAlerta = 1

        End If
        'If lstDomicilio.RowCount = 0 Then
        '    alerta.SetError(Me.lstDomicilio, "Ingrese un domicilio")
        '    estadoAlerta = 1
        'End If
        If opFísica.Checked = True And opJurídica.Checked = False Then
            If Me.txtApellido.Text = "" Then
                alerta.SetError(Me.txtApellido, "Ingrese el apellido")
                estadoAlerta = 1
            End If
        End If
            If opJurídica.Checked = True Then
            If Me.txtCuit.Text = "" Then
                alerta.SetError(Me.txtCuit, "Ingrese el CUIT")
                estadoAlerta = 1
            End If
            If Me.cboIva.SelectedIndex = -1 Then
                alerta.SetError(Me.cboIva, "Ingrese situación fiscal")
                estadoAlerta = 1
            End If
        End If
        If estadoAlerta = 1 Then
            Exit Sub
        End If

        'paso la validación
        If estadoAlerta = 0 Then
            Dim objCliente As New Clientes
            If accion = "nuevo" Then
                If Me.guardarNuevoCliente() = True Then
                    Dim idCliente As Integer

                    idCliente = objCliente.buscarUltimoCliente.Tables(0).Rows(0).Item(0)
                    Me.guardarNuevoDomicilioXcliente(idCliente)
                    nuevoCliente = 1
                    'Me.guardarNuevaActividadXcliente(idCliente)
                    'Me.guardarNuevaClaveBancariaXcliente(idCliente)
                    'Me.guardarNuevoResponsableXcliente(idCliente)
                End If
            ElseIf accion = "modificar" Then
                If Me.modificarCliente() = True Then
                    'objCliente.borrarActividadesXcliente(idCliente)
                    'objCliente.borrarClavesXcliente(idCliente)
                    objCliente.borrarDomicilioXcliente(idCliente)
                    'objCliente.borrarResponsableXcliente(idCliente)
                    Me.guardarNuevoDomicilioXcliente(idCliente)
                    ' Me.guardarNuevaActividadXcliente(idCliente)
                    ' Me.guardarNuevaClaveBancariaXcliente(idCliente)
                    'Me.guardarNuevoResponsableXcliente(idCliente)

                End If
            End If
            Me.bloquearControles()
            Me.inicializarControles()
        End If





    End Sub

    Private Sub btnAgregarDomicilio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDomicilio.Click

        Me.lstDomicilio.Rows.Add()
        If opFiscal.Checked = True Then
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(0).Value = 0
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(1).Value = "Fiscal"
        Else
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(0).Value = 1
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(1).Value = "Otro"
        End If
        Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(2).Value = Me.txtCalle.Text
        Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(3).Value = Me.txtNumero.Text
        Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(4).Value = Me.txtSector.Text
        Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(5).Value = Me.txtTorre.Text
        Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(6).Value = Me.txtPiso.Text
        Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(7).Value = Me.txtDpto.Text
        Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(8).Value = Me.txtManzana.Text
        Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(9).Value = Me.txtLocalidad.Text
        Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(10).Value = Me.txtLocalidad.Text
        Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(11).Value = Me.txtCodigoPostal.Text

        Me.txtCalle.Text = ""
        Me.txtCodigoPostal.Text = ""
        Me.txtDpto.Text = ""
        Me.txtManzana.Text = ""
        Me.txtNumero.Text = ""
        Me.txtPartido.Text = ""
        Me.txtPiso.Text = ""
        Me.txtProvincia.Text = ""
        Me.txtSector.Text = ""
        Me.txtTorre.Text = ""
        'Me.cboLocalidad.SelectedIndex = -1
        Me.txtLocalidad.Text = ""
    End Sub

    Private Sub btnAgregarActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.lstActividad.Rows.Add()
        'If opPrincipal.Checked = True Then
        '    Me.lstActividad.Rows(lstActividad.Rows.Count - 1).Cells(4).Value = 0
        '    Me.lstActividad.Rows(lstActividad.Rows.Count - 1).Cells(1).Value = "Principal"
        'ElseIf opSecundaria.Checked = True Then
        '    Me.lstActividad.Rows(lstActividad.Rows.Count - 1).Cells(4).Value = 1
        '    Me.lstActividad.Rows(lstActividad.Rows.Count - 1).Cells(1).Value = "Secundaria"
        'End If
        'Me.lstActividad.Rows(lstActividad.Rows.Count - 1).Cells(2).Value = Me.codigoActividad
        'Me.lstActividad.Rows(lstActividad.Rows.Count - 1).Cells(3).Value = Me.txtActividadAFIP.Text
        'Me.txtActividadAFIP.Text = ""
    End Sub

    Private Sub btnBorrarActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If lstActividad.Rows.Count > 0 Then
        '    If MsgBox("Desea eliminar Item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

        '        lstActividad.Rows.Remove(lstActividad.CurrentRow())
        '    End If
        'End If
    End Sub

    Private Sub lstActividad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If lstActividad.Rows.Count > 0 Then
        '    If MsgBox("Desea eliminar Item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

        '        lstActividad.Rows.Remove(lstActividad.CurrentRow())
        '    End If
        'End If
    End Sub

    Private Sub lstDomicilio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstDomicilio.KeyDown
        If e.KeyCode = Keys.Delete Then
            If lstDomicilio.Rows.Count > 0 Then
                If MsgBox("Desea eliminar Item?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then

                    lstDomicilio.Rows.Remove(lstDomicilio.CurrentRow())
                End If
            End If
        End If
    End Sub

    Private Sub btnEliminarDomicilio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDomicilio.Click
        If lstDomicilio.Rows.Count > 0 Then
            If MsgBox("Desea eliminar Item?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then

                lstDomicilio.Rows.Remove(lstDomicilio.CurrentRow())
            End If
        End If
    End Sub

    Private Sub btnAgregarCBU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.lstCBU.Rows.Add()
        'Me.lstCBU.Rows(lstCBU.Rows.Count - 1).Cells(0).Value = Me.txtCBU.Text
        'Me.txtCBU.Text = ""
    End Sub

    Private Sub btnBorrarCBU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If lstCBU.Rows.Count > 0 Then
        '    If MsgBox("Desea eliminar Item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

        '        lstCBU.Rows.Remove(lstCBU.CurrentRow())
        '    End If
        'End If
    End Sub

    Private Sub lstCBU_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Delete Then
        '    If lstCBU.Rows.Count > 0 Then
        '        If MsgBox("Desea eliminar Item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

        '            lstCBU.Rows.Remove(lstCBU.CurrentRow())
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub btnAgregarResponsable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.lstResponsable.Rows.Add()
        'Me.lstResponsable.Rows(lstResponsable.Rows.Count - 1).Cells(1).Value = Me.txtDniResponsable.Text
        'Me.lstResponsable.Rows(lstResponsable.Rows.Count - 1).Cells(2).Value = Me.txtNombreResponsable.Text
        'Me.lstResponsable.Rows(lstResponsable.Rows.Count - 1).Cells(3).Value = Me.cboPais.Text

        'Me.txtDniResponsable.Text = ""
        'Me.txtNombreResponsable.Text = ""
        'Me.cboPais.SelectedIndex = -1
    End Sub

    Private Sub btnBorrarResponsable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If lstResponsable.Rows.Count > 0 Then
        '    If MsgBox("Desea eliminar Item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

        '        lstResponsable.Rows.Remove(lstResponsable.CurrentRow())
        '    End If
        'End If
    End Sub

    Private Sub lstResponsable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If lstResponsable.Rows.Count > 0 Then
        '    If MsgBox("Desea eliminar Item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

        '        lstResponsable.Rows.Remove(lstResponsable.CurrentRow())
        '    End If
        'End If
    End Sub

    Private Sub tssBtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBtnConsultar.Click
        Dim min As Integer = 0

        Dim frmBuscarCliente As New frmBuscarCliente
        frmBuscarCliente.ShowDialog()
        If frmBuscarCliente.idClienteBusqueda <> 0 Then
            Me.inicializarControles()
            idCliente = frmBuscarCliente.idClienteBusqueda
            Me.pestanas.SelectedIndex = 0
            Me.recuperarDatosCliente()
            Me.recuperarDomicilioCliente()
            Me.recuperarActividadesCliente()
            Me.recuperarClavesBancarias()
            Me.recuperarResponsable()
            Me.bloquearControles()
        End If
    End Sub

    Private Sub lstActividad_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Try
        '    Dim oDataSet As New DataSet
        '    Dim objCliente As New Clientes
        '    Dim objAFIP As New AFIP
        '    oDataSet = objCliente.buscarActividadesXidActividad(Me.lstActividad.CurrentRow.Cells(0).Value.ToString)
        '    If oDataSet.Tables(0).Rows.Count > 0 Then
        '        Me.txtActividadAFIP.Text = objAFIP.buscarActividadXcodigo(oDataSet.Tables(0).Rows(0).Item("idCodigo_actividad")).Tables(0).Rows(0).Item("descripcion")
        '        If oDataSet.Tables(0).Rows(0).Item("idTipo_actividad") = 0 Then
        '            opPrincipal.Checked = True
        '        Else
        '            opSecundaria.Checked = True
        '        End If
        '    Else

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub lstActividad_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Try
        '    Dim oDataSet As New DataSet
        '    Dim objCliente As New Clientes
        '    Dim objAFIP As New AFIP
        '    oDataSet = objCliente.buscarActividadesXidActividad(Me.lstActividad.CurrentRow.Cells(0).Value.ToString)
        '    If oDataSet.Tables(0).Rows.Count > 0 Then
        '        Me.txtActividadAFIP.Text = objAFIP.buscarActividadXcodigo(oDataSet.Tables(0).Rows(0).Item("idCodigo_actividad")).Tables(0).Rows(0).Item("descripcion")
        '        If oDataSet.Tables(0).Rows(0).Item("idTipo_actividad") = 0 Then
        '            opPrincipal.Checked = True
        '        Else
        '            opSecundaria.Checked = True
        '        End If
        '    Else

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub lstDomicilio_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles lstDomicilio.CellContentClick
        Try
            'Dim oDataSet As New DataSet
            'Dim objCliente As New Clientes
            'Dim objAFIP As New AFIP
            'oDataSet = objCliente.buscarDomicilioXidDomicilio(Me.lstDomicilio.CurrentRow.Cells(12).Value.ToString)
            'If oDataSet.Tables(0).Rows.Count > 0 Then
            '    Me.txtCalle.Text = oDataSet.Tables(0).Rows(0).Item("calle")
            '    Me.txtNumero.Text = oDataSet.Tables(0).Rows(0).Item("numero")
            '    Me.txtSector.Text = oDataSet.Tables(0).Rows(0).Item("sector")
            '    Me.txtTorre.Text = oDataSet.Tables(0).Rows(0).Item("torre")
            '    Me.txtPiso.Text = oDataSet.Tables(0).Rows(0).Item("piso")
            '    Me.txtManzana.Text = oDataSet.Tables(0).Rows(0).Item("manzana")
            '    Me.txtCodigoPostal.Text = oDataSet.Tables(0).Rows(0).Item("cp")
            '    Me.txtDpto.Text = oDataSet.Tables(0).Rows(0).Item("dpto")
            '    If oDataSet.Tables(0).Rows(0).Item("idTipo_domicilio") = 0 Then
            '        opFiscal.Checked = True
            '    Else
            '        opOtro.Checked = True
            '    End If
            '    'Me.cboLocalidad.Text = objAFIP.buscarLocalidadXid(oDataSet.Tables(0).Rows(0).Item("idLocalidad")).Tables(0).Rows(0).Item("Nombre")
            'Else

            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstDomicilio_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDomicilio.SelectionChanged
        Try
            Dim oDataSet As New DataSet
            Dim objCliente As New Clientes
            Dim objAFIP As New AFIP
            oDataSet = objCliente.buscarDomicilioXidDomicilio(Me.lstDomicilio.CurrentRow.Cells(12).Value.ToString)
            If oDataSet.Tables(0).Rows.Count > 0 Then
                Me.txtCalle.Text = oDataSet.Tables(0).Rows(0).Item("calle")
                Me.txtNumero.Text = oDataSet.Tables(0).Rows(0).Item("numero")
                Me.txtSector.Text = oDataSet.Tables(0).Rows(0).Item("sector")
                Me.txtTorre.Text = oDataSet.Tables(0).Rows(0).Item("torre")
                Me.txtPiso.Text = oDataSet.Tables(0).Rows(0).Item("piso")
                Me.txtManzana.Text = oDataSet.Tables(0).Rows(0).Item("manzana")
                Me.txtCodigoPostal.Text = oDataSet.Tables(0).Rows(0).Item("cp")
                Me.txtDpto.Text = oDataSet.Tables(0).Rows(0).Item("dpto")
                If oDataSet.Tables(0).Rows(0).Item("idTipo_domicilio") = 0 Then
                    opFiscal.Checked = True
                Else
                    opOtro.Checked = True
                End If
                Me.cboLocalidad.Text = objAFIP.buscarLocalidadXid(oDataSet.Tables(0).Rows(0).Item("idLocalidad")).Tables(0).Rows(0).Item("Nombre")
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstCBU_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Try
        '    Dim oDataSet As New DataSet
        '    Dim objCliente As New Clientes
        '    oDataSet = objCliente.buscarClavesBancariasXidClave(Me.lstCBU.CurrentRow.Cells(1).Value.ToString)
        '    If oDataSet.Tables(0).Rows.Count > 0 Then
        '        Me.txtCBU.Text = oDataSet.Tables(0).Rows(0).Item("cbu")
        '    Else

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub lstCBU_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Try
        '    Dim oDataSet As New DataSet
        '    Dim objCliente As New Clientes
        '    oDataSet = objCliente.buscarClavesBancariasXidClave(Me.lstCBU.CurrentRow.Cells(1).Value.ToString)
        '    If oDataSet.Tables(0).Rows.Count > 0 Then
        '        Me.txtCBU.Text = oDataSet.Tables(0).Rows(0).Item("cbu")
        '    Else

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub lstResponsable_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Try
        '    Dim oDataSet As New DataSet
        '    Dim objCliente As New Clientes
        '    oDataSet = objCliente.buscarReponsableXidResponsable(Me.lstResponsable.CurrentRow.Cells(0).Value.ToString)
        '    If oDataSet.Tables(0).Rows.Count > 0 Then
        '        Me.txtDniResponsable.Text = oDataSet.Tables(0).Rows(0).Item("dni")
        '        Me.txtNombreResponsable.Text = oDataSet.Tables(0).Rows(0).Item("nombre")
        '        Me.cboPais.Text = oDataSet.Tables(0).Rows(0).Item("pais")
        '    Else

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub lstResponsable_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Try
        '    Dim oDataSet As New DataSet
        '    Dim objCliente As New Clientes
        '    oDataSet = objCliente.buscarReponsableXidResponsable(Me.lstResponsable.CurrentRow.Cells(0).Value.ToString)
        '    If oDataSet.Tables(0).Rows.Count > 0 Then
        '        Me.txtDniResponsable.Text = oDataSet.Tables(0).Rows(0).Item("dni")
        '        Me.txtNombreResponsable.Text = oDataSet.Tables(0).Rows(0).Item("nombre")
        '        Me.cboPais.Text = oDataSet.Tables(0).Rows(0).Item("pais")
        '    Else

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub tssBtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBtnModificar.Click

        Me.desbloquearControles()
        Me.pestanas.SelectedIndex = 0
        Me.accion = "modificar"
    End Sub

    Private Sub tssBtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBtnEliminar.Click
        Dim objCliente As New Clientes
        If MsgBox("La siguiente acción eliminará el cliente " & Me.txtNombre.Text & " " & Me.txtApellido.Text & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
            objCliente.borrarCliente(Me.idCliente)
            objCliente.borrarActividadesXcliente(Me.idCliente)
            objCliente.borrarClavesXcliente(Me.idCliente)
            objCliente.borrarDomicilioXcliente(Me.idCliente)
            objCliente.borrarResponsableXcliente(Me.idCliente)
            Me.inicializarControles()
        Else


        End If
    End Sub

#Region "Acceso a datos"

    Private Function guardarNuevoCliente() As Boolean
        Dim objCliente As New Clientes
        objCliente.nombre = Me.txtNombre.Text
        objCliente.apellido = Me.txtApellido.Text
        objCliente.apellido_materno = Me.txtApellidoMaterno.Text
        objCliente.fecha_nacimiento = FormatDateTime(Me.dtpFecha.Value, DateFormat.ShortDate)
        objCliente.cuit = Me.txtCuit.Text
        objCliente.mes_cierre_ejercicio = ""
        objCliente.idCondIva = cboIva.SelectedValue
        objCliente.mail = Trim(LCase(Me.txtMail.Text))
        'If ckEmpresa.Checked = True Then
        '    objCliente.idActividad_promovida = 1
        'Else
        objCliente.idActividad_promovida = 0
        'End If
        If opJurídica.Checked = True Then
            objCliente.idTipo_persona = 1
        Else
            objCliente.idTipo_persona = 0
        End If

        If objCliente.nuevoCliente(objCliente) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub guardarNuevoDomicilioXcliente(ByVal idCliente As Integer)

        Dim objCliente As New Clientes

        Dim i As Integer
        i = 0

        objCliente.idCliente = idCliente
        If lstDomicilio.Rows.Count = 0 Then
            Exit Sub
        End If
        While i < Me.lstDomicilio.Rows.Count()
            objCliente.idTipo_domicilio = Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(0).Value

            objCliente.calle = Me.lstDomicilio.Rows(i).Cells(2).Value
            objCliente.numero = Me.lstDomicilio.Rows(i).Cells(3).Value
            objCliente.sector = Me.lstDomicilio.Rows(i).Cells(4).Value
            objCliente.torre = Me.lstDomicilio.Rows(i).Cells(5).Value
            objCliente.piso = Me.lstDomicilio.Rows(i).Cells(6).Value
            objCliente.dpto = Me.lstDomicilio.Rows(i).Cells(7).Value
            objCliente.manzana = Me.lstDomicilio.Rows(i).Cells(8).Value
            objCliente.localidad = Me.lstDomicilio.Rows(i).Cells(9).Value
            objCliente.cp = Me.lstDomicilio.Rows(i).Cells(11).Value
            objCliente.nuevoDomicilio_x_cliente(objCliente)
            i = i + 1
        End While





    End Sub
    Private Sub guardarNuevaActividadXcliente(ByVal idCliente As Integer)

        'Dim objCliente As New Clientes

        'Dim i As Integer
        'i = 0

        'objCliente.idCliente = idCliente
        'If lstActividad.Rows.Count = 0 Then
        '    Exit Sub
        'End If
        'While i < Me.lstActividad.Rows.Count()
        '    objCliente.idTipo_actividad = Me.lstActividad.Rows(i).Cells(4).Value

        '    objCliente.idCodigo_actividad = Me.lstActividad.Rows(i).Cells(2).Value
        '    objCliente.nuevoActividad_x_cliente(objCliente)
        '    i = i + 1
        'End While
    End Sub
    Private Sub guardarNuevaClaveBancariaXcliente(ByVal idCliente As Integer)

        'Dim objCliente As New Clientes

        'Dim i As Integer
        'i = 0

        'objCliente.idCliente = idCliente
        'If lstCBU.Rows.Count = 0 Then
        '    Exit Sub
        'End If
        'While i < Me.lstCBU.Rows.Count()
        '    objCliente.cbu = Me.lstCBU.Rows(i).Cells(0).Value
        '    objCliente.nuevaClaves_bancarias_x_cliente(objCliente)
        '    i = i + 1
        'End While
    End Sub
    Private Sub guardarNuevoResponsableXcliente(ByVal idCliente As Integer)
        'Dim i As Integer
        'i = 0
        'Dim objCliente As New Clientes
        'objCliente.idCliente = idCliente
        'If lstResponsable.Rows.Count = 0 Then
        '    Exit Sub
        'End If
        'While i < Me.lstResponsable.Rows.Count()
        '    objCliente.dniResponsable = Me.lstResponsable.Rows(i).Cells(1).Value
        '    objCliente.nombreResponsable = Me.lstResponsable.Rows(i).Cells(2).Value
        '    objCliente.pais = Me.lstResponsable.Rows(i).Cells(3).Value
        '    objCliente.nuevoResponsable_x_cliente(objCliente)
        '    i = i + 1
        'End While
    End Sub
    Private Sub recuperarDatosCliente()
        Dim objCliente As New Clientes
        Dim oDataSet As New DataSet
        Dim objAFIP As New AFIP
        oDataSet = objCliente.buscarClientesXid(idCliente)

        If oDataSet.Tables(0).Rows(0).Item("idTipo_persona") = 0 Then
            Me.opFísica.Checked = True
            Me.opJurídica.Checked = False
        Else
            Me.opFísica.Checked = False
            Me.opJurídica.Checked = True
        End If

        If objAFIP.buscarCondIvaXcodigo(oDataSet.Tables(0).Rows(0).Item("idIva")).Tables(0).Rows.Count = 0 Then

        Else
            Me.cboIva.Text = objAFIP.buscarCondIvaXcodigo(oDataSet.Tables(0).Rows(0).Item("idIva")).Tables(0).Rows(0).Item("descripcion")

        End If

        Me.txtNombre.Text = oDataSet.Tables(0).Rows(0).Item("nombre")
        Me.txtApellido.Text = oDataSet.Tables(0).Rows(0).Item("apellido")
        If IsDBNull((oDataSet.Tables(0).Rows(0).Item("apellido_materno"))) = False Then
            Me.txtApellidoMaterno.Text = CStr(oDataSet.Tables(0).Rows(0).Item("apellido_materno")).ToString

        End If
        If IsDBNull((oDataSet.Tables(0).Rows(0).Item("fecha_nacimiento"))) = False Then
            Me.dtpFecha.Value = oDataSet.Tables(0).Rows(0).Item("fecha_nacimiento")
        End If
        If IsDBNull(oDataSet.Tables(0).Rows(0).Item("cuit")) Then
            Me.txtCuit.Text = "00-00000000-0"
        Else
            Me.txtCuit.Text = oDataSet.Tables(0).Rows(0).Item("cuit")
        End If

        If oDataSet.Tables(0).Rows(0).Item("mail").ToString = "" Then
            Me.txtMail.Text = ""
        Else
            Me.txtMail.Text = oDataSet.Tables(0).Rows(0).Item("mail")
        End If

        'Me.cboMes.Text = oDataSet.Tables(0).Rows(0).Item("mes_cierre_ejercicio")

        'If oDataSet.Tables(0).Rows(0).Item("idActividad_promovida") = 1 Then
        '    Me.ckEmpresa.Checked = True
        'Else
        '    Me.ckEmpresa.Checked = False
        'End If
    End Sub
    Private Sub recuperarDomicilioCliente()
        Dim objCliente As New Clientes
        Dim objAFIP As New AFIP
        Dim odataset As New DataSet
        Dim i As Integer
        i = 0
        lstDomicilio.Rows.Clear()
        odataset = objCliente.buscarDomicilioXidCliente(idCliente)

        If odataset.Tables(0).Rows.Count = 0 Then
            Exit Sub
        End If
        While i < odataset.Tables(0).Rows.Count()
            lstDomicilio.Rows.Add()
            If odataset.Tables(0).Rows(i).Item("idTipo_domicilio") = 0 Then
                Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(1).Value = "Fiscal"
            Else
                Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(1).Value = "Otro"
            End If


            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(2).Value = odataset.Tables(0).Rows(i).Item("calle").ToString
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(3).Value = odataset.Tables(0).Rows(i).Item("numero").ToString
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(4).Value = odataset.Tables(0).Rows(i).Item("sector").ToString
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(5).Value = odataset.Tables(0).Rows(i).Item("torre").ToString
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(6).Value = odataset.Tables(0).Rows(i).Item("piso").ToString
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(7).Value = odataset.Tables(0).Rows(i).Item("dpto").ToString
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(8).Value = odataset.Tables(0).Rows(i).Item("manzana").ToString
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(9).Value = odataset.Tables(0).Rows(i).Item("localidad").ToString
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(10).Value = odataset.Tables(0).Rows(i).Item("localidad").ToString
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(11).Value = odataset.Tables(0).Rows(i).Item("cp").ToString
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(12).Value = odataset.Tables(0).Rows(i).Item("idDomicilio").ToString

            i = i + 1
        End While
    End Sub
    Private Sub recuperarActividadesCliente()
        'Dim objCliente As New Clientes
        'Dim objAFIP As New AFIP
        'Dim odataset As New DataSet
        'Dim i As Integer
        'i = 0

        'odataset = objCliente.buscarActividadesXidCliente(idCliente)

        'If odataset.Tables(0).Rows.Count = 0 Then
        '    Exit Sub
        'End If
        'While i < odataset.Tables(0).Rows.Count()
        '    Me.lstActividad.Rows.Add()
        '    Me.lstActividad.Rows(lstActividad.Rows.Count - 1).Cells(0).Value = odataset.Tables(0).Rows(i).Item("idActividad_x_cliente")
        '    If odataset.Tables(0).Rows(i).Item("idTipo_actividad") = 0 Then
        '        opPrincipal.Checked = True
        '        Me.lstActividad.Rows(lstActividad.Rows.Count - 1).Cells(4).Value = odataset.Tables(0).Rows(i).Item("idTipo_actividad")
        '        Me.lstActividad.Rows(lstActividad.Rows.Count - 1).Cells(1).Value = "Principal"
        '    Else
        '        opSecundaria.Checked = True
        '        Me.lstActividad.Rows(lstActividad.Rows.Count - 1).Cells(4).Value = odataset.Tables(0).Rows(i).Item("idTipo_actividad")
        '        Me.lstActividad.Rows(lstActividad.Rows.Count - 1).Cells(1).Value = "Secundaria"
        '    End If

        '    Me.lstActividad.Rows(lstActividad.Rows.Count - 1).Cells(2).Value = odataset.Tables(0).Rows(i).Item("idCodigo_actividad")
        '    Me.lstActividad.Rows(lstActividad.Rows.Count - 1).Cells(3).Value = objAFIP.buscarActividadXcodigo(odataset.Tables(0).Rows(i).Item("idCodigo_actividad")).Tables(0).Rows(0).Item("descripcion")
        '    i = i + 1
        'End While
    End Sub
    Private Sub recuperarClavesBancarias()
        'Dim objCliente As New Clientes
        'Dim odataset As New DataSet
        'Dim i As Integer
        'i = 0

        'odataset = objCliente.buscarClavesBancariasXidCliente(idCliente)
        'If odataset.Tables(0).Rows.Count = 0 Then
        '    Exit Sub
        'End If
        'While i < odataset.Tables(0).Rows.Count
        '    lstCBU.Rows.Add()
        '    Me.lstCBU.Rows(lstCBU.Rows.Count - 1).Cells(1).Value = odataset.Tables(0).Rows(i).Item("idClave_bancaria")
        '    Me.lstCBU.Rows(lstCBU.Rows.Count - 1).Cells(0).Value = odataset.Tables(0).Rows(i).Item("cbu")

        '    i = i + 1
        'End While
    End Sub
    Private Sub recuperarResponsable()
        'Dim objCliente As New Clientes
        'Dim odataset As New DataSet
        'Dim i As Integer
        'i = 0

        'odataset = objCliente.buscarReponsableXidCliente(idCliente)
        'If odataset.Tables(0).Rows.Count = 0 Then
        '    Exit Sub
        'End If
        'While i < odataset.Tables(0).Rows.Count
        '    lstResponsable.Rows.Add()
        '    Me.lstResponsable.Rows(lstResponsable.Rows.Count - 1).Cells(1).Value = odataset.Tables(0).Rows(i).Item("dni")
        '    Me.lstResponsable.Rows(lstResponsable.Rows.Count - 1).Cells(0).Value = odataset.Tables(0).Rows(i).Item("idResponsable")
        '    Me.lstResponsable.Rows(lstResponsable.Rows.Count - 1).Cells(2).Value = odataset.Tables(0).Rows(i).Item("nombre")
        '    Me.lstResponsable.Rows(lstResponsable.Rows.Count - 1).Cells(3).Value = odataset.Tables(0).Rows(i).Item("pais")
        '    i = i + 1
        'End While
    End Sub
    Private Function modificarCliente() As Boolean
        Dim objCliente As New Clientes
        objCliente.idCliente = Me.idCliente
        objCliente.idCondIva = cboIva.SelectedValue
        objCliente.fecha_nacimiento = FormatDateTime(Me.dtpFecha.Value, DateFormat.ShortDate)
        objCliente.cuit = Me.txtCuit.Text
        objCliente.mes_cierre_ejercicio = ""
        objCliente.mail = Trim(UCase(Me.txtMail.Text))
        'If ckEmpresa.Checked = True Then
        '    objCliente.idActividad_promovida = 1
        'Else
        objCliente.idActividad_promovida = 0
        ' End If
        If opJurídica.Checked = True Then
            objCliente.idTipo_persona = 1
            objCliente.nombre = Me.txtNombre.Text
            objCliente.apellido = ""
            objCliente.apellido_materno = ""

        Else
            objCliente.idTipo_persona = 0
            objCliente.nombre = Me.txtNombre.Text
            objCliente.apellido = Me.txtApellido.Text
            objCliente.apellido_materno = Me.txtApellidoMaterno.Text
        End If

        If objCliente.modificarCliente(objCliente) = True Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Validaciones"

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If opFísica.Checked = True Then
                Me.txtApellido.Focus()
            Else
                Me.dtpFecha.Focus()
            End If
        End If
    End Sub

    Private Sub txtApellido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellido.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtApellidoMaterno.Focus()
        End If
    End Sub

    Private Sub txtApellidoMaterno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoMaterno.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.dtpFecha.Focus()
        End If
    End Sub

    Private Sub dtpFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtCalle.Focus()
        End If
    End Sub

    Private Sub txtCalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtNumero.Focus()
        End If
    End Sub

    Private Sub txtNumero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumero.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtSector.Focus()
        End If

    End Sub

    Private Sub txtSector_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSector.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtTorre.Focus()
        End If
    End Sub

    Private Sub txtTorre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTorre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtPiso.Focus()
        End If
    End Sub

    Private Sub txtPiso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPiso.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtDpto.Focus()
        End If
    End Sub

    Private Sub txtDpto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDpto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtManzana.Focus()
        End If
    End Sub

    Private Sub txtManzana_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtManzana.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cboLocalidad.Focus()
        End If
    End Sub

    Private Sub txtCodigoPostal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoPostal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnAgregarDomicilio.Focus()
        End If
    End Sub

    Private Sub txtCuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.cboIva.Focus()
        End If
    End Sub

    Private Sub cboIva_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ' Me.cboMes.Focus()

        End If
    End Sub

    Private Sub cboMes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    Me.txtCBU.Focus()
        'End If
    End Sub

    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Me.txtCBU.Focus()

    End Sub

    Private Sub cboIva_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.cboMes.Focus()
    End Sub

    Private Sub txtCBU_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'Me.btnAgregarCBU.Focus()
        End If
    End Sub

    Private Sub txtNombreResponsable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'Me.txtDniResponsable.Focus()
        End If
    End Sub

    Private Sub txtDniResponsable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ' Me.cboPais.Focus()
        End If
    End Sub

    Private Sub cboPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Me.btnAgregarResponsable.Focus()
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        Me.soloNumeros(e)
    End Sub

    Public Sub soloNumeros(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsDigit(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
        End If
    End Sub

    Private Sub txtPiso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPiso.KeyPress
        Me.soloNumeros(e)

    End Sub

    Private Sub txtManzana_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtManzana.KeyPress
        Me.soloNumeros(e)

    End Sub

    Private Sub txtCodigoPostal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoPostal.KeyPress
        Me.soloNumeros(e)

    End Sub
    Private Sub txtCuit_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim objAfip As New AFIP
        If objAfip.validarcuit(Me.txtCuit.Text) = False Then
            MsgBox("El CUIT ingresado es inválido", MsgBoxStyle.Critical)
            Me.txtCuit.Focus()

        End If
    End Sub
#End Region


    Public Sub New(ByVal estado As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        estadoCliente = estado
        If estadoCliente = "nuevoCliente" Then
            nuevoCliente = 0
            Me.inicializarControles()
            Me.activarControles()
            Me.tssBtnNuevo.Enabled = False
            Me.tssBtnEliminar.Enabled = False
            Me.tssBtnModificar.Enabled = False
            Me.tssBtnConsultar.Enabled = False
            Me.btnGuardar.Enabled = True
            Me.accion = "nuevo"

        End If
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub txtLocalidad_LostFocus(sender As Object, e As EventArgs) Handles txtLocalidad.LostFocus
        If txtLocalidad.Text = "" Then
            Exit Sub
        End If
        Try
            Dim objAfip As New AFIP

            Dim idPartido As Integer
            Dim idProvincia As Integer
            Dim odataset As DataSet

            odataset = New DataSet
            odataset = objAfip.buscarLocalidadXdescripcion(Me.txtLocalidad.Text)
            txtPartido.Text = UCase(odataset.Tables(0).Rows(0).Item(1))
            txtProvincia.Text = UCase(odataset.Tables(0).Rows(0).Item(2))
            txtCodigoPostal.Focus()
            'Me.txtCodigoPostal.Text = UCase(odataset.Tables(0).Rows(0).Item(3))
            'idPartido = odataset.Tables(0).Rows(0).Item("idPartido").ToString

            'odataset = New DataSet
            'odataset = objAfip.buscarDptoXLocalidad(idPartido)
            'Me.txtPartido.Text = odataset.Tables(0).Rows(1).Item("Nombre").ToString
            'idProvincia = odataset.Tables(0).Rows(0).Item("idProvincia").ToString

            'odataset = New DataSet
            'odataset = objAfip.buscarProvinciasXid(idProvincia)
            'Me.txtProvincia.Text = UCase(odataset.Tables(0).Rows(0).Item("Nombre").ToString)



        Catch ex As Exception

        End Try
    End Sub
End Class






