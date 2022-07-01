<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleVenta))
        Me.visorDetalle = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'visorDetalle
        '
        Me.visorDetalle.ActiveViewIndex = -1
        Me.visorDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.visorDetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.visorDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visorDetalle.Location = New System.Drawing.Point(0, 0)
        Me.visorDetalle.Name = "visorDetalle"
        Me.visorDetalle.ShowCloseButton = False
        Me.visorDetalle.ShowCopyButton = False
        Me.visorDetalle.ShowGotoPageButton = False
        Me.visorDetalle.ShowGroupTreeButton = False
        Me.visorDetalle.ShowLogo = False
        Me.visorDetalle.ShowPageNavigateButtons = False
        Me.visorDetalle.ShowParameterPanelButton = False
        Me.visorDetalle.ShowRefreshButton = False
        Me.visorDetalle.ShowTextSearchButton = False
        Me.visorDetalle.ShowZoomButton = False
        Me.visorDetalle.Size = New System.Drawing.Size(722, 313)
        Me.visorDetalle.TabIndex = 0
        Me.visorDetalle.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmDetalleVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 313)
        Me.Controls.Add(Me.visorDetalle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetalleVenta"
        Me.Text = "Detalle Venta"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents visorDetalle As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
