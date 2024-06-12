Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private connectionString As String = "Server=localhost;Port=3306;Database=dentalclinicc;Uid=root;"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = txtusername.Text.Trim()
        Dim password As String = txtpassword.Text.Trim()

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Username and password are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT username, password FROM tblregister WHERE username = @username AND password = @password"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim dashboardForm As New DashboardForm()
                        Me.Hide()
                        dashboardForm.ShowDialog()
                    Else
                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim signupForm As New SignupForm()
        signupForm.ShowDialog()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class
