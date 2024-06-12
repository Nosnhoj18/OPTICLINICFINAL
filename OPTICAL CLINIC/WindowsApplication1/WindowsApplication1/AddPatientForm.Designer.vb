<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPatientForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPatientForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnadmininfo = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnappointment = New System.Windows.Forms.Button()
        Me.btnaddpatient = New System.Windows.Forms.Button()
        Me.btndashboard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnpatientlogs = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtpid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtnationality = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.cmbbloodtype = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtmobile = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbsex = New System.Windows.Forms.ComboBox()
        Me.dpdate = New System.Windows.Forms.DateTimePicker()
        Me.txtzip = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.btnadmininfo)
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnappointment)
        Me.Panel1.Controls.Add(Me.btnaddpatient)
        Me.Panel1.Controls.Add(Me.btndashboard)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnpatientlogs)
        Me.Panel1.Location = New System.Drawing.Point(-5, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 734)
        Me.Panel1.TabIndex = 0
        '
        'btnadmininfo
        '
        Me.btnadmininfo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnadmininfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadmininfo.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadmininfo.Image = CType(resources.GetObject("btnadmininfo.Image"), System.Drawing.Image)
        Me.btnadmininfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadmininfo.Location = New System.Drawing.Point(4, 485)
        Me.btnadmininfo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadmininfo.Name = "btnadmininfo"
        Me.btnadmininfo.Size = New System.Drawing.Size(402, 82)
        Me.btnadmininfo.TabIndex = 31
        Me.btnadmininfo.Text = " Admin Info"
        Me.btnadmininfo.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Image = CType(resources.GetObject("btnlogout.Image"), System.Drawing.Image)
        Me.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogout.Location = New System.Drawing.Point(5, 575)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(402, 82)
        Me.btnlogout.TabIndex = 18
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'btnappointment
        '
        Me.btnappointment.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnappointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnappointment.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnappointment.Image = CType(resources.GetObject("btnappointment.Image"), System.Drawing.Image)
        Me.btnappointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnappointment.Location = New System.Drawing.Point(5, 250)
        Me.btnappointment.Margin = New System.Windows.Forms.Padding(4)
        Me.btnappointment.Name = "btnappointment"
        Me.btnappointment.Size = New System.Drawing.Size(402, 82)
        Me.btnappointment.TabIndex = 21
        Me.btnappointment.Text = "    Appointment"
        Me.btnappointment.UseVisualStyleBackColor = False
        '
        'btnaddpatient
        '
        Me.btnaddpatient.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnaddpatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddpatient.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddpatient.Image = CType(resources.GetObject("btnaddpatient.Image"), System.Drawing.Image)
        Me.btnaddpatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddpatient.Location = New System.Drawing.Point(5, 407)
        Me.btnaddpatient.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaddpatient.Name = "btnaddpatient"
        Me.btnaddpatient.Size = New System.Drawing.Size(402, 82)
        Me.btnaddpatient.TabIndex = 19
        Me.btnaddpatient.Text = " Add Patient"
        Me.btnaddpatient.UseVisualStyleBackColor = False
        '
        'btndashboard
        '
        Me.btndashboard.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndashboard.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashboard.Image = CType(resources.GetObject("btndashboard.Image"), System.Drawing.Image)
        Me.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndashboard.Location = New System.Drawing.Point(5, 172)
        Me.btndashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.Size = New System.Drawing.Size(402, 82)
        Me.btndashboard.TabIndex = 17
        Me.btndashboard.Text = "Dashboard"
        Me.btndashboard.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(160, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 50)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Optical Clinic "
        '
        'btnpatientlogs
        '
        Me.btnpatientlogs.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnpatientlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpatientlogs.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpatientlogs.Image = CType(resources.GetObject("btnpatientlogs.Image"), System.Drawing.Image)
        Me.btnpatientlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpatientlogs.Location = New System.Drawing.Point(5, 329)
        Me.btnpatientlogs.Margin = New System.Windows.Forms.Padding(4)
        Me.btnpatientlogs.Name = "btnpatientlogs"
        Me.btnpatientlogs.Size = New System.Drawing.Size(402, 82)
        Me.btnpatientlogs.TabIndex = 20
        Me.btnpatientlogs.Text = "  Patient Logs"
        Me.btnpatientlogs.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Controls.Add(Me.btnadd)
        Me.Panel3.Location = New System.Drawing.Point(1231, 199)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(249, 246)
        Me.Panel3.TabIndex = 27
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.White
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(19, 148)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(213, 50)
        Me.btnsave.TabIndex = 27
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.White
        Me.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnadd.FlatAppearance.BorderSize = 0
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.Black
        Me.btnadd.Location = New System.Drawing.Point(19, 62)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(213, 50)
        Me.btnadd.TabIndex = 25
        Me.btnadd.Text = "Add Patient"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.txtpid)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtname)
        Me.Panel2.Controls.Add(Me.txtnationality)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtaddress)
        Me.Panel2.Controls.Add(Me.cmbbloodtype)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtmobile)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtemail)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cmbsex)
        Me.Panel2.Controls.Add(Me.dpdate)
        Me.Panel2.Controls.Add(Me.txtzip)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(421, 114)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(787, 402)
        Me.Panel2.TabIndex = 26
        '
        'txtpid
        '
        Me.txtpid.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpid.Location = New System.Drawing.Point(190, 10)
        Me.txtpid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.Size = New System.Drawing.Size(326, 32)
        Me.txtpid.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 25)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "PID:"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(190, 54)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(326, 32)
        Me.txtname.TabIndex = 42
        '
        'txtnationality
        '
        Me.txtnationality.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnationality.Location = New System.Drawing.Point(189, 359)
        Me.txtnationality.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnationality.Name = "txtnationality"
        Me.txtnationality.Size = New System.Drawing.Size(338, 32)
        Me.txtnationality.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(66, 359)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 25)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Nationality:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(85, 306)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 25)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Zip Code:"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(189, 246)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(337, 32)
        Me.txtaddress.TabIndex = 38
        '
        'cmbbloodtype
        '
        Me.cmbbloodtype.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbloodtype.FormattingEnabled = True
        Me.cmbbloodtype.Items.AddRange(New Object() {"O-", "O+", "A-", "A+", "B-", "B+", "AB-", "AB+"})
        Me.cmbbloodtype.Location = New System.Drawing.Point(576, 96)
        Me.cmbbloodtype.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbbloodtype.Name = "cmbbloodtype"
        Me.cmbbloodtype.Size = New System.Drawing.Size(180, 33)
        Me.cmbbloodtype.TabIndex = 37
        Me.cmbbloodtype.Text = "     Choose here"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(460, 98)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 25)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Blood Type:"
        '
        'txtmobile
        '
        Me.txtmobile.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobile.Location = New System.Drawing.Point(189, 196)
        Me.txtmobile.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(337, 32)
        Me.txtmobile.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 198)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 25)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Mobile Number:"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(190, 147)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(337, 32)
        Me.txtemail.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(117, 147)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Email:"
        '
        'cmbsex
        '
        Me.cmbsex.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsex.FormattingEnabled = True
        Me.cmbsex.Items.AddRange(New Object() {"Male", "Female", "Custom"})
        Me.cmbsex.Location = New System.Drawing.Point(576, 15)
        Me.cmbsex.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbsex.Name = "cmbsex"
        Me.cmbsex.Size = New System.Drawing.Size(193, 33)
        Me.cmbsex.TabIndex = 31
        Me.cmbsex.Text = "          Choose here"
        '
        'dpdate
        '
        Me.dpdate.CustomFormat = "yyyy/MM/dd"
        Me.dpdate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpdate.Location = New System.Drawing.Point(189, 98)
        Me.dpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.dpdate.Name = "dpdate"
        Me.dpdate.Size = New System.Drawing.Size(264, 32)
        Me.dpdate.TabIndex = 28
        '
        'txtzip
        '
        Me.txtzip.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtzip.Location = New System.Drawing.Point(189, 306)
        Me.txtzip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtzip.Name = "txtzip"
        Me.txtzip.Size = New System.Drawing.Size(338, 32)
        Me.txtzip.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(93, 246)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 25)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(522, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Sex:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Date of Birth:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Patient Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(749, 14)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(343, 81)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Add Patient"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddPatientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1493, 726)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddPatientForm"
        Me.Text = "PatientlogsForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnaddpatient As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnpatientlogs As System.Windows.Forms.Button
    Friend WithEvents btndashboard As System.Windows.Forms.Button
    Friend WithEvents btnappointment As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbsex As System.Windows.Forms.ComboBox
    Friend WithEvents txtzip As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnationality As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents cmbbloodtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtmobile As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnadmininfo As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtpid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
