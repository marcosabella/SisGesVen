Imports System.Data
Imports System.Data.OleDb



Public Class frmListadoCtaCte

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
    Dim oSqlSaldosCtaCte As OleDbDataAdapter
    Dim oSqlPagosDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"


#End Region

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click

        Dim objCliente As New Clientes
        Dim odataset As New DataSet
        Dim min As Integer = 0

        Dim frmBuscarCliente As New frmBuscarCliente
        frmBuscarCliente.ShowDialog()
        If frmBuscarCliente.idClienteBusqueda <> 0 Then

            Dim idCliente As Integer
            idCliente = frmBuscarCliente.idClienteBusqueda
            odataset = objCliente.buscarClientesXid(idCliente)
            Me.txtCodCliente.Text = odataset.Tables(0).Rows(0).Item("idCLiente")
            txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("nombre") & " " & odataset.Tables(0).Rows(0).Item("apellido")

        End If
    End Sub

    Private Sub opClientes_CheckedChanged(sender As Object, e As EventArgs) Handles opClientes.CheckedChanged
        If opClientes.Checked = True Then
            Me.txtCodCliente.Enabled = True
            Me.txtRazonSocialCliente.Enabled = True
            Me.btnBuscarCliente.Enabled = True

            Me.txtCodCliente.Text = ""
            Me.txtRazonSocialCliente.Text = ""

        Else
            Me.txtCodCliente.Enabled = False
            Me.txtRazonSocialCliente.Enabled = False
            Me.btnBuscarCliente.Enabled = False

            Me.txtCodCliente.Text = ""
            Me.txtRazonSocialCliente.Text = ""
        End If
    End Sub

    Private Sub frmListadoCtaCte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.inicializarControles()
        'Me.llenarReporte1()
        Me.llenarReporteSaldos()
    End Sub

    Private Sub inicializarControles()

        Me.txtCodCliente.Text = ""
        Me.txtRazonSocialCliente.Text = ""
        Me.btnBuscarCliente.Enabled = False

        Me.dtpFechaDesde.Enabled = False
        Me.dtpFechaHasta.Enabled = False

        Me.opClientes.Checked = False
        Me.opFecha.Checked = False
        Me.OpFiltro.Checked = False
        Me.opTodosClientes.Checked = True

        Me.opFecha.Enabled = False
        Me.opClientes.Enabled = False

    End Sub

    Private Sub OpFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles OpFiltro.CheckedChanged
        If OpFiltro.Checked = True Then
            Me.opFecha.Enabled = True
            Me.opClientes.Enabled = True
        Else
            Me.opFecha.Enabled = False
            Me.opClientes.Enabled = False

        End If
    End Sub

    Private Sub opFecha_CheckedChanged(sender As Object, e As EventArgs) Handles opFecha.CheckedChanged
        If opFecha.Checked = True Then
            Me.dtpFechaDesde.Enabled = True
            Me.dtpFechaHasta.Enabled = True
        Else
            Me.dtpFechaDesde.Enabled = False
            Me.dtpFechaHasta.Enabled = False
        End If
    End Sub

    Private Sub opTodosClientes_CheckedChanged(sender As Object, e As EventArgs) Handles opTodosClientes.CheckedChanged
        If opTodosClientes.Checked = True Then
            Me.inicializarControles()
        End If
    End Sub

    Public Sub llenarReporte()
        Dim objClientes As New Clientes
        Dim cadenaVenta As String
        'Dim cadenaArticulo As String
        Dim cadenaCliente As String
        'Dim cadenaComprobante As String
        Dim cadenaCondicionVenta As String
        'Dim cadenaCondIva As String
        'Dim cadenaDetalleVenta As String
        Dim cadenaPagos As String



        Dim informe As Object

        Dim tituloInforme As New CrystalDecisions.Shared.ParameterField
        Dim paramtituloInforme As New CrystalDecisions.Shared.ParameterDiscreteValue

        'Dim cadenaDomicilio_x_cliente As String

        cadenaVenta = "select * from Ventas where idCondicion_venta = 2"
        'cadenaVenta = "select * from Ventas"
        'cadenaArticulo = "select * from Articulos"
        cadenaCliente = "select * from Clientes"
        'cadenaComprobante = "select * from Comprobantes"
        cadenaCondicionVenta = "select * from CondicionVenta"
        'cadenaCondIva = "select * from CondIva"
        'cadenaDetalleVenta = "select * from Detalle_venta"
        cadenaPagos = "select * from Pagos"
        'cadenaPagos = "select * from Pagos"
        'cadenaDomicilio_x_cliente = "select * from Domicilio_x_cliente"



        If opTodosClientes.Checked = True Then
            ' para todos los clientes sin filtro
            informe = New rpCtaCte

        Else
            'para los filtros
            If opClientes.Checked = True Then
                'filtro de clientes activo
                If Me.txtCodCliente.Text <> "" Then
                    cadenaCliente = "select * from Clientes where idCliente = " & txtCodCliente.Text
                    informe = New rpCtaCteXcliente
                Else
                    MsgBox("Seleccione el cliente", MsgBoxStyle.Information, "SISTEMA DE GESTIÓN DE VENTAS Y STOCK")
                    Exit Sub
                End If
            Else
                    informe = New rpCtaCte
            End If
            If opFecha.Checked = True Then
                'selector de fecha activoWHERE ep.Rate BETWEEN 27 AND 30 
                cadenaVenta = "select * from Ventas where idCondicion_venta = 2 and fecha_venta between #" & FormatDateTime(Me.dtpFechaDesde.Value, DateFormat.ShortDate) & "# and #" & FormatDateTime(Me.dtpFechaHasta.Value, DateFormat.ShortDate) & "#"
            End If

        End If



        oSqlConnection = New OleDbConnection(strConection)

        oSqlVentasDataAdapter = New OleDbDataAdapter(cadenaVenta, oSqlConnection)
        'oSqlArticuloDataAdapter = New OleDbDataAdapter(cadenaArticulo, oSqlConnection)
        oSqlClienteDataAdapter = New OleDbDataAdapter(cadenaCliente, oSqlConnection)
        'oSqlComprobanteDataAdapter = New OleDbDataAdapter(cadenaComprobante, oSqlConnection)
        oSqlCondicionVentaDataAdapter = New OleDbDataAdapter(cadenaCondicionVenta, oSqlConnection)
        'oSqlCondIvaDataAdapter = New OleDbDataAdapter(cadenaCondIva, oSqlConnection)
        'oSqlDetalleVentaDataAdapter = New OleDbDataAdapter(cadenaDetalleVenta, oSqlConnection)
        oSqlPagosDataAdapter = New OleDbDataAdapter(cadenaPagos, oSqlConnection)
        'oSqlDomicilio_x_clienteDataAdapter = New OleDbDataAdapter(cadenaDomicilio_x_cliente, oSqlConnection)


        oDataSet = New dsParaReporte
        ' oDataSet = New DataSet
        'oDataSet = objClientes.resumenCtaCteCliente

        oSqlVentasDataAdapter.Fill(oDataSet, "Ventas")
        'oSqlArticuloDataAdapter.Fill(oDataSet, "Articulos")
        oSqlClienteDataAdapter.Fill(oDataSet, "Clientes")
        'oSqlComprobanteDataAdapter.Fill(oDataSet, "Comprobantes")
        oSqlCondicionVentaDataAdapter.Fill(oDataSet, "CondicionVenta")
        'oSqlCondIvaDataAdapter.Fill(oDataSet, "CondIva")
        'oSqlDetalleVentaDataAdapter.Fill(oDataSet, "Detalle_venta")
        ''oSqlLocaldidadesDataAdapter.Fill(oDataSet, "Localidades")
        oSqlPagosDataAdapter.Fill(oDataSet, "Pagos")

        tituloInforme.ParameterFieldName = "tituloInforme" ' Este es el nombre del parametro en el crystal
        paramtituloInforme.Value = "Resumen de Cuenta Corriente"


        tituloInforme.CurrentValues.Add(paramtituloInforme)

        Dim parametros As New CrystalDecisions.Shared.ParameterFields
        parametros.Add(tituloInforme)


        informe.SetDataSource(oDataSet)

        visorCtaCte.ReportSource = informe
        visorCtaCte.ParameterFieldInfo = parametros
        visorCtaCte.Refresh()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If opTodosClientes.Checked = True Then
            Me.llenarReporte1()
        ElseIf OpFiltro.Checked = True Then
            llenarReporte()
        End If
    End Sub

    Public Sub llenarReporte1()
        Dim objClientes As New Clientes
        Dim cadenaVenta As String
        Dim cadenaCliente As String
        Dim cadenaPagos As String



        Dim informe As Object

        Dim tituloInforme As New CrystalDecisions.Shared.ParameterField
        Dim paramtituloInforme As New CrystalDecisions.Shared.ParameterDiscreteValue

        cadenaCliente = "select * from Clientes order by apellido asc"
        'cadenaPagos = "select p.idCliente, sum(p.importe) as importe from Pagos p, Clientes c where p.idCliente = c.IdCliente group by p.IdCliente"
        'cadenaVenta = "select c.idCliente, sum(v.monto) as monto from Ventas v, Clientes c where v.idCliente = c.IdCliente and v.idCondicion_venta = 2 group by c.IdCliente"
        'cadenaVenta = "select * from Ventas where idCondicion_venta = 2"
        cadenaVenta = "select Clientes.idCliente, sum(monto) as monto from Ventas, Clientes where idCondicion_venta = 2 and Ventas.idCliente = Clientes.idCliente group by Clientes.idCliente"
        'cadenaPagos = "select * from Pagos"
        cadenaPagos = "select Clientes.idCliente, sum(importe) as importe from Pagos, Clientes where Pagos.idCliente = Clientes.idCliente group by Clientes.idCliente"





        oSqlConnection = New OleDbConnection(strConection)


        oSqlClienteDataAdapter = New OleDbDataAdapter(cadenaCliente, oSqlConnection)

        oSqlPagosDataAdapter = New OleDbDataAdapter(cadenaPagos, oSqlConnection)

        oSqlVentasDataAdapter = New OleDbDataAdapter(cadenaVenta, oSqlConnection)

        oDataSet = New dsParaReporte


        oSqlClienteDataAdapter.Fill(oDataSet, "Clientes")

        oSqlPagosDataAdapter.Fill(oDataSet, "Pagos")

        oSqlVentasDataAdapter.Fill(oDataSet, "Ventas")

        tituloInforme.ParameterFieldName = "tituloInforme" ' Este es el nombre del parametro en el crystal
        paramtituloInforme.Value = "Resumen de Cuenta Corriente"


        tituloInforme.CurrentValues.Add(paramtituloInforme)

        Dim parametros As New CrystalDecisions.Shared.ParameterFields
        parametros.Add(tituloInforme)

        informe = New rpCtaCte
        informe.SetDataSource(oDataSet)

        visorCtaCte.ReportSource = informe
        visorCtaCte.ParameterFieldInfo = parametros
        visorCtaCte.Refresh()


    End Sub

    Public Sub llenarReporteSaldos()
        Dim objClientes As New Clientes
        Dim cadenaTemp As String


        Dim informe As Object

        Dim tituloInforme As New CrystalDecisions.Shared.ParameterField
        Dim paramtituloInforme As New CrystalDecisions.Shared.ParameterDiscreteValue

        cadenaTemp = "select * from TempSaldosCtaCte order by nombreCliente asc"

        oSqlConnection = New OleDbConnection(strConection)

        oSqlSaldosCtaCte = New OleDbDataAdapter(cadenaTemp, oSqlConnection)

        oDataSet = New dsSaldosCtaCte

        oSqlSaldosCtaCte.Fill(oDataSet, "TempSaldosCtaCte")

        tituloInforme.ParameterFieldName = "tituloInforme" ' Este es el nombre del parametro en el crystal
        paramtituloInforme.Value = "Resumen de Cuenta Corriente"

        tituloInforme.CurrentValues.Add(paramtituloInforme)

        Dim parametros As New CrystalDecisions.Shared.ParameterFields
        parametros.Add(tituloInforme)

        informe = New rptSaldosCtaCte
        informe.SetDataSource(oDataSet)

        visorCtaCte.ReportSource = informe
        visorCtaCte.ParameterFieldInfo = parametros
        visorCtaCte.Refresh()

    End Sub
End Class