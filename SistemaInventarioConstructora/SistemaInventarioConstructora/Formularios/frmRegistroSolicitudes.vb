Imports System.Data.SqlClient



Public Class frmRegistroSolicitudes
    Private tabla_tecnicos As New DataTable



    Private Sub frmRegistroSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        Tamañoformulario()
        LlenarDatos()
        dgvSolicitudes.AutoGenerateColumns = False
        Mostrar_Tecnicos()

        'cboDepartamento.SelectedIndex = -1

        'cboPuesto.SelectedIndex = -1

        btnBuscar.Enabled = True

        txtCodigoI.AutoCompleteMode = AutoCompleteMode.Suggest
        txtCodigoI.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCodigoI.AutoCompleteCustomSource = ObtenerCodigoInventario()

        txtNombreE.AutoCompleteMode = AutoCompleteMode.Suggest
        txtNombreE.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtNombreE.AutoCompleteCustomSource = ObtenerNombresInventario()
        LimpiarControles()



        dgvSolicitudes.AutoGenerateColumns = False

    End Sub


    Public Function Tecnico_Listar(activo As Integer) As DataTable

        Dim tabla As New DataTable
        Dim sql As String
        sql = " SELECT IdTecnico, NombreTecnico FROM Tecnicos"
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla

    End Function


    Private Sub Mostrar_Tecnicos()
        tabla_tecnicos = Tecnico_Listar(True)
        CboTecnico.DataSource = tabla_tecnicos
        CboTecnico.DisplayMember = "NombreTecnico"
        CboTecnico.ValueMember = "IdTecnico"


    End Sub


    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, Empleados.Nombre,  Departamentos.NombreD  , Articulos.IdArticulo,
           Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede, Solicitudes.FechaSolicitud , Solicitudes.EstadoSolicitud , Tecnicos.NombreTecnico, Solicitudes.Descripcion
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                          INNER JOIN Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo    
                          INNER JOIN Tecnicos ON  Solicitudes.IdTecnico = Tecnicos.IdTecnico
                      WHERE  Solicitudes.EstadoSolicitud <> 'Solucionada'"

        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvSolicitudes.DataSource = tabla
            lblTotalSolicitudes.Text = tabla.Rows.Count


        Catch ex As Exception

            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema Inventario")
        End Try

    End Sub


    Sub BuscarDatos()
        If rbNombreSolicitud.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
        End If

        adaptador = New SqlDataAdapter("SELECT CargoActivos.Idcargo, CargoActivos.CodigoInventario, 
                      Articulos.NombreA,  Articulos.IdArticulo, 
                      Empleados.Nombre, Empleados.Identidad,  Departamentos.NombreD,
                     Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede, Solicitudes.FechaSolicitud  , Tecnicos.NombreTecnico, Solicitudes.Descripcion
                    FROM Articulos INNER JOIN  CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo 
                                   INNER JOIN  Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                   INNER JOIN  Departamentos ON  Empleados.IdDepartamento = Departamentos.IdDepartamento
                                   INNER JOIN  Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo 
                                   INNER JOIN Tecnicos ON  Solicitudes.IdTecnico = Tecnicos.IdTecnico
                        WHERE  Solicitudes.NombreSolici LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSolicitudes.DataSource = tabla
                lblTotalSolicitudes.Text = tabla.Rows.Count
            Else
                dgvSolicitudes.DataSource = ""
            End If



        If rbDepartamento.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.Idcargo, CargoActivos.CodigoInventario, 
                      Articulos.NombreA,  Articulos.IdArticulo, 
                      Empleados.Nombre, Empleados.Identidad,  Departamentos.NombreD,
                     Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede, Solicitudes.FechaSolicitud  , Tecnicos.NombreTecnico, Solicitudes.Descripcion
                    FROM Articulos INNER JOIN  CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo 
                                   INNER JOIN  Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                   INNER JOIN  Departamentos ON  Empleados.IdDepartamento = Departamentos.IdDepartamento
                                   INNER JOIN  Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo 
                                   INNER JOIN Tecnicos ON  Solicitudes.IdTecnico = Tecnicos.IdTecnico
                  WHERE  Departamentos.NombreD LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSolicitudes.DataSource = tabla
                lblTotalSolicitudes.Text = tabla.Rows.Count
            Else
                dgvSolicitudes.DataSource = ""
            End If
        End If

        If rbSolicitante.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.Idcargo, CargoActivos.CodigoInventario, 
                      Articulos.NombreA,  Articulos.IdArticulo, 
                      Empleados.Nombre, Empleados.Identidad,  Departamentos.NombreD,
                     Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede, Solicitudes.FechaSolicitud  , Tecnicos.NombreTecnico, Solicitudes.Descripcion
                    FROM Articulos INNER JOIN  CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo 
                                   INNER JOIN  Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                   INNER JOIN  Departamentos ON  Empleados.IdDepartamento = Departamentos.IdDepartamento
                                   INNER JOIN  Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo
                                  INNER JOIN Tecnicos ON  Solicitudes.IdTecnico = Tecnicos.IdTecnico
                                  WHERE  Empleados.Nombre LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvSolicitudes.DataSource = tabla
                lblTotalSolicitudes.Text = tabla.Rows.Count
            Else
                dgvSolicitudes.DataSource = ""
            End If
        End If

        If rbTecnico.Checked Then
                If txtBuscar.Text = "" Then
                    LlenarDatos()
                End If
                adaptador = New SqlDataAdapter("SELECT CargoActivos.Idcargo, CargoActivos.CodigoInventario, 
                      Articulos.NombreA,  Articulos.IdArticulo, 
                      Empleados.Nombre, Empleados.Identidad,  Departamentos.NombreD,
                     Solicitudes.IdSolicitud, Solicitudes.NombreSolici, Solicitudes.Prioridad, Solicitudes.Sede, Solicitudes.FechaSolicitud  , Tecnicos.NombreTecnico, Solicitudes.Descripcion
                    FROM Articulos INNER JOIN  CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo 
                                   INNER JOIN  Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                   INNER JOIN  Departamentos ON  Empleados.IdDepartamento = Departamentos.IdDepartamento
                                   INNER JOIN  Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo 
                                   INNER JOIN Tecnicos ON  Solicitudes.IdTecnico = Tecnicos.IdTecnico
                  WHERE  Solicitudes.NombreTecni LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
                tabla.Clear()
                adaptador.Fill(tabla)
                If tabla.Rows.Count > 0 Then
                    dgvSolicitudes.DataSource = tabla
                    lblTotalSolicitudes.Text = tabla.Rows.Count
                Else
                    dgvSolicitudes.DataSource = ""
                End If
            End If


                                    
    End Sub

    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False



        txtId.Enabled = False
        cboSolicitud.Enabled = False
        cboPrioridad.Enabled = False

        txtDepartamento.Enabled = False



        txtCodigoI.Enabled = False
        txtNombreA.Enabled = False
        btnCargos.Enabled = False
        txtNombreA.Enabled = False

        txtNombreE.Enabled = False
        txtDepartamento.Enabled = False

        cboSede.Enabled = False
        DTPFechaSolicitud.Enabled = False
        CboTecnico.Enabled = False




        txtDescripcion.Enabled = False



        btnNuevo.Enabled = True
    End Sub

    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True



        txtId.Enabled = True
        cboSolicitud.Enabled = True
        cboPrioridad.Enabled = True

        txtDepartamento.Enabled = True



        txtCodigoI.Enabled = True
        txtNombreA.Enabled = True
        btnCargos.Enabled = True

        txtNombreE.Enabled = True
        txtDepartamento.Enabled = True

        cboSede.Enabled = True
        DTPFechaSolicitud.Enabled = True

        CboTecnico.Enabled = True


        txtDescripcion.Enabled = True



        btnNuevo.Enabled = False
    End Sub

    Sub LimpiarControles()

        txtId.Text = ""
        cboSolicitud.Text = ""
        cboPrioridad.Text = ""
        txtCodigoI.Text = ""
        txtNombreA.Text = ""
        txtIdArticulo.Text = ""

        txtNombreE.Text = ""
        txtDepartamento.Text = ""

        txtIdCargo.Text = ""
        cboSede.Text = ""
        DTPFechaSolicitud.Text = ""
        CboTecnico.Text = ""

        txtDescripcion.Text = ""


        txtBuscar.Text = ""

    End Sub

    Sub Tamañoformulario()
        Width = 1150
        Height = 393
        Panel1.Visible = False
    End Sub


    Sub TamañoformularioBuscar()
        Width = 1150
        Height = 972
        Panel1.Visible = True
        txtBuscar.Focus()
        txtBuscar.BackColor = Color.YellowGreen
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

    Private Function ObtenerNombresInventario() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT  Nombre FROM  Empleados
                                             INNER JOIN CargoActivos ON  Empleados.IdEmpleado = CargoActivos.IdEmpleado      ", obtenerconexion)
        Dim dt As New DataTable("Empleados")
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
                               INNER JOIN Solicitudes ON CargoActivos.IdCargo = Solicitudes.IdCargoActivo  
                            Where CargoActivos.CodigoInventario =  '" & txtCodigoI.Text & "' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        'If tabla.Rows.Count > 0 Then
        '    txtCodigoI.Text = tabla.Rows(0).Item("CodigoInventario")
        '    MsgBox("El registro ya existe en la base de datos", vbInformation, " Sistema inventario")
        '    Exit Sub

        'End If

        If txtIdArticulo.Text = "" Or txtIdCargo.Text = "" Or cboSolicitud.Text = "" Or txtNombreE.Text = "" Then
            MsgBox("Existen campos vacios", vbInformation, " Sistema inventario")
            Exit Sub

        Else
            sql = "INSERT INTO Solicitudes(NombreSolici, Prioridad, Sede, FechaSolicitud,IdTecnico,   Descripcion, IdCargoActivo, EstadoSolicitud)
                      VALUES ('" & cboSolicitud.Text.Trim() & "','" & cboPrioridad.Text.Trim() & "',
                          '" & cboSede.Text.Trim() & "','" & DTPFechaSolicitud.Text & "',  '" & Trim(CboTecnico.SelectedValue) & "', '" & txtDescripcion.Text & "', '" & txtIdCargo.Text & "' , 'PENDIENTE'         ) "

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
            sql = "UPDATE Solicitudes SET  NombreSolici = '" & cboSolicitud.Text & " ',Prioridad = '" & cboPrioridad.Text.Trim() & "', Sede =  '" & cboSede.Text.Trim() & "',
                                       FechaSolicitud = '" & DTPFechaSolicitud.Text & "', IdTecnico = '" & Trim(CboTecnico.SelectedValue) & "',
                                       Descripcion = '" & txtDescripcion.Text & "',   IdCargoActivo =  '" & txtIdCargo.Text & "'
                                        WHERE IdSolicitud = '" & txtId.Text & "'          "
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
            If MsgBox("Seguro en Eliminar la Solicitud  " + Trim(cboSolicitud.Text) + " De Su Registro de Asignación? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM Solicitudes WHERE IdSolicitud = " & Trim(txtId.Text)

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
        btnBuscar.Enabled = True
        cboSolicitud.Focus()

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

    Private Sub btnCrearSolicitante_Click(sender As Object, e As EventArgs)
        frmSolicitantes.ShowDialog()

    End Sub

    Private Sub btnBusquedaSolicitante_Click(sender As Object, e As EventArgs)
        frmBusquedaSolicitantes.ShowDialog()

    End Sub

    Private Sub btnCargos_Click(sender As Object, e As EventArgs) Handles btnCargos.Click
        frmBusquedaActivosFijosSolicitudes.ShowDialog()

    End Sub

    Private Sub txtCodigoI_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoI.TextChanged
        If txtCodigoI.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, Articulos.IdArticulo, Articulos.NombreA,    
                            Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD
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

                txtNombreE.Text = fila("Nombre").ToString
                txtDepartamento.Text = fila("NombreD").ToString
                txtIdCargo.Text = fila("IdCargo").ToString





            Else
                txtNombreA.Clear()


                txtCodigoI.Focus()
                txtIdArticulo.Clear()

                txtNombreE.Clear()
                txtDepartamento.Clear()

                txtIdCargo.Clear()

            End If

        End If
    End Sub

    Private Sub btnBuscarTecnico_Click(sender As Object, e As EventArgs)
        frmTecnicos.ShowDialog()

    End Sub

    Private Sub txtNombreE_TextChanged(sender As Object, e As EventArgs) Handles txtNombreE.TextChanged
        If txtNombreE.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo,CargoActivos.CodigoInventario, Articulos.IdArticulo, Articulos.NombreA,    
                            Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD
                FROM  Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo  = CargoActivos.IdArticulo
                                INNER JOIN Empleados ON  CargoActivos.IdEmpleado = Empleados.IdEmpleado   
                                INNER JOIN Departamentos ON  Empleados.IdDepartamento = Departamentos.IdDepartamento 
                         WHERE Empleados.Nombre = '" & txtNombreE.Text & "'  ", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                txtNombreA.Text = fila("NombreA").ToString

                txtIdArticulo.Text = fila("IdArticulo").ToString

                txtNombreE.Text = fila("Nombre").ToString
                txtDepartamento.Text = fila("NombreD").ToString
                txtIdCargo.Text = fila("IdCargo").ToString
                txtCodigoI.Text = fila("CodigoInventario")




            Else
                txtNombreA.Clear()


                txtNombreE.Focus()
                txtIdArticulo.Clear()

                txtCodigoI.Clear()
                txtDepartamento.Clear()

                txtIdCargo.Clear()

            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmBusquedaActivosFijosSolicitudes.ShowDialog()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
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

    Private Sub dgvSolicitudes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSolicitudes.CellDoubleClick
        On Error Resume Next

        cboSolicitud.Text = CStr(dgvSolicitudes.Item("NombreSolici", dgvSolicitudes.CurrentCell.RowIndex).Value)
        txtIdArticulo.Text = CStr(dgvSolicitudes.Item("IdArticulo", dgvSolicitudes.CurrentCell.RowIndex).Value)
        txtNombreA.Text = CStr(dgvSolicitudes.Item("NombreA", dgvSolicitudes.CurrentCell.RowIndex).Value)
        txtCodigoI.Text = CStr(dgvSolicitudes.Item("CodigoInventario", dgvSolicitudes.CurrentCell.RowIndex).Value)
        cboPrioridad.Text = CStr(dgvSolicitudes.Item("Prioridad", dgvSolicitudes.CurrentCell.RowIndex).Value)

        txtIdCargo.Text = CStr(dgvSolicitudes.Item("IdCargo", dgvSolicitudes.CurrentCell.RowIndex).Value)
        txtNombreE.Text = CStr(dgvSolicitudes.Item("Nombre", dgvSolicitudes.CurrentCell.RowIndex).Value)

        txtDepartamento.Text = CStr(dgvSolicitudes.Item("NombreD", dgvSolicitudes.CurrentCell.RowIndex).Value)

        txtId.Text = CStr(dgvSolicitudes.Item("IdSolicitud", dgvSolicitudes.CurrentCell.RowIndex).Value)
        cboSede.Text = CStr(dgvSolicitudes.Item("Sede", dgvSolicitudes.CurrentCell.RowIndex).Value)
        DTPFechaSolicitud.Text = CStr(dgvSolicitudes.Item("FechaSolicitud", dgvSolicitudes.CurrentCell.RowIndex).Value)
        CboTecnico.Text = CStr(dgvSolicitudes.Item("NombreTecnico", dgvSolicitudes.CurrentCell.RowIndex).Value)
        txtCodigoI.Text = CStr(dgvSolicitudes.Item("CodigoInventario", dgvSolicitudes.CurrentCell.RowIndex).Value)
        txtDescripcion.Text = CStr(dgvSolicitudes.Item("Descripcion", dgvSolicitudes.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False

        btnCargos.Enabled = True


        txtCodigoI.Enabled = True
        cboSolicitud.Enabled = True
        txtDescripcion.Enabled = True
        cboPrioridad.Enabled = True
        CboTecnico.Enabled = True
        txtNombreE.Enabled = True
        cboSede.Enabled = True
        DTPFechaSolicitud.Enabled = True



        txtNombreA.Focus()
    End Sub

    Private Sub btnSolicitudesPendientes_Click(sender As Object, e As EventArgs) Handles btnSolicitudesPendientes.Click
        ReporteSolicitudesPendientes.ImprimirSolicitudesPendientes()
        ReporteSolicitudesPendientes.ShowDialog()

    End Sub

    Private Sub btnReporteTotalSolicitudes_Click(sender As Object, e As EventArgs) Handles btnReporteTotalSolicitudes.Click
        ReporteTotalSolicitudes.ImprimirTotalSolicitudes()
        ReporteTotalSolicitudes.ShowDialog()

    End Sub
End Class