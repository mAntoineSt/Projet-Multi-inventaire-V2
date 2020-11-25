<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetourAjout
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dateRetour = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dateEmprunt = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SauvegarderBtn = New System.Windows.Forms.Button()
        Me.indPrenomTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.equipDescEtatTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.indNomTb = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.IdTb = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RechercheTB = New System.Windows.Forms.TextBox()
        Me.EquipmentDGV = New System.Windows.Forms.DataGridView()
        Me.IdRechercheBt = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EquipmentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Description de l'état"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dateRetour)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.dateEmprunt)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(258, 274)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 140)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dates"
        '
        'dateRetour
        '
        Me.dateRetour.Location = New System.Drawing.Point(6, 82)
        Me.dateRetour.Name = "dateRetour"
        Me.dateRetour.Size = New System.Drawing.Size(191, 20)
        Me.dateRetour.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Date retour initiale"
        '
        'dateEmprunt
        '
        Me.dateEmprunt.Location = New System.Drawing.Point(6, 43)
        Me.dateEmprunt.Name = "dateEmprunt"
        Me.dateEmprunt.Size = New System.Drawing.Size(191, 20)
        Me.dateEmprunt.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Retourné le"
        '
        'SauvegarderBtn
        '
        Me.SauvegarderBtn.Location = New System.Drawing.Point(467, 366)
        Me.SauvegarderBtn.Name = "SauvegarderBtn"
        Me.SauvegarderBtn.Size = New System.Drawing.Size(239, 48)
        Me.SauvegarderBtn.TabIndex = 10
        Me.SauvegarderBtn.Text = "Sauvegarder"
        Me.SauvegarderBtn.UseVisualStyleBackColor = True
        '
        'indPrenomTb
        '
        Me.indPrenomTb.Location = New System.Drawing.Point(5, 77)
        Me.indPrenomTb.Name = "indPrenomTb"
        Me.indPrenomTb.Size = New System.Drawing.Size(224, 20)
        Me.indPrenomTb.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom"
        '
        'equipDescEtatTb
        '
        Me.equipDescEtatTb.Location = New System.Drawing.Point(5, 87)
        Me.equipDescEtatTb.Multiline = True
        Me.equipDescEtatTb.Name = "equipDescEtatTb"
        Me.equipDescEtatTb.Size = New System.Drawing.Size(192, 60)
        Me.equipDescEtatTb.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Prenom"
        '
        'indNomTb
        '
        Me.indNomTb.Location = New System.Drawing.Point(5, 35)
        Me.indNomTb.Name = "indNomTb"
        Me.indNomTb.Size = New System.Drawing.Size(224, 20)
        Me.indNomTb.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "ID"
        '
        'IdTb
        '
        Me.IdTb.Location = New System.Drawing.Point(5, 35)
        Me.IdTb.Name = "IdTb"
        Me.IdTb.Size = New System.Drawing.Size(192, 20)
        Me.IdTb.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.IdTb)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.equipDescEtatTb)
        Me.GroupBox2.Location = New System.Drawing.Point(258, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(203, 265)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Equipement"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(95, 159)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Retard constaté"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IdRechercheBt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.indPrenomTb)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.indNomTb)
        Me.GroupBox1.Location = New System.Drawing.Point(467, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 357)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Individu"
        '
        'RechercheTB
        '
        Me.RechercheTB.Location = New System.Drawing.Point(7, 3)
        Me.RechercheTB.Name = "RechercheTB"
        Me.RechercheTB.Size = New System.Drawing.Size(245, 20)
        Me.RechercheTB.TabIndex = 7
        '
        'EquipmentDGV
        '
        Me.EquipmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EquipmentDGV.Location = New System.Drawing.Point(7, 29)
        Me.EquipmentDGV.Name = "EquipmentDGV"
        Me.EquipmentDGV.Size = New System.Drawing.Size(245, 385)
        Me.EquipmentDGV.TabIndex = 6
        '
        'IdRechercheBt
        '
        Me.IdRechercheBt.Location = New System.Drawing.Point(5, 117)
        Me.IdRechercheBt.Name = "IdRechercheBt"
        Me.IdRechercheBt.Size = New System.Drawing.Size(224, 70)
        Me.IdRechercheBt.TabIndex = 4
        Me.IdRechercheBt.Text = "Sélectionner l'individu"
        Me.IdRechercheBt.UseVisualStyleBackColor = True
        '
        'RetourAjout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.SauvegarderBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RechercheTB)
        Me.Controls.Add(Me.EquipmentDGV)
        Me.Name = "RetourAjout"
        Me.Size = New System.Drawing.Size(713, 417)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EquipmentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dateRetour As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents dateEmprunt As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents SauvegarderBtn As Button
    Friend WithEvents indPrenomTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents equipDescEtatTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents indNomTb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents IdTb As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RechercheTB As TextBox
    Friend WithEvents EquipmentDGV As DataGridView
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IdRechercheBt As Button
End Class
