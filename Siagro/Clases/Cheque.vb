Imports System.Data
Imports System.Data.OleDb
Public Class Cheque

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region

#Region "Atributos Cheques"
    Dim _idCheque As Integer
    Dim _nroCheque As Integer
    Dim _emisor As String
    Dim _fecha As Date
    Dim _idBanco As Integer
    Dim _monto As Double
    Dim _vtoCheque As Date
    Dim _idVenta As Integer
    Dim _idPago As Integer
    Dim _enCartera As Boolean
    Dim _idCliente As Integer
    Dim _destinatario As String
#End Region

#Region "Atributos Banco"
    Dim _id As Integer
    Dim _nombre As String
    Dim _sucursal As String

#End Region


#Region "Propiedades Cheques"

    Public Property idCheque() As Integer
        Get
            Return _idCheque
        End Get
        Set(ByVal value As Integer)
            _idCheque = value
        End Set
    End Property


    Public Property idCliente() As Integer
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property
    Public Property nroCheque() As Integer
        Get
            Return _nroCheque
        End Get
        Set(ByVal value As Integer)
            _nroCheque = value
        End Set
    End Property

    Public Property emisor As String
        Get
            Return _emisor
        End Get
        Set(value As String)
            _emisor = value
        End Set
    End Property

    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property idBanco As Integer
        Get
            Return _idBanco
        End Get
        Set(value As Integer)
            _idBanco = value
        End Set
    End Property

    Public Property monto As Double
        Get
            Return _monto
        End Get
        Set(value As Double)
            _monto = value
        End Set
    End Property

    Public Property vtoCheque As Date
        Get
            Return _vtoCheque
        End Get
        Set(value As Date)
            _vtoCheque = value
        End Set
    End Property

    Public Property idVenta As Integer
        Get
            Return _idVenta
        End Get
        Set(value As Integer)
            _idVenta = value
        End Set
    End Property

    Public Property idPago As Integer
        Get
            Return _idPago
        End Get
        Set(value As Integer)
            _idPago = value
        End Set
    End Property

    Public Property enCartera() As Boolean
        Get
            Return _enCartera
        End Get
        Set(ByVal value As Boolean)
            _enCartera = value
        End Set
    End Property

    Public Property destinatario() As String
        Get
            Return _destinatario
        End Get
        Set(ByVal value As String)
            _destinatario = value
        End Set
    End Property
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

#End Region

#Region "metodos cheques"

    Public Sub registrarCheque(ByRef objCheque As Cheque)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Cheques (emisor,fecha,idBanco,monto, vencimiento,idVenta,idPago,nroCheque,enCartera,idCliente) Values ('" & objCheque.emisor & "','" & objCheque.fecha & "'," & objCheque.idBanco & ",'" & objCheque.monto & "','" & objCheque._vtoCheque & "'," & objCheque.idVenta & "," & objCheque.idPago & "," & objCheque.nroCheque & "," & objCheque.enCartera & "," & objCheque.idCliente & ")"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el cheque")
            Exit Sub
        End Try
        'MsgBox("Se registró nuevo Articulo con Exito!")
    End Sub

    Public Sub modificarCheque(ByRef objCheque As Cheque)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            'CadenaSQL = "Update Cheques set codigo_barras = '" & objArticulo.codigo_barras & "', descripcion ='" & objArticulo.descripcion & "', idProveedor = " & objArticulo.idProveedor & ", idRubro = " & objArticulo.idRubro & ", idMarca = " & objArticulo.idMarca & ", costo = '" & objArticulo.costo & "', iva = " & objArticulo.iva & ", utilidad = " & objArticulo.utilidad & ", descuento = " & objArticulo.descuento & ", stock = " & objArticulo.stock & ", comentario = '" & objArticulo.comentario & "', moneda = '" & objArticulo.moneda & "' where idArticulo = " & objArticulo.idArticulo
            CadenaSQL = "Update Cheques set emisor = '" & objCheque.emisor & "',fecha = '" & objCheque.fecha & "',idBanco = " & objCheque.idBanco & ",monto = '" & objCheque.monto & "',venicmiento='" & objCheque._vtoCheque & "',idVenta =" & objCheque.idVenta & "',idPago = " & objCheque.idPago & ",nroCheque = " & objCheque.nroCheque & " where Id = " & objCheque.idCheque
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar el Cheque")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos del Articulo con Exito!")
    End Sub

    Public Sub modificarChequeEncartera(ByRef objCheque As Cheque)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            'CadenaSQL = "Update Cheques set codigo_barras = '" & objArticulo.codigo_barras & "', descripcion ='" & objArticulo.descripcion & "', idProveedor = " & objArticulo.idProveedor & ", idRubro = " & objArticulo.idRubro & ", idMarca = " & objArticulo.idMarca & ", costo = '" & objArticulo.costo & "', iva = " & objArticulo.iva & ", utilidad = " & objArticulo.utilidad & ", descuento = " & objArticulo.descuento & ", stock = " & objArticulo.stock & ", comentario = '" & objArticulo.comentario & "', moneda = '" & objArticulo.moneda & "' where idArticulo = " & objArticulo.idArticulo
            CadenaSQL = "Update Cheques set enCartera = " & objCheque.enCartera & " where Id = " & objCheque.idCheque
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar el Cheque")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos del Articulo con Exito!")
    End Sub

    Public Function buscarCheques() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Cheques "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarChequesXid(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Cheques where id = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarChequesXidVenta(ByVal idVenta As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Cheques where idVenta = " & idVenta
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarChequesXidPago(ByVal idPago As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Cheques where idPago = " & idPago
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarChequesXFechaVencimiento(ByVal fecha As Date) As DataSet
        Try
            Dim cadena As String

            cadena = "select * from Cheques where vencimiento <= #" & FormatDateTime(fecha, DateFormat.ShortDate)

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function borrarCheque(ByVal idCheque As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Cheques where idCheque = " & idCheque
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el cheque")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function

    Public Function borrarChequeXPago(ByVal idPago As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Cheques where idPago = " & idPago
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el cheque")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function

    Public Function borrarChequeXVenta(ByVal idVenta As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Cheques where idVenta = " & idVenta
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el cheque")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function

    Public Function buscarChequesEnCartera() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Cheques where enCartera = true "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarChequesFueraCartera() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Cheques where enCartera = false "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarChequesXparametros(ByVal cadena As String) As DataSet
        Try
            ' Dim cadena As String
            'cadena = "select * from Cheques where enCartera = false "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Sub registrarDestinatario(ByRef objCheque As Cheque)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            'CadenaSQL = "Update Cheques set codigo_barras = '" & objArticulo.codigo_barras & "', descripcion ='" & objArticulo.descripcion & "', idProveedor = " & objArticulo.idProveedor & ", idRubro = " & objArticulo.idRubro & ", idMarca = " & objArticulo.idMarca & ", costo = '" & objArticulo.costo & "', iva = " & objArticulo.iva & ", utilidad = " & objArticulo.utilidad & ", descuento = " & objArticulo.descuento & ", stock = " & objArticulo.stock & ", comentario = '" & objArticulo.comentario & "', moneda = '" & objArticulo.moneda & "' where idArticulo = " & objArticulo.idArticulo
            CadenaSQL = "Update Cheques set destinatario = '" & objCheque.destinatario & "' where Id = " & objCheque.idCheque
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar el Cheque")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos del Articulo con Exito!")
    End Sub

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
