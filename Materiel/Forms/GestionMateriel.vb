Public Class GestionMateriel

    Dim ctrlEnrMateriel As New EnregistrementMateriel()
    Dim ctrlFicheMateriel As New FicheMateriel()




    Private Sub GestionMateriel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.pnlControle.Controls.Add(ctrlFicheMateriel)
        Me.pnlControle.Controls.Add(ctrlEnrMateriel)
    End Sub


    Private Sub btnLEnrModif_Materiel_Click(sender As Object, e As EventArgs) Handles btnLEnrModif_Materiel.Click
        If Me.Enabled Then
            ctrlEnrMateriel.Show()
            ctrlFicheMateriel.Hide()
        End If
    End Sub

    Private Sub btnFiche_Materiel_Click(sender As Object, e As EventArgs) Handles btnFiche_Materiel.Click
        If Me.Enabled Then
            ctrlEnrMateriel.Hide()
            ctrlFicheMateriel.Show()
        End If
    End Sub


End Class