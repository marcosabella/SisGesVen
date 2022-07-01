Imports System.Data
Imports System.Data.OleDb
Public Class Localidades

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region

#Region "atributos"
    Dim _idLocalidad As Integer
    Dim _localidad As String
    Dim _idDepartamento As Integer
    Dim _departamento As String
    Dim _idProvincia As Integer
    Dim _provincia As String
#End Region

#Region "propiedades"

    Property idLocalidad() As Integer
        Get
            Return _idLocalidad
        End Get
        Set(value As Integer)
            _idLocalidad = value
        End Set
    End Property

    Property localidad() As String
        Get
            Return _localidad
        End Get
        Set(value As String)
            _localidad = value
        End Set
    End Property

    Property idDepartamento() As Integer
        Get
            Return _idDepartamento
        End Get
        Set(value As Integer)
            _idDepartamento = value
        End Set
    End Property

    Property departamento() As String
        Get
            Return _departamento
        End Get
        Set(value As String)
            _departamento = value
        End Set
    End Property

    Property idProvincia() As Integer
        Get
            Return _idProvincia
        End Get
        Set(value As Integer)
            _idProvincia = value
        End Set
    End Property

    Property provincia() As String
        Get
            Return _provincia
        End Get
        Set(value As String)
            _provincia = value
        End Set
    End Property

#End Region

#Region "métodos"

    Public Function buscarLocalidad() As DataSet
        Try
            Dim cadena As String
            cadena = "select *  from Localidades"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)

        Catch ex As Exception
            MsgBox("No se ha podido acceder a los datos. Consulte su Administrador", MsgBoxStyle.Critical)

        End Try
        Return oDataSet
    End Function

    Public Function buscarLocalidad(ByVal nombreLocalidad As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select *  from Localidad where localidad like '" & nombreLocalidad & "%'"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)

        Catch ex As Exception
            MsgBox("No se ha podido acceder a los datos. Consulte su Administrador", MsgBoxStyle.Critical)

        End Try
        Return oDataSet
    End Function

    Public Function buscarLocalidad(ByVal idLocalidad As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select *  from Localidad where idLocalidad =" & idLocalidad
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)

        Catch ex As Exception
            MsgBox("No se ha podido acceder a los datos. Consulte su Administrador", MsgBoxStyle.Critical)

        End Try
        Return oDataSet
    End Function

    Public Function buscarDepartamento(ByVal idDepartamento As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select *  from Departamento where idDepartamento =" & idDepartamento
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)

        Catch ex As Exception
            MsgBox("No se ha podido acceder a los datos. Consulte su Administrador", MsgBoxStyle.Critical)

        End Try
        Return oDataSet
    End Function

    Public Function buscarProvincia(ByVal idProvincia As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select *  from Provincia where idProvincia =" & idProvincia
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)

        Catch ex As Exception
            MsgBox("No se ha podido acceder a los datos. Consulte su Administrador", MsgBoxStyle.Critical)

        End Try
        Return oDataSet
    End Function

#End Region

End Class
