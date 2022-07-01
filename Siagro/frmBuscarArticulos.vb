Imports GlobalVariables
Public Class frmBuscarArticulos

    Public codigoArticulo As Integer
    Public codigoEan As String
    Public rubro As String
    Dim dolar As Double = 0
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ByVal rubro As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.rubro = rubro
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub txtParametro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtParametro.KeyDown
        If e.KeyCode = Keys.Enter Then
            If listaArticulos.RowCount = 0 Then
                codigoArticulo = 0
            Else
                codigoArticulo = CInt(listaArticulos.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            'Me.Close()
        ElseIf e.KeyCode = Keys.Down Then
            listaArticulos.Focus()
        Else
            txtParametro.Focus()
        End If
    End Sub
    Private Sub txtParametro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtParametro.TextChanged
        Dim objArticulo As New Articulos
        cargarGrillaArticulos(Me.txtParametro.Text)
    End Sub
    Private Sub cargarGrillaArticulos(ByVal parametro As String)
        Try
            Dim objArticulo As New Articulos
            Dim odataset As New DataSet
            Dim oDataTable As New DataTable
            Dim montoDolar As Double
            Dim precioVenta As String
            Dim i As Integer = 0

            odataset = objArticulo.buscarArticuloXdescripcion(parametro)

            If odataset.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            progreso.Visible = True
            progreso.Maximum = odataset.Tables(0).Rows.Count

            listaArticulos.DataSource = Nothing

            listaArticulos.Columns.Clear()

            oDataTable = odataset.Tables(0)
            listaArticulos.DataSource = oDataTable

            listaArticulos.DataSource = oDataTable
            listaArticulos.Columns(3).Visible = False
            listaArticulos.Columns(4).Visible = False
            listaArticulos.Columns(5).Visible = False
            listaArticulos.Columns(6).Visible = False
            listaArticulos.Columns(7).Visible = False
            listaArticulos.Columns(8).Visible = False
            listaArticulos.Columns(9).Visible = False
            listaArticulos.Columns(11).Visible = False
            listaArticulos.Columns(13).Visible = False

            listaArticulos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            listaArticulos.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            listaArticulos.Columns.Add("precioVenta", "Precio Venta")
            listaArticulos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            listaArticulos.Columns(0).HeaderText = "Cod"
            listaArticulos.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            listaArticulos.Columns(1).HeaderText = "Cod. Barras"
            listaArticulos.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            listaArticulos.Columns(2).HeaderText = "Descripcion"
            listaArticulos.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            listaArticulos.Columns(10).HeaderText = "Stock"
            listaArticulos.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            listaArticulos.Columns(12).HeaderText = "Moneda"
            listaArticulos.Columns(14).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            listaArticulos.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            For i = 0 To listaArticulos.Rows.Count - 1
                progreso.Value = i
                Application.DoEvents()
                montoDolar = 1
                If listaArticulos.Rows(i).Cells(12).Value = "U$D BLUE" Then
                    montoDolar = Form1.cotizacionDolarBlue
                ElseIf listaArticulos.Rows(i).Cells(12).Value = "U$D OFICIAL" Then
                    montoDolar = Form1.cotizacionDolarOficial
                End If
                precioVenta = CStr((FormatNumber(Me.calcularPrecioVenta(listaArticulos.Rows(i).Cells(6).Value, listaArticulos.Rows(i).Cells(7).Value, listaArticulos.Rows(i).Cells(9).Value, listaArticulos.Rows(i).Cells(8).Value) * montoDolar, 2))).ToString
                listaArticulos.Rows(i).Cells(14).Value = "$ " & FormatNumber(precioVenta, 2)

            Next

            progreso.Visible = False
        Catch ex As Exception

        End Try


    End Sub
    Private Sub cargarGrillaArticulos()
        'Me.lstArticulos.Rows.Clear()
        listaArticulos.DataSource = Nothing
        'listaArticuloParametro.DataSource = Nothing
        'l istaArticuloParametro.Visible = False
        listaArticulos.Visible = True
        Dim objArticulos As New Articulos
        Dim odataset As New DataSet
        Dim oDataTable As New DataTable
        Dim montoDolar As Double
        Dim precioVenta As String
        Dim i As Integer = 0

        'If rubro = Nothing Then
        odataset = objArticulos.buscarArticulos
        'Else
        'odataset = objArticulos.buscarArticulosXrubro(rubro)
        'End If
        If odataset.Tables(0).Rows.Count = 0 Then
            Exit Sub
        End If

        progreso.Visible = True
        progreso.Maximum = odataset.Tables(0).Rows.Count

        '//nuevo
        oDataTable = odataset.Tables(0)
        listaArticulos.DataSource = oDataTable
        listaArticulos.Columns(3).Visible = False
        listaArticulos.Columns(4).Visible = False
        listaArticulos.Columns(5).Visible = False
        listaArticulos.Columns(6).Visible = False
        listaArticulos.Columns(7).Visible = False
        listaArticulos.Columns(8).Visible = False
        listaArticulos.Columns(9).Visible = False
        listaArticulos.Columns(11).Visible = False
        listaArticulos.Columns(13).Visible = False
        listaArticulos.Columns.Add("precioVenta", "Precio Venta")


        listaArticulos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        listaArticulos.Columns(0).HeaderText = "Cod"
        listaArticulos.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        listaArticulos.Columns(1).HeaderText = "Cod. Barras"
        listaArticulos.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        listaArticulos.Columns(2).HeaderText = "Descripcion"
        listaArticulos.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        listaArticulos.Columns(10).HeaderText = "Stock"
        listaArticulos.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        listaArticulos.Columns(12).HeaderText = "Moneda"
        listaArticulos.Columns(14).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        listaArticulos.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        For i = 0 To listaArticulos.Rows.Count - 1
            progreso.Value = i
            Application.DoEvents()
            montoDolar = 1
            If listaArticulos.Rows(i).Cells(12).Value = "U$D BLUE" Then
                montoDolar = Form1.cotizacionDolarBlue
            ElseIf listaArticulos.Rows(i).Cells(12).Value = "U$D OFICIAL" Then
                montoDolar = Form1.cotizacionDolarOficial
            End If
            precioVenta = CStr((FormatNumber(Me.calcularPrecioVenta(listaArticulos.Rows(i).Cells(6).Value, listaArticulos.Rows(i).Cells(7).Value, listaArticulos.Rows(i).Cells(9).Value, listaArticulos.Rows(i).Cells(8).Value) * montoDolar, 2))).ToString
            listaArticulos.Rows(i).Cells(14).Value = "$ " & FormatNumber(precioVenta, 2)

        Next


        '//nuevo




        'While odataset.Tables(0).Rows.Count > i
        '    lstArticulos.Rows.Add()

        '    'busco monto dolar
        '    'Dim objArticulo As New Articulos
        '    Dim moneda As String

        '    Dim objVenta As New Ventas
        '    Dim montoDolar As Double
        '    Dim idUltimaCotizacion As Integer
        '    Dim odatasetUltimaCotizacion As New DataSet

        '    'obtener moneda del articulo
        '    moneda = odataset.Tables(0).Rows(i).Item("moneda")

        '    If moneda <> "AR$" Then
        '        'If IsDBNull(objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)) Then
        '        '    idUltimaCotizacion = objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)
        '        '    montoDolar = 1
        '        '    lstArticulos.Rows(i).Cells(5).Value = "S/C"

        '        'Else

        '        '    '                    odatasetUltimaCotizacion = objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)
        '        '    idUltimaCotizacion = objVenta.ultimaCotización(moneda).Tables(0).Rows(0).Item(0)

        '        '    montoDolar = objVenta.cotizaciónXid(idUltimaCotizacion).Tables(0).Rows(0).Item("monto")
        '        '    lstArticulos.Rows(i).Cells(5).Value = "$ " & CStr(montoDolar)
        '        'End If
        '        If moneda = "U$D BLUE" Then
        '            montoDolar = Form1.cotizacionDolarBlue
        '        ElseIf moneda = "U$D OFICIAL" Then
        '            montoDolar = Form1.cotizacionDolarOficial
        '        End If
        '    Else
        '        montoDolar = 1
        '        lstArticulos.Rows(i).Cells(5).Value = "$ " & CStr(montoDolar)
        '    End If


        '    lstArticulos.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item("idArticulo").ToString
        '    lstArticulos.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item("codigo_barras")
        '    lstArticulos.Rows(i).Cells(2).Value = odataset.Tables(0).Rows(i).Item("descripcion").ToString
        '    lstArticulos.Rows(i).Cells(3).Value = odataset.Tables(0).Rows(i).Item("moneda").ToString
        '    lstArticulos.Rows(i).Cells(4).Value = Microsoft.VisualBasic.Left((odataset.Tables(0).Rows(i).Item("moneda").ToString), 3) & " " & (FormatNumber(Me.calcularPrecioVenta(odataset.Tables(0).Rows(i).Item("costo").ToString, odataset.Tables(0).Rows(i).Item("iva").ToString, odataset.Tables(0).Rows(i).Item("descuento").ToString, odataset.Tables(0).Rows(i).Item("utilidad").ToString), 2) * 1)
        '    lstArticulos.Rows(i).Cells(5).Value = "$ " & CStr(montoDolar)
        '    'lstArticulos.Rows(i).Cells(6).Value = "$ " & (FormatNumber(Me.calcularPrecioVenta(odataset.Tables(0).Rows(i).Item("costo").ToString, odataset.Tables(0).Rows(i).Item("iva").ToString, odataset.Tables(0).Rows(i).Item("descuento").ToString, odataset.Tables(0).Rows(i).Item("utilidad").ToString), 2) * montoDolar)
        '    lstArticulos.Rows(i).Cells(7).Value = odataset.Tables(0).Rows(i).Item("stock")

        '    If odataset.Tables(0).Rows(i).Item("stock") < 1 Then
        '        lstArticulos.Rows(i).DefaultCellStyle.BackColor = Color.Red
        '        lstArticulos.Rows(i).DefaultCellStyle.ForeColor = Color.White
        '    End If
        '    i = i + 1
        'End While
        Me.txtParametro.Focus()
        progreso.Visible = False
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If listaArticulos.RowCount = 0 Then
            codigoArticulo = 0
        Else
            codigoArticulo = CInt(listaArticulos.CurrentRow.Cells(0).Value.ToString)
        End If
        'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
        Me.Close()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        codigoArticulo = 0
        Me.Close()
    End Sub

    Private Sub frmBuscarArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'obtenerCotizacion()
        progreso.Visible = False
        Me.cargarGrillaArticulos()
        Me.txtParametro.Focus()
    End Sub

    Private Sub obtenerCotizacion()
        Dim objVentas As New Ventas
        Dim oDataSet As New DataSet
        'oDataSet = objVentas.ultimaCotización()
        If oDataSet.Tables(0).Rows.Count > 0 Then

            ' dolar =  oDataSet.Tables(0).Rows(0).Item("monto")
            dolar = oDataSet.Tables(0).Rows(0).Item("monto")
        Else
            'Me.cotizacionDolar()
            ' Me.lblDolar.Text = " Dolar sin cotización"
        End If

    End Sub


    Private Function calcularPrecioVenta(ByVal costo As String, ByVal iva As String, ByVal descuento As String, ByVal utilidad As String) As Double
        Dim precioVenta As Double
        Dim conIva As Double
        Dim conUtilidad As Double
        'conIva = (costo * (1 + (iva / 100)))
        'conUtilidad = conIva * (1 + (utilidad / 100))
        precioVenta = (costo * (1 + (iva / 100))) * (1 + (utilidad / 100))
        'precioVenta = conUtilidad
        If descuento <> "" And descuento <> "0" Then
            precioVenta = precioVenta - ((precioVenta * (descuento / 100)))
        End If
        Return precioVenta
    End Function

    Private Sub lstArticulos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstArticulos.KeyDown
        If e.KeyCode = Keys.Enter Then
            If listaArticulos.RowCount = 0 Then
                codigoArticulo = 0
            Else
                codigoArticulo = CInt(listaArticulos.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            listaArticulos.Focus()
        ElseIf e.KeyCode = Keys.Back Then
            txtParametro.Focus()
            txtParametro.Text = ""
        Else
            txtParametro.Focus()
            txtParametro.Text = Chr(e.KeyCode)
            txtParametro.Select(txtParametro.Text.Length, 0)
            'txtParametro.Focus()
        End If
    End Sub

    Private Sub listaArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles listaArticulos.KeyDown
        If e.KeyCode = Keys.Enter Then
            If listaArticulos.RowCount = 0 Then
                codigoArticulo = 0
            Else
                codigoArticulo = CInt(listaArticulos.CurrentRow.Cells(0).Value.ToString)
            End If
            'codigo = CInt(lstClientes.CurrentRow.Cells(0).Value.ToString)
            Me.Close()
        ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            listaArticulos.Focus()
        ElseIf e.KeyCode = Keys.Back Then
            txtParametro.Focus()
            txtParametro.Text = ""
        Else
            txtParametro.Focus()
            txtParametro.Text = Chr(e.KeyCode)
            txtParametro.Select(txtParametro.Text.Length, 0)
            'txtParametro.Focus()
        End If

    End Sub
End Class