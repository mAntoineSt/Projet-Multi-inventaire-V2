<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FicheMateriel
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FicheMateriel))
        Me.dgvFicheMat = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblFiche_Antivol = New System.Windows.Forms.Label()
        Me.lblFiche_ValResd = New System.Windows.Forms.Label()
        Me.lblFiche_CoutAcquis = New System.Windows.Forms.Label()
        Me.lblFiche_Fournisseur = New System.Windows.Forms.Label()
        Me.lblFiche_Categorie = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblFiche_NoSerie = New System.Windows.Forms.Label()
        Me.lblFiche_Fabricant = New System.Windows.Forms.Label()
        Me.lblFiche_Descript = New System.Windows.Forms.Label()
        Me.lblFiche_Marque = New System.Windows.Forms.Label()
        Me.lblFiche_Modele = New System.Windows.Forms.Label()
        Me.lblFiche_Annee = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblFiche_HeadMarque = New System.Windows.Forms.Label()
        Me.lblFiche_HeadDescript = New System.Windows.Forms.Label()
        Me.lblFiche_HeadModele = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lsbFiche_Conditions = New System.Windows.Forms.ListView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvFiche_Entretien = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvFicheMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvFiche_Entretien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFicheMat
        '
        Me.dgvFicheMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFicheMat.Location = New System.Drawing.Point(14, 33)
        Me.dgvFicheMat.Name = "dgvFicheMat"
        Me.dgvFicheMat.RowHeadersWidth = 10
        Me.dgvFicheMat.Size = New System.Drawing.Size(295, 514)
        Me.dgvFicheMat.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.23077!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.76923!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label21, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label25, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFiche_Antivol, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFiche_ValResd, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFiche_CoutAcquis, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFiche_Fournisseur, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFiche_Categorie, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label23, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label19, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label20, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label22, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label24, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFiche_NoSerie, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFiche_Fabricant, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(417, 242)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(104, 43)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Fabricant"
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(65, 111)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(103, 16)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Coût Acquisition"
        '
        'lblFiche_Antivol
        '
        Me.lblFiche_Antivol.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFiche_Antivol.AutoSize = True
        Me.lblFiche_Antivol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_Antivol.Location = New System.Drawing.Point(414, 215)
        Me.lblFiche_Antivol.Name = "lblFiche_Antivol"
        Me.lblFiche_Antivol.Size = New System.Drawing.Size(0, 16)
        Me.lblFiche_Antivol.TabIndex = 9
        '
        'lblFiche_ValResd
        '
        Me.lblFiche_ValResd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFiche_ValResd.AutoSize = True
        Me.lblFiche_ValResd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_ValResd.Location = New System.Drawing.Point(414, 145)
        Me.lblFiche_ValResd.Name = "lblFiche_ValResd"
        Me.lblFiche_ValResd.Size = New System.Drawing.Size(0, 16)
        Me.lblFiche_ValResd.TabIndex = 10
        '
        'lblFiche_CoutAcquis
        '
        Me.lblFiche_CoutAcquis.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFiche_CoutAcquis.AutoSize = True
        Me.lblFiche_CoutAcquis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_CoutAcquis.Location = New System.Drawing.Point(414, 111)
        Me.lblFiche_CoutAcquis.Name = "lblFiche_CoutAcquis"
        Me.lblFiche_CoutAcquis.Size = New System.Drawing.Size(0, 16)
        Me.lblFiche_CoutAcquis.TabIndex = 11
        '
        'lblFiche_Fournisseur
        '
        Me.lblFiche_Fournisseur.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFiche_Fournisseur.AutoSize = True
        Me.lblFiche_Fournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_Fournisseur.Location = New System.Drawing.Point(414, 77)
        Me.lblFiche_Fournisseur.Name = "lblFiche_Fournisseur"
        Me.lblFiche_Fournisseur.Size = New System.Drawing.Size(0, 16)
        Me.lblFiche_Fournisseur.TabIndex = 14
        '
        'lblFiche_Categorie
        '
        Me.lblFiche_Categorie.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFiche_Categorie.AutoSize = True
        Me.lblFiche_Categorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_Categorie.Location = New System.Drawing.Point(414, 179)
        Me.lblFiche_Categorie.Name = "lblFiche_Categorie"
        Me.lblFiche_Categorie.Size = New System.Drawing.Size(0, 16)
        Me.lblFiche_Categorie.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(90, 77)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(78, 16)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Fournisseur"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(107, 9)
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
        Me.Label20.Location = New System.Drawing.Point(53, 145)
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
        Me.Label22.Location = New System.Drawing.Point(101, 179)
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
        Me.Label24.Location = New System.Drawing.Point(99, 215)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(69, 16)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "No Antivol"
        '
        'lblFiche_NoSerie
        '
        Me.lblFiche_NoSerie.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFiche_NoSerie.AutoSize = True
        Me.lblFiche_NoSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_NoSerie.Location = New System.Drawing.Point(414, 9)
        Me.lblFiche_NoSerie.Name = "lblFiche_NoSerie"
        Me.lblFiche_NoSerie.Size = New System.Drawing.Size(0, 16)
        Me.lblFiche_NoSerie.TabIndex = 3
        '
        'lblFiche_Fabricant
        '
        Me.lblFiche_Fabricant.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFiche_Fabricant.AutoSize = True
        Me.lblFiche_Fabricant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_Fabricant.Location = New System.Drawing.Point(414, 43)
        Me.lblFiche_Fabricant.Name = "lblFiche_Fabricant"
        Me.lblFiche_Fabricant.Size = New System.Drawing.Size(0, 16)
        Me.lblFiche_Fabricant.TabIndex = 12
        '
        'lblFiche_Descript
        '
        Me.lblFiche_Descript.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFiche_Descript.AutoSize = True
        Me.lblFiche_Descript.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_Descript.Location = New System.Drawing.Point(414, 22)
        Me.lblFiche_Descript.Name = "lblFiche_Descript"
        Me.lblFiche_Descript.Size = New System.Drawing.Size(0, 16)
        Me.lblFiche_Descript.TabIndex = 2
        '
        'lblFiche_Marque
        '
        Me.lblFiche_Marque.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFiche_Marque.AutoSize = True
        Me.lblFiche_Marque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_Marque.Location = New System.Drawing.Point(414, 82)
        Me.lblFiche_Marque.Name = "lblFiche_Marque"
        Me.lblFiche_Marque.Size = New System.Drawing.Size(0, 16)
        Me.lblFiche_Marque.TabIndex = 13
        '
        'lblFiche_Modele
        '
        Me.lblFiche_Modele.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFiche_Modele.AutoSize = True
        Me.lblFiche_Modele.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_Modele.Location = New System.Drawing.Point(414, 142)
        Me.lblFiche_Modele.Name = "lblFiche_Modele"
        Me.lblFiche_Modele.Size = New System.Drawing.Size(0, 16)
        Me.lblFiche_Modele.TabIndex = 4
        '
        'lblFiche_Annee
        '
        Me.lblFiche_Annee.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFiche_Annee.AutoSize = True
        Me.lblFiche_Annee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_Annee.Location = New System.Drawing.Point(414, 203)
        Me.lblFiche_Annee.Name = "lblFiche_Annee"
        Me.lblFiche_Annee.Size = New System.Drawing.Size(0, 16)
        Me.lblFiche_Annee.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(67, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Description"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(315, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(565, 514)
        Me.Panel2.TabIndex = 5
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblFiche_HeadMarque, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblFiche_HeadDescript, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblFiche_HeadModele, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(299, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(266, 205)
        Me.TableLayoutPanel3.TabIndex = 19
        '
        'lblFiche_HeadMarque
        '
        Me.lblFiche_HeadMarque.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFiche_HeadMarque.AutoSize = True
        Me.lblFiche_HeadMarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_HeadMarque.Location = New System.Drawing.Point(3, 155)
        Me.lblFiche_HeadMarque.Name = "lblFiche_HeadMarque"
        Me.lblFiche_HeadMarque.Size = New System.Drawing.Size(260, 31)
        Me.lblFiche_HeadMarque.TabIndex = 19
        '
        'lblFiche_HeadDescript
        '
        Me.lblFiche_HeadDescript.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFiche_HeadDescript.AutoSize = True
        Me.lblFiche_HeadDescript.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_HeadDescript.Location = New System.Drawing.Point(3, 18)
        Me.lblFiche_HeadDescript.Name = "lblFiche_HeadDescript"
        Me.lblFiche_HeadDescript.Size = New System.Drawing.Size(260, 31)
        Me.lblFiche_HeadDescript.TabIndex = 0
        '
        'lblFiche_HeadModele
        '
        Me.lblFiche_HeadModele.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFiche_HeadModele.AutoSize = True
        Me.lblFiche_HeadModele.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiche_HeadModele.Location = New System.Drawing.Point(3, 86)
        Me.lblFiche_HeadModele.Name = "lblFiche_HeadModele"
        Me.lblFiche_HeadModele.Size = New System.Drawing.Size(260, 31)
        Me.lblFiche_HeadModele.TabIndex = 18
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 221)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(565, 293)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(557, 262)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Informations Générales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl2.ItemSize = New System.Drawing.Size(30, 120)
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Multiline = True
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(551, 256)
        Me.TabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl2.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage5.Location = New System.Drawing.Point(124, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(423, 248)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Page 1"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.16484!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.83516!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFiche_Descript, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFiche_Marque, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFiche_Modele, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFiche_Annee, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(417, 242)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(96, 203)
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
        Me.Label17.Location = New System.Drawing.Point(89, 142)
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
        Me.Label16.Location = New System.Drawing.Point(89, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 16)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Marque"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage6.Location = New System.Drawing.Point(124, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(423, 248)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Page 2"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lsbFiche_Conditions)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(557, 262)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Conditions d'Emprunt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lsbFiche_Conditions
        '
        Me.lsbFiche_Conditions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lsbFiche_Conditions.HideSelection = False
        Me.lsbFiche_Conditions.Location = New System.Drawing.Point(3, 6)
        Me.lsbFiche_Conditions.Name = "lsbFiche_Conditions"
        Me.lsbFiche_Conditions.Size = New System.Drawing.Size(551, 253)
        Me.lsbFiche_Conditions.TabIndex = 0
        Me.lsbFiche_Conditions.UseCompatibleStateImageBehavior = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvFiche_Entretien)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(557, 262)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Historique d'Entretien"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvFiche_Entretien
        '
        Me.dgvFiche_Entretien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiche_Entretien.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvFiche_Entretien.Location = New System.Drawing.Point(0, 1)
        Me.dgvFiche_Entretien.Name = "dgvFiche_Entretien"
        Me.dgvFiche_Entretien.Size = New System.Drawing.Size(557, 261)
        Me.dgvFiche_Entretien.TabIndex = 5
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(557, 262)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'FicheMateriel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvFicheMat)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FicheMateriel"
        Me.Size = New System.Drawing.Size(900, 600)
        CType(Me.dgvFicheMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvFiche_Entretien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvFicheMat As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label25 As Label
    Friend WithEvents lblFiche_Antivol As Label
    Friend WithEvents lblFiche_ValResd As Label
    Friend WithEvents lblFiche_CoutAcquis As Label
    Friend WithEvents lblFiche_Fournisseur As Label
    Friend WithEvents lblFiche_Categorie As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblFiche_Fabricant As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblFiche_NoSerie As Label
    Friend WithEvents lblFiche_Descript As Label
    Friend WithEvents lblFiche_Marque As Label
    Friend WithEvents lblFiche_Modele As Label
    Friend WithEvents lblFiche_Annee As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblFiche_HeadDescript As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblFiche_HeadMarque As Label
    Friend WithEvents lblFiche_HeadModele As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvFiche_Entretien As DataGridView
    Friend WithEvents lsbFiche_Conditions As ListView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
End Class
