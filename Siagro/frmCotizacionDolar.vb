
Imports System.IO
Imports System.Net
Imports System.Xml
'Imports Siagro.convertirDolar
Public Class frmCotizacionDolar
    Dim precioDolar As Double
    Private Sub frmCotizacionDolar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'obtenerCotizacion()

    End Sub
    'Public Sub cotizacionDolar()
    '    Dim xmlResult As String = Nothing
    '    Dim url As String
    '    Dim encontrado As Boolean
    '    encontrado = False

    '    ' While encontrado = False
    '    'Dim result = client.ConversionRate(Currency.EUR, Currency.USD)
    '    'url = "http://www.webservicex.net/CurrencyConvertor.asmx/ConversionRate?FromCurrency=" & TextBox1.Text & "&ToCurrency=" & TextBox2.Text
    '    'EUR A MXN
    '    'USD A MXN
    '    'url = "http://www.webservicex.net/CurrencyConvertor.asmx/ConversionRate?FromCurrency=USD&ToCurrency=ARS"
    '    'Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
    '    'Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
    '    'Dim resStream As New StreamReader(response.GetResponseStream())
    '    'Dim doc As New XmlDocument()
    '    'xmlResult = resStream.ReadToEnd()
    '    'doc.LoadXml(xmlResult)
    '    ''Label1.Text = "Tipo de cambio actual para " & TextBox1.Text.ToUpper() & " ---> " & TextBox2.Text.ToUpper() & " valor " & doc.GetElementsByTagName("double").Item(0).InnerText

    '    txtContizacion.Text = doc.GetElementsByTagName("double").Item(0).InnerText
    '    If txtContizacion.Text = "-1" Then
    '        '        encontrado = False
    '        'txtContizacion.Text = "No se ha podido obtener cotización del dolar"
    '        'precioDolar = 1
    '        MsgBox("No se ha podido obtener cotización del dolar", vbExclamation)
    '        obtenerCotizacion()
    '    Else
    '        'encontrado = True
    '        txtContizacion.Text = doc.GetElementsByTagName("double").Item(0).InnerText
    '        precioDolar = Replace(doc.GetElementsByTagName("double").Item(0).InnerText, ".", ",")
    '        lblFechaActualizacion.Text = Now
    '    End If
    '    'End While
    'End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objventa As New Ventas
        If txtContizacion.Text = "" Then
            Exit Sub
        End If
        objventa.precioDolar = Replace(Me.txtContizacion.Text, ".", ",")
        objventa.tipoDolar = cboMoneda.Text
        objventa.registrarPrecioDolar(objventa)
        lstHistorico.Rows.Clear()
        obtenerCotizacion(cboMoneda.Text)

    End Sub

    Private Sub obtenerCotizacion(ByVal tipoDolar As String)
        Dim objVentas As New Ventas
        Dim oDataSet As New DataSet
        Dim odatasetUR As New DataSet
        Me.txtContizacion.Text = ""
        Me.lblFechaActualizacion.Text = ""
        odatasetUR = objVentas.ultimaCotización(tipoDolar)
        'MsgBox(odatasetUR.Tables(0).Rows(0).Item(0).ToString)
        If odatasetUR.Tables(0).Rows(0).Item(0).ToString <> "" Then
            oDataSet = objVentas.cotizaciónXid(odatasetUR.Tables(0).Rows(0).Item(0))
            If oDataSet.Tables(0).Rows.Count > 0 Then
                Me.lblFechaActualizacion.Text = oDataSet.Tables(0).Rows(0).Item("fecha_actualizacion")
                Me.txtContizacion.Text = oDataSet.Tables(0).Rows(0).Item("monto")

            Else
                'Me.cotizacionDolar()
                Me.txtContizacion.Text = ""
                Me.lblFechaActualizacion.Text = ""
            End If
        End If
        cargarGrillaHistorico()
    End Sub

    Private Sub btnCotizarOnline_Click(sender As Object, e As EventArgs)
        'cotizacionDolar()
    End Sub

    Private Sub cargarGrillaHistorico()
        Me.lstHistorico.Rows.Clear()
        Dim objVentas As New Ventas
        Dim odataset As New DataSet
        Dim i As Integer = 0
        odataset = objVentas.historicoDolar(cboMoneda.Text)

        While odataset.Tables(0).Rows.Count > i
            lstHistorico.Rows.Add()
            lstHistorico.Rows(i).Cells(0).Value = odataset.Tables(0).Rows(i).Item(0)
            lstHistorico.Rows(i).Cells(1).Value = odataset.Tables(0).Rows(i).Item("fecha_actualizacion")
            lstHistorico.Rows(i).Cells(2).Value = odataset.Tables(0).Rows(i).Item("monto")

            i = i + 1
        End While

    End Sub

    Private Sub lstHistorico_KeyDown(sender As Object, e As KeyEventArgs) Handles lstHistorico.KeyDown
        Dim objVentas As New Ventas
        If e.KeyCode = Keys.Delete Then
            If lstHistorico.Rows.Count > 0 Then
                If MsgBox("Desea eliminar Item?", MsgBoxStyle.YesNo, "SISTEMAS GESTIÓN DE VENTAS Y STOCK") = MsgBoxResult.Yes Then
                    objVentas.borrarCotizacion(lstHistorico.CurrentRow.Cells(0).Value.ToString)
                    lstHistorico.Rows.Remove(lstHistorico.CurrentRow())
                    If lstHistorico.Rows.Count = 0 Then
                        Me.txtContizacion.Text = ""
                        Me.lblFechaActualizacion.Text = ""
                    Else
                        Me.txtContizacion.Text = lstHistorico.Rows(0).Cells(2).Value.ToString
                        Me.lblFechaActualizacion.Text = lstHistorico.Rows(0).Cells(1).Value.ToString
                    End If

                End If

            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        obtenerCotizacion(cboMoneda.Text)
    End Sub

    Private Sub cboMoneda_TextChanged(sender As Object, e As EventArgs) Handles cboMoneda.TextChanged
        obtenerCotizacion(cboMoneda.Text)
    End Sub

    Private Sub btnGrafico_Click(sender As Object, e As EventArgs) Handles btnGrafico.Click
        'Dim frmGrafico As New frmGraficoDolar
        'frmGrafico.ShowDialog()
    End Sub
End Class