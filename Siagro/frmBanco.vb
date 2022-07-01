Public Class frmBanco
    Dim estadoFormulario As String
    Dim accion As String
    Private Sub frmBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.inicializarControles()
    End Sub


    Private Sub cargarGrilla()
        Me.lstDescripcion.Rows.Clear()
        Dim objCheque As New Cheque
        Dim odataset As New DataSet
        Dim i As Integer = 0

        odataset = objCheque.buscarBancos

        While odataset.Tables(0).Rows.Count > i

            lstDescripcion.Rows.Add()
            lstDescripcion.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item(1)
            lstDescripcion.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0)

            i = i + 1
        End While

    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        Dim objCheque As New Cheque
        cargarGrilla()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub inicializarControles()

        Me.btnCancelar.Enabled = False
        Me.btnGuardar.Enabled = False

        Me.tssBorrar.Enabled = False
        Me.tssModificar.Enabled = False
        Me.tssNuevo.Enabled = True
        Me.txtDescripcion.Enabled = False
        Me.lstDescripcion.Enabled = True

    End Sub

    Private Sub tssCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssCerrar.Click
        Me.Close()
    End Sub

    Private Sub lstDescripcion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles lstDescripcion.CellContentClick
        Dim oDataSet As New DataSet
        Dim objCheque As New Cheque
        oDataSet = objCheque.buscarBanco(Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString)

        If oDataSet.Tables(0).Rows.Count > 0 Then
            Me.txtDescripcion.Text = oDataSet.Tables(0).Rows(0).Item("nombre")

            Me.tssModificar.Enabled = True
            Me.tssBorrar.Enabled = True
        Else

        End If
    End Sub

    Private Sub tssNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssNuevo.Click
        Me.accion = "nuevo"
        habilitarControles()
        Me.txtDescripcion.Text = ""
    End Sub

    Private Sub habilitarControles()
        Me.tssNuevo.Enabled = False
        Me.tssBorrar.Enabled = False
        Me.tssModificar.Enabled = False
        Me.btnCancelar.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.lstDescripcion.Enabled = False
    End Sub

    Private Sub tssModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssModificar.Click
        Me.habilitarControles()
        Me.accion = "modificar"
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim estadoAlerta As Integer
        estadoAlerta = 0
        If Me.txtDescripcion.Text = "" Then
            ' alerta.SetError(Me.txtDescripcion, "Ingrese la descripción")
            estadoAlerta = 1
        Else
            estadoAlerta = 0
            'alerta.Clear()
        End If
        Dim objCheque As New Cheque
        Dim odataset As New DataSet

        objCheque.nombreBanco = Me.txtDescripcion.Text.ToString




        If accion = "modificar" Then
            objCheque.idBanco = Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString
            objCheque.modificarBanco(objCheque)
            Me.lstDescripcion.DataSource = Nothing
            Me.cargarGrilla()

        Else
            objCheque.nuevoBanco(objCheque)
            Me.lstDescripcion.DataSource = Nothing
            Me.cargarGrilla()
        End If
        Me.inicializarControles()

    End Sub

    Private Sub lstDescripcion_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDescripcion.SelectionChanged
        Try
            Dim oDataSet As New DataSet
            Dim objCheque As New Cheque
            oDataSet = objCheque.buscarBanco(Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString)

            If oDataSet.Tables(0).Rows.Count > 0 Then
                Me.txtDescripcion.Text = oDataSet.Tables(0).Rows(0).Item("nombre")

                Me.tssModificar.Enabled = True
                Me.tssBorrar.Enabled = True
            Else

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tssBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBorrar.Click

        Dim objCheque As New Cheque

        If MsgBox("La siguiente acción eliminará el Banco " & Me.txtDescripcion.Text & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
            objCheque.borrarBanco(Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString)
            Me.lstDescripcion.DataSource = Nothing
            Me.cargarGrilla()
        End If
        Me.inicializarControles()
    End Sub


End Class