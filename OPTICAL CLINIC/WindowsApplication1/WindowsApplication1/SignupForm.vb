Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class SignupForm
    Private connectionString As String = "Server=localhost;Port=3306;Database=dentalclinicc;Uid=root;"
    Private Sub Clear()
        txtadmin.Text = ""
        txtemail.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
    End Sub

    Private Sub SignupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        If txtadmin.Text = "" Or txtemail.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO tblregister(admin, email, username, password) VALUES(@admin, @email, @username, @password)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@admin", txtadmin.Text.Trim())
                    command.Parameters.AddWithValue("@email", txtemail.Text.Trim())
                    command.Parameters.AddWithValue("@username", txtusername.Text.Trim())
                    command.Parameters.AddWithValue("@password", txtpassword.Text.Trim())
                    command.ExecuteNonQuery()
                End Using
            End Using
            MsgBox("You are now registered!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Clear()
        Catch ex As Exception
            MsgBox("An error occurred while saving data: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub


    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class