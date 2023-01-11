<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Me.picGTA = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radTNG = New System.Windows.Forms.RadioButton()
        Me.radOnline = New System.Windows.Forms.RadioButton()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.dgvTickets = New System.Windows.Forms.DataGridView()
        Me.movieImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.movieName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.auditoriumName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seatNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ageCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ticketPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movieInfo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.gboPayInfo = New System.Windows.Forms.GroupBox()
        Me.tbpPayment = New System.Windows.Forms.TableLayoutPanel()
        Me.lblBottom = New System.Windows.Forms.Label()
        Me.txtTop = New System.Windows.Forms.TextBox()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.cboBottom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.AuditoriumsTableAdapter = New gpprojecttest.cinemadbDataSetTableAdapters.auditoriumsTableAdapter()
        Me.CinemadbDataSet = New gpprojecttest.cinemadbDataSet()
        Me.TableAdapterManager = New gpprojecttest.cinemadbDataSetTableAdapters.TableAdapterManager()
        Me.Purchase_lineTableAdapter = New gpprojecttest.cinemadbDataSetTableAdapters.purchase_lineTableAdapter()
        Me.PurchasesTableAdapter = New gpprojecttest.cinemadbDataSetTableAdapters.purchasesTableAdapter()
        CType(Me.picGTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboPayInfo.SuspendLayout()
        Me.tbpPayment.SuspendLayout()
        CType(Me.CinemadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGTA
        '
        Me.picGTA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picGTA.BackColor = System.Drawing.Color.Snow
        Me.picGTA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picGTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picGTA.Image = CType(resources.GetObject("picGTA.Image"), System.Drawing.Image)
        Me.picGTA.Location = New System.Drawing.Point(259, 12)
        Me.picGTA.Name = "picGTA"
        Me.picGTA.Size = New System.Drawing.Size(338, 70)
        Me.picGTA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGTA.TabIndex = 4
        Me.picGTA.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.radTNG)
        Me.GroupBox1.Controls.Add(Me.radOnline)
        Me.GroupBox1.Controls.Add(Me.radCash)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 318)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 170)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Method"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "~ 5% Discount"
        '
        'radTNG
        '
        Me.radTNG.AutoSize = True
        Me.radTNG.Location = New System.Drawing.Point(47, 94)
        Me.radTNG.Name = "radTNG"
        Me.radTNG.Size = New System.Drawing.Size(125, 17)
        Me.radTNG.TabIndex = 3
        Me.radTNG.TabStop = True
        Me.radTNG.Text = "Touch 'N Go eWallet"
        Me.radTNG.UseVisualStyleBackColor = True
        '
        'radOnline
        '
        Me.radOnline.AutoSize = True
        Me.radOnline.Location = New System.Drawing.Point(47, 59)
        Me.radOnline.Name = "radOnline"
        Me.radOnline.Size = New System.Drawing.Size(122, 17)
        Me.radOnline.TabIndex = 1
        Me.radOnline.TabStop = True
        Me.radOnline.Text = "FPX/Online Banking"
        Me.radOnline.UseVisualStyleBackColor = True
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Location = New System.Drawing.Point(47, 26)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(49, 17)
        Me.radCash.TabIndex = 0
        Me.radCash.TabStop = True
        Me.radCash.Text = "Cash"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'dgvTickets
        '
        Me.dgvTickets.AllowUserToDeleteRows = False
        Me.dgvTickets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTickets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.movieImage, Me.movieName, Me.auditoriumName, Me.seatNumber, Me.ageCategory, Me.ticketPrice, Me.movieInfo})
        Me.dgvTickets.Location = New System.Drawing.Point(33, 88)
        Me.dgvTickets.Name = "dgvTickets"
        Me.dgvTickets.ReadOnly = True
        Me.dgvTickets.Size = New System.Drawing.Size(801, 224)
        Me.dgvTickets.TabIndex = 6
        '
        'movieImage
        '
        Me.movieImage.HeaderText = "Movie Image"
        Me.movieImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.movieImage.MinimumWidth = 10
        Me.movieImage.Name = "movieImage"
        Me.movieImage.ReadOnly = True
        '
        'movieName
        '
        Me.movieName.HeaderText = "Movie Name"
        Me.movieName.Name = "movieName"
        Me.movieName.ReadOnly = True
        '
        'auditoriumName
        '
        Me.auditoriumName.HeaderText = "Auditorium Name"
        Me.auditoriumName.Name = "auditoriumName"
        Me.auditoriumName.ReadOnly = True
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
        'movieInfo
        '
        Me.movieInfo.HeaderText = "Movie Info"
        Me.movieInfo.Name = "movieInfo"
        Me.movieInfo.ReadOnly = True
        '
        'btnProceed
        '
        Me.btnProceed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProceed.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnProceed.Location = New System.Drawing.Point(719, 502)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(115, 37)
        Me.btnProceed.TabIndex = 10
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'gboPayInfo
        '
        Me.gboPayInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gboPayInfo.Controls.Add(Me.tbpPayment)
        Me.gboPayInfo.Controls.Add(Me.Label1)
        Me.gboPayInfo.Controls.Add(Me.lblPrice)
        Me.gboPayInfo.Location = New System.Drawing.Point(363, 318)
        Me.gboPayInfo.Name = "gboPayInfo"
        Me.gboPayInfo.Size = New System.Drawing.Size(471, 170)
        Me.gboPayInfo.TabIndex = 12
        Me.gboPayInfo.TabStop = False
        Me.gboPayInfo.Text = "Payment Info"
        '
        'tbpPayment
        '
        Me.tbpPayment.ColumnCount = 1
        Me.tbpPayment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbpPayment.Controls.Add(Me.lblBottom, 0, 2)
        Me.tbpPayment.Controls.Add(Me.txtTop, 0, 1)
        Me.tbpPayment.Controls.Add(Me.lblTop, 0, 0)
        Me.tbpPayment.Controls.Add(Me.cboBottom, 0, 3)
        Me.tbpPayment.Location = New System.Drawing.Point(19, 19)
        Me.tbpPayment.Name = "tbpPayment"
        Me.tbpPayment.RowCount = 4
        Me.tbpPayment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.5625!))
        Me.tbpPayment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.4375!))
        Me.tbpPayment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tbpPayment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.tbpPayment.Size = New System.Drawing.Size(238, 133)
        Me.tbpPayment.TabIndex = 2
        '
        'lblBottom
        '
        Me.lblBottom.AutoSize = True
        Me.lblBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottom.Location = New System.Drawing.Point(3, 64)
        Me.lblBottom.Name = "lblBottom"
        Me.lblBottom.Size = New System.Drawing.Size(0, 13)
        Me.lblBottom.TabIndex = 3
        '
        'txtTop
        '
        Me.txtTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTop.Location = New System.Drawing.Point(3, 20)
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(232, 20)
        Me.txtTop.TabIndex = 0
        '
        'lblTop
        '
        Me.lblTop.AutoSize = True
        Me.lblTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTop.Location = New System.Drawing.Point(3, 0)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(0, 13)
        Me.lblTop.TabIndex = 2
        '
        'cboBottom
        '
        Me.cboBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboBottom.FormattingEnabled = True
        Me.cboBottom.Location = New System.Drawing.Point(3, 89)
        Me.cboBottom.Name = "cboBottom"
        Me.cboBottom.Size = New System.Drawing.Size(232, 21)
        Me.cboBottom.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "~Before Tax"
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrice.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(263, 22)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(192, 23)
        Me.lblPrice.TabIndex = 0
        Me.lblPrice.Text = "Total Price: "
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(598, 502)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(115, 37)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'AuditoriumsTableAdapter
        '
        Me.AuditoriumsTableAdapter.ClearBeforeFill = True
        '
        'CinemadbDataSet
        '
        Me.CinemadbDataSet.DataSetName = "cinemadbDataSet"
        Me.CinemadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.auditoriumsTableAdapter = Me.AuditoriumsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customersTableAdapter = Nothing
        Me.TableAdapterManager.moviesTableAdapter = Nothing
        Me.TableAdapterManager.purchase_lineTableAdapter = Nothing
        Me.TableAdapterManager.purchasesTableAdapter = Nothing
        Me.TableAdapterManager.showtimesTableAdapter = Nothing
        Me.TableAdapterManager.ticket_priceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = gpprojecttest.cinemadbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Purchase_lineTableAdapter
        '
        Me.Purchase_lineTableAdapter.ClearBeforeFill = True
        '
        'PurchasesTableAdapter
        '
        Me.PurchasesTableAdapter.ClearBeforeFill = True
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gpprojecttest.My.Resources.Resources.cinema_red
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(858, 586)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gboPayInfo)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.dgvTickets)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picGTA)
        Me.MaximizeBox = False
        Me.Name = "frmPayment"
        Me.Text = "Cinema: Payment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picGTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboPayInfo.ResumeLayout(False)
        Me.gboPayInfo.PerformLayout()
        Me.tbpPayment.ResumeLayout(False)
        Me.tbpPayment.PerformLayout()
        CType(Me.CinemadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picGTA As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvTickets As DataGridView
    Friend WithEvents radTNG As RadioButton
    Friend WithEvents radOnline As RadioButton
    Friend WithEvents radCash As RadioButton
    Friend WithEvents btnProceed As Button
    Friend WithEvents gboPayInfo As GroupBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbpPayment As TableLayoutPanel
    Friend WithEvents AuditoriumsTableAdapter As cinemadbDataSetTableAdapters.auditoriumsTableAdapter
    Friend WithEvents CinemadbDataSet As cinemadbDataSet
    Friend WithEvents TableAdapterManager As cinemadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents movieImage As DataGridViewImageColumn
    Friend WithEvents movieName As DataGridViewTextBoxColumn
    Friend WithEvents auditoriumName As DataGridViewTextBoxColumn
    Friend WithEvents seatNumber As DataGridViewTextBoxColumn
    Friend WithEvents ageCategory As DataGridViewTextBoxColumn
    Friend WithEvents ticketPrice As DataGridViewTextBoxColumn
    Friend WithEvents movieInfo As DataGridViewButtonColumn
    Friend WithEvents txtTop As TextBox
    Friend WithEvents lblBottom As Label
    Friend WithEvents lblTop As Label
    Friend WithEvents cboBottom As ComboBox
    Friend WithEvents Purchase_lineTableAdapter As cinemadbDataSetTableAdapters.purchase_lineTableAdapter
    Friend WithEvents PurchasesTableAdapter As cinemadbDataSetTableAdapters.purchasesTableAdapter
End Class
