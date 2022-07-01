Public Class frmNuevoProductoVario
    Public ultimoCodigoCreado As Integer
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim objArticulo As New Articulos
        Dim odataset As New DataSet
        If Me.txtDescuento.Text = "" Then
            Me.txtDescuento.Text = 0
        End If
        If Me.txtIva.Text = "" Then
            Me.txtIva.Text = 0
        End If
        If Me.txtUtilidad.Text = "" Then
            Me.txtUtilidad.Text = 0
        End If
        'If Me.txtCodigoBarras.Text = "" Then
        '    Me.txtCodigoBarras.Text = "0"
        'End If
        'objArticulo.codigo_barras = Me.txtCodigoBarras.Text
        'objArticulo.comentario = Me.txtComentario.Text.ToString
        'objArticulo.costo = Me.txtCostoProducto.Text.ToString

        objArticulo.costo = FormatNumber((Me.txtCostoProducto.Text / 1.21), 2) 'Replace(Me.txtCostoProducto.Text, ".", ",")
        objArticulo.descripcion = Me.txtDescripcionProducto.Text.ToString
        objArticulo.descuento = CDbl(Me.txtDescuento.Text.ToString)
        objArticulo.idProveedor = 1
        objArticulo.iva = 21
        objArticulo.stock = 100
        objArticulo.utilidad = Me.txtUtilidad.Text.ToString
        objArticulo.idMarca = 1
        objArticulo.idRubro = 1
        objArticulo.moneda = "AR$"

        If txtDescripcionProducto.Text <> "" And txtCostoProducto.Text <> "" Then
            objArticulo.nuevoArticulo(objArticulo)
            ultimoCodigoCreado = objArticulo.buscarUltimoCodArticulo.Tables(0).Rows(0).Item(0)
            Me.Close()
        End If
    End Sub

    Private Sub frmNuevoProductoVario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDescripcionProducto.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class