<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroSolicitudes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistroSolicitudes))
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.txtIdCargo = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCodigoI = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSede = New System.Windows.Forms.ComboBox()
        Me.DTPFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbTecnico = New System.Windows.Forms.RadioButton()
        Me.rbSolicitante = New System.Windows.Forms.RadioButton()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbNombreSolicitud = New System.Windows.Forms.RadioButton()
        Me.lblTotalSolicitudes = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvSolicitudes = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreSolici = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prioridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreTecnico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboSolicitud = New System.Windows.Forms.ComboBox()
        Me.CboTecnico = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPrioridad = New System.Windows.Forms.ComboBox()
        Me.btnReporteTotalSolicitudes = New System.Windows.Forms.Button()
        Me.btnSolicitudesPendientes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCargos = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.Location = New System.Drawing.Point(760, 121)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(34, 20)
        Me.txtIdArticulo.TabIndex = 45
        Me.txtIdArticulo.Visible = False
        '
        'txtIdCargo
        '
        Me.txtIdCargo.Location = New System.Drawing.Point(661, 71)
        Me.txtIdCargo.Name = "txtIdCargo"
        Me.txtIdCargo.Size = New System.Drawing.Size(26, 20)
        Me.txtIdCargo.TabIndex = 197
        Me.txtIdCargo.Visible = False
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(511, 71)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(144, 20)
        Me.txtDepartamento.TabIndex = 196
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(390, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 15)
        Me.Label8.TabIndex = 195
        Me.Label8.Text = "Departamento:"
        '
        'txtNombreE
        '
        Me.txtNombreE.Location = New System.Drawing.Point(134, 73)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.Size = New System.Drawing.Size(212, 20)
        Me.txtNombreE.TabIndex = 194
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 38)
        Me.Label12.TabIndex = 193
        Me.Label12.Text = "Nombre Empleado:"
        '
        'txtCodigoI
        '
        Me.txtCodigoI.Location = New System.Drawing.Point(134, 122)
        Me.txtCodigoI.Name = "txtCodigoI"
        Me.txtCodigoI.Size = New System.Drawing.Size(136, 20)
        Me.txtCodigoI.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 39)
        Me.Label7.TabIndex = 190
        Me.Label7.Text = "Código Inventario"
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(470, 122)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.ReadOnly = True
        Me.txtNombreA.Size = New System.Drawing.Size(274, 20)
        Me.txtNombreA.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(316, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 15)
        Me.Label4.TabIndex = 187
        Me.Label4.Text = "Nombre de Artículo:"
        '
        'cboSede
        '
        Me.cboSede.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSede.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSede.FormattingEnabled = True
        Me.cboSede.Items.AddRange(New Object() {"Caribe Principal", "Sabaneta", "Cedi Caribe", "Sede Barranquilla"})
        Me.cboSede.Location = New System.Drawing.Point(134, 173)
        Me.cboSede.Name = "cboSede"
        Me.cboSede.Size = New System.Drawing.Size(179, 21)
        Me.cboSede.TabIndex = 7
        '
        'DTPFechaSolicitud
        '
        Me.DTPFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaSolicitud.Location = New System.Drawing.Point(470, 170)
        Me.DTPFechaSolicitud.Name = "DTPFechaSolicitud"
        Me.DTPFechaSolicitud.Size = New System.Drawing.Size(112, 20)
        Me.DTPFechaSolicitud.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(331, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 15)
        Me.Label11.TabIndex = 177
        Me.Label11.Text = "Fecha de Solicitud"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbTecnico)
        Me.Panel1.Controls.Add(Me.rbSolicitante)
        Me.Panel1.Controls.Add(Me.rbDepartamento)
        Me.Panel1.Controls.Add(Me.rbNombreSolicitud)
        Me.Panel1.Controls.Add(Me.lblTotalSolicitudes)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvSolicitudes)
        Me.Panel1.Location = New System.Drawing.Point(58, 350)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 564)
        Me.Panel1.TabIndex = 176
        '
        'rbTecnico
        '
        Me.rbTecnico.AutoSize = True
        Me.rbTecnico.Location = New System.Drawing.Point(359, 33)
        Me.rbTecnico.Name = "rbTecnico"
        Me.rbTecnico.Size = New System.Drawing.Size(67, 17)
        Me.rbTecnico.TabIndex = 22
        Me.rbTecnico.Text = "Técnico:"
        Me.rbTecnico.UseVisualStyleBackColor = True
        '
        'rbSolicitante
        '
        Me.rbSolicitante.AutoSize = True
        Me.rbSolicitante.Location = New System.Drawing.Point(236, 33)
        Me.rbSolicitante.Name = "rbSolicitante"
        Me.rbSolicitante.Size = New System.Drawing.Size(117, 17)
        Me.rbSolicitante.TabIndex = 20
        Me.rbSolicitante.Text = "Nombre Solicitante:"
        Me.rbSolicitante.UseVisualStyleBackColor = True
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.Location = New System.Drawing.Point(135, 33)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(95, 17)
        Me.rbDepartamento.TabIndex = 19
        Me.rbDepartamento.Text = "Departamento:"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'rbNombreSolicitud
        '
        Me.rbNombreSolicitud.AutoSize = True
        Me.rbNombreSolicitud.Checked = True
        Me.rbNombreSolicitud.Location = New System.Drawing.Point(27, 33)
        Me.rbNombreSolicitud.Name = "rbNombreSolicitud"
        Me.rbNombreSolicitud.Size = New System.Drawing.Size(108, 17)
        Me.rbNombreSolicitud.TabIndex = 18
        Me.rbNombreSolicitud.TabStop = True
        Me.rbNombreSolicitud.Text = "Nombre Solicitud:"
        Me.rbNombreSolicitud.UseVisualStyleBackColor = True
        '
        'lblTotalSolicitudes
        '
        Me.lblTotalSolicitudes.AutoSize = True
        Me.lblTotalSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSolicitudes.Location = New System.Drawing.Point(141, 526)
        Me.lblTotalSolicitudes.Name = "lblTotalSolicitudes"
        Me.lblTotalSolicitudes.Size = New System.Drawing.Size(44, 16)
        Me.lblTotalSolicitudes.TabIndex = 17
        Me.lblTotalSolicitudes.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 526)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Solicitudes Registradss:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Buscar Por:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(553, 30)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(434, 20)
        Me.txtBuscar.TabIndex = 21
        '
        'dgvSolicitudes
        '
        Me.dgvSolicitudes.AllowUserToAddRows = False
        Me.dgvSolicitudes.AllowUserToDeleteRows = False
        Me.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.IdSolicitud, Me.NombreSolici, Me.Prioridad, Me.Sede, Me.FechaSolicitud, Me.Descripcion, Me.NombreA, Me.NombreD, Me.IdArticulo, Me.IdCargo, Me.CodigoInventario, Me.NombreTecnico, Me.EstadoSolicitud})
        Me.dgvSolicitudes.Location = New System.Drawing.Point(22, 70)
        Me.dgvSolicitudes.Name = "dgvSolicitudes"
        Me.dgvSolicitudes.ReadOnly = True
        Me.dgvSolicitudes.RowHeadersVisible = False
        Me.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSolicitudes.Size = New System.Drawing.Size(965, 428)
        Me.dgvSolicitudes.TabIndex = 15
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "NOMBRE SOLICITANTE"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'IdSolicitud
        '
        Me.IdSolicitud.DataPropertyName = "IdSolicitud"
        Me.IdSolicitud.HeaderText = "ID"
        Me.IdSolicitud.Name = "IdSolicitud"
        Me.IdSolicitud.ReadOnly = True
        Me.IdSolicitud.Visible = False
        Me.IdSolicitud.Width = 10
        '
        'NombreSolici
        '
        Me.NombreSolici.DataPropertyName = "NombreSolici"
        Me.NombreSolici.HeaderText = "SOLICITUD"
        Me.NombreSolici.Name = "NombreSolici"
        Me.NombreSolici.ReadOnly = True
        Me.NombreSolici.Width = 200
        '
        'Prioridad
        '
        Me.Prioridad.DataPropertyName = "Prioridad"
        Me.Prioridad.HeaderText = "PRIORIDAD"
        Me.Prioridad.Name = "Prioridad"
        Me.Prioridad.ReadOnly = True
        '
        'Sede
        '
        Me.Sede.DataPropertyName = "Sede"
        Me.Sede.HeaderText = "SEDE"
        Me.Sede.Name = "Sede"
        Me.Sede.ReadOnly = True
        '
        'FechaSolicitud
        '
        Me.FechaSolicitud.DataPropertyName = "FechaSolicitud"
        Me.FechaSolicitud.HeaderText = "FECHA SOLICITUD"
        Me.FechaSolicitud.Name = "FechaSolicitud"
        Me.FechaSolicitud.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "DESCRIPCION"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'NombreA
        '
        Me.NombreA.DataPropertyName = "NombreA"
        Me.NombreA.HeaderText = "NOMBRE ARTICULO"
        Me.NombreA.Name = "NombreA"
        Me.NombreA.ReadOnly = True
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "DEPARTAMENTO"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        '
        'IdArticulo
        '
        Me.IdArticulo.DataPropertyName = "IdArticulo"
        Me.IdArticulo.HeaderText = "IDARTICULO"
        Me.IdArticulo.Name = "IdArticulo"
        Me.IdArticulo.ReadOnly = True
        Me.IdArticulo.Visible = False
        '
        'IdCargo
        '
        Me.IdCargo.DataPropertyName = "IdCargo"
        Me.IdCargo.HeaderText = "IDCARGOACTIVO"
        Me.IdCargo.Name = "IdCargo"
        Me.IdCargo.ReadOnly = True
        Me.IdCargo.Visible = False
        '
        'CodigoInventario
        '
        Me.CodigoInventario.DataPropertyName = "CodigoInventario"
        Me.CodigoInventario.HeaderText = "CODIGO INVENTARIO"
        Me.CodigoInventario.Name = "CodigoInventario"
        Me.CodigoInventario.ReadOnly = True
        Me.CodigoInventario.Visible = False
        '
        'NombreTecnico
        '
        Me.NombreTecnico.DataPropertyName = "NombreTecnico"
        Me.NombreTecnico.HeaderText = "TECNICO ASIGNADO"
        Me.NombreTecnico.Name = "NombreTecnico"
        Me.NombreTecnico.ReadOnly = True
        '
        'EstadoSolicitud
        '
        Me.EstadoSolicitud.DataPropertyName = "EstadoSolicitud"
        Me.EstadoSolicitud.HeaderText = "ESTADO SOLICITUD"
        Me.EstadoSolicitud.Name = "EstadoSolicitud"
        Me.EstadoSolicitud.ReadOnly = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(134, 254)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(558, 80)
        Me.txtDescripcion.TabIndex = 11
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(33, 6)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(34, 20)
        Me.txtId.TabIndex = 175
        Me.txtId.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 174
        Me.Label6.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 173
        Me.Label5.Text = "Sede:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "Solicitud:"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(26, 211)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 35)
        Me.Label16.TabIndex = 211
        Me.Label16.Text = "Asignar Técnico:"
        '
        'cboSolicitud
        '
        Me.cboSolicitud.FormattingEnabled = True
        Me.cboSolicitud.Items.AddRange(New Object() {"Falla en el PC o Portátil", "Falla  TOTVS", "Falla  Impresora", "Falla Teléfono", "Falla Google", "Falla Internet"})
        Me.cboSolicitud.Location = New System.Drawing.Point(134, 23)
        Me.cboSolicitud.Name = "cboSolicitud"
        Me.cboSolicitud.Size = New System.Drawing.Size(216, 21)
        Me.cboSolicitud.TabIndex = 217
        '
        'CboTecnico
        '
        Me.CboTecnico.FormattingEnabled = True
        Me.CboTecnico.Location = New System.Drawing.Point(134, 216)
        Me.CboTecnico.Name = "CboTecnico"
        Me.CboTecnico.Size = New System.Drawing.Size(179, 21)
        Me.CboTecnico.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(406, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 219
        Me.Label2.Text = "Prioridad:"
        '
        'cboPrioridad
        '
        Me.cboPrioridad.FormattingEnabled = True
        Me.cboPrioridad.Items.AddRange(New Object() {"Muy Alta", "Alta", "Media ", "Baja"})
        Me.cboPrioridad.Location = New System.Drawing.Point(511, 23)
        Me.cboPrioridad.Name = "cboPrioridad"
        Me.cboPrioridad.Size = New System.Drawing.Size(144, 21)
        Me.cboPrioridad.TabIndex = 220
        '
        'btnReporteTotalSolicitudes
        '
        Me.btnReporteTotalSolicitudes.BackgroundImage = CType(resources.GetObject("btnReporteTotalSolicitudes.BackgroundImage"), System.Drawing.Image)
        Me.btnReporteTotalSolicitudes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnReporteTotalSolicitudes.Location = New System.Drawing.Point(849, 257)
        Me.btnReporteTotalSolicitudes.Name = "btnReporteTotalSolicitudes"
        Me.btnReporteTotalSolicitudes.Size = New System.Drawing.Size(103, 57)
        Me.btnReporteTotalSolicitudes.TabIndex = 222
        Me.btnReporteTotalSolicitudes.Text = "&Reporte Total Solicitudes "
        Me.btnReporteTotalSolicitudes.UseVisualStyleBackColor = True
        '
        'btnSolicitudesPendientes
        '
        Me.btnSolicitudesPendientes.BackgroundImage = CType(resources.GetObject("btnSolicitudesPendientes.BackgroundImage"), System.Drawing.Image)
        Me.btnSolicitudesPendientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSolicitudesPendientes.Location = New System.Drawing.Point(725, 257)
        Me.btnSolicitudesPendientes.Name = "btnSolicitudesPendientes"
        Me.btnSolicitudesPendientes.Size = New System.Drawing.Size(103, 57)
        Me.btnSolicitudesPendientes.TabIndex = 221
        Me.btnSolicitudesPendientes.Text = "&Reporte Solicitudes Pendientes"
        Me.btnSolicitudesPendientes.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(352, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 27)
        Me.Button1.TabIndex = 218
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCargos
        '
        Me.btnCargos.BackgroundImage = CType(resources.GetObject("btnCargos.BackgroundImage"), System.Drawing.Image)
        Me.btnCargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCargos.Location = New System.Drawing.Point(276, 118)
        Me.btnCargos.Name = "btnCargos"
        Me.btnCargos.Size = New System.Drawing.Size(29, 27)
        Me.btnCargos.TabIndex = 6
        Me.btnCargos.Text = "..."
        Me.btnCargos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Location = New System.Drawing.Point(1034, 182)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 38)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.Location = New System.Drawing.Point(925, 112)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 38)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar.Location = New System.Drawing.Point(1034, 63)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 38)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "E&liminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.Location = New System.Drawing.Point(925, 63)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 38)
        Me.btnEditar.TabIndex = 14
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Location = New System.Drawing.Point(1034, 19)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 38)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = CType(resources.GetObject("btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.Location = New System.Drawing.Point(925, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 38)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmRegistroSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 933)
        Me.Controls.Add(Me.btnReporteTotalSolicitudes)
        Me.Controls.Add(Me.btnSolicitudesPendientes)
        Me.Controls.Add(Me.cboPrioridad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboSolicitud)
        Me.Controls.Add(Me.CboTecnico)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtIdArticulo)
        Me.Controls.Add(Me.txtIdCargo)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNombreE)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnCargos)
        Me.Controls.Add(Me.txtCodigoI)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNombreA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboSede)
        Me.Controls.Add(Me.DTPFechaSolicitud)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistroSolicitudes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Solicitudes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdArticulo As TextBox
    Friend WithEvents txtIdCargo As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnCargos As Button
    Friend WithEvents txtCodigoI As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombreA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboSede As ComboBox
    Friend WithEvents DTPFechaSolicitud As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbSolicitante As RadioButton
    Friend WithEvents rbDepartamento As RadioButton
    Friend WithEvents rbNombreSolicitud As RadioButton
    Friend WithEvents lblTotalSolicitudes As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvSolicitudes As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cboSolicitud As ComboBox
    Friend WithEvents CboTecnico As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboPrioridad As ComboBox
    Friend WithEvents rbTecnico As RadioButton
    Friend WithEvents btnSolicitudesPendientes As Button
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents IdSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents NombreSolici As DataGridViewTextBoxColumn
    Friend WithEvents Prioridad As DataGridViewTextBoxColumn
    Friend WithEvents Sede As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents NombreA As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents IdArticulo As DataGridViewTextBoxColumn
    Friend WithEvents IdCargo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoInventario As DataGridViewTextBoxColumn
    Friend WithEvents NombreTecnico As DataGridViewTextBoxColumn
    Friend WithEvents EstadoSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents btnReporteTotalSolicitudes As Button
End Class
