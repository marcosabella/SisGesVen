<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaldoCtaCteClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaldoCtaCteClientes))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSaldos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Ver = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnImprimirResumenCtaCte = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.progreso = New System.Windows.Forms.ProgressBar()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.lblSaldoTotal = New System.Windows.Forms.Label()
        CType(Me.dgvSaldos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSaldos
        '
        Me.dgvSaldos.AllowUserToAddRows = False
        Me.dgvSaldos.AllowUserToDeleteRows = False
        Me.dgvSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaldos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Sel, Me.Ver, Me.Cliente, Me.Saldo})
        Me.dgvSaldos.Location = New System.Drawing.Point(12, 12)
        Me.dgvSaldos.Name = "dgvSaldos"
        Me.dgvSaldos.ReadOnly = True
        Me.dgvSaldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSaldos.Size = New System.Drawing.Size(635, 299)
        Me.dgvSaldos.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Sel
        '
        Me.Sel.FillWeight = 30.0!
        Me.Sel.HeaderText = ""
        Me.Sel.Name = "Sel"
        Me.Sel.ReadOnly = True
        Me.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Sel.Visible = False
        Me.Sel.Width = 30
        '
        'Ver
        '
        Me.Ver.FillWeight = 30.0!
        Me.Ver.HeaderText = "Ver"
        Me.Ver.Image = CType(resources.GetObject("Ver.Image"), System.Drawing.Image)
        Me.Ver.Name = "Ver"
        Me.Ver.ReadOnly = True
        Me.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Ver.Width = 30
        '
        'Cliente
        '
        Me.Cliente.FillWeight = 380.0!
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 380
        '
        'Saldo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnListar)
        Me.Panel3.Controls.Add(Me.btnImprimirResumenCtaCte)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 342)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(659, 43)
        Me.Panel3.TabIndex = 48
        '
        'btnListar
        '
        Me.btnListar.ForeColor = System.Drawing.Color.Black
        Me.btnListar.Image = CType(resources.GetObject("btnListar.Image"), System.Drawing.Image)
        Me.btnListar.Location = New System.Drawing.Point(369, 3)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(88, 30)
        Me.btnListar.TabIndex = 30
        Me.btnListar.Text = "Listar"
        Me.btnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnImprimirResumenCtaCte
        '
        Me.btnImprimirResumenCtaCte.ForeColor = System.Drawing.Color.Black
        Me.btnImprimirResumenCtaCte.Image = CType(resources.GetObject("btnImprimirResumenCtaCte.Image"), System.Drawing.Image)
        Me.btnImprimirResumenCtaCte.Location = New System.Drawing.Point(463, 3)
        Me.btnImprimirResumenCtaCte.Name = "btnImprimirResumenCtaCte"
        Me.btnImprimirResumenCtaCte.Size = New System.Drawing.Size(88, 30)
        Me.btnImprimirResumenCtaCte.TabIndex = 29
        Me.btnImprimirResumenCtaCte.Text = "Imprimir"
        Me.btnImprimirResumenCtaCte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimirResumenCtaCte.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(557, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(88, 30)
        Me.btnCerrar.TabIndex = 26
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'progreso
        '
        Me.progreso.Location = New System.Drawing.Point(12, 317)
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(635, 14)
        Me.progreso.TabIndex = 49
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(532, 17)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(115, 17)
        Me.chkTodos.TabIndex = 50
        Me.chkTodos.Text = "Seleccionar Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        Me.chkTodos.Visible = False
        '
        'lblSaldoTotal
        '
        Me.lblSaldoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoTotal.Location = New System.Drawing.Point(12, 317)
        Me.lblSaldoTotal.Name = "lblSaldoTotal"
        Me.lblSaldoTotal.Size = New System.Drawing.Size(635, 22)
        Me.lblSaldoTotal.TabIndex = 51
        Me.lblSaldoTotal.Text = "Label1"
        Me.lblSaldoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSaldoCtaCteClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 385)
        Me.Controls.Add(Me.lblSaldoTotal)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.progreso)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgvSaldos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaldoCtaCteClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldo Cta Cte Clientes"
        CType(Me.dgvSaldos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSaldos As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnImprimirResumenCtaCte As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents progreso As ProgressBar
    Friend WithEvents btnListar As Button
    Friend WithEvents chkTodos As CheckBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Sel As DataGridViewCheckBoxColumn
    Friend WithEvents Ver As DataGridViewImageColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents lblSaldoTotal As Label
End Class
