Imports System.Data.SqlClient


Public Class frmBusquedaElaboradoPor
    Private Sub frmBusquedaElaboradoPor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
        dgvEmpleados.AutoGenerateColumns = False
        txtBuscar.Focus()
    End Sub


    Sub LlenarDatos()
        Dim sql As String
        sql = " Select Elaborado.IdElaborado, Elaborado.NombreEla, Elaborado.Identidad,  Elaborado.Correo,
               Departamentos.NombreD, Puestos.NombreP  FROM Departamentos
                      INNER JOIN Elaborado ON Departamentos.IdDepartamento =  Elaborado.IdDepartamento  
                                             INNER JOIN Puestos ON  Elaborado.IdPuesto = Puestos.IdPuesto  "
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
            adaptador = New SqlDataAdapter("Select Elaborado.IdElaborado, Elaborado.NombreEla, Elaborado.Identidad,
                                Elaborado.Correo, Departamentos.NombreD, Puestos.NombreP 
                                   FROM Departamentos INNER JOIN Elaborado ON Departamentos.IdDepartamento =  Elaborado.IdDepartamento  
                                             INNER JOIN Puestos ON  Elaborado.IdPuesto = Puestos.IdPuesto
                                WHERE  Elaborado.NombreEla Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
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
            adaptador = New SqlDataAdapter("Select Elaborado.IdElaborado, Elaborado.NombreEla, Elaborado.Identidad,
                                Elaborado.Correo, Departamentos.NombreD, Puestos.NombreP 
                                   FROM Departamentos INNER JOIN Elaborado ON Departamentos.IdDepartamento =  Elaborado.IdDepartamento  
                                             INNER JOIN Puestos ON  Elaborado.IdPuesto = Puestos.IdPuesto
                                WHERE  Empleados.Identidad Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
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
            adaptador = New SqlDataAdapter("Select Elaborado.IdElaborado, Elaborado.NombreEla, Elaborado.Identidad,
                                Elaborado.Correo, Departamentos.NombreD, Puestos.NombreP 
                                   FROM Departamentos INNER JOIN Elaborado ON Departamentos.IdDepartamento =  Elaborado.IdDepartamento  
                                             INNER JOIN Puestos ON  Elaborado.IdPuesto = Puestos.IdPuesto
                                     WHERE  Departamentos.NombreD Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
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
        frmActivosInformacion.TxtIdElaborado.Text = CStr(dgvEmpleados.Item("IdElaborado", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmActivosInformacion.txtElaborado.Text = CStr(dgvEmpleados.Item("NombreEla", dgvEmpleados.CurrentCell.RowIndex).Value)

        Me.Close()
    End Sub

    Private Sub rbNombreEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreEmpleado.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbIdentidad_CheckedChanged(sender As Object, e As EventArgs) Handles rbIdentidad.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbDepartamento_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepartamento.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub dgvEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellContentClick

    End Sub
End Class