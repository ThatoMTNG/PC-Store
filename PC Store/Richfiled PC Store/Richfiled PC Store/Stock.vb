Public Class Stock
    Private Sub New_stockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.NewstockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StockDataSet)

    End Sub

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.new_stock' table. You can move, or remove it, as needed.
        Me.New_stockTableAdapter.Fill(Me.StockDataSet.new_stock)
        'TODO: This line of code loads data into the 'StockDataSet.new_stock' table. You can move, or remove it, as needed.
        Me.New_stockTableAdapter.Fill(Me.StockDataSet.new_stock)

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        End
    End Sub

    Private Sub BillingFormButton_Click(sender As Object, e As EventArgs) Handles BillingFormButton.Click
        Billing_Form.Show()
        Me.Hide()
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        NewstockBindingSource.MovePrevious()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click

        Product_IDTextBox.Text = ""
        StocknameTextBox.Text = ""
        TypeTextBox.Text = ""
        SizeTextBox.Text = ""
        PriceTextBox.Text = ""
        QuantityTextBox.Text = ""
        SupplierTextBox.Text = ""
        CampusTextBox.Text = ""
        TextBox1.Text = ""

    End Sub

    Private Sub SignoutButton_Click(sender As Object, e As EventArgs) Handles SignoutButton.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        NewstockBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(StockDataSet)
        MsgBox("Records deleted.")
    End Sub

    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click

        NewstockBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(StockDataSet)
        MsgBox("Records changed.")

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Try
            NewstockBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(StockDataSet)
            MsgBox("Records saved.")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click

        Me.NewstockBindingSource.Filter = "Stockname LIKE '" & TextBox1.Text & "%'"

    End Sub
End Class