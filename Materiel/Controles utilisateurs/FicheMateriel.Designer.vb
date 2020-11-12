<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FicheMateriel
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtAntivol = New System.Windows.Forms.Label()
        Me.txtValResd = New System.Windows.Forms.Label()
        Me.txtCoutAcquis = New System.Windows.Forms.Label()
        Me.txtFournisseur = New System.Windows.Forms.Label()
        Me.txtCategorie = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtFabricant = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtNoSerie = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.Label()
        Me.txtMarque = New System.Windows.Forms.Label()
        Me.txtModele = New System.Windows.Forms.Label()
        Me.txtAnnee = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(58, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(284, 478)
        Me.DataGridView1.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.23077!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.76923!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label25, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAntivol, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.txtValResd, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCoutAcquis, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtFournisseur, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCategorie, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label23, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtFabricant, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label21, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label19, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label20, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label22, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label24, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNoSerie, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(156, 289)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(325, 168)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(28, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(103, 16)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Coût Acquisition"
        '
        'txtAntivol
        '
        Me.txtAntivol.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtAntivol.AutoSize = True
        Me.txtAntivol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntivol.Location = New System.Drawing.Point(253, 148)
        Me.txtAntivol.Name = "txtAntivol"
        Me.txtAntivol.Size = New System.Drawing.Size(69, 16)
        Me.txtAntivol.TabIndex = 9
        Me.txtAntivol.Text = "Glct 65789"
        '
        'txtValResd
        '
        Me.txtValResd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtValResd.AutoSize = True
        Me.txtValResd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValResd.Location = New System.Drawing.Point(276, 100)
        Me.txtValResd.Name = "txtValResd"
        Me.txtValResd.Size = New System.Drawing.Size(46, 16)
        Me.txtValResd.TabIndex = 10
        Me.txtValResd.Text = "90.00$"
        '
        'txtCoutAcquis
        '
        Me.txtCoutAcquis.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtCoutAcquis.AutoSize = True
        Me.txtCoutAcquis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoutAcquis.Location = New System.Drawing.Point(269, 76)
        Me.txtCoutAcquis.Name = "txtCoutAcquis"
        Me.txtCoutAcquis.Size = New System.Drawing.Size(53, 16)
        Me.txtCoutAcquis.TabIndex = 11
        Me.txtCoutAcquis.Text = "130.00$"
        '
        'txtFournisseur
        '
        Me.txtFournisseur.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtFournisseur.AutoSize = True
        Me.txtFournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFournisseur.Location = New System.Drawing.Point(247, 52)
        Me.txtFournisseur.Name = "txtFournisseur"
        Me.txtFournisseur.Size = New System.Drawing.Size(75, 16)
        Me.txtFournisseur.TabIndex = 14
        Me.txtFournisseur.Text = "Électrotech"
        '
        'txtCategorie
        '
        Me.txtCategorie.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtCategorie.AutoSize = True
        Me.txtCategorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategorie.Location = New System.Drawing.Point(230, 124)
        Me.txtCategorie.Name = "txtCategorie"
        Me.txtCategorie.Size = New System.Drawing.Size(92, 16)
        Me.txtCategorie.TabIndex = 5
        Me.txtCategorie.Text = "Périphériques"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(53, 52)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(78, 16)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Fournisseur"
        '
        'txtFabricant
        '
        Me.txtFabricant.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtFabricant.AutoSize = True
        Me.txtFabricant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFabricant.Location = New System.Drawing.Point(263, 28)
        Me.txtFabricant.Name = "txtFabricant"
        Me.txtFabricant.Size = New System.Drawing.Size(59, 16)
        Me.txtFabricant.TabIndex = 12
        Me.txtFabricant.Text = "Logitech"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(67, 28)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Fabricant"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(70, 4)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "No Série"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 100)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 16)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Valeur Résiduelle"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(64, 124)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 16)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Catégorie"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(62, 148)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(69, 16)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "No Antivol"
        '
        'txtNoSerie
        '
        Me.txtNoSerie.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtNoSerie.AutoSize = True
        Me.txtNoSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSerie.Location = New System.Drawing.Point(230, 4)
        Me.txtNoSerie.Name = "txtNoSerie"
        Me.txtNoSerie.Size = New System.Drawing.Size(92, 16)
        Me.txtNoSerie.TabIndex = 3
        Me.txtNoSerie.Text = "558698748948"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtDescription.AutoSize = True
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(220, 9)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(50, 16)
        Me.txtDescription.TabIndex = 2
        Me.txtDescription.Text = "Clavier"
        '
        'txtMarque
        '
        Me.txtMarque.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtMarque.AutoSize = True
        Me.txtMarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarque.Location = New System.Drawing.Point(211, 43)
        Me.txtMarque.Name = "txtMarque"
        Me.txtMarque.Size = New System.Drawing.Size(59, 16)
        Me.txtMarque.TabIndex = 13
        Me.txtMarque.Text = "Logitech"
        '
        'txtModele
        '
        Me.txtModele.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtModele.AutoSize = True
        Me.txtModele.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModele.Location = New System.Drawing.Point(136, 77)
        Me.txtModele.Name = "txtModele"
        Me.txtModele.Size = New System.Drawing.Size(134, 16)
        Me.txtModele.TabIndex = 4
        Me.txtModele.Text = "G910 Orion Spectrum"
        '
        'txtAnnee
        '
        Me.txtAnnee.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtAnnee.AutoSize = True
        Me.txtAnnee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnnee.Location = New System.Drawing.Point(234, 111)
        Me.txtAnnee.Name = "txtAnnee"
        Me.txtAnnee.Size = New System.Drawing.Size(36, 16)
        Me.txtAnnee.TabIndex = 6
        Me.txtAnnee.Text = "2019"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Description"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Location = New System.Drawing.Point(348, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(494, 478)
        Me.Panel2.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matériel"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.16484!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.83517!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDescription, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMarque, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtModele, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAnnee, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(208, 81)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(273, 136)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(46, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Année"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(39, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Modèle"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(39, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 16)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Marque"
        '
        'FicheMateriel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FicheMateriel"
        Me.Size = New System.Drawing.Size(900, 600)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label25 As Label
    Friend WithEvents txtAntivol As Label
    Friend WithEvents txtValResd As Label
    Friend WithEvents txtCoutAcquis As Label
    Friend WithEvents txtFournisseur As Label
    Friend WithEvents txtCategorie As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtFabricant As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtNoSerie As Label
    Friend WithEvents txtDescription As Label
    Friend WithEvents txtMarque As Label
    Friend WithEvents txtModele As Label
    Friend WithEvents txtAnnee As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
End Class
