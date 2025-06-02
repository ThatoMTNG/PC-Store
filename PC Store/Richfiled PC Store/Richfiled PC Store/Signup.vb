Imports System.Data.OleDb
Imports System.Data

Public Class Signup

    Dim connection As New OleDbConnection(My.Settings.RGI_tech_storeConnectionString1)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or
            RadioButton1.Checked = False Then
            MsgBox("Input a value!")

        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New OleDbCommand("insert into login_details('Name', 'Lastname', 'Gender', 'Username', 'Password') 
                                        values (@Name,@Lastname,@Gender,@Username,@Password)", connection)
            cmd.Parameters.AddWithValue("@Name", OleDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.AddWithValue("@Lastname", OleDbType.VarChar).Value = TextBox2.Text
            cmd.Parameters.AddWithValue("@Gender", OleDbType.VarChar).Value = RadioButton1.Checked Or
                                        RadioButton2.Checked
            cmd.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = TextBox3.Text
            cmd.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = TextBox4.Text

            cmd.ExecuteNonQuery()
            connection.Close()

            MsgBox("User has been registered!")

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class