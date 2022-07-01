Imports System.Data
Imports System.Data.OleDb
Public Class frmPresupuesto

    Dim idVenta As Integer
    Dim mandarMail As Boolean
    Dim idClientes As Integer
#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlDataAdapter1 As OleDbDataAdapter
    Dim oSqlArticuloDataAdapter As OleDbDataAdapter
    Dim oSqlArticulo1DataAdapter As OleDbDataAdapter
    Dim oSqlClienteDataAdapter As OleDbDataAdapter
    Dim oSqlComprobanteDataAdapter As OleDbDataAdapter
    Dim oSqlCondicionVentaDataAdapter As OleDbDataAdapter
    Dim oSqlCondIvaDataAdapter As OleDbDataAdapter
    Dim oSqlDetalleVentaDataAdapter As OleDbDataAdapter
    Dim oSqlVentasDataAdapter As OleDbDataAdapter
    Dim oSqlLocaldidadesDataAdapter As OleDbDataAdapter
    Dim oSqlDomicilio_x_clienteDataAdapter As OleDbDataAdapter

    Dim oSqlOpcionalesDataAdapter As OleDbDataAdapter

    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataSet1 As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

    Public Sub New(ByVal id As Integer, ByVal mail As Boolean, ByVal idClientes As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        idVenta = id
        mandarMail = mail
        Me.idClientes = idClientes
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#End Region

    Private Sub frmPresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.llenarReporte()

    End Sub

    Public Sub llenarReporte()

        Dim cadenaVenta As String
        Dim cadenaArticulo As String
        Dim cadenaCliente As String
        'Dim cadenaComprobante As String
        Dim cadenaCondicionVenta As String
        Dim cadenaCondIva As String
        Dim cadenaDetalleVenta As String
        'Dim cadenaLocaldidades As String
        Dim cadenaDomicilio_x_cliente As String
        Dim cadenaOpcionales As String

        cadenaVenta = "select * from Ventas where idVenta= " & idVenta
        cadenaArticulo = "select * from Articulos"
        cadenaCliente = "select * from Clientes"
        'cadenaComprobante = "select * from Comprobantes"
        cadenaCondicionVenta = "select * from CondicionVenta"
        cadenaCondIva = "select * from CondIva"
        cadenaDetalleVenta = "select * from Detalle_venta"
        'cadenaLocaldidades = "select * from Localidades"
        cadenaDomicilio_x_cliente = "select * from Domicilio_x_cliente"
        cadenaOpcionales = "select * from OpcionalesXPresupuesto where idVenta= " & idVenta

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
        oSqlOpcionalesDataAdapter = New OleDbDataAdapter(cadenaOpcionales, oSqlConnection)


        oSqlArticulo1DataAdapter = New OleDbDataAdapter(cadenaArticulo, oSqlConnection)

        'reporte principal
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
        'oSqlOpcionalesDataAdapter.Fill(oDataSet, "OpcionalesXPresupuesto")
        Dim informe As New rpPresupuesto

        'reporte opcional
        oDataSet1 = New dsParaReporte
        oSqlVentasDataAdapter.Fill(oDataSet1, "Ventas")
        oSqlArticulo1DataAdapter.Fill(oDataSet1, "Articulos")
        oSqlOpcionalesDataAdapter.Fill(oDataSet1, "OpcionalesXPresupuesto")


        Dim informeOpcional As New opcionalesPresupuesto

        informe.Subreports.Item("opcionalesPresupuesto.rpt").SetDataSource(oDataSet1)


        Dim objCliente As New Clientes
        'Dim informe As New rpDetalleVenta
        informe.SetDataSource(oDataSet)

        If mandarMail = True Then
            Dim objMail As New Mail
            objMail.textoCuerpo = "Presupuesto"
            'objMail.ExportToPDF(informe, "Resumen cuenta corriente.pdf", objMail.textoCuerpo)
            If objCliente.buscarMail(idClientes).Tables(0).Rows.Count > 0 Then
                objMail.ExportToPDF(informe, "Presupuesto.pdf", "Presupuesto", objCliente.buscarMail(idClientes).Tables(0).Rows(0).Item("mail").ToString)
            Else
                objMail.ExportToPDF(informe, "Presupuesto.pdf", "Presupuesto", "")
            End If

            Me.Close()
        Else
            visorPresupuesto.ReportSource = informe

        End If


    End Sub
End Class