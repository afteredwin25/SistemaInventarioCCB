Imports System.Data.SqlClient


Public Class frmTipoActivo
    Private Sub frmTipoActivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactivarControles()
        TamañoFormulario()
        LlenarDatos()
        dgvTipo.AutoGenerateColumns = False


    End Sub



    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False


        txtNombreT.Enabled = False
        txtDescripcionM.Enabled = False

        btnNuevo.Enabled = True




    End Sub



    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True



        txtNombreT.Enabled = True
        txtDescripcionM.Enabled = True

        btnNuevo.Enabled = False




    End Sub


    Sub LimpiarControles()
        txtNombreT.Text = ""
        txtDescripcionM.Text = ""

        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub


    Sub TamañoFormulario()
        Width = 868
        Height = 292
        Panel1.Visible = False

    End Sub

    Sub TamañoFormularioBuscar()
        Width = 868
        Height = 760
        Panel1.Visible = True
        txtBuscar.BackColor = Color.YellowGreen
    End Sub

    Sub Insertar()
        Dim sql As String
        Dim id As Integer

        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub

        End If

        adaptador = New SqlDataAdapter("SELECT * FROM TipoActivo WHERE NombreT = '" & txtNombreT.Text & "'  ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtNombreT.Text = tabla.Rows(0).Item("NombreT")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema Inventario")
            Exit Sub

        End If
        If txtNombreT.Text = "" Then
            MsgBox("Existen campos vacios ", vbInformation, "Sistema Inventario")

            Exit Sub

        Else
            sql = " INSERT INTO TipoActivo(NombreT, Descripcion ) VALUES ('" & txtNombreT.Text & "', '" & txtDescripcionM.Text & "') "
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
        sql = "Select * FROM TipoActivo"
        Try


            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvTipo.DataSource = tabla

            lblTotalTipos.Text = tabla.Rows.Count


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
            sql = "UPDATE TipoActivo SET  NombreT = '" & txtNombreT.Text & " ', Descripcion = '" & txtDescripcionM.Text & "'   WHERE IdTipo = '" & txtId.Text & "'          "
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
            If MsgBox("Seguro en Eliminar el Tipo  " + Trim(txtNombreT.Text) + " De Su Registro? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM TipoActivo WHERE IdTipo = " & Trim(txtId.Text)

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
        ActivarControles()
        txtNombreT.Focus()
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        TamañoFormulario()
        LimpiarControles()
        Panel1.Visible = False
        DesactivarControles()
        btnCancelar.Enabled = False
        btnBuscar.Enabled = True
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            LlenarDatos()
        End If
        adaptador = New SqlDataAdapter("Select * FROM TipoActivo WHERE  NombreT Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            dgvTipo.DataSource = tabla
            lblTotalTipos.Text = tabla.Rows.Count
            dgvTipo.DataSource = ""
        End If
    End Sub

    Private Sub dgvTipo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipo.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvTipo.Item("IdTipo", dgvTipo.CurrentCell.RowIndex).Value)
        txtNombreT.Text = CStr(dgvTipo.Item("NombreT", dgvTipo.CurrentCell.RowIndex).Value)
        txtDescripcionM.Text = CStr(dgvTipo.Item("Descripcion", dgvTipo.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False



        txtNombreT.Enabled = True
        txtDescripcionM.Enabled = True

        txtNombreT.Focus()
    End Sub
End Class