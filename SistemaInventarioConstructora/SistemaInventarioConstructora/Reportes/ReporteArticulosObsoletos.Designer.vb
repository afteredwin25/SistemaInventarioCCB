<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteArticulosObsoletos
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
        Me.CrystalReportViewerObsoletos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewerObsoletos
        '
        Me.CrystalReportViewerObsoletos.ActiveViewIndex = -1
        Me.CrystalReportViewerObsoletos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerObsoletos.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerObsoletos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerObsoletos.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerObsoletos.Name = "CrystalReportViewerObsoletos"
        Me.CrystalReportViewerObsoletos.ShowCloseButton = False
        Me.CrystalReportViewerObsoletos.ShowLogo = False
        Me.CrystalReportViewerObsoletos.Size = New System.Drawing.Size(1810, 869)
        Me.CrystalReportViewerObsoletos.TabIndex = 0
        Me.CrystalReportViewerObsoletos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteArticulosObsoletos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1810, 869)
        Me.Controls.Add(Me.CrystalReportViewerObsoletos)
        Me.Name = "ReporteArticulosObsoletos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Artículos Obsoletos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewerObsoletos As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
