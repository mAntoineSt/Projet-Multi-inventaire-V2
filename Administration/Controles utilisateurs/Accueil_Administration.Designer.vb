<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil_Administration
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
        Me.components = New System.ComponentModel.Container()
        Me.lTitreRole = New System.Windows.Forms.Label()
        Me.lRole = New System.Windows.Forms.Label()
        Me.pAcces = New System.Windows.Forms.Panel()
        Me.lAccesStatistiques = New System.Windows.Forms.Label()
        Me.lAccesGestionAdmins = New System.Windows.Forms.Label()
        Me.lAccesGestionPreteurs = New System.Windows.Forms.Label()
        Me.lAccesGestionEmprunteurs = New System.Windows.Forms.Label()
        Me.lTitrePasAcces = New System.Windows.Forms.Label()
        Me.lTitreAcces = New System.Windows.Forms.Label()
        Me.pPasAcces = New System.Windows.Forms.Panel()
        Me.lPasAccesGestionStats = New System.Windows.Forms.Label()
        Me.lPasAccesGestionAdmins = New System.Windows.Forms.Label()
        Me.pRole = New System.Windows.Forms.Panel()
        Me.tpMessagesLabels = New System.Windows.Forms.ToolTip(Me.components)
        Me.pAcces.SuspendLayout()
        Me.pPasAcces.SuspendLayout()
        Me.pRole.SuspendLayout()
        Me.SuspendLayout()
        '
        'lTitreRole
        '
        Me.lTitreRole.AutoSize = True
        Me.lTitreRole.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.lTitreRole.Location = New System.Drawing.Point(59, 28)
        Me.lTitreRole.Name = "lTitreRole"
        Me.lTitreRole.Size = New System.Drawing.Size(148, 28)
        Me.lTitreRole.TabIndex = 1
        Me.lTitreRole.Text = "Votre rôle : "
        '
        'lRole
        '
        Me.lRole.AutoSize = True
        Me.lRole.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.lRole.Location = New System.Drawing.Point(213, 28)
        Me.lRole.Name = "lRole"
        Me.lRole.Size = New System.Drawing.Size(78, 28)
        Me.lRole.TabIndex = 2
        Me.lRole.Text = "ROLE"
        Me.tpMessagesLabels.SetToolTip(Me.lRole, "C'est le rôle à laquelle votre compte est")
        '
        'pAcces
        '
        Me.pAcces.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pAcces.Controls.Add(Me.lAccesStatistiques)
        Me.pAcces.Controls.Add(Me.lAccesGestionAdmins)
        Me.pAcces.Controls.Add(Me.lAccesGestionPreteurs)
        Me.pAcces.Controls.Add(Me.lAccesGestionEmprunteurs)
        Me.pAcces.Location = New System.Drawing.Point(94, 218)
        Me.pAcces.Name = "pAcces"
        Me.pAcces.Size = New System.Drawing.Size(258, 242)
        Me.pAcces.TabIndex = 10
        '
        'lAccesStatistiques
        '
        Me.lAccesStatistiques.AutoSize = True
        Me.lAccesStatistiques.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lAccesStatistiques.Location = New System.Drawing.Point(14, 120)
        Me.lAccesStatistiques.Name = "lAccesStatistiques"
        Me.lAccesStatistiques.Size = New System.Drawing.Size(126, 16)
        Me.lAccesStatistiques.TabIndex = 3
        Me.lAccesStatistiques.Text = "• Aux statistiques"
        '
        'lAccesGestionAdmins
        '
        Me.lAccesGestionAdmins.AutoSize = True
        Me.lAccesGestionAdmins.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lAccesGestionAdmins.Location = New System.Drawing.Point(14, 84)
        Me.lAccesGestionAdmins.Name = "lAccesGestionAdmins"
        Me.lAccesGestionAdmins.Size = New System.Drawing.Size(237, 16)
        Me.lAccesGestionAdmins.TabIndex = 2
        Me.lAccesGestionAdmins.Text = "• À la gestion des administrateurs"
        '
        'lAccesGestionPreteurs
        '
        Me.lAccesGestionPreteurs.AutoSize = True
        Me.lAccesGestionPreteurs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lAccesGestionPreteurs.Location = New System.Drawing.Point(14, 54)
        Me.lAccesGestionPreteurs.Name = "lAccesGestionPreteurs"
        Me.lAccesGestionPreteurs.Size = New System.Drawing.Size(188, 16)
        Me.lAccesGestionPreteurs.TabIndex = 1
        Me.lAccesGestionPreteurs.Text = "• À la gestion des prêteurs"
        '
        'lAccesGestionEmprunteurs
        '
        Me.lAccesGestionEmprunteurs.AutoSize = True
        Me.lAccesGestionEmprunteurs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lAccesGestionEmprunteurs.Location = New System.Drawing.Point(14, 24)
        Me.lAccesGestionEmprunteurs.Name = "lAccesGestionEmprunteurs"
        Me.lAccesGestionEmprunteurs.Size = New System.Drawing.Size(216, 16)
        Me.lAccesGestionEmprunteurs.TabIndex = 0
        Me.lAccesGestionEmprunteurs.Text = "• À la gestion des emprunteurs"
        '
        'lTitrePasAcces
        '
        Me.lTitrePasAcces.AutoSize = True
        Me.lTitrePasAcces.BackColor = System.Drawing.Color.Red
        Me.lTitrePasAcces.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!)
        Me.lTitrePasAcces.Location = New System.Drawing.Point(616, 191)
        Me.lTitrePasAcces.Name = "lTitrePasAcces"
        Me.lTitrePasAcces.Size = New System.Drawing.Size(302, 23)
        Me.lTitrePasAcces.TabIndex = 9
        Me.lTitrePasAcces.Text = "Ce que vous n'avez pas accès"
        Me.tpMessagesLabels.SetToolTip(Me.lTitrePasAcces, "Vous n'avez pas accès à ces parties")
        '
        'lTitreAcces
        '
        Me.lTitreAcces.AutoSize = True
        Me.lTitreAcces.BackColor = System.Drawing.Color.Lime
        Me.lTitreAcces.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!)
        Me.lTitreAcces.Location = New System.Drawing.Point(101, 191)
        Me.lTitreAcces.Name = "lTitreAcces"
        Me.lTitreAcces.Size = New System.Drawing.Size(244, 23)
        Me.lTitreAcces.TabIndex = 8
        Me.lTitreAcces.Text = "Ce que vous avez accès"
        Me.tpMessagesLabels.SetToolTip(Me.lTitreAcces, "Vous avez accès à ces parties")
        '
        'pPasAcces
        '
        Me.pPasAcces.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pPasAcces.Controls.Add(Me.lPasAccesGestionStats)
        Me.pPasAcces.Controls.Add(Me.lPasAccesGestionAdmins)
        Me.pPasAcces.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pPasAcces.Location = New System.Drawing.Point(640, 218)
        Me.pPasAcces.Name = "pPasAcces"
        Me.pPasAcces.Size = New System.Drawing.Size(258, 242)
        Me.pPasAcces.TabIndex = 11
        '
        'lPasAccesGestionStats
        '
        Me.lPasAccesGestionStats.AutoSize = True
        Me.lPasAccesGestionStats.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lPasAccesGestionStats.Location = New System.Drawing.Point(14, 60)
        Me.lPasAccesGestionStats.Name = "lPasAccesGestionStats"
        Me.lPasAccesGestionStats.Size = New System.Drawing.Size(126, 16)
        Me.lPasAccesGestionStats.TabIndex = 5
        Me.lPasAccesGestionStats.Text = "• Aux statistiques"
        '
        'lPasAccesGestionAdmins
        '
        Me.lPasAccesGestionAdmins.AutoSize = True
        Me.lPasAccesGestionAdmins.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lPasAccesGestionAdmins.Location = New System.Drawing.Point(14, 24)
        Me.lPasAccesGestionAdmins.Name = "lPasAccesGestionAdmins"
        Me.lPasAccesGestionAdmins.Size = New System.Drawing.Size(237, 16)
        Me.lPasAccesGestionAdmins.TabIndex = 4
        Me.lPasAccesGestionAdmins.Text = "• À la gestion des administrateurs"
        '
        'pRole
        '
        Me.pRole.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pRole.Controls.Add(Me.lTitreRole)
        Me.pRole.Controls.Add(Me.lRole)
        Me.pRole.Location = New System.Drawing.Point(319, 12)
        Me.pRole.Name = "pRole"
        Me.pRole.Size = New System.Drawing.Size(368, 85)
        Me.pRole.TabIndex = 12
        '
        'tpMessagesLabels
        '
        Me.tpMessagesLabels.ToolTipTitle = "Cet énoncé veut dire que :"
        '
        'Accueil_Administration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pAcces)
        Me.Controls.Add(Me.lTitrePasAcces)
        Me.Controls.Add(Me.lTitreAcces)
        Me.Controls.Add(Me.pPasAcces)
        Me.Controls.Add(Me.pRole)
        Me.Name = "Accueil_Administration"
        Me.Size = New System.Drawing.Size(1013, 473)
        Me.pAcces.ResumeLayout(False)
        Me.pAcces.PerformLayout()
        Me.pPasAcces.ResumeLayout(False)
        Me.pPasAcces.PerformLayout()
        Me.pRole.ResumeLayout(False)
        Me.pRole.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lTitreRole As Label
    Friend WithEvents lRole As Label
    Friend WithEvents pAcces As Panel
    Friend WithEvents lAccesStatistiques As Label
    Friend WithEvents lAccesGestionAdmins As Label
    Friend WithEvents lAccesGestionPreteurs As Label
    Friend WithEvents lAccesGestionEmprunteurs As Label
    Friend WithEvents lTitrePasAcces As Label
    Friend WithEvents lTitreAcces As Label
    Friend WithEvents pPasAcces As Panel
    Friend WithEvents lPasAccesGestionStats As Label
    Friend WithEvents lPasAccesGestionAdmins As Label
    Friend WithEvents pRole As Panel
    Friend WithEvents tpMessagesLabels As ToolTip
End Class
