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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buttonFaireEmprunt = New System.Windows.Forms.Button()
        Me.buttonFaireRetour = New System.Windows.Forms.Button()
        Me.buttonHistEmprunt = New System.Windows.Forms.Button()
        Me.buttonHistRetours = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpruntsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaireUnEmpruntToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoriqueDesEmpruntsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetoursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaireUnRetourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoriqueDesRetoursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DossiersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsulterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmprunteurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(685, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Se déconnecter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(580, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom_utilisateur"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(34, 78)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(276, 334)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Prêts en cours"
        '
        'buttonFaireEmprunt
        '
        Me.buttonFaireEmprunt.Location = New System.Drawing.Point(441, 99)
        Me.buttonFaireEmprunt.Name = "buttonFaireEmprunt"
        Me.buttonFaireEmprunt.Size = New System.Drawing.Size(232, 55)
        Me.buttonFaireEmprunt.TabIndex = 4
        Me.buttonFaireEmprunt.Text = "Faire un emprunt"
        Me.buttonFaireEmprunt.UseVisualStyleBackColor = True
        '
        'buttonFaireRetour
        '
        Me.buttonFaireRetour.Location = New System.Drawing.Point(441, 178)
        Me.buttonFaireRetour.Name = "buttonFaireRetour"
        Me.buttonFaireRetour.Size = New System.Drawing.Size(232, 55)
        Me.buttonFaireRetour.TabIndex = 5
        Me.buttonFaireRetour.Text = "Faire un retour"
        Me.buttonFaireRetour.UseVisualStyleBackColor = True
        '
        'buttonHistEmprunt
        '
        Me.buttonHistEmprunt.Location = New System.Drawing.Point(441, 258)
        Me.buttonHistEmprunt.Name = "buttonHistEmprunt"
        Me.buttonHistEmprunt.Size = New System.Drawing.Size(232, 55)
        Me.buttonHistEmprunt.TabIndex = 6
        Me.buttonHistEmprunt.Text = "Historique des emprunts"
        Me.buttonHistEmprunt.UseVisualStyleBackColor = True
        '
        'buttonHistRetours
        '
        Me.buttonHistRetours.Location = New System.Drawing.Point(441, 335)
        Me.buttonHistRetours.Name = "buttonHistRetours"
        Me.buttonHistRetours.Size = New System.Drawing.Size(232, 55)
        Me.buttonHistRetours.TabIndex = 7
        Me.buttonHistRetours.Text = "Historique des retours"
        Me.buttonHistRetours.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.EmpruntsToolStripMenuItem, Me.RetoursToolStripMenuItem, Me.DossiersToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'EmpruntsToolStripMenuItem
        '
        Me.EmpruntsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FaireUnEmpruntToolStripMenuItem, Me.HistoriqueDesEmpruntsToolStripMenuItem})
        Me.EmpruntsToolStripMenuItem.Name = "EmpruntsToolStripMenuItem"
        Me.EmpruntsToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.EmpruntsToolStripMenuItem.Text = "Emprunts"
        '
        'FaireUnEmpruntToolStripMenuItem
        '
        Me.FaireUnEmpruntToolStripMenuItem.Name = "FaireUnEmpruntToolStripMenuItem"
        Me.FaireUnEmpruntToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.FaireUnEmpruntToolStripMenuItem.Text = "Faire un emprunt"
        '
        'HistoriqueDesEmpruntsToolStripMenuItem
        '
        Me.HistoriqueDesEmpruntsToolStripMenuItem.Name = "HistoriqueDesEmpruntsToolStripMenuItem"
        Me.HistoriqueDesEmpruntsToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.HistoriqueDesEmpruntsToolStripMenuItem.Text = "Historique des emprunts"
        '
        'RetoursToolStripMenuItem
        '
        Me.RetoursToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FaireUnRetourToolStripMenuItem, Me.HistoriqueDesRetoursToolStripMenuItem})
        Me.RetoursToolStripMenuItem.Name = "RetoursToolStripMenuItem"
        Me.RetoursToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.RetoursToolStripMenuItem.Text = "Retours"
        '
        'FaireUnRetourToolStripMenuItem
        '
        Me.FaireUnRetourToolStripMenuItem.Name = "FaireUnRetourToolStripMenuItem"
        Me.FaireUnRetourToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.FaireUnRetourToolStripMenuItem.Text = "Faire un retour"
        '
        'HistoriqueDesRetoursToolStripMenuItem
        '
        Me.HistoriqueDesRetoursToolStripMenuItem.Name = "HistoriqueDesRetoursToolStripMenuItem"
        Me.HistoriqueDesRetoursToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.HistoriqueDesRetoursToolStripMenuItem.Text = "Historique des retours"
        '
        'DossiersToolStripMenuItem
        '
        Me.DossiersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsulterToolStripMenuItem})
        Me.DossiersToolStripMenuItem.Name = "DossiersToolStripMenuItem"
        Me.DossiersToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.DossiersToolStripMenuItem.Text = "Dossiers"
        '
        'ConsulterToolStripMenuItem
        '
        Me.ConsulterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmprunteurToolStripMenuItem})
        Me.ConsulterToolStripMenuItem.Name = "ConsulterToolStripMenuItem"
        Me.ConsulterToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ConsulterToolStripMenuItem.Text = "Consulter"
        '
        'EmprunteurToolStripMenuItem
        '
        Me.EmprunteurToolStripMenuItem.Name = "EmprunteurToolStripMenuItem"
        Me.EmprunteurToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.EmprunteurToolStripMenuItem.Text = "Emprunteur"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonHistRetours)
        Me.Controls.Add(Me.buttonHistEmprunt)
        Me.Controls.Add(Me.buttonFaireRetour)
        Me.Controls.Add(Me.buttonFaireEmprunt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents buttonFaireEmprunt As Button
    Friend WithEvents buttonFaireRetour As Button
    Friend WithEvents buttonHistEmprunt As Button
    Friend WithEvents buttonHistRetours As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpruntsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaireUnEmpruntToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoriqueDesEmpruntsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetoursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaireUnRetourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoriqueDesRetoursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DossiersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsulterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmprunteurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
End Class
