Imports System.Data
Imports System.Data.OleDb
Public Class Marca
#Region "Atributos"
    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    ' Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.AppDomain.CurrentDomain.BaseDirectory() & "\baseDatos.mdb;Persist Security Info=False"
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

    Dim _id As Integer
    Dim _descripcion As String

#End Region

#Region "Propiedades"

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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



#End Region

#Region "Metodos"

    'Función para guardar nuevo rubro
    Public Sub nuevaMarca(ByRef objMarca As Marca)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Marca (descripcion) Values ('" & objMarca.descripcion & "')"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            ' MsgBox("Disculpe. No se ha podido registrar el Nueva Marca")
            Exit Sub
        End Try
        'MsgBox("Se registró nueva Marca con Exito!")
    End Sub

    'Función para modificar Rubro
    Public Sub modificarMarca(ByRef objMarca As Marca)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update Marca set descripcion ='" & objMarca.descripcion & "' where idMarca = " & objMarca.id
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            'MsgBox("Disculpe. No se ha podido Actualizar la Marca")
            Exit Sub
        End Try
        ' MsgBox("Se Actualizaron los datos de la Marca con Exito!")
    End Sub

    'Funcion para buscar Rubro por código
    Public Function buscarMarca(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Marca where idMarca =  " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function



    'Funcion para buscar todos los Articulos

    Public Function buscarMarcas() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Marca where borrar = false"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarMarcasLista() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Marca"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para borrar Rubro por Código
    Public Function borrarMarca(ByVal id As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Marca where idMarca = " & id
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            'MsgBox("Disculpe. No se ha podido Eliminar la Marca")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function


#End Region
End Class
