Public Class Form7
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Function DoValidations() As Boolean
        DoValidations = False

        If (TextBox1.Text = "") Then
            TextBox1.BackColor = Color.LightPink
            MsgBox("Please enter your first name!")
            TextBox1.Focus()
            Exit Function
        ElseIf (IsNumeric(TextBox1.Text) = True) Then
            TextBox1.BackColor = Color.LightPink
            MsgBox("You cannot enter a number for your first name!")
            TextBox1.Focus()
            Exit Function
        Else
            TextBox1.BackColor = Color.White
        End If

        If (TextBox6.Text = "") Then
            TextBox6.BackColor = Color.LightPink
            MsgBox("Please enter your surname!")
            TextBox6.Focus()
            Exit Function
        ElseIf (IsNumeric(TextBox6.Text) = True) Then
            TextBox6.BackColor = Color.LightPink
            MsgBox("You cannot enter a number for your surname!")
            TextBox6.Focus()
            Exit Function
        Else
            TextBox6.BackColor = Color.White
        End If

        If (TextBox5.Text = "") Then
            TextBox5.BackColor = Color.LightPink
            MsgBox("Please enter your employee number!")
            TextBox5.Focus()
            Exit Function
        Else
            TextBox6.BackColor = Color.White
        End If

        If (TextBox4.Text = "") Then
            TextBox4.BackColor = Color.LightPink
            MsgBox("Please enter your gross salary!")
            TextBox4.Focus()
            Exit Function
        ElseIf (IsNumeric(TextBox4.Text) = False) Then
            TextBox4.BackColor = Color.LightPink
            MsgBox("Please enter your gross salary!")
            TextBox4.Focus()
            Exit Function
        Else
            TextBox6.BackColor = Color.White
        End If

        If (TextBox3.Text = "") Then
            TextBox3.BackColor = Color.LightPink
            MsgBox("Please enter your taxation!")
            TextBox3.Focus()
            Exit Function
        ElseIf (IsNumeric(TextBox3.Text) = False) Then
            TextBox3.BackColor = Color.LightPink
            MsgBox("Please enter your taxation!")
            TextBox3.Focus()
            Exit Function
        Else
            TextBox6.BackColor = Color.White
        End If

        DoValidations = True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()

        If DoValidations() = True Then
            ListBox1.Items.Add("=========================== PAY SLIP ===========================")
            ListBox1.Items.Add("Pay Period: " & Format(DateTimePicker1.Value, "Long date") & " to " & Format(DateTimePicker2.Value, "Long date"))
            ListBox1.Items.Add("Employee's Name: " & TextBox1.Text & " " & TextBox6.Text)
            ListBox1.Items.Add("Employee Number: " & TextBox5.Text)
            ListBox1.Items.Add("----------------------------------------------------------------------------------------------------------------------------------------------------")
            ListBox1.Items.Add("Gross Salary: $" & TextBox4.Text)
            ListBox1.Items.Add("Taxation: $" & TextBox3.Text)
            ListBox1.Items.Add("")
            ListBox1.Items.Add("Net Salary: $" & (Val(TextBox4.Text) - Val(TextBox3.Text)))
            ListBox1.Items.Add("=========================== PAY SLIP ===========================")
            TextBox1.BackColor = Color.White
            TextBox3.BackColor = Color.White
            TextBox4.BackColor = Color.White
            TextBox5.BackColor = Color.White
            TextBox6.BackColor = Color.White
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class