<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresupuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPresupuesto))
        Me.visorPresupuesto = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'visorPresupuesto
        '
        Me.visorPresupuesto.ActiveViewIndex = -1
        Me.visorPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.visorPresupuesto.Cursor = System.Windows.Forms.Cursors.Default
        Me.visorPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visorPresupuesto.Location = New System.Drawing.Point(0, 0)
        Me.visorPresupuesto.Name = "visorPresupuesto"
        Me.visorPresupuesto.ShowCloseButton = False
        Me.visorPresupuesto.ShowCopyButton = False
        Me.visorPresupuesto.ShowGotoPageButton = False
        Me.visorPresupuesto.ShowGroupTreeButton = False
        Me.visorPresupuesto.ShowLogo = False
        Me.visorPresupuesto.ShowParameterPanelButton = False
        Me.visorPresupuesto.ShowRefreshButton = False
        Me.visorPresupuesto.ShowTextSearchButton = False
        Me.visorPresupuesto.ShowZoomButton = False
        Me.visorPresupuesto.Size = New System.Drawing.Size(789, 376)
        Me.visorPresupuesto.TabIndex = 0
        Me.visorPresupuesto.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 376)
        Me.Controls.Add(Me.visorPresupuesto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuesto"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents visorPresupuesto As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
