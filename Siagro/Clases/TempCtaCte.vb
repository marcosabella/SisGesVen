Imports System.Data
Imports System.Data.OleDb
Public Class TempCtaCte

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region

#Region "Variables tabla TempCtaCte"
    Dim _id As Integer
    Dim _idCliente As Integer
    Dim _fechaComprobante As Date
    Dim _detalleComprobante As String
    Dim _debe As Double
    Dim _haber As Double
    Dim _saldo As Double
    Dim _idVenta As Integer

    Dim _Cliente As String
#End Region

#Region "Propiedades"


    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property idCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            _idCliente = value
        End Set
    End Property
    Public Property fechaComprobante As Date
        Get
            Return _fechaComprobante
        End Get
        Set(value As Date)
            _fechaComprobante = value
        End Set
    End Property
    Public Property detalleComprobante As String
        Get
            Return _detalleComprobante
        End Get
        Set(value As String)
            _detalleComprobante = value
        End Set
    End Property
    Public Property debe As Double
        Get
            Return _debe
        End Get
        Set(value As Double)
            _debe = value
        End Set
    End Property
    Public Property haber As Double
        Get
            Return _haber
        End Get
        Set(value As Double)
            _haber = value
        End Set
    End Property
    Public Property saldo As Double
        Get
            Return _saldo
        End Get
        Set(value As Double)
            _saldo = value
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

    Public Property cliente As String
        Get
            Return _Cliente
        End Get
        Set(value As String)
            _Cliente = value
        End Set
    End Property
#End Region

#Region "Metodos"

    Public Function nuevoRegistro(ByRef objTempCtaCte As TempCtaCte) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into TempCtaCte (idCliente, fechaComprobante,detalleRecibo,debe,haber,saldo,idVenta) Values (" & objTempCtaCte.idCliente & ",'" & objTempCtaCte.fechaComprobante & "','" & objTempCtaCte.detalleComprobante & "','" & objTempCtaCte.debe & "','" & objTempCtaCte.haber & "','" & objTempCtaCte.saldo & "'," & objTempCtaCte.idVenta & ")"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nuevo Cliente con Exito!")
        Return True
    End Function

    Public Function borrarTempCtaCte() As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from TempCtaCte"
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

    Public Function buscarTemp() As DataSet
        Try
            Dim cadena As String
            'cadena = "select * from Ventas where idCliente = " & idCliente & " and idCondicion_Venta = 2"
            'cadena = "select v.idVenta, v.fecha_venta, c.Descripcion = (select Descripcion from Comprobantes c where c.Codigo = v.idComprobante) from Ventas v, Comprobantes c  where v.idCliente = " & idCliente & " and v.idCondicion_Venta = 2"
            cadena = "select * from TempCtaCte order by fechaComprobante asc, detalleRecibo asc "
            'cadena = "select * from TempCtaCte order by fechaComprobante asc"

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function nuevoSaldosRegistro(ByRef objTempCtaCte As TempCtaCte) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into TempSaldosCtaCte (idCliente, nombreCLiente,saldo) Values (" & objTempCtaCte.idCliente & ",'" & objTempCtaCte.cliente & "','" & objTempCtaCte.saldo & "')"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nuevo Cliente con Exito!")
        Return True
    End Function

    Public Function borrarSaldosTempCtaCte() As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from TempSaldosCtaCte"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar la tabla Saldos Cta Cte")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function

    Public Function saldoTotalTemp() As DataSet
        Try
            Dim cadena As String
            cadena = "select sum(saldo) from TempSaldosCtaCte"
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
