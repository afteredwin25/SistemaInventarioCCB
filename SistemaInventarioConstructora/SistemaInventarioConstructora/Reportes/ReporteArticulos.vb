Imports System.Data.SqlClient


Public Class ReporteArticulos
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Sub ImprimirArticulos()
        Dim adaptador1, adaptador2 As SqlDataAdapter
        Dim reporte As New rtpArticulos
        Dim ds As New dsData1
        Dim sql1, sql2 As String


        sql1 = " SELECT * FROM Articulos WHERE EstadoArticulo='PENDIENTE'"
        sql2 = " SELECT * FROM Marcas"

        Try
            adaptador1 = New SqlDataAdapter(sql1, obtenerconexion)
            adaptador2 = New SqlDataAdapter(sql2, obtenerconexion)

            adaptador1.Fill(ds, "Articulos")
            adaptador2.Fill(ds, "Marcas")

            reporte.SetDataSource(ds)
            Me.CrystalReportViewer1.ReportSource = reporte

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error " + ex.ToString + "Sistema Inventario")
        End Try


    End Sub

    Private Sub ReporteArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class