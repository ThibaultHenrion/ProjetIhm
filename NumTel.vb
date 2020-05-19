Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.TextLength = 2) Then
            TextBox2.Enabled = True
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If (TextBox2.TextLength = 2) Then
            TextBox3.Enabled = True
            TextBox3.Focus()
        ElseIf (TextBox2.TextLength = 0) Then
            TextBox1.Focus()
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If (TextBox3.TextLength = 2) Then
            TextBox4.Enabled = True
            TextBox4.Focus()
        ElseIf (TextBox3.TextLength = 0) Then
            TextBox2.Focus()
            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If (TextBox4.TextLength = 2) Then
            TextBox5.Enabled = True
            TextBox5.Focus()
        ElseIf (TextBox4.TextLength = 0) Then
            TextBox3.Focus()
            TextBox4.Enabled = False
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If (TextBox5.TextLength = 0) Then
            TextBox4.Focus()
            TextBox5.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Label4.Text = ""
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text + TextBox2.Text + TextBox3.Text + TextBox4.Text + TextBox5.Text).Length = 10 And IsNumeric(TextBox1.Text + TextBox2.Text + TextBox3.Text + TextBox4.Text + TextBox5.Text) Then
            Form1.Label4.Text = TextBox1.Text + TextBox2.Text + TextBox3.Text + TextBox4.Text + TextBox5.Text
            Close()
        Else
            MsgBox("Le numéro renseigné n'est pas valide.")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Focus()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub
End Class