'Importation nécessaire
Imports MySql.Data.MySqlClient

Public Class Gestion_Emprunteurs
    'Variables nécessaires
    Dim con As MySqlConnection = New MySqlConnection("Server=localhost;Database=projet_multi;Uid=root;Pwd='';Port=3308;")
    Dim reader As MySqlDataReader
    Dim commande As New MySqlCommand
    Dim table As New DataTable

    Private Sub bAjoutAdmin_Click(sender As Object, e As EventArgs) Handles bAjoutAdmin.Click
        Ajout_Modif_Admin.lTitre.Text = "Ajout Emprunteur"
        Ajout_Modif_Admin.ShowDialog()
    End Sub

    Public Sub refreshDataGridView()
        Try
            commande.Connection = con
            commande.CommandText = "select * from individus where statut='emprunteur';"
            con.Open()
            commande.Prepare()
            reader = commande.ExecuteReader
            table.Load(reader)
            reader.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            reader.Close()
        End Try
        dgvListeEmprunteurs.DataSource = table
    End Sub
End Class
