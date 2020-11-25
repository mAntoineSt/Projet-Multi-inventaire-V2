'Importation nécessaire
Imports MySql.Data.MySqlClient

Public Class Gestion_Admins
    'Variables nécessaires
    Dim con As MySqlConnection = New MySqlConnection("Server=localhost;Database=projet_multi;Uid=root;Pwd='';Port=3308;")
    Dim reader As MySqlDataReader
    Dim commande As New MySqlCommand
    Dim table As New DataTable

    Private Sub bAjoutAdmin_Click(sender As Object, e As EventArgs) Handles bAjoutAdmin.Click
        Ajout_Modif_Admin.lTitre.Text = "Ajout Administrateur"
        Ajout_Modif_Admin.refreshAll()
        Ajout_Modif_Admin.ShowDialog()
        refreshDataGridView()
    End Sub

    Public Sub refreshDataGridView()
        Try
            commande.Connection = con
            commande.CommandText = "select * from individus where statut='admin';"
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
        dgvListeAdministrateurs.DataSource = table

    End Sub

    Private Sub bModifAdmin_Click(sender As Object, e As EventArgs) Handles bModifAdmin.Click
        If Not dgvListeAdministrateurs.Rows.Count = 0 Then
            For index As Integer = 0 To 8
                dgvListeAdministrateurs.Rows(dgvListeAdministrateurs.CurrentRow.Index).Cells(index).Selected = True
                Select Case index
                    Case 0
                        Ajout_Modif_Admin.tbMatricule.Text = dgvListeAdministrateurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbMatricule.ForeColor = Color.Black
                        Ajout_Modif_Admin.tbMatricule.Enabled = False
                    Case 1
                        Ajout_Modif_Admin.tbNom.Text = dgvListeAdministrateurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbNom.ForeColor = Color.Black
                    Case 2
                        Ajout_Modif_Admin.tbPrenom.Text = dgvListeAdministrateurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbPrenom.ForeColor = Color.Black
                    Case 3
                        'À ENLEVER
                        'Ajout_Modif_Admin.tbMatricule.Text = dgvListeAdministrateurs.CurrentCell.Value
                    Case 4
                        Ajout_Modif_Admin.tbDepartementService.Text = dgvListeAdministrateurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbDepartementService.ForeColor = Color.Black
                    Case 5
                        'ON S'EN FOUT FOR NOW
                        'Ajout_Modif_Admin.tbMatricule.Text = dgvListeAdministrateurs.CurrentCell.Value
                    Case 6
                        Ajout_Modif_Admin.tbCellulaire.Text = dgvListeAdministrateurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbCellulaire.ForeColor = Color.Black
                    Case 7
                        Ajout_Modif_Admin.tbCourriel.Text = dgvListeAdministrateurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbCourriel.ForeColor = Color.Black
                    Case 8
                        Ajout_Modif_Admin.tbMdp.Text = dgvListeAdministrateurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbMdp.ForeColor = Color.Black
                        Ajout_Modif_Admin.tbMdp.UseSystemPasswordChar = True
                        Ajout_Modif_Admin.tbConfirmationMdp.Text = dgvListeAdministrateurs.CurrentCell.Value
                        Ajout_Modif_Admin.tbConfirmationMdp.ForeColor = Color.Black
                        Ajout_Modif_Admin.tbConfirmationMdp.UseSystemPasswordChar = True
                End Select
            Next

            Ajout_Modif_Admin.lTitre.Text = "Modification Admin"
            Ajout_Modif_Admin.ShowDialog()

            refreshDataGridView()

        Else
            MessageBox.Show("Il n'y a aucun administrateur d'inscrit, veuillez en créer un pour effectuer cette action,", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub

    Private Sub bSuppressionAdmin_Click(sender As Object, e As EventArgs) Handles bSuppressionAdmin.Click
        If Not dgvListeAdministrateurs.Rows.Count = 0 Then
            dgvListeAdministrateurs.Rows(dgvListeAdministrateurs.CurrentRow.Index).Cells(0).Selected = True
            If MessageBox.Show("Voulez-vous vraiment supprimer cet administrateur? (Ayant le matricule " & dgvListeAdministrateurs.CurrentCell.Value & ")", "Supression d'administrateur", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    commande.Connection = con
                    commande.CommandText = "Delete from individus where id_individu='" & dgvListeAdministrateurs.CurrentCell.Value & "';"
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
            MessageBox.Show("Il n'y a aucun administrateur d'inscrit, veuillez en créer un", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

    End Sub
End Class
