Imports System.Data.SqlClient



Public Class frmBusquedaSolicitudes

    Private Sub frmBusquedaSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
        dgvSolicitudes.AutoGenerateColumns = False
        txtBuscar.Focus()

    End Sub



    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, Empleados.Nombre,  Departamentos.NombreD  , Articulos.IdArticulo,
           Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede, Solicitudes.FechaSolicitud  , Tecnicos.NombreTecnico, Solicitudes.Descripcion
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                          INNER JOIN Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo    
                          INNER JOIN Tecnicos ON  Solicitudes.IdTecnico = Tecnicos.IdTecnico 
                          WHERE  Solicitudes.EstadoSolicitud = 'Pendiente'      "

        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvSolicitudes.DataSource = tabla
            lblTotalSolicitudes.Text = tabla.Rows.Count


        Catch ex As Exception

            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema Inventario")
        End Try

    End Sub


    Sub BuscarDatos()
        If rbNombreSolicitud.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, Empleados.Nombre,  Departamentos.NombreD  , Articulos.IdArticulo,
           Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede, Solicitudes.FechaSolicitud  , Tecnicos.NombreTecnico, Solicitudes.Descripcion
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                          INNER JOIN Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo    
                          INNER JOIN Tecnicos ON  Solicitudes.IdTecnico = Tecnicos.IdTecnico 
                        WHERE  Solicitudes.NombreSolici LIKE  '%" & txtBuscar.Text & "%'    AND Solicitudes.EstadoSolicitud = 'Pendiente'   ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSolicitudes.DataSource = tabla
                lblTotalSolicitudes.Text = tabla.Rows.Count
            Else
                dgvSolicitudes.DataSource = ""
            End If


        End If
        If rbDepartamento.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, Empleados.Nombre,  Departamentos.NombreD  , Articulos.IdArticulo,
           Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede, Solicitudes.FechaSolicitud  , Tecnicos.NombreTecnico, Solicitudes.Descripcion
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                          INNER JOIN Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo    
                          INNER JOIN Tecnicos ON  Solicitudes.IdTecnico = Tecnicos.IdTecnico 
                  WHERE  Departamentos.NombreD LIKE  '%" & txtBuscar.Text & "%' AND Solicitudes.EstadoSolicitud = 'Pendiente' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSolicitudes.DataSource = tabla
                lblTotalSolicitudes.Text = tabla.Rows.Count
            Else
                dgvSolicitudes.DataSource = ""
            End If
        End If

        If rbSolicitante.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, Empleados.Nombre,  Departamentos.NombreD  , Articulos.IdArticulo,
           Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede, Solicitudes.FechaSolicitud  , Tecnicos.NombreTecnico, Solicitudes.Descripcion
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                          INNER JOIN Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo    
                          INNER JOIN Tecnicos ON  Solicitudes.IdTecnico = Tecnicos.IdTecnico 
                                  WHERE  Empleados.Nombre LIKE  '%" & txtBuscar.Text & "%'  AND Solicitudes.EstadoSolicitud = 'Pendiente' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSolicitudes.DataSource = tabla
                lblTotalSolicitudes.Text = tabla.Rows.Count
            Else
                dgvSolicitudes.DataSource = ""
            End If
        End If

        If rbTecnico.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, Empleados.Nombre,  Departamentos.NombreD  , Articulos.IdArticulo,
           Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede, Solicitudes.FechaSolicitud  , Tecnicos.NombreTecnico, Solicitudes.Descripcion
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                          INNER JOIN Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo    
                          INNER JOIN Tecnicos ON  Solicitudes.IdTecnico = Tecnicos.IdTecnico 
                  WHERE  Solicitudes.NombreTecni LIKE  '%" & txtBuscar.Text & "%'  AND Solicitudes.EstadoSolicitud = 'Pendiente'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSolicitudes.DataSource = tabla
                lblTotalSolicitudes.Text = tabla.Rows.Count
            Else
                dgvSolicitudes.DataSource = ""
            End If
        End If



    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()

    End Sub

    Private Sub dgvSolicitudes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSolicitudes.CellDoubleClick
        On Error Resume Next

        frmSolucionSolicitudes.txtSolicitud.Text = CStr(dgvSolicitudes.Item("NombreSolici", dgvSolicitudes.CurrentCell.RowIndex).Value)
        frmSolucionSolicitudes.txtIdArticulo.Text = CStr(dgvSolicitudes.Item("IdArticulo", dgvSolicitudes.CurrentCell.RowIndex).Value)
        frmSolucionSolicitudes.txtIdSolicitud.Text = CStr(dgvSolicitudes.Item("IdSolicitud", dgvSolicitudes.CurrentCell.RowIndex).Value)
        frmSolucionSolicitudes.txtPrioridad.Text = CStr(dgvSolicitudes.Item("Prioridad", dgvSolicitudes.CurrentCell.RowIndex).Value)
        frmSolucionSolicitudes.txtNombreEmpleado.Text = CStr(dgvSolicitudes.Item("Nombre", dgvSolicitudes.CurrentCell.RowIndex).Value)
        frmSolucionSolicitudes.txtDepartamento.Text = CStr(dgvSolicitudes.Item("NombreD", dgvSolicitudes.CurrentCell.RowIndex).Value)
        frmSolucionSolicitudes.DTPFechaSolicitud.Text = CStr(dgvSolicitudes.Item("FechaSolicitud", dgvSolicitudes.CurrentCell.RowIndex).Value)
        frmSolucionSolicitudes.txtNombreA.Text = CStr(dgvSolicitudes.Item("NombreA", dgvSolicitudes.CurrentCell.RowIndex).Value)
        frmSolucionSolicitudes.txtSede.Text = CStr(dgvSolicitudes.Item("Sede", dgvSolicitudes.CurrentCell.RowIndex).Value)
        frmSolucionSolicitudes.txtTecnicoAsignado.Text = CStr(dgvSolicitudes.Item("NombreTecnico", dgvSolicitudes.CurrentCell.RowIndex).Value)
        frmSolucionSolicitudes.txtDescripcionSolicitud.Text = CStr(dgvSolicitudes.Item("Descripcion", dgvSolicitudes.CurrentCell.RowIndex).Value)
        frmSolucionSolicitudes.txtIdCargo.Text = CStr(dgvSolicitudes.Item("IdCargo", dgvSolicitudes.CurrentCell.RowIndex).Value)
        'txtNombreA.Text = CStr(dgvSolicitudes.Item("NombreA", dgvSolicitudes.CurrentCell.RowIndex).Value)
        'txtCodigoI.Text = CStr(dgvSolicitudes.Item("CodigoInventario", dgvSolicitudes.CurrentCell.RowIndex).Value)
        'cboPrioridad.Text = CStr(dgvSolicitudes.Item("Prioridad", dgvSolicitudes.CurrentCell.RowIndex).Value)

        'txtIdCargo.Text = CStr(dgvSolicitudes.Item("IdCargo", dgvSolicitudes.CurrentCell.RowIndex).Value)
        'txtNombreE.Text = CStr(dgvSolicitudes.Item("Nombre", dgvSolicitudes.CurrentCell.RowIndex).Value)

        'txtDepartamento.Text = CStr(dgvSolicitudes.Item("NombreD", dgvSolicitudes.CurrentCell.RowIndex).Value)

        'txtId.Text = CStr(dgvSolicitudes.Item("IdSolicitud", dgvSolicitudes.CurrentCell.RowIndex).Value)
        'cboSede.Text = CStr(dgvSolicitudes.Item("Sede", dgvSolicitudes.CurrentCell.RowIndex).Value)
        'DTPFechaSolicitud.Text = CStr(dgvSolicitudes.Item("FechaSolicitud", dgvSolicitudes.CurrentCell.RowIndex).Value)
        'CboTecnico.Text = CStr(dgvSolicitudes.Item("NombreTecnico", dgvSolicitudes.CurrentCell.RowIndex).Value)

        'txtDescripcion.Text = CStr(dgvSolicitudes.Item("Descripcion", dgvSolicitudes.CurrentCell.RowIndex).Value)





        'txtNombreA.Focus()
        Me.Close()


    End Sub

    Private Sub rbNombreSolicitud_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreSolicitud.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbDepartamento_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepartamento.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbSolicitante_CheckedChanged(sender As Object, e As EventArgs) Handles rbSolicitante.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbTecnico_CheckedChanged(sender As Object, e As EventArgs) Handles rbTecnico.CheckedChanged
        txtBuscar.Focus()
    End Sub
End Class