<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarteraCheque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCarteraCheque))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lstCheques = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.opEnCartera = New System.Windows.Forms.CheckBox()
        Me.txtRazonSocialCliente = New System.Windows.Forms.TextBox()
        Me.opClientes = New System.Windows.Forms.CheckBox()
        Me.opFecha = New System.Windows.Forms.CheckBox()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpFiltro = New System.Windows.Forms.RadioButton()
        Me.opTodosCheques = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.idCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enCartera = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.destinatario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.lstCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCheques
        '
        Me.lstCheques.AllowUserToAddRows = False
        Me.lstCheques.AllowUserToDeleteRows = False
        Me.lstCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstCheques.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCheque, Me.NroCheque, Me.Emisor, Me.FechaVto, Me.Comprobante, Me.Cliente, Me.monto, Me.enCartera, Me.destinatario})
        Me.lstCheques.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.lstCheques.Location = New System.Drawing.Point(11, 123)
        Me.lstCheques.MultiSelect = False
        Me.lstCheques.Name = "lstCheques"
        Me.lstCheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lstCheques.Size = New System.Drawing.Size(831, 259)
        Me.lstCheques.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.Controls.Add(Me.btnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 388)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(854, 43)
        Me.Panel3.TabIndex = 46
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(668, 8)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 31
        Me.btnAceptar.Text = "Cerrar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.opEnCartera)
        Me.Panel1.Controls.Add(Me.txtRazonSocialCliente)
        Me.Panel1.Controls.Add(Me.opClientes)
        Me.Panel1.Controls.Add(Me.opFecha)
        Me.Panel1.Controls.Add(Me.dtpFechaHasta)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtpFechaDesde)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnBuscarCliente)
        Me.Panel1.Controls.Add(Me.txtCodCliente)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.OpFiltro)
        Me.Panel1.Controls.Add(Me.opTodosCheques)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(854, 117)
        Me.Panel1.TabIndex = 54
        '
        'opEnCartera
        '
        Me.opEnCartera.AutoSize = True
        Me.opEnCartera.Location = New System.Drawing.Point(271, 72)
        Me.opEnCartera.Name = "opEnCartera"
        Me.opEnCartera.Size = New System.Drawing.Size(76, 17)
        Me.opEnCartera.TabIndex = 27
        Me.opEnCartera.Text = "En Cartera"
        Me.opEnCartera.UseVisualStyleBackColor = True
        '
        'txtRazonSocialCliente
        '
        Me.txtRazonSocialCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtRazonSocialCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocialCliente.Location = New System.Drawing.Point(491, 17)
        Me.txtRazonSocialCliente.Name = "txtRazonSocialCliente"
        Me.txtRazonSocialCliente.ReadOnly = True
        Me.txtRazonSocialCliente.Size = New System.Drawing.Size(208, 20)
        Me.txtRazonSocialCliente.TabIndex = 26
        Me.txtRazonSocialCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'opClientes
        '
        Me.opClientes.AutoSize = True
        Me.opClientes.Location = New System.Drawing.Point(271, 19)
        Me.opClientes.Name = "opClientes"
        Me.opClientes.Size = New System.Drawing.Size(63, 17)
        Me.opClientes.TabIndex = 25
        Me.opClientes.Text = "Clientes"
        Me.opClientes.UseVisualStyleBackColor = True
        '
        'opFecha
        '
        Me.opFecha.AutoSize = True
        Me.opFecha.Location = New System.Drawing.Point(271, 46)
        Me.opFecha.Name = "opFecha"
        Me.opFecha.Size = New System.Drawing.Size(78, 17)
        Me.opFecha.TabIndex = 24
        Me.opFecha.Text = "Fecha Vto."
        Me.opFecha.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(648, 44)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaHasta.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(553, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Fecha Hasta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(462, 44)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaDesde.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(367, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fecha Desde:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.AutoSize = True
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(705, 16)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(28, 22)
        Me.btnBuscarCliente.TabIndex = 19
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCliente.Location = New System.Drawing.Point(428, 17)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(57, 20)
        Me.txtCodCliente.TabIndex = 17
        Me.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(366, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpFiltro
        '
        Me.OpFiltro.AutoSize = True
        Me.OpFiltro.Location = New System.Drawing.Point(132, 18)
        Me.OpFiltro.Name = "OpFiltro"
        Me.OpFiltro.Size = New System.Drawing.Size(133, 17)
        Me.OpFiltro.TabIndex = 5
        Me.OpFiltro.TabStop = True
        Me.OpFiltro.Text = "Aplicar Filtro Búsqueda"
        Me.OpFiltro.UseVisualStyleBackColor = True
        '
        'opTodosCheques
        '
        Me.opTodosCheques.AutoSize = True
        Me.opTodosCheques.Location = New System.Drawing.Point(10, 16)
        Me.opTodosCheques.Name = "opTodosCheques"
        Me.opTodosCheques.Size = New System.Drawing.Size(116, 17)
        Me.opTodosCheques.TabIndex = 1
        Me.opTodosCheques.TabStop = True
        Me.opTodosCheques.Text = "Todos los Cheques"
        Me.opTodosCheques.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(619, 72)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(114, 29)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Aplicar Búsqueda"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'idCheque
        '
        Me.idCheque.HeaderText = "idCheque"
        Me.idCheque.Name = "idCheque"
        Me.idCheque.ReadOnly = True
        Me.idCheque.Visible = False
        '
        'NroCheque
        '
        Me.NroCheque.FillWeight = 80.0!
        Me.NroCheque.HeaderText = "Nro. Cheque"
        Me.NroCheque.Name = "NroCheque"
        Me.NroCheque.ReadOnly = True
        Me.NroCheque.Width = 80
        '
        'Emisor
        '
        Me.Emisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Emisor.HeaderText = "Emisor"
        Me.Emisor.Name = "Emisor"
        Me.Emisor.ReadOnly = True
        '
        'FechaVto
        '
        Me.FechaVto.FillWeight = 70.0!
        Me.FechaVto.HeaderText = "Fecha Vto"
        Me.FechaVto.Name = "FechaVto"
        Me.FechaVto.ReadOnly = True
        Me.FechaVto.Width = 70
        '
        'Comprobante
        '
        Me.Comprobante.FillWeight = 120.0!
        Me.Comprobante.HeaderText = "Comprobante"
        Me.Comprobante.Name = "Comprobante"
        Me.Comprobante.ReadOnly = True
        Me.Comprobante.Width = 120
        '
        'Cliente
        '
        Me.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'monto
        '
        Me.monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.monto.DefaultCellStyle = DataGridViewCellStyle1
        Me.monto.FillWeight = 80.0!
        Me.monto.HeaderText = "Importe"
        Me.monto.Name = "monto"
        Me.monto.Width = 80
        '
        'enCartera
        '
        Me.enCartera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.enCartera.FillWeight = 60.0!
        Me.enCartera.HeaderText = "En Cartera"
        Me.enCartera.Name = "enCartera"
        Me.enCartera.Width = 60
        '
        'destinatario
        '
        Me.destinatario.HeaderText = "Destinatario"
        Me.destinatario.Name = "destinatario"
        '
        'frmCarteraCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 431)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lstCheques)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarteraCheque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cartera de Cheques"
        CType(Me.lstCheques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstCheques As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents opEnCartera As CheckBox
    Friend WithEvents txtRazonSocialCliente As TextBox
    Friend WithEvents opClientes As CheckBox
    Friend WithEvents opFecha As CheckBox
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpFiltro As RadioButton
    Friend WithEvents opTodosCheques As RadioButton
    Friend WithEvents btnBuscar As Button
    Friend WithEvents idCheque As DataGridViewTextBoxColumn
    Friend WithEvents NroCheque As DataGridViewTextBoxColumn
    Friend WithEvents Emisor As DataGridViewTextBoxColumn
    Friend WithEvents FechaVto As DataGridViewTextBoxColumn
    Friend WithEvents Comprobante As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents enCartera As DataGridViewCheckBoxColumn
    Friend WithEvents destinatario As DataGridViewTextBoxColumn
End Class
