Public Class frmRegistrarCheque

    Public objCheque As New Cheque

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        'Me.cargarComboBanco()
        objCheque = New Cheque
        objCheque = objCheque.inicializar(objCheque)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByVal objChequeParam As Cheque)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Dim oDataSet As New DataSet
        Me.cargarComboBanco()
        objCheque = objChequeParam
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtEmisor.Text = objCheque.emisor
        txtImporte.Text = objCheque.monto
        txtNroCheque.Text = objCheque.nroCheque
        'cboBanco.SelectedValue = objCheque.
        oDataSet = objCheque.buscarBanco(objCheque.idBanco)
        cboBanco.Text = oDataSet.Tables(0).Rows(0).Item("nombre")
        dtpFechaEmisión.Value = objCheque.fecha
        dtpVtoCheque.Value = objCheque.vtoCheque

    End Sub

    Private Sub btnNuevaMarca_Click(sender As Object, e As EventArgs) Handles btnNuevaMarca.Click
        Dim frmBanco As New frmBanco
        frmBanco.ShowDialog()
        cboBanco.DataSource = Nothing
        Me.cargarComboBanco()
    End Sub

    Private Sub frmRegistrarCheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If objCheque.emisor = "" Then
            txtEmisor.Text = ""
            txtImporte.Text = ""
            txtNroCheque.Text = ""
            'cboBanco.SelectedValue = objCheque.
            Me.cargarComboBanco()
            cboBanco.SelectedIndex = -1
            dtpFechaEmisión.Value = Today
            dtpVtoCheque.Value = Today
        End If
    End Sub
    Private Sub cargarComboBanco()
        Dim objCheque As New Cheque
        Dim oDataSet As New DataSet
        oDataSet = objCheque.buscarBancos
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboBanco.DataSource = oDataSet.Tables(0)
            Me.cboBanco.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboBanco.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboBanco.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            objCheque.emisor = Me.txtEmisor.Text
            objCheque.idBanco = cboBanco.SelectedValue
            objCheque.monto = Replace(Me.txtImporte.Text, ".", ",")
            objCheque.vtoCheque = dtpVtoCheque.Value
            objCheque.fecha = dtpFechaEmisión.Value
            objCheque.nroCheque = Me.txtNroCheque.Text
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class