<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMENU
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
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BarraTopo = New System.Windows.Forms.Panel()
        Me.Fechar = New System.Windows.Forms.Panel()
        Me.Maximizar = New System.Windows.Forms.Panel()
        Me.Minimizar = New System.Windows.Forms.Panel()
        Me.Programa = New System.Windows.Forms.Panel()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Título"
        '
        'BarraTopo
        '
        Me.BarraTopo.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BarraTopo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTopo.Enabled = False
        Me.BarraTopo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTopo.Margin = New System.Windows.Forms.Padding(0)
        Me.BarraTopo.Name = "BarraTopo"
        Me.BarraTopo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BarraTopo.Size = New System.Drawing.Size(500, 32)
        Me.BarraTopo.TabIndex = 5
        '
        'Fechar
        '
        Me.Fechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fechar.BackColor = System.Drawing.Color.Transparent
        Me.Fechar.BackgroundImage = Global.MENU_001.My.Resources.Resources.Fechar
        Me.Fechar.Location = New System.Drawing.Point(455, -1)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(46, 33)
        Me.Fechar.TabIndex = 1
        '
        'Maximizar
        '
        Me.Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Maximizar.BackColor = System.Drawing.Color.Transparent
        Me.Maximizar.BackgroundImage = Global.MENU_001.My.Resources.Resources.Maximizar
        Me.Maximizar.Location = New System.Drawing.Point(410, -1)
        Me.Maximizar.Name = "Maximizar"
        Me.Maximizar.Size = New System.Drawing.Size(46, 33)
        Me.Maximizar.TabIndex = 2
        '
        'Minimizar
        '
        Me.Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizar.BackColor = System.Drawing.Color.Transparent
        Me.Minimizar.BackgroundImage = Global.MENU_001.My.Resources.Resources.Minimizar
        Me.Minimizar.Location = New System.Drawing.Point(365, -1)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Size = New System.Drawing.Size(46, 33)
        Me.Minimizar.TabIndex = 3
        '
        'Programa
        '
        Me.Programa.BackColor = System.Drawing.Color.White
        Me.Programa.BackgroundImage = Global.MENU_001.My.Resources.Resources.Bg
        Me.Programa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Programa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Programa.Enabled = False
        Me.Programa.Location = New System.Drawing.Point(0, 32)
        Me.Programa.Margin = New System.Windows.Forms.Padding(0)
        Me.Programa.Name = "Programa"
        Me.Programa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Programa.Size = New System.Drawing.Size(500, 468)
        Me.Programa.TabIndex = 4
        '
        'frmMENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.Fechar)
        Me.Controls.Add(Me.Maximizar)
        Me.Controls.Add(Me.Minimizar)
        Me.Controls.Add(Me.Programa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BarraTopo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMENU"
        Me.Text = "Form1"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Fechar As Panel
    Private WithEvents Maximizar As Panel
    Private WithEvents Minimizar As Panel
    Friend WithEvents Programa As Panel
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label1 As Label
    Friend WithEvents BarraTopo As Panel
End Class
