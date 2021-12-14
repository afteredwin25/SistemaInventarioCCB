<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolicitantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolicitantes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbIdentidad = New System.Windows.Forms.RadioButton()
        Me.rbNombreEmpleado = New System.Windows.Forms.RadioButton()
        Me.lblTotalSolicitantes = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvSolicitantes = New System.Windows.Forms.DataGridView()
        Me.IdSolicitante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreSolicitante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboPuesto = New System.Windows.Forms.ComboBox()
        Me.cboDepartamento = New System.Windows.Forms.ComboBox()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.txtNombreSolicitante = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdSolicitante = New System.Windows.Forms.TextBox()
        Me.btnEmpleado = New System.Windows.Forms.Button()
        Me.btnBusquedaSolicitantes = New System.Windows.Forms.Button()
        Me.btnPuestos = New System.Windows.Forms.Button()
        Me.btnDepartamentos = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSolicitantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbDepartamento)
        Me.Panel1.Controls.Add(Me.rbIdentidad)
        Me.Panel1.Controls.Add(Me.rbNombreEmpleado)
        Me.Panel1.Controls.Add(Me.lblTotalSolicitantes)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvSolicitantes)
        Me.Panel1.Location = New System.Drawing.Point(206, 310)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(753, 629)
        Me.Panel1.TabIndex = 127
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.Location = New System.Drawing.Point(278, 47)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(92, 17)
        Me.rbDepartamento.TabIndex = 15
        Me.rbDepartamento.Text = "Departamento"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'rbIdentidad
        '
        Me.rbIdentidad.AutoSize = True
        Me.rbIdentidad.Location = New System.Drawing.Point(166, 47)
        Me.rbIdentidad.Name = "rbIdentidad"
        Me.rbIdentidad.Size = New System.Drawing.Size(69, 17)
        Me.rbIdentidad.TabIndex = 14
        Me.rbIdentidad.Text = "Identidad"
        Me.rbIdentidad.UseVisualStyleBackColor = True
        '
        'rbNombreEmpleado
        '
        Me.rbNombreEmpleado.AutoSize = True
        Me.rbNombreEmpleado.Checked = True
        Me.rbNombreEmpleado.Location = New System.Drawing.Point(29, 46)
        Me.rbNombreEmpleado.Name = "rbNombreEmpleado"
        Me.rbNombreEmpleado.Size = New System.Drawing.Size(112, 17)
        Me.rbNombreEmpleado.TabIndex = 13
        Me.rbNombreEmpleado.TabStop = True
        Me.rbNombreEmpleado.Text = "Nombre Empleado"
        Me.rbNombreEmpleado.UseVisualStyleBackColor = True
        '
        'lblTotalSolicitantes
        '
        Me.lblTotalSolicitantes.AutoSize = True
        Me.lblTotalSolicitantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSolicitantes.Location = New System.Drawing.Point(136, 600)
        Me.lblTotalSolicitantes.Name = "lblTotalSolicitantes"
        Me.lblTotalSolicitantes.Size = New System.Drawing.Size(44, 16)
        Me.lblTotalSolicitantes.TabIndex = 17
        Me.lblTotalSolicitantes.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 600)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Empleados Registrados:"
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
        Me.txtBuscar.Location = New System.Drawing.Point(382, 45)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(278, 20)
        Me.txtBuscar.TabIndex = 16
        '
        'dgvSolicitantes
        '
        Me.dgvSolicitantes.AllowUserToAddRows = False
        Me.dgvSolicitantes.AllowUserToDeleteRows = False
        Me.dgvSolicitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolicitantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSolicitante, Me.Identidad, Me.NombreSolicitante, Me.NombreD, Me.NombreP})
        Me.dgvSolicitantes.Location = New System.Drawing.Point(22, 70)
        Me.dgvSolicitantes.Name = "dgvSolicitantes"
        Me.dgvSolicitantes.ReadOnly = True
        Me.dgvSolicitantes.RowHeadersVisible = False
        Me.dgvSolicitantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSolicitantes.Size = New System.Drawing.Size(638, 516)
        Me.dgvSolicitantes.TabIndex = 15
        '
        'IdSolicitante
        '
        Me.IdSolicitante.DataPropertyName = "IdSolicitante"
        Me.IdSolicitante.HeaderText = "ID"
        Me.IdSolicitante.Name = "IdSolicitante"
        Me.IdSolicitante.ReadOnly = True
        Me.IdSolicitante.Visible = False
        '
        'Identidad
        '
        Me.Identidad.DataPropertyName = "Identidad"
        Me.Identidad.HeaderText = "IDENTIDAD"
        Me.Identidad.Name = "Identidad"
        Me.Identidad.ReadOnly = True
        '
        'NombreSolicitante
        '
        Me.NombreSolicitante.DataPropertyName = "NombreSolicitante"
        Me.NombreSolicitante.HeaderText = "NOMBRE COMPLETO"
        Me.NombreSolicitante.Name = "NombreSolicitante"
        Me.NombreSolicitante.ReadOnly = True
        Me.NombreSolicitante.Width = 200
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "DEPARTAMENTO"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        '
        'NombreP
        '
        Me.NombreP.DataPropertyName = "NombreP"
        Me.NombreP.HeaderText = "PUESTO DE TRABAJO"
        Me.NombreP.Name = "NombreP"
        Me.NombreP.ReadOnly = True
        Me.NombreP.Width = 300
        '
        'cboPuesto
        '
        Me.cboPuesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPuesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPuesto.FormattingEnabled = True
        Me.cboPuesto.Location = New System.Drawing.Point(541, 98)
        Me.cboPuesto.Name = "cboPuesto"
        Me.cboPuesto.Size = New System.Drawing.Size(215, 21)
        Me.cboPuesto.TabIndex = 114
        '
        'cboDepartamento
        '
        Me.cboDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.Location = New System.Drawing.Point(125, 97)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(196, 21)
        Me.cboDepartamento.TabIndex = 112
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(125, 43)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(196, 20)
        Me.txtIdentidad.TabIndex = 110
        '
        'txtNombreSolicitante
        '
        Me.txtNombreSolicitante.Location = New System.Drawing.Point(541, 41)
        Me.txtNombreSolicitante.Name = "txtNombreSolicitante"
        Me.txtNombreSolicitante.Size = New System.Drawing.Size(274, 20)
        Me.txtNombreSolicitante.TabIndex = 111
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(32, 12)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(34, 20)
        Me.txtId.TabIndex = 126
        Me.txtId.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(441, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 15)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "Puesto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 15)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Departamento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Identidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(441, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Nombre:"
        '
        'txtIdSolicitante
        '
        Me.txtIdSolicitante.Location = New System.Drawing.Point(85, 44)
        Me.txtIdSolicitante.Name = "txtIdSolicitante"
        Me.txtIdSolicitante.Size = New System.Drawing.Size(34, 20)
        Me.txtIdSolicitante.TabIndex = 128
        Me.txtIdSolicitante.Visible = False
        '
        'btnEmpleado
        '
        Me.btnEmpleado.BackgroundImage = CType(resources.GetObject("btnEmpleado.BackgroundImage"), System.Drawing.Image)
        Me.btnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEmpleado.Location = New System.Drawing.Point(363, 37)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Size = New System.Drawing.Size(32, 30)
        Me.btnEmpleado.TabIndex = 130
        Me.btnEmpleado.Text = "..."
        Me.btnEmpleado.UseVisualStyleBackColor = True
        '
        'btnBusquedaSolicitantes
        '
        Me.btnBusquedaSolicitantes.BackgroundImage = CType(resources.GetObject("btnBusquedaSolicitantes.BackgroundImage"), System.Drawing.Image)
        Me.btnBusquedaSolicitantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBusquedaSolicitantes.Location = New System.Drawing.Point(327, 37)
        Me.btnBusquedaSolicitantes.Name = "btnBusquedaSolicitantes"
        Me.btnBusquedaSolicitantes.Size = New System.Drawing.Size(30, 30)
        Me.btnBusquedaSolicitantes.TabIndex = 129
        Me.btnBusquedaSolicitantes.Text = "..."
        Me.btnBusquedaSolicitantes.UseVisualStyleBackColor = True
        '
        'btnPuestos
        '
        Me.btnPuestos.BackgroundImage = CType(resources.GetObject("btnPuestos.BackgroundImage"), System.Drawing.Image)
        Me.btnPuestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPuestos.Location = New System.Drawing.Point(762, 92)
        Me.btnPuestos.Name = "btnPuestos"
        Me.btnPuestos.Size = New System.Drawing.Size(53, 30)
        Me.btnPuestos.TabIndex = 115
        Me.btnPuestos.Text = "..."
        Me.btnPuestos.UseVisualStyleBackColor = True
        '
        'btnDepartamentos
        '
        Me.btnDepartamentos.BackgroundImage = CType(resources.GetObject("btnDepartamentos.BackgroundImage"), System.Drawing.Image)
        Me.btnDepartamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDepartamentos.Location = New System.Drawing.Point(327, 91)
        Me.btnDepartamentos.Name = "btnDepartamentos"
        Me.btnDepartamentos.Size = New System.Drawing.Size(53, 30)
        Me.btnDepartamentos.TabIndex = 113
        Me.btnDepartamentos.Text = "..."
        Me.btnDepartamentos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Location = New System.Drawing.Point(1063, 196)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 38)
        Me.btnBuscar.TabIndex = 121
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.Location = New System.Drawing.Point(954, 126)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 38)
        Me.btnCancelar.TabIndex = 120
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar.Location = New System.Drawing.Point(1063, 77)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 38)
        Me.btnEliminar.TabIndex = 119
        Me.btnEliminar.Text = "E&liminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.Location = New System.Drawing.Point(954, 77)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 38)
        Me.btnEditar.TabIndex = 118
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Location = New System.Drawing.Point(1063, 33)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 38)
        Me.btnGuardar.TabIndex = 117
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = CType(resources.GetObject("btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.Location = New System.Drawing.Point(954, 33)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 38)
        Me.btnNuevo.TabIndex = 116
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmSolicitantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 953)
        Me.Controls.Add(Me.btnEmpleado)
        Me.Controls.Add(Me.btnBusquedaSolicitantes)
        Me.Controls.Add(Me.txtIdSolicitante)
        Me.Controls.Add(Me.btnPuestos)
        Me.Controls.Add(Me.btnDepartamentos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cboPuesto)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.txtNombreSolicitante)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSolicitantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Solicitantes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSolicitantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPuestos As Button
    Friend WithEvents btnDepartamentos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbDepartamento As RadioButton
    Friend WithEvents rbIdentidad As RadioButton
    Friend WithEvents rbNombreEmpleado As RadioButton
    Friend WithEvents lblTotalSolicitantes As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvSolicitantes As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cboPuesto As ComboBox
    Friend WithEvents cboDepartamento As ComboBox
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents txtNombreSolicitante As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IdSolicitante As DataGridViewTextBoxColumn
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents NombreSolicitante As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents NombreP As DataGridViewTextBoxColumn
    Friend WithEvents txtIdSolicitante As TextBox
    Friend WithEvents btnBusquedaSolicitantes As Button
    Friend WithEvents btnEmpleado As Button
End Class
