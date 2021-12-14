﻿Imports System.Data.SqlClient


Public Class frmEmpleados



    Private tabla_departamentos As New DataTable
    Private tabla_puestos As New DataTable

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        Tamañoformulario()
        LlenarDatos()
        dgvEmpleados.AutoGenerateColumns = False
        Mostrar_Departamentos()
        cboDepartamento.SelectedIndex = -1
        Mostrar_Puestos()
        cboPuesto.SelectedIndex = -1

        btnBuscar.Enabled = True

    End Sub










    Public Function Departamento_Listar(activo As Integer) As DataTable

        Dim tabla As New DataTable
        Dim sql As String
        sql = " SELECT IdDepartamento, NombreD FROM Departamentos"
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla

    End Function


    Private Sub Mostrar_Departamentos()
        tabla_departamentos = Departamento_Listar(True)
        cboDepartamento.DataSource = tabla_departamentos
        cboDepartamento.DisplayMember = "NombreD"
        cboDepartamento.ValueMember = "IdDepartamento"


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
        cboPuesto.DataSource = tabla_puestos
        cboPuesto.DisplayMember = "NombreP"
        cboPuesto.ValueMember = "IdPuesto"


    End Sub


    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnDepartamentos.Enabled = False
        btnPuestos.Enabled = false

        txtNombreE.Enabled = False
        txtIdentidad.Enabled = False
        txtCorreo.Enabled = False
        txtTelefono.Enabled = False
        txtDireccion.Enabled = False
        cboGenero.Enabled = False
        cboDepartamento.Enabled = False
        cboPuesto.Enabled = False



        btnNuevo.Enabled = True
    End Sub

    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        btnDepartamentos.Enabled = True
        btnPuestos.Enabled = True


        txtNombreE.Enabled = True
        txtIdentidad.Enabled = True
        txtCorreo.Enabled = True
        txtTelefono.Enabled = True
        txtDireccion.Enabled = True
        cboGenero.Enabled = True
        cboDepartamento.Enabled = True
        cboPuesto.Enabled = True

        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtNombreE.Text = ""
        txtIdentidad.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        cboGenero.Text = ""
        cboDepartamento.Text = ""
        cboPuesto.Text = ""

        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub




    Sub TamañoFormulario()
        Width = 1253
        Height = 369
        Panel1.Visible = False

    End Sub

    Sub TamañoFormularioBuscar()
        Width = 1253
        Height = 1105
        Panel1.Visible = True
        txtBuscar.BackColor = Color.YellowGreen
    End Sub


    Sub insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nueveo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub
        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Empleados Where Identidad = '" & txtIdentidad.Text & "' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtIdentidad.Text = tabla.Rows(0).Item("Idenditad")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema Inventario")
            Exit Sub


        End If

        If txtNombreE.Text = "" Or txtIdentidad.Text = "" Or cboGenero.Text = "" Or cboDepartamento.Text = "" Or cboPuesto.Text = "" Then
            MsgBox("Existen campos vacios ", vbInformation, "Sistema Inventario")
            Exit Sub
        Else

            sql = "INSERT INTO Empleados(Nombre, Identidad, Genero, Telefono , Correo, Direccion, IdPUesto, IdDepartamento) VALUES ('" & txtNombreE.Text.Trim() & "',
                                                        '" & txtIdentidad.Text.Trim() & "','" & cboGenero.Text.Trim() & "',
                                                            '" & txtTelefono.Text.Trim() & "','" & txtCorreo.Text.Trim() & "','" & txtDireccion.Text.Trim() & "',
                                                        '" & Trim(cboPuesto.SelectedValue) & "','" & Trim(cboDepartamento.SelectedValue) & "')"
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()

            End Using
            conect.Close()
            MsgBox("Registro realizado Exitosamente ", vbInformation, "Sistema Inventario")
        End If


    End Sub



    Sub llenarDatos()
        Dim sql As String
        sql = "SELECT Empleados.IdEmpleado, Empleados.Nombre,  Empleados.Identidad, Empleados.Genero, Empleados.Telefono, Empleados.Correo, Empleados.Direccion, Departamentos.NombreD,
                                 Puestos.NombreP FROM Departamentos INNER JOIN  Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                  INNER JOIN Puestos On Empleados.IdPuesto = Puestos.IdPuesto "
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvEmpleados.DataSource = tabla
            lblTotalEmpleados.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema Inventario")

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


    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE Empleados SET  Nombre = '" & txtNombreE.Text & " ', Identidad = '" & txtIdentidad.Text & "', Genero = '" & cboGenero.Text & "' ,
                                       Telefono = '" & txtTelefono.Text & "',   Correo =  '" & txtCorreo.Text & "',  Direccion =  '" & txtDireccion.Text & "' , IdDepartamento =  '" & Trim(cboDepartamento.SelectedValue) & "',  IdPuesto =  '" & Trim(cboPuesto.SelectedValue) & "'  WHERE IdEmpleado = '" & txtId.Text & "'          "
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
            If MsgBox("Seguro en Eliminar a " + Trim(txtNombreE.Text) + " De Su Registro? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM Empleados WHERE IdEmpleado = " & Trim(txtId.Text)

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


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call ActivarControles()
        LimpiarControles()
        txtNombreE.Focus()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        TamañoFormularioBuscar()
        btnCancelar.Enabled = True
        btnBuscar.Enabled = False
        txtBuscar.Focus()
        LlenarDatos()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Editar()
        DesactivarControles()
        LlenarDatos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        TamañoFormulario()
        Call DesactivarControles()
        LimpiarControles()
        Panel1.Visible = False
        btnCancelar.Enabled = False
        btnBuscar.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Insertar()
        LlenarDatos()
        Call DesactivarControles()
        LimpiarControles()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
        DesactivarControles()
        LlenarDatos()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        txtBuscar.Focus()
        BuscarDatos()

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

    Private Sub dgvEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvEmpleados.Item("IdEmpleado", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtNombreE.Text = CStr(dgvEmpleados.Item("Nombre", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtIdentidad.Text = CStr(dgvEmpleados.Item("Identidad", dgvEmpleados.CurrentCell.RowIndex).Value)
        cboGenero.Text = CStr(dgvEmpleados.Item("Genero", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtTelefono.Text = CStr(dgvEmpleados.Item("Telefono", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtCorreo.Text = CStr(dgvEmpleados.Item("Correo", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtDireccion.Text = CStr(dgvEmpleados.Item("Correo", dgvEmpleados.CurrentCell.RowIndex).Value)
        cboDepartamento.Text = CStr(dgvEmpleados.Item("NombreD", dgvEmpleados.CurrentCell.RowIndex).Value)
        cboPuesto.Text = CStr(dgvEmpleados.Item("NombreP", dgvEmpleados.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False



        txtNombreE.Enabled = True
        txtIdentidad.Enabled = True
        cboGenero.Enabled = True
        txtTelefono.Enabled = True
        txtCorreo.Enabled = True
        txtDireccion.Enabled = True
        cboDepartamento.Enabled = True
        cboPuesto.Enabled = True

        txtNombreE.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDepartamentos.Click
        frmDepartamentos.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPuestos.Click
        frmPuestosTrabajo.ShowDialog()


    End Sub

    Private Sub cboDepartamento_Click(sender As Object, e As EventArgs) Handles cboDepartamento.Click
        Mostrar_Departamentos()

    End Sub

    Private Sub cboPuesto_Click(sender As Object, e As EventArgs) Handles cboPuesto.Click
        Mostrar_Puestos()

    End Sub


End Class