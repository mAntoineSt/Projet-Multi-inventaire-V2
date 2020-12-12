Public Class Parametres_Supplementaires
    Dim variables_application As New Variables_Application()
    Private Sub bSauvegarderChoix_Click(sender As Object, e As EventArgs) Handles bSauvegarderChoix.Click
        ChangementsVariablesApplication()
    End Sub

    Public Sub refreshObjetVariablesApplications(variables_application As Variables_Application)
        Me.variables_application = New Variables_Application(variables_application.getFrais_Retards_Emprunteurs, variables_application.getNbr_prets_max_emprunteurs, variables_application.getDelais_entre_prets_emprunteurs, variables_application.getDelais_minimum_retour_emprunteurs, variables_application.getNbr_Max_Equipements_Prets_emprunteurs,
                                                             variables_application.getFrais_Retards_Preteurs, variables_application.getNbr_prets_max_Preteurs, variables_application.getDelais_entre_prets_Preteurs, variables_application.getDelais_minimum_retour_Preteurs, variables_application.getNbr_Max_Equipements_Prets_Preteurs,
                                                             variables_application.getFrais_Retards_Administrateurs, variables_application.getNbr_prets_max_Administrateurs, variables_application.getDelais_entre_prets_Administrateurs, variables_application.getDelais_minimum_retour_Administrateurs, variables_application.getNbr_Max_Equipements_Prets_Administrateurs,
                                                             variables_application.getLangue, variables_application.getVisuel, variables_application.getStatut)
    End Sub

    Public Sub refreshInfos()
        If rbPreteurs.Checked = True Then
            tbFraisRetard.Text = variables_application.getFrais_Retards_Preteurs
            tbNbrPretsMaxPersonne.Text = variables_application.getNbr_prets_max_Preteurs
            tbDelaisMinEntrePrets.Text = variables_application.getDelais_entre_prets_Preteurs
            tbDelaisMinRetour.Text = variables_application.getDelais_minimum_retour_Preteurs
            tbNbrEquipementsMaxPret.Text = variables_application.getNbr_Max_Equipements_Prets_Preteurs
        ElseIf rbEmprunteurs.Checked = True Then
            tbFraisRetard.Text = variables_application.getFrais_Retards_Emprunteurs
            tbNbrPretsMaxPersonne.Text = variables_application.getNbr_prets_max_emprunteurs
            tbDelaisMinEntrePrets.Text = variables_application.getDelais_entre_prets_emprunteurs
            tbDelaisMinRetour.Text = variables_application.getDelais_minimum_retour_emprunteurs
            tbNbrEquipementsMaxPret.Text = variables_application.getNbr_Max_Equipements_Prets_emprunteurs
        ElseIf rbAdmins.Checked = True Then
            tbFraisRetard.Text = variables_application.getFrais_Retards_Administrateurs
            tbNbrPretsMaxPersonne.Text = variables_application.getNbr_prets_max_Administrateurs
            tbDelaisMinEntrePrets.Text = variables_application.getDelais_entre_prets_Administrateurs
            tbDelaisMinRetour.Text = variables_application.getDelais_minimum_retour_Administrateurs
            tbNbrEquipementsMaxPret.Text = variables_application.getNbr_Max_Equipements_Prets_Administrateurs
        End If
    End Sub

    Public Sub ChangementsVariablesApplication()
        'Vérification pour voir si tout est correct
        Dim testInt As Integer
        If Not Integer.TryParse(tbFraisRetard.Text, testInt) Then
            MessageBox.Show("Vous n'avez pas entré de nombres pour le montant des frais de retard", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not Integer.TryParse(tbNbrPretsMaxPersonne.Text, testInt) Then
            MessageBox.Show("Vous n'avez pas entré de nombres pour le nombre de prêts maximum par personnne", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not Integer.TryParse(tbDelaisMinEntrePrets.Text, testInt) Then
            MessageBox.Show("Vous n'avez pas entré de nombres pour le délai minimum entre chaque prêt", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not Integer.TryParse(tbDelaisMinRetour.Text, testInt) Then
            MessageBox.Show("Vous n'avez pas entré de nombres pour le délai minimum pour effectuer un retour", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not Integer.TryParse(tbNbrEquipementsMaxPret.Text, testInt) Then
            MessageBox.Show("Vous n'avez pas entré de nombres pour le nombre d'équipements maximum par prêt", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Vérifie si les infos rentrées sont toutes les mêmes qu'avant
        If (rbPreteurs.Checked = True AndAlso
                tbFraisRetard.Text = variables_application.getFrais_Retards_Preteurs AndAlso
                tbFraisRetard.Text = variables_application.getFrais_Retards_Preteurs AndAlso
                tbDelaisMinEntrePrets.Text = variables_application.getDelais_entre_prets_Preteurs AndAlso
                tbDelaisMinRetour.Text = variables_application.getDelais_minimum_retour_Preteurs AndAlso
                tbNbrEquipementsMaxPret.Text = variables_application.getNbr_Max_Equipements_Prets_Preteurs) = True OrElse
                    (rbEmprunteurs.Checked = True AndAlso
                    tbFraisRetard.Text = variables_application.getFrais_Retards_Emprunteurs AndAlso
                    tbFraisRetard.Text = variables_application.getFrais_Retards_Emprunteurs AndAlso
                    tbDelaisMinEntrePrets.Text = variables_application.getDelais_entre_prets_emprunteurs AndAlso
                    tbDelaisMinRetour.Text = variables_application.getDelais_minimum_retour_emprunteurs AndAlso
                    tbNbrEquipementsMaxPret.Text = variables_application.getNbr_Max_Equipements_Prets_emprunteurs) OrElse
                        (rbAdmins.Checked = True AndAlso
                        tbFraisRetard.Text = variables_application.getFrais_Retards_Emprunteurs AndAlso
                        tbFraisRetard.Text = variables_application.getFrais_Retards_Emprunteurs AndAlso
                        tbDelaisMinEntrePrets.Text = variables_application.getDelais_entre_prets_emprunteurs AndAlso
                        tbDelaisMinRetour.Text = variables_application.getDelais_minimum_retour_emprunteurs AndAlso
                        tbNbrEquipementsMaxPret.Text = variables_application.getNbr_Max_Equipements_Prets_emprunteurs) Then

            MessageBox.Show("Veuillez changer au minimum une info pour que ça ait de l'intérêt", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Si toutes les variables inscrites n'ont pas été modifiées, demande si l'utilisateur veut bien sauvegarder le tout.
        If MessageBox.Show("Voulez-vous enregistrer les modifications faites?", "Modification des variables de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        'Changement des informations dans l'objet des variables de l'application
        If rbPreteurs.Checked = True Then
            variables_application.setFrais_Retards_Preteurs(tbFraisRetard.Text)
            variables_application.setNbr_prets_max_Preteurs(tbNbrPretsMaxPersonne.Text)
            variables_application.setDelais_entre_prets_Preteurs(tbDelaisMinEntrePrets.Text)
            variables_application.setDelais_minimum_retour_Preteurs(tbDelaisMinRetour.Text)
            variables_application.setNbr_Max_Equipements_Prets_Preteurs(tbNbrEquipementsMaxPret.Text)
        ElseIf rbEmprunteurs.Checked = True Then
            variables_application.setFrais_Retards_Emprunteurs(tbFraisRetard.Text)
            variables_application.setNbr_prets_max_emprunteurs(tbNbrPretsMaxPersonne.Text)
            variables_application.setDelais_entre_prets_emprunteurs(tbDelaisMinEntrePrets.Text)
            variables_application.setDelais_minimum_retour_emprunteurs(tbDelaisMinRetour.Text)
            variables_application.setNbr_Max_Equipements_Prets_emprunteurs(tbNbrEquipementsMaxPret.Text)
        ElseIf rbAdmins.Checked = True Then
            variables_application.setFrais_Retards_Administrateurs(tbFraisRetard.Text)
            variables_application.setNbr_prets_max_Administrateurs(tbNbrPretsMaxPersonne.Text)
            variables_application.setDelais_entre_prets_Administrateurs(tbDelaisMinEntrePrets.Text)
            variables_application.setDelais_minimum_retour_Administrateurs(tbDelaisMinRetour.Text)
            variables_application.setNbr_Max_Equipements_Prets_Administrateurs(tbNbrEquipementsMaxPret.Text)
        End If
        MessageBox.Show("Les changements ont été sauvegardées !", "Sauvegarde réussie", MessageBoxButtons.OK, MessageBoxIcon.Information)
        refreshObjetVariablesApplications(variables_application)
    End Sub

    Private Sub rbEmprunteurs_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmprunteurs.CheckedChanged
        refreshInfos()
    End Sub

    Private Sub rbPreteurs_CheckedChanged(sender As Object, e As EventArgs) Handles rbPreteurs.CheckedChanged
        refreshInfos()
    End Sub

    Private Sub rbAdmins_CheckedChanged(sender As Object, e As EventArgs) Handles rbAdmins.CheckedChanged
        refreshInfos()
    End Sub
End Class