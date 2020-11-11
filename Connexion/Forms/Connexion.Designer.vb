<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
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
        Me.LQuitter = New System.Windows.Forms.Label()
        Me.lTitrePage = New System.Windows.Forms.Label()
        Me.tbMdp = New System.Windows.Forms.TextBox()
        Me.tbMatricule = New System.Windows.Forms.TextBox()
        Me.pBas = New System.Windows.Forms.Panel()
        Me.LCreationCompte = New System.Windows.Forms.Label()
        Me.lMessageCreationCompte = New System.Windows.Forms.Label()
        Me.lMdpOublie = New System.Windows.Forms.Label()
        Me.bConfirmer = New System.Windows.Forms.Button()
        Me.pHaut.SuspendLayout()
        Me.pBas.SuspendLayout()
        Me.SuspendLayout()
        '
        'pHaut
        '
        Me.pHaut.Controls.Add(Me.LQuitter)
        Me.pHaut.Controls.Add(Me.lTitrePage)
        Me.pHaut.Location = New System.Drawing.Point(-1, -1)
        Me.pHaut.Name = "pHaut"
        Me.pHaut.Size = New System.Drawing.Size(351, 57)
        Me.pHaut.TabIndex = 11
        '
        'LQuitter
        '
        Me.LQuitter.AutoSize = True
        Me.LQuitter.BackColor = System.Drawing.Color.Transparent
        Me.LQuitter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LQuitter.ForeColor = System.Drawing.Color.White
        Me.LQuitter.Location = New System.Drawing.Point(302, 5)
        Me.LQuitter.Name = "LQuitter"
        Me.LQuitter.Size = New System.Drawing.Size(44, 46)
        Me.LQuitter.TabIndex = 1
        Me.LQuitter.Text = "X"
        '
        'lTitrePage
        '
        Me.lTitrePage.AutoSize = True
        Me.lTitrePage.BackColor = System.Drawing.Color.Transparent
        Me.lTitrePage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitrePage.ForeColor = System.Drawing.Color.White
        Me.lTitrePage.Location = New System.Drawing.Point(92, 12)
        Me.lTitrePage.Name = "lTitrePage"
        Me.lTitrePage.Size = New System.Drawing.Size(166, 33)
        Me.lTitrePage.TabIndex = 0
        Me.lTitrePage.Text = "Connexion"
        '
        'tbMdp
        '
        Me.tbMdp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMdp.ForeColor = System.Drawing.Color.LightGray
        Me.tbMdp.Location = New System.Drawing.Point(11, 144)
        Me.tbMdp.MaxLength = 25
        Me.tbMdp.Name = "tbMdp"
        Me.tbMdp.Size = New System.Drawing.Size(325, 31)
        Me.tbMdp.TabIndex = 9
        Me.tbMdp.TabStop = False
        Me.tbMdp.Text = "Mot de passe"
        '
        'tbMatricule
        '
        Me.tbMatricule.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMatricule.ForeColor = System.Drawing.Color.LightGray
        Me.tbMatricule.Location = New System.Drawing.Point(11, 87)
        Me.tbMatricule.MaximumSize = New System.Drawing.Size(10000, 10000)
        Me.tbMatricule.MaxLength = 7
        Me.tbMatricule.Name = "tbMatricule"
        Me.tbMatricule.Size = New System.Drawing.Size(325, 31)
        Me.tbMatricule.TabIndex = 8
        Me.tbMatricule.TabStop = False
        Me.tbMatricule.Text = "Utilisateur"
        '
        'pBas
        '
        Me.pBas.Controls.Add(Me.LCreationCompte)
        Me.pBas.Controls.Add(Me.lMessageCreationCompte)
        Me.pBas.Location = New System.Drawing.Point(-1, 314)
        Me.pBas.Name = "pBas"
        Me.pBas.Size = New System.Drawing.Size(351, 41)
        Me.pBas.TabIndex = 12
        '
        'LCreationCompte
        '
        Me.LCreationCompte.AutoSize = True
        Me.LCreationCompte.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.LCreationCompte.ForeColor = System.Drawing.Color.Black
        Me.LCreationCompte.Location = New System.Drawing.Point(256, 8)
        Me.LCreationCompte.Name = "LCreationCompte"
        Me.LCreationCompte.Padding = New System.Windows.Forms.Padding(5)
        Me.LCreationCompte.Size = New System.Drawing.Size(88, 26)
        Me.LCreationCompte.TabIndex = 1
        Me.LCreationCompte.Text = "Cliquez ici"
        '
        'lMessageCreationCompte
        '
        Me.lMessageCreationCompte.AutoSize = True
        Me.lMessageCreationCompte.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.lMessageCreationCompte.ForeColor = System.Drawing.Color.White
        Me.lMessageCreationCompte.Location = New System.Drawing.Point(7, 12)
        Me.lMessageCreationCompte.Name = "lMessageCreationCompte"
        Me.lMessageCreationCompte.Size = New System.Drawing.Size(218, 16)
        Me.lMessageCreationCompte.TabIndex = 0
        Me.lMessageCreationCompte.Text = "Votre compte n'a pas été créé?"
        '
        'lMdpOublie
        '
        Me.lMdpOublie.AutoSize = True
        Me.lMdpOublie.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!)
        Me.lMdpOublie.ForeColor = System.Drawing.Color.White
        Me.lMdpOublie.Location = New System.Drawing.Point(72, 190)
        Me.lMdpOublie.Name = "lMdpOublie"
        Me.lMdpOublie.Size = New System.Drawing.Size(202, 22)
        Me.lMdpOublie.TabIndex = 13
        Me.lMdpOublie.Text = "Mot de passe oublié?"
        '
        'bConfirmer
        '
        Me.bConfirmer.BackColor = System.Drawing.Color.Transparent
        Me.bConfirmer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConfirmer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.bConfirmer.ForeColor = System.Drawing.Color.White
        Me.bConfirmer.Location = New System.Drawing.Point(11, 232)
        Me.bConfirmer.Name = "bConfirmer"
        Me.bConfirmer.Size = New System.Drawing.Size(325, 62)
        Me.bConfirmer.TabIndex = 10
        Me.bConfirmer.TabStop = False
        Me.bConfirmer.Text = "CONFIRMER"
        Me.bConfirmer.UseVisualStyleBackColor = False
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 355)
        Me.Controls.Add(Me.pHaut)
        Me.Controls.Add(Me.bConfirmer)
        Me.Controls.Add(Me.tbMdp)
        Me.Controls.Add(Me.tbMatricule)
        Me.Controls.Add(Me.pBas)
        Me.Controls.Add(Me.lMdpOublie)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Connexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        Me.pHaut.ResumeLayout(False)
        Me.pHaut.PerformLayout()
        Me.pBas.ResumeLayout(False)
        Me.pBas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pHaut As Panel
    Friend WithEvents LQuitter As Label
    Friend WithEvents lTitrePage As Label
    Friend WithEvents tbMdp As TextBox
    Friend WithEvents tbMatricule As TextBox
    Friend WithEvents pBas As Panel
    Friend WithEvents LCreationCompte As Label
    Friend WithEvents lMessageCreationCompte As Label
    Friend WithEvents lMdpOublie As Label
    Friend WithEvents bConfirmer As Button
End Class
