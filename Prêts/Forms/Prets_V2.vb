Imports MySql.Data.MySqlClient
Public Class Prets_V2

    Dim id_emprunteur As String
    Dim id_preteur As String
    Dim id_equipement As String
    Dim connexion As New MySqlConnection("database=projetmulti;datasource=localhost;port=3306;username=root;password=")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDateRetourPrevue.MinDate = DateTime.Now
        Dim mindate As New DateTime
        btValiderPret.Enabled = False
        mindate = DateTime.Now
        mindate.AddDays(1)
        dtpDatePret.MinDate = mindate
        testConnexionUtilisateur()
    End Sub

    Private Sub verificationValider()
        If (Not (tbPrenomInd.Text.Equals("")) And Not (tbNomInd.Text.Equals("")) And Not (tbNomEquip.Text.Equals("")) And Not (tbEtatEquip.Text.Equals(""))) Then
            btValiderPret.Enabled = True
        Else
            btValiderPret.Enabled = False
        End If
    End Sub

    Private Sub btValiderMatricule_Click(sender As Object, e As EventArgs) Handles btValiderMatricule.Click
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
        tbEtatEquip.Text = ""
        id_equipement = ""
        Try
            connexion.Open()
            Dim str As String = "SELECT * from equipements where id_equipement = """ & tbIdEquip.Text & """ AND "
            str = str + " etat = 'fonctionnel'"
            Dim command As MySqlCommand = New MySqlCommand(str, connexion)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                tbNomEquip.Text = reader.GetString(1)
                tbEtatEquip.Text = reader.GetString(2)
                id_equipement = tbIdEquip.Text
            End While
        Catch ex As Exception
            Console.WriteLine("Erreur : " & ex.ToString())
        Finally
            connexion.Close()
        End Try
        verificationValider()
    End Sub

    Private Sub btValiderPret_Click(sender As Object, e As EventArgs) Handles btValiderPret.Click
        Try
            connexion.Open()
            Dim command As New MySqlCommand()
            command.Connection = connexion
            command.CommandText = "INSERT INTO prets VALUES (@id_pret, @id_emprunteur, @id_preteur, @id_equipement, @date_emprunt, @date_retour)"
            command.Parameters.AddWithValue("@id_pret", 1)
            command.Parameters.AddWithValue("@id_emprunteur", id_emprunteur)
            command.Parameters.AddWithValue("@id_preteur", id_preteur)
            command.Parameters.AddWithValue("@id_equipement", id_equipement)
            command.Parameters.AddWithValue("@date_emprunt", dtpDatePret.Value)
            command.Parameters.AddWithValue("@date_retour", dtpDateRetourPrevue.Value)
            command.ExecuteNonQuery()
            Console.WriteLine("Prêt effectué avec succès")
        Catch ex As Exception
            Console.WriteLine("Erreur : " & ex.ToString())
        Finally
            connexion.Close()
        End Try
    End Sub

    Public Sub testConnexionUtilisateur()
        Try
            connexion.Open()
            Dim str As String = "SELECT * from individus where id_individu = '578788' AND statut >=2"
            Dim command As MySqlCommand = New MySqlCommand(str, connexion)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                lbUsername.Text = reader.GetString(2) & " " & reader.GetString(1)
                id_preteur = reader.GetString(0)
            End While
        Catch ex As Exception
            Console.WriteLine("Erreur : " & ex.ToString())
        Finally
            connexion.Close()
        End Try
    End Sub
End Class