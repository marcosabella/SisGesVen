<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtaCte
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtaCte))
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstCtaCte = New System.Windows.Forms.DataGridView()
        Me.ver = New System.Windows.Forms.DataGridViewImageColumn()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idOT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMandarMail = New System.Windows.Forms.Button()
        Me.btnImprimirResumenCtaCte = New System.Windows.Forms.Button()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.chkHistorico = New System.Windows.Forms.CheckBox()
        Me.opFecha = New System.Windows.Forms.CheckBox()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaDesde = New System.Windows.Forms.Label()
        Me.btnVerEstado = New System.Windows.Forms.Button()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboRubro = New System.Windows.Forms.ComboBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtRazonSocialCliente = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.lstCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstCtaCte)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(681, 308)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'lstCtaCte
        '
        Me.lstCtaCte.AllowUserToAddRows = False
        Me.lstCtaCte.AllowUserToDeleteRows = False
        Me.lstCtaCte.AllowUserToOrderColumns = True
        Me.lstCtaCte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.lstCtaCte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.lstCtaCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstCtaCte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ver, Me.sel, Me.fecha, Me.detalle, Me.debe, Me.haber, Me.idVenta, Me.idOT, Me.saldo})
        Me.lstCtaCte.Location = New System.Drawing.Point(7, 19)
        Me.lstCtaCte.Name = "lstCtaCte"
        Me.lstCtaCte.ReadOnly = True
        Me.lstCtaCte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.lstCtaCte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lstCtaCte.Size = New System.Drawing.Size(659, 263)
        Me.lstCtaCte.TabIndex = 0
        '
        'ver
        '
        Me.ver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ver.FillWeight = 40.0!
        Me.ver.HeaderText = "VER"
        Me.ver.Image = CType(resources.GetObject("ver.Image"), System.Drawing.Image)
        Me.ver.MinimumWidth = 50
        Me.ver.Name = "ver"
        Me.ver.ReadOnly = True
        Me.ver.Width = 50
        '
        'sel
        '
        Me.sel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.sel.FillWeight = 50.0!
        Me.sel.HeaderText = ""
        Me.sel.MinimumWidth = 50
        Me.sel.Name = "sel"
        Me.sel.ReadOnly = True
        Me.sel.Visible = False
        Me.sel.Width = 50
        '
        'fecha
        '
        Me.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle12.Format = "dd/MM/yyyy"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle12
        Me.fecha.FillWeight = 80.0!
        Me.fecha.HeaderText = "FECHA"
        Me.fecha.MinimumWidth = 80
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 80
        '
        'detalle
        '
        Me.detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.detalle.FillWeight = 230.0!
        Me.detalle.HeaderText = "DETALLE"
        Me.detalle.MinimumWidth = 220
        Me.detalle.Name = "detalle"
        Me.detalle.ReadOnly = True
        Me.detalle.Width = 220
        '
        'debe
        '
        Me.debe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "C2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.debe.DefaultCellStyle = DataGridViewCellStyle13
        Me.debe.FillWeight = 80.0!
        Me.debe.HeaderText = "DEBE"
        Me.debe.MinimumWidth = 80
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        Me.debe.Width = 80
        '
        'haber
        '
        Me.haber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "C2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.haber.DefaultCellStyle = DataGridViewCellStyle14
        Me.haber.FillWeight = 80.0!
        Me.haber.HeaderText = "HABER"
        Me.haber.MinimumWidth = 80
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        Me.haber.Width = 80
        '
        'idVenta
        '
        Me.idVenta.HeaderText = "idVenta"
        Me.idVenta.Name = "idVenta"
        Me.idVenta.ReadOnly = True
        Me.idVenta.Visible = False
        '
        'idOT
        '
        Me.idOT.HeaderText = "idOT"
        Me.idOT.Name = "idOT"
        Me.idOT.ReadOnly = True
        Me.idOT.Visible = False
        '
        'saldo
        '
        Me.saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "C2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.saldo.DefaultCellStyle = DataGridViewCellStyle15
        Me.saldo.FillWeight = 80.0!
        Me.saldo.HeaderText = "SALDO"
        Me.saldo.MinimumWidth = 80
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Width = 80
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnMandarMail)
        Me.Panel3.Controls.Add(Me.btnImprimirResumenCtaCte)
        Me.Panel3.Controls.Add(Me.btnPago)
        Me.Panel3.Controls.Add(Me.btnImprimir)
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 467)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(704, 43)
        Me.Panel3.TabIndex = 47
        '
        'btnMandarMail
        '
        Me.btnMandarMail.Image = CType(resources.GetObject("btnMandarMail.Image"), System.Drawing.Image)
        Me.btnMandarMail.Location = New System.Drawing.Point(223, 6)
        Me.btnMandarMail.Name = "btnMandarMail"
        Me.btnMandarMail.Size = New System.Drawing.Size(88, 30)
        Me.btnMandarMail.TabIndex = 31
        Me.btnMandarMail.Text = "Enviar Mail"
        Me.btnMandarMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMandarMail.UseVisualStyleBackColor = True
        '
        'btnImprimirResumenCtaCte
        '
        Me.btnImprimirResumenCtaCte.ForeColor = System.Drawing.Color.Black
        Me.btnImprimirResumenCtaCte.Image = CType(resources.GetObject("btnImprimirResumenCtaCte.Image"), System.Drawing.Image)
        Me.btnImprimirResumenCtaCte.Location = New System.Drawing.Point(317, 6)
        Me.btnImprimirResumenCtaCte.Name = "btnImprimirResumenCtaCte"
        Me.btnImprimirResumenCtaCte.Size = New System.Drawing.Size(88, 30)
        Me.btnImprimirResumenCtaCte.TabIndex = 29
        Me.btnImprimirResumenCtaCte.Text = "Resumen"
        Me.btnImprimirResumenCtaCte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimirResumenCtaCte.UseVisualStyleBackColor = True
        '
        'btnPago
        '
        Me.btnPago.ForeColor = System.Drawing.Color.Black
        Me.btnPago.Image = CType(resources.GetObject("btnPago.Image"), System.Drawing.Image)
        Me.btnPago.Location = New System.Drawing.Point(411, 6)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(88, 30)
        Me.btnPago.TabIndex = 28
        Me.btnPago.Text = "Pago"
        Me.btnPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(411, 6)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(88, 30)
        Me.btnImprimir.TabIndex = 27
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        Me.btnImprimir.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(505, 6)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 30)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(586, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 30)
        Me.btnCerrar.TabIndex = 26
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 411)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(680, 50)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(338, 27)
        Me.Label3.TabIndex = 26
        Me.Label3.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(552, 16)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(93, 20)
        Me.txtTotal.TabIndex = 25
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(501, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 20)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Saldo:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.btnVerEstado)
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboRubro)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocialCliente)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(681, 80)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnAplicar)
        Me.GroupBox4.Controls.Add(Me.chkHistorico)
        Me.GroupBox4.Controls.Add(Me.opFecha)
        Me.GroupBox4.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox4.Controls.Add(Me.lblFechaDesde)
        Me.GroupBox4.Location = New System.Drawing.Point(384, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(297, 80)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(225, 37)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(57, 23)
        Me.btnAplicar.TabIndex = 38
        Me.btnAplicar.Text = "->"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'chkHistorico
        '
        Me.chkHistorico.AutoSize = True
        Me.chkHistorico.Location = New System.Drawing.Point(12, 15)
        Me.chkHistorico.Name = "chkHistorico"
        Me.chkHistorico.Size = New System.Drawing.Size(89, 17)
        Me.chkHistorico.TabIndex = 37
        Me.chkHistorico.Text = "Ver  Histórico"
        Me.chkHistorico.UseVisualStyleBackColor = True
        '
        'opFecha
        '
        Me.opFecha.AutoSize = True
        Me.opFecha.Location = New System.Drawing.Point(12, 41)
        Me.opFecha.Name = "opFecha"
        Me.opFecha.Size = New System.Drawing.Size(56, 17)
        Me.opFecha.TabIndex = 36
        Me.opFecha.Text = "Fecha"
        Me.opFecha.UseVisualStyleBackColor = True
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(134, 39)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaDesde.TabIndex = 33
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDesde.ForeColor = System.Drawing.Color.Black
        Me.lblFechaDesde.Location = New System.Drawing.Point(74, 40)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(54, 21)
        Me.lblFechaDesde.TabIndex = 32
        Me.lblFechaDesde.Text = "Desde:"
        Me.lblFechaDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnVerEstado
        '
        Me.btnVerEstado.Location = New System.Drawing.Point(350, 40)
        Me.btnVerEstado.Name = "btnVerEstado"
        Me.btnVerEstado.Size = New System.Drawing.Size(76, 23)
        Me.btnVerEstado.TabIndex = 25
        Me.btnVerEstado.Text = "Ver Estado"
        Me.btnVerEstado.UseVisualStyleBackColor = True
        Me.btnVerEstado.Visible = False
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(280, 46)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(64, 17)
        Me.chkTodos.TabIndex = 24
        Me.chkTodos.Text = "TODOS"
        Me.chkTodos.UseVisualStyleBackColor = True
        Me.chkTodos.Visible = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Rubro:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'cboRubro
        '
        Me.cboRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRubro.FormattingEnabled = True
        Me.cboRubro.Location = New System.Drawing.Point(69, 42)
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Size = New System.Drawing.Size(205, 21)
        Me.cboRubro.TabIndex = 22
        Me.cboRubro.Visible = False
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.AutoSize = True
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(350, 15)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(28, 22)
        Me.btnBuscarCliente.TabIndex = 20
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtRazonSocialCliente
        '
        Me.txtRazonSocialCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtRazonSocialCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocialCliente.Location = New System.Drawing.Point(121, 16)
        Me.txtRazonSocialCliente.Name = "txtRazonSocialCliente"
        Me.txtRazonSocialCliente.ReadOnly = True
        Me.txtRazonSocialCliente.Size = New System.Drawing.Size(223, 20)
        Me.txtRazonSocialCliente.TabIndex = 19
        Me.txtRazonSocialCliente.TabStop = False
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCliente.Location = New System.Drawing.Point(69, 16)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(46, 20)
        Me.txtCodCliente.TabIndex = 18
        Me.txtCodCliente.TabStop = False
        Me.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCtaCte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 510)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCtaCte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Cuenta Corriente Clientes"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.lstCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstCtaCte As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnPago As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnVerEstado As Button
    Friend WithEvents chkTodos As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboRubro As ComboBox
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtRazonSocialCliente As TextBox
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnImprimirResumenCtaCte As Button
    Friend WithEvents btnMandarMail As Button
    Friend WithEvents ver As DataGridViewImageColumn
    Friend WithEvents sel As DataGridViewCheckBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents detalle As DataGridViewTextBoxColumn
    Friend WithEvents debe As DataGridViewTextBoxColumn
    Friend WithEvents haber As DataGridViewTextBoxColumn
    Friend WithEvents idVenta As DataGridViewTextBoxColumn
    Friend WithEvents idOT As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents opFecha As CheckBox
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents lblFechaDesde As Label
    Friend WithEvents chkHistorico As CheckBox
    Friend WithEvents btnAplicar As Button
End Class
