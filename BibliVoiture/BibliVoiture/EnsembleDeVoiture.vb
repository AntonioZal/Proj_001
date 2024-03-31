Public Class CollectionDeVoiture

    Private lesvoitures As Collection

    Public Sub New()
        lesvoitures = New Collection
    End Sub

    Public Sub AjouterUneVoiture(ByVal wvoiture As Voiture)
        lesvoitures.Add(wvoiture)
    End Sub

    Public Sub SupprimerUneVoiture(ByVal wi As Integer)
        lesvoitures.Remove(wi)
    End Sub

    Public Function RetournerListeDesVoitures() As Collection
        Return lesvoitures
    End Function

    Public Function RetournerNombresDeVoiture() As Integer
        Return lesvoitures.Count
    End Function

    Public Function RetournerUneVoiture(ByVal wi As Integer) As Voiture
        Return lesvoitures.Item(wi)
    End Function

End Class