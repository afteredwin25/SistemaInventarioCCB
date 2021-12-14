<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteDescargoArticulos
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
        Me.CrystalReportDescargoA = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportDescargoA
        '
        Me.CrystalReportDescargoA.ActiveViewIndex = -1
        Me.CrystalReportDescargoA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportDescargoA.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportDescargoA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportDescargoA.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportDescargoA.Name = "CrystalReportDescargoA"
        Me.CrystalReportDescargoA.ShowCloseButton = False
        Me.CrystalReportDescargoA.ShowLogo = False
        Me.CrystalReportDescargoA.Size = New System.Drawing.Size(1904, 1002)
        Me.CrystalReportDescargoA.TabIndex = 0
        Me.CrystalReportDescargoA.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteDescargoArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1002)
        Me.Controls.Add(Me.CrystalReportDescargoA)
        Me.Name = "ReporteDescargoArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Descargo de Articulos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportDescargoA As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
