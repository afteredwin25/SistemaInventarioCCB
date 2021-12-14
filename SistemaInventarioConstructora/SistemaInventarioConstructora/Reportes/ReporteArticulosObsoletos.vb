Imports System.Data.SqlClient

Public Class ReporteArticulosObsoletos

    Private Sub CrystalReportViewerObsoletos_Load(sender As Object, e As EventArgs) Handles CrystalReportViewerObsoletos.Load

    End Sub

    Sub ImprimirArticulosObsoletos()
        Dim adaptador1, adaptador2, adaptador3, adaptador4, adaptador5, adaptador6 As SqlDataAdapter
        Dim reporte As New rptArticulosObsoletos
        Dim ds As New dsData1
        Dim sql1, sql2, sql3, sql4, sql5, sql6 As String


        sql1 = " Select * from Articulos where EstadoArticulo='NO FUNCIONA'"
        sql2 = " select * from Marcas"
        sql3 = " Select * from  CargoActivos "
        sql4 = " select * from Departamentos"
        sql5 = " select * from DescargoActivos "
        sql6 = " select * from Empleados"



        Try
            adaptador1 = New SqlDataAdapter(sql1, obtenerconexion)
            adaptador2 = New SqlDataAdapter(sql2, obtenerconexion)
            adaptador3 = New SqlDataAdapter(sql3, obtenerconexion)
            adaptador4 = New SqlDataAdapter(sql4, obtenerconexion)
            adaptador5 = New SqlDataAdapter(sql5, obtenerconexion)
            adaptador6 = New SqlDataAdapter(sql6, obtenerconexion)



            adaptador1.Fill(ds, "Articulos")
            adaptador2.Fill(ds, "Marcas")
            adaptador3.Fill(ds, "CargoActivos")
            adaptador4.Fill(ds, "Departamentos")
            adaptador5.Fill(ds, "DescargoActivos")
            adaptador6.Fill(ds, "Empleados")



            reporte.SetDataSource(ds)
            Me.CrystalReportViewerObsoletos.ReportSource = reporte


        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error " + ex.ToString + "Sistema Inventario")
        End Try
    End Sub


End Class