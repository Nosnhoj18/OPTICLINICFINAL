Public Class AdminInfoForm
    Public adding As Boolean = False
    Public updating As Boolean = False
    Public id As Integer = Nothing
    Private rid As Integer = Nothing
    Private Sub Clear()
        txtname.Text = Nothing
        txtemail.Text = Nothing
        txtusername.Text = Nothing
        txtpassword.Text = Nothing
    End Sub
    Private Sub txtene()
        txtname.Enabled = True
        txtemail.Enabled = True
        txtusername.Enabled = True
        txtpassword.Enabled = True
    End Sub
    Private Sub txtdis()
        txtname.Enabled = False
        txtemail.Enabled = False
        txtusername.Enabled = False
        txtpassword.Enabled = False
    End Sub
    Public Sub filluser()
        GetQuery("SELECT * FROM tblregister", "tblregister")
        ListView1.Items.Clear()
        For i = 0 To ds.Tables("tblregister").Rows.Count - 1
            ListView1.Items.Add(ds.Tables("tblregister").Rows(i).Item("Rid").ToString)
            With ListView1.Items(i).SubItems
                .Add(ds.Tables("tblregister").Rows(i).Item("admin").ToString)
                .Add(ds.Tables("tblregister").Rows(i).Item("email").ToString)
                .Add(ds.Tables("tblregister").Rows(i).Item("username").ToString)
                .Add(ds.Tables("tblregister").Rows(i).Item("password").ToString)
            End With
        Next
    End Sub

    Private Sub AdminInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "dentalclinicc", "3306", "root", "")
        filluser()
    End Sub
    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        Me.Close()
        Dim dashboardForm As New DashboardForm()
        dashboardForm.Show()
    End Sub
    Private Sub btnappointment_Click(sender As Object, e As EventArgs) Handles btnappointment.Click
        Me.Close()
        Dim appointmentForm As New AppointmentForm()
        appointmentForm.Show()
    End Sub
    Private Sub btnpatientlogs_Click(sender As Object, e As EventArgs) Handles btnpatientlogs.Click
        Me.Close()
        Dim patientlogsForm As New PatientlogsForm()
        patientlogsForm.Show()
    End Sub

    Private Sub btnaddpatient_Click(sender As Object, e As EventArgs) Handles btnaddpatient.Click
        Me.Close()
        Dim addpatientForm As New AddPatientForm()
        addpatientForm.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        MessageBox.Show("Log out successful.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        id = ListView1.FocusedItem.SubItems(0).Text
        GetQuery("SELECT * FROM tblregister where rid='" & id & "'", "tblregister")
        txtname.Text = ds.Tables("tblregister").Rows(0).Item("admin").ToString
        txtemail.Text = ds.Tables("tblregister").Rows(0).Item("email").ToString
        txtusername.Text = ds.Tables("tblregister").Rows(0).Item("username").ToString
        txtpassword.Text = ds.Tables("tblregister").Rows(0).Item("password").ToString
        txtdis()
        btnsave.Enabled = False
        btnedit.Enabled = True
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        rid = ListView1.FocusedItem.SubItems(0).Text
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If adding = True Then
            If txtname.Text = Nothing Or txtemail.Text = Nothing Or txtusername.Text = Nothing Or txtpassword.Text = Nothing Then
                MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Else
                If MsgBox("Are you sure you want to add new information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    SetQuery("INSERT INTO tblregister(admin, email, username, password)VALUES(' " & txtname.Text.Trim & "','" & txtemail.Text & "','" & txtusername.Text.Trim & "','" & txtpassword.Text.Trim & "')")
                    filluser()
                    Clear()
                    txtdis()
                    adding = False
                    updating = False
                    MsgBox("Information have been Saved!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                    btnedit.Enabled = False
                    btnsave.Enabled = False

                End If
            End If
        ElseIf updating = True Then
            If MsgBox("Are you sure you want to update information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("UPDATE tblregister SET admin='" & txtname.Text.Trim & "', email='" & txtemail.Text.Trim & "', username='" & txtusername.Text.Trim & "', password = '" & txtpassword.Text & "'WHERE rid='" & rid & "'")
                filluser()
                txtdis()
                adding = False
                updating = False
                MsgBox("Information have been Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                Clear()
                btnedit.Enabled = False
                btnsave.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        updating = True
        btnsave.Enabled = True
        btnedit.Enabled = False
        txtene()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class