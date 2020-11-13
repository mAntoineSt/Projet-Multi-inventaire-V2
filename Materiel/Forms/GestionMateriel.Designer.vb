<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionMateriel
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLogin_Materiel = New System.Windows.Forms.Button()
        Me.pnlForme = New System.Windows.Forms.Panel()
        Me.pnlControle = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnListe_Materiel = New System.Windows.Forms.Button()
        Me.btnAccueil_Materiel = New System.Windows.Forms.Button()
        Me.btnFiche_Materiel = New System.Windows.Forms.Button()
        Me.btnLEnrModif_Materiel = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlForme.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.74616!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.25384!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnLogin_Materiel, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1162, 56)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnLogin_Materiel
        '
        Me.btnLogin_Materiel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLogin_Materiel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin_Materiel.Location = New System.Drawing.Point(811, 3)
        Me.btnLogin_Materiel.Name = "btnLogin_Materiel"
        Me.btnLogin_Materiel.Size = New System.Drawing.Size(236, 50)
        Me.btnLogin_Materiel.TabIndex = 0
        Me.btnLogin_Materiel.Text = "Connection"
        Me.btnLogin_Materiel.UseVisualStyleBackColor = True
        '
        'pnlForme
        '
        Me.pnlForme.Controls.Add(Me.pnlControle)
        Me.pnlForme.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlForme.Controls.Add(Me.Panel4)
        Me.pnlForme.Controls.Add(Me.Panel2)
        Me.pnlForme.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlForme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlForme.Location = New System.Drawing.Point(0, 0)
        Me.pnlForme.Name = "pnlForme"
        Me.pnlForme.Size = New System.Drawing.Size(1162, 694)
        Me.pnlForme.TabIndex = 2
        '
        'pnlControle
        '
        Me.pnlControle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlControle.Location = New System.Drawing.Point(190, 56)
        Me.pnlControle.Name = "pnlControle"
        Me.pnlControle.Size = New System.Drawing.Size(898, 610)
        Me.pnlControle.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnListe_Materiel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnAccueil_Materiel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnFiche_Materiel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnLEnrModif_Materiel, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 56)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.60538!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.69731!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.69731!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.69731!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.69731!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.60538!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(190, 610)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'btnListe_Materiel
        '
        Me.btnListe_Materiel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnListe_Materiel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListe_Materiel.Location = New System.Drawing.Point(20, 210)
        Me.btnListe_Materiel.Margin = New System.Windows.Forms.Padding(20)
        Me.btnListe_Materiel.Name = "btnListe_Materiel"
        Me.btnListe_Materiel.Size = New System.Drawing.Size(150, 74)
        Me.btnListe_Materiel.TabIndex = 2
        Me.btnListe_Materiel.Text = "LISTE DU MATÉRIEL"
        Me.btnListe_Materiel.UseVisualStyleBackColor = True
        '
        'btnAccueil_Materiel
        '
        Me.btnAccueil_Materiel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAccueil_Materiel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccueil_Materiel.Location = New System.Drawing.Point(20, 96)
        Me.btnAccueil_Materiel.Margin = New System.Windows.Forms.Padding(20)
        Me.btnAccueil_Materiel.Name = "btnAccueil_Materiel"
        Me.btnAccueil_Materiel.Size = New System.Drawing.Size(150, 74)
        Me.btnAccueil_Materiel.TabIndex = 0
        Me.btnAccueil_Materiel.Text = "ACCUEIL"
        Me.btnAccueil_Materiel.UseVisualStyleBackColor = True
        '
        'btnFiche_Materiel
        '
        Me.btnFiche_Materiel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFiche_Materiel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiche_Materiel.Location = New System.Drawing.Point(20, 324)
        Me.btnFiche_Materiel.Margin = New System.Windows.Forms.Padding(20)
        Me.btnFiche_Materiel.Name = "btnFiche_Materiel"
        Me.btnFiche_Materiel.Size = New System.Drawing.Size(150, 74)
        Me.btnFiche_Materiel.TabIndex = 1
        Me.btnFiche_Materiel.Text = "FICHE DU MATÉRIEL"
        Me.btnFiche_Materiel.UseVisualStyleBackColor = True
        '
        'btnLEnrModif_Materiel
        '
        Me.btnLEnrModif_Materiel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLEnrModif_Materiel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLEnrModif_Materiel.Location = New System.Drawing.Point(20, 438)
        Me.btnLEnrModif_Materiel.Margin = New System.Windows.Forms.Padding(20)
        Me.btnLEnrModif_Materiel.Name = "btnLEnrModif_Materiel"
        Me.btnLEnrModif_Materiel.Size = New System.Drawing.Size(150, 74)
        Me.btnLEnrModif_Materiel.TabIndex = 3
        Me.btnLEnrModif_Materiel.Text = "ENREGISTREMENT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ET " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MODIFICATION"
        Me.btnLEnrModif_Materiel.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 666)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1088, 28)
        Me.Panel4.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1088, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(74, 638)
        Me.Panel2.TabIndex = 1
        '
        'GestionMateriel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 694)
        Me.Controls.Add(Me.pnlForme)
        Me.Name = "GestionMateriel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionMateriel"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlForme.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnLogin_Materiel As Button
    Friend WithEvents pnlForme As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnListe_Materiel As Button
    Friend WithEvents btnAccueil_Materiel As Button
    Friend WithEvents btnFiche_Materiel As Button
    Friend WithEvents btnLEnrModif_Materiel As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlControle As Panel
End Class
