Imports System.Data
Imports System.Data.OleDb
Public Class CondicionVenta

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region
#Region "Atributos"

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

    'Función para guardar nueva condicion de venta
    Public Sub nuevaCondicionVenta(ByRef objCondicionVenta As CondicionVenta)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into CondicionVenta (descripcion) Values ('" & objCondicionVenta.descripcion & "')"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el Nueva Condicion de Venta")
            Exit Sub
        End Try
        MsgBox("Se registró nueva Condicion de Venta con Exito!")
    End Sub

    'Función para modificar condicion de venta
    Public Sub modificarCondicionVenta(ByRef objCondicionVenta As CondicionVenta)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update CondicionVenta set descripcion ='" & objCondicionVenta.descripcion & "' where idCondicion_Venta = " & objCondicionVenta.id
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar la Condicion de Venta")
            Exit Sub
        End Try
        MsgBox("Se Actualizaron los datos de la Condicion de Venta con Exito!")
    End Sub

    'Funcion para buscar Rubro por código
    Public Function buscarCondicionVenta(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from CondicionVenta where idCondicion_Venta =  " & id
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

    Public Function buscarCondicionVenta() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from CondicionVenta"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para borrar CondicionVenta por Código
    Public Function borrarCondicionVenta(ByVal id As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from CondicionVenta where idCondicion_Venta = " & id
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar la Condicion de Venta")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function


#End Region
End Class
