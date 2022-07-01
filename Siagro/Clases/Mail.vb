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

Public Class Mail

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region

    Dim _textoCuerpo As String
    Dim _correoEnvio As String
    Dim _passCorreoEnvio As String
    Dim _servidorCorreo As String

#Region "envio del correo"

    Public Property textoCuerpo() As String
        Get
            Return _textoCuerpo
        End Get
        Set(ByVal value As String)
            _textoCuerpo = value
        End Set
    End Property

    Public Property correoEnvio() As String
        Get
            Return _correoEnvio
        End Get
        Set(ByVal value As String)
            _correoEnvio = value
        End Set
    End Property

    Public Property passCorreoEnvio() As String
        Get
            Return _passCorreoEnvio
        End Get
        Set(ByVal value As String)
            _passCorreoEnvio = value
        End Set
    End Property

    Public Property servidorCorreo() As String
        Get
            Return _servidorCorreo
        End Get
        Set(ByVal value As String)
            _servidorCorreo = value
        End Set
    End Property


    Public Function buscarDatosMails() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from DatosCorreo"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Shared Function EnviarCorreo(ByVal CuentaCorreoEnvio As String,
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

            ' If Me.iTipo <> Constantes.TipoCorreo.Boletin Then
            'i = 0
            'While i < DireccionesEmail.Count
            miMail.To.Add(New MailAddress(DireccionesEmail))
            '    i = i + 1
            'End While

            i = 0
            'While i < DireccionEmailCopia.Count
            'miMail.CC.Add(New MailAddress(DireccionEmailCopia))
            '    i = i + 1
            'End While

            i = 0
            'While i < DireccionEmailCopiaOculta.Count
            ' miMail.Bcc.Add(New MailAddress(DireccionEmailCopiaOculta))
            '    i = i + 1
            'End While

            miMail.Subject = Asunto
            miMail.IsBodyHtml = True
            miMail.Body = Cuerpo

            i = 0
            'While i < RutaFichero.Count
            miRecurso = New Attachment(RutaFichero)
            miMail.Attachments.Add(miRecurso)
            '    i = i + 1
            'End While

            smtp.Port = PuertoSMTP
            smtp.Timeout = 30000
            smtp.Host = ServidorSMTP  ' Config.ServidorSMTP
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential(LCase(CuentaCorreoEnvio), ClaveCorreoEnvio)
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network

            EnviarCorreo = True

            ServicePointManager.ServerCertificateValidationCallback = Function(s As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) True

            smtp.Send(miMail)

            If MostrarMensajeOK Then
                MessageBox.Show("Mensaje enviado correctamente", "Administrador",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            EnviarCorreo = False

            If MostrarMensajeOK Then
                MessageBox.Show("ERROR " & ex.Message, "ADMINISTRADOR",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Finally
            miMail.Dispose()
        End Try
    End Function

    Public Shared Function ExportToPDF(rpt As ReportDocument, NombreArchivo As String, asunto As String, mail As String) As String
        Dim vFileName As String = Nothing
        Dim diskOpts As New DiskFileDestinationOptions()
        Dim DireccionesEmail As String = Nothing
        Dim objMail As New Mail
        Try
            If mail = "" Then
                DireccionesEmail = InputBox("Ingrese dirección de correo electrónico de destino", "Registro de Mail", "")
            Else
                DireccionesEmail = mail
            End If


            If String.IsNullOrEmpty(DireccionesEmail) Then
                MsgBox("Envío de mail cancelado")
                Exit Function

            End If


            rpt.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
            rpt.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat

            'Este es la ruta donde se guardara tu archivo.
            'vFileName = "c:\comprobantes\" & NombreArchivo
            vFileName = My.Computer.FileSystem.CurrentDirectory & "\" & NombreArchivo
            If File.Exists(vFileName) Then
                File.Delete(vFileName)
            End If
            diskOpts.DiskFileName = vFileName
            rpt.ExportOptions.DestinationOptions = diskOpts
            rpt.Export()

            Dim odatasetMail As New DataSet
            odatasetMail = objMail.buscarDatosMails()
            objMail.correoEnvio = odatasetMail.Tables(0).Rows(0).Item("mail")
            objMail.passCorreoEnvio = odatasetMail.Tables(0).Rows(0).Item("pass")
            objMail.servidorCorreo = odatasetMail.Tables(0).Rows(0).Item("servidor")
            EnviarCorreo(objMail.correoEnvio, objMail.passCorreoEnvio, objMail.servidorCorreo, 25, DireccionesEmail, asunto, "Estimado adjunto " & asunto & "<br><br><br>Un servicio de DELCOM SISTEMAS", vFileName, True, "DELCOM SISTEMAS", False)
        Catch ex As Exception
            Throw ex
        End Try

        File.Delete(vFileName)
        Return vFileName
    End Function
#End Region

#Region "log Sincronización"

    Dim _fechaSincronizacion As Date
    Dim _usuarioSincronizacion As String
    Dim _idSincronizacion As Integer
    Dim _correoSincronizacion As String
    Dim _eventoSincronizacion As String

    Public Property fechaSincronizacion() As Date
        Get
            Return _fechaSincronizacion
        End Get
        Set(value As Date)
            value = _fechaSincronizacion
        End Set
    End Property

    Public Property usuarioSincronizacion As String
        Get
            Return _usuarioSincronizacion
        End Get
        Set(value As String)
            value = _usuarioSincronizacion
        End Set
    End Property

    Public Property idSincronizacion As Integer
        Get
            Return _idSincronizacion
        End Get
        Set(value As Integer)
            value = _idSincronizacion
        End Set
    End Property

    Public Property correoSincronizacion As String
        Get
            Return _correoSincronizacion
        End Get
        Set(value As String)
            value = _correoSincronizacion
        End Set
    End Property

    Public Property eventoSincronizacion As String
        Get
            Return _eventoSincronizacion
        End Get
        Set(value As String)
            value = _eventoSincronizacion
        End Set
    End Property

    Public Sub registrarLog(ByRef objMail As Mail)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into LogMail (fechaSincronizacion,ususarioSincronizacion,correoSincronizacion, eventoSincronizacion) Values (" & objMail.fechaSincronizacion & ",'" & objMail.usuarioSincronizacion & "','" & objMail.correoSincronizacion & "','" & objMail.eventoSincronizacion & "')"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el registro")
            Exit Sub
        End Try
        'MsgBox("Se registró nuevo Articulo con Exito!")
    End Sub

#End Region

End Class
