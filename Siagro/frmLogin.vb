
Public Class frmLogin
    Public oDataSetValidar As New DataSet
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        validarUsuario()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContrasena.Text = ""
        txtUsuario.Text = ""
        txtUsuario.Focus()

    End Sub

    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            validarUsuario()
        End If
    End Sub


    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtContrasena.Focus()
        End If
    End Sub


    Private Sub validarUsuario()

        Dim objUsuario As New Usuarios
        Dim oDataSet As New DataSet

        If txtUsuario.Text = "" Or Me.txtContrasena.Text = "" Then
            MsgBox("No pueden quedar campos vacíos", MsgBoxStyle.Critical)
            txtContrasena.Text = ""
            txtUsuario.Text = ""
            txtUsuario.Focus()
            Exit Sub
        End If

        oDataSet = objUsuario.buscarUsuario(Me.txtUsuario.Text, Me.txtContrasena.Text)
        If oDataSet.Tables(0).Rows.Count > 0 Then
            oDataSetValidar = oDataSet
            Me.Close()
        Else
            MsgBox("Usuario y/o Contraseña incorrecta", MsgBoxStyle.Critical)
            txtContrasena.Text = ""
            txtUsuario.Text = ""
            txtUsuario.Focus()
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class