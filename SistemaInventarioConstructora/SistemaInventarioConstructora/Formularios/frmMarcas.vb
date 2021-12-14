Imports System.Data.SqlClient



Public Class frmMarcas
    Private Sub frmMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactivarControles()
        LlenarDatos()
        dgvMarcas.AutoGenerateColumns = False
        TamañoFormulario()

    End Sub



    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False


        txtNombreM.Enabled = False
        txtDescripcionM.Enabled = False

        btnNuevo.Enabled = True




    End Sub



    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True



        txtNombreM.Enabled = True
        txtDescripcionM.Enabled = True

        btnNuevo.Enabled = False




    End Sub


    Sub LimpiarControles()
        txtNombreM.Text = ""
        txtDescripcionM.Text = ""

        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub



    Sub TamañoFormulario()
        Width = 845
        Height = 321
        Panel1.Visible = False

    End Sub

    Sub TamañoFormularioBuscar()
        Width = 845
        Height = 929
        Panel1.Visible = True
        txtBuscar.BackColor = Color.YellowGreen
    End Sub


    Sub Insertar()
        Dim sql As String
        Dim id As Integer

        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub

        End If

        adaptador = New SqlDataAdapter("SELECT * FROM Marcas WHERE NombreM = '" & txtNombreM.Text & "'  ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtNombreM.Text = tabla.Rows(0).Item("NombreM")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema Inventario")
            Exit Sub

        End If
        If txtNombreM.Text = "" Then
            MsgBox("Existen campos vacios ", vbInformation, "Sistema Inventario")

            Exit Sub

        Else
            sql = " INSERT INTO Marcas(NombreM, DescripcionM ) VALUES ('" & txtNombreM.Text & "', '" & txtDescripcionM.Text & "') "
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
        sql = "Select * FROM Marcas"
        Try


            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvMarcas.DataSource = tabla

            lblTotalMarcas.Text = tabla.Rows.Count


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
            sql = "UPDATE Marcas SET  NombreM = '" & txtNombreM.Text & " ', DescripcionM = '" & txtDescripcionM.Text & "'   WHERE IdMarca = '" & txtId.Text & "'          "
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
            If MsgBox("Seguro en Eliminar la Marca de " + Trim(txtNombreM.Text) + " De Su Registro? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM Marcas WHERE IdMarca = " & Trim(txtId.Text)

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
        txtNombreM.Focus()
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
        LimpiarControles()
        Panel1.Visible = False
        DesactivarControles()
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

        If txtBuscar.Text = "" Then
            LlenarDatos()
        End If
        adaptador = New SqlDataAdapter("Select * FROM Marcas WHERE  NombreM Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            dgvMarcas.DataSource = tabla
            lblTotalMarcas.Text = tabla.Rows.Count
        Else
            dgvMarcas.DataSource = ""
        End If
    End Sub

    Private Sub dgvMarcas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMarcas.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvMarcas.Item("IdMarca", dgvMarcas.CurrentCell.RowIndex).Value)
        txtNombreM.Text = CStr(dgvMarcas.Item("NombreM", dgvMarcas.CurrentCell.RowIndex).Value)
        txtDescripcionM.Text = CStr(dgvMarcas.Item("DescripcionM", dgvMarcas.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False



        txtNombreM.Enabled = True
        txtDescripcionM.Enabled = True

        txtNombreM.Focus()
    End Sub
End Class