<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoVentas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.visorVentas = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboCondVenta = New System.Windows.Forms.ComboBox()
        Me.opCondVenta = New System.Windows.Forms.CheckBox()
        Me.txtRazonSocialCliente = New System.Windows.Forms.TextBox()
        Me.opClientes = New System.Windows.Forms.CheckBox()
        Me.opFecha = New System.Windows.Forms.CheckBox()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpFiltro = New System.Windows.Forms.RadioButton()
        Me.opTodosClientes = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.visorVentas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 339)
        Me.Panel1.TabIndex = 52
        '
        'visorVentas
        '
        Me.visorVentas.ActiveViewIndex = -1
        Me.visorVentas.AutoScroll = True
        Me.visorVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.visorVentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.visorVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visorVentas.Location = New System.Drawing.Point(0, 0)
        Me.visorVentas.Name = "visorVentas"
        Me.visorVentas.ShowCloseButton = False
        Me.visorVentas.ShowCopyButton = False
        Me.visorVentas.ShowGotoPageButton = False
        Me.visorVentas.ShowGroupTreeButton = False
        Me.visorVentas.ShowLogo = False
        Me.visorVentas.ShowParameterPanelButton = False
        Me.visorVentas.ShowRefreshButton = False
        Me.visorVentas.ShowTextSearchButton = False
        Me.visorVentas.ShowZoomButton = False
        Me.visorVentas.Size = New System.Drawing.Size(879, 339)
        Me.visorVentas.TabIndex = 51
        Me.visorVentas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(879, 107)
        Me.FlowLayoutPanel1.TabIndex = 51
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(293, 0)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.cboCondVenta)
        Me.Panel3.Controls.Add(Me.opCondVenta)
        Me.Panel3.Controls.Add(Me.txtRazonSocialCliente)
        Me.Panel3.Controls.Add(Me.opClientes)
        Me.Panel3.Controls.Add(Me.opFecha)
        Me.Panel3.Controls.Add(Me.dtpFechaHasta)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.dtpFechaDesde)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnBuscarCliente)
        Me.Panel3.Controls.Add(Me.txtCodCliente)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.OpFiltro)
        Me.Panel3.Controls.Add(Me.opTodosClientes)
        Me.Panel3.Controls.Add(Me.btnBuscar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(879, 104)
        Me.Panel3.TabIndex = 53
        '
        'cboCondVenta
        '
        Me.cboCondVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondVenta.FormattingEnabled = True
        Me.cboCondVenta.Location = New System.Drawing.Point(280, 67)
        Me.cboCondVenta.Name = "cboCondVenta"
        Me.cboCondVenta.Size = New System.Drawing.Size(181, 21)
        Me.cboCondVenta.TabIndex = 28
        '
        'opCondVenta
        '
        Me.opCondVenta.AutoSize = True
        Me.opCondVenta.Location = New System.Drawing.Point(185, 69)
        Me.opCondVenta.Name = "opCondVenta"
        Me.opCondVenta.Size = New System.Drawing.Size(85, 17)
        Me.opCondVenta.TabIndex = 27
        Me.opCondVenta.Text = "Cond. Venta"
        Me.opCondVenta.UseVisualStyleBackColor = True
        '
        'txtRazonSocialCliente
        '
        Me.txtRazonSocialCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtRazonSocialCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocialCliente.Location = New System.Drawing.Point(405, 14)
        Me.txtRazonSocialCliente.Name = "txtRazonSocialCliente"
        Me.txtRazonSocialCliente.ReadOnly = True
        Me.txtRazonSocialCliente.Size = New System.Drawing.Size(208, 20)
        Me.txtRazonSocialCliente.TabIndex = 26
        Me.txtRazonSocialCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'opClientes
        '
        Me.opClientes.AutoSize = True
        Me.opClientes.Location = New System.Drawing.Point(185, 16)
        Me.opClientes.Name = "opClientes"
        Me.opClientes.Size = New System.Drawing.Size(63, 17)
        Me.opClientes.TabIndex = 25
        Me.opClientes.Text = "Clientes"
        Me.opClientes.UseVisualStyleBackColor = True
        '
        'opFecha
        '
        Me.opFecha.AutoSize = True
        Me.opFecha.Location = New System.Drawing.Point(185, 43)
        Me.opFecha.Name = "opFecha"
        Me.opFecha.Size = New System.Drawing.Size(56, 17)
        Me.opFecha.TabIndex = 24
        Me.opFecha.Text = "Fecha"
        Me.opFecha.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(562, 41)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaHasta.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(467, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Fecha Hasta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(376, 41)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaDesde.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(281, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fecha Desde:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.AutoSize = True
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(619, 13)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(28, 22)
        Me.btnBuscarCliente.TabIndex = 19
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCliente.Location = New System.Drawing.Point(342, 14)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(57, 20)
        Me.txtCodCliente.TabIndex = 17
        Me.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(280, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpFiltro
        '
        Me.OpFiltro.AutoSize = True
        Me.OpFiltro.Location = New System.Drawing.Point(10, 42)
        Me.OpFiltro.Name = "OpFiltro"
        Me.OpFiltro.Size = New System.Drawing.Size(133, 17)
        Me.OpFiltro.TabIndex = 5
        Me.OpFiltro.TabStop = True
        Me.OpFiltro.Text = "Aplicar Filtro Búsqueda"
        Me.OpFiltro.UseVisualStyleBackColor = True
        '
        'opTodosClientes
        '
        Me.opTodosClientes.AutoSize = True
        Me.opTodosClientes.Location = New System.Drawing.Point(10, 16)
        Me.opTodosClientes.Name = "opTodosClientes"
        Me.opTodosClientes.Size = New System.Drawing.Size(111, 17)
        Me.opTodosClientes.TabIndex = 1
        Me.opTodosClientes.TabStop = True
        Me.opTodosClientes.Text = "Todos los Clientes"
        Me.opTodosClientes.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(705, 36)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(114, 29)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Aplicar Búsqueda"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmListadoVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 446)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmListadoVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents visorVentas As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cboCondVenta As ComboBox
    Friend WithEvents opCondVenta As CheckBox
    Friend WithEvents txtRazonSocialCliente As TextBox
    Friend WithEvents opClientes As CheckBox
    Friend WithEvents opFecha As CheckBox
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpFiltro As RadioButton
    Friend WithEvents opTodosClientes As RadioButton
    Friend WithEvents btnBuscar As Button
End Class
