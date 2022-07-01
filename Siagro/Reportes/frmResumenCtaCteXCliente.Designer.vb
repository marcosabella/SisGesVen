<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenCtaCteXCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResumenCtaCteXCliente))
        Me.visorCtaCteXCliente = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'visorCtaCteXCliente
        '
        Me.visorCtaCteXCliente.ActiveViewIndex = -1
        Me.visorCtaCteXCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.visorCtaCteXCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.visorCtaCteXCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visorCtaCteXCliente.Location = New System.Drawing.Point(0, 0)
        Me.visorCtaCteXCliente.Name = "visorCtaCteXCliente"
        Me.visorCtaCteXCliente.ShowCloseButton = False
        Me.visorCtaCteXCliente.ShowCopyButton = False
        Me.visorCtaCteXCliente.ShowGotoPageButton = False
        Me.visorCtaCteXCliente.ShowGroupTreeButton = False
        Me.visorCtaCteXCliente.ShowLogo = False
        Me.visorCtaCteXCliente.ShowParameterPanelButton = False
        Me.visorCtaCteXCliente.ShowRefreshButton = False
        Me.visorCtaCteXCliente.ShowTextSearchButton = False
        Me.visorCtaCteXCliente.Size = New System.Drawing.Size(599, 321)
        Me.visorCtaCteXCliente.TabIndex = 0
        Me.visorCtaCteXCliente.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmResumenCtaCteXCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 321)
        Me.Controls.Add(Me.visorCtaCteXCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmResumenCtaCteXCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen Cta Cte Por Cliente"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents visorCtaCteXCliente As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
