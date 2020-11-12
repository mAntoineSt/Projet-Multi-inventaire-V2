<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PretAjout
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
        Me.EquipmentDGV = New System.Windows.Forms.DataGridView()
        Me.RechercheTB = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.indCourrielTb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.indTelephoneTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.indDepartementTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.indAddresseTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.indPrenomTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.indNomTb = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.IdTb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.equipCatTb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.equipDescTb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.equipNomTb = New System.Windows.Forms.TextBox()
        Me.CustomInstaller1 = New MySql.Data.MySqlClient.CustomInstaller()
        Me.SauvegarderBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dateEmprunt = New System.Windows.Forms.DateTimePicker()
        Me.dateRetour = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.EquipmentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'EquipmentDGV
        '
        Me.EquipmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EquipmentDGV.Location = New System.Drawing.Point(3, 29)
        Me.EquipmentDGV.Name = "EquipmentDGV"
        Me.EquipmentDGV.Size = New System.Drawing.Size(245, 385)
        Me.EquipmentDGV.TabIndex = 0
        '
        'RechercheTB
        '
        Me.RechercheTB.Location = New System.Drawing.Point(3, 3)
        Me.RechercheTB.Name = "RechercheTB"
        Me.RechercheTB.Size = New System.Drawing.Size(245, 20)
        Me.RechercheTB.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.indCourrielTb)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.indTelephoneTb)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.indDepartementTb)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.indAddresseTb)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.indPrenomTb)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.indNomTb)
        Me.GroupBox1.Location = New System.Drawing.Point(463, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 357)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Individu"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Courriel"
        '
        'indCourrielTb
        '
        Me.indCourrielTb.Location = New System.Drawing.Point(5, 245)
        Me.indCourrielTb.Name = "indCourrielTb"
        Me.indCourrielTb.Size = New System.Drawing.Size(224, 20)
        Me.indCourrielTb.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Telephone"
        '
        'indTelephoneTb
        '
        Me.indTelephoneTb.Location = New System.Drawing.Point(5, 203)
        Me.indTelephoneTb.Name = "indTelephoneTb"
        Me.indTelephoneTb.Size = New System.Drawing.Size(224, 20)
        Me.indTelephoneTb.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Departement"
        '
        'indDepartementTb
        '
        Me.indDepartementTb.Location = New System.Drawing.Point(5, 161)
        Me.indDepartementTb.Name = "indDepartementTb"
        Me.indDepartementTb.Size = New System.Drawing.Size(224, 20)
        Me.indDepartementTb.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Addresse"
        '
        'indAddresseTb
        '
        Me.indAddresseTb.Location = New System.Drawing.Point(5, 119)
        Me.indAddresseTb.Name = "indAddresseTb"
        Me.indAddresseTb.Size = New System.Drawing.Size(224, 20)
        Me.indAddresseTb.TabIndex = 4
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
        'indNomTb
        '
        Me.indNomTb.Location = New System.Drawing.Point(5, 35)
        Me.indNomTb.Name = "indNomTb"
        Me.indNomTb.Size = New System.Drawing.Size(224, 20)
        Me.indNomTb.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.IdTb)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.equipCatTb)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.equipDescTb)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.equipNomTb)
        Me.GroupBox2.Location = New System.Drawing.Point(254, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(203, 265)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Equipement"
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Categorie"
        '
        'equipCatTb
        '
        Me.equipCatTb.Location = New System.Drawing.Point(5, 201)
        Me.equipCatTb.Name = "equipCatTb"
        Me.equipCatTb.Size = New System.Drawing.Size(192, 20)
        Me.equipCatTb.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Description"
        '
        'equipDescTb
        '
        Me.equipDescTb.Location = New System.Drawing.Point(5, 119)
        Me.equipDescTb.Multiline = True
        Me.equipDescTb.Name = "equipDescTb"
        Me.equipDescTb.Size = New System.Drawing.Size(192, 60)
        Me.equipDescTb.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nom"
        '
        'equipNomTb
        '
        Me.equipNomTb.Location = New System.Drawing.Point(5, 77)
        Me.equipNomTb.Name = "equipNomTb"
        Me.equipNomTb.Size = New System.Drawing.Size(192, 20)
        Me.equipNomTb.TabIndex = 2
        '
        'SauvegarderBtn
        '
        Me.SauvegarderBtn.Location = New System.Drawing.Point(463, 366)
        Me.SauvegarderBtn.Name = "SauvegarderBtn"
        Me.SauvegarderBtn.Size = New System.Drawing.Size(239, 48)
        Me.SauvegarderBtn.TabIndex = 4
        Me.SauvegarderBtn.Text = "Sauvegarder"
        Me.SauvegarderBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dateRetour)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.dateEmprunt)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(254, 274)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 140)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dates"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Date emprunt"
        '
        'dateEmprunt
        '
        Me.dateEmprunt.Location = New System.Drawing.Point(6, 43)
        Me.dateEmprunt.Name = "dateEmprunt"
        Me.dateEmprunt.Size = New System.Drawing.Size(191, 20)
        Me.dateEmprunt.TabIndex = 12
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
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Date retour"
        '
        'PretAjout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.SauvegarderBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RechercheTB)
        Me.Controls.Add(Me.EquipmentDGV)
        Me.Name = "PretAjout"
        Me.Size = New System.Drawing.Size(713, 417)
        CType(Me.EquipmentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EquipmentDGV As DataGridView
    Friend WithEvents RechercheTB As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents indNomTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents indAddresseTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents indPrenomTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents indDepartementTb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents indCourrielTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents indTelephoneTb As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents equipNomTb As TextBox
    Friend WithEvents CustomInstaller1 As MySql.Data.MySqlClient.CustomInstaller
    Friend WithEvents Label8 As Label
    Friend WithEvents equipDescTb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents equipCatTb As TextBox
    Friend WithEvents SauvegarderBtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents IdTb As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dateRetour As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents dateEmprunt As DateTimePicker

End Class
