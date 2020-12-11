<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_relprodutos
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
        Me.cadastroDataSet4 = New estoque.cadastroDataSet4()
        Me.produtosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.produtosTableAdapter = New estoque.cadastroDataSet4TableAdapters.produtosTableAdapter()
        CType(Me.cadastroDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.produtosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.produtosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "estoque.R_produtos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(521, 274)
        Me.ReportViewer1.TabIndex = 0
        '
        'cadastroDataSet4
        '
        Me.cadastroDataSet4.DataSetName = "cadastroDataSet4"
        Me.cadastroDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'produtosBindingSource
        '
        Me.produtosBindingSource.DataMember = "produtos"
        Me.produtosBindingSource.DataSource = Me.cadastroDataSet4
        '
        'produtosTableAdapter
        '
        Me.produtosTableAdapter.ClearBeforeFill = True
        '
        'F_relprodutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 274)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "F_relprodutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "relatorios de produtos"
        CType(Me.cadastroDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.produtosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents produtosBindingSource As BindingSource
    Friend WithEvents cadastroDataSet4 As cadastroDataSet4
    Friend WithEvents produtosTableAdapter As cadastroDataSet4TableAdapters.produtosTableAdapter
End Class
