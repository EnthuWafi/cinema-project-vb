<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaffHome))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMovie = New System.Windows.Forms.Button()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.btnShowtimes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picGTA = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picGTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox1.Controls.Add(Me.btnMovie)
        Me.GroupBox1.Controls.Add(Me.btnInvoice)
        Me.GroupBox1.Controls.Add(Me.btnShowtimes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 129)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(815, 167)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnMovie
        '
        Me.btnMovie.Location = New System.Drawing.Point(37, 76)
        Me.btnMovie.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMovie.Name = "btnMovie"
        Me.btnMovie.Size = New System.Drawing.Size(241, 65)
        Me.btnMovie.TabIndex = 5
        Me.btnMovie.Text = "Movies"
        Me.btnMovie.UseVisualStyleBackColor = True
        '
        'btnInvoice
        '
        Me.btnInvoice.Location = New System.Drawing.Point(536, 76)
        Me.btnInvoice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(241, 65)
        Me.btnInvoice.TabIndex = 4
        Me.btnInvoice.Text = "View Transaction"
        Me.btnInvoice.UseVisualStyleBackColor = True
        '
        'btnShowtimes
        '
        Me.btnShowtimes.Location = New System.Drawing.Point(287, 76)
        Me.btnShowtimes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnShowtimes.Name = "btnShowtimes"
        Me.btnShowtimes.Size = New System.Drawing.Size(241, 65)
        Me.btnShowtimes.TabIndex = 2
        Me.btnShowtimes.Text = "Showtimes"
        Me.btnShowtimes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STAFF ONLY"
        '
        'picGTA
        '
        Me.picGTA.BackColor = System.Drawing.Color.Snow
        Me.picGTA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picGTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picGTA.Image = Global.gpprojecttest.My.Resources.Resources.GTAlogo
        Me.picGTA.Location = New System.Drawing.Point(228, 15)
        Me.picGTA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picGTA.Name = "picGTA"
        Me.picGTA.Size = New System.Drawing.Size(449, 85)
        Me.picGTA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGTA.TabIndex = 3
        Me.picGTA.TabStop = False
        '
        'frmStaffHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(847, 319)
        Me.Controls.Add(Me.picGTA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmStaffHome"
        Me.Text = "Staff Home Page"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picGTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picGTA As PictureBox
    Friend WithEvents btnShowtimes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInvoice As Button
    Friend WithEvents btnMovie As Button
End Class
