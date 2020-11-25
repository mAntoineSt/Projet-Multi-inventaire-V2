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
        Me.pnlForme = New System.Windows.Forms.Panel()
        Me.pnlControle = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnFiche = New System.Windows.Forms.Button()
        Me.btnEnregistrement = New System.Windows.Forms.Button()
        Me.btnEntretienReparations = New System.Windows.Forms.Button()
        Me.btnConditions = New System.Windows.Forms.Button()
        Me.btnEtat = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1162, 56)
        Me.TableLayoutPanel1.TabIndex = 0
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
        Me.TableLayoutPanel2.Controls.Add(Me.btnFiche, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btnEnregistrement, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnEntretienReparations, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btnConditions, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnEtat, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 56)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(190, 610)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'btnFiche
        '
        Me.btnFiche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFiche.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiche.Location = New System.Drawing.Point(20, 440)
        Me.btnFiche.Margin = New System.Windows.Forms.Padding(20, 5, 20, 5)
        Me.btnFiche.Name = "btnFiche"
        Me.btnFiche.Size = New System.Drawing.Size(150, 77)
        Me.btnFiche.TabIndex = 4
        Me.btnFiche.Text = "FICHE"
        Me.btnFiche.UseVisualStyleBackColor = True
        '
        'btnEnregistrement
        '
        Me.btnEnregistrement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEnregistrement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregistrement.Location = New System.Drawing.Point(20, 92)
        Me.btnEnregistrement.Margin = New System.Windows.Forms.Padding(20, 5, 20, 5)
        Me.btnEnregistrement.Name = "btnEnregistrement"
        Me.btnEnregistrement.Size = New System.Drawing.Size(150, 77)
        Me.btnEnregistrement.TabIndex = 2
        Me.btnEnregistrement.Text = "ENREGISTREMENT"
        Me.btnEnregistrement.UseVisualStyleBackColor = True
        '
        'btnEntretienReparations
        '
        Me.btnEntretienReparations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEntretienReparations.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntretienReparations.Location = New System.Drawing.Point(20, 353)
        Me.btnEntretienReparations.Margin = New System.Windows.Forms.Padding(20, 5, 20, 5)
        Me.btnEntretienReparations.Name = "btnEntretienReparations"
        Me.btnEntretienReparations.Size = New System.Drawing.Size(150, 77)
        Me.btnEntretienReparations.TabIndex = 3
        Me.btnEntretienReparations.Text = "ENTRETIEN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ET " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RÉPARATIONS"
        Me.btnEntretienReparations.UseVisualStyleBackColor = True
        '
        'btnConditions
        '
        Me.btnConditions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConditions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConditions.Location = New System.Drawing.Point(20, 179)
        Me.btnConditions.Margin = New System.Windows.Forms.Padding(20, 5, 20, 5)
        Me.btnConditions.Name = "btnConditions"
        Me.btnConditions.Size = New System.Drawing.Size(150, 77)
        Me.btnConditions.TabIndex = 0
        Me.btnConditions.Text = "CONDITIONS"
        Me.btnConditions.UseVisualStyleBackColor = True
        '
        'btnEtat
        '
        Me.btnEtat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEtat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEtat.Location = New System.Drawing.Point(20, 266)
        Me.btnEtat.Margin = New System.Windows.Forms.Padding(20, 5, 20, 5)
        Me.btnEtat.Name = "btnEtat"
        Me.btnEtat.Size = New System.Drawing.Size(150, 77)
        Me.btnEtat.TabIndex = 1
        Me.btnEtat.Text = "ÉTAT"
        Me.btnEtat.UseVisualStyleBackColor = True
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
        Me.pnlForme.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pnlForme As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnEnregistrement As Button
    Friend WithEvents btnConditions As Button
    Friend WithEvents btnEtat As Button
    Friend WithEvents btnEntretienReparations As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlControle As Panel
    Friend WithEvents btnFiche As Button
End Class
