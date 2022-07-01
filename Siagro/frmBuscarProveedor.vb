Public Class frmBuscarProveedor
    Public idProveedorBusqueda As Integer
    Private Sub frmBuscarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarGrillaProveedores()

    End Sub

    Private Sub cargarGrillaProveedores()
        Me.lstProveedor.Rows.Clear()
        Dim objProveedor As New Proveedores
        Dim odataset As New DataSet
        Dim i As Integer = 0
        odataset = objProveedor.buscarProveedores
        While odataset.Tables(0).Rows.Count > i
            If odataset.Tables(0).Rows(i).Item(0) <> 1 Then
                lstProveedor.Rows.Add()
                lstProveedor.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0).ToString
                lstProveedor.Rows(i).Cells(2).Value = odataset.Tables(0).Rows(i).Item("razon_social").ToString
                lstProveedor.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item("cuit").ToString
            End If
            i = i + 1
        End While
        Me.lblRegistrosEncontrados.Text = odataset.Tables(0).Rows.Count & " registros encontrados"
    End Sub

    Private Sub txtParametro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtParametro.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lstProveedor.RowCount = 0 Then
                idProveedorBusqueda = 0
            Else
                idProveedorBusqueda = CInt(lstProveedor.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        End If
        If e.KeyCode = Keys.Down Then
            lstProveedor.Focus()
        End If
    End Sub

    Private Sub txtParametro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtParametro.TextChanged
        Dim objProveedor As New Proveedores
        Me.cargarGrillaProveedores(Me.txtParametro.Text)
    End Sub

    Private Sub cargarGrillaProveedores(ByVal parametro As String)
        lstProveedor.Rows.Clear()
        Dim objProveedor As New Proveedores
        Dim odataset As New DataSet
        Dim i As Integer = 0
        odataset = objProveedor.buscarProveedoresXdescripcion(Me.txtParametro.Text)

        While odataset.Tables(0).Rows.Count > i
            'If odataset.Tables(0).Rows(i).Item(0) <> 1 Then
            lstProveedor.Rows.Add()
                lstProveedor.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0).ToString
                lstProveedor.Rows(i).Cells(2).Value = odataset.Tables(0).Rows(i).Item("razon_social").ToString
                lstProveedor.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item("cuit").ToString
            'End If
            i = i + 1
        End While
        Me.lblRegistrosEncontrados.Text = odataset.Tables(0).Rows.Count & " registros encontrados"

    End Sub

    Private Sub lstClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lstProveedor.RowCount = 0 Then
                idProveedorBusqueda = 0
            Else
                idProveedorBusqueda = CInt(lstProveedor.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        idProveedorBusqueda = 0
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If lstProveedor.RowCount = 0 Then
            idProveedorBusqueda = 0
        Else
            idProveedorBusqueda = CInt(lstProveedor.CurrentRow.Cells(0).Value.ToString)
        End If
        'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
        Me.Close()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtParametro.Focus()
    End Sub

    Private Sub lstClientes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstProveedor.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            txtParametro.Text = ""
            txtParametro.Text = e.KeyChar
            txtParametro.SelectionStart = txtParametro.TextLength
            txtParametro.Focus()
        End If

    End Sub
End Class