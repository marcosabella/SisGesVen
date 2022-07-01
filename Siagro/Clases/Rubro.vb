Imports System.Data
Imports System.Data.OleDb
Public Class Rubro
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
    Public Sub nuevoRubro(ByRef objRubro As Rubro)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Rubro (descripcion) Values ('" & objRubro.descripcion & "')"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            'MsgBox("Disculpe. No se ha podido registrar el Nuevo Rubro")
            Exit Sub
        End Try
        ' MsgBox("Se registró nuevo Rubro con Exito!")
    End Sub

    'Función para modificar Rubro
    Public Sub modificarRubro(ByRef objRubro As Rubro)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update Rubro set descripcion ='" & objRubro.descripcion & "' where idRubro = " & objRubro.id
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            'MsgBox("Disculpe. No se ha podido Actualizar el Rubro")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos del Rubro con Exito!")
    End Sub

    'Funcion para buscar Rubro por código
    Public Function buscarRubro(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Rubro where idRubro =  " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    ''Funcion para buscar Articulo por descripcion
    'Public Function buscarArticuloXdescripcion(ByVal parametro As String) As DataSet
    '    Try
    '        Dim cadena As String
    '        cadena = "select * from Articulos where descripcion like '%" & parametro & "%'"
    '        oSqlConnection = New OleDbConnection(strConection)
    '        oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
    '        oDataSet = New DataSet
    '        oSqlDataAdapter.Fill(oDataSet)
    '        Return oDataSet
    '    Catch ex As Exception

    '    End Try

    'End Function

    'Funcion para buscar todos los Articulos

    Public Function buscarRubros() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Rubro where borrar = false"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarRubrosLista() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Rubro"
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
    Public Function borrarRubros(ByVal id As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Rubro where idRubro = " & id
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            'MsgBox("Disculpe. No se ha podido Eliminar el Rubro")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function


#End Region

End Class
