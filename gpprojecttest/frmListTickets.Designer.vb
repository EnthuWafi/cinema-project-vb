<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListTickets
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListTickets))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvTicket = New System.Windows.Forms.DataGridView()
        Me.movieName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seatNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ageCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ticketPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvTicket)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(36, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(912, 507)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Tickets"
        '
        'dgvTicket
        '
        Me.dgvTicket.AllowUserToAddRows = False
        Me.dgvTicket.AllowUserToDeleteRows = False
        Me.dgvTicket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTicket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.movieName, Me.seatNumber, Me.ageCategory, Me.ticketPrice})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTicket.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTicket.Location = New System.Drawing.Point(28, 38)
        Me.dgvTicket.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTicket.Name = "dgvTicket"
        Me.dgvTicket.ReadOnly = True
        Me.dgvTicket.Size = New System.Drawing.Size(849, 370)
        Me.dgvTicket.TabIndex = 3
        '
        'movieName
        '
        Me.movieName.HeaderText = "Movie Name"
        Me.movieName.Name = "movieName"
        Me.movieName.ReadOnly = True
        '
        'seatNumber
        '
        Me.seatNumber.HeaderText = "Seat Number"
        Me.seatNumber.Name = "seatNumber"
        Me.seatNumber.ReadOnly = True
        '
        'ageCategory
        '
        Me.ageCategory.HeaderText = "Age Category"
        Me.ageCategory.Name = "ageCategory"
        Me.ageCategory.ReadOnly = True
        '
        'ticketPrice
        '
        Me.ticketPrice.HeaderText = "Ticket Price"
        Me.ticketPrice.Name = "ticketPrice"
        Me.ticketPrice.ReadOnly = True
        '
        'btnClose
        '
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(745, 448)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(132, 41)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(39, 412)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "**You can click to select which ticket to discard"
        '
        'frmListTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.BackgroundImage = Global.gpprojecttest.My.Resources.Resources.cinema_red
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(977, 553)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmListTickets"
        Me.Text = "Cinema: Tickets List"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvTicket As DataGridView
    Friend WithEvents movieName As DataGridViewTextBoxColumn
    Friend WithEvents seatNumber As DataGridViewTextBoxColumn
    Friend WithEvents ageCategory As DataGridViewTextBoxColumn
    Friend WithEvents ticketPrice As DataGridViewTextBoxColumn
End Class
