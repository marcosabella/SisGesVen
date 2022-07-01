Public Class frmBuscarUsuarios
    Public idUsuarioBusqueda As Integer
    Private Sub frmBuscarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarGrillaUsuarios()
    End Sub
    Private Sub cargarGrillaUsuarios()
        Me.lstClientes.Rows.Clear()
        Dim objUsuarios As New Usuarios
        Dim odataset As New DataSet
        Dim i As Integer = 0
        odataset = objUsuarios.buscarUsuarios
        While odataset.Tables(0).Rows.Count > i
            lstClientes.Rows.Add()
            lstClientes.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0).ToString
            lstClientes.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item("nombre").ToString

            i = i + 1
        End While
        'Me.lblRegistrosEncontrados.Text = odataset.Tables(0).Rows.Count & " registros encontrados"
    End Sub

    Private Sub txtParametro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If lstClientes.RowCount = 0 Then
                idUsuarioBusqueda = 0
            Else
                idUsuarioBusqueda = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        End If
        If e.KeyCode = Keys.Down Then
            lstClientes.Focus()
        End If
    End Sub

    'Private Sub txtParametro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtParametro.TextChanged
    '    Dim objCliente As New Clientes
    '    Me.cargarGrillaClientes(Me.txtParametro.Text)
    'End Sub

    'Private Sub cargarGrillaClientes(ByVal parametro As String)
    '    lstClientes.Rows.Clear()
    '    Dim objUsuarios As New Usuarios
    '    Dim odataset As New DataSet
    '    Dim i As Integer = 0
    '    odataset = objUsuarios.buscarClientesXdescripcion(Me.txtParametro.Text)

    '    While odataset.Tables(0).Rows.Count > i
    '        lstClientes.Rows.Add()
    '        lstClientes.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0).ToString
    '        lstClientes.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item("nombre").ToString & " " & odataset.Tables(0).Rows(i).Item("apellido").ToString

    '        i = i + 1
    '    End While
    '    'Me.lblRegistrosEncontrados.Text = odataset.Tables(0).Rows.Count & " registros encontrados"

    'End Sub

    Private Sub lstClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstClientes.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lstClientes.RowCount = 0 Then
                idUsuarioBusqueda = 0
            Else
                idUsuarioBusqueda = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        idUsuarioBusqueda = 0
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If lstClientes.RowCount = 0 Then
            idUsuarioBusqueda = 0
        Else
            idUsuarioBusqueda = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
        End If
        'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
        Me.Close()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'txtParametro.Focus()
    End Sub

    'Private Sub lstClientes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstClientes.KeyPress
    '    If Char.IsLetter(e.KeyChar) Then
    '        txtParametro.Text = ""
    '        txtParametro.Text = e.KeyChar
    '        txtParametro.SelectionStart = txtParametro.TextLength
    '        txtParametro.Focus()
    '    End If

    'End Sub
End Class