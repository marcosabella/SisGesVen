<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalIvaAfip = New System.Windows.Forms.Label()
        Me.lblTotalNetoAfip = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAFIP = New System.Windows.Forms.Button()
        Me.btnMandarMail = New System.Windows.Forms.Button()
        Me.btnImprimirDetalle = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tssBarraVentas = New System.Windows.Forms.ToolStrip()
        Me.tssNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tssBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tssModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssCerrar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.grupoGrilla = New System.Windows.Forms.GroupBox()
        Me.lblCae = New System.Windows.Forms.Label()
        Me.lblVtoCae = New System.Windows.Forms.Label()
        Me.txtDatosCheques = New System.Windows.Forms.TextBox()
        Me.lblDolar = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodigoArticulo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstArticulos = New System.Windows.Forms.DataGridView()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cotizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRazonSocialCliente = New System.Windows.Forms.TextBox()
        Me.cboComprobantes = New System.Windows.Forms.ComboBox()
        Me.txtFacturaNumero = New System.Windows.Forms.MaskedTextBox()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtFechaVto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCondVenta = New System.Windows.Forms.ComboBox()
        Me.alerta = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboBanco = New System.Windows.Forms.ComboBox()
        Me.btnEditarMedioPago = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtRecargo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTipoTarjeta = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtNroCupon = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.tssBarraVentas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grupoGrilla.SuspendLayout()
        CType(Me.lstArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.alerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lblTotalIvaAfip)
        Me.Panel3.Controls.Add(Me.lblTotalNetoAfip)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btnAFIP)
        Me.Panel3.Controls.Add(Me.btnMandarMail)
        Me.Panel3.Controls.Add(Me.btnImprimirDetalle)
        Me.Panel3.Controls.Add(Me.btnImprimir)
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 544)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(999, 43)
        Me.Panel3.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(482, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Label7"
        Me.Label7.Visible = False
        '
        'lblTotalIvaAfip
        '
        Me.lblTotalIvaAfip.AutoSize = True
        Me.lblTotalIvaAfip.Location = New System.Drawing.Point(410, 370)
        Me.lblTotalIvaAfip.Name = "lblTotalIvaAfip"
        Me.lblTotalIvaAfip.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalIvaAfip.TabIndex = 66
        Me.lblTotalIvaAfip.Text = "Label7"
        Me.lblTotalIvaAfip.Visible = False
        '
        'lblTotalNetoAfip
        '
        Me.lblTotalNetoAfip.AutoSize = True
        Me.lblTotalNetoAfip.Location = New System.Drawing.Point(358, 370)
        Me.lblTotalNetoAfip.Name = "lblTotalNetoAfip"
        Me.lblTotalNetoAfip.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalNetoAfip.TabIndex = 65
        Me.lblTotalNetoAfip.Text = "Label7"
        Me.lblTotalNetoAfip.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'btnAFIP
        '
        Me.btnAFIP.Location = New System.Drawing.Point(20, 3)
        Me.btnAFIP.Name = "btnAFIP"
        Me.btnAFIP.Size = New System.Drawing.Size(106, 30)
        Me.btnAFIP.TabIndex = 63
        Me.btnAFIP.Text = "CAE AFIP"
        Me.btnAFIP.UseVisualStyleBackColor = True
        '
        'btnMandarMail
        '
        Me.btnMandarMail.Image = CType(resources.GetObject("btnMandarMail.Image"), System.Drawing.Image)
        Me.btnMandarMail.Location = New System.Drawing.Point(256, 4)
        Me.btnMandarMail.Name = "btnMandarMail"
        Me.btnMandarMail.Size = New System.Drawing.Size(106, 30)
        Me.btnMandarMail.TabIndex = 30
        Me.btnMandarMail.Text = "Enviar Mail"
        Me.btnMandarMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMandarMail.UseVisualStyleBackColor = True
        '
        'btnImprimirDetalle
        '
        Me.btnImprimirDetalle.ForeColor = System.Drawing.Color.Black
        Me.btnImprimirDetalle.Image = CType(resources.GetObject("btnImprimirDetalle.Image"), System.Drawing.Image)
        Me.btnImprimirDetalle.Location = New System.Drawing.Point(368, 4)
        Me.btnImprimirDetalle.Name = "btnImprimirDetalle"
        Me.btnImprimirDetalle.Size = New System.Drawing.Size(106, 30)
        Me.btnImprimirDetalle.TabIndex = 28
        Me.btnImprimirDetalle.Text = "Imprimir Detalle"
        Me.btnImprimirDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimirDetalle.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(480, 4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(106, 30)
        Me.btnImprimir.TabIndex = 27
        Me.btnImprimir.Text = "Imprimir Recibo"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(592, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 30)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(689, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(94, 30)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'tssBarraVentas
        '
        Me.tssBarraVentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssNuevo, Me.tssBorrar, Me.tssModificar, Me.ToolStripSeparator2, Me.tssConsultar, Me.ToolStripSeparator1, Me.tssCerrar})
        Me.tssBarraVentas.Location = New System.Drawing.Point(0, 0)
        Me.tssBarraVentas.Name = "tssBarraVentas"
        Me.tssBarraVentas.Size = New System.Drawing.Size(999, 38)
        Me.tssBarraVentas.TabIndex = 46
        Me.tssBarraVentas.Text = "ToolStrip1"
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
        'tssConsultar
        '
        Me.tssConsultar.Image = CType(resources.GetObject("tssConsultar.Image"), System.Drawing.Image)
        Me.tssConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssConsultar.Name = "tssConsultar"
        Me.tssConsultar.Size = New System.Drawing.Size(62, 35)
        Me.tssConsultar.Text = "Consultar"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 366)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(765, 55)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(599, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 20)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Total:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(192, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 20)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "IVA:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(460, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 20)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "% Recargo:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(306, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "% Descuento:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(17, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 20)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Subtotal:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.Black
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.White
        Me.txtSubTotal.Location = New System.Drawing.Point(16, 216)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(174, 38)
        Me.txtSubTotal.TabIndex = 21
        Me.txtSubTotal.Text = "Cancelar"
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grupoGrilla
        '
        Me.grupoGrilla.Controls.Add(Me.lblCae)
        Me.grupoGrilla.Controls.Add(Me.lblVtoCae)
        Me.grupoGrilla.Controls.Add(Me.txtDatosCheques)
        Me.grupoGrilla.Controls.Add(Me.lblDolar)
        Me.grupoGrilla.Controls.Add(Me.txtObservaciones)
        Me.grupoGrilla.Controls.Add(Me.txtCantidad)
        Me.grupoGrilla.Controls.Add(Me.Label10)
        Me.grupoGrilla.Controls.Add(Me.txtDescripcion)
        Me.grupoGrilla.Controls.Add(Me.Label9)
        Me.grupoGrilla.Controls.Add(Me.txtCodigoArticulo)
        Me.grupoGrilla.Controls.Add(Me.Label8)
        Me.grupoGrilla.Controls.Add(Me.lstArticulos)
        Me.grupoGrilla.Location = New System.Drawing.Point(5, 119)
        Me.grupoGrilla.Name = "grupoGrilla"
        Me.grupoGrilla.Size = New System.Drawing.Size(765, 407)
        Me.grupoGrilla.TabIndex = 44
        Me.grupoGrilla.TabStop = False
        '
        'lblCae
        '
        Me.lblCae.AutoSize = True
        Me.lblCae.Location = New System.Drawing.Point(638, 335)
        Me.lblCae.Name = "lblCae"
        Me.lblCae.Size = New System.Drawing.Size(10, 13)
        Me.lblCae.TabIndex = 65
        Me.lblCae.Text = "-"
        Me.lblCae.Visible = False
        '
        'lblVtoCae
        '
        Me.lblVtoCae.AutoSize = True
        Me.lblVtoCae.Location = New System.Drawing.Point(683, 335)
        Me.lblVtoCae.Name = "lblVtoCae"
        Me.lblVtoCae.Size = New System.Drawing.Size(10, 13)
        Me.lblVtoCae.TabIndex = 66
        Me.lblVtoCae.Text = "-"
        Me.lblVtoCae.Visible = False
        '
        'txtDatosCheques
        '
        Me.txtDatosCheques.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtDatosCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatosCheques.Location = New System.Drawing.Point(17, 332)
        Me.txtDatosCheques.Multiline = True
        Me.txtDatosCheques.Name = "txtDatosCheques"
        Me.txtDatosCheques.ReadOnly = True
        Me.txtDatosCheques.Size = New System.Drawing.Size(730, 23)
        Me.txtDatosCheques.TabIndex = 58
        '
        'lblDolar
        '
        Me.lblDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDolar.ForeColor = System.Drawing.Color.Green
        Me.lblDolar.Location = New System.Drawing.Point(547, 381)
        Me.lblDolar.Name = "lblDolar"
        Me.lblDolar.Size = New System.Drawing.Size(188, 26)
        Me.lblDolar.TabIndex = 56
        Me.lblDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDolar.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(17, 361)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(730, 40)
        Me.txtObservaciones.TabIndex = 48
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(696, 13)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(51, 20)
        Me.txtCantidad.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(613, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Cantidad:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(259, 13)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(348, 20)
        Me.txtDescripcion.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(170, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Descripción:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(79, 13)
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(85, 20)
        Me.txtCodigoArticulo.TabIndex = 17
        Me.txtCodigoArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(17, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Cod.:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstArticulos
        '
        Me.lstArticulos.AllowUserToAddRows = False
        Me.lstArticulos.AllowUserToDeleteRows = False
        Me.lstArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.Cantidad, Me.Descripcion, Me.PU, Me.iva, Me.subTotal, Me.Total, Me.cotizacion})
        Me.lstArticulos.Location = New System.Drawing.Point(17, 39)
        Me.lstArticulos.Name = "lstArticulos"
        Me.lstArticulos.ReadOnly = True
        Me.lstArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lstArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lstArticulos.Size = New System.Drawing.Size(730, 290)
        Me.lstArticulos.TabIndex = 0
        '
        'Cod
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Cod.DefaultCellStyle = DataGridViewCellStyle1
        Me.Cod.FillWeight = 50.0!
        Me.Cod.HeaderText = "Cod."
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Width = 50
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.FillWeight = 80.0!
        Me.Cantidad.HeaderText = "Cant."
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 57
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Descripcion.FillWeight = 345.0!
        Me.Descripcion.HeaderText = "Descripción."
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 345
        '
        'PU
        '
        Me.PU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PU.FillWeight = 80.0!
        Me.PU.HeaderText = "P.U"
        Me.PU.Name = "PU"
        Me.PU.ReadOnly = True
        '
        'iva
        '
        Me.iva.FillWeight = 50.0!
        Me.iva.HeaderText = "I.V.A"
        Me.iva.Name = "iva"
        Me.iva.ReadOnly = True
        Me.iva.Width = 50
        '
        'subTotal
        '
        Me.subTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.subTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.subTotal.FillWeight = 85.0!
        Me.subTotal.HeaderText = "SubTotal"
        Me.subTotal.Name = "subTotal"
        Me.subTotal.ReadOnly = True
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle4
        Me.Total.FillWeight = 80.0!
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'cotizacion
        '
        Me.cotizacion.HeaderText = "cotizacion"
        Me.cotizacion.Name = "cotizacion"
        Me.cotizacion.ReadOnly = True
        Me.cotizacion.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRazonSocialCliente)
        Me.GroupBox1.Controls.Add(Me.cboComprobantes)
        Me.GroupBox1.Controls.Add(Me.txtFacturaNumero)
        Me.GroupBox1.Controls.Add(Me.btnNuevoCliente)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.txtFechaVto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFechaAlta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 74)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'txtRazonSocialCliente
        '
        Me.txtRazonSocialCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtRazonSocialCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocialCliente.Location = New System.Drawing.Point(168, 38)
        Me.txtRazonSocialCliente.Name = "txtRazonSocialCliente"
        Me.txtRazonSocialCliente.ReadOnly = True
        Me.txtRazonSocialCliente.Size = New System.Drawing.Size(281, 20)
        Me.txtRazonSocialCliente.TabIndex = 19
        Me.txtRazonSocialCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboComprobantes
        '
        Me.cboComprobantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboComprobantes.FormattingEnabled = True
        Me.cboComprobantes.Location = New System.Drawing.Point(344, 14)
        Me.cboComprobantes.Name = "cboComprobantes"
        Me.cboComprobantes.Size = New System.Drawing.Size(169, 21)
        Me.cboComprobantes.TabIndex = 18
        '
        'txtFacturaNumero
        '
        Me.txtFacturaNumero.BackColor = System.Drawing.SystemColors.Control
        Me.txtFacturaNumero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFacturaNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacturaNumero.Location = New System.Drawing.Point(533, 21)
        Me.txtFacturaNumero.Mask = "9999 - 99999999"
        Me.txtFacturaNumero.Name = "txtFacturaNumero"
        Me.txtFacturaNumero.ReadOnly = True
        Me.txtFacturaNumero.Size = New System.Drawing.Size(228, 31)
        Me.txtFacturaNumero.TabIndex = 17
        Me.txtFacturaNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.AutoSize = True
        Me.btnNuevoCliente.Image = CType(resources.GetObject("btnNuevoCliente.Image"), System.Drawing.Image)
        Me.btnNuevoCliente.Location = New System.Drawing.Point(455, 37)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(28, 22)
        Me.btnNuevoCliente.TabIndex = 16
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.AutoSize = True
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(485, 37)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(28, 22)
        Me.btnBuscarCliente.TabIndex = 15
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtFechaVto
        '
        Me.txtFechaVto.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtFechaVto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaVto.Location = New System.Drawing.Point(259, 14)
        Me.txtFechaVto.Name = "txtFechaVto"
        Me.txtFechaVto.ReadOnly = True
        Me.txtFechaVto.Size = New System.Drawing.Size(78, 20)
        Me.txtFechaVto.TabIndex = 8
        Me.txtFechaVto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(170, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha Vto.:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCliente.Location = New System.Drawing.Point(79, 38)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(85, 20)
        Me.txtCodCliente.TabIndex = 3
        Me.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaAlta
        '
        Me.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAlta.Location = New System.Drawing.Point(79, 14)
        Me.dtpFechaAlta.Name = "dtpFechaAlta"
        Me.dtpFechaAlta.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaAlta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboCondVenta
        '
        Me.cboCondVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondVenta.FormattingEnabled = True
        Me.cboCondVenta.Location = New System.Drawing.Point(16, 39)
        Me.cboCondVenta.Name = "cboCondVenta"
        Me.cboCondVenta.Size = New System.Drawing.Size(138, 21)
        Me.cboCondVenta.TabIndex = 14
        '
        'alerta
        '
        Me.alerta.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboBanco)
        Me.GroupBox2.Controls.Add(Me.btnEditarMedioPago)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtRecargo)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtIva)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboTipoTarjeta)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.txtNroCupon)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.txtSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.cboCondVenta)
        Me.GroupBox2.Location = New System.Drawing.Point(781, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 487)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales"
        '
        'cboBanco
        '
        Me.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Items.AddRange(New Object() {"Bco. MACRO", "Bco. CÓRDOBA"})
        Me.cboBanco.Location = New System.Drawing.Point(16, 87)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(173, 21)
        Me.cboBanco.TabIndex = 57
        '
        'btnEditarMedioPago
        '
        Me.btnEditarMedioPago.Image = CType(resources.GetObject("btnEditarMedioPago.Image"), System.Drawing.Image)
        Me.btnEditarMedioPago.Location = New System.Drawing.Point(161, 38)
        Me.btnEditarMedioPago.Name = "btnEditarMedioPago"
        Me.btnEditarMedioPago.Size = New System.Drawing.Size(28, 23)
        Me.btnEditarMedioPago.TabIndex = 56
        Me.btnEditarMedioPago.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Black
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Yellow
        Me.txtTotal.Location = New System.Drawing.Point(16, 412)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(173, 40)
        Me.txtTotal.TabIndex = 55
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(16, 389)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(173, 20)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Total:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRecargo
        '
        Me.txtRecargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecargo.Location = New System.Drawing.Point(16, 348)
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.Size = New System.Drawing.Size(173, 38)
        Me.txtRecargo.TabIndex = 53
        Me.txtRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(16, 325)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(173, 20)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "% Recargo:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescuento
        '
        Me.txtDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(16, 282)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(173, 38)
        Me.txtDescuento.TabIndex = 51
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 20)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "% Descuento:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIva
        '
        Me.txtIva.BackColor = System.Drawing.Color.Black
        Me.txtIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.ForeColor = System.Drawing.Color.White
        Me.txtIva.Location = New System.Drawing.Point(6, 244)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(188, 38)
        Me.txtIva.TabIndex = 49
        Me.txtIva.Text = "Cancelar"
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIva.Visible = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(6, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 20)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "IVA:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'cboTipoTarjeta
        '
        Me.cboTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoTarjeta.FormattingEnabled = True
        Me.cboTipoTarjeta.Location = New System.Drawing.Point(16, 87)
        Me.cboTipoTarjeta.Name = "cboTipoTarjeta"
        Me.cboTipoTarjeta.Size = New System.Drawing.Size(173, 21)
        Me.cboTipoTarjeta.TabIndex = 47
        '
        'Label32
        '
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(16, 64)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(173, 20)
        Me.Label32.TabIndex = 46
        Me.Label32.Text = "Tarjeta"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNroCupon
        '
        Me.txtNroCupon.Location = New System.Drawing.Point(16, 134)
        Me.txtNroCupon.Name = "txtNroCupon"
        Me.txtNroCupon.Size = New System.Drawing.Size(173, 20)
        Me.txtNroCupon.TabIndex = 45
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(16, 111)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(173, 20)
        Me.Label28.TabIndex = 44
        Me.Label28.Text = "Cupón N°:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(16, 193)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(173, 20)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "Sub Total:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(16, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(173, 20)
        Me.Label27.TabIndex = 42
        Me.Label27.Text = "Cond. Venta:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 587)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.tssBarraVentas)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grupoGrilla)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Ventas"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tssBarraVentas.ResumeLayout(False)
        Me.tssBarraVentas.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.grupoGrilla.ResumeLayout(False)
        Me.grupoGrilla.PerformLayout()
        CType(Me.lstArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.alerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents tssBarraVentas As ToolStrip
    Friend WithEvents tssNuevo As ToolStripButton
    Friend WithEvents tssBorrar As ToolStripButton
    Friend WithEvents tssModificar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tssConsultar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tssCerrar As ToolStripButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents grupoGrilla As GroupBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCodigoArticulo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lstArticulos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFacturaNumero As MaskedTextBox
    Friend WithEvents btnNuevoCliente As Button
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents cboCondVenta As ComboBox
    Friend WithEvents txtFechaVto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaAlta As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents alerta As ErrorProvider
    Friend WithEvents cboComprobantes As ComboBox
    Friend WithEvents txtRazonSocialCliente As TextBox
    Friend WithEvents btnImprimirDetalle As Button
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtRecargo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIva As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboTipoTarjeta As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtNroCupon As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents lblDolar As Label
    Friend WithEvents btnEditarMedioPago As Button
    Friend WithEvents txtDatosCheques As TextBox
    Friend WithEvents btnMandarMail As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalIvaAfip As Label
    Friend WithEvents lblTotalNetoAfip As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAFIP As Button
    Friend WithEvents lblVtoCae As Label
    Friend WithEvents lblCae As Label
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents PU As DataGridViewTextBoxColumn
    Friend WithEvents iva As DataGridViewTextBoxColumn
    Friend WithEvents subTotal As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents cotizacion As DataGridViewTextBoxColumn
    Friend WithEvents cboBanco As ComboBox
End Class
