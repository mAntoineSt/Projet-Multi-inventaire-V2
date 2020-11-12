'Importation nécessaire
Imports MySql.Data.MySqlClient

Public Class Ajout_Modif_Admin
    'Variables nécessaires
    Dim styleVisuel As Integer = 0
    Dim langue As Integer = 0
    Dim emplacement As Point
    Dim pressetMatricule,
        pressetMdp,
        pressetConfirmationMdp,
        pressetNom,
        pressetPrenom,
        pressetDepServProg,
        pressetNumBureau,
        pressetTelephoneBureau,
        pressetPosteTelephonique,
        pressetCellulaire,
        pressetCourriel As String
    Dim con As MySqlConnection = New MySqlConnection("Server=localhost;Database=projet_multi;Uid=root;Pwd='';Port=3308;")
    Dim reader As MySqlDataReader
    Dim commande As New MySqlCommand


    'PARTIE FORM------------------------------------------------------------------------------------------
    Private Sub Ajout_Modif_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Change le thème visuel de la form selon celle choisie.
        If styleVisuel = 0 Then
            pHaut.BackColor = ColorTranslator.FromHtml("#4b6584")
            pBas.BackColor = ColorTranslator.FromHtml("#4b6584")
            Me.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            bConfirmer.ForeColor = Color.White
            bConfirmer.BackColor = ColorTranslator.FromHtml("#4d73a1")
        Else
            pHaut.BackColor = ColorTranslator.FromHtml("#252926")
            pBas.BackColor = ColorTranslator.FromHtml("#252926")
            Me.BackColor = ColorTranslator.FromHtml("#3c403d")
            bConfirmer.ForeColor = Color.White
            bConfirmer.BackColor = ColorTranslator.FromHtml("#747d8c")
        End If

        'Change la langue selon celle choisie
        If langue = 0 Then
            bConfirmer.Text = "CONFIRMER"
            pressetMatricule = "Utilisateur"
            pressetMdp = "Mot de passe"
            pressetConfirmationMdp = "Confirmation du mot de passe"
            pressetNom = "Nom"
            pressetPrenom = "Prénom"
            pressetDepServProg = "Département/Service/Programme"
            pressetNumBureau = "Numéro de bureau (optionnel)"
            pressetTelephoneBureau = "Téléphone de bureau (optionnel)"
            pressetPosteTelephonique = "Poste téléphonique (Optionnel)"
            pressetCellulaire = "Cellulaire (Optionnel)"
            pressetCourriel = "Courriel (Optionnel)"
        Else
            bConfirmer.Text = "CONFIRM"
            pressetMatricule = "User"
            pressetMdp = "Password"
            pressetConfirmationMdp = "Password confirmation"
            pressetNom = "Last name"
            pressetPrenom = "First name"
            pressetDepServProg = "Department/Service/Program"
            pressetNumBureau = "Office number (Optional)"
            pressetTelephoneBureau = "Office phone (Optional)"
            pressetPosteTelephonique = "Telephone set (Optional)"
            pressetCellulaire = "Cellular (Optional)"
            pressetCourriel = "Email (Optional)"
        End If

        tbMatricule.Text = pressetMatricule
        tbMdp.Text = pressetMdp
        tbConfirmationMdp.Text = pressetConfirmationMdp
        tbNom.Text = pressetNom
        tbPrenom.Text = pressetPrenom
        tbDepartementService.Text = pressetDepServProg
        tbNumeroBureau.Text = pressetNumBureau
        tbTelephoneBureau.Text = pressetTelephoneBureau
        tbPosteTelephonique.Text = pressetPosteTelephonique
        tbCellulaire.Text = pressetCellulaire
        tbCourriel.Text = pressetCourriel
    End Sub

    'PARTIE DES TEXTBOXS----------------------------------------------------------------------------------

    'LES ENTER----------------------------------------
    Private Sub tbMatricule_Enter(sender As Object, e As EventArgs) Handles tbMatricule.Enter
        If tbMatricule.Text = pressetMatricule And tbMatricule.ForeColor = Color.LightGray Then
            tbMatricule.ResetText()
            tbMatricule.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbMdp_Enter(sender As Object, e As EventArgs) Handles tbMdp.Enter
        If tbMdp.Text = pressetMdp And tbMdp.ForeColor = Color.LightGray Then
            tbMdp.ResetText()
            tbMdp.ForeColor = Color.Black
            tbMdp.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub tbConfirmationMdp_Enter(sender As Object, e As EventArgs) Handles tbConfirmationMdp.Enter
        If tbConfirmationMdp.Text = pressetConfirmationMdp And tbConfirmationMdp.ForeColor = Color.LightGray Then
            tbConfirmationMdp.ResetText()
            tbConfirmationMdp.ForeColor = Color.Black
            tbConfirmationMdp.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub tbNom_Enter(sender As Object, e As EventArgs) Handles tbNom.Enter
        If tbNom.Text = pressetNom And tbNom.ForeColor = Color.LightGray Then
            tbNom.ResetText()
            tbNom.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbPrenom_Enter(sender As Object, e As EventArgs) Handles tbPrenom.Enter
        If tbPrenom.Text = pressetPrenom And tbPrenom.ForeColor = Color.LightGray Then
            tbPrenom.ResetText()
            tbPrenom.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbDepartementService_Enter(sender As Object, e As EventArgs) Handles tbDepartementService.Enter
        If tbDepartementService.Text = pressetDepServProg And tbDepartementService.ForeColor = Color.LightGray Then
            tbDepartementService.ResetText()
            tbDepartementService.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbNumeroBureau_Enter(sender As Object, e As EventArgs) Handles tbNumeroBureau.Enter
        If tbNumeroBureau.Text = pressetNumBureau And tbNumeroBureau.ForeColor = Color.LightGray Then
            tbNumeroBureau.ResetText()
            tbNumeroBureau.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbTelephoneBureau_Enter(sender As Object, e As EventArgs) Handles tbTelephoneBureau.Enter
        If tbTelephoneBureau.Text = pressetTelephoneBureau And tbTelephoneBureau.ForeColor = Color.LightGray Then
            tbTelephoneBureau.ResetText()
            tbTelephoneBureau.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbPosteTelephonique_Enter(sender As Object, e As EventArgs) Handles tbPosteTelephonique.Enter
        If tbPosteTelephonique.Text = pressetPosteTelephonique And tbPosteTelephonique.ForeColor = Color.LightGray Then
            tbPosteTelephonique.ResetText()
            tbPosteTelephonique.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbCellulaire_Enter(sender As Object, e As EventArgs) Handles tbCellulaire.Enter
        If tbCellulaire.Text = pressetCellulaire And tbCellulaire.ForeColor = Color.LightGray Then
            tbCellulaire.ResetText()
            tbCellulaire.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbCourriel_Enter(sender As Object, e As EventArgs) Handles tbCourriel.Enter
        If tbCourriel.Text = pressetCourriel And tbCourriel.ForeColor = Color.LightGray Then
            tbCourriel.ResetText()
            tbCourriel.ForeColor = Color.Black
        End If
    End Sub


    'LES LEAVE----------------------------------------
    Private Sub tbMatricule_Leave(sender As Object, e As EventArgs) Handles tbMatricule.Leave
        If String.IsNullOrWhiteSpace(tbMatricule.Text) Then
            tbMatricule.Text = pressetMatricule
            tbMatricule.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbMdp_Leave(sender As Object, e As EventArgs) Handles tbMdp.Leave
        If String.IsNullOrWhiteSpace(tbMdp.Text) Then
            tbMdp.Text = pressetMdp
            tbMdp.ForeColor = Color.LightGray
            tbMdp.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub tbConfirmationMdp_Leave(sender As Object, e As EventArgs) Handles tbConfirmationMdp.Leave
        If String.IsNullOrWhiteSpace(tbConfirmationMdp.Text) Then
            tbConfirmationMdp.Text = pressetConfirmationMdp
            tbConfirmationMdp.ForeColor = Color.LightGray
            tbConfirmationMdp.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub tbNom_Leave(sender As Object, e As EventArgs) Handles tbNom.Leave
        If String.IsNullOrWhiteSpace(tbNom.Text) Then
            tbNom.Text = pressetNom
            tbNom.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbPrenom_Leave(sender As Object, e As EventArgs) Handles tbPrenom.Leave
        If String.IsNullOrWhiteSpace(tbPrenom.Text) Then
            tbPrenom.Text = pressetPrenom
            tbPrenom.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbDepartementService_Leave(sender As Object, e As EventArgs) Handles tbDepartementService.Leave
        If String.IsNullOrWhiteSpace(tbDepartementService.Text) Then
            tbDepartementService.Text = pressetDepServProg
            tbDepartementService.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbNumeroBureau_Leave(sender As Object, e As EventArgs) Handles tbNumeroBureau.Leave
        If String.IsNullOrWhiteSpace(tbNumeroBureau.Text) Then
            tbNumeroBureau.Text = pressetNumBureau
            tbNumeroBureau.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbTelephoneBureau_Leave(sender As Object, e As EventArgs) Handles tbTelephoneBureau.Leave
        If String.IsNullOrWhiteSpace(tbTelephoneBureau.Text) Then
            tbTelephoneBureau.Text = pressetTelephoneBureau
            tbTelephoneBureau.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbPosteTelephonique_Leave(sender As Object, e As EventArgs) Handles tbPosteTelephonique.Leave
        If String.IsNullOrWhiteSpace(tbPosteTelephonique.Text) Then
            tbPosteTelephonique.Text = pressetPosteTelephonique
            tbPosteTelephonique.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbCellulaire_Leave(sender As Object, e As EventArgs) Handles tbCellulaire.Leave
        If String.IsNullOrWhiteSpace(tbCellulaire.Text) Then
            tbCellulaire.Text = pressetCellulaire
            tbCellulaire.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub tbCourriel_Leave(sender As Object, e As EventArgs) Handles tbCourriel.Leave
        If String.IsNullOrWhiteSpace(tbCourriel.Text) Then
            tbCourriel.Text = pressetCourriel
            tbCourriel.ForeColor = Color.LightGray
        End If
    End Sub

    'PARTIE DES LABELS-------------------------------------------------------------------------------------------

    'Permet de fermer cette fenêtre
    Private Sub lQuitter_Click(sender As Object, e As EventArgs) Handles lQuitter.Click
        Me.Close()
    End Sub

    'PARTIE DES BOUTONS------------------------------------------------------------------------------------------

    'Sert à confirmer le tout
    Private Sub bConfirmer_Click(sender As Object, e As EventArgs) Handles bConfirmer.Click
        Dim testInt As Integer

        'Vérifications

        'Vérifie si tous les champs obligatoires ont été remplies
        If tbMatricule.ForeColor = Color.LightGray OrElse tbMdp.ForeColor = Color.LightGray OrElse tbConfirmationMdp.ForeColor = Color.LightGray OrElse tbNom.ForeColor = Color.LightGray OrElse tbPrenom.ForeColor = Color.LightGray OrElse tbDepartementService.ForeColor = Color.LightGray Then
            MessageBox.Show("Vous n'avez pas remplie tous les champs obligatoires", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Vérifie si le matricule est au bon format

        If Not tbMatricule.Text.Length = 7 OrElse Not Integer.TryParse(tbMatricule.Text, testInt) Then
            MessageBox.Show("Vous n'avez pas entré le bon format de matricule (nombre de 7 chiffres)", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Vérifie si le mot de passe et le mot de passe de confirmation sont les mêmes
        If Not tbMdp.Text = tbConfirmationMdp.Text Then
            MessageBox.Show("Vous avez écrit 2 mots de passe différents.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Vérifie s'il y a un chiffre dans le nom
        For index As Integer = 0 To (tbNom.Text.Length - 1)
            If Integer.TryParse(tbNom.Text.Substring(index, 1), testInt) Then
                MessageBox.Show("Vous ne pouvz pas mettre de numéros dans un nom.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        'Vérifie s'il y a un chiffre dans le prénom
        For index As Integer = 0 To (tbPrenom.Text.Length - 1)
            If Integer.TryParse(tbPrenom.Text.Substring(index, 1), testInt) Then
                MessageBox.Show("Vous ne pouvz pas mettre de numéros dans un prénom.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        'Vérifie si le numéro de bureau est entièrement numérique
        If Not tbNumeroBureau.ForeColor = Color.LightGray AndAlso Not Integer.TryParse(tbNumeroBureau.Text, testInt) Then
            MessageBox.Show("Vous ne devez entrer que des numéros pour le numéro de bureau", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Vérifie si le numéro de téléphone de bureau est correct
        If Not tbTelephoneBureau.ForeColor = Color.LightGray Then
            Select Case tbTelephoneBureau.Text.Length
                Case 14
                    If Not tbTelephoneBureau.Text.Substring(0, 1) = "(" OrElse Not Integer.TryParse(tbTelephoneBureau.Text.Substring(1, 3), testInt) OrElse Not tbTelephoneBureau.Text.Substring(4, 2) = ")-" OrElse Not Integer.TryParse(tbTelephoneBureau.Text.Substring(6, 3), testInt) OrElse Not tbTelephoneBureau.Text.Substring(9, 1) = "-" OrElse Not Integer.TryParse(tbTelephoneBureau.Text.Substring(10, 4), testInt) Then
                        MessageBox.Show("Vous n'avez pas entré le bon format de téléphone de bureau", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                Case 12
                    If Not Integer.TryParse(tbTelephoneBureau.Text.Substring(0, 3), testInt) OrElse Not tbTelephoneBureau.Text.Substring(3, 1) = "-" OrElse Not Integer.TryParse(tbTelephoneBureau.Text.Substring(4, 3), testInt) OrElse Not tbTelephoneBureau.Text.Substring(7, 1) = "-" OrElse Integer.TryParse(tbTelephoneBureau.Text.Substring(8, 4), testInt) Then
                        MessageBox.Show("Vous n'avez pas entré le bon format de téléphone de bureau", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                Case 10
                    If Not Integer.TryParse(tbTelephoneBureau.Text.Substring(0, 10), testInt) Then
                        MessageBox.Show("Vous n'avez pas entré le bon format de téléphone de bureau", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                Case Else
                    MessageBox.Show("Vous n'avez pas entré le bon format de téléphone de bureau", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
            End Select
        End If

        'Vérifie si le poste téléphonique est entièrement numérique (NE FONCTIONNE PAS)
        If tbPosteTelephonique.ForeColor = Color.LightGray AndAlso Not Integer.TryParse(tbPosteTelephonique.Text, testInt) Then
            MessageBox.Show("Vous ne devez entrer que des numéros pour le poste téléphonique", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Vérifie si le numéro de cellulaire est au bon format
        If tbCellulaire.ForeColor = Color.LightGray Then
            Select Case tbCellulaire.Text.Length
                Case 14
                    If Not tbCellulaire.Text.Substring(0, 1) = "(" OrElse Not Integer.TryParse(tbCellulaire.Text.Substring(1, 3), testInt) OrElse Not tbCellulaire.Text.Substring(4, 2) = ")-" OrElse Not Integer.TryParse(tbCellulaire.Text.Substring(6, 3), testInt) OrElse Not tbCellulaire.Text.Substring(9, 1) = "-" OrElse Not Integer.TryParse(tbCellulaire.Text.Substring(10, 4), testInt) Then
                        MessageBox.Show("Vous n'avez pas entré le bon format de cellulaire", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                Case 12
                    If Not Integer.TryParse(tbCellulaire.Text.Substring(0, 3), testInt) OrElse Not tbCellulaire.Text.Substring(3, 1) = "-" OrElse Not Integer.TryParse(tbCellulaire.Text.Substring(4, 3), testInt) OrElse Not tbCellulaire.Text.Substring(7, 1) = "-" OrElse Integer.TryParse(tbCellulaire.Text.Substring(8, 4), testInt) Then
                        MessageBox.Show("Vous n'avez pas entré le bon format de cellulaire", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                Case 10
                    If Not Integer.TryParse(tbCellulaire.Text.Substring(0, 10), testInt) Then
                        MessageBox.Show("Vous n'avez pas entré le bon format de cellulaire", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                Case Else
                    MessageBox.Show("Vous n'avez pas entré le bon format de cellulaire", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
            End Select
        End If

        'Vérifie si le courriel est au bon format


        'Quand toutes les vérifications sont faites, faire l'action demandé par l'utilisateur (selon le titre affiché)
        envoieInfos()
    End Sub

    'PARTIE DES PANELS-------------------------------------------------------------------------------------------
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

    'LES FONCTIONS----------------------------------------------------------------------------------------------
    Private Sub envoieInfos()
        Select Case lTitre.Text
            Case "Ajout Administrateur"
                Try
                    'Vérifie si le matricule existe déjà dans la BD
                    Dim verifSiExiste As String = ""
                    commande.Connection = con
                    commande.CommandText = "Select * from individus where id_individu='" & tbMatricule.Text & "';"
                    con.Open()
                    reader = commande.ExecuteReader
                    While (reader.Read)
                        verifSiExiste = reader(1)
                    End While

                    con.Close()
                    reader.Close()

                    If Not String.IsNullOrWhiteSpace(verifSiExiste) Then
                        MessageBox.Show("Ce matricule est déjà dans la base de donnée", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    commande.CommandText = "insert into individus values('" & tbMatricule.Text & "','" & tbNom.Text & "', '" & tbPrenom.Text & "','','info','admin','8195422222','test2','1234');"
                    con.Open()
                    commande.ExecuteNonQuery()
                    con.Close()

                    MessageBox.Show("Ajout de l'administrateur effectué")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    con.Close()
                    reader.Close()
                    Return
                End Try
            Case "Ajout Emprunteur"

            Case "Ajout Prêteurs"

        End Select
    End Sub
End Class