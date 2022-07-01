<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
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
        Me.pestanas = New System.Windows.Forms.TabControl()
        Me.pagina1 = New System.Windows.Forms.TabPage()
        Me.grupoFiscal = New System.Windows.Forms.GroupBox()
        Me.cboIva = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.grupoDomicilio = New System.Windows.Forms.GroupBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.btnEliminarDomicilio = New System.Windows.Forms.Button()
        Me.btnAgregarDomicilio = New System.Windows.Forms.Button()
        Me.cboLocalidad = New System.Windows.Forms.ComboBox()
        Me.lstDomicilio = New System.Windows.Forms.DataGridView()
        Me.tipoDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrpcionTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.torre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.piso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dpto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.manzana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idlocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoPostal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPartido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtManzana = New System.Windows.Forms.TextBox()
        Me.txtDpto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPiso = New System.Windows.Forms.TextBox()
        Me.txtTorre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSector = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.opOtro = New System.Windows.Forms.RadioButton()
        Me.opFiscal = New System.Windows.Forms.RadioButton()
        Me.grupoNombre = New System.Windows.Forms.GroupBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.opJurídica = New System.Windows.Forms.RadioButton()
        Me.opFísica = New System.Windows.Forms.RadioButton()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.alerta = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tssMenuCliente.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pestanas.SuspendLayout()
        Me.pagina1.SuspendLayout()
        Me.grupoFiscal.SuspendLayout()
        Me.grupoDomicilio.SuspendLayout()
        CType(Me.lstDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoNombre.SuspendLayout()
        CType(Me.alerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tssMenuCliente
        '
        Me.tssMenuCliente.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.tssMenuCliente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssBtnNuevo, Me.tssBtnEliminar, Me.tssBtnModificar, Me.ToolStripSeparator1, Me.tssBtnConsultar, Me.ToolStripSeparator2, Me.tssBtnCerrar})
        Me.tssMenuCliente.Location = New System.Drawing.Point(0, 0)
        Me.tssMenuCliente.Name = "tssMenuCliente"
        Me.tssMenuCliente.Size = New System.Drawing.Size(861, 36)
        Me.tssMenuCliente.TabIndex = 45
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
        Me.Panel3.Location = New System.Drawing.Point(0, 525)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(861, 43)
        Me.Panel3.TabIndex = 47
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(688, 3)
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
        Me.btnGuardar.Location = New System.Drawing.Point(767, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 30)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'pestanas
        '
        Me.pestanas.Controls.Add(Me.pagina1)
        Me.pestanas.Location = New System.Drawing.Point(12, 50)
        Me.pestanas.Name = "pestanas"
        Me.pestanas.SelectedIndex = 0
        Me.pestanas.Size = New System.Drawing.Size(832, 469)
        Me.pestanas.TabIndex = 48
        '
        'pagina1
        '
        Me.pagina1.BackColor = System.Drawing.SystemColors.Control
        Me.pagina1.Controls.Add(Me.grupoFiscal)
        Me.pagina1.Controls.Add(Me.grupoDomicilio)
        Me.pagina1.Controls.Add(Me.grupoNombre)
        Me.pagina1.Location = New System.Drawing.Point(4, 22)
        Me.pagina1.Name = "pagina1"
        Me.pagina1.Padding = New System.Windows.Forms.Padding(3)
        Me.pagina1.Size = New System.Drawing.Size(824, 443)
        Me.pagina1.TabIndex = 0
        Me.pagina1.Text = "Datos Identificatorios"
        '
        'grupoFiscal
        '
        Me.grupoFiscal.BackColor = System.Drawing.SystemColors.Control
        Me.grupoFiscal.Controls.Add(Me.cboIva)
        Me.grupoFiscal.Controls.Add(Me.Label4)
        Me.grupoFiscal.Controls.Add(Me.txtCuit)
        Me.grupoFiscal.Controls.Add(Me.Label17)
        Me.grupoFiscal.Location = New System.Drawing.Point(15, 343)
        Me.grupoFiscal.Name = "grupoFiscal"
        Me.grupoFiscal.Size = New System.Drawing.Size(795, 87)
        Me.grupoFiscal.TabIndex = 3
        Me.grupoFiscal.TabStop = False
        Me.grupoFiscal.Text = "Datos de Interés Fiscal"
        '
        'cboIva
        '
        Me.cboIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIva.FormattingEnabled = True
        Me.cboIva.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cboIva.Location = New System.Drawing.Point(330, 27)
        Me.cboIva.Name = "cboIva"
        Me.cboIva.Size = New System.Drawing.Size(264, 21)
        Me.cboIva.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "I.V.A.:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCuit
        '
        Me.txtCuit.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtCuit.Location = New System.Drawing.Point(101, 28)
        Me.txtCuit.Mask = "99 - 99999999 - 9"
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(136, 20)
        Me.txtCuit.TabIndex = 20
        Me.txtCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCuit.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(26, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 20)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "C.U.I.T.:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grupoDomicilio
        '
        Me.grupoDomicilio.Controls.Add(Me.txtLocalidad)
        Me.grupoDomicilio.Controls.Add(Me.btnEliminarDomicilio)
        Me.grupoDomicilio.Controls.Add(Me.btnAgregarDomicilio)
        Me.grupoDomicilio.Controls.Add(Me.cboLocalidad)
        Me.grupoDomicilio.Controls.Add(Me.lstDomicilio)
        Me.grupoDomicilio.Controls.Add(Me.Label15)
        Me.grupoDomicilio.Controls.Add(Me.txtCodigoPostal)
        Me.grupoDomicilio.Controls.Add(Me.Label14)
        Me.grupoDomicilio.Controls.Add(Me.Label13)
        Me.grupoDomicilio.Controls.Add(Me.txtPartido)
        Me.grupoDomicilio.Controls.Add(Me.Label5)
        Me.grupoDomicilio.Controls.Add(Me.txtProvincia)
        Me.grupoDomicilio.Controls.Add(Me.txtManzana)
        Me.grupoDomicilio.Controls.Add(Me.txtDpto)
        Me.grupoDomicilio.Controls.Add(Me.Label11)
        Me.grupoDomicilio.Controls.Add(Me.Label12)
        Me.grupoDomicilio.Controls.Add(Me.txtPiso)
        Me.grupoDomicilio.Controls.Add(Me.txtTorre)
        Me.grupoDomicilio.Controls.Add(Me.Label9)
        Me.grupoDomicilio.Controls.Add(Me.Label10)
        Me.grupoDomicilio.Controls.Add(Me.txtSector)
        Me.grupoDomicilio.Controls.Add(Me.txtNumero)
        Me.grupoDomicilio.Controls.Add(Me.txtCalle)
        Me.grupoDomicilio.Controls.Add(Me.Label6)
        Me.grupoDomicilio.Controls.Add(Me.Label7)
        Me.grupoDomicilio.Controls.Add(Me.Label8)
        Me.grupoDomicilio.Controls.Add(Me.opOtro)
        Me.grupoDomicilio.Controls.Add(Me.opFiscal)
        Me.grupoDomicilio.Location = New System.Drawing.Point(15, 157)
        Me.grupoDomicilio.Name = "grupoDomicilio"
        Me.grupoDomicilio.Size = New System.Drawing.Size(796, 180)
        Me.grupoDomicilio.TabIndex = 1
        Me.grupoDomicilio.TabStop = False
        Me.grupoDomicilio.Text = "Domicilios:"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLocalidad.Location = New System.Drawing.Point(116, 69)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(154, 20)
        Me.txtLocalidad.TabIndex = 58
        '
        'btnEliminarDomicilio
        '
        Me.btnEliminarDomicilio.AutoSize = True
        Me.btnEliminarDomicilio.Image = CType(resources.GetObject("btnEliminarDomicilio.Image"), System.Drawing.Image)
        Me.btnEliminarDomicilio.Location = New System.Drawing.Point(747, 40)
        Me.btnEliminarDomicilio.Name = "btnEliminarDomicilio"
        Me.btnEliminarDomicilio.Size = New System.Drawing.Size(28, 22)
        Me.btnEliminarDomicilio.TabIndex = 57
        Me.btnEliminarDomicilio.UseVisualStyleBackColor = True
        '
        'btnAgregarDomicilio
        '
        Me.btnAgregarDomicilio.AutoSize = True
        Me.btnAgregarDomicilio.Image = CType(resources.GetObject("btnAgregarDomicilio.Image"), System.Drawing.Image)
        Me.btnAgregarDomicilio.Location = New System.Drawing.Point(713, 40)
        Me.btnAgregarDomicilio.Name = "btnAgregarDomicilio"
        Me.btnAgregarDomicilio.Size = New System.Drawing.Size(28, 22)
        Me.btnAgregarDomicilio.TabIndex = 56
        Me.btnAgregarDomicilio.UseVisualStyleBackColor = True
        '
        'cboLocalidad
        '
        Me.cboLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboLocalidad.FormattingEnabled = True
        Me.cboLocalidad.Location = New System.Drawing.Point(116, 68)
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(154, 21)
        Me.cboLocalidad.TabIndex = 55
        Me.cboLocalidad.Visible = False
        '
        'lstDomicilio
        '
        Me.lstDomicilio.AllowUserToAddRows = False
        Me.lstDomicilio.AllowUserToDeleteRows = False
        Me.lstDomicilio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.lstDomicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstDomicilio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipoDomicilio, Me.descrpcionTD, Me.calle, Me.numero, Me.sector, Me.torre, Me.piso, Me.dpto, Me.manzana, Me.idlocalidad, Me.localidad, Me.codigoPostal, Me.idDomicilio})
        Me.lstDomicilio.Location = New System.Drawing.Point(28, 94)
        Me.lstDomicilio.MultiSelect = False
        Me.lstDomicilio.Name = "lstDomicilio"
        Me.lstDomicilio.ReadOnly = True
        Me.lstDomicilio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lstDomicilio.Size = New System.Drawing.Size(747, 75)
        Me.lstDomicilio.TabIndex = 2
        '
        'tipoDomicilio
        '
        Me.tipoDomicilio.HeaderText = "tipoDomicilio"
        Me.tipoDomicilio.Name = "tipoDomicilio"
        Me.tipoDomicilio.ReadOnly = True
        Me.tipoDomicilio.Visible = False
        '
        'descrpcionTD
        '
        Me.descrpcionTD.HeaderText = "Domicilio"
        Me.descrpcionTD.Name = "descrpcionTD"
        Me.descrpcionTD.ReadOnly = True
        '
        'calle
        '
        Me.calle.HeaderText = "Calle"
        Me.calle.Name = "calle"
        Me.calle.ReadOnly = True
        '
        'numero
        '
        Me.numero.HeaderText = "N°"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        '
        'sector
        '
        Me.sector.HeaderText = "Sector"
        Me.sector.Name = "sector"
        Me.sector.ReadOnly = True
        Me.sector.Visible = False
        '
        'torre
        '
        Me.torre.HeaderText = "Torre"
        Me.torre.Name = "torre"
        Me.torre.ReadOnly = True
        Me.torre.Visible = False
        '
        'piso
        '
        Me.piso.HeaderText = "Piso"
        Me.piso.Name = "piso"
        Me.piso.ReadOnly = True
        Me.piso.Visible = False
        '
        'dpto
        '
        Me.dpto.HeaderText = "Dpto"
        Me.dpto.Name = "dpto"
        Me.dpto.ReadOnly = True
        Me.dpto.Visible = False
        '
        'manzana
        '
        Me.manzana.HeaderText = "Manzana"
        Me.manzana.Name = "manzana"
        Me.manzana.ReadOnly = True
        Me.manzana.Visible = False
        '
        'idlocalidad
        '
        Me.idlocalidad.HeaderText = "Localidad"
        Me.idlocalidad.Name = "idlocalidad"
        Me.idlocalidad.ReadOnly = True
        Me.idlocalidad.Visible = False
        '
        'localidad
        '
        Me.localidad.HeaderText = "localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        '
        'codigoPostal
        '
        Me.codigoPostal.HeaderText = "C.P"
        Me.codigoPostal.Name = "codigoPostal"
        Me.codigoPostal.ReadOnly = True
        '
        'idDomicilio
        '
        Me.idDomicilio.HeaderText = "idDomicilio"
        Me.idDomicilio.Name = "idDomicilio"
        Me.idDomicilio.ReadOnly = True
        Me.idDomicilio.Visible = False
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(572, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Provincia:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Location = New System.Drawing.Point(333, 68)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(53, 20)
        Me.txtCodigoPostal.TabIndex = 47
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(276, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 20)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "C.P.:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(392, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 20)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Dpto."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPartido
        '
        Me.txtPartido.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtPartido.Location = New System.Drawing.Point(441, 68)
        Me.txtPartido.Name = "txtPartido"
        Me.txtPartido.ReadOnly = True
        Me.txtPartido.Size = New System.Drawing.Size(125, 20)
        Me.txtPartido.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Localidad:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProvincia
        '
        Me.txtProvincia.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtProvincia.Location = New System.Drawing.Point(650, 68)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.ReadOnly = True
        Me.txtProvincia.Size = New System.Drawing.Size(125, 20)
        Me.txtProvincia.TabIndex = 43
        '
        'txtManzana
        '
        Me.txtManzana.Location = New System.Drawing.Point(572, 44)
        Me.txtManzana.Name = "txtManzana"
        Me.txtManzana.Size = New System.Drawing.Size(53, 20)
        Me.txtManzana.TabIndex = 41
        '
        'txtDpto
        '
        Me.txtDpto.Location = New System.Drawing.Point(441, 44)
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.Size = New System.Drawing.Size(53, 20)
        Me.txtDpto.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(500, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 20)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Manzana:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(392, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 20)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Dpto:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPiso
        '
        Me.txtPiso.Location = New System.Drawing.Point(333, 43)
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(53, 20)
        Me.txtPiso.TabIndex = 37
        '
        'txtTorre
        '
        Me.txtTorre.Location = New System.Drawing.Point(217, 43)
        Me.txtTorre.Name = "txtTorre"
        Me.txtTorre.Size = New System.Drawing.Size(53, 20)
        Me.txtTorre.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(276, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Piso:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(155, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 20)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Torre:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSector
        '
        Me.txtSector.Location = New System.Drawing.Point(96, 42)
        Me.txtSector.Name = "txtSector"
        Me.txtSector.Size = New System.Drawing.Size(53, 20)
        Me.txtSector.TabIndex = 32
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(441, 17)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(53, 20)
        Me.txtNumero.TabIndex = 31
        '
        'txtCalle
        '
        Me.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalle.Location = New System.Drawing.Point(217, 17)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(169, 20)
        Me.txtCalle.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Sector:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(392, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "N°"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(155, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Calle:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'opOtro
        '
        Me.opOtro.AutoSize = True
        Me.opOtro.Location = New System.Drawing.Point(100, 21)
        Me.opOtro.Name = "opOtro"
        Me.opOtro.Size = New System.Drawing.Size(45, 17)
        Me.opOtro.TabIndex = 25
        Me.opOtro.TabStop = True
        Me.opOtro.Text = "Otro"
        Me.opOtro.UseVisualStyleBackColor = True
        '
        'opFiscal
        '
        Me.opFiscal.AutoSize = True
        Me.opFiscal.Location = New System.Drawing.Point(33, 20)
        Me.opFiscal.Name = "opFiscal"
        Me.opFiscal.Size = New System.Drawing.Size(52, 17)
        Me.opFiscal.TabIndex = 24
        Me.opFiscal.TabStop = True
        Me.opFiscal.Text = "Fiscal"
        Me.opFiscal.UseVisualStyleBackColor = True
        '
        'grupoNombre
        '
        Me.grupoNombre.BackColor = System.Drawing.SystemColors.Control
        Me.grupoNombre.Controls.Add(Me.txtMail)
        Me.grupoNombre.Controls.Add(Me.Label16)
        Me.grupoNombre.Controls.Add(Me.opJurídica)
        Me.grupoNombre.Controls.Add(Me.opFísica)
        Me.grupoNombre.Controls.Add(Me.dtpFecha)
        Me.grupoNombre.Controls.Add(Me.txtApellidoMaterno)
        Me.grupoNombre.Controls.Add(Me.txtApellido)
        Me.grupoNombre.Controls.Add(Me.txtNombre)
        Me.grupoNombre.Controls.Add(Me.lblFecha)
        Me.grupoNombre.Controls.Add(Me.Label3)
        Me.grupoNombre.Controls.Add(Me.Label2)
        Me.grupoNombre.Controls.Add(Me.Label1)
        Me.grupoNombre.Location = New System.Drawing.Point(15, 13)
        Me.grupoNombre.Name = "grupoNombre"
        Me.grupoNombre.Size = New System.Drawing.Size(795, 138)
        Me.grupoNombre.TabIndex = 0
        Me.grupoNombre.TabStop = False
        Me.grupoNombre.Text = "Nombre y otros datos"
        '
        'txtMail
        '
        Me.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMail.Location = New System.Drawing.Point(408, 104)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(217, 20)
        Me.txtMail.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(328, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 20)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "E-mail:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'opJurídica
        '
        Me.opJurídica.AutoSize = True
        Me.opJurídica.Location = New System.Drawing.Point(154, 19)
        Me.opJurídica.Name = "opJurídica"
        Me.opJurídica.Size = New System.Drawing.Size(105, 17)
        Me.opJurídica.TabIndex = 23
        Me.opJurídica.TabStop = True
        Me.opJurídica.Text = "Persona Jurídica"
        Me.opJurídica.UseVisualStyleBackColor = True
        '
        'opFísica
        '
        Me.opFísica.AutoSize = True
        Me.opFísica.Location = New System.Drawing.Point(27, 19)
        Me.opFísica.Name = "opFísica"
        Me.opFísica.Size = New System.Drawing.Size(96, 17)
        Me.opFísica.TabIndex = 22
        Me.opFísica.TabStop = True
        Me.opFísica.Text = "Persona Física"
        Me.opFísica.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(154, 71)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(154, 20)
        Me.dtpFecha.TabIndex = 21
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(154, 105)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(154, 20)
        Me.txtApellidoMaterno.TabIndex = 20
        Me.txtApellidoMaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtApellido
        '
        Me.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellido.Location = New System.Drawing.Point(408, 39)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(125, 20)
        Me.txtApellido.TabIndex = 19
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(154, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(154, 20)
        Me.txtNombre.TabIndex = 18
        '
        'lblFecha
        '
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(27, 73)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(121, 20)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha Nacimiento:"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Teléfono"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(328, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'alerta
        '
        Me.alerta.ContainerControl = Me
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 568)
        Me.Controls.Add(Me.pestanas)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.tssMenuCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Clientes"
        Me.tssMenuCliente.ResumeLayout(False)
        Me.tssMenuCliente.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.pestanas.ResumeLayout(False)
        Me.pagina1.ResumeLayout(False)
        Me.grupoFiscal.ResumeLayout(False)
        Me.grupoFiscal.PerformLayout()
        Me.grupoDomicilio.ResumeLayout(False)
        Me.grupoDomicilio.PerformLayout()
        CType(Me.lstDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoNombre.ResumeLayout(False)
        Me.grupoNombre.PerformLayout()
        CType(Me.alerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tssMenuCliente As System.Windows.Forms.ToolStrip
    Friend WithEvents tssBtnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssBtnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssBtnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssBtnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssBtnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents pestanas As System.Windows.Forms.TabControl
    Friend WithEvents pagina1 As System.Windows.Forms.TabPage
    Friend WithEvents grupoDomicilio As System.Windows.Forms.GroupBox
    Friend WithEvents grupoNombre As System.Windows.Forms.GroupBox
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents opJurídica As System.Windows.Forms.RadioButton
    Friend WithEvents opFísica As System.Windows.Forms.RadioButton
    Friend WithEvents opOtro As System.Windows.Forms.RadioButton
    Friend WithEvents opFiscal As System.Windows.Forms.RadioButton
    Friend WithEvents txtManzana As System.Windows.Forms.TextBox
    Friend WithEvents txtDpto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPiso As System.Windows.Forms.TextBox
    Friend WithEvents txtTorre As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSector As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPartido As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstDomicilio As System.Windows.Forms.DataGridView
    Friend WithEvents cboLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminarDomicilio As System.Windows.Forms.Button
    Friend WithEvents btnAgregarDomicilio As System.Windows.Forms.Button
    Friend WithEvents tipoDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrpcionTD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents torre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents piso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dpto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents manzana As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idlocalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigoPostal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents grupoFiscal As GroupBox
    Friend WithEvents cboIva As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCuit As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents alerta As ErrorProvider
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label16 As Label
End Class
