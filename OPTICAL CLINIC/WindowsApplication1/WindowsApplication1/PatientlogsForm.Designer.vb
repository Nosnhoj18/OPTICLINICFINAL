<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientlogsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientlogsForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnadmininfo = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnappointment = New System.Windows.Forms.Button()
        Me.btnaddpatient = New System.Windows.Forms.Button()
        Me.btndashboard = New System.Windows.Forms.Button()
        Me.btnpatientlogs = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnappoint = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbname = New System.Windows.Forms.TextBox()
        Me.txtplid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpicker = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtmedicine = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbinjured = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnadmininfo)
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.btnappointment)
        Me.Panel1.Controls.Add(Me.btnaddpatient)
        Me.Panel1.Controls.Add(Me.btndashboard)
        Me.Panel1.Controls.Add(Me.btnpatientlogs)
        Me.Panel1.Location = New System.Drawing.Point(-3, -5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 740)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(152, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 50)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Optical Clinic "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
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
        Me.btnadmininfo.TabIndex = 30
        Me.btnadmininfo.Text = "Admin Info"
        Me.btnadmininfo.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Image = CType(resources.GetObject("btnlogout.Image"), System.Drawing.Image)
        Me.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogout.Location = New System.Drawing.Point(1, 575)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(402, 82)
        Me.btnlogout.TabIndex = 25
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnappointment
        '
        Me.btnappointment.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnappointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnappointment.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnappointment.Image = CType(resources.GetObject("btnappointment.Image"), System.Drawing.Image)
        Me.btnappointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnappointment.Location = New System.Drawing.Point(3, 251)
        Me.btnappointment.Margin = New System.Windows.Forms.Padding(4)
        Me.btnappointment.Name = "btnappointment"
        Me.btnappointment.Size = New System.Drawing.Size(402, 82)
        Me.btnappointment.TabIndex = 28
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
        Me.btnaddpatient.Location = New System.Drawing.Point(3, 409)
        Me.btnaddpatient.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaddpatient.Name = "btnaddpatient"
        Me.btnaddpatient.Size = New System.Drawing.Size(402, 82)
        Me.btnaddpatient.TabIndex = 26
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
        Me.btndashboard.Location = New System.Drawing.Point(3, 174)
        Me.btndashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.Size = New System.Drawing.Size(402, 82)
        Me.btndashboard.TabIndex = 24
        Me.btndashboard.Text = "Dashboard"
        Me.btndashboard.UseVisualStyleBackColor = False
        '
        'btnpatientlogs
        '
        Me.btnpatientlogs.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnpatientlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpatientlogs.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpatientlogs.Image = CType(resources.GetObject("btnpatientlogs.Image"), System.Drawing.Image)
        Me.btnpatientlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpatientlogs.Location = New System.Drawing.Point(3, 330)
        Me.btnpatientlogs.Margin = New System.Windows.Forms.Padding(4)
        Me.btnpatientlogs.Name = "btnpatientlogs"
        Me.btnpatientlogs.Size = New System.Drawing.Size(402, 82)
        Me.btnpatientlogs.TabIndex = 27
        Me.btnpatientlogs.Text = "  Patient Logs"
        Me.btnpatientlogs.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Controls.Add(Me.btnadd)
        Me.Panel3.Controls.Add(Me.btndelete)
        Me.Panel3.Controls.Add(Me.btnedit)
        Me.Panel3.Controls.Add(Me.btnappoint)
        Me.Panel3.Location = New System.Drawing.Point(1225, 114)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(249, 350)
        Me.Panel3.TabIndex = 28
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.White
        Me.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnadd.FlatAppearance.BorderSize = 0
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.Black
        Me.btnadd.Location = New System.Drawing.Point(20, 47)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(213, 50)
        Me.btnadd.TabIndex = 28
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.White
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btndelete.FlatAppearance.BorderSize = 0
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Black
        Me.btndelete.Location = New System.Drawing.Point(20, 264)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(213, 50)
        Me.btndelete.TabIndex = 27
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.White
        Me.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnedit.FlatAppearance.BorderSize = 0
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.Black
        Me.btnedit.Location = New System.Drawing.Point(20, 193)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(213, 50)
        Me.btnedit.TabIndex = 26
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnappoint
        '
        Me.btnappoint.BackColor = System.Drawing.Color.White
        Me.btnappoint.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnappoint.FlatAppearance.BorderSize = 0
        Me.btnappoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnappoint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnappoint.ForeColor = System.Drawing.Color.Black
        Me.btnappoint.Location = New System.Drawing.Point(20, 117)
        Me.btnappoint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnappoint.Name = "btnappoint"
        Me.btnappoint.Size = New System.Drawing.Size(213, 50)
        Me.btnappoint.TabIndex = 25
        Me.btnappoint.Text = "Appoint"
        Me.btnappoint.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.cmbname)
        Me.Panel2.Controls.Add(Me.txtplid)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.txtdescription)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtcost)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.dtpicker)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtmedicine)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cmbinjured)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cmbdate)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(418, 114)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(787, 350)
        Me.Panel2.TabIndex = 27
        '
        'cmbname
        '
        Me.cmbname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbname.Location = New System.Drawing.Point(259, 56)
        Me.cmbname.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbname.Name = "cmbname"
        Me.cmbname.Size = New System.Drawing.Size(338, 32)
        Me.cmbname.TabIndex = 45
        '
        'txtplid
        '
        Me.txtplid.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplid.Location = New System.Drawing.Point(260, 9)
        Me.txtplid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtplid.Name = "txtplid"
        Me.txtplid.Size = New System.Drawing.Size(338, 32)
        Me.txtplid.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 25)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "PLID:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(606, 30)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(164, 134)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(606, 197)
        Me.txtdescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(168, 146)
        Me.txtdescription.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(632, 167)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 25)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Description:"
        '
        'txtcost
        '
        Me.txtcost.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcost.Location = New System.Drawing.Point(259, 310)
        Me.txtcost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(338, 32)
        Me.txtcost.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(196, 310)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 25)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Cost:"
        '
        'dtpicker
        '
        Me.dtpicker.CustomFormat = "yyyy/MM/dd"
        Me.dtpicker.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpicker.Location = New System.Drawing.Point(259, 263)
        Me.dtpicker.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpicker.Name = "dtpicker"
        Me.dtpicker.Size = New System.Drawing.Size(338, 32)
        Me.dtpicker.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(73, 269)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 25)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Date of Eye Work:"
        '
        'txtmedicine
        '
        Me.txtmedicine.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmedicine.Location = New System.Drawing.Point(259, 210)
        Me.txtmedicine.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmedicine.Name = "txtmedicine"
        Me.txtmedicine.Size = New System.Drawing.Size(338, 32)
        Me.txtmedicine.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(153, 210)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 25)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Medicine:"
        '
        'cmbinjured
        '
        Me.cmbinjured.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbinjured.FormattingEnabled = True
        Me.cmbinjured.Items.AddRange(New Object() {"Refractive Errors", "Cataracts", "Glaucoma", "Macular Degeneration", "Diabetic Retinopathy", "Dry Eye Syndrome", "Eye Infection"})
        Me.cmbinjured.Location = New System.Drawing.Point(259, 161)
        Me.cmbinjured.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbinjured.Name = "cmbinjured"
        Me.cmbinjured.Size = New System.Drawing.Size(338, 33)
        Me.cmbinjured.TabIndex = 33
        Me.cmbinjured.Text = "                   Choose here"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(128, 161)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Eye Problem:"
        '
        'cmbdate
        '
        Me.cmbdate.CustomFormat = "yyyy/MM/dd"
        Me.cmbdate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbdate.Location = New System.Drawing.Point(260, 107)
        Me.cmbdate.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdate.Name = "cmbdate"
        Me.cmbdate.Size = New System.Drawing.Size(264, 32)
        Me.cmbdate.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 25)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Date of Initial Symptoms:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 54)
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
        Me.Label7.Location = New System.Drawing.Point(763, 14)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(357, 81)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Patient Logs"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(424, 480)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1058, 238)
        Me.ListView1.TabIndex = 29
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "PLID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Patient Name"
        Me.ColumnHeader2.Width = 192
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date of Initial Symptoms"
        Me.ColumnHeader3.Width = 222
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = " Eye Problem"
        Me.ColumnHeader4.Width = 170
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Medicine"
        Me.ColumnHeader5.Width = 76
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Date of Eye Work"
        Me.ColumnHeader6.Width = 121
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Cost"
        Me.ColumnHeader7.Width = 122
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Description"
        Me.ColumnHeader8.Width = 373
        '
        'PatientlogsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1493, 726)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PatientlogsForm"
        Me.Text = "PatientlogsForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btnappointment As System.Windows.Forms.Button
    Friend WithEvents btnaddpatient As System.Windows.Forms.Button
    Friend WithEvents btndashboard As System.Windows.Forms.Button
    Friend WithEvents btnpatientlogs As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnappoint As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcost As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtmedicine As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbinjured As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnadmininfo As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtplid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbname As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
