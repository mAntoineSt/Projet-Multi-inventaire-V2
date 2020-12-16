'Importation nécessaire
Imports MySql.Data.MySqlClient

Public Class Gestion_Emprunteurs
    'Variables nécessaires
    Dim con As MySqlConnection = New MySqlConnection("Server=localhost;Database=projet_multi;Uid=root;Pwd='';Port=3308;")
    Dim reader As MySqlDataReader
    Dim commande As New MySqlCommand
    Dim table As New DataTable

    Private Sub bAjoutEmprunteurs_Click(sender As Object, e As EventArgs) Handles bAjoutEmprunteurs.Click
        Ajout_Modif_Admin.lTitre.Text = "Ajout Emprunteur"
        Ajout_Modif_Admin.refreshAll()
        Ajout_Modif_Admin.ShowDialog()
        refreshDataGridView()
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

    Private Sub bModifEmprunteurs_Click(sender As Object, e As EventArgs) Handles bModifEmprunteurs.Click
        If Not dgvListeEmprunteurs.Rows.Count = 0 Then
            For index As Integer = 0 To 8
                dgvListeEmprunteurs.Rows(dgvListeEmprunteurs.CurrentRow.Index).Cells(index).Selected = True
                Select Case index
                    Case 0
                        Ajout_Modif_Admin.tbMatricule.Text = dgvListeEmprunteurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbMatricule.ForeColor = Color.Black
                        Ajout_Modif_Admin.tbMatricule.Enabled = False
                    Case 1
                        Ajout_Modif_Admin.tbNom.Text = dgvListeEmprunteurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbNom.ForeColor = Color.Black
                    Case 2
                        Ajout_Modif_Admin.tbPrenom.Text = dgvListeEmprunteurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbPrenom.ForeColor = Color.Black
                    Case 3
                        'À ENLEVER
                        'Ajout_Modif_Admin.tbMatricule.Text = dgvListeAdministrateurs.CurrentCell.Value
                    Case 4
                        Ajout_Modif_Admin.tbDepartementService.Text = dgvListeEmprunteurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbDepartementService.ForeColor = Color.Black
                    Case 5
                        'ON S'EN FOUT FOR NOW
                        'Ajout_Modif_Admin.tbMatricule.Text = dgvListeAdministrateurs.CurrentCell.Value
                    Case 6
                        Ajout_Modif_Admin.tbCellulaire.Text = dgvListeEmprunteurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbCellulaire.ForeColor = Color.Black
                    Case 7
                        Ajout_Modif_Admin.tbCourriel.Text = dgvListeEmprunteurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbCourriel.ForeColor = Color.Black
                    Case 8
                        Ajout_Modif_Admin.tbMdp.Text = dgvListeEmprunteurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbMdp.ForeColor = Color.Black
                        Ajout_Modif_Admin.tbMdp.UseSystemPasswordChar = True
                        Ajout_Modif_Admin.tbConfirmationMdp.Text = dgvListeEmprunteurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbConfirmationMdp.ForeColor = Color.Black
                        Ajout_Modif_Admin.tbConfirmationMdp.UseSystemPasswordChar = True
                End Select
            Next

            Ajout_Modif_Admin.lTitre.Text = "Modification Emprunteur"
            Ajout_Modif_Admin.ShowDialog()

            refreshDataGridView()

        Else
            MessageBox.Show("Il n'y a aucun emprunteur d'inscrit, veuillez en créer un pour effectuer cette action,", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub

    Private Sub bSuppressionEmprunteurs_Click(sender As Object, e As EventArgs) Handles bSuppressionEmprunteurs.Click
        If Not dgvListeEmprunteurs.Rows.Count = 0 Then
            dgvListeEmprunteurs.Rows(dgvListeEmprunteurs.CurrentRow.Index).Cells(0).Selected = True
            If MessageBox.Show("Voulez-vous vraiment supprimer cet emprunteur? (Ayant le matricule " & dgvListeEmprunteurs.CurrentCell.Value & ")", "Supression d'emprunteurs", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    commande.Connection = con
                    commande.CommandText = "Delete from individus where id_individu='" & dgvListeEmprunteurs.CurrentCell.Value & "';"
                    con.Open()
                    commande.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    con.Close()
                    Return
                End Try
                refreshDataGridView()
                MessageBox.Show("Supression effectuée !")

            End If
        Else
            MessageBox.Show("Il n'y a aucun emprunteur d'inscrit, veuillez en créer un", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub

    Private Sub bDroitsEmprunteurs_Click(sender As Object, e As EventArgs) Handles bDroitsEmprunteurs.Click
        If MessageBox.Show("Voulez-vous vraiment enlever les droits à cet emprunteur?", "Droits à retirer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MessageBox.Show("Droits enlevées !", "Droits retirées à l'emprunteur", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Code pour enlever ou retirer ses droits
        End If
    End Sub
End Class
