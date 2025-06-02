Imports System.Data.SqlClient
Imports System.Configuration

Public Class Login
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Signup.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Enter username or password")
        Else
            Dim conn As New System.Data.OleDb.OleDbConnection
            conn.ConnectionString = "C:\Users\Thato Metsing\Documents\BSc Information Technology\ASSIGNMENTS\Semester 2\Programming\RGI tech store.mdb"

            Try
                Dim sql As String = "SELECT * FROM login_details WHERE Username = '" & TextBox1.Text & "' AND Password = '" & TextBox2.Text & "' "
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                sqlCom.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader

                If sqlRead.Read() Then

                    LoadForm.Show()
                    Me.Hide()
                Else
                    MsgBox("Username and password do not mach. Try again.")
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox1.Focus()

                End If
            Catch ex As Exception

                MsgBox("Failed to connect to database.")

            End Try
        End If

    End Sub
End Class