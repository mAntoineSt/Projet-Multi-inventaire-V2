<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.bDroitsAdmins = New System.Windows.Forms.Button()
        Me.bSuppressionAdmin = New System.Windows.Forms.Button()
        Me.bModifAdmin = New System.Windows.Forms.Button()
        Me.bAjoutAdmin = New System.Windows.Forms.Button()
        Me.pTitre = New System.Windows.Forms.Panel()
        Me.lTitre = New System.Windows.Forms.Label()
        Me.dgvListeAdministrateurs = New System.Windows.Forms.DataGridView()
        Me.pTitre.SuspendLayout()
        CType(Me.dgvListeAdministrateurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bDroitsAdmins
        '
        Me.bDroitsAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDroitsAdmins.ForeColor = System.Drawing.Color.White
        Me.bDroitsAdmins.Location = New System.Drawing.Point(795, 367)
        Me.bDroitsAdmins.Name = "bDroitsAdmins"
        Me.bDroitsAdmins.Size = New System.Drawing.Size(142, 56)
        Me.bDroitsAdmins.TabIndex = 18
        Me.bDroitsAdmins.TabStop = False
        Me.bDroitsAdmins.Text = "Enlever/Remettre les droits d'un administrateur"
        Me.bDroitsAdmins.UseVisualStyleBackColor = True
        '
        'bSuppressionAdmin
        '
        Me.bSuppressionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSuppressionAdmin.ForeColor = System.Drawing.Color.White
        Me.bSuppressionAdmin.Location = New System.Drawing.Point(795, 293)
        Me.bSuppressionAdmin.Name = "bSuppressionAdmin"
        Me.bSuppressionAdmin.Size = New System.Drawing.Size(142, 56)
        Me.bSuppressionAdmin.TabIndex = 17
        Me.bSuppressionAdmin.TabStop = False
        Me.bSuppressionAdmin.Text = "Supprimer un administrateur"
        Me.bSuppressionAdmin.UseVisualStyleBackColor = True
        '
        'bModifAdmin
        '
        Me.bModifAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bModifAdmin.ForeColor = System.Drawing.Color.White
        Me.bModifAdmin.Location = New System.Drawing.Point(795, 221)
        Me.bModifAdmin.Name = "bModifAdmin"
        Me.bModifAdmin.Size = New System.Drawing.Size(142, 56)
        Me.bModifAdmin.TabIndex = 16
        Me.bModifAdmin.TabStop = False
        Me.bModifAdmin.Text = "Modifier un administrateur"
        Me.bModifAdmin.UseVisualStyleBackColor = True
        '
        'bAjoutAdmin
        '
        Me.bAjoutAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAjoutAdmin.ForeColor = System.Drawing.Color.White
        Me.bAjoutAdmin.Location = New System.Drawing.Point(795, 148)
        Me.bAjoutAdmin.Name = "bAjoutAdmin"
        Me.bAjoutAdmin.Size = New System.Drawing.Size(142, 56)
        Me.bAjoutAdmin.TabIndex = 15
        Me.bAjoutAdmin.TabStop = False
        Me.bAjoutAdmin.Text = "Ajouter un nouvel administrateur"
        Me.bAjoutAdmin.UseVisualStyleBackColor = True
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
        'dgvListeAdministrateurs
        '
        Me.dgvListeAdministrateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListeAdministrateurs.Location = New System.Drawing.Point(75, 124)
        Me.dgvListeAdministrateurs.Name = "dgvListeAdministrateurs"
        Me.dgvListeAdministrateurs.Size = New System.Drawing.Size(601, 323)
        Me.dgvListeAdministrateurs.TabIndex = 13
        '
        'Gestion_Emprunteurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.bDroitsAdmins)
        Me.Controls.Add(Me.bSuppressionAdmin)
        Me.Controls.Add(Me.bModifAdmin)
        Me.Controls.Add(Me.bAjoutAdmin)
        Me.Controls.Add(Me.pTitre)
        Me.Controls.Add(Me.dgvListeAdministrateurs)
        Me.Name = "Gestion_Emprunteurs"
        Me.Size = New System.Drawing.Size(1013, 473)
        Me.pTitre.ResumeLayout(False)
        Me.pTitre.PerformLayout()
        CType(Me.dgvListeAdministrateurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bDroitsAdmins As Button
    Friend WithEvents bSuppressionAdmin As Button
    Friend WithEvents bModifAdmin As Button
    Friend WithEvents bAjoutAdmin As Button
    Friend WithEvents pTitre As Panel
    Friend WithEvents lTitre As Label
    Friend WithEvents dgvListeAdministrateurs As DataGridView
End Class
