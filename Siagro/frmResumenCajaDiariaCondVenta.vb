Public Class frmResumenCajaDiariaCondVenta
    Dim idCondVenta As Integer
    Dim descrpCondVenta As String
    Dim fechaParam As DateTime
    Public Sub New(ByVal idCondVenta As Integer, ByVal descrpCondVenta As String, ByVal fecha As DateTime)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.idCondVenta = idCondVenta
        Me.descrpCondVenta = descrpCondVenta
        fechaParam = fecha
        Me.Text = "Resúmen de Caja: " & Me.descrpCondVenta & " - " & fechaParam.ToString("MM/dd/yyyy")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().



    End Sub

    Private Sub FrmResumenCajaDiariaCondVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Me.idCondVenta = 2 Then
            reumenPorTarjeta()
        ElseIf Me.idCondVenta = 4 Then
            reumenPorTransferencia()
        End If

    End Sub

    Private Sub reumenPorTarjeta()
        Dim objCaja As New Caja
        Dim oDataSet As New DataSet
        Dim oDataSetTarjetaPorVeta As DataSet
        setGrillaParaTarjetas()

        oDataSet = objCaja.buscarResumenTarjetaVentaDiaria(fechaParam)

        If oDataSet.Tables(0).Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim fila As Integer = 0
            While oDataSet.Tables(0).Rows.Count > i

                dgvResumen.Rows.Add()
                dgvResumen.Rows(fila).Cells(0).Value = oDataSet.Tables(0).Rows(i).Item(1).ToString
                dgvResumen.Rows(fila).Cells(1).Value = ""
                dgvResumen.Rows(fila).Cells(2).Value = ""
                dgvResumen.Rows(fila).Cells(3).Value = FormatCurrency(oDataSet.Tables(0).Rows(i).Item(0).ToString)

                Dim style As New DataGridViewCellStyle
                style.Font = New Font(dgvResumen.Font, FontStyle.Bold)
                dgvResumen.Rows(fila).DefaultCellStyle = style

                dgvResumen.Rows(fila).DefaultCellStyle.BackColor = Color.LightGreen

                'detalle por tarjeta
                j = 0
                oDataSetTarjetaPorVeta = objCaja.buscarResumenTarjetaVentaDiariaXtarjeta(oDataSet.Tables(0).Rows(i).Item(2), fechaParam)
                While oDataSetTarjetaPorVeta.Tables(0).Rows.Count > j
                    dgvResumen.Rows.Add()
                    fila = fila + 1
                    dgvResumen.Rows(fila).Cells(0).Value = ""
                    dgvResumen.Rows(fila).Cells(1).Value = "Cupón: " & oDataSetTarjetaPorVeta.Tables(0).Rows(j).Item(1)
                    dgvResumen.Rows(fila).Cells(2).Value = FormatCurrency(oDataSetTarjetaPorVeta.Tables(0).Rows(j).Item(0))
                    dgvResumen.Rows(fila).Cells(3).Value = ""

                    j = j + 1

                End While


                i = i + 1
                fila = fila + 1
            End While
        Else
            MsgBox("No se encuentran movimientos registrados para la condición de venta " & Me.descrpCondVenta, MsgBoxStyle.Information, "ARCO ELECTRICIDAD")
            Me.Close()
        End If

        dgvResumen.ClearSelection()

    End Sub

    Private Sub reumenPorTransferencia()
        Dim objCaja As New Caja
        Dim oDataSet As New DataSet
        Dim oDataSetTraansferenciaPorVeta As DataSet
        setGrillaParaTransferencia()

        oDataSet = objCaja.buscarResumenTransferenciaVentaDiaria(fechaParam)

        If oDataSet.Tables(0).Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim fila As Integer = 0
            While oDataSet.Tables(0).Rows.Count > i

                dgvResumen.Rows.Add()
                dgvResumen.Rows(fila).Cells(0).Value = oDataSet.Tables(0).Rows(i).Item(1).ToString
                dgvResumen.Rows(fila).Cells(1).Value = FormatCurrency(oDataSet.Tables(0).Rows(i).Item(0).ToString)

                i = i + 1
                fila = fila + 1
            End While
        Else
            MsgBox("No se encuentran movimientos registrados para la condición de venta " & Me.descrpCondVenta, MsgBoxStyle.Information, "ARCO ELECTRICIDAD")
            Me.Close()
        End If
        dgvResumen.ClearSelection()
    End Sub

    Private Sub setGrillaParaTarjetas()

        Dim columna1, columna2, columna3, columna4 As New DataGridViewTextBoxColumn

        dgvResumen.Columns.Add(columna1)
        dgvResumen.Columns.Add(columna2)
        dgvResumen.Columns.Add(columna3)
        dgvResumen.Columns.Add(columna4)

        dgvResumen.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvResumen.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


    End Sub

    Private Sub setGrillaParaTransferencia()

        Dim columna1, columna2, columna3, columna4 As New DataGridViewTextBoxColumn

        dgvResumen.Columns.Add(columna1)
        dgvResumen.Columns.Add(columna2)

        dgvResumen.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvResumen.Columns(0).Width = 330



    End Sub
End Class


