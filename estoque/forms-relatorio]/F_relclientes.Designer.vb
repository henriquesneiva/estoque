<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_relclientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_relclientes))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cadastroDataSet3 = New estoque.cadastroDataSet3()
        Me.clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clientesTableAdapter = New estoque.cadastroDataSet3TableAdapters.clientesTableAdapter()
        CType(Me.cadastroDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "relatorios_datasert"
        ReportDataSource1.Value = Me.clientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "estoque.R_clientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(473, 250)
        Me.ReportViewer1.TabIndex = 0
        '
        'cadastroDataSet3
        '
        Me.cadastroDataSet3.DataSetName = "cadastroDataSet3"
        Me.cadastroDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'clientesBindingSource
        '
        Me.clientesBindingSource.DataMember = "clientes"
        Me.clientesBindingSource.DataSource = Me.cadastroDataSet3
        '
        'clientesTableAdapter
        '
        Me.clientesTableAdapter.ClearBeforeFill = True
        '
        'F_relclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(473, 250)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "F_relclientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "relatorios de clientes"
        CType(Me.cadastroDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clientesBindingSource As BindingSource
    Friend WithEvents cadastroDataSet3 As cadastroDataSet3
    Friend WithEvents clientesTableAdapter As cadastroDataSet3TableAdapters.clientesTableAdapter
End Class
