<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaffTransaction))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvInvoice = New System.Windows.Forms.DataGridView()
        Me.invoiceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateCreated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClearTable = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PurchasesTableAdapter = New gpprojecttest.cinemadbDataSetTableAdapters.purchasesTableAdapter()
        Me.CinemadbDataSet = New gpprojecttest.cinemadbDataSet()
        Me.TableAdapterManager = New gpprojecttest.cinemadbDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox4.Controls.Add(Me.dgvInvoice)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 108)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(1013, 300)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Invoice List"
        '
        'dgvInvoice
        '
        Me.dgvInvoice.AllowUserToAddRows = False
        Me.dgvInvoice.AllowUserToDeleteRows = False
        Me.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invoiceID, Me.customerName, Me.dateCreated})
        Me.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInvoice.Location = New System.Drawing.Point(4, 19)
        Me.dgvInvoice.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvInvoice.Name = "dgvInvoice"
        Me.dgvInvoice.ReadOnly = True
        Me.dgvInvoice.Size = New System.Drawing.Size(1005, 277)
        Me.dgvInvoice.TabIndex = 0
        '
        'invoiceID
        '
        Me.invoiceID.FillWeight = 30.45685!
        Me.invoiceID.HeaderText = "ID"
        Me.invoiceID.Name = "invoiceID"
        Me.invoiceID.ReadOnly = True
        '
        'customerName
        '
        Me.customerName.FillWeight = 134.7716!
        Me.customerName.HeaderText = "Customer Name"
        Me.customerName.Name = "customerName"
        Me.customerName.ReadOnly = True
        '
        'dateCreated
        '
        Me.dateCreated.FillWeight = 134.7716!
        Me.dateCreated.HeaderText = "Date Created"
        Me.dateCreated.Name = "dateCreated"
        Me.dateCreated.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1013, 86)
        Me.GroupBox2.TabIndex = 26
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
        Me.Label9.Size = New System.Drawing.Size(260, 42)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "TRANSACTION"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.btnClearTable)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.btnBack)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 416)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1013, 123)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        '
        'btnClearTable
        '
        Me.btnClearTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearTable.Location = New System.Drawing.Point(666, 42)
        Me.btnClearTable.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClearTable.Name = "btnClearTable"
        Me.btnClearTable.Size = New System.Drawing.Size(157, 48)
        Me.btnClearTable.TabIndex = 22
        Me.btnClearTable.Text = "Clear Table"
        Me.btnClearTable.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "**Click on an invoice to view it"
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
        'PurchasesTableAdapter
        '
        Me.PurchasesTableAdapter.ClearBeforeFill = True
        '
        'CinemadbDataSet
        '
        Me.CinemadbDataSet.DataSetName = "cinemadbDataSet"
        Me.CinemadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.auditoriumsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customersTableAdapter = Nothing
        Me.TableAdapterManager.moviesTableAdapter = Nothing
        Me.TableAdapterManager.purchase_lineTableAdapter = Nothing
        Me.TableAdapterManager.purchasesTableAdapter = Me.PurchasesTableAdapter
        Me.TableAdapterManager.showtimesTableAdapter = Nothing
        Me.TableAdapterManager.ticket_priceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = gpprojecttest.cinemadbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmStaffTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gpprojecttest.My.Resources.Resources.netflix_img
        Me.ClientSize = New System.Drawing.Size(1045, 554)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmStaffTransaction"
        Me.Text = "Staff: View Transaction"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CinemadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvInvoice As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnBack As Button
    Friend WithEvents PurchasesTableAdapter As cinemadbDataSetTableAdapters.purchasesTableAdapter
    Friend WithEvents CinemadbDataSet As cinemadbDataSet
    Friend WithEvents TableAdapterManager As cinemadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents invoiceID As DataGridViewTextBoxColumn
    Friend WithEvents customerName As DataGridViewTextBoxColumn
    Friend WithEvents dateCreated As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClearTable As Button
End Class
