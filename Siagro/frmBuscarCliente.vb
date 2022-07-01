Public Class frmBuscarCliente
    Public idClienteBusqueda As Integer

    Private Sub frmBuscarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        progreso.Visible = False
        Me.cargarGrillaClientes()
    End Sub

    Private Sub cargarGrillaClientes()
        Try
            Dim objClientes As New Clientes
            Dim odataset As New DataSet

            odataset = objClientes.buscarClientes

            dgvClientes.DataSource = Nothing
            dgvClientes.Visible = True
            Dim objArticulos As New Articulos
            Dim oDataTable As New DataTable
            Dim i As Integer = 0

            If odataset.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            '//nuevo
            oDataTable = odataset.Tables(0)
            dgvClientes.DataSource = oDataTable

            dgvClientes.Columns(0).Visible = False
            dgvClientes.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgvClientes.Columns(1).HeaderText = "CUIT"
            dgvClientes.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvClientes.Columns(2).HeaderText = "Cliente"

            Me.txtParametro.Focus()

            Me.lblRegistrosEncontrados.Text = odataset.Tables(0).Rows.Count & " registros encontrados"

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtParametro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtParametro.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lstClientes.RowCount = 0 Then
                idClienteBusqueda = 0
            Else
                idClienteBusqueda = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        ElseIf e.KeyCode = Keys.Down Then
            dgvClientes.Focus()
        Else
            txtParametro.Focus()
        End If
    End Sub

    Private Sub txtParametro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtParametro.TextChanged
        Dim objCliente As New Clientes
        Me.cargarGrillaClientes(Me.txtParametro.Text)
    End Sub

    Private Sub cargarGrillaClientes(ByVal parametro As String)
        Try
            lstClientes.Rows.Clear()
            Dim objCliente As New Clientes
            Dim odataset As New DataSet

            odataset = objCliente.buscarClientesXdescripcion(Me.txtParametro.Text)

            dgvClientes.DataSource = Nothing
            dgvClientes.Visible = True
            Dim objArticulos As New Articulos
            Dim oDataTable As New DataTable
            Dim i As Integer = 0

            If odataset.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            '//nuevo
            oDataTable = odataset.Tables(0)
            dgvClientes.DataSource = oDataTable

            dgvClientes.Columns(0).Visible = False
            dgvClientes.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgvClientes.Columns(1).HeaderText = "CUIT"
            dgvClientes.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvClientes.Columns(2).HeaderText = "Cliente"

            Me.txtParametro.Focus()

            Me.lblRegistrosEncontrados.Text = odataset.Tables(0).Rows.Count & " registros encontrados"

        Catch ex As Exception

        End Try

    End Sub

    Private Sub lstClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstClientes.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lstClientes.RowCount = 0 Then
                idClienteBusqueda = 0
            Else
                idClienteBusqueda = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        idClienteBusqueda = 0
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If dgvClientes.RowCount = 0 Then
            idClienteBusqueda = 0
        Else
            idClienteBusqueda = CInt(dgvClientes.CurrentRow.Cells(0).Value.ToString)
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

    Private Sub lstClientes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstClientes.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            txtParametro.Text = ""
            txtParametro.Text = e.KeyChar
            txtParametro.SelectionStart = txtParametro.TextLength
            txtParametro.Focus()
        End If

    End Sub



    Private Sub dgvClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvClientes.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgvClientes.RowCount = 0 Then
                idClienteBusqueda = 0
            Else
                idClienteBusqueda = CInt(dgvClientes.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            dgvClientes.Focus()
        ElseIf e.KeyCode = Keys.Back Then
            txtParametro.Focus()
            txtParametro.Text = ""
        Else
            txtParametro.Focus()
            txtParametro.Text = Chr(e.KeyCode)
            txtParametro.Select(txtParametro.Text.Length, 0)
            'txtParametro.Focus()
        End If
    End Sub


End Class