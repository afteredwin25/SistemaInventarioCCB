Imports System.Data.SqlClient


Public Class frmArticulos
    Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

        Call DesactivarControles()
        TamañoFormulario()
        LlenarDatos()
        dgvArticulos.AutoGenerateColumns = False
        Mostrar_Marcas()
        cboMarca.SelectedIndex = -1

        dgvArticulos.Columns("PrecioCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvArticulos.Columns("PrecioCompra").DefaultCellStyle.Format = "N2"



    End Sub

    Private tabla_marcas As New DataTable



    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnMarca.Enabled = False


        txtNombreA.Enabled = False
        txtCodigo.Enabled = False
        txtSerie.Enabled = False
        txtModelo.Enabled = False
        cboMarca.Enabled = False
        cboTipoAdquisicion.Enabled = False
        DTPFechaCompra.Enabled = False
        cboMemoria.Enabled = False
        cboDiscoDuro.Enabled = False
        txtProcesador.Enabled = False

        txtPrecio.Enabled = False

        txtDescripcion.Enabled = False



        btnNuevo.Enabled = True
    End Sub

    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True

        btnMarca.Enabled = True

        txtNombreA.Enabled = True
        txtCodigo.Enabled = True
        txtSerie.Enabled = True
        txtModelo.Enabled = True
        cboMarca.Enabled = True
        cboTipoAdquisicion.Enabled = True
        DTPFechaCompra.Enabled = True
        cboMemoria.Enabled = True
        cboDiscoDuro.Enabled = True
        txtProcesador.Enabled = True
        txtPrecio.Enabled = True
        txtDescripcion.Enabled = True

        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtNombreA.Text = ""
        txtCodigo.Text = ""
        txtSerie.Text = ""
        txtModelo.Text = ""
        cboMarca.Text = ""
        cboTipoAdquisicion.Text = ""
        DTPFechaCompra.Text = ""
        txtPrecio.Text = ""
        txtDescripcion.Text = ""
        cboMemoria.Text = ""
        cboDiscoDuro.Text = ""
        txtProcesador.Text = ""


        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub


    Public Function Marcas_Listar(activo As Integer) As DataTable

        Dim tabla As New DataTable
        Dim sql As String
        sql = " SELECT IdMarca, NombreM FROM Marcas"
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla
    End Function



    Private Sub Mostrar_Marcas()
        tabla_marcas = Marcas_Listar(True)
        cboMarca.DataSource = tabla_marcas
        cboMarca.DisplayMember = "NombreM"
        cboMarca.ValueMember = "IdMarca"

    End Sub




    Sub TamañoFormulario()
        Width = 1379
        Height = 319
        Panel1.Visible = False

    End Sub


    Sub TamañoFormularioBuscar()
        Width = 1379
        Height = 958
        Panel1.Visible = True
        txtBuscar.BackColor = Color.YellowGreen
    End Sub



    Sub insertar()
        Dim sql As String
        Dim id As Integer

        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Articulos Where CodigoA =  '" & txtCodigo.Text & "'   ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtCodigo.Text = tabla.Rows(0).Item("CodigoA")
            MsgBox("El registro ya existe en la base de datos", vbInformation, " Sistema inventario")
            Exit Sub

        End If

        If txtNombreA.Text = "" Or txtCodigo.Text = "" Then
            MsgBox("Existen campos vacios", vbInformation, " Sistema inventario")
            Exit Sub

        Else
            sql = "INSERT INTO Articulos(NombreA, NumeroSerie, CodigoA, IdMarca, Modelo, PrecioCompra, FechaCompra, EstadoArticulo, MemoriaRam, 
                   DiscoDuro, Procesador, Descripcion) VALUES
                     ('" & txtNombreA.Text & "', '" & txtSerie.Text & "', '" & txtCodigo.Text & "', '" & Trim(cboMarca.SelectedValue) & "',
                        '" & txtModelo.Text & "',  '" & Trim(cboTipoAdquisicion.Text) & "', '" & txtPrecio.Text & "','" & DTPFechaCompra.Text & "', 'PENDIENTE', '" & Trim(cboMemoria.Text) & "',
                     '" & Trim(cboDiscoDuro.Text) & "' , '" & txtProcesador.Text & "', '" & txtDescripcion.Text & "') "
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro realizado existosamente", vbInformation, " Sistema inventario")
        End If

    End Sub


    Sub LlenarDatos()
        Dim sql As String
        sql = " SELECT Articulos.IdArticulo, Articulos.NombreA, Articulos.NumeroSerie, Articulos.CodigoA, Marcas.NombreM, Articulos.Modelo, Articulos.TipoAdquisicion, Articulos.PrecioCompra, 
       Articulos.FechaCompra, Articulos.EstadoArticulo, Articulos.MemoriaRam, Articulos.DiscoDuro, Articulos.Procesador, Articulos.Descripcion  
      FROM  Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca WHERE  Articulos.EstadoArticulo ='PENDIENTE' "
        Try


            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvArticulos.DataSource = tabla

            lblTotalArticulos.Text = tabla.Rows.Count


        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente Error " + ex.ToString + " Sistema Inventario")
        End Try


    End Sub

    Sub BuscarDatos()
        If rbNombreArticulo.Checked Then


            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT  Articulos.NombreA, Articulos.NumeroSerie, Articulos.CodigoA, Marcas.NombreM, Articulos.Modelo,  Articulos.TipoAdquisicion,
                                Articulos.PrecioCompra,  Articulos.FechaCompra, Articulos.EstadoArticulo,Articulos.MemoriaRam, Articulos.DiscoDuro, Articulos.Procesador, Articulos.Descripcion
                                    FROM  Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca
                                  WHERE  Articulos.NombreA Like  '%" & txtBuscar.Text & "%' AND   Articulos.EstadoArticulo ='PENDIENTE'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvArticulos.DataSource = tabla
                lblTotalArticulos.Text = tabla.Rows.Count
            Else
                dgvArticulos.DataSource = ""
            End If
        End If

        If rbCodigoA.Checked Then

            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT  Articulos.NombreA, Articulos.NumeroSerie, Articulos.CodigoA, Marcas.NombreM, Articulos.Modelo,  Articulos.TipoAdquisicion,
                                Articulos.PrecioCompra,  Articulos.FechaCompra, Articulos.EstadoArticulo,Articulos.MemoriaRam, Articulos.DiscoDuro, Articulos.Procesador, Articulos.Descripcion
                                    FROM  Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca
                         WHERE  Articulos.CodigoA Like  '%" & txtBuscar.Text & "%' AND    Articulos.EstadoArticulo ='PENDIENTE'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvArticulos.DataSource = tabla
                lblTotalArticulos.Text = tabla.Rows.Count
            Else
                dgvArticulos.DataSource = ""
            End If
        End If

        If rbMarca.Checked Then

            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT  Articulos.NombreA, Articulos.NumeroSerie, Articulos.CodigoA, Marcas.NombreM, Articulos.Modelo,  Articulos.TipoAdquisicion,
                                Articulos.PrecioCompra,  Articulos.FechaCompra, Articulos.EstadoArticulo,Articulos.MemoriaRam, Articulos.DiscoDuro, Articulos.Procesador, Articulos.Descripcion
                                    FROM  Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca 
                    WHERE  Marcas.NombreM Like  '%" & txtBuscar.Text & "%' AND    Articulos.EstadoArticulo ='PENDIENTE' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvArticulos.DataSource = tabla
                lblTotalArticulos.Text = tabla.Rows.Count
            Else
                dgvArticulos.DataSource = ""
            End If
        End If




    End Sub


    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios ", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE Articulos SET  NombreA = '" & txtNombreA.Text & " ', NumeroSerie = '" & txtSerie.Text & "', CodigoA = '" & txtCodigo.Text & "' ,
                                       IdMarca = '" & Trim(cboMarca.SelectedValue) & "', Modelo =  '" & txtModelo.Text & "',TipoAdquisicion =  '" & Trim(cboTipoAdquisicion.Text) & "',
    PrecioCompra =  '" & txtPrecio.Text & "' , FechaCompra =  '" & DTPFechaCompra.Text & "', MemoriaRam = '" & Trim(cboMemoria.Text) & "', DiscoDuro = '" & Trim(cboDiscoDuro.Text) & "' , 
                                       Procesador = '" & txtProcesador.Text & "', Descripcion =  '" & txtDescripcion.Text & "'  WHERE IdArticulo = '" & txtId.Text & "'          "
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
            If MsgBox("Seguro en Eliminar el artículo  " + Trim(txtNombreA.Text) + " De Su Registro? ", vbQuestion + vbYesNo, " Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else


                Dim sql As String
                sql = "DELETE FROM Articulos WHERE IdArticulo = " & Trim(txtId.Text)

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


    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        frmMarcas.ShowDialog()

    End Sub

    Private Sub cboMarca_Click(sender As Object, e As EventArgs) Handles cboMarca.Click
        Mostrar_Marcas()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call ActivarControles()
        LimpiarControles()
        txtNombreA.Focus()
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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        txtBuscar.Focus()
        BuscarDatos()
    End Sub

    Private Sub rbNombreArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreArticulo.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbCodigoA_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigoA.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbMarca_CheckedChanged(sender As Object, e As EventArgs) Handles rbMarca.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub dgvArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticulos.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvArticulos.Item("IdArticulo", dgvArticulos.CurrentCell.RowIndex).Value)
        txtNombreA.Text = CStr(dgvArticulos.Item("NombreA", dgvArticulos.CurrentCell.RowIndex).Value)
        txtSerie.Text = CStr(dgvArticulos.Item("NumeroSerie", dgvArticulos.CurrentCell.RowIndex).Value)
        txtCodigo.Text = CStr(dgvArticulos.Item("CodigoA", dgvArticulos.CurrentCell.RowIndex).Value)
        cboMarca.Text = CStr(dgvArticulos.Item("NombreM", dgvArticulos.CurrentCell.RowIndex).Value)
        txtModelo.Text = CStr(dgvArticulos.Item("Modelo", dgvArticulos.CurrentCell.RowIndex).Value)
        cboTipoAdquisicion.Text = CStr(dgvArticulos.Item("TipoAdquisicion", dgvArticulos.CurrentCell.RowIndex).Value)
        txtPrecio.Text = CStr(dgvArticulos.Item("PrecioCompra", dgvArticulos.CurrentCell.RowIndex).Value)
        DTPFechaCompra.Text = CStr(dgvArticulos.Item("FechaCompra", dgvArticulos.CurrentCell.RowIndex).Value)
        'txtPrecio.Text = Convert.ToString(dgvArticulos.Item("PrecioCOmpra", dgvArticulos.CurrentCell.RowIndex).Value)
        cboMemoria.Text = CStr(dgvArticulos.Item("MemoriaRam", dgvArticulos.CurrentCell.RowIndex).Value)
        cboDiscoDuro.Text = CStr(dgvArticulos.Item("DiscoDuro", dgvArticulos.CurrentCell.RowIndex).Value)
        txtProcesador.Text = CStr(dgvArticulos.Item("Procesador", dgvArticulos.CurrentCell.RowIndex).Value)
        txtDescripcion.Text = CStr(dgvArticulos.Item("Descripcion", dgvArticulos.CurrentCell.RowIndex).Value)


        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False



        txtNombreA.Enabled = True
        txtSerie.Enabled = True
        txtCodigo.Enabled = True
        cboMarca.Text = True
        txtModelo.Enabled = True
        cboTipoAdquisicion.Enabled = True
        txtPrecio.Enabled = True
        DTPFechaCompra.Enabled = True
        cboMemoria.Enabled = True
        cboDiscoDuro.Enabled = True
        txtProcesador.Enabled = True
        txtDescripcion.Enabled = True

        txtNombreA.Focus()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtSerie_TextChanged(sender As Object, e As EventArgs) Handles txtSerie.TextChanged

    End Sub

    Private Sub cboMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMarca.SelectedIndexChanged

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtModelo_TextChanged(sender As Object, e As EventArgs) Handles txtModelo.TextChanged

    End Sub

    Private Sub DTPFechaCompra_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaCompra.ValueChanged

    End Sub

    Private Sub txtNombreA_TextChanged(sender As Object, e As EventArgs) Handles txtNombreA.TextChanged

    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        ReporteArticulos.ImprimirArticulos()
        ReporteArticulos.ShowDialog()

    End Sub

    Private Sub btnImprimirObsoletos_Click(sender As Object, e As EventArgs) Handles btnImprimirObsoletos.Click
        ReporteArticulosObsoletos.ImprimirArticulosObsoletos()
        ReporteArticulosObsoletos.ShowDialog()

    End Sub

    Private Sub btnImprimirHurtados_Click(sender As Object, e As EventArgs) Handles btnImprimirHurtados.Click
        ReporteArticulosHurtados.ImprimirArticulosHurtados()
        ReporteArticulosHurtados.ShowDialog()

    End Sub

    Private Sub btnImprimirEntregados_Click(sender As Object, e As EventArgs) Handles btnImprimirEntregados.Click
        ReporteArticulosEntregados.ImprimirArticulosEntregados()
        ReporteArticulosEntregados.ShowDialog()

    End Sub


End Class