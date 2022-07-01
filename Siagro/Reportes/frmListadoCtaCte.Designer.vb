<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoCtaCte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoCtaCte))
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.visorCtaCte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(879, 86)
        Me.Panel3.TabIndex = 50
        Me.Panel3.Visible = False
        '
        'txtRazonSocialCliente
        '
        Me.txtRazonSocialCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtRazonSocialCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocialCliente.Location = New System.Drawing.Point(372, 14)
        Me.txtRazonSocialCliente.Name = "txtRazonSocialCliente"
        Me.txtRazonSocialCliente.ReadOnly = True
        Me.txtRazonSocialCliente.Size = New System.Drawing.Size(208, 20)
        Me.txtRazonSocialCliente.TabIndex = 26
        Me.txtRazonSocialCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'opClientes
        '
        Me.opClientes.AutoSize = True
        Me.opClientes.Location = New System.Drawing.Point(186, 16)
        Me.opClientes.Name = "opClientes"
        Me.opClientes.Size = New System.Drawing.Size(63, 17)
        Me.opClientes.TabIndex = 25
        Me.opClientes.Text = "Clientes"
        Me.opClientes.UseVisualStyleBackColor = True
        '
        'opFecha
        '
        Me.opFecha.AutoSize = True
        Me.opFecha.Location = New System.Drawing.Point(186, 43)
        Me.opFecha.Name = "opFecha"
        Me.opFecha.Size = New System.Drawing.Size(56, 17)
        Me.opFecha.TabIndex = 24
        Me.opFecha.Text = "Fecha"
        Me.opFecha.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(529, 41)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaHasta.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(434, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Fecha Hasta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(343, 41)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaDesde.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(248, 41)
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
        Me.btnBuscarCliente.Location = New System.Drawing.Point(586, 13)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(28, 22)
        Me.btnBuscarCliente.TabIndex = 19
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCliente.Location = New System.Drawing.Point(309, 14)
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
        Me.Label2.Location = New System.Drawing.Point(247, 14)
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
        'visorCtaCte
        '
        Me.visorCtaCte.ActiveViewIndex = -1
        Me.visorCtaCte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.visorCtaCte.Cursor = System.Windows.Forms.Cursors.Default
        Me.visorCtaCte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visorCtaCte.Location = New System.Drawing.Point(0, 86)
        Me.visorCtaCte.Name = "visorCtaCte"
        Me.visorCtaCte.ReuseParameterValuesOnRefresh = True
        Me.visorCtaCte.ShowCloseButton = False
        Me.visorCtaCte.ShowCopyButton = False
        Me.visorCtaCte.ShowGotoPageButton = False
        Me.visorCtaCte.ShowGroupTreeButton = False
        Me.visorCtaCte.ShowLogo = False
        Me.visorCtaCte.ShowParameterPanelButton = False
        Me.visorCtaCte.ShowRefreshButton = False
        Me.visorCtaCte.ShowTextSearchButton = False
        Me.visorCtaCte.ShowZoomButton = False
        Me.visorCtaCte.Size = New System.Drawing.Size(879, 360)
        Me.visorCtaCte.TabIndex = 51
        Me.visorCtaCte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmListadoCtaCte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 446)
        Me.Controls.Add(Me.visorCtaCte)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmListadoCtaCte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Cta. Cte."
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents OpFiltro As RadioButton
    Friend WithEvents opTodosClientes As RadioButton
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents opFecha As CheckBox
    Friend WithEvents visorCtaCte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents opClientes As CheckBox
    Friend WithEvents txtRazonSocialCliente As TextBox
End Class
