Public Class Inscription
    Private Sub Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabRégions() As String = {"Auvergne", "Bordelais", "Bourgogne",
                                      "Bretagne", "Corse", "Nord", "Normandie",
                                      "Paris", "Poitou", "Roussillon"}
        RegionBox.Items.AddRange(tabRégions)

        Dim tabEcrit() As String = {"Algorithmique", "Base de données",
                                    "Langage C", "Langage Java",
                                    "Programmation web", "Visual Basic .NET"}

        Dim tabEcritOral() As String = {"Droit", "Expression", "Gestion",
                                        "Mathématiques", "Réseau", "Système"}

        Dim tabOral() As String = {"Anglais", "Chinois", "Espagnol"}
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class