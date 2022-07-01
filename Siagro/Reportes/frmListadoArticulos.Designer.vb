<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoArticulos))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.opMarca = New System.Windows.Forms.CheckBox()
        Me.cboRubro = New System.Windows.Forms.ComboBox()
        Me.OpFiltro = New System.Windows.Forms.RadioButton()
        Me.opSinStock = New System.Windows.Forms.CheckBox()
        Me.opEnStock = New System.Windows.Forms.CheckBox()
        Me.opRubro = New System.Windows.Forms.CheckBox()
        Me.opTodosArticulos = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.visorArticulos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.cboMarca)
        Me.Panel3.Controls.Add(Me.opMarca)
        Me.Panel3.Controls.Add(Me.cboRubro)
        Me.Panel3.Controls.Add(Me.OpFiltro)
        Me.Panel3.Controls.Add(Me.opSinStock)
        Me.Panel3.Controls.Add(Me.opEnStock)
        Me.Panel3.Controls.Add(Me.opRubro)
        Me.Panel3.Controls.Add(Me.opTodosArticulos)
        Me.Panel3.Controls.Add(Me.btnBuscar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(879, 87)
        Me.Panel3.TabIndex = 49
        '
        'cboMarca
        '
        Me.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(360, 42)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(151, 21)
        Me.cboMarca.TabIndex = 8
        '
        'opMarca
        '
        Me.opMarca.AutoSize = True
        Me.opMarca.Location = New System.Drawing.Point(280, 44)
        Me.opMarca.Name = "opMarca"
        Me.opMarca.Size = New System.Drawing.Size(56, 17)
        Me.opMarca.TabIndex = 7
        Me.opMarca.Text = "Marca"
        Me.opMarca.UseVisualStyleBackColor = True
        '
        'cboRubro
        '
        Me.cboRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRubro.FormattingEnabled = True
        Me.cboRubro.Location = New System.Drawing.Point(360, 15)
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Size = New System.Drawing.Size(151, 21)
        Me.cboRubro.TabIndex = 6
        '
        'OpFiltro
        '
        Me.OpFiltro.AutoSize = True
        Me.OpFiltro.Location = New System.Drawing.Point(132, 16)
        Me.OpFiltro.Name = "OpFiltro"
        Me.OpFiltro.Size = New System.Drawing.Size(133, 17)
        Me.OpFiltro.TabIndex = 5
        Me.OpFiltro.TabStop = True
        Me.OpFiltro.Text = "Aplicar Filtro Búsqueda"
        Me.OpFiltro.UseVisualStyleBackColor = True
        '
        'opSinStock
        '
        Me.opSinStock.AutoSize = True
        Me.opSinStock.Location = New System.Drawing.Point(593, 17)
        Me.opSinStock.Name = "opSinStock"
        Me.opSinStock.Size = New System.Drawing.Size(72, 17)
        Me.opSinStock.TabIndex = 4
        Me.opSinStock.Text = "Sin Stock"
        Me.opSinStock.UseVisualStyleBackColor = True
        '
        'opEnStock
        '
        Me.opEnStock.AutoSize = True
        Me.opEnStock.Location = New System.Drawing.Point(517, 17)
        Me.opEnStock.Name = "opEnStock"
        Me.opEnStock.Size = New System.Drawing.Size(70, 17)
        Me.opEnStock.TabIndex = 3
        Me.opEnStock.Text = "En Stock"
        Me.opEnStock.UseVisualStyleBackColor = True
        '
        'opRubro
        '
        Me.opRubro.AutoSize = True
        Me.opRubro.Location = New System.Drawing.Point(280, 17)
        Me.opRubro.Name = "opRubro"
        Me.opRubro.Size = New System.Drawing.Size(55, 17)
        Me.opRubro.TabIndex = 2
        Me.opRubro.Text = "Rubro"
        Me.opRubro.UseVisualStyleBackColor = True
        '
        'opTodosArticulos
        '
        Me.opTodosArticulos.AutoSize = True
        Me.opTodosArticulos.Location = New System.Drawing.Point(10, 16)
        Me.opTodosArticulos.Name = "opTodosArticulos"
        Me.opTodosArticulos.Size = New System.Drawing.Size(116, 17)
        Me.opTodosArticulos.TabIndex = 1
        Me.opTodosArticulos.TabStop = True
        Me.opTodosArticulos.Text = "Todos los Artículos"
        Me.opTodosArticulos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(751, 37)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(114, 29)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Aplicar Búsqueda"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.visorArticulos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 359)
        Me.Panel1.TabIndex = 50
        '
        'visorArticulos
        '
        Me.visorArticulos.ActiveViewIndex = -1
        Me.visorArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.visorArticulos.Cursor = System.Windows.Forms.Cursors.Default
        Me.visorArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visorArticulos.Location = New System.Drawing.Point(0, 0)
        Me.visorArticulos.Name = "visorArticulos"
        Me.visorArticulos.ShowCloseButton = False
        Me.visorArticulos.ShowCopyButton = False
        Me.visorArticulos.ShowGotoPageButton = False
        Me.visorArticulos.ShowGroupTreeButton = False
        Me.visorArticulos.ShowLogo = False
        Me.visorArticulos.ShowParameterPanelButton = False
        Me.visorArticulos.ShowRefreshButton = False
        Me.visorArticulos.ShowTextSearchButton = False
        Me.visorArticulos.ShowZoomButton = False
        Me.visorArticulos.Size = New System.Drawing.Size(879, 359)
        Me.visorArticulos.TabIndex = 1
        Me.visorArticulos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmListadoArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 446)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmListadoArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Articulos"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents opRubro As CheckBox
    Friend WithEvents opTodosArticulos As RadioButton
    Friend WithEvents btnBuscar As Button
    Friend WithEvents cboRubro As ComboBox
    Friend WithEvents OpFiltro As RadioButton
    Friend WithEvents opSinStock As CheckBox
    Friend WithEvents opEnStock As CheckBox
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents opMarca As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents visorArticulos As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
