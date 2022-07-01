Imports System.IO
Imports System.Net
Imports System.Xml
Imports Siagro.convertirDolar


Public Class frmCtaCte
    Dim precioDolar As Double
    Dim totalSaldoVenta As Double
    Dim totalSaldoPagos As Double
    Dim totalSaldoOT As Double
    Dim totalSaldo As Double
    Dim totalParcialVentas As Double
    Dim totalParcialPagos As Double
    Dim totalParcialOT As Double
    Dim idCliente As Integer = 0

    Public numerofilas As Integer
    Dim indiceArray As Integer
    Private client As Object

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub New(ByVal idClienteSaldo As Integer)

        InitializeComponent()

        Dim objCliente As New Clientes
        Dim odataset As New DataSet

        Dim min As Integer = 0
        Dim objTempCtaCte As New TempCtaCte
        Dim frmBuscarCliente As New frmBuscarCliente

        objTempCtaCte.borrarTempCtaCte()
        idCliente = idClienteSaldo
        odataset = objCliente.buscarClientesXid(idCliente)
        Me.txtCodCliente.Text = odataset.Tables(0).Rows(0).Item("idCLiente")
        txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("nombre") & " " & odataset.Tables(0).Rows(0).Item("apellido")

        lstCtaCte.Rows.Clear()

        Me.buscarVentas()
        Me.buscarOT()
        Me.buscarPagos()

        Me.calcularSaldos()

        Me.generarTablaTemp()
        Me.cargarTempAgrilla()

        If lstCtaCte.RowCount > 0 Or (lstCtaCte.RowCount > 1 And chkHistorico.Checked = True) Then
            Me.btnPago.Enabled = True
            Me.btnImprimirResumenCtaCte.Enabled = True
            Me.btnMandarMail.Enabled = True
        Else
            Me.btnPago.Enabled = False
            Me.btnMandarMail.Enabled = False
            Me.btnImprimirResumenCtaCte.Enabled = False
        End If

        Me.btnBuscarCliente.Enabled = False
        Me.btnMandarMail.Enabled = True
        Me.btnImprimir.Enabled = True
        Me.btnPago.Enabled = True

    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click

        Dim objCliente As New Clientes
        Dim odataset As New DataSet

        Dim min As Integer = 0
        Dim objTempCtaCte As New TempCtaCte
        Dim frmBuscarCliente As New frmBuscarCliente
        frmBuscarCliente.ShowDialog()
        If frmBuscarCliente.idClienteBusqueda <> 0 Then

            objTempCtaCte.borrarTempCtaCte()
            idCliente = frmBuscarCliente.idClienteBusqueda
            odataset = objCliente.buscarClientesXid(idCliente)
            Me.txtCodCliente.Text = odataset.Tables(0).Rows(0).Item("idCLiente")
            txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("nombre") & " " & odataset.Tables(0).Rows(0).Item("apellido")

            lstCtaCte.Rows.Clear()

            Me.buscarVentas()
            Me.buscarOT()
            Me.buscarPagos()

            Me.calcularSaldos()

            Me.generarTablaTemp()
            Me.cargarTempAgrilla()
        End If
        If lstCtaCte.RowCount > 0 Or (lstCtaCte.RowCount > 1 And chkHistorico.Checked = True) Then
            Me.btnPago.Enabled = True
            Me.btnImprimirResumenCtaCte.Enabled = True
            Me.btnMandarMail.Enabled = True
        Else
            Me.btnPago.Enabled = False
            Me.btnMandarMail.Enabled = False
            Me.btnImprimirResumenCtaCte.Enabled = False
        End If
    End Sub
    Private Sub frmCtaCte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarComboRubro()
        Me.btnBuscarCliente.Focus()
        btnAplicar.Enabled = False
        dtpFechaDesde.Enabled = False
        If idCliente = 0 Then
            Me.btnPago.Enabled = False
            Me.btnImprimirResumenCtaCte.Enabled = False
            Me.btnMandarMail.Enabled = False
        End If

        Dim objVentas As New Ventas

    End Sub
    Private Sub cargarComboRubro()
        Dim objRubro As New Rubro
        Dim oDataSet As New DataSet
        oDataSet = objRubro.buscarRubros
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboRubro.DataSource = oDataSet.Tables(0)
            Me.cboRubro.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboRubro.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboRubro.SelectedIndex = -1
        End If
    End Sub
    Private Function calcularTotalXfactura(ByVal idFactura As Integer) As Double

        Dim objVentas As New Ventas
        Dim odataset As New DataSet
        Dim odatasetarticulo As New DataSet
        Dim objArticulo As New Articulos
        Dim acumuladorMonto As Double
        Dim i As Integer
        acumuladorMonto = 0
        i = 0
        odataset = objVentas.buscarDetalleFacturaXventa(idFactura)

        While i < odataset.Tables(0).Rows.Count
            odatasetarticulo = objArticulo.buscarArticulo(odataset.Tables(0).Rows(i).Item("idArticulo"))
            acumuladorMonto = acumuladorMonto + (odataset.Tables(0).Rows(i).Item("cantidad") * (Me.calcularPrecioVenta(odatasetarticulo.Tables(0).Rows(0).Item("costo"), odatasetarticulo.Tables(0).Rows(0).Item("iva"), odatasetarticulo.Tables(0).Rows(0).Item("descuento"), odatasetarticulo.Tables(0).Rows(0).Item("utilidad"))))

            i = i + 1
        End While
        Return acumuladorMonto

    End Function
    Private Function calcularPrecioVenta(ByVal costo As String, ByVal iva As String, ByVal descuento As String, ByVal utilidad As String) As Double
        Dim precioVenta As Double
        Dim conIva As Double
        Dim conUtilidad As Double
        conIva = (costo * (1 + (iva / 100)))
        conUtilidad = conIva * (1 + (utilidad / 100))
        precioVenta = conUtilidad
        If descuento <> "" And descuento <> "0" Then
            precioVenta = precioVenta - ((precioVenta * descuento / 100))
        End If
        Return precioVenta

    End Function
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
        While i < 7
            cadena = cadena.ToString & "0"
            i = i + 1
        End While
        numeroFacturaConvertido = "0001 - " & cadena & nroNV
        Return numeroFacturaConvertido

    End Function

    Private Sub buscarVentas()
        Dim objVentas As New Ventas
        Dim objCliente As New Clientes
        Dim objCondicionVenta As New CondicionVenta
        Dim odataset As New DataSet
        Dim objAfip As New AFIP
        Dim oDataSetAfip As New DataSet
        Dim oDataSetCae As DataSet

        odataset = objVentas.buscarVentasXclienteCtaCte(Me.txtCodCliente.Text.ToString)

        Me.totalSaldoVenta = 0
        Dim totalSaldoXComprobante As Double
        totalSaldoXComprobante = 0
        Dim i As Integer = 0
        Dim totalSinDescuentoPorFC As Double
        totalParcialVentas = 0
        'Dim día_corte = (New DateTime(Year(dtpFechaDesde.Value), Month(dtpFechaDesde.Value), dtpFechaDesde.Value.Day).AddMonths(0).AddDays(-(dtpFechaDesde.Value.Day)).Date)
        Dim día_corte = (New DateTime(Year(dtpFechaDesde.Value), Month(dtpFechaDesde.Value), dtpFechaDesde.Value.Day))
        Dim ultimo_dia = (New DateTime(Year(Now), Month(Now), Now.Day).AddMonths(0).AddDays(-(Now.Day)).Date)
        If odataset.Tables(0).Rows.Count > 0 Then
            lstCtaCte.Rows.Add()

            While odataset.Tables(0).Rows.Count > i
                'busca al corte del ultimo día del mes
                If chkHistorico.Checked = False And opFecha.Checked = False And FormatDateTime(odataset.Tables(0).Rows(i).Item("fecha_venta").ToString, DateFormat.ShortDate) <= ultimo_dia Then


                    If odataset.Tables(0).Rows(i).Item("idComprobante") = 3 Or odataset.Tables(0).Rows(i).Item("idComprobante") = 8 Then
                        totalParcialVentas = FormatNumber(totalParcialVentas - FormatNumber(odataset.Tables(0).Rows(i).Item("monto"), 2), 2)
                        totalSaldoXComprobante = FormatNumber(odataset.Tables(0).Rows(i).Item("monto"), 2)
                        totalSaldoVenta = FormatNumber(totalSaldoVenta - totalSaldoXComprobante, 2)
                    Else
                        totalParcialVentas = FormatNumber(totalParcialVentas + FormatNumber(odataset.Tables(0).Rows(i).Item("monto"), 2), 2)
                        totalSaldoXComprobante = FormatNumber(odataset.Tables(0).Rows(i).Item("monto"), 2)
                        totalSaldoVenta = FormatNumber(totalSaldoVenta + totalSaldoXComprobante, 2)

                    End If

                    'busco fecha desde
                ElseIf chkHistorico.Checked = False And opFecha.Checked = True And FormatDateTime(odataset.Tables(0).Rows(i).Item("fecha_venta").ToString, DateFormat.ShortDate) <= día_corte Then


                    If odataset.Tables(0).Rows(i).Item("idComprobante") = 3 Or odataset.Tables(0).Rows(i).Item("idComprobante") = 8 Then
                        totalParcialVentas = FormatNumber(totalParcialVentas - FormatNumber(odataset.Tables(0).Rows(i).Item("monto"), 2), 2)
                        totalSaldoXComprobante = FormatNumber(odataset.Tables(0).Rows(i).Item("monto"), 2)
                        totalSaldoVenta = FormatNumber(totalSaldoVenta - totalSaldoXComprobante, 2)
                    Else
                        totalParcialVentas = FormatNumber(totalParcialVentas + FormatNumber(odataset.Tables(0).Rows(i).Item("monto"), 2), 2)
                        totalSaldoXComprobante = FormatNumber(odataset.Tables(0).Rows(i).Item("monto"), 2)
                        totalSaldoVenta = FormatNumber(totalSaldoVenta + totalSaldoXComprobante, 2)

                    End If

                    ' busca el historico o el resto
                Else

                    lstCtaCte.Rows.Add()

                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(2).Value = Format(odataset.Tables(0).Rows(i).Item("fecha_venta"), "dd/MM/yyyy")
                    oDataSetCae = objAfip.buscarCaeXfactura(odataset.Tables(0).Rows(i).Item("idVenta"))
                    If oDataSetCae.Tables(0).Rows.Count > 0 Then
                        lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(3).Value = odataset.Tables(0).Rows(i).Item("Descripcion").ToString & " - " & Me.generarNumeroFactura(oDataSetCae.Tables(0).Rows(0).Item("idVentaAfip").ToString, "0003")
                    Else
                        lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(3).Value = odataset.Tables(0).Rows(i).Item("Descripcion").ToString & " - " & Me.generarNumeroFactura(odataset.Tables(0).Rows(i).Item("idVenta").ToString)

                    End If

                    If odataset.Tables(0).Rows(i).Item("idComprobante") = 3 Or odataset.Tables(0).Rows(i).Item("idComprobante") = 8 Then
                        lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(5).Value = FormatNumber(odataset.Tables(0).Rows(i).Item("monto").ToString, 2)
                        totalSaldoXComprobante = FormatNumber(odataset.Tables(0).Rows(i).Item("monto"), 2)
                        totalSaldoVenta = FormatNumber(totalSaldoVenta - totalSaldoXComprobante, 2)
                    Else
                        lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(4).Value = FormatNumber(odataset.Tables(0).Rows(i).Item("monto").ToString, 2)
                        lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(6).Value = odataset.Tables(0).Rows(i).Item("idVenta").ToString
                        totalSaldoXComprobante = FormatCurrency(odataset.Tables(0).Rows(i).Item("monto"), 2)
                        totalSaldoVenta = FormatNumber(totalSaldoVenta + totalSaldoXComprobante, 2)

                    End If

                End If

                i = i + 1
            End While

        End If

        numerofilas = i
    End Sub

    Public Sub calcularSaldos()
        Dim saldo As Double
        Dim ultimo_dia
        saldo = (totalSaldoPagos - (totalSaldoVenta))
        txtTotal.Text = "$ " & FormatNumber(saldo, 2)
        If opFecha.Checked = True Then
            ultimo_dia = FormatDateTime(dtpFechaDesde.Value, DateFormat.ShortDate)
        Else
            ultimo_dia = (New DateTime(Year(Now), Month(Now), Now.Day).AddMonths(0).AddDays(-(Now.Day)).Date)
        End If
        Try
            If chkHistorico.Checked = False Or opFecha.Checked = True Then
                If totalParcialVentas > totalParcialPagos Then
                    lstCtaCte.Rows(0).Cells(2).Value = ultimo_dia
                    lstCtaCte.Rows(0).Cells(3).Value = "Saldo correspondiente al: " & ultimo_dia
                    lstCtaCte.Rows(0).Cells(4).Value = CStr(FormatCurrency((totalParcialVentas - totalParcialPagos), 2))
                    lstCtaCte.Rows(0).Cells(6).Value = 0
                Else
                    lstCtaCte.Rows(0).Cells(2).Value = ultimo_dia
                    lstCtaCte.Rows(0).Cells(3).Value = "Saldo correspondiente al: " & ultimo_dia
                    lstCtaCte.Rows(0).Cells(5).Value = CStr(FormatCurrency((totalParcialPagos - totalParcialVentas), 2))
                    lstCtaCte.Rows(0).Cells(6).Value = 0
                End If
            Else

                lstCtaCte.Rows.Remove(lstCtaCte.Rows(0))
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lstCtaCte_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles lstCtaCte.CellContentClick
        Try
            Dim Valor As String

            If lstCtaCte.CurrentRow.Cells(4).Value <> Nothing Then
                If lstCtaCte.CurrentRow.Cells(6).Value <> "0" Then
                    If lstCtaCte.CurrentCell.ColumnIndex = 0 Then
                        Valor = Me.lstCtaCte.Item(6, e.RowIndex).Value
                        Dim frmVentas As New frmVentas(Valor)
                        frmVentas.ShowDialog()
                    ElseIf lstCtaCte.CurrentCell.ColumnIndex = 1 Then
                        If lstCtaCte.CurrentRow.Cells(1).Value = True Then
                            lstCtaCte.CurrentRow.Cells(1).Value = False

                        Else
                            lstCtaCte.CurrentRow.Cells(1).Value = True

                        End If
                    End If
                Else
                    Valor = Me.lstCtaCte.Item(7, e.RowIndex).Value
                    Dim frmOT As New frmOrdenTrabajo(Valor)
                    frmOT.ShowDialog()
                End If
            ElseIf lstCtaCte.CurrentRow.Cells(5).Value.ToString <> "" Then
                Dim frmPagos As New frmPagos(lstCtaCte.CurrentRow.Cells(6).Value.ToString, 1)
                frmPagos.ShowDialog()
                lstCtaCte.Rows.Clear()
                Me.buscarVentas()
                buscarOT()
                Me.buscarPagos()
                Me.calcularSaldos()
                lstCtaCte.Sort(fecha, System.ComponentModel.ListSortDirection.Ascending)
                Dim objTempCtaCte As New TempCtaCte
                objTempCtaCte.borrarTempCtaCte()
                Me.generarTablaTemp()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        lstCtaCte.Rows.Clear()
        Me.txtRazonSocialCliente.Text = ""
        Me.txtCodCliente.Text = ""
        Me.txtTotal.Text = ""
        Me.btnPago.Enabled = False
    End Sub

    Private Sub btnPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPago.Click
        Dim montoAbonar As Double
        Dim objVentas As New Ventas
        Dim textoRecibo As String = ""
        montoAbonar = 0

        Dim frmRegistroPago As New frmPagos(Me.txtCodCliente.Text, ((totalSaldoVenta + totalSaldoOT) - totalSaldoPagos), 1)
        frmRegistroPago.ShowDialog()

        lstCtaCte.Rows.Clear()
        Me.buscarVentas()
        Me.buscarOT()
        Me.buscarPagos()

        Me.calcularSaldos()

        Dim objTempCtaCte As New TempCtaCte
        objTempCtaCte.borrarTempCtaCte()
        Me.generarTablaTemp()
    End Sub

    Private Sub buscarPagos()
        Dim objPagos As New Pagos
        Dim objCliente As New Clientes

        Dim odataset As New DataSet

        odataset = objPagos.buscarPagosXcliente(Me.txtCodCliente.Text)

        Me.totalSaldoPagos = 0
        totalParcialPagos = 0
        Dim ultimo_dia = (New DateTime(Year(Now), Month(Now), Now.Day).AddMonths(0).AddDays(-(Now.Day)).Date)
        Dim día_corte = (New DateTime(Year(dtpFechaDesde.Value), Month(dtpFechaDesde.Value), dtpFechaDesde.Value.Day))

        If odataset.Tables(0).Rows.Count > 0 Then

            Dim i As Integer = 0
            While odataset.Tables(0).Rows.Count > i
                If chkHistorico.Checked = False And opFecha.Checked = False And FormatDateTime(odataset.Tables(0).Rows(i).Item("fecha_pago").ToString, DateFormat.ShortDate) <= ultimo_dia Then
                    totalParcialPagos = totalParcialPagos + FormatNumber(odataset.Tables(0).Rows(i).Item("importe"), 2)
                    totalSaldoPagos = totalSaldoPagos + FormatNumber((odataset.Tables(0).Rows(i).Item("importe").ToString), 2)
                ElseIf chkHistorico.Checked = False And opFecha.Checked = True And FormatDateTime(odataset.Tables(0).Rows(i).Item("fecha_pago").ToString, DateFormat.ShortDate) <= día_corte Then
                    totalParcialPagos = totalParcialPagos + FormatNumber(odataset.Tables(0).Rows(i).Item("importe"), 2)
                    totalSaldoPagos = totalSaldoPagos + FormatNumber((odataset.Tables(0).Rows(i).Item("importe").ToString), 2)

                Else
                    lstCtaCte.Rows.Add()
                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(2).Value = odataset.Tables(0).Rows(i).Item("fecha_pago")
                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(3).Value = "RN: " & Me.generarNumeroRecibo(odataset.Tables(0).Rows(i).Item("idPago").ToString)
                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(5).Value = FormatCurrency((odataset.Tables(0).Rows(i).Item("importe").ToString), 2)
                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(6).Value = odataset.Tables(0).Rows(i).Item("idPago").ToString
                    totalSaldoPagos = totalSaldoPagos + FormatNumber((odataset.Tables(0).Rows(i).Item("importe").ToString), 2)
                    numerofilas = numerofilas + 1

                    numerofilas = lstCtaCte.RowCount
                End If
                i = i + 1
            End While
        End If

    End Sub

    Private Function generarNumeroRecibo(ByVal idRecibo As Integer) As String
        Dim oDataSet As New DataSet
        Dim objPagos As New Pagos
        Dim i As Integer
        Dim cadena As String
        Dim nroNR As Integer
        Dim numeroReciboConvertido As String
        nroNR = idRecibo

        cadena = ""
        i = nroNR.ToString.Length
        While i < 7
            cadena = cadena.ToString & "0"
            i = i + 1
        End While
        numeroReciboConvertido = "0001 - " & cadena & nroNR
        Return numeroReciboConvertido

    End Function

    Private Function calcularDescuentos(ByRef odataset As DataSet, ByVal total As Double, ByVal i As Integer) As Double
        Dim montoDescuento As Double

        montoDescuento = total * (Replace(odataset.Tables(0).Rows(i).Item("descuento_venta"), ",", ".") / 100)
        total = total - montoDescuento

        Return total
    End Function
    Private Function calcularRecargos(ByRef odataset As DataSet, ByVal total As Double, ByVal i As Integer) As Double
        Dim montoDescuento As Double

        montoDescuento = total * (Replace(odataset.Tables(0).Rows(i).Item("recargo_venta"), ",", ".") / 100)
        total = total + montoDescuento

        Return total
    End Function

    Private Sub cotizacionDolar()
        '    Dim objVentas As New Ventas
        '    Dim odataset As New DataSet
        '    odataset = objVentas.ultimaCotización()
        '    Label3.Text = "Cotización Dolar al " & odataset.Tables(0).Rows(0).Item("fecha_actualizacion") & " $:" & odataset.Tables(0).Rows(0).Item("monto")
    End Sub

    Private Sub generarTablaTemp()
        Dim objTempCtaCte As New TempCtaCte
        Dim saldo As Double
        saldo = 0
        Dim i As Integer = 0
        While lstCtaCte.RowCount > i
            objTempCtaCte.idCliente = Me.txtCodCliente.Text.ToString
            objTempCtaCte.fechaComprobante = lstCtaCte.Rows(i).Cells(2).Value
            objTempCtaCte.detalleComprobante = lstCtaCte.Rows(i).Cells(3).Value
            objTempCtaCte.debe = lstCtaCte.Rows(i).Cells(4).Value
            objTempCtaCte.haber = lstCtaCte.Rows(i).Cells(5).Value
            objTempCtaCte.saldo = saldo - Math.Abs(objTempCtaCte.debe) + Math.Abs(objTempCtaCte.haber)
            objTempCtaCte.idVenta = CStr(lstCtaCte.Rows(i).Cells(6).Value)
            objTempCtaCte.nuevoRegistro(objTempCtaCte)
            saldo = objTempCtaCte.saldo
            i = i + 1
        End While

    End Sub

    Private Sub btnImprimirResumenCtaCte_Click(sender As Object, e As EventArgs) Handles btnImprimirResumenCtaCte.Click
        Dim frmResumenDeCuenta As New frmResumenCtaCteXCliente(False, 0)
        frmResumenDeCuenta.Show()
    End Sub

    Private Sub chkHistorico_CheckedChanged(sender As Object, e As EventArgs) 
        Try
            If txtCodCliente.Text = "" Then
                Exit Sub
            End If
            opFecha.Checked = False
            lstCtaCte.Rows.Clear()
            Dim objTempCtaCte As New TempCtaCte
            objTempCtaCte.borrarTempCtaCte()
            Me.buscarVentas()
            Me.buscarPagos()

            Me.calcularSaldos()

            Me.generarTablaTemp()
            Me.cargarTempAgrilla()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub buscarOT()
        Dim objOT As New OrdenTrabajo
        Dim objCliente As New Clientes
        Dim objCondicionVenta As New CondicionVenta
        Dim odataset As New DataSet
        Dim objAfip As New AFIP
        Dim oDataSetAfip As New DataSet

        odataset = objOT.buscarOTXclienteCtaCte(Me.txtCodCliente.Text.ToString)

        Me.totalSaldoOT = 0
        Dim totalSaldoXComprobante As Double
        totalSaldoXComprobante = 0
        Dim i As Integer = 0
        Dim totalSinDescuentoPorFC As Double
        totalParcialOT = 0


        Dim ultimo_dia = (New DateTime(Year(Now), Month(Now), Now.Day).AddMonths(0).AddDays(-(Now.Day)).Date)
        If odataset.Tables(0).Rows.Count > 0 Then
            If lstCtaCte.Rows.Count > 1 Then
            Else
                lstCtaCte.Rows.Add()
            End If

            While odataset.Tables(0).Rows.Count > i
                If chkHistorico.Checked = False And FormatDateTime(odataset.Tables(0).Rows(i).Item("fechaRecepcion").ToString, DateFormat.ShortDate) < ultimo_dia Then

                    totalParcialOT = totalParcialOT + FormatNumber(odataset.Tables(0).Rows(i).Item("importe"), 2)
                    totalSaldoXComprobante = FormatNumber(odataset.Tables(0).Rows(i).Item("importe"), 2)
                    totalSaldoOT = FormatNumber(totalSaldoOT + totalSaldoXComprobante, 2)
                Else

                    lstCtaCte.Rows.Add()

                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(2).Value = FormatDateTime(odataset.Tables(0).Rows(i).Item("fechaRecepcion").ToString, DateFormat.ShortDate)
                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(3).Value = "Orden Trabajo N°: - " & Me.generarNumeroFactura(odataset.Tables(0).Rows(i).Item("idOT").ToString)
                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(4).Value = odataset.Tables(0).Rows(i).Item("importe").ToString
                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(6).Value = "0"
                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(7).Value = odataset.Tables(0).Rows(i).Item("idOT").ToString

                    totalSaldoXComprobante = FormatNumber(odataset.Tables(0).Rows(i).Item("importe"), 2)
                    totalSaldoOT = FormatNumber(totalSaldoOT + totalSaldoXComprobante, 2)
                End If

                i = i + 1
            End While

        End If

        numerofilas = i
    End Sub

    Private Sub btnMandarMail_Click(sender As Object, e As EventArgs) Handles btnMandarMail.Click

        Dim frmReporte As New frmResumenCtaCteXCliente(True, idCliente)
        frmReporte.ShowDialog()

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

    Private Sub cargarTempAgrilla()
        Dim objTempCtaCte As New TempCtaCte
        Dim oDataSet As New DataSet
        Dim i As Integer = 0
        Dim saldo As Double = 0
        oDataSet = objTempCtaCte.buscarTemp

        lstCtaCte.Rows.Clear()

        If oDataSet.Tables(0).Rows.Count = 0 Then
            MsgBox("No se encuentran movimientos en la cuenta del cliente seleccionado", MsgBoxStyle.Information, "IMPULSO REPUESTOS")
            Exit Sub
        End If

        While oDataSet.Tables(0).Rows.Count > i

            lstCtaCte.Rows.Add()

            lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(2).Value = oDataSet.Tables(0).Rows(i).Item(2)
            lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(3).Value = oDataSet.Tables(0).Rows(i).Item(3).ToString
            lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(4).Value = oDataSet.Tables(0).Rows(i).Item(4)
            lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(5).Value = oDataSet.Tables(0).Rows(i).Item(5)
            lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(6).Value = oDataSet.Tables(0).Rows(i).Item(7).ToString

            lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(8).Value = saldo - oDataSet.Tables(0).Rows(i).Item(4) + oDataSet.Tables(0).Rows(i).Item(5)
            saldo = lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(8).Value

            i = i + 1
        End While

        If chkHistorico.Checked = False Then
            lstCtaCte.Rows(0).Cells(2).Value = ""
        End If

    End Sub

    Private Sub chkHistorico_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkHistorico.CheckedChanged
        Try
            If txtCodCliente.Text = "" Then
                Exit Sub
            End If
            opFecha.Checked = False
            lstCtaCte.Rows.Clear()
            Dim objTempCtaCte As New TempCtaCte
            objTempCtaCte.borrarTempCtaCte()
            Me.buscarVentas()
            Me.buscarPagos()

            Me.calcularSaldos()

            Me.generarTablaTemp()
            Me.cargarTempAgrilla()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub opFecha_CheckedChanged(sender As Object, e As EventArgs) Handles opFecha.CheckedChanged
        If opFecha.Checked = True Then
            dtpFechaDesde.Enabled = True
            btnAplicar.Enabled = True
            chkHistorico.Checked = False
        Else
            dtpFechaDesde.Enabled = False
            btnAplicar.Enabled = False
            chkHistorico.Checked = False
        End If
        lstCtaCte.Rows.Clear()
        Dim objTempCtaCte As New TempCtaCte
        objTempCtaCte.borrarTempCtaCte()
        Me.buscarVentas()
        Me.buscarPagos()

        Me.calcularSaldos()

        Me.generarTablaTemp()
        Me.cargarTempAgrilla()
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Try
            If txtCodCliente.Text = "" Then
                Exit Sub
            End If

            lstCtaCte.Rows.Clear()
            Dim objTempCtaCte As New TempCtaCte
            objTempCtaCte.borrarTempCtaCte()
            Me.buscarVentas()
            Me.buscarPagos()

            Me.calcularSaldos()

            Me.generarTablaTemp()
            Me.cargarTempAgrilla()
        Catch ex As Exception

        End Try
    End Sub
End Class