Imports System.Data
Imports System.Data.OleDb
Public Class CondIVA

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region

#Region "atributos"

    Public _idCondIVA As Integer
    Public _descripcion As String

#End Region

#Region "propiedades"

    Public Property idCondIVA() As Integer
        Get
            Return _idCondIVA
        End Get
        Set(value As Integer)
            _idCondIVA = value
        End Set
    End Property

    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property


#End Region

#Region "métodos"

    Public Function buscarDescripcion(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select *  from CondIVA where idCondIVA = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)

        Catch ex As Exception
            MsgBox("No se ha podido acceder a los datos. Consulte su Administrador", MsgBoxStyle.Critical)

        End Try
        Return oDataSet
    End Function

    Public Function buscarDescripcion() As DataSet
        Try
            Dim cadena As String
            cadena = "select *  from CondIVA"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)

        Catch ex As Exception
            MsgBox("No se ha podido acceder a los datos. Consulte su Administrador", MsgBoxStyle.Critical)

        End Try
        Return oDataSet
    End Function

    Public Function eliminarDescripcion(ByVal id As Integer) As DataSet
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Delete from CondIVA Where idCondIVA =" & id
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()

        Catch ex As Exception
            MsgBox("No se ha podido acceder a los datos. Consulte su Administrador", MsgBoxStyle.Critical)

        End Try
        Return oDataSet
    End Function

    Public Sub modificarDescripcion(ByVal objCondIVA As CondIVA)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update CondIVA set descripcion = '" & objCondIVA.descripcion & "' where idCondIVA = " & objCondIVA.idCondIVA
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()

        Catch ex As Exception
            MsgBox("No se ha podido actualizar el registro. Consulte su administrador", MsgBoxStyle.Critical)
        End Try
    End Sub

#End Region

End Class
