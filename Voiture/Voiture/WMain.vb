Imports BibliVoiture.Voiture
Imports BibliVoiture.CollectionDeVoiture
Imports BibliVoiture

Public Class WMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uneVoitureUn As New BibliVoiture.Voiture("CR-812-BZ", "Opel Astra", "Opel", "Astra", "2013", "Blanche", 221132)
        Dim uneVoitureDeux As New BibliVoiture.Voiture("FE-892-JW", "Peugeot 307", "Peugeot", "307", "2008", "Grise", 265452)

        Dim mesVoitures As New CollectionDeVoiture

        mesVoitures.AjouterUneVoiture(uneVoitureUn)
        mesVoitures.AjouterUneVoiture(uneVoitureDeux)

        MsgBox("Nombre de Voiture : " & mesVoitures.RetournerNombresDeVoiture(), MsgBoxStyle.Information, "Information")
    End Sub
End Class