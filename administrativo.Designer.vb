<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrativo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administrativo))
        Me.btn_compras = New System.Windows.Forms.Button()
        Me.btn_agendamentos = New System.Windows.Forms.Button()
        Me.sair_administrativo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_compras
        '
        Me.btn_compras.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_compras.Location = New System.Drawing.Point(665, 142)
        Me.btn_compras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_compras.Name = "btn_compras"
        Me.btn_compras.Size = New System.Drawing.Size(288, 85)
        Me.btn_compras.TabIndex = 0
        Me.btn_compras.Text = "Gerar Relatórios de Compras"
        Me.btn_compras.UseVisualStyleBackColor = True
        '
        'btn_agendamentos
        '
        Me.btn_agendamentos.Location = New System.Drawing.Point(665, 310)
        Me.btn_agendamentos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_agendamentos.Name = "btn_agendamentos"
        Me.btn_agendamentos.Size = New System.Drawing.Size(288, 86)
        Me.btn_agendamentos.TabIndex = 1
        Me.btn_agendamentos.Text = "Gerar Relatórios de Agendamentos"
        Me.btn_agendamentos.UseVisualStyleBackColor = True
        '
        'sair_administrativo
        '
        Me.sair_administrativo.AutoSize = True
        Me.sair_administrativo.BackColor = System.Drawing.Color.Transparent
        Me.sair_administrativo.Location = New System.Drawing.Point(529, 11)
        Me.sair_administrativo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sair_administrativo.Name = "sair_administrativo"
        Me.sair_administrativo.Size = New System.Drawing.Size(134, 16)
        Me.sair_administrativo.TabIndex = 94
        Me.sair_administrativo.Text = "↩  Voltar para o menu"
        '
        'administrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.sair_administrativo)
        Me.Controls.Add(Me.btn_agendamentos)
        Me.Controls.Add(Me.btn_compras)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "administrativo"
        Me.Text = "Administrativo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_compras As Button
    Friend WithEvents btn_agendamentos As Button
    Friend WithEvents sair_administrativo As Label
End Class
