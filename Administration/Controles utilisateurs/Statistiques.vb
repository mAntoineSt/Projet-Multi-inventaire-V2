﻿'Importation nécessaire
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Statistiques
    'Variables nécessaires
    Dim con As MySqlConnection = New MySqlConnection("Server=localhost;Database=projet_multi;Uid=root;Pwd='';Port=3308;")
    Dim reader As MySqlDataReader
    Dim commande As New MySqlCommand

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie globale
    Private Sub bPartieGlobale_Click(sender As Object, e As EventArgs) Handles bPartieGlobale.Click
        visibleFalseEverything()
        gbGlobale.Visible = True
        refreshInfos()
    End Sub

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie emprunteurs
    Private Sub bEmprunteurs_Click(sender As Object, e As EventArgs) Handles bEmprunteurs.Click
        visibleFalseEverything()
        gbPartieEmprunteurs.Visible = True
        refreshInfos()
    End Sub

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie prêteurs
    Private Sub bPreteurs_Click(sender As Object, e As EventArgs) Handles bPreteurs.Click
        visibleFalseEverything()
        gbPartiePreteurs.Visible = True
        refreshInfos()
    End Sub

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie administrateurs
    Private Sub bAdministrateurs_Click(sender As Object, e As EventArgs) Handles bAdministrateurs.Click
        visibleFalseEverything()
        gbPartieAdministrateur.Visible = True
        refreshInfos()
    End Sub

    'Fonction privée servant à faire disparaître toutes les groupBox
    Private Sub visibleFalseEverything()
        gbGlobale.Visible = False
        gbPartieEmprunteurs.Visible = False
        gbPartiePreteurs.Visible = False
        gbPartieAdministrateur.Visible = False
    End Sub

    'PARTIE BOUTONS archivage externe

    'PARTIE XLSX (EXCEL)
    Private Sub bPreteursXLSX_Click(sender As Object, e As EventArgs) Handles bPreteursXLSX.Click
        archivageXLSX(1)
    End Sub

    Private Sub bEmprunteursXLSX_Click(sender As Object, e As EventArgs) Handles bEmprunteursXLSX.Click
        archivageXLSX(2)
    End Sub

    Private Sub bAdminsXLSX_Click(sender As Object, e As EventArgs) Handles bAdminsXLSX.Click
        archivageXLSX(3)
    End Sub

    Private Sub bGlobaleXLSX_Click(sender As Object, e As EventArgs) Handles bGlobaleXLSX.Click
        archivageXLSX(4)
    End Sub

    Private Sub archivageXLSX(type As Integer)
        Dim sfd As New SaveFileDialog

        sfd.Filter = "Excel Files|*.xlsx"
        sfd.DefaultExt = "xlsx"
        sfd.ShowDialog()

        If String.IsNullOrWhiteSpace(sfd.FileName) Then
            Return
        End If

        Dim sw As New StreamWriter(sfd.FileName)



        Select Case type
            Case 1
                'Partie Prêteurs
                sw.WriteLine("Résumé des statistiques des prêteurs")
                sw.WriteLine("")
                sw.WriteLine("Nombre de prêteurs;", lPreteursNbrPreteurs)
                sw.WriteLine("Nombre de prêteurs actifs;", lPreteursNbrPreteursActifs)
                sw.WriteLine("Nombre de prêteurs suspendues;", lPreteursNbrPreteursSuspendues)
                sw.WriteLine("Nombre de prêts autorisés;", lPreteursNbrPretsAutorisees)
                sw.WriteLine("Nombre de retours autorisés;", lPreteursNbrRetoursAutorisees)
                sw.WriteLine("Nombre de retours en attente d'autorisations;", lPreteursNbrRetoursAttentesAutorisation)

            Case 2
                'Partie Emprunteurs

            Case 3
                'Partie Admins

            Case 4
                'Partie Globale

        End Select

        sw.Close()
    End Sub

    'PARTIE DOCS (Word)
    Private Sub bPreteursDOCS_Click(sender As Object, e As EventArgs) Handles bPreteursDOCS.Click
        archivageDOCS(1)
    End Sub

    Private Sub bEmprunteursDOCS_Click(sender As Object, e As EventArgs) Handles bEmprunteursDOCS.Click
        archivageDOCS(2)
    End Sub

    Private Sub bAdminsDOCS_Click(sender As Object, e As EventArgs) Handles bAdminsDOCS.Click
        archivageDOCS(3)
    End Sub

    Private Sub bGlobaleDOCS_Click(sender As Object, e As EventArgs) Handles bGlobaleDOCS.Click
        archivageDOCS(4)
    End Sub

    Private Sub archivageDOCS(type As Integer)
        Select Case type
            Case 1
                'Partie Prêteurs

            Case 2
                'Partie Emprunteurs

            Case 3
                'Partie Admins

            Case 4
                'Partie Globale

        End Select
    End Sub

    'PARTIE PDF
    Private Sub bPreteursPDF_Click(sender As Object, e As EventArgs) Handles bPreteursPDF.Click
        archivagePDF(1)
    End Sub

    Private Sub bEmprunteursPDF_Click(sender As Object, e As EventArgs) Handles bEmprunteursPDF.Click
        archivagePDF(2)
    End Sub

    Private Sub bAdminsPDF_Click(sender As Object, e As EventArgs) Handles bAdminsPDF.Click
        archivagePDF(3)
    End Sub

    Private Sub bGlobalePDF_Click(sender As Object, e As EventArgs) Handles bGlobalePDF.Click
        archivagePDF(4)
    End Sub

    Private Sub archivagePDF(type As Integer)
        Select Case type
            Case 1
                'Partie Prêteurs

            Case 2
                'Partie Emprunteurs

            Case 3
                'Partie Admins

            Case 4
                'Partie Globale

        End Select
    End Sub

    Public Sub refreshInfos()
        Try
            commande.Connection = con
            If gbGlobale.Visible = True Then
                'PARTIE GLOBALE
                If cbGlobaleChoixAnnee.SelectedIndex = -1 AndAlso cbGlobaleChoixMois.SelectedIndex = -1 Then

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=1;"
                    con.Open()
                    reader = commande.ExecuteReader()
                    reader.Read()
                    lNbrOuverturesApplis.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_pret) from prets;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPrets.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_retour) from retours;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrRetours.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPersonneBD.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus where statut='emprunteur';"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrEmprunteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus where statut='preteur';"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPreteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus where statut='admin';"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrAdministratifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_equipement) from equipements;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrEquipements.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_condition) from conditions;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrConditions.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_responsabilite) from responsabilites;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrResponsabilites.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select sum(montant_dommages) from retards;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrFraisRetards.Text = reader(0) & "$"
                    reader.Close()
                    con.Close()

                ElseIf Not cbGlobaleChoixAnnee.SelectedIndex = -1 AndAlso cbGlobaleChoixMois.SelectedIndex = -1 Then

                ElseIf cbGlobaleChoixAnnee.SelectedIndex = -1 AndAlso cbGlobaleChoixMois.SelectedIndex = -1 Then

                Else

                End If


            ElseIf gbPartieAdministrateur.Visible = True Then
                'PARTIE ADMINISTRATEURS
                If cbAdminsChoixAnnee.SelectedIndex = -1 AndAlso cbAdminsChoixMois.SelectedIndex = -1 Then
                    commande.CommandText = "select count(id_individu) from individus where statut='admin';"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNombreAdmins.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus where statut='admin' and id_individu not in(select id_individu from suspensions)"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNbrAdminsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus where statut='admin' and id_individu in(select id_individu from suspensions);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNbrAdminsSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()
                ElseIf Not cbAdminsChoixAnnee.SelectedIndex = -1 AndAlso cbAdminsChoixMois.SelectedIndex = -1 Then

                ElseIf cbAdminsChoixAnnee.SelectedIndex = -1 AndAlso cbAdminsChoixMois.SelectedIndex = -1 Then

                Else

                End If

            ElseIf gbPartieEmprunteurs.Visible = True Then
                'PARTIE EMPRUNTEURS
                If cbEmprunteurChoixAnnee.SelectedIndex = -1 AndAlso cbEmprunteurChoixMois.SelectedIndex = -1 Then

                    commande.CommandText = "select count(id_individu) from individus where statut='emprunteur';"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrEmprunteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus where statut='emprunteur' and id_individu not in(select id_individu from suspensions);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrEmpruntsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus where statut='emprunteur' and id_individu in(select id_individu from suspensions);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    Label12.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteurNbrPretsEffectuees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_pret) from prets;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrPretsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=5;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrRetoursEffectuees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_pret) from prets where id_pret not in(select id_pret from retours);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrRetoursAttentes.Text = reader(0)
                    reader.Close()
                    con.Close()

                ElseIf Not cbEmprunteurChoixAnnee.SelectedIndex = -1 AndAlso cbEmprunteurChoixMois.SelectedIndex = -1 Then

                ElseIf cbEmprunteurChoixAnnee.SelectedIndex = -1 AndAlso cbEmprunteurChoixMois.SelectedIndex = -1 Then

                Else

                End If

            ElseIf gbPartiePreteurs.Visible = True Then
                'PARTIE PRÊTEURS
                If cbPreteursChoixAnnee.SelectedIndex = -1 AndAlso cbPreteursChoixMois.SelectedIndex = -1 Then

                    commande.CommandText = "select count(id_individu) from individus where statut='preteur';"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus where statut='preteur' and id_individu not in(select id_individu from suspensions);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteursActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus where statut='preteur' and id_individu in(select id_individu from suspensions);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteursSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_pret) from prets;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPretsAutorisees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_retour) from retours;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrRetoursAutorisees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_pret) from prets where id_pret not in(select id_pret from retours);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrRetoursAttentesAutorisation.Text = reader(0)
                    reader.Close()
                    con.Close()

                ElseIf Not cbPreteursChoixAnnee.SelectedIndex = -1 AndAlso cbPreteursChoixMois.SelectedIndex = -1 Then

                ElseIf cbPreteursChoixAnnee.SelectedIndex = -1 AndAlso cbPreteursChoixMois.SelectedIndex = -1 Then

                Else

                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.close()
            reader.Close()
            Return
        End Try
    End Sub

End Class
