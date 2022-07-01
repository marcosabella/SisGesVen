Public Class frmProveedores
    Dim accion As String
    Dim codigoActividad As Integer
    Dim idProveedor As Integer
    Public codigoNuevoProveedor As Integer
    Dim accionProveedor As String

    Dim estadoProveedor As String
    Public nuevoProveedor As Integer
    Private Sub tssBtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBtnCerrar.Click
        Me.Close()
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
    End Sub

    Private Sub tssBtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBtnEliminar.Click
        Dim objProveedores As New Proveedores
        If MsgBox("La siguiente acción eliminará el Proveedor " & Me.txtRazonSocial.Text & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
            objProveedores.borrarProveedor(idProveedor)
            objProveedores.borrarDomicilioXproveedor(Me.idProveedor)
            objProveedores.borrarResponsableXproveedor(Me.idProveedor)
            Me.inicializarControles()
        Else


        End If
    End Sub

    Private Sub tssBtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBtnModificar.Click
        Me.desbloquearControles()
        Me.pestanas.SelectedIndex = 0
        Me.accion = "modificar"
    End Sub

    Private Sub tssBtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBtnConsultar.Click
        Dim frmBuscarProveedor As New frmBuscarProveedor
        Dim min As Integer = 0



        frmBuscarProveedor.ShowDialog()
        If frmBuscarProveedor.idProveedorBusqueda <> 0 Then
            Me.inicializarControles()
            idProveedor = frmBuscarProveedor.idProveedorBusqueda
            Me.pestanas.SelectedIndex = 0
            Me.recuperarDatosProveedor()
            Me.recuperarDomicilioProveedor()
            Me.recuperarResponsable()
            Me.bloquearControles()
        End If
    End Sub

    'Private Sub llenarComboLocalidad()
    '    Dim objAFIP As New AFIP
    '    Dim oDataSet As New DataSet
    '    oDataSet = objAFIP.buscarLocalidad


    '    If oDataSet.Tables(0).Rows.Count <> 0 Then
    '        Me.cboLocalidad.DataSource = oDataSet.Tables(0)
    '        Me.cboLocalidad.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
    '        Me.cboLocalidad.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString

    '    End If

    '    Dim coleccion As New AutoCompleteStringCollection()
    '    'recorrer y cargar los items para el autocompletado
    '    For Each row As DataRow In oDataSet.Tables(0).Rows
    '        coleccion.Add(Convert.ToString(row("Nombre")))
    '    Next

    '    cboLocalidad.AutoCompleteCustomSource = coleccion
    '    cboLocalidad.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '    cboLocalidad.AutoCompleteSource = AutoCompleteSource.CustomSource
    '    Me.cboLocalidad.SelectedIndex = -1
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

    Private Sub llenarComboDocumentos()
        Dim objAFIP As New AFIP
        Dim oDataSet As New DataSet
        oDataSet = objAFIP.buscarCodDocumento

        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboCodDcumento.DataSource = oDataSet.Tables(0)
            Me.cboCodDcumento.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboCodDcumento.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
        End If


        Me.cboCodDcumento.SelectedIndex = -1
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
        Me.alerta.Clear()
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.tssBtnConsultar.Enabled = True
        Me.tssBtnEliminar.Enabled = False
        Me.tssBtnModificar.Enabled = False
        Me.tssBtnNuevo.Enabled = True

        Me.txtCalle.Text = ""
        Me.txtTelefonoResponsable.Text = ""
        Me.txtIIBB.Text = ""
        Me.txtCodigoPostal.Text = ""
        Me.txtCuit.Text = ""
        Me.txtDpto.Text = ""
        Me.txtManzana.Text = ""
        Me.txtRazonSocial.Text = ""
        Me.txtNombreResponsable.Text = ""
        Me.txtNumero.Text = ""
        Me.txtPartido.Text = ""
        Me.txtPiso.Text = ""
        Me.txtProvincia.Text = ""
        Me.txtSector.Text = ""
        Me.txtTorre.Text = ""
        Me.cboLocalidad.SelectedIndex = -1
        Me.cboCodDcumento.SelectedIndex = -1
        Me.cboIva.SelectedIndex = 0
        Me.lstResponsable.Rows.Clear()
        Me.lstDomicilio.Rows.Clear()
        grupoDatosFiscal.Enabled = False
        grupoNombre.Enabled = False
        grupoDomicilio.Enabled = False
        grupoResponsables.Enabled = False
        Me.accion = ""



    End Sub

    Private Sub activarControles()
        grupoNombre.Enabled = True
        grupoDomicilio.Enabled = True
        grupoResponsables.Enabled = True
        grupoDatosFiscal.Enabled = True

        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.tssBtnConsultar.Enabled = False
        Me.tssBtnEliminar.Enabled = False
        Me.tssBtnModificar.Enabled = False
        Me.tssBtnNuevo.Enabled = False
        Me.pestanas.SelectedIndex = 0
        Me.opFísica.Checked = True
        Me.opFiscal.Checked = True
        Me.txtRazonSocial.Focus()

        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = True
        Me.tssBtnConsultar.Enabled = True
        Me.tssBtnEliminar.Enabled = True
        Me.tssBtnModificar.Enabled = True
        Me.tssBtnNuevo.Enabled = False

        Me.txtCalle.ReadOnly = False
        Me.txtTelefonoResponsable.ReadOnly = False
        Me.txtIIBB.ReadOnly = False
        Me.txtCodigoPostal.ReadOnly = False
        Me.txtCuit.ReadOnly = False
        Me.txtDpto.ReadOnly = False
        Me.txtManzana.ReadOnly = False
        Me.txtRazonSocial.ReadOnly = False
        Me.txtNombreResponsable.ReadOnly = False
        Me.txtNumero.ReadOnly = False
        Me.txtPartido.ReadOnly = False
        Me.txtPiso.ReadOnly = False
        Me.txtProvincia.ReadOnly = False
        Me.txtSector.ReadOnly = False
        Me.txtTorre.ReadOnly = False
        Me.cboLocalidad.Enabled = True
        Me.cboCodDcumento.Enabled = True
        Me.cboIva.Enabled = True

        Me.opFiscal.Enabled = True
        Me.opFísica.Enabled = True
        Me.opJurídica.Enabled = True
        Me.opOtro.Enabled = True


    End Sub

    Private Sub bloquearControles()

        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = True
        Me.tssBtnConsultar.Enabled = True
        Me.tssBtnEliminar.Enabled = True
        Me.tssBtnModificar.Enabled = True
        Me.tssBtnNuevo.Enabled = False

        Me.txtCalle.ReadOnly = True
        Me.txtTelefonoResponsable.ReadOnly = True
        Me.txtIIBB.ReadOnly = True
        Me.txtCodigoPostal.ReadOnly = True
        Me.txtCuit.ReadOnly = True
        Me.txtDpto.ReadOnly = True
        Me.txtManzana.ReadOnly = True
        Me.txtRazonSocial.ReadOnly = True
        Me.txtNombreResponsable.ReadOnly = True
        Me.txtNumero.ReadOnly = True
        Me.txtPartido.ReadOnly = True
        Me.txtPiso.ReadOnly = True
        Me.txtProvincia.ReadOnly = True
        Me.txtSector.ReadOnly = True
        Me.txtTorre.ReadOnly = True
        Me.cboLocalidad.Enabled = False
        Me.cboCodDcumento.Enabled = False
        Me.cboIva.Enabled = False

        Me.opFiscal.Enabled = False
        Me.opFísica.Enabled = False
        Me.opJurídica.Enabled = False
        Me.opOtro.Enabled = False


        Me.btnAgregarDomicilio.Enabled = False
        Me.btnAgregarResponsable.Enabled = False

        Me.btnBorrarResponsable.Enabled = False
        Me.btnEliminarDomicilio.Enabled = False

        grupoNombre.Enabled = True
        grupoDomicilio.Enabled = True
        grupoResponsables.Enabled = True
        grupoDatosFiscal.Enabled = True
    End Sub

    Private Sub desbloquearControles()
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.tssBtnConsultar.Enabled = False
        Me.tssBtnEliminar.Enabled = False
        Me.tssBtnModificar.Enabled = False
        Me.tssBtnNuevo.Enabled = False

        Me.txtCalle.ReadOnly = False
        Me.txtTelefonoResponsable.ReadOnly = False
        Me.txtIIBB.ReadOnly = False
        Me.txtCodigoPostal.ReadOnly = False
        Me.txtCuit.ReadOnly = False
        Me.txtDpto.ReadOnly = False
        Me.txtManzana.ReadOnly = False
        Me.txtRazonSocial.ReadOnly = False
        Me.txtNombreResponsable.ReadOnly = False
        Me.txtNumero.ReadOnly = False
        Me.txtPartido.ReadOnly = False
        Me.txtPiso.ReadOnly = False
        Me.txtProvincia.ReadOnly = False
        Me.txtSector.ReadOnly = False
        Me.txtTorre.ReadOnly = False
        Me.cboLocalidad.Enabled = True
        Me.cboCodDcumento.Enabled = True
        Me.cboIva.Enabled = True

        Me.opFiscal.Enabled = True
        Me.opFísica.Enabled = True
        Me.opJurídica.Enabled = True
        Me.opOtro.Enabled = True

        Me.btnAgregarDomicilio.Enabled = True
        Me.btnAgregarResponsable.Enabled = True

        Me.btnBorrarResponsable.Enabled = True
        Me.btnEliminarDomicilio.Enabled = True

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.inicializarControles()
        Me.inicializarControles()
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
        Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(9).Value = cboLocalidad.SelectedValue
        Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(10).Value = txtLocalidad.Text
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
        Me.cboLocalidad.SelectedIndex = -1

    End Sub

    Private Sub lstDomicilio_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles lstDomicilio.CellContentClick
        Try
            Dim oDataSet As New DataSet
            Dim objProveedor As New Proveedores
            Dim objAFIP As New AFIP
            oDataSet = objProveedor.buscarDomicilioXidDomicilio(Me.lstDomicilio.CurrentRow.Cells(12).Value.ToString)
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

    Private Sub btnAgregarResponsable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarResponsable.Click
        Me.lstResponsable.Rows.Add()
        Me.lstResponsable.Rows(lstResponsable.Rows.Count - 1).Cells(1).Value = Me.txtTelefonoResponsable.Text
        Me.lstResponsable.Rows(lstResponsable.Rows.Count - 1).Cells(2).Value = Me.txtNombreResponsable.Text

        Me.txtNombreResponsable.Text = ""
        Me.txtTelefonoResponsable.Text = ""
    End Sub

    Private Sub btnBorrarResponsable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarResponsable.Click
        If lstResponsable.Rows.Count > 0 Then
            If MsgBox("Desea eliminar Item?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then

                lstResponsable.Rows.Remove(lstResponsable.CurrentRow())
            End If
        End If
    End Sub

    Private Sub lstResponsable_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles lstResponsable.CellContentClick
        Try
            Dim oDataSet As New DataSet
            Dim objProveedor As New Proveedores
            oDataSet = objProveedor.buscarReponsableXidResponsable(Me.lstResponsable.CurrentRow.Cells(0).Value.ToString)
            If oDataSet.Tables(0).Rows.Count > 0 Then
                Me.txtTelefonoResponsable.Text = oDataSet.Tables(0).Rows(0).Item("telefono")
                Me.txtNombreResponsable.Text = oDataSet.Tables(0).Rows(0).Item("nombre_responsable")
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstResponsable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstResponsable.KeyDown
        If lstResponsable.Rows.Count > 0 Then
            If MsgBox("Desea eliminar Item?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then

                lstResponsable.Rows.Remove(lstResponsable.CurrentRow())
            End If
        End If
    End Sub

    Private Sub lstDomicilio_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDomicilio.SelectionChanged
        Try
            Dim oDataSet As New DataSet
            Dim objProveedor As New Proveedores
            Dim objAFIP As New AFIP
            oDataSet = objProveedor.buscarDomicilioXidDomicilio(Me.lstDomicilio.CurrentRow.Cells(12).Value.ToString)
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

    Private Sub lstResponsable_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstResponsable.SelectionChanged
        Try
            Dim oDataSet As New DataSet
            Dim objProveedor As New Proveedores
            oDataSet = objProveedor.buscarReponsableXidResponsable(Me.lstResponsable.CurrentRow.Cells(0).Value.ToString)
            If oDataSet.Tables(0).Rows.Count > 0 Then
                Me.txtTelefonoResponsable.Text = oDataSet.Tables(0).Rows(0).Item("telefono")
                Me.txtNombreResponsable.Text = oDataSet.Tables(0).Rows(0).Item("nombre_responsable")
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.llenarComboLocalidad()
        Me.llenarComboDocumentos()
        Me.llenarComboIva()
        ' cargo la lista de items para el autocomplete dle combobox
        Me.inicializarControles()
        If accionProveedor = "nuevoProveedor" Then
            Me.activarControles()
            Me.tssBtnNuevo.Enabled = False
            Me.tssBtnEliminar.Enabled = False
            Me.tssBtnModificar.Enabled = False
            Me.tssBtnConsultar.Enabled = False
            Me.btnGuardar.Enabled = True
            Me.accion = "nuevo"
            codigoNuevoProveedor = 0
        End If
    End Sub

    Private Sub llenarComboIva()
        Dim objAFIP As New AFIP
        Dim oDataSet As New DataSet
        oDataSet = objAFIP.buscarCondIva
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboIva.DataSource = oDataSet.Tables(0)
            Me.cboIva.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboIva.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
        End If


        Me.cboIva.SelectedIndex = 0
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim estadoAlerta As Integer
        estadoAlerta = 0
        alerta.Clear()

        If Me.txtRazonSocial.Text = "" Then
            alerta.SetError(Me.txtRazonSocial, "Ingrese el razón social del proveedor")
            estadoAlerta = 1
        End If
        If lstDomicilio.RowCount = 0 Then
            alerta.SetError(Me.lstDomicilio, "Ingrese un domicilio")
            estadoAlerta = 1
        End If


        If estadoAlerta = 1 Then
            Exit Sub
        End If

        'paso la validación
        If estadoAlerta = 0 Then


            Dim objProveedor As New Proveedores
            If accion = "nuevo" Then
                If Me.guardarNuevoProveedor() = True Then
                    Dim idProveedor As Integer
                    idProveedor = objProveedor.buscarUltimoProveedor.Tables(0).Rows(0).Item(0)
                    Me.guardarNuevoDomicilioXproveedor(idProveedor)
                    Me.guardarNuevoResponsableXproveedor(idProveedor)
                    If accionProveedor = "nuevoProveedor" Then
                        codigoNuevoProveedor = idProveedor
                        nuevoProveedor = 1
                        Me.Close()
                    End If
                End If
            ElseIf accion = "modificar" Then
                If Me.modificarProveedor() = True Then
                    objProveedor.borrarDomicilioXproveedor(idProveedor)
                    objProveedor.borrarResponsableXproveedor(idProveedor)
                    Me.guardarNuevoDomicilioXproveedor(idProveedor)
                    Me.guardarNuevoResponsableXproveedor(idProveedor)

                End If
            End If
            Me.inicializarControles()
        End If
    End Sub

    Private Sub cboCodDcumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodDcumento.SelectedIndexChanged
        Try
            Dim objAFIP As New AFIP
            Dim odataset As New DataSet
            odataset = objAFIP.verificarCodDocumentosEsCuit(Me.cboCodDcumento.SelectedValue)
            If odataset.Tables(0).Rows.Count > 0 Then
                Me.txtCuit.Mask = "99 - 99999999 - 9"
            Else
                Me.txtCuit.Mask = "99999999"
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub New(ByVal nuevoProveedor As String)

        InitializeComponent()
        accionProveedor = nuevoProveedor

        If accionProveedor = "nuevoCliente" Then
            nuevoProveedor = 0
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
            Dim odataset As DataSet

            odataset = New DataSet
            odataset = objAfip.buscarLocalidadXdescripcion(Me.txtLocalidad.Text)
            txtPartido.Text = UCase(odataset.Tables(0).Rows(0).Item(1))
            txtProvincia.Text = UCase(odataset.Tables(0).Rows(0).Item(2))
            txtCodigoPostal.Focus()

        Catch ex As Exception

        End Try
    End Sub

#Region "Acceso a datos"

    Private Function guardarNuevoProveedor() As Boolean
        Dim objProveedor As New Proveedores
        objProveedor.razon_social = Me.txtRazonSocial.Text
        objProveedor.cuit = Me.txtCuit.Text
        objProveedor.iibb = Me.txtIIBB.Text
        objProveedor.idCodDocumento = cboCodDcumento.SelectedValue
        objProveedor.idCondIva = cboIva.SelectedValue
        If opJurídica.Checked = True Then
            objProveedor.idTipo_persona = 1
        Else
            objProveedor.idTipo_persona = 0
        End If

        If objProveedor.nuevoProveedor(objProveedor) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub guardarNuevoDomicilioXproveedor(ByVal idProveedor As Integer)

        Dim objProveedor As New Proveedores

        Dim i As Integer
        i = 0

        objProveedor.idProveedor = idProveedor
        If lstDomicilio.Rows.Count = 0 Then
            Exit Sub
        End If
        While i < Me.lstDomicilio.Rows.Count()
            objProveedor.idTipo_domicilio = Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(0).Value

            objProveedor.calle = Me.lstDomicilio.Rows(i).Cells(2).Value
            objProveedor.numero = Me.lstDomicilio.Rows(i).Cells(3).Value
            objProveedor.sector = Me.lstDomicilio.Rows(i).Cells(4).Value
            objProveedor.torre = Me.lstDomicilio.Rows(i).Cells(5).Value
            objProveedor.piso = Me.lstDomicilio.Rows(i).Cells(6).Value
            objProveedor.dpto = Me.lstDomicilio.Rows(i).Cells(7).Value
            objProveedor.manzana = Me.lstDomicilio.Rows(i).Cells(8).Value
            objProveedor.localidad = Me.lstDomicilio.Rows(i).Cells(10).Value
            objProveedor.cp = Me.lstDomicilio.Rows(i).Cells(11).Value
            objProveedor.nuevoDomicilio_x_proveedor(objProveedor)
            i = i + 1
        End While





    End Sub
    Private Sub guardarNuevoResponsableXproveedor(ByVal idProveedor As Integer)
        Dim i As Integer
        i = 0
        Dim objProveedor As New Proveedores
        objProveedor.idProveedor = idProveedor
        If lstResponsable.Rows.Count = 0 Then
            Exit Sub
        End If
        While i < Me.lstResponsable.Rows.Count()
            objProveedor.telefono = Me.lstResponsable.Rows(i).Cells(1).Value
            objProveedor.nombreResponsable = Me.lstResponsable.Rows(i).Cells(2).Value
            objProveedor.nuevoResponsable_x_proveedor(objProveedor)
            i = i + 1
        End While
    End Sub

    Private Sub recuperarDatosProveedor()
        Dim objProveedor As New Proveedores
        Dim oDataSet As New DataSet
        Dim odatasetCuit As New DataSet
        Dim objAFIP As New AFIP
        oDataSet = objProveedor.buscarProveedoresXid(idProveedor)

        If oDataSet.Tables(0).Rows(0).Item("idTipo_persona") = 0 Then
            Me.opFísica.Checked = True
            Me.opJurídica.Checked = False
        Else
            Me.opFísica.Checked = False
            Me.opJurídica.Checked = True
        End If

        Me.txtRazonSocial.Text = oDataSet.Tables(0).Rows(0).Item("razon_social")

        Me.cboCodDcumento.Text = objAFIP.buscarCodDocumentosXcodigo(oDataSet.Tables(0).Rows(0).Item("idCodDocumento")).Tables(0).Rows(0).Item("Descripcion")
        Me.txtIIBB.Text = oDataSet.Tables(0).Rows(0).Item("iibb")
        odatasetCuit = objAFIP.verificarCodDocumentosEsCuit(Me.cboCodDcumento.SelectedValue)
        If odatasetCuit.Tables(0).Rows.Count > 0 Then
            Me.txtCuit.Mask = "99 - 99999999 - 9"
        Else
            Me.txtCuit.Mask = "99999999"
        End If
        Me.txtCuit.Text = oDataSet.Tables(0).Rows(0).Item("cuit").ToString
        If objAFIP.buscarCondIvaXcodigo(oDataSet.Tables(0).Rows(0).Item("idCondIva")).Tables(0).Rows.Count > 0 Then
            Me.cboIva.Text = objAFIP.buscarCondIvaXcodigo(oDataSet.Tables(0).Rows(0).Item("idCondIva")).Tables(0).Rows(0).Item("descripcion")
        End If

    End Sub
    Private Sub recuperarDomicilioProveedor()
        Dim objProveedor As New Proveedores
        Dim objAFIP As New AFIP
        Dim odataset As New DataSet
        Dim i As Integer
        i = 0

        odataset = objProveedor.buscarDomicilioXidProveedor(idProveedor)

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
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(9).Value = 0 'odataset.Tables(0).Rows(i).Item("idLocalidad").ToString
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(10).Value = odataset.Tables(0).Rows(i).Item("localidad").ToString
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(11).Value = odataset.Tables(0).Rows(i).Item("cp").ToString
            Me.lstDomicilio.Rows(lstDomicilio.Rows.Count - 1).Cells(12).Value = odataset.Tables(0).Rows(i).Item("idDomicilio").ToString

            i = i + 1
        End While
    End Sub
    Private Sub recuperarResponsable()
        Dim objProveedor As New Proveedores
        Dim odataset As New DataSet
        Dim i As Integer
        i = 0

        odataset = objProveedor.buscarReponsableXidProveedor(idProveedor)
        If odataset.Tables(0).Rows.Count = 0 Then
            Exit Sub
        End If
        While i < odataset.Tables(0).Rows.Count
            lstResponsable.Rows.Add()
            Me.lstResponsable.Rows(lstResponsable.Rows.Count - 1).Cells(1).Value = odataset.Tables(0).Rows(i).Item("telefono")
            Me.lstResponsable.Rows(lstResponsable.Rows.Count - 1).Cells(0).Value = odataset.Tables(0).Rows(i).Item("idResponsable")
            Me.lstResponsable.Rows(lstResponsable.Rows.Count - 1).Cells(2).Value = odataset.Tables(0).Rows(i).Item("nombreResponsable")
            i = i + 1
        End While
    End Sub

    Private Function modificarProveedor() As Boolean
        Dim objProveedor As New Proveedores
        objProveedor.idProveedor = Me.idProveedor
        objProveedor.idCodDocumento = Me.cboCodDcumento.SelectedValue
        objProveedor.cuit = Me.txtCuit.Text
        objProveedor.iibb = Me.txtIIBB.Text
        objProveedor.idCondIva = Me.cboIva.SelectedValue
        If opJurídica.Checked = True Then
            objProveedor.idTipo_persona = 1
        Else
            objProveedor.idTipo_persona = 0
        End If
        objProveedor.razon_social = Me.txtRazonSocial.Text

        If objProveedor.modificarProveedor(objProveedor) = True Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Validaciones"

    Private Sub txtRazonSocial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRazonSocial.KeyDown
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

    Private Sub txtCuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuit.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtIIBB.Focus()
        End If
    End Sub

    Private Sub txtNombreResponsable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombreResponsable.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtTelefonoResponsable.Focus()
        End If
    End Sub

    Private Sub txtTelefonoResponsable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTelefonoResponsable.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnAgregarResponsable.Focus()
        End If
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

    Private Sub txtCuit_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuit.Validated
        Dim objAfip As New AFIP
        If objAfip.validarcuit(Me.txtCuit.Text) = False Then
            MsgBox("El CUIT ingresado es inválido", MsgBoxStyle.Critical, "SISTEMAS GESTIÓN DE VENTAS Y STOCK")
            Me.txtCuit.Focus()

        End If
    End Sub

    Private Sub txtLocalidad_TextChanged(sender As Object, e As EventArgs) Handles txtLocalidad.TextChanged

    End Sub



#End Region


End Class