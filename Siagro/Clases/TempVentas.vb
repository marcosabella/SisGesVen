Imports System.Data
Imports System.Data.OleDb
Public Class TempVentas

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region

#Region "Atributos"

    Dim _idVenta As Integer
    Dim _fecha_venta As String
    Dim _idCondicion_venta As Integer
    Dim _idCliente As Integer
    Dim _idIva As Integer
    Dim _descuento_venta As Double
    Dim _recargo_venta As Double
    Dim _idUsuario As Integer
    Dim _idComprobante As Integer
    Dim _monto As Double
    Dim _numeroComprobante As String
    Dim _numVenta As Integer

    Dim _idDetalle_venta As Integer
    Dim _idArticulo As Integer
    Dim _cantidad As Double
    Dim _precioUnitario As Double

    Dim _cotizacion As Integer
    Dim _precioDolar As Double
    Dim _observaciones As String
    Dim _tipoDolar As String
    'TARJETAS DE CRÉDITO
    Dim _idTarjeta As Integer
    Dim _descripcion As String
    Dim _porcRecargo As Double

#End Region

#Region "Propiedades"

    Public Property idVenta() As Integer


        Get
            Return _idVenta
        End Get
        Set(ByVal value As Integer)
            _idVenta = value
        End Set
    End Property

    Public Property numVenta() As Integer


        Get
            Return _numVenta
        End Get
        Set(ByVal value As Integer)
            _numVenta = value
        End Set
    End Property

    Public Property cotizacion() As Double
        Get
            Return _cotizacion
        End Get
        Set(ByVal value As Double)
            _cotizacion = value
        End Set
    End Property
    Public Property idComprobante() As Integer
        Get
            Return _idComprobante
        End Get
        Set(ByVal value As Integer)
            _idComprobante = value
        End Set
    End Property

    Public Property idDetalle_venta() As Integer
        Get
            Return _idDetalle_venta
        End Get
        Set(ByVal value As Integer)
            _idDetalle_venta = value
        End Set
    End Property

    Public Property fecha_venta() As String
        Get
            Return _fecha_venta
        End Get
        Set(ByVal value As String)
            _fecha_venta = value
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

    Public Property idCliente() As Integer
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property

    Public Property idIva() As Integer
        Get
            Return _idIva
        End Get
        Set(ByVal value As Integer)
            _idIva = value
        End Set
    End Property

    Public Property idArticulo() As Integer
        Get
            Return _idArticulo
        End Get
        Set(ByVal value As Integer)
            _idArticulo = value
        End Set
    End Property

    Public Property cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property

    Public Property descuento_venta() As Double
        Get
            Return _descuento_venta
        End Get
        Set(ByVal value As Double)
            _descuento_venta = value
        End Set
    End Property

    Public Property recargo_venta() As Double
        Get
            Return _recargo_venta
        End Get
        Set(ByVal value As Double)
            _recargo_venta = value
        End Set
    End Property

    Public Property idUsuario() As Double
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As Double)
            _idUsuario = value
        End Set
    End Property

    Public Property precioDolar() As Double
        Get
            Return _precioDolar
        End Get
        Set(ByVal value As Double)
            _precioDolar = value
        End Set
    End Property

    Public Property tipoDolar As String
        Get
            Return _tipoDolar
        End Get
        Set(value As String)
            _tipoDolar = value
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

    Public Property monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    Public Property precioUnitario() As Double
        Get
            Return _precioUnitario
        End Get
        Set(ByVal value As Double)
            _precioUnitario = value
        End Set
    End Property

    Public Property idTarjetas As Integer
        Get
            Return _idTarjeta
        End Get
        Set(value As Integer)
            _idTarjeta = value
        End Set
    End Property

    Public Property descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property porcRecargo As Double
        Get
            Return _porcRecargo
        End Get
        Set(value As Double)
            _porcRecargo = value
        End Set
    End Property

    Public Property numeroComprobante() As String
        Get
            Return _numeroComprobante
        End Get
        Set(ByVal value As String)
            _numeroComprobante = value
        End Set
    End Property
#End Region

#Region "Metodos"

    'Función para guardar nueva venta
    Public Function nuevaVenta(ByRef objTempVentas As TempVentas) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into TempVentas (fecha_venta,idCondicion_venta,idCliente,descuento_venta,recargo_venta,idComprobante,monto,observaciones,numeroComprobante, numVenta) Values ('" & objTempVentas.fecha_venta & "'," & objTempVentas.idCondicion_venta & "," & objTempVentas.idCliente & "," & objTempVentas.descuento_venta & "," & objTempVentas.recargo_venta & "," & objTempVentas.idComprobante & ",'" & objTempVentas.monto & "','" & objTempVentas.observaciones & "','" & objTempVentas.numeroComprobante & "'," & objTempVentas.numVenta & ")"
            'CadenaSQL = ""
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar la nueva venta")
            Return False
        End Try
        'MsgBox("Se registró nueva venta con Exito!")
        Return True
    End Function

    'Función para guardar nuevo detalle de  venta
    Public Function nuevoDetalleVenta(ByRef objTempVentas As TempVentas) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into TempDetalle_Venta (idVenta, idArticulo, cantidad, precioUnitario,cotizacion) Values (" & objTempVentas.idDetalle_venta & "," & objTempVentas.idArticulo & ",'" & objTempVentas.cantidad & "','" & objTempVentas.precioUnitario & "','" & objTempVentas.cotizacion & "')"
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

    'Funcion para buscar todas las Ventas
    Public Function buscarTodasLasVentas() As DataSet
        Try
            Dim cadena As String
            'cadena = "select *,(select Descripcion from Comprobantes where Codigo = v.idComprobante)  from Ventas v, Comprobantes c"
            'cadena = "select (select nombre & ' ' &  apellido from Clientes where idCliente = v.idCliente) as nombreCliente,  v.idVenta, v.fecha_venta, v.monto,(select descripcion from CondicionVenta where idCondicion_venta = v.idCondicion_venta ) as CondVenta  , v.idCliente , v.descuento_venta , v.recargo_venta, (select Descripcion from Comprobantes where Codigo = v.idComprobante) as Descripcion  from Ventas v, Comprobantes c, CondicionVenta cv group by  v.idVenta, v.fecha_venta,v.idCondicion_venta, v.idCliente  , v.descuento_venta, v.recargo_venta, v.idComprobante, v.idCliente, v.monto"
            cadena = "select (c.nombre + '  ' + c.apellido ) as nombreCliente, cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion as CondVenta  , v.idCliente  
from Clientes c, TempVentas v, Comprobantes cp, CondicionVenta cv 
where v.idCliente = c.idCliente and v.idComprobante = cp.Codigo and v.idCondicion_venta = cv.idCondicion_venta and cp.Codigo = v.idComprobante and cp.Codigo <> 333
group by   (c.nombre + '  ' + c.apellido ),cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion  , v.idCliente  "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar todas las Ventas
    Public Function buscarTodasLasVentasXfecha(ByVal fecha As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from TempVentas where fecha_venta = '" & fecha & "'"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


    'Funcion para buscar detaller de factura por id Venta
    Public Function buscarDetalleFacturaXventa(ByVal idFactura As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from TempDetalle_Venta where numVenta =  " & idFactura & " order by IdDetalle_venta asc"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar ventas por id cliente
    Public Function buscarVentasXcliente(ByVal idCliente As String) As DataSet
        Try
            Dim cadena As String
            'cadena = "select * from Ventas where idCliente = " & idCliente
            'cadena = "select (select nombre & ' ' &  apellido from Clientes where idCliente = v.idCliente) as nombreCliente,  v.idVenta, v.fecha_venta,(select descripcion from CondicionVenta where idCondicion_venta = v.idCondicion_venta ) as CondVenta  , v.idCliente , v.descuento_venta, (select Descripcion from Comprobantes where Codigo = v.idComprobante) as Descripcion  from Ventas v, Comprobantes c, CondicionVenta cv where v.idCliente = " & idCliente & " group by  v.idVenta, v.fecha_venta,v.idCondicion_venta, v.idCliente  , v.descuento_venta, v.idComprobante, v.idCliente"

            cadena = "select (select nombre & ' ' &  apellido from Clientes where idCliente = v.idCliente) as nombreCliente,  v.idVenta, v.fecha_venta,v.monto,(select descripcion from CondicionVenta where idCondicion_venta = v.idCondicion_venta ) as CondVenta  , v.idCliente , v.descuento_venta, (select Descripcion from Comprobantes where Codigo = v.idComprobante) as Descripcion  from TempVentas v, Comprobantes c, CondicionVenta cv where v.idCliente = " & idCliente & " and v.idComprobante <> 333 group by  v.idVenta, v.fecha_venta,v.idCondicion_venta, v.idCliente  , v.descuento_venta, v.idComprobante, v.idCliente,v.monto
"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar ventas por id cliente de ctacte
    Public Function buscarVentasXclienteCtaCte(ByVal idCliente As String) As DataSet
        Try
            Dim cadena As String
            'cadena = "select * from Ventas where idCliente = " & idCliente & " and idCondicion_Venta = 2"
            'cadena = "select v.idVenta, v.fecha_venta, c.Descripcion = (select Descripcion from Comprobantes c where c.Codigo = v.idComprobante) from Ventas v, Comprobantes c  where v.idCliente = " & idCliente & " and v.idCondicion_Venta = 2"
            cadena = "select v.monto, v.cantidad, v.descuento_venta, v.recargo_venta, v.idVenta, v.fecha_venta, (select Descripcion from Comprobantes where Codigo = v.idComprobante) as Descripcion from TempVentas v, Comprobantes c  where v.idCliente = " & idCliente & " and v.idCondicion_Venta = 2 group by v.monto, v.cantidad, v.descuento_venta, v.recargo_venta, v.idVenta, v.fecha_venta, v.idComprobante"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar ventas por id venta
    Public Function buscarVentasXidVenta(ByVal idVenta As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from TempVentas where idVenta = " & idVenta
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


    'Funcion para borrar detalle de venta
    Public Function borrarDetalleVenta(ByVal idVenta As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            'CadenaSQL = "delete from TempDetalle_Venta where idVenta = " & idVenta
            CadenaSQL = "delete from TempDetalle_Venta"
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

    'Función para borrar venta
    Public Function borrarVenta(ByVal idVenta As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            'CadenaSQL = "delete from TempVentas where numVenta = " & idVenta
            CadenaSQL = "delete from TempVentas"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar la Venta")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function


    Public Function ultimaVenta() As DataSet
        Try
            Dim cadena As String
            cadena = "select max(idVenta) from TempVentas"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function ultimaVenta(ByVal idComprobante As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select max(idVenta) from TempVentas where idComprobante = " & idComprobante
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
