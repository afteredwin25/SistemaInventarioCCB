<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargoActivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargoActivos))
        Me.DTPFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbNombreEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbCodigoInventario = New System.Windows.Forms.RadioButton()
        Me.rbNombreArticulo = New System.Windows.Forms.RadioButton()
        Me.lblTotalActivosAsignados = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvActivosAsignados = New System.Windows.Forms.DataGridView()
        Me.IdCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtCodigoInventario = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.cboSede = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReporteSabaneta = New System.Windows.Forms.Button()
        Me.BtnEntregadosCaribe = New System.Windows.Forms.Button()
        Me.btnEntregadosCEDI = New System.Windows.Forms.Button()
        Me.btnEntregadosBarranquilla = New System.Windows.Forms.Button()
        Me.btnArticulosEntregadosAlquiler = New System.Windows.Forms.Button()
        Me.btnArticulosEntregadosCompra = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvActivosAsignados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTPFechaEntrega
        '
        Me.DTPFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaEntrega.Location = New System.Drawing.Point(505, 81)
        Me.DTPFechaEntrega.Name = "DTPFechaEntrega"
        Me.DTPFechaEntrega.Size = New System.Drawing.Size(123, 20)
        Me.DTPFechaEntrega.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Silver
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(351, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 15)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Fecha de Entrega:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbDepartamento)
        Me.Panel1.Controls.Add(Me.rbNombreEmpleado)
        Me.Panel1.Controls.Add(Me.rbCodigoInventario)
        Me.Panel1.Controls.Add(Me.rbNombreArticulo)
        Me.Panel1.Controls.Add(Me.lblTotalActivosAsignados)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvActivosAsignados)
        Me.Panel1.Location = New System.Drawing.Point(25, 359)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1347, 637)
        Me.Panel1.TabIndex = 89
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
        'lblTotalActivosAsignados
        '
        Me.lblTotalActivosAsignados.AutoSize = True
        Me.lblTotalActivosAsignados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalActivosAsignados.Location = New System.Drawing.Point(136, 601)
        Me.lblTotalActivosAsignados.Name = "lblTotalActivosAsignados"
        Me.lblTotalActivosAsignados.Size = New System.Drawing.Size(44, 16)
        Me.lblTotalActivosAsignados.TabIndex = 17
        Me.lblTotalActivosAsignados.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 601)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Activos Asignados:"
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
        'dgvActivosAsignados
        '
        Me.dgvActivosAsignados.AllowUserToAddRows = False
        Me.dgvActivosAsignados.AllowUserToDeleteRows = False
        Me.dgvActivosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActivosAsignados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCargo, Me.CodigoInventario, Me.NombreA, Me.PrecioCompra, Me.Nombre, Me.Identidad, Me.NombreD, Me.FechaAsignacion, Me.Sede, Me.Descripcion, Me.IdArticulo, Me.IdEmpleado, Me.CodigoA, Me.EstadoArticulo})
        Me.dgvActivosAsignados.Location = New System.Drawing.Point(22, 70)
        Me.dgvActivosAsignados.Name = "dgvActivosAsignados"
        Me.dgvActivosAsignados.ReadOnly = True
        Me.dgvActivosAsignados.RowHeadersVisible = False
        Me.dgvActivosAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActivosAsignados.Size = New System.Drawing.Size(1310, 515)
        Me.dgvActivosAsignados.TabIndex = 15
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
        'FechaAsignacion
        '
        Me.FechaAsignacion.DataPropertyName = "FechaAsignacion"
        Me.FechaAsignacion.HeaderText = "FECHA DE ASIGNACION"
        Me.FechaAsignacion.Name = "FechaAsignacion"
        Me.FechaAsignacion.ReadOnly = True
        '
        'Sede
        '
        Me.Sede.DataPropertyName = "Sede"
        Me.Sede.HeaderText = "SEDE"
        Me.Sede.Name = "Sede"
        Me.Sede.ReadOnly = True
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
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(853, 16)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(144, 20)
        Me.txtPrecio.TabIndex = 68
        '
        'cboEstado
        '
        Me.cboEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Nuevo", "Usado"})
        Me.cboEstado.Location = New System.Drawing.Point(853, 81)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(144, 21)
        Me.cboEstado.TabIndex = 7
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(145, 20)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(116, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtCodigoInventario
        '
        Me.txtCodigoInventario.Location = New System.Drawing.Point(145, 84)
        Me.txtCodigoInventario.Name = "txtCodigoInventario"
        Me.txtCodigoInventario.Size = New System.Drawing.Size(117, 20)
        Me.txtCodigoInventario.TabIndex = 5
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(140, 184)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(852, 80)
        Me.txtDescripcion.TabIndex = 8
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(505, 16)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.ReadOnly = True
        Me.txtNombreA.Size = New System.Drawing.Size(212, 20)
        Me.txtNombreA.TabIndex = 66
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(23, 103)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(34, 20)
        Me.txtId.TabIndex = 88
        Me.txtId.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(727, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 15)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Estado del Activo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(727, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Precio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 15)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Código Inventario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Código Artículo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 15)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Nombre de Artículo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(50, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 15)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "N. Identidad:"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(145, 51)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(116, 20)
        Me.txtIdentidad.TabIndex = 3
        '
        'txtNombreE
        '
        Me.txtNombreE.Location = New System.Drawing.Point(505, 51)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.ReadOnly = True
        Me.txtNombreE.Size = New System.Drawing.Size(212, 20)
        Me.txtNombreE.TabIndex = 94
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(351, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 15)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Nombre Empleado:"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(853, 52)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(144, 20)
        Me.txtDepartamento.TabIndex = 96
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Silver
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(727, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 15)
        Me.Label13.TabIndex = 95
        Me.Label13.Text = "Departamento:"
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.Location = New System.Drawing.Point(1016, 15)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(34, 20)
        Me.txtIdArticulo.TabIndex = 97
        Me.txtIdArticulo.Visible = False
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Location = New System.Drawing.Point(1016, 53)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(34, 20)
        Me.txtIdEmpleado.TabIndex = 98
        Me.txtIdEmpleado.Visible = False
        '
        'btnEmpleados
        '
        Me.btnEmpleados.BackgroundImage = CType(resources.GetObject("btnEmpleados.BackgroundImage"), System.Drawing.Image)
        Me.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEmpleados.Location = New System.Drawing.Point(267, 47)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(34, 27)
        Me.btnEmpleados.TabIndex = 4
        Me.btnEmpleados.Text = "..."
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnArticulos
        '
        Me.btnArticulos.BackgroundImage = CType(resources.GetObject("btnArticulos.BackgroundImage"), System.Drawing.Image)
        Me.btnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnArticulos.Location = New System.Drawing.Point(267, 15)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(34, 27)
        Me.btnArticulos.TabIndex = 2
        Me.btnArticulos.Text = "..."
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Location = New System.Drawing.Point(1297, 172)
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
        Me.btnCancelar.Location = New System.Drawing.Point(1188, 102)
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
        Me.btnEliminar.Location = New System.Drawing.Point(1297, 53)
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
        Me.btnEditar.Location = New System.Drawing.Point(1188, 53)
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
        Me.btnGuardar.Location = New System.Drawing.Point(1297, 9)
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
        Me.btnNuevo.Location = New System.Drawing.Point(1188, 9)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 38)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = CType(resources.GetObject("btnImprimir.BackgroundImage"), System.Drawing.Image)
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnImprimir.Location = New System.Drawing.Point(97, 296)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(108, 57)
        Me.btnImprimir.TabIndex = 99
        Me.btnImprimir.Text = "&Reporte Artículos Entregados"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'cboSede
        '
        Me.cboSede.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSede.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSede.FormattingEnabled = True
        Me.cboSede.Items.AddRange(New Object() {"Caribe Principal", "Sabaneta", "Cedi Caribe", "Sede Barranquilla"})
        Me.cboSede.Location = New System.Drawing.Point(145, 135)
        Me.cboSede.Name = "cboSede"
        Me.cboSede.Size = New System.Drawing.Size(179, 21)
        Me.cboSede.TabIndex = 174
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Sede:"
        '
        'btnReporteSabaneta
        '
        Me.btnReporteSabaneta.BackgroundImage = CType(resources.GetObject("btnReporteSabaneta.BackgroundImage"), System.Drawing.Image)
        Me.btnReporteSabaneta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnReporteSabaneta.Location = New System.Drawing.Point(970, 296)
        Me.btnReporteSabaneta.Name = "btnReporteSabaneta"
        Me.btnReporteSabaneta.Size = New System.Drawing.Size(108, 57)
        Me.btnReporteSabaneta.TabIndex = 176
        Me.btnReporteSabaneta.Text = "&Reporte Artículos Entregados Sabaneta"
        Me.btnReporteSabaneta.UseVisualStyleBackColor = True
        '
        'BtnEntregadosCaribe
        '
        Me.BtnEntregadosCaribe.BackgroundImage = CType(resources.GetObject("BtnEntregadosCaribe.BackgroundImage"), System.Drawing.Image)
        Me.BtnEntregadosCaribe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEntregadosCaribe.Location = New System.Drawing.Point(606, 296)
        Me.BtnEntregadosCaribe.Name = "BtnEntregadosCaribe"
        Me.BtnEntregadosCaribe.Size = New System.Drawing.Size(108, 57)
        Me.BtnEntregadosCaribe.TabIndex = 100
        Me.BtnEntregadosCaribe.Text = "&Reporte Artículos Entregados Caribe"
        Me.BtnEntregadosCaribe.UseVisualStyleBackColor = True
        '
        'btnEntregadosCEDI
        '
        Me.btnEntregadosCEDI.BackgroundImage = CType(resources.GetObject("btnEntregadosCEDI.BackgroundImage"), System.Drawing.Image)
        Me.btnEntregadosCEDI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEntregadosCEDI.Location = New System.Drawing.Point(802, 296)
        Me.btnEntregadosCEDI.Name = "btnEntregadosCEDI"
        Me.btnEntregadosCEDI.Size = New System.Drawing.Size(108, 57)
        Me.btnEntregadosCEDI.TabIndex = 177
        Me.btnEntregadosCEDI.Text = "&Reporte Artículos Entregados CEDI"
        Me.btnEntregadosCEDI.UseVisualStyleBackColor = True
        '
        'btnEntregadosBarranquilla
        '
        Me.btnEntregadosBarranquilla.BackgroundImage = CType(resources.GetObject("btnEntregadosBarranquilla.BackgroundImage"), System.Drawing.Image)
        Me.btnEntregadosBarranquilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEntregadosBarranquilla.Location = New System.Drawing.Point(1117, 296)
        Me.btnEntregadosBarranquilla.Name = "btnEntregadosBarranquilla"
        Me.btnEntregadosBarranquilla.Size = New System.Drawing.Size(108, 57)
        Me.btnEntregadosBarranquilla.TabIndex = 178
        Me.btnEntregadosBarranquilla.Text = "&Reporte Artículos Entregados Barranquilla"
        Me.btnEntregadosBarranquilla.UseVisualStyleBackColor = True
        '
        'btnArticulosEntregadosAlquiler
        '
        Me.btnArticulosEntregadosAlquiler.BackgroundImage = CType(resources.GetObject("btnArticulosEntregadosAlquiler.BackgroundImage"), System.Drawing.Image)
        Me.btnArticulosEntregadosAlquiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnArticulosEntregadosAlquiler.Location = New System.Drawing.Point(225, 296)
        Me.btnArticulosEntregadosAlquiler.Name = "btnArticulosEntregadosAlquiler"
        Me.btnArticulosEntregadosAlquiler.Size = New System.Drawing.Size(108, 57)
        Me.btnArticulosEntregadosAlquiler.TabIndex = 179
        Me.btnArticulosEntregadosAlquiler.Text = "&Reporte Artículos Entregados Alquiler"
        Me.btnArticulosEntregadosAlquiler.UseVisualStyleBackColor = True
        '
        'btnArticulosEntregadosCompra
        '
        Me.btnArticulosEntregadosCompra.BackgroundImage = CType(resources.GetObject("btnArticulosEntregadosCompra.BackgroundImage"), System.Drawing.Image)
        Me.btnArticulosEntregadosCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnArticulosEntregadosCompra.Location = New System.Drawing.Point(390, 296)
        Me.btnArticulosEntregadosCompra.Name = "btnArticulosEntregadosCompra"
        Me.btnArticulosEntregadosCompra.Size = New System.Drawing.Size(108, 57)
        Me.btnArticulosEntregadosCompra.TabIndex = 180
        Me.btnArticulosEntregadosCompra.Text = "&Reporte Artículos Entregados  Compra"
        Me.btnArticulosEntregadosCompra.UseVisualStyleBackColor = True
        '
        'frmCargoActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1408, 1030)
        Me.Controls.Add(Me.btnArticulosEntregadosCompra)
        Me.Controls.Add(Me.btnArticulosEntregadosAlquiler)
        Me.Controls.Add(Me.btnEntregadosBarranquilla)
        Me.Controls.Add(Me.btnEntregadosCEDI)
        Me.Controls.Add(Me.BtnEntregadosCaribe)
        Me.Controls.Add(Me.btnReporteSabaneta)
        Me.Controls.Add(Me.cboSede)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnEmpleados)
        Me.Controls.Add(Me.txtIdEmpleado)
        Me.Controls.Add(Me.txtIdArticulo)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtNombreE)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DTPFechaEntrega)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnArticulos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtCodigoInventario)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombreA)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCargoActivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Cargo Activos a los Empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvActivosAsignados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTPFechaEntrega As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents btnArticulos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbNombreEmpleado As RadioButton
    Friend WithEvents rbCodigoInventario As RadioButton
    Friend WithEvents rbNombreArticulo As RadioButton
    Friend WithEvents lblTotalActivosAsignados As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvActivosAsignados As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtCodigoInventario As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombreA As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtIdArticulo As TextBox
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents rbDepartamento As RadioButton
    Friend WithEvents btnImprimir As Button
    Friend WithEvents cboSede As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IdCargo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoInventario As DataGridViewTextBoxColumn
    Friend WithEvents NombreA As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents FechaAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents Sede As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents IdArticulo As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents CodigoA As DataGridViewTextBoxColumn
    Friend WithEvents EstadoArticulo As DataGridViewTextBoxColumn
    Friend WithEvents btnReporteSabaneta As Button
    Friend WithEvents BtnEntregadosCaribe As Button
    Friend WithEvents btnEntregadosCEDI As Button
    Friend WithEvents btnEntregadosBarranquilla As Button
    Friend WithEvents btnArticulosEntregadosAlquiler As Button
    Friend WithEvents btnArticulosEntregadosCompra As Button
End Class
