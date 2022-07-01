<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenTrabajo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenTrabajo))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tssBarraVentas = New System.Windows.Forms.ToolStrip()
        Me.tssNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tssBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tssModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssCerrar = New System.Windows.Forms.ToolStripButton()
        Me.txtRazonSocialCliente = New System.Windows.Forms.TextBox()
        Me.txtOrdenNumero = New System.Windows.Forms.MaskedTextBox()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaRecepcion = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.dtpFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaReceta = New System.Windows.Forms.DateTimePicker()
        Me.txtDr = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCercaOI = New System.Windows.Forms.TextBox()
        Me.txtCercaOD = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLejosOI = New System.Windows.Forms.TextBox()
        Me.txtLejosOD = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarCristalesCerca = New System.Windows.Forms.Button()
        Me.btnLimpiarCristalesLejos = New System.Windows.Forms.Button()
        Me.txtCodigoCristalCerca = New System.Windows.Forms.TextBox()
        Me.txtCodigoCristalLejos = New System.Windows.Forms.TextBox()
        Me.btnBuscarCristalesCerca = New System.Windows.Forms.Button()
        Me.btnBuscarCristalesLejos = New System.Windows.Forms.Button()
        Me.txtPrecioCristalCerca = New System.Windows.Forms.TextBox()
        Me.txtDescripcionCristalCerca = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPrecioCristalLejos = New System.Windows.Forms.TextBox()
        Me.txtDescripcionCristalLejos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarArmazonCerca = New System.Windows.Forms.Button()
        Me.btnLimpiarArmazonLejos = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnbuscarModeloCerca = New System.Windows.Forms.Button()
        Me.btnBuscarModeloLejos = New System.Windows.Forms.Button()
        Me.txtPrecioArmazonCerca = New System.Windows.Forms.TextBox()
        Me.txtModeloCerca = New System.Windows.Forms.TextBox()
        Me.txtPrecioArmazonLejos = New System.Windows.Forms.TextBox()
        Me.txtModeloLejos = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtMarcaCerca = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMarcaLejos = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnLimparReparaciones = New System.Windows.Forms.Button()
        Me.btnBuscarReparaciones = New System.Windows.Forms.Button()
        Me.txtPrecioReparaciones = New System.Windows.Forms.TextBox()
        Me.txtReparaciones = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarOS = New System.Windows.Forms.Button()
        Me.txtObraSocial = New System.Windows.Forms.TextBox()
        Me.btnBuscarObraSocial = New System.Windows.Forms.Button()
        Me.cboDescOS = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtTotalDescOS = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cboTipoTarjeta = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtNroCupon = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboCondVenta = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.alerta = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel3.SuspendLayout()
        Me.tssBarraVentas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.alerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnImprimir)
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 544)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(877, 43)
        Me.Panel3.TabIndex = 49
        '
        'btnImprimir
        '
        Me.btnImprimir.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(534, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(106, 30)
        Me.btnImprimir.TabIndex = 27
        Me.btnImprimir.Text = "Imprimir Orden"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(646, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(106, 30)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(758, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(106, 30)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'tssBarraVentas
        '
        Me.tssBarraVentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssNuevo, Me.tssBorrar, Me.tssModificar, Me.ToolStripSeparator2, Me.tssConsultar, Me.ToolStripSeparator1, Me.tssCerrar})
        Me.tssBarraVentas.Location = New System.Drawing.Point(0, 0)
        Me.tssBarraVentas.Name = "tssBarraVentas"
        Me.tssBarraVentas.Size = New System.Drawing.Size(877, 38)
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
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
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
        'txtRazonSocialCliente
        '
        Me.txtRazonSocialCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtRazonSocialCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocialCliente.Location = New System.Drawing.Point(232, 39)
        Me.txtRazonSocialCliente.Name = "txtRazonSocialCliente"
        Me.txtRazonSocialCliente.ReadOnly = True
        Me.txtRazonSocialCliente.Size = New System.Drawing.Size(281, 20)
        Me.txtRazonSocialCliente.TabIndex = 19
        Me.txtRazonSocialCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOrdenNumero
        '
        Me.txtOrdenNumero.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtOrdenNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenNumero.Location = New System.Drawing.Point(516, 14)
        Me.txtOrdenNumero.Name = "txtOrdenNumero"
        Me.txtOrdenNumero.ReadOnly = True
        Me.txtOrdenNumero.Size = New System.Drawing.Size(62, 20)
        Me.txtOrdenNumero.TabIndex = 17
        Me.txtOrdenNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.AutoSize = True
        Me.btnNuevoCliente.Image = CType(resources.GetObject("btnNuevoCliente.Image"), System.Drawing.Image)
        Me.btnNuevoCliente.Location = New System.Drawing.Point(516, 38)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(28, 22)
        Me.btnNuevoCliente.TabIndex = 16
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.AutoSize = True
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(550, 38)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(28, 22)
        Me.btnBuscarCliente.TabIndex = 15
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(455, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "O. N°:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(232, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha Entrega:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaRecepcion
        '
        Me.dtpFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRecepcion.Location = New System.Drawing.Point(141, 14)
        Me.dtpFechaRecepcion.Name = "dtpFechaRecepcion"
        Me.dtpFechaRecepcion.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaRecepcion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Recepción:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.dtpFechaEntrega)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocialCliente)
        Me.GroupBox1.Controls.Add(Me.txtOrdenNumero)
        Me.GroupBox1.Controls.Add(Me.btnNuevoCliente)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFechaRecepcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 75)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCliente.Location = New System.Drawing.Point(141, 39)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(85, 20)
        Me.txtCodCliente.TabIndex = 22
        Me.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFechaEntrega
        '
        Me.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEntrega.Location = New System.Drawing.Point(364, 14)
        Me.dtpFechaEntrega.Name = "dtpFechaEntrega"
        Me.dtpFechaEntrega.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaEntrega.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpFechaReceta)
        Me.GroupBox2.Controls.Add(Me.txtDr)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCercaOI)
        Me.GroupBox2.Controls.Add(Me.txtCercaOD)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtLejosOI)
        Me.GroupBox2.Controls.Add(Me.txtLejosOD)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 123)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'dtpFechaReceta
        '
        Me.dtpFechaReceta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaReceta.Location = New System.Drawing.Point(364, 91)
        Me.dtpFechaReceta.Name = "dtpFechaReceta"
        Me.dtpFechaReceta.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaReceta.TabIndex = 22
        '
        'txtDr
        '
        Me.txtDr.Location = New System.Drawing.Point(58, 91)
        Me.txtDr.Name = "txtDr"
        Me.txtDr.Size = New System.Drawing.Size(226, 20)
        Me.txtDr.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(290, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 20)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Fecha:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Dr:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCercaOI
        '
        Me.txtCercaOI.Location = New System.Drawing.Point(184, 63)
        Me.txtCercaOI.Name = "txtCercaOI"
        Me.txtCercaOI.Size = New System.Drawing.Size(100, 20)
        Me.txtCercaOI.TabIndex = 12
        '
        'txtCercaOD
        '
        Me.txtCercaOD.Location = New System.Drawing.Point(184, 34)
        Me.txtCercaOD.Name = "txtCercaOD"
        Me.txtCercaOD.Size = New System.Drawing.Size(100, 20)
        Me.txtCercaOD.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(152, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "OI:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(152, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "OD:"
        '
        'txtLejosOI
        '
        Me.txtLejosOI.Location = New System.Drawing.Point(58, 63)
        Me.txtLejosOI.Name = "txtLejosOI"
        Me.txtLejosOI.Size = New System.Drawing.Size(88, 20)
        Me.txtLejosOI.TabIndex = 8
        '
        'txtLejosOD
        '
        Me.txtLejosOD.Location = New System.Drawing.Point(58, 34)
        Me.txtLejosOD.Name = "txtLejosOD"
        Me.txtLejosOD.Size = New System.Drawing.Size(88, 20)
        Me.txtLejosOD.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(149, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Cerca:"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 14)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "OI:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 14)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "OD:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lejos:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnLimpiarCristalesCerca)
        Me.GroupBox3.Controls.Add(Me.btnLimpiarCristalesLejos)
        Me.GroupBox3.Controls.Add(Me.txtCodigoCristalCerca)
        Me.GroupBox3.Controls.Add(Me.txtCodigoCristalLejos)
        Me.GroupBox3.Controls.Add(Me.btnBuscarCristalesCerca)
        Me.GroupBox3.Controls.Add(Me.btnBuscarCristalesLejos)
        Me.GroupBox3.Controls.Add(Me.txtPrecioCristalCerca)
        Me.GroupBox3.Controls.Add(Me.txtDescripcionCristalCerca)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtPrecioCristalLejos)
        Me.GroupBox3.Controls.Add(Me.txtDescripcionCristalLejos)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 251)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(642, 83)
        Me.GroupBox3.TabIndex = 52
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Descripción cristales"
        '
        'btnLimpiarCristalesCerca
        '
        Me.btnLimpiarCristalesCerca.AutoSize = True
        Me.btnLimpiarCristalesCerca.Image = CType(resources.GetObject("btnLimpiarCristalesCerca.Image"), System.Drawing.Image)
        Me.btnLimpiarCristalesCerca.Location = New System.Drawing.Point(516, 44)
        Me.btnLimpiarCristalesCerca.Name = "btnLimpiarCristalesCerca"
        Me.btnLimpiarCristalesCerca.Size = New System.Drawing.Size(28, 22)
        Me.btnLimpiarCristalesCerca.TabIndex = 30
        Me.btnLimpiarCristalesCerca.UseVisualStyleBackColor = True
        '
        'btnLimpiarCristalesLejos
        '
        Me.btnLimpiarCristalesLejos.AutoSize = True
        Me.btnLimpiarCristalesLejos.Image = CType(resources.GetObject("btnLimpiarCristalesLejos.Image"), System.Drawing.Image)
        Me.btnLimpiarCristalesLejos.Location = New System.Drawing.Point(516, 18)
        Me.btnLimpiarCristalesLejos.Name = "btnLimpiarCristalesLejos"
        Me.btnLimpiarCristalesLejos.Size = New System.Drawing.Size(28, 22)
        Me.btnLimpiarCristalesLejos.TabIndex = 29
        Me.btnLimpiarCristalesLejos.UseVisualStyleBackColor = True
        '
        'txtCodigoCristalCerca
        '
        Me.txtCodigoCristalCerca.Location = New System.Drawing.Point(58, 45)
        Me.txtCodigoCristalCerca.Name = "txtCodigoCristalCerca"
        Me.txtCodigoCristalCerca.Size = New System.Drawing.Size(88, 20)
        Me.txtCodigoCristalCerca.TabIndex = 28
        '
        'txtCodigoCristalLejos
        '
        Me.txtCodigoCristalLejos.Location = New System.Drawing.Point(58, 20)
        Me.txtCodigoCristalLejos.Name = "txtCodigoCristalLejos"
        Me.txtCodigoCristalLejos.Size = New System.Drawing.Size(88, 20)
        Me.txtCodigoCristalLejos.TabIndex = 27
        '
        'btnBuscarCristalesCerca
        '
        Me.btnBuscarCristalesCerca.AutoSize = True
        Me.btnBuscarCristalesCerca.Image = CType(resources.GetObject("btnBuscarCristalesCerca.Image"), System.Drawing.Image)
        Me.btnBuscarCristalesCerca.Location = New System.Drawing.Point(550, 44)
        Me.btnBuscarCristalesCerca.Name = "btnBuscarCristalesCerca"
        Me.btnBuscarCristalesCerca.Size = New System.Drawing.Size(28, 22)
        Me.btnBuscarCristalesCerca.TabIndex = 26
        Me.btnBuscarCristalesCerca.UseVisualStyleBackColor = True
        '
        'btnBuscarCristalesLejos
        '
        Me.btnBuscarCristalesLejos.AutoSize = True
        Me.btnBuscarCristalesLejos.Image = CType(resources.GetObject("btnBuscarCristalesLejos.Image"), System.Drawing.Image)
        Me.btnBuscarCristalesLejos.Location = New System.Drawing.Point(550, 18)
        Me.btnBuscarCristalesLejos.Name = "btnBuscarCristalesLejos"
        Me.btnBuscarCristalesLejos.Size = New System.Drawing.Size(28, 22)
        Me.btnBuscarCristalesLejos.TabIndex = 25
        Me.btnBuscarCristalesLejos.UseVisualStyleBackColor = True
        '
        'txtPrecioCristalCerca
        '
        Me.txtPrecioCristalCerca.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtPrecioCristalCerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioCristalCerca.Location = New System.Drawing.Point(580, 45)
        Me.txtPrecioCristalCerca.Name = "txtPrecioCristalCerca"
        Me.txtPrecioCristalCerca.ReadOnly = True
        Me.txtPrecioCristalCerca.Size = New System.Drawing.Size(54, 20)
        Me.txtPrecioCristalCerca.TabIndex = 24
        Me.txtPrecioCristalCerca.Text = "0"
        Me.txtPrecioCristalCerca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescripcionCristalCerca
        '
        Me.txtDescripcionCristalCerca.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtDescripcionCristalCerca.Location = New System.Drawing.Point(152, 45)
        Me.txtDescripcionCristalCerca.Name = "txtDescripcionCristalCerca"
        Me.txtDescripcionCristalCerca.ReadOnly = True
        Me.txtDescripcionCristalCerca.Size = New System.Drawing.Size(361, 20)
        Me.txtDescripcionCristalCerca.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 15)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Cerca:"
        '
        'txtPrecioCristalLejos
        '
        Me.txtPrecioCristalLejos.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtPrecioCristalLejos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioCristalLejos.Location = New System.Drawing.Point(580, 19)
        Me.txtPrecioCristalLejos.Name = "txtPrecioCristalLejos"
        Me.txtPrecioCristalLejos.ReadOnly = True
        Me.txtPrecioCristalLejos.Size = New System.Drawing.Size(54, 20)
        Me.txtPrecioCristalLejos.TabIndex = 21
        Me.txtPrecioCristalLejos.Text = "0"
        Me.txtPrecioCristalLejos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescripcionCristalLejos
        '
        Me.txtDescripcionCristalLejos.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtDescripcionCristalLejos.Location = New System.Drawing.Point(152, 19)
        Me.txtDescripcionCristalLejos.Name = "txtDescripcionCristalLejos"
        Me.txtDescripcionCristalLejos.ReadOnly = True
        Me.txtDescripcionCristalLejos.Size = New System.Drawing.Size(361, 20)
        Me.txtDescripcionCristalLejos.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Lejos:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnLimpiarArmazonCerca)
        Me.GroupBox4.Controls.Add(Me.btnLimpiarArmazonLejos)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.btnbuscarModeloCerca)
        Me.GroupBox4.Controls.Add(Me.btnBuscarModeloLejos)
        Me.GroupBox4.Controls.Add(Me.txtPrecioArmazonCerca)
        Me.GroupBox4.Controls.Add(Me.txtModeloCerca)
        Me.GroupBox4.Controls.Add(Me.txtPrecioArmazonLejos)
        Me.GroupBox4.Controls.Add(Me.txtModeloLejos)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtMarcaCerca)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtMarcaLejos)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 340)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(642, 85)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Descripción armazones"
        '
        'btnLimpiarArmazonCerca
        '
        Me.btnLimpiarArmazonCerca.AutoSize = True
        Me.btnLimpiarArmazonCerca.Image = CType(resources.GetObject("btnLimpiarArmazonCerca.Image"), System.Drawing.Image)
        Me.btnLimpiarArmazonCerca.Location = New System.Drawing.Point(516, 45)
        Me.btnLimpiarArmazonCerca.Name = "btnLimpiarArmazonCerca"
        Me.btnLimpiarArmazonCerca.Size = New System.Drawing.Size(28, 22)
        Me.btnLimpiarArmazonCerca.TabIndex = 44
        Me.btnLimpiarArmazonCerca.UseVisualStyleBackColor = True
        '
        'btnLimpiarArmazonLejos
        '
        Me.btnLimpiarArmazonLejos.AutoSize = True
        Me.btnLimpiarArmazonLejos.Image = CType(resources.GetObject("btnLimpiarArmazonLejos.Image"), System.Drawing.Image)
        Me.btnLimpiarArmazonLejos.Location = New System.Drawing.Point(516, 19)
        Me.btnLimpiarArmazonLejos.Name = "btnLimpiarArmazonLejos"
        Me.btnLimpiarArmazonLejos.Size = New System.Drawing.Size(28, 22)
        Me.btnLimpiarArmazonLejos.TabIndex = 43
        Me.btnLimpiarArmazonLejos.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(290, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 20)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Modelo:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(290, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 20)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Modelo:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnbuscarModeloCerca
        '
        Me.btnbuscarModeloCerca.AutoSize = True
        Me.btnbuscarModeloCerca.Image = CType(resources.GetObject("btnbuscarModeloCerca.Image"), System.Drawing.Image)
        Me.btnbuscarModeloCerca.Location = New System.Drawing.Point(550, 46)
        Me.btnbuscarModeloCerca.Name = "btnbuscarModeloCerca"
        Me.btnbuscarModeloCerca.Size = New System.Drawing.Size(28, 22)
        Me.btnbuscarModeloCerca.TabIndex = 40
        Me.btnbuscarModeloCerca.UseVisualStyleBackColor = True
        '
        'btnBuscarModeloLejos
        '
        Me.btnBuscarModeloLejos.AutoSize = True
        Me.btnBuscarModeloLejos.Image = CType(resources.GetObject("btnBuscarModeloLejos.Image"), System.Drawing.Image)
        Me.btnBuscarModeloLejos.Location = New System.Drawing.Point(550, 20)
        Me.btnBuscarModeloLejos.Name = "btnBuscarModeloLejos"
        Me.btnBuscarModeloLejos.Size = New System.Drawing.Size(28, 22)
        Me.btnBuscarModeloLejos.TabIndex = 39
        Me.btnBuscarModeloLejos.UseVisualStyleBackColor = True
        '
        'txtPrecioArmazonCerca
        '
        Me.txtPrecioArmazonCerca.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtPrecioArmazonCerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioArmazonCerca.Location = New System.Drawing.Point(580, 47)
        Me.txtPrecioArmazonCerca.Name = "txtPrecioArmazonCerca"
        Me.txtPrecioArmazonCerca.ReadOnly = True
        Me.txtPrecioArmazonCerca.Size = New System.Drawing.Size(54, 20)
        Me.txtPrecioArmazonCerca.TabIndex = 36
        Me.txtPrecioArmazonCerca.Text = "0"
        Me.txtPrecioArmazonCerca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtModeloCerca
        '
        Me.txtModeloCerca.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtModeloCerca.Location = New System.Drawing.Point(364, 47)
        Me.txtModeloCerca.Name = "txtModeloCerca"
        Me.txtModeloCerca.ReadOnly = True
        Me.txtModeloCerca.Size = New System.Drawing.Size(149, 20)
        Me.txtModeloCerca.TabIndex = 35
        '
        'txtPrecioArmazonLejos
        '
        Me.txtPrecioArmazonLejos.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtPrecioArmazonLejos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioArmazonLejos.Location = New System.Drawing.Point(580, 21)
        Me.txtPrecioArmazonLejos.Name = "txtPrecioArmazonLejos"
        Me.txtPrecioArmazonLejos.ReadOnly = True
        Me.txtPrecioArmazonLejos.Size = New System.Drawing.Size(54, 20)
        Me.txtPrecioArmazonLejos.TabIndex = 34
        Me.txtPrecioArmazonLejos.Text = "0"
        Me.txtPrecioArmazonLejos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtModeloLejos
        '
        Me.txtModeloLejos.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtModeloLejos.Location = New System.Drawing.Point(364, 21)
        Me.txtModeloLejos.Name = "txtModeloLejos"
        Me.txtModeloLejos.ReadOnly = True
        Me.txtModeloLejos.Size = New System.Drawing.Size(149, 20)
        Me.txtModeloLejos.TabIndex = 33
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(60, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 15)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Marca"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(60, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 15)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Marca"
        '
        'txtMarcaCerca
        '
        Me.txtMarcaCerca.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtMarcaCerca.Location = New System.Drawing.Point(110, 47)
        Me.txtMarcaCerca.Name = "txtMarcaCerca"
        Me.txtMarcaCerca.ReadOnly = True
        Me.txtMarcaCerca.Size = New System.Drawing.Size(174, 20)
        Me.txtMarcaCerca.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 15)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Cerca:"
        '
        'txtMarcaLejos
        '
        Me.txtMarcaLejos.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtMarcaLejos.Location = New System.Drawing.Point(110, 21)
        Me.txtMarcaLejos.Name = "txtMarcaLejos"
        Me.txtMarcaLejos.ReadOnly = True
        Me.txtMarcaLejos.Size = New System.Drawing.Size(174, 20)
        Me.txtMarcaLejos.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(11, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 15)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Lejos:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnLimparReparaciones)
        Me.GroupBox5.Controls.Add(Me.btnBuscarReparaciones)
        Me.GroupBox5.Controls.Add(Me.txtPrecioReparaciones)
        Me.GroupBox5.Controls.Add(Me.txtReparaciones)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 431)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(641, 49)
        Me.GroupBox5.TabIndex = 54
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Reparaciones"
        '
        'btnLimparReparaciones
        '
        Me.btnLimparReparaciones.AutoSize = True
        Me.btnLimparReparaciones.Image = CType(resources.GetObject("btnLimparReparaciones.Image"), System.Drawing.Image)
        Me.btnLimparReparaciones.Location = New System.Drawing.Point(516, 18)
        Me.btnLimparReparaciones.Name = "btnLimparReparaciones"
        Me.btnLimparReparaciones.Size = New System.Drawing.Size(28, 22)
        Me.btnLimparReparaciones.TabIndex = 57
        Me.btnLimparReparaciones.UseVisualStyleBackColor = True
        '
        'btnBuscarReparaciones
        '
        Me.btnBuscarReparaciones.AutoSize = True
        Me.btnBuscarReparaciones.Image = CType(resources.GetObject("btnBuscarReparaciones.Image"), System.Drawing.Image)
        Me.btnBuscarReparaciones.Location = New System.Drawing.Point(550, 18)
        Me.btnBuscarReparaciones.Name = "btnBuscarReparaciones"
        Me.btnBuscarReparaciones.Size = New System.Drawing.Size(28, 22)
        Me.btnBuscarReparaciones.TabIndex = 41
        Me.btnBuscarReparaciones.UseVisualStyleBackColor = True
        '
        'txtPrecioReparaciones
        '
        Me.txtPrecioReparaciones.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtPrecioReparaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioReparaciones.Location = New System.Drawing.Point(580, 19)
        Me.txtPrecioReparaciones.Name = "txtPrecioReparaciones"
        Me.txtPrecioReparaciones.ReadOnly = True
        Me.txtPrecioReparaciones.Size = New System.Drawing.Size(54, 20)
        Me.txtPrecioReparaciones.TabIndex = 26
        Me.txtPrecioReparaciones.Text = "0"
        Me.txtPrecioReparaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReparaciones
        '
        Me.txtReparaciones.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtReparaciones.Location = New System.Drawing.Point(11, 19)
        Me.txtReparaciones.Name = "txtReparaciones"
        Me.txtReparaciones.ReadOnly = True
        Me.txtReparaciones.Size = New System.Drawing.Size(502, 20)
        Me.txtReparaciones.TabIndex = 25
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnLimpiarOS)
        Me.GroupBox6.Controls.Add(Me.txtObraSocial)
        Me.GroupBox6.Controls.Add(Me.btnBuscarObraSocial)
        Me.GroupBox6.Controls.Add(Me.cboDescOS)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 486)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(641, 49)
        Me.GroupBox6.TabIndex = 55
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Obra Social"
        '
        'btnLimpiarOS
        '
        Me.btnLimpiarOS.AutoSize = True
        Me.btnLimpiarOS.Image = CType(resources.GetObject("btnLimpiarOS.Image"), System.Drawing.Image)
        Me.btnLimpiarOS.Location = New System.Drawing.Point(389, 15)
        Me.btnLimpiarOS.Name = "btnLimpiarOS"
        Me.btnLimpiarOS.Size = New System.Drawing.Size(28, 22)
        Me.btnLimpiarOS.TabIndex = 58
        Me.btnLimpiarOS.UseVisualStyleBackColor = True
        '
        'txtObraSocial
        '
        Me.txtObraSocial.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtObraSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObraSocial.Location = New System.Drawing.Point(58, 16)
        Me.txtObraSocial.Name = "txtObraSocial"
        Me.txtObraSocial.ReadOnly = True
        Me.txtObraSocial.Size = New System.Drawing.Size(325, 20)
        Me.txtObraSocial.TabIndex = 33
        '
        'btnBuscarObraSocial
        '
        Me.btnBuscarObraSocial.AutoSize = True
        Me.btnBuscarObraSocial.Image = CType(resources.GetObject("btnBuscarObraSocial.Image"), System.Drawing.Image)
        Me.btnBuscarObraSocial.Location = New System.Drawing.Point(423, 15)
        Me.btnBuscarObraSocial.Name = "btnBuscarObraSocial"
        Me.btnBuscarObraSocial.Size = New System.Drawing.Size(26, 22)
        Me.btnBuscarObraSocial.TabIndex = 32
        Me.btnBuscarObraSocial.UseVisualStyleBackColor = True
        '
        'cboDescOS
        '
        Me.cboDescOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDescOS.FormattingEnabled = True
        Me.cboDescOS.Location = New System.Drawing.Point(550, 16)
        Me.cboDescOS.Name = "cboDescOS"
        Me.cboDescOS.Size = New System.Drawing.Size(84, 21)
        Me.cboDescOS.TabIndex = 31
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(455, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 18)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Descuento:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 17)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 18)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "O.S:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtTotalDescOS)
        Me.GroupBox7.Controls.Add(Me.txtSubTotal)
        Me.GroupBox7.Controls.Add(Me.txtTotal)
        Me.GroupBox7.Controls.Add(Me.cboTipoTarjeta)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.txtDescuento)
        Me.GroupBox7.Controls.Add(Me.txtNroCupon)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Controls.Add(Me.Label24)
        Me.GroupBox7.Controls.Add(Me.Label23)
        Me.GroupBox7.Controls.Add(Me.cboCondVenta)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Location = New System.Drawing.Point(659, 41)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(206, 497)
        Me.GroupBox7.TabIndex = 56
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Totales"
        '
        'txtTotalDescOS
        '
        Me.txtTotalDescOS.BackColor = System.Drawing.Color.Black
        Me.txtTotalDescOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDescOS.ForeColor = System.Drawing.Color.White
        Me.txtTotalDescOS.Location = New System.Drawing.Point(15, 295)
        Me.txtTotalDescOS.Name = "txtTotalDescOS"
        Me.txtTotalDescOS.ReadOnly = True
        Me.txtTotalDescOS.Size = New System.Drawing.Size(175, 38)
        Me.txtTotalDescOS.TabIndex = 58
        Me.txtTotalDescOS.Text = "Cancelar"
        Me.txtTotalDescOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.Black
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.White
        Me.txtSubTotal.Location = New System.Drawing.Point(16, 231)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(175, 38)
        Me.txtSubTotal.TabIndex = 57
        Me.txtSubTotal.Text = "Cancelar"
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Black
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Yellow
        Me.txtTotal.Location = New System.Drawing.Point(17, 427)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(174, 40)
        Me.txtTotal.TabIndex = 56
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboTipoTarjeta
        '
        Me.cboTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoTarjeta.FormattingEnabled = True
        Me.cboTipoTarjeta.Location = New System.Drawing.Point(16, 99)
        Me.cboTipoTarjeta.Name = "cboTipoTarjeta"
        Me.cboTipoTarjeta.Size = New System.Drawing.Size(174, 21)
        Me.cboTipoTarjeta.TabIndex = 41
        '
        'Label32
        '
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(16, 76)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(174, 20)
        Me.Label32.TabIndex = 40
        Me.Label32.Text = "Tarjeta"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescuento
        '
        Me.txtDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(17, 359)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(174, 38)
        Me.txtDescuento.TabIndex = 39
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNroCupon
        '
        Me.txtNroCupon.Location = New System.Drawing.Point(16, 146)
        Me.txtNroCupon.Name = "txtNroCupon"
        Me.txtNroCupon.Size = New System.Drawing.Size(174, 20)
        Me.txtNroCupon.TabIndex = 34
        '
        'Label26
        '
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(17, 404)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(174, 20)
        Me.Label26.TabIndex = 11
        Me.Label26.Text = "Total:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(17, 336)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(174, 20)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Bonificación/Recargo:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(16, 123)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(174, 20)
        Me.Label28.TabIndex = 17
        Me.Label28.Text = "Cupón N°:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(16, 272)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(174, 20)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Sub Total Desc. O.S:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(16, 208)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(174, 20)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Sub Total:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboCondVenta
        '
        Me.cboCondVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondVenta.FormattingEnabled = True
        Me.cboCondVenta.Location = New System.Drawing.Point(16, 52)
        Me.cboCondVenta.Name = "cboCondVenta"
        Me.cboCondVenta.Size = New System.Drawing.Size(174, 21)
        Me.cboCondVenta.TabIndex = 16
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(16, 29)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(174, 20)
        Me.Label27.TabIndex = 15
        Me.Label27.Text = "Cond. Venta:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'alerta
        '
        Me.alerta.ContainerControl = Me
        '
        'frmOrdenTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 587)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.tssBarraVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrdenTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestión  de Orden de Trabajo"
        Me.Panel3.ResumeLayout(False)
        Me.tssBarraVentas.ResumeLayout(False)
        Me.tssBarraVentas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.alerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents tssBarraVentas As ToolStrip
    Friend WithEvents tssNuevo As ToolStripButton
    Friend WithEvents tssBorrar As ToolStripButton
    Friend WithEvents tssModificar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tssConsultar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tssCerrar As ToolStripButton
    Friend WithEvents txtRazonSocialCliente As TextBox
    Friend WithEvents txtOrdenNumero As MaskedTextBox
    Friend WithEvents btnNuevoCliente As Button
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaRecepcion As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpFechaEntrega As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpFechaReceta As DateTimePicker
    Friend WithEvents txtDr As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCercaOI As TextBox
    Friend WithEvents txtCercaOD As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLejosOI As TextBox
    Friend WithEvents txtLejosOD As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtPrecioCristalCerca As TextBox
    Friend WithEvents txtDescripcionCristalCerca As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPrecioCristalLejos As TextBox
    Friend WithEvents txtDescripcionCristalLejos As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtPrecioArmazonCerca As TextBox
    Friend WithEvents txtModeloCerca As TextBox
    Friend WithEvents txtPrecioArmazonLejos As TextBox
    Friend WithEvents txtModeloLejos As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtMarcaCerca As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtMarcaLejos As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtPrecioReparaciones As TextBox
    Friend WithEvents txtReparaciones As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cboDescOS As ComboBox
    Friend WithEvents txtObraSocial As TextBox
    Friend WithEvents btnBuscarObraSocial As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents cboCondVenta As ComboBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents cboTipoTarjeta As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtNroCupon As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents btnBuscarCristalesCerca As Button
    Friend WithEvents btnBuscarCristalesLejos As Button
    Friend WithEvents btnbuscarModeloCerca As Button
    Friend WithEvents btnBuscarModeloLejos As Button
    Friend WithEvents btnBuscarReparaciones As Button
    Friend WithEvents txtCodigoCristalCerca As TextBox
    Friend WithEvents txtCodigoCristalLejos As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btnLimpiarCristalesCerca As Button
    Friend WithEvents btnLimpiarCristalesLejos As Button
    Friend WithEvents btnLimpiarArmazonCerca As Button
    Friend WithEvents btnLimpiarArmazonLejos As Button
    Friend WithEvents btnLimparReparaciones As Button
    Friend WithEvents btnLimpiarOS As Button
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtTotalDescOS As TextBox
    Friend WithEvents alerta As ErrorProvider
End Class
