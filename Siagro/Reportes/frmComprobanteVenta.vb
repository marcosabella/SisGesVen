Imports System.Data
Imports System.Data.OleDb
Public Class frmComprobanteVenta

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

    Public Sub New(ByVal id As Integer, ByVal mail As Boolean, ByVal idCliente As Integer, ByVal nrocae As String, ByVal vtoCae As String, ByVal tipoComprobante As Integer, ByVal codComprobante As String, ByVal idVentaAfip As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        idVenta = id
        mandarMail = mail
        Me.idCliente = idCliente
        Me.nrocae = nrocae
        Me.vtoCae = vtoCae
        Me.tipoComprobante = tipoComprobante
        Me.codComprobante = codComprobante
        Me.idVentaAfip = idVentaAfip
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ByVal tipoComprobante As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        'idVenta = id
        'mandarMail = Mail
        'Me.idCliente = idCliente
        'Me.nrocae = nrocae
        'Me.vtoCae = vtoCae
        Me.tipoComprobante = tipoComprobante
        'Me.codComprobante = codComprobante
        'Me.idVentaAfip = idVentaAfip
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#End Region

    Private Sub frmComprobanteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.llenarReporte()
        llenarNuevoReporte()
    End Sub

    Public Sub llenarReporte()

        Dim parametros As New CrystalDecisions.Shared.ParameterFields

        Dim nroFactura As New CrystalDecisions.Shared.ParameterField
        Dim paramnroFactura As New CrystalDecisions.Shared.ParameterDiscreteValue

        Dim cae As New CrystalDecisions.Shared.ParameterField
        Dim paramnrocae As New CrystalDecisions.Shared.ParameterDiscreteValue

        Dim vtoCae As New CrystalDecisions.Shared.ParameterField
        Dim paramnrovtoCae As New CrystalDecisions.Shared.ParameterDiscreteValue

        Dim tipoComprobanteP As New CrystalDecisions.Shared.ParameterField
        Dim paramntipoComprobante As New CrystalDecisions.Shared.ParameterDiscreteValue

        Dim codComprobante As New CrystalDecisions.Shared.ParameterField
        Dim paramcodComprobante As New CrystalDecisions.Shared.ParameterDiscreteValue

        Dim direccion As New CrystalDecisions.Shared.ParameterField
        Dim paramDireccion As New CrystalDecisions.Shared.ParameterDiscreteValue

        Dim cadenaVenta As String
        Dim cadenaArticulo As String
        Dim cadenaCliente As String
        'Dim cadenaComprobante As String
        Dim cadenaCondicionVenta As String
        Dim cadenaCondIva As String
        Dim cadenaDetalleVenta As String
        Dim cadenaLocaldidades As String
        Dim cadenaDomicilio_x_cliente As String

        cadenaVenta = "select * from Ventas where idVenta= " & idVenta
        cadenaArticulo = "select * from Articulos"
        cadenaCliente = "select * from Clientes"
        'cadenaComprobante = "select * from Comprobantes"
        cadenaCondicionVenta = "select * from CondicionVenta"
        cadenaCondIva = "select * from CondIva"
        cadenaDetalleVenta = "select * from Detalle_venta"
        cadenaLocaldidades = "select * from Localidades"
        'cadenaDomicilio_x_cliente = "select * from Domicilio_x_cliente"

        oSqlConnection = New OleDbConnection(strConection)

        oSqlVentasDataAdapter = New OleDbDataAdapter(cadenaVenta, oSqlConnection)
        oSqlArticuloDataAdapter = New OleDbDataAdapter(cadenaArticulo, oSqlConnection)
        oSqlClienteDataAdapter = New OleDbDataAdapter(cadenaCliente, oSqlConnection)
        'oSqlComprobanteDataAdapter = New OleDbDataAdapter(cadenaComprobante, oSqlConnection)
        oSqlCondicionVentaDataAdapter = New OleDbDataAdapter(cadenaCondicionVenta, oSqlConnection)
        oSqlCondIvaDataAdapter = New OleDbDataAdapter(cadenaCondIva, oSqlConnection)
        oSqlDetalleVentaDataAdapter = New OleDbDataAdapter(cadenaDetalleVenta, oSqlConnection)
        oSqlLocaldidadesDataAdapter = New OleDbDataAdapter(cadenaLocaldidades, oSqlConnection)
        'oSqlDomicilio_x_clienteDataAdapter = New OleDbDataAdapter(cadenaDomicilio_x_cliente, oSqlConnection)



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

        Dim informe As New rpComprobante
        Dim informe1 As New rpComprobante1
        Dim objCliente As New Clientes


        'numero de factura
        nroFactura.ParameterFieldName = "nroFactura" ' Este es el nombre del parametro en el crystal
        If idVentaAfip.ToString <> 0 Then
            paramnroFactura.Value = generarNumeroFactura(idVentaAfip, "0003") ' el nombre de tu textbox
        Else
            paramnroFactura.Value = generarNumeroFactura(idVenta, "0001") ' el nombre de tu textbox
        End If

        nroFactura.CurrentValues.Add(paramnroFactura)

        'numero de factura

        'cae
        cae.ParameterFieldName = "cae" ' Este es el nombre del parametro en el crystal
        paramnrocae.Value = nrocae ' el nombre de tu textbox
        cae.CurrentValues.Add(paramnrocae)

        'cae

        'vtocae
        vtoCae.ParameterFieldName = "vtoCae" ' Este es el nombre del parametro en el crystal
        paramnrovtoCae.Value = Me.vtoCae ' el nombre de tu textbox
        vtoCae.CurrentValues.Add(paramnrovtoCae)
        'vto cae


        'tipo comprobante
        tipoComprobanteP.ParameterFieldName = "tipoComprobante" ' Este es el nombre del parametro en el crystal
        If Me.tipoComprobante = 1 Then
            paramntipoComprobante.Value = "A" ' el nombre de tu textbox
        ElseIf Me.tipoComprobante = 2 Then
            paramntipoComprobante.Value = "Nota de Débito A"
        ElseIf Me.tipoComprobante = 3 Then
            paramntipoComprobante.Value = "Nota de Crédito A"
        ElseIf Me.tipoComprobante = 6 Then
            paramntipoComprobante.Value = "B"
        ElseIf Me.tipoComprobante = 7 Then
            paramntipoComprobante.Value = "Nota de Débito B"
        ElseIf Me.tipoComprobante = 8 Then
            paramntipoComprobante.Value = "Nota de Crédito B"
        ElseIf Me.tipoComprobante = 11 Then
            paramntipoComprobante.Value = "C"
        Else
            paramntipoComprobante.Value = "X"
        End If
        tipoComprobanteP.CurrentValues.Add(paramntipoComprobante)
        'tipo comprobante

        'cod comprobante

        codComprobante.ParameterFieldName = "codComprobante" ' Este es el nombre del parametro en el crystal
        paramcodComprobante.Value = "Cod. " & Me.codComprobante ' el nombre de tu textbox
        codComprobante.CurrentValues.Add(paramcodComprobante)
        'cod comprobante


        ''Dim objCliente As New Clientes
        Dim oDataSetLocalidad As New DataSet
        oDataSetLocalidad = objCliente.buscarDomicilioXidCliente(Me.idCliente)
        If oDataSetLocalidad.Tables(0).Rows.Count > 0 Then
            'Localidad
            direccion.ParameterFieldName = "localidad" ' Este es el nombre del parametro en el crystal
            paramDireccion.Value = oDataSetLocalidad.Tables(0).Rows(0).Item("calle") & " " & oDataSetLocalidad.Tables(0).Rows(0).Item("numero") & " - " & oDataSetLocalidad.Tables(0).Rows(0).Item("Localidad") ' el nombre de tu textbox
            direccion.CurrentValues.Add(paramDireccion)
            'Localidad
        Else
            direccion.ParameterFieldName = "localidad" ' Este es el nombre del parametro en el crystal
            paramDireccion.Value = "-" ' el nombre de tu textbox
            direccion.CurrentValues.Add(paramDireccion)

        End If



        parametros.Add(vtoCae)
        parametros.Add(nroFactura)
        parametros.Add(cae)
        parametros.Add(tipoComprobanteP)
        parametros.Add(codComprobante)
        parametros.Add(direccion)

        If tipoComprobante > 3 Then
            informe1.SetDataSource(oDataSet)
        Else
            'comprobantes con iva discriminado
            informe.SetDataSource(oDataSet)
        End If
        'Dim informe As New rpDetalleVenta


        If mandarMail = True Then
            Dim objMail As New Mail
            objMail.textoCuerpo = "Comprobante venta"
            If objCliente.buscarMail(idCliente).Tables(0).Rows.Count > 0 Then
                If tipoComprobante < 4 Then
                    objMail.ExportToPDF(informe, "Comprobante venta.pdf", "Comprobante venta", objCliente.buscarMail(idCliente).Tables(0).Rows(0).Item("mail").ToString)
                Else
                    objMail.ExportToPDF(informe1, "Comprobante venta.pdf", "Comprobante venta", objCliente.buscarMail(idCliente).Tables(0).Rows(0).Item("mail").ToString)
                End If

            Else
                If tipoComprobante < 4 Then
                    objMail.ExportToPDF(informe, "Comprobante venta.pdf", "Comprobante venta", "")
                Else
                    objMail.ExportToPDF(informe1, "Comprobante venta.pdf", "Comprobante venta", "")
                End If

            End If
            Me.Close()
        Else
            If tipoComprobante > 3 Then
                'visor comprobante sin iva
                visorComprobantesVenta.ReportSource = informe1
                visorComprobantesVenta.ParameterFieldInfo = parametros

                Dim printDoc = New System.Drawing.Printing.PrintDocument()
                Dim sPrinterName = printDoc.PrinterSettings.PrinterName
                informe1.PrintOptions.PrinterName = sPrinterName

                informe1.PrintToPrinter(1, False, 0, 0)

            Else
                'visor comprobante con iva
                visorComprobantesVenta.ReportSource = informe
                visorComprobantesVenta.ParameterFieldInfo = parametros


            End If

        End If


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

    Public Sub llenarNuevoReporte()
        Dim objVenta As New Ventas
        Dim cadenaVenta As String
        Dim cadenaArticulo As String
        Dim cadenaCliente As String
        Dim cadenaComprobante As String
        Dim cadenaCondicionVenta As String
        Dim cadenaCondIva As String
        Dim cadenaDetalleVenta As String
        Dim cadenaDomicilio_x_cliente As String
        Dim cadenaCaeXventa As String
        Dim informeA As New rptFacturaA
        Dim InformeBC As New rptFacturaBC
        Dim objCliente As New Clientes

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

        If tipoComprobante > 3 Then
            InformeBC.SetDataSource(oDataSet)

            If MsgBox("¿Desea imprimir el siguiente comprobante?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                objVenta.marcarImpresaFactura(oDataSet.Tables("TempVentas").Rows(0).Item("numVenta"), True)
                InformeBC.PrintToPrinter(1, False, 0, 0)

                Me.Close()
            Else
                visorComprobantesVenta.ReportSource = InformeBC
            End If
        Else
            'comprobantes con iva discriminado
            informeA.SetDataSource(oDataSet)

            If MsgBox("¿Desea imprimir el siguiente comprobante?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                objVenta.marcarImpresaFactura(oDataSet.Tables("TempVentas").Rows(0).Item("numVenta"), True)
                informeA.PrintToPrinter(1, False, 0, 0)

                Me.Close()
            Else
                visorComprobantesVenta.ReportSource = informeA
            End If
        End If

    End Sub

End Class