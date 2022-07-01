Public Class frmBuscarActividades
    Public codigoActividad As Integer

    Private Sub frmBuscarActividades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarGrillaActidades()

    End Sub

    Private Sub cargarGrillaActidades()
        Me.lstActividades.Rows.Clear()
        Dim objAFIP As New AFIP
        Dim odataset As New DataSet
        Dim i As Integer = 0
        odataset = objAFIP.buscarActividades
        While odataset.Tables(0).Rows.Count > i
            lstActividades.Rows.Add()
            lstActividades.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0).ToString
            lstActividades.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item(1).ToString

            i = i + 1
        End While
        Me.lblRegistrosEncontrados.Text = odataset.Tables(0).Rows.Count & " registros encontrados"
    End Sub

    Private Sub txtParametro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtParametro.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lstActividades.RowCount = 0 Then
                codigoActividad = 0
            Else
                codigoActividad = CInt(lstActividades.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        End If
        If e.KeyCode = Keys.Down Then
            lstActividades.Focus()
        End If
    End Sub

    Private Sub txtParametro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtParametro.TextChanged
        Dim objAFIP As New AFIP
        Me.cargarGrillaActividades(Me.txtParametro.Text)
    End Sub

    Private Sub cargarGrillaActividades(ByVal parametro As String)
        lstActividades.Rows.Clear()
        Dim objAFIP As New AFIP
        Dim odataset As New DataSet
        Dim i As Integer = 0
        odataset = objAFIP.buscarActividadXdescripcion(Me.txtParametro.Text)

        While odataset.Tables(0).Rows.Count > i
            lstActividades.Rows.Add()
            lstActividades.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0)
            lstActividades.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item(1)
            i = i + 1

        End While
        Me.lblRegistrosEncontrados.Text = odataset.Tables(0).Rows.Count & " registros encontrados"

    End Sub

    Private Sub lstActividades_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstActividades.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lstActividades.RowCount = 0 Then
                codigoActividad = 0
            Else
                codigoActividad = CInt(lstActividades.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        codigoActividad = 0
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If lstActividades.RowCount = 0 Then
            codigoActividad = 0
        Else
            codigoActividad = CInt(lstActividades.CurrentRow.Cells(0).Value.ToString)
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

    Private Sub lstActividades_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstActividades.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            txtParametro.Text = ""
            txtParametro.Text = e.KeyChar
            txtParametro.SelectionStart = txtParametro.TextLength
            txtParametro.Focus()
        End If
       
    End Sub
End Class