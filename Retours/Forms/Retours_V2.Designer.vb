<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retours_V2
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
        Me.lbNomUtilisateur = New System.Windows.Forms.Label()
        Me.lbMatriculeEmp = New System.Windows.Forms.Label()
        Me.lbPrenom = New System.Windows.Forms.Label()
        Me.lbNomEmp = New System.Windows.Forms.Label()
        Me.tbMatriculeInd = New System.Windows.Forms.TextBox()
        Me.tbPrenomInd = New System.Windows.Forms.TextBox()
        Me.tbNomInd = New System.Windows.Forms.TextBox()
        Me.lbIdEquip = New System.Windows.Forms.Label()
        Me.lbNomEquip = New System.Windows.Forms.Label()
        Me.lbEtatEquip = New System.Windows.Forms.Label()
        Me.lbDateRetour = New System.Windows.Forms.Label()
        Me.tbIdEquip = New System.Windows.Forms.TextBox()
        Me.tbNomEquip = New System.Windows.Forms.TextBox()
        Me.cbEtatEquip = New System.Windows.Forms.ComboBox()
        Me.btValiderEmp = New System.Windows.Forms.Button()
        Me.btValiderEquip = New System.Windows.Forms.Button()
        Me.lbDateRetourPrevue = New System.Windows.Forms.Label()
        Me.btValiderRetour = New System.Windows.Forms.Button()
        Me.dtpDateRetourPrevue = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateRetour = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lbNomUtilisateur
        '
        Me.lbNomUtilisateur.AutoSize = True
        Me.lbNomUtilisateur.Location = New System.Drawing.Point(681, 24)
        Me.lbNomUtilisateur.Name = "lbNomUtilisateur"
        Me.lbNomUtilisateur.Size = New System.Drawing.Size(79, 13)
        Me.lbNomUtilisateur.TabIndex = 0
        Me.lbNomUtilisateur.Text = "Nom_utilisateur"
        '
        'lbMatriculeEmp
        '
        Me.lbMatriculeEmp.AutoSize = True
        Me.lbMatriculeEmp.Location = New System.Drawing.Point(22, 60)
        Me.lbMatriculeEmp.Name = "lbMatriculeEmp"
        Me.lbMatriculeEmp.Size = New System.Drawing.Size(125, 13)
        Me.lbMatriculeEmp.TabIndex = 1
        Me.lbMatriculeEmp.Text = "Matricule de l'emprunteur"
        '
        'lbPrenom
        '
        Me.lbPrenom.AutoSize = True
        Me.lbPrenom.Location = New System.Drawing.Point(292, 60)
        Me.lbPrenom.Name = "lbPrenom"
        Me.lbPrenom.Size = New System.Drawing.Size(43, 13)
        Me.lbPrenom.TabIndex = 2
        Me.lbPrenom.Text = "Prénom"
        '
        'lbNomEmp
        '
        Me.lbNomEmp.AutoSize = True
        Me.lbNomEmp.Location = New System.Drawing.Point(474, 60)
        Me.lbNomEmp.Name = "lbNomEmp"
        Me.lbNomEmp.Size = New System.Drawing.Size(29, 13)
        Me.lbNomEmp.TabIndex = 3
        Me.lbNomEmp.Text = "Nom"
        '
        'tbMatriculeInd
        '
        Me.tbMatriculeInd.Location = New System.Drawing.Point(25, 88)
        Me.tbMatriculeInd.Name = "tbMatriculeInd"
        Me.tbMatriculeInd.Size = New System.Drawing.Size(100, 20)
        Me.tbMatriculeInd.TabIndex = 4
        '
        'tbPrenomInd
        '
        Me.tbPrenomInd.Enabled = False
        Me.tbPrenomInd.Location = New System.Drawing.Point(295, 88)
        Me.tbPrenomInd.Name = "tbPrenomInd"
        Me.tbPrenomInd.Size = New System.Drawing.Size(121, 20)
        Me.tbPrenomInd.TabIndex = 5
        '
        'tbNomInd
        '
        Me.tbNomInd.Enabled = False
        Me.tbNomInd.Location = New System.Drawing.Point(477, 88)
        Me.tbNomInd.Name = "tbNomInd"
        Me.tbNomInd.Size = New System.Drawing.Size(121, 20)
        Me.tbNomInd.TabIndex = 6
        '
        'lbIdEquip
        '
        Me.lbIdEquip.AutoSize = True
        Me.lbIdEquip.Location = New System.Drawing.Point(22, 129)
        Me.lbIdEquip.Name = "lbIdEquip"
        Me.lbIdEquip.Size = New System.Drawing.Size(77, 13)
        Me.lbIdEquip.TabIndex = 7
        Me.lbIdEquip.Text = "ID Equipement"
        '
        'lbNomEquip
        '
        Me.lbNomEquip.AutoSize = True
        Me.lbNomEquip.Location = New System.Drawing.Point(292, 129)
        Me.lbNomEquip.Name = "lbNomEquip"
        Me.lbNomEquip.Size = New System.Drawing.Size(29, 13)
        Me.lbNomEquip.TabIndex = 8
        Me.lbNomEquip.Text = "Nom"
        '
        'lbEtatEquip
        '
        Me.lbEtatEquip.AutoSize = True
        Me.lbEtatEquip.Location = New System.Drawing.Point(474, 129)
        Me.lbEtatEquip.Name = "lbEtatEquip"
        Me.lbEtatEquip.Size = New System.Drawing.Size(133, 13)
        Me.lbEtatEquip.TabIndex = 9
        Me.lbEtatEquip.Text = "État de l'équipement rendu"
        '
        'lbDateRetour
        '
        Me.lbDateRetour.AutoSize = True
        Me.lbDateRetour.Location = New System.Drawing.Point(22, 211)
        Me.lbDateRetour.Name = "lbDateRetour"
        Me.lbDateRetour.Size = New System.Drawing.Size(75, 13)
        Me.lbDateRetour.TabIndex = 10
        Me.lbDateRetour.Text = "Date de retour"
        '
        'tbIdEquip
        '
        Me.tbIdEquip.Location = New System.Drawing.Point(25, 160)
        Me.tbIdEquip.Name = "tbIdEquip"
        Me.tbIdEquip.Size = New System.Drawing.Size(100, 20)
        Me.tbIdEquip.TabIndex = 11
        '
        'tbNomEquip
        '
        Me.tbNomEquip.Enabled = False
        Me.tbNomEquip.Location = New System.Drawing.Point(295, 160)
        Me.tbNomEquip.Name = "tbNomEquip"
        Me.tbNomEquip.Size = New System.Drawing.Size(121, 20)
        Me.tbNomEquip.TabIndex = 12
        '
        'cbEtatEquip
        '
        Me.cbEtatEquip.FormattingEnabled = True
        Me.cbEtatEquip.Items.AddRange(New Object() {"fonctionnel", "brisé", "manquant", "partie(s) manquante(s)", "défectueux"})
        Me.cbEtatEquip.Location = New System.Drawing.Point(477, 159)
        Me.cbEtatEquip.Name = "cbEtatEquip"
        Me.cbEtatEquip.Size = New System.Drawing.Size(121, 21)
        Me.cbEtatEquip.TabIndex = 13
        '
        'btValiderEmp
        '
        Me.btValiderEmp.Location = New System.Drawing.Point(141, 88)
        Me.btValiderEmp.Name = "btValiderEmp"
        Me.btValiderEmp.Size = New System.Drawing.Size(75, 23)
        Me.btValiderEmp.TabIndex = 14
        Me.btValiderEmp.Text = "Valider"
        Me.btValiderEmp.UseVisualStyleBackColor = True
        '
        'btValiderEquip
        '
        Me.btValiderEquip.Location = New System.Drawing.Point(141, 160)
        Me.btValiderEquip.Name = "btValiderEquip"
        Me.btValiderEquip.Size = New System.Drawing.Size(75, 23)
        Me.btValiderEquip.TabIndex = 15
        Me.btValiderEquip.Text = "Valider"
        Me.btValiderEquip.UseVisualStyleBackColor = True
        '
        'lbDateRetourPrevue
        '
        Me.lbDateRetourPrevue.AutoSize = True
        Me.lbDateRetourPrevue.Location = New System.Drawing.Point(22, 263)
        Me.lbDateRetourPrevue.Name = "lbDateRetourPrevue"
        Me.lbDateRetourPrevue.Size = New System.Drawing.Size(111, 13)
        Me.lbDateRetourPrevue.TabIndex = 17
        Me.lbDateRetourPrevue.Text = "Date de retour prévue"
        '
        'btValiderRetour
        '
        Me.btValiderRetour.Location = New System.Drawing.Point(295, 211)
        Me.btValiderRetour.Name = "btValiderRetour"
        Me.btValiderRetour.Size = New System.Drawing.Size(303, 89)
        Me.btValiderRetour.TabIndex = 19
        Me.btValiderRetour.Text = "Valider le retour"
        Me.btValiderRetour.UseVisualStyleBackColor = True
        '
        'dtpDateRetourPrevue
        '
        Me.dtpDateRetourPrevue.Location = New System.Drawing.Point(25, 279)
        Me.dtpDateRetourPrevue.MinDate = New Date(2020, 2, 1, 0, 0, 0, 0)
        Me.dtpDateRetourPrevue.Name = "dtpDateRetourPrevue"
        Me.dtpDateRetourPrevue.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateRetourPrevue.TabIndex = 20
        '
        'dtpDateRetour
        '
        Me.dtpDateRetour.Enabled = False
        Me.dtpDateRetour.Location = New System.Drawing.Point(25, 228)
        Me.dtpDateRetour.Name = "dtpDateRetour"
        Me.dtpDateRetour.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateRetour.TabIndex = 21
        '
        'Retours_V2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtpDateRetour)
        Me.Controls.Add(Me.dtpDateRetourPrevue)
        Me.Controls.Add(Me.btValiderRetour)
        Me.Controls.Add(Me.lbDateRetourPrevue)
        Me.Controls.Add(Me.btValiderEquip)
        Me.Controls.Add(Me.btValiderEmp)
        Me.Controls.Add(Me.cbEtatEquip)
        Me.Controls.Add(Me.tbNomEquip)
        Me.Controls.Add(Me.tbIdEquip)
        Me.Controls.Add(Me.lbDateRetour)
        Me.Controls.Add(Me.lbEtatEquip)
        Me.Controls.Add(Me.lbNomEquip)
        Me.Controls.Add(Me.lbIdEquip)
        Me.Controls.Add(Me.tbNomInd)
        Me.Controls.Add(Me.tbPrenomInd)
        Me.Controls.Add(Me.tbMatriculeInd)
        Me.Controls.Add(Me.lbNomEmp)
        Me.Controls.Add(Me.lbPrenom)
        Me.Controls.Add(Me.lbMatriculeEmp)
        Me.Controls.Add(Me.lbNomUtilisateur)
        Me.Name = "Retours_V2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNomUtilisateur As Label
    Friend WithEvents lbMatriculeEmp As Label
    Friend WithEvents lbPrenom As Label
    Friend WithEvents lbNomEmp As Label
    Friend WithEvents tbMatriculeInd As TextBox
    Friend WithEvents tbPrenomInd As TextBox
    Friend WithEvents tbNomInd As TextBox
    Friend WithEvents lbIdEquip As Label
    Friend WithEvents lbNomEquip As Label
    Friend WithEvents lbEtatEquip As Label
    Friend WithEvents lbDateRetour As Label
    Friend WithEvents tbIdEquip As TextBox
    Friend WithEvents tbNomEquip As TextBox
    Friend WithEvents cbEtatEquip As ComboBox
    Friend WithEvents btValiderEmp As Button
    Friend WithEvents btValiderEquip As Button
    Friend WithEvents lbDateRetourPrevue As Label
    Friend WithEvents btValiderRetour As Button
    Friend WithEvents dtpDateRetourPrevue As DateTimePicker
    Friend WithEvents dtpDateRetour As DateTimePicker
End Class
