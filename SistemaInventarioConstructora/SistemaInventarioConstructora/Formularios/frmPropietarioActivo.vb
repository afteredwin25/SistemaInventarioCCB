Imports System.Data.SqlClient

Public Class frmPropietarioActivo
    Private Sub frmPropietarioActivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
        dgvEmpleados.AutoGenerateColumns = False
        txtBuscar.Focus()
    End Sub

    Sub LlenarDatos()
        Dim sql As String
        sql = "Select Propietarios.IdPropietario, Propietarios.Nombre, Propietarios.Identidad,  Propietarios.Correo,
               Departamentos.NombreD, Puestos.NombreP  FROM Departamentos
                      INNER JOIN Propietarios ON Departamentos.IdDepartamento =  Propietarios.IdDepartamento  
                                             INNER JOIN Puestos ON  Propietarios.IdPuesto = Puestos.IdPuesto  "
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
            adaptador = New SqlDataAdapter("Select Propietarios.IdPropietario, Propietarios.Nombre, Propietarios.Identidad,
                                Propietarios.Correo, Departamentos.NombreD, Puestos.NombreP 
                                   FROM Departamentos INNER JOIN Propietarios ON Departamentos.IdDepartamento =  Propietarios.IdDepartamento  
                                             INNER JOIN Puestos ON  Propietarios.IdPuesto = Puestos.IdPuesto WHERE 
                                             Propietarios.Nombre Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
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
            adaptador = New SqlDataAdapter("Select Select Propietarios.IdPropietario, Propietarios.Nombre, Propietarios.Identidad,
                                Propietarios.Correo, Departamentos.NombreD, Puestos.NombreP 
                                   FROM Departamentos INNER JOIN Propietarios ON Departamentos.IdDepartamento =  Propietarios.IdDepartamento  
                                             INNER JOIN Puestos ON  Propietarios.IdPuesto = Puestos.IdPuestoo WHERE 
                                            Propietarios.Identidad Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
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
            adaptador = New SqlDataAdapter("Select Propietarios.IdPropietario, Propietarios.Nombre, Propietarios.Identidad,
                                Propietarios.Correo, Departamentos.NombreD, Puestos.NombreP 
                                   FROM Departamentos INNER JOIN Propietarios ON Departamentos.IdDepartamento =  Propietarios.IdDepartamento  
                                             INNER JOIN Puestos ON  Propietarios.IdPuesto = Puestos.IdPuesto WHERE  Departamentos.NombreD Like  
                                              '%" & txtBuscar.Text & "%' ", obtenerconexion)
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
        frmActivosInformacion.txtIdPropietario.Text = CStr(dgvEmpleados.Item("IdPropietario", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmActivosInformacion.txtPropietario.Text = CStr(dgvEmpleados.Item("Nombre", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmActivosInformacion.cboPropCargo.Text = CStr(dgvEmpleados.Item("NombreP", dgvEmpleados.CurrentCell.RowIndex).Value)

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
End Class