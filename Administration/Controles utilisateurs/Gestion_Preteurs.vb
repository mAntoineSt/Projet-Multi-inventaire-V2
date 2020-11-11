Public Class Gestion_Preteurs
    Private Sub bAjoutAdmin_Click(sender As Object, e As EventArgs) Handles bAjoutAdmin.Click
        Ajout_Modif_Admin.Text = "Ajout Prêteurs"
        Ajout_Modif_Admin.ShowDialog()
    End Sub
End Class
