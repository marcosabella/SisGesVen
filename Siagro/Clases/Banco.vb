Imports System.Data
Imports System.Data.OleDb
Public Class Banco

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region


#Region "Atributos Banco"
    Dim _id As Integer
    Dim _nombre As String
    Dim _sucursal As String
    Dim _propio As Boolean

#End Region




#Region "propiedades banco"

    Public Property idBancos As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property nombreBanco As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property sucursal As String
        Get
            Return _sucursal
        End Get
        Set(value As String)
            _sucursal = value
        End Set
    End Property

    Public Property propio As Boolean
        Get
            Return _propio
        End Get
        Set(value As Boolean)
            _propio = value
        End Set
    End Property

#End Region


#Region "metodos Banco"

    'Función para guardar nuevo rubro
    Public Sub nuevoBanco(ByRef objCheque As Cheque)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Banco (nombre) Values ('" & objCheque.nombreBanco & "')"
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
    Public Sub modificarBanco(ByRef objCheque As Cheque)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update Banco set nombre ='" & objCheque.nombreBanco & "' where Id = " & objCheque.idBanco
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
    Public Function buscarBanco(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Banco where Id =  " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar todos los Articulos

    Public Function buscarBancos() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Banco"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarBancosPropios() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Banco where propio = true"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para borrar Rubro por Código
    Public Function borrarBanco(ByVal id As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Banco where Id = " & id
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

    Public Function inicializar(ByVal objcheque As Cheque)
        objcheque.emisor = ""
        'objCheque.fecha = ""
        objcheque.idBanco = 0
        objcheque.idBancos = 0
        objcheque.idPago = 0
        objcheque.idVenta = 0
        objcheque.monto = 0
        objcheque.nombreBanco = ""
        objcheque.nroCheque = 0
        objcheque.sucursal = ""
        'objCheque.vtoCheque = ""
        Return objcheque
    End Function

End Class
