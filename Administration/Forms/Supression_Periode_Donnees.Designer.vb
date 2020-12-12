<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supression_Periode_Donnees
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
        Me.pHaut = New System.Windows.Forms.Panel()
        Me.lQuitter = New System.Windows.Forms.Label()
        Me.lTitreHaut = New System.Windows.Forms.Label()
        Me.pBas = New System.Windows.Forms.Panel()
        Me.dtpDe = New System.Windows.Forms.DateTimePicker()
        Me.dtpAu = New System.Windows.Forms.DateTimePicker()
        Me.lDe = New System.Windows.Forms.Label()
        Me.lAu = New System.Windows.Forms.Label()
        Me.bConfirmer = New System.Windows.Forms.Button()
        Me.lTitre = New System.Windows.Forms.Label()
        Me.pHaut.SuspendLayout()
        Me.SuspendLayout()
        '
        'pHaut
        '
        Me.pHaut.Controls.Add(Me.lQuitter)
        Me.pHaut.Controls.Add(Me.lTitreHaut)
        Me.pHaut.Location = New System.Drawing.Point(0, 0)
        Me.pHaut.Name = "pHaut"
        Me.pHaut.Size = New System.Drawing.Size(351, 43)
        Me.pHaut.TabIndex = 2
        '
        'lQuitter
        '
        Me.lQuitter.AutoSize = True
        Me.lQuitter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!)
        Me.lQuitter.ForeColor = System.Drawing.Color.White
        Me.lQuitter.Location = New System.Drawing.Point(327, 12)
        Me.lQuitter.Name = "lQuitter"
        Me.lQuitter.Size = New System.Drawing.Size(21, 22)
        Me.lQuitter.TabIndex = 2
        Me.lQuitter.Text = "X"
        '
        'lTitreHaut
        '
        Me.lTitreHaut.AutoSize = True
        Me.lTitreHaut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lTitreHaut.ForeColor = System.Drawing.Color.White
        Me.lTitreHaut.Location = New System.Drawing.Point(3, 12)
        Me.lTitreHaut.Name = "lTitreHaut"
        Me.lTitreHaut.Size = New System.Drawing.Size(154, 18)
        Me.lTitreHaut.TabIndex = 1
        Me.lTitreHaut.Text = "Menu administratif"
        '
        'pBas
        '
        Me.pBas.Location = New System.Drawing.Point(0, 256)
        Me.pBas.Name = "pBas"
        Me.pBas.Size = New System.Drawing.Size(351, 27)
        Me.pBas.TabIndex = 3
        '
        'dtpDe
        '
        Me.dtpDe.Location = New System.Drawing.Point(88, 87)
        Me.dtpDe.MaxDate = New Date(2080, 12, 31, 0, 0, 0, 0)
        Me.dtpDe.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtpDe.Name = "dtpDe"
        Me.dtpDe.Size = New System.Drawing.Size(200, 20)
        Me.dtpDe.TabIndex = 4
        '
        'dtpAu
        '
        Me.dtpAu.Location = New System.Drawing.Point(88, 132)
        Me.dtpAu.MaxDate = New Date(2080, 12, 31, 0, 0, 0, 0)
        Me.dtpAu.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtpAu.Name = "dtpAu"
        Me.dtpAu.Size = New System.Drawing.Size(200, 20)
        Me.dtpAu.TabIndex = 5
        '
        'lDe
        '
        Me.lDe.AutoSize = True
        Me.lDe.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!)
        Me.lDe.Location = New System.Drawing.Point(62, 91)
        Me.lDe.Name = "lDe"
        Me.lDe.Size = New System.Drawing.Size(20, 12)
        Me.lDe.TabIndex = 6
        Me.lDe.Text = "De"
        '
        'lAu
        '
        Me.lAu.AutoSize = True
        Me.lAu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!)
        Me.lAu.Location = New System.Drawing.Point(62, 136)
        Me.lAu.Name = "lAu"
        Me.lAu.Size = New System.Drawing.Size(20, 12)
        Me.lAu.TabIndex = 7
        Me.lAu.Text = "Au"
        '
        'bConfirmer
        '
        Me.bConfirmer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!)
        Me.bConfirmer.Location = New System.Drawing.Point(90, 189)
        Me.bConfirmer.Name = "bConfirmer"
        Me.bConfirmer.Size = New System.Drawing.Size(171, 52)
        Me.bConfirmer.TabIndex = 8
        Me.bConfirmer.Text = "Confirmer la supression"
        Me.bConfirmer.UseVisualStyleBackColor = True
        '
        'lTitre
        '
        Me.lTitre.AutoSize = True
        Me.lTitre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!)
        Me.lTitre.Location = New System.Drawing.Point(24, 57)
        Me.lTitre.Name = "lTitre"
        Me.lTitre.Size = New System.Drawing.Size(302, 12)
        Me.lTitre.TabIndex = 9
        Me.lTitre.Text = "Sur quel période voulez-vous supprimer les données?"
        '
        'Supression_Periode_Donnees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 284)
        Me.Controls.Add(Me.lTitre)
        Me.Controls.Add(Me.bConfirmer)
        Me.Controls.Add(Me.lAu)
        Me.Controls.Add(Me.lDe)
        Me.Controls.Add(Me.dtpAu)
        Me.Controls.Add(Me.dtpDe)
        Me.Controls.Add(Me.pBas)
        Me.Controls.Add(Me.pHaut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Supression_Periode_Donnees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supression_Periode_Donnees"
        Me.pHaut.ResumeLayout(False)
        Me.pHaut.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pHaut As Panel
    Friend WithEvents lQuitter As Label
    Friend WithEvents lTitreHaut As Label
    Friend WithEvents pBas As Panel
    Friend WithEvents dtpDe As DateTimePicker
    Friend WithEvents dtpAu As DateTimePicker
    Friend WithEvents lDe As Label
    Friend WithEvents lAu As Label
    Friend WithEvents bConfirmer As Button
    Friend WithEvents lTitre As Label
End Class
