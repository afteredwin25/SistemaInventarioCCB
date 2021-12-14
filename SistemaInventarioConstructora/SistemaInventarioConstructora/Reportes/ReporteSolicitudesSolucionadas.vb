Imports System.Data.SqlClient

Public Class ReporteSolicitudesSolucionadas
    Private Sub ReporteSolicitudesSolucionadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub ImprimirTotalSolicitudesSolucionadas()
        Dim adaptador1, adaptador2, adaptador3, adaptador4, adaptador5, adaptador6, adaptador7, adaptador8, adaptador9, adaptador10 As SqlDataAdapter
        Dim reporte As New rptSolicitudesSolucionadas
        Dim ds As New dsData1
        Dim sql1, sql2, sql3, sql4, sql5, sql6, sql7, sql8, sql9, sql10 As String


        sql1 = " Select * from Articulos where EstadoArticulo = 'ENTREGADO' "
        sql2 = " select * from Marcas"
        sql3 = " Select * from  CargoActivos where EstadoArticulo <> 'ELIMINADO' "
        sql4 = " select * from Departamentos"
        sql5 = " select * from DescargoActivos "
        sql6 = " select * from Empleados"
        sql7 = " Select * from Puestos"
        sql8 = " Select * from Solicitudes where EstadoSolicitud = 'Solucionada'"
        sql9 = " Select * from TecnicosSoluciones"
        sql10 = "Select * from SolucionSolicitudes"

        Try
            adaptador1 = New SqlDataAdapter(sql1, obtenerconexion)
            adaptador2 = New SqlDataAdapter(sql2, obtenerconexion)
            adaptador3 = New SqlDataAdapter(sql3, obtenerconexion)
            adaptador4 = New SqlDataAdapter(sql4, obtenerconexion)
            adaptador5 = New SqlDataAdapter(sql5, obtenerconexion)
            adaptador6 = New SqlDataAdapter(sql6, obtenerconexion)
            adaptador7 = New SqlDataAdapter(sql7, obtenerconexion)
            adaptador8 = New SqlDataAdapter(sql8, obtenerconexion)
            adaptador9 = New SqlDataAdapter(sql9, obtenerconexion)
            adaptador10 = New SqlDataAdapter(sql10, obtenerconexion)


            adaptador1.Fill(ds, "Articulos")
            adaptador2.Fill(ds, "Marcas")
            adaptador3.Fill(ds, "CargoActivos")
            adaptador4.Fill(ds, "Departamentos")
            adaptador5.Fill(ds, "DescargoActivos")
            adaptador6.Fill(ds, "Empleados")
            adaptador7.Fill(ds, "Puestos")
            adaptador8.Fill(ds, "Solicitudes")
            adaptador9.Fill(ds, "TecnicosSoluciones")
            adaptador10.Fill(ds, "SolucionSolicitudes")


            reporte.SetDataSource(ds)
            Me.CrystalReportViewer1.ReportSource = reporte




        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error " + ex.ToString + "Sistema Inventario")
        End Try




    End Sub

End Class