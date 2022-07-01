<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibo))
        Me.visorRecibo = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'visorRecibo
        '
        Me.visorRecibo.ActiveViewIndex = -1
        Me.visorRecibo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.visorRecibo.Cursor = System.Windows.Forms.Cursors.Default
        Me.visorRecibo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visorRecibo.Location = New System.Drawing.Point(0, 0)
        Me.visorRecibo.Name = "visorRecibo"
        Me.visorRecibo.ShowCloseButton = False
        Me.visorRecibo.ShowCopyButton = False
        Me.visorRecibo.ShowGotoPageButton = False
        Me.visorRecibo.ShowGroupTreeButton = False
        Me.visorRecibo.ShowLogo = False
        Me.visorRecibo.ShowPageNavigateButtons = False
        Me.visorRecibo.ShowParameterPanelButton = False
        Me.visorRecibo.ShowRefreshButton = False
        Me.visorRecibo.ShowTextSearchButton = False
        Me.visorRecibo.ShowZoomButton = False
        Me.visorRecibo.Size = New System.Drawing.Size(789, 376)
        Me.visorRecibo.TabIndex = 1
        Me.visorRecibo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 376)
        Me.Controls.Add(Me.visorRecibo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmRecibo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents visorRecibo As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
