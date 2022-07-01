<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagos))
        Me.tssBarraVentas = New System.Windows.Forms.ToolStrip()
        Me.tssNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tssBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tssModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssCerrar = New System.Windows.Forms.ToolStripButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEditarMedioPago = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboCondVenta = New System.Windows.Forms.ComboBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtReciboNumero = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRazonSocialCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.tssBarraVentas.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tssBarraVentas
        '
        Me.tssBarraVentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssNuevo, Me.tssBorrar, Me.tssModificar, Me.ToolStripSeparator2, Me.tssConsultar, Me.ToolStripSeparator1, Me.tssCerrar})
        Me.tssBarraVentas.Location = New System.Drawing.Point(0, 0)
        Me.tssBarraVentas.Name = "tssBarraVentas"
        Me.tssBarraVentas.Size = New System.Drawing.Size(375, 38)
        Me.tssBarraVentas.TabIndex = 48
        Me.tssBarraVentas.Text = "ToolStrip1"
        '
        'tssNuevo
        '
        Me.tssNuevo.Image = CType(resources.GetObject("tssNuevo.Image"), System.Drawing.Image)
        Me.tssNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssNuevo.Name = "tssNuevo"
        Me.tssNuevo.Size = New System.Drawing.Size(46, 35)
        Me.tssNuevo.Text = "Nuevo"
        Me.tssNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tssNuevo.ToolTipText = "Nuevo"
        Me.tssNuevo.Visible = False
        '
        'tssBorrar
        '
        Me.tssBorrar.Image = CType(resources.GetObject("tssBorrar.Image"), System.Drawing.Image)
        Me.tssBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssBorrar.Name = "tssBorrar"
        Me.tssBorrar.Size = New System.Drawing.Size(43, 35)
        Me.tssBorrar.Text = "Borrar"
        Me.tssBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tssBorrar.ToolTipText = "Borrar"
        '
        'tssModificar
        '
        Me.tssModificar.Image = CType(resources.GetObject("tssModificar.Image"), System.Drawing.Image)
        Me.tssModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssModificar.Name = "tssModificar"
        Me.tssModificar.Size = New System.Drawing.Size(62, 35)
        Me.tssModificar.Text = "Modificar"
        Me.tssModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tssModificar.ToolTipText = "Modificar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'tssConsultar
        '
        Me.tssConsultar.Image = CType(resources.GetObject("tssConsultar.Image"), System.Drawing.Image)
        Me.tssConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssConsultar.Name = "tssConsultar"
        Me.tssConsultar.Size = New System.Drawing.Size(62, 35)
        Me.tssConsultar.Text = "Consultar"
        Me.tssConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tssConsultar.ToolTipText = "Consultar"
        Me.tssConsultar.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        Me.ToolStripSeparator1.Visible = False
        '
        'tssCerrar
        '
        Me.tssCerrar.Image = CType(resources.GetObject("tssCerrar.Image"), System.Drawing.Image)
        Me.tssCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssCerrar.Name = "tssCerrar"
        Me.tssCerrar.Size = New System.Drawing.Size(43, 35)
        Me.tssCerrar.Text = "Cerrar"
        Me.tssCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnImprimir)
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 299)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(375, 43)
        Me.Panel3.TabIndex = 47
        '
        'btnImprimir
        '
        Me.btnImprimir.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(70, 4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 30)
        Me.btnImprimir.TabIndex = 28
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(149, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 30)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(229, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 30)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "Pagar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEditarMedioPago)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.cboCondVenta)
        Me.GroupBox2.Controls.Add(Me.txtImporte)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 88)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        '
        'btnEditarMedioPago
        '
        Me.btnEditarMedioPago.Image = CType(resources.GetObject("btnEditarMedioPago.Image"), System.Drawing.Image)
        Me.btnEditarMedioPago.Location = New System.Drawing.Point(300, 16)
        Me.btnEditarMedioPago.Name = "btnEditarMedioPago"
        Me.btnEditarMedioPago.Size = New System.Drawing.Size(28, 23)
        Me.btnEditarMedioPago.TabIndex = 59
        Me.btnEditarMedioPago.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(6, 17)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(97, 20)
        Me.Label27.TabIndex = 58
        Me.Label27.Text = "Cond. Venta:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboCondVenta
        '
        Me.cboCondVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondVenta.FormattingEnabled = True
        Me.cboCondVenta.Location = New System.Drawing.Point(109, 17)
        Me.cboCondVenta.Name = "cboCondVenta"
        Me.cboCondVenta.Size = New System.Drawing.Size(185, 21)
        Me.cboCondVenta.TabIndex = 57
        '
        'txtImporte
        '
        Me.txtImporte.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(109, 47)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(105, 20)
        Me.txtImporte.TabIndex = 1
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Importe $:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.txtReciboNumero)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpFechaAlta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocialCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 83)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.AutoSize = True
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(300, 42)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(28, 22)
        Me.btnBuscarCliente.TabIndex = 24
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        Me.btnBuscarCliente.Visible = False
        '
        'txtReciboNumero
        '
        Me.txtReciboNumero.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtReciboNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReciboNumero.Location = New System.Drawing.Point(220, 18)
        Me.txtReciboNumero.Mask = "9999 - 99999999"
        Me.txtReciboNumero.Name = "txtReciboNumero"
        Me.txtReciboNumero.ReadOnly = True
        Me.txtReciboNumero.Size = New System.Drawing.Size(108, 20)
        Me.txtReciboNumero.TabIndex = 23
        Me.txtReciboNumero.TabStop = False
        Me.txtReciboNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(159, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "R. N°:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaAlta
        '
        Me.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAlta.Location = New System.Drawing.Point(68, 18)
        Me.dtpFechaAlta.Name = "dtpFechaAlta"
        Me.dtpFechaAlta.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaAlta.TabIndex = 21
        Me.dtpFechaAlta.TabStop = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Fecha:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRazonSocialCliente
        '
        Me.txtRazonSocialCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtRazonSocialCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocialCliente.Location = New System.Drawing.Point(68, 44)
        Me.txtRazonSocialCliente.Name = "txtRazonSocialCliente"
        Me.txtRazonSocialCliente.ReadOnly = True
        Me.txtRazonSocialCliente.Size = New System.Drawing.Size(260, 20)
        Me.txtRazonSocialCliente.TabIndex = 19
        Me.txtRazonSocialCliente.TabStop = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(9, 203)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 13)
        Me.lblMensaje.TabIndex = 49
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(12, 222)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ReadOnly = True
        Me.txtObservaciones.Size = New System.Drawing.Size(347, 71)
        Me.txtObservaciones.TabIndex = 50
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 342)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.tssBarraVentas)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Pagos"
        Me.tssBarraVentas.ResumeLayout(False)
        Me.tssBarraVentas.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tssBarraVentas As ToolStrip
    Friend WithEvents tssNuevo As ToolStripButton
    Friend WithEvents tssBorrar As ToolStripButton
    Friend WithEvents tssModificar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tssConsultar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tssCerrar As ToolStripButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtReciboNumero As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFechaAlta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRazonSocialCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMensaje As Label
    Friend WithEvents btnEditarMedioPago As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents cboCondVenta As ComboBox
    Friend WithEvents txtObservaciones As TextBox
End Class
