Imports System.Runtime.Remoting

Public Class Voiture

    Private plaque As String
    Private libelle As String
    Private marque As String
    Private model As String
    Private annee As String
    Private couleur As String
    Private kmbase As Integer

    Public Sub New(ByVal wplaque As String, ByVal wlibelle As String, ByVal wmarque As String, ByVal wmodel As String, ByVal wannee As String, ByVal wcouleur As String, ByVal wkmbase As Integer)
        Me.plaque = wplaque
        Me.libelle = wlibelle
        Me.marque = wmarque
        Me.model = wmodel
        Me.annee = wannee
        Me.couleur = wcouleur
        Me.kmbase = wkmbase
    End Sub

    Public Sub SupprimerUneVoiture()
        ' Promis Corentin je le ferrais un jour ! ;)
    End Sub

    Public Function RetournerPlaque() As String
        Return Me.plaque
    End Function

    Public Sub ModifierPlaque(ByVal wplaque As String)
        Me.plaque = wplaque
    End Sub

    Public Function RetournerLibelle() As String
        Return Me.libelle
    End Function

    Public Sub ModifierLibelle(ByVal wlibelle As String)
        Me.libelle = wlibelle
    End Sub

    Public Function RetournerMarque() As String
        Return Me.marque
    End Function

    Public Sub ModifierMarque(ByVal wmarque As String)
        Me.marque = wmarque
    End Sub

    Public Function RetournerModel() As String
        Return Me.model
    End Function

    Public Sub ModifierModel(ByVal wmodel As String)
        Me.model = wmodel
    End Sub

    Public Function RetournerAnnee() As String
        Return Me.annee
    End Function

    Public Sub ModifierAnnee(ByVal wannee As String)
        Me.annee = wannee
    End Sub

    Public Function RetournerCouleur() As String
        Return Me.couleur
    End Function

    Public Sub ModifierCouleur(ByVal wcouleur As String)
        Me.couleur = wcouleur
    End Sub

    Public Function RetournerKmBase() As Integer
        Return Me.kmbase
    End Function

    Public Sub ModifierKmBase(ByVal wkmbase As Integer)
        Me.kmbase = wkmbase
    End Sub

End Class
