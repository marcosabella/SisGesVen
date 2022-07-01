Public Class frmModificarPrecios
    Private Sub frmModificarPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opTodos.Checked = True
        cboRubro.Enabled = False
        cargarComboRubro()
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

    Private Sub opTodos_CheckedChanged(sender As Object, e As EventArgs) Handles opTodos.CheckedChanged
        If opTodos.Checked = True Then
            cboRubro.Enabled = False
            cboRubro.SelectedIndex = -1
        Else
            cboRubro.SelectedIndex = -1
            cboRubro.Enabled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objArticulo As New Articulos
        Dim idRubro As Integer

        If txtporc.Text = "" Then
            alerta.SetError(Label1, "Ingrese el porcentaje")
            Exit Sub
        Else
            alerta.Clear()
        End If

        If opTodos.Checked = True Then
            idRubro = 0
        Else
            idRubro = cboRubro.SelectedValue
        End If

        If MsgBox("La siguiente acción modificará el precio de todos los artículos" & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
            objArticulo.modificarTodosPrecios(Replace(Me.txtporc.Text, ".", ","), idRubro)
        End If
        Me.Close()


    End Sub


    Private Sub txtporc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtporc.KeyPress
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtporc.Text = ""
        cboRubro.SelectedIndex = -1
        opTodos.Checked = True
    End Sub
End Class