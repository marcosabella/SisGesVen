Imports System.Data
Imports System.Data.OleDb
Public Class frmRecibo
    Dim idPago As Integer

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection

    Dim oSqlPagosDataAdapter As OleDbDataAdapter
    Dim oSqlClienteDataAdapter As OleDbDataAdapter

    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"
#End Region
    Public Sub New(ByVal id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        idPago = id
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub frmRecibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarReporte()
    End Sub

    Public Sub llenarReporte()

        Dim cadenaPago As String
        Dim cadenaCliente As String
        'Dim cadenaComprobante As String

        cadenaPago = "select * from Pagos where idPago = " & idPago
        cadenaCliente = "select * from Clientes"

        oSqlConnection = New OleDbConnection(strConection)

        oSqlClienteDataAdapter = New OleDbDataAdapter(cadenaCliente, oSqlConnection)
        oSqlPagosDataAdapter = New OleDbDataAdapter(cadenaPago, oSqlConnection)



        oDataSet = New dsParaReporte
        oSqlClienteDataAdapter.Fill(oDataSet, "Clientes")
        oSqlPagosDataAdapter.Fill(oDataSet, "Pagos")


        Dim informe As New rpRecibo
        informe.SetDataSource(oDataSet)
        visorRecibo.ReportSource = informe


    End Sub

End Class