<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaja))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnDetalleTarjeta = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCheque = New System.Windows.Forms.Label()
        Me.lblTarjeta = New System.Windows.Forms.Label()
        Me.lblEfectivo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bgCajaDiaria = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaCierre = New System.Windows.Forms.DateTimePicker()
        Me.lblDiarioPagos = New System.Windows.Forms.Label()
        Me.btnResumenCajaDiaria = New System.Windows.Forms.Button()
        Me.lblDiarioCtaCte = New System.Windows.Forms.Label()
        Me.lblDiarioTransfereicia = New System.Windows.Forms.Label()
        Me.lblDiarioCheque = New System.Windows.Forms.Label()
        Me.lblDiarioTarjeta = New System.Windows.Forms.Label()
        Me.lblDiarioContado = New System.Windows.Forms.Label()
        Me.lstVentas = New System.Windows.Forms.DataGridView()
        Me.FN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoComp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CondVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboCondVenta = New System.Windows.Forms.ComboBox()
        Me.opCondVenta = New System.Windows.Forms.CheckBox()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.btnAjusteCaja = New System.Windows.Forms.Button()
        Me.btnOrdenPago = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.bgCajaDiaria.SuspendLayout()
        CType(Me.lstVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.btnDetalleTarjeta)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.lblCheque)
        Me.GroupBox2.Controls.Add(Me.lblTarjeta)
        Me.GroupBox2.Controls.Add(Me.lblEfectivo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 213)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valores en Caja:"
        Me.GroupBox2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 113)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 23)
        Me.Button3.TabIndex = 33
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'btnDetalleTarjeta
        '
        Me.btnDetalleTarjeta.Image = CType(resources.GetObject("btnDetalleTarjeta.Image"), System.Drawing.Image)
        Me.btnDetalleTarjeta.Location = New System.Drawing.Point(6, 81)
        Me.btnDetalleTarjeta.Name = "btnDetalleTarjeta"
        Me.btnDetalleTarjeta.Size = New System.Drawing.Size(33, 23)
        Me.btnDetalleTarjeta.TabIndex = 32
        Me.btnDetalleTarjeta.UseVisualStyleBackColor = True
        Me.btnDetalleTarjeta.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lblCheque
        '
        Me.lblCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheque.ForeColor = System.Drawing.Color.Black
        Me.lblCheque.Location = New System.Drawing.Point(89, 107)
        Me.lblCheque.Name = "lblCheque"
        Me.lblCheque.Size = New System.Drawing.Size(142, 32)
        Me.lblCheque.TabIndex = 30
        Me.lblCheque.Text = "$ -"
        Me.lblCheque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTarjeta
        '
        Me.lblTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarjeta.ForeColor = System.Drawing.Color.Black
        Me.lblTarjeta.Location = New System.Drawing.Point(89, 75)
        Me.lblTarjeta.Name = "lblTarjeta"
        Me.lblTarjeta.Size = New System.Drawing.Size(142, 32)
        Me.lblTarjeta.TabIndex = 29
        Me.lblTarjeta.Text = "$ -"
        Me.lblTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEfectivo
        '
        Me.lblEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEfectivo.ForeColor = System.Drawing.Color.Black
        Me.lblEfectivo.Location = New System.Drawing.Point(89, 43)
        Me.lblEfectivo.Name = "lblEfectivo"
        Me.lblEfectivo.Size = New System.Drawing.Size(142, 32)
        Me.lblEfectivo.TabIndex = 28
        Me.lblEfectivo.Text = "$ -"
        Me.lblEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 32)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Cheque:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 32)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Tarjeta:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 32)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Efectivo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bgCajaDiaria
        '
        Me.bgCajaDiaria.Controls.Add(Me.Label1)
        Me.bgCajaDiaria.Controls.Add(Me.dtpFechaCierre)
        Me.bgCajaDiaria.Controls.Add(Me.lblDiarioPagos)
        Me.bgCajaDiaria.Controls.Add(Me.btnResumenCajaDiaria)
        Me.bgCajaDiaria.Controls.Add(Me.lblDiarioCtaCte)
        Me.bgCajaDiaria.Controls.Add(Me.lblDiarioTransfereicia)
        Me.bgCajaDiaria.Controls.Add(Me.lblDiarioCheque)
        Me.bgCajaDiaria.Controls.Add(Me.lblDiarioTarjeta)
        Me.bgCajaDiaria.Controls.Add(Me.lblDiarioContado)
        Me.bgCajaDiaria.Controls.Add(Me.lstVentas)
        Me.bgCajaDiaria.Controls.Add(Me.cboCondVenta)
        Me.bgCajaDiaria.Controls.Add(Me.opCondVenta)
        Me.bgCajaDiaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bgCajaDiaria.Location = New System.Drawing.Point(12, 12)
        Me.bgCajaDiaria.Name = "bgCajaDiaria"
        Me.bgCajaDiaria.Size = New System.Drawing.Size(738, 344)
        Me.bgCajaDiaria.TabIndex = 2
        Me.bgCajaDiaria.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Fecha Cierre Caja"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaCierre
        '
        Me.dtpFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCierre.Location = New System.Drawing.Point(112, 29)
        Me.dtpFechaCierre.Name = "dtpFechaCierre"
        Me.dtpFechaCierre.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaCierre.TabIndex = 54
        '
        'lblDiarioPagos
        '
        Me.lblDiarioPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiarioPagos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDiarioPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDiarioPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiarioPagos.ForeColor = System.Drawing.Color.Black
        Me.lblDiarioPagos.Location = New System.Drawing.Point(608, 292)
        Me.lblDiarioPagos.Name = "lblDiarioPagos"
        Me.lblDiarioPagos.Size = New System.Drawing.Size(116, 32)
        Me.lblDiarioPagos.TabIndex = 53
        Me.lblDiarioPagos.Text = "$ -"
        Me.lblDiarioPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnResumenCajaDiaria
        '
        Me.btnResumenCajaDiaria.Image = CType(resources.GetObject("btnResumenCajaDiaria.Image"), System.Drawing.Image)
        Me.btnResumenCajaDiaria.Location = New System.Drawing.Point(624, 28)
        Me.btnResumenCajaDiaria.Name = "btnResumenCajaDiaria"
        Me.btnResumenCajaDiaria.Size = New System.Drawing.Size(100, 23)
        Me.btnResumenCajaDiaria.TabIndex = 52
        Me.btnResumenCajaDiaria.Text = "Resúmen"
        Me.btnResumenCajaDiaria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResumenCajaDiaria.UseVisualStyleBackColor = True
        '
        'lblDiarioCtaCte
        '
        Me.lblDiarioCtaCte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiarioCtaCte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDiarioCtaCte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDiarioCtaCte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiarioCtaCte.ForeColor = System.Drawing.Color.Black
        Me.lblDiarioCtaCte.Location = New System.Drawing.Point(486, 292)
        Me.lblDiarioCtaCte.Name = "lblDiarioCtaCte"
        Me.lblDiarioCtaCte.Size = New System.Drawing.Size(116, 32)
        Me.lblDiarioCtaCte.TabIndex = 51
        Me.lblDiarioCtaCte.Text = "$ -"
        Me.lblDiarioCtaCte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiarioTransfereicia
        '
        Me.lblDiarioTransfereicia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiarioTransfereicia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDiarioTransfereicia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDiarioTransfereicia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiarioTransfereicia.ForeColor = System.Drawing.Color.Black
        Me.lblDiarioTransfereicia.Location = New System.Drawing.Point(366, 292)
        Me.lblDiarioTransfereicia.Name = "lblDiarioTransfereicia"
        Me.lblDiarioTransfereicia.Size = New System.Drawing.Size(116, 32)
        Me.lblDiarioTransfereicia.TabIndex = 50
        Me.lblDiarioTransfereicia.Text = "$ -"
        Me.lblDiarioTransfereicia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiarioCheque
        '
        Me.lblDiarioCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiarioCheque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDiarioCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDiarioCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiarioCheque.ForeColor = System.Drawing.Color.Black
        Me.lblDiarioCheque.Location = New System.Drawing.Point(246, 292)
        Me.lblDiarioCheque.Name = "lblDiarioCheque"
        Me.lblDiarioCheque.Size = New System.Drawing.Size(116, 32)
        Me.lblDiarioCheque.TabIndex = 49
        Me.lblDiarioCheque.Text = "$ -"
        Me.lblDiarioCheque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiarioTarjeta
        '
        Me.lblDiarioTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiarioTarjeta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDiarioTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDiarioTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiarioTarjeta.ForeColor = System.Drawing.Color.Black
        Me.lblDiarioTarjeta.Location = New System.Drawing.Point(126, 292)
        Me.lblDiarioTarjeta.Name = "lblDiarioTarjeta"
        Me.lblDiarioTarjeta.Size = New System.Drawing.Size(116, 32)
        Me.lblDiarioTarjeta.TabIndex = 48
        Me.lblDiarioTarjeta.Text = "$ -"
        Me.lblDiarioTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiarioContado
        '
        Me.lblDiarioContado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiarioContado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDiarioContado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDiarioContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiarioContado.ForeColor = System.Drawing.Color.Black
        Me.lblDiarioContado.Location = New System.Drawing.Point(6, 292)
        Me.lblDiarioContado.Name = "lblDiarioContado"
        Me.lblDiarioContado.Size = New System.Drawing.Size(116, 32)
        Me.lblDiarioContado.TabIndex = 47
        Me.lblDiarioContado.Text = "$ -"
        Me.lblDiarioContado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstVentas
        '
        Me.lstVentas.AllowUserToAddRows = False
        Me.lstVentas.AllowUserToDeleteRows = False
        Me.lstVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FN, Me.TipoComp, Me.Fecha, Me.CondVenta, Me.cliente, Me.monto, Me.id})
        Me.lstVentas.Location = New System.Drawing.Point(6, 71)
        Me.lstVentas.MultiSelect = False
        Me.lstVentas.Name = "lstVentas"
        Me.lstVentas.ReadOnly = True
        Me.lstVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lstVentas.Size = New System.Drawing.Size(718, 218)
        Me.lstVentas.TabIndex = 46
        '
        'FN
        '
        Me.FN.FillWeight = 90.0!
        Me.FN.HeaderText = "FN"
        Me.FN.Name = "FN"
        Me.FN.ReadOnly = True
        Me.FN.Width = 90
        '
        'TipoComp
        '
        Me.TipoComp.FillWeight = 80.0!
        Me.TipoComp.HeaderText = "Tipo Comp."
        Me.TipoComp.Name = "TipoComp"
        Me.TipoComp.ReadOnly = True
        Me.TipoComp.Width = 80
        '
        'Fecha
        '
        Me.Fecha.FillWeight = 65.0!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 65
        '
        'CondVenta
        '
        Me.CondVenta.FillWeight = 55.0!
        Me.CondVenta.HeaderText = "Cond. Venta"
        Me.CondVenta.Name = "CondVenta"
        Me.CondVenta.ReadOnly = True
        Me.CondVenta.Width = 55
        '
        'cliente
        '
        Me.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        '
        'monto
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.monto.DefaultCellStyle = DataGridViewCellStyle1
        Me.monto.FillWeight = 80.0!
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        Me.monto.Width = 80
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'cboCondVenta
        '
        Me.cboCondVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondVenta.FormattingEnabled = True
        Me.cboCondVenta.Location = New System.Drawing.Point(437, 29)
        Me.cboCondVenta.Name = "cboCondVenta"
        Me.cboCondVenta.Size = New System.Drawing.Size(181, 21)
        Me.cboCondVenta.TabIndex = 30
        '
        'opCondVenta
        '
        Me.opCondVenta.AutoSize = True
        Me.opCondVenta.Location = New System.Drawing.Point(342, 31)
        Me.opCondVenta.Name = "opCondVenta"
        Me.opCondVenta.Size = New System.Drawing.Size(85, 17)
        Me.opCondVenta.TabIndex = 29
        Me.opCondVenta.Text = "Cond. Venta"
        Me.opCondVenta.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(12, 231)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(61, 64)
        Me.btnDepositar.TabIndex = 3
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        Me.btnDepositar.Visible = False
        '
        'btnAjusteCaja
        '
        Me.btnAjusteCaja.Location = New System.Drawing.Point(188, 231)
        Me.btnAjusteCaja.Name = "btnAjusteCaja"
        Me.btnAjusteCaja.Size = New System.Drawing.Size(61, 64)
        Me.btnAjusteCaja.TabIndex = 4
        Me.btnAjusteCaja.Text = "Ajuste de Caja"
        Me.btnAjusteCaja.UseVisualStyleBackColor = True
        Me.btnAjusteCaja.Visible = False
        '
        'btnOrdenPago
        '
        Me.btnOrdenPago.Location = New System.Drawing.Point(79, 231)
        Me.btnOrdenPago.Name = "btnOrdenPago"
        Me.btnOrdenPago.Size = New System.Drawing.Size(61, 64)
        Me.btnOrdenPago.TabIndex = 5
        Me.btnOrdenPago.Text = "Orden de Pago"
        Me.btnOrdenPago.UseVisualStyleBackColor = True
        Me.btnOrdenPago.Visible = False
        '
        'frmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 368)
        Me.Controls.Add(Me.bgCajaDiaria)
        Me.Controls.Add(Me.btnOrdenPago)
        Me.Controls.Add(Me.btnAjusteCaja)
        Me.Controls.Add(Me.btnDepositar)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de Caja"
        Me.GroupBox2.ResumeLayout(False)
        Me.bgCajaDiaria.ResumeLayout(False)
        Me.bgCajaDiaria.PerformLayout()
        CType(Me.lstVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCheque As Label
    Friend WithEvents lblTarjeta As Label
    Friend WithEvents lblEfectivo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bgCajaDiaria As GroupBox
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnAjusteCaja As Button
    Friend WithEvents btnOrdenPago As Button
    Friend WithEvents cboCondVenta As ComboBox
    Friend WithEvents opCondVenta As CheckBox
    Friend WithEvents lstVentas As DataGridView
    Friend WithEvents FN As DataGridViewTextBoxColumn
    Friend WithEvents TipoComp As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents CondVenta As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents lblDiarioCtaCte As Label
    Friend WithEvents lblDiarioTransfereicia As Label
    Friend WithEvents lblDiarioCheque As Label
    Friend WithEvents lblDiarioTarjeta As Label
    Friend WithEvents lblDiarioContado As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnDetalleTarjeta As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnResumenCajaDiaria As Button
    Friend WithEvents lblDiarioPagos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaCierre As DateTimePicker
End Class
