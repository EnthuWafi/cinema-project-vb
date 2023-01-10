<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeatSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeatSelection))
        Me.picGTA = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblMovie = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpSeatSelection = New System.Windows.Forms.GroupBox()
        Me.lblAuditorium = New System.Windows.Forms.Label()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton19 = New System.Windows.Forms.RadioButton()
        Me.RadioButton20 = New System.Windows.Forms.RadioButton()
        Me.RadioButton21 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.CinemadbDataSet = New gpprojecttest.cinemadbDataSet()
        Me.AuditoriumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuditoriumsTableAdapter = New gpprojecttest.cinemadbDataSetTableAdapters.auditoriumsTableAdapter()
        Me.TableAdapterManager = New gpprojecttest.cinemadbDataSetTableAdapters.TableAdapterManager()
        Me.Purchase_lineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Purchase_lineTableAdapter = New gpprojecttest.cinemadbDataSetTableAdapters.purchase_lineTableAdapter()
        CType(Me.picGTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpSeatSelection.SuspendLayout()
        CType(Me.CinemadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditoriumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Purchase_lineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGTA
        '
        Me.picGTA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picGTA.BackColor = System.Drawing.Color.Snow
        Me.picGTA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picGTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picGTA.Image = CType(resources.GetObject("picGTA.Image"), System.Drawing.Image)
        Me.picGTA.Location = New System.Drawing.Point(209, 12)
        Me.picGTA.Name = "picGTA"
        Me.picGTA.Size = New System.Drawing.Size(338, 70)
        Me.picGTA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGTA.TabIndex = 4
        Me.picGTA.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Controls.Add(Me.lblPrice)
        Me.GroupBox1.Controls.Add(Me.lblMovie)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnConfirm)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 370)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 136)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Location = New System.Drawing.Point(48, 76)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(200, 21)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "Price:"
        '
        'lblMovie
        '
        Me.lblMovie.BackColor = System.Drawing.SystemColors.Control
        Me.lblMovie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMovie.Location = New System.Drawing.Point(48, 48)
        Me.lblMovie.Name = "lblMovie"
        Me.lblMovie.Size = New System.Drawing.Size(200, 21)
        Me.lblMovie.TabIndex = 3
        Me.lblMovie.Text = "Movie: "
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(544, 85)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 32)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(426, 85)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(112, 32)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "**Disabled Seat are seats that are already taken"
        '
        'grpSeatSelection
        '
        Me.grpSeatSelection.BackColor = System.Drawing.Color.Firebrick
        Me.grpSeatSelection.Controls.Add(Me.lblAuditorium)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton15)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton16)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton17)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton18)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton19)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton20)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton21)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton8)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton9)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton10)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton11)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton12)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton13)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton14)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton7)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton6)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton5)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton4)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton3)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton2)
        Me.grpSeatSelection.Controls.Add(Me.RadioButton1)
        Me.grpSeatSelection.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpSeatSelection.Location = New System.Drawing.Point(40, 88)
        Me.grpSeatSelection.Name = "grpSeatSelection"
        Me.grpSeatSelection.Size = New System.Drawing.Size(674, 276)
        Me.grpSeatSelection.TabIndex = 6
        Me.grpSeatSelection.TabStop = False
        Me.grpSeatSelection.Text = "Seat Selection"
        '
        'lblAuditorium
        '
        Me.lblAuditorium.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblAuditorium.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAuditorium.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuditorium.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAuditorium.Location = New System.Drawing.Point(33, 28)
        Me.lblAuditorium.Name = "lblAuditorium"
        Me.lblAuditorium.Size = New System.Drawing.Size(191, 22)
        Me.lblAuditorium.TabIndex = 21
        Me.lblAuditorium.Text = "Auditorium: "
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.Location = New System.Drawing.Point(529, 216)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton15.TabIndex = 20
        Me.RadioButton15.Text = "21"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Location = New System.Drawing.Point(475, 216)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton16.TabIndex = 19
        Me.RadioButton16.Text = "20"
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'RadioButton17
        '
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.Location = New System.Drawing.Point(372, 216)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton17.TabIndex = 18
        Me.RadioButton17.Text = "19"
        Me.RadioButton17.UseVisualStyleBackColor = True
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.Location = New System.Drawing.Point(318, 216)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton18.TabIndex = 17
        Me.RadioButton18.Text = "18"
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'RadioButton19
        '
        Me.RadioButton19.AutoSize = True
        Me.RadioButton19.Location = New System.Drawing.Point(264, 216)
        Me.RadioButton19.Name = "RadioButton19"
        Me.RadioButton19.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton19.TabIndex = 16
        Me.RadioButton19.Text = "17"
        Me.RadioButton19.UseVisualStyleBackColor = True
        '
        'RadioButton20
        '
        Me.RadioButton20.AutoSize = True
        Me.RadioButton20.Location = New System.Drawing.Point(156, 216)
        Me.RadioButton20.Name = "RadioButton20"
        Me.RadioButton20.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton20.TabIndex = 15
        Me.RadioButton20.Text = "16"
        Me.RadioButton20.UseVisualStyleBackColor = True
        '
        'RadioButton21
        '
        Me.RadioButton21.AutoSize = True
        Me.RadioButton21.Location = New System.Drawing.Point(102, 216)
        Me.RadioButton21.Name = "RadioButton21"
        Me.RadioButton21.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton21.TabIndex = 14
        Me.RadioButton21.Text = "15"
        Me.RadioButton21.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(529, 155)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton8.TabIndex = 13
        Me.RadioButton8.Text = "14"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(475, 155)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton9.TabIndex = 12
        Me.RadioButton9.Text = "13"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(372, 155)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton10.TabIndex = 11
        Me.RadioButton10.Text = "12"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(318, 155)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton11.TabIndex = 10
        Me.RadioButton11.Text = "11"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(264, 155)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton12.TabIndex = 9
        Me.RadioButton12.Text = "10"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(156, 155)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton13.TabIndex = 8
        Me.RadioButton13.Text = "9"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.Location = New System.Drawing.Point(102, 155)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton14.TabIndex = 7
        Me.RadioButton14.Text = "8"
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(529, 94)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.Text = "7"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(475, 94)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Text = "6"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(372, 94)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(318, 94)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(264, 94)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(156, 94)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(102, 94)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'CinemadbDataSet
        '
        Me.CinemadbDataSet.DataSetName = "cinemadbDataSet"
        Me.CinemadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuditoriumsBindingSource
        '
        Me.AuditoriumsBindingSource.DataMember = "auditoriums"
        Me.AuditoriumsBindingSource.DataSource = Me.CinemadbDataSet
        '
        'AuditoriumsTableAdapter
        '
        Me.AuditoriumsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ticketsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = gpprojecttest.cinemadbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Purchase_lineBindingSource
        '
        Me.Purchase_lineBindingSource.DataMember = "purchase_line"
        Me.Purchase_lineBindingSource.DataSource = Me.CinemadbDataSet
        '
        'Purchase_lineTableAdapter
        '
        Me.Purchase_lineTableAdapter.ClearBeforeFill = True
        '
        'frmSeatSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gpprojecttest.My.Resources.Resources.cinema_red
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(737, 518)
        Me.Controls.Add(Me.grpSeatSelection)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picGTA)
        Me.MaximizeBox = False
        Me.Name = "frmSeatSelection"
        Me.Text = "Ticket: Seat Selection"
        CType(Me.picGTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpSeatSelection.ResumeLayout(False)
        Me.grpSeatSelection.PerformLayout()
        CType(Me.CinemadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditoriumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Purchase_lineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picGTA As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblMovie As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents grpSeatSelection As GroupBox
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents RadioButton17 As RadioButton
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents RadioButton19 As RadioButton
    Friend WithEvents RadioButton20 As RadioButton
    Friend WithEvents RadioButton21 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lblAuditorium As Label
    Friend WithEvents CinemadbDataSet As cinemadbDataSet
    Friend WithEvents AuditoriumsBindingSource As BindingSource
    Friend WithEvents AuditoriumsTableAdapter As cinemadbDataSetTableAdapters.auditoriumsTableAdapter
    Friend WithEvents TableAdapterManager As cinemadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Purchase_lineBindingSource As BindingSource
    Friend WithEvents Purchase_lineTableAdapter As cinemadbDataSetTableAdapters.purchase_lineTableAdapter
End Class
