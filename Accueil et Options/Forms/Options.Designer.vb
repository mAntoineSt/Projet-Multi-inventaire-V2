<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.lTitre = New System.Windows.Forms.Label()
        Me.rbClair = New System.Windows.Forms.RadioButton()
        Me.gbVisuel = New System.Windows.Forms.GroupBox()
        Me.rbSombre = New System.Windows.Forms.RadioButton()
        Me.pHaut = New System.Windows.Forms.Panel()
        Me.lQuitter = New System.Windows.Forms.Label()
        Me.pBas = New System.Windows.Forms.Panel()
        Me.gbLangue = New System.Windows.Forms.GroupBox()
        Me.rbAnglais = New System.Windows.Forms.RadioButton()
        Me.rbFrancais = New System.Windows.Forms.RadioButton()
        Me.pLangue = New System.Windows.Forms.Panel()
        Me.pVisuel = New System.Windows.Forms.Panel()
        Me.gbVisuel.SuspendLayout()
        Me.pHaut.SuspendLayout()
        Me.gbLangue.SuspendLayout()
        Me.pLangue.SuspendLayout()
        Me.pVisuel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lTitre
        '
        Me.lTitre.AutoSize = True
        Me.lTitre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitre.ForeColor = System.Drawing.Color.White
        Me.lTitre.Location = New System.Drawing.Point(3, 7)
        Me.lTitre.Name = "lTitre"
        Me.lTitre.Size = New System.Drawing.Size(102, 28)
        Me.lTitre.TabIndex = 0
        Me.lTitre.Text = "Options"
        '
        'rbClair
        '
        Me.rbClair.AutoSize = True
        Me.rbClair.Checked = True
        Me.rbClair.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbClair.ForeColor = System.Drawing.Color.White
        Me.rbClair.Location = New System.Drawing.Point(13, 25)
        Me.rbClair.Name = "rbClair"
        Me.rbClair.Size = New System.Drawing.Size(137, 28)
        Me.rbClair.TabIndex = 1
        Me.rbClair.TabStop = True
        Me.rbClair.Text = "Mode Clair"
        Me.rbClair.UseVisualStyleBackColor = True
        '
        'gbVisuel
        '
        Me.gbVisuel.Controls.Add(Me.rbSombre)
        Me.gbVisuel.Controls.Add(Me.rbClair)
        Me.gbVisuel.ForeColor = System.Drawing.Color.White
        Me.gbVisuel.Location = New System.Drawing.Point(4, 3)
        Me.gbVisuel.Name = "gbVisuel"
        Me.gbVisuel.Padding = New System.Windows.Forms.Padding(0)
        Me.gbVisuel.Size = New System.Drawing.Size(296, 114)
        Me.gbVisuel.TabIndex = 1
        Me.gbVisuel.TabStop = False
        Me.gbVisuel.Text = "Mode visuel"
        '
        'rbSombre
        '
        Me.rbSombre.AutoSize = True
        Me.rbSombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.rbSombre.ForeColor = System.Drawing.Color.White
        Me.rbSombre.Location = New System.Drawing.Point(13, 67)
        Me.rbSombre.Name = "rbSombre"
        Me.rbSombre.Size = New System.Drawing.Size(168, 28)
        Me.rbSombre.TabIndex = 2
        Me.rbSombre.Text = "Mode Sombre"
        Me.rbSombre.UseVisualStyleBackColor = True
        '
        'pHaut
        '
        Me.pHaut.Controls.Add(Me.lQuitter)
        Me.pHaut.Controls.Add(Me.lTitre)
        Me.pHaut.Location = New System.Drawing.Point(0, 0)
        Me.pHaut.Name = "pHaut"
        Me.pHaut.Size = New System.Drawing.Size(322, 42)
        Me.pHaut.TabIndex = 6
        '
        'lQuitter
        '
        Me.lQuitter.AutoSize = True
        Me.lQuitter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lQuitter.ForeColor = System.Drawing.Color.White
        Me.lQuitter.Location = New System.Drawing.Point(290, 7)
        Me.lQuitter.Name = "lQuitter"
        Me.lQuitter.Size = New System.Drawing.Size(26, 28)
        Me.lQuitter.TabIndex = 1
        Me.lQuitter.Text = "X"
        '
        'pBas
        '
        Me.pBas.Location = New System.Drawing.Point(-1, 322)
        Me.pBas.Name = "pBas"
        Me.pBas.Size = New System.Drawing.Size(323, 20)
        Me.pBas.TabIndex = 7
        '
        'gbLangue
        '
        Me.gbLangue.Controls.Add(Me.rbAnglais)
        Me.gbLangue.Controls.Add(Me.rbFrancais)
        Me.gbLangue.ForeColor = System.Drawing.Color.White
        Me.gbLangue.Location = New System.Drawing.Point(6, 5)
        Me.gbLangue.Name = "gbLangue"
        Me.gbLangue.Padding = New System.Windows.Forms.Padding(0)
        Me.gbLangue.Size = New System.Drawing.Size(296, 114)
        Me.gbLangue.TabIndex = 3
        Me.gbLangue.TabStop = False
        Me.gbLangue.Text = "Langue"
        '
        'rbAnglais
        '
        Me.rbAnglais.AutoSize = True
        Me.rbAnglais.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.rbAnglais.ForeColor = System.Drawing.Color.White
        Me.rbAnglais.Location = New System.Drawing.Point(13, 67)
        Me.rbAnglais.Name = "rbAnglais"
        Me.rbAnglais.Size = New System.Drawing.Size(104, 28)
        Me.rbAnglais.TabIndex = 2
        Me.rbAnglais.Text = "Anglais"
        Me.rbAnglais.UseVisualStyleBackColor = True
        '
        'rbFrancais
        '
        Me.rbFrancais.AutoSize = True
        Me.rbFrancais.Checked = True
        Me.rbFrancais.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.rbFrancais.ForeColor = System.Drawing.Color.White
        Me.rbFrancais.Location = New System.Drawing.Point(13, 25)
        Me.rbFrancais.Name = "rbFrancais"
        Me.rbFrancais.Size = New System.Drawing.Size(116, 28)
        Me.rbFrancais.TabIndex = 1
        Me.rbFrancais.TabStop = True
        Me.rbFrancais.Text = "Français"
        Me.rbFrancais.UseVisualStyleBackColor = True
        '
        'pLangue
        '
        Me.pLangue.Controls.Add(Me.gbLangue)
        Me.pLangue.Location = New System.Drawing.Point(8, 190)
        Me.pLangue.Name = "pLangue"
        Me.pLangue.Size = New System.Drawing.Size(308, 126)
        Me.pLangue.TabIndex = 9
        '
        'pVisuel
        '
        Me.pVisuel.Controls.Add(Me.gbVisuel)
        Me.pVisuel.Location = New System.Drawing.Point(8, 57)
        Me.pVisuel.Name = "pVisuel"
        Me.pVisuel.Size = New System.Drawing.Size(308, 126)
        Me.pVisuel.TabIndex = 8
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 342)
        Me.Controls.Add(Me.pHaut)
        Me.Controls.Add(Me.pBas)
        Me.Controls.Add(Me.pLangue)
        Me.Controls.Add(Me.pVisuel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.gbVisuel.ResumeLayout(False)
        Me.gbVisuel.PerformLayout()
        Me.pHaut.ResumeLayout(False)
        Me.pHaut.PerformLayout()
        Me.gbLangue.ResumeLayout(False)
        Me.gbLangue.PerformLayout()
        Me.pLangue.ResumeLayout(False)
        Me.pVisuel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lTitre As Label
    Friend WithEvents rbClair As RadioButton
    Friend WithEvents gbVisuel As GroupBox
    Friend WithEvents rbSombre As RadioButton
    Friend WithEvents pHaut As Panel
    Friend WithEvents lQuitter As Label
    Friend WithEvents pBas As Panel
    Friend WithEvents gbLangue As GroupBox
    Friend WithEvents rbAnglais As RadioButton
    Friend WithEvents rbFrancais As RadioButton
    Friend WithEvents pLangue As Panel
    Friend WithEvents pVisuel As Panel
End Class
