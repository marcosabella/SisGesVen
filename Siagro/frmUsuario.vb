Imports System.ComponentModel

Public Class frmUsuario
    Dim accion As String
    Dim estadoAlerta As Integer
    Dim idUsuario As Integer
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicialicarControles()
    End Sub

    Private Sub inicialicarControles()
        accion = ""
        alerta.Clear()
        estadoAlerta = 0
        Me.tssBtnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.tssBtnConsultar.Enabled = True
        Me.tssBtnEliminar.Enabled = False
        Me.tssBtnModificar.Enabled = False
        Me.btnCancelar.Enabled = False

        txtContrasena.Text = ""
        txtNombreUsuario.Text = ""
        txtRepetirContrasena.Text = ""
        txtUsuarioSistema.Text = ""

        txtContrasena.Enabled = False
        txtNombreUsuario.Enabled = False
        txtRepetirContrasena.Enabled = False
        txtUsuarioSistema.Enabled = False

        chkClientes.Enabled = False
        chkConfiguracion.Enabled = False
        chkCtaCte.Enabled = False
        chkListados.Enabled = False
        chkListaPrecios.Enabled = False
        chkProductos.Enabled = False
        chkProveedores.Enabled = False
        chkVentas.Enabled = False

        chkClientes.Checked = False
        chkConfiguracion.Checked = False
        chkCtaCte.Checked = False
        chkListados.Checked = False
        chkListaPrecios.Checked = False
        chkProductos.Checked = False
        chkProveedores.Checked = False
        chkVentas.Checked = False


    End Sub

    Private Sub tssBtnCerrar_Click(sender As Object, e As EventArgs) Handles tssBtnCerrar.Click
        Close()
    End Sub

    Private Sub activarControles()
        Me.tssBtnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.tssBtnConsultar.Enabled = False
        Me.tssBtnEliminar.Enabled = False
        Me.tssBtnModificar.Enabled = False
        Me.btnCancelar.Enabled = True


        txtContrasena.Enabled = True
        txtNombreUsuario.Enabled = True
        txtRepetirContrasena.Enabled = True
        txtUsuarioSistema.Enabled = True

        chkClientes.Enabled = True
        chkConfiguracion.Enabled = True
        chkCtaCte.Enabled = True
        chkListados.Enabled = True
        chkListaPrecios.Enabled = True
        chkProductos.Enabled = True
        chkProveedores.Enabled = True
        chkVentas.Enabled = True


    End Sub

    Private Sub tssBtnNuevo_Click(sender As Object, e As EventArgs) Handles tssBtnNuevo.Click
        Me.activarControles()
        accion = "nuevo"
        txtNombreUsuario.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        inicialicarControles()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        estadoAlerta = 0
        If Me.txtContrasena.Text <> Me.txtRepetirContrasena.Text Then
            alerta.SetError(txtContrasena, "No coincide contraseña")
            alerta.SetError(txtRepetirContrasena, "No coincide contraseña")
            estadoAlerta = 1

        End If
        If Me.txtContrasena.Text = "" Then
            alerta.SetError(txtContrasena, "Ingrese contraseña")
            estadoAlerta = 1
        End If
        If Me.txtNombreUsuario.Text = "" Then
            alerta.SetError(txtNombreUsuario, "Ingrese nombre de usuario")
            estadoAlerta = 1
        End If
        If Me.txtRepetirContrasena.Text = "" Then
            alerta.SetError(txtRepetirContrasena, "Ingrese contraseña")
            estadoAlerta = 1
        End If
        If Me.txtUsuarioSistema.Text = "" Then
            alerta.SetError(txtUsuarioSistema, "Ingrese usuario del sistema")
            estadoAlerta = 1
        End If
        If estadoAlerta = 1 Then
            Exit Sub
        Else
            alerta.Clear()
            estadoAlerta = 0

        End If

        Dim objUsuario As New Usuarios
        objUsuario.nombreUsuario = txtNombreUsuario.Text
        objUsuario.usuarioSistema = txtUsuarioSistema.Text
        objUsuario.contrasena = txtContrasena.Text

        objUsuario.opClientes = chkClientes.Checked
        objUsuario.opConfiguracion = chkConfiguracion.Checked
        objUsuario.opCtaCte = chkCtaCte.Checked
        objUsuario.opListados = chkListados.Checked
        objUsuario.opListaPrecios = chkListaPrecios.Checked
        objUsuario.opProductos = chkProductos.Checked
        objUsuario.opProveedores = chkProveedores.Checked
        objUsuario.opVentas = chkVentas.Checked

        If accion = "nuevo" Then
            objUsuario.nuevoUsuario(objUsuario)
        ElseIf accion = "modificar" Then
            objUsuario.idUsuario = idUsuario
            objUsuario.modificarUsuario(objUsuario)
        End If
        inicialicarControles()
    End Sub

    Private Sub tssBtnConsultar_Click(sender As Object, e As EventArgs) Handles tssBtnConsultar.Click
        Dim frmBuscarUsuario As New frmBuscarUsuarios
        frmBuscarUsuario.ShowDialog()
        If frmBuscarUsuario.idUsuarioBusqueda <> 0 Then
            Dim oDataSet As New DataSet
            Dim objUsuario As New Usuarios
            idUsuario = frmBuscarUsuario.idUsuarioBusqueda
            oDataSet = objUsuario.buscarUsuariosXid(idUsuario)
            txtNombreUsuario.Text = oDataSet.Tables(0).Rows(0).Item("nombre")
            txtUsuarioSistema.Text = oDataSet.Tables(0).Rows(0).Item("usuarioSistema")
            txtContrasena.Text = oDataSet.Tables(0).Rows(0).Item("contrasena")
            txtRepetirContrasena.Text = oDataSet.Tables(0).Rows(0).Item("contrasena")
            chkClientes.Checked = oDataSet.Tables(0).Rows(0).Item("clientes")
            chkConfiguracion.Checked = oDataSet.Tables(0).Rows(0).Item("configuracion")
            chkCtaCte.Checked = oDataSet.Tables(0).Rows(0).Item("ctacte")
            chkListados.Checked = oDataSet.Tables(0).Rows(0).Item("listados")
            chkListaPrecios.Checked = oDataSet.Tables(0).Rows(0).Item("listaPrecios")
            chkProductos.Checked = oDataSet.Tables(0).Rows(0).Item("productos")
            chkProveedores.Checked = oDataSet.Tables(0).Rows(0).Item("proveedores")
            chkVentas.Checked = oDataSet.Tables(0).Rows(0).Item("ventas")
            tssBtnNuevo.Enabled = False
            tssBtnModificar.Enabled = True
            tssBtnEliminar.Enabled = True
            btnCancelar.Enabled = True
        End If
    End Sub

    Private Sub tssBtnModificar_Click(sender As Object, e As EventArgs) Handles tssBtnModificar.Click
        accion = "modificar"
        activarControles()
    End Sub

    Private Sub txtUsuarioSistema_Validated(sender As Object, e As EventArgs) Handles txtUsuarioSistema.Validated
        Dim objUsuario As New Usuarios
        Dim oDataSet As New DataSet
        oDataSet = objUsuario.existeUsuario(Me.txtUsuarioSistema.Text)
        If oDataSet.Tables(0).Rows.Count > 0 Then
            MsgBox("El usuario ya se encuentra en el sistema. Ingrese otro nombre de usuario", MsgBoxStyle.Information)
            txtUsuarioSistema.Focus()
            txtUsuarioSistema.SelectAll()
        End If
    End Sub

    Private Sub tssBtnEliminar_Click(sender As Object, e As EventArgs) Handles tssBtnEliminar.Click
        Dim objUsuarios As New Usuarios
        If MsgBox("La siguiente acción eliminará el Usuario " & Me.txtNombreUsuario.Text & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
            objUsuarios.borrarUsuario(idUsuario)
            inicialicarControles()
        Else


        End If
    End Sub
End Class