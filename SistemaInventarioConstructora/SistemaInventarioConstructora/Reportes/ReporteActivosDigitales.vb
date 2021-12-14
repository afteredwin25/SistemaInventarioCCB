Imports System.Data.SqlClient


Public Class ReporteActivosDigitales
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Sub ImprimirActivos()
        Dim adaptador1, adaptador2, adaptador3, adaptador4, adaptador5, adaptador6, adaptador7, adaptador8 As SqlDataAdapter
        Dim reporte As New rptActivosInformacion
        Dim ds As New dsData1
        Dim sql1, sql2, sql3, sql4, sql5, sql6, sql7, sql8 As String

        sql1 = " Select * from ActivosInformacion  "
        sql2 = " select * from Aprobado"
        sql3 = " Select * from Departamentos "
        sql4 = " select * from Elaborado"
        sql5 = " select * from Propietarios "
        sql6 = " select * from Puestos"
        sql7 = " Select * from Revisados"
        sql8 = " Select * from TipoActivo"



        Try
            adaptador1 = New SqlDataAdapter(sql1, obtenerconexion)
            adaptador2 = New SqlDataAdapter(sql2, obtenerconexion)
            adaptador3 = New SqlDataAdapter(sql3, obtenerconexion)
            adaptador4 = New SqlDataAdapter(sql4, obtenerconexion)
            adaptador5 = New SqlDataAdapter(sql5, obtenerconexion)
            adaptador6 = New SqlDataAdapter(sql6, obtenerconexion)
            adaptador7 = New SqlDataAdapter(sql7, obtenerconexion)
            adaptador8 = New SqlDataAdapter(sql8, obtenerconexion)


            adaptador1.Fill(ds, "ActivosInformacion")
            adaptador2.Fill(ds, "Aprobado")
            adaptador3.Fill(ds, "Departamentos")
            adaptador4.Fill(ds, "Elaborado")
            adaptador5.Fill(ds, "Propietarios")
            adaptador6.Fill(ds, "Puestos")
            adaptador7.Fill(ds, "Revisados")
            adaptador8.Fill(ds, "TipoActivo")

            reporte.SetDataSource(ds)
            Me.CrystalReportViewer1.ReportSource = reporte

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error " + ex.ToString + "Sistema Inventario")
        End Try


    End Sub


End Class