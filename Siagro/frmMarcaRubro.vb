Public Class frmMarcaRubro
    Dim estadoFormulario As String
    Dim accion As String
    Private Sub frmMarcaRubro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.inicializarControles()
    End Sub


    Private Sub cargarGrilla(ByVal tabla As String)
        Me.lstDescripcion.Rows.Clear()
        Dim objRubro As New Rubro
        Dim objMarca As New Marca
        Dim odataset As New DataSet
        Dim i As Integer = 0

        If tabla = "Rubro" Then
            odataset = objRubro.buscarRubros
        ElseIf tabla = "Marca" Then
            odataset = objMarca.buscarMarcas
        End If



        While odataset.Tables(0).Rows.Count > i

            lstDescripcion.Rows.Add()
            If tabla = "Rubro" Then
                lstDescripcion.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item(2)
            Else
                lstDescripcion.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item(1)
            End If
            lstDescripcion.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0)

            i = i + 1
        End While

    End Sub

    Public Sub New(ByVal tabla As String)
        Me.estadoFormulario = tabla
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        If estadoFormulario = "Rubro" Then
            Me.Text = "Rubro"
            Dim objRubro As New Rubro
            cargarGrilla(estadoFormulario)

        ElseIf estadoFormulario = "Marca" Then
            Me.Text = "Marca"
            Dim objMarca As New Marca
            cargarGrilla(estadoFormulario)
        End If
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
        Dim objRubro As New Rubro
        Dim objMarca As New Marca
        If estadoFormulario = "Rubro" Then
            oDataSet = objRubro.buscarRubro(Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString)
        ElseIf estadoFormulario = "Marca" Then
            oDataSet = objMarca.buscarMarca(Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString)

        End If
        If oDataSet.Tables(0).Rows.Count > 0 Then
            Me.txtDescripcion.Text = oDataSet.Tables(0).Rows(0).Item("descripcion")

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
        Dim objRubro As New Rubro
        Dim objMarca As New Marca
        Dim odataset As New DataSet

        If estadoFormulario = "Rubro" Then
            objRubro.descripcion = Me.txtDescripcion.Text.ToString
        ElseIf estadoFormulario = "Marca" Then
            objMarca.descripcion = Me.txtDescripcion.Text.ToString

        End If



        If accion = "modificar" Then
            If estadoFormulario = "Rubro" Then
                objRubro.id = Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString
                objRubro.modificarRubro(objRubro)
                Me.lstDescripcion.DataSource = Nothing
                Me.cargarGrilla("Rubro")
            ElseIf estadoFormulario = "Marca" Then
                objMarca.id = Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString
                objMarca.modificarMarca(objMarca)
                Me.lstDescripcion.DataSource = Nothing
                Me.cargarGrilla("Marca")
            End If

        Else
            If estadoFormulario = "Rubro" Then
                objRubro.nuevoRubro(objRubro)
                Me.lstDescripcion.DataSource = Nothing
                Me.cargarGrilla("Rubro")
            ElseIf estadoFormulario = "Marca" Then
                objMarca.nuevaMarca(objMarca)
                Me.lstDescripcion.DataSource = Nothing
                Me.cargarGrilla("Marca")
            End If
        End If
        Me.inicializarControles()

    End Sub

    Private Sub lstDescripcion_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDescripcion.SelectionChanged
        Try
            Dim oDataSet As New DataSet
            Dim objRubro As New Rubro
            Dim objMarca As New Marca
            If estadoFormulario = "Rubro" Then
                oDataSet = objRubro.buscarRubro(Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString)
            ElseIf estadoFormulario = "Marca" Then
                oDataSet = objMarca.buscarMarca(Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString)

            End If
            If oDataSet.Tables(0).Rows.Count > 0 Then
                Me.txtDescripcion.Text = oDataSet.Tables(0).Rows(0).Item("descripcion")

                Me.tssModificar.Enabled = True
                Me.tssBorrar.Enabled = True
            Else

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tssBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssBorrar.Click
        If estadoFormulario = "Rubro" Then
            Dim objRubro As New Rubro

            If MsgBox("La siguiente acción eliminará el Rubro " & Me.txtDescripcion.Text & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                objRubro.borrarRubros(Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString)
                Me.lstDescripcion.DataSource = Nothing
                Me.cargarGrilla("Rubro")
            End If
        ElseIf estadoFormulario = "Marca" Then
            Dim objMarca As New Marca
            If MsgBox("La siguiente acción eliminará la Marca " & Me.txtDescripcion.Text & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                objMarca.borrarMarca(Me.lstDescripcion.CurrentRow.Cells(0).Value.ToString)
                Me.lstDescripcion.DataSource = Nothing
                Me.cargarGrilla("Marca")
            End If
        End If
        Me.inicializarControles()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class