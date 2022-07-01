Imports System.Data
Imports System.Data.OleDb
Public Class frmListadoProveedores

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlDataAdapter1 As OleDbDataAdapter
    Dim oSqlDomicilioDataAdapter As OleDbDataAdapter
    Dim oSqlLocalidadDataAdapter As OleDbDataAdapter
    Dim oSqlDocumentosDataAdapter As OleDbDataAdapter
    Dim oSqlResponsableDataAdapter As OleDbDataAdapter

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
        Dim cadenaDocumentos As String
        Dim cadenaResponsable As String

        cadena = "select * from Proveedores order by razon_social asc"
        cadenaCondIva = "select * from CondIva"
        cadenaDocumentos = "select * from Documentos"
        cadenaDomicilio = "select * from Domicilio_x_proveedor"
        cadenaLocalidad = "select * from Localidades"
        cadenaResponsable = "select * from Responsable_x_proveedor"
        oSqlConnection = New OleDbConnection(strConection)

        oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
        oSqlDataAdapter1 = New OleDbDataAdapter(cadenaCondIva, oSqlConnection)
        oSqlDocumentosDataAdapter = New OleDbDataAdapter(cadenaDocumentos, oSqlConnection)
        oSqlDomicilioDataAdapter = New OleDbDataAdapter(cadenaDomicilio, oSqlConnection)
        oSqlLocalidadDataAdapter = New OleDbDataAdapter(cadenaLocalidad, oSqlConnection)
        oSqlResponsableDataAdapter = New OleDbDataAdapter(cadenaResponsable, oSqlConnection)

        oDataSet = New dsParaReporte
        oSqlDataAdapter.Fill(oDataSet, "Proveedores")
        oSqlDataAdapter1.Fill(oDataSet, "CondIva")
        oSqlDocumentosDataAdapter.Fill(oDataSet, "Documentos")
        oSqlDomicilioDataAdapter.Fill(oDataSet, "Domicilio_x_proveedor")
        oSqlLocalidadDataAdapter.Fill(oDataSet, "Localidades")
        oSqlResponsableDataAdapter.Fill(oDataSet, "Responsable_x_proveedor")

        Dim informe As New rpProveedores
        informe.SetDataSource(oDataSet)
        visorProveedores.ReportSource = informe


    End Sub

    Private Sub frmListadoProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarReporte()
    End Sub
End Class