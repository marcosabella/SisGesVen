Public Class frmCaja
    Private Sub FrmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaCierre.Value = Now
        bgCajaDiaria.Text = "Detalle de caja diaria"
        'obtenerVentasContado()
        'obtenerVentasTarjeta()
        'obtenerVentasCheque()

        llenarComboCondicionVenta()
        opCondVenta.Checked = False
        cboCondVenta.Enabled = False
        btnResumenCajaDiaria.Enabled = False
        buscarVentas()
        buscarPagos()
    End Sub

    Private Sub obtenerVentasContado()
        Dim objCaja As New Caja
        Dim ds As New DataSet
        Dim montoVenta As Double = 0
        Dim montoPagos As Double = 0
        Dim montoDepositos As Double = 0

        ds = objCaja.buscarTodasLasContado(1)
        If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
            montoVenta = ds.Tables(0).Rows(0).Item(0)
        End If

        ds = objCaja.buscarTodosPagosContado
        If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
            montoPagos = ds.Tables(0).Rows(0).Item(0)
        End If

        ds = objCaja.devolverMontoDepositoPorValor(0)
        If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
            montoDepositos = ds.Tables(0).Rows(0).Item(0)
        End If

        lblEfectivo.Text = ""
        lblEfectivo.Text = FormatCurrency(montoVenta + montoPagos - montoDepositos)

    End Sub

    Private Sub obtenerVentasTarjeta()
        Dim objCaja As New Caja
        Dim ds As New DataSet
        Dim montoVenta As Double = 0

        ds = objCaja.buscarTodasLasContado(3, "Tarjeta")

        If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
            montoVenta = ds.Tables(0).Rows(0).Item(0)

        End If
        lblTarjeta.Text = ""
        lblTarjeta.Text = FormatCurrency(montoVenta)
    End Sub

    Private Sub obtenerVentasCheque()
        Dim objCaja As New Caja
        Dim ds As New DataSet
        Dim montoVenta As Double = 0

        ds = objCaja.buscarTodasLasContado(4, "si")
        If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
            montoVenta = ds.Tables(0).Rows(0).Item(0)



        End If

        lblCheque.Text = ""
        lblCheque.Text = FormatCurrency(montoVenta)
    End Sub

    Private Sub llenarComboCondicionVenta()
        Dim objCondicionVenta As New CondicionVenta
        Dim oDataSet As New DataSet
        Dim fila As Data.DataRow
        oDataSet = objCondicionVenta.buscarCondicionVenta
        fila = oDataSet.Tables(0).NewRow

        fila(0) = oDataSet.Tables(0).Rows.Count
        fila(1) = "Cobros"

        oDataSet.Tables(0).Rows.Add(fila)

        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboCondVenta.DataSource = oDataSet.Tables(0)
            Me.cboCondVenta.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboCondVenta.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboCondVenta.SelectedIndex = -1
        End If

    End Sub

    Private Sub OpCondVenta_CheckedChanged(sender As Object, e As EventArgs) Handles opCondVenta.CheckedChanged
        cboCondVenta.SelectedIndex = -1
        If opCondVenta.Checked = False Then
            cboCondVenta.Enabled = False
            btnResumenCajaDiaria.Enabled = False
        Else
            cboCondVenta.Enabled = True
            btnResumenCajaDiaria.Enabled = False

        End If
        buscarVentas()
        buscarPagos()
    End Sub

    Private Sub buscarVentas()
        Dim objCaja As New Caja
        Dim objCliente As New Clientes
        Dim objCondicionVenta As New CondicionVenta
        Dim odataset As New DataSet
        Dim odatasetCliente As New DataSet
        Dim objAfip As New AFIP
        Dim oDataSetAfip As New DataSet
        Dim odatasetClienteEncontrado As New DataSet
        Dim montoDiarioTarjeta As Double = 0
        Dim montoDiarioContado As Double = 0
        Dim montoDiarioCtaCte As Double = 0
        Dim montoDiarioTransferencia As Double = 0
        Dim montoDiarioCheque As Double = 0

        lstVentas.Rows.Clear()

        odataset = objCaja.buscarTodasLasVentas(FormatDateTime(dtpFechaCierre.Value, DateFormat.ShortDate))

        If odataset.Tables(0).Rows.Count > 0 Then

            Dim i As Integer = 0
            While odataset.Tables(0).Rows.Count > i
                lstVentas.Rows.Add()
                lstVentas.Rows(i).Cells(0).Value = Me.generarNumeroFactura(odataset.Tables(0).Rows(i).Item("idVenta").ToString)
                lstVentas.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item("descripcion").ToString
                lstVentas.Rows(i).Cells(2).Value = FormatDateTime(odataset.Tables(0).Rows(i).Item("fecha_venta").ToString, DateFormat.ShortDate)
                lstVentas.Rows(i).Cells(3).Value = odataset.Tables(0).Rows(i).Item("CondVenta").ToString
                lstVentas.Rows(i).Cells(4).Value = odataset.Tables(0).Rows(i).Item("nombreCliente").ToString
                lstVentas.Rows(i).Cells(5).Value = FormatCurrency(odataset.Tables(0).Rows(i).Item("monto").ToString, 2)

                If lstVentas.Rows(i).Cells(1).Value <> "NOTAS DE CREDITO C" Then
                    If lstVentas.Rows(i).Cells(3).Value = "Contado" Then
                        montoDiarioContado = FormatCurrency(montoDiarioContado + odataset.Tables(0).Rows(i).Item("monto").ToString, 2)
                    ElseIf lstVentas.Rows(i).Cells(3).Value = "Cta. Cte" Then
                        montoDiarioCtaCte = FormatCurrency(montoDiarioCtaCte + odataset.Tables(0).Rows(i).Item("monto").ToString, 2)
                    ElseIf lstVentas.Rows(i).Cells(3).Value = "Tarjeta" Then
                        montoDiarioTarjeta = FormatCurrency(montoDiarioTarjeta + odataset.Tables(0).Rows(i).Item("monto").ToString, 2)
                    ElseIf lstVentas.Rows(i).Cells(3).Value = "Cheque" Then
                        montoDiarioCheque = FormatCurrency(montoDiarioCheque + odataset.Tables(0).Rows(i).Item("monto").ToString, 2)
                    ElseIf lstVentas.Rows(i).Cells(3).Value = "Transferencia" Then
                        montoDiarioTransferencia = FormatCurrency(montoDiarioTransferencia + odataset.Tables(0).Rows(i).Item("monto").ToString, 2)

                    End If
                    lstVentas.Rows(i).Cells(6).Value = odataset.Tables(0).Rows(i).Item("idVenta").ToString
                End If
                i = i + 1
            End While

        End If
        lblDiarioCheque.Text = "Cheque" & vbNewLine & FormatCurrency(montoDiarioCheque)
        lblDiarioContado.Text = "Contado" & vbNewLine & FormatCurrency(montoDiarioContado)
        lblDiarioCtaCte.Text = "Cta. Cte." & vbNewLine & FormatCurrency(montoDiarioCtaCte)
        lblDiarioTarjeta.Text = "Tarjeta" & vbNewLine & FormatCurrency(montoDiarioTarjeta)
        lblDiarioTransfereicia.Text = "Transferenia" & vbNewLine & FormatCurrency(montoDiarioTransferencia)
    End Sub

    Private Sub buscarPagos()
        Dim objCaja As New Caja
        Dim objCliente As New Clientes
        Dim objCondicionVenta As New CondicionVenta
        Dim odataset As New DataSet
        Dim odatasetCliente As New DataSet
        Dim objAfip As New AFIP
        Dim oDataSetAfip As New DataSet
        Dim odatasetClienteEncontrado As New DataSet

        Dim montoPago As Double = 0

        odataset = objCaja.buscarTodasLosPagos(FormatDateTime(dtpFechaCierre.Value, DateFormat.ShortDate))

        If odataset.Tables(0).Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim fila As Integer = lstVentas.Rows.Count
            While odataset.Tables(0).Rows.Count > i
                lstVentas.Rows.Add()
                lstVentas.Rows(fila).Cells(0).Value = Me.generarNumeroFactura(odataset.Tables(0).Rows(i).Item("idPago").ToString)
                lstVentas.Rows(fila).Cells(1).Value = odataset.Tables(0).Rows(i).Item(1).ToString
                lstVentas.Rows(fila).Cells(2).Value = FormatDateTime(odataset.Tables(0).Rows(i).Item("fecha_pago").ToString, DateFormat.ShortDate)
                lstVentas.Rows(fila).Cells(3).Value = odataset.Tables(0).Rows(i).Item("CondVenta").ToString
                lstVentas.Rows(fila).Cells(4).Value = odataset.Tables(0).Rows(i).Item("nombreCliente").ToString
                lstVentas.Rows(fila).Cells(5).Value = FormatCurrency(odataset.Tables(0).Rows(i).Item("importe").ToString, 2)

                montoPago = FormatCurrency(montoPago + odataset.Tables(0).Rows(i).Item("importe").ToString, 2)

                lstVentas.Rows(fila).Cells(6).Value = odataset.Tables(0).Rows(i).Item("idPago").ToString
                fila = fila + 1
                i = i + 1
        End While

        End If

        lblDiarioPagos.Text = "Cobros" & vbNewLine & FormatCurrency(montoPago)

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
        While i < 7
            cadena = cadena.ToString & "0"
            i = i + 1
        End While
        numeroFacturaConvertido = "0001 - " & cadena & nroNV
        Return numeroFacturaConvertido

    End Function

    Private Sub BtnResumenCajaDiaria_Click(sender As Object, e As EventArgs) Handles btnResumenCajaDiaria.Click
        Dim frmResumenCajas As New frmResumenCajaDiariaCondVenta(Me.cboCondVenta.SelectedIndex, Me.cboCondVenta.Text, Me.dtpFechaCierre.Value)
        frmResumenCajas.ShowDialog()
    End Sub

    Private Sub CboCondVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCondVenta.SelectedIndexChanged
        If cboCondVenta.Text = "Tarjeta" OrElse cboCondVenta.Text = "Cheque" OrElse cboCondVenta.Text = "Transferencia" Then
            btnResumenCajaDiaria.Enabled = True

        Else
            btnResumenCajaDiaria.Enabled = False
        End If
        buscarVentasXcondicion()
    End Sub

    Private Sub buscarVentasXcondicion()
        Dim objCaja As New Caja
        Dim objCliente As New Clientes
        Dim objCondicionVenta As New CondicionVenta
        Dim odataset As New DataSet
        Dim odatasetCliente As New DataSet
        Dim objAfip As New AFIP
        Dim oDataSetAfip As New DataSet
        Dim odatasetClienteEncontrado As New DataSet
        Dim montoDiarioTarjeta As Double = 0
        Dim montoDiarioContado As Double = 0
        Dim montoDiarioCtaCte As Double = 0
        Dim montoDiarioTransferencia As Double = 0
        Dim montoDiarioCheque As Double = 0
        lstVentas.Rows.Clear()

        odataset = objCaja.buscarTodasLasVentasXcondicion(Me.cboCondVenta.SelectedIndex + 1, FormatDateTime(dtpFechaCierre.Value, DateFormat.ShortDate))
        If odataset Is Nothing Then
            Exit Sub
        End If
        If odataset.Tables(0).Rows.Count > 0 Then

            Dim i As Integer = 0
            While odataset.Tables(0).Rows.Count > i
                lstVentas.Rows.Add()
                lstVentas.Rows(i).Cells(0).Value = Me.generarNumeroFactura(odataset.Tables(0).Rows(i).Item(2).ToString)
                lstVentas.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item(1).ToString
                lstVentas.Rows(i).Cells(2).Value = FormatDateTime(odataset.Tables(0).Rows(i).Item(3).ToString, DateFormat.ShortDate)
                lstVentas.Rows(i).Cells(3).Value = odataset.Tables(0).Rows(i).Item(5).ToString
                lstVentas.Rows(i).Cells(4).Value = odataset.Tables(0).Rows(i).Item(0).ToString
                lstVentas.Rows(i).Cells(5).Value = FormatCurrency(odataset.Tables(0).Rows(i).Item(4).ToString, 2)
                lstVentas.Rows(i).Cells(6).Value = odataset.Tables(0).Rows(i).Item(2).ToString

                i = i + 1
            End While

        End If
    End Sub

    Private Sub LblDiarioTarjeta_Click(sender As Object, e As EventArgs) Handles lblDiarioTarjeta.Click
        Dim frmResumenCajas As New frmResumenCajaDiariaCondVenta(2, "Tarjeta", dtpFechaCierre.Value)
        frmResumenCajas.ShowDialog()
    End Sub

    Private Sub LblDiarioTransfereicia_Click(sender As Object, e As EventArgs) Handles lblDiarioTransfereicia.Click
        Dim frmResumenCajas As New frmResumenCajaDiariaCondVenta(4, "Transferencia", dtpFechaCierre.Value)
        frmResumenCajas.ShowDialog()
    End Sub

    Private Sub BtnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim frmDepositar As New frmDepositar
        frmDepositar.ShowDialog()
        obtenerVentasContado()
        obtenerVentasTarjeta()
        obtenerVentasCheque()
    End Sub

    Private Sub dtpFechaCierre_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaCierre.ValueChanged
        buscarVentas()
        buscarPagos()
    End Sub
End Class