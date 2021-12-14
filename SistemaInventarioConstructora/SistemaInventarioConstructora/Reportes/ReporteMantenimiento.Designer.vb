<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteMantenimiento
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
        Me.CrystalReportMantenimientos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportMantenimientos
        '
        Me.CrystalReportMantenimientos.ActiveViewIndex = -1
        Me.CrystalReportMantenimientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportMantenimientos.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportMantenimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportMantenimientos.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportMantenimientos.Name = "CrystalReportMantenimientos"
        Me.CrystalReportMantenimientos.ShowCloseButton = False
        Me.CrystalReportMantenimientos.ShowLogo = False
        Me.CrystalReportMantenimientos.Size = New System.Drawing.Size(1904, 1153)
        Me.CrystalReportMantenimientos.TabIndex = 0
        Me.CrystalReportMantenimientos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1153)
        Me.Controls.Add(Me.CrystalReportMantenimientos)
        Me.Name = "ReporteMantenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Mantenimiento Activos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportMantenimientos As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
