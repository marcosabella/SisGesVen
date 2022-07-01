Public Class frmBuscarNombre
    Dim estado As String
    Public codigo As Integer
    Dim param As String
    Private Sub frmBuscarNombre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub cargarGrillaClientes()
        Me.lstNombre.Rows.Clear()
        Dim objClientes As New Clientes
        Dim odataset As New DataSet
        Dim i As Integer = 0
        odataset = objClientes.buscarClientes

        While odataset.Tables(0).Rows.Count > i
            lstNombre.Rows.Add()
            lstNombre.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0)
            lstNombre.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item(1)
            i = i + 1
        End While

    End Sub
    Private Sub cargarGrillaClientes(ByVal parametro As String)
        lstNombre.Rows.Clear()
        Dim objCliente As New Clientes
        Dim odataset As New DataSet
        Dim i As Integer = 0
        odataset = objCliente.buscarClienteXnombre(parametro)

        While odataset.Tables(0).Rows.Count > i
            lstNombre.Rows.Add()
            lstNombre.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0)
            lstNombre.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item(1)
            i = i + 1
        End While

    End Sub
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    'Public Sub New(ByVal estadoBusqueda As String, ByVal parametro As String)
    '    Me.estado = estadoBusqueda
    '    Me.param = parametro
    '    ' Llamada necesaria para el Diseñador de Windows Forms.
    '    InitializeComponent()
    '    If estado = "buscarCliente" Then
    '        Me.Text = "Busqueda de Clientes"
    '        Dim objClientes As New Clientes
    '        Me.txtParametroCliente.Text = param
    '        cargarGrillaClientes(param)

    '    ElseIf estado = "buscarProveedor" Then
    '        Me.Text = "Busqueda de Proveedor"
    '    End If
    '    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    'End Sub
    Public Sub New(ByVal estadoBusqueda As String)
        Me.estado = estadoBusqueda
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        If estado = "buscarCliente" Then
            Me.Text = "Busqueda de Clientes"
            Dim objClientes As New Clientes
            cargarGrillaClientes()

        ElseIf estado = "buscarProveedor" Then
            Me.Text = "Busqueda de Proveedor"
            Dim objProveedor As New Proveedores
            cargarGrillaProveedores()
        End If
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub txtParametroCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtParametroCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lstNombre.RowCount = 0 Then
                codigo = 0
            Else
                codigo = CInt(lstNombre.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        End If
    End Sub
    Private Sub txtParametroCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtParametroCliente.TextChanged
        If estado = "buscarCliente" Then
            Dim objCliente As New Clientes
            cargarGrillaClientes(Me.txtParametroCliente.Text)
        ElseIf estado = "buscarProveedores" Then
            Dim objProveedor As New Proveedores
            cargarGrillaProveedores(Me.txtParametroCliente.Text)
        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If lstNombre.RowCount = 0 Then
            codigo = 0
        Else
            codigo = CInt(lstNombre.CurrentRow.Cells(0).Value.ToString)
        End If
        'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
        Me.Close()

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        codigo = 0
        Me.Close()
    End Sub


    Private Sub cargarGrillaProveedores()
        Me.lstNombre.Rows.Clear()
        Dim objProveedor As New Proveedores
        Dim odataset As New DataSet
        Dim i As Integer = 0
        odataset = objProveedor.buscarProveedores

        While odataset.Tables(0).Rows.Count > i
            lstNombre.Rows.Add()
            lstNombre.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0)
            lstNombre.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item(2)
            i = i + 1
        End While

    End Sub
    Private Sub cargarGrillaProveedores(ByVal parametro As String)
        lstNombre.Rows.Clear()
        Dim objProveedore As New Proveedores
        Dim odataset As New DataSet
        Dim i As Integer = 0
        odataset = objProveedore.buscarProveedorXnombre(parametro)

        While odataset.Tables(0).Rows.Count > i
            lstNombre.Rows.Add()
            lstNombre.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0)
            lstNombre.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item(2)
            i = i + 1
        End While

    End Sub
End Class