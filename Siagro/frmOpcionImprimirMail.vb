Public Class frmOpcionImprimirMail
    Dim idVenta As Integer
    Dim reporte As String
    Dim idCliente As Integer
    Dim cae As String
    Dim vtocae As String
    Public Sub New(ByVal id As Integer, ByVal accion As String, ByVal idCliente As Integer, ByVal cae As String, ByVal vtoCae As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        idVenta = id
        reporte = accion
        Me.idCliente = idCliente
        Me.cae = cae
        Me.vtocae = vtoCae
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If reporte = "presupuesto" Then
            Dim frmReporte As New frmPresupuesto(idVenta, False, 0)
            frmReporte.ShowDialog()

        Else
            Dim frmReporte As New frmComprobanteVenta(idVenta, False, 0, cae, vtocae, "", "", "")
            frmReporte.ShowDialog()

        End If
        Me.Close()
    End Sub

    Private Sub btnMail_Click(sender As Object, e As EventArgs) Handles btnMail.Click
        If reporte = "presupuesto" Then
            Dim frmReporte As New frmPresupuesto(idVenta, True, idCliente)

            frmReporte.ShowDialog()
            frmReporte.Close()
        Else
            Dim frmReporte As New frmComprobanteVenta(idVenta, True, idCliente, cae, vtocae, "", "", "")

            frmReporte.ShowDialog()
            frmReporte.Close()
        End If
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmOpcionImprimirMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class