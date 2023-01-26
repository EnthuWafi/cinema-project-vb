<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblIntro2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIntro
        '
        Me.lblIntro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIntro.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblIntro.Location = New System.Drawing.Point(92, 139)
        Me.lblIntro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(680, 85)
        Me.lblIntro.TabIndex = 0
        Me.lblIntro.Text = resources.GetString("lblIntro.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.gpprojecttest.My.Resources.Resources.GTAlogo
        Me.PictureBox1.Location = New System.Drawing.Point(265, 37)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblIntro2
        '
        Me.lblIntro2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIntro2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblIntro2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblIntro2.Location = New System.Drawing.Point(92, 236)
        Me.lblIntro2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIntro2.Name = "lblIntro2"
        Me.lblIntro2.Size = New System.Drawing.Size(680, 59)
        Me.lblIntro2.TabIndex = 2
        Me.lblIntro2.Text = "We are also a fully integrated content provider and a key player in the acquisiti" &
    "on, distribution, licensing and marketing of movies in various languages."
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(864, 554)
        Me.Controls.Add(Me.lblIntro2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblIntro)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAbout"
        Me.Text = "GTA Cinema: About Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblIntro As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblIntro2 As Label
End Class
