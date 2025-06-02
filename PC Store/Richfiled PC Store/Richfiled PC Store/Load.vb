Public Class LoadForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label3.Text = ProgressBar1.Value & "%"
        ProgressBar1.Value += 1

        If ProgressBar1.Value <= 10 Then
            Label2.Text = "Please wait system is loading!!"
        ElseIf ProgressBar1.Value <= 40 Then
            Label2.Text = "Please wait system is loading!!"
        ElseIf ProgressBar1.Value <= 70 Then
            Label2.Text = "Please wait system is loading!!"
        ElseIf ProgressBar1.Value <= 90 Then
            Label2.Text = "Please wait system is loading!!"
        ElseIf ProgressBar1.Value <= 100 Then
            Label2.Text = "Please wait system is loading!!"
            Billing_Form.Show()
            Me.Hide()
            Timer1.Dispose()
        End If

    End Sub
End Class