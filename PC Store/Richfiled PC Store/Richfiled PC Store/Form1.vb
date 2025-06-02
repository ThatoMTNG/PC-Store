Public Class Form1
    Private Sub More_detailsBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles More_detailsBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.More_detailsBindingSource1.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.MoreUserDetailsDataSet1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RGI_tech_storeDataSet1.login_details' table. You can move, or remove it, as needed.
        Me.Login_detailsTableAdapter1.Fill(Me.RGI_tech_storeDataSet1.login_details)
        'TODO: This line of code loads data into the 'MoreUserDetailsDataSet1.more_details' table. You can move, or remove it, as needed.
        Me.More_detailsTableAdapter1.Fill(Me.MoreUserDetailsDataSet1.more_details)

    End Sub

    Private Sub BTadd_Click(sender As Object, e As EventArgs) Handles BTadd.Click

        Login_detailsBindingSource1.AddNew()
        TableAdapterManager3.UpdateAll(RGI_tech_storeDataSet1)
        RadioButton1.Checked = True

    End Sub

    Private Sub BTupdate_Click(sender As Object, e As EventArgs) Handles BTupdate.Click

        Try
            Login_detailsBindingSource1.EndEdit()
            TableAdapterManager3.UpdateAll(RGI_tech_storeDataSet1)
            MsgBox("Records updated.")
        Catch ex As Exception
            MsgBox("Error occured. Please recheck fields and try again.")
        End Try

    End Sub

    Private Sub BTdelete_Click(sender As Object, e As EventArgs) Handles BTdelete.Click

        Login_detailsBindingSource1.RemoveCurrent()
        TableAdapterManager3.UpdateAll(RGI_tech_storeDataSet1)
        MsgBox("Records deleted.")

    End Sub

    Private Sub BTlogout_Click(sender As Object, e As EventArgs) Handles BTlogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub BTreset_Click(sender As Object, e As EventArgs) Handles BTreset.Click

        IDTextBox3.Text = ""
        NameTextBox3.Text = ""
        LastnameTextBox3.Text = ""
        Date_of_BirthDateTimePicker1.Value = ""
        GenderTextBox1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        UsernameTextBox1.Text = ""
        DepartmentTextBox1.Text = ""
        PasswordTextBox1.Text = ""

    End Sub

    Private Sub BTsearch_Click(sender As Object, e As EventArgs) Handles BTsearch.Click

    End Sub

    Private Sub BTnextform_Click(sender As Object, e As EventArgs) Handles BTnextform.Click
        Stock.Show()
        Me.Hide()
    End Sub

    Private Sub BTbillingform_Click(sender As Object, e As EventArgs) Handles BTbillingform.Click
        Billing_Form.Show()
        Me.Hide()
    End Sub

    Private Sub BTexit_Click(sender As Object, e As EventArgs) Handles BTexit.Click
        End
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked Then
            GenderTextBox1.Text = RadioButton1.Text
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked Then
            GenderTextBox1.Text = RadioButton2.Text
        End If

    End Sub

    Private Sub More_detailsBindingSource1BindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles More_detailsBindingSource1BindingNavigator.RefreshItems

        If GenderTextBox1.Text = RadioButton1.Text Then
            RadioButton1.Checked = True
            RadioButton2.Checked = False
        ElseIf GenderTextBox1.Text = RadioButton2.Text Then
            RadioButton2.Checked = True
            RadioButton1.Checked = False
        End If

    End Sub

    Private Sub ADDbtn_Click(sender As Object, e As EventArgs) Handles ADDbtn.Click

        More_detailsBindingSource1.AddNew()
        TableAdapterManager2.UpdateAll(MoreUserDetailsDataSet1)

    End Sub

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click

        Try
            More_detailsBindingSource1.EndEdit()
            TableAdapterManager2.UpdateAll(MoreUserDetailsDataSet1)
            MsgBox("Records updated.")
        Catch ex As Exception
            MsgBox("Error occured. Please recheck fields and try again.")
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        More_detailsBindingSource1.RemoveCurrent()
        TableAdapterManager2.UpdateAll(MoreUserDetailsDataSet1)
        MsgBox("Records deleted.")

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        IDTextBox2.Text = ""
        NameTextBox2.Text = ""
        LastnameTextBox2.Text = ""
        AddressTextBox1.Text = ""
        ContactTextBox1.Text = ""
        QualificationTextBox1.Text = ""
        Net_ProfitTextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click

        Me.More_detailsBindingSource1.Filter = "Name LIKE '" & TextBox2.Text & "%'"

    End Sub

    Private Sub NextFormbtn_Click(sender As Object, e As EventArgs) Handles NextFormbtn.Click
        Stock.Show()
        Me.Hide()
    End Sub

    Private Sub BillingFormbtn_Click(sender As Object, e As EventArgs) Handles BillingFormbtn.Click
        Billing_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        End
    End Sub
End Class