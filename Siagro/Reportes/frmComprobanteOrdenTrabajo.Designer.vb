<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobanteOrdenTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComprobanteOrdenTrabajo))
        Me.visorOrdenTrabajo = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'visorOrdenTrabajo
        '
        Me.visorOrdenTrabajo.ActiveViewIndex = -1
        Me.visorOrdenTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.visorOrdenTrabajo.Cursor = System.Windows.Forms.Cursors.Default
        Me.visorOrdenTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visorOrdenTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.visorOrdenTrabajo.Name = "visorOrdenTrabajo"
        Me.visorOrdenTrabajo.ShowCopyButton = False
        Me.visorOrdenTrabajo.ShowGotoPageButton = False
        Me.visorOrdenTrabajo.ShowGroupTreeButton = False
        Me.visorOrdenTrabajo.ShowLogo = False
        Me.visorOrdenTrabajo.ShowParameterPanelButton = False
        Me.visorOrdenTrabajo.ShowRefreshButton = False
        Me.visorOrdenTrabajo.ShowTextSearchButton = False
        Me.visorOrdenTrabajo.ShowZoomButton = False
        Me.visorOrdenTrabajo.Size = New System.Drawing.Size(763, 370)
        Me.visorOrdenTrabajo.TabIndex = 0
        Me.visorOrdenTrabajo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmComprobanteOrdenTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 370)
        Me.Controls.Add(Me.visorOrdenTrabajo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmComprobanteOrdenTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobante Orden de Trabajo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents visorOrdenTrabajo As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
