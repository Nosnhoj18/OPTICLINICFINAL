<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnadmininfo = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnaddpatient = New System.Windows.Forms.Button()
        Me.btnpatientlogs = New System.Windows.Forms.Button()
        Me.btnappointment = New System.Windows.Forms.Button()
        Me.btndashboard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.btnadmininfo)
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.btnaddpatient)
        Me.Panel1.Controls.Add(Me.btnpatientlogs)
        Me.Panel1.Controls.Add(Me.btnappointment)
        Me.Panel1.Controls.Add(Me.btndashboard)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-5, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 737)
        Me.Panel1.TabIndex = 0
        '
        'btnadmininfo
        '
        Me.btnadmininfo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnadmininfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadmininfo.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadmininfo.Image = CType(resources.GetObject("btnadmininfo.Image"), System.Drawing.Image)
        Me.btnadmininfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadmininfo.Location = New System.Drawing.Point(5, 486)
        Me.btnadmininfo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadmininfo.Name = "btnadmininfo"
        Me.btnadmininfo.Size = New System.Drawing.Size(402, 82)
        Me.btnadmininfo.TabIndex = 8
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
        Me.btnlogout.Location = New System.Drawing.Point(5, 576)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(402, 82)
        Me.btnlogout.TabIndex = 7
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
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
        Me.btnaddpatient.TabIndex = 7
        Me.btnaddpatient.Text = " Add Patient"
        Me.btnaddpatient.UseVisualStyleBackColor = False
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
        Me.btnpatientlogs.TabIndex = 7
        Me.btnpatientlogs.Text = "  Patient Logs"
        Me.btnpatientlogs.UseVisualStyleBackColor = False
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
        Me.btnappointment.TabIndex = 7
        Me.btnappointment.Text = "    Appointment"
        Me.btnappointment.UseVisualStyleBackColor = False
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
        Me.btndashboard.TabIndex = 6
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
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Optical Clinic "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(734, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(324, 81)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Dashboard"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(409, 108)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1067, 523)
        Me.ListView1.TabIndex = 22
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "PID"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "NAME"
        Me.ColumnHeader11.Width = 104
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "DATE OF BIRTH"
        Me.ColumnHeader12.Width = 176
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "BLOOD TYPE"
        Me.ColumnHeader13.Width = 148
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "SEX"
        Me.ColumnHeader14.Width = 59
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "EMAIL ADDRESS"
        Me.ColumnHeader15.Width = 167
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "MOBILE NUMBER"
        Me.ColumnHeader16.Width = 172
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "ADDRESS"
        Me.ColumnHeader17.Width = 120
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "ZIP CODE"
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "NATIONALITY"
        Me.ColumnHeader19.Width = 180
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(408, 655)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Note :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(477, 655)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(851, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "If you want to appoint the patient on the listview, Just double click the PID of " & _
    "the patient. Thank you!"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1481, 726)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btnaddpatient As System.Windows.Forms.Button
    Friend WithEvents btnpatientlogs As System.Windows.Forms.Button
    Friend WithEvents btnappointment As System.Windows.Forms.Button
    Friend WithEvents btndashboard As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnadmininfo As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
