<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoClientes))
        Me.visorReporteCliente = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'visorReporteCliente
        '
        Me.visorReporteCliente.ActiveViewIndex = -1
        Me.visorReporteCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.visorReporteCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.visorReporteCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visorReporteCliente.Location = New System.Drawing.Point(0, 0)
        Me.visorReporteCliente.Name = "visorReporteCliente"
        Me.visorReporteCliente.ShowCloseButton = False
        Me.visorReporteCliente.ShowCopyButton = False
        Me.visorReporteCliente.ShowGotoPageButton = False
        Me.visorReporteCliente.ShowGroupTreeButton = False
        Me.visorReporteCliente.ShowLogo = False
        Me.visorReporteCliente.ShowParameterPanelButton = False
        Me.visorReporteCliente.ShowRefreshButton = False
        Me.visorReporteCliente.ShowTextSearchButton = False
        Me.visorReporteCliente.ShowZoomButton = False
        Me.visorReporteCliente.Size = New System.Drawing.Size(879, 446)
        Me.visorReporteCliente.TabIndex = 0
        Me.visorReporteCliente.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmListadoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 446)
        Me.Controls.Add(Me.visorReporteCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmListadoClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Clientes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents visorReporteCliente As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
