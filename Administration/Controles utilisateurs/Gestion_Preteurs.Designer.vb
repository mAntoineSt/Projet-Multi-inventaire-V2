﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_Preteurs
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
        Me.bDroitsPreteur = New System.Windows.Forms.Button()
        Me.bSuppressionPreteur = New System.Windows.Forms.Button()
        Me.bModifPreteur = New System.Windows.Forms.Button()
        Me.bAjoutPreteur = New System.Windows.Forms.Button()
        Me.pTitre = New System.Windows.Forms.Panel()
        Me.lTitre = New System.Windows.Forms.Label()
        Me.dgvListePreteurs = New System.Windows.Forms.DataGridView()
        Me.pTitre.SuspendLayout()
        CType(Me.dgvListePreteurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bDroitsPreteur
        '
        Me.bDroitsPreteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDroitsPreteur.ForeColor = System.Drawing.Color.White
        Me.bDroitsPreteur.Location = New System.Drawing.Point(795, 367)
        Me.bDroitsPreteur.Name = "bDroitsPreteur"
        Me.bDroitsPreteur.Size = New System.Drawing.Size(142, 56)
        Me.bDroitsPreteur.TabIndex = 18
        Me.bDroitsPreteur.TabStop = False
        Me.bDroitsPreteur.Text = "Enlever/Remettre les droits d'un administrateur"
        Me.bDroitsPreteur.UseVisualStyleBackColor = True
        '
        'bSuppressionPreteur
        '
        Me.bSuppressionPreteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSuppressionPreteur.ForeColor = System.Drawing.Color.White
        Me.bSuppressionPreteur.Location = New System.Drawing.Point(795, 293)
        Me.bSuppressionPreteur.Name = "bSuppressionPreteur"
        Me.bSuppressionPreteur.Size = New System.Drawing.Size(142, 56)
        Me.bSuppressionPreteur.TabIndex = 17
        Me.bSuppressionPreteur.TabStop = False
        Me.bSuppressionPreteur.Text = "Supprimer un administrateur"
        Me.bSuppressionPreteur.UseVisualStyleBackColor = True
        '
        'bModifPreteur
        '
        Me.bModifPreteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bModifPreteur.ForeColor = System.Drawing.Color.White
        Me.bModifPreteur.Location = New System.Drawing.Point(795, 221)
        Me.bModifPreteur.Name = "bModifPreteur"
        Me.bModifPreteur.Size = New System.Drawing.Size(142, 56)
        Me.bModifPreteur.TabIndex = 16
        Me.bModifPreteur.TabStop = False
        Me.bModifPreteur.Text = "Modifier un administrateur"
        Me.bModifPreteur.UseVisualStyleBackColor = True
        '
        'bAjoutPreteur
        '
        Me.bAjoutPreteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAjoutPreteur.ForeColor = System.Drawing.Color.White
        Me.bAjoutPreteur.Location = New System.Drawing.Point(795, 148)
        Me.bAjoutPreteur.Name = "bAjoutPreteur"
        Me.bAjoutPreteur.Size = New System.Drawing.Size(142, 56)
        Me.bAjoutPreteur.TabIndex = 15
        Me.bAjoutPreteur.TabStop = False
        Me.bAjoutPreteur.Text = "Ajouter un nouvel administrateur"
        Me.bAjoutPreteur.UseVisualStyleBackColor = True
        '
        'pTitre
        '
        Me.pTitre.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pTitre.Controls.Add(Me.lTitre)
        Me.pTitre.Location = New System.Drawing.Point(163, 26)
        Me.pTitre.Name = "pTitre"
        Me.pTitre.Size = New System.Drawing.Size(436, 80)
        Me.pTitre.TabIndex = 14
        '
        'lTitre
        '
        Me.lTitre.AutoSize = True
        Me.lTitre.BackColor = System.Drawing.Color.Transparent
        Me.lTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lTitre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lTitre.Location = New System.Drawing.Point(85, 22)
        Me.lTitre.Name = "lTitre"
        Me.lTitre.Size = New System.Drawing.Size(266, 31)
        Me.lTitre.TabIndex = 0
        Me.lTitre.Text = "Gestion des prêteurs"
        '
        'dgvListePreteurs
        '
        Me.dgvListePreteurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListePreteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListePreteurs.Location = New System.Drawing.Point(22, 124)
        Me.dgvListePreteurs.MultiSelect = False
        Me.dgvListePreteurs.Name = "dgvListePreteurs"
        Me.dgvListePreteurs.ReadOnly = True
        Me.dgvListePreteurs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListePreteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListePreteurs.Size = New System.Drawing.Size(755, 323)
        Me.dgvListePreteurs.TabIndex = 13
        '
        'Gestion_Preteurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.bDroitsPreteur)
        Me.Controls.Add(Me.bSuppressionPreteur)
        Me.Controls.Add(Me.bModifPreteur)
        Me.Controls.Add(Me.bAjoutPreteur)
        Me.Controls.Add(Me.pTitre)
        Me.Controls.Add(Me.dgvListePreteurs)
        Me.Name = "Gestion_Preteurs"
        Me.Size = New System.Drawing.Size(1013, 473)
        Me.pTitre.ResumeLayout(False)
        Me.pTitre.PerformLayout()
        CType(Me.dgvListePreteurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bDroitsPreteur As Button
    Friend WithEvents bSuppressionPreteur As Button
    Friend WithEvents bModifPreteur As Button
    Friend WithEvents bAjoutPreteur As Button
    Friend WithEvents pTitre As Panel
    Friend WithEvents lTitre As Label
    Friend WithEvents dgvListePreteurs As DataGridView
End Class
