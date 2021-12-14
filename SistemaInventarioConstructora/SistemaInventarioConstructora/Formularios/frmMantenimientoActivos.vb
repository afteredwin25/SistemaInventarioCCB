Imports System.Data.SqlClient



Public Class frmMantenimientoActivos
    Private Sub frmMantenimientoActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        Tamañoformulario()
        LlenarDatos()

        txtCodigoI.AutoCompleteMode = AutoCompleteMode.Suggest
        txtCodigoI.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCodigoI.AutoCompleteCustomSource = ObtenerCodigoInventario()





        dgvMantenimientoActivos.AutoGenerateColumns = False

    End Sub


    Sub Tamañoformulario()
        Width = 1423
        Height = 393
        Panel1.Visible = False
    End Sub


    Sub TamañoformularioBuscar()
        Width = 1423
        Height = 1176
        Panel1.Visible = True
        txtBuscar.Focus()
        txtBuscar.BackColor = Color.YellowGreen
    End Sub

    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnCargos.Enabled = False


        txtCodigoI.Enabled = False
        txtNombreA.Enabled = False

        txtIdentidad.Enabled = False
        txtNombreE.Enabled = False
        txtDepartamento.Enabled = False

        DTPFechaEntrega.Enabled = False
        DTPFechaMantenimiento.Enabled = False

        txtDescripcion.Enabled = False


        btnNuevo.Enabled = True
    End Sub

    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        btnCargos.Enabled = True



        txtCodigoI.Enabled = True
        txtNombreA.Enabled = True

        txtIdentidad.Enabled = True
        txtNombreE.Enabled = True
        txtDepartamento.Enabled = True

        DTPFechaEntrega.Enabled = False
        DTPFechaMantenimiento.Enabled = True

        txtDescripcion.Enabled = True




        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtCodigoI.Text = ""
        txtNombreA.Text = ""

        txtIdentidad.Text = ""
        txtNombreE.Text = ""
        txtDepartamento.Text = ""

        DTPFechaEntrega.Text = ""

        txtDescripcion.Text = ""




        txtIdCargo.Text = ""
        txtIdArticulo.Text = ""
        txtId.Text = ""
        txtBuscar.Text = ""

        DTPFechaMantenimiento.Text = ""


    End Sub

    Private Function ObtenerCodigoInventario() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT  CodigoInventario FROM  CargoActivos WHERE EstadoArticulo  <> 'ELIMINADO'      ", obtenerconexion)
        Dim dt As New DataTable("CargoActivos")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            ListarDatos.Add(CStr(row(0)))
        Next
        Return ListarDatos

    End Function

    Sub insertar()
        Dim sql As String
        Dim id As Integer

        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT CargoActivos.CodigoInventario FROM CargoActivos
                               INNER JOIN Mantenimientos ON CargoActivos.IdCargo = Mantenimientos.IdCargo  
                            Where CargoActivos.CodigoInventario =  '" & txtCodigoI.Text & "' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        'If tabla.Rows.Count > 0 Then
        '    txtCodigoI.Text = tabla.Rows(0).Item("CodigoInventario")
        '    MsgBox("El registro ya existe en la base de datos", vbInformation, " Sistema inventario")
        '    Exit Sub

        'End If

        If txtIdArticulo.Text = "" Or txtIdCargo.Text = "" Or DTPFechaMantenimiento.Text = "" Then
            MsgBox("Existen campos vacios", vbInformation, " Sistema inventario")
            Exit Sub

        Else
            sql = "INSERT INTO Mantenimientos(FechaMantenimiento, Descripcion,  IdCargo) VALUES ('" & DTPFechaMantenimiento.Text & "', '" & txtDescripcion.Text & "', '" & txtIdCargo.Text & "' ) "
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()


            MsgBox("Registro realizado existosamente", vbInformation, " Sistema inventario")
        End If


    End Sub

    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE Mantenimientos SET  FechaMantenimiento = '" & DTPFechaMantenimiento.Text & " ', Descripcion = '" & txtDescripcion.Text & "'
                    WHERE IdMantenimiento = '" & txtId.Text & "'          "
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
            If MsgBox("Seguro en Eliminar el Mantenimiento  " + Trim(txtNombreA.Text) + " De Su Registro de Mantenimiento? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM Mantenimientos WHERE IdMantenimiento = " & Trim(txtId.Text)

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
        sql = "SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA,  Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD  , Articulos.IdArticulo,
           Mantenimientos.IdMantenimiento, Mantenimientos.FechaMantenimiento, Mantenimientos.Descripcion
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                          INNER JOIN Mantenimientos ON CargoActivos.IdCargo = Mantenimientos.IdCargo        "

        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvMantenimientoActivos.DataSource = tabla
            lblTotalMantenimientos.Text = tabla.Rows.Count


        Catch ex As Exception

            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema Inventario")
        End Try

    End Sub


    Sub BuscarDatos()
        If rbNombreEmpleado.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.Idcargo, CargoActivos.CodigoInventario, 
                      Articulos.NombreA,  Articulos.IdArticulo, 
                      Empleados.Nombre, Empleados.Identidad,  Departamentos.NombreD,
                      Mantenimientos.IdMantenimiento, Mantenimientos.FechaMantenimiento, Mantenimientos.Descripcion
                    FROM Articulos INNER JOIN  CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo 
                                   INNER JOIN  Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                   INNER JOIN  Departamentos ON  Empleados.IdDepartamento = Departamentos.IdDepartamento
                                   INNER JOIN  Mantenimientos ON CargoActivos.IdCargo = Mantenimientos.IdCargo 
                        WHERE  Empleados.Nombre LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvMantenimientoActivos.DataSource = tabla
                lblTotalMantenimientos.Text = tabla.Rows.Count
            Else
                dgvMantenimientoActivos.DataSource = ""
            End If


        End If
        If rbCodigoInventario.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.Idcargo, CargoActivos.CodigoInventario, 
                      Articulos.NombreA,  Articulos.IdArticulo, 
                      Empleados.Nombre, Empleados.Identidad,  Departamentos.NombreD,
                      Mantenimientos.IdMantenimiento, Mantenimientos.FechaMantenimiento, Mantenimientos.Descripcion
                    FROM Articulos INNER JOIN  CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo 
                                   INNER JOIN  Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                   INNER JOIN  Departamentos ON  Empleados.IdDepartamento = Departamentos.IdDepartamento
                                   INNER JOIN  Mantenimientos ON CargoActivos.IdCargo = Mantenimientos.IdCargo 
                  WHERE  CargoActivos.CodigoInventario LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvMantenimientoActivos.DataSource = tabla
                lblTotalMantenimientos.Text = tabla.Rows.Count
            Else
                dgvMantenimientoActivos.DataSource = ""
            End If
        End If

        If rbNombreArticulo.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.Idcargo, CargoActivos.CodigoInventario, 
                      Articulos.NombreA,  Articulos.IdArticulo, 
                      Empleados.Nombre, Empleados.Identidad,  Departamentos.NombreD,
                      Mantenimientos.IdMantenimiento, Mantenimientos.FechaMantenimiento, Mantenimientos.Descripcion
                    FROM Articulos INNER JOIN  CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo 
                                   INNER JOIN  Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                   INNER JOIN  Departamentos ON  Empleados.IdDepartamento = Departamentos.IdDepartamento
                                   INNER JOIN  Mantenimientos ON CargoActivos.IdCargo = Mantenimientos.IdCargo 
                                  WHERE  Articulos.NombreA LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvMantenimientoActivos.DataSource = tabla
                lblTotalMantenimientos.Text = tabla.Rows.Count
            Else
                dgvMantenimientoActivos.DataSource = ""
            End If
        End If


        If rbDepartamento.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.Idcargo, CargoActivos.CodigoInventario, 
                      Articulos.NombreA,  Articulos.IdArticulo, Articulos.PrecioCompra,
                      Empleados.Nombre, Empleados.Identidad,  Departamentos.NombreD,
                      DescargoActivos.IdDescargo, DescargoActivos.FechaDescargo,DescargoActivos.MotivoDescargo, DescargoActivos.Descripcion
                    FROM Articulos INNER JOIN  CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo 
                                   INNER JOIN  Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                   INNER JOIN  Departamentos ON  Empleados.IdDepartamento = Departamentos.IdDepartamento
                                   INNER JOIN  DescargoActivos ON CargoActivos.IdCargo = DescargoActivos.IdCargoActivo
                    WHERE  Departamentos.NombreD LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvMantenimientoActivos.DataSource = tabla
                lblTotalMantenimientos.Text = tabla.Rows.Count
            Else
                dgvMantenimientoActivos.DataSource = ""
            End If
        End If













    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call ActivarControles()
        LimpiarControles()
        btnBuscar.Enabled = True
        txtCodigoI.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        TamañoformularioBuscar()



        insertar()

        LlenarDatos()
        DesactivarControles()
        LimpiarControles()



    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            Editar()
            DesactivarControles()
            LlenarDatos()
        Else
            MsgBox("No tiene los privilegios para editar la Información", vbInformation, "Operación Cancelada")
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            Eliminar()
            DesactivarControles()
            LlenarDatos()
        Else
            MsgBox("No tiene los privilegios para editar la Información", vbInformation, "Operación Cancelada")
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Tamañoformulario()
        Call DesactivarControles()
        LimpiarControles()
        btnBuscar.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        TamañoformularioBuscar()
        btnCancelar.Enabled = True
        btnBuscar.Enabled = False
    End Sub



    Private Sub txtCodigoI_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoI.TextChanged
        If txtCodigoI.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.FechaAsignacion, Articulos.IdArticulo, Articulos.NombreA,  Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD
                FROM  Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo  = CargoActivos.IdArticulo
                                INNER JOIN Empleados ON  CargoActivos.IdEmpleado = Empleados.IdEmpleado   
                                INNER JOIN Departamentos ON  Empleados.IdDepartamento = Departamentos.IdDepartamento 
                         WHERE CargoActivos.CodigoInventario = '" & txtCodigoI.Text & "'  ", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                txtNombreA.Text = fila("NombreA").ToString
                txtIdArticulo.Text = fila("IdArticulo").ToString
                txtIdentidad.Text = fila("Identidad").ToString
                txtNombreE.Text = fila("Nombre").ToString
                txtDepartamento.Text = fila("NombreD").ToString
                txtIdCargo.Text = fila("IdCargo").ToString



                DTPFechaEntrega.Text = fila("FechaAsignacion").ToString

            Else
                txtNombreA.Clear()


                txtCodigoI.Focus()
                txtIdArticulo.Clear()
                txtIdentidad.Clear()
                txtNombreE.Clear()
                txtDepartamento.Clear()
                DTPFechaEntrega.Text = ""
                txtIdCargo.Clear()

            End If

        End If
    End Sub


    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
    End Sub

    Private Sub btnCargos_Click(sender As Object, e As EventArgs) Handles btnCargos.Click
        frmBusquedaActivosFijosM.ShowDialog()


    End Sub

    Private Sub rbNombreArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreArticulo.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbCodigoInventario_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigoInventario.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbNombreEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreEmpleado.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbDepartamento_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepartamento.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub dgvMantenimientoActivos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMantenimientoActivos.CellDoubleClick
        On Error Resume Next
        txtIdArticulo.Text = CStr(dgvMantenimientoActivos.Item("IdArticulo", dgvMantenimientoActivos.CurrentCell.RowIndex).Value)
        txtNombreA.Text = CStr(dgvMantenimientoActivos.Item("NombreA", dgvMantenimientoActivos.CurrentCell.RowIndex).Value)
        txtCodigoI.Text = CStr(dgvMantenimientoActivos.Item("CodigoInventario", dgvMantenimientoActivos.CurrentCell.RowIndex).Value)


        txtIdCargo.Text = CStr(dgvMantenimientoActivos.Item("IdCargo", dgvMantenimientoActivos.CurrentCell.RowIndex).Value)
        txtNombreE.Text = CStr(dgvMantenimientoActivos.Item("Nombre", dgvMantenimientoActivos.CurrentCell.RowIndex).Value)
        txtIdentidad.Text = CStr(dgvMantenimientoActivos.Item("Identidad", dgvMantenimientoActivos.CurrentCell.RowIndex).Value)
        txtDepartamento.Text = CStr(dgvMantenimientoActivos.Item("NombreD", dgvMantenimientoActivos.CurrentCell.RowIndex).Value)

        txtId.Text = CStr(dgvMantenimientoActivos.Item("IdMantenimiento", dgvMantenimientoActivos.CurrentCell.RowIndex).Value)
        DTPFechaEntrega.Text = CStr(dgvMantenimientoActivos.Item("FechaAsignacion", dgvMantenimientoActivos.CurrentCell.RowIndex).Value)
        DTPFechaMantenimiento.Text = CStr(dgvMantenimientoActivos.Item("FechaDescargo", dgvMantenimientoActivos.CurrentCell.RowIndex).Value)


        txtDescripcion.Text = CStr(dgvMantenimientoActivos.Item("Descripcion", dgvMantenimientoActivos.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False

        btnCargos.Enabled = True


        txtCodigoI.Enabled = True
        DTPFechaMantenimiento.Enabled = True

        txtDescripcion.Enabled = True

        txtNombreA.Focus()
    End Sub

    Private Sub btnImprimirMantenimientos_Click(sender As Object, e As EventArgs) Handles btnImprimirMantenimientos.Click
        ReporteMantenimiento.ImprimirMantenimientoActivos()
        ReporteMantenimiento.ShowDialog()

    End Sub
End Class