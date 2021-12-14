﻿Imports System.Data.SqlClient


Public Class frmUsuarios
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        LlenarDatos()
        dgvUsuarios.AutoGenerateColumns = False
        TamañoFormulario()


    End Sub


    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False


        txtNombreC.Enabled = False
        txtUsuario.Enabled = False
        txtContraseña.Enabled = False
        cboTipoUser.Enabled = False
        cboEstado.Enabled = False

        btnNuevo.Enabled = True




    End Sub



    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True



        txtNombreC.Enabled = True
        txtUsuario.Enabled = True
        txtContraseña.Enabled = True
        cboTipoUser.Enabled = True
        cboEstado.Enabled = True

        btnNuevo.Enabled = False




    End Sub


    Sub LimpiarControles()
        txtNombreC.Text = ""
        txtUsuario.Text = ""
        txtContraseña.Text = ""

        cboTipoUser.Text = ""
        cboEstado.Text = ""
        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub


    Sub TamañoFormulario()
        Width = 801
        Height = 297
        Panel1.Visible = False

    End Sub

    Sub TamañoFormularioBuscar()
        Width = 801
        Height = 879
        Panel1.Visible = True
        txtBuscar.BackColor = Color.YellowGreen
    End Sub


    Sub Insertar()
        Dim sql As String
        Dim id As Integer

        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub

        End If

        adaptador = New SqlDataAdapter("SELECT * FROM Usuarios WHERE Usuario = '" & txtUsuario.Text & "'  ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtUsuario.Text = tabla.Rows(0).Item("Usuario")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema Inventario")
            Exit Sub

        End If
        If txtNombreC.Text = "" Or txtUsuario.Text = "" Or txtContraseña.Text = "" Or cboTipoUser.Text = "" Or cboEstado.Text = "" Then
            MsgBox("Existen campos vacios ", vbInformation, "Sistema Inventario")

            Exit Sub

        Else
            sql = " INSERT INTO Usuarios(NombreCompleto, Usuario, Password, TipoUsuario, Estado ) VALUES ('" & txtNombreC.Text & "', '" & txtUsuario.Text & "', '" & txtContraseña.Text & "', '" & cboTipoUser.Text & "', '" & cboEstado.Text & "') "
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()


            End Using
            conect.Close()
            MsgBox("Registro realizado exitosamente ", vbInformation, "Sistema Inventario")


        End If





    End Sub


    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE Usuarios SET  NombreCompleto = '" & txtNombreC.Text & " ', Usuario = '" & txtUsuario.Text & "', Password = '" & txtContraseña.Text & "' ,
                                       TipoUsuario = '" & cboTipoUser.Text & "',   Estado =  '" & cboEstado.Text & "'   WHERE IdUsuario = '" & txtId.Text & "'          "
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
            If MsgBox("Seguro en Eliminar a " + Trim(txtNombreC.Text) + " De Su Registro? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM Usuarios WHERE IdUsuario = " & Trim(txtId.Text)

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


    Sub LlenarDatos()
        Dim sql As String
        sql = "Select * FROM Usuarios"
        Try


            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvUsuarios.DataSource = tabla

            lblTotalUsuarios.Text = tabla.Rows.Count


        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente Error " + ex.ToString + " Sistema Inventario")
        End Try


    End Sub







    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call ActivarControles()
        LimpiarControles()
        txtNombreC.Focus()



    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Insertar()
        LlenarDatos()
        Call DesactivarControles()
        LimpiarControles()





    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        TamañoFormulario()
        Call DesactivarControles()
        LimpiarControles()
        Panel1.Visible = False
        btnCancelar.Enabled = False
        btnBuscar.Enabled = True



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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            LlenarDatos()
        End If
        adaptador = New SqlDataAdapter("Select * FROM Usuarios WHERE  NombreCompleto Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            dgvUsuarios.DataSource = tabla
            lblTotalUsuarios.Text = tabla.Rows.Count
        Else
            dgvUsuarios.DataSource = ""
        End If

    End Sub

    Private Sub dgvUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick

        On Error Resume Next
        txtId.Text = CStr(dgvUsuarios.Item("IdUsuario", dgvUsuarios.CurrentCell.RowIndex).Value)
        txtNombreC.Text = CStr(dgvUsuarios.Item("NombreCompleto", dgvUsuarios.CurrentCell.RowIndex).Value)
        txtUsuario.Text = CStr(dgvUsuarios.Item("Usuario", dgvUsuarios.CurrentCell.RowIndex).Value)
        txtContraseña.Text = CStr(dgvUsuarios.Item("Password", dgvUsuarios.CurrentCell.RowIndex).Value)
        cboTipoUser.Text = CStr(dgvUsuarios.Item("TipoUsuario", dgvUsuarios.CurrentCell.RowIndex).Value)
        cboEstado.Text = CStr(dgvUsuarios.Item("Estado", dgvUsuarios.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False



        txtNombreC.Enabled = True
        txtUsuario.Enabled = True
        txtContraseña.Enabled = True
        cboTipoUser.Enabled = True
        cboEstado.Enabled = True

        txtNombreC.Focus()


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        TamañoFormularioBuscar()
        btnCancelar.Enabled = True
        btnBuscar.Enabled = False
        txtBuscar.Focus()
        LlenarDatos()


    End Sub
End Class