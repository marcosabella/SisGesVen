Imports System.Data
Imports System.Data.OleDb
Public Class frmDetalleVenta

    Dim idVenta As Integer

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlDataAdapter1 As OleDbDataAdapter
    Dim oSqlArticuloDataAdapter As OleDbDataAdapter
    Dim oSqlClienteDataAdapter As OleDbDataAdapter
    Dim oSqlComprobanteDataAdapter As OleDbDataAdapter
    Dim oSqlCondicionVentaDataAdapter As OleDbDataAdapter
    Dim oSqlCondIvaDataAdapter As OleDbDataAdapter
    Dim oSqlDetalleVentaDataAdapter As OleDbDataAdapter
    Dim oSqlVentasDataAdapter As OleDbDataAdapter
    Dim oSqlLocaldidadesDataAdapter As OleDbDataAdapter
    Dim oSqlDomicilio_x_clienteDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

    Public Sub New(ByVal id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        idVenta = id
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#End Region

    Private Sub frmComprobanteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.llenarReporte()

    End Sub

    Public Sub llenarReporte()

        Dim parametros As New CrystalDecisions.Shared.ParameterFields
        Dim nroFactura As New CrystalDecisions.Shared.ParameterField
        Dim paramnroFactura As New CrystalDecisions.Shared.ParameterDiscreteValue


        Dim cadenaVenta As String
        Dim cadenaArticulo As String
        Dim cadenaCliente As String
        'Dim cadenaComprobante As String
        Dim cadenaCondicionVenta As String
        Dim cadenaCondIva As String
        Dim cadenaDetalleVenta As String
        'Dim cadenaLocaldidades As String
        Dim cadenaDomicilio_x_cliente As String

        cadenaVenta = "select * from Ventas where idVenta= " & idVenta
        cadenaArticulo = "select * from Articulos"
        cadenaCliente = "select * from Clientes"
        'cadenaComprobante = "select * from Comprobantes"
        cadenaCondicionVenta = "select * from CondicionVenta"
        cadenaCondIva = "select * from CondIva"
        cadenaDetalleVenta = "select * from Detalle_venta"
        'cadenaLocaldidades = "select * from Localidades"
        cadenaDomicilio_x_cliente = "select * from Domicilio_x_cliente"

        oSqlConnection = New OleDbConnection(strConection)

        oSqlVentasDataAdapter = New OleDbDataAdapter(cadenaVenta, oSqlConnection)
        oSqlArticuloDataAdapter = New OleDbDataAdapter(cadenaArticulo, oSqlConnection)
        oSqlClienteDataAdapter = New OleDbDataAdapter(cadenaCliente, oSqlConnection)
        'oSqlComprobanteDataAdapter = New OleDbDataAdapter(cadenaComprobante, oSqlConnection)
        oSqlCondicionVentaDataAdapter = New OleDbDataAdapter(cadenaCondicionVenta, oSqlConnection)
        oSqlCondIvaDataAdapter = New OleDbDataAdapter(cadenaCondIva, oSqlConnection)
        oSqlDetalleVentaDataAdapter = New OleDbDataAdapter(cadenaDetalleVenta, oSqlConnection)
        'oSqlLocaldidadesDataAdapter = New OleDbDataAdapter(cadenaLocaldidades, oSqlConnection)
        oSqlDomicilio_x_clienteDataAdapter = New OleDbDataAdapter(cadenaDomicilio_x_cliente, oSqlConnection)



        oDataSet = New dsParaReporte

        oSqlVentasDataAdapter.Fill(oDataSet, "Ventas")
        oSqlArticuloDataAdapter.Fill(oDataSet, "Articulos")
        oSqlClienteDataAdapter.Fill(oDataSet, "Clientes")
        'oSqlComprobanteDataAdapter.Fill(oDataSet, "Comprobantes")
        oSqlCondicionVentaDataAdapter.Fill(oDataSet, "CondicionVenta")
        oSqlCondIvaDataAdapter.Fill(oDataSet, "CondIva")
        oSqlDetalleVentaDataAdapter.Fill(oDataSet, "Detalle_venta")
        'oSqlLocaldidadesDataAdapter.Fill(oDataSet, "Localidades")
        'oSqlDomicilio_x_clienteDataAdapter.Fill(oDataSet, "Domicilio_x_cliente")


        'numero de factura
        nroFactura.ParameterFieldName = "nroFactura" ' Este es el nombre del parametro en el crystal
        paramnroFactura.Value = generarNumeroFactura(idVenta) ' el nombre de tu textbox
        nroFactura.CurrentValues.Add(paramnroFactura)

        parametros.Add(nroFactura)


        'numero de factura


        'Dim informe As New rpComprobante
        Dim informe As New rpDetalleVenta
        informe.SetDataSource(oDataSet)
        visorDetalle.ReportSource = informe
        visorDetalle.ParameterFieldInfo = parametros

    End Sub

    Private Function generarNumeroFactura(ByVal idFactura As Integer) As String
        Dim oDataSet As New DataSet
        Dim objVentas As New Ventas
        Dim i As Integer
        Dim cadena As String
        Dim nroNV As Integer
        Dim numeroFacturaConvertido As String
        nroNV = idFactura

        cadena = ""
        i = nroNV.ToString.Length
        While i < 8
            cadena = cadena.ToString & "0"
            i = i + 1
        End While
        numeroFacturaConvertido = "0001 - " & cadena & nroNV
        Return numeroFacturaConvertido

    End Function
End Class