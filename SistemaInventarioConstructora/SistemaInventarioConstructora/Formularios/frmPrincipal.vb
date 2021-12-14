Imports System.Windows.Forms

Public Class frmPrincipal





    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        On Error Resume Next
        Dim salir As String
        salir = MsgBox("Desea salir del Sistema ? ", vbQuestion + vbYesNo, "Salir")
        If salir = vbYes Then
            Global.System.Windows.Forms.Application.Exit()
        Else
            Me.ShowDialog()
        End If
    End Sub






    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            frmUsuarios.Show()
        Else
            MsgBox("No tiene los privilegios para acceder a este modulo", vbInformation, "Operación Cancelada")


        End If
    End Sub

    Private Sub frmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        On Error Resume Next
        Dim salir As String
        salir = MsgBox("Desea salir del Sistema ? ", vbQuestion + vbYesNo, "Salir")
        If salir = vbYes Then
            Global.System.Windows.Forms.Application.Exit()
        Else
            Me.ShowDialog()
        End If



    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub EntregaDeActivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregaDeActivosToolStripMenuItem.Click
        frmCargoActivos.Show()

    End Sub

    Private Sub RegistroDeActivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeActivosToolStripMenuItem.Click
        frmArticulos.Show()


    End Sub

    Private Sub DescargoDeActivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargoDeActivosToolStripMenuItem.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            frmDescargoActivos.Show()
        Else
            MsgBox("No tiene los privilegios para acceder a este modulo", vbInformation, "Operación Cancelada")


        End If
    End Sub

    Private Sub MantenimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientosToolStripMenuItem.Click
        frmMantenimientoActivos.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            frmEmpleados.Show()
        Else
            MsgBox("No tiene los privilegios para acceder a este modulo", vbInformation, "Operación Cancelada")


        End If
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            frmDepartamentos.Show()
        Else
            MsgBox("No tiene los privilegios para acceder a este modulo", vbInformation, "Operación Cancelada")


        End If
    End Sub

    Private Sub PuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuestosToolStripMenuItem.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            frmPuestosTrabajo.Show()
        Else
            MsgBox("No tiene los privilegios para acceder a este modulo", vbInformation, "Operación Cancelada")


        End If
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasToolStripMenuItem.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            frmMarcas.Show()
        Else
            MsgBox("No tiene los privilegios para acceder a este modulo", vbInformation, "Operación Cancelada")


        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        ReporteArticulos.ImprimirArticulos()
        ReporteArticulos.ShowDialog()
    End Sub

    Private Sub btnImprimirEntregados_Click(sender As Object, e As EventArgs) Handles btnImprimirEntregados.Click
        ReporteArticulosEntregados.ImprimirArticulosEntregados()
        ReporteArticulosEntregados.ShowDialog()
    End Sub

    Private Sub btnImprimirObsoletos_Click(sender As Object, e As EventArgs) Handles btnImprimirObsoletos.Click
        ReporteArticulosObsoletos.ImprimirArticulosObsoletos()
        ReporteArticulosObsoletos.ShowDialog()
    End Sub

    Private Sub btnImprimirHurtados_Click(sender As Object, e As EventArgs) Handles btnImprimirHurtados.Click
        ReporteArticulosHurtados.ImprimirArticulosHurtados()
        ReporteArticulosHurtados.ShowDialog()
    End Sub

    Private Sub btnImprimirMantenimientos_Click(sender As Object, e As EventArgs) Handles btnImprimirMantenimientos.Click
        ReporteMantenimiento.ImprimirMantenimientoActivos()
        ReporteMantenimiento.ShowDialog()

    End Sub

    Private Sub RegistroActivosDiigitalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroActivosDiigitalesToolStripMenuItem.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            frmTipoActivo.Show()
        Else
            MsgBox("No tiene los privilegios para acceder a este modulo", vbInformation, "Operación Cancelada")


        End If
    End Sub

    Private Sub ResitroActivosDigitalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResitroActivosDigitalesToolStripMenuItem.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            frmActivosInformacion.Show()
        Else
            MsgBox("No tiene los privilegios para acceder a este modulo", vbInformation, "Operación Cancelada")


        End If
    End Sub

    Private Sub IngresoSolicitudesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoSolicitudesToolStripMenuItem.Click
        frmRegistroSolicitudes.Show()
    End Sub

    Private Sub SoluciónSolicitudesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoluciónSolicitudesToolStripMenuItem.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            frmSolucionSolicitudes.Show()
        Else
            MsgBox("No tiene los privilegios para acceder a este modulo", vbInformation, "Operación Cancelada")


        End If
    End Sub

    Private Sub btnReporteSabaneta_Click(sender As Object, e As EventArgs) Handles btnReporteSabaneta.Click
        ReporteArticulosEntregadosSabaneta.ImprimirArticulosEntregadosSabaneta()
        ReporteArticulosEntregadosSabaneta.ShowDialog()
    End Sub

    Private Sub BtnEntregadosCaribe_Click(sender As Object, e As EventArgs) Handles BtnEntregadosCaribe.Click
        ReporteArticulosEntregadosCaribe.ImprimirArticulosEntregadosCaribe()
        ReporteArticulosEntregadosCaribe.ShowDialog()
    End Sub

    Private Sub btnEntregadosCEDI_Click(sender As Object, e As EventArgs) Handles btnEntregadosCEDI.Click
        ReporteArticulosEntregadosCEDI.ImprimirArticulosEntregadosCEDI()
        ReporteArticulosEntregadosCEDI.ShowDialog()
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

    Private Sub btnInformeSoluciones_Click(sender As Object, e As EventArgs) Handles btnInformeSoluciones.Click
        ReporteSolicitudesSolucionadas.ImprimirTotalSolicitudesSolucionadas()
        ReporteSolicitudesSolucionadas.ShowDialog()



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
