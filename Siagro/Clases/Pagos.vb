Imports System.Data
Imports System.Data.OleDb
Public Class Pagos
#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region
#Region "Atributos"

    Dim _idPago As Integer
    Dim _fecha_pago As String
    Dim _idCliente As Integer
    Dim _idProveedor As Integer
    Dim _observaciones As String
    Dim _importe As Double
    Dim _idCondicion_venta As Integer


#End Region
#Region "Propiedades"

    Public Property idPago() As Integer
        Get
            Return _idPago
        End Get
        Set(ByVal value As Integer)
            _idPago = value
        End Set
    End Property

    Public Property idCondicion_venta() As Integer
        Get
            Return _idCondicion_venta
        End Get
        Set(ByVal value As Integer)
            _idCondicion_venta = value
        End Set
    End Property

    Public Property fecha_pago() As String
        Get
            Return _fecha_pago
        End Get
        Set(ByVal value As String)
            _fecha_pago = value
        End Set
    End Property
    Public Property observaciones() As String
        Get
            Return _observaciones
        End Get
        Set(ByVal value As String)
            _observaciones = value
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

    Public Property idProveedor() As Integer
        Get
            Return _idProveedor
        End Get
        Set(ByVal value As Integer)
            _idProveedor = value
        End Set
    End Property
    Public Property importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
        End Set
    End Property




#End Region
#Region "Metodos"

    Public Function ultimoPago() As DataSet
        Try
            Dim cadena As String
            cadena = "select max(idPago) from Pagos"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Función para guardar nuevo pago
    Public Sub nuevoPago(ByRef objPago As Pagos)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Pagos (idCliente,fecha_pago,importe,observaciones,idCondicion_venta) Values (" & objPago.idCliente & ",'" & objPago.fecha_pago & "', '" & objPago.importe & "', '" & objPago.observaciones & "', " & objPago.idCondicion_venta & ")"

            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el pago")

        End Try


    End Sub

    'Funcion para buscar pagos por id cliente
    Public Function buscarPagosXcliente(ByVal idCliente As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Pagos where idCliente = " & idCliente
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar pagos por id pago
    Public Function buscarPagosXid(ByVal idPago As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Pagos where idPago = " & idPago
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


    'Función para borrar pago
    Public Function borrarPago(ByVal idPago As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Pagos where idPago = " & idPago
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el Pago")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function

    'Función para modificar venta
    Public Sub modificarPago(ByRef objPago As Pagos)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update Pagos set importe ='" & objPago.importe & "',idCondicion_venta= " & objPago.idCondicion_venta & "  where idPago = " & objPago.idPago
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar el pago")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos del pago con Exito!")
    End Sub

    Public Function buscarSumaPagosXcliente(ByVal idCliente As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select sum(importe) from Pagos where idCliente = " & idCliente
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


#Region "Pagos Proveedores"

    Public Sub nuevoPagoProveedores(ByRef objPago As Pagos)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into PagosProveedores (idProveedor,fecha_pago,importe,observaciones,idCondicion_venta) Values (" & objPago.idProveedor & ",'" & objPago.fecha_pago & "', '" & objPago.importe & "', '" & objPago.observaciones & "', " & objPago.idCondicion_venta & ")"
            'CadenaSQL = ""
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el pago")

        End Try


    End Sub

    Public Function ultimoPagoProveedor() As DataSet
        Try
            Dim cadena As String
            cadena = "select max(idPago) from PagosProveedores"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Sub modificarPagoProveedor(ByRef objPago As Pagos)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update PagosProveedores set importe ='" & objPago.importe & "', idCondicion_venta = " & objPago.idCondicion_venta & " where idPago = " & objPago.idPago
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar el pago")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos del pago con Exito!")
    End Sub

    Public Function borrarPagoProveedor(ByVal idPago As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from PagosProveedores where idPago = " & idPago
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el Pago")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function

#End Region

#End Region

#Region "Tarjetas de crédito"
    Public Function buscarTarjetasPago() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Tarjetas"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarTarjetasPago(ByVal idTarjeta As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Tarjetas where idTarjeta = " & idTarjeta
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function nuevaTarjetaPorPAgo(ByRef idTarjeta As Integer, ByRef idOrden As Integer, ByRef idPago As Integer, ByRef cuponNumero As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into TarjetaPorPago (idTarjeta, idOrden, idPago,cuponNumero) Values (" & idTarjeta & "," & idOrden & "," & idPago & "," & cuponNumero & ")"
            'CadenaSQL = ""
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el detalle de la venta")
            Return False
        End Try
        'MsgBox("Se registró nuevo detalle de venta con Exito!")
        Return True
    End Function

    Public Function borrarTarjetaPorPago(ByVal idPago As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from TarjetaPorPago where idPago = " & idPago
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el detalle de la venta")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function

    Public Function buscarTarjetasPagoPorID(ByVal idTarjeta As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from TarjetaPorPago where idTarjeta = " & idTarjeta
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarTarjetasVentaPorIDPago(ByVal idPago As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from TarjetaPorPago where idPago = " & idPago
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarTarjetasVentaPorIDOrden(ByVal idVenta As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from TarjetaPorVenta where idOrden = " & idVenta
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function borrarTarjetaPorOT(ByVal idOrden As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from TarjetaPorVenta where idOrden = " & idOrden
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el detalle de la venta")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function


#End Region

#Region "transferencia"


    Public Function nuevaTransferenciaPorPago(ByRef idBanco As Integer, ByRef idPago As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into TransferenciaXpago (idBanco, idPago) Values (" & idBanco & "," & idPago & ")"
            'CadenaSQL = ""
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido el detalle de la transferencia")
            Return False
        End Try
        'MsgBox("Se registró nuevo detalle de venta con Exito!")
        Return True
    End Function

    Public Function borrarTransferenciaPorPago(ByVal idPago As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from TransferenciaXpago where idPago = " & idPago
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el detalle de la transferencia por venta")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function

    Public Function buscarTransferenciaVentaPorIDPago(ByVal idPago As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from TransferenciaXpago, Banco where TransferenciaXventa.idVenta = " & idPago & " and Banco.id = TransferenciaXventa.idBanco"
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
