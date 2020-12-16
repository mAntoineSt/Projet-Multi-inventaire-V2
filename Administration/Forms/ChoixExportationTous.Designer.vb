<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class choixExportationTous
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.components = New System.ComponentModel.Container()
        Me.bCSV = New System.Windows.Forms.Button()
        Me.tpMessageBoutons = New System.Windows.Forms.ToolTip(Me.components)
        Me.pHaut = New System.Windows.Forms.Panel()
        Me.lQuitter = New System.Windows.Forms.Label()
        Me.lTitreHaut = New System.Windows.Forms.Label()
        Me.pBas = New System.Windows.Forms.Panel()
        Me.lTitre = New System.Windows.Forms.Label()
        Me.bDoc = New System.Windows.Forms.Button()
        Me.pHaut.SuspendLayout()
        Me.SuspendLayout()
        '
        'bCSV
        '
        Me.bCSV.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.0!)
        Me.bCSV.Location = New System.Drawing.Point(40, 119)
        Me.bCSV.Name = "bCSV"
        Me.bCSV.Size = New System.Drawing.Size(120, 52)
        Me.bCSV.TabIndex = 0
        Me.bCSV.Text = "En .CSV"
        Me.bCSV.UseVisualStyleBackColor = True
        '
        'tpMessageBoutons
        '
        Me.tpMessageBoutons.ToolTipTitle = "Ce bouton sert à :"
        '
        'pHaut
        '
        Me.pHaut.Controls.Add(Me.lQuitter)
        Me.pHaut.Controls.Add(Me.lTitreHaut)
        Me.pHaut.Location = New System.Drawing.Point(-1, -1)
        Me.pHaut.Name = "pHaut"
        Me.pHaut.Size = New System.Drawing.Size(402, 43)
        Me.pHaut.TabIndex = 1
        '
        'lQuitter
        '
        Me.lQuitter.AutoSize = True
        Me.lQuitter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!)
        Me.lQuitter.ForeColor = System.Drawing.Color.White
        Me.lQuitter.Location = New System.Drawing.Point(375, 10)
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
        Me.pBas.Location = New System.Drawing.Point(-1, 194)
        Me.pBas.Name = "pBas"
        Me.pBas.Size = New System.Drawing.Size(402, 27)
        Me.pBas.TabIndex = 2
        '
        'lTitre
        '
        Me.lTitre.AutoSize = True
        Me.lTitre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.lTitre.Location = New System.Drawing.Point(16, 55)
        Me.lTitre.Name = "lTitre"
        Me.lTitre.Size = New System.Drawing.Size(368, 17)
        Me.lTitre.TabIndex = 3
        Me.lTitre.Text = "En quoi voulez-vous exporter toutes les données?"
        '
        'bDoc
        '
        Me.bDoc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.0!)
        Me.bDoc.Location = New System.Drawing.Point(241, 119)
        Me.bDoc.Name = "bDoc"
        Me.bDoc.Size = New System.Drawing.Size(120, 52)
        Me.bDoc.TabIndex = 4
        Me.bDoc.Text = "En .DOC"
        Me.bDoc.UseVisualStyleBackColor = True
        '
        'choixExportationTous
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 220)
        Me.Controls.Add(Me.bDoc)
        Me.Controls.Add(Me.lTitre)
        Me.Controls.Add(Me.pBas)
        Me.Controls.Add(Me.pHaut)
        Me.Controls.Add(Me.bCSV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "choixExportationTous"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "choixExportationTous"
        Me.pHaut.ResumeLayout(False)
        Me.pHaut.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bCSV As Button
    Friend WithEvents tpMessageBoutons As ToolTip
    Friend WithEvents pHaut As Panel
    Friend WithEvents pBas As Panel
    Friend WithEvents lTitreHaut As Label
    Friend WithEvents lQuitter As Label
    Friend WithEvents lTitre As Label
    Friend WithEvents bDoc As Button
End Class
