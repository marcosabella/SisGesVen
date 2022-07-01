Imports System.Data
Imports System.Data.OleDb
Public Class frmComprobanteOrdenTrabajo
    Private precioArticuloSeleccionado, ivaArticuloSeleccionado, utilidad, descuento As Double
    Dim codigoArticuloDeVenta As Integer
    Dim codigoModeloCerca, codigoModeloLejos, codigoReparaciones As Integer
    Dim codigoOS As Integer
    Dim idOT As Integer
    Dim cadenaCristalLejos As String
    Dim cadenaPrecioCristalLejos As String
    Dim cadenaCristalCerca As String
    Dim cadenaPrecioCristalCerca As String
    Dim cadenaModeloLejos As String
    Dim cadenaMarcaLejos As String
    Dim cadenaPrecioArmazanLejos As String
    Dim cadenaModeloCerca As String
    Dim cadenaMarcaCerca As String
    Dim cadenaPrecioArmazonCerca As String
    Dim cadenaReparaciones As String
    Dim cadenaPrecioReparaciones As String

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlDataAdapter1 As OleDbDataAdapter
    Dim oSqlArticuloDataAdapter As OleDbDataAdapter
    Dim oSqlClienteDataAdapter As OleDbDataAdapter
    'Dim oSqlComprobanteDataAdapter As OleDbDataAdapter
    Dim oSqlCondicionVentaDataAdapter As OleDbDataAdapter
    Dim oSqlCondIvaDataAdapter As OleDbDataAdapter
    'Dim oSqlDetalleVentaDataAdapter As OleDbDataAdapter
    Dim oSqlOTDataAdapter As OleDbDataAdapter
    Dim oSqlLocaldidadesDataAdapter As OleDbDataAdapter
    Dim oSqlDomicilio_x_clienteDataAdapter As OleDbDataAdapter
    Dim oSqlDescuentosOSDataAdapter As OleDbDataAdapter
    Dim oSqlTarjetaDataAdapter As OleDbDataAdapter
    Dim oSqlTarjetaPorVentaDataAdapter As OleDbDataAdapter
    Dim oSqlOSaDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

    Public Sub New(ByVal id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        idOT = id
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#End Region
    Private Sub frmComprobanteOrdenTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarReporte()
    End Sub

    Public Sub llenarReporte()

        Dim cadenaOT As String
        Dim cadenaArticulo As String
        Dim cadenaCliente As String
        'Dim cadenaComprobante As String
        Dim cadenaCondicionVenta As String
        Dim cadenaCondIva As String
        'Dim cadenaDetalleVenta As String
        'Dim cadenaLocaldidades As String
        Dim cadenaDomicilio_x_cliente As String
        Dim cadenaDescuentoPorOS As String
        Dim cadenaTarjeta As String
        Dim cadenaTarjetaPorVenta As String
        Dim cadenaOS As String

        cadenaOT = "select * from OrdenTrabajo where idOT = " & idOT
        cadenaArticulo = "select * from Articulos"
        cadenaCliente = "select * from Clientes"
        'cadenaComprobante = "select * from Comprobantes"
        cadenaCondicionVenta = "select * from CondicionVenta"
        cadenaCondIva = "select * from CondIva"
        'cadenaDetalleVenta = "select * from Detalle_venta"
        'cadenaLocaldidades = "select * from Localidades"
        cadenaDomicilio_x_cliente = "select * from Domicilio_x_cliente"
        cadenaDescuentoPorOS = "select * from DescuentosPorObraSocial"
        cadenaTarjeta = "select * from Tarjetas"
        cadenaTarjetaPorVenta = "select * from TarjetaPorVenta"
        cadenaOS = "select * from ObraSocial"
        oSqlConnection = New OleDbConnection(strConection)

        oSqlOTDataAdapter = New OleDbDataAdapter(cadenaOT, oSqlConnection)
        oSqlArticuloDataAdapter = New OleDbDataAdapter(cadenaArticulo, oSqlConnection)
        oSqlClienteDataAdapter = New OleDbDataAdapter(cadenaCliente, oSqlConnection)
        'oSqlComprobanteDataAdapter = New OleDbDataAdapter(cadenaComprobante, oSqlConnection)
        oSqlCondicionVentaDataAdapter = New OleDbDataAdapter(cadenaCondicionVenta, oSqlConnection)
        oSqlCondIvaDataAdapter = New OleDbDataAdapter(cadenaCondIva, oSqlConnection)
        'oSqlDetalleVentaDataAdapter = New OleDbDataAdapter(cadenaDetalleVenta, oSqlConnection)
        'oSqlLocaldidadesDataAdapter = New OleDbDataAdapter(cadenaLocaldidades, oSqlConnection)
        oSqlDomicilio_x_clienteDataAdapter = New OleDbDataAdapter(cadenaDomicilio_x_cliente, oSqlConnection)
        oSqlDescuentosOSDataAdapter = New OleDbDataAdapter(cadenaDescuentoPorOS, oSqlConnection)
        oSqlTarjetaDataAdapter = New OleDbDataAdapter(cadenaTarjeta, oSqlConnection)
        oSqlTarjetaPorVentaDataAdapter = New OleDbDataAdapter(cadenaTarjetaPorVenta, oSqlConnection)
        oSqlOSaDataAdapter = New OleDbDataAdapter(cadenaOS, oSqlConnection)

        'data set para orden de trabajo
        oDataSet = New BDsiagroDataSet1

        oSqlOTDataAdapter.Fill(oDataSet, "OrdenTrabajo")
        oSqlArticuloDataAdapter.Fill(oDataSet, "Articulos")
        oSqlClienteDataAdapter.Fill(oDataSet, "Clientes")
        'oSqlComprobanteDataAdapter.Fill(oDataSet, "Comprobantes")
        oSqlCondicionVentaDataAdapter.Fill(oDataSet, "CondicionVenta")
        oSqlCondIvaDataAdapter.Fill(oDataSet, "CondIva")
        'oSqlDetalleVentaDataAdapter.Fill(oDataSet, "Detalle_venta")
        'oSqlLocaldidadesDataAdapter.Fill(oDataSet, "Localidades")
        oSqlDomicilio_x_clienteDataAdapter.Fill(oDataSet, "Domicilio_x_cliente")
        oSqlDescuentosOSDataAdapter.Fill(oDataSet, "DescuentosPorObraSocial")
        oSqlTarjetaDataAdapter.Fill(oDataSet, "Tarjetas")
        oSqlTarjetaPorVentaDataAdapter.Fill(oDataSet, "TarjetaPorVenta")
        oSqlOSaDataAdapter.Fill(oDataSet, "ObraSocial")

        buscarOT(idOT)
        Dim parametros As New CrystalDecisions.Shared.ParameterFields
        Dim cristalLejo As New CrystalDecisions.Shared.ParameterField
        Dim paramCristalLejos As New CrystalDecisions.Shared.ParameterDiscreteValue
        cristalLejo.ParameterFieldName = "cristalLejos" ' Este es el nombre del parametro en el crystal
        If cadenaCristalLejos = Nothing Then
            paramCristalLejos.Value = ""
        Else
            paramCristalLejos.Value = cadenaCristalLejos
        End If

        cristalLejo.CurrentValues.Add(paramCristalLejos)



        Dim precioCristalLejo As New CrystalDecisions.Shared.ParameterField
        Dim paramprecioCristalLejos As New CrystalDecisions.Shared.ParameterDiscreteValue
        precioCristalLejo.ParameterFieldName = "precioCristalLejos" ' Este es el nombre del parametro en el crystal
        If cadenaPrecioCristalLejos = Nothing Then
            paramprecioCristalLejos.Value = 0
        Else
            paramprecioCristalLejos.Value = cadenaPrecioCristalLejos
        End If

        precioCristalLejo.CurrentValues.Add(paramprecioCristalLejos)
        'Dim parametros As New CrystalDecisions.Shared.ParameterFields


        Dim cristalCerca As New CrystalDecisions.Shared.ParameterField
        Dim paramcristalCerca As New CrystalDecisions.Shared.ParameterDiscreteValue
        cristalCerca.ParameterFieldName = "cristalCerca" ' Este es el nombre del parametro en el crystal
        If cadenaCristalCerca = Nothing Then
            paramcristalCerca.Value = ""
        Else
            paramcristalCerca.Value = cadenaCristalCerca
        End If
        cristalCerca.CurrentValues.Add(paramcristalCerca)



        Dim preciocristalCerca As New CrystalDecisions.Shared.ParameterField
        Dim parampreciocristalCerca As New CrystalDecisions.Shared.ParameterDiscreteValue
        preciocristalCerca.ParameterFieldName = "precioCristalCerca" ' Este es el nombre del parametro en el crystal
        If cadenaPrecioCristalCerca = Nothing Then
            parampreciocristalCerca.Value = 0
        Else
            parampreciocristalCerca.Value = cadenaPrecioCristalCerca
        End If
        preciocristalCerca.CurrentValues.Add(parampreciocristalCerca)

        Dim marcaLejos As New CrystalDecisions.Shared.ParameterField
        Dim parammarcaLejos As New CrystalDecisions.Shared.ParameterDiscreteValue
        marcaLejos.ParameterFieldName = "marcaLejos" ' Este es el nombre del parametro en el crystal
        If cadenaMarcaLejos = Nothing Then
            parammarcaLejos.Value = ""
        Else
            parammarcaLejos.Value = cadenaMarcaLejos
        End If
        marcaLejos.CurrentValues.Add(parammarcaLejos)

        Dim ModeloLejos As New CrystalDecisions.Shared.ParameterField
        Dim paramModeloLejos As New CrystalDecisions.Shared.ParameterDiscreteValue
        ModeloLejos.ParameterFieldName = "ModeloLejos" ' Este es el nombre del parametro en el crystal
        If cadenaModeloLejos = Nothing Then
            paramModeloLejos.Value = ""
        Else
            paramModeloLejos.Value = cadenaModeloLejos
        End If
        ModeloLejos.CurrentValues.Add(paramModeloLejos)

        Dim precioArmazonLejos As New CrystalDecisions.Shared.ParameterField
        Dim paramprecioArmazonLejos As New CrystalDecisions.Shared.ParameterDiscreteValue
        precioArmazonLejos.ParameterFieldName = "precioArmazonLejos" ' Este es el nombre del parametro en el crystal
        If cadenaPrecioArmazanLejos = Nothing Then
            paramprecioArmazonLejos.Value = 0
        Else
            paramprecioArmazonLejos.Value = cadenaPrecioArmazanLejos
        End If

        precioArmazonLejos.CurrentValues.Add(paramprecioArmazonLejos)

        '
        Dim marcaCerca As New CrystalDecisions.Shared.ParameterField
        Dim parammarcaCerca As New CrystalDecisions.Shared.ParameterDiscreteValue
        marcaCerca.ParameterFieldName = "marcaCerca" ' Este es el nombre del parametro en el crystal
        If cadenaMarcaCerca = Nothing Then
            parammarcaCerca.Value = ""
        Else
            parammarcaCerca.Value = cadenaMarcaCerca
        End If
        marcaCerca.CurrentValues.Add(parammarcaCerca)

        Dim ModeloCerca As New CrystalDecisions.Shared.ParameterField
        Dim paramModeloCerca As New CrystalDecisions.Shared.ParameterDiscreteValue
        ModeloCerca.ParameterFieldName = "ModeloCerca" ' Este es el nombre del parametro en el crystal
        If cadenaModeloCerca = Nothing Then
            paramModeloCerca.Value = ""
        Else
            paramModeloCerca.Value = cadenaModeloCerca
        End If
        ModeloCerca.CurrentValues.Add(paramModeloCerca)

        Dim precioArmazonCerca As New CrystalDecisions.Shared.ParameterField
        Dim paramprecioArmazonCerca As New CrystalDecisions.Shared.ParameterDiscreteValue
        precioArmazonCerca.ParameterFieldName = "precioArmazonCerca" ' Este es el nombre del parametro en el crystal
        If cadenaPrecioArmazonCerca = Nothing Then
            paramprecioArmazonCerca.Value = 0
        Else
            paramprecioArmazonCerca.Value = cadenaPrecioArmazonCerca
        End If
        precioArmazonCerca.CurrentValues.Add(paramprecioArmazonCerca)

        Dim reparaciones As New CrystalDecisions.Shared.ParameterField
        Dim paramreparaciones As New CrystalDecisions.Shared.ParameterDiscreteValue
        reparaciones.ParameterFieldName = "reparaciones" ' Este es el nombre del parametro en el crystal
        If cadenaReparaciones = Nothing Then
            paramreparaciones.Value = ""
        Else
            paramreparaciones.Value = cadenaReparaciones
        End If
        reparaciones.CurrentValues.Add(paramreparaciones)

        Dim precioreparaciones As New CrystalDecisions.Shared.ParameterField
        Dim paramprecioreparaciones As New CrystalDecisions.Shared.ParameterDiscreteValue
        precioreparaciones.ParameterFieldName = "precioreparaciones" ' Este es el nombre del parametro en el crystal
        If cadenaReparaciones = Nothing Then
            paramprecioreparaciones.Value = 0
        Else
            paramprecioreparaciones.Value = cadenaPrecioReparaciones
        End If
        precioreparaciones.CurrentValues.Add(paramprecioreparaciones)

        Dim codigoBarras As New CrystalDecisions.Shared.ParameterField
        Dim paramcodigoBarras As New CrystalDecisions.Shared.ParameterDiscreteValue
        codigoBarras.ParameterFieldName = "codigoBarras" ' Este es el nombre del parametro en el crystal
        paramcodigoBarras.Value = generarNumeroCodigoBarras(idOT)
        codigoBarras.CurrentValues.Add(paramcodigoBarras)


        parametros.Add(cristalLejo)
        parametros.Add(precioCristalLejo)
        parametros.Add(cristalCerca)
        parametros.Add(preciocristalCerca)
        parametros.Add(marcaLejos)
        parametros.Add(ModeloLejos)
        parametros.Add(precioArmazonLejos)
        parametros.Add(marcaCerca)
        parametros.Add(ModeloCerca)
        parametros.Add(precioArmazonCerca)
        parametros.Add(reparaciones)
        parametros.Add(precioreparaciones)
        parametros.Add(codigoBarras)

        Dim informe As New rpOrdenTrabajo
        'Dim informe As New rpDetalleVenta
        informe.SetDataSource(oDataSet)
        visorOrdenTrabajo.ReportSource = informe
        visorOrdenTrabajo.ParameterFieldInfo = parametros


    End Sub

    Private Sub buscarOT(ByVal idOT As Integer)
        Dim objVentas As New Ventas
        Dim objOT As New OrdenTrabajo
        Dim oDataSet As New DataSet
        Dim objCliente As New Clientes
        Dim objArticulo As New Articulos
        Dim objCondicionVenta As New CondicionVenta
        Dim objAfip As New AFIP
        Dim oDataSetVentas As New DataSet
        Dim oDataSetCliente As New DataSet
        Dim oDataSetTarjetas As New DataSet
        Dim oDataSetOS As New DataSet
        Dim objOS As New ObraSocial

        oDataSet = objOT.BuscarOrdenesXid(idOT)


        If oDataSet.Tables(0).Rows(0).Item("idCristalLejos") = 0 Then
        Else
            'Me.txtCodigoCristalLejos.Text = oDataSet.Tables(0).Rows(0).Item("idCristalLejos")
            Me.llenarCampoArticulo(oDataSet.Tables(0).Rows(0).Item("idCristalLejos"), "cristal lejos")
        End If

        If oDataSet.Tables(0).Rows(0).Item("idCristalCerca") = 0 Then
        Else
            'Me.txtCodigoCristalCerca.Text = oDataSet.Tables(0).Rows(0).Item("idCristalCerca")
            Me.llenarCampoArticulo(oDataSet.Tables(0).Rows(0).Item("idCristalCerca"), "cristal cerca")
        End If

        If oDataSet.Tables(0).Rows(0).Item("idArmazonCerca") = 0 Then
        Else
            'Me.codigoModeloCerca = oDataSet.Tables(0).Rows(0).Item("idArmazonCerca")
            Me.llenarCampoArticulo(oDataSet.Tables(0).Rows(0).Item("idArmazonCerca"), "modelo cerca")
        End If

        If oDataSet.Tables(0).Rows(0).Item("idArmazonLejos") = 0 Then
        Else
            'Me.codigoModeloLejos = oDataSet.Tables(0).Rows(0).Item("idArmazonLejos")
            Me.llenarCampoArticulo(oDataSet.Tables(0).Rows(0).Item("idArmazonLejos"), "modelo lejos")
        End If

        If oDataSet.Tables(0).Rows(0).Item("idReparacion") = 0 Then
        Else
            'Me.codigoReparaciones = oDataSet.Tables(0).Rows(0).Item("idReparacion")
            Me.llenarCampoArticulo(oDataSet.Tables(0).Rows(0).Item("idReparacion"), "reparaciones")
        End If


        'calcularDescuentosRecargos()
    End Sub

    Private Sub llenarCampoArticulo(ByVal codigoArticulo As String, ByVal campo As String)
        Dim objArticulo As New Articulos
        Dim oDataSet As New DataSet

        oDataSet = objArticulo.buscarArticulo(codigoArticulo)
        If oDataSet.Tables(0).Rows.Count > 0 Then
            'Me.stock = oDataSet.Tables(0).Rows(0).Item("stock")
            'If accion = "" Then
            '    stock = 1
            'End If
            'If 1 <= Me.stock Then
            Me.precioArticuloSeleccionado = FormatNumber(oDataSet.Tables(0).Rows(0).Item("costo") + (oDataSet.Tables(0).Rows(0).Item("costo") * (oDataSet.Tables(0).Rows(0).Item("utilidad") / 100)), 2)
            Me.precioArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado - (Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("descuento") / 100)), 2)
            Me.ivaArticuloSeleccionado = FormatNumber(Me.precioArticuloSeleccionado * (oDataSet.Tables(0).Rows(0).Item("iva") / 100), 2)

            If campo = "cristal lejos" Then
                Me.cadenaCristalLejos = oDataSet.Tables(0).Rows(0).Item("descripcion")
                'Me.txtCodigoCristalLejos.Text = oDataSet.Tables(0).Rows(0).Item("idArticulo")
                Me.cadenaPrecioCristalLejos = Me.precioArticuloSeleccionado + Me.ivaArticuloSeleccionado
            ElseIf campo = "cristal cerca" Then
                Me.cadenaCristalCerca = oDataSet.Tables(0).Rows(0).Item("descripcion")
                'Me.txtCodigoCristalLejos.Text = oDataSet.Tables(0).Rows(0).Item("idArticulo")
                Me.cadenaPrecioCristalCerca = Me.precioArticuloSeleccionado + Me.ivaArticuloSeleccionado
            ElseIf campo = "modelo lejos" Then
                Dim objMarca As New Marca
                Me.cadenaModeloLejos = oDataSet.Tables(0).Rows(0).Item("descripcion")
                'Me.codigoModeloLejos = oDataSet.Tables(0).Rows(0).Item("idArticulo")
                Me.cadenaPrecioArmazanLejos = Me.precioArticuloSeleccionado + Me.ivaArticuloSeleccionado
                Me.cadenaMarcaLejos = objMarca.buscarMarca(oDataSet.Tables(0).Rows(0).Item("idMarca")).Tables(0).Rows(0).Item("descripcion")
            ElseIf campo = "modelo cerca" Then
                Dim objMarca As New Marca
                Me.cadenaModeloCerca = oDataSet.Tables(0).Rows(0).Item("descripcion")
                'Me.codigoModeloCerca = oDataSet.Tables(0).Rows(0).Item("idArticulo")
                Me.cadenaPrecioArmazonCerca = Me.precioArticuloSeleccionado + Me.ivaArticuloSeleccionado
                Me.cadenaMarcaCerca = objMarca.buscarMarca(oDataSet.Tables(0).Rows(0).Item("idMarca")).Tables(0).Rows(0).Item("descripcion")
            ElseIf campo = "reparaciones" Then
                'Dim objMarca As New Marca
                Me.cadenaReparaciones = oDataSet.Tables(0).Rows(0).Item("descripcion")
                'Me.codigoReparaciones = oDataSet.Tables(0).Rows(0).Item("idArticulo")
                Me.cadenaPrecioReparaciones = Me.precioArticuloSeleccionado + Me.ivaArticuloSeleccionado

            End If
            '    objArticulo.idArticulo = codigoArticulo
            '    objArticulo.restarStockArticulo(objArticulo, 1)
            'Else
            '    MsgBox("El artículo no contiene el stock que usted a ingrasado. Solo dispone de: " & Me.stock & " artículos")

            '    Exit Sub
        End If
        'End If
        'Me.sumarPrecios()
    End Sub

    Private Function generarNumeroCodigoBarras(ByVal idOT As Integer)
        'Dim oDataSet As New DataSet
        'Dim objVentas As New Ventas
        'oDataSet = objVentas.ultimaVenta(cboComprobantes.SelectedValue)
        Dim i As Integer
        Dim cadena As String
        Dim nroNV As Integer
        Dim cadenaReturn As String
        'Dim ultimoIdNotaVenta As Integer
        'oDataSet = objVentas.ultimaVenta

        'If oDataSet.Tables(0).Rows(0).Item(0).ToString = "" Then
        'ultimoIdNotaVenta = 0
        'Else

        'ultimoIdNotaVenta = oDataSet.Tables(0).Rows(0).Item(0)

        'End If
        'nroNV = ultimoIdNotaVenta + 1
        cadena = ""
        i = idOT.ToString.Length
        While i < 12
            cadena = cadena.ToString & "0"
            i = i + 1
        End While
        cadenaReturn = cadena & idOT
        'modificacion ultima
        'idVentaFN = nroNV
        Return cadenaReturn
    End Function
End Class