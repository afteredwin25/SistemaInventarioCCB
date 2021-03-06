Imports System.Data.SqlClient


Public Class ReporteArticulosEntregadosCaribe
    Private Sub ReporteArticulosEntregadosCaribe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub ImprimirArticulosEntregadosCaribe()
        Dim adaptador1, adaptador2, adaptador3, adaptador4, adaptador5, adaptador6, adaptador7 As SqlDataAdapter
        Dim reporte As New rptArticulosEntregados
        Dim ds As New dsData1
        Dim sql1, sql2, sql3, sql4, sql5, sql6, sql7 As String


        sql1 = " Select * from Articulos where EstadoArticulo = 'ENTREGADO' "
        sql2 = " select * from Marcas"
        sql3 = " Select * from  CargoActivos where EstadoArticulo <> 'ELIMINADO' AND Sede = 'Caribe Principal' "
        sql4 = " select * from Departamentos"
        sql5 = " select * from DescargoActivos "
        sql6 = " select * from Empleados"
        sql7 = " Select * from Puestos"



        Try
            adaptador1 = New SqlDataAdapter(sql1, obtenerconexion)
            adaptador2 = New SqlDataAdapter(sql2, obtenerconexion)
            adaptador3 = New SqlDataAdapter(sql3, obtenerconexion)
            adaptador4 = New SqlDataAdapter(sql4, obtenerconexion)
            adaptador5 = New SqlDataAdapter(sql5, obtenerconexion)
            adaptador6 = New SqlDataAdapter(sql6, obtenerconexion)
            adaptador7 = New SqlDataAdapter(sql7, obtenerconexion)


            adaptador1.Fill(ds, "Articulos")
            adaptador2.Fill(ds, "Marcas")
            adaptador3.Fill(ds, "CargoActivos")
            adaptador4.Fill(ds, "Departamentos")
            adaptador5.Fill(ds, "DescargoActivos")
            adaptador6.Fill(ds, "Empleados")
            adaptador7.Fill(ds, "Puestos")




            reporte.SetDataSource(ds)
            Me.CrystalReportViewer1.ReportSource = reporte




        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error " + ex.ToString + "Sistema Inventario")
        End Try


    End Sub



End Class