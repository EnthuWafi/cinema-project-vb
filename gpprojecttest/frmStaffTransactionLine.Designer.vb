<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffTransactionLine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaffTransactionLine))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvInvoiceLine = New System.Windows.Forms.DataGridView()
        Me.movieName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.auditoriumName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seatNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ticketPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.CinemadbDataSet = New gpprojecttest.cinemadbDataSet()
        Me.Purchase_lineTableAdapter = New gpprojecttest.cinemadbDataSetTableAdapters.purchase_lineTableAdapter()
        Me.TableAdapterManager = New gpprojecttest.cinemadbDataSetTableAdapters.TableAdapterManager()
        Me.PurchasesTableAdapter = New gpprojecttest.cinemadbDataSetTableAdapters.purchasesTableAdapter()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvInvoiceLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CinemadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.dgvInvoiceLine)
        Me.GroupBox4.Location = New System.Drawing.Point(37, 108)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(1013, 300)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Invoice"
        '
        'dgvInvoiceLine
        '
        Me.dgvInvoiceLine.AllowUserToAddRows = False
        Me.dgvInvoiceLine.AllowUserToDeleteRows = False
        Me.dgvInvoiceLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInvoiceLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoiceLine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.movieName, Me.auditoriumName, Me.seatNumber, Me.ticketPrice})
        Me.dgvInvoiceLine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInvoiceLine.Location = New System.Drawing.Point(4, 19)
        Me.dgvInvoiceLine.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvInvoiceLine.Name = "dgvInvoiceLine"
        Me.dgvInvoiceLine.ReadOnly = True
        Me.dgvInvoiceLine.Size = New System.Drawing.Size(1005, 277)
        Me.dgvInvoiceLine.TabIndex = 0
        '
        'movieName
        '
        Me.movieName.FillWeight = 113.0288!
        Me.movieName.HeaderText = "Movie"
        Me.movieName.Name = "movieName"
        Me.movieName.ReadOnly = True
        '
        'auditoriumName
        '
        Me.auditoriumName.FillWeight = 113.0288!
        Me.auditoriumName.HeaderText = "Auditorium Name"
        Me.auditoriumName.Name = "auditoriumName"
        Me.auditoriumName.ReadOnly = True
        '
        'seatNumber
        '
        Me.seatNumber.FillWeight = 60.9137!
        Me.seatNumber.HeaderText = "Seat"
        Me.seatNumber.Name = "seatNumber"
        Me.seatNumber.ReadOnly = True
        '
        'ticketPrice
        '
        Me.ticketPrice.FillWeight = 113.0288!
        Me.ticketPrice.HeaderText = "Ticket Price"
        Me.ticketPrice.Name = "ticketPrice"
        Me.ticketPrice.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1013, 86)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label9.Location = New System.Drawing.Point(29, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 42)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "INVOICE: "
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.btnBack)
        Me.GroupBox3.Location = New System.Drawing.Point(37, 416)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1013, 123)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(666, 42)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(157, 48)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.Location = New System.Drawing.Point(831, 42)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(157, 48)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'CinemadbDataSet
        '
        Me.CinemadbDataSet.DataSetName = "cinemadbDataSet"
        Me.CinemadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Purchase_lineTableAdapter
        '
        Me.Purchase_lineTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.auditoriumsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customersTableAdapter = Nothing
        Me.TableAdapterManager.moviesTableAdapter = Nothing
        Me.TableAdapterManager.purchase_lineTableAdapter = Me.Purchase_lineTableAdapter
        Me.TableAdapterManager.purchasesTableAdapter = Nothing
        Me.TableAdapterManager.showtimesTableAdapter = Nothing
        Me.TableAdapterManager.ticket_priceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = gpprojecttest.cinemadbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PurchasesTableAdapter
        '
        Me.PurchasesTableAdapter.ClearBeforeFill = True
        '
        'frmStaffTransactionLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmStaffTransactionLine"
        Me.Text = "Transaction"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvInvoiceLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.CinemadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvInvoiceLine As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnBack As Button
    Friend WithEvents movieName As DataGridViewTextBoxColumn
    Friend WithEvents auditoriumName As DataGridViewTextBoxColumn
    Friend WithEvents seatNumber As DataGridViewTextBoxColumn
    Friend WithEvents ticketPrice As DataGridViewTextBoxColumn
    Friend WithEvents CinemadbDataSet As cinemadbDataSet
    Friend WithEvents Purchase_lineTableAdapter As cinemadbDataSetTableAdapters.purchase_lineTableAdapter
    Friend WithEvents TableAdapterManager As cinemadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnDelete As Button
    Friend WithEvents PurchasesTableAdapter As cinemadbDataSetTableAdapters.purchasesTableAdapter
End Class
