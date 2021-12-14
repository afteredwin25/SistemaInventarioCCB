Imports System.Data.SqlClient



Public Class frmTecnicos

    Private tabla_puestos As New DataTable

    Private Sub frmTecnicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        TamañoFormulario()
        LlenarDatos()
        dgvTecnicos.AutoGenerateColumns = False

        Mostrar_Puestos()
        cboCargo.SelectedIndex = -1
        btnBuscar.Enabled = True

    End Sub






    Public Function Puesto_Listar(activo As Integer) As DataTable

        Dim tabla As New DataTable
        Dim sql As String
        sql = " SELECT IdPuesto, NombreP FROM Puestos"
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla

    End Function

    Private Sub Mostrar_Puestos()
        tabla_puestos = Puesto_Listar(True)
        cboCargo.DataSource = tabla_puestos
        cboCargo.DisplayMember = "NombreP"
        cboCargo.ValueMember = "IdPuesto"


    End Sub





    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False


        txtNombreTecnico.Enabled = False
        txtIdentidad.Enabled = False
        cboCargo.Enabled = False




        btnNuevo.Enabled = True
    End Sub

    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True


        txtNombreTecnico.Enabled = True
        txtIdentidad.Enabled = True
        cboCargo.Enabled = True


        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtNombreTecnico.Text = ""
        txtIdentidad.Text = ""

        cboCargo.Text = ""


        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub



    Sub TamañoFormulario()
        Width = 679
        Height = 314
        Panel1.Visible = False

    End Sub

    Sub TamañoFormularioBuscar()
        Width = 679
        Height = 989
        Panel1.Visible = True
        txtBuscar.BackColor = Color.YellowGreen
    End Sub


    Sub Insertar()
        Dim sql As String
        Dim id As Integer

        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub

        End If

        adaptador = New SqlDataAdapter("SELECT * FROM Tecnicos WHERE Identidad = '" & txtIdentidad.Text & "'  ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtIdentidad.Text = tabla.Rows(0).Item("Identidad")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema Inventario")
            Exit Sub

        End If
        If txtNombreTecnico.Text = "" Then
            MsgBox("Existen campos vacios ", vbInformation, "Sistema Inventario")

            Exit Sub

        Else
            sql = " INSERT INTO Tecnicos(Identidad, NombreTecnico, IdPuesto ) VALUES ('" & txtIdentidad.Text & "', '" & txtNombreTecnico.Text & "',  '" & Trim(cboCargo.SelectedValue) & "') "
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()


            End Using
            conect.Close()
            MsgBox("Registro realizado exitosamente ", vbInformation, "Sistema Inventario")


        End If





    End Sub

    Sub LlenarDatos()
        Dim sql As String
        sql = "Select Tecnicos.IdTecnico,  Tecnicos.Identidad, Tecnicos.NombreTecnico, Puestos.NombreP  
                  FROM Puestos INNER JOIN  Tecnicos ON Puestos.IdPuesto = Tecnicos.IdPuesto"
        Try


            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvTecnicos.DataSource = tabla

            lblTotalTecnicos.Text = tabla.Rows.Count


        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente Error " + ex.ToString + " Sistema Inventario")
        End Try


    End Sub

    Sub BuscarDatos()
        If rbNombreEmpleado.Checked Then


            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("Select Tecnicos.IdTecnico, Tecnicos.Identidad,Tecnicos.NombreTecnico,Tecnicos.NombreP

                                              FROM Puestos INNER JOIN Tecnicos ON Puestos.IdPuesto =  Tecnicos.IdPuesto  
                                              WHERE  Tecnicos.NombreTecnico Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvTecnicos.DataSource = tabla
                lblTotalTecnicos.Text = tabla.Rows.Count
            Else
                dgvTecnicos.DataSource = ""
            End If
        End If

        If rbIdentidad.Checked Then

            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("Select Tecnicos.IdTecnico, Tecnicos.Identidad,  Tecnicos.NombreTecnico,Tecnicos.NombreP

                                              FROM Puestos INNER JOIN Tecnicos ON Puestos.IdPuesto =  Tecnicos.IdPuesto
                                    WHERE  Empleados.Identidad Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvTecnicos.DataSource = tabla
                lblTotalTecnicos.Text = tabla.Rows.Count
            Else
                dgvTecnicos.DataSource = ""
            End If
        End If





    End Sub
    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE Tecnicos SET  Identidad = '" & txtIdentidad.Text & " ', NombreTecnico = '" & txtNombreTecnico.Text & "',  IdPuesto =  '" & Trim(cboCargo.SelectedValue) & "'
               WHERE IdTecnico = '" & txtId.Text & "'          "
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro editado exitosamente ", vbInformation, "Sistema de Inventario")
            LimpiarControles()
        End If

    End Sub

    Sub Eliminar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            If MsgBox("Seguro en Eliminar El técnico de " + Trim(txtNombreTecnico.Text) + " De Su Registro? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM Tenicos WHERE IdTecnico = " & Trim(txtId.Text)

                Dim conect As New SqlConnection(obtenerconexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()
                End Using
                conect.Close()
                MsgBox("Registro Eliminado Exitosamente ", vbInformation, "Sistema de Inventario")
                LimpiarControles()
            End If

        End If


    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        TamañoFormularioBuscar()

        btnCancelar.Enabled = True
        btnBuscar.Enabled = False
        txtBuscar.Focus()
        LlenarDatos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ActivarControles()
        txtIdentidad.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Insertar()
        LlenarDatos()
        Call DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Editar()
        DesactivarControles()
        LlenarDatos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
        DesactivarControles()
        LlenarDatos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        TamañoFormulario()
        LimpiarControles()
        Panel1.Visible = False
        DesactivarControles()
        btnCancelar.Enabled = False
        btnBuscar.Enabled = True
    End Sub

    Private Sub dgvTecnicos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTecnicos.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvTecnicos.Item("IdTecnico", dgvTecnicos.CurrentCell.RowIndex).Value)
        txtIdentidad.Text = CStr(dgvTecnicos.Item("Identidad", dgvTecnicos.CurrentCell.RowIndex).Value)
        txtNombreTecnico.Text = CStr(dgvTecnicos.Item("NombreTecnico", dgvTecnicos.CurrentCell.RowIndex).Value)
        cboCargo.Text = CStr(dgvTecnicos.Item("Cargo", dgvTecnicos.CurrentCell.RowIndex).Value)


        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False



        txtIdentidad.Enabled = True
        txtNombreTecnico.Enabled = True
        cboCargo.Enabled = True

        txtIdentidad.Focus()
    End Sub

    Private Sub btnPuestos_Click(sender As Object, e As EventArgs) Handles btnPuestos.Click
        frmPuestosTrabajo.ShowDialog()


    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()

    End Sub
End Class