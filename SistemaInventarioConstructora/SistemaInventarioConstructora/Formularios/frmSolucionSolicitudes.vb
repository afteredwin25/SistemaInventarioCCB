Imports System.Data.SqlClient



Public Class frmSolucionSolicitudes

    Private tabla_tecnicos As New DataTable


    Private Sub frmSolucionSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        Tamañoformulario()
        LlenarDatos()
        dgvSoluciones.AutoGenerateColumns = False


        'cboDepartamento.SelectedIndex = -1

        'cboPuesto.SelectedIndex = -1

        btnBuscar.Enabled = True

        txtSolicitud.AutoCompleteMode = AutoCompleteMode.Suggest
        txtSolicitud.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtSolicitud.AutoCompleteCustomSource = ObtenerSolicitudes()


        LimpiarControles()



        dgvSoluciones.AutoGenerateColumns = False

        Mostrar_tecnicos()
        CboTecnicoSolucion.SelectedIndex = -1

    End Sub
    Public Function Tecnico_Listar(activo As Integer) As DataTable

        Dim tabla As New DataTable
        Dim sql As String
        sql = " SELECT IdTecnico, NombreTecnico FROM TecnicosSoluciones"
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla

    End Function


    Private Sub Mostrar_Tecnicos()
        tabla_tecnicos = Tecnico_Listar(True)
        CboTecnicoSolucion.DataSource = tabla_tecnicos
        CboTecnicoSolucion.DisplayMember = "NombreTecnico"
        CboTecnicoSolucion.ValueMember = "IdTecnico"


    End Sub

    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False



        txtSolicitud.Enabled = False
        btnBuscarSolucion.Enabled = False
        txtPrioridad.Enabled = False
        txtIdSolicitud.Enabled = False
        btnBuscarSolucion.Enabled = False
        txtNombreEmpleado.Enabled = False
        txtDepartamento.Enabled = False
        DTPFechaSolicitud.Enabled = False
        txtNombreA.Enabled = False
        txtSede.Enabled = False
        txtIdCargo.Enabled = False
        'txtIdTecnico.Enabled = False
        txtSolucion.Enabled = False
        CboTecnicoSolucion.Enabled = False
        btnBuscarTecnico.Enabled = False
        DTPFechaSolucion.Enabled = False
        cboEstado.Enabled = False
        txtDescripcion.Enabled = False
        txtTecnicoAsignado.Enabled = False
        txtDescripcionSolicitud.Enabled = False


        btnNuevo.Enabled = True
    End Sub

    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True



        txtSolicitud.Enabled = True
        btnBuscarSolucion.Enabled = True
        txtPrioridad.Enabled = True
        txtIdSolicitud.Enabled = True
        btnBuscarSolucion.Enabled = True
        txtNombreEmpleado.Enabled = True
        txtDepartamento.Enabled = True

        txtNombreA.Enabled = True
        txtSede.Enabled = True
        txtIdCargo.Enabled = True
        'txtIdTecnico.Enabled = True
        txtSolucion.Enabled = True
        CboTecnicoSolucion.Enabled = True
        btnBuscarTecnico.Enabled = True
        DTPFechaSolucion.Enabled = True
        cboEstado.Enabled = True
        txtDescripcion.Enabled = True
        txtTecnicoAsignado.Enabled = True


        btnNuevo.Enabled = False
    End Sub

    Sub LimpiarControles()

        txtId.Text = ""
        txtSolicitud.Text = ""
        txtPrioridad.Text = ""
        txtIdSolicitud.Text = ""
        txtNombreA.Text = ""
        btnBuscarSolucion.Text = ""
        txtNombreEmpleado.Text = ""
        txtDepartamento.Text = ""
        DTPFechaSolicitud.Text = ""
        txtNombreA.Text = ""
        txtSede.Text = ""
        txtIdCargo.Text = ""
        'txtIdTecnico.Text = ""
        txtSolucion.Text = ""
        CboTecnicoSolucion.Text = ""
        DTPFechaSolucion.Text = ""
        cboEstado.Text = ""
        txtTecnicoAsignado.Text = ""
        txtDescripcionSolicitud.Text = ""

        txtDescripcion.Text = ""


        txtBuscar.Text = ""

    End Sub

    Sub Tamañoformulario()
        Width = 1150
        Height = 534
        Panel1.Visible = False
    End Sub


    Sub TamañoformularioBuscar()
        Width = 1127
        Height = 1148
        Panel1.Visible = True
        txtBuscar.Focus()
        txtBuscar.BackColor = Color.YellowGreen
    End Sub

    Private Function ObtenerSolicitudes() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT  NombreSolici FROM  Solicitudes  WHERE  EstadoSolicitud = 'Pendiente'    ", obtenerconexion)
        Dim dt As New DataTable("Solicitudes")
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
        adaptador = New SqlDataAdapter("SELECT Solicitudes.NombreSolici FROM Solicitudes
                               INNER JOIN SolucionSolicitudes ON Solicitudes.IdSolicitud = SolucionSolicitudes.IdSolucion  
                            Where Solicitudes.NombreSolici =  '" & txtIdSolicitud.Text & "' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        'If tabla.Rows.Count > 0 Then
        '    txtCodigoI.Text = tabla.Rows(0).Item("CodigoInventario")
        '    MsgBox("El registro ya existe en la base de datos", vbInformation, " Sistema inventario")
        '    Exit Sub

        'End If

        If txtIdSolicitud.Text = "" Or txtIdArticulo.Text = "" Or txtIdCargo.Text = "" Or txtSolicitud.Text = "" Or txtSolucion.Text = "" Or cboEstado.Text = "" Then
            MsgBox("Existen campos vacios", vbInformation, " Sistema inventario")
            Exit Sub

        Else
            sql = "INSERT INTO SolucionSolicitudes(NombreSolucion, FechaSolucion, Descripcion, EstadoSolucion, IdSolicitud, IdTecnico)
                      VALUES ('" & txtSolucion.Text.Trim() & "',  '" & DTPFechaSolucion.Text.Trim() & "', '" & txtDescripcion.Text.Trim() & "', '" & cboEstado.Text.Trim() & "',
                          '" & txtIdSolicitud.Text.Trim() & "',  '" & Trim(CboTecnicoSolucion.SelectedValue) & "'       ) "

            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            ModificarSolicitud()

            MsgBox("Registro realizado existosamente", vbInformation, " Sistema inventario")
        End If


    End Sub

    Sub ModificarSolicitud()
        Dim id As Integer

        Dim sql As String
        sql = "UPDATE Solicitudes SET  EstadoSolicitud = '" & cboEstado.Text & "',  DescripcionSolucion =  '" & txtDescripcion.Text & "'
                                        WHERE IdSolicitud = '" & txtIdSolicitud.Text & "'          "
        Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()



    End Sub

    Sub ModificarSolicitudEliminada()
        Dim id As Integer

        Dim sql As String
        sql = "UPDATE Solicitudes SET  EstadoSolicitud = 'Pendiente'
                                        WHERE IdSolicitud = '" & txtIdSolicitud.Text & "'          "
        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()



    End Sub

    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE SolucionSolicitudes SET  NombreSolucion = '" & txtSolucion.Text & " ', FechaSolucion = '" & DTPFechaSolucion.Text & "',
                                    Descripcion = '" & txtDescripcion.Text & "',   EstadoSolucion = '" & cboEstado.Text.Trim() & "', IdSolicitud =  '" & txtIdSolicitud.Text.Trim() & "',
                                        IdTecnico = '" & Trim(CboTecnicoSolucion.SelectedValue) & "'
                                        
                                        WHERE IdSolucion = '" & txtId.Text & "'          "
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            ModificarSolicitud()
            MsgBox("Registro editado exitosamente ", vbInformation, "Sistema de Inventario")
            LimpiarControles()
        End If

    End Sub
    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo,  Articulos.NombreA, Empleados.Nombre,  Departamentos.NombreD  , Articulos.IdArticulo,
           Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede,   TecnicosSoluciones.NombreTecnico, SolucionSolicitudes.NombreSolucion, SolucionSolicitudes.IdSolucion,
            SolucionSolicitudes.FechaSolucion, SolucionSolicitudes.EstadoSolucion, SolucionSolicitudes.Descripcion
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                          INNER JOIN Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo    
                          INNER JOIN TecnicosSoluciones ON  Solicitudes.IdTecnico = TecnicosSoluciones.IdTecnico
                          INNER JOIN SolucionSolicitudes ON Solicitudes.IdSolicitud = SolucionSolicitudes.IdSolicitud    "

        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvSoluciones.DataSource = tabla
            lblTotalSoluciones.Text = tabla.Rows.Count


        Catch ex As Exception

            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema Inventario")
        End Try

    End Sub


    Sub BuscarDatos()
        If rbNombreSolicitud.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo,  Articulos.NombreA, Empleados.Nombre,  Departamentos.NombreD  , Articulos.IdArticulo,
           Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede,   TecnicosSoluciones.NombreTecnico, SolucionSolicitudes.NombreSolucion, SolucionSolicitudes.IdSolucion,
            SolucionSolicitudes.FechaSolucion, SolucionSolicitudes.EstadoSolucion, SolucionSolicitudes.Descripcion
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                          INNER JOIN Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo    
                          INNER JOIN TecnicosSoluciones ON  Solicitudes.IdTecnico = TecnicosSoluciones.IdTecnico
                          INNER JOIN SolucionSolicitudes ON Solicitudes.IdSolicitud = SolucionSolicitudes.IdSolicitud
                        WHERE  Solicitudes.NombreSolici LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSoluciones.DataSource = tabla
                lblTotalSoluciones.Text = tabla.Rows.Count
            Else
                dgvSoluciones.DataSource = ""
            End If


        End If
        If rbDepartamento.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo,  Articulos.NombreA, Empleados.Nombre,  Departamentos.NombreD  , Articulos.IdArticulo,
           Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede,   TecnicosSoluciones.NombreTecnico, SolucionSolicitudes.NombreSolucion, SolucionSolicitudes.IdSolucion,
            SolucionSolicitudes.FechaSolucion, SolucionSolicitudes.EstadoSolucion, SolucionSolicitudes.Descripcion
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                          INNER JOIN Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo    
                          INNER JOIN TecnicosSoluciones ON  Solicitudes.IdTecnico = TecnicosSoluciones.IdTecnico
                          INNER JOIN SolucionSolicitudes ON Solicitudes.IdSolicitud = SolucionSolicitudes.IdSolicitud
                  WHERE  Departamentos.NombreD LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSoluciones.DataSource = tabla
                lblTotalSoluciones.Text = tabla.Rows.Count
            Else
                dgvSoluciones.DataSource = ""
            End If
        End If

        If rbSolicitante.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo,  Articulos.NombreA, Empleados.Nombre,  Departamentos.NombreD  , Articulos.IdArticulo,
           Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede,   TecnicosSoluciones.NombreTecnico, SolucionSolicitudes.NombreSolucion, SolucionSolicitudes.IdSolucion,
            SolucionSolicitudes.FechaSolucion, SolucionSolicitudes.EstadoSolucion, SolucionSolicitudes.Descripcion
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                          INNER JOIN Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo    
                          INNER JOIN TecnicosSoluciones ON  Solicitudes.IdTecnico = TecnicosSoluciones.IdTecnico
                          INNER JOIN SolucionSolicitudes ON Solicitudes.IdSolicitud = SolucionSolicitudes.IdSolicitud
                                  WHERE  Empleados.Nombre LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSoluciones.DataSource = tabla
                lblTotalSoluciones.Text = tabla.Rows.Count
            Else
                dgvSoluciones.DataSource = ""
            End If
        End If

        If rbTecnico.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo,  Articulos.NombreA, Empleados.Nombre,  Departamentos.NombreD  , Articulos.IdArticulo,
           Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede,   TecnicosSoluciones.NombreTecnico, SolucionSolicitudes.NombreSolucion, SolucionSolicitudes.IdSolucion,
            SolucionSolicitudes.FechaSolucion, SolucionSolicitudes.EstadoSolucion, SolucionSolicitudes.Descripcion
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                          INNER JOIN Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo    
                          INNER JOIN TecnicosSoluciones ON  Solicitudes.IdTecnico = TecnicosSoluciones.IdTecnico
                          INNER JOIN SolucionSolicitudes ON Solicitudes.IdSolicitud = SolucionSolicitudes.IdSolicitud
                  WHERE  TecnicosSoluciones.NombreTecnico LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSoluciones.DataSource = tabla
                lblTotalSoluciones.Text = tabla.Rows.Count
            Else
                dgvSoluciones.DataSource = ""
            End If
        End If



    End Sub


    Sub Eliminar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            If MsgBox("Seguro en Eliminar la Solución  " + Trim(txtSolucion.Text) + " De Su Registro de Asignación? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM SolucionSolicitudes WHERE IdSolucion = " & Trim(txtId.Text)

                Dim conect As New SqlConnection(obtenerconexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()
                End Using
                conect.Close()
                ModificarSolicitudEliminada()


                MsgBox("Registro Eliminado Exitosamente ", vbInformation, "Sistema de Inventario")
                LimpiarControles()
            End If

        End If


    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call ActivarControles()
        LimpiarControles()
        btnBuscar.Enabled = True
        txtSolicitud.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        insertar()
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
        Tamañoformulario()
        Call DesactivarControles()
        LimpiarControles()
        btnBuscar.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        TamañoformularioBuscar()
        btnCancelar.Enabled = True
        btnBuscar.Enabled = False
        txtBuscar.Focus()
        LlenarDatos()
    End Sub


    Private Sub txtSolicitud_TextChanged(sender As Object, e As EventArgs) Handles txtSolicitud.TextChanged
        If txtSolicitud.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, Articulos.IdArticulo, Articulos.NombreA,    
                            Empleados.Nombre,  Departamentos.NombreD, Solicitudes.IdSolicitud, Solicitudes.NombreSolici, 
                              Solicitudes.Prioridad, Solicitudes.Sede, Solicitudes.FechaSolicitud, Solicitudes.Descripcion,Tecnicos.NombreTecnico
                FROM  Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo  = CargoActivos.IdArticulo
                                INNER JOIN Empleados ON  CargoActivos.IdEmpleado = Empleados.IdEmpleado   
                                INNER JOIN Departamentos ON  Empleados.IdDepartamento = Departamentos.IdDepartamento 
                                INNER JOIN Solicitudes ON  CargoActivos.IdCargo = Solicitudes.IdCargoActivo
                                INNER JOIN Tecnicos ON Solicitudes.IdTecnico = Tecnicos.IdTecnico
                         WHERE Solicitudes.NombreSolici = '" & txtSolicitud.Text & "'  ", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                txtPrioridad.Text = fila("Prioridad").ToString
                txtNombreEmpleado.Text = fila("Nombre").ToString
                txtDepartamento.Text = fila("NombreD").ToString
                DTPFechaSolicitud.Value = fila("FechaSolicitud").ToString
                txtDescripcionSolicitud.Text = fila("Descripcion").ToString
                txtNombreA.Text = fila("NombreA").ToString
                txtSede.Text = fila("Sede").ToString
                txtTecnicoAsignado.Text = fila("NombreTecnico").ToString
                txtIdArticulo.Text = fila("IdArticulo").ToString
                txtIdCargo.Text = fila("IdCargo").ToString
                txtIdSolicitud.Text = fila("IdSolicitud").ToString





            Else
                txtNombreA.Clear()
                txtPrioridad.Clear()
                txtNombreEmpleado.Clear()
                txtDepartamento.Clear()
                txtSede.Clear()
                txtTecnicoAsignado.Clear()
                txtIdArticulo.Clear()
                txtIdCargo.Clear()
                txtIdSolicitud.Clear()
                DTPFechaSolicitud.Text = ""





            End If

        End If
    End Sub

    Private Sub btnBuscarSolucion_Click(sender As Object, e As EventArgs) Handles btnBuscarSolucion.Click
        frmBusquedaSolicitudes.ShowDialog()

    End Sub

    Private Sub btnBuscarTecnico_Click(sender As Object, e As EventArgs) Handles btnBuscarTecnico.Click
        frmTecnicos.ShowDialog()

    End Sub

    Private Sub rbNombreSolicitud_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreSolicitud.CheckedChanged
        txtBuscar.Focus()

    End Sub

    Private Sub rbDepartamento_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepartamento.CheckedChanged
        txtBuscar.Focus()

    End Sub

    Private Sub rbSolicitante_CheckedChanged(sender As Object, e As EventArgs) Handles rbSolicitante.CheckedChanged
        txtBuscar.Focus()

    End Sub

    Private Sub rbTecnico_CheckedChanged(sender As Object, e As EventArgs) Handles rbTecnico.CheckedChanged
        txtBuscar.Focus()

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
    End Sub

    Private Sub dgvSoluciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSoluciones.CellDoubleClick
        On Error Resume Next

        txtId.Text = CStr(dgvSoluciones.Item("IdSolucion", dgvSoluciones.CurrentCell.RowIndex).Value)

        txtSolicitud.Text = CStr(dgvSoluciones.Item("NombreSolici", dgvSoluciones.CurrentCell.RowIndex).Value)
        txtIdArticulo.Text = CStr(dgvSoluciones.Item("IdArticulo", dgvSoluciones.CurrentCell.RowIndex).Value)
        txtNombreA.Text = CStr(dgvSoluciones.Item("NombreA", dgvSoluciones.CurrentCell.RowIndex).Value)
        txtSolucion.Text = CStr(dgvSoluciones.Item("NombreSolucion", dgvSoluciones.CurrentCell.RowIndex).Value)
        CboTecnicoSolucion.Text = CStr(dgvSoluciones.Item("NombreTecnico", dgvSoluciones.CurrentCell.RowIndex).Value)
        cboEstado.Text = CStr(dgvSoluciones.Item("EstadoSolucion", dgvSoluciones.CurrentCell.RowIndex).Value)
        DTPFechaSolucion.Text = CStr(dgvSoluciones.Item("FechaSolucion", dgvSoluciones.CurrentCell.RowIndex).Value)
        'txtCodigoI.Text = CStr(dgvSoluciones.Item("CodigoInventario", dgvSoluciones.CurrentCell.RowIndex).Value)


        'txtIdCargo.Text = CStr(dgvSoluciones.Item("IdCargo", dgvSoluciones.CurrentCell.RowIndex).Value)
        'txtNombreE.Text = CStr(dgvSoluciones.Item("Nombre", dgvSoluciones.CurrentCell.RowIndex).Value)

        'txtDepartamento.Text = CStr(dgvSoluciones.Item("NombreD", dgvSoluciones.CurrentCell.RowIndex).Value)

        'txtId.Text = CStr(dgvSoluciones.Item("IdSolicitud", dgvSoluciones.CurrentCell.RowIndex).Value)
        'cboSede.Text = CStr(dgvSoluciones.Item("Sede", dgvSoluciones.CurrentCell.RowIndex).Value)

        'CboTecnico.Text = CStr(dgvSoluciones.Item("NombreTecnico", dgvSoluciones.CurrentCell.RowIndex).Value)

        txtDescripcion.Text = CStr(dgvSoluciones.Item("Descripcion", dgvSoluciones.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False

        btnBuscarSolucion.Enabled = True

        btnBuscarTecnico.Enabled = True

        txtSolicitud.Enabled = True
        txtSolucion.Enabled = True
        txtIdSolicitud.Enabled = True
        txtIdCargo.Enabled = True

        CboTecnicoSolucion.Enabled = True
        cboEstado.Enabled = True
        DTPFechaSolicitud.Enabled = False
        DTPFechaSolucion.Enabled = True
        txtDescripcion.Enabled = True
        'txtCodigoI.Enabled = True
        'cboSolicitud.Enabled = True
        'txtDescripcion.Enabled = True
        'cboPrioridad.Enabled = True
        'CboTecnico.Enabled = True
        'txtNombreE.Enabled = True
        'cboSede.Enabled = True
        DTPFechaSolicitud.Enabled = True



        txtSolicitud.Focus()
    End Sub

    Private Sub btnInformeSoluciones_Click(sender As Object, e As EventArgs) Handles btnInformeSoluciones.Click
        ReporteSolicitudesSolucionadas.ImprimirTotalSolicitudesSolucionadas()
        ReporteSolicitudesSolucionadas.ShowDialog()

    End Sub

    Private Sub btnSolicitudesPendientes_Click(sender As Object, e As EventArgs) Handles btnSolicitudesPendientes.Click
        ReporteSolicitudesPendientes.ImprimirSolicitudesPendientes()
        ReporteSolicitudesPendientes.ShowDialog()


    End Sub
End Class