<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArticulo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulo))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtDescuento = New System.Windows.Forms.MaskedTextBox()
        Me.txtUtilidad = New System.Windows.Forms.MaskedTextBox()
        Me.txtIva = New System.Windows.Forms.MaskedTextBox()
        Me.txtCostoProducto = New System.Windows.Forms.MaskedTextBox()
        Me.btnIngresoMercaderia = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEan = New System.Windows.Forms.Label()
        Me.btnGenerarEAN = New System.Windows.Forms.Button()
        Me.txtCodProducto = New System.Windows.Forms.TextBox()
        Me.btnNuevoRubro = New System.Windows.Forms.Button()
        Me.btnNuevaMarca = New System.Windows.Forms.Button()
        Me.btnNuevoProveedor = New System.Windows.Forms.Button()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboRubro = New System.Windows.Forms.ComboBox()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.txtRazonSocialProveedor = New System.Windows.Forms.TextBox()
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.txtCodProveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tssBarraArticulos = New System.Windows.Forms.ToolStrip()
        Me.tssNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tssBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tssModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssModificarPrecios = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssCerrar = New System.Windows.Forms.ToolStripButton()
        Me.alerta = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tssBarraArticulos.SuspendLayout()
        CType(Me.alerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtComentario)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 265)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(746, 73)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Comentario"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(5, 19)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentario.Size = New System.Drawing.Size(725, 48)
        Me.txtComentario.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboMoneda)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.btnActualizar)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.txtUtilidad)
        Me.GroupBox2.Controls.Add(Me.txtIva)
        Me.GroupBox2.Controls.Add(Me.txtCostoProducto)
        Me.GroupBox2.Controls.Add(Me.btnIngresoMercaderia)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtPrecioVenta)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtStock)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(747, 79)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Items.AddRange(New Object() {"AR$", "U$D BLUE", "U$D OFICIAL"})
        Me.cboMoneda.Location = New System.Drawing.Point(394, 41)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(47, 21)
        Me.cboMoneda.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(322, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 20)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Moneda:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.Location = New System.Drawing.Point(713, 14)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(27, 23)
        Me.btnActualizar.TabIndex = 30
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(530, 15)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(31, 20)
        Me.txtDescuento.TabIndex = 29
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUtilidad
        '
        Me.txtUtilidad.Location = New System.Drawing.Point(394, 15)
        Me.txtUtilidad.Name = "txtUtilidad"
        Me.txtUtilidad.Size = New System.Drawing.Size(47, 20)
        Me.txtUtilidad.TabIndex = 28
        Me.txtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(267, 15)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(40, 20)
        Me.txtIva.TabIndex = 27
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostoProducto
        '
        Me.txtCostoProducto.Location = New System.Drawing.Point(119, 15)
        Me.txtCostoProducto.Name = "txtCostoProducto"
        Me.txtCostoProducto.Size = New System.Drawing.Size(64, 20)
        Me.txtCostoProducto.TabIndex = 26
        Me.txtCostoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnIngresoMercaderia
        '
        Me.btnIngresoMercaderia.AutoSize = True
        Me.btnIngresoMercaderia.Image = CType(resources.GetObject("btnIngresoMercaderia.Image"), System.Drawing.Image)
        Me.btnIngresoMercaderia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresoMercaderia.Location = New System.Drawing.Point(190, 40)
        Me.btnIngresoMercaderia.Name = "btnIngresoMercaderia"
        Me.btnIngresoMercaderia.Size = New System.Drawing.Size(126, 23)
        Me.btnIngresoMercaderia.TabIndex = 25
        Me.btnIngresoMercaderia.Text = "Ingreso Mercadería"
        Me.btnIngresoMercaderia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIngresoMercaderia.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(457, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "% Desc:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtPrecioVenta.Location = New System.Drawing.Point(640, 15)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.ReadOnly = True
        Me.txtPrecioVenta.Size = New System.Drawing.Size(67, 20)
        Me.txtPrecioVenta.TabIndex = 22
        Me.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(568, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "P. Venta:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtStock.Location = New System.Drawing.Point(119, 41)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(64, 20)
        Me.txtStock.TabIndex = 18
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(322, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "% Utilidad:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(190, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "% I.V.A:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(6, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 20)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Stock:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Costo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEan)
        Me.GroupBox1.Controls.Add(Me.btnGenerarEAN)
        Me.GroupBox1.Controls.Add(Me.txtCodProducto)
        Me.GroupBox1.Controls.Add(Me.btnNuevoRubro)
        Me.GroupBox1.Controls.Add(Me.btnNuevaMarca)
        Me.GroupBox1.Controls.Add(Me.btnNuevoProveedor)
        Me.GroupBox1.Controls.Add(Me.cboMarca)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboRubro)
        Me.GroupBox1.Controls.Add(Me.txtCodigoBarras)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionProducto)
        Me.GroupBox1.Controls.Add(Me.btnBuscarProducto)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocialProveedor)
        Me.GroupBox1.Controls.Add(Me.btnBuscarProveedor)
        Me.GroupBox1.Controls.Add(Me.txtCodProveedor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(747, 132)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'lblEan
        '
        Me.lblEan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEan.Font = New System.Drawing.Font("Code EAN13", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblEan.ForeColor = System.Drawing.Color.Black
        Me.lblEan.Location = New System.Drawing.Point(564, 15)
        Me.lblEan.Name = "lblEan"
        Me.lblEan.Size = New System.Drawing.Size(166, 46)
        Me.lblEan.TabIndex = 22
        Me.lblEan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarEAN
        '
        Me.btnGenerarEAN.Location = New System.Drawing.Point(468, 40)
        Me.btnGenerarEAN.Name = "btnGenerarEAN"
        Me.btnGenerarEAN.Size = New System.Drawing.Size(90, 23)
        Me.btnGenerarEAN.TabIndex = 21
        Me.btnGenerarEAN.Text = "Generar EAN"
        Me.btnGenerarEAN.UseVisualStyleBackColor = True
        '
        'txtCodProducto
        '
        Me.txtCodProducto.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCodProducto.Location = New System.Drawing.Point(119, 16)
        Me.txtCodProducto.Name = "txtCodProducto"
        Me.txtCodProducto.ReadOnly = True
        Me.txtCodProducto.Size = New System.Drawing.Size(64, 20)
        Me.txtCodProducto.TabIndex = 0
        Me.txtCodProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnNuevoRubro
        '
        Me.btnNuevoRubro.AutoSize = True
        Me.btnNuevoRubro.Image = CType(resources.GetObject("btnNuevoRubro.Image"), System.Drawing.Image)
        Me.btnNuevoRubro.Location = New System.Drawing.Point(702, 89)
        Me.btnNuevoRubro.Name = "btnNuevoRubro"
        Me.btnNuevoRubro.Size = New System.Drawing.Size(28, 22)
        Me.btnNuevoRubro.TabIndex = 20
        Me.btnNuevoRubro.UseVisualStyleBackColor = True
        '
        'btnNuevaMarca
        '
        Me.btnNuevaMarca.AutoSize = True
        Me.btnNuevaMarca.Image = CType(resources.GetObject("btnNuevaMarca.Image"), System.Drawing.Image)
        Me.btnNuevaMarca.Location = New System.Drawing.Point(313, 91)
        Me.btnNuevaMarca.Name = "btnNuevaMarca"
        Me.btnNuevaMarca.Size = New System.Drawing.Size(28, 22)
        Me.btnNuevaMarca.TabIndex = 19
        Me.btnNuevaMarca.UseVisualStyleBackColor = True
        '
        'btnNuevoProveedor
        '
        Me.btnNuevoProveedor.AutoSize = True
        Me.btnNuevoProveedor.Image = CType(resources.GetObject("btnNuevoProveedor.Image"), System.Drawing.Image)
        Me.btnNuevoProveedor.Location = New System.Drawing.Point(188, 68)
        Me.btnNuevoProveedor.Name = "btnNuevoProveedor"
        Me.btnNuevoProveedor.Size = New System.Drawing.Size(30, 22)
        Me.btnNuevoProveedor.TabIndex = 18
        Me.btnNuevoProveedor.UseVisualStyleBackColor = True
        '
        'cboMarca
        '
        Me.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(119, 92)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(188, 21)
        Me.cboMarca.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Marca:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboRubro
        '
        Me.cboRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRubro.FormattingEnabled = True
        Me.cboRubro.Location = New System.Drawing.Point(468, 91)
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Size = New System.Drawing.Size(216, 21)
        Me.cboRubro.TabIndex = 15
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCodigoBarras.Location = New System.Drawing.Point(468, 16)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(90, 20)
        Me.txtCodigoBarras.TabIndex = 14
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(119, 41)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(222, 20)
        Me.txtDescripcionProducto.TabIndex = 13
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Image = CType(resources.GetObject("btnBuscarProducto.Image"), System.Drawing.Image)
        Me.btnBuscarProducto.Location = New System.Drawing.Point(189, 15)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(29, 22)
        Me.btnBuscarProducto.TabIndex = 12
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        Me.btnBuscarProducto.Visible = False
        '
        'txtRazonSocialProveedor
        '
        Me.txtRazonSocialProveedor.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtRazonSocialProveedor.Location = New System.Drawing.Point(468, 67)
        Me.txtRazonSocialProveedor.Name = "txtRazonSocialProveedor"
        Me.txtRazonSocialProveedor.ReadOnly = True
        Me.txtRazonSocialProveedor.Size = New System.Drawing.Size(262, 20)
        Me.txtRazonSocialProveedor.TabIndex = 8
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.Image = CType(resources.GetObject("btnBuscarProveedor.Image"), System.Drawing.Image)
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(224, 68)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(31, 22)
        Me.btnBuscarProveedor.TabIndex = 9
        Me.btnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'txtCodProveedor
        '
        Me.txtCodProveedor.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCodProveedor.Location = New System.Drawing.Point(119, 68)
        Me.txtCodProveedor.Name = "txtCodProveedor"
        Me.txtCodProveedor.ReadOnly = True
        Me.txtCodProveedor.Size = New System.Drawing.Size(64, 20)
        Me.txtCodProveedor.TabIndex = 7
        Me.txtCodProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(364, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Razón Social:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cod. Proveedor:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(364, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Rubro:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripción:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(364, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cód. Barras:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cód.:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnImprimir)
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 344)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(774, 47)
        Me.Panel3.TabIndex = 48
        '
        'btnImprimir
        '
        Me.btnImprimir.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(508, 6)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(88, 30)
        Me.btnImprimir.TabIndex = 27
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(602, 6)
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
        Me.btnGuardar.Location = New System.Drawing.Point(683, 6)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 30)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'tssBarraArticulos
        '
        Me.tssBarraArticulos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssNuevo, Me.tssBorrar, Me.tssModificar, Me.ToolStripSeparator2, Me.tssModificarPrecios, Me.ToolStripSeparator3, Me.tssConsultar, Me.ToolStripSeparator1, Me.tssCerrar})
        Me.tssBarraArticulos.Location = New System.Drawing.Point(0, 0)
        Me.tssBarraArticulos.Name = "tssBarraArticulos"
        Me.tssBarraArticulos.Size = New System.Drawing.Size(774, 38)
        Me.tssBarraArticulos.TabIndex = 47
        Me.tssBarraArticulos.Text = "ToolStrip1"
        '
        'tssNuevo
        '
        Me.tssNuevo.Image = CType(resources.GetObject("tssNuevo.Image"), System.Drawing.Image)
        Me.tssNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssNuevo.Name = "tssNuevo"
        Me.tssNuevo.Size = New System.Drawing.Size(91, 35)
        Me.tssNuevo.Text = "Nuevo Artículo"
        Me.tssNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tssNuevo.ToolTipText = "Nuevo"
        '
        'tssBorrar
        '
        Me.tssBorrar.Image = CType(resources.GetObject("tssBorrar.Image"), System.Drawing.Image)
        Me.tssBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssBorrar.Name = "tssBorrar"
        Me.tssBorrar.Size = New System.Drawing.Size(88, 35)
        Me.tssBorrar.Text = "Borrar Artículo"
        Me.tssBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tssBorrar.ToolTipText = "Borrar"
        '
        'tssModificar
        '
        Me.tssModificar.Image = CType(resources.GetObject("tssModificar.Image"), System.Drawing.Image)
        Me.tssModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssModificar.Name = "tssModificar"
        Me.tssModificar.Size = New System.Drawing.Size(107, 35)
        Me.tssModificar.Text = "Modificar Artículo"
        Me.tssModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tssModificar.ToolTipText = "Modificar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'tssModificarPrecios
        '
        Me.tssModificarPrecios.Image = CType(resources.GetObject("tssModificarPrecios.Image"), System.Drawing.Image)
        Me.tssModificarPrecios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssModificarPrecios.Name = "tssModificarPrecios"
        Me.tssModificarPrecios.Size = New System.Drawing.Size(103, 35)
        Me.tssModificarPrecios.Text = "Modificar Precios"
        Me.tssModificarPrecios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'tssConsultar
        '
        Me.tssConsultar.Image = CType(resources.GetObject("tssConsultar.Image"), System.Drawing.Image)
        Me.tssConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssConsultar.Name = "tssConsultar"
        Me.tssConsultar.Size = New System.Drawing.Size(107, 35)
        Me.tssConsultar.Text = "Consultar Artículo"
        Me.tssConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tssConsultar.ToolTipText = "Consultar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
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
        'alerta
        '
        Me.alerta.ContainerControl = Me
        '
        'frmArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 391)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.tssBarraArticulos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Artículos"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.tssBarraArticulos.ResumeLayout(False)
        Me.tssBarraArticulos.PerformLayout()
        CType(Me.alerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents txtDescuento As MaskedTextBox
    Friend WithEvents txtUtilidad As MaskedTextBox
    Friend WithEvents txtIva As MaskedTextBox
    Friend WithEvents txtCostoProducto As MaskedTextBox
    Friend WithEvents btnIngresoMercaderia As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCodProducto As TextBox
    Friend WithEvents btnNuevoRubro As Button
    Friend WithEvents btnNuevaMarca As Button
    Friend WithEvents btnNuevoProveedor As Button
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboRubro As ComboBox
    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents txtDescripcionProducto As TextBox
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents txtRazonSocialProveedor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBuscarProveedor As Button
    Friend WithEvents txtCodProveedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents tssBarraArticulos As ToolStrip
    Friend WithEvents tssNuevo As ToolStripButton
    Friend WithEvents tssBorrar As ToolStripButton
    Friend WithEvents tssModificar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tssConsultar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tssCerrar As ToolStripButton
    Friend WithEvents alerta As ErrorProvider
    Friend WithEvents cboMoneda As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnGenerarEAN As Button
    Friend WithEvents lblEan As Label
    Friend WithEvents tssModificarPrecios As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
