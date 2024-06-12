Public Class PatientlogsForm
    Public adding As Boolean = False
    Public updating As Boolean = False
    Public id As Integer = Nothing
    Private plid As Integer = Nothing
    Private Sub Clear()
        txtplid.Text = Nothing
        cmbname.Text = Nothing
        cmbdate.Text = Nothing
        cmbinjured.Text = Nothing
        txtmedicine.Text = Nothing
        dtpicker.Text = Nothing
        txtcost.Text = Nothing
        txtdescription.Text = Nothing
    End Sub
    Private Sub txtene()
        txtplid.Enabled = True
        cmbname.Enabled = True
        cmbdate.Enabled = True
        cmbinjured.Enabled = True
        txtmedicine.Enabled = True
        dtpicker.Enabled = True
        txtcost.Enabled = True
        txtdescription.Enabled = True
    End Sub
    Private Sub txtdis()
        txtplid.Enabled = False
        cmbname.Enabled = False
        cmbdate.Enabled = False
        cmbinjured.Enabled = False
        txtmedicine.Enabled = False
        dtpicker.Enabled = False
        txtcost.Enabled = False
        txtdescription.Enabled = False
    End Sub
    Public Sub filluser()
        GetQuery("SELECT * FROM tbllogs", "tbllogs")
        ListView1.Items.Clear()
        For i = 0 To ds.Tables("tbllogs").Rows.Count - 1
            ListView1.Items.Add(ds.Tables("tbllogs").Rows(i).Item("plid").ToString)
            With ListView1.Items(i).SubItems
                .Add(ds.Tables("tbllogs").Rows(i).Item("name").ToString)
                .Add(ds.Tables("tbllogs").Rows(i).Item("date").ToString)
                .Add(ds.Tables("tbllogs").Rows(i).Item("injured").ToString)
                .Add(ds.Tables("tbllogs").Rows(i).Item("medicine").ToString)
                .Add(ds.Tables("tbllogs").Rows(i).Item("datework").ToString)
                .Add(ds.Tables("tbllogs").Rows(i).Item("cost").ToString)
                .Add(ds.Tables("tbllogs").Rows(i).Item("description").ToString)
            End With
        Next
    End Sub

    Private Sub PatientlogsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "dentalclinicc", "3306", "root", "")
        txtdis()
        filluser()
    End Sub

    Private Sub btnappoint_Click(sender As Object, e As EventArgs) Handles btnappoint.Click
        If adding = True Then
            If cmbname.Text = Nothing Or cmbdate.Text = Nothing Or cmbinjured.Text = Nothing Or txtmedicine.Text = Nothing Or dtpicker.Text = Nothing Or txtcost.Text = Nothing Or txtdescription.Text = Nothing Then
                MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Else
                If MsgBox("Are you sure you want to add new information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    SetQuery("INSERT INTO tbllogs(plid, name, date, injured, medicine, datework, cost, description)VALUES(' " & txtplid.Text.Trim & "','" & cmbname.Text & "','" & cmbdate.Text.Trim & "','" & cmbinjured.Text.Trim & "','" & txtmedicine.Text & "','" & dtpicker.Text.Trim & "','" & txtcost.Text.Trim & "','" & txtdescription.Text.Trim & "')")
                    filluser()
                    Clear()
                    txtdis()
                    adding = False
                    updating = False
                    MsgBox("Information have been Saved!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                    btnadd.Enabled = True
                    btnedit.Enabled = False
                    btndelete.Enabled = False
                    btnappoint.Enabled = False

                End If
            End If
        ElseIf updating = True Then
            If MsgBox("Are you sure you want to update information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("UPDATE tbllogs SET plid='" & txtplid.Text.Trim & "', name='" & cmbname.Text.Trim & "', date='" & cmbdate.Text.Trim & "', injured = '" & cmbinjured.Text & "', medicine= '" & txtmedicine.Text.Trim & "', datework='" & dtpicker.Text & "', cost='" & txtcost.Text & "', description='" & txtdescription.Text & "'WHERE plid='" & plid & "'")
                filluser()
                txtdis()
                adding = False
                updating = False
                MsgBox("Information have been Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                Clear()
                btnadd.Enabled = True
                btnedit.Enabled = False
                btndelete.Enabled = False
                btnappoint.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        updating = True
        btnappoint.Enabled = True
        btnedit.Enabled = False
        btndelete.Enabled = False
        btnadd.Enabled = False
        txtene()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If plid = Nothing Then
            MsgBox("Select profile to delete", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        Else
            If MsgBox("Are you sure you want to delete information record", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("DELETE FROM tbllogs WHERE plid='" & plid & "'")
                filluser()
                plid = Nothing
                MsgBox("Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                Clear()
                btnedit.Enabled = False
                btnappoint.Enabled = False
                btndelete.Enabled = False
                btnadd.Enabled = True
            End If
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        id = ListView1.FocusedItem.SubItems(0).Text
        GetQuery("SELECT * FROM tbllogs where plid='" & id & "'", "tbllogs")
        txtplid.Text = ds.Tables("tbllogs").Rows(0).Item("plid").ToString
        cmbname.Text = ds.Tables("tbllogs").Rows(0).Item("name").ToString
        cmbdate.Text = ds.Tables("tbllogs").Rows(0).Item("date").ToString
        cmbinjured.Text = ds.Tables("tbllogs").Rows(0).Item("injured").ToString
        txtmedicine.Text = ds.Tables("tbllogs").Rows(0).Item("medicine").ToString
        dtpicker.Text = ds.Tables("tbllogs").Rows(0).Item("datework").ToString
        txtcost.Text = ds.Tables("tbllogs").Rows(0).Item("cost").ToString
        txtdescription.Text = ds.Tables("tbllogs").Rows(0).Item("description").ToString
        txtdis()
        btnappoint.Enabled = False
        btnedit.Enabled = True
        btndelete.Enabled = True
        btnadd.Enabled = False
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        plid = ListView1.FocusedItem.SubItems(0).Text
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        adding = True
        txtene()
        cmbname.Focus()
        btnappoint.Enabled = True
        btnedit.Enabled = False
        btndelete.Enabled = False
        btnadd.Enabled = False
        txtplid.Focus()
    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        Me.Close()
        Dim dashboardForm As New DashboardForm()
        dashboardForm.Show()
    End Sub

    Private Sub btnappointment_Click(sender As Object, e As EventArgs) Handles btnappointment.Click
        Me.Close()
        Dim appointmentForm As New AppointmentForm
        appointmentForm.Show()
    End Sub

    Private Sub btnpatientlogs_Click(sender As Object, e As EventArgs) Handles btnpatientlogs.Click

    End Sub

    Private Sub btnaddpatient_Click(sender As Object, e As EventArgs) Handles btnaddpatient.Click
        Me.Close()
        Dim addpatientForm As New AddPatientForm
        addpatientForm.Show()
    End Sub

    Private Sub btnadmininfo_Click(sender As Object, e As EventArgs) Handles btnadmininfo.Click
        Me.Close()
        Dim admininfoForm As New AdminInfoForm
        admininfoForm.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        MessageBox.Show("Log out successful.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub
End Class