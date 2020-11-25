<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EtatMateriel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvEtatMat_ListeMat = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvEtatMat_ListeEval = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEtatMat_Modif = New System.Windows.Forms.Button()
        Me.btnEtatMat_Ajout = New System.Windows.Forms.Button()
        Me.btnEtatMat_Annuler = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtxEtatMat_Notes = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEtatMat_Materiel = New System.Windows.Forms.TextBox()
        Me.txtEtatMat_Emprunt = New System.Windows.Forms.TextBox()
        Me.dtpEtatMat_Date = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtEtatMat_EtatGen = New System.Windows.Forms.TextBox()
        Me.txtEtatMat_Boitier = New System.Windows.Forms.TextBox()
        Me.txtEtatMat_Electro = New System.Windows.Forms.TextBox()
        Me.txtEtatMat_Moteur = New System.Windows.Forms.TextBox()
        Me.txtEtatMat_Cablage = New System.Windows.Forms.TextBox()
        Me.txtEtatMat_Logiciel = New System.Windows.Forms.TextBox()
        Me.txtEtatMat_Eau = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvEtatMat_ListeMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvEtatMat_ListeEval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 600)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(14, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(295, 514)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvEtatMat_ListeMat)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(287, 478)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Liste du Matériel"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvEtatMat_ListeMat
        '
        Me.dgvEtatMat_ListeMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEtatMat_ListeMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEtatMat_ListeMat.Location = New System.Drawing.Point(3, 3)
        Me.dgvEtatMat_ListeMat.Name = "dgvEtatMat_ListeMat"
        Me.dgvEtatMat_ListeMat.RowHeadersWidth = 10
        Me.dgvEtatMat_ListeMat.Size = New System.Drawing.Size(281, 472)
        Me.dgvEtatMat_ListeMat.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvEtatMat_ListeEval)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(287, 478)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Historique"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvEtatMat_ListeEval
        '
        Me.dgvEtatMat_ListeEval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEtatMat_ListeEval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEtatMat_ListeEval.Location = New System.Drawing.Point(3, 3)
        Me.dgvEtatMat_ListeEval.Name = "dgvEtatMat_ListeEval"
        Me.dgvEtatMat_ListeEval.RowHeadersWidth = 10
        Me.dgvEtatMat_ListeEval.Size = New System.Drawing.Size(281, 472)
        Me.dgvEtatMat_ListeEval.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 32)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(287, 478)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Emprunts"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(281, 96)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.63636!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.36364!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.ComboBox1, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(275, 42)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Recherche Par:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Emprunteur", "Date Emprunt", "Date Retour"})
        Me.ComboBox1.Location = New System.Drawing.Point(122, 7)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 28)
        Me.ComboBox1.TabIndex = 1
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.27273!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.72727!))
        Me.TableLayoutPanel7.Controls.Add(Me.TextBox1, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 51)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(275, 42)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(3, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 27)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(221, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 33)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(281, 373)
        Me.Panel3.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(281, 373)
        Me.DataGridView1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.25253!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12121!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.25253!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12121!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.25253!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnEtatMat_Modif, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnEtatMat_Ajout, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnEtatMat_Annuler, 4, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(315, 448)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(567, 99)
        Me.TableLayoutPanel4.TabIndex = 8
        '
        'btnEtatMat_Modif
        '
        Me.btnEtatMat_Modif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEtatMat_Modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEtatMat_Modif.Location = New System.Drawing.Point(3, 23)
        Me.btnEtatMat_Modif.Name = "btnEtatMat_Modif"
        Me.btnEtatMat_Modif.Size = New System.Drawing.Size(137, 52)
        Me.btnEtatMat_Modif.TabIndex = 0
        Me.btnEtatMat_Modif.Text = "Modifier"
        Me.btnEtatMat_Modif.UseVisualStyleBackColor = True
        '
        'btnEtatMat_Ajout
        '
        Me.btnEtatMat_Ajout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEtatMat_Ajout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEtatMat_Ajout.Location = New System.Drawing.Point(214, 23)
        Me.btnEtatMat_Ajout.Name = "btnEtatMat_Ajout"
        Me.btnEtatMat_Ajout.Size = New System.Drawing.Size(137, 52)
        Me.btnEtatMat_Ajout.TabIndex = 1
        Me.btnEtatMat_Ajout.Text = "Ajouter"
        Me.btnEtatMat_Ajout.UseVisualStyleBackColor = True
        '
        'btnEtatMat_Annuler
        '
        Me.btnEtatMat_Annuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEtatMat_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEtatMat_Annuler.Location = New System.Drawing.Point(425, 23)
        Me.btnEtatMat_Annuler.Name = "btnEtatMat_Annuler"
        Me.btnEtatMat_Annuler.Size = New System.Drawing.Size(139, 52)
        Me.btnEtatMat_Annuler.TabIndex = 2
        Me.btnEtatMat_Annuler.Text = "Annuler"
        Me.btnEtatMat_Annuler.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel2.Location = New System.Drawing.Point(315, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(575, 409)
        Me.Panel2.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rtxEtatMat_Notes, 0, 1)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 163)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.69547!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.30453!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(305, 243)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(51, 42)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Notes"
        '
        'rtxEtatMat_Notes
        '
        Me.rtxEtatMat_Notes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxEtatMat_Notes.Location = New System.Drawing.Point(3, 45)
        Me.rtxEtatMat_Notes.Name = "rtxEtatMat_Notes"
        Me.rtxEtatMat_Notes.Size = New System.Drawing.Size(299, 195)
        Me.rtxEtatMat_Notes.TabIndex = 1
        Me.rtxEtatMat_Notes.Text = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.60656!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.39344!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEtatMat_Materiel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEtatMat_Emprunt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpEtatMat_Date, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(305, 154)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matériel"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Emprunt (optionnel)"
        '
        'txtEtatMat_Materiel
        '
        Me.txtEtatMat_Materiel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEtatMat_Materiel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtatMat_Materiel.Location = New System.Drawing.Point(136, 12)
        Me.txtEtatMat_Materiel.Name = "txtEtatMat_Materiel"
        Me.txtEtatMat_Materiel.Size = New System.Drawing.Size(166, 26)
        Me.txtEtatMat_Materiel.TabIndex = 3
        '
        'txtEtatMat_Emprunt
        '
        Me.txtEtatMat_Emprunt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEtatMat_Emprunt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtatMat_Emprunt.Location = New System.Drawing.Point(136, 115)
        Me.txtEtatMat_Emprunt.Name = "txtEtatMat_Emprunt"
        Me.txtEtatMat_Emprunt.Size = New System.Drawing.Size(166, 26)
        Me.txtEtatMat_Emprunt.TabIndex = 4
        '
        'dtpEtatMat_Date
        '
        Me.dtpEtatMat_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpEtatMat_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEtatMat_Date.Location = New System.Drawing.Point(136, 63)
        Me.dtpEtatMat_Date.Name = "dtpEtatMat_Date"
        Me.dtpEtatMat_Date.Size = New System.Drawing.Size(166, 26)
        Me.dtpEtatMat_Date.TabIndex = 5
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.76563!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.23438!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label24, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label17, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label18, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label25, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label26, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label19, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label37, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label28, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label34, 0, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.txtEtatMat_EtatGen, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtEtatMat_Boitier, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtEtatMat_Electro, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txtEtatMat_Moteur, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.txtEtatMat_Cablage, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.txtEtatMat_Logiciel, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.txtEtatMat_Eau, 1, 7)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(311, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 8
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(256, 409)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(157, 17)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(93, 17)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Coût estimé"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(57, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Item"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 66)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(146, 20)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "État général"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(3, 117)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(146, 20)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Boîtier"
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(3, 168)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(146, 20)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "Électronique"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 219)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(146, 20)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Moteur"
        '
        'Label37
        '
        Me.Label37.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(3, 270)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(146, 20)
        Me.Label37.TabIndex = 19
        Me.Label37.Text = "Câblage Électrique"
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(3, 321)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(146, 20)
        Me.Label28.TabIndex = 16
        Me.Label28.Text = "Logiciel"
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(3, 373)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(146, 20)
        Me.Label34.TabIndex = 17
        Me.Label34.Text = "Eau"
        '
        'txtEtatMat_EtatGen
        '
        Me.txtEtatMat_EtatGen.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEtatMat_EtatGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtatMat_EtatGen.Location = New System.Drawing.Point(155, 63)
        Me.txtEtatMat_EtatGen.Name = "txtEtatMat_EtatGen"
        Me.txtEtatMat_EtatGen.Size = New System.Drawing.Size(98, 26)
        Me.txtEtatMat_EtatGen.TabIndex = 36
        Me.txtEtatMat_EtatGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEtatMat_Boitier
        '
        Me.txtEtatMat_Boitier.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEtatMat_Boitier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtatMat_Boitier.Location = New System.Drawing.Point(155, 114)
        Me.txtEtatMat_Boitier.Name = "txtEtatMat_Boitier"
        Me.txtEtatMat_Boitier.Size = New System.Drawing.Size(98, 26)
        Me.txtEtatMat_Boitier.TabIndex = 38
        Me.txtEtatMat_Boitier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEtatMat_Electro
        '
        Me.txtEtatMat_Electro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEtatMat_Electro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtatMat_Electro.Location = New System.Drawing.Point(155, 165)
        Me.txtEtatMat_Electro.Name = "txtEtatMat_Electro"
        Me.txtEtatMat_Electro.Size = New System.Drawing.Size(98, 26)
        Me.txtEtatMat_Electro.TabIndex = 39
        Me.txtEtatMat_Electro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEtatMat_Moteur
        '
        Me.txtEtatMat_Moteur.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEtatMat_Moteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtatMat_Moteur.Location = New System.Drawing.Point(155, 216)
        Me.txtEtatMat_Moteur.Name = "txtEtatMat_Moteur"
        Me.txtEtatMat_Moteur.Size = New System.Drawing.Size(98, 26)
        Me.txtEtatMat_Moteur.TabIndex = 40
        Me.txtEtatMat_Moteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEtatMat_Cablage
        '
        Me.txtEtatMat_Cablage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEtatMat_Cablage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtatMat_Cablage.Location = New System.Drawing.Point(155, 267)
        Me.txtEtatMat_Cablage.Name = "txtEtatMat_Cablage"
        Me.txtEtatMat_Cablage.Size = New System.Drawing.Size(98, 26)
        Me.txtEtatMat_Cablage.TabIndex = 41
        Me.txtEtatMat_Cablage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEtatMat_Logiciel
        '
        Me.txtEtatMat_Logiciel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEtatMat_Logiciel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtatMat_Logiciel.Location = New System.Drawing.Point(155, 318)
        Me.txtEtatMat_Logiciel.Name = "txtEtatMat_Logiciel"
        Me.txtEtatMat_Logiciel.Size = New System.Drawing.Size(98, 26)
        Me.txtEtatMat_Logiciel.TabIndex = 42
        Me.txtEtatMat_Logiciel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEtatMat_Eau
        '
        Me.txtEtatMat_Eau.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEtatMat_Eau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtatMat_Eau.Location = New System.Drawing.Point(155, 370)
        Me.txtEtatMat_Eau.Name = "txtEtatMat_Eau"
        Me.txtEtatMat_Eau.Size = New System.Drawing.Size(98, 26)
        Me.txtEtatMat_Eau.TabIndex = 43
        Me.txtEtatMat_Eau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'EtatMateriel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EtatMateriel"
        Me.Size = New System.Drawing.Size(900, 600)
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvEtatMat_ListeMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvEtatMat_ListeEval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvEtatMat_ListeMat As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label24 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents txtEtatMat_EtatGen As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents rtxEtatMat_Notes As RichTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEtatMat_Materiel As TextBox
    Friend WithEvents txtEtatMat_Emprunt As TextBox
    Friend WithEvents dtpEtatMat_Date As DateTimePicker
    Friend WithEvents txtEtatMat_Boitier As TextBox
    Friend WithEvents txtEtatMat_Electro As TextBox
    Friend WithEvents txtEtatMat_Moteur As TextBox
    Friend WithEvents txtEtatMat_Cablage As TextBox
    Friend WithEvents txtEtatMat_Logiciel As TextBox
    Friend WithEvents txtEtatMat_Eau As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnEtatMat_Modif As Button
    Friend WithEvents btnEtatMat_Ajout As Button
    Friend WithEvents btnEtatMat_Annuler As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvEtatMat_ListeEval As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
