Public Class DashboardForm
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "dentalclinicc", "3306", "root", "")
        PopulateListView()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndashboard.Click

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

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedName As String = ListView1.SelectedItems(0).SubItems(1).Text
            Me.Hide()
            Dim appointmentForm As New AppointmentForm()
            appointmentForm.SelectedName = selectedName
            appointmentForm.Show()
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
Private Sub PopulateListView()
        ListView1.Items.Clear()
        Dim query As String = "SELECT * FROM tbladd"
        GetQuery(query, "tbladd")

        If ds.Tables.Contains("tbladd") AndAlso ds.Tables("tbladd").Rows.Count > 0 Then
            For Each row As DataRow In ds.Tables("tbladd").Rows
                Dim item As New ListViewItem(row("pid").ToString())
                item.SubItems.Add(row("name").ToString())
                item.SubItems.Add(row("datebirth").ToString())
                item.SubItems.Add(row("bloodtype").ToString())
                item.SubItems.Add(row("sex").ToString())
                item.SubItems.Add(row("email").ToString())
                item.SubItems.Add(row("mobilenumber").ToString())
                item.SubItems.Add(row("address").ToString())
                item.SubItems.Add(row("zip").ToString())
                item.SubItems.Add(row("nationality").ToString())
                ListView1.Items.Add(item)
            Next
        End If
    End Sub

End Class