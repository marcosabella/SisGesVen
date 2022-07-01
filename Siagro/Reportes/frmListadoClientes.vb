Imports System.Data
Imports System.Data.OleDb
Public Class frmListadoClientes

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlDataAdapter1 As OleDbDataAdapter
    Dim oSqlDomicilioDataAdapter As OleDbDataAdapter
    Dim oSqlLocalidadDataAdapter As OleDbDataAdapter

    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region


    Public Sub llenarReporte()
        Dim cadena As String
        Dim cadenaCondIva As String
        Dim cadenaDomicilio As String
        Dim cadenaLocalidad As String

        cadena = "select * from Clientes order by apellido asc"
        'cadenaCondIva = "select * from CondIva"
        'cadenaDomicilio = "select * from Domicilio_x_cliente"
        'cadenaLocalidad = "select * from Localidades"

        oSqlConnection = New OleDbConnection(strConection)

        oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
        'oSqlDataAdapter1 = New OleDbDataAdapter(cadenaCondIva, oSqlConnection)
        'oSqlDomicilioDataAdapter = New OleDbDataAdapter(cadenaDomicilio, oSqlConnection)
        'oSqlLocalidadDataAdapter = New OleDbDataAdapter(cadenaLocalidad, oSqlConnection)

        oDataSet = New dsParaReporte
        oSqlDataAdapter.Fill(oDataSet, "Clientes")
        'oSqlDataAdapter1.Fill(oDataSet, "CondIva")
        'oSqlDomicilioDataAdapter.Fill(oDataSet, "Domicilio_x_cliente")
        'oSqlLocalidadDataAdapter.Fill(oDataSet, "Localidades")

        Dim informe As New rpClientes
        informe.SetDataSource(oDataSet)
        visorReporteCliente.ReportSource = informe


    End Sub

    Private Sub frmListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.llenarReporte()
        'Dim informe As New prueba
        'informe.SetDataSource(oDataSet)
        'visorReporteCliente.ReportSource = informe
    End Sub
End Class