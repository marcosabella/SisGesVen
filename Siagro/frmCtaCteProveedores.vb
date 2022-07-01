Imports System.IO
Imports System.Net
Imports System.Xml
Imports Siagro.convertirDolar


Public Class frmCtaCteProveedores
    Dim totalSaldoCompra As Double
    Dim totalSaldoPagos As Double
    Dim totalSaldo As Double
    Dim totalParcialCompra As Double
    Dim totalParcialPagos As Double
    Public numerofilas As Integer
    Dim indiceArray As Integer
    'Private client As Object
    Private Sub frmCtaCteProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnBuscarCliente.Focus()
        Me.btnPago.Enabled = False
        Me.btnCompras.Enabled = False
        Me.btnImprimirResumenCtaCte.Enabled = False
    End Sub


    Private Sub buscarCompras()
        Dim objProveedor As New Proveedores
        Dim objCliente As New Clientes
        Dim objCondicionVenta As New CondicionVenta
        Dim odataset As New DataSet
        Dim objAfip As New AFIP
        Dim oDataSetAfip As New DataSet

        odataset = objProveedor.buscarComprasPorProveedor(Me.txtCodCliente.Text.ToString)

        If odataset Is Nothing Then
            lstCtaCte.Rows.Add()
            Exit Sub
        End If

        Me.totalSaldoCompra = 0
        Dim totalSaldoXComprobante As Double
        totalSaldoXComprobante = 0
        Dim i As Integer = 0
        totalParcialCompra = 0



        Dim ultimo_dia = (New DateTime(Year(Now), Month(Now), Now.Day).AddMonths(0).AddDays(-(Now.Day)).Date)
        If odataset.Tables(0).Rows.Count > 0 Then
            lstCtaCte.Rows.Add()

            While odataset.Tables(0).Rows.Count > i
                If chkHistorico.Checked = False And FormatDateTime(odataset.Tables(0).Rows(i).Item("fecha").ToString, DateFormat.ShortDate) < ultimo_dia Then


                    'MsgBox(ultimo_dia)
                    totalParcialCompra = totalParcialCompra + FormatNumber(odataset.Tables(0).Rows(i).Item("monto"), 2)
                    totalSaldoXComprobante = FormatCurrency(odataset.Tables(0).Rows(i).Item("monto"), 2)
                    totalSaldoCompra = FormatNumber(totalSaldoCompra + totalSaldoXComprobante, 2)
                Else

                    lstCtaCte.Rows.Add()

                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(2).Value = FormatDateTime(odataset.Tables(0).Rows(i).Item("fecha").ToString, DateFormat.ShortDate)
                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(3).Value = "FN°: " & (odataset.Tables(0).Rows(i).Item("numeroComprobante").ToString)
                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(4).Value = FormatCurrency(odataset.Tables(0).Rows(i).Item("monto").ToString, 2)
                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(6).Value = odataset.Tables(0).Rows(i).Item("idCompraProveedores").ToString
                    totalSaldoXComprobante = FormatNumber(odataset.Tables(0).Rows(i).Item("monto"), 2)
                    totalSaldoCompra = FormatNumber(totalSaldoCompra + totalSaldoXComprobante, 2)
                End If

                i = i + 1
            End While

        End If

        numerofilas = i
    End Sub

    Public Sub calcularSaldos()
        Dim saldo As Double
        saldo = FormatNumber(totalSaldoPagos, 2) - FormatNumber(totalSaldoCompra, 2)
        'txtTotal.Text = "$ " & Replace(FormatNumber(saldo, 2), ".", "")
        txtTotal.Text = FormatCurrency(saldo, 2)
        If saldo <> 0 Then
            Me.btnPago.Enabled = True
        End If
        Try
            If chkHistorico.Checked = False Then
                Dim ultimo_dia = (New DateTime(Year(Now), Month(Now), Now.Day).AddMonths(0).AddDays(-(Now.Day)).Date)
                If totalParcialCompra > totalParcialPagos Then
                    lstCtaCte.Rows(0).Cells(2).Value = Nothing
                    lstCtaCte.Rows(0).Cells(3).Value = "Saldo correspondiente al: " & ultimo_dia
                    lstCtaCte.Rows(0).Cells(4).Value = CStr(FormatCurrency(totalParcialCompra - totalParcialPagos, 2))
                    lstCtaCte.Rows(0).Cells(6).Value = ""
                Else
                    lstCtaCte.Rows(0).Cells(2).Value = Nothing
                    lstCtaCte.Rows(0).Cells(3).Value = "Saldo correspondiente al: " & ultimo_dia
                    lstCtaCte.Rows(0).Cells(5).Value = CStr(FormatCurrency(totalParcialCompra - totalParcialPagos, 2))
                    lstCtaCte.Rows(0).Cells(6).Value = ""
                End If
            Else

                lstCtaCte.Rows.Remove(lstCtaCte.Rows(0))
            End If
        Catch ex As Exception

        End Try

        'txtTotal.Text = "$ " & FormatNumber(totalSaldoVenta, 2)
    End Sub

    Private Sub lstCtaCte_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles lstCtaCte.CellContentClick
        Try
            Dim Valor As String

            If lstCtaCte.CurrentRow.Cells(4).Value <> Nothing Then

                If lstCtaCte.CurrentCell.ColumnIndex = 0 Then
                    Valor = Me.lstCtaCte.Item(6, e.RowIndex).Value
                    'MsgBox(Valor)
                    Dim frmCompraProveedores As New frmCompraProveedor(Me.txtCodCliente.Text, Valor)
                    frmCompraProveedores.ShowDialog()
                ElseIf lstCtaCte.CurrentCell.ColumnIndex = 1 Then
                    If lstCtaCte.CurrentRow.Cells(1).Value = True Then
                        lstCtaCte.CurrentRow.Cells(1).Value = False

                    Else
                        lstCtaCte.CurrentRow.Cells(1).Value = True

                    End If
                End If
            ElseIf lstCtaCte.CurrentRow.Cells(5).Value.ToString <> "" Then
                'Dim frmRecibo As New frmRecibo(lstCtaCte.CurrentRow.Cells(6).Value.ToString)
                'frmRecibo.ShowDialog()
                Dim frmPagos As New frmPagos(lstCtaCte.CurrentRow.Cells(6).Value.ToString, 2)
                frmPagos.ShowDialog()
                'lstCtaCte.Rows.Clear()
                'Me.buscarCompras()
                'Me.buscarPagos()
                'Me.calcularSaldos()
                'lstCtaCte.Sort(fecha, System.ComponentModel.ListSortDirection.Ascending)
                'Dim objTempCtaCte As New TempCtaCte
                'objTempCtaCte.borrarTempCtaCte()
                'Me.generarTablaTemp()
            End If
            lstCtaCte.Rows.Clear()
            Me.buscarCompras()
            Me.buscarPagos()
            Me.calcularSaldos()
            lstCtaCte.Sort(fecha, System.ComponentModel.ListSortDirection.Ascending)
            Dim objTempCtaCte As New TempCtaCte
            objTempCtaCte.borrarTempCtaCte()
            Me.generarTablaTemp()
        Catch ex As Exception
            'MsgBox(ex.ToString)
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
        Me.btnCompras.Enabled = False
    End Sub

    Private Sub btnPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPago.Click
        Dim montoAbonar As Double
        Dim objVentas As New Ventas
        Dim textoRecibo As String = ""
        montoAbonar = 0
        With lstCtaCte
            For i = 0 To (.RowCount - 1)
                'If lstCtaCte.Rows(i).Cells(1).Value = True Then
                'montoAbonar = montoAbonar + lstCtaCte.Rows(i).Cells(4).Value
                'End If

            Next
        End With

        'If montoAbonar = 0 Then
        'MsgBox("El monto a abonor no puede ser 0 (Cero)", MsgBoxStyle.Exclamation, "SISTEMA DE GESTIÓN DE VENTA Y STOCK")
        'Exit Sub
        'End If

        Dim frmRegistroPago As New frmPagos(Me.txtCodCliente.Text, (totalSaldoCompra - totalSaldoPagos), 2)
        frmRegistroPago.ShowDialog()

        lstCtaCte.Rows.Clear()
        Me.buscarCompras()
        Me.buscarPagos()
        Me.calcularSaldos()
        lstCtaCte.Sort(fecha, System.ComponentModel.ListSortDirection.Ascending)
        Dim objTempCtaCte As New TempCtaCte
        objTempCtaCte.borrarTempCtaCte()
        Me.generarTablaTemp()
    End Sub

    Private Sub buscarPagos()
        Dim objProveedor As New Proveedores

        Dim odataset As New DataSet

        odataset = objProveedor.buscarPagosXProveedor(Me.txtCodCliente.Text)

        If odataset Is Nothing Then
            Exit Sub
        End If

        Me.totalSaldoPagos = 0
        totalParcialPagos = 0
        Dim ultimo_dia = (New DateTime(Year(Now), Month(Now), Now.Day).AddMonths(0).AddDays(-(Now.Day)).Date)

        If odataset.Tables(0).Rows.Count > 0 Then

            Dim i As Integer = 0
            While odataset.Tables(0).Rows.Count > i
                If chkHistorico.Checked = False And FormatDateTime(odataset.Tables(0).Rows(i).Item("fecha_pago").ToString, DateFormat.ShortDate) < ultimo_dia Then
                    totalParcialPagos = totalParcialPagos + FormatNumber(odataset.Tables(0).Rows(i).Item("importe"), 2)
                    totalSaldoPagos = totalSaldoPagos + FormatNumber((odataset.Tables(0).Rows(i).Item("importe").ToString), 2)

                Else
                    lstCtaCte.Rows.Add()
                    lstCtaCte.Rows(lstCtaCte.RowCount - 1).Cells(2).Value = odataset.Tables(0).Rows(i).Item("fecha_pago").ToString
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
            objTempCtaCte.saldo = saldo + objTempCtaCte.haber - objTempCtaCte.debe
            objTempCtaCte.nuevoRegistro(objTempCtaCte)
            saldo = objTempCtaCte.saldo
            i = i + 1
        End While
    End Sub

    Private Sub btnImprimirResumenCtaCte_Click(sender As Object, e As EventArgs) Handles btnImprimirResumenCtaCte.Click
        Dim frmResumenDeCuenta As New frmResumenCtaCteXCliente(False, 0)
        frmResumenDeCuenta.Show()
    End Sub

    Private Sub chkHistorico_CheckedChanged(sender As Object, e As EventArgs) Handles chkHistorico.CheckedChanged
        Try
            If txtCodCliente.Text = "" Then
                Exit Sub
            End If
            lstCtaCte.Rows.Clear()
            Dim objTempCtaCte As New TempCtaCte
            objTempCtaCte.borrarTempCtaCte()
            Me.buscarCompras()
            Me.buscarPagos()
            'Me.cotizacionDolar()
            Me.calcularSaldos()
            'lstCtaCte.Sort(fecha, System.ComponentModel.ListSortDirection.Descending)
            Me.generarTablaTemp()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click

        Dim objProveedores As New Proveedores
        Dim odataset As New DataSet

        Dim min As Integer = 0
        Dim objTempCtaCte As New TempCtaCte
        Dim frmBuscarProveedores As New frmBuscarProveedor
        frmBuscarProveedores.ShowDialog()
        If frmBuscarProveedores.idProveedorBusqueda <> 0 Then

            Dim idProveedor As Integer
            objTempCtaCte.borrarTempCtaCte()
            idProveedor = frmBuscarProveedores.idProveedorBusqueda
            odataset = objProveedores.buscarProveedoresXid(idProveedor)
            Me.txtCodCliente.Text = odataset.Tables(0).Rows(0).Item("idProveedor")
            txtRazonSocialCliente.Text = odataset.Tables(0).Rows(0).Item("razon_social")

            lstCtaCte.Rows.Clear()

            Me.buscarCompras()
            Me.buscarPagos()

            Me.calcularSaldos()
            lstCtaCte.Sort(fecha, System.ComponentModel.ListSortDirection.Ascending)
            Me.generarTablaTemp()
            Me.btnCompras.Enabled = True
        End If
        If lstCtaCte.RowCount > 0 Or (lstCtaCte.RowCount > 1 And chkHistorico.Checked = True) Then
            Me.btnPago.Enabled = True

            Me.btnImprimirResumenCtaCte.Enabled = True
        Else
            Me.btnPago.Enabled = False

            Me.btnImprimirResumenCtaCte.Enabled = False
        End If
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        Dim frmCompraProveedores As New frmCompraProveedor(Me.txtCodCliente.Text)
        frmCompraProveedores.ShowDialog()
        lstCtaCte.Rows.Clear()
        Me.buscarCompras()
        Me.buscarPagos()
        Me.calcularSaldos()
        lstCtaCte.Sort(fecha, System.ComponentModel.ListSortDirection.Ascending)
        Dim objTempCtaCte As New TempCtaCte
        objTempCtaCte.borrarTempCtaCte()
        Me.generarTablaTemp()
    End Sub
End Class