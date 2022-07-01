<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiquetasCodigo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtiquetasCodigo))
        Me.visorEtiquetaProducto = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'visorEtiquetaProducto
        '
        Me.visorEtiquetaProducto.ActiveViewIndex = -1
        Me.visorEtiquetaProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.visorEtiquetaProducto.Cursor = System.Windows.Forms.Cursors.Default
        Me.visorEtiquetaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visorEtiquetaProducto.Location = New System.Drawing.Point(0, 0)
        Me.visorEtiquetaProducto.Name = "visorEtiquetaProducto"
        Me.visorEtiquetaProducto.ShowCloseButton = False
        Me.visorEtiquetaProducto.ShowCopyButton = False
        Me.visorEtiquetaProducto.ShowGotoPageButton = False
        Me.visorEtiquetaProducto.ShowGroupTreeButton = False
        Me.visorEtiquetaProducto.ShowLogo = False
        Me.visorEtiquetaProducto.ShowParameterPanelButton = False
        Me.visorEtiquetaProducto.ShowRefreshButton = False
        Me.visorEtiquetaProducto.ShowTextSearchButton = False
        Me.visorEtiquetaProducto.Size = New System.Drawing.Size(570, 335)
        Me.visorEtiquetaProducto.TabIndex = 0
        Me.visorEtiquetaProducto.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmEtiquetasCodigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 335)
        Me.Controls.Add(Me.visorEtiquetaProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmEtiquetasCodigo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresión de Etiquetas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents visorEtiquetaProducto As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
