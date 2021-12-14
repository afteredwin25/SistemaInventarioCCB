Imports System.Data.SqlClient


Public Class frmBusquedaEmpleadosAprobados


    Private Sub frmBusquedaEmpleadosAprobados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
        dgvEmpleados.AutoGenerateColumns = False
    End Sub


    Sub LlenarDatos()
        Dim sql As String
        sql = "Select Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Telefono, Empleados.Correo, Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP  FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento =  Empleados.IdDepartamento  
                                             INNER JOIN Puestos ON  Empleados.IdPuesto = Puestos.IdPuesto  "
        Try


            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvEmpleados.DataSource = tabla

            lblTotalEmpleados.Text = tabla.Rows.Count


        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente Error " + ex.ToString + " Sistema Inventario")
        End Try


    End Sub


    Sub BuscarDatos()
        If rbNombreEmpleado.Checked Then


            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("Select Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Telefono, Empleados.Correo, Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP  FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento =  Empleados.IdDepartamento  
                                             INNER JOIN Puestos ON  Empleados.IdPuesto = Puestos.IdPuesto WHERE  Empleados.Nombre Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvEmpleados.DataSource = tabla
                lblTotalEmpleados.Text = tabla.Rows.Count
            Else
                dgvEmpleados.DataSource = ""
            End If
        End If

        If rbIdentidad.Checked Then

            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("Select Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Telefono, Empleados.Correo, Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP  FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento =  Empleados.IdDepartamento  
                                             INNER JOIN Puestos ON  Empleados.IdPuesto = Puestos.IdPuesto WHERE  Empleados.Identidad Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvEmpleados.DataSource = tabla
                lblTotalEmpleados.Text = tabla.Rows.Count
            Else
                dgvEmpleados.DataSource = ""
            End If
        End If

        If rbDepartamento.Checked Then

            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("Select Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Telefono, Empleados.Correo, Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP  FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento =  Empleados.IdDepartamento  
                                             INNER JOIN Puestos ON  Empleados.IdPuesto = Puestos.IdPuesto WHERE  Departamentos.NombreD Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvEmpleados.DataSource = tabla
                lblTotalEmpleados.Text = tabla.Rows.Count
            Else
                dgvEmpleados.DataSource = ""
            End If
        End If




    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
        txtBuscar.Focus()
    End Sub

    Private Sub dgvEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellDoubleClick
        frmAprobados.txtIdAprobado.Text = CStr(dgvEmpleados.Item("IdEmpleado", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmAprobados.txtNombreE.Text = CStr(dgvEmpleados.Item("Nombre", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmAprobados.txtIdentidad.Text = CStr(dgvEmpleados.Item("Identidad", dgvEmpleados.CurrentCell.RowIndex).Value)

        frmAprobados.cboDepartamento.Text = CStr(dgvEmpleados.Item("NombreD", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmAprobados.cboPuesto.Text = CStr(dgvEmpleados.Item("NombreP", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmAprobados.txtCorreo.Text = CStr(dgvEmpleados.Item("Correo", dgvEmpleados.CurrentCell.RowIndex).Value)

        Me.Close()
    End Sub
End Class