<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscarArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarArticulos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.listaArticulos = New System.Windows.Forms.DataGridView()
        Me.lstArticulos = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoBarras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioSC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cotización = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.progreso = New System.Windows.Forms.ProgressBar()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.listaArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 352)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(749, 43)
        Me.Panel3.TabIndex = 45
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(545, 8)
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
        Me.btnAceptar.Location = New System.Drawing.Point(626, 8)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 31
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtParametro)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(732, 55)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro de  Búsqueda"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese Descripción:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtParametro
        '
        Me.txtParametro.Location = New System.Drawing.Point(142, 19)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(584, 20)
        Me.txtParametro.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.listaArticulos)
        Me.GroupBox1.Controls.Add(Me.lstArticulos)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(732, 269)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'listaArticulos
        '
        Me.listaArticulos.AllowUserToAddRows = False
        Me.listaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaArticulos.Location = New System.Drawing.Point(8, 16)
        Me.listaArticulos.Name = "listaArticulos"
        Me.listaArticulos.ReadOnly = True
        Me.listaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listaArticulos.Size = New System.Drawing.Size(717, 240)
        Me.listaArticulos.TabIndex = 101
        '
        'lstArticulos
        '
        Me.lstArticulos.AllowUserToAddRows = False
        Me.lstArticulos.AllowUserToDeleteRows = False
        Me.lstArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.codigoBarras, Me.descripcion, Me.moneda, Me.PrecioSC, Me.cotización, Me.precio, Me.stock})
        Me.lstArticulos.Location = New System.Drawing.Point(7, 14)
        Me.lstArticulos.MultiSelect = False
        Me.lstArticulos.Name = "lstArticulos"
        Me.lstArticulos.ReadOnly = True
        Me.lstArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lstArticulos.Size = New System.Drawing.Size(719, 243)
        Me.lstArticulos.StandardTab = True
        Me.lstArticulos.TabIndex = 100
        Me.lstArticulos.Visible = False
        '
        'codigo
        '
        Me.codigo.FillWeight = 40.0!
        Me.codigo.HeaderText = "Cod"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 40
        '
        'codigoBarras
        '
        Me.codigoBarras.FillWeight = 80.0!
        Me.codigoBarras.HeaderText = "Cod. Barras"
        Me.codigoBarras.Name = "codigoBarras"
        Me.codigoBarras.ReadOnly = True
        Me.codigoBarras.Width = 80
        '
        'descripcion
        '
        Me.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descripcion.FillWeight = 200.0!
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'moneda
        '
        Me.moneda.FillWeight = 60.0!
        Me.moneda.HeaderText = "Tipo Cambio"
        Me.moneda.Name = "moneda"
        Me.moneda.ReadOnly = True
        Me.moneda.Width = 60
        '
        'PrecioSC
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PrecioSC.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrecioSC.FillWeight = 90.0!
        Me.PrecioSC.HeaderText = "Precio"
        Me.PrecioSC.Name = "PrecioSC"
        Me.PrecioSC.ReadOnly = True
        Me.PrecioSC.Width = 90
        '
        'cotización
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cotización.DefaultCellStyle = DataGridViewCellStyle2
        Me.cotización.FillWeight = 60.0!
        Me.cotización.HeaderText = "Cotización Moneda"
        Me.cotización.Name = "cotización"
        Me.cotización.ReadOnly = True
        Me.cotización.Width = 60
        '
        'precio
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.precio.DefaultCellStyle = DataGridViewCellStyle3
        Me.precio.FillWeight = 90.0!
        Me.precio.HeaderText = "Precio Venta"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 90
        '
        'stock
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.stock.DefaultCellStyle = DataGridViewCellStyle4
        Me.stock.FillWeight = 50.0!
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        Me.stock.Width = 50
        '
        'progreso
        '
        Me.progreso.Location = New System.Drawing.Point(12, 332)
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(718, 14)
        Me.progreso.TabIndex = 50
        '
        'frmBuscarArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 395)
        Me.Controls.Add(Me.progreso)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Artículos"
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.listaArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtParametro As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstArticulos As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents codigoBarras As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents moneda As DataGridViewTextBoxColumn
    Friend WithEvents PrecioSC As DataGridViewTextBoxColumn
    Friend WithEvents cotización As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents listaArticulos As DataGridView
    Friend WithEvents progreso As ProgressBar
End Class
