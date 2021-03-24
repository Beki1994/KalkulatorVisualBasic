<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pocetna
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pocetna))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VerzijaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JednostavniKalkulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JednostavniKalkulatorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ZnanstveniKalkulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerzijaToolStripMenuItem, Me.JednostavniKalkulatorToolStripMenuItem, Me.FormuleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(803, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VerzijaToolStripMenuItem
        '
        Me.VerzijaToolStripMenuItem.Name = "VerzijaToolStripMenuItem"
        Me.VerzijaToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.VerzijaToolStripMenuItem.Text = "Verzija"
        '
        'JednostavniKalkulatorToolStripMenuItem
        '
        Me.JednostavniKalkulatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JednostavniKalkulatorToolStripMenuItem1, Me.ZnanstveniKalkulatorToolStripMenuItem})
        Me.JednostavniKalkulatorToolStripMenuItem.Name = "JednostavniKalkulatorToolStripMenuItem"
        Me.JednostavniKalkulatorToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.JednostavniKalkulatorToolStripMenuItem.Text = "Kalkulator"
        '
        'JednostavniKalkulatorToolStripMenuItem1
        '
        Me.JednostavniKalkulatorToolStripMenuItem1.Name = "JednostavniKalkulatorToolStripMenuItem1"
        Me.JednostavniKalkulatorToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
        Me.JednostavniKalkulatorToolStripMenuItem1.Text = "Jednostavni kalkulator"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(802, 533)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ZnanstveniKalkulatorToolStripMenuItem
        '
        Me.ZnanstveniKalkulatorToolStripMenuItem.Name = "ZnanstveniKalkulatorToolStripMenuItem"
        Me.ZnanstveniKalkulatorToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ZnanstveniKalkulatorToolStripMenuItem.Text = "Znanstveni kalkulator"
        '
        'FormuleToolStripMenuItem
        '
        Me.FormuleToolStripMenuItem.Name = "FormuleToolStripMenuItem"
        Me.FormuleToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.FormuleToolStripMenuItem.Text = "Formule"
        '
        'Pocetna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 559)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Pocetna"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VerzijaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JednostavniKalkulatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents JednostavniKalkulatorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ZnanstveniKalkulatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormuleToolStripMenuItem As ToolStripMenuItem
End Class
