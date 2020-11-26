'Importation nécessaire
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
        refreshComboboxes()
        refreshInfos()
    End Sub

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie emprunteurs
    Private Sub bEmprunteurs_Click(sender As Object, e As EventArgs) Handles bEmprunteurs.Click
        visibleFalseEverything()
        gbPartieEmprunteurs.Visible = True
        refreshComboboxes()
        refreshInfos()
    End Sub

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie prêteurs
    Private Sub bPreteurs_Click(sender As Object, e As EventArgs) Handles bPreteurs.Click
        visibleFalseEverything()
        gbPartiePreteurs.Visible = True
        refreshComboboxes()
        refreshInfos()
    End Sub

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie administrateurs
    Private Sub bAdministrateurs_Click(sender As Object, e As EventArgs) Handles bAdministrateurs.Click
        visibleFalseEverything()
        gbPartieAdministrateur.Visible = True
        refreshComboboxes()
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

    'PARTIE CSV (EXCEL)
    Private Sub bPreteursCSV_Click(sender As Object, e As EventArgs) Handles bPreteursCSV.Click
        archivageCSV(1)
    End Sub

    Private Sub bEmprunteursCSV_Click(sender As Object, e As EventArgs) Handles bEmprunteursCSV.Click
        archivageCSV(2)
    End Sub

    Private Sub bAdminsCSV_Click(sender As Object, e As EventArgs) Handles bAdminsCSV.Click
        archivageCSV(3)
    End Sub

    Private Sub bGlobaleCSV_Click(sender As Object, e As EventArgs) Handles bGlobaleCSV.Click
        archivageCSV(4)
    End Sub

    Private Sub archivageCSV(typeInfo As Integer)
        Dim sfd As New SaveFileDialog

        sfd.Filter = "CSV|*.csv"
        sfd.DefaultExt = "csv"
        sfd.ShowDialog()

        If String.IsNullOrWhiteSpace(sfd.FileName) Then
            Return
        End If

        Dim sw As New StreamWriter(sfd.FileName)

        Select Case typeInfo
            Case 1
                'Partie Prêteurs
                sw.WriteLine("Résumé des statistiques des prêteurs")
                sw.WriteLine("")
                sw.WriteLine("Nombre de prêteurs;" & lPreteursNbrPreteurs.Text)
                sw.WriteLine("Nombre de prêteurs actifs;" & lPreteursNbrPreteursActifs.Text)
                sw.WriteLine("Nombre de prêteurs suspendues;" & lPreteursNbrPreteursSuspendues.Text)
                sw.WriteLine("Nombre de prêts autorisés;" & lPreteursNbrPretsAutorisees.Text)
                sw.WriteLine("Nombre de retours autorisés;" & lPreteursNbrRetoursAutorisees.Text)
                sw.WriteLine("Nombre de retours en attente d'autorisations;" & lPreteursNbrRetoursAttentesAutorisation.Text)

            Case 2
                'Partie Emprunteurs
                sw.WriteLine("Résumé des statistiques des emprunteurs")
                sw.WriteLine("")
                sw.WriteLine("Nombre d'emprunteurs : " & lEmprunteursNbrEmprunteurs.Text)
                sw.WriteLine("Nombre d'emprunteurs actifs : " & lEmprunteursNbrEmpruntsActifs.Text)
                sw.WriteLine("Nombre d'emprunteurs suspendues : " & lEmprunteurNbrEmprunteursSuspendues.Text)
                sw.WriteLine("Nombre de prêts effectuées : " & lEmprunteurNbrPretsEffectuees.Text)
                sw.WriteLine("Nombre de prêts actifs : " & lEmprunteursNbrPretsActifs.Text)
                sw.WriteLine("Nombre de retours effectuées : " & lEmprunteursNbrRetoursEffectuees.Text)

            Case 3
                'Partie Admins
                sw.WriteLine("Résumé des statistiques des administrateurs")
                sw.WriteLine("")
                sw.WriteLine("Nombre d'admins :" & lAdminsNombreAdmins.Text)
                sw.WriteLine("Nombre d'admins actifs :" & lAdminsNbrAdminsActifs.Text)
                sw.WriteLine("Nombre d'admins suspendues :" & lAdminsNbrAdminsSuspendues.Text)

            Case 4
                'Partie Globale
                sw.WriteLine("Résumé des statistiques de la globalité du logiciel")
                sw.WriteLine("")
                sw.WriteLine("Nombre d'ouvertures de l'application :" & lNbrOuverturesApplis.Text)
                sw.WriteLine("Nombre de prêts enregistré :" & lNbrPrets.Text)
                sw.WriteLine("Nombre de retours effectuées :" & lNbrRetours.Text)
                sw.WriteLine("Nombre de personnes inscrites dans la base de données :" & lNbrPersonneBD.Text)
                sw.WriteLine("Nombre d'emprunteurs inscrit :" & lNbrEmprunteurs.Text)
                sw.WriteLine("Nombre de prêteurs inscrit :" & lNbrPreteurs.Text)
                sw.WriteLine("Nombre d'administrateurs inscrit :" & lNbrAdministratifs.Text)
                sw.WriteLine("Nombre d'équipements inscrit :" & lNbrEquipements.Text)
                sw.WriteLine("Nombre de conditions inscrites :" & lNbrConditions.Text)
                sw.WriteLine("Nombre de responsabilités inscrites :" & lNbrResponsabilites.Text)
                sw.WriteLine("Nombre de frais de retards accumulées :" & lNbrFraisRetards.Text)

        End Select
        MessageBox.Show("Le fichier a été enregistré !", "Enregistrement effectué", MessageBoxButtons.OK, MessageBoxIcon.Information)
        sw.Close()
    End Sub

    'PARTIE DOCS (Word)
    Private Sub bPreteursDOC_Click(sender As Object, e As EventArgs) Handles bPreteursDOC.Click
        archivageDOC(1)
    End Sub

    Private Sub bEmprunteursDOC_Click(sender As Object, e As EventArgs) Handles bEmprunteursDOC.Click
        archivageDOC(2)
    End Sub

    Private Sub bAdminsDOC_Click(sender As Object, e As EventArgs) Handles bAdminsDOC.Click
        archivageDOC(3)
    End Sub

    Private Sub bGlobaleDOC_Click(sender As Object, e As EventArgs) Handles bGlobaleDOC.Click
        archivageDOC(4)
    End Sub

    Private Sub archivageDOC(typeInfo As Integer)
        Dim sfd As New SaveFileDialog

        sfd.Filter = "DOC|*.doc"
        sfd.DefaultExt = "doc"
        sfd.ShowDialog()

        If String.IsNullOrWhiteSpace(sfd.FileName) Then
            Return
        End If

        Dim sw As New StreamWriter(sfd.FileName)

        Select Case typeInfo
            Case 1
                'Partie Prêteurs
                sw.WriteLine("Résumé des statistiques des prêteurs")
                sw.WriteLine("")
                sw.WriteLine("Nombre de prêteurs;" & lPreteursNbrPreteurs.Text)
                sw.WriteLine("Nombre de prêteurs actifs;" & lPreteursNbrPreteursActifs.Text)
                sw.WriteLine("Nombre de prêteurs suspendues;" & lPreteursNbrPreteursSuspendues.Text)
                sw.WriteLine("Nombre de prêts autorisés;" & lPreteursNbrPretsAutorisees.Text)
                sw.WriteLine("Nombre de retours autorisés;" & lPreteursNbrRetoursAutorisees.Text)
                sw.WriteLine("Nombre de retours en attente d'autorisations;" & lPreteursNbrRetoursAttentesAutorisation.Text)

            Case 2
                'Partie Emprunteurs
                sw.WriteLine("Résumé des statistiques des emprunteurs")
                sw.WriteLine("")
                sw.WriteLine("Nombre d'emprunteurs : " & lEmprunteursNbrEmprunteurs.Text)
                sw.WriteLine("Nombre d'emprunteurs actifs : " & lEmprunteursNbrEmpruntsActifs.Text)
                sw.WriteLine("Nombre d'emprunteurs suspendues : " & lEmprunteurNbrEmprunteursSuspendues.Text)
                sw.WriteLine("Nombre de prêts effectuées : " & lEmprunteurNbrPretsEffectuees.Text)
                sw.WriteLine("Nombre de prêts actifs : " & lEmprunteursNbrPretsActifs.Text)
                sw.WriteLine("Nombre de retours effectuées : " & lEmprunteursNbrRetoursEffectuees.Text)

            Case 3
                'Partie Admins
                sw.WriteLine("Résumé des statistiques des administrateurs")
                sw.WriteLine("")
                sw.WriteLine("Nombre d'admins :" & lAdminsNombreAdmins.Text)
                sw.WriteLine("Nombre d'admins actifs :" & lAdminsNbrAdminsActifs.Text)
                sw.WriteLine("Nombre d'admins suspendues :" & lAdminsNbrAdminsSuspendues.Text)

            Case 4
                'Partie Globale
                sw.WriteLine("Résumé des statistiques de la globalité du logiciel")
                sw.WriteLine("")
                sw.WriteLine("Nombre d'ouvertures de l'application :" & lNbrOuverturesApplis.Text)
                sw.WriteLine("Nombre de prêts enregistré :" & lNbrPrets.Text)
                sw.WriteLine("Nombre de retours effectuées :" & lNbrRetours.Text)
                sw.WriteLine("Nombre de personnes inscrites dans la base de données :" & lNbrPersonneBD.Text)
                sw.WriteLine("Nombre d'emprunteurs inscrit :" & lNbrEmprunteurs.Text)
                sw.WriteLine("Nombre de prêteurs inscrit :" & lNbrPreteurs.Text)
                sw.WriteLine("Nombre d'administrateurs inscrit :" & lNbrAdministratifs.Text)
                sw.WriteLine("Nombre d'équipements inscrit :" & lNbrEquipements.Text)
                sw.WriteLine("Nombre de conditions inscrites :" & lNbrConditions.Text)
                sw.WriteLine("Nombre de responsabilités inscrites :" & lNbrResponsabilites.Text)
                sw.WriteLine("Nombre de frais de retards accumulées :" & lNbrFraisRetards.Text)

        End Select
        MessageBox.Show("Le fichier a été enregistré !", "Enregistrement effectué", MessageBoxButtons.OK, MessageBoxIcon.Information)
        sw.Close()
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

    Private Sub archivagePDF(typeInfo As Integer)
        Dim sfd As New SaveFileDialog

        sfd.Filter = "PDF|*.pdf"
        sfd.DefaultExt = "pdf"
        sfd.ShowDialog()

        If String.IsNullOrWhiteSpace(sfd.FileName) Then
            Return
        End If

        Dim sw As New StreamWriter(sfd.FileName)

        Select Case typeInfo
            Case 1
                'Partie Prêteurs
                sw.WriteLine("Résumé des statistiques des prêteurs")
                sw.WriteLine("")
                sw.WriteLine("Nombre de prêteurs;" & lPreteursNbrPreteurs.Text)
                sw.WriteLine("Nombre de prêteurs actifs;" & lPreteursNbrPreteursActifs.Text)
                sw.WriteLine("Nombre de prêteurs suspendues;" & lPreteursNbrPreteursSuspendues.Text)
                sw.WriteLine("Nombre de prêts autorisés;" & lPreteursNbrPretsAutorisees.Text)
                sw.WriteLine("Nombre de retours autorisés;" & lPreteursNbrRetoursAutorisees.Text)
                sw.WriteLine("Nombre de retours en attente d'autorisations;" & lPreteursNbrRetoursAttentesAutorisation.Text)

            Case 2
                'Partie Emprunteurs
                sw.WriteLine("Résumé des statistiques des emprunteurs")
                sw.WriteLine("")
                sw.WriteLine("Nombre d'emprunteurs : " & lEmprunteursNbrEmprunteurs.Text)
                sw.WriteLine("Nombre d'emprunteurs actifs : " & lEmprunteursNbrEmpruntsActifs.Text)
                sw.WriteLine("Nombre d'emprunteurs suspendues : " & lEmprunteurNbrEmprunteursSuspendues.Text)
                sw.WriteLine("Nombre de prêts effectuées : " & lEmprunteurNbrPretsEffectuees.Text)
                sw.WriteLine("Nombre de prêts actifs : " & lEmprunteursNbrPretsActifs.Text)
                sw.WriteLine("Nombre de retours effectuées : " & lEmprunteursNbrRetoursEffectuees.Text)

            Case 3
                'Partie Admins
                sw.WriteLine("Résumé des statistiques des administrateurs")
                sw.WriteLine("")
                sw.WriteLine("Nombre d'admins :" & lAdminsNombreAdmins.Text)
                sw.WriteLine("Nombre d'admins actifs :" & lAdminsNbrAdminsActifs.Text)
                sw.WriteLine("Nombre d'admins suspendues :" & lAdminsNbrAdminsSuspendues.Text)

            Case 4
                'Partie Globale
                sw.WriteLine("Résumé des statistiques de la globalité du logiciel")
                sw.WriteLine("")
                sw.WriteLine("Nombre d'ouvertures de l'application :" & lNbrOuverturesApplis.Text)
                sw.WriteLine("Nombre de prêts enregistré :" & lNbrPrets.Text)
                sw.WriteLine("Nombre de retours effectuées :" & lNbrRetours.Text)
                sw.WriteLine("Nombre de personnes inscrites dans la base de données :" & lNbrPersonneBD.Text)
                sw.WriteLine("Nombre d'emprunteurs inscrit :" & lNbrEmprunteurs.Text)
                sw.WriteLine("Nombre de prêteurs inscrit :" & lNbrPreteurs.Text)
                sw.WriteLine("Nombre d'administrateurs inscrit :" & lNbrAdministratifs.Text)
                sw.WriteLine("Nombre d'équipements inscrit :" & lNbrEquipements.Text)
                sw.WriteLine("Nombre de conditions inscrites :" & lNbrConditions.Text)
                sw.WriteLine("Nombre de responsabilités inscrites :" & lNbrResponsabilites.Text)
                sw.WriteLine("Nombre de frais de retards accumulées :" & lNbrFraisRetards.Text)

        End Select
        MessageBox.Show("Le fichier a été enregistré !", "Enregistrement effectué", MessageBoxButtons.OK, MessageBoxIcon.Information)
        sw.Close()
    End Sub

    Public Sub refreshComboboxes()
        Try
            commande.Connection = con

            cbAdminsChoixAnnee.Items.Clear()
            cbEmprunteurChoixAnnee.Items.Clear()
            cbGlobaleChoixAnnee.Items.Clear()
            cbPreteursChoixAnnee.Items.Clear()

            cbAdminsChoixMois.Items.Clear()
            cbEmprunteurChoixMois.Items.Clear()
            cbGlobaleChoixMois.Items.Clear()
            cbPreteursChoixMois.Items.Clear()

            commande.CommandText = "select distinct month(date_activite) from journal_activites;"
            con.Open()
            reader = commande.ExecuteReader
            While (reader.Read)
                cbAdminsChoixMois.Items.Add(translateMoisString(reader(0)))
                cbEmprunteurChoixMois.Items.Add(translateMoisString(reader(0)))
                cbGlobaleChoixMois.Items.Add(translateMoisString(reader(0)))
                cbPreteursChoixMois.Items.Add(translateMoisString(reader(0)))
            End While
            reader.Close()
            con.Close()

            commande.CommandText = "select distinct year(date_activite) from journal_activites;"
            con.Open()
            reader = commande.ExecuteReader
            While (reader.Read)
                cbAdminsChoixAnnee.Items.Add(reader(0))
                cbEmprunteurChoixAnnee.Items.Add(reader(0))
                cbGlobaleChoixAnnee.Items.Add(reader(0))
                cbPreteursChoixAnnee.Items.Add(reader(0))
            End While
            reader.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try
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

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPrets.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=5;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrRetours.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action in(17,22,27);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPersonneBD.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=17;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrEmprunteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPreteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrAdministratifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=8;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrEquipements.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=11;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrConditions.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=14;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrResponsabilites.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select sum(montant_activite) from journal_activites where code_action=32;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrFraisRetards.Text = reader(0) & "$"
                    reader.Close()
                    con.Close()

                ElseIf Not cbGlobaleChoixAnnee.SelectedIndex = -1 AndAlso cbGlobaleChoixMois.SelectedIndex = -1 Then
                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=1 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader()
                    reader.Read()
                    lNbrOuverturesApplis.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPrets.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=5 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrRetours.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action in(17,22,27) and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPersonneBD.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=17 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrEmprunteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPreteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrAdministratifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=8 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrEquipements.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=11 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrConditions.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=14 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrResponsabilites.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select sum(montant_activite) from journal_activites where code_action=32 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrFraisRetards.Text = reader(0) & "$"
                    reader.Close()
                    con.Close()
                ElseIf cbGlobaleChoixAnnee.SelectedIndex = -1 AndAlso Not cbGlobaleChoixMois.SelectedIndex = -1 Then
                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=1 and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader()
                    reader.Read()
                    lNbrOuverturesApplis.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPrets.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=5 and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrRetours.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action in(17,22,27) and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPersonneBD.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=17 and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrEmprunteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPreteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27 and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrAdministratifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=8 and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrEquipements.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=11 and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrConditions.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=14 and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrResponsabilites.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select sum(montant_activite) from journal_activites where code_action=32 and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrFraisRetards.Text = reader(0) & "$"
                    reader.Close()
                    con.Close()
                Else
                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=1 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & " and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader()
                    reader.Read()
                    lNbrOuverturesApplis.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & " and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPrets.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=5 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & " and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrRetours.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action in(17,22,27) and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & " and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPersonneBD.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=17 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & " and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrEmprunteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & " and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrPreteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & " and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrAdministratifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=8 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & " and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrEquipements.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=11 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & " and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrConditions.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=14 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & " and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrResponsabilites.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select sum(montant_activite) from journal_activites where code_action=32 and year(date_activite)=" & translateMoisNombre(cbGlobaleChoixAnnee.SelectedItem) & " and mois(date_activite)=" & translateMoisNombre(cbGlobaleChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lNbrFraisRetards.Text = reader(0) & "$"
                    reader.Close()
                    con.Close()
                End If


            ElseIf gbPartieAdministrateur.Visible = True Then
                'PARTIE ADMINISTRATEURS
                If cbAdminsChoixAnnee.SelectedIndex = -1 AndAlso cbAdminsChoixMois.SelectedIndex = -1 Then
                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNombreAdmins.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27 and id_individu_1 not in(select id_individu_1 from journal_activites where code_action=30)"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNbrAdminsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27 and id_individu_1 in(select id_individu_1 from journal_activites where code_action=30);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNbrAdminsSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()
                ElseIf Not cbAdminsChoixAnnee.SelectedIndex = -1 AndAlso cbAdminsChoixMois.SelectedIndex = -1 Then
                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27 and year(date_activite)=" & translateMoisNombre(cbAdminsChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNombreAdmins.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27 and id_individu_1 not in(select id_individu_1 from journal_activites where code_action=30) and year(date_activite)=" & translateMoisNombre(cbAdminsChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNbrAdminsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27 and id_individu_1 in(select id_individu_1 from journal_activites where code_action=30) and year(date_activite)=" & translateMoisNombre(cbAdminsChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNbrAdminsSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()
                ElseIf cbAdminsChoixAnnee.SelectedIndex = -1 AndAlso Not cbAdminsChoixMois.SelectedIndex = -1 Then
                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNombreAdmins.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27 and id_individu_1 not in(select id_individu_1 from journal_activites where code_action=30) and month(date_activite)=" & translateMoisNombre(cbAdminsChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNbrAdminsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27 and id_individu_1 in(select id_individu_1 from journal_activites where code_action=30) and month(date_activite)=" & translateMoisNombre(cbAdminsChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNbrAdminsSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()
                Else
                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27 and year(date_activite)=" & translateMoisNombre(cbAdminsChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbAdminsChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNombreAdmins.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27 and id_individu_1 not in(select id_individu_1 from journal_activites where code_action=30) and year(date_activite)=" & translateMoisNombre(cbAdminsChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbAdminsChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNbrAdminsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=27 and id_individu_1 in(select id_individu_1 from journal_activites where code_action=30) and year(date_activite)=" & translateMoisNombre(cbAdminsChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbAdminsChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lAdminsNbrAdminsSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()
                End If

            ElseIf gbPartieEmprunteurs.Visible = True Then
                'PARTIE EMPRUNTEURS
                If cbEmprunteurChoixAnnee.SelectedIndex = -1 AndAlso cbEmprunteurChoixMois.SelectedIndex = -1 Then

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=17;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrEmprunteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=17 and id_individu_1 not in(select id_individu_1 from journal_activites where code_action=21);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrEmpruntsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus where statut='emprunteur' and id_individu in(select id_individu_1 from journal_activites where code_action=21);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteurNbrEmprunteursSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteurNbrPretsEffectuees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and id_activite not in(select id_individu_1 from journal_activites where code_action=21);"
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

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and id_activite not in(select id_activite from journal_activites where code_action=5);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    reader.Close()
                    con.Close()

                ElseIf Not cbEmprunteurChoixAnnee.SelectedIndex = -1 AndAlso cbEmprunteurChoixMois.SelectedIndex = -1 Then
                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=17 and year(date_activite)=" & translateMoisNombre(cbEmprunteurChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrEmprunteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=17 and id_individu_1 not in(select id_individu_1 from journal_activites where code_action=21) and year(date_activite)=" & translateMoisNombre(cbEmprunteurChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrEmpruntsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus where statut='emprunteur' and id_individu in(select id_individu_1 from journal_activites where code_action=21) and year(date_activite)=" & translateMoisNombre(cbEmprunteurChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteurNbrEmprunteursSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and year(date_activite)=" & translateMoisNombre(cbEmprunteurChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteurNbrPretsEffectuees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and id_activite not in(select id_individu_1 from journal_activites where code_action=21) and year(date_activite)=" & translateMoisNombre(cbEmprunteurChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrPretsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=5 and year(date_activite)=" & translateMoisNombre(cbEmprunteurChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrRetoursEffectuees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and id_activite not in(select id_activite from journal_activites where code_action=5) and year(date_activite)=" & translateMoisNombre(cbEmprunteurChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    reader.Close()
                    con.Close()
                ElseIf cbEmprunteurChoixAnnee.SelectedIndex = -1 AndAlso Not cbEmprunteurChoixMois.SelectedIndex = -1 Then
                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=17 and month(date_activite)=" & translateMoisNombre(cbEmprunteurChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrEmprunteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=17 and id_individu_1 not in(select id_individu_1 from journal_activites where code_action=21) and month(date_activite)=" & translateMoisNombre(cbEmprunteurChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrEmpruntsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus where statut='emprunteur' and id_individu in(select id_individu_1 from journal_activites where code_action=21) and month(date_activite)=" & translateMoisNombre(cbEmprunteurChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteurNbrEmprunteursSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and month(date_activite)=" & translateMoisNombre(cbEmprunteurChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteurNbrPretsEffectuees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and id_activite not in(select id_individu_1 from journal_activites where code_action=21) and month(date_activite)=" & translateMoisNombre(cbEmprunteurChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrPretsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=5 and month(date_activite)=" & translateMoisNombre(cbEmprunteurChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrRetoursEffectuees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and id_activite not in(select id_activite from journal_activites where code_action=5) and month(date_activite)=" & translateMoisNombre(cbEmprunteurChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    reader.Close()
                    con.Close()
                Else
                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=17;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrEmprunteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=17 and id_individu_1 not in(select id_individu_1 from journal_activites where code_action=21) and year(date_activite)=" & translateMoisNombre(cbEmprunteurChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbEmprunteurChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrEmpruntsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_individu) from individus where statut='emprunteur' and id_individu in(select id_individu_1 from journal_activites where code_action=21) and year(date_activite)=" & translateMoisNombre(cbEmprunteurChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbEmprunteurChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteurNbrEmprunteursSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and year(date_activite)=" & translateMoisNombre(cbEmprunteurChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbEmprunteurChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteurNbrPretsEffectuees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and id_activite not in(select id_individu_1 from journal_activites where code_action=21) and year(date_activite)=" & translateMoisNombre(cbEmprunteurChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbEmprunteurChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrPretsActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=5 and year(date_activite)=" & translateMoisNombre(cbEmprunteurChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbEmprunteurChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrRetoursEffectuees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and id_activite not in(select id_activite from journal_activites where code_action=5) and year(date_activite)=" & translateMoisNombre(cbEmprunteurChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbEmprunteurChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    reader.Close()
                    con.Close()
                End If

            ElseIf gbPartiePreteurs.Visible = True Then
                'PARTIE PRÊTEURS
                If cbPreteursChoixAnnee.SelectedIndex = -1 AndAlso cbPreteursChoixMois.SelectedIndex = -1 Then

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22;"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and id_individu_1 not in(select id_activite from journal_activites where code_action=25);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteursActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and id_individu_1 in(select count(id_activite) from journal_activites where code_action=26);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteursSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=33"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPretsAutorisees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=34"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrRetoursAutorisees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and id_activite not in(select count(id_activite) from journal_activites where code_action=5);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrRetoursAttentesAutorisation.Text = reader(0)
                    reader.Close()
                    con.Close()

                ElseIf Not cbPreteursChoixAnnee.SelectedIndex = -1 AndAlso cbPreteursChoixMois.SelectedIndex = -1 Then
                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and year(date_activite)=" & translateMoisNombre(cbPreteursChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and id_individu_1 not in(select id_activite from journal_activites where code_action=25) and year(date_activite)=" & translateMoisNombre(cbPreteursChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteursActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and id_individu_1 in(select count(id_activite) from journal_activites where code_action=26) and year(date_activite)=" & translateMoisNombre(cbPreteursChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteursSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=33 and year(date_activite)=" & translateMoisNombre(cbPreteursChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPretsAutorisees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=34 and year(date_activite)=" & translateMoisNombre(cbPreteursChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrRetoursAutorisees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and id_activite not in(select count(id_activite) from journal_activites where code_action=5) and year(date_activite)=" & translateMoisNombre(cbPreteursChoixAnnee.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrRetoursAttentesAutorisation.Text = reader(0)
                    reader.Close()
                    con.Close()
                ElseIf cbPreteursChoixAnnee.SelectedIndex = -1 AndAlso Not cbPreteursChoixMois.SelectedIndex = -1 Then
                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and month(date_activite)=" & translateMoisNombre(cbPreteursChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and id_individu_1 not in(select id_activite from journal_activites where code_action=25) and month(date_activite)=" & translateMoisNombre(cbPreteursChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteursActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and id_individu_1 in(select count(id_activite) from journal_activites where code_action=26) and month(date_activite)=" & translateMoisNombre(cbPreteursChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteursSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=33 and month(date_activite)=" & translateMoisNombre(cbPreteursChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPretsAutorisees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=34 and month(date_activite)=" & translateMoisNombre(cbPreteursChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrRetoursAutorisees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and id_activite not in(select count(id_activite) from journal_activites where code_action=5) and month(date_activite)=" & translateMoisNombre(cbPreteursChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrRetoursAttentesAutorisation.Text = reader(0)
                    reader.Close()
                    con.Close()
                Else
                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and year(date_activite)=" & translateMoisNombre(cbPreteursChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbPreteursChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteurs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and id_individu_1 not in(select id_activite from journal_activites where code_action=25) and year(date_activite)=" & translateMoisNombre(cbPreteursChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbPreteursChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteursActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and id_individu_1 in(select count(id_activite) from journal_activites where code_action=26) and year(date_activite)=" & translateMoisNombre(cbPreteursChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbPreteursChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteursSuspendues.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=33 and year(date_activite)=" & translateMoisNombre(cbPreteursChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbPreteursChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPretsAutorisees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=34 and year(date_activite)=" & translateMoisNombre(cbPreteursChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbPreteursChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrRetoursAutorisees.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 and id_activite not in(select count(id_activite) from journal_activites where code_action=5) and year(date_activite)=" & translateMoisNombre(cbPreteursChoixAnnee.SelectedItem) & " and month(date_activite)=" & translateMoisNombre(cbPreteursChoixMois.SelectedItem) & ";"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrRetoursAttentesAutorisation.Text = reader(0)
                    reader.Close()
                    con.Close()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.close()
            reader.Close()
            Return
        End Try
    End Sub

    Private Sub cbPreteursChoixMois_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPreteursChoixMois.SelectedIndexChanged
        If Not cbPreteursChoixMois.SelectedIndex = -1 Then
            refreshInfos()
        End If
    End Sub

    Private Sub cbPreteursChoixAnnee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPreteursChoixAnnee.SelectedIndexChanged
        If Not cbPreteursChoixAnnee.SelectedIndex = -1 Then
            refreshInfos()
        End If
    End Sub

    Private Sub cbEmprunteurChoixMois_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmprunteurChoixMois.SelectedIndexChanged
        If Not cbEmprunteurChoixMois.SelectedIndex = -1 Then
            refreshInfos()
        End If
    End Sub

    Private Sub cbEmprunteurChoixAnnee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmprunteurChoixAnnee.SelectedIndexChanged
        If Not cbEmprunteurChoixAnnee.SelectedIndex = -1 Then
            refreshInfos()
        End If
    End Sub

    Private Sub cbGlobaleChoixMois_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGlobaleChoixMois.SelectedIndexChanged
        If Not cbGlobaleChoixMois.SelectedIndex = -1 Then
            refreshInfos()
        End If
    End Sub

    Private Sub cbGlobaleChoixAnnee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGlobaleChoixAnnee.SelectedIndexChanged
        If Not cbGlobaleChoixAnnee.SelectedIndex = -1 Then
            refreshInfos()
        End If
    End Sub

    Private Sub cbAdminsChoixMois_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdminsChoixMois.SelectedIndexChanged
        If Not cbAdminsChoixMois.SelectedIndex = -1 Then
            refreshInfos()
        End If
    End Sub

    Private Sub cbAdminsChoixAnnee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdminsChoixAnnee.SelectedIndexChanged
        If Not cbAdminsChoixAnnee.SelectedIndex = -1 Then
            refreshInfos()
        End If
    End Sub

    Function translateMoisString(mois As Integer) As String
        Select Case mois
            Case "1"
                Return "Janvier"
            Case "2"
                Return "Février"
            Case "3"
                Return "Mars"
            Case "4"
                Return "Avril"
            Case "5"
                Return "Mai"
            Case "6"
                Return "Juin"
            Case "7"
                Return "Juillet"
            Case "8"
                Return "Août"
            Case "9"
                Return "Septembre"
            Case "10"
                Return "Octobre"
            Case "11"
                Return "Novembre"
            Case "12"
                Return "Décembre"
            Case Else
                Return "rien"
        End Select
    End Function

    Function translateMoisNombre(mois As String) As Integer
        Select Case mois
            Case "Janvier"
                Return 1
            Case "Février"
                Return 2
            Case "Mars"
                Return 3
            Case "Avril"
                Return 4
            Case "Mai"
                Return 5
            Case "Juin"
                Return 6
            Case "Juillet"
                Return 7
            Case "Août"
                Return 8
            Case "Septembre"
                Return 9
            Case "Octobre"
                Return 10
            Case "Novembre"
                Return 11
            Case "Décembre"
                Return 12
            Case Else
                Return "666"
        End Select
    End Function
End Class
