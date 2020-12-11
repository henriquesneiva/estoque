<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_relusuarios
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cadastroDataSet5 = New estoque.cadastroDataSet5()
        Me.loginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.loginTableAdapter = New estoque.cadastroDataSet5TableAdapters.loginTableAdapter()
        CType(Me.cadastroDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.loginBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "estoque.R_usuarios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(468, 294)
        Me.ReportViewer1.TabIndex = 0
        '
        'cadastroDataSet5
        '
        Me.cadastroDataSet5.DataSetName = "cadastroDataSet5"
        Me.cadastroDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'loginBindingSource
        '
        Me.loginBindingSource.DataMember = "login"
        Me.loginBindingSource.DataSource = Me.cadastroDataSet5
        '
        'loginTableAdapter
        '
        Me.loginTableAdapter.ClearBeforeFill = True
        '
        'F_relusuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 294)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "F_relusuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "relatorio de usuarios"
        CType(Me.cadastroDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents loginBindingSource As BindingSource
    Friend WithEvents cadastroDataSet5 As cadastroDataSet5
    Friend WithEvents loginTableAdapter As cadastroDataSet5TableAdapters.loginTableAdapter
End Class
