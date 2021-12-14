Imports System.Data.SqlClient

Public Class frmBusquedaActivosFijos
    Private Sub frmBusquedaActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
        txtBuscar.Focus()
    End Sub






    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD  ,CargoActivos.FechaAsignacion , Articulos.IdArticulo, Empleados.IdEmpleado, CargoActivos.Descripcion, Articulos.CodigoA, CargoActivos.EstadoArticulo
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                  WHERE CargoActivos.EstadoArticulo <> 'ELIMINADO'"

        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvActivosAsignados.DataSource = tabla
            lblTotalActivosAsignados.Text = tabla.Rows.Count


        Catch ex As Exception

            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema Inventario")
        End Try

    End Sub



    Sub BuscarDatos()
        If rbNombreEmpleado.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD  ,CargoActivos.FechaAsignacion , Articulos.IdArticulo, Empleados.IdEmpleado, CargoActivos.Descripcion, Articulos.CodigoA, CargoActivos.EstadoArticulo
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento                                                             WHERE Empleados.Nombre Like  '%" & txtBuscar.Text & "%'  AND CargoActivos.EstadoArticulo <> 'ELIMINADO' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosAsignados.DataSource = tabla
                lblTotalActivosAsignados.Text = tabla.Rows.Count
            Else
                dgvActivosAsignados.DataSource = ""
            End If
        End If

        If rbCodigoInventario.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD  ,CargoActivos.FechaAsignacion , Articulos.IdArticulo, Empleados.IdEmpleado, CargoActivos.Descripcion, Articulos.CodigoA, CargoActivos.EstadoArticulo
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento                        WHERE CargoActivos.CodigoInventario Like  '%" & txtBuscar.Text & "%' AND CargoActivos.EstadoArticulo <> 'ELIMINADO' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosAsignados.DataSource = tabla
                lblTotalActivosAsignados.Text = tabla.Rows.Count
            Else
                dgvActivosAsignados.DataSource = ""
            End If
        End If


        If rbNombreArticulo.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD  ,CargoActivos.FechaAsignacion , Articulos.IdArticulo, Empleados.IdEmpleado, CargoActivos.Descripcion, Articulos.CodigoA, CargoActivos.EstadoArticulo
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento                                                                  WHERE Articulos.NombreA Like  '%" & txtBuscar.Text & "%'  AND CargoActivos.EstadoArticulo <> 'ELIMINADO' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosAsignados.DataSource = tabla
                lblTotalActivosAsignados.Text = tabla.Rows.Count
            Else
                dgvActivosAsignados.DataSource = ""
            End If
        End If



        If rbDepartamento.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD  ,CargoActivos.FechaAsignacion , Articulos.IdArticulo, Empleados.IdEmpleado, CargoActivos.Descripcion, Articulos.CodigoA, CargoActivos.EstadoArticulo
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento                                                                   WHERE Departamentos.NombreD Like  '%" & txtBuscar.Text & "%'  AND CargoActivos.EstadoArticulo <> 'ELIMINADO' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosAsignados.DataSource = tabla
                lblTotalActivosAsignados.Text = tabla.Rows.Count
            Else
                dgvActivosAsignados.DataSource = ""
            End If
        End If




    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()

    End Sub

    Private Sub rbNombreArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreArticulo.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbCodigoInventario_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigoInventario.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbNombreEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreEmpleado.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbDepartamento_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepartamento.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub dgvActivosAsignados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActivosAsignados.CellDoubleClick
        On Error Resume Next
        frmDescargoActivos.txtIdArticulo.Text = CStr(dgvActivosAsignados.Item("IdArticulo", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtNombreA.Text = CStr(dgvActivosAsignados.Item("NombreA", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtCodigoI.Text = CStr(dgvActivosAsignados.Item("CodigoInventario", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtPrecio.Text = CStr(dgvActivosAsignados.Item("PrecioCompra", dgvActivosAsignados.CurrentCell.RowIndex).Value)

        frmDescargoActivos.txtIdCargo.Text = CStr(dgvActivosAsignados.Item("IdCargo", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtNombreE.Text = CStr(dgvActivosAsignados.Item("Nombre", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtIdentidad.Text = CStr(dgvActivosAsignados.Item("Identidad", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtDepartamento.Text = CStr(dgvActivosAsignados.Item("NombreD", dgvActivosAsignados.CurrentCell.RowIndex).Value)


        frmDescargoActivos.DTPFechaEntrega.Text = CStr(dgvActivosAsignados.Item("FechaAsignacion", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        Me.Close()

    End Sub
End Class