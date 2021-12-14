Imports System.Data.SqlClient


Public Class frmActivosInformacion

    Private tabla_tipoActivo As New DataTable
    Private tabla_departamentos As New DataTable
    Private tabla_puestos As New DataTable
    Private tabla_empleados As New DataTable

    Private Sub frmActivosInformacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Call DesactivarControles()
        TamañoFormulario()
        LlenarDatos()
        dgvActivosInf.AutoGenerateColumns = False
        Mostrar_Tipo()
        cboTipo.SelectedIndex = -1

        Mostrar_Departamentos()
        cboProceso.SelectedIndex = -1

        Mostrar_Puestos()
        cboPropCargo.SelectedIndex = -1
    End Sub





    Public Function TipoActivos_Listar(activo As Integer) As DataTable

        Dim tabla As New DataTable
        Dim sql As String
        sql = " SELECT IdTipo, NombreT FROM TipoActivo"
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla
    End Function




    Private Sub Mostrar_Tipo()
        tabla_tipoActivo = TipoActivos_Listar(True)
        cboTipo.DataSource = tabla_tipoActivo
        cboTipo.DisplayMember = "NombreT"
        cboTipo.ValueMember = "IdTipo"


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
        cboProceso.DataSource = tabla_departamentos
        cboProceso.DisplayMember = "NombreD"
        cboProceso.ValueMember = "IdDepartamento"


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
        cboPropCargo.DataSource = tabla_puestos
        cboPropCargo.DisplayMember = "NombreP"
        cboPropCargo.ValueMember = "IdPuesto"


    End Sub



    Public Function Empleados_Listar(activo As Integer) As DataTable

        Dim tabla As New DataTable
        Dim sql As String
        sql = " SELECT IdEmpleado, NombreE FROM Empleados"
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla
    End Function

    Private Sub Mostrar_Empleados()
        tabla_empleados = Empleados_Listar(True)
        cboPropCargo.DataSource = tabla_empleados
        cboPropCargo.DisplayMember = "Nombre"
        cboPropCargo.ValueMember = "IdPuesto"


    End Sub


    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnProceso.Enabled = False


        txtIdentificador.Enabled = False
        cboProceso.Enabled = False
        txtNombreActivoInf.Enabled = False
        cboTipo.Enabled = False
        cboUbicacion.Enabled = False
        txtRuta.Enabled = False
        txtJustificación.Enabled = False
        txtPropietario.Enabled = False
        btnEmpleado.Enabled = False
        DTPFechaIngreso.Enabled = False
        DTPFechaSalida.Enabled = False
        cboConfidencialidad.Enabled = False
        cboIntegridad.Enabled = False
        cboDisponibilidad.Enabled = False
        txtElaborado.Enabled = False
        btnEmpleado2.Enabled = False
        txtAprobado.Enabled = False
        btnEmpleado3.Enabled = False
        cboPropCargo.Enabled = False
        btnPuesto.Enabled = False
        txtRevisado.Enabled = False
        DTPFechaValidacion.Enabled = False
        btnPropietario.Enabled = False
        btnTipo.Enabled = False
        btnElaborado.Enabled = False
        btnAprobado.Enabled = False
        btnRevisadoBusque.Enabled = False
        btnRevisado.Enabled = False


        txtDescripcion.Enabled = False



        btnNuevo.Enabled = True
    End Sub

    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True



        btnProceso.Enabled = True


        txtIdentificador.Enabled = True
        cboProceso.Enabled = True
        txtNombreActivoInf.Enabled = True
        cboTipo.Enabled = True
        cboUbicacion.Enabled = True
        txtRuta.Enabled = True
        txtJustificación.Enabled = True
        txtPropietario.Enabled = True
        btnEmpleado.Enabled = True
        DTPFechaIngreso.Enabled = True
        DTPFechaSalida.Enabled = True
        cboConfidencialidad.Enabled = True
        cboIntegridad.Enabled = True
        cboDisponibilidad.Enabled = True
        txtElaborado.Enabled = True
        btnEmpleado2.Enabled = True
        txtAprobado.Enabled = True
        btnEmpleado3.Enabled = True
        cboPropCargo.Enabled = True
        btnPuesto.Enabled = True
        txtRevisado.Enabled = True
        DTPFechaValidacion.Enabled = True
        btnPropietario.Enabled = True
        btnTipo.Enabled = True
        btnElaborado.Enabled = True
        btnAprobado.Enabled = True
        btnRevisadoBusque.Enabled = True
        btnRevisado.Enabled = True


        txtDescripcion.Enabled = True

    End Sub

    Sub LimpiarControles()

        txtIdentificador.Text = ""
        cboProceso.Text = ""
        txtNombreActivoInf.Text = ""
        cboTipo.Text = ""
        cboUbicacion.Text = ""
        txtRuta.Text = ""
        txtJustificación.Text = ""
        txtPropietario.Text = ""

        DTPFechaIngreso.Text = ""
        DTPFechaSalida.Text = ""
        cboConfidencialidad.Text = ""
        cboIntegridad.Text = ""
        cboDisponibilidad.Text = ""
        txtElaborado.Text = ""
        btnEmpleado2.Text = ""
        txtAprobado.Text = ""

        cboPropCargo.Text = ""

        txtRevisado.Text = ""
        DTPFechaValidacion.Text = ""


        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub


    Sub TamañoFormulario()
        Width = 1387
        Height = 513
        Panel1.Visible = False

    End Sub


    Sub TamañoFormularioBuscar()
        Width = 1387
        Height = 990
        Panel1.Visible = True
        txtBuscar.BackColor = Color.YellowGreen
    End Sub

    Sub insertar()
        Dim sql As String
        Dim id As Integer

        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM ActivosInformacion Where IdentificadorActivo =  '" & txtIdentificador.Text & "'   ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtIdentificador.Text = tabla.Rows(0).Item("Identificador")
            MsgBox("El registro ya existe en la base de datos", vbInformation, " Sistema inventario")
            Exit Sub

        End If

        If txtNombreActivoInf.Text = "" Or txtIdentificador.Text = "" Then
            MsgBox("Existen campos vacios", vbInformation, " Sistema inventario")
            Exit Sub

        Else
            sql = "INSERT INTO ActivosInformacion(IdentificadorActivo, NombreActivo, Descripcion, Ubicacion,Ruta,  ClasiConfi,ClasiInteg, ClasiDispon, JustificacionActivo,
           FechaIngreso, FechaSalida,  FechaValidacion,IdPropietario,IdElaborado, IdAprobado,IdRevisado, IdTipo, IdDepartamento, IdPuesto)
         VALUES ('" & txtIdentificador.Text & "','" & txtNombreActivoInf.Text & "','" & txtDescripcion.Text & "',
            '" & Trim(cboUbicacion.Text) & "','" & txtRuta.Text & "', 
          '" & Trim(cboConfidencialidad.Text) & "', '" & Trim(cboIntegridad.Text) & "',    '" & Trim(cboDisponibilidad.Text) & "' ,
             '" & txtJustificación.Text & "', '" & DTPFechaIngreso.Text & "', '" & DTPFechaSalida.Text & "',
          '" & DTPFechaValidacion.Text & "', '" & txtIdPropietario.Text & "', '" & TxtIdElaborado.Text & "',
              '" & txtIdAprobado.Text & "', '" & txtIdRevisado.Text & "','" & Trim(cboTipo.SelectedValue) & "','" & Trim(cboProceso.SelectedValue) & "',
             '" & Trim(cboPropCargo.SelectedValue) & "'   ) "


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
            sql = "UPDATE ActivosInformacion SET  IdentificadorActivo = '" & txtIdentificador.Text & " ', NombreActivo = '" & txtNombreActivoInf.Text & "',
                                         Descripcion = '" & txtDescripcion.Text & "', Ubicacion = '" & Trim(cboUbicacion.Text) & "' ,    
                                   Ruta =  '" & txtRuta.Text & "', ClasiConfi =  '" & Trim(cboConfidencialidad.Text) & "' ,
                                         ClasiInteg =  '" & Trim(cboIntegridad.Text) & "' ,
                                         ClasiDispon =  '" & Trim(cboDisponibilidad.Text) & "', 
                                         JustificacionActivo =   '" & txtJustificación.Text & "' ,
                                         FechaIngreso = '" & DTPFechaIngreso.Text & "' , 
                                         FechaSalida = '" & DTPFechaSalida.Text & "' , 
                                          FechaValidacion = '" & DTPFechaValidacion.Text & "' , 
                                         IdPropietario  = '" & txtIdPropietario.Text & "',
                                          IdElaborado  = '" & TxtIdElaborado.Text & "' , 
                                         IdAprobado =  '" & txtIdAprobado.Text & "' , 
                                         IdRevisado =  '" & txtIdRevisado.Text & "' , 
                                         IdTipo =  '" & Trim(cboTipo.SelectedValue) & "' ,
                                         IdDepartamento   =  '" & Trim(cboProceso.SelectedValue) & "' ,

                                        IdPuesto   =  '" & Trim(cboPropCargo.SelectedValue) & "'  WHERE IdActivoInf = '" & txtId.Text & "'          "
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
            If MsgBox("Seguro en Eliminar el Activo  " + Trim(txtNombreActivoInf.Text) + " De Su Registro de Asignación? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM ActivosInformacion WHERE IdActivoInf = " & Trim(txtId.Text)

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

        sql = " SELECT ActivosInformacion.IdActivoInf, ActivosInformacion.IdentificadorActivo, ActivosInformacion.NombreActivo,
                      Departamentos.NombreD,  TipoActivo.NombreT, TipoActivo.IdTipo,
        ActivosInformacion.Ubicacion,  ActivosInformacion.Ruta, ActivosInformacion.JustificacionActivo, Propietarios.IdPropietario,
          Propietarios.Nombre,Puestos.NombreP, ActivosInformacion.FechaIngreso, ActivosInformacion.ClasiConfi,  ActivosInformacion.ClasiInteg,
         ActivosInformacion.ClasiDispon, Elaborado.IdElaborado, Elaborado.NombreEla, 
        Aprobado.IdAprobado, Aprobado.NombreApro, Revisados.IdRevisado, Revisados.NombreRev,
         Puestos.IdPuesto,   
        ActivosInformacion.FechaValidacion, ActivosInformacion.FechaSalida, ActivosInformacion.Descripcion
        FROM  ActivosInformacion INNER JOIN Departamentos ON ActivosInformacion.IdDepartamento  = Departamentos.IdDepartamento
                         INNER JOIN TipoActivo ON ActivosInformacion.IdTipo = TipoActivo.IdTipo
                         INNER JOIN Propietarios ON ActivosInformacion.IdPropietario = Propietarios.IdPropietario 
                         INNER JOIN Puestos ON ActivosInformacion.IdPuesto = Puestos.IdPuesto
                         INNER JOIN Elaborado ON ActivosInformacion.IdElaborado = Elaborado.IdElaborado 
                         INNER JOIN Aprobado ON ActivosInformacion.IdAprobado = Aprobado.IdAprobado
                         INNER JOIN Revisados ON ActivosInformacion.IdRevisado = Revisados.IdRevisado       "







        Try


            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvActivosInf.DataSource = tabla

            lblTotalActivos.Text = tabla.Rows.Count


        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente Error " + ex.ToString + " Sistema Inventario")
        End Try


    End Sub



    Sub BuscarDatos()
        If rbProceso.Checked Then


            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT ActivosInformacion.IdActivoInf, ActivosInformacion.IdentificadorActivo, ActivosInformacion.NombreActivo,
                      Departamentos.NombreD,  TipoActivo.NombreT, TipoActivo.IdTipo,
        ActivosInformacion.Ubicacion,  ActivosInformacion.Ruta, ActivosInformacion.JustificacionActivo, Propietarios.IdPropietario,
          Propietarios.Nombre,Puestos.NombreP, ActivosInformacion.FechaIngreso, ActivosInformacion.ClasiConfi,  ActivosInformacion.ClasiInteg,
         ActivosInformacion.ClasiDispon, Elaborado.IdElaborado, Elaborado.NombreEla, 
        Aprobado.IdAprobado, Aprobado.NombreApro, Revisados.IdRevisado, Revisados.NombreRev,
         Puestos.IdPuesto,   
        ActivosInformacion.FechaValidacion, ActivosInformacion.FechaSalida, ActivosInformacion.Descripcion
        FROM  ActivosInformacion INNER JOIN Departamentos ON ActivosInformacion.IdDepartamento  = Departamentos.IdDepartamento
                         INNER JOIN TipoActivo ON ActivosInformacion.IdTipo = TipoActivo.IdTipo
                         INNER JOIN Propietarios ON ActivosInformacion.IdPropietario = Propietarios.IdPropietario 
                         INNER JOIN Puestos ON ActivosInformacion.IdPuesto = Puestos.IdPuesto
                         INNER JOIN Elaborado ON ActivosInformacion.IdElaborado = Elaborado.IdElaborado 
                         INNER JOIN Aprobado ON ActivosInformacion.IdAprobado = Aprobado.IdAprobado
                         INNER JOIN Revisados ON ActivosInformacion.IdRevisado = Revisados.IdRevisado
                          WHERE  Departamentos.NombreD Like  '%" & txtBuscar.Text & "%'    ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosInf.DataSource = tabla
                lblTotalActivos.Text = tabla.Rows.Count
            Else
                dgvActivosInf.DataSource = ""
            End If
        End If

        If rbPropietario.Checked Then

            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT ActivosInformacion.IdActivoInf, ActivosInformacion.IdentificadorActivo, ActivosInformacion.NombreActivo,
                      Departamentos.NombreD,  TipoActivo.NombreT, TipoActivo.IdTipo,
        ActivosInformacion.Ubicacion,  ActivosInformacion.Ruta, ActivosInformacion.JustificacionActivo, Propietarios.IdPropietario,
          Propietarios.Nombre,Puestos.NombreP, ActivosInformacion.FechaIngreso, ActivosInformacion.ClasiConfi,  ActivosInformacion.ClasiInteg,
         ActivosInformacion.ClasiDispon, Elaborado.IdElaborado, Elaborado.NombreEla, 
        Aprobado.IdAprobado, Aprobado.NombreApro, Revisados.IdRevisado, Revisados.NombreRev,
         Puestos.IdPuesto,   
        ActivosInformacion.FechaValidacion, ActivosInformacion.FechaSalida, ActivosInformacion.Descripcion
        FROM  ActivosInformacion INNER JOIN Departamentos ON ActivosInformacion.IdDepartamento  = Departamentos.IdDepartamento
                         INNER JOIN TipoActivo ON ActivosInformacion.IdTipo = TipoActivo.IdTipo
                         INNER JOIN Propietarios ON ActivosInformacion.IdPropietario = Propietarios.IdPropietario 
                         INNER JOIN Puestos ON ActivosInformacion.IdPuesto = Puestos.IdPuesto
                         INNER JOIN Elaborado ON ActivosInformacion.IdElaborado = Elaborado.IdElaborado 
                         INNER JOIN Aprobado ON ActivosInformacion.IdAprobado = Aprobado.IdAprobado
                         INNER JOIN Revisados ON ActivosInformacion.IdRevisado = Revisados.IdRevisado
                                   WHERE  Propietarios.Nombre Like  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosInf.DataSource = tabla
                lblTotalActivos.Text = tabla.Rows.Count
            Else
                dgvActivosInf.DataSource = ""
            End If
        End If

        If rbElaborado.Checked Then

            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT ActivosInformacion.IdActivoInf, ActivosInformacion.IdentificadorActivo, ActivosInformacion.NombreActivo,
                      Departamentos.NombreD,  TipoActivo.NombreT, TipoActivo.IdTipo,
        ActivosInformacion.Ubicacion,  ActivosInformacion.Ruta, ActivosInformacion.JustificacionActivo, Propietarios.IdPropietario,
          Propietarios.Nombre,Puestos.NombreP, ActivosInformacion.FechaIngreso, ActivosInformacion.ClasiConfi,  ActivosInformacion.ClasiInteg,
         ActivosInformacion.ClasiDispon, Elaborado.IdElaborado, Elaborado.NombreEla, 
        Aprobado.IdAprobado, Aprobado.NombreApro, Revisados.IdRevisado, Revisados.NombreRev,
         Puestos.IdPuesto,   
        ActivosInformacion.FechaValidacion, ActivosInformacion.FechaSalida, ActivosInformacion.Descripcion
        FROM  ActivosInformacion INNER JOIN Departamentos ON ActivosInformacion.IdDepartamento  = Departamentos.IdDepartamento
                         INNER JOIN TipoActivo ON ActivosInformacion.IdTipo = TipoActivo.IdTipo
                         INNER JOIN Propietarios ON ActivosInformacion.IdPropietario = Propietarios.IdPropietario 
                         INNER JOIN Puestos ON ActivosInformacion.IdPuesto = Puestos.IdPuesto
                         INNER JOIN Elaborado ON ActivosInformacion.IdElaborado = Elaborado.IdElaborado 
                         INNER JOIN Aprobado ON ActivosInformacion.IdAprobado = Aprobado.IdAprobado
                         INNER JOIN Revisados ON ActivosInformacion.IdRevisado = Revisados.IdRevisado 
                WHERE  Elaborado.NombreEla Like  '%" & txtBuscar.Text & "%'   ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosInf.DataSource = tabla
                lblTotalActivos.Text = tabla.Rows.Count
            Else
                dgvActivosInf.DataSource = ""
            End If
        End If

        If rbUbicacion.Checked Then

            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT ActivosInformacion.IdActivoInf, ActivosInformacion.IdentificadorActivo, ActivosInformacion.NombreActivo,
                      Departamentos.NombreD,  TipoActivo.NombreT, TipoActivo.IdTipo,
        ActivosInformacion.Ubicacion,  ActivosInformacion.Ruta, ActivosInformacion.JustificacionActivo, Propietarios.IdPropietario,
          Propietarios.Nombre,Puestos.NombreP, ActivosInformacion.FechaIngreso, ActivosInformacion.ClasiConfi,  ActivosInformacion.ClasiInteg,
         ActivosInformacion.ClasiDispon, Elaborado.IdElaborado, Elaborado.NombreEla, 
        Aprobado.IdAprobado, Aprobado.NombreApro, Revisados.IdRevisado, Revisados.NombreRev,
         Puestos.IdPuesto,   
        ActivosInformacion.FechaValidacion, ActivosInformacion.FechaSalida, ActivosInformacion.Descripcion
        FROM  ActivosInformacion INNER JOIN Departamentos ON ActivosInformacion.IdDepartamento  = Departamentos.IdDepartamento
                         INNER JOIN TipoActivo ON ActivosInformacion.IdTipo = TipoActivo.IdTipo
                         INNER JOIN Propietarios ON ActivosInformacion.IdPropietario = Propietarios.IdPropietario 
                         INNER JOIN Puestos ON ActivosInformacion.IdPuesto = Puestos.IdPuesto
                         INNER JOIN Elaborado ON ActivosInformacion.IdElaborado = Elaborado.IdElaborado 
                         INNER JOIN Aprobado ON ActivosInformacion.IdAprobado = Aprobado.IdAprobado
                         INNER JOIN Revisados ON ActivosInformacion.IdRevisado = Revisados.IdRevisado
                WHERE  ActivosInformacion.Ubicacion Like  '%" & txtBuscar.Text & "%'   ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosInf.DataSource = tabla
                lblTotalActivos.Text = tabla.Rows.Count
            Else
                dgvActivosInf.DataSource = ""
            End If
        End If


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ActivarControles()
        LimpiarControles()
        txtIdentificador.Focus()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        TamañoFormularioBuscar()
        btnCancelar.Enabled = True
        btnBuscar.Enabled = False
        txtBuscar.Focus()
        LlenarDatos()
    End Sub

    Private Sub btnTipo_Click(sender As Object, e As EventArgs) Handles btnTipo.Click
        frmTipoActivo.ShowDialog()

    End Sub

    Private Sub cboTipo_Click(sender As Object, e As EventArgs) Handles cboTipo.Click
        Mostrar_Tipo()

    End Sub

    Private Sub cboProceso_Click(sender As Object, e As EventArgs) Handles cboProceso.Click
        Mostrar_Departamentos()

    End Sub

    Private Sub btnProceso_Click(sender As Object, e As EventArgs) Handles btnProceso.Click
        frmDepartamentos.ShowDialog()

    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        frmPropietario.ShowDialog()

    End Sub

    Private Sub btnEmpleado2_Click(sender As Object, e As EventArgs) Handles btnEmpleado2.Click
        frmElaborado.ShowDialog()
    End Sub

    Private Sub btnEmpleado3_Click(sender As Object, e As EventArgs) Handles btnEmpleado3.Click
        frmAprobados.ShowDialog()

    End Sub

    Private Sub btnPuesto_Click(sender As Object, e As EventArgs) Handles btnPuesto.Click
        frmPuestosTrabajo.ShowDialog()


    End Sub


    Private Sub cboPropCargo_Click(sender As Object, e As EventArgs) Handles cboPropCargo.Click
        Mostrar_Puestos()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        insertar()
        LlenarDatos()
        Call DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub btnRevisado_Click(sender As Object, e As EventArgs) Handles btnRevisado.Click
        frmRevisados.ShowDialog()


    End Sub

    Private Sub btnPropietario_Click(sender As Object, e As EventArgs) Handles btnPropietario.Click
        frmPropietarioActivo.ShowDialog()

    End Sub

    Private Sub btnElaborado_Click(sender As Object, e As EventArgs) Handles btnElaborado.Click
        frmBusquedaElaboradoPor.ShowDialog()

    End Sub

    Private Sub btnAprobado_Click(sender As Object, e As EventArgs) Handles btnAprobado.Click
        frmAprobadoPor.ShowDialog()

    End Sub

    Private Sub btnRevisadoBusque_Click(sender As Object, e As EventArgs) Handles btnRevisadoBusque.Click
        frmBusquedaRevisadoPor.ShowDialog()

    End Sub

    Private Sub txtRevisado_TextChanged(sender As Object, e As EventArgs) Handles txtRevisado.TextChanged

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        TamañoFormulario()
        Call DesactivarControles()
        LimpiarControles()
        Panel1.Visible = False
        btnCancelar.Enabled = False
        btnBuscar.Enabled = True
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        txtBuscar.Focus()
        BuscarDatos()
    End Sub

    Private Sub rbProceso_CheckedChanged(sender As Object, e As EventArgs) Handles rbProceso.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbPropietario_CheckedChanged(sender As Object, e As EventArgs) Handles rbPropietario.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbElaborado_CheckedChanged(sender As Object, e As EventArgs) Handles rbElaborado.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbUbicacion_CheckedChanged(sender As Object, e As EventArgs) Handles rbUbicacion.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub dgvActivosInf_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActivosInf.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvActivosInf.Item("IdActivoInf", dgvActivosInf.CurrentCell.RowIndex).Value)
        txtIdentificador.Text = CStr(dgvActivosInf.Item("IdentificadorActivo", dgvActivosInf.CurrentCell.RowIndex).Value)
        cboProceso.Text = CStr(dgvActivosInf.Item("NombreD", dgvActivosInf.CurrentCell.RowIndex).Value)
        txtNombreActivoInf.Text = CStr(dgvActivosInf.Item("NombreActivo", dgvActivosInf.CurrentCell.RowIndex).Value)
        cboTipo.Text = CStr(dgvActivosInf.Item("NombreT", dgvActivosInf.CurrentCell.RowIndex).Value)
        cboUbicacion.Text = CStr(dgvActivosInf.Item("Ubicacion", dgvActivosInf.CurrentCell.RowIndex).Value)
        txtRuta.Text = CStr(dgvActivosInf.Item("Ruta", dgvActivosInf.CurrentCell.RowIndex).Value)
        txtJustificación.Text = CStr(dgvActivosInf.Item("JustificacionActivo", dgvActivosInf.CurrentCell.RowIndex).Value)
        txtPropietario.Text = CStr(dgvActivosInf.Item("Nombre", dgvActivosInf.CurrentCell.RowIndex).Value)
        txtIdPropietario.Text = CStr(dgvActivosInf.Item("IdPropietario", dgvActivosInf.CurrentCell.RowIndex).Value)
        cboPropCargo.Text = CStr(dgvActivosInf.Item("NombreP", dgvActivosInf.CurrentCell.RowIndex).Value)
        DTPFechaIngreso.Text = CStr(dgvActivosInf.Item("FechaIngreso", dgvActivosInf.CurrentCell.RowIndex).Value)
        cboConfidencialidad.Text = CStr(dgvActivosInf.Item("ClasiConfi", dgvActivosInf.CurrentCell.RowIndex).Value)
        cboIntegridad.Text = CStr(dgvActivosInf.Item("ClasiInteg", dgvActivosInf.CurrentCell.RowIndex).Value)
        cboDisponibilidad.Text = CStr(dgvActivosInf.Item("ClasiDispon", dgvActivosInf.CurrentCell.RowIndex).Value)
        TxtIdElaborado.Text = CStr(dgvActivosInf.Item("IdElaborado", dgvActivosInf.CurrentCell.RowIndex).Value)
        txtElaborado.Text = CStr(dgvActivosInf.Item("NombreEla", dgvActivosInf.CurrentCell.RowIndex).Value)
        txtAprobado.Text = CStr(dgvActivosInf.Item("NombreApro", dgvActivosInf.CurrentCell.RowIndex).Value)
        txtIdAprobado.Text = CStr(dgvActivosInf.Item("IdAprobado", dgvActivosInf.CurrentCell.RowIndex).Value)
        txtIdRevisado.Text = CStr(dgvActivosInf.Item("IdRevisado", dgvActivosInf.CurrentCell.RowIndex).Value)
        txtRevisado.Text = CStr(dgvActivosInf.Item("NombreRev", dgvActivosInf.CurrentCell.RowIndex).Value)
        DTPFechaValidacion.Text = CStr(dgvActivosInf.Item("FechaValidacion", dgvActivosInf.CurrentCell.RowIndex).Value)
        DTPFechaSalida.Text = CStr(dgvActivosInf.Item("FechaSalida", dgvActivosInf.CurrentCell.RowIndex).Value)
        txtDescripcion.Text = CStr(dgvActivosInf.Item("Descripcion", dgvActivosInf.CurrentCell.RowIndex).Value)



        'ActivosInformacion.IdTipo, ActivosInformacion.IdentificadorActivo, ActivosInformacion.NombreActivo,
        '              Departamentos.NombreD, TipoActivo.NombreT, TipoActivo.IdTipo,
        'ActivosInformacion.Ubicacion, ActivosInformacion.Ruta, ActivosInformacion.JustificacionActivo, Propietarios.IdPropietario,
        '  Propietarios.Nombre, Puestos.NombreP, ActivosInformacion.FechaIngreso, ActivosInformacion.ClasiConfi, ActivosInformacion.ClasiInteg,
        ' ActivosInformacion.ClasiDispon, Elaborado.IdElaborado, Elaborado.NombreEla,
        'Aprobado.IdAprobado, Aprobado.NombreApro, Revisados.IdRevisado, Revisados.NombreRev,
        ' Puestos.IdPuesto,
        'ActivosInformacion.FechaValidacion, ActivosInformacion.FechaSalida, ActivosInformacion.Descripcion

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False



        txtIdentificador.Enabled = True
        cboProceso.Enabled = True
        txtNombreActivoInf.Enabled = True
        cboTipo.Enabled = True
        cboUbicacion.Enabled = True
        txtRuta.Enabled = True
        txtJustificación.Enabled = True
        txtPropietario.Enabled = True
        cboPropCargo.Enabled = True
        DTPFechaIngreso.Enabled = True
        cboConfidencialidad.Enabled = True
        cboIntegridad.Enabled = True
        cboDisponibilidad.Enabled = True
        txtElaborado.Enabled = True
        txtAprobado.Enabled = True
        txtRevisado.Enabled = True
        DTPFechaValidacion.Enabled = True
        DTPFechaSalida.Enabled = True

        txtDescripcion.Enabled = True

        btnPropietario.Enabled = True
        btnTipo.Enabled = True
        btnElaborado.Enabled = True
        btnAprobado.Enabled = True
        btnRevisadoBusque.Enabled = True
        btnRevisado.Enabled = True
        btnEmpleado.Enabled = True
        btnProceso.Enabled = True
        btnPuesto.Enabled = True
        btnEmpleado2.Enabled = True
        btnEmpleado3.Enabled = True


        txtIdentificador.Focus()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInfConfidencialidad.Click
        MsgBox("La confidencialidad se conoce como la forma de prevenir la divulgación de la información a personas o sistemas que no se encuentran autorizados.",
               vbInformation, "Información Confidencialidad Activos")
    End Sub

    Private Sub btnInfIdentificador_Click(sender As Object, e As EventArgs) Handles btnInfIdentificador.Click
        MsgBox("Número consecutivo único que identifica el activo en el inventario",
               vbInformation, "Información Identificador Activos")
    End Sub

    Private Sub btnInfoTipo_Click(sender As Object, e As EventArgs) Handles btnInfoTipo.Click
        MsgBox("Define el tipo al cual pertenece el activo. Bases de datos, contratos,  documentacion del sistema, investigaciones, acuerdos de confidencialidad, manuales de usuario,  procedimientos operativos o de soporte, planes para la continuidad del negocio, acuerdos sobre el retiro y pruebas de auditoría.  Software, recurso humano, Servicio, Hardware, Otros",
               vbInformation, "Información Tipo  Activos")
    End Sub

    Private Sub btnInfReservada_Click(sender As Object, e As EventArgs) Handles btnInfReservada.Click
        MsgBox("Información disponible sólo para un proceso de la compañía y que en caso de ser conocida por terceros sin autorización puede conllevar un impacto negativo de índole legal,   operativa, de pérdida de imagen o económica.",
             vbInformation, "Información   Reservada")
    End Sub

    Private Sub btnInfClasificada_Click(sender As Object, e As EventArgs) Handles btnInfClasificada.Click
        MsgBox("Informacion disponible para todos los procesos de la compañia y  que en caso de ser conocida por terceros sin autorización puede conllevar un impacto negativo para los procesos de la misma,   Esta información es propia de la compañía o de terceros y puede ser utilizada  por todos los usuarios de la misma para realizar labores propias de los procesos,   pero no puede ser conocida por terceros sin autorización del propietario",
            vbInformation, "Información  Clasificada")
    End Sub

    Private Sub btnInfPublic_Click(sender As Object, e As EventArgs) Handles btnInfPublic.Click
        MsgBox(" Información que puede ser entregada o publicada sin restricciones a cualquier persona y fuera de la compañia,   sin que esto implique daños a terceros ni a las actividades y procesos de la entidad",
           vbInformation, "Información  Pública")
    End Sub

    Private Sub btnInfNoAPlica_Click(sender As Object, e As EventArgs) Handles btnInfNoAPlica.Click
        MsgBox(" Activos de información que deben ser incluidos  en el inventario y que aún no han sido clasificados,  deben ser tratados como  activos de INFORMACION RESERVADA",
          vbInformation, "InformaciónInformacion  No Clasificada")
    End Sub

    Private Sub btnInfoIntegridad_Click(sender As Object, e As EventArgs) Handles btnInfoIntegridad.Click
        MsgBox(" La integridad se refiere a cómo los datos se mantienen intactos libre de modificaciones o alteraciones por terceros, cuando una violación modifica algo en la base de datos, sea por accidente o intencionado se pierde la integridad y falla el proceso",
         vbInformation, "Información Integridad")
    End Sub

    Private Sub btnInfoDisponibilidad_Click(sender As Object, e As EventArgs) Handles btnInfoDisponibilidad.Click
        MsgBox(" La disponibilidad es la propiedad de la información que se refiere a que ésta debe ser accesible cuando el usuario o sistema necesite realizar una consulta",
         vbInformation, "Información Disponibilidad")
    End Sub

    Private Sub btnInfInteAlta_Click(sender As Object, e As EventArgs) Handles btnInfInteAlta.Click
        MsgBox(" Información cuya pérdida de exactitud y completitud puede conllevar un impacto negativo de índole legal o económica, retrasar sus funciones, o generar pérdidas de imagen severas de la compañía",
         vbInformation, "Información Integridad Alta")
    End Sub

    Private Sub btnInfIntegMedia_Click(sender As Object, e As EventArgs) Handles btnInfIntegMedia.Click
        MsgBox(" Información cuya pérdida de exactitud y completitud puede conllevar un impacto negativo de índole legal o económica,  retrasar sus funciones, o generar pérdidas de imagen moderado a funcionarios de la compañía",
       vbInformation, "Información Integridad Media")
    End Sub

    Private Sub btnInfoInteBaja_Click(sender As Object, e As EventArgs) Handles btnInfoInteBaja.Click
        MsgBox(" Información cuya pérdida de exactitud y completitud conlleva un impacto no significativo para la compañía o entes externos",
  vbInformation, "Información Integridad Baja")
    End Sub

    Private Sub btnInfoInteNoclasifica_Click(sender As Object, e As EventArgs) Handles btnInfoInteNoclasifica.Click
        MsgBox("Activos de información que deben ser incluidos en el inventario y que aún no han sido clasificados,  deben ser tratados como activos de información de integridad ALTA",
vbInformation, "Información Integridad No Clasificada")
    End Sub

    Private Sub btnInfoDispoAlta_Click(sender As Object, e As EventArgs) Handles btnInfoDispoAlta.Click
        MsgBox("La no disponibilidad de la información puede conllevar un impacto negativo de índole legal o económica, retrasar sus funciones,   o generar pérdidas de imagen severas a entes externos",
vbInformation, "Información Disponibilidad Alta")
    End Sub

    Private Sub btnInfoDispoMedia_Click(sender As Object, e As EventArgs) Handles btnInfoDispoMedia.Click
        MsgBox("La no disponibilidad de la información puede conllevar un impacto negativo de índole legal o económica, retrasar sus funciones,    o generar pérdidas de imagen moderado de la compañia",
vbInformation, "Información Disponibilidad Media")
    End Sub

    Private Sub btnInfoDispoBaja_Click(sender As Object, e As EventArgs) Handles btnInfoDispoBaja.Click
        MsgBox("La no disponibilidad de la información puede afectar la operación normal de la compñía o entes externos,  pero no conlleva implicaciones legales, económicas o de pérdida de  imagen",
vbInformation, "Información Disponibilidad Baja")
    End Sub

    Private Sub btnInfoDispoNoclasifica_Click(sender As Object, e As EventArgs) Handles btnInfoDispoNoclasifica.Click
        MsgBox("Activos de información que deben ser incluidos en el inventario y que aún no han sido clasificados, deben ser tratados como activos de información de disponiblidad ALTA",
vbInformation, "Información Disponibilidad No clasificada")
    End Sub

    Private Sub btnJustificacion_Click(sender As Object, e As EventArgs) Handles btnJustificacion.Click
        MsgBox("El argumento del porque se asignó dicha valoración, describe el impacto que causaría la pérdida de la propiedad (Confidencialidad – Integridad - Disponibilidad           ",
vbInformation, "Información Justificación")
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        ReporteActivosDigitales.ImprimirActivos()
        ReporteActivosDigitales.ShowDialog()

    End Sub
End Class