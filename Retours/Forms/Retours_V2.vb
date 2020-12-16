Imports MySql.Data.MySqlClient
Public Class Retours_V2
    Dim id_emprunteur As String
    Dim id_preteur As String
    Dim id_equipement As String
    Dim connexion As New MySqlConnection("database=projetmulti;datasource=localhost;port=3306;username=root;password=")
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbEtatEquip.Enabled = False
        btValiderRetour.Enabled = False
        cbEtatEquip.SelectedItem = "fonctionnel"
        dtpDateRetour.Value = DateTime.Now
        testConnexionUtilisateur()
    End Sub

    Public Sub testConnexionUtilisateur()
        Try
            connexion.Open()
            Dim str As String = "SELECT * from individus where id_individu = '578788' AND statut >=2"
            Dim command As MySqlCommand = New MySqlCommand(str, connexion)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                lbNomUtilisateur.Text = reader.GetString(2) & " " & reader.GetString(1)
                id_preteur = reader.GetString(0)
            End While
        Catch ex As Exception
            Console.WriteLine("Erreur : " & ex.ToString())
        Finally
            connexion.Close()
        End Try
    End Sub

    Private Sub verificationValider()
        If (Not (tbPrenomInd.Text.Equals("")) And Not (tbNomInd.Text.Equals("")) And Not (tbNomEquip.Text.Equals(""))) Then
            btValiderRetour.Enabled = True
        Else
            btValiderRetour.Enabled = False
        End If
    End Sub

    Private Sub btValiderEmp_Click(sender As Object, e As EventArgs) Handles btValiderEmp.Click
        tbNomInd.Text = ""
        tbPrenomInd.Text = ""
        id_emprunteur = ""
        Try
            connexion.Open()
            Dim str As String = "SELECT * from individus where id_individu = """ & tbMatriculeInd.Text & """ AND statut >=0"
            Dim command As MySqlCommand = New MySqlCommand(str, connexion)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                tbNomInd.Text = reader.GetString(1)
                tbPrenomInd.Text = reader.GetString(2)
                id_emprunteur = tbMatriculeInd.Text
            End While
        Catch ex As Exception
            Console.WriteLine("Erreur : " & ex.ToString())
        Finally
            connexion.Close()
        End Try
        verificationValider()
    End Sub

    Private Sub btValiderEquip_Click(sender As Object, e As EventArgs) Handles btValiderEquip.Click
        tbNomEquip.Text = ""
        cbEtatEquip.SelectedItem = "fonctionnel"
        cbEtatEquip.Enabled = False
        id_equipement = ""
        Try
            connexion.Open()
            Dim str As String = "SELECT * from equipements where id_equipement = """ & tbIdEquip.Text & """ AND "
            str = str + " etat = 'fonctionnel'"
            Dim command As MySqlCommand = New MySqlCommand(str, connexion)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                tbNomEquip.Text = reader.GetString(1)
                cbEtatEquip.Enabled = True
                id_equipement = tbIdEquip.Text
            End While
        Catch ex As Exception
            Console.WriteLine("Erreur : " & ex.ToString())
        Finally
            connexion.Close()
        End Try
        verificationValider()
    End Sub

    Private Sub btValiderRetour_Click(sender As Object, e As EventArgs) Handles btValiderRetour.Click
        Try
            connexion.Open()
            Dim command As New MySqlCommand()
            command.Connection = connexion
            command.CommandText = "INSERT INTO retours VALUES (@id_retour, @id_emprunteur, @id_preteur, @id_equipement, @date_retour_prevue, @date_retour)"
            command.Parameters.AddWithValue("@id_retour", 1)
            command.Parameters.AddWithValue("@id_emprunteur", id_emprunteur)
            command.Parameters.AddWithValue("@id_preteur", id_preteur)
            command.Parameters.AddWithValue("@id_equipement", id_equipement)
            command.Parameters.AddWithValue("@date_retour_prevue", dtpDateRetourPrevue.Value)
            dtpDateRetour.Value = DateTime.Now
            command.Parameters.AddWithValue("@date_retour", dtpDateRetour.Value)
            command.ExecuteNonQuery()
            Console.WriteLine("Prêt effectué avec succès")
        Catch ex As Exception
            Console.WriteLine("Erreur : " & ex.ToString())
        Finally
            connexion.Close()
        End Try
    End Sub
End Class