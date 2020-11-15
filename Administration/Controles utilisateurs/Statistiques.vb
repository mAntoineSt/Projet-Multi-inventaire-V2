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
                cbAdminsChoixMois.Items.Add(reader(0))
                cbEmprunteurChoixMois.Items.Add(reader(0))
                cbGlobaleChoixMois.Items.Add(reader(0))
                cbPreteursChoixMois.Items.Add(reader(0))
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

                ElseIf cbGlobaleChoixAnnee.SelectedIndex = -1 AndAlso Not cbGlobaleChoixMois.SelectedIndex = -1 Then

                Else

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

                ElseIf cbAdminsChoixAnnee.SelectedIndex = -1 AndAlso Not cbAdminsChoixMois.SelectedIndex = -1 Then

                Else

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

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 where not in(select id_individu_1 from journal_activites where code_action=21);"
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

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 where id_activite not in(select id_activite from journal activites where code_activite=5);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lEmprunteursNbrRetoursAttentes.Text = reader(0)
                    reader.Close()
                    con.Close()

                ElseIf Not cbEmprunteurChoixAnnee.SelectedIndex = -1 AndAlso cbEmprunteurChoixMois.SelectedIndex = -1 Then

                ElseIf cbEmprunteurChoixAnnee.SelectedIndex = -1 AndAlso Not cbEmprunteurChoixMois.SelectedIndex = -1 Then

                Else

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

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and id_individu not in(select id_activite from journal_activites where code_action=25);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrPreteursActifs.Text = reader(0)
                    reader.Close()
                    con.Close()

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=22 and id_individu in(select count(id_activite) from journal_activites where code_action=26);"
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

                    commande.CommandText = "select count(id_activite) from journal_activites where code_action=2 where id_pret not in(select count(id_activite) from journal_activites where code_action=5);"
                    con.Open()
                    reader = commande.ExecuteReader
                    reader.Read()
                    lPreteursNbrRetoursAttentesAutorisation.Text = reader(0)
                    reader.Close()
                    con.Close()

                ElseIf Not cbPreteursChoixAnnee.SelectedIndex = -1 AndAlso cbPreteursChoixMois.SelectedIndex = -1 Then

                ElseIf cbPreteursChoixAnnee.SelectedIndex = -1 AndAlso Not cbPreteursChoixMois.SelectedIndex = -1 Then

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
End Class
