Imports System.Data
Imports System.Data.OleDb
Public Class frmEtiquetasCodigo

    Dim codigoProducto As Integer

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
    Public Sub New(ByRef codigo As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        codigoProducto = codigo
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmEtiquetasCodigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarReporte()
    End Sub

    Public Sub llenarReporte()
        Dim cadenaArticulos As String

        cadenaArticulos = "select * from Articulos where idArticulo =  " & codigoProducto



        oSqlConnection = New OleDbConnection(strConection)

        oSqlArticulosDataAdapter = New OleDbDataAdapter(cadenaArticulos, oSqlConnection)

        oDataSet = New dsParaReporte
        oSqlArticulosDataAdapter.Fill(oDataSet, "Articulos")

        Dim informe As New rpEtiquetas
        informe.SetDataSource(oDataSet)
        visorEtiquetaProducto.ReportSource = informe
        visorEtiquetaProducto.Refresh()


    End Sub
End Class