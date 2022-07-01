<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarVentas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lstVentas = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opComprobantesSinCae = New System.Windows.Forms.RadioButton()
        Me.opComprobantesCae = New System.Windows.Forms.RadioButton()
        Me.opTodosComprobantes = New System.Windows.Forms.RadioButton()
        Me.txtRazonSocialCliente = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.progreso = New System.Windows.Forms.ProgressBar()
        Me.FN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoComp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CondVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impreso = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.lstVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 425)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(734, 43)
        Me.Panel3.TabIndex = 46
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(527, 8)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 32
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(608, 8)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 31
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lstVentas
        '
        Me.lstVentas.AllowUserToAddRows = False
        Me.lstVentas.AllowUserToDeleteRows = False
        Me.lstVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FN, Me.TipoComp, Me.Fecha, Me.CondVenta, Me.cliente, Me.monto, Me.id, Me.impreso})
        Me.lstVentas.Location = New System.Drawing.Point(12, 89)
        Me.lstVentas.MultiSelect = False
        Me.lstVentas.Name = "lstVentas"
        Me.lstVentas.ReadOnly = True
        Me.lstVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lstVentas.Size = New System.Drawing.Size(710, 302)
        Me.lstVentas.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opComprobantesSinCae)
        Me.GroupBox1.Controls.Add(Me.opComprobantesCae)
        Me.GroupBox1.Controls.Add(Me.opTodosComprobantes)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocialCliente)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.cboCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 77)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'opComprobantesSinCae
        '
        Me.opComprobantesSinCae.AutoSize = True
        Me.opComprobantesSinCae.Location = New System.Drawing.Point(414, 52)
        Me.opComprobantesSinCae.Name = "opComprobantesSinCae"
        Me.opComprobantesSinCae.Size = New System.Drawing.Size(131, 17)
        Me.opComprobantesSinCae.TabIndex = 47
        Me.opComprobantesSinCae.TabStop = True
        Me.opComprobantesSinCae.Text = "Comprobantes sin Cae"
        Me.opComprobantesSinCae.UseVisualStyleBackColor = True
        '
        'opComprobantesCae
        '
        Me.opComprobantesCae.AutoSize = True
        Me.opComprobantesCae.Location = New System.Drawing.Point(272, 52)
        Me.opComprobantesCae.Name = "opComprobantesCae"
        Me.opComprobantesCae.Size = New System.Drawing.Size(136, 17)
        Me.opComprobantesCae.TabIndex = 46
        Me.opComprobantesCae.TabStop = True
        Me.opComprobantesCae.Text = "Comprobantes con Cae"
        Me.opComprobantesCae.UseVisualStyleBackColor = True
        '
        'opTodosComprobantes
        '
        Me.opTodosComprobantes.AutoSize = True
        Me.opTodosComprobantes.Location = New System.Drawing.Point(125, 52)
        Me.opTodosComprobantes.Name = "opTodosComprobantes"
        Me.opTodosComprobantes.Size = New System.Drawing.Size(141, 17)
        Me.opTodosComprobantes.TabIndex = 45
        Me.opTodosComprobantes.TabStop = True
        Me.opTodosComprobantes.Text = "Todos los comprobantes"
        Me.opTodosComprobantes.UseVisualStyleBackColor = True
        '
        'txtRazonSocialCliente
        '
        Me.txtRazonSocialCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtRazonSocialCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocialCliente.Location = New System.Drawing.Point(147, 20)
        Me.txtRazonSocialCliente.Name = "txtRazonSocialCliente"
        Me.txtRazonSocialCliente.ReadOnly = True
        Me.txtRazonSocialCliente.Size = New System.Drawing.Size(316, 20)
        Me.txtRazonSocialCliente.TabIndex = 44
        Me.txtRazonSocialCliente.TabStop = False
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCliente.Location = New System.Drawing.Point(95, 20)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(46, 20)
        Me.txtCodCliente.TabIndex = 43
        Me.txtCodCliente.TabStop = False
        Me.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(469, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(30, 22)
        Me.btnBuscar.TabIndex = 41
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(508, 22)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(112, 17)
        Me.chkTodos.TabIndex = 38
        Me.chkTodos.Text = "Todos los Clientes"
        Me.chkTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'cboCliente
        '
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Items.AddRange(New Object() {"Todos"})
        Me.cboCliente.Location = New System.Drawing.Point(95, 20)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(296, 21)
        Me.cboCliente.TabIndex = 37
        Me.cboCliente.Visible = False
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'progreso
        '
        Me.progreso.Location = New System.Drawing.Point(12, 395)
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(710, 18)
        Me.progreso.TabIndex = 106
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
        Me.TipoComp.HeaderText = "Tipo Comp."
        Me.TipoComp.Name = "TipoComp"
        Me.TipoComp.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.FillWeight = 75.0!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 75
        '
        'CondVenta
        '
        Me.CondVenta.FillWeight = 60.0!
        Me.CondVenta.HeaderText = "Cond. Venta"
        Me.CondVenta.Name = "CondVenta"
        Me.CondVenta.ReadOnly = True
        Me.CondVenta.Width = 60
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
        'impreso
        '
        Me.impreso.FillWeight = 50.0!
        Me.impreso.HeaderText = "Impreso"
        Me.impreso.Name = "impreso"
        Me.impreso.ReadOnly = True
        Me.impreso.Width = 50
        '
        'frmBuscarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 468)
        Me.Controls.Add(Me.progreso)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lstVentas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Ventas"
        Me.Panel3.ResumeLayout(False)
        CType(Me.lstVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lstVentas As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents chkTodos As CheckBox
    Friend WithEvents cboCliente As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRazonSocialCliente As TextBox
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents progreso As ProgressBar
    Friend WithEvents opComprobantesSinCae As RadioButton
    Friend WithEvents opComprobantesCae As RadioButton
    Friend WithEvents opTodosComprobantes As RadioButton
    Friend WithEvents FN As DataGridViewTextBoxColumn
    Friend WithEvents TipoComp As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents CondVenta As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents impreso As DataGridViewCheckBoxColumn
End Class
