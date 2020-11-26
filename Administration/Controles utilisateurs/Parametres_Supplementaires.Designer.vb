<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parametres_Supplementaires
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pInfosModifiables = New System.Windows.Forms.Panel()
        Me.lMessage = New System.Windows.Forms.Label()
        Me.lNbrEquipementsMaxPret = New System.Windows.Forms.Label()
        Me.lDelaisMinRetour = New System.Windows.Forms.Label()
        Me.lDelaisMinEntrePrets = New System.Windows.Forms.Label()
        Me.lNbrPretsMaxPersonne = New System.Windows.Forms.Label()
        Me.lMontantFraisRetard = New System.Windows.Forms.Label()
        Me.tbNbrEquipementsMaxPret = New System.Windows.Forms.TextBox()
        Me.tbDelaisMinRetour = New System.Windows.Forms.TextBox()
        Me.tbDelaisMinEntrePrets = New System.Windows.Forms.TextBox()
        Me.tbNbrPretsMaxPersonne = New System.Windows.Forms.TextBox()
        Me.tbFraisRetard = New System.Windows.Forms.TextBox()
        Me.lTitreHaut = New System.Windows.Forms.Label()
        Me.lTitreInfosModifiables = New System.Windows.Forms.Label()
        Me.pChoixCategorie = New System.Windows.Forms.Panel()
        Me.rbAdmins = New System.Windows.Forms.RadioButton()
        Me.rbPreteurs = New System.Windows.Forms.RadioButton()
        Me.rbEmprunteurs = New System.Windows.Forms.RadioButton()
        Me.lTitreChoixTypeStatut = New System.Windows.Forms.Label()
        Me.bSauvegarderChoix = New System.Windows.Forms.Button()
        Me.pInfosModifiables.SuspendLayout()
        Me.pChoixCategorie.SuspendLayout()
        Me.SuspendLayout()
        '
        'pInfosModifiables
        '
        Me.pInfosModifiables.Controls.Add(Me.lMessage)
        Me.pInfosModifiables.Controls.Add(Me.lNbrEquipementsMaxPret)
        Me.pInfosModifiables.Controls.Add(Me.lDelaisMinRetour)
        Me.pInfosModifiables.Controls.Add(Me.lDelaisMinEntrePrets)
        Me.pInfosModifiables.Controls.Add(Me.lNbrPretsMaxPersonne)
        Me.pInfosModifiables.Controls.Add(Me.lMontantFraisRetard)
        Me.pInfosModifiables.Controls.Add(Me.tbNbrEquipementsMaxPret)
        Me.pInfosModifiables.Controls.Add(Me.tbDelaisMinRetour)
        Me.pInfosModifiables.Controls.Add(Me.tbDelaisMinEntrePrets)
        Me.pInfosModifiables.Controls.Add(Me.tbNbrPretsMaxPersonne)
        Me.pInfosModifiables.Controls.Add(Me.tbFraisRetard)
        Me.pInfosModifiables.Location = New System.Drawing.Point(111, 129)
        Me.pInfosModifiables.Name = "pInfosModifiables"
        Me.pInfosModifiables.Size = New System.Drawing.Size(332, 294)
        Me.pInfosModifiables.TabIndex = 0
        '
        'lMessage
        '
        Me.lMessage.AutoSize = True
        Me.lMessage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMessage.Location = New System.Drawing.Point(12, 246)
        Me.lMessage.Name = "lMessage"
        Me.lMessage.Size = New System.Drawing.Size(284, 32)
        Me.lMessage.TabIndex = 10
        Me.lMessage.Text = "(Si vous ne voulez pas mettre de limites, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mettez 'X')"
        '
        'lNbrEquipementsMaxPret
        '
        Me.lNbrEquipementsMaxPret.AutoSize = True
        Me.lNbrEquipementsMaxPret.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lNbrEquipementsMaxPret.Location = New System.Drawing.Point(11, 185)
        Me.lNbrEquipementsMaxPret.Name = "lNbrEquipementsMaxPret"
        Me.lNbrEquipementsMaxPret.Size = New System.Drawing.Size(297, 32)
        Me.lNbrEquipementsMaxPret.TabIndex = 9
        Me.lNbrEquipementsMaxPret.Text = "Nombre d'équipements max à mettre dans " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "un prêt"
        '
        'lDelaisMinRetour
        '
        Me.lDelaisMinRetour.AutoSize = True
        Me.lDelaisMinRetour.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lDelaisMinRetour.Location = New System.Drawing.Point(11, 140)
        Me.lDelaisMinRetour.Name = "lDelaisMinRetour"
        Me.lDelaisMinRetour.Size = New System.Drawing.Size(298, 16)
        Me.lDelaisMinRetour.TabIndex = 8
        Me.lDelaisMinRetour.Text = "Le délais minimum pour effectuer un retour"
        '
        'lDelaisMinEntrePrets
        '
        Me.lDelaisMinEntrePrets.AutoSize = True
        Me.lDelaisMinEntrePrets.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lDelaisMinEntrePrets.Location = New System.Drawing.Point(11, 98)
        Me.lDelaisMinEntrePrets.Name = "lDelaisMinEntrePrets"
        Me.lDelaisMinEntrePrets.Size = New System.Drawing.Size(317, 16)
        Me.lDelaisMinEntrePrets.TabIndex = 7
        Me.lDelaisMinEntrePrets.Text = "Le délais minimum entre chaque prêt (en jour)"
        '
        'lNbrPretsMaxPersonne
        '
        Me.lNbrPretsMaxPersonne.AutoSize = True
        Me.lNbrPretsMaxPersonne.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lNbrPretsMaxPersonne.Location = New System.Drawing.Point(11, 56)
        Me.lNbrPretsMaxPersonne.Name = "lNbrPretsMaxPersonne"
        Me.lNbrPretsMaxPersonne.Size = New System.Drawing.Size(284, 16)
        Me.lNbrPretsMaxPersonne.TabIndex = 6
        Me.lNbrPretsMaxPersonne.Text = "Nombre de prêts maximum par personne"
        '
        'lMontantFraisRetard
        '
        Me.lMontantFraisRetard.AutoSize = True
        Me.lMontantFraisRetard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMontantFraisRetard.Location = New System.Drawing.Point(11, 14)
        Me.lMontantFraisRetard.Name = "lMontantFraisRetard"
        Me.lMontantFraisRetard.Size = New System.Drawing.Size(193, 16)
        Me.lMontantFraisRetard.TabIndex = 5
        Me.lMontantFraisRetard.Text = "Montant des frais de retard"
        '
        'tbNbrEquipementsMaxPret
        '
        Me.tbNbrEquipementsMaxPret.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.tbNbrEquipementsMaxPret.Location = New System.Drawing.Point(14, 220)
        Me.tbNbrEquipementsMaxPret.MaxLength = 2
        Me.tbNbrEquipementsMaxPret.Name = "tbNbrEquipementsMaxPret"
        Me.tbNbrEquipementsMaxPret.Size = New System.Drawing.Size(301, 23)
        Me.tbNbrEquipementsMaxPret.TabIndex = 4
        '
        'tbDelaisMinRetour
        '
        Me.tbDelaisMinRetour.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.tbDelaisMinRetour.Location = New System.Drawing.Point(14, 159)
        Me.tbDelaisMinRetour.MaxLength = 2
        Me.tbDelaisMinRetour.Name = "tbDelaisMinRetour"
        Me.tbDelaisMinRetour.Size = New System.Drawing.Size(301, 23)
        Me.tbDelaisMinRetour.TabIndex = 3
        '
        'tbDelaisMinEntrePrets
        '
        Me.tbDelaisMinEntrePrets.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.tbDelaisMinEntrePrets.Location = New System.Drawing.Point(14, 117)
        Me.tbDelaisMinEntrePrets.MaxLength = 2
        Me.tbDelaisMinEntrePrets.Name = "tbDelaisMinEntrePrets"
        Me.tbDelaisMinEntrePrets.Size = New System.Drawing.Size(301, 20)
        Me.tbDelaisMinEntrePrets.TabIndex = 2
        '
        'tbNbrPretsMaxPersonne
        '
        Me.tbNbrPretsMaxPersonne.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.tbNbrPretsMaxPersonne.Location = New System.Drawing.Point(14, 75)
        Me.tbNbrPretsMaxPersonne.MaxLength = 2
        Me.tbNbrPretsMaxPersonne.Name = "tbNbrPretsMaxPersonne"
        Me.tbNbrPretsMaxPersonne.Size = New System.Drawing.Size(301, 20)
        Me.tbNbrPretsMaxPersonne.TabIndex = 1
        '
        'tbFraisRetard
        '
        Me.tbFraisRetard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.tbFraisRetard.Location = New System.Drawing.Point(14, 33)
        Me.tbFraisRetard.MaxLength = 3
        Me.tbFraisRetard.Name = "tbFraisRetard"
        Me.tbFraisRetard.Size = New System.Drawing.Size(301, 20)
        Me.tbFraisRetard.TabIndex = 0
        '
        'lTitreHaut
        '
        Me.lTitreHaut.AutoSize = True
        Me.lTitreHaut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lTitreHaut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.0!)
        Me.lTitreHaut.Location = New System.Drawing.Point(258, 20)
        Me.lTitreHaut.Name = "lTitreHaut"
        Me.lTitreHaut.Size = New System.Drawing.Size(496, 41)
        Me.lTitreHaut.TabIndex = 1
        Me.lTitreHaut.Text = "Paramètres supplémentaires"
        '
        'lTitreInfosModifiables
        '
        Me.lTitreInfosModifiables.AutoSize = True
        Me.lTitreInfosModifiables.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lTitreInfosModifiables.Location = New System.Drawing.Point(206, 108)
        Me.lTitreInfosModifiables.Name = "lTitreInfosModifiables"
        Me.lTitreInfosModifiables.Size = New System.Drawing.Size(141, 18)
        Me.lTitreInfosModifiables.TabIndex = 2
        Me.lTitreInfosModifiables.Text = "Infos modifiables"
        '
        'pChoixCategorie
        '
        Me.pChoixCategorie.Controls.Add(Me.rbAdmins)
        Me.pChoixCategorie.Controls.Add(Me.rbPreteurs)
        Me.pChoixCategorie.Controls.Add(Me.rbEmprunteurs)
        Me.pChoixCategorie.Location = New System.Drawing.Point(555, 170)
        Me.pChoixCategorie.Name = "pChoixCategorie"
        Me.pChoixCategorie.Size = New System.Drawing.Size(309, 184)
        Me.pChoixCategorie.TabIndex = 3
        '
        'rbAdmins
        '
        Me.rbAdmins.AutoSize = True
        Me.rbAdmins.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!)
        Me.rbAdmins.Location = New System.Drawing.Point(24, 128)
        Me.rbAdmins.Name = "rbAdmins"
        Me.rbAdmins.Size = New System.Drawing.Size(223, 27)
        Me.rbAdmins.TabIndex = 2
        Me.rbAdmins.Text = "Les administrateurs"
        Me.rbAdmins.UseVisualStyleBackColor = True
        '
        'rbPreteurs
        '
        Me.rbPreteurs.AutoSize = True
        Me.rbPreteurs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!)
        Me.rbPreteurs.Location = New System.Drawing.Point(24, 76)
        Me.rbPreteurs.Name = "rbPreteurs"
        Me.rbPreteurs.Size = New System.Drawing.Size(153, 27)
        Me.rbPreteurs.TabIndex = 1
        Me.rbPreteurs.Text = "Les prêteurs"
        Me.rbPreteurs.UseVisualStyleBackColor = True
        '
        'rbEmprunteurs
        '
        Me.rbEmprunteurs.AutoSize = True
        Me.rbEmprunteurs.Checked = True
        Me.rbEmprunteurs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!)
        Me.rbEmprunteurs.Location = New System.Drawing.Point(24, 23)
        Me.rbEmprunteurs.Name = "rbEmprunteurs"
        Me.rbEmprunteurs.Size = New System.Drawing.Size(195, 27)
        Me.rbEmprunteurs.TabIndex = 0
        Me.rbEmprunteurs.TabStop = True
        Me.rbEmprunteurs.Text = "Les emprunteurs"
        Me.rbEmprunteurs.UseVisualStyleBackColor = True
        '
        'lTitreChoixTypeStatut
        '
        Me.lTitreChoixTypeStatut.AutoSize = True
        Me.lTitreChoixTypeStatut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lTitreChoixTypeStatut.Location = New System.Drawing.Point(523, 145)
        Me.lTitreChoixTypeStatut.Name = "lTitreChoixTypeStatut"
        Me.lTitreChoixTypeStatut.Size = New System.Drawing.Size(379, 18)
        Me.lTitreChoixTypeStatut.TabIndex = 4
        Me.lTitreChoixTypeStatut.Text = "Veuillez choisir le type de personnes à modifier"
        '
        'bSauvegarderChoix
        '
        Me.bSauvegarderChoix.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSauvegarderChoix.Location = New System.Drawing.Point(616, 360)
        Me.bSauvegarderChoix.Name = "bSauvegarderChoix"
        Me.bSauvegarderChoix.Size = New System.Drawing.Size(186, 63)
        Me.bSauvegarderChoix.TabIndex = 5
        Me.bSauvegarderChoix.Text = "Sauvegarder les choix"
        Me.bSauvegarderChoix.UseVisualStyleBackColor = True
        '
        'Parametres_Supplementaires
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.bSauvegarderChoix)
        Me.Controls.Add(Me.lTitreChoixTypeStatut)
        Me.Controls.Add(Me.pChoixCategorie)
        Me.Controls.Add(Me.lTitreInfosModifiables)
        Me.Controls.Add(Me.lTitreHaut)
        Me.Controls.Add(Me.pInfosModifiables)
        Me.Name = "Parametres_Supplementaires"
        Me.Size = New System.Drawing.Size(1013, 473)
        Me.pInfosModifiables.ResumeLayout(False)
        Me.pInfosModifiables.PerformLayout()
        Me.pChoixCategorie.ResumeLayout(False)
        Me.pChoixCategorie.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pInfosModifiables As Panel
    Friend WithEvents lTitreHaut As Label
    Friend WithEvents lTitreInfosModifiables As Label
    Friend WithEvents tbFraisRetard As TextBox
    Friend WithEvents tbNbrPretsMaxPersonne As TextBox
    Friend WithEvents tbDelaisMinRetour As TextBox
    Friend WithEvents tbDelaisMinEntrePrets As TextBox
    Friend WithEvents tbNbrEquipementsMaxPret As TextBox
    Friend WithEvents lNbrEquipementsMaxPret As Label
    Friend WithEvents lDelaisMinRetour As Label
    Friend WithEvents lDelaisMinEntrePrets As Label
    Friend WithEvents lNbrPretsMaxPersonne As Label
    Friend WithEvents lMontantFraisRetard As Label
    Friend WithEvents lMessage As Label
    Friend WithEvents pChoixCategorie As Panel
    Friend WithEvents rbAdmins As RadioButton
    Friend WithEvents rbPreteurs As RadioButton
    Friend WithEvents rbEmprunteurs As RadioButton
    Friend WithEvents lTitreChoixTypeStatut As Label
    Friend WithEvents bSauvegarderChoix As Button
End Class
