Imports System.Data
Imports System.Data.OleDb
Public Class Caja

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region

    Public Function buscarTodasLasContado(ByVal condVenta As Integer, Optional cheque As String = "") As DataSet
        Try
            Dim cadena As String
            If cheque = "" Then
                cadena = "select sum(v.monto)
                from Ventas v, Comprobantes cp, CondicionVenta cv 
                where  v.idComprobante = cp.Codigo 
                and v.idCondicion_venta = cv.idCondicion_venta 
                and cp.Codigo = v.idComprobante 
                and cp.Codigo <> 333 
                and cv.idCondicion_venta = " & condVenta

            ElseIf cheque = "si" Then
                cadena = "select sum(ch.monto)
                from Ventas v, Comprobantes cp, CondicionVenta cv, cheques ch
                where  v.idComprobante = cp.Codigo 
                and v.idCondicion_venta = cv.idCondicion_venta 
                and cp.Codigo = v.idComprobante 
                and cp.Codigo <> 333 
                and cv.idCondicion_venta = 4 
                and v.idVenta = ch.idVenta
                and enCartera = true and enCartera = true"
            ElseIf cheque = "Tarjeta" Then
                cadena = "select sum(v.monto)
                from Ventas v, Comprobantes cp, CondicionVenta cv, Tarjetas t, TarjetaPorVenta tv 
                where  v.idComprobante = cp.Codigo 
                and v.idCondicion_venta = cv.idCondicion_venta 
                and cp.Codigo = v.idComprobante 
                and cp.Codigo <> 333 
                and cv.idCondicion_venta = 3
                and v.idVenta = tv.idVenta 
                and tv.idTarjeta = t.idTarjeta
                and tv.depositado = false
                "
            End If

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarTodosPagosContado() As DataSet
        Try
            Dim cadena As String
            cadena = "select sum(importe) from Pagos where idCondicion_venta = 1"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarTodasLasVentas(ByVal fecha As DateTime) As DataSet
        Try
            Dim cadena As String

            cadena = "select (c.apellido + '  ' + c.nombre ) as nombreCliente, cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion as CondVenta  , v.idCliente from Clientes c, Ventas v, Comprobantes cp, CondicionVenta cv 
where v.idCliente = c.idCliente and v.idComprobante = cp.Codigo and v.idCondicion_venta = cv.idCondicion_venta and cp.Codigo = v.idComprobante and cp.Codigo <> 333 and v.fecha_venta = #" & fecha.ToString("MM/dd/yyyy") &
            "# group by  (c.apellido + '  ' + c.nombre ),cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion  , v.idCliente  order by v.fecha_venta desc  "


            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarTodasLasVentas() As DataSet
        Try
            Dim cadena As String

            cadena = "select (c.apellido + '  ' + c.nombre ) as nombreCliente, cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion as CondVenta  , v.idCliente from Clientes c, Ventas v, Comprobantes cp, CondicionVenta cv 
where v.idCliente = c.idCliente and v.idComprobante = cp.Codigo and v.idCondicion_venta = cv.idCondicion_venta and cp.Codigo = v.idComprobante and cp.Codigo <> 333 and v.fecha_venta = #" & FormatDateTime(Now, DateFormat.ShortDate) &
            "# group by  (c.apellido + '  ' + c.nombre ),cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion  , v.idCliente  order by v.fecha_venta desc  "


            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarResumenTarjetaVentaDiaria(ByVal fecha As DateTime)

        Try
            Dim cadena As String

            cadena = "select sum(v.monto), t.descripcion, tv.idTarjeta
from Ventas v, Comprobantes cp, CondicionVenta cv, Tarjetas t, TarjetaPorVenta tv 
where  v.idComprobante = cp.Codigo and v.idCondicion_venta = cv.idCondicion_venta and cp.Codigo = v.idComprobante and cp.Codigo <> 333 and cv.idCondicion_venta = 3
and v.idVenta = tv.idVenta and tv.idTarjeta = t.idTarjeta and v.fecha_venta = #" & fecha.ToString("MM/dd/yyyy") &
            "# group by t.descripcion, tv.idTarjeta"

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarResumenTarjetaVentaDiariaXtarjeta(ByVal idTarjeta As Integer, ByVal fecha As DateTime)

        Try
            Dim cadena As String

            cadena = "select v.monto, tv.cuponNumero
from Ventas v, Comprobantes cp, CondicionVenta cv, Tarjetas t, TarjetaPorVenta tv 
where  v.idComprobante = cp.Codigo and v.idCondicion_venta = cv.idCondicion_venta and cp.Codigo = v.idComprobante and cp.Codigo <> 333 and cv.idCondicion_venta = 3
and v.idVenta = tv.idVenta and tv.idTarjeta = t.idTarjeta and v.fecha_venta = #" & fecha.ToString("MM/dd/yyyy") &
            "# and tv.idTarjeta = " & idTarjeta

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarResumenTransferenciaVentaDiaria(ByVal fecha As DateTime)

        Try
            Dim cadena As String

            cadena = "select sum(v.monto), b.nombre
from Ventas v, Comprobantes cp, CondicionVenta cv, Banco b, TransferenciaXventa tv 
where  v.idComprobante = cp.Codigo and v.idCondicion_venta = cv.idCondicion_venta and cp.Codigo = v.idComprobante and cp.Codigo <> 333 and cv.idCondicion_venta = 5
and v.idVenta = tv.idVenta and tv.idBanco = b.Id and v.fecha_venta = #" & fecha.ToString("MM/dd/yyyy") &
            "# group by  b.nombre"

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarTodasLasVentasXcondicion(ByVal idCondVenta As Integer, ByVal fecha As DateTime) As DataSet
        Try
            Dim cadena As String
            If idCondVenta <> 6 Then
                cadena = "select (c.apellido + '  ' + c.nombre ) as nombreCliente, cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion as CondVenta  , v.idCliente from Clientes c, Ventas v, Comprobantes cp, CondicionVenta cv 
where v.idCliente = c.idCliente and v.idComprobante = cp.Codigo and v.idCondicion_venta = cv.idCondicion_venta and cp.Codigo = v.idComprobante and cp.Codigo <> 333 and cv.idCondicion_venta = " & idCondVenta & " and v.fecha_venta = #" & fecha.ToString("MM/dd/yyyy") & "# group by  (c.apellido + '  ' + c.nombre ),cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion  , v.idCliente  order by v.fecha_venta desc  "


            Else
                cadena = "select (c.apellido + '  ' + c.nombre ) as nombreCliente, 'RECIBO' , p.idPago, p.fecha_pago, p.importe , cv.Descripcion as CondVenta  , p.idCliente from Clientes c, Pagos p, CondicionVenta cv where p.idCliente = c.idCliente and cv.idCondicion_venta = p.idCondicion_venta and cv.idCondicion_venta = 1 and p.fecha_pago = #" & fecha.ToString("MM/dd/yyyy") & "# group by  (c.apellido + '  ' + c.nombre ) , p.idPago, p.fecha_pago, p.importe , cv.Descripcion  , p.idCliente  order by p.fecha_pago desc"

            End If


            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarTodasTarjetasSinDepositar() As DataSet
        Try
            Dim cadena As String

            cadena = "select tv.Id, v.idVenta, t.descripcion, tv.cuponNumero, v.monto, tv.depositado 
                from Ventas v, Comprobantes cp, CondicionVenta cv, Tarjetas t, TarjetaPorVenta tv 
                where  v.idComprobante = cp.Codigo 
                and v.idCondicion_venta = cv.idCondicion_venta 
                and cp.Codigo = v.idComprobante 
                and cp.Codigo <> 333 
                and cv.idCondicion_venta = 3
                and v.idVenta = tv.idVenta 
                and tv.idTarjeta = t.idTarjeta
                and tv.depositado = false"

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarTodosChequesSinDepositar() As DataSet
        Try
            Dim cadena As String

            'cadena = "select sum(v.monto)
            'from Ventas v, Comprobantes cp, CondicionVenta cv, cheques ch
            'where  v.idComprobante = cp.Codigo 
            'and v.idCondicion_venta = cv.idCondicion_venta 
            'and cp.Codigo = v.idComprobante 
            'and cp.Codigo <> 333 
            'and cv.idCondicion_venta = 4 
            'and v.idVenta = ch.idVenta
            'and enCartera = true and enCartera = true"
            cadena = "select 
            Id,
            idVenta ,
            emisor ,    
            fecha ,
            vencimiento ,
            monto   
            from Cheques where enCartera = true"

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    Public Sub modificarTarjetaAdpositado(ByRef id As Integer)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update TarjetaPorVenta set depositado = true  where Id = " & id
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

    Public Sub RegistrarDeposito(ByRef fechaDeposito As Date, ByRef montoDepositado As Double, ByRef idBanco As Integer, ByRef idValor As Integer)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "insert into Depositos (fechadeposito,montoDepositado,idBanco,idValor) values ('" & fechaDeposito & "','" & montoDepositado & "'," & idBanco & "," & idValor & ")"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el depósito")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos de la Venta con Exito!")
    End Sub

    Public Function devolverMontoDepositoPorValor(ByRef idValor As Integer) As DataSet
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "select sum(montoDepositado) from Depositos where idValor = " & idValor
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)

            oSqlDataAdapter = New OleDbDataAdapter(CadenaSQL, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el depósito")
            Exit Function
        End Try

        'MsgBox("Se Actualizaron los datos de la Venta con Exito!")
    End Function

    Public Function buscarTodasLosPagos(ByVal fecha As DateTime) As DataSet
        Try
            Dim cadena As String

            '            cadena = "select (c.apellido + '  ' + c.nombre ) as nombreCliente, cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion as CondVenta  , v.idCliente from Clientes c, Ventas v, Comprobantes cp, CondicionVenta cv 
            'where v.idCliente = c.idCliente and v.idComprobante = cp.Codigo and v.idCondicion_venta = cv.idCondicion_venta and cp.Codigo = v.idComprobante and cp.Codigo <> 333 and v.fecha_venta = #" & FormatDateTime(fecha, DateFormat.ShortDate) &
            '            "# group by  (c.apellido + '  ' + c.nombre ),cp.descripcion , v.idVenta, v.fecha_venta, v.monto , cv.Descripcion  , v.idCliente  order by v.fecha_venta desc  "

            'cadena = "select (c.apellido + '  ' + c.nombre ) as nombreCliente, 'RECIBO' , p.idPago, p.fecha_pago, p.importe , cv.Descripcion as CondVenta  , p.idCliente from Clientes c, Pagos p, CondicionVenta cv where p.idCliente = c.idCliente and cv.idCondicion_venta = p.idCondicion_venta and cv.idCondicion_venta = 1 and p.fecha_pago = #" & fecha.ToString("MM/dd/yyyy") & "# group by  (c.apellido + '  ' + c.nombre ) , p.idPago, p.fecha_pago, p.importe , cv.Descripcion  , p.idCliente  order by p.fecha_pago desc"
            cadena = "select (c.apellido + '  ' + c.nombre ) as nombreCliente, 'RECIBO' , p.idPago, p.fecha_pago, p.importe , cv.Descripcion as CondVenta  , p.idCliente from Clientes c, Pagos p, CondicionVenta cv where p.idCliente = c.idCliente and cv.idCondicion_venta = p.idCondicion_venta and p.fecha_pago = #" & fecha.ToString("MM/dd/yyyy") & "# group by  (c.apellido + '  ' + c.nombre ) , p.idPago, p.fecha_pago, p.importe , cv.Descripcion  , p.idCliente  order by p.fecha_pago desc"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
End Class
