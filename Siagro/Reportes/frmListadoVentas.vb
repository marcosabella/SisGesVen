Imports System.Data
Imports System.Data.OleDb
Public Class frmListadoVentas
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


#End Region
    Private Sub frmListadoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.llenarComboCondicionVenta()
    End Sub


    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs)

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

    Private Sub opClientes_CheckedChanged(sender As Object, e As EventArgs)
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
        Me.inicializarControles()
    End Sub

    Private Sub inicializarControles()

        Me.txtCodCliente.Text = ""
        Me.txtRazonSocialCliente.Text = ""
        Me.btnBuscarCliente.Enabled = False
        Me.cboCondVenta.Enabled = False
        Me.cboCondVenta.SelectedIndex = -1

        Me.dtpFechaDesde.Enabled = False
        Me.dtpFechaHasta.Enabled = False

        Me.opClientes.Checked = False
        Me.opFecha.Checked = False
        Me.opCondVenta.Checked = False
        Me.OpFiltro.Checked = False
        Me.opTodosClientes.Checked = True

        Me.opFecha.Enabled = False
        Me.opClientes.Enabled = False
        Me.opCondVenta.Enabled = False

    End Sub

    Private Sub OpFiltro_CheckedChanged(sender As Object, e As EventArgs)
        If OpFiltro.Checked = True Then
            Me.opFecha.Enabled = True
            Me.opClientes.Enabled = True
            Me.opCondVenta.Enabled = True
        Else
            Me.opFecha.Enabled = False
            Me.opClientes.Enabled = False
            Me.opCondVenta.Enabled = False
        End If
    End Sub

    Private Sub opFecha_CheckedChanged_1(sender As Object, e As EventArgs)
        If opFecha.Checked = True Then
            Me.dtpFechaDesde.Enabled = True
            Me.dtpFechaHasta.Enabled = True
        Else
            Me.dtpFechaDesde.Enabled = False
            Me.dtpFechaHasta.Enabled = False
        End If
    End Sub

    Private Sub opTodosClientes_CheckedChanged(sender As Object, e As EventArgs)
        If opTodosClientes.Checked = True Then
            Me.inicializarControles()
        End If
    End Sub

    Public Sub llenarReporte()

        Dim cadenaVenta As String
        Dim cadenaArticulo As String
        Dim cadenaCliente As String
        Dim cadenaComprobante As String
        Dim cadenaCondicionVenta As String
        'Dim cadenaCondIva As String
        Dim cadenaDetalleVenta As String

        Dim informe As Object

        Dim tituloInforme As New CrystalDecisions.Shared.ParameterField
        Dim paramtituloInforme As New CrystalDecisions.Shared.ParameterDiscreteValue


        'Dim cadenaDomicilio_x_cliente As String

        cadenaVenta = "select * from Ventas order by fecha_venta asc"
        cadenaArticulo = "select * from Articulos"
        cadenaCliente = "select * from Clientes"
        cadenaComprobante = "select * from Comprobantes"
        cadenaCondicionVenta = "select * from CondicionVenta"
        'cadenaCondIva = "select * from CondIva"
        cadenaDetalleVenta = "select * from Detalle_venta"

        'cadenaDomicilio_x_cliente = "select * from Domicilio_x_cliente"



        If opTodosClientes.Checked = True Then
            ' para todos los clientes sin filtro
            informe = New rpVentas

        Else
            'para los filtros
            If opClientes.Checked = True Then
                If Me.txtCodCliente.Text <> "" Then
                    'filtro de clientes activo
                    cadenaCliente = "select * from Clientes where idCliente = " & txtCodCliente.Text
                    informe = New rpVentas
                Else
                    MsgBox("Seleccione el cliente", MsgBoxStyle.Information, "SISTEMA DE GESIÓN DE VENTAS Y STOCK")
                    Exit Sub
                End If
            Else
                informe = New rpVentas
            End If
            If opFecha.Checked = True Then
                'selector de fecha activoWHERE ep.Rate BETWEEN 27 AND 30 
                'cadenaVenta = "select * from Ventas where fecha_venta between #" & FormatDateTime(dtpFechaDesde.Value, DateFormat.ShortDate) & "# and #" & FormatDateTime(Me.dtpFechaHasta.Value, DateFormat.ShortDate) & "#"
                cadenaVenta = "select * from Ventas where fecha_venta between #" & dtpFechaDesde.Value.Month & "/" & dtpFechaDesde.Value.Day & "/" & dtpFechaDesde.Value.Year & "# and #" & dtpFechaHasta.Value.Month & "/" & dtpFechaHasta.Value.Day & "/" & dtpFechaHasta.Value.Year & "#"


                If opCondVenta.Checked = True Then
                    If cboCondVenta.Text <> "" Then
                        cadenaVenta = "select * from Ventas where idCondicion_venta = " & cboCondVenta.SelectedValue & " and fecha_venta between #" & dtpFechaDesde.Value.Month & "/" & dtpFechaDesde.Value.Day & "/" & dtpFechaDesde.Value.Year & "# and #" & dtpFechaHasta.Value.Month & "/" & dtpFechaHasta.Value.Day & "/" & dtpFechaHasta.Value.Year & "#"
                    Else
                        MsgBox("Seleccione la condición de venta", MsgBoxStyle.Information, "SISTEMA DE GESIÓN DE VENTAS Y STOCK")
                        Exit Sub
                    End If
                End If
            Else
                If opCondVenta.Checked = True Then
                    If cboCondVenta.Text <> "" Then
                        cadenaVenta = "select * from Ventas where idCondicion_venta = " & cboCondVenta.SelectedValue
                    Else
                        MsgBox("Seleccione la condición de venta", MsgBoxStyle.Information, "SISTEMA DE GESIÓN DE VENTAS Y STOCK")
                        Exit Sub
                    End If
                End If
            End If


        End If



        oSqlConnection = New OleDbConnection(strConection)

        oSqlVentasDataAdapter = New OleDbDataAdapter(cadenaVenta, oSqlConnection)
        oSqlArticuloDataAdapter = New OleDbDataAdapter(cadenaArticulo, oSqlConnection)
        oSqlClienteDataAdapter = New OleDbDataAdapter(cadenaCliente, oSqlConnection)
        oSqlComprobanteDataAdapter = New OleDbDataAdapter(cadenaComprobante, oSqlConnection)
        oSqlCondicionVentaDataAdapter = New OleDbDataAdapter(cadenaCondicionVenta, oSqlConnection)
        'oSqlCondIvaDataAdapter = New OleDbDataAdapter(cadenaCondIva, oSqlConnection)
        oSqlDetalleVentaDataAdapter = New OleDbDataAdapter(cadenaDetalleVenta, oSqlConnection)

        'oSqlDomicilio_x_clienteDataAdapter = New OleDbDataAdapter(cadenaDomicilio_x_cliente, oSqlConnection)


        oDataSet = New dsParaReporte

        oSqlVentasDataAdapter.Fill(oDataSet, "Ventas")
        oSqlArticuloDataAdapter.Fill(oDataSet, "Articulos")
        oSqlClienteDataAdapter.Fill(oDataSet, "Clientes")
        oSqlComprobanteDataAdapter.Fill(oDataSet, "Comprobantes")
        oSqlCondicionVentaDataAdapter.Fill(oDataSet, "CondicionVenta")
        'oSqlCondIvaDataAdapter.Fill(oDataSet, "CondIva")
        oSqlDetalleVentaDataAdapter.Fill(oDataSet, "Detalle_venta")
        ''oSqlLocaldidadesDataAdapter.Fill(oDataSet, "Localidades")
        ''oSqlDomicilio_x_clienteDataAdapter.Fill(oDataSet, "Domicilio_x_cliente")

        tituloInforme.ParameterFieldName = "tituloInforme" ' Este es el nombre del parametro en el crystal
        paramtituloInforme.Value = "Listado de Ventas"
        tituloInforme.CurrentValues.Add(paramtituloInforme)

        Dim parametros As New CrystalDecisions.Shared.ParameterFields
        parametros.Add(tituloInforme)

        informe.SetDataSource(oDataSet)

        visorVentas.ReportSource = informe
        visorVentas.ParameterFieldInfo = parametros
        visorVentas.Refresh()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Me.llenarReporte()
    End Sub

    Private Sub llenarComboCondicionVenta()
        Dim objCondicionVenta As New CondicionVenta
        Dim oDataSet As New DataSet
        oDataSet = objCondicionVenta.buscarCondicionVenta
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboCondVenta.DataSource = oDataSet.Tables(0)
            Me.cboCondVenta.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboCondVenta.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboCondVenta.SelectedIndex = -1
        End If
    End Sub

    Private Sub opCondVenta_CheckedChanged_1(sender As Object, e As EventArgs)
        If opCondVenta.Checked = True Then
            Me.cboCondVenta.Enabled = True

        Else
            cboCondVenta.Enabled = False
            cboCondVenta.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.llenarReporte()
    End Sub

    Private Sub OpFiltro_CheckedChanged_1(sender As Object, e As EventArgs) Handles OpFiltro.CheckedChanged
        If OpFiltro.Checked = True Then
            Me.opFecha.Enabled = True
            Me.opClientes.Enabled = True
            Me.opCondVenta.Enabled = True
        Else
            Me.opFecha.Enabled = False
            Me.opClientes.Enabled = False
            Me.opCondVenta.Enabled = False
        End If
    End Sub

    Private Sub opTodosClientes_CheckedChanged_1(sender As Object, e As EventArgs) Handles opTodosClientes.CheckedChanged
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

    Private Sub opClientes_CheckedChanged_1(sender As Object, e As EventArgs) Handles opClientes.CheckedChanged
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

    Private Sub opFecha_CheckedChanged(sender As Object, e As EventArgs) Handles opFecha.CheckedChanged
        If opFecha.Checked = True Then
            Me.dtpFechaDesde.Enabled = True
            Me.dtpFechaHasta.Enabled = True
        Else
            Me.dtpFechaDesde.Enabled = False
            Me.dtpFechaHasta.Enabled = False
        End If
    End Sub

    Private Sub opCondVenta_CheckedChanged(sender As Object, e As EventArgs) Handles opCondVenta.CheckedChanged
        If opCondVenta.Checked = True Then
            Me.cboCondVenta.Enabled = True

        Else
            cboCondVenta.Enabled = False
            cboCondVenta.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnBuscarCliente_Click_1(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
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
End Class