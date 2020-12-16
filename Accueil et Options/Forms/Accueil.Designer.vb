<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lDeconnection = New System.Windows.Forms.Label()
        Me.lNomUtilisateur = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lTitreRichTextBox = New System.Windows.Forms.Label()
        Me.bFaireEmprunt = New System.Windows.Forms.Button()
        Me.bFaireRetour = New System.Windows.Forms.Button()
        Me.bHistEmprunt = New System.Windows.Forms.Button()
        Me.bHistRetours = New System.Windows.Forms.Button()
        Me.pBas = New System.Windows.Forms.Panel()
        Me.pHaut = New System.Windows.Forms.Panel()
        Me.lTitre = New System.Windows.Forms.Label()
        Me.lQuitter = New System.Windows.Forms.Label()
        Me.lMsFichier = New System.Windows.Forms.Label()
        Me.lMsQuitter = New System.Windows.Forms.Label()
        Me.lMsEmprunts = New System.Windows.Forms.Label()
        Me.lMsFaireEmprunt = New System.Windows.Forms.Label()
        Me.lMsHistoriqueEmprunt = New System.Windows.Forms.Label()
        Me.lMsRetours = New System.Windows.Forms.Label()
        Me.lMsFaireRetour = New System.Windows.Forms.Label()
        Me.lMsHistoriqueRetours = New System.Windows.Forms.Label()
        Me.lMsDossiers = New System.Windows.Forms.Label()
        Me.lMsConsulter = New System.Windows.Forms.Label()
        Me.lMsEmprunteur = New System.Windows.Forms.Label()
        Me.lMsOptions = New System.Windows.Forms.Label()
        Me.lMsAdministration = New System.Windows.Forms.Label()
        Me.lMsEquipements = New System.Windows.Forms.Label()
        Me.pHaut.SuspendLayout()
        Me.SuspendLayout()
        '
        'lDeconnection
        '
        Me.lDeconnection.AutoSize = True
        Me.lDeconnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lDeconnection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lDeconnection.Location = New System.Drawing.Point(671, 116)
        Me.lDeconnection.Name = "lDeconnection"
        Me.lDeconnection.Size = New System.Drawing.Size(115, 18)
        Me.lDeconnection.TabIndex = 0
        Me.lDeconnection.Text = "Se déconnecter"
        '
        'lNomUtilisateur
        '
        Me.lNomUtilisateur.AutoSize = True
        Me.lNomUtilisateur.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lNomUtilisateur.Location = New System.Drawing.Point(551, 118)
        Me.lNomUtilisateur.Name = "lNomUtilisateur"
        Me.lNomUtilisateur.Size = New System.Drawing.Size(114, 16)
        Me.lNomUtilisateur.TabIndex = 1
        Me.lNomUtilisateur.Text = "Nom_utilisateur"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(40, 155)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(276, 334)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'lTitreRichTextBox
        '
        Me.lTitreRichTextBox.AutoSize = True
        Me.lTitreRichTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lTitreRichTextBox.Location = New System.Drawing.Point(121, 139)
        Me.lTitreRichTextBox.Name = "lTitreRichTextBox"
        Me.lTitreRichTextBox.Size = New System.Drawing.Size(106, 16)
        Me.lTitreRichTextBox.TabIndex = 3
        Me.lTitreRichTextBox.Text = "Prêts en cours"
        '
        'bFaireEmprunt
        '
        Me.bFaireEmprunt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.bFaireEmprunt.Location = New System.Drawing.Point(447, 176)
        Me.bFaireEmprunt.Name = "bFaireEmprunt"
        Me.bFaireEmprunt.Size = New System.Drawing.Size(232, 55)
        Me.bFaireEmprunt.TabIndex = 4
        Me.bFaireEmprunt.Text = "Faire un emprunt"
        Me.bFaireEmprunt.UseVisualStyleBackColor = True
        '
        'bFaireRetour
        '
        Me.bFaireRetour.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.bFaireRetour.Location = New System.Drawing.Point(447, 255)
        Me.bFaireRetour.Name = "bFaireRetour"
        Me.bFaireRetour.Size = New System.Drawing.Size(232, 55)
        Me.bFaireRetour.TabIndex = 5
        Me.bFaireRetour.Text = "Faire un retour"
        Me.bFaireRetour.UseVisualStyleBackColor = True
        '
        'bHistEmprunt
        '
        Me.bHistEmprunt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.bHistEmprunt.Location = New System.Drawing.Point(447, 335)
        Me.bHistEmprunt.Name = "bHistEmprunt"
        Me.bHistEmprunt.Size = New System.Drawing.Size(232, 55)
        Me.bHistEmprunt.TabIndex = 6
        Me.bHistEmprunt.Text = "Historique des emprunts"
        Me.bHistEmprunt.UseVisualStyleBackColor = True
        '
        'bHistRetours
        '
        Me.bHistRetours.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.bHistRetours.Location = New System.Drawing.Point(447, 412)
        Me.bHistRetours.Name = "bHistRetours"
        Me.bHistRetours.Size = New System.Drawing.Size(232, 55)
        Me.bHistRetours.TabIndex = 7
        Me.bHistRetours.Text = "Historique des retours"
        Me.bHistRetours.UseVisualStyleBackColor = True
        '
        'pBas
        '
        Me.pBas.Location = New System.Drawing.Point(0, 498)
        Me.pBas.Name = "pBas"
        Me.pBas.Size = New System.Drawing.Size(799, 31)
        Me.pBas.TabIndex = 9
        '
        'pHaut
        '
        Me.pHaut.Controls.Add(Me.lTitre)
        Me.pHaut.Controls.Add(Me.lQuitter)
        Me.pHaut.Location = New System.Drawing.Point(0, 0)
        Me.pHaut.Name = "pHaut"
        Me.pHaut.Size = New System.Drawing.Size(799, 31)
        Me.pHaut.TabIndex = 10
        '
        'lTitre
        '
        Me.lTitre.AutoSize = True
        Me.lTitre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitre.ForeColor = System.Drawing.Color.White
        Me.lTitre.Location = New System.Drawing.Point(12, 1)
        Me.lTitre.Name = "lTitre"
        Me.lTitre.Size = New System.Drawing.Size(99, 28)
        Me.lTitre.TabIndex = 11
        Me.lTitre.Text = "Accueil"
        '
        'lQuitter
        '
        Me.lQuitter.AutoSize = True
        Me.lQuitter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lQuitter.ForeColor = System.Drawing.Color.White
        Me.lQuitter.Location = New System.Drawing.Point(769, 1)
        Me.lQuitter.Name = "lQuitter"
        Me.lQuitter.Size = New System.Drawing.Size(26, 28)
        Me.lQuitter.TabIndex = 11
        Me.lQuitter.Text = "X"
        '
        'lMsFichier
        '
        Me.lMsFichier.AutoSize = True
        Me.lMsFichier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsFichier.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsFichier.Location = New System.Drawing.Point(27, 38)
        Me.lMsFichier.Name = "lMsFichier"
        Me.lMsFichier.Size = New System.Drawing.Size(56, 18)
        Me.lMsFichier.TabIndex = 11
        Me.lMsFichier.Text = "Fichier"
        '
        'lMsQuitter
        '
        Me.lMsQuitter.AutoSize = True
        Me.lMsQuitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsQuitter.Enabled = False
        Me.lMsQuitter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsQuitter.Location = New System.Drawing.Point(27, 62)
        Me.lMsQuitter.Name = "lMsQuitter"
        Me.lMsQuitter.Size = New System.Drawing.Size(57, 18)
        Me.lMsQuitter.TabIndex = 12
        Me.lMsQuitter.Text = "Quitter"
        Me.lMsQuitter.Visible = False
        '
        'lMsEmprunts
        '
        Me.lMsEmprunts.AutoSize = True
        Me.lMsEmprunts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsEmprunts.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsEmprunts.Location = New System.Drawing.Point(87, 38)
        Me.lMsEmprunts.Name = "lMsEmprunts"
        Me.lMsEmprunts.Size = New System.Drawing.Size(75, 18)
        Me.lMsEmprunts.TabIndex = 13
        Me.lMsEmprunts.Text = "Emprunts"
        '
        'lMsFaireEmprunt
        '
        Me.lMsFaireEmprunt.AutoSize = True
        Me.lMsFaireEmprunt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsFaireEmprunt.Enabled = False
        Me.lMsFaireEmprunt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsFaireEmprunt.Location = New System.Drawing.Point(87, 62)
        Me.lMsFaireEmprunt.Name = "lMsFaireEmprunt"
        Me.lMsFaireEmprunt.Size = New System.Drawing.Size(124, 18)
        Me.lMsFaireEmprunt.TabIndex = 14
        Me.lMsFaireEmprunt.Text = "Faire un emprunt"
        Me.lMsFaireEmprunt.Visible = False
        '
        'lMsHistoriqueEmprunt
        '
        Me.lMsHistoriqueEmprunt.AutoSize = True
        Me.lMsHistoriqueEmprunt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsHistoriqueEmprunt.Enabled = False
        Me.lMsHistoriqueEmprunt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsHistoriqueEmprunt.Location = New System.Drawing.Point(217, 62)
        Me.lMsHistoriqueEmprunt.Name = "lMsHistoriqueEmprunt"
        Me.lMsHistoriqueEmprunt.Size = New System.Drawing.Size(178, 18)
        Me.lMsHistoriqueEmprunt.TabIndex = 15
        Me.lMsHistoriqueEmprunt.Text = "Historique des emprunts"
        Me.lMsHistoriqueEmprunt.Visible = False
        '
        'lMsRetours
        '
        Me.lMsRetours.AutoSize = True
        Me.lMsRetours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsRetours.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsRetours.Location = New System.Drawing.Point(168, 38)
        Me.lMsRetours.Name = "lMsRetours"
        Me.lMsRetours.Size = New System.Drawing.Size(63, 18)
        Me.lMsRetours.TabIndex = 16
        Me.lMsRetours.Text = "Retours"
        '
        'lMsFaireRetour
        '
        Me.lMsFaireRetour.AutoSize = True
        Me.lMsFaireRetour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsFaireRetour.Enabled = False
        Me.lMsFaireRetour.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsFaireRetour.Location = New System.Drawing.Point(168, 62)
        Me.lMsFaireRetour.Name = "lMsFaireRetour"
        Me.lMsFaireRetour.Size = New System.Drawing.Size(109, 18)
        Me.lMsFaireRetour.TabIndex = 17
        Me.lMsFaireRetour.Text = "Faire un retour"
        Me.lMsFaireRetour.Visible = False
        '
        'lMsHistoriqueRetours
        '
        Me.lMsHistoriqueRetours.AutoSize = True
        Me.lMsHistoriqueRetours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsHistoriqueRetours.Enabled = False
        Me.lMsHistoriqueRetours.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsHistoriqueRetours.Location = New System.Drawing.Point(283, 62)
        Me.lMsHistoriqueRetours.Name = "lMsHistoriqueRetours"
        Me.lMsHistoriqueRetours.Size = New System.Drawing.Size(163, 18)
        Me.lMsHistoriqueRetours.TabIndex = 18
        Me.lMsHistoriqueRetours.Text = "Historique des retours"
        Me.lMsHistoriqueRetours.Visible = False
        '
        'lMsDossiers
        '
        Me.lMsDossiers.AutoSize = True
        Me.lMsDossiers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsDossiers.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsDossiers.Location = New System.Drawing.Point(237, 38)
        Me.lMsDossiers.Name = "lMsDossiers"
        Me.lMsDossiers.Size = New System.Drawing.Size(70, 18)
        Me.lMsDossiers.TabIndex = 19
        Me.lMsDossiers.Text = "Dossiers"
        '
        'lMsConsulter
        '
        Me.lMsConsulter.AutoSize = True
        Me.lMsConsulter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsConsulter.Enabled = False
        Me.lMsConsulter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsConsulter.Location = New System.Drawing.Point(237, 62)
        Me.lMsConsulter.Name = "lMsConsulter"
        Me.lMsConsulter.Size = New System.Drawing.Size(75, 18)
        Me.lMsConsulter.TabIndex = 20
        Me.lMsConsulter.Text = "Consulter"
        Me.lMsConsulter.Visible = False
        '
        'lMsEmprunteur
        '
        Me.lMsEmprunteur.AutoSize = True
        Me.lMsEmprunteur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsEmprunteur.Enabled = False
        Me.lMsEmprunteur.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsEmprunteur.Location = New System.Drawing.Point(318, 62)
        Me.lMsEmprunteur.Name = "lMsEmprunteur"
        Me.lMsEmprunteur.Size = New System.Drawing.Size(89, 18)
        Me.lMsEmprunteur.TabIndex = 21
        Me.lMsEmprunteur.Text = "Emprunteur"
        Me.lMsEmprunteur.Visible = False
        '
        'lMsOptions
        '
        Me.lMsOptions.AutoSize = True
        Me.lMsOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsOptions.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsOptions.Location = New System.Drawing.Point(313, 38)
        Me.lMsOptions.Name = "lMsOptions"
        Me.lMsOptions.Size = New System.Drawing.Size(63, 18)
        Me.lMsOptions.TabIndex = 22
        Me.lMsOptions.Text = "Options"
        '
        'lMsAdministration
        '
        Me.lMsAdministration.AutoSize = True
        Me.lMsAdministration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsAdministration.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsAdministration.Location = New System.Drawing.Point(486, 38)
        Me.lMsAdministration.Name = "lMsAdministration"
        Me.lMsAdministration.Size = New System.Drawing.Size(109, 18)
        Me.lMsAdministration.TabIndex = 23
        Me.lMsAdministration.Text = "Administration"
        '
        'lMsEquipements
        '
        Me.lMsEquipements.AutoSize = True
        Me.lMsEquipements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMsEquipements.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMsEquipements.Location = New System.Drawing.Point(382, 38)
        Me.lMsEquipements.Name = "lMsEquipements"
        Me.lMsEquipements.Size = New System.Drawing.Size(98, 18)
        Me.lMsEquipements.TabIndex = 24
        Me.lMsEquipements.Text = "Équipements"
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 530)
        Me.Controls.Add(Me.lMsEquipements)
        Me.Controls.Add(Me.lMsAdministration)
        Me.Controls.Add(Me.lMsOptions)
        Me.Controls.Add(Me.lMsEmprunteur)
        Me.Controls.Add(Me.lMsConsulter)
        Me.Controls.Add(Me.lMsDossiers)
        Me.Controls.Add(Me.lMsHistoriqueRetours)
        Me.Controls.Add(Me.lMsFaireRetour)
        Me.Controls.Add(Me.lMsRetours)
        Me.Controls.Add(Me.lMsHistoriqueEmprunt)
        Me.Controls.Add(Me.lMsFaireEmprunt)
        Me.Controls.Add(Me.lMsEmprunts)
        Me.Controls.Add(Me.lMsQuitter)
        Me.Controls.Add(Me.lMsFichier)
        Me.Controls.Add(Me.pHaut)
        Me.Controls.Add(Me.pBas)
        Me.Controls.Add(Me.bHistRetours)
        Me.Controls.Add(Me.bHistEmprunt)
        Me.Controls.Add(Me.bFaireRetour)
        Me.Controls.Add(Me.bFaireEmprunt)
        Me.Controls.Add(Me.lTitreRichTextBox)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.lNomUtilisateur)
        Me.Controls.Add(Me.lDeconnection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        Me.pHaut.ResumeLayout(False)
        Me.pHaut.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lDeconnection As Label
    Friend WithEvents lNomUtilisateur As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lTitreRichTextBox As Label
    Friend WithEvents bFaireEmprunt As Button
    Friend WithEvents bFaireRetour As Button
    Friend WithEvents bHistEmprunt As Button
    Friend WithEvents bHistRetours As Button
    Friend WithEvents pBas As Panel
    Friend WithEvents pHaut As Panel
    Friend WithEvents lQuitter As Label
    Friend WithEvents lTitre As Label
    Friend WithEvents lMsFichier As Label
    Friend WithEvents lMsQuitter As Label
    Friend WithEvents lMsEmprunts As Label
    Friend WithEvents lMsFaireEmprunt As Label
    Friend WithEvents lMsHistoriqueEmprunt As Label
    Friend WithEvents lMsRetours As Label
    Friend WithEvents lMsFaireRetour As Label
    Friend WithEvents lMsHistoriqueRetours As Label
    Friend WithEvents lMsDossiers As Label
    Friend WithEvents lMsConsulter As Label
    Friend WithEvents lMsEmprunteur As Label
    Friend WithEvents lMsOptions As Label
    Friend WithEvents lMsAdministration As Label
    Friend WithEvents lMsEquipements As Label
End Class
