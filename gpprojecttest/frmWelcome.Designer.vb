<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWelcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.picGTA = New System.Windows.Forms.PictureBox()
        Me.lblMain2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        CType(Me.picGTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnuMain.Size = New System.Drawing.Size(912, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileStaff, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileStaff
        '
        Me.mnuFileStaff.Name = "mnuFileStaff"
        Me.mnuFileStaff.Size = New System.Drawing.Size(130, 22)
        Me.mnuFileStaff.Text = "&Staff Path"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(130, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuAbout.Text = "&About"
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.SystemColors.Control
        Me.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWelcome.Font = New System.Drawing.Font("Perpetua Titling MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(349, 51)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(202, 34)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "WELCOME TO"
        '
        'btnSignUp
        '
        Me.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSignUp.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.Location = New System.Drawing.Point(432, 214)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(196, 66)
        Me.btnSignUp.TabIndex = 4
        Me.btnSignUp.Text = "SIGN UP"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CINEMA TICKETING SYSTEM"
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(140, 214)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(196, 66)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "LOG IN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'picGTA
        '
        Me.picGTA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picGTA.BackColor = System.Drawing.Color.Snow
        Me.picGTA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picGTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picGTA.Image = Global.gpprojecttest.My.Resources.Resources.GTAlogo
        Me.picGTA.Location = New System.Drawing.Point(161, 23)
        Me.picGTA.Margin = New System.Windows.Forms.Padding(4)
        Me.picGTA.Name = "picGTA"
        Me.picGTA.Size = New System.Drawing.Size(449, 85)
        Me.picGTA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGTA.TabIndex = 2
        Me.picGTA.TabStop = False
        '
        'lblMain2
        '
        Me.lblMain2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblMain2.AutoSize = True
        Me.lblMain2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain2.Location = New System.Drawing.Point(265, 343)
        Me.lblMain2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMain2.Name = "lblMain2"
        Me.lblMain2.Size = New System.Drawing.Size(239, 16)
        Me.lblMain2.TabIndex = 6
        Me.lblMain2.Text = "2022 (C) SANWAD ENTERTAINMENT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblMain2)
        Me.GroupBox1.Controls.Add(Me.picGTA)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSignUp)
        Me.GroupBox1.Location = New System.Drawing.Point(75, 107)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(769, 390)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(644, 343)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "version 1.2.5"
        '
        'frmWelcome
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.gpprojecttest.My.Resources.Resources.netflix_img
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(912, 512)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.mnuMain)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmWelcome"
        Me.Text = "GTA Cinema Ticketing System: Welcome"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        CType(Me.picGTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents picGTA As PictureBox
    Friend WithEvents lblMain2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mnuFileStaff As ToolStripMenuItem
End Class
