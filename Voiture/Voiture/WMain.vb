Imports BibliVoiture.Voiture

Public Class WMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uneVoiture As New BibliVoiture.Voiture(1, "Opel Astra", "Opel", "Astra", "2013", "Blanche", 121023)
        Dim i As Integer
        Dim j As Integer

        i = 1
        j = 2020
        MsgBox(uneVoiture.RetournerLibelle(), MsgBoxStyle.Critical, "Libelle de la Voiture")

        While i < 5
            uneVoiture.ModifierAnnee(j + i)
            MsgBox(uneVoiture.RetournerLibelle() & " " & uneVoiture.RetournerCouleur & " " & uneVoiture.RetournerKmBase & " " & uneVoiture.RetournerAnnee(), MsgBoxStyle.Information, "Info Année " & j + i)
            i += 1
        End While

    End Sub
End Class