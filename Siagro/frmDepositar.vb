Public Class frmDepositar
    Private Sub FrmDepositar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboValores.SelectedIndex = -1
        Me.cargarComboBanco()
        dgv_valores.Visible = False
        lblImporte.Visible = False
        txtImporte.Visible = False
        chkTodo.Visible = False
    End Sub

    Private Sub CboValores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboValores.SelectedIndexChanged
        dgv_valores.DataSource = Nothing
        dgv_valores.Columns.Clear()
        chkTodo.Checked = False
        txtImporte.Text = ""
        If cboValores.Text = "Tarjeta" Then
            lblImporte.Visible = False
            txtImporte.Visible = False
            cargarGrillaTarjeta()
            dgv_valores.Visible = True
            chkTodo.Visible = True
        ElseIf cboValores.Text = "Cheque" Then
            lblImporte.Visible = False
            txtImporte.Visible = False
            cargarGrillaCheque()
            dgv_valores.Visible = True
            chkTodo.Visible = True
        Else
            dgv_valores.Visible = False
            chkTodo.Visible = False
            lblImporte.Visible = True
            txtImporte.Visible = True

        End If
    End Sub

    Private Sub cargarGrillaTarjeta()
        Dim objCaja As New Caja
        Dim oDataSet As New DataSet

        dgv_valores.DataSource = Nothing
        dgv_valores.Columns.Clear()
        dgv_valores.Visible = True

        Dim oDataTable As New DataTable

        Dim i As Integer = 0

        oDataSet = objCaja.buscarTodasTarjetasSinDepositar

        If odataset.Tables(0).Rows.Count = 0 Then
            Exit Sub
        End If

        '//nuevo
        oDataTable = odataset.Tables(0)
        dgv_valores.DataSource = oDataTable
        dgv_valores.Columns(0).Visible = False
        dgv_valores.Columns(0).Name = "id"

        dgv_valores.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgv_valores.Columns(1).HeaderText = "N° Venta"

        dgv_valores.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_valores.Columns(2).HeaderText = "Nombre Tarjeta"

        dgv_valores.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgv_valores.Columns(3).HeaderText = "N° Cupón"


        dgv_valores.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_valores.Columns(4).HeaderText = "Monto"
        dgv_valores.Columns(4).Name = "Monto"

        dgv_valores.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgv_valores.Columns(5).HeaderText = "Depositar"
        dgv_valores.Columns(5).Name = "Depositar"

        dgv_valores.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_valores.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_valores.Columns(2).Width = 300
        dgv_valores.Columns(3).Width = 150
        '//nuevo

        Me.lblCantRegistro.Text = "Registros encontrados: " & oDataSet.Tables(0).Rows.Count

    End Sub

    Private Sub cargarGrillaCheque()
        Dim objCaja As New Caja
        Dim oDataSet As New DataSet
        dgv_valores.DataSource = Nothing
        dgv_valores.Columns.Clear()
        dgv_valores.Visible = True


        Dim oDataTable As New DataTable

        Dim i As Integer = 0


        oDataSet = objCaja.buscarTodosChequesSinDepositar

        If oDataSet.Tables(0).Rows.Count = 0 Then
            Exit Sub
        End If

        '//nuevo
        oDataTable = oDataSet.Tables(0)
        dgv_valores.DataSource = oDataTable

        Dim chk As New DataGridViewCheckBoxColumn
        chk.HeaderText = "Depositar"
        chk.Name = "Depositar"
        dgv_valores.Columns.Add(chk)

        dgv_valores.Columns(0).Visible = False
        dgv_valores.Columns(0).Name = "id"

        dgv_valores.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgv_valores.Columns(1).HeaderText = "N° Venta"

        dgv_valores.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_valores.Columns(2).HeaderText = "Emisor"

        dgv_valores.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_valores.Columns(3).HeaderText = "Fecha"

        dgv_valores.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_valores.Columns(4).HeaderText = "Fecha Vto."

        dgv_valores.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_valores.Columns(5).HeaderText = "Monto"
        dgv_valores.Columns(5).Name = "Monto"

        dgv_valores.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        'dgv_valores.Columns(6).HeaderText = "Depositar"

        dgv_valores.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgv_valores.Columns(2).Width = 200
        dgv_valores.Columns(3).Width = 80
        dgv_valores.Columns(4).Width = 80
        dgv_valores.Columns(5).Width = 100
        dgv_valores.Columns(6).Width = 80
        '//nuevo

        Me.lblCantRegistro.Text = "Registros encontrados: " & oDataSet.Tables(0).Rows.Count

    End Sub

    Private Sub TxtImporte_TextChanged(sender As Object, e As EventArgs) Handles txtImporte.TextChanged

    End Sub

    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cargarComboBanco()
        Dim objBanco As New Banco
        Dim oDataSet As New DataSet
        oDataSet = objBanco.buscarBancosPropios
        If oDataSet.Tables(0).Rows.Count <> 0 Then
            Me.cboBanco.DataSource = oDataSet.Tables(0)
            Me.cboBanco.DisplayMember = oDataSet.Tables(0).Columns(1).Caption.ToString
            Me.cboBanco.ValueMember = oDataSet.Tables(0).Columns(0).Caption.ToString
            Me.cboBanco.SelectedIndex = -1
        End If
    End Sub

    Private Sub montoDepositarGrilla(ByVal grilla As DataGridView)
        Dim montoAdepositar As Double
        Dim objCaja As New Caja
        If cboBanco.Text <> "" Then
            If cboValores.Text = "Efectivo" Then
                montoAdepositar = txtImporte.Text
            Else
                For Each Fila As DataGridViewRow In grilla.Rows
                    If Fila.Cells("Depositar").Value = True Then
                        montoAdepositar += Fila.Cells("Monto").Value
                    End If
                Next
            End If

            If montoAdepositar <> 0 Then
                If MsgBox("Se realizará el deposito de: " & FormatCurrency(montoAdepositar, 2) & ", en " & cboBanco.Text & vbNewLine & " ¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                    marcarDepositadoGrilla(cboValores.Text, dgv_valores)
                    objCaja.RegistrarDeposito(FormatDateTime(Now, DateFormat.ShortDate), montoAdepositar, cboBanco.SelectedValue, cboValores.SelectedIndex)
                    cboValores.SelectedIndex = -1
                    Me.cargarComboBanco()
                    dgv_valores.Visible = False
                    lblImporte.Visible = False
                    txtImporte.Visible = False
                    chkTodo.Visible = False
                    txtImporte.Text = ""
                    MsgBox("Se registro el depósito exitosamente.")
                End If
            Else
                MsgBox("Seleccione monto a depositar", MsgBoxStyle.Information, "SISTEMAS GESTIÓN DE VENTAS Y STOCK")
            End If
        Else
                MsgBox("Seleccione el banco a realizar el depósito", MsgBoxStyle.Information, "SISTEMAS GESTIÓN DE VENTAS Y STOCK")
        End If
    End Sub

    Private Sub marcarDepositadoGrilla(ByVal valor As String, ByVal grilla As DataGridView)
        If valor = "Cheque" Then
            Dim objCheque As New Cheque
            For Each Fila As DataGridViewRow In grilla.Rows
                If Fila.Cells("Depositar").Value = True Then
                    objCheque.idCheque = Fila.Cells("id").Value
                    objCheque.modificarChequeEncartera(objCheque)
                End If
            Next
            cargarGrillaCheque()

        ElseIf valor = "Tarjeta" Then
            Dim objCaja As New Caja
            For Each Fila As DataGridViewRow In grilla.Rows
                If Fila.Cells("Depositar").Value = True Then
                    objCaja.modificarTarjetaAdpositado(Fila.Cells("id").Value)
                End If
            Next
            cargarGrillaTarjeta()
        End If

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        montoDepositarGrilla(dgv_valores)
    End Sub

    Private Sub ChkTodo_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodo.CheckedChanged
        For Each Fila As DataGridViewRow In dgv_valores.Rows

            If chkTodo.Checked = True Then
                Fila.Cells("Depositar").Value = True
            Else
                Fila.Cells("Depositar").Value = False
            End If

        Next
    End Sub
End Class