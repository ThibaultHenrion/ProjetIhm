Public Class Inscription
    Private Sub Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub nomVille_TextChanged(sender As Object, e As EventArgs) Handles nomVille.TextChanged

    End Sub

    Private Sub scrollAge_Scroll(sender As Object, e As ScrollEventArgs) Handles scrollAge.Scroll
        affichAge.Text = scrollAge.Value & " ans"
    End Sub

    Private Sub Annuler_Click(sender As Object, e As EventArgs) Handles Annuler.Click
        Me.Close()
    End Sub

    Private Sub Suivant_Click(sender As Object, e As EventArgs) Handles Suivant.Click

    End Sub


    Sub Nomprenomadr_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles NomCandidat.KeyPress, PrenomCandidat.KeyPress, AdresseCandidat.KeyPress
        If e.KeyChar = vbBack Then Exit Sub

        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CP_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CP.KeyPress
        If e.KeyChar = vbBack Then Exit Sub

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class