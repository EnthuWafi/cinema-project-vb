<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.lblLoginIn = New System.Windows.Forms.Label()
        Me.lblPasswordIn = New System.Windows.Forms.Label()
        Me.lblUsernameIn = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogIN = New System.Windows.Forms.Button()
        Me.lblInterface = New System.Windows.Forms.Label()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLoginIn
        '
        Me.lblLoginIn.AutoSize = True
        Me.lblLoginIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginIn.Location = New System.Drawing.Point(285, 24)
        Me.lblLoginIn.Name = "lblLoginIn"
        Me.lblLoginIn.Size = New System.Drawing.Size(118, 46)
        Me.lblLoginIn.TabIndex = 0
        Me.lblLoginIn.Text = "Login"
        '
        'lblPasswordIn
        '
        Me.lblPasswordIn.AutoSize = True
        Me.lblPasswordIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordIn.Location = New System.Drawing.Point(43, 173)
        Me.lblPasswordIn.Name = "lblPasswordIn"
        Me.lblPasswordIn.Size = New System.Drawing.Size(151, 33)
        Me.lblPasswordIn.TabIndex = 2
        Me.lblPasswordIn.Text = "Password:"
        '
        'lblUsernameIn
        '
        Me.lblUsernameIn.AutoSize = True
        Me.lblUsernameIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameIn.Location = New System.Drawing.Point(43, 108)
        Me.lblUsernameIn.Name = "lblUsernameIn"
        Me.lblUsernameIn.Size = New System.Drawing.Size(158, 33)
        Me.lblUsernameIn.TabIndex = 1
        Me.lblUsernameIn.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(233, 108)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(426, 33)
        Me.txtUsername.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(233, 173)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(426, 33)
        Me.txtPassword.TabIndex = 4
        '
        'btnLogIN
        '
        Me.btnLogIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIN.Location = New System.Drawing.Point(264, 248)
        Me.btnLogIN.Name = "btnLogIN"
        Me.btnLogIN.Size = New System.Drawing.Size(174, 69)
        Me.btnLogIN.TabIndex = 5
        Me.btnLogIN.Text = "Login"
        Me.btnLogIN.UseVisualStyleBackColor = True
        '
        'lblInterface
        '
        Me.lblInterface.AutoSize = True
        Me.lblInterface.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterface.Location = New System.Drawing.Point(57, 380)
        Me.lblInterface.Name = "lblInterface"
        Me.lblInterface.Size = New System.Drawing.Size(401, 18)
        Me.lblInterface.TabIndex = 6
        Me.lblInterface.Text = "If you don't have account, please click this button for sign-in:"
        '
        'btnSignIn
        '
        Me.btnSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.Location = New System.Drawing.Point(480, 364)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(141, 52)
        Me.btnSignIn.TabIndex = 7
        Me.btnSignIn.Text = "SIGN-IN"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gpprojecttest.My.Resources.Resources.netflix_img
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(710, 450)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.lblInterface)
        Me.Controls.Add(Me.btnLogIN)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPasswordIn)
        Me.Controls.Add(Me.lblUsernameIn)
        Me.Controls.Add(Me.lblLoginIn)
        Me.Name = "frmLogin"
        Me.Text = "Login Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLoginIn As Label
    Friend WithEvents lblPasswordIn As Label
    Friend WithEvents lblUsernameIn As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogIN As Button
    Friend WithEvents lblInterface As Label
    Friend WithEvents btnSignIn As Button
End Class
