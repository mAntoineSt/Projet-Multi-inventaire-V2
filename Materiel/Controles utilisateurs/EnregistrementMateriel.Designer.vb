<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EnregistrementMateriel
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEnrMat_NoAntivol = New System.Windows.Forms.TextBox()
        Me.txtEnrMat_Valeur = New System.Windows.Forms.TextBox()
        Me.txtEnrMat_CoutAchat = New System.Windows.Forms.TextBox()
        Me.txtEnrMat_Fabricant = New System.Windows.Forms.TextBox()
        Me.txtEnrMat_NoSerie = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboEnrMat_Categorie = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEnrMat_Modele = New System.Windows.Forms.TextBox()
        Me.txtEnrMat_Marque = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEnrMat_DateFabrict = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rtxEnrMat_Notes = New System.Windows.Forms.RichTextBox()
        Me.txtEnrMat_Fournisseur = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEnrMat_Modif = New System.Windows.Forms.Button()
        Me.btnEnrMat_Ajout = New System.Windows.Forms.Button()
        Me.btnEnrMat_Annuler = New System.Windows.Forms.Button()
        Me.dgvEnrMat = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbcEnrMat = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpEnrMat_DateAcquis = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEnrMat_Photo = New System.Windows.Forms.Button()
        Me.lblEnrMat_UrlPhoto = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dgvEnrMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.tbcEnrMat.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(0, 305)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(161, 17)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Photo"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEnrMat_NoAntivol
        '
        Me.txtEnrMat_NoAntivol.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnrMat_NoAntivol.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnrMat_NoAntivol.Location = New System.Drawing.Point(164, 248)
        Me.txtEnrMat_NoAntivol.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.txtEnrMat_NoAntivol.Name = "txtEnrMat_NoAntivol"
        Me.txtEnrMat_NoAntivol.Size = New System.Drawing.Size(301, 24)
        Me.txtEnrMat_NoAntivol.TabIndex = 8
        '
        'txtEnrMat_Valeur
        '
        Me.txtEnrMat_Valeur.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnrMat_Valeur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnrMat_Valeur.Location = New System.Drawing.Point(164, 191)
        Me.txtEnrMat_Valeur.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.txtEnrMat_Valeur.Name = "txtEnrMat_Valeur"
        Me.txtEnrMat_Valeur.Size = New System.Drawing.Size(301, 24)
        Me.txtEnrMat_Valeur.TabIndex = 8
        '
        'txtEnrMat_CoutAchat
        '
        Me.txtEnrMat_CoutAchat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnrMat_CoutAchat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnrMat_CoutAchat.Location = New System.Drawing.Point(164, 134)
        Me.txtEnrMat_CoutAchat.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.txtEnrMat_CoutAchat.Name = "txtEnrMat_CoutAchat"
        Me.txtEnrMat_CoutAchat.Size = New System.Drawing.Size(301, 24)
        Me.txtEnrMat_CoutAchat.TabIndex = 8
        '
        'txtEnrMat_Fabricant
        '
        Me.txtEnrMat_Fabricant.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnrMat_Fabricant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnrMat_Fabricant.Location = New System.Drawing.Point(161, 180)
        Me.txtEnrMat_Fabricant.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEnrMat_Fabricant.Name = "txtEnrMat_Fabricant"
        Me.txtEnrMat_Fabricant.Size = New System.Drawing.Size(307, 24)
        Me.txtEnrMat_Fabricant.TabIndex = 11
        '
        'txtEnrMat_NoSerie
        '
        Me.txtEnrMat_NoSerie.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnrMat_NoSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnrMat_NoSerie.Location = New System.Drawing.Point(161, 125)
        Me.txtEnrMat_NoSerie.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEnrMat_NoSerie.Name = "txtEnrMat_NoSerie"
        Me.txtEnrMat_NoSerie.Size = New System.Drawing.Size(307, 24)
        Me.txtEnrMat_NoSerie.TabIndex = 10
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.44444!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.55556!))
        Me.TableLayoutPanel1.Controls.Add(Me.cboEnrMat_Categorie, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEnrMat_Fabricant, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEnrMat_NoSerie, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEnrMat_Modele, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEnrMat_Marque, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpEnrMat_DateFabrict, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.27027!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.27027!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.27027!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.27027!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.27027!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.64865!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(468, 343)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'cboEnrMat_Categorie
        '
        Me.cboEnrMat_Categorie.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEnrMat_Categorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnrMat_Categorie.FormattingEnabled = True
        Me.cboEnrMat_Categorie.Location = New System.Drawing.Point(161, 296)
        Me.cboEnrMat_Categorie.Margin = New System.Windows.Forms.Padding(0)
        Me.cboEnrMat_Categorie.Name = "cboEnrMat_Categorie"
        Me.cboEnrMat_Categorie.Size = New System.Drawing.Size(307, 26)
        Me.cboEnrMat_Categorie.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 300)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Catégorie"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEnrMat_Modele
        '
        Me.txtEnrMat_Modele.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnrMat_Modele.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnrMat_Modele.Location = New System.Drawing.Point(161, 70)
        Me.txtEnrMat_Modele.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEnrMat_Modele.Name = "txtEnrMat_Modele"
        Me.txtEnrMat_Modele.Size = New System.Drawing.Size(307, 24)
        Me.txtEnrMat_Modele.TabIndex = 9
        '
        'txtEnrMat_Marque
        '
        Me.txtEnrMat_Marque.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnrMat_Marque.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnrMat_Marque.Location = New System.Drawing.Point(161, 15)
        Me.txtEnrMat_Marque.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEnrMat_Marque.Name = "txtEnrMat_Marque"
        Me.txtEnrMat_Marque.Size = New System.Drawing.Size(307, 24)
        Me.txtEnrMat_Marque.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 129)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "No Série"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 74)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Modèle"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Marque"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fabricant"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 239)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Année de Fabrication"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpEnrMat_DateFabrict
        '
        Me.dtpEnrMat_DateFabrict.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpEnrMat_DateFabrict.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnrMat_DateFabrict.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnrMat_DateFabrict.Location = New System.Drawing.Point(161, 235)
        Me.dtpEnrMat_DateFabrict.Margin = New System.Windows.Forms.Padding(0)
        Me.dtpEnrMat_DateFabrict.Name = "dtpEnrMat_DateFabrict"
        Me.dtpEnrMat_DateFabrict.Size = New System.Drawing.Size(307, 24)
        Me.dtpEnrMat_DateFabrict.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 19)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(254, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Informations Complémentaires"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtxEnrMat_Notes
        '
        Me.rtxEnrMat_Notes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxEnrMat_Notes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxEnrMat_Notes.Location = New System.Drawing.Point(3, 52)
        Me.rtxEnrMat_Notes.Name = "rtxEnrMat_Notes"
        Me.rtxEnrMat_Notes.Size = New System.Drawing.Size(462, 285)
        Me.rtxEnrMat_Notes.TabIndex = 13
        Me.rtxEnrMat_Notes.Text = ""
        '
        'txtEnrMat_Fournisseur
        '
        Me.txtEnrMat_Fournisseur.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnrMat_Fournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnrMat_Fournisseur.Location = New System.Drawing.Point(164, 20)
        Me.txtEnrMat_Fournisseur.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.txtEnrMat_Fournisseur.Name = "txtEnrMat_Fournisseur"
        Me.txtEnrMat_Fournisseur.Size = New System.Drawing.Size(301, 24)
        Me.txtEnrMat_Fournisseur.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel1.Controls.Add(Me.dgvEnrMat)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 600)
        Me.Panel1.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.44641!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.830388!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.44641!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.830388!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.44641!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnEnrMat_Modif, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnEnrMat_Ajout, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnEnrMat_Annuler, 4, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(400, 487)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(480, 60)
        Me.TableLayoutPanel4.TabIndex = 9
        '
        'btnEnrMat_Modif
        '
        Me.btnEnrMat_Modif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnrMat_Modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrMat_Modif.Location = New System.Drawing.Point(20, 10)
        Me.btnEnrMat_Modif.Margin = New System.Windows.Forms.Padding(20, 10, 0, 10)
        Me.btnEnrMat_Modif.Name = "btnEnrMat_Modif"
        Me.btnEnrMat_Modif.Size = New System.Drawing.Size(121, 40)
        Me.btnEnrMat_Modif.TabIndex = 0
        Me.btnEnrMat_Modif.Text = "Modifier"
        Me.btnEnrMat_Modif.UseVisualStyleBackColor = True
        '
        'btnEnrMat_Ajout
        '
        Me.btnEnrMat_Ajout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnrMat_Ajout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrMat_Ajout.Location = New System.Drawing.Point(178, 10)
        Me.btnEnrMat_Ajout.Margin = New System.Windows.Forms.Padding(10)
        Me.btnEnrMat_Ajout.Name = "btnEnrMat_Ajout"
        Me.btnEnrMat_Ajout.Size = New System.Drawing.Size(121, 40)
        Me.btnEnrMat_Ajout.TabIndex = 1
        Me.btnEnrMat_Ajout.Text = "Ajouter"
        Me.btnEnrMat_Ajout.UseVisualStyleBackColor = True
        '
        'btnEnrMat_Annuler
        '
        Me.btnEnrMat_Annuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnrMat_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrMat_Annuler.Location = New System.Drawing.Point(336, 10)
        Me.btnEnrMat_Annuler.Margin = New System.Windows.Forms.Padding(0, 10, 20, 10)
        Me.btnEnrMat_Annuler.Name = "btnEnrMat_Annuler"
        Me.btnEnrMat_Annuler.Size = New System.Drawing.Size(124, 40)
        Me.btnEnrMat_Annuler.TabIndex = 2
        Me.btnEnrMat_Annuler.Text = "Annuler"
        Me.btnEnrMat_Annuler.UseVisualStyleBackColor = True
        '
        'dgvEnrMat
        '
        Me.dgvEnrMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnrMat.Location = New System.Drawing.Point(14, 33)
        Me.dgvEnrMat.Name = "dgvEnrMat"
        Me.dgvEnrMat.RowHeadersWidth = 10
        Me.dgvEnrMat.Size = New System.Drawing.Size(369, 514)
        Me.dgvEnrMat.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.tbcEnrMat)
        Me.Panel2.Location = New System.Drawing.Point(400, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(482, 448)
        Me.Panel2.TabIndex = 0
        '
        'tbcEnrMat
        '
        Me.tbcEnrMat.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tbcEnrMat.Controls.Add(Me.TabPage1)
        Me.tbcEnrMat.Controls.Add(Me.TabPage2)
        Me.tbcEnrMat.Controls.Add(Me.TabPage3)
        Me.tbcEnrMat.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbcEnrMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcEnrMat.Location = New System.Drawing.Point(0, 0)
        Me.tbcEnrMat.Name = "tbcEnrMat"
        Me.tbcEnrMat.SelectedIndex = 0
        Me.tbcEnrMat.ShowToolTips = True
        Me.tbcEnrMat.Size = New System.Drawing.Size(482, 385)
        Me.tbcEnrMat.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tbcEnrMat.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(474, 349)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Général"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(474, 349)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Acquisition"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.44444!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.55556!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtEnrMat_Valeur, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEnrMat_CoutAchat, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEnrMat_Fournisseur, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpEnrMat_DateAcquis, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEnrMat_NoAntivol, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label16, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 5)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(468, 343)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 134)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 17)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Coût d'Achat"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 77)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Date d'Acquisition"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Fournisseur"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(0, 191)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 17)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Valeur résiduelle"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpEnrMat_DateAcquis
        '
        Me.dtpEnrMat_DateAcquis.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpEnrMat_DateAcquis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnrMat_DateAcquis.Location = New System.Drawing.Point(164, 77)
        Me.dtpEnrMat_DateAcquis.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.dtpEnrMat_DateAcquis.Name = "dtpEnrMat_DateAcquis"
        Me.dtpEnrMat_DateAcquis.Size = New System.Drawing.Size(301, 24)
        Me.dtpEnrMat_DateAcquis.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(0, 248)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 17)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "No Antivol"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.24294!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.75706!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnEnrMat_Photo, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblEnrMat_UrlPhoto, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(164, 288)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(301, 52)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'btnEnrMat_Photo
        '
        Me.btnEnrMat_Photo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEnrMat_Photo.Location = New System.Drawing.Point(7, 7)
        Me.btnEnrMat_Photo.Margin = New System.Windows.Forms.Padding(7)
        Me.btnEnrMat_Photo.Name = "btnEnrMat_Photo"
        Me.btnEnrMat_Photo.Size = New System.Drawing.Size(110, 38)
        Me.btnEnrMat_Photo.TabIndex = 17
        Me.btnEnrMat_Photo.Text = "Parcourir"
        Me.btnEnrMat_Photo.UseVisualStyleBackColor = True
        '
        'lblEnrMat_UrlPhoto
        '
        Me.lblEnrMat_UrlPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEnrMat_UrlPhoto.AutoSize = True
        Me.lblEnrMat_UrlPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrMat_UrlPhoto.Location = New System.Drawing.Point(127, 19)
        Me.lblEnrMat_UrlPhoto.Name = "lblEnrMat_UrlPhoto"
        Me.lblEnrMat_UrlPhoto.Size = New System.Drawing.Size(171, 13)
        Me.lblEnrMat_UrlPhoto.TabIndex = 18
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 32)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(474, 349)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Notes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.rtxEnrMat_Notes, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 6)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.44142!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.55859!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(468, 340)
        Me.TableLayoutPanel5.TabIndex = 14
        '
        'EnregistrementMateriel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EnregistrementMateriel"
        Me.Size = New System.Drawing.Size(900, 600)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.dgvEnrMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.tbcEnrMat.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents txtEnrMat_NoAntivol As TextBox
    Friend WithEvents txtEnrMat_Valeur As TextBox
    Friend WithEvents txtEnrMat_CoutAchat As TextBox
    Friend WithEvents txtEnrMat_Fabricant As TextBox
    Friend WithEvents txtEnrMat_NoSerie As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtEnrMat_Modele As TextBox
    Friend WithEvents txtEnrMat_Marque As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpEnrMat_DateFabrict As DateTimePicker
    Friend WithEvents rtxEnrMat_Notes As RichTextBox
    Friend WithEvents txtEnrMat_Fournisseur As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cboEnrMat_Categorie As ComboBox
    Friend WithEvents dtpEnrMat_DateAcquis As DateTimePicker
    Friend WithEvents btnEnrMat_Photo As Button
    Friend WithEvents dgvEnrMat As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnEnrMat_Modif As Button
    Friend WithEvents btnEnrMat_Ajout As Button
    Friend WithEvents btnEnrMat_Annuler As Button
    Friend WithEvents tbcEnrMat As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblEnrMat_UrlPhoto As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
End Class
