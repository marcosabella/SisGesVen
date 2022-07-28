Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmRespaldoBD
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    'Public Sub New()

    '    ' Esta llamada es exigida por el diseñador.
    '    InitializeComponent()

    '    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    'End Sub
    Private Sub frmRespaldoBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.txtlog.Text = ""
        Me.txtMailEnvio.Enabled = False
        barra.Visible = False
        barra.Minimum = 0
        barra.Maximum = 10
    End Sub

    Public Function obtenerRutaFichero() As String
        Dim Carpeta As String = My.Computer.FileSystem.CurrentDirectory
        lblPath.Text = Carpeta & "\BDsiagro.mdb"
        Return lblPath.Text
    End Function

    Public Function EnviarCorreo(ByVal CuentaCorreoEnvio As String,
                                       ByVal ClaveCorreoEnvio As String,
                                       ByVal ServidorSMTP As String,
                                       ByVal PuertoSMTP As Integer,
                                       ByVal DireccionesEmail As String,
                                       ByVal Asunto As String,
                                       ByVal Cuerpo As String,
                                       ByVal RutaFichero As String,
                                       ByVal MostrarMensajeOK As Boolean,
                                       ByVal NombreVisibleCorreo As String,
                                       ByVal DireccionEmailCopiaOculta As Boolean)

        Dim miMail As New MailMessage

        Try


            Dim smtp As New SmtpClient
            Dim i As Integer = 0
            Dim miRecurso As Attachment

            Dim miDireccion As New MailAddress(LCase(CuentaCorreoEnvio), NombreVisibleCorreo, System.Text.Encoding.UTF8)

            miMail.From = miDireccion

            Dim html As AlternateView = AlternateView.CreateAlternateViewFromString(Cuerpo, Encoding.UTF8, "text/html")
            miMail.To.Add(New MailAddress(DireccionesEmail))

            i = 0

            i = 0

            miMail.Subject = Asunto
            miMail.IsBodyHtml = True
            miMail.Body = Cuerpo

            i = 0
            miRecurso = New Attachment(RutaFichero)

            miMail.Attachments.Add(miRecurso)

            smtp.Port = PuertoSMTP
            smtp.Timeout = 30000
            smtp.Host = ServidorSMTP  ' Config.ServidorSMTP
            smtp.EnableSsl = False
            smtp.Credentials = New NetworkCredential(LCase(CuentaCorreoEnvio), ClaveCorreoEnvio)
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network

            EnviarCorreo = True

            ServicePointManager.ServerCertificateValidationCallback = Function(s As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) True

            smtp.Send(miMail)

            If MostrarMensajeOK Then
                barra.Value = 10
                ' Dim objMail As New Mail
                'objMail.eventoSincronizacion = "SINCRONIZACION EXITOSA"
                'objMail.fechaSincronizacion = Now
                'objMail.correoSincronizacion = Me.txtMailEnvio.Text
                'objMail.usuarioSincronizacion = ""
                'objMail.registrarLog(objMail)
                MsgBox("SINCRONIZACION EXITOSA")
            End If
        Catch ex As Exception
            EnviarCorreo = False

            If MostrarMensajeOK Then
                barra.Visible = False
                'Dim objMail As New Mail
                'objMail.eventoSincronizacion = "ERROR DE SINCRONIZACION"
                'objMail.fechaSincronizacion = Now
                'objMail.correoSincronizacion = Me.txtMailEnvio.Text
                'objMail.usuarioSincronizacion = ""
                'objMail.registrarLog(objMail)
                MsgBox("ERROR DE SINCRONIZACION")
            End If

        Finally
            miMail.Dispose()
            barra.Value = 10
            barra.Visible = False

        End Try
    End Function

    Public Sub adjuntarFichero()
        Dim vFileName As String = Nothing
        Dim diskOpts As New DiskFileDestinationOptions()
        Dim DireccionesEmail As String = Nothing
        Dim objMail As New Mail

        Try

            DireccionesEmail = Me.txtMailEnvio.Text
            If String.IsNullOrEmpty(DireccionesEmail) Then
                Exit Sub

            End If
            Dim Carpeta As String = My.Computer.FileSystem.CurrentDirectory
            vFileName = Carpeta & "\BDsiagro.mdb"
            barra.Value = 4
            Dim odatasetMail As New DataSet
            odatasetMail = objMail.buscarDatosMails()
            objMail.correoEnvio = odatasetMail.Tables(0).Rows(0).Item("mail")
            objMail.passCorreoEnvio = odatasetMail.Tables(0).Rows(0).Item("pass")
            objMail.servidorCorreo = odatasetMail.Tables(0).Rows(0).Item("servidor")
            barra.Value = 7
            EnviarCorreo(objMail.correoEnvio, objMail.passCorreoEnvio, objMail.servidorCorreo, 25, DireccionesEmail, "Copia de Seguridad", "Estimado adjunto Copia de Seguridad<br><br><br>Un servicio de DELCOM SISTEMAS", vFileName, True, "ARCO ELECTRICIDAD", False)
        Catch ex As Exception
            'Dim objMail As New Mail
            'objMail.eventoSincronizacion = "ERROR DE SINCRONIZACION"
            'objMail.fechaSincronizacion = Now
            'objMail.correoSincronizacion = Me.txtMailEnvio.Text
            'objMail.usuarioSincronizacion = ""
            'objMail.registrarLog(objMail)
            'Dim frmLogin As New frmLogin
            'objMail.usuarioSincronizacion = frmLogin.oDataSetValidar.Tables(0).Rows(0).Item("nombre")
            MsgBox("ERROR DE SINCRONIZACION")
        End Try
    End Sub

    Private Sub btnRespaldo_Click(sender As Object, e As EventArgs) Handles btnRespaldo.Click
        Me.txtMailEnvio.Enabled = False
        'Me.txtlog.Text = ""
        'Me.txtlog.Text = Nothing
        'Me.txtlog.ResetText()
        'Me.txtlog.Text = "Preparando sincronización..." & vbNewLine & "Aguarde por favor..." & vbNewLine
        barra.Visible = True
        barra.Value = 2
        btnEditMail.Enabled = False
        btnRespaldo.Enabled = False
        adjuntarFichero()
        btnEditMail.Enabled = True
        btnRespaldo.Enabled = True
        Me.txtMailEnvio.Enabled = False
        barra.Visible = False
    End Sub

    Private Sub btnEditMail_Click(sender As Object, e As EventArgs) Handles btnEditMail.Click
        Me.txtMailEnvio.Enabled = True
    End Sub

    Private Sub txtMailEnvio_LostFocus(sender As Object, e As EventArgs) Handles txtMailEnvio.LostFocus
        Me.txtMailEnvio.Enabled = False
    End Sub
End Class