'Importation nécessaire
Imports MySql.Data.MySqlClient

Public Class Connexion
    'Variables nécessaires

    Dim con As MySqlConnection = New MySqlConnection("Server=localhost;Database=projet_multi;Uid=root;Pwd='';Port=3308;")
    Dim reader As MySqlDataReader
    Dim commande As New MySqlCommand
    Dim mdp As String
    Dim styleVisuel As Integer = 0
    Dim langue As Integer = 1
    Dim emplacement As Point
    Dim pressetMatricule As String
    Dim pressetMdp As String

    'PARTIE FORM--------------------------------------------------------------------------------------------------------------------

    'Lors de l'ouverture de l'application
    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Recherche dans les documents de l'ordi pour voir quel style visuel il avait avant sa fermeture
        '...

        'Définit le visuel de l'application
        If styleVisuel = 0 Then
            'Si le visuel choisie avant est le clair
            pHaut.BackColor = ColorTranslator.FromHtml("#4b6584")
            pBas.BackColor = ColorTranslator.FromHtml("#4b6584")
            Me.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            bConfirmer.ForeColor = Color.White
            bConfirmer.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMdpOublie.ForeColor = Color.Black
        Else
            'Si le visuel choisie avant est le sombre
            pHaut.BackColor = ColorTranslator.FromHtml("#252926")
            pBas.BackColor = ColorTranslator.FromHtml("#252926")
            Me.BackColor = ColorTranslator.FromHtml("#3c403d")
            bConfirmer.ForeColor = Color.White
            bConfirmer.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMdpOublie.ForeColor = Color.White
        End If

        'Définit la langue de l'application
        If langue = 0 Then
            lTitrePage.Text = "Connexion"
            pressetMatricule = "Utilisateur"
            pressetMdp = "Mot de passe"
            lMdpOublie.Text = "Mot de passe oublié?"
            bConfirmer.Text = "CONFIRMER"
            lMessageCreationCompte.Text = "Votre compte n'a pas été créé?"
            LCreationCompte.Text = "Cliquez ici"
        Else
            lTitrePage.Text = "Connection"
            pressetMatricule = "User"
            pressetMdp = "Password"
            lMdpOublie.Text = "Forgot your password?"
            bConfirmer.Text = "CONFIRM"
            lMessageCreationCompte.Text = "Your account has not been created?"
            LCreationCompte.Text = "Click here"
        End If

        'Les objets à changer manuellement et qui seront toujours pareil même si le mode visuel change
        tbMatricule.AutoSize = False
        tbMatricule.Height = 30
        tbMatricule.Text = pressetMatricule
        tbMdp.AutoSize = False
        tbMdp.Height = 30
        tbMdp.Text = pressetMdp
        LCreationCompte.BackColor = ColorTranslator.FromHtml("#69db63")
    End Sub

    'PARTIE BOUTONS------------------------------------------------------------------------------------------------------------

    'Sert à vérifier si le matricule et le mot de passe est correct pour se connecter
    Private Sub bConfirmer_Click(sender As Object, e As EventArgs) Handles bConfirmer.Click

        'Vérifie si tous les champs ont étés remplis
        If (tbMatricule.Text = pressetMatricule And tbMatricule.ForeColor = Color.LightGray) Or (tbMdp.Text = pressetMdp And tbMdp.ForeColor = Color.LightGray) Then
            If langue = 0 Then
                MessageBox.Show("Vous devez remplir tous les champs demandés", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("You must fill in all the requested fields", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            refreshTextBoxes()
            Return
        End If

        'Vérifie si la taille des champs est de 7 caractères
        If tbMatricule.Text.Length < 7 Then
            If langue = 0 Then
                MessageBox.Show("Le matricule n'est pas au bon format (7 chiffres)", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("The user is not at the correct format (7 numbers)", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            refreshTextBoxes()
            Return
        End If

        'Vérifie si le matricule n'est composé que de nombres
        Dim testInt As Integer
        If Not Integer.TryParse(tbMatricule.Text, testInt) Then
            If langue = 0 Then
                MessageBox.Show("Le matricule n'est pas composé que de nombres", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("The user is not only made up of numbers", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            refreshTextBoxes()
            Return
        End If

        'Recherche dans la BD pour voir si le prêteur ou l'administrateur est là.
        mdp = ""

        Try

            'Connexion et commande
            commande.Connection = con
            commande.CommandText = "Select * from individus where id_individu='" & tbMatricule.Text & "';"
            con.Open()
            reader = commande.ExecuteReader
            While (reader.Read)
                mdp = reader(8)
            End While

            'Vérifie si la base de donnée a retourné quelque chose.
            If String.IsNullOrWhiteSpace(mdp) Then
                If langue = 0 Then
                    MessageBox.Show("Le matricule que vous avez entré n'existe pas.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("The user you entered does not exist.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                con.Close()
                refreshTextBoxes()
                Return
            End If

            'Vérifie si le mot de passe trouvé dans la base de donné est le bon.
            If mdp <> tbMdp.Text Then
                If langue = 0 Then
                    MessageBox.Show("Le mot de passe que vous avez entré n'est pas le bon", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("The password you entered is not correct", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                con.Close()
                refreshTextBoxes()
                Return
            End If

            'Appelle la fonction de la page d'accueil
            Accueil.role(reader(5))

            'Referme la connexion pour que cela ne cause pas de problèmes pour la prochaine demande de connexion à la bd
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            refreshTextBoxes()
            Return
        End Try


        'Si tout est correct
        Accueil.Show()
        Me.Close()
    End Sub

    'PARTIE DES TEXTBOXS DU FORM-------------------------------------------------------------------------------------------------

    'Quand on appuie sur le textbox de matricule
    Private Sub tbMatricule_Enter(sender As Object, e As EventArgs) Handles tbMatricule.Enter
        If tbMatricule.Text = pressetMatricule And tbMatricule.ForeColor = Color.LightGray Then
            tbMatricule.ResetText()
            tbMatricule.ForeColor = Color.Black
        End If
    End Sub

    'Quand on déselectionne le textbox de mot de passe
    Private Sub tbMatricule_Leave(sender As Object, e As EventArgs) Handles tbMatricule.Leave
        If String.IsNullOrWhiteSpace(tbMatricule.Text) Then
            tbMatricule.Text = pressetMatricule
            tbMatricule.ForeColor = Color.LightGray
        End If
    End Sub

    'Quand on appuie sur le textbox de mot de passe
    Private Sub tbMdp_Enter(sender As Object, e As EventArgs) Handles tbMdp.Enter
        If tbMdp.Text = pressetMdp And tbMdp.ForeColor = Color.LightGray Then
            tbMdp.ResetText()
            tbMdp.ForeColor = Color.Black
            tbMdp.UseSystemPasswordChar = True
        End If
    End Sub

    'Quand on déselectionne le textbox de mot de passe
    Private Sub tbMdp_Leave(sender As Object, e As EventArgs) Handles tbMdp.Leave
        If String.IsNullOrWhiteSpace(tbMdp.Text) Then
            tbMdp.Text = pressetMdp
            tbMdp.ForeColor = Color.LightGray
            tbMdp.UseSystemPasswordChar = False
        End If
    End Sub

    'PARTIE DES LABELS DU FORM---------------------------------------------------------------------------------------------------

    'Quand on appuie sur le X en haut à droite du form
    Private Sub LQuitter_Click(sender As Object, e As EventArgs) Handles LQuitter.Click
        End
    End Sub

    'Quand on appuie sur "Mot de passe oublié?" au centre
    Private Sub lMdpOublie_Click(sender As Object, e As EventArgs) Handles lMdpOublie.Click
        messageCommunicationAdmin()
    End Sub

    'Quand on appuie sur le label de création de comptes en bas à droite
    Private Sub LCreationCompte_Click(sender As Object, e As EventArgs) Handles LCreationCompte.Click
        messageCommunicationAdmin()
    End Sub

    'PARTIE DES PANELS----------------------------------------------------------------------------------------------------------

    Private Sub pHaut_MouseDown(sender As Object, e As MouseEventArgs) Handles pHaut.MouseDown, lTitrePage.MouseDown, LQuitter.MouseDown
        If e.Button = MouseButtons.Left Then
            emplacement = e.Location
        End If
    End Sub

    Private Sub pHaut_MouseMove(sender As Object, e As MouseEventArgs) Handles pHaut.MouseMove, lTitrePage.MouseMove, LQuitter.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - emplacement
        End If
    End Sub

    'PARTIE DES FONCTIONS-------------------------------------------------------------------------------------------------------

    'Envoie un message à l'utilisateur (selon la langue choisie) pour lui dire de communiquer avec un administrateur ou un prêteur autorisé pour effectuer l'action
    Private Sub messageCommunicationAdmin()
        If langue = 0 Then
            MessageBox.Show("Veuillez communiquer avec un prêteur ou un administrateur autorisé pour effectuer cette action.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please contact an authorized lender or administrator to complete this action.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Refresh le contenu des textboxs s'il y a un erreur durant la tentative de connexion
    Private Sub refreshTextBoxes()
        If langue = 0 Then
            tbMatricule.Text = "Utilisateur"
            tbMdp.Text = "Mot de passe"
        Else
            tbMatricule.Text = "User"
            tbMdp.Text = "Password"
        End If
        tbMatricule.ForeColor = Color.LightGray
        tbMdp.ForeColor = Color.LightGray
        tbMdp.UseSystemPasswordChar = False
    End Sub
End Class