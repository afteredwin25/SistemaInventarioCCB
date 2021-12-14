Imports System.Data.SqlClient


Public Class frmSolicitantes
    Private tabla_departamentos As New DataTable
    Private tabla_puestos As New DataTable

    Private Sub frmSolicitantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        Tamañoformulario()
        LlenarDatos()
        dgvSolicitantes.AutoGenerateColumns = False
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
        btnPuestos.Enabled = False

        txtNombreSolicitante.Enabled = False
        txtIdentidad.Enabled = False

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


        txtNombreSolicitante.Enabled = True
        txtIdentidad.Enabled = True

        cboDepartamento.Enabled = True
        cboPuesto.Enabled = True

        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtNombreSolicitante.Text = ""
        txtIdentidad.Text = ""

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
        adaptador = New SqlDataAdapter("SELECT * FROM Solicitante Where Identidad = '" & txtIdentidad.Text & "' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtIdentidad.Text = tabla.Rows(0).Item("Idenditad")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema Inventario")
            Exit Sub


        End If

        If txtNombreSolicitante.Text = "" Or txtIdentidad.Text = "" Or cboDepartamento.Text = "" Or cboPuesto.Text = "" Then
            MsgBox("Existen campos vacios ", vbInformation, "Sistema Inventario")
            Exit Sub
        Else

            sql = "INSERT INTO Solicitante(Identidad, NombreSolicitante,  IdDepartamento , IdPUesto) VALUES ('" & txtIdentidad.Text.Trim() & "', 
                                  '" & txtNombreSolicitante.Text.Trim() & "',                                                      
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
        sql = "SELECT Solicitante.IdSolicitante, Solicitante.Identidad, Solicitante.NombreSolicitante,    Departamentos.NombreD,
                                 Puestos.NombreP FROM Departamentos INNER JOIN  Solicitante ON Departamentos.IdDepartamento = Solicitante.IdDepartamento
                                  INNER JOIN Puestos On Solicitante.IdPuesto = Puestos.IdPuesto "
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvSolicitantes.DataSource = tabla
            lblTotalSolicitantes.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema Inventario")

        End Try
    End Sub

    Sub BuscarDatos()
        If rbNombreEmpleado.Checked Then


            If txtBuscar.Text = "" Then
                llenarDatos()
            End If
            adaptador = New SqlDataAdapter("Select Solicitante.IdSolicitante, Solicitante.NombreSolicitante, Solicitante.Identidad, 
                                             Departamentos.NombreD, Puestos.NombreP  
                                            FROM Departamentos INNER JOIN Tecnicos ON Departamentos.IdDepartamento =  Tecnicos.IdDepartamento  
                                                                INNER JOIN Puestos ON  Solicitante.IdPuesto = Puestos.IdPuesto WHERE  
                                                               Solicitante.NombreSolicitante Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSolicitantes.DataSource = tabla
                lblTotalSolicitantes.Text = tabla.Rows.Count
            Else
                dgvSolicitantes.DataSource = ""
            End If
        End If

        If rbIdentidad.Checked Then

            If txtBuscar.Text = "" Then
                llenarDatos()
            End If
            adaptador = New SqlDataAdapter("Select Solicitante.IdSolicitante, Solicitante.NombreSolicitante, Solicitante.Identidad, 
                                             Departamentos.NombreD, Puestos.NombreP  
                                            FROM Departamentos INNER JOIN Tecnicos ON Departamentos.IdDepartamento =  Tecnicos.IdDepartamento  
                                                                INNER JOIN Puestos ON  Solicitante.IdPuesto = Puestos.IdPuesto
                                               WHERE  Tecnicos.Identidad Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSolicitantes.DataSource = tabla
                lblTotalSolicitantes.Text = tabla.Rows.Count
            Else
                dgvSolicitantes.DataSource = ""
            End If
        End If

        If rbDepartamento.Checked Then

            If txtBuscar.Text = "" Then
                llenarDatos()
            End If
            adaptador = New SqlDataAdapter("Select Solicitante.IdSolicitante, Solicitante.NombreSolicitante, Solicitante.Identidad, 
                                             Departamentos.NombreD, Puestos.NombreP  
                                            FROM Departamentos INNER JOIN Tecnicos ON Departamentos.IdDepartamento =  Tecnicos.IdDepartamento  
                                                                INNER JOIN Puestos ON  Solicitante.IdPuesto = Puestos.IdPuesto
                                                WHERE  Departamentos.NombreD Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSolicitantes.DataSource = tabla
                lblTotalSolicitantes.Text = tabla.Rows.Count
            Else
                dgvSolicitantes.DataSource = ""
            End If
        End If




    End Sub

    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE Solicitante SET  NombreSolicitante = '" & txtNombreSolicitante.Text & " ', Identidad = '" & txtIdentidad.Text & "',
                          IdDepartamento =  '" & Trim(cboDepartamento.SelectedValue) & "',  IdPuesto =  '" & Trim(cboPuesto.SelectedValue) & "'
                             WHERE IdSolicitante = '" & txtId.Text & "'          "
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
            If MsgBox("Seguro en Eliminar a " + Trim(txtNombreSolicitante.Text) + " De Su Registro? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM Solicitante WHERE IdSolicitante = " & Trim(txtId.Text)

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
        txtIdentidad.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        insertar()
        llenarDatos()
        Call DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Editar()
        DesactivarControles()
        llenarDatos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
        DesactivarControles()
        llenarDatos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        TamañoFormulario()
        Call DesactivarControles()
        LimpiarControles()
        Panel1.Visible = False
        btnCancelar.Enabled = False
        btnBuscar.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        TamañoFormularioBuscar()
        btnCancelar.Enabled = True
        btnBuscar.Enabled = False
        txtBuscar.Focus()
        llenarDatos()
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

    Private Sub dgvSolicitantes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSolicitantes.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvSolicitantes.Item("IdSolicitante", dgvSolicitantes.CurrentCell.RowIndex).Value)
        txtNombreSolicitante.Text = CStr(dgvSolicitantes.Item("NombreSolicitante", dgvSolicitantes.CurrentCell.RowIndex).Value)
        txtIdentidad.Text = CStr(dgvSolicitantes.Item("Identidad", dgvSolicitantes.CurrentCell.RowIndex).Value)

        cboDepartamento.Text = CStr(dgvSolicitantes.Item("NombreD", dgvSolicitantes.CurrentCell.RowIndex).Value)
        cboPuesto.Text = CStr(dgvSolicitantes.Item("NombreP", dgvSolicitantes.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False



        txtNombreSolicitante.Enabled = True
        txtIdentidad.Enabled = True

        cboDepartamento.Enabled = True
        cboPuesto.Enabled = True

        txtNombreSolicitante.Focus()
    End Sub

    Private Sub btnDepartamentos_Click(sender As Object, e As EventArgs) Handles btnDepartamentos.Click
        frmDepartamentos.ShowDialog()

    End Sub

    Private Sub btnPuestos_Click(sender As Object, e As EventArgs) Handles btnPuestos.Click
        frmPuestosTrabajo.ShowDialog()

    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        frmEmpleados.ShowDialog()
    End Sub

    Private Sub btnBusquedaSolicitantes_Click(sender As Object, e As EventArgs) Handles btnBusquedaSolicitantes.Click
        frmBusquedaEmpleadosSolicitantes.ShowDialog()

    End Sub
End Class