<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescargoActivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescargoActivos))
        Me.txtIdCargo = New System.Windows.Forms.TextBox()
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DTPFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbNombreEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbCodigoInventario = New System.Windows.Forms.RadioButton()
        Me.rbNombreArticulo = New System.Windows.Forms.RadioButton()
        Me.lblTotalActivosDescargados = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvActivosDescargados = New System.Windows.Forms.DataGridView()
        Me.IdCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDescargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotivoDescargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDescargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.cboMotivo = New System.Windows.Forms.ComboBox()
        Me.txtCodigoI = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFechaDescargo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCargos = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnImprimirHurtados = New System.Windows.Forms.Button()
        Me.btnImprimirObsoletos = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnImprimirBajas = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvActivosDescargados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdCargo
        '
        Me.txtIdCargo.Location = New System.Drawing.Point(1025, 74)
        Me.txtIdCargo.Name = "txtIdCargo"
        Me.txtIdCargo.Size = New System.Drawing.Size(34, 20)
        Me.txtIdCargo.TabIndex = 130
        Me.txtIdCargo.Visible = False
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.Location = New System.Drawing.Point(1025, 36)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(34, 20)
        Me.txtIdArticulo.TabIndex = 129
        Me.txtIdArticulo.Visible = False
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(862, 73)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(144, 20)
        Me.txtDepartamento.TabIndex = 128
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Silver
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(736, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 15)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Departamento:"
        '
        'txtNombreE
        '
        Me.txtNombreE.Location = New System.Drawing.Point(514, 72)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.ReadOnly = True
        Me.txtNombreE.Size = New System.Drawing.Size(212, 20)
        Me.txtNombreE.TabIndex = 126
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(360, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 15)
        Me.Label12.TabIndex = 125
        Me.Label12.Text = "Nombre Empleado:"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(165, 72)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.ReadOnly = True
        Me.txtIdentidad.Size = New System.Drawing.Size(116, 20)
        Me.txtIdentidad.TabIndex = 101
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 15)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "N. Identidad:"
        '
        'DTPFechaEntrega
        '
        Me.DTPFechaEntrega.Enabled = False
        Me.DTPFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaEntrega.Location = New System.Drawing.Point(165, 111)
        Me.DTPFechaEntrega.Name = "DTPFechaEntrega"
        Me.DTPFechaEntrega.Size = New System.Drawing.Size(123, 20)
        Me.DTPFechaEntrega.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Silver
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 15)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "Fecha de Entrega:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbDepartamento)
        Me.Panel1.Controls.Add(Me.rbNombreEmpleado)
        Me.Panel1.Controls.Add(Me.rbCodigoInventario)
        Me.Panel1.Controls.Add(Me.rbNombreArticulo)
        Me.Panel1.Controls.Add(Me.lblTotalActivosDescargados)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvActivosDescargados)
        Me.Panel1.Location = New System.Drawing.Point(32, 465)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1347, 637)
        Me.Panel1.TabIndex = 122
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.Location = New System.Drawing.Point(510, 31)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(98, 17)
        Me.rbDepartamento.TabIndex = 18
        Me.rbDepartamento.Text = " Departamento:"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'rbNombreEmpleado
        '
        Me.rbNombreEmpleado.AutoSize = True
        Me.rbNombreEmpleado.Location = New System.Drawing.Point(365, 31)
        Me.rbNombreEmpleado.Name = "rbNombreEmpleado"
        Me.rbNombreEmpleado.Size = New System.Drawing.Size(115, 17)
        Me.rbNombreEmpleado.TabIndex = 17
        Me.rbNombreEmpleado.Text = "Nombre Empleado:"
        Me.rbNombreEmpleado.UseVisualStyleBackColor = True
        '
        'rbCodigoInventario
        '
        Me.rbCodigoInventario.AutoSize = True
        Me.rbCodigoInventario.Location = New System.Drawing.Point(237, 31)
        Me.rbCodigoInventario.Name = "rbCodigoInventario"
        Me.rbCodigoInventario.Size = New System.Drawing.Size(111, 17)
        Me.rbCodigoInventario.TabIndex = 16
        Me.rbCodigoInventario.Text = "Codigo Inventario:"
        Me.rbCodigoInventario.UseVisualStyleBackColor = True
        '
        'rbNombreArticulo
        '
        Me.rbNombreArticulo.AutoSize = True
        Me.rbNombreArticulo.Checked = True
        Me.rbNombreArticulo.Location = New System.Drawing.Point(100, 30)
        Me.rbNombreArticulo.Name = "rbNombreArticulo"
        Me.rbNombreArticulo.Size = New System.Drawing.Size(102, 17)
        Me.rbNombreArticulo.TabIndex = 15
        Me.rbNombreArticulo.TabStop = True
        Me.rbNombreArticulo.Text = "Nombre Artículo"
        Me.rbNombreArticulo.UseVisualStyleBackColor = True
        '
        'lblTotalActivosDescargados
        '
        Me.lblTotalActivosDescargados.AutoSize = True
        Me.lblTotalActivosDescargados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalActivosDescargados.Location = New System.Drawing.Point(97, 601)
        Me.lblTotalActivosDescargados.Name = "lblTotalActivosDescargados"
        Me.lblTotalActivosDescargados.Size = New System.Drawing.Size(44, 16)
        Me.lblTotalActivosDescargados.TabIndex = 17
        Me.lblTotalActivosDescargados.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 601)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Registros:"
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
        Me.txtBuscar.Location = New System.Drawing.Point(752, 27)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(571, 20)
        Me.txtBuscar.TabIndex = 19
        '
        'dgvActivosDescargados
        '
        Me.dgvActivosDescargados.AllowUserToAddRows = False
        Me.dgvActivosDescargados.AllowUserToDeleteRows = False
        Me.dgvActivosDescargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActivosDescargados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCargo, Me.CodigoInventario, Me.NombreA, Me.PrecioCompra, Me.Nombre, Me.Identidad, Me.NombreD, Me.FechaDescargo, Me.MotivoDescargo, Me.Descripcion, Me.IdArticulo, Me.IdEmpleado, Me.CodigoA, Me.EstadoArticulo, Me.IdDescargo})
        Me.dgvActivosDescargados.Location = New System.Drawing.Point(22, 70)
        Me.dgvActivosDescargados.Name = "dgvActivosDescargados"
        Me.dgvActivosDescargados.ReadOnly = True
        Me.dgvActivosDescargados.RowHeadersVisible = False
        Me.dgvActivosDescargados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActivosDescargados.Size = New System.Drawing.Size(1310, 515)
        Me.dgvActivosDescargados.TabIndex = 15
        '
        'IdCargo
        '
        Me.IdCargo.DataPropertyName = "IdCargo"
        Me.IdCargo.HeaderText = "ID"
        Me.IdCargo.Name = "IdCargo"
        Me.IdCargo.ReadOnly = True
        Me.IdCargo.Visible = False
        Me.IdCargo.Width = 10
        '
        'CodigoInventario
        '
        Me.CodigoInventario.DataPropertyName = "CodigoInventario"
        Me.CodigoInventario.HeaderText = "CODIGO INVENTARIO"
        Me.CodigoInventario.Name = "CodigoInventario"
        Me.CodigoInventario.ReadOnly = True
        '
        'NombreA
        '
        Me.NombreA.DataPropertyName = "NombreA"
        Me.NombreA.HeaderText = "NOMBRE DEL ACTIVO"
        Me.NombreA.Name = "NombreA"
        Me.NombreA.ReadOnly = True
        Me.NombreA.Width = 200
        '
        'PrecioCompra
        '
        Me.PrecioCompra.DataPropertyName = "PrecioCompra"
        Me.PrecioCompra.HeaderText = "PRECIO DE COMPRA"
        Me.PrecioCompra.Name = "PrecioCompra"
        Me.PrecioCompra.ReadOnly = True
        Me.PrecioCompra.Width = 120
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "NOMBRE EMPLEADO"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 125
        '
        'Identidad
        '
        Me.Identidad.DataPropertyName = "Identidad"
        Me.Identidad.HeaderText = "IDENTIDAD"
        Me.Identidad.Name = "Identidad"
        Me.Identidad.ReadOnly = True
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "DEPARTAMENTO"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        Me.NombreD.Width = 135
        '
        'FechaDescargo
        '
        Me.FechaDescargo.DataPropertyName = "FechaDescargo"
        Me.FechaDescargo.HeaderText = "FECHA DESCARGO"
        Me.FechaDescargo.Name = "FechaDescargo"
        Me.FechaDescargo.ReadOnly = True
        '
        'MotivoDescargo
        '
        Me.MotivoDescargo.DataPropertyName = "MotivoDescargo"
        Me.MotivoDescargo.HeaderText = "MOTIVO DESCARGO"
        Me.MotivoDescargo.Name = "MotivoDescargo"
        Me.MotivoDescargo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "DESCRIPCION"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 425
        '
        'IdArticulo
        '
        Me.IdArticulo.DataPropertyName = "IdArticulo"
        Me.IdArticulo.HeaderText = "IDARTICULO"
        Me.IdArticulo.Name = "IdArticulo"
        Me.IdArticulo.ReadOnly = True
        Me.IdArticulo.Visible = False
        '
        'IdEmpleado
        '
        Me.IdEmpleado.DataPropertyName = "IdEmpleado"
        Me.IdEmpleado.HeaderText = "IDEMPLEADO"
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.ReadOnly = True
        Me.IdEmpleado.Visible = False
        '
        'CodigoA
        '
        Me.CodigoA.DataPropertyName = "CodigoA"
        Me.CodigoA.HeaderText = "CODIGOARTICULO"
        Me.CodigoA.Name = "CodigoA"
        Me.CodigoA.ReadOnly = True
        Me.CodigoA.Visible = False
        '
        'EstadoArticulo
        '
        Me.EstadoArticulo.DataPropertyName = "EstadoArticulo"
        Me.EstadoArticulo.HeaderText = "ESTADOARTICULO"
        Me.EstadoArticulo.Name = "EstadoArticulo"
        Me.EstadoArticulo.ReadOnly = True
        Me.EstadoArticulo.Visible = False
        '
        'IdDescargo
        '
        Me.IdDescargo.DataPropertyName = "IdDescargo"
        Me.IdDescargo.HeaderText = "ID DESCARGO"
        Me.IdDescargo.Name = "IdDescargo"
        Me.IdDescargo.ReadOnly = True
        Me.IdDescargo.Visible = False
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(862, 37)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(144, 20)
        Me.txtPrecio.TabIndex = 114
        '
        'cboMotivo
        '
        Me.cboMotivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMotivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMotivo.FormattingEnabled = True
        Me.cboMotivo.Items.AddRange(New Object() {"Obsoleto", "Cambio", "Hurto"})
        Me.cboMotivo.Location = New System.Drawing.Point(862, 114)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Size = New System.Drawing.Size(144, 21)
        Me.cboMotivo.TabIndex = 5
        '
        'txtCodigoI
        '
        Me.txtCodigoI.Location = New System.Drawing.Point(165, 41)
        Me.txtCodigoI.Name = "txtCodigoI"
        Me.txtCodigoI.Size = New System.Drawing.Size(116, 20)
        Me.txtCodigoI.TabIndex = 1
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(154, 203)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(852, 80)
        Me.txtDescripcion.TabIndex = 8
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(514, 37)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.ReadOnly = True
        Me.txtNombreA.Size = New System.Drawing.Size(212, 20)
        Me.txtNombreA.TabIndex = 113
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(32, 136)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(34, 20)
        Me.txtId.TabIndex = 121
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(736, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 15)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Motivo Descargo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(736, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Precio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 15)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Código Inventario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 15)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Nombre de Artículo:"
        '
        'DTPFechaDescargo
        '
        Me.DTPFechaDescargo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaDescargo.Location = New System.Drawing.Point(514, 110)
        Me.DTPFechaDescargo.Name = "DTPFechaDescargo"
        Me.DTPFechaDescargo.Size = New System.Drawing.Size(123, 20)
        Me.DTPFechaDescargo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(360, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 15)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Fecha de Descargo:"
        '
        'btnCargos
        '
        Me.btnCargos.BackgroundImage = CType(resources.GetObject("btnCargos.BackgroundImage"), System.Drawing.Image)
        Me.btnCargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCargos.Location = New System.Drawing.Point(287, 36)
        Me.btnCargos.Name = "btnCargos"
        Me.btnCargos.Size = New System.Drawing.Size(34, 27)
        Me.btnCargos.TabIndex = 2
        Me.btnCargos.Text = "..."
        Me.btnCargos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Location = New System.Drawing.Point(1306, 224)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 38)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.Location = New System.Drawing.Point(1197, 123)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 38)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar.Location = New System.Drawing.Point(1306, 74)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 38)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "E&liminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.Location = New System.Drawing.Point(1197, 74)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 38)
        Me.btnEditar.TabIndex = 11
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Location = New System.Drawing.Point(1306, 30)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 38)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = CType(resources.GetObject("btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.Location = New System.Drawing.Point(1197, 30)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 38)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnImprimirHurtados
        '
        Me.btnImprimirHurtados.BackgroundImage = CType(resources.GetObject("btnImprimirHurtados.BackgroundImage"), System.Drawing.Image)
        Me.btnImprimirHurtados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnImprimirHurtados.Location = New System.Drawing.Point(1197, 386)
        Me.btnImprimirHurtados.Name = "btnImprimirHurtados"
        Me.btnImprimirHurtados.Size = New System.Drawing.Size(108, 57)
        Me.btnImprimirHurtados.TabIndex = 133
        Me.btnImprimirHurtados.Text = "Reporte Artículos &Hurtados"
        Me.btnImprimirHurtados.UseVisualStyleBackColor = True
        '
        'btnImprimirObsoletos
        '
        Me.btnImprimirObsoletos.BackgroundImage = CType(resources.GetObject("btnImprimirObsoletos.BackgroundImage"), System.Drawing.Image)
        Me.btnImprimirObsoletos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnImprimirObsoletos.Location = New System.Drawing.Point(898, 386)
        Me.btnImprimirObsoletos.Name = "btnImprimirObsoletos"
        Me.btnImprimirObsoletos.Size = New System.Drawing.Size(108, 57)
        Me.btnImprimirObsoletos.TabIndex = 135
        Me.btnImprimirObsoletos.Text = "Rep&orte Artículos Obsoletos"
        Me.btnImprimirObsoletos.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = CType(resources.GetObject("btnImprimir.BackgroundImage"), System.Drawing.Image)
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnImprimir.Location = New System.Drawing.Point(529, 386)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(108, 57)
        Me.btnImprimir.TabIndex = 134
        Me.btnImprimir.Text = "&Reporte Artículos sin Asignar"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnImprimirBajas
        '
        Me.btnImprimirBajas.BackgroundImage = CType(resources.GetObject("btnImprimirBajas.BackgroundImage"), System.Drawing.Image)
        Me.btnImprimirBajas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnImprimirBajas.Location = New System.Drawing.Point(180, 386)
        Me.btnImprimirBajas.Name = "btnImprimirBajas"
        Me.btnImprimirBajas.Size = New System.Drawing.Size(108, 57)
        Me.btnImprimirBajas.TabIndex = 136
        Me.btnImprimirBajas.Text = "&Reporte de Bajas de Artículos"
        Me.btnImprimirBajas.UseVisualStyleBackColor = True
        '
        'frmDescargoActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SisInvCCB.My.Resources.Resources.descar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1416, 1031)
        Me.Controls.Add(Me.btnImprimirBajas)
        Me.Controls.Add(Me.btnImprimirObsoletos)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnImprimirHurtados)
        Me.Controls.Add(Me.DTPFechaDescargo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdCargo)
        Me.Controls.Add(Me.txtIdArticulo)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtNombreE)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DTPFechaEntrega)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnCargos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.cboMotivo)
        Me.Controls.Add(Me.txtCodigoI)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombreA)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDescargoActivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Bajas de Activos Fijos de Empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvActivosDescargados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdCargo As TextBox
    Friend WithEvents txtIdArticulo As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DTPFechaEntrega As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCargos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbDepartamento As RadioButton
    Friend WithEvents rbNombreEmpleado As RadioButton
    Friend WithEvents rbCodigoInventario As RadioButton
    Friend WithEvents rbNombreArticulo As RadioButton
    Friend WithEvents lblTotalActivosDescargados As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvActivosDescargados As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents cboMotivo As ComboBox
    Friend WithEvents txtCodigoI As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombreA As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPFechaDescargo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents IdCargo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoInventario As DataGridViewTextBoxColumn
    Friend WithEvents NombreA As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents FechaDescargo As DataGridViewTextBoxColumn
    Friend WithEvents MotivoDescargo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents IdArticulo As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents CodigoA As DataGridViewTextBoxColumn
    Friend WithEvents EstadoArticulo As DataGridViewTextBoxColumn
    Friend WithEvents IdDescargo As DataGridViewTextBoxColumn
    Friend WithEvents btnImprimirHurtados As Button
    Friend WithEvents btnImprimirObsoletos As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnImprimirBajas As Button
End Class
