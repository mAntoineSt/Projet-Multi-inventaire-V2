﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_Emprunteurs
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
        Me.bDroitsEmprunteurs = New System.Windows.Forms.Button()
        Me.bSuppressionEmprunteurs = New System.Windows.Forms.Button()
        Me.bModifEmprunteurs = New System.Windows.Forms.Button()
        Me.bAjoutEmprunteurs = New System.Windows.Forms.Button()
        Me.pTitre = New System.Windows.Forms.Panel()
        Me.lTitre = New System.Windows.Forms.Label()
        Me.dgvListeEmprunteurs = New System.Windows.Forms.DataGridView()
        Me.pTitre.SuspendLayout()
        CType(Me.dgvListeEmprunteurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bDroitsEmprunteurs
        '
        Me.bDroitsEmprunteurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDroitsEmprunteurs.ForeColor = System.Drawing.Color.White
        Me.bDroitsEmprunteurs.Location = New System.Drawing.Point(795, 367)
        Me.bDroitsEmprunteurs.Name = "bDroitsEmprunteurs"
        Me.bDroitsEmprunteurs.Size = New System.Drawing.Size(142, 56)
        Me.bDroitsEmprunteurs.TabIndex = 18
        Me.bDroitsEmprunteurs.TabStop = False
        Me.bDroitsEmprunteurs.Text = "Enlever/Remettre les droits d'un administrateur"
        Me.bDroitsEmprunteurs.UseVisualStyleBackColor = True
        '
        'bSuppressionEmprunteurs
        '
        Me.bSuppressionEmprunteurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSuppressionEmprunteurs.ForeColor = System.Drawing.Color.White
        Me.bSuppressionEmprunteurs.Location = New System.Drawing.Point(795, 293)
        Me.bSuppressionEmprunteurs.Name = "bSuppressionEmprunteurs"
        Me.bSuppressionEmprunteurs.Size = New System.Drawing.Size(142, 56)
        Me.bSuppressionEmprunteurs.TabIndex = 17
        Me.bSuppressionEmprunteurs.TabStop = False
        Me.bSuppressionEmprunteurs.Text = "Supprimer un administrateur"
        Me.bSuppressionEmprunteurs.UseVisualStyleBackColor = True
        '
        'bModifEmprunteurs
        '
        Me.bModifEmprunteurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bModifEmprunteurs.ForeColor = System.Drawing.Color.White
        Me.bModifEmprunteurs.Location = New System.Drawing.Point(795, 221)
        Me.bModifEmprunteurs.Name = "bModifEmprunteurs"
        Me.bModifEmprunteurs.Size = New System.Drawing.Size(142, 56)
        Me.bModifEmprunteurs.TabIndex = 16
        Me.bModifEmprunteurs.TabStop = False
        Me.bModifEmprunteurs.Text = "Modifier un administrateur"
        Me.bModifEmprunteurs.UseVisualStyleBackColor = True
        '
        'bAjoutEmprunteurs
        '
        Me.bAjoutEmprunteurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAjoutEmprunteurs.ForeColor = System.Drawing.Color.White
        Me.bAjoutEmprunteurs.Location = New System.Drawing.Point(795, 148)
        Me.bAjoutEmprunteurs.Name = "bAjoutEmprunteurs"
        Me.bAjoutEmprunteurs.Size = New System.Drawing.Size(142, 56)
        Me.bAjoutEmprunteurs.TabIndex = 15
        Me.bAjoutEmprunteurs.TabStop = False
        Me.bAjoutEmprunteurs.Text = "Ajouter un nouvel administrateur"
        Me.bAjoutEmprunteurs.UseVisualStyleBackColor = True
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
        Me.lTitre.Location = New System.Drawing.Point(59, 22)
        Me.lTitre.Name = "lTitre"
        Me.lTitre.Size = New System.Drawing.Size(318, 31)
        Me.lTitre.TabIndex = 0
        Me.lTitre.Text = "Gestion des emprunteurs"
        '
        'dgvListeEmprunteurs
        '
        Me.dgvListeEmprunteurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListeEmprunteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListeEmprunteurs.Location = New System.Drawing.Point(22, 124)
        Me.dgvListeEmprunteurs.MultiSelect = False
        Me.dgvListeEmprunteurs.Name = "dgvListeEmprunteurs"
        Me.dgvListeEmprunteurs.ReadOnly = True
        Me.dgvListeEmprunteurs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListeEmprunteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListeEmprunteurs.Size = New System.Drawing.Size(755, 323)
        Me.dgvListeEmprunteurs.TabIndex = 13
        '
        'Gestion_Emprunteurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.bDroitsEmprunteurs)
        Me.Controls.Add(Me.bSuppressionEmprunteurs)
        Me.Controls.Add(Me.bModifEmprunteurs)
        Me.Controls.Add(Me.bAjoutEmprunteurs)
        Me.Controls.Add(Me.pTitre)
        Me.Controls.Add(Me.dgvListeEmprunteurs)
        Me.Name = "Gestion_Emprunteurs"
        Me.Size = New System.Drawing.Size(1013, 473)
        Me.pTitre.ResumeLayout(False)
        Me.pTitre.PerformLayout()
        CType(Me.dgvListeEmprunteurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bDroitsEmprunteurs As Button
    Friend WithEvents bSuppressionEmprunteurs As Button
    Friend WithEvents bModifEmprunteurs As Button
    Friend WithEvents bAjoutEmprunteurs As Button
    Friend WithEvents pTitre As Panel
    Friend WithEvents lTitre As Label
    Friend WithEvents dgvListeEmprunteurs As DataGridView
End Class
