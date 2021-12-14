<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmActivosInformacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivosInformacion))
        Me.txtRevisado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DTPFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbProceso = New System.Windows.Forms.RadioButton()
        Me.rbPropietario = New System.Windows.Forms.RadioButton()
        Me.rbElaborado = New System.Windows.Forms.RadioButton()
        Me.rbUbicacion = New System.Windows.Forms.RadioButton()
        Me.lblTotalActivos = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvActivosInf = New System.Windows.Forms.DataGridView()
        Me.IdActivoInf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentificadorActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ruta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JustificacionActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClasiConfi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClasiInteg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClasiDispon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreEla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreApro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreRev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaValidacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPropietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdElaborado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAprobado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRevisado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboUbicacion = New System.Windows.Forms.ComboBox()
        Me.txtJustificación = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtIdentificador = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboProceso = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNombreActivoInf = New System.Windows.Forms.TextBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.txtPropietario = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DTPFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboConfidencialidad = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboIntegridad = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboDisponibilidad = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtElaborado = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtAprobado = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboPropCargo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DTPFechaValidacion = New System.Windows.Forms.DateTimePicker()
        Me.txtIdPropietario = New System.Windows.Forms.TextBox()
        Me.TxtIdElaborado = New System.Windows.Forms.TextBox()
        Me.txtIdAprobado = New System.Windows.Forms.TextBox()
        Me.txtIdRevisado = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnJustificacion = New System.Windows.Forms.Button()
        Me.btnInfoDisponibilidad = New System.Windows.Forms.Button()
        Me.btnInfoIntegridad = New System.Windows.Forms.Button()
        Me.btnInfoDispoNoclasifica = New System.Windows.Forms.Button()
        Me.btnInfoDispoBaja = New System.Windows.Forms.Button()
        Me.btnInfoDispoMedia = New System.Windows.Forms.Button()
        Me.btnInfoDispoAlta = New System.Windows.Forms.Button()
        Me.btnInfoInteNoclasifica = New System.Windows.Forms.Button()
        Me.btnInfoInteBaja = New System.Windows.Forms.Button()
        Me.btnInfIntegMedia = New System.Windows.Forms.Button()
        Me.btnInfInteAlta = New System.Windows.Forms.Button()
        Me.btnInfNoAPlica = New System.Windows.Forms.Button()
        Me.btnInfIdentificador = New System.Windows.Forms.Button()
        Me.btnInfoTipo = New System.Windows.Forms.Button()
        Me.btnInfPublic = New System.Windows.Forms.Button()
        Me.btnInfClasificada = New System.Windows.Forms.Button()
        Me.btnInfReservada = New System.Windows.Forms.Button()
        Me.btnInfConfidencialidad = New System.Windows.Forms.Button()
        Me.btnRevisadoBusque = New System.Windows.Forms.Button()
        Me.btnAprobado = New System.Windows.Forms.Button()
        Me.btnElaborado = New System.Windows.Forms.Button()
        Me.btnPropietario = New System.Windows.Forms.Button()
        Me.btnRevisado = New System.Windows.Forms.Button()
        Me.btnTipo = New System.Windows.Forms.Button()
        Me.btnEmpleado3 = New System.Windows.Forms.Button()
        Me.btnPuesto = New System.Windows.Forms.Button()
        Me.btnEmpleado2 = New System.Windows.Forms.Button()
        Me.btnEmpleado = New System.Windows.Forms.Button()
        Me.btnProceso = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvActivosInf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRevisado
        '
        Me.txtRevisado.Location = New System.Drawing.Point(143, 360)
        Me.txtRevisado.Name = "txtRevisado"
        Me.txtRevisado.Size = New System.Drawing.Size(358, 20)
        Me.txtRevisado.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(54, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "Propietario:"
        '
        'DTPFechaSalida
        '
        Me.DTPFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaSalida.Location = New System.Drawing.Point(1018, 362)
        Me.DTPFechaSalida.Name = "DTPFechaSalida"
        Me.DTPFechaSalida.Size = New System.Drawing.Size(112, 20)
        Me.DTPFechaSalida.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbProceso)
        Me.Panel1.Controls.Add(Me.rbPropietario)
        Me.Panel1.Controls.Add(Me.rbElaborado)
        Me.Panel1.Controls.Add(Me.rbUbicacion)
        Me.Panel1.Controls.Add(Me.lblTotalActivos)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvActivosInf)
        Me.Panel1.Location = New System.Drawing.Point(37, 491)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1315, 448)
        Me.Panel1.TabIndex = 129
        '
        'rbProceso
        '
        Me.rbProceso.AutoSize = True
        Me.rbProceso.Checked = True
        Me.rbProceso.Location = New System.Drawing.Point(90, 31)
        Me.rbProceso.Name = "rbProceso"
        Me.rbProceso.Size = New System.Drawing.Size(67, 17)
        Me.rbProceso.TabIndex = 36
        Me.rbProceso.TabStop = True
        Me.rbProceso.Text = "Proceso:"
        Me.rbProceso.UseVisualStyleBackColor = True
        '
        'rbPropietario
        '
        Me.rbPropietario.AutoSize = True
        Me.rbPropietario.Location = New System.Drawing.Point(181, 31)
        Me.rbPropietario.Name = "rbPropietario"
        Me.rbPropietario.Size = New System.Drawing.Size(78, 17)
        Me.rbPropietario.TabIndex = 37
        Me.rbPropietario.Text = "Propietario:"
        Me.rbPropietario.UseVisualStyleBackColor = True
        '
        'rbElaborado
        '
        Me.rbElaborado.AutoSize = True
        Me.rbElaborado.Location = New System.Drawing.Point(279, 31)
        Me.rbElaborado.Name = "rbElaborado"
        Me.rbElaborado.Size = New System.Drawing.Size(76, 17)
        Me.rbElaborado.TabIndex = 38
        Me.rbElaborado.Text = "Elaborado:"
        Me.rbElaborado.UseVisualStyleBackColor = True
        '
        'rbUbicacion
        '
        Me.rbUbicacion.AutoSize = True
        Me.rbUbicacion.Location = New System.Drawing.Point(392, 31)
        Me.rbUbicacion.Name = "rbUbicacion"
        Me.rbUbicacion.Size = New System.Drawing.Size(76, 17)
        Me.rbUbicacion.TabIndex = 39
        Me.rbUbicacion.Text = "Ubicación:"
        Me.rbUbicacion.UseVisualStyleBackColor = True
        '
        'lblTotalActivos
        '
        Me.lblTotalActivos.AutoSize = True
        Me.lblTotalActivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalActivos.Location = New System.Drawing.Point(159, 422)
        Me.lblTotalActivos.Name = "lblTotalActivos"
        Me.lblTotalActivos.Size = New System.Drawing.Size(44, 16)
        Me.lblTotalActivos.TabIndex = 17
        Me.lblTotalActivos.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 424)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Artículos Registrados:"
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
        Me.txtBuscar.Location = New System.Drawing.Point(678, 28)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(601, 20)
        Me.txtBuscar.TabIndex = 40
        '
        'dgvActivosInf
        '
        Me.dgvActivosInf.AllowUserToAddRows = False
        Me.dgvActivosInf.AllowUserToDeleteRows = False
        Me.dgvActivosInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActivosInf.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdActivoInf, Me.IdentificadorActivo, Me.NombreActivo, Me.NombreD, Me.NombreT, Me.Ubicacion, Me.Ruta, Me.JustificacionActivo, Me.Nombre, Me.NombreP, Me.FechaIngreso, Me.ClasiConfi, Me.ClasiInteg, Me.ClasiDispon, Me.NombreEla, Me.NombreApro, Me.NombreRev, Me.FechaValidacion, Me.FechaSalida, Me.Descripcion, Me.IdTipo, Me.IdEmpleado, Me.IdPuesto, Me.IdTipo1, Me.IdPropietario, Me.IdElaborado, Me.IdAprobado, Me.IdRevisado})
        Me.dgvActivosInf.Location = New System.Drawing.Point(32, 64)
        Me.dgvActivosInf.Name = "dgvActivosInf"
        Me.dgvActivosInf.ReadOnly = True
        Me.dgvActivosInf.RowHeadersVisible = False
        Me.dgvActivosInf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActivosInf.Size = New System.Drawing.Size(1247, 344)
        Me.dgvActivosInf.TabIndex = 15
        '
        'IdActivoInf
        '
        Me.IdActivoInf.DataPropertyName = "IdActivoInf"
        Me.IdActivoInf.HeaderText = "ID"
        Me.IdActivoInf.Name = "IdActivoInf"
        Me.IdActivoInf.ReadOnly = True
        Me.IdActivoInf.Visible = False
        Me.IdActivoInf.Width = 10
        '
        'IdentificadorActivo
        '
        Me.IdentificadorActivo.DataPropertyName = "IdentificadorActivo"
        Me.IdentificadorActivo.HeaderText = "IDENTIFICADOR ACTIVO"
        Me.IdentificadorActivo.Name = "IdentificadorActivo"
        Me.IdentificadorActivo.ReadOnly = True
        '
        'NombreActivo
        '
        Me.NombreActivo.DataPropertyName = "NombreActivo"
        Me.NombreActivo.HeaderText = "NOMBRE DEL ACTIVO"
        Me.NombreActivo.Name = "NombreActivo"
        Me.NombreActivo.ReadOnly = True
        Me.NombreActivo.Width = 200
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "PROCESO"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        '
        'NombreT
        '
        Me.NombreT.DataPropertyName = "NombreT"
        Me.NombreT.HeaderText = "TIPO"
        Me.NombreT.Name = "NombreT"
        Me.NombreT.ReadOnly = True
        Me.NombreT.Width = 120
        '
        'Ubicacion
        '
        Me.Ubicacion.DataPropertyName = "Ubicacion"
        Me.Ubicacion.HeaderText = "UBICACION"
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.ReadOnly = True
        Me.Ubicacion.Width = 125
        '
        'Ruta
        '
        Me.Ruta.DataPropertyName = "Ruta"
        Me.Ruta.HeaderText = "RUTA ACCESO"
        Me.Ruta.Name = "Ruta"
        Me.Ruta.ReadOnly = True
        Me.Ruta.Width = 135
        '
        'JustificacionActivo
        '
        Me.JustificacionActivo.DataPropertyName = "JustificacionActivo"
        Me.JustificacionActivo.HeaderText = "JUSTIFICACION"
        Me.JustificacionActivo.Name = "JustificacionActivo"
        Me.JustificacionActivo.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "PROPIETARIO"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'NombreP
        '
        Me.NombreP.DataPropertyName = "NombreP"
        Me.NombreP.HeaderText = "CARGO PROPIETARIO"
        Me.NombreP.Name = "NombreP"
        Me.NombreP.ReadOnly = True
        '
        'FechaIngreso
        '
        Me.FechaIngreso.DataPropertyName = "FechaIngreso"
        Me.FechaIngreso.HeaderText = "FECHA INGRESO"
        Me.FechaIngreso.Name = "FechaIngreso"
        Me.FechaIngreso.ReadOnly = True
        '
        'ClasiConfi
        '
        Me.ClasiConfi.DataPropertyName = "ClasiConfi"
        Me.ClasiConfi.HeaderText = "CLASIFICAION CONFIDENCIALIDAD"
        Me.ClasiConfi.Name = "ClasiConfi"
        Me.ClasiConfi.ReadOnly = True
        '
        'ClasiInteg
        '
        Me.ClasiInteg.DataPropertyName = "ClasiInteg"
        Me.ClasiInteg.HeaderText = "CLASIFICACION INTEGRIDAD"
        Me.ClasiInteg.Name = "ClasiInteg"
        Me.ClasiInteg.ReadOnly = True
        '
        'ClasiDispon
        '
        Me.ClasiDispon.DataPropertyName = "ClasiDispon"
        Me.ClasiDispon.HeaderText = "CLASIFICACION DISPONIBILIDLAD"
        Me.ClasiDispon.Name = "ClasiDispon"
        Me.ClasiDispon.ReadOnly = True
        '
        'NombreEla
        '
        Me.NombreEla.DataPropertyName = "NombreEla"
        Me.NombreEla.HeaderText = "ELABORADO"
        Me.NombreEla.Name = "NombreEla"
        Me.NombreEla.ReadOnly = True
        '
        'NombreApro
        '
        Me.NombreApro.DataPropertyName = "NombreApro"
        Me.NombreApro.HeaderText = "APROBADO"
        Me.NombreApro.Name = "NombreApro"
        Me.NombreApro.ReadOnly = True
        '
        'NombreRev
        '
        Me.NombreRev.DataPropertyName = "NombreRev"
        Me.NombreRev.HeaderText = "REVISADO"
        Me.NombreRev.Name = "NombreRev"
        Me.NombreRev.ReadOnly = True
        '
        'FechaValidacion
        '
        Me.FechaValidacion.DataPropertyName = "FechaValidacion"
        Me.FechaValidacion.HeaderText = "FECHA VALIDACION"
        Me.FechaValidacion.Name = "FechaValidacion"
        Me.FechaValidacion.ReadOnly = True
        '
        'FechaSalida
        '
        Me.FechaSalida.DataPropertyName = "FechaSalida"
        Me.FechaSalida.HeaderText = "FECHA SALIDA"
        Me.FechaSalida.Name = "FechaSalida"
        Me.FechaSalida.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "DESCRIPCION"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'IdTipo
        '
        Me.IdTipo.DataPropertyName = "IdTipo"
        Me.IdTipo.HeaderText = "IDTIPO"
        Me.IdTipo.Name = "IdTipo"
        Me.IdTipo.ReadOnly = True
        Me.IdTipo.Visible = False
        '
        'IdEmpleado
        '
        Me.IdEmpleado.DataPropertyName = "IdEmpleado"
        Me.IdEmpleado.HeaderText = "IDEMPLEADO"
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.ReadOnly = True
        Me.IdEmpleado.Visible = False
        '
        'IdPuesto
        '
        Me.IdPuesto.DataPropertyName = "IdPuesto"
        Me.IdPuesto.HeaderText = "IDPUESTO"
        Me.IdPuesto.Name = "IdPuesto"
        Me.IdPuesto.ReadOnly = True
        Me.IdPuesto.Visible = False
        '
        'IdTipo1
        '
        Me.IdTipo1.DataPropertyName = "IdTipo1"
        Me.IdTipo1.HeaderText = "ID TIPO1"
        Me.IdTipo1.Name = "IdTipo1"
        Me.IdTipo1.ReadOnly = True
        Me.IdTipo1.Visible = False
        '
        'IdPropietario
        '
        Me.IdPropietario.DataPropertyName = "IdPropietario"
        Me.IdPropietario.HeaderText = "ID PROPIETARIO"
        Me.IdPropietario.Name = "IdPropietario"
        Me.IdPropietario.ReadOnly = True
        Me.IdPropietario.Visible = False
        '
        'IdElaborado
        '
        Me.IdElaborado.DataPropertyName = "IdElaborado"
        Me.IdElaborado.HeaderText = "ID ELABORADO"
        Me.IdElaborado.Name = "IdElaborado"
        Me.IdElaborado.ReadOnly = True
        Me.IdElaborado.Visible = False
        '
        'IdAprobado
        '
        Me.IdAprobado.DataPropertyName = "IdAprobado"
        Me.IdAprobado.HeaderText = "ID APROBADO"
        Me.IdAprobado.Name = "IdAprobado"
        Me.IdAprobado.ReadOnly = True
        Me.IdAprobado.Visible = False
        '
        'IdRevisado
        '
        Me.IdRevisado.DataPropertyName = "IdRevisado"
        Me.IdRevisado.HeaderText = "ID REVISADO"
        Me.IdRevisado.Name = "IdRevisado"
        Me.IdRevisado.ReadOnly = True
        Me.IdRevisado.Visible = False
        '
        'cboUbicacion
        '
        Me.cboUbicacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboUbicacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUbicacion.FormattingEnabled = True
        Me.cboUbicacion.Items.AddRange(New Object() {"Servidor Local CCB", "Nuva Drive", "Computador Local CCB"})
        Me.cboUbicacion.Location = New System.Drawing.Point(142, 104)
        Me.cboUbicacion.Name = "cboUbicacion"
        Me.cboUbicacion.Size = New System.Drawing.Size(226, 21)
        Me.cboUbicacion.TabIndex = 6
        '
        'txtJustificación
        '
        Me.txtJustificación.Location = New System.Drawing.Point(142, 136)
        Me.txtJustificación.Multiline = True
        Me.txtJustificación.Name = "txtJustificación"
        Me.txtJustificación.Size = New System.Drawing.Size(781, 38)
        Me.txtJustificación.TabIndex = 8
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(147, 392)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(539, 80)
        Me.txtDescripcion.TabIndex = 29
        '
        'txtIdentificador
        '
        Me.txtIdentificador.Location = New System.Drawing.Point(170, 39)
        Me.txtIdentificador.Name = "txtIdentificador"
        Me.txtIdentificador.Size = New System.Drawing.Size(135, 20)
        Me.txtIdentificador.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(6, 11)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(34, 20)
        Me.txtId.TabIndex = 128
        Me.txtId.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(65, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 15)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Ubicación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 412)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(511, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Tipo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Justificación:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Revisado por:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(313, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 15)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Proceso / Departamento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 15)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Identifiacor Activo:"
        '
        'cboProceso
        '
        Me.cboProceso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProceso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProceso.FormattingEnabled = True
        Me.cboProceso.Location = New System.Drawing.Point(495, 37)
        Me.cboProceso.Name = "cboProceso"
        Me.cboProceso.Size = New System.Drawing.Size(428, 21)
        Me.cboProceso.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(34, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 15)
        Me.Label14.TabIndex = 135
        Me.Label14.Text = "Nombre Activo:"
        '
        'txtNombreActivoInf
        '
        Me.txtNombreActivoInf.Location = New System.Drawing.Point(142, 74)
        Me.txtNombreActivoInf.Name = "txtNombreActivoInf"
        Me.txtNombreActivoInf.Size = New System.Drawing.Size(343, 20)
        Me.txtNombreActivoInf.TabIndex = 4
        '
        'cboTipo
        '
        Me.cboTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(576, 73)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(347, 21)
        Me.cboTipo.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(381, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(151, 15)
        Me.Label15.TabIndex = 138
        Me.Label15.Text = "Ruta de Acceso Activo:"
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(549, 104)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(374, 20)
        Me.txtRuta.TabIndex = 7
        '
        'txtPropietario
        '
        Me.txtPropietario.Location = New System.Drawing.Point(142, 192)
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.Size = New System.Drawing.Size(320, 20)
        Me.txtPropietario.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(950, 186)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(124, 43)
        Me.Label16.TabIndex = 142
        Me.Label16.Text = "Fecha de Ingreso del Activo:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTPFechaIngreso
        '
        Me.DTPFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaIngreso.Location = New System.Drawing.Point(1080, 201)
        Me.DTPFechaIngreso.Name = "DTPFechaIngreso"
        Me.DTPFechaIngreso.Size = New System.Drawing.Size(112, 20)
        Me.DTPFechaIngreso.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(888, 351)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 43)
        Me.Label17.TabIndex = 144
        Me.Label17.Text = "Fecha de Salida del Activo:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(14, 236)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(176, 51)
        Me.Label18.TabIndex = 145
        Me.Label18.Text = "Clasificación de la información de acuerdo con la confidencialidad:"
        '
        'cboConfidencialidad
        '
        Me.cboConfidencialidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboConfidencialidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboConfidencialidad.FormattingEnabled = True
        Me.cboConfidencialidad.Items.AddRange(New Object() {"Informacion Reservada (IR)", "Informacion Clasificada(IC)", "Informacion Publica(IP)", "No Clasifica(NC)"})
        Me.cboConfidencialidad.Location = New System.Drawing.Point(196, 248)
        Me.cboConfidencialidad.Name = "cboConfidencialidad"
        Me.cboConfidencialidad.Size = New System.Drawing.Size(209, 21)
        Me.cboConfidencialidad.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(411, 236)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(176, 51)
        Me.Label19.TabIndex = 147
        Me.Label19.Text = "Clasificación de la información de acuerdo con la  integridad:"
        '
        'cboIntegridad
        '
        Me.cboIntegridad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboIntegridad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIntegridad.FormattingEnabled = True
        Me.cboIntegridad.Items.AddRange(New Object() {"Alta(A)", "Media(M)", "Baja(B)", "No Clasifica"})
        Me.cboIntegridad.Location = New System.Drawing.Point(612, 248)
        Me.cboIntegridad.Name = "cboIntegridad"
        Me.cboIntegridad.Size = New System.Drawing.Size(209, 21)
        Me.cboIntegridad.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(857, 236)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(176, 51)
        Me.Label20.TabIndex = 149
        Me.Label20.Text = "Clasificación de la información de acuerdo con la  disponibilidad:"
        '
        'cboDisponibilidad
        '
        Me.cboDisponibilidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDisponibilidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDisponibilidad.FormattingEnabled = True
        Me.cboDisponibilidad.Items.AddRange(New Object() {"(1)Alta", "(2)Media", "(3)Baja", "No Clasifica"})
        Me.cboDisponibilidad.Location = New System.Drawing.Point(1039, 248)
        Me.cboDisponibilidad.Name = "cboDisponibilidad"
        Me.cboDisponibilidad.Size = New System.Drawing.Size(209, 21)
        Me.cboDisponibilidad.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(36, 313)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 15)
        Me.Label21.TabIndex = 151
        Me.Label21.Text = "Elaborado por:"
        '
        'txtElaborado
        '
        Me.txtElaborado.Location = New System.Drawing.Point(142, 312)
        Me.txtElaborado.Name = "txtElaborado"
        Me.txtElaborado.Size = New System.Drawing.Size(373, 20)
        Me.txtElaborado.TabIndex = 18
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(593, 313)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 15)
        Me.Label22.TabIndex = 154
        Me.Label22.Text = "Aprobado por:"
        '
        'txtAprobado
        '
        Me.txtAprobado.Location = New System.Drawing.Point(696, 312)
        Me.txtAprobado.Name = "txtAprobado"
        Me.txtAprobado.Size = New System.Drawing.Size(373, 20)
        Me.txtAprobado.TabIndex = 21
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(553, 177)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(102, 46)
        Me.Label23.TabIndex = 156
        Me.Label23.Text = "Cargo Propietario activo:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPropCargo
        '
        Me.cboPropCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPropCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPropCargo.FormattingEnabled = True
        Me.cboPropCargo.Location = New System.Drawing.Point(661, 192)
        Me.cboPropCargo.Name = "cboPropCargo"
        Me.cboPropCargo.Size = New System.Drawing.Size(224, 21)
        Me.cboPropCargo.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(587, 362)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 15)
        Me.Label11.TabIndex = 159
        Me.Label11.Text = "Fecha de validación:"
        '
        'DTPFechaValidacion
        '
        Me.DTPFechaValidacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaValidacion.Location = New System.Drawing.Point(732, 361)
        Me.DTPFechaValidacion.Name = "DTPFechaValidacion"
        Me.DTPFechaValidacion.Size = New System.Drawing.Size(112, 20)
        Me.DTPFechaValidacion.TabIndex = 27
        '
        'txtIdPropietario
        '
        Me.txtIdPropietario.Location = New System.Drawing.Point(17, 189)
        Me.txtIdPropietario.Name = "txtIdPropietario"
        Me.txtIdPropietario.Size = New System.Drawing.Size(24, 20)
        Me.txtIdPropietario.TabIndex = 161
        Me.txtIdPropietario.Visible = False
        '
        'TxtIdElaborado
        '
        Me.TxtIdElaborado.Location = New System.Drawing.Point(12, 308)
        Me.TxtIdElaborado.Name = "TxtIdElaborado"
        Me.TxtIdElaborado.Size = New System.Drawing.Size(24, 20)
        Me.TxtIdElaborado.TabIndex = 162
        Me.TxtIdElaborado.Visible = False
        '
        'txtIdAprobado
        '
        Me.txtIdAprobado.Location = New System.Drawing.Point(1144, 312)
        Me.txtIdAprobado.Name = "txtIdAprobado"
        Me.txtIdAprobado.Size = New System.Drawing.Size(24, 20)
        Me.txtIdAprobado.TabIndex = 163
        Me.txtIdAprobado.Visible = False
        '
        'txtIdRevisado
        '
        Me.txtIdRevisado.Location = New System.Drawing.Point(12, 361)
        Me.txtIdRevisado.Name = "txtIdRevisado"
        Me.txtIdRevisado.Size = New System.Drawing.Size(24, 20)
        Me.txtIdRevisado.TabIndex = 169
        Me.txtIdRevisado.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(196, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 13)
        Me.Label12.TabIndex = 182
        Me.Label12.Text = "IR"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(249, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 13)
        Me.Label13.TabIndex = 183
        Me.Label13.Text = "IC"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(301, 225)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(17, 13)
        Me.Label24.TabIndex = 184
        Me.Label24.Text = "IP"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(353, 225)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(23, 13)
        Me.Label25.TabIndex = 185
        Me.Label25.Text = "NO"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(771, 229)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(23, 13)
        Me.Label26.TabIndex = 193
        Me.Label26.Text = "NO"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(719, 229)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 13)
        Me.Label27.TabIndex = 192
        Me.Label27.Text = "B"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(667, 229)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(16, 13)
        Me.Label28.TabIndex = 191
        Me.Label28.Text = "M"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(614, 229)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 13)
        Me.Label29.TabIndex = 190
        Me.Label29.Text = "A"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(1039, 229)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(26, 13)
        Me.Label33.TabIndex = 198
        Me.Label33.Text = "1(A)"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(1098, 229)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(28, 13)
        Me.Label30.TabIndex = 203
        Me.Label30.Text = "2(M)"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(1142, 229)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(26, 13)
        Me.Label31.TabIndex = 204
        Me.Label31.Text = "3(B)"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(1193, 229)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(23, 13)
        Me.Label32.TabIndex = 205
        Me.Label32.Text = "NO"
        '
        'btnReporte
        '
        Me.btnReporte.BackgroundImage = CType(resources.GetObject("btnReporte.BackgroundImage"), System.Drawing.Image)
        Me.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnReporte.Location = New System.Drawing.Point(774, 412)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(75, 38)
        Me.btnReporte.TabIndex = 209
        Me.btnReporte.Text = "&Informe Activos "
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnJustificacion
        '
        Me.btnJustificacion.BackgroundImage = CType(resources.GetObject("btnJustificacion.BackgroundImage"), System.Drawing.Image)
        Me.btnJustificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnJustificacion.Location = New System.Drawing.Point(111, 139)
        Me.btnJustificacion.Name = "btnJustificacion"
        Me.btnJustificacion.Size = New System.Drawing.Size(23, 21)
        Me.btnJustificacion.TabIndex = 208
        Me.btnJustificacion.Text = "..."
        Me.btnJustificacion.UseVisualStyleBackColor = True
        '
        'btnInfoDisponibilidad
        '
        Me.btnInfoDisponibilidad.BackgroundImage = CType(resources.GetObject("btnInfoDisponibilidad.BackgroundImage"), System.Drawing.Image)
        Me.btnInfoDisponibilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfoDisponibilidad.Location = New System.Drawing.Point(1010, 266)
        Me.btnInfoDisponibilidad.Name = "btnInfoDisponibilidad"
        Me.btnInfoDisponibilidad.Size = New System.Drawing.Size(23, 21)
        Me.btnInfoDisponibilidad.TabIndex = 207
        Me.btnInfoDisponibilidad.Text = "..."
        Me.btnInfoDisponibilidad.UseVisualStyleBackColor = True
        '
        'btnInfoIntegridad
        '
        Me.btnInfoIntegridad.BackgroundImage = CType(resources.GetObject("btnInfoIntegridad.BackgroundImage"), System.Drawing.Image)
        Me.btnInfoIntegridad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfoIntegridad.Location = New System.Drawing.Point(564, 266)
        Me.btnInfoIntegridad.Name = "btnInfoIntegridad"
        Me.btnInfoIntegridad.Size = New System.Drawing.Size(23, 21)
        Me.btnInfoIntegridad.TabIndex = 206
        Me.btnInfoIntegridad.Text = "..."
        Me.btnInfoIntegridad.UseVisualStyleBackColor = True
        '
        'btnInfoDispoNoclasifica
        '
        Me.btnInfoDispoNoclasifica.BackgroundImage = CType(resources.GetObject("btnInfoDispoNoclasifica.BackgroundImage"), System.Drawing.Image)
        Me.btnInfoDispoNoclasifica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfoDispoNoclasifica.Location = New System.Drawing.Point(1225, 225)
        Me.btnInfoDispoNoclasifica.Name = "btnInfoDispoNoclasifica"
        Me.btnInfoDispoNoclasifica.Size = New System.Drawing.Size(20, 17)
        Me.btnInfoDispoNoclasifica.TabIndex = 202
        Me.btnInfoDispoNoclasifica.Text = "..."
        Me.btnInfoDispoNoclasifica.UseVisualStyleBackColor = True
        '
        'btnInfoDispoBaja
        '
        Me.btnInfoDispoBaja.BackgroundImage = CType(resources.GetObject("btnInfoDispoBaja.BackgroundImage"), System.Drawing.Image)
        Me.btnInfoDispoBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfoDispoBaja.Location = New System.Drawing.Point(1173, 225)
        Me.btnInfoDispoBaja.Name = "btnInfoDispoBaja"
        Me.btnInfoDispoBaja.Size = New System.Drawing.Size(20, 17)
        Me.btnInfoDispoBaja.TabIndex = 197
        Me.btnInfoDispoBaja.Text = "..."
        Me.btnInfoDispoBaja.UseVisualStyleBackColor = True
        '
        'btnInfoDispoMedia
        '
        Me.btnInfoDispoMedia.BackgroundImage = CType(resources.GetObject("btnInfoDispoMedia.BackgroundImage"), System.Drawing.Image)
        Me.btnInfoDispoMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfoDispoMedia.Location = New System.Drawing.Point(1121, 225)
        Me.btnInfoDispoMedia.Name = "btnInfoDispoMedia"
        Me.btnInfoDispoMedia.Size = New System.Drawing.Size(20, 17)
        Me.btnInfoDispoMedia.TabIndex = 196
        Me.btnInfoDispoMedia.Text = "..."
        Me.btnInfoDispoMedia.UseVisualStyleBackColor = True
        '
        'btnInfoDispoAlta
        '
        Me.btnInfoDispoAlta.BackgroundImage = CType(resources.GetObject("btnInfoDispoAlta.BackgroundImage"), System.Drawing.Image)
        Me.btnInfoDispoAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfoDispoAlta.Location = New System.Drawing.Point(1069, 225)
        Me.btnInfoDispoAlta.Name = "btnInfoDispoAlta"
        Me.btnInfoDispoAlta.Size = New System.Drawing.Size(20, 17)
        Me.btnInfoDispoAlta.TabIndex = 195
        Me.btnInfoDispoAlta.Text = "..."
        Me.btnInfoDispoAlta.UseVisualStyleBackColor = True
        '
        'btnInfoInteNoclasifica
        '
        Me.btnInfoInteNoclasifica.BackgroundImage = CType(resources.GetObject("btnInfoInteNoclasifica.BackgroundImage"), System.Drawing.Image)
        Me.btnInfoInteNoclasifica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfoInteNoclasifica.Location = New System.Drawing.Point(794, 225)
        Me.btnInfoInteNoclasifica.Name = "btnInfoInteNoclasifica"
        Me.btnInfoInteNoclasifica.Size = New System.Drawing.Size(20, 17)
        Me.btnInfoInteNoclasifica.TabIndex = 194
        Me.btnInfoInteNoclasifica.Text = "..."
        Me.btnInfoInteNoclasifica.UseVisualStyleBackColor = True
        '
        'btnInfoInteBaja
        '
        Me.btnInfoInteBaja.BackgroundImage = CType(resources.GetObject("btnInfoInteBaja.BackgroundImage"), System.Drawing.Image)
        Me.btnInfoInteBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfoInteBaja.Location = New System.Drawing.Point(742, 225)
        Me.btnInfoInteBaja.Name = "btnInfoInteBaja"
        Me.btnInfoInteBaja.Size = New System.Drawing.Size(20, 17)
        Me.btnInfoInteBaja.TabIndex = 189
        Me.btnInfoInteBaja.Text = "..."
        Me.btnInfoInteBaja.UseVisualStyleBackColor = True
        '
        'btnInfIntegMedia
        '
        Me.btnInfIntegMedia.BackgroundImage = CType(resources.GetObject("btnInfIntegMedia.BackgroundImage"), System.Drawing.Image)
        Me.btnInfIntegMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfIntegMedia.Location = New System.Drawing.Point(690, 225)
        Me.btnInfIntegMedia.Name = "btnInfIntegMedia"
        Me.btnInfIntegMedia.Size = New System.Drawing.Size(20, 17)
        Me.btnInfIntegMedia.TabIndex = 188
        Me.btnInfIntegMedia.Text = "..."
        Me.btnInfIntegMedia.UseVisualStyleBackColor = True
        '
        'btnInfInteAlta
        '
        Me.btnInfInteAlta.BackgroundImage = CType(resources.GetObject("btnInfInteAlta.BackgroundImage"), System.Drawing.Image)
        Me.btnInfInteAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfInteAlta.Location = New System.Drawing.Point(638, 225)
        Me.btnInfInteAlta.Name = "btnInfInteAlta"
        Me.btnInfInteAlta.Size = New System.Drawing.Size(20, 17)
        Me.btnInfInteAlta.TabIndex = 187
        Me.btnInfInteAlta.Text = "..."
        Me.btnInfInteAlta.UseVisualStyleBackColor = True
        '
        'btnInfNoAPlica
        '
        Me.btnInfNoAPlica.BackgroundImage = CType(resources.GetObject("btnInfNoAPlica.BackgroundImage"), System.Drawing.Image)
        Me.btnInfNoAPlica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfNoAPlica.Location = New System.Drawing.Point(376, 221)
        Me.btnInfNoAPlica.Name = "btnInfNoAPlica"
        Me.btnInfNoAPlica.Size = New System.Drawing.Size(20, 17)
        Me.btnInfNoAPlica.TabIndex = 186
        Me.btnInfNoAPlica.Text = "..."
        Me.btnInfNoAPlica.UseVisualStyleBackColor = True
        '
        'btnInfIdentificador
        '
        Me.btnInfIdentificador.BackgroundImage = CType(resources.GetObject("btnInfIdentificador.BackgroundImage"), System.Drawing.Image)
        Me.btnInfIdentificador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfIdentificador.Location = New System.Drawing.Point(141, 39)
        Me.btnInfIdentificador.Name = "btnInfIdentificador"
        Me.btnInfIdentificador.Size = New System.Drawing.Size(23, 21)
        Me.btnInfIdentificador.TabIndex = 181
        Me.btnInfIdentificador.Text = "..."
        Me.btnInfIdentificador.UseVisualStyleBackColor = True
        '
        'btnInfoTipo
        '
        Me.btnInfoTipo.BackgroundImage = CType(resources.GetObject("btnInfoTipo.BackgroundImage"), System.Drawing.Image)
        Me.btnInfoTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfoTipo.Location = New System.Drawing.Point(551, 73)
        Me.btnInfoTipo.Name = "btnInfoTipo"
        Me.btnInfoTipo.Size = New System.Drawing.Size(23, 21)
        Me.btnInfoTipo.TabIndex = 180
        Me.btnInfoTipo.Text = "..."
        Me.btnInfoTipo.UseVisualStyleBackColor = True
        '
        'btnInfPublic
        '
        Me.btnInfPublic.BackgroundImage = CType(resources.GetObject("btnInfPublic.BackgroundImage"), System.Drawing.Image)
        Me.btnInfPublic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfPublic.Location = New System.Drawing.Point(324, 221)
        Me.btnInfPublic.Name = "btnInfPublic"
        Me.btnInfPublic.Size = New System.Drawing.Size(20, 17)
        Me.btnInfPublic.TabIndex = 173
        Me.btnInfPublic.Text = "..."
        Me.btnInfPublic.UseVisualStyleBackColor = True
        '
        'btnInfClasificada
        '
        Me.btnInfClasificada.BackgroundImage = CType(resources.GetObject("btnInfClasificada.BackgroundImage"), System.Drawing.Image)
        Me.btnInfClasificada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfClasificada.Location = New System.Drawing.Point(272, 221)
        Me.btnInfClasificada.Name = "btnInfClasificada"
        Me.btnInfClasificada.Size = New System.Drawing.Size(20, 17)
        Me.btnInfClasificada.TabIndex = 172
        Me.btnInfClasificada.Text = "..."
        Me.btnInfClasificada.UseVisualStyleBackColor = True
        '
        'btnInfReservada
        '
        Me.btnInfReservada.BackgroundImage = CType(resources.GetObject("btnInfReservada.BackgroundImage"), System.Drawing.Image)
        Me.btnInfReservada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfReservada.Location = New System.Drawing.Point(220, 221)
        Me.btnInfReservada.Name = "btnInfReservada"
        Me.btnInfReservada.Size = New System.Drawing.Size(20, 17)
        Me.btnInfReservada.TabIndex = 171
        Me.btnInfReservada.Text = "..."
        Me.btnInfReservada.UseVisualStyleBackColor = True
        '
        'btnInfConfidencialidad
        '
        Me.btnInfConfidencialidad.BackgroundImage = CType(resources.GetObject("btnInfConfidencialidad.BackgroundImage"), System.Drawing.Image)
        Me.btnInfConfidencialidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfConfidencialidad.Location = New System.Drawing.Point(170, 266)
        Me.btnInfConfidencialidad.Name = "btnInfConfidencialidad"
        Me.btnInfConfidencialidad.Size = New System.Drawing.Size(24, 21)
        Me.btnInfConfidencialidad.TabIndex = 170
        Me.btnInfConfidencialidad.Text = "..."
        Me.btnInfConfidencialidad.UseVisualStyleBackColor = True
        '
        'btnRevisadoBusque
        '
        Me.btnRevisadoBusque.BackgroundImage = CType(resources.GetObject("btnRevisadoBusque.BackgroundImage"), System.Drawing.Image)
        Me.btnRevisadoBusque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRevisadoBusque.Location = New System.Drawing.Point(517, 354)
        Me.btnRevisadoBusque.Name = "btnRevisadoBusque"
        Me.btnRevisadoBusque.Size = New System.Drawing.Size(28, 30)
        Me.btnRevisadoBusque.TabIndex = 25
        Me.btnRevisadoBusque.Text = "..."
        Me.btnRevisadoBusque.UseVisualStyleBackColor = True
        '
        'btnAprobado
        '
        Me.btnAprobado.BackgroundImage = CType(resources.GetObject("btnAprobado.BackgroundImage"), System.Drawing.Image)
        Me.btnAprobado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAprobado.Location = New System.Drawing.Point(1080, 306)
        Me.btnAprobado.Name = "btnAprobado"
        Me.btnAprobado.Size = New System.Drawing.Size(26, 30)
        Me.btnAprobado.TabIndex = 22
        Me.btnAprobado.Text = "..."
        Me.btnAprobado.UseVisualStyleBackColor = True
        '
        'btnElaborado
        '
        Me.btnElaborado.BackgroundImage = CType(resources.GetObject("btnElaborado.BackgroundImage"), System.Drawing.Image)
        Me.btnElaborado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnElaborado.Location = New System.Drawing.Point(521, 306)
        Me.btnElaborado.Name = "btnElaborado"
        Me.btnElaborado.Size = New System.Drawing.Size(29, 30)
        Me.btnElaborado.TabIndex = 19
        Me.btnElaborado.Text = "..."
        Me.btnElaborado.UseVisualStyleBackColor = True
        '
        'btnPropietario
        '
        Me.btnPropietario.BackgroundImage = CType(resources.GetObject("btnPropietario.BackgroundImage"), System.Drawing.Image)
        Me.btnPropietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPropietario.Location = New System.Drawing.Point(477, 186)
        Me.btnPropietario.Name = "btnPropietario"
        Me.btnPropietario.Size = New System.Drawing.Size(31, 30)
        Me.btnPropietario.TabIndex = 10
        Me.btnPropietario.Text = "..."
        Me.btnPropietario.UseVisualStyleBackColor = True
        '
        'btnRevisado
        '
        Me.btnRevisado.BackgroundImage = CType(resources.GetObject("btnRevisado.BackgroundImage"), System.Drawing.Image)
        Me.btnRevisado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRevisado.Location = New System.Drawing.Point(551, 354)
        Me.btnRevisado.Name = "btnRevisado"
        Me.btnRevisado.Size = New System.Drawing.Size(28, 30)
        Me.btnRevisado.TabIndex = 26
        Me.btnRevisado.Text = "..."
        Me.btnRevisado.UseVisualStyleBackColor = True
        '
        'btnTipo
        '
        Me.btnTipo.BackgroundImage = CType(resources.GetObject("btnTipo.BackgroundImage"), System.Drawing.Image)
        Me.btnTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTipo.Location = New System.Drawing.Point(938, 67)
        Me.btnTipo.Name = "btnTipo"
        Me.btnTipo.Size = New System.Drawing.Size(53, 30)
        Me.btnTipo.TabIndex = 160
        Me.btnTipo.Text = "..."
        Me.btnTipo.UseVisualStyleBackColor = True
        '
        'btnEmpleado3
        '
        Me.btnEmpleado3.BackgroundImage = CType(resources.GetObject("btnEmpleado3.BackgroundImage"), System.Drawing.Image)
        Me.btnEmpleado3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEmpleado3.Location = New System.Drawing.Point(1112, 306)
        Me.btnEmpleado3.Name = "btnEmpleado3"
        Me.btnEmpleado3.Size = New System.Drawing.Size(26, 30)
        Me.btnEmpleado3.TabIndex = 23
        Me.btnEmpleado3.Text = "..."
        Me.btnEmpleado3.UseVisualStyleBackColor = True
        '
        'btnPuesto
        '
        Me.btnPuesto.BackgroundImage = CType(resources.GetObject("btnPuesto.BackgroundImage"), System.Drawing.Image)
        Me.btnPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPuesto.Location = New System.Drawing.Point(891, 186)
        Me.btnPuesto.Name = "btnPuesto"
        Me.btnPuesto.Size = New System.Drawing.Size(33, 30)
        Me.btnPuesto.TabIndex = 13
        Me.btnPuesto.Text = "..."
        Me.btnPuesto.UseVisualStyleBackColor = True
        '
        'btnEmpleado2
        '
        Me.btnEmpleado2.BackgroundImage = CType(resources.GetObject("btnEmpleado2.BackgroundImage"), System.Drawing.Image)
        Me.btnEmpleado2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEmpleado2.Location = New System.Drawing.Point(556, 306)
        Me.btnEmpleado2.Name = "btnEmpleado2"
        Me.btnEmpleado2.Size = New System.Drawing.Size(31, 30)
        Me.btnEmpleado2.TabIndex = 20
        Me.btnEmpleado2.Text = "..."
        Me.btnEmpleado2.UseVisualStyleBackColor = True
        '
        'btnEmpleado
        '
        Me.btnEmpleado.BackgroundImage = CType(resources.GetObject("btnEmpleado.BackgroundImage"), System.Drawing.Image)
        Me.btnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEmpleado.Location = New System.Drawing.Point(514, 186)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Size = New System.Drawing.Size(31, 30)
        Me.btnEmpleado.TabIndex = 11
        Me.btnEmpleado.Text = "..."
        Me.btnEmpleado.UseVisualStyleBackColor = True
        '
        'btnProceso
        '
        Me.btnProceso.BackgroundImage = CType(resources.GetObject("btnProceso.BackgroundImage"), System.Drawing.Image)
        Me.btnProceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProceso.Location = New System.Drawing.Point(938, 31)
        Me.btnProceso.Name = "btnProceso"
        Me.btnProceso.Size = New System.Drawing.Size(53, 30)
        Me.btnProceso.TabIndex = 3
        Me.btnProceso.Text = "..."
        Me.btnProceso.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Location = New System.Drawing.Point(1253, 186)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 38)
        Me.btnBuscar.TabIndex = 35
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.Location = New System.Drawing.Point(1144, 116)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 38)
        Me.btnCancelar.TabIndex = 34
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar.Location = New System.Drawing.Point(1253, 67)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 38)
        Me.btnEliminar.TabIndex = 33
        Me.btnEliminar.Text = "E&liminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.Location = New System.Drawing.Point(1144, 67)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 38)
        Me.btnEditar.TabIndex = 32
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Location = New System.Drawing.Point(1253, 23)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 38)
        Me.btnGuardar.TabIndex = 31
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = CType(resources.GetObject("btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.Location = New System.Drawing.Point(1144, 23)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 38)
        Me.btnNuevo.TabIndex = 30
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmActivosInformacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1363, 956)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.btnJustificacion)
        Me.Controls.Add(Me.btnInfoDisponibilidad)
        Me.Controls.Add(Me.btnInfoIntegridad)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.btnInfoDispoNoclasifica)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.btnInfoDispoBaja)
        Me.Controls.Add(Me.btnInfoDispoMedia)
        Me.Controls.Add(Me.btnInfoDispoAlta)
        Me.Controls.Add(Me.btnInfoInteNoclasifica)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.btnInfoInteBaja)
        Me.Controls.Add(Me.btnInfIntegMedia)
        Me.Controls.Add(Me.btnInfInteAlta)
        Me.Controls.Add(Me.btnInfNoAPlica)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnInfIdentificador)
        Me.Controls.Add(Me.btnInfoTipo)
        Me.Controls.Add(Me.btnInfPublic)
        Me.Controls.Add(Me.btnInfClasificada)
        Me.Controls.Add(Me.btnInfReservada)
        Me.Controls.Add(Me.btnInfConfidencialidad)
        Me.Controls.Add(Me.txtIdRevisado)
        Me.Controls.Add(Me.btnRevisadoBusque)
        Me.Controls.Add(Me.btnAprobado)
        Me.Controls.Add(Me.btnElaborado)
        Me.Controls.Add(Me.btnPropietario)
        Me.Controls.Add(Me.btnRevisado)
        Me.Controls.Add(Me.txtIdAprobado)
        Me.Controls.Add(Me.TxtIdElaborado)
        Me.Controls.Add(Me.txtIdPropietario)
        Me.Controls.Add(Me.btnTipo)
        Me.Controls.Add(Me.btnEmpleado3)
        Me.Controls.Add(Me.DTPFechaValidacion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnPuesto)
        Me.Controls.Add(Me.cboPropCargo)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtAprobado)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnEmpleado2)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtElaborado)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cboDisponibilidad)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cboIntegridad)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cboConfidencialidad)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DTPFechaIngreso)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnEmpleado)
        Me.Controls.Add(Me.txtPropietario)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.txtNombreActivoInf)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboProceso)
        Me.Controls.Add(Me.txtRevisado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DTPFechaSalida)
        Me.Controls.Add(Me.btnProceso)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cboUbicacion)
        Me.Controls.Add(Me.txtJustificación)
        Me.Controls.Add(Me.txtIdentificador)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmActivosInformacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Activos Informacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvActivosInf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtRevisado As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DTPFechaSalida As DateTimePicker
    Friend WithEvents btnProceso As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbPropietario As RadioButton
    Friend WithEvents rbElaborado As RadioButton
    Friend WithEvents rbUbicacion As RadioButton
    Friend WithEvents lblTotalActivos As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvActivosInf As DataGridView
    Friend WithEvents cboUbicacion As ComboBox
    Friend WithEvents txtJustificación As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtIdentificador As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboProceso As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtNombreActivoInf As TextBox
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents txtPropietario As TextBox
    Friend WithEvents btnEmpleado As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents DTPFechaIngreso As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cboConfidencialidad As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cboIntegridad As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cboDisponibilidad As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtElaborado As TextBox
    Friend WithEvents btnEmpleado2 As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents txtAprobado As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents cboPropCargo As ComboBox
    Friend WithEvents btnPuesto As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents DTPFechaValidacion As DateTimePicker
    Friend WithEvents btnEmpleado3 As Button
    Friend WithEvents btnTipo As Button
    Friend WithEvents txtIdPropietario As TextBox
    Friend WithEvents TxtIdElaborado As TextBox
    Friend WithEvents txtIdAprobado As TextBox
    Friend WithEvents btnRevisado As Button
    Friend WithEvents btnPropietario As Button
    Friend WithEvents btnElaborado As Button
    Friend WithEvents btnAprobado As Button
    Friend WithEvents btnRevisadoBusque As Button
    Friend WithEvents txtIdRevisado As TextBox
    Friend WithEvents Elaborado As DataGridViewTextBoxColumn
    Friend WithEvents Aprobado As DataGridViewTextBoxColumn
    Friend WithEvents IdActivoInf As DataGridViewTextBoxColumn
    Friend WithEvents IdentificadorActivo As DataGridViewTextBoxColumn
    Friend WithEvents NombreActivo As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents NombreT As DataGridViewTextBoxColumn
    Friend WithEvents Ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents Ruta As DataGridViewTextBoxColumn
    Friend WithEvents JustificacionActivo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents NombreP As DataGridViewTextBoxColumn
    Friend WithEvents FechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents ClasiConfi As DataGridViewTextBoxColumn
    Friend WithEvents ClasiInteg As DataGridViewTextBoxColumn
    Friend WithEvents ClasiDispon As DataGridViewTextBoxColumn
    Friend WithEvents NombreEla As DataGridViewTextBoxColumn
    Friend WithEvents NombreApro As DataGridViewTextBoxColumn
    Friend WithEvents NombreRev As DataGridViewTextBoxColumn
    Friend WithEvents FechaValidacion As DataGridViewTextBoxColumn
    Friend WithEvents FechaSalida As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents IdTipo As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents IdPuesto As DataGridViewTextBoxColumn
    Friend WithEvents IdTipo1 As DataGridViewTextBoxColumn
    Friend WithEvents IdPropietario As DataGridViewTextBoxColumn
    Friend WithEvents IdElaborado As DataGridViewTextBoxColumn
    Friend WithEvents IdAprobado As DataGridViewTextBoxColumn
    Friend WithEvents IdRevisado As DataGridViewTextBoxColumn
    Friend WithEvents rbProceso As RadioButton
    Friend WithEvents btnInfConfidencialidad As Button
    Friend WithEvents btnInfReservada As Button
    Friend WithEvents btnInfClasificada As Button
    Friend WithEvents btnInfPublic As Button
    Friend WithEvents btnInfoTipo As Button
    Friend WithEvents btnInfIdentificador As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents btnInfNoAPlica As Button
    Friend WithEvents btnInfoInteNoclasifica As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents btnInfoInteBaja As Button
    Friend WithEvents btnInfIntegMedia As Button
    Friend WithEvents btnInfInteAlta As Button
    Friend WithEvents btnInfoDispoNoclasifica As Button
    Friend WithEvents Label33 As Label
    Friend WithEvents btnInfoDispoBaja As Button
    Friend WithEvents btnInfoDispoMedia As Button
    Friend WithEvents btnInfoDispoAlta As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents btnInfoIntegridad As Button
    Friend WithEvents btnInfoDisponibilidad As Button
    Friend WithEvents btnJustificacion As Button
    Friend WithEvents btnReporte As Button
End Class
