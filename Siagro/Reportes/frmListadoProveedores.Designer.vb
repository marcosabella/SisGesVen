<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoProveedores))
        Me.visorProveedores = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'visorProveedores
        '
        Me.visorProveedores.ActiveViewIndex = -1
        Me.visorProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.visorProveedores.Cursor = System.Windows.Forms.Cursors.Default
        Me.visorProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visorProveedores.Location = New System.Drawing.Point(0, 0)
        Me.visorProveedores.Name = "visorProveedores"
        Me.visorProveedores.ShowCloseButton = False
        Me.visorProveedores.ShowCopyButton = False
        Me.visorProveedores.ShowGotoPageButton = False
        Me.visorProveedores.ShowGroupTreeButton = False
        Me.visorProveedores.ShowLogo = False
        Me.visorProveedores.ShowParameterPanelButton = False
        Me.visorProveedores.ShowRefreshButton = False
        Me.visorProveedores.ShowTextSearchButton = False
        Me.visorProveedores.ShowZoomButton = False
        Me.visorProveedores.Size = New System.Drawing.Size(879, 446)
        Me.visorProveedores.TabIndex = 0
        Me.visorProveedores.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmListadoProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 446)
        Me.Controls.Add(Me.visorProveedores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmListadoProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Proveedores"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents visorProveedores As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
