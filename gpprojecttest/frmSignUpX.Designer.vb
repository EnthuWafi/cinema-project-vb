<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSignUpX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignUpX))
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CinemadbDataSet = New gpprojecttest.cinemadbDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New gpprojecttest.cinemadbDataSetTableAdapters.TableAdapterManager()
        Me.CustomersTableAdapter = New gpprojecttest.cinemadbDataSetTableAdapters.customersTableAdapter()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CinemadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFName
        '
        Me.txtFName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "cust_fname", True))
        Me.txtFName.Location = New System.Drawing.Point(149, 53)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFName.MaxLength = 50
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(301, 22)
        Me.txtFName.TabIndex = 0
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "customers"
        Me.CustomersBindingSource.DataSource = Me.CinemadbDataSet
        '
        'CinemadbDataSet
        '
        Me.CinemadbDataSet.DataSetName = "cinemadbDataSet"
        Me.CinemadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 112)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(504, 356)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sign Up"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtAddress)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtPhone)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 194)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(488, 154)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Optional"
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "address", True))
        Me.txtAddress.Location = New System.Drawing.Point(141, 87)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.MaxLength = 12
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(301, 22)
        Me.txtAddress.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(69, 91)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Address:"
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "phone_number", True))
        Me.txtPhone.Location = New System.Drawing.Point(141, 41)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.MaxLength = 12
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(301, 22)
        Me.txtPhone.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 44)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Phone Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "email", True))
        Me.txtEmail.Location = New System.Drawing.Point(149, 142)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(301, 22)
        Me.txtEmail.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name:"
        '
        'txtLName
        '
        Me.txtLName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "cust_lname", True))
        Me.txtLName.Location = New System.Drawing.Point(149, 97)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLName.MaxLength = 50
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(301, 22)
        Me.txtLName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(868, 86)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label9.Location = New System.Drawing.Point(29, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(485, 42)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "SIGN UP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "User name:"
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "cust_username", True))
        Me.txtUsername.Location = New System.Drawing.Point(112, 53)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.MaxLength = 10
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(207, 22)
        Me.txtUsername.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 127)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "cust_password", True))
        Me.txtPassword.Location = New System.Drawing.Point(113, 123)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(207, 22)
        Me.txtPassword.TabIndex = 8
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(109, 81)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 24)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "*Username can be alphanumeric with" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "less or equal to 10 character"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.btnClear)
        Me.GroupBox3.Controls.Add(Me.btnSignUp)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtUsername)
        Me.GroupBox3.Controls.Add(Me.txtPassword)
        Me.GroupBox3.Location = New System.Drawing.Point(547, 112)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(356, 356)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Account Info"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.Location = New System.Drawing.Point(85, 262)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(184, 41)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSignUp
        '
        Me.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSignUp.Location = New System.Drawing.Point(85, 214)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(184, 41)
        Me.btnSignUp.TabIndex = 19
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.auditoriumsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.moviesTableAdapter = Nothing
        Me.TableAdapterManager.purchase_lineTableAdapter = Nothing
        Me.TableAdapterManager.purchasesTableAdapter = Nothing
        Me.TableAdapterManager.showtimesTableAdapter = Nothing
        Me.TableAdapterManager.ticket_priceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = gpprojecttest.cinemadbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'frmSignUpX
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = Global.gpprojecttest.My.Resources.Resources.netflix_img
        Me.ClientSize = New System.Drawing.Size(931, 491)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmSignUpX"
        Me.Text = "Cinema: Sign Up"
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CinemadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtFName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents CinemadbDataSet As cinemadbDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As cinemadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersTableAdapter As cinemadbDataSetTableAdapters.customersTableAdapter
    Friend WithEvents errorProvider As ErrorProvider
End Class
