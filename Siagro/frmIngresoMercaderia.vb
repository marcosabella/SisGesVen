Public Class frmIngresoMercaderia
    Public ingresoMercaderia As Integer

    Private Sub frmIngresoMercaderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        ingresoMercaderia = Me.txtIngresoMercaderia.Text
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        ingresoMercaderia = 0
        Me.Close()
    End Sub

End Class