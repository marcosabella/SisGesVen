<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRespaldoBD
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRespaldoBD))
        Me.lblPath = New System.Windows.Forms.Label()
        Me.btnRespaldo = New System.Windows.Forms.Button()
        Me.btnEditMail = New System.Windows.Forms.Button()
        Me.txtMailEnvio = New System.Windows.Forms.TextBox()
        Me.barra = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(12, 117)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(39, 13)
        Me.lblPath.TabIndex = 0
        Me.lblPath.Text = "Label1"
        Me.lblPath.Visible = False
        '
        'btnRespaldo
        '
        Me.btnRespaldo.Image = CType(resources.GetObject("btnRespaldo.Image"), System.Drawing.Image)
        Me.btnRespaldo.Location = New System.Drawing.Point(15, 58)
        Me.btnRespaldo.Name = "btnRespaldo"
        Me.btnRespaldo.Size = New System.Drawing.Size(275, 29)
        Me.btnRespaldo.TabIndex = 1
        Me.btnRespaldo.Text = "RESPALDAR BASE DE DATOS"
        Me.btnRespaldo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRespaldo.UseMnemonic = False
        Me.btnRespaldo.UseVisualStyleBackColor = False
        '
        'btnEditMail
        '
        Me.btnEditMail.Image = CType(resources.GetObject("btnEditMail.Image"), System.Drawing.Image)
        Me.btnEditMail.Location = New System.Drawing.Point(254, 30)
        Me.btnEditMail.Name = "btnEditMail"
        Me.btnEditMail.Size = New System.Drawing.Size(29, 23)
        Me.btnEditMail.TabIndex = 50
        Me.btnEditMail.UseVisualStyleBackColor = True
        '
        'txtMailEnvio
        '
        Me.txtMailEnvio.Location = New System.Drawing.Point(15, 32)
        Me.txtMailEnvio.Name = "txtMailEnvio"
        Me.txtMailEnvio.Size = New System.Drawing.Size(233, 20)
        Me.txtMailEnvio.TabIndex = 51
        '
        'barra
        '
        Me.barra.Location = New System.Drawing.Point(15, 93)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(275, 17)
        Me.barra.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Ingrese e-mail de respaldo:"
        '
        'frmRespaldoBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 129)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.btnRespaldo)
        Me.Controls.Add(Me.txtMailEnvio)
        Me.Controls.Add(Me.btnEditMail)
        Me.Controls.Add(Me.lblPath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRespaldoBD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Respaldo Base de Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPath As Label
    Friend WithEvents btnRespaldo As Button
    Friend WithEvents btnEditMail As Button
    Friend WithEvents txtMailEnvio As TextBox
    Friend WithEvents barra As ProgressBar
    Friend WithEvents Label1 As Label
End Class
