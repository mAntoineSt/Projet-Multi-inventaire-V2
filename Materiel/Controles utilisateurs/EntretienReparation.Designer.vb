<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EntretienReparation
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
        Me.dgvEntRep_ListeMat = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvEntRep_ListeRepEnt = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvEntRep_cboRechEmprunt = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvEntRep_txtRechEmprunt = New System.Windows.Forms.TextBox()
        Me.dgvEntRep_btnRechEmprunt = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvEntRep_ListeEmprunts = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEntRep_Modif = New System.Windows.Forms.Button()
        Me.btnEntRep_Ajout = New System.Windows.Forms.Button()
        Me.btnEntRep_Annuler = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEntRep_Materiel = New System.Windows.Forms.TextBox()
        Me.dtpEntRep_Date = New System.Windows.Forms.DateTimePicker()
        Me.txtEntRep_Element = New System.Windows.Forms.TextBox()
        Me.txtEntRep_Montant = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.rbtEntRep_Statut_Rep = New System.Windows.Forms.RadioButton()
        Me.rbtEntRep_Statut_Ent = New System.Windows.Forms.RadioButton()
        Me.txtEntRep_Emprunt = New System.Windows.Forms.TextBox()
        Me.rtxEntRep_Note = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvEntRep_ListeMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvEntRep_ListeRepEnt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvEntRep_ListeEmprunts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.TabControl1.Size = New System.Drawing.Size(369, 514)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvEntRep_ListeMat)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(361, 478)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Liste du Matériel"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvEntRep_ListeMat
        '
        Me.dgvEntRep_ListeMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntRep_ListeMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEntRep_ListeMat.Location = New System.Drawing.Point(3, 3)
        Me.dgvEntRep_ListeMat.Name = "dgvEntRep_ListeMat"
        Me.dgvEntRep_ListeMat.RowHeadersWidth = 10
        Me.dgvEntRep_ListeMat.Size = New System.Drawing.Size(355, 472)
        Me.dgvEntRep_ListeMat.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvEntRep_ListeRepEnt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(361, 478)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Historique "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvEntRep_ListeRepEnt
        '
        Me.dgvEntRep_ListeRepEnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntRep_ListeRepEnt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEntRep_ListeRepEnt.Location = New System.Drawing.Point(3, 3)
        Me.dgvEntRep_ListeRepEnt.Name = "dgvEntRep_ListeRepEnt"
        Me.dgvEntRep_ListeRepEnt.RowHeadersWidth = 10
        Me.dgvEntRep_ListeRepEnt.Size = New System.Drawing.Size(355, 472)
        Me.dgvEntRep_ListeRepEnt.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 32)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(361, 478)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Emprunts"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(355, 96)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.63636!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.36364!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.dgvEntRep_cboRechEmprunt, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(349, 42)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Recherche Par:"
        '
        'dgvEntRep_cboRechEmprunt
        '
        Me.dgvEntRep_cboRechEmprunt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEntRep_cboRechEmprunt.FormattingEnabled = True
        Me.dgvEntRep_cboRechEmprunt.Items.AddRange(New Object() {"Emprunteur", "Date Emprunt", "Date Retour"})
        Me.dgvEntRep_cboRechEmprunt.Location = New System.Drawing.Point(155, 7)
        Me.dgvEntRep_cboRechEmprunt.Name = "dgvEntRep_cboRechEmprunt"
        Me.dgvEntRep_cboRechEmprunt.Size = New System.Drawing.Size(191, 28)
        Me.dgvEntRep_cboRechEmprunt.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.27273!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.72727!))
        Me.TableLayoutPanel6.Controls.Add(Me.dgvEntRep_txtRechEmprunt, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.dgvEntRep_btnRechEmprunt, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 51)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(349, 42)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'dgvEntRep_txtRechEmprunt
        '
        Me.dgvEntRep_txtRechEmprunt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEntRep_txtRechEmprunt.Location = New System.Drawing.Point(3, 7)
        Me.dgvEntRep_txtRechEmprunt.Name = "dgvEntRep_txtRechEmprunt"
        Me.dgvEntRep_txtRechEmprunt.Size = New System.Drawing.Size(270, 27)
        Me.dgvEntRep_txtRechEmprunt.TabIndex = 1
        '
        'dgvEntRep_btnRechEmprunt
        '
        Me.dgvEntRep_btnRechEmprunt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEntRep_btnRechEmprunt.Location = New System.Drawing.Point(279, 4)
        Me.dgvEntRep_btnRechEmprunt.Name = "dgvEntRep_btnRechEmprunt"
        Me.dgvEntRep_btnRechEmprunt.Size = New System.Drawing.Size(67, 33)
        Me.dgvEntRep_btnRechEmprunt.TabIndex = 2
        Me.dgvEntRep_btnRechEmprunt.Text = "OK"
        Me.dgvEntRep_btnRechEmprunt.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvEntRep_ListeEmprunts)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(355, 373)
        Me.Panel3.TabIndex = 0
        '
        'dgvEntRep_ListeEmprunts
        '
        Me.dgvEntRep_ListeEmprunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntRep_ListeEmprunts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEntRep_ListeEmprunts.Location = New System.Drawing.Point(0, 0)
        Me.dgvEntRep_ListeEmprunts.Name = "dgvEntRep_ListeEmprunts"
        Me.dgvEntRep_ListeEmprunts.Size = New System.Drawing.Size(355, 373)
        Me.dgvEntRep_ListeEmprunts.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.77532!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.837016!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.77532!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.837016!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.77532!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnEntRep_Modif, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnEntRep_Ajout, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnEntRep_Annuler, 4, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(400, 487)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(480, 60)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'btnEntRep_Modif
        '
        Me.btnEntRep_Modif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEntRep_Modif.Location = New System.Drawing.Point(20, 10)
        Me.btnEntRep_Modif.Margin = New System.Windows.Forms.Padding(20, 10, 0, 10)
        Me.btnEntRep_Modif.Name = "btnEntRep_Modif"
        Me.btnEntRep_Modif.Size = New System.Drawing.Size(118, 40)
        Me.btnEntRep_Modif.TabIndex = 0
        Me.btnEntRep_Modif.Text = "Modifier"
        Me.btnEntRep_Modif.UseVisualStyleBackColor = True
        '
        'btnEntRep_Ajout
        '
        Me.btnEntRep_Ajout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEntRep_Ajout.Location = New System.Drawing.Point(180, 10)
        Me.btnEntRep_Ajout.Margin = New System.Windows.Forms.Padding(10)
        Me.btnEntRep_Ajout.Name = "btnEntRep_Ajout"
        Me.btnEntRep_Ajout.Size = New System.Drawing.Size(118, 40)
        Me.btnEntRep_Ajout.TabIndex = 1
        Me.btnEntRep_Ajout.Text = "Ajouter"
        Me.btnEntRep_Ajout.UseVisualStyleBackColor = True
        '
        'btnEntRep_Annuler
        '
        Me.btnEntRep_Annuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEntRep_Annuler.Location = New System.Drawing.Point(340, 10)
        Me.btnEntRep_Annuler.Margin = New System.Windows.Forms.Padding(0, 10, 20, 10)
        Me.btnEntRep_Annuler.Name = "btnEntRep_Annuler"
        Me.btnEntRep_Annuler.Size = New System.Drawing.Size(120, 40)
        Me.btnEntRep_Annuler.TabIndex = 2
        Me.btnEntRep_Annuler.Text = "Annuler"
        Me.btnEntRep_Annuler.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Location = New System.Drawing.Point(400, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(482, 448)
        Me.Panel2.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.60996!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.39005!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEntRep_Materiel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpEntRep_Date, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEntRep_Element, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEntRep_Montant, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEntRep_Emprunt, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.rtxEntRep_Note, 1, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.82275!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.82275!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.82275!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.82275!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.82275!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.82275!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0635!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(482, 392)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matériel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Élément"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Montant"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Statut"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Emprunt (optionnel)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 267)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Notes"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEntRep_Materiel
        '
        Me.txtEntRep_Materiel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEntRep_Materiel.Location = New System.Drawing.Point(164, 8)
        Me.txtEntRep_Materiel.Name = "txtEntRep_Materiel"
        Me.txtEntRep_Materiel.Size = New System.Drawing.Size(315, 26)
        Me.txtEntRep_Materiel.TabIndex = 7
        '
        'dtpEntRep_Date
        '
        Me.dtpEntRep_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpEntRep_Date.Location = New System.Drawing.Point(164, 50)
        Me.dtpEntRep_Date.Name = "dtpEntRep_Date"
        Me.dtpEntRep_Date.Size = New System.Drawing.Size(315, 26)
        Me.dtpEntRep_Date.TabIndex = 8
        '
        'txtEntRep_Element
        '
        Me.txtEntRep_Element.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEntRep_Element.Location = New System.Drawing.Point(164, 92)
        Me.txtEntRep_Element.Name = "txtEntRep_Element"
        Me.txtEntRep_Element.Size = New System.Drawing.Size(315, 26)
        Me.txtEntRep_Element.TabIndex = 9
        '
        'txtEntRep_Montant
        '
        Me.txtEntRep_Montant.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEntRep_Montant.Location = New System.Drawing.Point(164, 134)
        Me.txtEntRep_Montant.Name = "txtEntRep_Montant"
        Me.txtEntRep_Montant.Size = New System.Drawing.Size(315, 26)
        Me.txtEntRep_Montant.TabIndex = 10
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.rbtEntRep_Statut_Rep, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rbtEntRep_Statut_Ent, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(164, 171)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(315, 36)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'rbtEntRep_Statut_Rep
        '
        Me.rbtEntRep_Statut_Rep.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtEntRep_Statut_Rep.AutoSize = True
        Me.rbtEntRep_Statut_Rep.Location = New System.Drawing.Point(15, 6)
        Me.rbtEntRep_Statut_Rep.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.rbtEntRep_Statut_Rep.Name = "rbtEntRep_Statut_Rep"
        Me.rbtEntRep_Statut_Rep.Size = New System.Drawing.Size(139, 24)
        Me.rbtEntRep_Statut_Rep.TabIndex = 0
        Me.rbtEntRep_Statut_Rep.TabStop = True
        Me.rbtEntRep_Statut_Rep.Text = "Réparation"
        Me.rbtEntRep_Statut_Rep.UseVisualStyleBackColor = True
        '
        'rbtEntRep_Statut_Ent
        '
        Me.rbtEntRep_Statut_Ent.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtEntRep_Statut_Ent.AutoSize = True
        Me.rbtEntRep_Statut_Ent.Location = New System.Drawing.Point(172, 6)
        Me.rbtEntRep_Statut_Ent.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.rbtEntRep_Statut_Ent.Name = "rbtEntRep_Statut_Ent"
        Me.rbtEntRep_Statut_Ent.Size = New System.Drawing.Size(140, 24)
        Me.rbtEntRep_Statut_Ent.TabIndex = 1
        Me.rbtEntRep_Statut_Ent.TabStop = True
        Me.rbtEntRep_Statut_Ent.Text = "Entretien"
        Me.rbtEntRep_Statut_Ent.UseVisualStyleBackColor = True
        '
        'txtEntRep_Emprunt
        '
        Me.txtEntRep_Emprunt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEntRep_Emprunt.Location = New System.Drawing.Point(164, 218)
        Me.txtEntRep_Emprunt.Name = "txtEntRep_Emprunt"
        Me.txtEntRep_Emprunt.Size = New System.Drawing.Size(315, 26)
        Me.txtEntRep_Emprunt.TabIndex = 12
        '
        'rtxEntRep_Note
        '
        Me.rtxEntRep_Note.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxEntRep_Note.Location = New System.Drawing.Point(164, 255)
        Me.rtxEntRep_Note.Name = "rtxEntRep_Note"
        Me.rtxEntRep_Note.Size = New System.Drawing.Size(315, 134)
        Me.rtxEntRep_Note.TabIndex = 13
        Me.rtxEntRep_Note.Text = ""
        '
        'EntretienReparation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EntretienReparation"
        Me.Size = New System.Drawing.Size(900, 600)
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvEntRep_ListeMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvEntRep_ListeRepEnt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvEntRep_ListeEmprunts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvEntRep_ListeRepEnt As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEntRep_Materiel As TextBox
    Friend WithEvents dtpEntRep_Date As DateTimePicker
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnEntRep_Modif As Button
    Friend WithEvents btnEntRep_Ajout As Button
    Friend WithEvents btnEntRep_Annuler As Button
    Friend WithEvents txtEntRep_Element As TextBox
    Friend WithEvents txtEntRep_Montant As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents rbtEntRep_Statut_Rep As RadioButton
    Friend WithEvents rbtEntRep_Statut_Ent As RadioButton
    Friend WithEvents txtEntRep_Emprunt As TextBox
    Friend WithEvents rtxEntRep_Note As RichTextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvEntRep_ListeMat As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvEntRep_cboRechEmprunt As ComboBox
    Friend WithEvents dgvEntRep_txtRechEmprunt As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents dgvEntRep_btnRechEmprunt As Button
    Friend WithEvents dgvEntRep_ListeEmprunts As DataGridView
End Class
