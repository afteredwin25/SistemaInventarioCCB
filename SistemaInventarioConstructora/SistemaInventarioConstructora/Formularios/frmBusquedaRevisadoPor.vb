Imports System.Data.SqlClient


Public Class frmBusquedaRevisadoPor
    Private Sub frmBusquedaRevisadoPor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
        dgvEmpleados.AutoGenerateColumns = False
        txtBuscar.Focus()
    End Sub

    'Select Revisados.IdRevisado, Revisados.NombreRev, Revisados.Identidad,  Revisados.Correo,
    '           Departamentos.NombreD, Puestos.NombreP  FROM Departamentos
    '                  INNER JOIN Revisados ON Departamentos.IdDepartamento =  Revisados.IdDepartamento  
    '                                         INNER JOIN Puestos ON  Revisados.IdPuesto = Puestos.IdPuesto

    Sub LlenarDatos()
        Dim sql As String
        sql = "Select Revisados.IdRevisado, Revisados.NombreRev, Revisados.Identidad,  Revisados.Correo,
               Departamentos.NombreD, Puestos.NombreP  FROM Departamentos
                      INNER JOIN Revisados ON Departamentos.IdDepartamento =  Revisados.IdDepartamento  
                                             INNER JOIN Puestos ON  Revisados.IdPuesto = Puestos.IdPuesto   "
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
            adaptador = New SqlDataAdapter("Select Revisados.IdRevisado, Revisados.NombreRev, Revisados.Identidad,
                                Revisados.Correo, Departamentos.NombreD, Puestos.NombreP 
                                   FROM Departamentos INNER JOIN Revisados ON Departamentos.IdDepartamento =  Revisados.IdDepartamento  
                                             INNER JOIN Puestos ON  Revisados.IdPuesto = Puestos.IdPuesto WHERE 
                                             Revisados.NombreRev Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
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
            adaptador = New SqlDataAdapter("Select Revisados.IdRevisado, Revisados.NombreRev, Revisados.Identidad,
                                Revisados.Correo, Departamentos.NombreD, Puestos.NombreP 
                                   FROM Departamentos INNER JOIN Revisados ON Departamentos.IdDepartamento =  Revisados.IdDepartamento  
                                             INNER JOIN Puestos ON  Revisados.IdPuesto = Puestos.IdPuesto WHERE 
                                            Revisados.Identidad Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
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
            adaptador = New SqlDataAdapter("Select Revisados.IdRevisado, Revisados.NombreRev, Revisados.Identidad,
                                Revisados.Correo, Departamentos.NombreD, Puestos.NombreP 
                                   FROM Departamentos INNER JOIN Revisados ON Departamentos.IdDepartamento =  Revisados.IdDepartamento  
                                             INNER JOIN Puestos ON  Revisados.IdPuesto = Puestos.IdPuesto
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

    Private Sub dgvEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        frmActivosInformacion.txtIdRevisado.Text = CStr(dgvEmpleados.Item("IdRevisado", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmActivosInformacion.txtRevisado.Text = CStr(dgvEmpleados.Item("NombreRev", dgvEmpleados.CurrentCell.RowIndex).Value)

        Me.Close()
    End Sub

    Private Sub rbNombreEmpleado_CheckedChanged(sender As Object, e As EventArgs)
        txtBuscar.Focus()
    End Sub

    Private Sub rbIdentidad_CheckedChanged(sender As Object, e As EventArgs)
        txtBuscar.Focus()
    End Sub

    Private Sub rbDepartamento_CheckedChanged(sender As Object, e As EventArgs)
        txtBuscar.Focus()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs)
        BuscarDatos()
        txtBuscar.Focus()
    End Sub

    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
        txtBuscar.Focus()
    End Sub

    Private Sub dgvEmpleados_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellDoubleClick
        frmActivosInformacion.txtIdRevisado.Text = CStr(dgvEmpleados.Item("IdRevisado", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmActivosInformacion.txtRevisado.Text = CStr(dgvEmpleados.Item("NombreRev", dgvEmpleados.CurrentCell.RowIndex).Value)


        Me.Close()
    End Sub

    Private Sub rbNombreEmpleado_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbNombreEmpleado.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbIdentidad_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbIdentidad.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbDepartamento_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbDepartamento.CheckedChanged
        txtBuscar.Focus()
    End Sub

End Class