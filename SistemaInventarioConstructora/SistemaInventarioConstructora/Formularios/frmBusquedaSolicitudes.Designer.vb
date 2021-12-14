<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaSolicitudes
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
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTecnico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(21, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 564)
        Me.Panel1.TabIndex = 177
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
        Me.dgvSolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.IdSolicitud, Me.NombreSolici, Me.Prioridad, Me.Sede, Me.FechaSolicitud, Me.Descripcion, Me.NombreA, Me.NombreD, Me.IdArticulo, Me.IdCargo, Me.CodigoInventario, Me.NombreTecnico, Me.IdUsuario, Me.Usuario, Me.Password, Me.TipoUsuario, Me.Estado, Me.IdTecnico})
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
        'IdUsuario
        '
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        Me.IdUsuario.HeaderText = "IDUSUARIO"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        Me.IdUsuario.Visible = False
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "USUARIO"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Visible = False
        '
        'Password
        '
        Me.Password.DataPropertyName = "Password"
        Me.Password.HeaderText = "PASSWORD"
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        Me.Password.Visible = False
        '
        'TipoUsuario
        '
        Me.TipoUsuario.DataPropertyName = "TipoUsuario"
        Me.TipoUsuario.HeaderText = "TIPOUSUARIO"
        Me.TipoUsuario.Name = "TipoUsuario"
        Me.TipoUsuario.ReadOnly = True
        Me.TipoUsuario.Visible = False
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "ESTADO"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Visible = False
        '
        'IdTecnico
        '
        Me.IdTecnico.DataPropertyName = "IdTecnico"
        Me.IdTecnico.HeaderText = "IDTECNICO"
        Me.IdTecnico.Name = "IdTecnico"
        Me.IdTecnico.ReadOnly = True
        Me.IdTecnico.Visible = False
        '
        'frmBusquedaSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 619)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBusquedaSolicitudes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Solicitudes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbTecnico As RadioButton
    Friend WithEvents rbSolicitante As RadioButton
    Friend WithEvents rbDepartamento As RadioButton
    Friend WithEvents rbNombreSolicitud As RadioButton
    Friend WithEvents lblTotalSolicitudes As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvSolicitudes As DataGridView
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
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents TipoUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents IdTecnico As DataGridViewTextBoxColumn
End Class
