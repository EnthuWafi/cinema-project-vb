<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picGTA = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSeatSelection = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTicketCount = New System.Windows.Forms.Label()
        Me.btnListOfTicket = New System.Windows.Forms.Button()
        Me.btnTicket = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMovie = New System.Windows.Forms.ComboBox()
        Me.flpMovie = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblMovie = New System.Windows.Forms.Label()
        Me.lblSeat = New System.Windows.Forms.Label()
        Me.CinemadbDataSet = New gpprojecttest.cinemadbDataSet()
        Me.ShowtimesTableAdapter = New gpprojecttest.cinemadbDataSetTableAdapters.showtimesTableAdapter()
        Me.TableAdapterManager = New gpprojecttest.cinemadbDataSetTableAdapters.TableAdapterManager()
        Me.AuditoriumsTableAdapter = New gpprojecttest.cinemadbDataSetTableAdapters.auditoriumsTableAdapter()
        Me.Ticket_priceTableAdapter = New gpprojecttest.cinemadbDataSetTableAdapters.ticket_priceTableAdapter()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.picGTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CinemadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGTA
        '
        Me.picGTA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picGTA.BackColor = System.Drawing.Color.Snow
        Me.picGTA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picGTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picGTA.Image = CType(resources.GetObject("picGTA.Image"), System.Drawing.Image)
        Me.picGTA.Location = New System.Drawing.Point(383, 15)
        Me.picGTA.Margin = New System.Windows.Forms.Padding(4)
        Me.picGTA.Name = "picGTA"
        Me.picGTA.Size = New System.Drawing.Size(449, 85)
        Me.picGTA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGTA.TabIndex = 3
        Me.picGTA.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.IndianRed
        Me.GroupBox1.Controls.Add(Me.btnSeatSelection)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblTicketCount)
        Me.GroupBox1.Controls.Add(Me.btnListOfTicket)
        Me.GroupBox1.Controls.Add(Me.btnTicket)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboCategory)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(500, 489)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(701, 137)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets"
        '
        'btnSeatSelection
        '
        Me.btnSeatSelection.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSeatSelection.Location = New System.Drawing.Point(357, 41)
        Me.btnSeatSelection.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSeatSelection.Name = "btnSeatSelection"
        Me.btnSeatSelection.Size = New System.Drawing.Size(137, 32)
        Me.btnSeatSelection.TabIndex = 11
        Me.btnSeatSelection.Text = "Seat Selection"
        Me.btnSeatSelection.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Seat:"
        '
        'lblTicketCount
        '
        Me.lblTicketCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTicketCount.AutoSize = True
        Me.lblTicketCount.Location = New System.Drawing.Point(569, 20)
        Me.lblTicketCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTicketCount.Name = "lblTicketCount"
        Me.lblTicketCount.Size = New System.Drawing.Size(80, 13)
        Me.lblTicketCount.TabIndex = 6
        Me.lblTicketCount.Text = "Ticket Count: 0"
        '
        'btnListOfTicket
        '
        Me.btnListOfTicket.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListOfTicket.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnListOfTicket.Location = New System.Drawing.Point(541, 80)
        Me.btnListOfTicket.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListOfTicket.Name = "btnListOfTicket"
        Me.btnListOfTicket.Size = New System.Drawing.Size(137, 32)
        Me.btnListOfTicket.TabIndex = 5
        Me.btnListOfTicket.Text = "List of Tickets"
        Me.btnListOfTicket.UseVisualStyleBackColor = True
        '
        'btnTicket
        '
        Me.btnTicket.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTicket.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTicket.Location = New System.Drawing.Point(541, 41)
        Me.btnTicket.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTicket.Name = "btnTicket"
        Me.btnTicket.Size = New System.Drawing.Size(137, 32)
        Me.btnTicket.TabIndex = 4
        Me.btnTicket.Text = "Add Ticket"
        Me.btnTicket.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Category:"
        '
        'cboCategory
        '
        Me.cboCategory.BackColor = System.Drawing.SystemColors.Window
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Adult", "Children"})
        Me.cboCategory.Location = New System.Drawing.Point(125, 46)
        Me.cboCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(139, 21)
        Me.cboCategory.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Movie Name:"
        '
        'cboMovie
        '
        Me.cboMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMovie.FormattingEnabled = True
        Me.cboMovie.Location = New System.Drawing.Point(145, 47)
        Me.cboMovie.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMovie.Name = "cboMovie"
        Me.cboMovie.Size = New System.Drawing.Size(245, 21)
        Me.cboMovie.TabIndex = 0
        '
        'flpMovie
        '
        Me.flpMovie.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpMovie.AutoScroll = True
        Me.flpMovie.BackColor = System.Drawing.Color.IndianRed
        Me.flpMovie.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMovie.Location = New System.Drawing.Point(47, 108)
        Me.flpMovie.Margin = New System.Windows.Forms.Padding(4)
        Me.flpMovie.Name = "flpMovie"
        Me.flpMovie.Padding = New System.Windows.Forms.Padding(4)
        Me.flpMovie.Size = New System.Drawing.Size(1155, 373)
        Me.flpMovie.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.IndianRed
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cboMovie)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(47, 489)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(445, 137)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Movies"
        '
        'btnProceed
        '
        Me.btnProceed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProceed.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnProceed.Location = New System.Drawing.Point(1032, 644)
        Me.btnProceed.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(153, 46)
        Me.btnProceed.TabIndex = 9
        Me.btnProceed.Text = "Next"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.Location = New System.Drawing.Point(893, 76)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(265, 22)
        Me.dtpDate.TabIndex = 1
        Me.dtpDate.Value = New Date(2023, 1, 9, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 60)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 33)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "SHOWTIMES:"
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Location = New System.Drawing.Point(335, 644)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(267, 26)
        Me.lblPrice.TabIndex = 12
        Me.lblPrice.Text = "Price:"
        '
        'lblMovie
        '
        Me.lblMovie.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMovie.BackColor = System.Drawing.SystemColors.Control
        Me.lblMovie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMovie.Location = New System.Drawing.Point(47, 644)
        Me.lblMovie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMovie.Name = "lblMovie"
        Me.lblMovie.Size = New System.Drawing.Size(267, 26)
        Me.lblMovie.TabIndex = 11
        Me.lblMovie.Text = "Movie: "
        '
        'lblSeat
        '
        Me.lblSeat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeat.BackColor = System.Drawing.SystemColors.Control
        Me.lblSeat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSeat.Location = New System.Drawing.Point(625, 644)
        Me.lblSeat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeat.Name = "lblSeat"
        Me.lblSeat.Size = New System.Drawing.Size(213, 26)
        Me.lblSeat.TabIndex = 13
        Me.lblSeat.Text = "Seat Number:"
        '
        'CinemadbDataSet
        '
        Me.CinemadbDataSet.DataSetName = "cinemadbDataSet"
        Me.CinemadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShowtimesTableAdapter
        '
        Me.ShowtimesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.auditoriumsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customersTableAdapter = Nothing
        Me.TableAdapterManager.moviesTableAdapter = Nothing
        Me.TableAdapterManager.purchase_lineTableAdapter = Nothing
        Me.TableAdapterManager.purchasesTableAdapter = Nothing
        Me.TableAdapterManager.showtimesTableAdapter = Me.ShowtimesTableAdapter
        Me.TableAdapterManager.ticket_priceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = gpprojecttest.cinemadbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AuditoriumsTableAdapter
        '
        Me.AuditoriumsTableAdapter.ClearBeforeFill = True
        '
        'Ticket_priceTableAdapter
        '
        Me.Ticket_priceTableAdapter.ClearBeforeFill = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1217, 740)
        Me.Controls.Add(Me.lblSeat)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblMovie)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.flpMovie)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picGTA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Cinema: Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picGTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CinemadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGTA As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMovie As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents flpMovie As FlowLayoutPanel
    Friend WithEvents lblTicketCount As Label
    Friend WithEvents btnListOfTicket As Button
    Friend WithEvents btnTicket As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnProceed As Button
    Friend WithEvents btnSeatSelection As Button
    Friend WithEvents CinemadbDataSet As cinemadbDataSet
    Friend WithEvents ShowtimesTableAdapter As cinemadbDataSetTableAdapters.showtimesTableAdapter
    Friend WithEvents TableAdapterManager As cinemadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblMovie As Label
    Friend WithEvents AuditoriumsTableAdapter As cinemadbDataSetTableAdapters.auditoriumsTableAdapter
    Friend WithEvents Ticket_priceTableAdapter As cinemadbDataSetTableAdapters.ticket_priceTableAdapter
    Friend WithEvents lblSeat As Label
    Friend WithEvents errorProvider As ErrorProvider
End Class
