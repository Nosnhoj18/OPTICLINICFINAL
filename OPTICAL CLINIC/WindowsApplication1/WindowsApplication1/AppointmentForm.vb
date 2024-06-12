Public Class AppointmentForm
    Public adding As Boolean = False
    Public updating As Boolean = False
    Public id As Integer = Nothing
    Private aid As Integer = Nothing
    Private Sub Clear()
        txtaid.Text = Nothing
        cmbname.Text = Nothing
        cmbtype.Text = Nothing
        dtpicker.Text = Nothing
        cmbtime.Text = Nothing
        txtprice.Text = Nothing
    End Sub
    Private Sub txtene()
        txtaid.Enabled = True
        cmbname.Enabled = True
        cmbtype.Enabled = True
        dtpicker.Enabled = True
        cmbtime.Enabled = True
        txtprice.Enabled = True
    End Sub
    Private Sub txtdis()
        txtaid.Enabled = False
        cmbname.Enabled = False
        cmbtype.Enabled = False
        dtpicker.Enabled = False
        cmbtime.Enabled = False
        txtprice.Enabled = False
    End Sub
    Public Property SelectedName As String
        Get
            Return cmbName.Text
        End Get
        Set(value As String)
            cmbName.Text = value
        End Set
    End Property
    Public Sub filluser()
        GetQuery("SELECT * FROM tblapp", "tblapp")
        ListView1.Items.Clear()
        For i = 0 To ds.Tables("tblapp").Rows.Count - 1
            ListView1.Items.Add(ds.Tables("tblapp").Rows(i).Item("aid").ToString)
            With ListView1.Items(i).SubItems
                .Add(ds.Tables("tblapp").Rows(i).Item("name").ToString)
                .Add(ds.Tables("tblapp").Rows(i).Item("appointment").ToString)
                .Add(ds.Tables("tblapp").Rows(i).Item("date").ToString)
                .Add(ds.Tables("tblapp").Rows(i).Item("time").ToString)
                .Add(ds.Tables("tblapp").Rows(i).Item("price").ToString)
            End With
        Next
    End Sub
    Private Sub AppointmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "dentalclinicc", "3306", "root", "")
        txtdis()
        filluser()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        adding = True
        txtene()
        cmbname.Focus()
        btnappoint.Enabled = True
        btnedit.Enabled = False
        btndelete.Enabled = False
        btnadd.Enabled = False
        txtaid.Focus()
    End Sub
    Private Sub btnappoint_Click(sender As Object, e As EventArgs) Handles btnappoint.Click
        If adding Then
            If txtaid.Text = Nothing Or cmbname.Text = Nothing Or cmbtype.Text = Nothing Or dtpicker.Text = Nothing Or cmbtime.Text = Nothing Or txtprice.Text = Nothing Then
                MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Else
                If MsgBox("Are you sure you want to add add new information ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    SetQuery("INSERT INTO tblapp(aid, name, appointment, date, time, price)VALUES('" & txtaid.Text.Trim & "','" & cmbname.Text & "','" & cmbtype.Text & "','" & dtpicker.Text & "','" & cmbtime.Text & "','" & txtprice.Text.Trim & "')")
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
        ElseIf updating Then
            If MsgBox("Are you sure you want to update information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("UPDATE tblapp SET aid='" & txtaid.Text.Trim & "', name='" & cmbname.Text & "', appointment='" & cmbtype.Text & "', date = '" & dtpicker.Text & "', time= '" & cmbtime.Text & "', price='" & txtprice.Text.Trim & "' WHERE aid='" & aid & "'")
                filluser()
                txtdis()
                adding = False
                updating = True
                MsgBox("Information have been Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                Clear()
                btnadd.Enabled = True
                btnedit.Enabled = False
                btndelete.Enabled = True
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
        If aid = Nothing Then
            MsgBox("Select profile to delete", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        Else
            If MsgBox("Are you sure you want to delete information record", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("DELETE FROM tblapp WHERE aid='" & id & "'")
                filluser()
                aid = Nothing
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
        GetQuery("SELECT * FROM tblapp where aid='" & id & "'", "tblapp")
        txtaid.Text = ds.Tables("tblapp").Rows(0).Item("aid").ToString
        cmbname.Text = ds.Tables("tblapp").Rows(0).Item("name").ToString
        cmbtype.Text = ds.Tables("tblapp").Rows(0).Item("appointment").ToString
        dtpicker.Text = ds.Tables("tblapp").Rows(0).Item("date").ToString
        cmbtime.Text = ds.Tables("tblapp").Rows(0).Item("time").ToString
        txtprice.Text = ds.Tables("tblapp").Rows(0).Item("price").ToString
        txtdis()
        btnappoint.Enabled = False
        btnedit.Enabled = True
        btndelete.Enabled = True
        btnadd.Enabled = False
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        aid = ListView1.FocusedItem.SubItems(0).Text
    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        Me.Close()
        Dim dashboardForm As New DashboardForm()
        dashboardForm.Show()
    End Sub

    Private Sub btnappointment_Click(sender As Object, e As EventArgs) Handles btnappointment.Click

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
        Dim admininforForm As New AdminInfoForm()
        admininforForm.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        MessageBox.Show("Log out successful.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub
End Class