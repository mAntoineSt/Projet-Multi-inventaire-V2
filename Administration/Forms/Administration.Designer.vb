<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administration
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pHaut = New System.Windows.Forms.Panel()
        Me.lQuitter = New System.Windows.Forms.Label()
        Me.lTitreHaut = New System.Windows.Forms.Label()
        Me.pUserControls = New System.Windows.Forms.Panel()
        Me.lStatistiques = New System.Windows.Forms.Label()
        Me.lGestionPreteurs = New System.Windows.Forms.Label()
        Me.lGestionEmprunteurs = New System.Windows.Forms.Label()
        Me.lGestionAdmins = New System.Windows.Forms.Label()
        Me.lAccueilAdministratif = New System.Windows.Forms.Label()
        Me.pBas = New System.Windows.Forms.Panel()
        Me.pHaut.SuspendLayout()
        Me.SuspendLayout()
        '
        'pHaut
        '
        Me.pHaut.Controls.Add(Me.lQuitter)
        Me.pHaut.Controls.Add(Me.lTitreHaut)
        Me.pHaut.Location = New System.Drawing.Point(0, 0)
        Me.pHaut.Name = "pHaut"
        Me.pHaut.Size = New System.Drawing.Size(1013, 28)
        Me.pHaut.TabIndex = 10
        '
        'lQuitter
        '
        Me.lQuitter.AutoSize = True
        Me.lQuitter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!)
        Me.lQuitter.ForeColor = System.Drawing.Color.White
        Me.lQuitter.Location = New System.Drawing.Point(992, 3)
        Me.lQuitter.Name = "lQuitter"
        Me.lQuitter.Size = New System.Drawing.Size(21, 22)
        Me.lQuitter.TabIndex = 1
        Me.lQuitter.Text = "X"
        '
        'lTitreHaut
        '
        Me.lTitreHaut.AutoSize = True
        Me.lTitreHaut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lTitreHaut.ForeColor = System.Drawing.Color.White
        Me.lTitreHaut.Location = New System.Drawing.Point(8, 5)
        Me.lTitreHaut.Name = "lTitreHaut"
        Me.lTitreHaut.Size = New System.Drawing.Size(154, 18)
        Me.lTitreHaut.TabIndex = 0
        Me.lTitreHaut.Text = "Menu administratif"
        '
        'pUserControls
        '
        Me.pUserControls.Location = New System.Drawing.Point(0, 70)
        Me.pUserControls.Name = "pUserControls"
        Me.pUserControls.Size = New System.Drawing.Size(1013, 473)
        Me.pUserControls.TabIndex = 9
        '
        'lStatistiques
        '
        Me.lStatistiques.AutoSize = True
        Me.lStatistiques.BackColor = System.Drawing.Color.Black
        Me.lStatistiques.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lStatistiques.ForeColor = System.Drawing.Color.White
        Me.lStatistiques.Location = New System.Drawing.Point(876, 36)
        Me.lStatistiques.Name = "lStatistiques"
        Me.lStatistiques.Padding = New System.Windows.Forms.Padding(4)
        Me.lStatistiques.Size = New System.Drawing.Size(111, 26)
        Me.lStatistiques.TabIndex = 16
        Me.lStatistiques.Text = "Statistiques"
        '
        'lGestionPreteurs
        '
        Me.lGestionPreteurs.AutoSize = True
        Me.lGestionPreteurs.BackColor = System.Drawing.Color.Black
        Me.lGestionPreteurs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lGestionPreteurs.ForeColor = System.Drawing.Color.White
        Me.lGestionPreteurs.Location = New System.Drawing.Point(685, 36)
        Me.lGestionPreteurs.Name = "lGestionPreteurs"
        Me.lGestionPreteurs.Padding = New System.Windows.Forms.Padding(4)
        Me.lGestionPreteurs.Size = New System.Drawing.Size(184, 26)
        Me.lGestionPreteurs.TabIndex = 15
        Me.lGestionPreteurs.Text = "Gestion des prêteurs"
        '
        'lGestionEmprunteurs
        '
        Me.lGestionEmprunteurs.AutoSize = True
        Me.lGestionEmprunteurs.BackColor = System.Drawing.Color.Black
        Me.lGestionEmprunteurs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lGestionEmprunteurs.ForeColor = System.Drawing.Color.White
        Me.lGestionEmprunteurs.Location = New System.Drawing.Point(460, 36)
        Me.lGestionEmprunteurs.Name = "lGestionEmprunteurs"
        Me.lGestionEmprunteurs.Padding = New System.Windows.Forms.Padding(4)
        Me.lGestionEmprunteurs.Size = New System.Drawing.Size(218, 26)
        Me.lGestionEmprunteurs.TabIndex = 14
        Me.lGestionEmprunteurs.Text = "Gestion des emprunteurs"
        '
        'lGestionAdmins
        '
        Me.lGestionAdmins.AutoSize = True
        Me.lGestionAdmins.BackColor = System.Drawing.Color.Black
        Me.lGestionAdmins.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lGestionAdmins.ForeColor = System.Drawing.Color.White
        Me.lGestionAdmins.Location = New System.Drawing.Point(212, 36)
        Me.lGestionAdmins.Name = "lGestionAdmins"
        Me.lGestionAdmins.Padding = New System.Windows.Forms.Padding(4)
        Me.lGestionAdmins.Size = New System.Drawing.Size(241, 26)
        Me.lGestionAdmins.TabIndex = 13
        Me.lGestionAdmins.Text = "Gestion des administrateurs"
        '
        'lAccueilAdministratif
        '
        Me.lAccueilAdministratif.AutoSize = True
        Me.lAccueilAdministratif.BackColor = System.Drawing.Color.Black
        Me.lAccueilAdministratif.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lAccueilAdministratif.ForeColor = System.Drawing.Color.White
        Me.lAccueilAdministratif.Location = New System.Drawing.Point(26, 36)
        Me.lAccueilAdministratif.Name = "lAccueilAdministratif"
        Me.lAccueilAdministratif.Padding = New System.Windows.Forms.Padding(4)
        Me.lAccueilAdministratif.Size = New System.Drawing.Size(179, 26)
        Me.lAccueilAdministratif.TabIndex = 12
        Me.lAccueilAdministratif.Text = "Accueil administratif"
        '
        'pBas
        '
        Me.pBas.Location = New System.Drawing.Point(0, 544)
        Me.pBas.Name = "pBas"
        Me.pBas.Size = New System.Drawing.Size(1013, 28)
        Me.pBas.TabIndex = 11
        '
        'Administration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 572)
        Me.Controls.Add(Me.pHaut)
        Me.Controls.Add(Me.pUserControls)
        Me.Controls.Add(Me.lStatistiques)
        Me.Controls.Add(Me.lGestionPreteurs)
        Me.Controls.Add(Me.lGestionEmprunteurs)
        Me.Controls.Add(Me.lGestionAdmins)
        Me.Controls.Add(Me.lAccueilAdministratif)
        Me.Controls.Add(Me.pBas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Administration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administration"
        Me.pHaut.ResumeLayout(False)
        Me.pHaut.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pHaut As Panel
    Friend WithEvents lQuitter As Label
    Friend WithEvents lTitreHaut As Label
    Friend WithEvents pUserControls As Panel
    Friend WithEvents lStatistiques As Label
    Friend WithEvents lGestionPreteurs As Label
    Friend WithEvents lGestionEmprunteurs As Label
    Friend WithEvents lGestionAdmins As Label
    Friend WithEvents lAccueilAdministratif As Label
    Friend WithEvents pBas As Panel
End Class
