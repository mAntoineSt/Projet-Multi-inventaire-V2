Imports System.IO
Public Class Statistiques
    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie globale
    Private Sub bPartieGlobale_Click(sender As Object, e As EventArgs) Handles bPartieGlobale.Click
        visibleFalseEverything()
        gbGlobale.Visible = True
    End Sub

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie emprunteurs
    Private Sub bEmprunteurs_Click(sender As Object, e As EventArgs) Handles bEmprunteurs.Click
        visibleFalseEverything()
        gbPartieEmprunteurs.Visible = True
    End Sub

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie prêteurs
    Private Sub bPreteurs_Click(sender As Object, e As EventArgs) Handles bPreteurs.Click
        visibleFalseEverything()
        gbPartiePreteurs.Visible = True
    End Sub

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie administrateurs
    Private Sub bAdministrateurs_Click(sender As Object, e As EventArgs) Handles bAdministrateurs.Click
        visibleFalseEverything()
        gbPartieAdministrateur.Visible = True
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
End Class
