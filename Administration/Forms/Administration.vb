Public Class Administration
    'Création des objets pour les usercontrols
    Dim ucAccueilAdmin As New Accueil_Administration
    Dim ucGestionAdmin As New Gestion_Admins
    Dim ucGestionEmprunteurs As New Gestion_Emprunteurs
    Dim ucGestionPreteur As New Gestion_Preteurs
    Dim ucStatistiques As New Statistiques
    Dim emplacement As Point
    Dim langue As Integer = 0

    'Variables nécessaires
    Dim styleVisuel As Integer = 1

    'Variables utiles pour la Form
    Dim droits_administratif As Integer = 2

    'LE FORM---------------------------------------------------------------------------------------------
    Private Sub Administration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pUserControls.Controls.Add(ucAccueilAdmin)
        pUserControls.Controls.Add(ucGestionAdmin)
        pUserControls.Controls.Add(ucGestionEmprunteurs)
        pUserControls.Controls.Add(ucGestionPreteur)
        pUserControls.Controls.Add(ucStatistiques)
        ucAccueilAdmin.BringToFront()

        If droits_administratif = 1 Then
            ucAccueilAdmin.lRole.Text = "Prêteur"
            ucAccueilAdmin.lAccesGestionAdmins.Visible = False
            ucAccueilAdmin.lAccesStatistiques.Visible = False
            ucAccueilAdmin.lPasAccesGestionAdmins.Visible = True
            ucAccueilAdmin.lPasAccesGestionStats.Visible = True
        Else
            ucAccueilAdmin.lRole.Text = "Admin"
            ucAccueilAdmin.lPasAccesGestionAdmins.Visible = False
            ucAccueilAdmin.lPasAccesGestionStats.Visible = False
        End If

        If styleVisuel = 0 Then
            pHaut.BackColor = ColorTranslator.FromHtml("#4b6584")
            pBas.BackColor = ColorTranslator.FromHtml("#4b6584")
            Me.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucAccueilAdmin.pRole.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucAccueilAdmin.pAcces.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucAccueilAdmin.pPasAcces.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionAdmin.pTitre.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionEmprunteurs.pTitre.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionPreteur.pTitre.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionAdmin.bAjoutAdmin.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionAdmin.bModifAdmin.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionAdmin.bSuppressionAdmin.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionAdmin.bDroitsAdmins.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionPreteur.bAjoutPreteur.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionPreteur.bModifPreteur.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionPreteur.bSuppressionPreteur.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionPreteur.bDroitsPreteur.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionEmprunteurs.bAjoutEmprunteurs.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionEmprunteurs.bModifEmprunteurs.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionEmprunteurs.bSuppressionEmprunteurs.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionEmprunteurs.bDroitsEmprunteurs.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucStatistiques.bPartieGlobale.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucStatistiques.bEmprunteurs.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucStatistiques.bPreteurs.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucStatistiques.bAdministrateurs.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucStatistiques.bAdminsDOC.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bEmprunteursDOC.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bGlobaleDOC.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bPreteursDOC.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bAdminsPDF.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bEmprunteursPDF.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bGlobalePDF.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bPreteursPDF.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bAdminsCSV.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bEmprunteursCSV.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bGlobaleCSV.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bPreteursCSV.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.pCategories.BackColor = ColorTranslator.FromHtml("#4d73a1")

            ucStatistiques.bPartieGlobale.ForeColor = Color.Black
            ucStatistiques.bEmprunteurs.ForeColor = Color.Black
            ucStatistiques.bPreteurs.ForeColor = Color.Black
            ucStatistiques.bAdministrateurs.ForeColor = Color.Black
            ucStatistiques.bAdminsDOC.ForeColor = Color.Black
            ucStatistiques.bEmprunteursDOC.ForeColor = Color.Black
            ucStatistiques.bGlobaleDOC.ForeColor = Color.Black
            ucStatistiques.bPreteursDOC.ForeColor = Color.Black
            ucStatistiques.bAdminsPDF.ForeColor = Color.Black
            ucStatistiques.bEmprunteursPDF.ForeColor = Color.Black
            ucStatistiques.bGlobalePDF.ForeColor = Color.Black
            ucStatistiques.bPreteursPDF.ForeColor = Color.Black
            ucStatistiques.bAdminsCSV.ForeColor = Color.Black
            ucStatistiques.bEmprunteursCSV.ForeColor = Color.Black
            ucStatistiques.bGlobaleCSV.ForeColor = Color.Black
            ucStatistiques.bPreteursCSV.ForeColor = Color.Black
            ucStatistiques.pCategories.ForeColor = Color.Black
        Else
            pHaut.BackColor = ColorTranslator.FromHtml("#252926")
            pBas.BackColor = ColorTranslator.FromHtml("#252926")
            Me.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucAccueilAdmin.pRole.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucAccueilAdmin.pAcces.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucAccueilAdmin.pPasAcces.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionAdmin.pTitre.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionEmprunteurs.pTitre.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionPreteur.pTitre.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionAdmin.bAjoutAdmin.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionAdmin.bModifAdmin.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionAdmin.bSuppressionAdmin.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionAdmin.bDroitsAdmins.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionPreteur.bAjoutPreteur.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionPreteur.bModifPreteur.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionPreteur.bSuppressionPreteur.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionPreteur.bDroitsPreteur.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionEmprunteurs.bAjoutEmprunteurs.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionEmprunteurs.bModifEmprunteurs.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionEmprunteurs.bSuppressionEmprunteurs.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionEmprunteurs.bDroitsEmprunteurs.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucStatistiques.bPartieGlobale.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucStatistiques.bEmprunteurs.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucStatistiques.bPreteurs.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucStatistiques.bAdministrateurs.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucStatistiques.bAdminsDOC.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bEmprunteursDOC.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bGlobaleDOC.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bPreteursDOC.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bAdminsPDF.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bEmprunteursPDF.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bGlobalePDF.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bPreteursPDF.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bAdminsCSV.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bEmprunteursCSV.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bGlobaleCSV.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bPreteursCSV.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.pCategories.BackColor = ColorTranslator.FromHtml("#747d8c")

            ucStatistiques.bPartieGlobale.ForeColor = Color.White
            ucStatistiques.bEmprunteurs.ForeColor = Color.White
            ucStatistiques.bPreteurs.ForeColor = Color.White
            ucStatistiques.bAdministrateurs.ForeColor = Color.White
            ucStatistiques.bAdminsDOC.ForeColor = Color.White
            ucStatistiques.bEmprunteursDOC.ForeColor = Color.White
            ucStatistiques.bGlobaleDOC.ForeColor = Color.White
            ucStatistiques.bPreteursDOC.ForeColor = Color.White
            ucStatistiques.bAdminsPDF.ForeColor = Color.White
            ucStatistiques.bEmprunteursPDF.ForeColor = Color.White
            ucStatistiques.bGlobalePDF.ForeColor = Color.White
            ucStatistiques.bPreteursPDF.ForeColor = Color.White
            ucStatistiques.bAdminsCSV.ForeColor = Color.White
            ucStatistiques.bEmprunteursCSV.ForeColor = Color.White
            ucStatistiques.bGlobaleCSV.ForeColor = Color.White
            ucStatistiques.bPreteursCSV.ForeColor = Color.White
            ucStatistiques.pCategories.ForeColor = Color.White
        End If

        'Modifie la langue selon ce que l'utilisateur préfère
        If langue = 0 Then
            lTitreHaut.Text = "Menu administratif"
            lAccueilAdministratif.Text = "Accueil administratif"
            lGestionAdmins.Text = "Gestion des administrateurs"
            lGestionEmprunteurs.Text = "Gestion des emprunteurs"
            lGestionPreteurs.Text = "Gestion des prêteurs"
            lStatistiques.Text = "Statistiques"
            ucAccueilAdmin.lTitreRole.Text = "Votre rôle : "
            ucAccueilAdmin.lRole.Text = "ROLE"
            ucAccueilAdmin.lTitreAcces.Text = "Ce que vous avez accès"
            ucAccueilAdmin.lAccesGestionEmprunteurs.Text = "• À la gestion des emprunteurs"
            ucAccueilAdmin.lAccesGestionPreteurs.Text = "• À la gestion des prêteurs"
            ucAccueilAdmin.lAccesGestionAdmins.Text = "• À la gestion des administrateurs"
            ucAccueilAdmin.lAccesStatistiques.Text = "• Aux statistiques"
            ucAccueilAdmin.lTitrePasAcces.Text = "Ce que vous n'avez pas accès"
            ucAccueilAdmin.lPasAccesGestionAdmins.Text = "• À la gestion des administrateurs"
            ucAccueilAdmin.lPasAccesGestionStats.Text = "• Aux statistiques"
            ucGestionAdmin.lTitre.Text = "Gestion des administrateurs"
            ucGestionAdmin.bAjoutAdmin.Text = "Ajouter un nouvel administrateur"
            ucGestionAdmin.bModifAdmin.Text = "Modifier un administrateur"
            ucGestionAdmin.bSuppressionAdmin.Text = "Supprimer un administrateur"
            ucGestionAdmin.bDroitsAdmins.Text = "Enlever/Remettre les droits d'un administrateur"
            ucGestionEmprunteurs.lTitre.Text = "Gestion des emprunteurs"
            ucGestionEmprunteurs.bAjoutEmprunteurs.Text = "Ajouter un nouvel emprunteur"
            ucGestionEmprunteurs.bModifEmprunteurs.Text = "Modifier un emprunteur"
            ucGestionEmprunteurs.bSuppressionEmprunteurs.Text = "Supprimer un emprunteur"
            ucGestionEmprunteurs.bDroitsEmprunteurs.Text = "Enlever/Remettre les droits d'un emprunteur"
            ucGestionPreteur.lTitre.Text = "Gestion des prêteurs"
            ucGestionPreteur.bAjoutPreteur.Text = "Ajouter un nouvel prêteur"
            ucGestionPreteur.bModifPreteur.Text = "Modifier un prêteur"
            ucGestionPreteur.bSuppressionPreteur.Text = "Supprimer un prêteur"
            ucGestionPreteur.bDroitsPreteur.Text = "Enlever/Remettre les droits d'un prêteur"
            ucStatistiques.bPartieGlobale.Text = "Partie globale"
            ucStatistiques.bEmprunteurs.Text = "Partie emprunteurs"
            ucStatistiques.bPreteurs.Text = "Partie prêteurs"
            ucStatistiques.bAdministrateurs.Text = "Partie administrateurs"
            ucStatistiques.gbGlobale.Text = "Partie globale"
            ucStatistiques.gbPartieAdministrateur.Text = "Partie administrateurs"
            ucStatistiques.gbPartieEmprunteurs.Text = "Partie emprunteurs"
            ucStatistiques.gbPartiePreteurs.Text = "Partie prêteurs"
            ucStatistiques.lTitreGlobale.Text = "Toutes les infos en globalité de l'application"
            ucStatistiques.lGlobaleChoixMois.Text = "Mois"
            ucStatistiques.lGlobaleChoixAnnee.Text = "Année"
            ucStatistiques.lTitreNbrOuverturesApplis.Text = "Nombre d'ouvertures de l'application :"
            ucStatistiques.lTitreNbrPrets.Text = "Nombre de prêts enregistré :"
            ucStatistiques.lTitreNbrRetours.Text = "Nombre de retours effectuées :"
            ucStatistiques.lTitreNbrPersonneBD.Text = "Nombre de personnes inscrites dans la base de données :"
            ucStatistiques.lTitreNbrEmprunteurs.Text = "Nombre d'emprunteurs inscrit :"
            ucStatistiques.lTitreNbrPreteurs.Text = "Nombre de prêteurs inscrit :"
            ucStatistiques.lTitreNbrAdministratifs.Text = "Nombre d'administrateurs inscrit :"
            ucStatistiques.lTitreNbrEquipements.Text = "Nombre d'équipements inscrit :"
            ucStatistiques.lTitreNbrConditions.Text = "Nombre de conditions inscrites :"
            ucStatistiques.lTitreNbrResponsabilites.Text = "Nombre de responsabilités inscrites :"
            ucStatistiques.lTitreNbrFraisRetards.Text = "Nombre de frais de retards accumulées :"
            ucStatistiques.bGlobaleCSV.Text = "Exporter en .XLSX"
            ucStatistiques.bGlobaleDOC.Text = "Exporter en .DOCS"
            ucStatistiques.bGlobalePDF.Text = "Exporter en .PDF"
            ucStatistiques.lTitrePartieEmprunteurs.Text = "Toutes les infos des emprunteurs de l'application"
            ucStatistiques.lEmprunteurTitreChoixMois.Text = "Mois"
            ucStatistiques.lEmprunteurTitreChoixAnnee.Text = "Année"
            ucStatistiques.lEmprunteursTitreNbrEmprunteurs.Text = "Nombre d'emprunteurs :"
            ucStatistiques.lEmprunteursTitreNbrEmpruntsActifs.Text = "Nombre d'emprunteurs actifs :"
            ucStatistiques.lEmprunteurTitreEmprunteursSuspendues.Text = "Nombre d'emprunteurs suspendues :"
            ucStatistiques.lEmprunteurTitreNbrPretsEffectuees.Text = "Nombre de prêts effectuées :"
            ucStatistiques.lEmprunteursTitreNbrPretsActifs.Text = "Nombre de prêts actifs :"
            ucStatistiques.lEmprunteursTitreNbrRetoursEffectuees.Text = "Nombre de retours efectuées :"
            ucStatistiques.bEmprunteursCSV.Text = "Exporter en .XLSX"
            ucStatistiques.bEmprunteursDOC.Text = "Exporter en .DOCS"
            ucStatistiques.bEmprunteursPDF.Text = "Exporter en .PDF"
            ucStatistiques.lPreteursTitre.Text = "Toutes les infos des prêteurs de l'application"
            ucStatistiques.lPreteursTitreChoixMois.Text = "Mois"
            ucStatistiques.lPreteursTitreChoixAnnee.Text = "Année"
            ucStatistiques.lPreteursTitreNbrPreteurs.Text = "Nombre de prêteurs :"
            ucStatistiques.lPreteursTitreNbrPreteursActifs.Text = "Nombre de prêteurs actifs :"
            ucStatistiques.lPreteursTitreNbrPreteursSuspendues.Text = "Nombre de prêteurs suspendues :"
            ucStatistiques.lPreteursTitreNbrPretsAutorisees.Text = "Nombre de prêts autorisés :"
            ucStatistiques.lPreteursTitreNbrRetoursAutorisees.Text = "Nombre de retours autorisés :"
            ucStatistiques.lPreteursTitreNbrRetoursAttentesAutorisation.Text = "Nombre de retours en attente d'autorisations :"
            ucStatistiques.bPreteursCSV.Text = "Exporter en .XLSX"
            ucStatistiques.bPreteursDOC.Text = "Exporter en .DOCS"
            ucStatistiques.bPreteursPDF.Text = "Exporter en .PDF"
            ucStatistiques.lTitreAdministrateur.Text = "Toutes les infos des administrateurs de l'application"
            ucStatistiques.lAdminsTitreChoixMois.Text = "Mois"
            ucStatistiques.lAdminsTitreChoixAnnee.Text = "Année"
            ucStatistiques.lAdminsTitreNombreAdmins.Text = "Nombre d'admins :"
            ucStatistiques.lAdminsTitreNbrAdminsActifs.Text = "Nombre d'admins actifs :"
            ucStatistiques.lAdminsTitreNbrAdminsSuspendues.Text = "Nombre d'admins suspendues :"
            ucStatistiques.bAdminsCSV.Text = "Exporter en .XLSX"
            ucStatistiques.bAdminsDOC.Text = "Exporter en .DOCS"
            ucStatistiques.bAdminsPDF.Text = "Exporter en .PDF"
        Else
            lTitreHaut.Text = "Administrative menu"
            lAccueilAdministratif.Text = "Administrative reception"
            lGestionAdmins.Text = "Administrators management"
            lGestionEmprunteurs.Text = "Management of borrowers"
            lGestionPreteurs.Text = "Management of lenders"
            lStatistiques.Text = "Statistics"
            ucAccueilAdmin.lTitreRole.Text = "Your role :"
            ucAccueilAdmin.lRole.Text = "ROLE"
            ucAccueilAdmin.lTitreAcces.Text = "What you have access to"
            ucAccueilAdmin.lAccesGestionEmprunteurs.Text = "• To the management of borrowers"
            ucAccueilAdmin.lAccesGestionPreteurs.Text = "• To the management of lenders"
            ucAccueilAdmin.lAccesGestionAdmins.Text = "• To the management of administrators"
            ucAccueilAdmin.lAccesStatistiques.Text = "• Statistics"
            ucAccueilAdmin.lTitrePasAcces.Text = "What you don't have access to"
            ucAccueilAdmin.lPasAccesGestionAdmins.Text = "• To the management of administrators"
            ucAccueilAdmin.lPasAccesGestionStats.Text = "• Statistics"
            ucGestionAdmin.lTitre.Text = "Administrators management"
            ucGestionAdmin.bAjoutAdmin.Text = "Add a new administrator"
            ucGestionAdmin.bModifAdmin.Text = "Modify an administrator"
            ucGestionAdmin.bSuppressionAdmin.Text = "Delete an administrator"
            ucGestionAdmin.bDroitsAdmins.Text = "Remove / Reset the rights of an administrator"
            ucGestionEmprunteurs.lTitre.Text = "Management of borrowers"
            ucGestionEmprunteurs.bAjoutEmprunteurs.Text = "Add a new borrower"
            ucGestionEmprunteurs.bModifEmprunteurs.Text = "Modify a new borrower"
            ucGestionEmprunteurs.bSuppressionEmprunteurs.Text = "Delete a new borrower"
            ucGestionEmprunteurs.bDroitsEmprunteurs.Text = "Remove / Reset the rights of an borrower"
            ucGestionPreteur.lTitre.Text = "Management of lenders"
            ucGestionPreteur.bAjoutPreteur.Text = "Add a new lender"
            ucGestionPreteur.bModifPreteur.Text = "Modify a new lender"
            ucGestionPreteur.bSuppressionPreteur.Text = "Delete a new lender"
            ucGestionPreteur.bDroitsPreteur.Text = "Remove / Reset the rights of an lender"
            ucStatistiques.bPartieGlobale.Text = "Global part"
            ucStatistiques.bEmprunteurs.Text = "Borrowers part"
            ucStatistiques.bPreteurs.Text = "Lenders part"
            ucStatistiques.bAdministrateurs.Text = "Administrators part"
            ucStatistiques.gbGlobale.Text = "Global part"
            ucStatistiques.gbPartieAdministrateur.Text = "Administrators part"
            ucStatistiques.gbPartieEmprunteurs.Text = "Borrowers part"
            ucStatistiques.gbPartiePreteurs.Text = "Lenders part"
            ucStatistiques.lTitreGlobale.Text = "All the information about the application"
            ucStatistiques.lGlobaleChoixMois.Text = "Month"
            ucStatistiques.lGlobaleChoixAnnee.Text = "Year"
            ucStatistiques.lTitreNbrOuverturesApplis.Text = "Number of times the application was opened:"
            ucStatistiques.lTitreNbrPrets.Text = "Number of loans registered:"
            ucStatistiques.lTitreNbrRetours.Text = "Number of returns made:"
            ucStatistiques.lTitreNbrPersonneBD.Text = "Number of people registered in the database:"
            ucStatistiques.lTitreNbrEmprunteurs.Text = "Number of registered borrowers:"
            ucStatistiques.lTitreNbrPreteurs.Text = "Number of registered lenders:"
            ucStatistiques.lTitreNbrAdministratifs.Text = "Number of registered administrators:"
            ucStatistiques.lTitreNbrEquipements.Text = "Number of equipment registered:"
            ucStatistiques.lTitreNbrConditions.Text = "Number of conditions listed:"
            ucStatistiques.lTitreNbrResponsabilites.Text = "Number of responsibilities listed:"
            ucStatistiques.lTitreNbrFraisRetards.Text = "Number of accumulated late fees:"
            ucStatistiques.bGlobaleCSV.Text = "Export to .XLSX"
            ucStatistiques.bGlobaleDOC.Text = "Export to .DOCS"
            ucStatistiques.bGlobalePDF.Text = "Export to .PDF"
            ucStatistiques.lTitrePartieEmprunteurs.Text = "All the information of borrowers in the application"
            ucStatistiques.lEmprunteurTitreChoixMois.Text = "Month"
            ucStatistiques.lEmprunteurTitreChoixAnnee.Text = "Year"
            ucStatistiques.lEmprunteursTitreNbrEmprunteurs.Text = "Number of borrowers:"
            ucStatistiques.lEmprunteursTitreNbrEmpruntsActifs.Text = "Number of active borrowers:"
            ucStatistiques.lEmprunteurTitreEmprunteursSuspendues.Text = "Number of suspended borrowers:"
            ucStatistiques.lEmprunteurTitreNbrPretsEffectuees.Text = "Number of loans made:"
            ucStatistiques.lEmprunteursTitreNbrPretsActifs.Text = "Number of active loans:"
            ucStatistiques.lEmprunteursTitreNbrRetoursEffectuees.Text = "Number of returns made:"
            ucStatistiques.bEmprunteursCSV.Text = "Export to .XLSX"
            ucStatistiques.bEmprunteursDOC.Text = "Export to .DOCS"
            ucStatistiques.bEmprunteursPDF.Text = "Export to .PDF"
            ucStatistiques.lPreteursTitre.Text = "All the information of the lenders of the application"
            ucStatistiques.lPreteursTitreChoixMois.Text = "Month"
            ucStatistiques.lPreteursTitreChoixAnnee.Text = "Year"
            ucStatistiques.lPreteursTitreNbrPreteurs.Text = "Number of lenders:"
            ucStatistiques.lPreteursTitreNbrPreteursActifs.Text = "Number of active lenders:"
            ucStatistiques.lPreteursTitreNbrPreteursSuspendues.Text = "Number of suspended lenders:"
            ucStatistiques.lPreteursTitreNbrPretsAutorisees.Text = "Number of loans authorized:"
            ucStatistiques.lPreteursTitreNbrRetoursAutorisees.Text = "Number of authorized returns:"
            ucStatistiques.lPreteursTitreNbrRetoursAttentesAutorisation.Text = "Number of returns pending authorization:"
            ucStatistiques.bPreteursCSV.Text = "Export to .XLSX"
            ucStatistiques.bPreteursDOC.Text = "Export to .DOCS"
            ucStatistiques.bPreteursPDF.Text = "Export to .PDF"
            ucStatistiques.lTitreAdministrateur.Text = "All the information of the administrators of the application"
            ucStatistiques.lAdminsTitreChoixMois.Text = "Month"
            ucStatistiques.lAdminsTitreChoixAnnee.Text = "Year"
            ucStatistiques.lAdminsTitreNombreAdmins.Text = "Number of admins:"
            ucStatistiques.lAdminsTitreNbrAdminsActifs.Text = "Number of active admins:"
            ucStatistiques.lAdminsTitreNbrAdminsSuspendues.Text = "Number of suspended admins:"
            ucStatistiques.bAdminsCSV.Text = "Export to .XLSX"
            ucStatistiques.bAdminsDOC.Text = "Export to .DOCS"
            ucStatistiques.bAdminsPDF.Text = "Export to .PDF"
        End If

    End Sub

    'LES LABELS------------------------------------------------------------------------------------------------------

    Private Sub lQuitter_Click(sender As Object, e As EventArgs) Handles lQuitter.Click
        Me.Close()
    End Sub

    Private Sub lAccueilAdministratif_Click(sender As Object, e As EventArgs) Handles lAccueilAdministratif.Click
        ucAccueilAdmin.BringToFront()
    End Sub

    Private Sub lGestionAdmins_Click(sender As Object, e As EventArgs) Handles lGestionAdmins.Click
        If droits_administratif <> 2 Then
            MessageBox.Show("Vous n'avez pas accès à cette partie administrative.", "AVERTISSEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ucGestionAdmin.BringToFront()
        ucGestionAdmin.refreshDataGridView()
    End Sub

    Private Sub lGestionEmpreuteurs_Click(sender As Object, e As EventArgs) Handles lGestionEmprunteurs.Click
        ucGestionEmprunteurs.BringToFront()
        ucGestionEmprunteurs.refreshDataGridView()
    End Sub

    Private Sub lGestionPreteurs_Click(sender As Object, e As EventArgs) Handles lGestionPreteurs.Click
        ucGestionPreteur.BringToFront()
        ucGestionPreteur.refreshDataGridView()
    End Sub

    Private Sub lStatistiques_Click(sender As Object, e As EventArgs) Handles lStatistiques.Click
        If droits_administratif <> 2 Then
            MessageBox.Show("Vous n'avez pas accès à cette partie administrative.", "AVERTISSEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ucStatistiques.refreshInfos()
        ucStatistiques.refreshComboboxes()
        ucStatistiques.BringToFront()

    End Sub

    Private Sub pHaut_MouseDown(sender As Object, e As MouseEventArgs) Handles pHaut.MouseDown, lTitreHaut.MouseDown, lQuitter.MouseDown
        If e.Button = MouseButtons.Left Then
            emplacement = e.Location
        End If
    End Sub

    Private Sub pHaut_MouseMove(sender As Object, e As MouseEventArgs) Handles pHaut.MouseMove, lTitreHaut.MouseMove, lQuitter.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - emplacement
        End If
    End Sub
End Class