Imports System.Data.SqlClient



Public Class frmDescargoActivos
    Private Sub frmDescargoActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        Tamañoformulario()
        LlenarDatos()

        txtCodigoI.AutoCompleteMode = AutoCompleteMode.Suggest
        txtCodigoI.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCodigoI.AutoCompleteCustomSource = ObtenerCodigoInventario()




        dgvActivosDescargados.Columns("PrecioCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvActivosDescargados.Columns("PrecioCompra").DefaultCellStyle.Format = "N2"

        dgvActivosDescargados.AutoGenerateColumns = False


    End Sub


    Sub Tamañoformulario()
        Width = 1432
        Height = 393
        Panel1.Visible = False
    End Sub


    Sub TamañoformularioBuscar()
        Width = 1432
        Height = 1153
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


    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnCargos.Enabled = False


        txtCodigoI.Enabled = False
        txtNombreA.Enabled = False
        txtPrecio.Enabled = False
        txtIdentidad.Enabled = False
        txtNombreE.Enabled = False
        txtDepartamento.Enabled = False

        DTPFechaEntrega.Enabled = False
        DTPFechaDescargo.Enabled = False
        cboMotivo.Enabled = False
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
        txtPrecio.Enabled = True
        txtIdentidad.Enabled = True
        txtNombreE.Enabled = True
        txtDepartamento.Enabled = True

        DTPFechaEntrega.Enabled = False
        DTPFechaDescargo.Enabled = True
        cboMotivo.Enabled = True
        txtDescripcion.Enabled = True




        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtCodigoI.Text = ""
        txtNombreA.Text = ""
        txtPrecio.Text = ""
        txtIdentidad.Text = ""
        txtNombreE.Text = ""
        txtDepartamento.Text = ""

        DTPFechaEntrega.Text = ""
        cboMotivo.Text = ""
        txtDescripcion.Text = ""




        txtIdCargo.Text = ""
        txtIdArticulo.Text = ""
        txtId.Text = ""
        txtBuscar.Text = ""

        DTPFechaDescargo.Text = ""


    End Sub
    Sub Editar()
        Dim id As Integer



        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String



            sql = "UPDATE DescargoActivos SET  FechaDescargo = '" & DTPFechaDescargo.Text & " ', Descripcion = '" & txtDescripcion.Text & "', MotivoDescargo = '" & cboMotivo.Text & "' ,
                                       IdCargoActivo = '" & txtIdCargo.Text & "'
                    WHERE IdDescargo = '" & txtId.Text & "'          "

            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            If cboMotivo.Text = "Obsoleto" Then
                ModificarArticuloDefectuoso()

            ElseIf cboMotivo.Text = "Hurto" Then
                ModificarArticuloHurto()

            Else
                ModificarArticuloPendiente()

            End If



            MsgBox("Registro editado exitosamente ", vbInformation, "Sistema de Inventario")
            LimpiarControles()
        End If

    End Sub
    Sub insertar()
        Dim sql As String

        Dim id As Integer


        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT CargoActivos.CodigoInventario FROM CargoActivos
                               INNER JOIN DescargoActivos ON CargoActivos.IdCargo = DescargoActivos.IdCargoActivo  
                            Where CargoActivos.CodigoInventario =  '" & txtCodigoI.Text & "' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtCodigoI.Text = tabla.Rows(0).Item("CodigoInventario")
            MsgBox("El registro ya existe en la base de datos", vbInformation, " Sistema inventario")
            Exit Sub

        End If

        If txtIdArticulo.Text = "" Or txtIdCargo.Text = "" Or DTPFechaDescargo.Text = "" Or cboMotivo.Text = "" Then
            MsgBox("Existen campos vacios", vbInformation, " Sistema inventario")
            Exit Sub

        Else
            sql = "INSERT INTO DescargoActivos(FechaDescargo, Descripcion, MotivoDescargo, IdCargoActivo) VALUES ('" & DTPFechaDescargo.Text & "', 
                      '" & txtDescripcion.Text & "', '" & cboMotivo.Text & "', '" & txtIdCargo.Text & "' ) "

            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            If cboMotivo.Text = "Obsoleto" Then
                ModificarArticuloDefectuoso()

            ElseIf cboMotivo.Text = "Hurto" Then
                ModificarArticuloHurto()

            Else
                ModificarArticuloPendiente()

            End If
            MsgBox("Registro realizado existosamente", vbInformation, " Sistema inventario")
        End If


    End Sub



    Sub EliminarCargo()
        Dim id As Integer



        Dim sql As String
        sql = "UPDATE CargoActivos SET EstadoArticulo  = 'ELIMINADO'   WHERE IdCargo = " & Trim(txtIdCargo.Text)
        'sql = "DELETE FROM CargoActivos    WHERE IdCargo = " & Trim(txtIdCargo.Text)


        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()



    End Sub


    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, Articulos.NombreA, Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD  , Articulos.IdArticulo,
           DescargoActivos.IdDescargo, DescargoActivos.FechaDescargo, DescargoActivos.MotivoDescargo, DescargoActivos.Descripcion
           FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento 
                          INNER JOIN DescargoActivos ON CargoActivos.IdCargo = DescargoActivos.IdCargoActivo          "

        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvActivosDescargados.DataSource = tabla
            lblTotalActivosDescargados.Text = tabla.Rows.Count


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
                      Articulos.NombreA,  Articulos.IdArticulo, Articulos.PrecioCompra,
                      Empleados.Nombre, Empleados.Identidad,  Departamentos.NombreD,
                      DescargoActivos.IdDescargo, DescargoActivos.FechaDescargo,DescargoActivos.MotivoDescargo, DescargoActivos.Descripcion
                    FROM Articulos INNER JOIN  CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo 
                                   INNER JOIN  Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                   INNER JOIN  Departamentos ON  Empleados.IdDepartamento = Departamentos.IdDepartamento
                                   INNER JOIN  DescargoActivos ON CargoActivos.IdCargo = DescargoActivos.IdCargoActivo 
                        WHERE  Empleados.Nombre LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosDescargados.DataSource = tabla
                lblTotalActivosDescargados.Text = tabla.Rows.Count
            Else
                dgvActivosDescargados.DataSource = ""
            End If


        End If
        If rbCodigoInventario.Checked Then
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
                  WHERE  CargoActivos.CodigoInventario LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosDescargados.DataSource = tabla
                lblTotalActivosDescargados.Text = tabla.Rows.Count
            Else
                dgvActivosDescargados.DataSource = ""
            End If
        End If

        If rbNombreArticulo.Checked Then
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
                                  WHERE  Articulos.NombreA LIKE  '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosDescargados.DataSource = tabla
                lblTotalActivosDescargados.Text = tabla.Rows.Count
            Else
                dgvActivosDescargados.DataSource = ""
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
                dgvActivosDescargados.DataSource = tabla
                lblTotalActivosDescargados.Text = tabla.Rows.Count
            Else
                dgvActivosDescargados.DataSource = ""
            End If
        End If













    End Sub




    Sub Eliminar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            If MsgBox("Seguro en Eliminar el Activo  " + Trim(txtNombreA.Text) + " De Su Registro de Descargo? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM DescargoActivos WHERE IdDescargo = " & Trim(txtId.Text)

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

    ''Pendiente si es necesario o no?

    'Sub ModificarIdDescargoArticulos()
    '    Dim id As Integer

    '    Dim sql As String
    '    sql = "INSERT INTO  Articulos (IdDescargo) VALUES ( '" & txtId.Text & "')"


    '    Dim conect As New SqlConnection(obtenerconexion)
    '    conect.Open()
    '    Using comando As New SqlCommand(sql, conect)
    '        id = comando.ExecuteScalar()
    '    End Using
    '    conect.Close()

    'End Sub

    Sub ModificarArticuloPendiente()
        Dim id As Integer

        Dim sql As String
        sql = "UPDATE Articulos SET  EstadoArticulo = 'PENDIENTE',  DescripcionH = '" & txtDescripcion.Text & "', FechaHurto = '" & DTPFechaDescargo.Text & "' WHERE IdArticulo = '" & txtIdArticulo.Text & "'  "


        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()

    End Sub

    Sub ModificarArticuloDefectuoso()
        Dim id As Integer

        Dim sql As String
        sql = "UPDATE Articulos SET  EstadoArticulo = 'NO FUNCIONA',  DescripcionH = '" & txtDescripcion.Text & "' , FechaHurto = '" & DTPFechaDescargo.Text & "'  WHERE IdArticulo = '" & txtIdArticulo.Text & "'  "


        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()

    End Sub

    Sub ModificarArticuloHurto()
        Dim id As Integer

        Dim sql As String
        sql = "UPDATE Articulos SET  EstadoArticulo = 'HURTADO', DescripcionH = '" & txtDescripcion.Text & "' , FechaHurto = '" & DTPFechaDescargo.Text & "'   WHERE IdArticulo = '" & txtIdArticulo.Text & "'  "


        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()

    End Sub





    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call ActivarControles()
        LimpiarControles()
        btnBuscar.Enabled = True
        txtCodigoI.Focus()

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
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.FechaAsignacion, Articulos.IdArticulo, Articulos.NombreA, 
                                Articulos.PrecioCompra , Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD
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
                txtPrecio.Text = fila("PrecioCompra").ToString
                txtIdArticulo.Text = fila("IdArticulo").ToString
                txtIdentidad.Text = fila("Identidad").ToString
                txtNombreE.Text = fila("Nombre").ToString
                txtDepartamento.Text = fila("NombreD").ToString
                txtIdCargo.Text = fila("IdCargo").ToString



                DTPFechaEntrega.Text = fila("FechaAsignacion").ToString

            Else
                txtNombreA.Clear()
                txtPrecio.Clear()

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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        TamañoformularioBuscar()


        If cboMotivo.Text = "Obsoleto" Then
            insertar()
            'ModificarArticuloDefectuoso()
            EliminarCargo()

            LlenarDatos()
            DesactivarControles()
            LimpiarControles()

        ElseIf cboMotivo.Text = "Hurto" Then

            insertar()
            'ModificarArticuloHurto()
            EliminarCargo()

            LlenarDatos()
            DesactivarControles()
            LimpiarControles()
        Else
            insertar()
            'ModificarArticuloPendiente()
            EliminarCargo()

            LlenarDatos()
            'DesactivarControles()
            LimpiarControles()

        End If

    End Sub

    Private Sub btnCargos_Click(sender As Object, e As EventArgs) Handles btnCargos.Click
        frmBusquedaActivosFijos.ShowDialog()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
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

    Private Sub dgvActivosDescargados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActivosDescargados.CellDoubleClick
        On Error Resume Next
        txtIdArticulo.Text = CStr(dgvActivosDescargados.Item("IdArticulo", dgvActivosDescargados.CurrentCell.RowIndex).Value)
        txtNombreA.Text = CStr(dgvActivosDescargados.Item("NombreA", dgvActivosDescargados.CurrentCell.RowIndex).Value)
        txtCodigoI.Text = CStr(dgvActivosDescargados.Item("CodigoInventario", dgvActivosDescargados.CurrentCell.RowIndex).Value)
        txtPrecio.Text = CStr(dgvActivosDescargados.Item("PrecioCompra", dgvActivosDescargados.CurrentCell.RowIndex).Value)

        txtIdCargo.Text = CStr(dgvActivosDescargados.Item("IdCargo", dgvActivosDescargados.CurrentCell.RowIndex).Value)
        txtNombreE.Text = CStr(dgvActivosDescargados.Item("Nombre", dgvActivosDescargados.CurrentCell.RowIndex).Value)
        txtIdentidad.Text = CStr(dgvActivosDescargados.Item("Identidad", dgvActivosDescargados.CurrentCell.RowIndex).Value)
        txtDepartamento.Text = CStr(dgvActivosDescargados.Item("NombreD", dgvActivosDescargados.CurrentCell.RowIndex).Value)

        txtId.Text = CStr(dgvActivosDescargados.Item("IdDescargo", dgvActivosDescargados.CurrentCell.RowIndex).Value)
        DTPFechaEntrega.Text = CStr(dgvActivosDescargados.Item("FechaAsignacion", dgvActivosDescargados.CurrentCell.RowIndex).Value)
        DTPFechaDescargo.Text = CStr(dgvActivosDescargados.Item("FechaDescargo", dgvActivosDescargados.CurrentCell.RowIndex).Value)
        cboMotivo.Text = CStr(dgvActivosDescargados.Item("MotivoDescargo", dgvActivosDescargados.CurrentCell.RowIndex).Value)

        txtDescripcion.Text = CStr(dgvActivosDescargados.Item("Descripcion", dgvActivosDescargados.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False

        btnCargos.Enabled = True


        txtCodigoI.Enabled = True
        DTPFechaDescargo.Enabled = True
        cboMotivo.Enabled = True
        txtDescripcion.Enabled = True

        txtNombreA.Focus()
    End Sub

    Private Sub cboMotivo_Validated(sender As Object, e As EventArgs) Handles cboMotivo.Validated
        If cboMotivo.SelectedIndex.ToString = -1 Then
            MsgBox("No existe ('" & Me.cboMotivo.Text & "') Vuelva a intentarlo ", MessageBoxButtons.OK)
            Me.cboMotivo.Focus()
            Return
        End If
    End Sub

    Private Sub cbFechaHurto_CheckedChanged(sender As Object, e As EventArgs)

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

    Private Sub btnImprimirHurtados_Click(sender As Object, e As EventArgs) Handles btnImprimirHurtados.Click
        ReporteArticulosHurtados.ImprimirArticulosHurtados()
        ReporteArticulosHurtados.ShowDialog()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        ReporteArticulos.ImprimirArticulos()
        ReporteArticulos.ShowDialog()
    End Sub

    Private Sub btnImprimirObsoletos_Click(sender As Object, e As EventArgs) Handles btnImprimirObsoletos.Click
        ReporteArticulosObsoletos.ImprimirArticulosObsoletos()
        ReporteArticulosObsoletos.ShowDialog()
    End Sub

    Private Sub btnImprimirBajas_Click(sender As Object, e As EventArgs) Handles btnImprimirBajas.Click
        ReporteDescargoArticulos.ImprimirDescargoArticulos()
        ReporteDescargoArticulos.ShowDialog()

    End Sub
End Class