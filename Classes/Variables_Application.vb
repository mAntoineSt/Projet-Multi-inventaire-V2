Public Class Variables_Application
    'Variables de la classe-----------------------------------------------------------------------------------------------

    'Pour les emprunteurs
    Dim frais_retards_emprunteurs As Double
    Dim nbr_prets_max_emprunteurs,
        delais_entre_prets_emprunteurs,
        delais_minimum_retour_emprunteurs,
        nbr_Max_Equipements_Prets_emprunteurs As Integer

    'Pour les prêteurs
    Dim frais_retards_preteurs As Double
    Dim nbr_prets_max_preteurs,
        delais_entre_prets_preteurs,
        delais_minimum_retour_preteurs,
        nbr_Max_Equipements_Prets_preteurs As Integer

    'Pour les administrateurs
    Dim frais_retards_administrateurs As Double
    Dim nbr_prets_max_administrateurs,
        delais_entre_prets_administrateurs,
        delais_minimum_retour_administrateurs,
        nbr_Max_Equipements_Prets_administrateurs As Integer

    'Pour la globalité dans l'application
    Dim langue,
        visuel,
        statut As String

    'PARTIE CONSTRUCTEUR----------------------------------------------------------------------------------------------------------
    Public Sub New()
        'Partie emprunteurs
        Me.frais_retards_emprunteurs = 1
        Me.nbr_prets_max_emprunteurs = 1
        Me.delais_entre_prets_emprunteurs = 1
        Me.delais_minimum_retour_emprunteurs = 1
        Me.nbr_Max_Equipements_Prets_emprunteurs = 1

        'Partie prêteurs
        Me.frais_retards_preteurs = 1
        Me.nbr_prets_max_preteurs = 1
        Me.delais_entre_prets_preteurs = 1
        Me.delais_minimum_retour_preteurs = 1
        Me.nbr_Max_Equipements_Prets_preteurs = 1

        'Partie administrateurs
        Me.frais_retards_administrateurs = 1
        Me.nbr_prets_max_administrateurs = 1
        Me.delais_entre_prets_administrateurs = 1
        Me.delais_minimum_retour_administrateurs = 1
        Me.nbr_Max_Equipements_Prets_administrateurs = 1

        'Partie globale
        Me.langue = "Francais"
        Me.visuel = "Clair"
        Me.statut = "Administrateur"
    End Sub
    Public Sub New(frais_retards_emprunteurs As Double, nbr_prets_max_emprunteurs As Integer, delais_entre_prets_emprunteurs As Integer, delais_minimum_retour_emprunteurs As Integer, nbr_Max_Equipements_Prets_emprunteurs As Integer,
                   frais_retards_preteurs As Double, nbr_prets_max_preteurs As Integer, delais_entre_prets_preteurs As Integer, delais_minimum_retour_preteurs As Integer, nbr_Max_Equipements_Prets_preteurs As Integer,
                   frais_retards_administrateurs As Double, nbr_prets_max_administrateurs As Integer, delais_entre_prets_administrateurs As Integer, delais_minimum_retour_administrateurs As Integer, nbr_Max_Equipements_Prets_administrateurs As Integer,
                   langue As String, visuel As String, statut As String)
        'Partie emprunteurs
        Me.frais_retards_emprunteurs = frais_retards_emprunteurs
        Me.nbr_prets_max_emprunteurs = nbr_prets_max_emprunteurs
        Me.delais_entre_prets_emprunteurs = delais_entre_prets_emprunteurs
        Me.delais_minimum_retour_emprunteurs = delais_minimum_retour_emprunteurs
        Me.nbr_Max_Equipements_Prets_emprunteurs = nbr_Max_Equipements_Prets_emprunteurs

        'Partie prêteurs
        Me.frais_retards_preteurs = frais_retards_preteurs
        Me.nbr_prets_max_preteurs = frais_retards_emprunteurs
        Me.delais_entre_prets_preteurs = delais_entre_prets_preteurs
        Me.delais_minimum_retour_preteurs = delais_minimum_retour_preteurs
        Me.nbr_Max_Equipements_Prets_preteurs = nbr_Max_Equipements_Prets_preteurs

        'Partie administrateurs
        Me.frais_retards_administrateurs = frais_retards_administrateurs
        Me.nbr_prets_max_administrateurs = nbr_prets_max_administrateurs
        Me.delais_entre_prets_administrateurs = delais_entre_prets_administrateurs
        Me.delais_minimum_retour_administrateurs = delais_minimum_retour_administrateurs
        Me.nbr_Max_Equipements_Prets_administrateurs = nbr_Max_Equipements_Prets_administrateurs

        'Partie globale
        Me.langue = langue
        Me.visuel = visuel
        Me.statut = statut
    End Sub

    'PARTIE GET-SET------------------------------------------------------------------------------------------------

    'Partie emprunteurs
    Public Function getFrais_Retards_Emprunteurs() As Double
        Return Me.frais_retards_emprunteurs
    End Function

    Public Sub setFrais_Retards_Emprunteurs(frais_retards_emprunteurs As Double)
        Me.frais_retards_emprunteurs = frais_retards_emprunteurs
    End Sub

    Public Function getNbr_prets_max_emprunteurs() As Integer
        Return Me.nbr_prets_max_emprunteurs
    End Function

    Public Sub setNbr_prets_max_emprunteurs(nbr_prets_max_emprunteurs As Integer)
        Me.nbr_prets_max_emprunteurs = nbr_prets_max_emprunteurs
    End Sub

    Public Function getDelais_entre_prets_emprunteurs() As Integer
        Return Me.delais_entre_prets_emprunteurs
    End Function

    Public Sub setDelais_entre_prets_emprunteurs(delais_entre_prets_emprunteurs As Integer)
        Me.delais_entre_prets_emprunteurs = delais_entre_prets_emprunteurs
    End Sub

    Public Function getDelais_minimum_retour_emprunteurs() As Integer
        Return Me.delais_minimum_retour_emprunteurs
    End Function

    Public Sub setDelais_minimum_retour_emprunteurs(delais_minimum_retour_emprunteurs As Integer)
        Me.delais_minimum_retour_emprunteurs = delais_minimum_retour_emprunteurs
    End Sub

    Public Function getNbr_Max_Equipements_Prets_emprunteurs() As Integer
        Return Me.nbr_Max_Equipements_Prets_emprunteurs
    End Function

    Public Sub setNbr_Max_Equipements_Prets_emprunteurs(nbr_Max_Equipements_Prets_emprunteurs As Integer)
        Me.nbr_Max_Equipements_Prets_emprunteurs = nbr_Max_Equipements_Prets_emprunteurs
    End Sub


    'Partie prêteurs
    Public Function getFrais_Retards_Preteurs() As Double
        Return Me.frais_retards_preteurs
    End Function

    Public Sub setFrais_Retards_Preteurs(frais_retards_preteurs As Double)
        Me.frais_retards_preteurs = frais_retards_preteurs
    End Sub

    Public Function getNbr_prets_max_Preteurs() As Integer
        Return Me.nbr_prets_max_preteurs
    End Function

    Public Sub setNbr_prets_max_Preteurs(nbr_prets_max_preteurs As Integer)
        Me.nbr_prets_max_preteurs = nbr_prets_max_preteurs
    End Sub

    Public Function getDelais_entre_prets_Preteurs() As Integer
        Return Me.delais_entre_prets_preteurs
    End Function

    Public Sub setDelais_entre_prets_Preteurs(delais_entre_prets_preteurs As Integer)
        Me.delais_entre_prets_preteurs = delais_entre_prets_preteurs
    End Sub

    Public Function getDelais_minimum_retour_Preteurs() As Integer
        Return Me.delais_minimum_retour_preteurs
    End Function

    Public Sub setDelais_minimum_retour_Preteurs(delais_minimum_retour_preteurs As Integer)
        Me.delais_minimum_retour_preteurs = delais_minimum_retour_preteurs
    End Sub

    Public Function getNbr_Max_Equipements_Prets_Preteurs() As Integer
        Return Me.nbr_Max_Equipements_Prets_preteurs
    End Function

    Public Sub setNbr_Max_Equipements_Prets_Preteurs(nbr_Max_Equipements_Prets_preteurs As Integer)
        Me.nbr_Max_Equipements_Prets_preteurs = nbr_Max_Equipements_Prets_preteurs
    End Sub

    'Partie administration
    Public Function getFrais_Retards_Administrateurs() As Double
        Return Me.frais_retards_administrateurs
    End Function

    Public Sub setFrais_Retards_Administrateurs(frais_retards_pdministrateurs As Double)
        Me.frais_retards_administrateurs = frais_retards_administrateurs
    End Sub

    Public Function getNbr_prets_max_Administrateurs() As Integer
        Return Me.nbr_prets_max_administrateurs
    End Function

    Public Sub setNbr_prets_max_Administrateurs(nbr_prets_max_administrateurs As Integer)
        Me.nbr_prets_max_administrateurs = nbr_prets_max_administrateurs
    End Sub

    Public Function getDelais_entre_prets_Administrateurs() As Integer
        Return Me.delais_entre_prets_administrateurs
    End Function

    Public Sub setDelais_entre_prets_Administrateurs(delais_entre_prets_administrateurs As Integer)
        Me.delais_entre_prets_administrateurs = delais_entre_prets_administrateurs
    End Sub

    Public Function getDelais_minimum_retour_Administrateurs() As Integer
        Return Me.delais_minimum_retour_administrateurs
    End Function

    Public Sub setDelais_minimum_retour_Administrateurs(delais_minimum_retour_administrateurs As Integer)
        Me.delais_minimum_retour_administrateurs = delais_minimum_retour_administrateurs
    End Sub

    Public Function getNbr_Max_Equipements_Prets_Administrateurs() As Integer
        Return Me.nbr_Max_Equipements_Prets_administrateurs
    End Function

    Public Sub setNbr_Max_Equipements_Prets_Administrateurs(nbr_Max_Equipements_Prets_administrateurs As Integer)
        Me.nbr_Max_Equipements_Prets_administrateurs = nbr_Max_Equipements_Prets_administrateurs
    End Sub

    'Partie globale
    Public Function getLangue() As String
        Return Me.langue
    End Function

    Public Sub setLangue(langue As String)
        Me.langue = langue
    End Sub

    Public Function getVisuel() As String
        Return Me.visuel
    End Function

    Public Sub setVisuel(langue As String)
        Me.visuel = visuel
    End Sub

    Public Function getStatut() As String
        Return Me.statut
    End Function

    Public Sub setStatut(statut As String)
        Me.statut = statut
    End Sub
End Class
