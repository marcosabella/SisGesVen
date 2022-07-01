Imports System.Data
Imports System.Data.OleDb
Public Class OrdenTrabajo
#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region
#Region "Atributos"
    Dim _idOT As Integer
    Dim _fechaRecepcion As Date
    Dim _fechaEntrega As Date
    Dim _idCliente As Integer
    Dim _lejosOD As String
    Dim _lejosOI As String
    Dim _cercaOD As String
    Dim _cercaOI As String
    Dim _dr As String
    Dim _fechaReceta As Date
    Dim _idCristalLejos As Integer
    Dim _idCristalCerca As Integer
    Dim _idArmazonLejos As Integer
    Dim _idArmazonCerca As Integer
    Dim _idReparacion As Integer
    Dim _idOS As Integer
    Dim _idCondVenta As Integer
    Dim _idDescuentoOS As Integer
    Dim _descRecargo As Double
    Dim _importe As Double

#End Region

#Region "propiedades"

    Public Property idOT() As Integer
        Get
            Return _idOT
        End Get
        Set(ByVal value As Integer)
            _idOT = value
        End Set
    End Property

    Public Property fechaRecepcion() As Date
        Get
            Return _fechaRecepcion
        End Get
        Set(ByVal value As Date)
            _fechaRecepcion = value
        End Set
    End Property

    Public Property fechaEntrega() As Date
        Get
            Return _fechaEntrega
        End Get
        Set(ByVal value As Date)
            _fechaEntrega = value
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

    Public Property lejosOI() As String
        Get
            Return _lejosOI
        End Get
        Set(ByVal value As String)
            _lejosOI = value
        End Set
    End Property

    Public Property lejosOD() As String
        Get
            Return _lejosOD
        End Get
        Set(ByVal value As String)
            _lejosOD = value
        End Set
    End Property

    Public Property cercaOD() As String
        Get
            Return _cercaOD
        End Get
        Set(ByVal value As String)
            _cercaOD = value
        End Set
    End Property

    Public Property cercaOI() As String
        Get
            Return _cercaOI
        End Get
        Set(ByVal value As String)
            _cercaOI = value
        End Set
    End Property

    Public Property dr() As String
        Get
            Return _dr
        End Get
        Set(ByVal value As String)
            _dr = value
        End Set
    End Property

    Public Property fechaReceta() As Date
        Get
            Return _fechaReceta
        End Get
        Set(ByVal value As Date)
            _fechaReceta = value
        End Set
    End Property

    Public Property idCristalLejos() As Integer
        Get
            Return _idCristalLejos
        End Get
        Set(ByVal value As Integer)
            _idCristalLejos = value
        End Set
    End Property

    Public Property idCristalCerca() As Integer
        Get
            Return _idCristalCerca
        End Get
        Set(ByVal value As Integer)
            _idCristalCerca = value
        End Set
    End Property

    Public Property idArmazonCerca() As Integer
        Get
            Return _idArmazonCerca
        End Get
        Set(ByVal value As Integer)
            _idArmazonCerca = value
        End Set
    End Property

    Public Property idArmazonLejos() As Integer
        Get
            Return _idArmazonLejos
        End Get
        Set(ByVal value As Integer)
            _idArmazonLejos = value
        End Set
    End Property

    Public Property idReparacion() As Integer
        Get
            Return _idReparacion
        End Get
        Set(ByVal value As Integer)
            _idReparacion = value
        End Set
    End Property

    Public Property idOS() As Integer
        Get
            Return _idOS
        End Get
        Set(ByVal value As Integer)
            _idOS = value
        End Set
    End Property

    Public Property idCondVenta() As Integer
        Get
            Return _idCondVenta
        End Get
        Set(ByVal value As Integer)
            _idCondVenta = value
        End Set
    End Property

    Public Property idDescuentoOS() As Integer
        Get
            Return _idDescuentoOS
        End Get
        Set(ByVal value As Integer)
            _idDescuentoOS = value
        End Set
    End Property

    Public Property descRecargo() As Double
        Get
            Return _descRecargo
        End Get
        Set(ByVal value As Double)
            _descRecargo = value
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


#Region "metodos"
    Public Function ultimaOrden() As DataSet
        Try
            Dim cadena As String
            cadena = "select max(idOT) from OrdenTrabajo"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function nuevaOT(ByRef objOT As OrdenTrabajo) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into OrdenTrabajo (fechaRecepcion,fechaEntrega,idCliente,lejosOD,lejosOI,cercaOD,cercaOI,dr,fechaReceta,idCristalLejos,idCristalCerca,idArmazonLejos,idArmazonCerca,idReparacion,idObraSocial,idCondVenta,idDescuentoOS,descRecargo,importe) Values ('" & objOT.fechaRecepcion & "','" & objOT.fechaEntrega & "'," & objOT.idCliente & ",'" & objOT.lejosOD & "','" & objOT.lejosOI & "','" & objOT.cercaOD & "','" & objOT.cercaOI & "','" & objOT.dr & "','" & objOT.fechaEntrega & "'," & objOT.idCristalLejos & "," & objOT.idCristalCerca & "," & objOT.idArmazonLejos & "," & objOT.idArmazonCerca & "," & objOT.idReparacion & "," & objOT.idOS & "," & objOT.idCondVenta & "," & objOT.idDescuentoOS & ",'" & objOT.descRecargo & "','" & objOT.importe & "')"
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

    Public Function BuscarTodasOrdenes() As DataSet
        Try
            Dim cadena As String
            cadena = "select OT.fechaRecepcion, OT.fechaEntrega, (c.nombre + ' ' + c.apellido) as nombreCliente, OT.idOT from OrdenTrabajo OT, Clientes c where OT.idCliente = c.idCliente "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function BuscarOrdenesXid(ByVal idOT As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from OrdenTrabajo where idOT =" & idOT
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function BuscarOrdenesXidClienteParaGrilla(ByVal idCliente As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select OT.idOT, OT.fechaRecepcion, OT.fechaEntrega, (c.nombre + ' ' + c.apellido) as nombreCliente from OrdenTrabajo OT, Clientes c where OT.idCliente = c.idCliente and OT.idCliente =" & idCliente
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function borrarOT(ByVal idOT As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from OrdenTrabajo where idOT = " & idOT
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar la Orden de Trabajo")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function

    Public Function modificarOT(ByRef objOT As OrdenTrabajo) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update OrdenTrabajo set fechaRecepcion = '" & objOT.fechaRecepcion & "', fechaEntrega = '" & objOT.fechaEntrega & "' ,idCliente = " & objOT.idCliente & ",lejosOD = " & objOT.lejosOD & " ,lejosOI = " & objOT.lejosOI & ",cercaOD = " & objOT.cercaOD & " ,cercaOI = " & objOT.cercaOI & " ,dr = '" & objOT.dr & "',fechaReceta = '" & objOT.fechaReceta & "',idCristalLejos = " & objOT.idCristalLejos & " ,idCristalCerca = " & objOT.idCristalCerca & ",idArmazonLejos = " & objOT.idArmazonLejos & ",idArmazonCerca=" & objOT.idArmazonCerca & ",idReparacion= " & objOT.idReparacion & ",idObraSocial=" & objOT.idOS & ",idCondVenta=" & objOT.idCondVenta & ",idDescuentoOS = " & objOT.idDescuentoOS & ",descRecargo = '" & objOT.descRecargo & "',importe = '" & objOT.importe & "' where idOT = " & idOT
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

    Public Function buscarOTXclienteCtaCte(ByVal idCliente As String) As DataSet
        Try
            Dim cadena As String
            'cadena = "select * from Ventas where idCliente = " & idCliente & " and idCondicion_Venta = 2"
            'cadena = "select v.idVenta, v.fecha_venta, c.Descripcion = (select Descripcion from Comprobantes c where c.Codigo = v.idComprobante) from Ventas v, Comprobantes c  where v.idCliente = " & idCliente & " and v.idCondicion_Venta = 2"
            cadena = "select ot.importe, ot.idOT, ot.fechaRecepcion from OrdenTrabajo ot where ot.idCliente = " & idCliente & "and ot.idCondVenta = 2 group by ot.importe, ot.idOT, ot.fechaRecepcion"
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
