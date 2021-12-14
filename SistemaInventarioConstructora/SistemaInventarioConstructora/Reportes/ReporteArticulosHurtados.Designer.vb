<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteArticulosHurtados
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
        Me.CrystalReportHurtados = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportHurtados
        '
        Me.CrystalReportHurtados.ActiveViewIndex = -1
        Me.CrystalReportHurtados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportHurtados.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportHurtados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportHurtados.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportHurtados.Name = "CrystalReportHurtados"
        Me.CrystalReportHurtados.ShowCloseButton = False
        Me.CrystalReportHurtados.ShowLogo = False
        Me.CrystalReportHurtados.Size = New System.Drawing.Size(1904, 1008)
        Me.CrystalReportHurtados.TabIndex = 0
        Me.CrystalReportHurtados.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteArticulosHurtados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1008)
        Me.Controls.Add(Me.CrystalReportHurtados)
        Me.Name = "ReporteArticulosHurtados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteArticulosHurtados"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportHurtados As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
