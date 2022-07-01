Imports System.Data
Imports System.Data.OleDb
Public Class frmSaldoCtaCteClientes

    Dim odsVentasSuma As DataSet
    Dim odsVentasResta As DataSet
    Dim odsPagos As DataSet
    Dim objVentas As New Ventas
    Dim objPagos As New Pagos

    Private Sub frmSaldoCtaCteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenarGrilla()
        Me.lblSaldoTotal.Visible = False
    End Sub

    Private Sub llenarGrilla()
        dgvSaldos.Visible = False
        Dim objTemp As New TempCtaCte
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim saldo As Double = 0
        Dim saldoSuma As Double = 0
        Dim saldoResta As Double = 0
        Dim saldoPagos As Double = 0
        odsVentasSuma = New DataSet
        odsPagos = New DataSet

        objTemp.borrarSaldosTempCtaCte()

        odsVentasSuma = objVentas.buscarSaldosVentasXclienteCtaCteSuma


        If odsVentasSuma.Tables(0).Rows.Count = 0 Then
            Exit Sub
        End If
        Me.lblSaldoTotal.Visible = False
        progreso.Visible = True
        progreso.Maximum = odsVentasSuma.Tables(0).Rows.Count

        While odsVentasSuma.Tables(0).Rows.Count > i
            progreso.Value = i
            Application.DoEvents()
            saldo = 0
            saldoResta = 0
            saldoSuma = 0
            saldoPagos = 0
            odsVentasResta = objVentas.buscarSaldosVentasXclienteCtaCteResta(odsVentasSuma.Tables(0).Rows(i).Item("idCliente"))
            If odsVentasResta.Tables(0).Rows.Count <> 0 Then
                saldoResta = CDbl(odsVentasResta.Tables(0).Rows(0).Item(1))
            End If
            saldoSuma = CDbl(odsVentasSuma.Tables(0).Rows(i).Item(2).ToString)
            odsPagos = objPagos.buscarSumaPagosXcliente(odsVentasSuma.Tables(0).Rows(i).Item("idCliente"))
            If odsPagos.Tables(0).Rows.Count <> 0 Then
                If odsPagos.Tables(0).Rows(0).Item(0).ToString <> "" Then
                    saldoPagos = CDbl(odsPagos.Tables(0).Rows(0).Item(0))
                End If
            End If

            If FormatCurrency(((saldoResta + saldoPagos) - saldoSuma), 2) <> 0 Then
                dgvSaldos.Rows.Add()
                dgvSaldos.Rows(j).Cells(0).Value = odsVentasSuma.Tables(0).Rows(i).Item(0).ToString
                dgvSaldos.Rows(j).Cells(3).Value = Trim(odsVentasSuma.Tables(0).Rows(i).Item(1).ToString)
                dgvSaldos.Rows(j).Cells(4).Value = FormatCurrency(saldoResta + saldoPagos - saldoSuma, 2)

                objTemp.idCliente = dgvSaldos.Rows(j).Cells(0).Value
                objTemp.cliente = dgvSaldos.Rows(j).Cells(3).Value
                objTemp.saldo = dgvSaldos.Rows(j).Cells(4).Value
                objTemp.nuevoSaldosRegistro(objTemp)
                j = j + 1
            End If
            i = i + 1
            odsVentasResta = Nothing
            odsPagos = Nothing
        End While
        progreso.Visible = False
        dgvSaldos.Sort(dgvSaldos.Columns(3), System.ComponentModel.ListSortDirection.Ascending)

        dgvSaldos.Visible = True

        lblSaldoTotal.Text = "Saldo total pendiente de cobro: " & FormatCurrency(Math.Abs(objTemp.saldoTotalTemp.Tables(0).Rows(0).Item(0)), 2)

        Me.lblSaldoTotal.Visible = True

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        llenarGrilla()
    End Sub

    Private Sub dgvSaldos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSaldos.CellContentClick
        Try
            Dim Valor As String
            If dgvSaldos.CurrentCell.ColumnIndex = 2 Then
                Valor = dgvSaldos.CurrentRow.Cells(0).Value.ToString
                'MsgBox(Valor)
                Dim frmCtaCte As New frmCtaCte(Valor)
                frmCtaCte.ShowDialog()
            ElseIf dgvSaldos.CurrentCell.ColumnIndex = 1 Then
                If dgvSaldos.CurrentRow.Cells(1).Value = True Then
                    dgvSaldos.CurrentRow.Cells(1).Value = False
                Else
                    dgvSaldos.CurrentRow.Cells(1).Value = True
                End If

            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        Dim i As Integer = 0

        While i < Me.dgvSaldos.Rows.Count
            If chkTodos.Checked = True Then
                Me.dgvSaldos.Rows(i).Cells(1).Value = True
            Else
                Me.dgvSaldos.Rows(i).Cells(1).Value = False
            End If
            i = i + 1
        End While

    End Sub

    Private Sub btnImprimirResumenCtaCte_Click(sender As Object, e As EventArgs) Handles btnImprimirResumenCtaCte.Click
        Dim frmListado As New frmListadoCtaCte
        frmListado.ShowDialog()
    End Sub
End Class