<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.tssMenuCliente = New System.Windows.Forms.ToolStrip()
        Me.tssBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tssBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tssBtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssBtnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssBtnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRepetirContrasena = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsuarioSistema = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkConfiguracion = New System.Windows.Forms.CheckBox()
        Me.chkListaPrecios = New System.Windows.Forms.CheckBox()
        Me.chkListados = New System.Windows.Forms.CheckBox()
        Me.chkCtaCte = New System.Windows.Forms.CheckBox()
        Me.chkVentas = New System.Windows.Forms.CheckBox()
        Me.chkProductos = New System.Windows.Forms.CheckBox()
        Me.chkProveedores = New System.Windows.Forms.CheckBox()
        Me.chkClientes = New System.Windows.Forms.CheckBox()
        Me.alerta = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tssMenuCliente.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.alerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tssMenuCliente
        '
        Me.tssMenuCliente.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.tssMenuCliente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssBtnNuevo, Me.tssBtnEliminar, Me.tssBtnModificar, Me.ToolStripSeparator1, Me.tssBtnConsultar, Me.ToolStripSeparator2, Me.tssBtnCerrar})
        Me.tssMenuCliente.Location = New System.Drawing.Point(0, 0)
        Me.tssMenuCliente.Name = "tssMenuCliente"
        Me.tssMenuCliente.Size = New System.Drawing.Size(518, 36)
        Me.tssMenuCliente.TabIndex = 46
        Me.tssMenuCliente.Text = "tssClientes"
        '
        'tssBtnNuevo
        '
        Me.tssBtnNuevo.Image = CType(resources.GetObject("tssBtnNuevo.Image"), System.Drawing.Image)
        Me.tssBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssBtnNuevo.Name = "tssBtnNuevo"
        Me.tssBtnNuevo.Size = New System.Drawing.Size(42, 33)
        Me.tssBtnNuevo.Text = "Nuevo"
        Me.tssBtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tssBtnEliminar
        '
        Me.tssBtnEliminar.Image = CType(resources.GetObject("tssBtnEliminar.Image"), System.Drawing.Image)
        Me.tssBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssBtnEliminar.Name = "tssBtnEliminar"
        Me.tssBtnEliminar.Size = New System.Drawing.Size(47, 33)
        Me.tssBtnEliminar.Text = "Eliminar"
        Me.tssBtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tssBtnModificar
        '
        Me.tssBtnModificar.Image = CType(resources.GetObject("tssBtnModificar.Image"), System.Drawing.Image)
        Me.tssBtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssBtnModificar.Name = "tssBtnModificar"
        Me.tssBtnModificar.Size = New System.Drawing.Size(54, 33)
        Me.tssBtnModificar.Text = "Modificar"
        Me.tssBtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 36)
        '
        'tssBtnConsultar
        '
        Me.tssBtnConsultar.Image = CType(resources.GetObject("tssBtnConsultar.Image"), System.Drawing.Image)
        Me.tssBtnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssBtnConsultar.Name = "tssBtnConsultar"
        Me.tssBtnConsultar.Size = New System.Drawing.Size(57, 33)
        Me.tssBtnConsultar.Text = "Consultar"
        Me.tssBtnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 36)
        '
        'tssBtnCerrar
        '
        Me.tssBtnCerrar.Image = CType(resources.GetObject("tssBtnCerrar.Image"), System.Drawing.Image)
        Me.tssBtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssBtnCerrar.Name = "tssBtnCerrar"
        Me.tssBtnCerrar.Size = New System.Drawing.Size(42, 33)
        Me.tssBtnCerrar.Text = "Cerrar"
        Me.tssBtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 309)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(518, 43)
        Me.Panel3.TabIndex = 48
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(348, 3)
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
        Me.btnGuardar.Location = New System.Drawing.Point(429, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 30)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 23)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Nombre Usuario:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRepetirContrasena)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtContrasena)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUsuarioSistema)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombreUsuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 146)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Usuario"
        '
        'txtRepetirContrasena
        '
        Me.txtRepetirContrasena.Location = New System.Drawing.Point(130, 110)
        Me.txtRepetirContrasena.Name = "txtRepetirContrasena"
        Me.txtRepetirContrasena.Size = New System.Drawing.Size(144, 20)
        Me.txtRepetirContrasena.TabIndex = 56
        Me.txtRepetirContrasena.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(13, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 23)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Repetir Contraseña:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(130, 84)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(144, 20)
        Me.txtContrasena.TabIndex = 54
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(13, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 23)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Contraseña:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsuarioSistema
        '
        Me.txtUsuarioSistema.Location = New System.Drawing.Point(130, 58)
        Me.txtUsuarioSistema.Name = "txtUsuarioSistema"
        Me.txtUsuarioSistema.Size = New System.Drawing.Size(144, 20)
        Me.txtUsuarioSistema.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 23)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Usuario Sistema:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreUsuario.Location = New System.Drawing.Point(130, 32)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(345, 20)
        Me.txtNombreUsuario.TabIndex = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkConfiguracion)
        Me.GroupBox2.Controls.Add(Me.chkListaPrecios)
        Me.GroupBox2.Controls.Add(Me.chkListados)
        Me.GroupBox2.Controls.Add(Me.chkCtaCte)
        Me.GroupBox2.Controls.Add(Me.chkVentas)
        Me.GroupBox2.Controls.Add(Me.chkProductos)
        Me.GroupBox2.Controls.Add(Me.chkProveedores)
        Me.GroupBox2.Controls.Add(Me.chkClientes)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(494, 106)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asignación Permisos"
        '
        'chkConfiguracion
        '
        Me.chkConfiguracion.AutoSize = True
        Me.chkConfiguracion.Location = New System.Drawing.Point(273, 67)
        Me.chkConfiguracion.Name = "chkConfiguracion"
        Me.chkConfiguracion.Size = New System.Drawing.Size(91, 17)
        Me.chkConfiguracion.TabIndex = 69
        Me.chkConfiguracion.Text = "Configuración"
        Me.chkConfiguracion.UseVisualStyleBackColor = True
        '
        'chkListaPrecios
        '
        Me.chkListaPrecios.AutoSize = True
        Me.chkListaPrecios.Location = New System.Drawing.Point(273, 34)
        Me.chkListaPrecios.Name = "chkListaPrecios"
        Me.chkListaPrecios.Size = New System.Drawing.Size(86, 17)
        Me.chkListaPrecios.TabIndex = 68
        Me.chkListaPrecios.Text = "Lista Precios"
        Me.chkListaPrecios.UseVisualStyleBackColor = True
        '
        'chkListados
        '
        Me.chkListados.AutoSize = True
        Me.chkListados.Location = New System.Drawing.Point(421, 66)
        Me.chkListados.Name = "chkListados"
        Me.chkListados.Size = New System.Drawing.Size(65, 17)
        Me.chkListados.TabIndex = 67
        Me.chkListados.Text = "Listados"
        Me.chkListados.UseVisualStyleBackColor = True
        '
        'chkCtaCte
        '
        Me.chkCtaCte.AutoSize = True
        Me.chkCtaCte.Location = New System.Drawing.Point(421, 34)
        Me.chkCtaCte.Name = "chkCtaCte"
        Me.chkCtaCte.Size = New System.Drawing.Size(67, 17)
        Me.chkCtaCte.TabIndex = 66
        Me.chkCtaCte.Text = "Cta. Cte."
        Me.chkCtaCte.UseVisualStyleBackColor = True
        '
        'chkVentas
        '
        Me.chkVentas.AutoSize = True
        Me.chkVentas.Location = New System.Drawing.Point(130, 67)
        Me.chkVentas.Name = "chkVentas"
        Me.chkVentas.Size = New System.Drawing.Size(59, 17)
        Me.chkVentas.TabIndex = 65
        Me.chkVentas.Text = "Ventas"
        Me.chkVentas.UseVisualStyleBackColor = True
        '
        'chkProductos
        '
        Me.chkProductos.AutoSize = True
        Me.chkProductos.Location = New System.Drawing.Point(130, 34)
        Me.chkProductos.Name = "chkProductos"
        Me.chkProductos.Size = New System.Drawing.Size(74, 17)
        Me.chkProductos.TabIndex = 64
        Me.chkProductos.Text = "Productos"
        Me.chkProductos.UseVisualStyleBackColor = True
        '
        'chkProveedores
        '
        Me.chkProveedores.AutoSize = True
        Me.chkProveedores.Location = New System.Drawing.Point(13, 67)
        Me.chkProveedores.Name = "chkProveedores"
        Me.chkProveedores.Size = New System.Drawing.Size(86, 17)
        Me.chkProveedores.TabIndex = 63
        Me.chkProveedores.Text = "Proveedores"
        Me.chkProveedores.UseVisualStyleBackColor = True
        '
        'chkClientes
        '
        Me.chkClientes.AutoSize = True
        Me.chkClientes.Location = New System.Drawing.Point(13, 35)
        Me.chkClientes.Name = "chkClientes"
        Me.chkClientes.Size = New System.Drawing.Size(63, 17)
        Me.chkClientes.TabIndex = 62
        Me.chkClientes.Text = "Clientes"
        Me.chkClientes.UseVisualStyleBackColor = True
        '
        'alerta
        '
        Me.alerta.ContainerControl = Me
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 352)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.tssMenuCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Usuarios"
        Me.tssMenuCliente.ResumeLayout(False)
        Me.tssMenuCliente.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.alerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tssMenuCliente As ToolStrip
    Friend WithEvents tssBtnNuevo As ToolStripButton
    Friend WithEvents tssBtnEliminar As ToolStripButton
    Friend WithEvents tssBtnModificar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tssBtnConsultar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tssBtnCerrar As ToolStripButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtRepetirContrasena As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsuarioSistema As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkConfiguracion As CheckBox
    Friend WithEvents chkListaPrecios As CheckBox
    Friend WithEvents chkListados As CheckBox
    Friend WithEvents chkCtaCte As CheckBox
    Friend WithEvents chkVentas As CheckBox
    Friend WithEvents chkProductos As CheckBox
    Friend WithEvents chkProveedores As CheckBox
    Friend WithEvents chkClientes As CheckBox
    Friend WithEvents alerta As ErrorProvider
End Class
