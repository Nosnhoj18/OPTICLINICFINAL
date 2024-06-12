Public Class AddPatientForm
    Public Property NewPatientName As String
    Public adding As Boolean = False
    Public updating As Boolean = False
    Public id As Integer = Nothing
    Private pid As Integer = Nothing
    Private Sub Clear()
        txtpid.Text = Nothing
        txtname.Text = Nothing
        dpdate.Text = Nothing
        cmbbloodtype.Text = Nothing
        cmbsex.Text = Nothing
        txtemail.Text = Nothing
        txtmobile.Text = Nothing
        txtaddress.Text = Nothing
        txtzip.Text = Nothing
        txtnationality.Text = Nothing
    End Sub
    Private Sub txtene()
        txtpid.Enabled = True
        txtname.Enabled = True
        dpdate.Enabled = True
        cmbbloodtype.Enabled = True
        cmbsex.Enabled = True
        txtemail.Enabled = True
        txtmobile.Enabled = True
        txtaddress.Enabled = True
        txtzip.Enabled = True
        txtnationality.Enabled = True
    End Sub
    Private Sub txtdis()
        txtpid.Enabled = False
        txtname.Enabled = False
        dpdate.Enabled = False
        cmbbloodtype.Enabled = False
        cmbsex.Enabled = False
        txtemail.Enabled = False
        txtmobile.Enabled = False
        txtaddress.Enabled = False
        txtzip.Enabled = False
        txtnationality.Enabled = False
    End Sub
    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        Me.Close()
        Dim dashboardInfo As New DashboardForm()
        dashboardInfo.Show()
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

    Private Sub btnadmininfo_Click(sender As Object, e As EventArgs) Handles btnadmininfo.Click
        Me.Close()
        Dim admininfoForm As New AdminInfoForm()
        admininfoForm.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        MessageBox.Show("Log out successful.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub

    Private Sub AddPatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "dentalclinicc", "3306", "root", "")
        txtdis()

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        adding = True
        txtene()
        txtname.Focus()
        btnsave.Enabled = True
        btnadd.Enabled = False
        txtpid.Focus()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        NewPatientName = txtname.Text.Trim()

        If adding = True Then
            If txtname.Text = Nothing Or dpdate.Text = Nothing Or cmbbloodtype.Text = Nothing Or cmbsex.Text = Nothing Or txtemail.Text = Nothing Or txtmobile.Text = Nothing Or txtaddress.Text = Nothing Or txtzip.Text = Nothing Or txtnationality.Text = Nothing Then
                MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Else
                If MsgBox("Are you sure you want to add new User?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    SetQuery("INSERT INTO tbladd(pid, name, datebirth, bloodtype, sex, email, mobilenumber, address, zip, nationality)VALUES(' " & txtpid.Text.Trim & "','" & txtname.Text.Trim & "','" & dpdate.Text.Trim & "','" & cmbbloodtype.Text & "','" & cmbsex.Text & "','" & txtemail.Text.Trim & "','" & txtmobile.Text.Trim & "','" & txtaddress.Text.Trim & "','" & txtzip.Text.Trim & "','" & txtnationality.Text.Trim & "')")
                    Clear()
                    txtdis()
                    adding = False
                    updating = False
                    MsgBox("Information have been Saved!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                    btnadd.Enabled = True
                    btnsave.Enabled = False

                End If
            End If
        ElseIf updating = True Then
            If MsgBox("Are you sure you want to update Product?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("UPDATE tbladd SET pid='" & txtpid.Text.Trim & "', name='" & txtname.Text.Trim & "', datebirth='" & dpdate.Text.Trim & "', bloodtype = '" & cmbbloodtype.Text & "', sex= '" & cmbsex.Text.Trim & "', email='" & txtemail.Text & "', mobilenumber='" & txtmobile.Text & "', address='" & txtaddress.Text & "', zip='" & txtzip.Text & "', nationality='" & txtnationality.Text & "'WHERE pid='" & pid & "'")
                txtdis()
                adding = False
                updating = False
                MsgBox("Information have been Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                Clear()
                btnadd.Enabled = True
                btnsave.Enabled = False
            End If
        End If
    End Sub
End Class