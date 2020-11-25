<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConditionsEmprunt
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
        Me.dgvCondEmp_ListeMat = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvCondEmp_ListeCond = New System.Windows.Forms.DataGridView()
        Me.btnCondEmp_LstCond = New System.Windows.Forms.Button()
        Me.btnCondEmp_CreerCond = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lsvCondEmp_RechCond = New System.Windows.Forms.ListView()
        Me.IdCond = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Condition = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Detail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCondEmp_RechCond = New System.Windows.Forms.TextBox()
        Me.btnCondEmp_RechCond = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCondEmp_Materiel = New System.Windows.Forms.TextBox()
        Me.txtCondEmp_Condition = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCondEmp_Modif = New System.Windows.Forms.Button()
        Me.btnCondEmp_Ajout = New System.Windows.Forms.Button()
        Me.btnCondEmp_Annuler = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvCondEmp_ListeMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvCondEmp_ListeCond, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.btnCondEmp_LstCond)
        Me.Panel1.Controls.Add(Me.btnCondEmp_CreerCond)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel4)
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
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(14, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(295, 514)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvCondEmp_ListeMat)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(287, 478)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Liste du Matériel"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvCondEmp_ListeMat
        '
        Me.dgvCondEmp_ListeMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCondEmp_ListeMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCondEmp_ListeMat.Location = New System.Drawing.Point(3, 3)
        Me.dgvCondEmp_ListeMat.Name = "dgvCondEmp_ListeMat"
        Me.dgvCondEmp_ListeMat.RowHeadersWidth = 10
        Me.dgvCondEmp_ListeMat.Size = New System.Drawing.Size(281, 472)
        Me.dgvCondEmp_ListeMat.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvCondEmp_ListeCond)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(287, 478)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Liste des Conditions"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvCondEmp_ListeCond
        '
        Me.dgvCondEmp_ListeCond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCondEmp_ListeCond.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCondEmp_ListeCond.Location = New System.Drawing.Point(3, 3)
        Me.dgvCondEmp_ListeCond.Name = "dgvCondEmp_ListeCond"
        Me.dgvCondEmp_ListeCond.RowHeadersWidth = 10
        Me.dgvCondEmp_ListeCond.Size = New System.Drawing.Size(281, 472)
        Me.dgvCondEmp_ListeCond.TabIndex = 0
        '
        'btnCondEmp_LstCond
        '
        Me.btnCondEmp_LstCond.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCondEmp_LstCond.Location = New System.Drawing.Point(669, 33)
        Me.btnCondEmp_LstCond.Name = "btnCondEmp_LstCond"
        Me.btnCondEmp_LstCond.Size = New System.Drawing.Size(210, 64)
        Me.btnCondEmp_LstCond.TabIndex = 13
        Me.btnCondEmp_LstCond.Text = "Liste des conditions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pour ce matériel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCondEmp_LstCond.UseVisualStyleBackColor = True
        '
        'btnCondEmp_CreerCond
        '
        Me.btnCondEmp_CreerCond.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCondEmp_CreerCond.Location = New System.Drawing.Point(669, 97)
        Me.btnCondEmp_CreerCond.Name = "btnCondEmp_CreerCond"
        Me.btnCondEmp_CreerCond.Size = New System.Drawing.Size(210, 64)
        Me.btnCondEmp_CreerCond.TabIndex = 12
        Me.btnCondEmp_CreerCond.Text = "Créer/Modifier " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "une Condition"
        Me.btnCondEmp_CreerCond.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lsvCondEmp_RechCond, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(318, 167)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.09091!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.90909!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(564, 275)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'lsvCondEmp_RechCond
        '
        Me.lsvCondEmp_RechCond.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdCond, Me.Condition, Me.Detail})
        Me.lsvCondEmp_RechCond.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvCondEmp_RechCond.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvCondEmp_RechCond.FullRowSelect = True
        Me.lsvCondEmp_RechCond.GridLines = True
        Me.lsvCondEmp_RechCond.HideSelection = False
        Me.lsvCondEmp_RechCond.Location = New System.Drawing.Point(3, 39)
        Me.lsvCondEmp_RechCond.Name = "lsvCondEmp_RechCond"
        Me.lsvCondEmp_RechCond.Size = New System.Drawing.Size(558, 233)
        Me.lsvCondEmp_RechCond.TabIndex = 1
        Me.lsvCondEmp_RechCond.UseCompatibleStateImageBehavior = False
        Me.lsvCondEmp_RechCond.View = System.Windows.Forms.View.Details
        '
        'IdCond
        '
        Me.IdCond.Text = "idCondition"
        Me.IdCond.Width = 0
        '
        'Condition
        '
        Me.Condition.Text = "Condition"
        Me.Condition.Width = 186
        '
        'Detail
        '
        Me.Detail.Text = "Détail"
        Me.Detail.Width = 440
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.36511!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.63489!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtCondEmp_RechCond, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnCondEmp_RechCond, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(558, 30)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recherche de conditions"
        '
        'txtCondEmp_RechCond
        '
        Me.txtCondEmp_RechCond.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCondEmp_RechCond.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCondEmp_RechCond.Location = New System.Drawing.Point(200, 3)
        Me.txtCondEmp_RechCond.Name = "txtCondEmp_RechCond"
        Me.txtCondEmp_RechCond.Size = New System.Drawing.Size(286, 26)
        Me.txtCondEmp_RechCond.TabIndex = 1
        '
        'btnCondEmp_RechCond
        '
        Me.btnCondEmp_RechCond.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCondEmp_RechCond.Location = New System.Drawing.Point(492, 3)
        Me.btnCondEmp_RechCond.Name = "btnCondEmp_RechCond"
        Me.btnCondEmp_RechCond.Size = New System.Drawing.Size(63, 24)
        Me.btnCondEmp_RechCond.TabIndex = 2
        Me.btnCondEmp_RechCond.Text = "OK"
        Me.btnCondEmp_RechCond.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.47126!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.52873!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCondEmp_Materiel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCondEmp_Condition, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(318, 33)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(348, 128)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Condition"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Matériel"
        '
        'txtCondEmp_Materiel
        '
        Me.txtCondEmp_Materiel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCondEmp_Materiel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCondEmp_Materiel.Location = New System.Drawing.Point(115, 19)
        Me.txtCondEmp_Materiel.Name = "txtCondEmp_Materiel"
        Me.txtCondEmp_Materiel.Size = New System.Drawing.Size(230, 26)
        Me.txtCondEmp_Materiel.TabIndex = 4
        '
        'txtCondEmp_Condition
        '
        Me.txtCondEmp_Condition.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCondEmp_Condition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCondEmp_Condition.Location = New System.Drawing.Point(115, 83)
        Me.txtCondEmp_Condition.Name = "txtCondEmp_Condition"
        Me.txtCondEmp_Condition.Size = New System.Drawing.Size(230, 26)
        Me.txtCondEmp_Condition.TabIndex = 5
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.25253!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12121!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.25253!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12121!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.25253!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnCondEmp_Modif, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnCondEmp_Ajout, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnCondEmp_Annuler, 4, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(315, 448)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(567, 99)
        Me.TableLayoutPanel4.TabIndex = 9
        '
        'btnCondEmp_Modif
        '
        Me.btnCondEmp_Modif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCondEmp_Modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCondEmp_Modif.Location = New System.Drawing.Point(3, 23)
        Me.btnCondEmp_Modif.Name = "btnCondEmp_Modif"
        Me.btnCondEmp_Modif.Size = New System.Drawing.Size(137, 52)
        Me.btnCondEmp_Modif.TabIndex = 0
        Me.btnCondEmp_Modif.Text = "Modifier"
        Me.btnCondEmp_Modif.UseVisualStyleBackColor = True
        '
        'btnCondEmp_Ajout
        '
        Me.btnCondEmp_Ajout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCondEmp_Ajout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCondEmp_Ajout.Location = New System.Drawing.Point(214, 23)
        Me.btnCondEmp_Ajout.Name = "btnCondEmp_Ajout"
        Me.btnCondEmp_Ajout.Size = New System.Drawing.Size(137, 52)
        Me.btnCondEmp_Ajout.TabIndex = 1
        Me.btnCondEmp_Ajout.Text = "Ajouter"
        Me.btnCondEmp_Ajout.UseVisualStyleBackColor = True
        '
        'btnCondEmp_Annuler
        '
        Me.btnCondEmp_Annuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCondEmp_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCondEmp_Annuler.Location = New System.Drawing.Point(425, 23)
        Me.btnCondEmp_Annuler.Name = "btnCondEmp_Annuler"
        Me.btnCondEmp_Annuler.Size = New System.Drawing.Size(139, 52)
        Me.btnCondEmp_Annuler.TabIndex = 2
        Me.btnCondEmp_Annuler.Text = "Annuler"
        Me.btnCondEmp_Annuler.UseVisualStyleBackColor = True
        '
        'ConditionsEmprunt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ConditionsEmprunt"
        Me.Size = New System.Drawing.Size(900, 600)
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvCondEmp_ListeMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvCondEmp_ListeCond, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnCondEmp_Modif As Button
    Friend WithEvents btnCondEmp_Ajout As Button
    Friend WithEvents btnCondEmp_Annuler As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCondEmp_CreerCond As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCondEmp_Materiel As TextBox
    Friend WithEvents txtCondEmp_Condition As TextBox
    Friend WithEvents btnCondEmp_LstCond As Button
    Friend WithEvents lsvCondEmp_RechCond As ListView
    Friend WithEvents dgvCondEmp_ListeMat As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvCondEmp_ListeCond As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtCondEmp_RechCond As TextBox
    Friend WithEvents IdCond As ColumnHeader
    Friend WithEvents Condition As ColumnHeader
    Friend WithEvents Detail As ColumnHeader
    Friend WithEvents btnCondEmp_RechCond As Button
End Class
