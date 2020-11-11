Public Class Gestion_Emprunteurs
    Private Sub bAjoutAdmin_Click(sender As Object, e As EventArgs) Handles bAjoutAdmin.Click
        Ajout_Modif_Admin.Text = "Ajout Emprunteur"
        Ajout_Modif_Admin.ShowDialog()
    End Sub
End Class
