Public Class Accueil
    Dim emplacement As Point
    Dim styleVisuel As Integer = 1
    Private Sub FaireUnEmpruntToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim emprunt As New PretAjout()
        'emprunt.Show()
    End Sub

    Private Sub buttonFaireEmprunt_Click(sender As Object, e As EventArgs) Handles bFaireEmprunt.Click
        Prets_V2.ShowDialog()
    End Sub

    Private Sub HistoriqueDesEmpruntsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim hist As New Prets()
        'hist.Show()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub FaireUnRetourToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim retour As New RetourAjout()
        retour.Show()
    End Sub

    Private Sub buttonFaireRetour_Click(sender As Object, e As EventArgs) Handles bFaireRetour.Click
        Retours_V2.ShowDialog()
    End Sub

    Private Sub HistoriqueDesRetoursToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim hist As New Retours()
        hist.Show()
    End Sub

    Private Sub EmprunteurToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub buttonHistEmprunt_Click(sender As Object, e As EventArgs) Handles bHistEmprunt.Click
        Dim hist As New Prets()
        hist.Show()
    End Sub

    Private Sub buttonHistRetours_Click(sender As Object, e As EventArgs) Handles bHistRetours.Click
        Dim hist As New Retours()
        hist.ShowDialog()
    End Sub


    'FONCTIONS-------------------------------------------------------------------------------------------------------
    Public Sub role(role As String)
        MessageBox.Show("Bonjour " & role & " !")
        lNomUtilisateur.Text = role
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changement_visuel()
    End Sub

    'Sert à changer le style visuel de l'application
    Private Sub changement_visuel()
        If styleVisuel = 0 Then
            pHaut.BackColor = ColorTranslator.FromHtml("#4b6584")
            pBas.BackColor = ColorTranslator.FromHtml("#4b6584")
            Me.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            bFaireEmprunt.ForeColor = Color.White
            bFaireEmprunt.BackColor = ColorTranslator.FromHtml("#4d73a1")
            bFaireRetour.ForeColor = Color.White
            bFaireRetour.BackColor = ColorTranslator.FromHtml("#4d73a1")
            bHistEmprunt.ForeColor = Color.White
            bHistEmprunt.BackColor = ColorTranslator.FromHtml("#4d73a1")
            bHistRetours.ForeColor = Color.White
            bHistRetours.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMsFichier.ForeColor = Color.Black
            lMsFichier.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMsQuitter.ForeColor = Color.Black
            lMsQuitter.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMsEmprunts.ForeColor = Color.Black
            lMsEmprunts.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMsFaireEmprunt.ForeColor = Color.Black
            lMsFaireEmprunt.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMsHistoriqueEmprunt.ForeColor = Color.Black
            lMsHistoriqueEmprunt.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMsRetours.ForeColor = Color.Black
            lMsRetours.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMsFaireRetour.ForeColor = Color.Black
            lMsFaireRetour.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMsHistoriqueRetours.ForeColor = Color.Black
            lMsHistoriqueRetours.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMsDossiers.ForeColor = Color.Black
            lMsDossiers.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMsConsulter.ForeColor = Color.Black
            lMsConsulter.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMsEmprunteur.ForeColor = Color.Black
            lMsEmprunteur.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMsOptions.ForeColor = Color.Black
            lMsOptions.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lTitreRichTextBox.ForeColor = Color.Black
            lNomUtilisateur.ForeColor = Color.Black
            lDeconnection.ForeColor = Color.Black
            lDeconnection.BackColor = ColorTranslator.FromHtml("#4d73a1")

        Else
            pHaut.BackColor = ColorTranslator.FromHtml("#252926")
            pBas.BackColor = ColorTranslator.FromHtml("#252926")
            Me.BackColor = ColorTranslator.FromHtml("#3c403d")
            bFaireEmprunt.ForeColor = Color.White
            bFaireEmprunt.BackColor = ColorTranslator.FromHtml("#747d8c")
            bFaireRetour.ForeColor = Color.White
            bFaireRetour.BackColor = ColorTranslator.FromHtml("#747d8c")
            bHistEmprunt.ForeColor = Color.White
            bHistEmprunt.BackColor = ColorTranslator.FromHtml("#747d8c")
            bHistRetours.ForeColor = Color.White
            bHistRetours.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMsFichier.ForeColor = Color.Black
            lMsFichier.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMsQuitter.ForeColor = Color.Black
            lMsQuitter.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMsEmprunts.ForeColor = Color.Black
            lMsEmprunts.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMsFaireEmprunt.ForeColor = Color.Black
            lMsFaireEmprunt.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMsHistoriqueEmprunt.ForeColor = Color.Black
            lMsHistoriqueEmprunt.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMsRetours.ForeColor = Color.Black
            lMsRetours.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMsFaireRetour.ForeColor = Color.Black
            lMsFaireRetour.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMsHistoriqueRetours.ForeColor = Color.Black
            lMsHistoriqueRetours.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMsDossiers.ForeColor = Color.Black
            lMsDossiers.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMsConsulter.ForeColor = Color.Black
            lMsConsulter.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMsEmprunteur.ForeColor = Color.Black
            lMsEmprunteur.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMsOptions.ForeColor = Color.Black
            lMsOptions.BackColor = ColorTranslator.FromHtml("#747d8c")
            lTitreRichTextBox.ForeColor = Color.White
            lNomUtilisateur.ForeColor = Color.White
            lDeconnection.ForeColor = Color.White
            lDeconnection.BackColor = ColorTranslator.FromHtml("#747d8c")

        End If
    End Sub

    Private Sub lQuitter_Click(sender As Object, e As EventArgs) Handles lQuitter.Click
        End
    End Sub

    'PARTIE DES PANELS--------------------------------------------------------------------------------------------------------------
    Private Sub pHaut_MouseDown(sender As Object, e As MouseEventArgs) Handles pHaut.MouseDown, lTitre.MouseDown, lQuitter.MouseDown
        If e.Button = MouseButtons.Left Then
            emplacement = e.Location
        End If
    End Sub

    Private Sub pHaut_MouseMove(sender As Object, e As MouseEventArgs) Handles pHaut.MouseMove, lTitre.MouseMove, lQuitter.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - emplacement
        End If
    End Sub

    'PARTIE DU MENU DU HAUT--------------------------------------------------------------------------------------------------------
    Private Sub refreshMenuHaut()
        lMsQuitter.Enabled = False
        lMsQuitter.Visible = False
        lMsFaireEmprunt.Enabled = False
        lMsFaireEmprunt.Visible = False
        lMsHistoriqueEmprunt.Enabled = False
        lMsHistoriqueEmprunt.Visible = False
        lMsFaireRetour.Enabled = False
        lMsFaireRetour.Visible = False
        lMsHistoriqueRetours.Enabled = False
        lMsHistoriqueRetours.Visible = False
        lMsConsulter.Enabled = False
        lMsConsulter.Visible = False
        lMsEmprunteur.Enabled = False
        lMsEmprunteur.Visible = False
    End Sub

    Private Sub Accueil_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        refreshMenuHaut()
    End Sub

    Private Sub lMsFichier_Click(sender As Object, e As EventArgs) Handles lMsFichier.Click
        refreshMenuHaut()
        lMsQuitter.Enabled = True
        lMsQuitter.Visible = True
    End Sub

    Private Sub lMsEmprunts_Click(sender As Object, e As EventArgs) Handles lMsEmprunts.Click
        refreshMenuHaut()
        lMsFaireEmprunt.Enabled = True
        lMsFaireEmprunt.Visible = True
        lMsHistoriqueEmprunt.Enabled = True
        lMsHistoriqueEmprunt.Visible = True
    End Sub

    Private Sub lMsRetours_Click(sender As Object, e As EventArgs) Handles lMsRetours.Click
        refreshMenuHaut()
        lMsFaireRetour.Enabled = True
        lMsFaireRetour.Visible = True
        lMsHistoriqueRetours.Visible = True
        lMsHistoriqueRetours.Enabled = True
    End Sub

    Private Sub lMsDossiers_Click(sender As Object, e As EventArgs) Handles lMsDossiers.Click
        refreshMenuHaut()
        lMsConsulter.Enabled = True
        lMsConsulter.Visible = True
    End Sub

    Private Sub lMsConsulter_Click(sender As Object, e As EventArgs) Handles lMsConsulter.Click
        lMsEmprunteur.Enabled = True
        lMsEmprunteur.Visible = True
    End Sub

    Private Sub lMsQuitter_Click(sender As Object, e As EventArgs) Handles lMsQuitter.Click
        End
    End Sub

    Private Sub lMsFaireEmprunt_Click(sender As Object, e As EventArgs) Handles lMsFaireEmprunt.Click
        Prets_V2.ShowDialog()
    End Sub

    Private Sub lMsHistoriqueEmprunt_Click(sender As Object, e As EventArgs) Handles lMsHistoriqueEmprunt.Click
        MessageBox.Show("L'historique des emprunts")
    End Sub

    Private Sub lMsFaireRetour_Click(sender As Object, e As EventArgs) Handles lMsFaireRetour.Click
        Retours_V2.ShowDialog()
    End Sub

    Private Sub lMsHistoriqueRetours_Click(sender As Object, e As EventArgs) Handles lMsHistoriqueRetours.Click
        MessageBox.Show("L'historique des retours")
    End Sub

    Private Sub lMsEmprunteur_Click(sender As Object, e As EventArgs) Handles lMsEmprunteur.Click
        MessageBox.Show("Les emprunteurs")
    End Sub

    Private Sub lMsOptions_Click(sender As Object, e As EventArgs) Handles lMsOptions.Click
        refreshMenuHaut()
        Options.ShowDialog()
    End Sub

    Private Sub lDeconnection_Click(sender As Object, e As EventArgs) Handles lDeconnection.Click
        Connexion.Show()
        Me.Close()
    End Sub

    Private Sub lMsAdministration_Click(sender As Object, e As EventArgs) Handles lMsAdministration.Click
        Administration.ShowDialog()
    End Sub

    Private Sub lMsEquipements_Click(sender As Object, e As EventArgs) Handles lMsEquipements.Click
        GestionMateriel.ShowDialog()
    End Sub
End Class