Imports System.Data
Imports System.Data.OleDb
Public Class frmComprobanteVentaMail
    Dim idVenta As Integer
    Dim idVentaAfip As Integer
    Dim mandarMail As Boolean
    Dim idCliente As Integer

    Dim nrocae As String
    Dim vtoCae As String

    Dim tipoComprobante As Integer
    Dim codComprobante As String
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
    Dim oSqlCaeXventa As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

    Public Sub New(ByVal tipoComprobante As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.tipoComprobante = tipoComprobante
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#End Region

    Private Sub frmComprobanteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.llenarReporte()

    End Sub

    Public Sub llenarReporte()

        Dim cadenaVenta As String
        Dim cadenaArticulo As String
        Dim cadenaCliente As String
        Dim cadenaComprobante As String
        Dim cadenaCondicionVenta As String
        Dim cadenaCondIva As String
        Dim cadenaDetalleVenta As String
        Dim cadenaDomicilio_x_cliente As String
        Dim cadenaCaeXventa As String

        cadenaVenta = "select * from TempVentas"
        cadenaArticulo = "select * from Articulos"
        cadenaCliente = "select * from Clientes"
        cadenaComprobante = "select * from Comprobantes"
        cadenaCondicionVenta = "select * from CondicionVenta"
        cadenaCondIva = "select * from CondIva"
        cadenaDetalleVenta = "select * from TempDetalle_Venta"
        cadenaDomicilio_x_cliente = "select * from Domicilio_x_cliente"
        cadenaCaeXventa = "select * from CaeXventa"

        oSqlConnection = New OleDbConnection(strConection)

        oSqlVentasDataAdapter = New OleDbDataAdapter(cadenaVenta, oSqlConnection)
        oSqlArticuloDataAdapter = New OleDbDataAdapter(cadenaArticulo, oSqlConnection)
        oSqlClienteDataAdapter = New OleDbDataAdapter(cadenaCliente, oSqlConnection)
        oSqlComprobanteDataAdapter = New OleDbDataAdapter(cadenaComprobante, oSqlConnection)
        oSqlCondicionVentaDataAdapter = New OleDbDataAdapter(cadenaCondicionVenta, oSqlConnection)
        oSqlCondIvaDataAdapter = New OleDbDataAdapter(cadenaCondIva, oSqlConnection)
        oSqlDetalleVentaDataAdapter = New OleDbDataAdapter(cadenaDetalleVenta, oSqlConnection)
        oSqlDomicilio_x_clienteDataAdapter = New OleDbDataAdapter(cadenaDomicilio_x_cliente, oSqlConnection)
        oSqlCaeXventa = New OleDbDataAdapter(cadenaCaeXventa, oSqlConnection)

        oDataSet = New dsComprobanteMail

        oSqlVentasDataAdapter.Fill(oDataSet, "TempVentas")
        oSqlArticuloDataAdapter.Fill(oDataSet, "Articulos")
        oSqlClienteDataAdapter.Fill(oDataSet, "Clientes")
        oSqlComprobanteDataAdapter.Fill(oDataSet, "Comprobantes")
        oSqlCondicionVentaDataAdapter.Fill(oDataSet, "CondicionVenta")
        oSqlCondIvaDataAdapter.Fill(oDataSet, "CondIva")
        oSqlDetalleVentaDataAdapter.Fill(oDataSet, "TempDetalle_Venta")
        oSqlDomicilio_x_clienteDataAdapter.Fill(oDataSet, "Domicilio_x_cliente")
        oSqlCaeXventa.Fill(oDataSet, "CaeXventa")

        'Dim informe As New rptComprobanteMail
        Dim informe As New rptFacturaBC
        Dim informe1 As New rptFacturaA
        Dim objCliente As New Clientes

        If tipoComprobante > 3 Then

            informe.SetDataSource(oDataSet)
        Else

            informe1.SetDataSource(oDataSet)
        End If

        Dim objMail As New Mail

        If tipoComprobante > 3 Then
            objMail.ExportToPDF(informe, "Comprobante venta.pdf", "Comprobante venta", "")
        Else
            objMail.ExportToPDF(informe1, "Comprobante venta.pdf", "Comprobante venta", "")
        End If

        Me.Close()

    End Sub

    Private Function generarNumeroFactura(ByVal idFactura As Integer, ByVal puntoVenta As String) As String
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
        numeroFacturaConvertido = puntoVenta & " - " & cadena & nroNV
        Return numeroFacturaConvertido

    End Function
End Class