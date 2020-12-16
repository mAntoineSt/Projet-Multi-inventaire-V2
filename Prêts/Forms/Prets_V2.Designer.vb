<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prets_V2
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
        Me.tbMatriculeInd = New System.Windows.Forms.TextBox()
        Me.tbIdEquip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btValiderMatricule = New System.Windows.Forms.Button()
        Me.btValiderEquip = New System.Windows.Forms.Button()
        Me.tbPrenomInd = New System.Windows.Forms.TextBox()
        Me.tbNomInd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbUsername = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbNomEquip = New System.Windows.Forms.TextBox()
        Me.tbEtatEquip = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDateRetourPrevue = New System.Windows.Forms.DateTimePicker()
        Me.btValiderPret = New System.Windows.Forms.Button()
        Me.labelDatePret = New System.Windows.Forms.Label()
        Me.dtpDatePret = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'tbMatriculeInd
        '
        Me.tbMatriculeInd.Location = New System.Drawing.Point(30, 80)
        Me.tbMatriculeInd.Name = "tbMatriculeInd"
        Me.tbMatriculeInd.Size = New System.Drawing.Size(100, 20)
        Me.tbMatriculeInd.TabIndex = 0
        '
        'tbIdEquip
        '
        Me.tbIdEquip.Location = New System.Drawing.Point(30, 161)
        Me.tbIdEquip.Name = "tbIdEquip"
        Me.tbIdEquip.Size = New System.Drawing.Size(100, 20)
        Me.tbIdEquip.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Matricule de l'emprunteur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID Équipement"
        '
        'btValiderMatricule
        '
        Me.btValiderMatricule.Location = New System.Drawing.Point(146, 80)
        Me.btValiderMatricule.Name = "btValiderMatricule"
        Me.btValiderMatricule.Size = New System.Drawing.Size(75, 20)
        Me.btValiderMatricule.TabIndex = 5
        Me.btValiderMatricule.Text = "Valider"
        Me.btValiderMatricule.UseVisualStyleBackColor = True
        '
        'btValiderEquip
        '
        Me.btValiderEquip.Location = New System.Drawing.Point(146, 161)
        Me.btValiderEquip.Name = "btValiderEquip"
        Me.btValiderEquip.Size = New System.Drawing.Size(75, 20)
        Me.btValiderEquip.TabIndex = 6
        Me.btValiderEquip.Text = "Valider"
        Me.btValiderEquip.UseVisualStyleBackColor = True
        '
        'tbPrenomInd
        '
        Me.tbPrenomInd.Location = New System.Drawing.Point(266, 81)
        Me.tbPrenomInd.Name = "tbPrenomInd"
        Me.tbPrenomInd.Size = New System.Drawing.Size(100, 20)
        Me.tbPrenomInd.TabIndex = 7
        '
        'tbNomInd
        '
        Me.tbNomInd.Location = New System.Drawing.Point(413, 81)
        Me.tbNomInd.Name = "tbNomInd"
        Me.tbNomInd.Size = New System.Drawing.Size(100, 20)
        Me.tbNomInd.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Prénom de l'empruteur"
        '
        'lbUsername
        '
        Me.lbUsername.AutoSize = True
        Me.lbUsername.Location = New System.Drawing.Point(709, 9)
        Me.lbUsername.Name = "lbUsername"
        Me.lbUsername.Size = New System.Drawing.Size(79, 13)
        Me.lbUsername.TabIndex = 10
        Me.lbUsername.Text = "Nom_utilisateur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(413, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Nom de l'emprunteur"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(263, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nom de l'équipement"
        '
        'tbNomEquip
        '
        Me.tbNomEquip.Location = New System.Drawing.Point(266, 161)
        Me.tbNomEquip.Name = "tbNomEquip"
        Me.tbNomEquip.Size = New System.Drawing.Size(100, 20)
        Me.tbNomEquip.TabIndex = 13
        '
        'tbEtatEquip
        '
        Me.tbEtatEquip.Location = New System.Drawing.Point(413, 161)
        Me.tbEtatEquip.Name = "tbEtatEquip"
        Me.tbEtatEquip.Size = New System.Drawing.Size(100, 20)
        Me.tbEtatEquip.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "État de l'équipement"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Date de retour prévue"
        '
        'dtpDateRetourPrevue
        '
        Me.dtpDateRetourPrevue.Location = New System.Drawing.Point(30, 231)
        Me.dtpDateRetourPrevue.MinDate = New Date(2020, 12, 9, 0, 0, 0, 0)
        Me.dtpDateRetourPrevue.Name = "dtpDateRetourPrevue"
        Me.dtpDateRetourPrevue.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateRetourPrevue.TabIndex = 17
        Me.dtpDateRetourPrevue.Value = New Date(2020, 12, 9, 0, 0, 0, 0)
        '
        'btValiderPret
        '
        Me.btValiderPret.Location = New System.Drawing.Point(266, 217)
        Me.btValiderPret.Name = "btValiderPret"
        Me.btValiderPret.Size = New System.Drawing.Size(247, 90)
        Me.btValiderPret.TabIndex = 18
        Me.btValiderPret.Text = "Valider le prêt"
        Me.btValiderPret.UseVisualStyleBackColor = True
        '
        'labelDatePret
        '
        Me.labelDatePret.AutoSize = True
        Me.labelDatePret.Location = New System.Drawing.Point(30, 265)
        Me.labelDatePret.Name = "labelDatePret"
        Me.labelDatePret.Size = New System.Drawing.Size(66, 13)
        Me.labelDatePret.TabIndex = 19
        Me.labelDatePret.Text = "Date de prêt"
        '
        'dtpDatePret
        '
        Me.dtpDatePret.Location = New System.Drawing.Point(30, 286)
        Me.dtpDatePret.Name = "dtpDatePret"
        Me.dtpDatePret.Size = New System.Drawing.Size(200, 20)
        Me.dtpDatePret.TabIndex = 20
        '
        'Prets_V2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtpDatePret)
        Me.Controls.Add(Me.labelDatePret)
        Me.Controls.Add(Me.btValiderPret)
        Me.Controls.Add(Me.dtpDateRetourPrevue)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbEtatEquip)
        Me.Controls.Add(Me.tbNomEquip)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNomInd)
        Me.Controls.Add(Me.tbPrenomInd)
        Me.Controls.Add(Me.btValiderEquip)
        Me.Controls.Add(Me.btValiderMatricule)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbIdEquip)
        Me.Controls.Add(Me.tbMatriculeInd)
        Me.Name = "Prets_V2"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbMatriculeInd As TextBox
    Friend WithEvents tbIdEquip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btValiderMatricule As Button
    Friend WithEvents btValiderEquip As Button
    Friend WithEvents tbPrenomInd As TextBox
    Friend WithEvents tbNomInd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbUsername As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbNomEquip As TextBox
    Friend WithEvents tbEtatEquip As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpDateRetourPrevue As DateTimePicker
    Friend WithEvents btValiderPret As Button
    Friend WithEvents labelDatePret As Label
    Friend WithEvents dtpDatePret As DateTimePicker

End Class
