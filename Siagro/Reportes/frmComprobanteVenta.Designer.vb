<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobanteVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComprobanteVenta))
        Me.visorComprobantesVenta = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'visorComprobantesVenta
        '
        Me.visorComprobantesVenta.ActiveViewIndex = -1
        Me.visorComprobantesVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.visorComprobantesVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.visorComprobantesVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visorComprobantesVenta.Location = New System.Drawing.Point(0, 0)
        Me.visorComprobantesVenta.Name = "visorComprobantesVenta"
        Me.visorComprobantesVenta.ShowCopyButton = False
        Me.visorComprobantesVenta.ShowGotoPageButton = False
        Me.visorComprobantesVenta.ShowGroupTreeButton = False
        Me.visorComprobantesVenta.ShowLogo = False
        Me.visorComprobantesVenta.ShowPageNavigateButtons = False
        Me.visorComprobantesVenta.ShowParameterPanelButton = False
        Me.visorComprobantesVenta.ShowPrintButton = False
        Me.visorComprobantesVenta.ShowRefreshButton = False
        Me.visorComprobantesVenta.ShowTextSearchButton = False
        Me.visorComprobantesVenta.ShowZoomButton = False
        Me.visorComprobantesVenta.Size = New System.Drawing.Size(731, 319)
        Me.visorComprobantesVenta.TabIndex = 0
        Me.visorComprobantesVenta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmComprobanteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 319)
        Me.Controls.Add(Me.visorComprobantesVenta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmComprobanteVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresión de Comprobantes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents visorComprobantesVenta As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
