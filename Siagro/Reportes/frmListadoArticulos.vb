Imports System.Data
Imports System.Data.OleDb
Public Class frmListadoArticulos
#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlArticulosDataAdapter As OleDbDataAdapter
    Dim oSqlMarcaDataAdapter As OleDbDataAdapter
    Dim oSqlRubroDataAdapter As OleDbDataAdapter

    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region
    Private Sub cboRubro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarComboRubro()
        Me.cargarComboMarca()
        Me.inicializarControles()
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
    Private Sub cargarComboMarca()
        Dim objMarca As New Marca
        Dim oDataSet As New DataSet
        oDataSet = objMarca.buscarMarcasLista
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboMarca.DataSource = oDataSet.Tables(0)
            Me.cboMarca.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboMarca.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboMarca.SelectedIndex = -1
        End If
    End Sub

    Private Sub inicializarControles()
        Me.opTodosArticulos.Enabled = True
        Me.OpFiltro.Enabled = True
        Me.opEnStock.Enabled = False
        Me.opRubro.Enabled = False
        Me.opMarca.Enabled = False
        Me.opSinStock.Enabled = False
        Me.cboMarca.Enabled = False
        Me.cboRubro.Enabled = False
        Me.cboRubro.SelectedIndex = -1
        Me.cboMarca.SelectedIndex = -1
        Me.opEnStock.Checked = False
        Me.opSinStock.Checked = False
        Me.OpFiltro.Checked = False
        Me.opMarca.Checked = False
        Me.opTodosArticulos.Checked = True
    End Sub

    Private Sub OpFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles OpFiltro.CheckedChanged
        If OpFiltro.Checked = True Then
            Me.opTodosArticulos.Enabled = True
            Me.OpFiltro.Enabled = True
            Me.opEnStock.Enabled = True
            Me.opRubro.Enabled = True
            Me.opMarca.Enabled = True
            Me.opSinStock.Enabled = True
            Me.cboMarca.Enabled = False
            Me.cboRubro.Enabled = False
        Else
            Me.inicializarControles()
        End If
    End Sub

    Private Sub opRubro_CheckedChanged(sender As Object, e As EventArgs) Handles opRubro.CheckedChanged
        If Me.opRubro.Checked = True Then
            Me.cboRubro.Enabled = True
        Else
            Me.cboRubro.Enabled = False
            Me.cboRubro.SelectedIndex = -1
        End If
    End Sub

    Private Sub opMarca_CheckedChanged(sender As Object, e As EventArgs) Handles opMarca.CheckedChanged
        If Me.opMarca.Checked = True Then
            Me.cboMarca.Enabled = True
        Else
            Me.cboMarca.Enabled = False
            Me.cboMarca.SelectedIndex = -1
        End If
    End Sub

    Public Sub llenarReporte()
        Dim cadenaArticulos As String
        Dim cadenaMarca As String
        Dim cadenaRubro As String



        cadenaArticulos = "select * from Articulos"



        If opRubro.Checked = True Then
            cadenaRubro = "select * from Rubro where idRubro=" & cboRubro.SelectedValue
        Else
            cadenaRubro = "select * from Rubro"
        End If

        If opMarca.Checked = True Then
            cadenaMarca = "select * from Marca where idMarca=" & cboMarca.SelectedValue
        Else
            cadenaMarca = "select * from Marca"
        End If

        If opSinStock.Checked = True Then

            If opEnStock.Checked = True Then
                cadenaArticulos = cadenaArticulos & " where stock >= 0"
            Else
                cadenaArticulos = "select * from Articulos where stock = 0"
            End If
        Else
            If opEnStock.Checked = True Then
                cadenaArticulos = "select * from Articulos where stock > 0"
            Else
                cadenaArticulos = "select * from Articulos  where stock >= 0"
            End If
        End If








        oSqlConnection = New OleDbConnection(strConection)

        oSqlArticulosDataAdapter = New OleDbDataAdapter(cadenaArticulos, oSqlConnection)
        oSqlMarcaDataAdapter = New OleDbDataAdapter(cadenaMarca, oSqlConnection)
        oSqlRubroDataAdapter = New OleDbDataAdapter(cadenaRubro, oSqlConnection)

        oDataSet = New dsParaReporte
        oSqlArticulosDataAdapter.Fill(oDataSet, "Articulos")
        oSqlMarcaDataAdapter.Fill(oDataSet, "Marca")
        oSqlRubroDataAdapter.Fill(oDataSet, "Rubro")

        Dim informe As New rpArticulos
        informe.SetDataSource(oDataSet)
        visorArticulos.ReportSource = informe
        visorArticulos.Refresh()


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        llenarReporte()
    End Sub
End Class