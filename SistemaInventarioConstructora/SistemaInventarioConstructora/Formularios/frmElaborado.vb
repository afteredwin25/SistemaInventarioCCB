Imports System.Data.SqlClient


Public Class frmElaborado

    Private tabla_departamentos As New DataTable
    Private tabla_puestos As New DataTable

    Private Sub frmElaborado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        Tamañoformulario()
        LlenarDatos()
        dgvElaborado.AutoGenerateColumns = False
        Mostrar_Departamentos()
        cboDepartamento.SelectedIndex = -1
        Mostrar_Puestos()
        cboPuesto.SelectedIndex = -1


        txtIdentidad.AutoCompleteMode = AutoCompleteMode.Suggest
        txtIdentidad.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtIdentidad.AutoCompleteCustomSource = ObtenerIdentidades()

        LimpiarControles()

    End Sub

    Private Function ObtenerIdentidades() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT Identidad FROM Empleados ", obtenerconexion)
        Dim dt As New DataTable("Empleados")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            ListarDatos.Add(CStr(row(0)))

        Next
        Return ListarDatos

    End Function

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

        btnBusquedaEmpleados.Enabled = False
        btnEmpleado.Enabled = False

        txtNombreE.Enabled = False
        txtIdentidad.Enabled = False
        txtCorreo.Enabled = False

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

        btnBusquedaEmpleados.Enabled = True
        btnEmpleado.Enabled = True

        txtNombreE.Enabled = True
        txtIdentidad.Enabled = True
        txtCorreo.Enabled = True

        cboDepartamento.Enabled = True
        cboPuesto.Enabled = True

        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtNombreE.Text = ""
        txtIdentidad.Text = ""
        txtCorreo.Text = ""

        cboDepartamento.Text = ""
        cboPuesto.Text = ""

        txtId.Text = ""
        txtBuscar.Text = ""
        txtIdElaborado.Text = ""

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
        Try
            Dim sql As String
            Dim id As Integer
            If MsgBox("Guardar Nueveo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
                Exit Sub
            End If
            adaptador = New SqlDataAdapter("SELECT * FROM Elaborado Where Identidad = '" & txtIdentidad.Text & "' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                txtIdentidad.Text = tabla.Rows(0).Item("Idenditad")
                MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema Inventario")
                Exit Sub


            End If

            If txtNombreE.Text = "" Or txtIdentidad.Text = "" Or cboDepartamento.Text = "" Or cboPuesto.Text = "" Then
                MsgBox("Existen campos vacios ", vbInformation, "Sistema Inventario")
                Exit Sub
            Else

                sql = "INSERT INTO Elaborado(NombreEla, Identidad,  Correo,  IdPUesto, IdDepartamento) VALUES ('" & txtNombreE.Text.Trim() & "',
                                                        '" & txtIdentidad.Text.Trim() & "',
                                                            '" & txtCorreo.Text.Trim() & "',
                                                        '" & Trim(cboPuesto.SelectedValue) & "','" & Trim(cboDepartamento.SelectedValue) & "')"
                Dim conect As New SqlConnection(obtenerconexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()

                End Using
                conect.Close()
                MsgBox("Registro realizado Exitosamente ", vbInformation, "Sistema Inventario")
            End If

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema Inventario")
        End Try


    End Sub



    Sub llenarDatos()
        Dim sql As String
        sql = "SELECT Elaborado.IdElaborado, Elaborado.NombreEla,  Elaborado.Identidad, Elaborado.Correo, 
                    Departamentos.NombreD,
                                 Puestos.NombreP FROM Departamentos INNER JOIN  Elaborado ON Departamentos.IdDepartamento = Elaborado.IdDepartamento
                                                     INNER JOIN Puestos On Elaborado.IdPuesto = Puestos.IdPuesto "
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvElaborado.DataSource = tabla
            lblTotalPropietarios.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema Inventario")
        End Try
    End Sub


    Sub BuscarDatos()
        If rbNombreEmpleado.Checked Then


            If txtBuscar.Text = "" Then
                llenarDatos()
            End If
            adaptador = New SqlDataAdapter("Select Elaborado.IdElaborado, Elaborado.NombreEla, Elaborado.Identidad, 
                         Elaborado.Correo,  Departamentos.NombreD, Puestos.NombreP 
                          FROM Departamentos  INNER JOIN Elaborado ON Departamentos.IdDepartamento =  Elaborado.IdDepartamento  
                                               INNER JOIN Puestos ON  Elaborado.IdPuesto = Puestos.IdPuesto WHERE 
                                 Elaborado.Nombre Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvElaborado.DataSource = tabla
                lblTotalPropietarios.Text = tabla.Rows.Count
            Else
                dgvElaborado.DataSource = ""
            End If
        End If

        If rbIdentidad.Checked Then

            If txtBuscar.Text = "" Then
                llenarDatos()
            End If
            adaptador = New SqlDataAdapter("Select Elaborado.IdElaborado, Elaborado.NombreEla, Elaborado.Identidad, 
                         Elaborado.Correo,  Departamentos.NombreD, Puestos.NombreP 
                          FROM Departamentos  INNER JOIN Elaborado ON Departamentos.IdDepartamento =  Elaborado.IdDepartamento  
                                               INNER JOIN Puestos ON  Elaborado.IdPuesto = Puestos.IdPuesto WHERE  Propietarios.Identidad Like
                                     '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvElaborado.DataSource = tabla
                lblTotalPropietarios.Text = tabla.Rows.Count
            Else
                dgvElaborado.DataSource = ""
            End If
        End If

        If rbDepartamento.Checked Then

            If txtBuscar.Text = "" Then
                llenarDatos()
            End If
            adaptador = New SqlDataAdapter("Select Elaborado.IdElaborado, Elaborado.NombreEla, Elaborado.Identidad, 
                         Elaborado.Correo,  Departamentos.NombreD, Puestos.NombreP 
                          FROM Departamentos  INNER JOIN Elaborado ON Departamentos.IdDepartamento =  Elaborado.IdDepartamento  
                                               INNER JOIN Puestos ON  Elaborado.IdPuesto = Puestos.IdPuesto
                                  WHERE  Elaborado.NombreD Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvElaborado.DataSource = tabla
                lblTotalPropietarios.Text = tabla.Rows.Count
            Else
                dgvElaborado.DataSource = ""
            End If
        End If




    End Sub


    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE Elaborado SET  NombreEla = '" & txtNombreE.Text & " ', Identidad = '" & txtIdentidad.Text & "',
                                          Correo =  '" & txtCorreo.Text & "',  
            IdDepartamento =  '" & Trim(cboDepartamento.SelectedValue) & "',  IdPuesto =  '" & Trim(cboPuesto.SelectedValue) & "'  WHERE IdElaborado = '" & txtId.Text & "'  "
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
                sql = "DELETE FROM Elaborado WHERE IdPropietario = " & Trim(txtId.Text)

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

    Private Sub txtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad.TextChanged
        If txtIdentidad.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Correo,
                                          Departamentos.NombreD, Puestos.NombreP  FROM   Departamentos 
                                      INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento 
                                      INNER JOIN Puestos ON  Empleados.IdPuesto= Puestos.IdPuesto                                                                                                   
                                   WHERE   Identidad = '" & txtIdentidad.Text & "'  ", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                txtNombreE.Text = fila("Nombre").ToString
                cboDepartamento.Text = fila("NombreD").ToString
                txtIdElaborado.Text = fila("IdEmpleado").ToString
                txtCorreo.Text = fila("Correo").ToString
                cboPuesto.Text = fila("NombreP").ToString
            Else
                txtNombreE.Clear()
                cboDepartamento.Text = ""

                txtIdentidad.Focus()

            End If



        End If
    End Sub

    Private Sub btnBusquedaEmpleados_Click(sender As Object, e As EventArgs) Handles btnBusquedaEmpleados.Click
        frmBusquedaEmpleadosElaborados.ShowDialog()

    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        frmEmpleados.ShowDialog()

    End Sub

    Private Sub dgvPropietarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvElaborado.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvElaborado.Item("IdElaborado", dgvElaborado.CurrentCell.RowIndex).Value)
        txtNombreE.Text = CStr(dgvElaborado.Item("NombreEla", dgvElaborado.CurrentCell.RowIndex).Value)
        txtIdentidad.Text = CStr(dgvElaborado.Item("Identidad", dgvElaborado.CurrentCell.RowIndex).Value)


        txtCorreo.Text = CStr(dgvElaborado.Item("Correo", dgvElaborado.CurrentCell.RowIndex).Value)

        cboDepartamento.Text = CStr(dgvElaborado.Item("NombreD", dgvElaborado.CurrentCell.RowIndex).Value)
        cboPuesto.Text = CStr(dgvElaborado.Item("NombreP", dgvElaborado.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False



        txtNombreE.Enabled = True
        txtIdentidad.Enabled = True

        txtCorreo.Enabled = True

        cboDepartamento.Enabled = True
        cboPuesto.Enabled = True

        txtNombreE.Focus()
    End Sub

    Private Sub btnDepartamentos_Click(sender As Object, e As EventArgs) Handles btnDepartamentos.Click
        frmDepartamentos.ShowDialog()
    End Sub

    Private Sub btnPuestos_Click(sender As Object, e As EventArgs) Handles btnPuestos.Click
        frmPuestosTrabajo.ShowDialog()

    End Sub
End Class