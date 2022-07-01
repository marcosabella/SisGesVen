<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarjetas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTarjetas))
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tssBarraArticulos = New System.Windows.Forms.ToolStrip()
        Me.tssNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tssBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tssModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssCerrar = New System.Windows.Forms.ToolStripButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lstDescripcion = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.porcTarjeta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtRecargo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tssBarraArticulos.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.lstDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(98, 52)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(334, 20)
        Me.txtDescripcion.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Descripción:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tssBarraArticulos
        '
        Me.tssBarraArticulos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssNuevo, Me.tssBorrar, Me.tssModificar, Me.ToolStripSeparator2, Me.tssCerrar})
        Me.tssBarraArticulos.Location = New System.Drawing.Point(0, 0)
        Me.tssBarraArticulos.Name = "tssBarraArticulos"
        Me.tssBarraArticulos.Size = New System.Drawing.Size(444, 38)
        Me.tssBarraArticulos.TabIndex = 54
        Me.tssBarraArticulos.Text = "ToolStrip1"
        '
        'tssNuevo
        '
        Me.tssNuevo.Image = CType(resources.GetObject("tssNuevo.Image"), System.Drawing.Image)
        Me.tssNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssNuevo.Name = "tssNuevo"
        Me.tssNuevo.Size = New System.Drawing.Size(46, 35)
        Me.tssNuevo.Text = "Nuevo"
        Me.tssNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tssNuevo.ToolTipText = "Nuevo"
        '
        'tssBorrar
        '
        Me.tssBorrar.Image = CType(resources.GetObject("tssBorrar.Image"), System.Drawing.Image)
        Me.tssBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssBorrar.Name = "tssBorrar"
        Me.tssBorrar.Size = New System.Drawing.Size(43, 35)
        Me.tssBorrar.Text = "Borrar"
        Me.tssBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tssBorrar.ToolTipText = "Borrar"
        '
        'tssModificar
        '
        Me.tssModificar.Image = CType(resources.GetObject("tssModificar.Image"), System.Drawing.Image)
        Me.tssModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssModificar.Name = "tssModificar"
        Me.tssModificar.Size = New System.Drawing.Size(62, 35)
        Me.tssModificar.Text = "Modificar"
        Me.tssModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tssModificar.ToolTipText = "Modificar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'tssCerrar
        '
        Me.tssCerrar.Image = CType(resources.GetObject("tssCerrar.Image"), System.Drawing.Image)
        Me.tssCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssCerrar.Name = "tssCerrar"
        Me.tssCerrar.Size = New System.Drawing.Size(43, 35)
        Me.tssCerrar.Text = "Cerrar"
        Me.tssCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 337)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(444, 47)
        Me.Panel3.TabIndex = 53
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(274, 6)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 30)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(355, 6)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 30)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lstDescripcion
        '
        Me.lstDescripcion.AllowUserToAddRows = False
        Me.lstDescripcion.AllowUserToDeleteRows = False
        Me.lstDescripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstDescripcion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Descripcion, Me.porcTarjeta})
        Me.lstDescripcion.Location = New System.Drawing.Point(12, 150)
        Me.lstDescripcion.Name = "lstDescripcion"
        Me.lstDescripcion.ReadOnly = True
        Me.lstDescripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lstDescripcion.Size = New System.Drawing.Size(420, 171)
        Me.lstDescripcion.TabIndex = 52
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion.HeaderText = "DESCRIPCION"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'porcTarjeta
        '
        Me.porcTarjeta.FillWeight = 50.0!
        Me.porcTarjeta.HeaderText = "% REC."
        Me.porcTarjeta.Name = "porcTarjeta"
        Me.porcTarjeta.ReadOnly = True
        Me.porcTarjeta.Width = 50
        '
        'txtRecargo
        '
        Me.txtRecargo.Location = New System.Drawing.Point(98, 78)
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.Size = New System.Drawing.Size(28, 20)
        Me.txtRecargo.TabIndex = 56
        Me.txtRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Recargo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(132, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "%"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmTarjetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 384)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRecargo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tssBarraArticulos)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lstDescripcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTarjetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión Tarjetas"
        Me.tssBarraArticulos.ResumeLayout(False)
        Me.tssBarraArticulos.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.lstDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tssBarraArticulos As ToolStrip
    Friend WithEvents tssNuevo As ToolStripButton
    Friend WithEvents tssBorrar As ToolStripButton
    Friend WithEvents tssModificar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tssCerrar As ToolStripButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lstDescripcion As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents porcTarjeta As DataGridViewTextBoxColumn
    Friend WithEvents txtRecargo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
