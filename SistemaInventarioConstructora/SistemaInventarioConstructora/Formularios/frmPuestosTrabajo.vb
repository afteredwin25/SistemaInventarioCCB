Imports System.Data.SqlClient


Public Class frmPuestosTrabajo
    Private Sub frmPuestosTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactivarControles()
        LlenarDatos()
        dgvPuestos.AutoGenerateColumns = False
        TamañoFormulario()

    End Sub

    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False


        txtNombreP.Enabled = False
        txtDescripcionP.Enabled = False

        btnNuevo.Enabled = True




    End Sub



    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True



        txtNombreP.Enabled = True
        txtDescripcionP.Enabled = True

        btnNuevo.Enabled = False




    End Sub


    Sub LimpiarControles()
        txtNombreP.Text = ""
        txtDescripcionP.Text = ""

        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub



    Sub TamañoFormulario()
        Width = 843
        Height = 321
        Panel1.Visible = False

    End Sub



    Sub Insertar()
        Dim sql As String
        Dim id As Integer

        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub

        End If

        adaptador = New SqlDataAdapter("SELECT * FROM Puestos WHERE NombreP = '" & txtNombreP.Text & "'  ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtNombreP.Text = tabla.Rows(0).Item("NombreP")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema Inventario")
            Exit Sub

        End If
        If txtNombreP.Text = "" Or txtDescripcionP.Text = "" Then
            MsgBox("Existen campos vacios ", vbInformation, "Sistema Inventario")

            Exit Sub

        Else
            sql = " INSERT INTO Puestos(NombreP, DescripcionP) VALUES ('" & txtNombreP.Text & "', '" & txtDescripcionP.Text & "') "
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
        sql = "Select * FROM Puestos"
        Try


            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvPuestos.DataSource = tabla

            lblTotalPuestos.Text = tabla.Rows.Count


        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente Error " + ex.ToString + " Sistema Inventario")
        End Try


    End Sub


    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE Puestos SET  NombreP = '" & txtNombreP.Text & " ', DescripcionP = '" & txtDescripcionP.Text & "'   WHERE IdPuesto = '" & txtId.Text & "'          "
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
            If MsgBox("Seguro en Eliminar el Puesto de " + Trim(txtNombreP.Text) + " De Su Registro? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM Puestos WHERE IdPuesto = " & Trim(txtId.Text)

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

    Sub TamañoFormularioBuscar()
        Width = 843
        Height = 938
        Panel1.Visible = True
        txtBuscar.BackColor = Color.YellowGreen
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ActivarControles()
        txtNombreP.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        TamañoFormulario()
        LimpiarControles()
        Panel1.Visible = False
        DesactivarControles()
        btnCancelar.Enabled = False
        btnBuscar.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        TamañoFormularioBuscar()

        btnCancelar.Enabled = True
        btnBuscar.Enabled = False
        txtBuscar.Focus()
        LlenarDatos()

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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        If txtBuscar.Text = "" Then
            LlenarDatos()
        End If
        adaptador = New SqlDataAdapter("Select * FROM Puestos WHERE  Nombre Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            dgvPuestos.DataSource = tabla
            lblTotalPuestos.Text = tabla.Rows.Count
        Else
            dgvPuestos.DataSource = ""
        End If
    End Sub

    Private Sub dgvPuestos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPuestos.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvPuestos.Item("IdPuesto", dgvPuestos.CurrentCell.RowIndex).Value)
        txtNombreP.Text = CStr(dgvPuestos.Item("NombreP", dgvPuestos.CurrentCell.RowIndex).Value)
        txtDescripcionP.Text = CStr(dgvPuestos.Item("DescripcionP", dgvPuestos.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False



        txtNombreP.Enabled = True
        txtDescripcionP.Enabled = True

        txtNombreP.Focus()
    End Sub
End Class