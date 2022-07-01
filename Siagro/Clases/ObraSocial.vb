Imports System.Data
Imports System.Data.OleDb
Public Class ObraSocial
#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region

#Region "Atributos"

    Dim _idObraSocial As Integer
    Dim _descripcion As String

    Dim _idDescuento As Integer
    Dim _descuento As Double

#End Region

#Region "Propiedades"

    Public Property idObraSocial() As Integer
        Get
            Return _idObraSocial
        End Get
        Set(ByVal value As Integer)
            _idObraSocial = value
        End Set
    End Property

    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property idDescuento() As Integer
        Get
            Return _idDescuento
        End Get
        Set(ByVal value As Integer)
            _idDescuento = value
        End Set
    End Property

    Public Property descuento() As Double
        Get
            Return _descuento
        End Get
        Set(ByVal value As Double)
            _descuento = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Function buscarObraSocial() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from ObraSocial"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarObraSocialXdescripcion(ByVal parametro As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from ObraSocial where descripcion  like '%" & parametro & "%'"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarObraSocialXID(ByVal idOS As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from ObraSocial where idObraSocial  = " & idOS
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarDescuentoXOS(ByVal idOS As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from DescuentosPorObraSocial where idObraSocial  = " & idOS
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarDescuentoXID(ByVal idDescuento As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from DescuentosPorObraSocial where idDescuento  = " & idDescuento
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
#End Region

End Class
