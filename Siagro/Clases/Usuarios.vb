Imports System.Data
Imports System.Data.OleDb
Public Class Usuarios

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region

#Region "atributos"

    Dim _idUsuario As Integer
    Dim _nombreUsuario As String
    Dim _usuarioSistema As String
    Dim _contrasena As String

    Dim _opClientes As Boolean
    Dim _opProveedores As Boolean
    Dim _opProductos As Boolean
    Dim _opVentas As Boolean
    Dim _opListaPrecios As Boolean
    Dim _opConfigiracion As Boolean
    Dim _opCtacte As Boolean
    Dim _opListados As Boolean

#End Region


#Region "propiedades"

    Public Property idUsuario As Integer
        Set(value As Integer)
            _idUsuario = value
        End Set
        Get
            Return _idUsuario
        End Get
    End Property

    Public Property nombreUsuario As String
        Get
            Return _nombreUsuario
        End Get
        Set(value As String)
            _nombreUsuario = value
        End Set
    End Property

    Public Property usuarioSistema As String
        Get
            Return _usuarioSistema
        End Get
        Set(value As String)
            _usuarioSistema = value
        End Set
    End Property

    Public Property contrasena As String
        Get
            Return _contrasena
        End Get
        Set(value As String)
            _contrasena = value
        End Set
    End Property

    Public Property opClientes As Boolean
        Set(value As Boolean)
            _opClientes = value
        End Set
        Get
            Return _opClientes
        End Get
    End Property

    Public Property opProveedores As Boolean
        Set(value As Boolean)
            _opProveedores = value
        End Set
        Get
            Return _opProveedores
        End Get
    End Property

    Public Property opProductos As Boolean
        Set(value As Boolean)
            _opProductos = value
        End Set
        Get
            Return _opProductos
        End Get
    End Property

    Public Property opVentas As Boolean
        Set(value As Boolean)
            _opVentas = value
        End Set
        Get
            Return _opVentas
        End Get
    End Property

    Public Property opListaPrecios As Boolean
        Set(value As Boolean)
            _opListaPrecios = value
        End Set
        Get
            Return _opListaPrecios
        End Get
    End Property

    Public Property opConfiguracion As Boolean
        Set(value As Boolean)
            _opConfigiracion = value
        End Set
        Get
            Return _opConfigiracion
        End Get
    End Property

    Public Property opCtaCte As Boolean
        Set(value As Boolean)
            _opCtacte = value
        End Set
        Get
            Return _opCtacte
        End Get
    End Property

    Public Property opListados As Boolean
        Set(value As Boolean)
            _opListados = value
        End Set
        Get
            Return _opListados
        End Get
    End Property
#End Region

#Region "métodos"

    Public Function nuevoUsuario(ByRef objUsuario As Usuarios) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Usuarios (nombre, usuarioSistema, contrasena,clientes, proveedores,productos,ventas,listaPrecios,configuracion,ctacte,listados) Values ('" & objUsuario.nombreUsuario & "','" & objUsuario.usuarioSistema & "','" & objUsuario.contrasena & "'," & objUsuario.opClientes & "," & objUsuario.opProveedores & "," & objUsuario.opProductos & "," & objUsuario.opVentas & "," & objUsuario.opListaPrecios & "," & objUsuario.opConfiguracion & "," & objUsuario.opCtaCte & "," & objUsuario.opListados & ")"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el Nuevo Usuario" & ex.Message)
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nuevo Cliente con Exito!")
        Return True
    End Function

    Public Function buscarUsuario(ByVal usuarioSistema As String, ByVal contrasena As String) As DataSet
        Try
            Dim cadena As String
            'cadena = "select * from Usuarios where usuarioSistema =  '" & usuarioSistema & "' and contrasena = '" & contrasena & "'"
            cadena = "select * from Usuarios where InStr(1, usuarioSistema,'" & usuarioSistema & "', 0)<>0  and  InStr(1, contrasena,'" & contrasena & "', 0)<>0"

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarUsuarios() As DataSet
        Try
            Dim cadena As String
            cadena = "Select * from Usuarios where idUsuario > 1"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarUsuariosXid(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "Select * from Usuarios where idUsuario =" & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function existeUsuario(ByVal usuarioSistema As String) As DataSet
        Try
            Dim cadena As String
            cadena = "Select * from Usuarios where usuarioSistema = '" & usuarioSistema & "'"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function modificarUsuario(ByRef objUsuario As Usuarios) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "update  Usuarios  set nombre ='" & objUsuario.nombreUsuario & "', usuarioSistema = '" & objUsuario.usuarioSistema & "', contrasena = '" & objUsuario.contrasena & "', clientes = " & objUsuario.opClientes & ", proveedores = " & objUsuario.opProveedores & ",productos=" & objUsuario.opProductos & ",ventas= " & objUsuario.opVentas & ",listaPrecios = " & objUsuario.opListaPrecios & " ,configuracion = " & objUsuario.opConfiguracion & ",ctacte = " & objUsuario.opCtaCte & " ,listados  = " & objUsuario.opListados & " where idUsuario = " & objUsuario.idUsuario
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido modificar el Usuario" & ex.Message)
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nuevo Cliente con Exito!")
        Return True
    End Function

    Public Function borrarUsuario(ByVal idUsuario As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Usuarios where idUsuario = " & idUsuario
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el Cliente")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function
#End Region
End Class
