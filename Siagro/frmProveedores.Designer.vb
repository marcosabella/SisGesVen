<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.pestanas = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.opJurídica = New System.Windows.Forms.RadioButton()
        Me.opFísica = New System.Windows.Forms.RadioButton()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grupoDatosFiscal = New System.Windows.Forms.GroupBox()
        Me.cboIva = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCodDcumento = New System.Windows.Forms.ComboBox()
        Me.txtIIBB = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.grupoResponsables = New System.Windows.Forms.GroupBox()
        Me.txtNombreResponsable = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTelefonoResponsable = New System.Windows.Forms.MaskedTextBox()
        Me.btnBorrarResponsable = New System.Windows.Forms.Button()
        Me.btnAgregarResponsable = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lstResponsable = New System.Windows.Forms.DataGridView()
        Me.idResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pais = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tssMenuCliente = New System.Windows.Forms.ToolStrip()
        Me.tssBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tssBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tssBtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssBtnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssBtnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.alerta = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pestanas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grupoDomicilio.SuspendLayout()
        CType(Me.lstDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoNombre.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grupoDatosFiscal.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.grupoResponsables.SuspendLayout()
        CType(Me.lstResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.tssMenuCliente.SuspendLayout()
        CType(Me.alerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pestanas
        '
        Me.pestanas.Controls.Add(Me.TabPage1)
        Me.pestanas.Controls.Add(Me.TabPage2)
        Me.pestanas.Controls.Add(Me.TabPage3)
        Me.pestanas.Location = New System.Drawing.Point(6, 50)
        Me.pestanas.Name = "pestanas"
        Me.pestanas.SelectedIndex = 0
        Me.pestanas.Size = New System.Drawing.Size(832, 346)
        Me.pestanas.TabIndex = 49
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.grupoDomicilio)
        Me.TabPage1.Controls.Add(Me.grupoNombre)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(824, 320)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Identificatorios"
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
        Me.grupoDomicilio.Location = New System.Drawing.Point(14, 96)
        Me.grupoDomicilio.Name = "grupoDomicilio"
        Me.grupoDomicilio.Size = New System.Drawing.Size(796, 180)
        Me.grupoDomicilio.TabIndex = 24
        Me.grupoDomicilio.TabStop = False
        Me.grupoDomicilio.Text = "Domicilios:"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLocalidad.Location = New System.Drawing.Point(116, 68)
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
        Me.grupoNombre.Controls.Add(Me.opJurídica)
        Me.grupoNombre.Controls.Add(Me.opFísica)
        Me.grupoNombre.Controls.Add(Me.txtRazonSocial)
        Me.grupoNombre.Controls.Add(Me.Label1)
        Me.grupoNombre.Location = New System.Drawing.Point(15, 13)
        Me.grupoNombre.Name = "grupoNombre"
        Me.grupoNombre.Size = New System.Drawing.Size(795, 77)
        Me.grupoNombre.TabIndex = 0
        Me.grupoNombre.TabStop = False
        Me.grupoNombre.Text = "Nombre y otros datos"
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
        'txtRazonSocial
        '
        Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonSocial.Location = New System.Drawing.Point(154, 39)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(620, 20)
        Me.txtRazonSocial.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Razón Social:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.grupoDatosFiscal)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(824, 320)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos Comerciales"
        '
        'grupoDatosFiscal
        '
        Me.grupoDatosFiscal.BackColor = System.Drawing.SystemColors.Control
        Me.grupoDatosFiscal.Controls.Add(Me.cboIva)
        Me.grupoDatosFiscal.Controls.Add(Me.Label4)
        Me.grupoDatosFiscal.Controls.Add(Me.cboCodDcumento)
        Me.grupoDatosFiscal.Controls.Add(Me.txtIIBB)
        Me.grupoDatosFiscal.Controls.Add(Me.Label16)
        Me.grupoDatosFiscal.Controls.Add(Me.txtCuit)
        Me.grupoDatosFiscal.Controls.Add(Me.Label17)
        Me.grupoDatosFiscal.Location = New System.Drawing.Point(15, 15)
        Me.grupoDatosFiscal.Name = "grupoDatosFiscal"
        Me.grupoDatosFiscal.Size = New System.Drawing.Size(795, 79)
        Me.grupoDatosFiscal.TabIndex = 2
        Me.grupoDatosFiscal.TabStop = False
        Me.grupoDatosFiscal.Text = "Datos de Interés Fiscal"
        '
        'cboIva
        '
        Me.cboIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIva.FormattingEnabled = True
        Me.cboIva.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cboIva.Location = New System.Drawing.Point(449, 28)
        Me.cboIva.Name = "cboIva"
        Me.cboIva.Size = New System.Drawing.Size(152, 21)
        Me.cboIva.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(374, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "I.V.A.:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboCodDcumento
        '
        Me.cboCodDcumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboCodDcumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodDcumento.FormattingEnabled = True
        Me.cboCodDcumento.Location = New System.Drawing.Point(101, 28)
        Me.cboCodDcumento.Name = "cboCodDcumento"
        Me.cboCodDcumento.Size = New System.Drawing.Size(154, 21)
        Me.cboCodDcumento.TabIndex = 56
        '
        'txtIIBB
        '
        Me.txtIIBB.Location = New System.Drawing.Point(682, 28)
        Me.txtIIBB.Mask = "999999999"
        Me.txtIIBB.Name = "txtIIBB"
        Me.txtIIBB.Size = New System.Drawing.Size(107, 20)
        Me.txtIIBB.TabIndex = 22
        Me.txtIIBB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(607, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 20)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "I.I.B.B:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCuit
        '
        Me.txtCuit.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.txtCuit.Location = New System.Drawing.Point(261, 28)
        Me.txtCuit.Mask = "99 - 99999999 - 9"
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(107, 20)
        Me.txtCuit.TabIndex = 20
        Me.txtCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(26, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 20)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Cód. Doc."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.grupoResponsables)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(824, 320)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Persona de Contacto"
        '
        'grupoResponsables
        '
        Me.grupoResponsables.Controls.Add(Me.txtNombreResponsable)
        Me.grupoResponsables.Controls.Add(Me.Label22)
        Me.grupoResponsables.Controls.Add(Me.txtTelefonoResponsable)
        Me.grupoResponsables.Controls.Add(Me.btnBorrarResponsable)
        Me.grupoResponsables.Controls.Add(Me.btnAgregarResponsable)
        Me.grupoResponsables.Controls.Add(Me.Label20)
        Me.grupoResponsables.Controls.Add(Me.lstResponsable)
        Me.grupoResponsables.Location = New System.Drawing.Point(17, 6)
        Me.grupoResponsables.Name = "grupoResponsables"
        Me.grupoResponsables.Size = New System.Drawing.Size(792, 388)
        Me.grupoResponsables.TabIndex = 1
        Me.grupoResponsables.TabStop = False
        '
        'txtNombreResponsable
        '
        Me.txtNombreResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreResponsable.Location = New System.Drawing.Point(151, 34)
        Me.txtNombreResponsable.Name = "txtNombreResponsable"
        Me.txtNombreResponsable.Size = New System.Drawing.Size(154, 20)
        Me.txtNombreResponsable.TabIndex = 60
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 34)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(121, 20)
        Me.Label22.TabIndex = 59
        Me.Label22.Text = "Nombre:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelefonoResponsable
        '
        Me.txtTelefonoResponsable.Location = New System.Drawing.Point(373, 35)
        Me.txtTelefonoResponsable.Mask = "99999999999999"
        Me.txtTelefonoResponsable.Name = "txtTelefonoResponsable"
        Me.txtTelefonoResponsable.Size = New System.Drawing.Size(151, 20)
        Me.txtTelefonoResponsable.TabIndex = 58
        '
        'btnBorrarResponsable
        '
        Me.btnBorrarResponsable.AutoSize = True
        Me.btnBorrarResponsable.Image = CType(resources.GetObject("btnBorrarResponsable.Image"), System.Drawing.Image)
        Me.btnBorrarResponsable.Location = New System.Drawing.Point(740, 32)
        Me.btnBorrarResponsable.Name = "btnBorrarResponsable"
        Me.btnBorrarResponsable.Size = New System.Drawing.Size(28, 22)
        Me.btnBorrarResponsable.TabIndex = 57
        Me.btnBorrarResponsable.UseVisualStyleBackColor = True
        '
        'btnAgregarResponsable
        '
        Me.btnAgregarResponsable.AutoSize = True
        Me.btnAgregarResponsable.Image = CType(resources.GetObject("btnAgregarResponsable.Image"), System.Drawing.Image)
        Me.btnAgregarResponsable.Location = New System.Drawing.Point(706, 32)
        Me.btnAgregarResponsable.Name = "btnAgregarResponsable"
        Me.btnAgregarResponsable.Size = New System.Drawing.Size(28, 22)
        Me.btnAgregarResponsable.TabIndex = 56
        Me.btnAgregarResponsable.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(311, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 20)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "Tel:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstResponsable
        '
        Me.lstResponsable.AllowUserToAddRows = False
        Me.lstResponsable.AllowUserToDeleteRows = False
        Me.lstResponsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstResponsable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idResponsable, Me.dni, Me.nombre, Me.Pais})
        Me.lstResponsable.Location = New System.Drawing.Point(24, 63)
        Me.lstResponsable.Name = "lstResponsable"
        Me.lstResponsable.ReadOnly = True
        Me.lstResponsable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lstResponsable.Size = New System.Drawing.Size(744, 294)
        Me.lstResponsable.TabIndex = 54
        '
        'idResponsable
        '
        Me.idResponsable.HeaderText = "idResponsable"
        Me.idResponsable.Name = "idResponsable"
        Me.idResponsable.ReadOnly = True
        Me.idResponsable.Visible = False
        '
        'dni
        '
        Me.dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dni.HeaderText = "Teléfono"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        Me.dni.Width = 351
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'Pais
        '
        Me.Pais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Pais.HeaderText = "Pais"
        Me.Pais.Name = "Pais"
        Me.Pais.ReadOnly = True
        Me.Pais.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 403)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(858, 43)
        Me.Panel3.TabIndex = 50
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
        'tssMenuCliente
        '
        Me.tssMenuCliente.AutoSize = False
        Me.tssMenuCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tssMenuCliente.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.tssMenuCliente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssBtnNuevo, Me.tssBtnEliminar, Me.tssBtnModificar, Me.ToolStripSeparator1, Me.tssBtnConsultar, Me.ToolStripSeparator2, Me.tssBtnCerrar})
        Me.tssMenuCliente.Location = New System.Drawing.Point(0, 0)
        Me.tssMenuCliente.Name = "tssMenuCliente"
        Me.tssMenuCliente.Size = New System.Drawing.Size(858, 42)
        Me.tssMenuCliente.TabIndex = 51
        Me.tssMenuCliente.Text = "tssClientes"
        '
        'tssBtnNuevo
        '
        Me.tssBtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tssBtnNuevo.Image = CType(resources.GetObject("tssBtnNuevo.Image"), System.Drawing.Image)
        Me.tssBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssBtnNuevo.Name = "tssBtnNuevo"
        Me.tssBtnNuevo.Size = New System.Drawing.Size(42, 39)
        Me.tssBtnNuevo.Text = "Nuevo"
        Me.tssBtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tssBtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tssBtnEliminar
        '
        Me.tssBtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tssBtnEliminar.Image = CType(resources.GetObject("tssBtnEliminar.Image"), System.Drawing.Image)
        Me.tssBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssBtnEliminar.Name = "tssBtnEliminar"
        Me.tssBtnEliminar.Size = New System.Drawing.Size(47, 39)
        Me.tssBtnEliminar.Text = "Eliminar"
        Me.tssBtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tssBtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tssBtnModificar
        '
        Me.tssBtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tssBtnModificar.Image = CType(resources.GetObject("tssBtnModificar.Image"), System.Drawing.Image)
        Me.tssBtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssBtnModificar.Name = "tssBtnModificar"
        Me.tssBtnModificar.Size = New System.Drawing.Size(54, 39)
        Me.tssBtnModificar.Text = "Modificar"
        Me.tssBtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tssBtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 42)
        '
        'tssBtnConsultar
        '
        Me.tssBtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tssBtnConsultar.Image = CType(resources.GetObject("tssBtnConsultar.Image"), System.Drawing.Image)
        Me.tssBtnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssBtnConsultar.Name = "tssBtnConsultar"
        Me.tssBtnConsultar.Size = New System.Drawing.Size(57, 39)
        Me.tssBtnConsultar.Text = "Consultar"
        Me.tssBtnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tssBtnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 42)
        '
        'tssBtnCerrar
        '
        Me.tssBtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tssBtnCerrar.Image = CType(resources.GetObject("tssBtnCerrar.Image"), System.Drawing.Image)
        Me.tssBtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssBtnCerrar.Name = "tssBtnCerrar"
        Me.tssBtnCerrar.Size = New System.Drawing.Size(42, 39)
        Me.tssBtnCerrar.Text = "Cerrar"
        Me.tssBtnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tssBtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'alerta
        '
        Me.alerta.ContainerControl = Me
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 446)
        Me.Controls.Add(Me.tssMenuCliente)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pestanas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión Proveedores"
        Me.pestanas.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grupoDomicilio.ResumeLayout(False)
        Me.grupoDomicilio.PerformLayout()
        CType(Me.lstDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoNombre.ResumeLayout(False)
        Me.grupoNombre.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.grupoDatosFiscal.ResumeLayout(False)
        Me.grupoDatosFiscal.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.grupoResponsables.ResumeLayout(False)
        Me.grupoResponsables.PerformLayout()
        CType(Me.lstResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.tssMenuCliente.ResumeLayout(False)
        Me.tssMenuCliente.PerformLayout()
        CType(Me.alerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pestanas As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grupoNombre As System.Windows.Forms.GroupBox
    Friend WithEvents opJurídica As System.Windows.Forms.RadioButton
    Friend WithEvents opFísica As System.Windows.Forms.RadioButton
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grupoDatosFiscal As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents tssMenuCliente As System.Windows.Forms.ToolStrip
    Friend WithEvents tssBtnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssBtnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssBtnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssBtnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssBtnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtIIBB As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents grupoDomicilio As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminarDomicilio As System.Windows.Forms.Button
    Friend WithEvents btnAgregarDomicilio As System.Windows.Forms.Button
    Friend WithEvents cboLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents lstDomicilio As System.Windows.Forms.DataGridView
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPartido As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents txtManzana As System.Windows.Forms.TextBox
    Friend WithEvents txtDpto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPiso As System.Windows.Forms.TextBox
    Friend WithEvents txtTorre As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSector As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents opOtro As System.Windows.Forms.RadioButton
    Friend WithEvents opFiscal As System.Windows.Forms.RadioButton
    Friend WithEvents grupoResponsables As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreResponsable As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoResponsable As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnBorrarResponsable As System.Windows.Forms.Button
    Friend WithEvents btnAgregarResponsable As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lstResponsable As System.Windows.Forms.DataGridView
    Friend WithEvents idResponsable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pais As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboCodDcumento As System.Windows.Forms.ComboBox
    Friend WithEvents txtCuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboIva As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents alerta As ErrorProvider
    Friend WithEvents txtLocalidad As TextBox
End Class
