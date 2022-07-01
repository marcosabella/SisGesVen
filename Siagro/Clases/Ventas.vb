Imports System.Data
Imports System.Data.OleDb
Public Class Ventas

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
#End Region

#Region "Metodos"

    'Función para guardar nueva venta
    Public Function nuevaVenta(ByRef objVentas As Ventas) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Ventas (fecha_venta,idCondicion_venta,idCliente,descuento_venta,recargo_venta,idComprobante,monto,observaciones) Values ('" & objVentas.fecha_venta & "'," & objVentas.idCondicion_venta & "," & objVentas.idCliente & "," & objVentas.descuento_venta & "," & objVentas.recargo_venta & "," & objVentas.idComprobante & ",'" & objVentas.monto & "','" & objVentas.observaciones & "')"
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
    Public Function nuevoDetalleVenta(ByRef objVentas As Ventas) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Detalle_Venta (idVenta, idArticulo, cantidad, precioUnitario,cotizacion) Values (" & objVentas.idDetalle_venta & "," & objVentas.idArticulo & ",'" & objVentas.cantidad & "','" & objVentas.precioUnitario & "','" & objVentas.cotizacion & "')"
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

            '            cadena = "select (c.apellido + '  ' + c.nombre ) as nombreCliente, cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion as CondVenta  , v.idCliente  
            'from Clientes c, Ventas v, Comprobantes cp, CondicionVenta cv 
            'where v.idCliente = c.idCliente and v.idComprobante = cp.Codigo and v.idCondicion_venta = cv.idCondicion_venta and cp.Codigo = v.idComprobante and cp.Codigo <> 333
            'group by   (c.apellido + '  ' + c.nombre ),cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion  , v.idCliente  order by (c.apellido + '  ' + c.nombre )  asc  "

            '            cadena = "select (c.apellido + '  ' + c.nombre ) as nombreCliente, cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion as CondVenta  , v.idCliente, ce.cae  
            'from Clientes c, Ventas v, Comprobantes cp, CondicionVenta cv, CaeXventa ce 
            'where v.idCliente = c.idCliente and v.idComprobante = cp.Codigo and v.idCondicion_venta = cv.idCondicion_venta and cp.Codigo = v.idComprobante and cp.Codigo <> 333 and ce.idVenta = v.idVenta
            'group by   (c.apellido + '  ' + c.nombre ),cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion  , v.idCliente, ce.cae  order by v.fecha_venta desc  "

            cadena = "select (c.apellido + '  ' + c.nombre) as nombreCliente, cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion as CondVenta  , v.idCliente, caeXventa.cae, v.impreso
from  ((((Ventas v 
left join CaeXventa on CaeXventa.idVenta = v.idVenta)
left join Clientes c on c.idCliente = v.idCliente)
left join  Comprobantes cp on v.idComprobante = cp.Codigo) 
left join CondicionVenta cv on v.idCondicion_venta = cv.idCondicion_venta )

where cp.Codigo <> 333

group by   (c.apellido + '  ' + c.nombre ),cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion  , v.idCliente ,  caeXventa.cae, v.impreso
order by v.fecha_venta desc "

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
            cadena = "select * from Ventas where fecha_venta = '" & fecha & "'"
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
            cadena = "select * from Detalle_Venta where idVenta =  " & idFactura & " order by IdDetalle_venta asc"
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

            '            cadena = "select (select nombre & ' ' &  apellido from Clientes where idCliente = v.idCliente) as nombreCliente,  v.idVenta, v.fecha_venta,v.monto,(select descripcion from CondicionVenta where idCondicion_venta = v.idCondicion_venta ) as CondVenta  , v.idCliente , v.descuento_venta, (select Descripcion from Comprobantes where Codigo = v.idComprobante) as Descripcion, ce.cae  from Ventas v, Comprobantes c, CondicionVenta cv, CaeXventa ce where v.idCliente = " & idCliente & " and v.idComprobante <> 333 and v.idVenta = ce.idVenta group by  v.idVenta, v.fecha_venta,v.idCondicion_venta, v.idCliente  , v.descuento_venta, v.idComprobante, v.idCliente,v.monto, ce.cae
            '"
            cadena = "select (c.apellido + '  ' + c.nombre) as nombreCliente, cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion as CondVenta  , v.idCliente, caeXventa.cae,v.impreso
from  ((((Ventas v 
left join CaeXventa on CaeXventa.idVenta = v.idVenta)
left join Clientes c on c.idCliente = v.idCliente)
left join  Comprobantes cp on v.idComprobante = cp.Codigo) 
left join CondicionVenta cv on v.idCondicion_venta = cv.idCondicion_venta )

where cp.Codigo <> 333
and v.idCliente = " & idCliente & "
group by   (c.apellido + '  ' + c.nombre ),cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion  , v.idCliente ,  caeXventa.cae,v.impreso
order by v.fecha_venta desc "

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
            cadena = "select v.monto, v.cantidad, v.descuento_venta, v.recargo_venta, v.idVenta, v.fecha_venta, (select Descripcion from Comprobantes where Codigo = v.idComprobante) as Descripcion, v.idComprobante from Ventas v, Comprobantes c  where v.idCliente = " & idCliente & " and v.idCondicion_Venta = 2 and v.idComprobante <> 333 group by v.monto, v.cantidad, v.descuento_venta, v.recargo_venta, v.idVenta, v.fecha_venta, v.idComprobante"
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
            cadena = "select * from Ventas where idVenta = " & idVenta
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Función para modificar venta
    Public Sub modificarVenta(ByRef objVenta As Ventas)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update Ventas set fecha_Venta = '" & objVenta.fecha_venta & "', idCondicion_venta =" & objVenta.idCondicion_venta & ", idCliente = " & objVenta.idCliente & ", idIva = " & objVenta.idIva & ", descuento_venta = " & objVenta.descuento_venta & ", recargo_venta = " & objVenta.recargo_venta & ", idComprobante = " & objVenta.idComprobante & ", monto = '" & objVenta.monto & "', observaciones = '" & objVenta.observaciones & "' where idVenta = " & objVenta.idVenta
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar la venta")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos de la Venta con Exito!")
    End Sub

    'Funcion para borrar detalle de venta
    Public Function borrarDetalleVenta(ByVal idVenta As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Detalle_Venta where idVenta = " & idVenta
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
            CadenaSQL = "delete from Ventas where idVenta = " & idVenta
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

    ''Funcion para buscar Articulo por código
    'Public Function buscarArticulo(ByVal idArticulo As Integer) As DataSet
    '    Try
    '        Dim cadena As String
    '        cadena = "select * from Articulos where idArticulo =  " & idArticulo
    '        oSqlConnection = New OleDbConnection(strConection)
    '        oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
    '        oDataSet = New DataSet
    '        oSqlDataAdapter.Fill(oDataSet)
    '        Return oDataSet
    '    Catch ex As Exception

    '    End Try

    'End Function

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

    ''Funcion para buscar todos los Articulos
    'Public Function buscarArticulos() As DataSet
    '    Try
    '        Dim cadena As String
    '        cadena = "select * from Articulos "
    '        oSqlConnection = New OleDbConnection(strConection)
    '        oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
    '        oDataSet = New DataSet
    '        oSqlDataAdapter.Fill(oDataSet)
    '        Return oDataSet
    '    Catch ex As Exception

    '    End Try

    'End Function

    ''Funcion para borrar Articulos por Código
    'Public Function borrarArticulos(ByVal idArticulos As Integer) As Boolean
    '    Try
    '        oSqlConnection = New OleDbConnection(strConection)
    '        Dim CadenaSQL As String
    '        CadenaSQL = "delete from Articulos where idArticulo = " & idArticulos
    '        Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
    '        oSqlConnection.Open()
    '        oSqlCommand.ExecuteNonQuery()
    '        oSqlConnection.Close()
    '    Catch ex As Exception
    '        MsgBox("Disculpe. No se ha podido Eliminar el Articulo")
    '        Return False
    '        Exit Function
    '    End Try
    '    'MsgBox("Se registró nueva Alimento con Exito!")
    '    '    Return True
    'End Function

    'Funcion para buscar ultimo numero de venta
    Public Function ultimaVenta() As DataSet
        Try
            Dim cadena As String
            cadena = "select max(idVenta) from Ventas"
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
            cadena = "select max(idVenta) from Ventas where idComprobante = " & idComprobante
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Sub modificarEstadoVenta(ByRef objVenta As Ventas)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update Ventas set idCondicion_venta = " & objVenta.idCondicion_venta & ", observaciones ='" & objVenta.observaciones & "' where idVenta = " & objVenta.idVenta
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar la venta")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos de la Venta con Exito!")
    End Sub

    Public Function registrarPrecioDolar(ByRef objVentas As Ventas) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into CotizacionDolar (fecha_actualizacion,monto,tipoDolar) Values ('" & Now & "','" & objVentas.precioDolar & "','" & objVentas.tipoDolar & "')"
            'CadenaSQL = ""
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            'MsgBox("Disculpe. No se ha podido registrar la nueva venta")
            Return False
        End Try
        'MsgBox("Se registró nueva venta con Exito!")
        Return True
    End Function

    Public Function ultimaCotización(ByVal tipoDolar As String) As DataSet
        Try
            Dim cadena As String
            'cadena = "select* from CotizacionDolar c where c.Id = (select max(d.Id) from CotizacionDolar d) and tipoDolar = '" & tipoDolar & "'"
            cadena = "select max(id) from CotizacionDolar where tipoDolar = '" & tipoDolar & "'"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function cotizaciónXid(ByVal id As String) As DataSet
        Try
            Dim cadena As String
            'cadena = "select* from CotizacionDolar c where c.Id = (select max(d.Id) from CotizacionDolar d) and tipoDolar = '" & tipoDolar & "'"
            cadena = "select * from CotizacionDolar where id = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function historicoDolar(ByVal tipoDolar As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from CotizacionDolar where tipoDolar = '" & tipoDolar & "' order by id desc"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function borrarCotizacion(ByVal idCotización As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from CotizacionDolar where Id = " & idCotización
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

    Public Function buscarSaldosVentasXclienteCtaCteSuma() As DataSet
        Try
            Dim cadena As String
            cadena = "select Clientes.idCliente, (Clientes.apellido + ' ' + Clientes.nombre), sum(Ventas.monto) " &
                   "from Clientes, Ventas, Comprobantes " &
                   "where Clientes.idCliente = Ventas.idCliente and " &
                   "Ventas.idCondicion_Venta = 2 and " &
                   "Ventas.idComprobante = Comprobantes.codigo and " &
                   "Comprobantes.Resta = false " &
                   "group by Clientes.idCliente, (Clientes.apellido + ' ' + Clientes.nombre)"

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarSaldosVentasXclienteCtaCteResta(ByVal idCliente As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select Clientes.idCliente, sum(Ventas.monto) " &
                   "from Clientes, Ventas, Comprobantes " &
                   "where Clientes.idCliente = Ventas.idCliente and " &
                   "Clientes.idCliente = " & idCliente & " and " &
                   "Ventas.idCondicion_Venta = 2 and " &
                   "Ventas.idComprobante = Comprobantes.codigo and " &
                   "Comprobantes.Resta = true " &
                   "group by Clientes.idCliente"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarTodasLasVentasCae() As DataSet
        Try
            Dim cadena As String

            cadena = "select (c.apellido + '  ' + c.nombre) as nombreCliente, cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion as CondVenta  , v.idCliente, caeXventa.cae,v.impreso
from  ((((Ventas v 
left join CaeXventa on CaeXventa.idVenta = v.idVenta)
left join Clientes c on c.idCliente = v.idCliente)
left join  Comprobantes cp on v.idComprobante = cp.Codigo) 
left join CondicionVenta cv on v.idCondicion_venta = cv.idCondicion_venta )

where cp.Codigo <> 333
and CaeXventa.cae <> ' '
group by   (c.apellido + '  ' + c.nombre ),cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion  , v.idCliente ,  caeXventa.cae,v.impreso
order by v.fecha_venta desc"

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarTodasLasVentasSinCae() As DataSet
        Try
            Dim cadena As String

            cadena = "select (c.apellido + '  ' + c.nombre) as nombreCliente, cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion as CondVenta  , v.idCliente, caeXventa.cae,v.impreso
from  ((((Ventas v 
left join CaeXventa on CaeXventa.idVenta = v.idVenta)
left join Clientes c on c.idCliente = v.idCliente)
left join  Comprobantes cp on v.idComprobante = cp.Codigo) 
left join CondicionVenta cv on v.idCondicion_venta = cv.idCondicion_venta )

where cp.Codigo <> 333
and CaeXventa.cae is null
group by   (c.apellido + '  ' + c.nombre ),cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion  , v.idCliente ,  caeXventa.cae, v.impreso
order by v.fecha_venta desc"

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Sub marcarImpresaFactura(ByRef idVenta As Integer, ByVal marca As Boolean)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update Ventas set impreso = " & marca & " where idVenta = " & idVenta
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar la venta")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos de la Venta con Exito!")
    End Sub
    'buscar tarjetas para venta

#End Region

#Region "Tarjetas de crédito"
    Public Function buscarTarjetasVenta() As DataSet
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

    Public Function buscarTarjetasVenta(ByVal idTarjeta As Integer) As DataSet
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

    Public Function nuevaTarjetaPorVenta(ByRef idTarjeta As Integer, ByRef idOrden As Integer, ByRef idVenta As Integer, ByRef cuponNumero As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into TarjetaPorVenta (idTarjeta, idOrden, idVenta,cuponNumero) Values (" & idTarjeta & "," & idOrden & "," & idVenta & "," & cuponNumero & ")"
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

    Public Function borrarTarjetaPorVemta(ByVal idVenta As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from TarjetaPorVenta where idVenta = " & idVenta
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

    Public Function buscarTarjetasVentaPorID(ByVal idTarjeta As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from TarjetaPorVenta where idTarjeta = " & idTarjeta
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarTarjetasVentaPorIDVenta(ByVal idVenta As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from TarjetaPorVenta where idVenta = " & idVenta
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

    Public Function nuevaTarjetaa(ByRef objVentas As Ventas) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Tarjetas (descripcion, porcRecargo) Values ('" & objVentas.descripcion & "','" & objVentas.porcRecargo & "')"
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

    Public Function borrarTarjeta(ByVal idTarjetas As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Tarjetas where idTarjeta = " & idTarjetas
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

    Public Function buscarTarjetas() As DataSet
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

    Public Function buscarTarjetasXid(ByVal idTarjeta As Integer) As DataSet
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

    Public Sub modificarTarjeta(ByRef objVenta As Ventas)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update Tarjetas set descripcion = '" & objVenta.descripcion & "', porcRecargo ='" & objVenta.porcRecargo & "'  where idTarjeta = " & objVenta.idTarjetas
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar la venta")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos de la Venta con Exito!")
    End Sub
#End Region


#Region "Presupuesto"

    Public Function buscarTodosLosPresupuestos() As DataSet
        Try
            Dim cadena As String
            'cadena = "select *,(select Descripcion from Comprobantes where Codigo = v.idComprobante)  from Ventas v, Comprobantes c"
            'cadena = "select (select nombre & ' ' &  apellido from Clientes where idCliente = v.idCliente) as nombreCliente,  v.idVenta, v.fecha_venta, v.monto,(select descripcion from CondicionVenta where idCondicion_venta = v.idCondicion_venta ) as CondVenta  , v.idCliente , v.descuento_venta , v.recargo_venta, (select Descripcion from Comprobantes where Codigo = v.idComprobante) as Descripcion  from Ventas v, Comprobantes c, CondicionVenta cv group by  v.idVenta, v.fecha_venta,v.idCondicion_venta, v.idCliente  , v.descuento_venta, v.recargo_venta, v.idComprobante, v.idCliente, v.monto"
            cadena = "select (c.nombre + '  ' + c.apellido ) as nombreCliente, cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion as CondVenta  , v.idCliente  
from Clientes c, Ventas v, Comprobantes cp, CondicionVenta cv 
where v.idCliente = c.idCliente and v.idComprobante = cp.Codigo and v.idCondicion_venta = cv.idCondicion_venta and cp.Codigo = v.idComprobante and cp.Codigo = 333
group by   (c.nombre + '  ' + c.apellido ),cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion  , v.idCliente  "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarPresupuestoXcliente(ByVal idCliente As String) As DataSet
        Try
            Dim cadena As String
            'cadena = "select * from Ventas where idCliente = " & idCliente
            'cadena = "select (select nombre & ' ' &  apellido from Clientes where idCliente = v.idCliente) as nombreCliente,  v.idVenta, v.fecha_venta,(select descripcion from CondicionVenta where idCondicion_venta = v.idCondicion_venta ) as CondVenta  , v.idCliente , v.descuento_venta, (select Descripcion from Comprobantes where Codigo = v.idComprobante) as Descripcion  from Ventas v, Comprobantes c, CondicionVenta cv where v.idCliente = " & idCliente & " group by  v.idVenta, v.fecha_venta,v.idCondicion_venta, v.idCliente  , v.descuento_venta, v.idComprobante, v.idCliente"

            cadena = "select (select nombre & ' ' &  apellido from Clientes where idCliente = v.idCliente) as nombreCliente,  v.idVenta, v.fecha_venta,v.monto,(select descripcion from CondicionVenta where idCondicion_venta = v.idCondicion_venta ) as CondVenta  , v.idCliente , v.descuento_venta, (select Descripcion from Comprobantes where Codigo = v.idComprobante) as Descripcion  from Ventas v, Comprobantes c, CondicionVenta cv where v.idCliente = " & idCliente & " and v.idComprobante = 333 group by  v.idVenta, v.fecha_venta,v.idCondicion_venta, v.idCliente  , v.descuento_venta, v.idComprobante, v.idCliente,v.monto
"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function nuevOpcionales(ByRef objVentas As Ventas) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into OpcionalesXPresupuesto (idVenta, idArticulo, cantidad, precioUnitario,cotizacion) Values (" & objVentas.idDetalle_venta & "," & objVentas.idArticulo & ",'" & objVentas.cantidad & "','" & objVentas.precioUnitario & "','" & objVentas.cotizacion & "')"
            'CadenaSQL = ""
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar los opcionales")
            Return False
        End Try
        'MsgBox("Se registró nuevo detalle de venta con Exito!")
        Return True
    End Function
    Public Function borrarOpcionalesVenta(ByVal idVenta As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from OpcionalesXPresupuesto where idVenta = " & idVenta
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

    Public Function buscarOpcionalesXPresupuesto(ByVal idFactura As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from OpcionalesXPresupuesto where idVenta =  " & idFactura
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
#End Region

#Region "transferencia"


    Public Function nuevaTransferenciaPorVenta(ByRef idBanco As Integer, ByRef idVenta As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into TransferenciaXventa (idBanco, idVenta) Values (" & idBanco & "," & idVenta & ")"
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

    Public Function borrarTransferenciaPorVenta(ByVal idVenta As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from TransferenciaXventa where idVenta = " & idVenta
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

    Public Function buscarTransferenciaVentaPorIDVenta(ByVal idVenta As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from TransferenciaXventa, Banco where TransferenciaXventa.idVenta = " & idVenta & " and Banco.id = TransferenciaXventa.idBanco"
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