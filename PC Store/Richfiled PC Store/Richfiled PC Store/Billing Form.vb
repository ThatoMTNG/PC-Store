Public Class Billing_Form

    Dim fullName, motherboards, processor, hardDrive, ram, graphic As String
    Dim discount, subtotal, vat, priceDiscount, total As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        fullName = txtName.Text

        If cmbMother.SelectedItem.ToString = True Then
            txtMotherPrice.Text = 582
        Else
            txtMotherPrice.Text = 0
        End If
        motherboards = txtMotherPrice.Text

        If cmbProcessor.SelectedItem.ToString = True Then
            txtProcessorPrice.Text = 449
        Else
            txtProcessorPrice.Text = 0
        End If
        processor = txtProcessorPrice.Text

        If cmbHard.SelectedItem.ToString = True Then
            txtHardPrice.Text = 250
        Else
            txtHardPrice.Text = 0
        End If
        hardDrive = txtHardPrice.Text

        If cmbRAM.SelectedItem.ToString = True Then
            txtRAMPrice.Text = 549
        Else
            txtRAMPrice.Text = 0
        End If
        ram = txtRAMPrice.Text

        If cmbGraphic.SelectedItem.ToString = True Then
            txtGraphicPrice.Text = 863
        Else
            txtGraphicPrice.Text = 0
        End If
        graphic = txtGraphicPrice.Text

        discount = RadioButton1.Checked Or RadioButton2.Checked
        vat = 15 / 100
        txtVAT.Text = vat
        discount = txtDiscount.Text

        subtotal = motherboards + processor + hardDrive + ram + graphic
        txtSubtotal.Text = subtotal
        total = (subtotal + vat) - discount
        txtTotal.Text = total

        RichTextBox1.AppendText("               Richfield PC Components Store        " + vbNewLine)
        RichTextBox1.AppendText("====================================================" + vbNewLine)
        RichTextBox1.AppendText("Customer Name: " + vbTab + txtName.Text + vbNewLine)
        RichTextBox1.AppendText("====================================================" + vbNewLine)
        RichTextBox1.AppendText("Components              Type                   Price" + vbNewLine)
        RichTextBox1.AppendText("====================================================" + vbNewLine)
        RichTextBox1.AppendText("motherboards" + vbTab + cmbMother.Text + txtMotherPrice.Text + vbNewLine)
        RichTextBox1.AppendText("processor" + vbTab + cmbProcessor.Text + txtProcessorPrice.Text + vbNewLine)
        RichTextBox1.AppendText("hard disk" + vbTab + cmbHard.Text + txtHardPrice.Text + vbNewLine)
        RichTextBox1.AppendText("RAM" + vbTab + cmbRAM.Text + txtRAMPrice.Text + vbNewLine)
        RichTextBox1.AppendText("graphic" + vbTab + cmbGraphic.Text + txtGraphicPrice.Text + vbNewLine)
        RichTextBox1.AppendText("====================================================" + vbNewLine)
        RichTextBox1.AppendText("Subtotal" + vbTab + txtSubtotal.Text + vbNewLine)
        RichTextBox1.AppendText("VAT" + vbTab + txtVAT.Text + vbNewLine)
        RichTextBox1.AppendText("Discount" + vbTab + txtDiscount.Text + vbNewLine)
        RichTextBox1.AppendText("Total" + vbTab + txtTotal.Text + vbNewLine)
        RichTextBox1.AppendText(vbTab + "Enjoy your day" + vbNewLine + "Please keep slip as proof of purchase and return")
        RichTextBox1.AppendText("====================================================" + vbNewLine)
        RichTextBox1.AppendText(vbTab + "2022-07-20" + vbNewLine)
        RichTextBox1.AppendText("====================================================" + vbNewLine)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Stock.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtName.Clear()
        cmbMother.Text = ""
        cmbProcessor.Text = ""
        cmbHard.Text = ""
        cmbGraphic.Text = ""
        txtMotherPrice.Clear()
        txtProcessorPrice.Clear()
        txtHardPrice.Clear()
        txtGraphicPrice.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        txtSubtotal.Clear()
        txtVAT.Clear()
        txtDiscount.Clear()
        txtTotal.Clear()


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked = True Then
            RadioButton1.Checked = 10 / 100
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then
            RadioButton2.Checked = 15 / 100
        End If

    End Sub
End Class