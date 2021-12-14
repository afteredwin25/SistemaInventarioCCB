Imports System.Data.SqlClient


Public Class frmCargoActivos

    Private Sub frmCargoActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        txtCodigo.AutoCompleteMode = AutoCompleteMode.Suggest
        txtCodigo.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCodigo.AutoCompleteCustomSource = ObtenerCodigos()


        txtIdentidad.AutoCompleteMode = AutoCompleteMode.Suggest
        txtIdentidad.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtIdentidad.AutoCompleteCustomSource = ObtenerIdentidades()

        TamañoFormulario()
        LlenarDatos()
        dgvActivosAsignados.AutoGenerateColumns = False
        'Mostrar_Marcas()
        'cboMarca.SelectedIndex = -1

        dgvActivosAsignados.Columns("PrecioCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvActivosAsignados.Columns("PrecioCompra").DefaultCellStyle.Format = "N2"


    End Sub


    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False


        txtCodigo.Enabled = False
        txtNombreA.Enabled = False
        txtCodigo.Enabled = False
        txtPrecio.Enabled = False
        txtIdentidad.Enabled = False
        txtNombreE.Enabled = False
        txtDepartamento.Enabled = False
        txtCodigoInventario.Enabled = False
        DTPFechaEntrega.Enabled = False
        cboEstado.Enabled = False
        txtDescripcion.Enabled = False
        cboSede.Enabled = False


        btnArticulos.Enabled = False
        btnEmpleados.Enabled = False




        btnNuevo.Enabled = True
    End Sub

    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True

        txtCodigo.Enabled = True
        txtNombreA.Enabled = True
        txtCodigo.Enabled = True
        txtPrecio.Enabled = True
        txtIdentidad.Enabled = True
        txtNombreE.Enabled = True
        txtDepartamento.Enabled = True
        txtCodigoInventario.Enabled = True
        DTPFechaEntrega.Enabled = True
        cboEstado.Enabled = True
        txtDescripcion.Enabled = True
        cboSede.Enabled = True


        btnArticulos.Enabled = True
        btnEmpleados.Enabled = True


        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()


        txtCodigo.Text = ""
        txtNombreA.Text = ""
        txtCodigo.Text = ""
        txtPrecio.Text = ""
        txtIdentidad.Text = ""
        txtNombreE.Text = ""
        txtDepartamento.Text = ""
        txtCodigoInventario.Text = ""
        DTPFechaEntrega.Text = ""
        cboEstado.Text = ""
        txtDescripcion.Text = ""
        cboSede.Text = ""

        txtId.Text = ""
        txtBuscar.Text = ""
        txtIdArticulo.Text = ""
        txtIdEmpleado.Text = ""


    End Sub


    Sub TamañoFormulario()
        Width = 1424
        Height = 321
        Panel1.Visible = False

    End Sub


    Sub TamañoFormularioBuscar()
        Width = 1424
        Height = 1069
        Panel1.Visible = True
        txtBuscar.BackColor = Color.YellowGreen
    End Sub



    Sub insertar()
        Dim sql As String
        Dim id As Integer

        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM CargoActivos Where CodigoInventario =  '" & txtCodigoInventario.Text & "'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtCodigoInventario.Text = tabla.Rows(0).Item("CodigoInventario")
            MsgBox("El registro ya existe en la base de datos", vbInformation, " Sistema inventario")
            Exit Sub

        End If

        If txtIdArticulo.Text = "" Or txtIdEmpleado.Text = "" Or txtCodigoInventario.Text = "" Or DTPFechaEntrega.Text = "" Then
            MsgBox("Existen campos vacios", vbInformation, " Sistema inventario")
            Exit Sub

        Else
            sql = "INSERT INTO CargoActivos(CodigoInventario, FechaAsignacion, EstadoArticulo, Sede,Descripcion, IdArticulo, IdEmpleado) 
            VALUES ('" & txtCodigoInventario.Text & "', '" & DTPFechaEntrega.Text & "', '" & cboEstado.Text & "',  '" & cboSede.Text & "',  '" & txtDescripcion.Text & "',  
              '" & txtIdArticulo.Text & "', '" & txtIdEmpleado.Text & "') "
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            ModificarArticulo()
            MsgBox("Registro realizado existosamente", vbInformation, " Sistema inventario")
        End If

    End Sub



    Sub ModificarArticulo()
        Dim id As Integer
        Dim sql As String
        sql = "UPDATE Articulos SET  EstadoArticulo = 'ENTREGADO' WHERE IdArticulo = '" & txtIdArticulo.Text & "' "
        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()





    End Sub

    Sub ModificarArticuloPendiente()

        Dim id As Integer
        Dim sql As String
        sql = "UPDATE Articulos SET  EstadoArticulo = 'PENDIENTE' WHERE IdArticulo = '" & txtIdArticulo.Text & "' "
        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()

    End Sub


    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, Articulos.PrecioCompra, 
          Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD  ,CargoActivos.FechaAsignacion , Articulos.IdArticulo,
            Empleados.IdEmpleado,CargoActivos.Sede,  CargoActivos.Descripcion, Articulos.CodigoA, CargoActivos.EstadoArticulo
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento  
           WHERE  CargoActivos.EstadoArticulo <> 'ELIMINADO'"

        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvActivosAsignados.DataSource = tabla
            lblTotalActivosAsignados.Text = tabla.Rows.Count


        Catch ex As Exception

            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema Inventario")
        End Try


    End Sub



    Sub BuscarDatos()
        If rbNombreEmpleado.Checked Then


            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, 
                  Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD  ,CargoActivos.FechaAsignacion ,
                 Articulos.IdArticulo, Empleados.IdEmpleado,CargoActivos.Sede, CargoActivos.Descripcion, Articulos.CodigoA, CargoActivos.EstadoArticulo
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento   WHERE  Empleados.Nombre Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosAsignados.DataSource = tabla
                lblTotalActivosAsignados.Text = tabla.Rows.Count
            Else
                dgvActivosAsignados.DataSource = ""
            End If
        End If

        If rbCodigoInventario.Checked Then

            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, 
                  Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD  ,CargoActivos.FechaAsignacion ,
                 Articulos.IdArticulo, Empleados.IdEmpleado,CargoActivos.Sede, CargoActivos.Descripcion, Articulos.CodigoA, CargoActivos.EstadoArticulo
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                      WHERE  CargoActivos.CodigoInventario Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosAsignados.DataSource = tabla
                lblTotalActivosAsignados.Text = tabla.Rows.Count
            Else
                dgvActivosAsignados.DataSource = ""
            End If
        End If

        If rbNombreArticulo.Checked Then

            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, 
                  Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD  ,CargoActivos.FechaAsignacion ,
                 Articulos.IdArticulo, Empleados.IdEmpleado,CargoActivos.Sede, CargoActivos.Descripcion, Articulos.CodigoA, CargoActivos.EstadoArticulo
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento  
                     WHERE  Articulos.NombreA Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosAsignados.DataSource = tabla
                lblTotalActivosAsignados.Text = tabla.Rows.Count
            Else
                dgvActivosAsignados.DataSource = ""
            End If
        End If


        If rbDepartamento.Checked Then

            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, 
                  Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD  ,CargoActivos.FechaAsignacion ,
                 Articulos.IdArticulo, Empleados.IdEmpleado,CargoActivos.Sede, CargoActivos.Descripcion, Articulos.CodigoA, CargoActivos.EstadoArticulo
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento   
                       WHERE  Departamentos.NombreD Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosAsignados.DataSource = tabla
                lblTotalActivosAsignados.Text = tabla.Rows.Count
            Else
                dgvActivosAsignados.DataSource = ""
            End If
        End If



    End Sub



    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE CargoActivos SET  CodigoInventario = '" & txtCodigoInventario.Text & " ', FechaAsignacion = '" & DTPFechaEntrega.Text & "',

                                       EstadoArticulo = '" & cboEstado.Text & "' , Sede = '" & cboSede.Text & "',
                                       Descripcion = '" & txtDescripcion.Text & "',   IdArticulo =  '" & txtIdArticulo.Text & "', 
                                      IdEmpleado =  '" & txtIdEmpleado.Text & "'   WHERE IdCargo = '" & txtId.Text & "'          "
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
            If MsgBox("Seguro en Eliminar el Activo  " + Trim(txtNombreA.Text) + " De Su Registro de Asignación? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM CargoActivos WHERE IdCargo = " & Trim(txtId.Text)

                Dim conect As New SqlConnection(obtenerconexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()
                End Using
                conect.Close()
                ModificarArticuloPendiente()

                MsgBox("Registro Eliminado Exitosamente ", vbInformation, "Sistema de Inventario")
                LimpiarControles()
            End If

        End If


    End Sub


    Private Function ObtenerCodigos() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT CodigoA FROM Articulos  WHERE   EstadoArticulo = 'PENDIENTE' ", obtenerconexion)
        Dim dt As New DataTable("Articulos")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            ListarDatos.Add(CStr(row(0)))

        Next
        Return ListarDatos

    End Function

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


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call ActivarControles()
        LimpiarControles()
        txtCodigo.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        insertar()
        LlenarDatos()
        Call DesactivarControles()
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
        LlenarDatos()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT IdArticulo, NombreA, PrecioCompra FROM Articulos WHERE CodigoA = '" & txtCodigo.Text & "'  ", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                txtNombreA.Text = fila("NombreA").ToString
                txtPrecio.Text = fila("PrecioCompra").ToString
                txtIdArticulo.Text = fila("IdArticulo").ToString
            Else
                txtNombreA.Clear()
                txtPrecio.Clear()
                txtIdArticulo.Clear()


                txtCodigo.Focus()

            End If



        End If





    End Sub

    Private Sub txtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad.TextChanged

        If txtIdentidad.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Departamentos.NombreD  
                                                      FROM Departamentos 
                                               INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento WHERE Identidad = '" & txtIdentidad.Text & "'  ", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                txtNombreE.Text = fila("Nombre").ToString
                txtDepartamento.Text = fila("NombreD").ToString
                txtIdEmpleado.Text = fila("IdEmpleado").ToString
            Else
                txtNombreE.Clear()
                txtDepartamento.Clear()

                txtIdentidad.Focus()

            End If



        End If






    End Sub

    Private Sub btnCodigo_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        frmBusquedaArticulos.ShowDialog()
        txtIdentidad.Focus()

    End Sub

    Private Sub btnIdentidad_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        frmBusquedaEmpleados.ShowDialog()
        txtCodigoInventario.Focus()

    End Sub

    Private Sub rbCodigoInventario_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigoInventario.CheckedChanged
        txtBuscar.Focus()

    End Sub

    Private Sub rbNombreArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreArticulo.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbNombreEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreEmpleado.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbDepartamento_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepartamento.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()

    End Sub

    Private Sub dgvActivosAsignados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActivosAsignados.CellDoubleClick

        txtIdArticulo.Text = CStr(dgvActivosAsignados.Item("IdArticulo", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtNombreA.Text = CStr(dgvActivosAsignados.Item("NombreA", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtCodigo.Text = CStr(dgvActivosAsignados.Item("CodigoA", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtPrecio.Text = CStr(dgvActivosAsignados.Item("PrecioCompra", dgvActivosAsignados.CurrentCell.RowIndex).Value)

        txtIdEmpleado.Text = CStr(dgvActivosAsignados.Item("IdEmpleado", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtNombreE.Text = CStr(dgvActivosAsignados.Item("Nombre", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtIdentidad.Text = CStr(dgvActivosAsignados.Item("Identidad", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtDepartamento.Text = CStr(dgvActivosAsignados.Item("NombreD", dgvActivosAsignados.CurrentCell.RowIndex).Value)

        txtId.Text = CStr(dgvActivosAsignados.Item("IdCargo", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtCodigoInventario.Text = CStr(dgvActivosAsignados.Item("CodigoInventario", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        DTPFechaEntrega.Text = CStr(dgvActivosAsignados.Item("FechaAsignacion", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        cboEstado.Text = CStr(dgvActivosAsignados.Item("EstadoArticulo", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        cboSede.Text = CStr(dgvActivosAsignados.Item("Sede", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtDescripcion.Text = CStr(dgvActivosAsignados.Item("Descripcion", dgvActivosAsignados.CurrentCell.RowIndex).Value)


        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False
        btnArticulos.Enabled = True
        btnEmpleados.Enabled = True




        txtCodigo.Enabled = True
        txtIdentidad.Enabled = True

        txtCodigoInventario.Enabled = True
        DTPFechaEntrega.Enabled = True
        cboEstado.Enabled = True
        txtPrecio.Enabled = True
        cboSede.Enabled = True

        txtDescripcion.Enabled = True

        txtCodigo.Focus()



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        ReporteArticulosEntregados.ImprimirArticulosEntregados()
        ReporteArticulosEntregados.ShowDialog()

    End Sub

    Private Sub BtnEntregadosCaribe_Click(sender As Object, e As EventArgs) Handles BtnEntregadosCaribe.Click
        ReporteArticulosEntregadosCaribe.ImprimirArticulosEntregadosCaribe()
        ReporteArticulosEntregadosCaribe.ShowDialog()

    End Sub

    Private Sub btnEntregadosCEDI_Click(sender As Object, e As EventArgs) Handles btnEntregadosCEDI.Click
        ReporteArticulosEntregadosCEDI.ImprimirArticulosEntregadosCEDI()
        ReporteArticulosEntregadosCEDI.ShowDialog()

    End Sub

    Private Sub btnReporteSabaneta_Click(sender As Object, e As EventArgs) Handles btnReporteSabaneta.Click
        ReporteArticulosEntregadosSabaneta.ImprimirArticulosEntregadosSabaneta()
        ReporteArticulosEntregadosSabaneta.ShowDialog()
    End Sub

    Private Sub btnEntregadosBarranquilla_Click(sender As Object, e As EventArgs) Handles btnEntregadosBarranquilla.Click
        ReporteArticulosEntregadosBarranquilla.ImprimirArticulosEntregadosBarranquilla()
        ReporteArticulosEntregadosBarranquilla.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnArticulosEntregadosAlquiler.Click
        ReporteArticulosEntregadosAlquiler.ImprimirArticulosEntregadosAlquiler()
        ReporteArticulosEntregadosAlquiler.ShowDialog()

    End Sub

    Private Sub btnArticulosEntregadosCompra_Click(sender As Object, e As EventArgs) Handles btnArticulosEntregadosCompra.Click
        ReporteArticulosEntregadosCompra.ImprimirArticulosEntregadosCompra()
        ReporteArticulosEntregadosCompra.ShowDialog()

    End Sub
End Class