<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolucionSolicitudes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolucionSolicitudes))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtIdSolicitud = New System.Windows.Forms.TextBox()
        Me.txtIdCargo = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbTecnico = New System.Windows.Forms.RadioButton()
        Me.rbSolicitante = New System.Windows.Forms.RadioButton()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbNombreSolicitud = New System.Windows.Forms.RadioButton()
        Me.lblTotalSoluciones = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvSoluciones = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreSolici = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prioridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreSolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreTecnico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoSolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBuscarSolucion = New System.Windows.Forms.Button()
        Me.txtSolicitud = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txtPrioridad = New System.Windows.Forms.TextBox()
        Me.txtSede = New System.Windows.Forms.TextBox()
        Me.txtTecnicoAsignado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSolucion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscarTecnico = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DTPFechaSolucion = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.CboTecnicoSolucion = New System.Windows.Forms.ComboBox()
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.txtDescripcionSolicitud = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnInformeSoluciones = New System.Windows.Forms.Button()
        Me.btnSolicitudesPendientes = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(399, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 248
        Me.Label2.Text = "Prioridad:"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(19, 165)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 35)
        Me.Label16.TabIndex = 245
        Me.Label16.Text = "Técnico Asignado:"
        '
        'txtIdSolicitud
        '
        Me.txtIdSolicitud.Location = New System.Drawing.Point(630, 25)
        Me.txtIdSolicitud.Name = "txtIdSolicitud"
        Me.txtIdSolicitud.Size = New System.Drawing.Size(34, 20)
        Me.txtIdSolicitud.TabIndex = 231
        Me.txtIdSolicitud.Visible = False
        '
        'txtIdCargo
        '
        Me.txtIdCargo.Location = New System.Drawing.Point(664, 117)
        Me.txtIdCargo.Name = "txtIdCargo"
        Me.txtIdCargo.Size = New System.Drawing.Size(26, 20)
        Me.txtIdCargo.TabIndex = 244
        Me.txtIdCargo.Visible = False
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(501, 73)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(144, 20)
        Me.txtDepartamento.TabIndex = 243
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(396, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 15)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "Departamento:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 38)
        Me.Label12.TabIndex = 240
        Me.Label12.Text = "Nombre Empleado:"
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(127, 121)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.ReadOnly = True
        Me.txtNombreA.Size = New System.Drawing.Size(212, 20)
        Me.txtNombreA.TabIndex = 226
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 37)
        Me.Label4.TabIndex = 238
        Me.Label4.Text = "Nombre de Artículo:"
        '
        'DTPFechaSolicitud
        '
        Me.DTPFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaSolicitud.Location = New System.Drawing.Point(746, 69)
        Me.DTPFechaSolicitud.Name = "DTPFechaSolicitud"
        Me.DTPFechaSolicitud.Size = New System.Drawing.Size(112, 20)
        Me.DTPFechaSolicitud.TabIndex = 224
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(661, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 38)
        Me.Label11.TabIndex = 237
        Me.Label11.Text = "Fecha de Solicitud"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbTecnico)
        Me.Panel1.Controls.Add(Me.rbSolicitante)
        Me.Panel1.Controls.Add(Me.rbDepartamento)
        Me.Panel1.Controls.Add(Me.rbNombreSolicitud)
        Me.Panel1.Controls.Add(Me.lblTotalSoluciones)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvSoluciones)
        Me.Panel1.Location = New System.Drawing.Point(35, 516)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 564)
        Me.Panel1.TabIndex = 236
        '
        'rbTecnico
        '
        Me.rbTecnico.AutoSize = True
        Me.rbTecnico.Location = New System.Drawing.Point(396, 33)
        Me.rbTecnico.Name = "rbTecnico"
        Me.rbTecnico.Size = New System.Drawing.Size(67, 17)
        Me.rbTecnico.TabIndex = 17
        Me.rbTecnico.Text = "Técnico:"
        Me.rbTecnico.UseVisualStyleBackColor = True
        '
        'rbSolicitante
        '
        Me.rbSolicitante.AutoSize = True
        Me.rbSolicitante.Checked = True
        Me.rbSolicitante.Location = New System.Drawing.Point(28, 33)
        Me.rbSolicitante.Name = "rbSolicitante"
        Me.rbSolicitante.Size = New System.Drawing.Size(117, 17)
        Me.rbSolicitante.TabIndex = 16
        Me.rbSolicitante.TabStop = True
        Me.rbSolicitante.Text = "Nombre Solicitante:"
        Me.rbSolicitante.UseVisualStyleBackColor = True
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.Location = New System.Drawing.Point(282, 33)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(95, 17)
        Me.rbDepartamento.TabIndex = 15
        Me.rbDepartamento.Text = "Departamento:"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'rbNombreSolicitud
        '
        Me.rbNombreSolicitud.AutoSize = True
        Me.rbNombreSolicitud.Location = New System.Drawing.Point(151, 33)
        Me.rbNombreSolicitud.Name = "rbNombreSolicitud"
        Me.rbNombreSolicitud.Size = New System.Drawing.Size(108, 17)
        Me.rbNombreSolicitud.TabIndex = 14
        Me.rbNombreSolicitud.Text = "Nombre Solicitud:"
        Me.rbNombreSolicitud.UseVisualStyleBackColor = True
        '
        'lblTotalSoluciones
        '
        Me.lblTotalSoluciones.AutoSize = True
        Me.lblTotalSoluciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSoluciones.Location = New System.Drawing.Point(141, 526)
        Me.lblTotalSoluciones.Name = "lblTotalSoluciones"
        Me.lblTotalSoluciones.Size = New System.Drawing.Size(44, 16)
        Me.lblTotalSoluciones.TabIndex = 17
        Me.lblTotalSoluciones.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 526)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Soluciones Registradas:"
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
        Me.txtBuscar.Size = New System.Drawing.Size(475, 20)
        Me.txtBuscar.TabIndex = 18
        '
        'dgvSoluciones
        '
        Me.dgvSoluciones.AllowUserToAddRows = False
        Me.dgvSoluciones.AllowUserToDeleteRows = False
        Me.dgvSoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSoluciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.IdSolicitud, Me.NombreSolici, Me.Prioridad, Me.NombreSolucion, Me.Sede, Me.FechaSolucion, Me.NombreTecnico, Me.Descripcion, Me.NombreA, Me.NombreD, Me.IdArticulo, Me.IdCargo, Me.IdSolucion, Me.EstadoSolucion})
        Me.dgvSoluciones.Location = New System.Drawing.Point(22, 70)
        Me.dgvSoluciones.Name = "dgvSoluciones"
        Me.dgvSoluciones.ReadOnly = True
        Me.dgvSoluciones.RowHeadersVisible = False
        Me.dgvSoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSoluciones.Size = New System.Drawing.Size(1006, 428)
        Me.dgvSoluciones.TabIndex = 15
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
        'NombreSolucion
        '
        Me.NombreSolucion.DataPropertyName = "NombreSolucion"
        Me.NombreSolucion.HeaderText = "SOLUCION"
        Me.NombreSolucion.Name = "NombreSolucion"
        Me.NombreSolucion.ReadOnly = True
        '
        'Sede
        '
        Me.Sede.DataPropertyName = "Sede"
        Me.Sede.HeaderText = "SEDE"
        Me.Sede.Name = "Sede"
        Me.Sede.ReadOnly = True
        '
        'FechaSolucion
        '
        Me.FechaSolucion.DataPropertyName = "FechaSolucion"
        Me.FechaSolucion.HeaderText = "FECHA SOLUCION"
        Me.FechaSolucion.Name = "FechaSolucion"
        Me.FechaSolucion.ReadOnly = True
        '
        'NombreTecnico
        '
        Me.NombreTecnico.DataPropertyName = "NombreTecnico"
        Me.NombreTecnico.HeaderText = "NOMBRE TECNICO SOLUCIONADOR"
        Me.NombreTecnico.Name = "NombreTecnico"
        Me.NombreTecnico.ReadOnly = True
        Me.NombreTecnico.Width = 200
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
        'IdSolucion
        '
        Me.IdSolucion.DataPropertyName = "IdSolucion"
        Me.IdSolucion.HeaderText = "IDSOLUCION"
        Me.IdSolucion.Name = "IdSolucion"
        Me.IdSolucion.ReadOnly = True
        Me.IdSolucion.Visible = False
        '
        'EstadoSolucion
        '
        Me.EstadoSolucion.DataPropertyName = "EstadoSolucion"
        Me.EstadoSolucion.HeaderText = "ESTADO SOLUCION"
        Me.EstadoSolucion.Name = "EstadoSolucion"
        Me.EstadoSolucion.ReadOnly = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(124, 400)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(558, 80)
        Me.txtDescripcion.TabIndex = 7
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(26, 12)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(34, 20)
        Me.txtId.TabIndex = 235
        Me.txtId.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 46)
        Me.Label6.TabIndex = 234
        Me.Label6.Text = "Falla en el Dispositivo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(407, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 233
        Me.Label5.Text = "Sede:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 232
        Me.Label1.Text = "Solicitud:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.Location = New System.Drawing.Point(902, 121)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 38)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.Location = New System.Drawing.Point(902, 72)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 38)
        Me.btnEditar.TabIndex = 10
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = CType(resources.GetObject("btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.Location = New System.Drawing.Point(902, 28)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 38)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Location = New System.Drawing.Point(988, 190)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 38)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar.Location = New System.Drawing.Point(988, 71)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 38)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "E&liminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Location = New System.Drawing.Point(988, 27)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 38)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnBuscarSolucion
        '
        Me.btnBuscarSolucion.BackgroundImage = CType(resources.GetObject("btnBuscarSolucion.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarSolucion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscarSolucion.Location = New System.Drawing.Point(345, 22)
        Me.btnBuscarSolucion.Name = "btnBuscarSolucion"
        Me.btnBuscarSolucion.Size = New System.Drawing.Size(29, 27)
        Me.btnBuscarSolucion.TabIndex = 254
        Me.btnBuscarSolucion.Text = "..."
        Me.btnBuscarSolucion.UseVisualStyleBackColor = True
        '
        'txtSolicitud
        '
        Me.txtSolicitud.Location = New System.Drawing.Point(127, 28)
        Me.txtSolicitud.Name = "txtSolicitud"
        Me.txtSolicitud.Size = New System.Drawing.Size(212, 20)
        Me.txtSolicitud.TabIndex = 1
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(127, 77)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.ReadOnly = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(212, 20)
        Me.txtNombreEmpleado.TabIndex = 255
        '
        'txtPrioridad
        '
        Me.txtPrioridad.Location = New System.Drawing.Point(475, 27)
        Me.txtPrioridad.Name = "txtPrioridad"
        Me.txtPrioridad.ReadOnly = True
        Me.txtPrioridad.Size = New System.Drawing.Size(144, 20)
        Me.txtPrioridad.TabIndex = 256
        '
        'txtSede
        '
        Me.txtSede.Location = New System.Drawing.Point(482, 117)
        Me.txtSede.Name = "txtSede"
        Me.txtSede.ReadOnly = True
        Me.txtSede.Size = New System.Drawing.Size(162, 20)
        Me.txtSede.TabIndex = 257
        '
        'txtTecnicoAsignado
        '
        Me.txtTecnicoAsignado.Location = New System.Drawing.Point(127, 165)
        Me.txtTecnicoAsignado.Name = "txtTecnicoAsignado"
        Me.txtTecnicoAsignado.ReadOnly = True
        Me.txtTecnicoAsignado.Size = New System.Drawing.Size(212, 20)
        Me.txtTecnicoAsignado.TabIndex = 258
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 259
        Me.Label3.Text = "Solución:"
        '
        'txtSolucion
        '
        Me.txtSolucion.Location = New System.Drawing.Point(124, 307)
        Me.txtSolucion.Name = "txtSolucion"
        Me.txtSolucion.Size = New System.Drawing.Size(212, 20)
        Me.txtSolucion.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(342, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 35)
        Me.Label7.TabIndex = 261
        Me.Label7.Text = "Técnico que Soluciona:"
        '
        'btnBuscarTecnico
        '
        Me.btnBuscarTecnico.BackgroundImage = CType(resources.GetObject("btnBuscarTecnico.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarTecnico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscarTecnico.Location = New System.Drawing.Point(664, 302)
        Me.btnBuscarTecnico.Name = "btnBuscarTecnico"
        Me.btnBuscarTecnico.Size = New System.Drawing.Size(29, 27)
        Me.btnBuscarTecnico.TabIndex = 4
        Me.btnBuscarTecnico.Text = "..."
        Me.btnBuscarTecnico.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(268, 339)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 38)
        Me.Label13.TabIndex = 264
        Me.Label13.Text = "Fecha de Solución:"
        '
        'DTPFechaSolucion
        '
        Me.DTPFechaSolucion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaSolucion.Location = New System.Drawing.Point(364, 347)
        Me.DTPFechaSolucion.Name = "DTPFechaSolucion"
        Me.DTPFechaSolucion.Size = New System.Drawing.Size(109, 20)
        Me.DTPFechaSolucion.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 344)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 33)
        Me.Label14.TabIndex = 266
        Me.Label14.Text = "Estado Solicitud:"
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Solucionada", "Pendiente"})
        Me.cboEstado.Location = New System.Drawing.Point(124, 344)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboEstado.TabIndex = 5
        '
        'CboTecnicoSolucion
        '
        Me.CboTecnicoSolucion.FormattingEnabled = True
        Me.CboTecnicoSolucion.Location = New System.Drawing.Point(449, 306)
        Me.CboTecnicoSolucion.Name = "CboTecnicoSolucion"
        Me.CboTecnicoSolucion.Size = New System.Drawing.Size(212, 21)
        Me.CboTecnicoSolucion.TabIndex = 3
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.Location = New System.Drawing.Point(348, 121)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(26, 20)
        Me.txtIdArticulo.TabIndex = 268
        Me.txtIdArticulo.Visible = False
        '
        'txtDescripcionSolicitud
        '
        Me.txtDescripcionSolicitud.Location = New System.Drawing.Point(124, 200)
        Me.txtDescripcionSolicitud.Multiline = True
        Me.txtDescripcionSolicitud.Name = "txtDescripcionSolicitud"
        Me.txtDescripcionSolicitud.ReadOnly = True
        Me.txtDescripcionSolicitud.Size = New System.Drawing.Size(558, 80)
        Me.txtDescripcionSolicitud.TabIndex = 269
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 422)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 15)
        Me.Label15.TabIndex = 270
        Me.Label15.Text = "Descripción:"
        '
        'btnInformeSoluciones
        '
        Me.btnInformeSoluciones.BackgroundImage = CType(resources.GetObject("btnInformeSoluciones.BackgroundImage"), System.Drawing.Image)
        Me.btnInformeSoluciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnInformeSoluciones.Location = New System.Drawing.Point(722, 391)
        Me.btnInformeSoluciones.Name = "btnInformeSoluciones"
        Me.btnInformeSoluciones.Size = New System.Drawing.Size(85, 57)
        Me.btnInformeSoluciones.TabIndex = 271
        Me.btnInformeSoluciones.Text = "&Reporte Solución Solicitudes"
        Me.btnInformeSoluciones.UseVisualStyleBackColor = True
        '
        'btnSolicitudesPendientes
        '
        Me.btnSolicitudesPendientes.BackgroundImage = CType(resources.GetObject("btnSolicitudesPendientes.BackgroundImage"), System.Drawing.Image)
        Me.btnSolicitudesPendientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSolicitudesPendientes.Location = New System.Drawing.Point(874, 391)
        Me.btnSolicitudesPendientes.Name = "btnSolicitudesPendientes"
        Me.btnSolicitudesPendientes.Size = New System.Drawing.Size(103, 57)
        Me.btnSolicitudesPendientes.TabIndex = 272
        Me.btnSolicitudesPendientes.Text = "&Reporte Solicitudes Pendientes"
        Me.btnSolicitudesPendientes.UseVisualStyleBackColor = True
        '
        'frmSolucionSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 1031)
        Me.Controls.Add(Me.btnSolicitudesPendientes)
        Me.Controls.Add(Me.btnInformeSoluciones)
        Me.Controls.Add(Me.txtDescripcionSolicitud)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtIdArticulo)
        Me.Controls.Add(Me.CboTecnicoSolucion)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DTPFechaSolucion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnBuscarTecnico)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSolucion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTecnicoAsignado)
        Me.Controls.Add(Me.txtSede)
        Me.Controls.Add(Me.txtPrioridad)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.btnBuscarSolucion)
        Me.Controls.Add(Me.txtSolicitud)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtIdSolicitud)
        Me.Controls.Add(Me.txtIdCargo)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNombreA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DTPFechaSolicitud)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSolucionSolicitudes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solución Solicitudes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtIdSolicitud As TextBox
    Friend WithEvents txtIdCargo As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNombreA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DTPFechaSolicitud As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbTecnico As RadioButton
    Friend WithEvents rbSolicitante As RadioButton
    Friend WithEvents rbDepartamento As RadioButton
    Friend WithEvents rbNombreSolicitud As RadioButton
    Friend WithEvents lblTotalSoluciones As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvSoluciones As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBuscarSolucion As Button
    Friend WithEvents txtSolicitud As TextBox
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents txtPrioridad As TextBox
    Friend WithEvents txtSede As TextBox
    Friend WithEvents txtTecnicoAsignado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSolucion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscarTecnico As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents DTPFechaSolucion As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents CboTecnicoSolucion As ComboBox
    Friend WithEvents txtIdArticulo As TextBox
    Friend WithEvents txtDescripcionSolicitud As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents IdSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents NombreSolici As DataGridViewTextBoxColumn
    Friend WithEvents Prioridad As DataGridViewTextBoxColumn
    Friend WithEvents NombreSolucion As DataGridViewTextBoxColumn
    Friend WithEvents Sede As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolucion As DataGridViewTextBoxColumn
    Friend WithEvents NombreTecnico As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents NombreA As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents IdArticulo As DataGridViewTextBoxColumn
    Friend WithEvents IdCargo As DataGridViewTextBoxColumn
    Friend WithEvents IdSolucion As DataGridViewTextBoxColumn
    Friend WithEvents EstadoSolucion As DataGridViewTextBoxColumn
    Friend WithEvents btnInformeSoluciones As Button
    Friend WithEvents btnSolicitudesPendientes As Button
End Class
