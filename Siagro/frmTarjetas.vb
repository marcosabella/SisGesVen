Public Class frmTarjetas
    Dim accion As String
    Private Sub frmTarjetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
        Me.inicializarControles()
    End Sub

    Private Sub cargarGrilla()
        Me.lstDescripcion.Rows.Clear()

        Dim objVentas As New Ventas
        Dim odataset As New DataSet
        Dim i As Integer = 0

        odataset = objVentas.buscarTarjetas

        While odataset.Tables(0).Rows.Count > i

            lstDescripcion.Rows.Add()
            lstDescripcion.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0)
            lstDescripcion.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item(1)
            lstDescripcion.Rows(i).Cells(2).Value = odataset.Tables(0).Rows(i).Item(2)
            i = i + 1
        End While

    End Sub

    Private Sub inicializarControles()

        Me.btnCancelar.Enabled = False
        Me.btnGuardar.Enabled = False

        Me.tssBorrar.Enabled = False
        Me.tssModificar.Enabled = False
        Me.tssNuevo.Enabled = True
        Me.txtDescripcion.Enabled = False
        Me.lstDescripcion.Enabled = True
        Me.txtRecargo.Enabled = False

    End Sub

    Private Sub tssCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssCerrar.Click
        Me.Close()
    End Sub

    Private Sub lstDescripcion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles lstDescripcion.CellContentClick
        Dim oDataSet As New DataSet
        Dim objVentas As New Ventas
        oDataSet = objVentas.buscarTarjetasXid(Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString)

        If oDataSet.Tables(0).Rows.Count > 0 Then
            Me.txtDescripcion.Text = oDataSet.Tables(0).Rows(0).Item("descripcion")
            Me.txtRecargo.Text = oDataSet.Tables(0).Rows(0).Item("porcRecargo")
            Me.tssModificar.Enabled = True
            Me.tssBorrar.Enabled = True
        Else

        End If
    End Sub

    Private Sub tssNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssNuevo.Click
        Me.accion = "nuevo"
        habilitarControles()
        Me.txtDescripcion.Text = ""
        Me.txtRecargo.Text = ""
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub habilitarControles()
        Me.tssNuevo.Enabled = False
        Me.tssBorrar.Enabled = False
        Me.tssModificar.Enabled = False
        Me.btnCancelar.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.lstDescripcion.Enabled = False
        Me.txtRecargo.Enabled = True
    End Sub

    Private Sub tssModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssModificar.Click
        Me.habilitarControles()
        Me.accion = "modificar"
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim estadoAlerta As Integer
        estadoAlerta = 0
        If Me.txtDescripcion.Text = "" Then
            estadoAlerta = 1
        Else
            estadoAlerta = 0
        End If
        If Me.txtRecargo.Text = "" Then
            estadoAlerta = 1
        Else
            estadoAlerta = 0
        End If

        If estadoAlerta = 1 Then
            MsgBox("Complete los campos descripcion y/o monto de recargo", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim objVentas As New Ventas
        Dim odataset As New DataSet


        objVentas.descripcion = Me.txtDescripcion.Text.ToString
        objVentas.porcRecargo = Replace(Me.txtRecargo.Text, ".", ",")

        If accion = "modificar" Then

            objVentas.idTarjetas = Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString
            objVentas.modificarTarjeta(objVentas)
            Me.lstDescripcion.DataSource = Nothing
        Else

            objVentas.nuevaTarjetaa(objVentas)
            Me.lstDescripcion.DataSource = Nothing

        End If
        Me.cargarGrilla()
        Me.inicializarControles()

    End Sub

    Private Sub lstDescripcion_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDescripcion.SelectionChanged
        Try
            Dim oDataSet As New DataSet
            Dim objVentas As New Ventas

            oDataSet = objVentas.buscarTarjetasXid(Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString)

            If oDataSet.Tables(0).Rows.Count > 0 Then
                Me.txtDescripcion.Text = oDataSet.Tables(0).Rows(0).Item("descripcion")
                Me.txtRecargo.Text = oDataSet.Tables(0).Rows(0).Item("porcRecargo")
                Me.tssModificar.Enabled = True
                Me.tssBorrar.Enabled = True
            Else

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tssBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBorrar.Click

        Dim objVentas As New Ventas

        If MsgBox("La siguiente acción eliminará la Tarjeta " & Me.txtDescripcion.Text & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
            objVentas.borrarTarjeta(Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString)
            Me.lstDescripcion.DataSource = Nothing
            Me.cargarGrilla()
        End If

        Me.inicializarControles()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.inicializarControles()
    End Sub


    Private Sub txtRecargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecargo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        ElseIf e.KeyChar = "-" Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class