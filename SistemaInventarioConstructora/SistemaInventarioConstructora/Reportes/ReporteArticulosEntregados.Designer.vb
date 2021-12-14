<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteArticulosEntregados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportAEntregados = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportAEntregados
        '
        Me.CrystalReportAEntregados.ActiveViewIndex = -1
        Me.CrystalReportAEntregados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportAEntregados.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportAEntregados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportAEntregados.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportAEntregados.Name = "CrystalReportAEntregados"
        Me.CrystalReportAEntregados.ShowCloseButton = False
        Me.CrystalReportAEntregados.ShowLogo = False
        Me.CrystalReportAEntregados.Size = New System.Drawing.Size(1813, 1007)
        Me.CrystalReportAEntregados.TabIndex = 0
        Me.CrystalReportAEntregados.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteArticulosEntregados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1813, 1007)
        Me.Controls.Add(Me.CrystalReportAEntregados)
        Me.Name = "ReporteArticulosEntregados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Artículos Entregados"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportAEntregados As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
