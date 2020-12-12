'Importation nécessaire
Imports MySql.Data.MySqlClient

Public Class Supression_Periode_Donnees
    'Variables nécessaires
    Dim emplacement As Point
    Dim visuel As Integer = 0
    Dim con As MySqlConnection = New MySqlConnection("Server=localhost;Database=projet_multi;Uid=root;Pwd='';Port=3308;")
    Dim reader As MySqlDataReader
    Dim commande As New MySqlCommand

    'PARTIE DES PANELS--------------------------------------------------------------------------------------------------------------
    Private Sub pHaut_MouseDown(sender As Object, e As MouseEventArgs) Handles pHaut.MouseDown, lTitreHaut.MouseDown, lQuitter.MouseDown
        If e.Button = MouseButtons.Left Then
            emplacement = e.Location
        End If
    End Sub

    Private Sub pHaut_MouseMove(sender As Object, e As MouseEventArgs) Handles pHaut.MouseMove, lTitreHaut.MouseMove, lQuitter.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - emplacement
        End If
    End Sub

    Private Sub Supression_Periode_Donnees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If visuel = 0 Then
            pHaut.BackColor = ColorTranslator.FromHtml("#4b6584")
            pBas.BackColor = ColorTranslator.FromHtml("#4b6584")
            Me.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            lTitre.ForeColor = Color.Black
            lDe.ForeColor = Color.Black
            lAu.ForeColor = Color.Black
            bConfirmer.ForeColor = Color.Black
            bConfirmer.BackColor = ColorTranslator.FromHtml("#4d73a1")
        Else
            pHaut.BackColor = ColorTranslator.FromHtml("#252926")
            pBas.BackColor = ColorTranslator.FromHtml("#252926")
            Me.BackColor = ColorTranslator.FromHtml("#3c403d")
            lTitre.ForeColor = Color.White
            lDe.ForeColor = Color.White
            lAu.ForeColor = Color.White
            bConfirmer.ForeColor = Color.White
            bConfirmer.BackColor = ColorTranslator.FromHtml("#747d8c")
        End If
    End Sub

    Private Sub lQuitter_Click(sender As Object, e As EventArgs) Handles lQuitter.Click
        Me.Close()
    End Sub

    Private Sub bConfirmer_Click(sender As Object, e As EventArgs) Handles bConfirmer.Click
        'Demande si l'utilisateur veut vraiment supprimer les données servant aux statistiques
        If MessageBox.Show("Voulez-vous vraiment supprimer ces données servant aux statistiques dans cette plage horaire?", "Demande de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        'Supression dans la base de donnée
        Try
            commande.Connection = con
            commande.CommandText = "delete from journal_activites where date_activite between '" & dtpDe.Value.Year & "-" & dtpDe.Value.Month & "-" & dtpDe.Value.Day & "' and '" & dtpAu.Value.Year & "-" & dtpAu.Value.Month & "-" & dtpAu.Value.Day & "';"
            con.Open()
            commande.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            Return
        End Try
        MessageBox.Show("Les données ont été supprimés !", "Supression effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub dtpDe_ValueChanged(sender As Object, e As EventArgs) Handles dtpDe.ValueChanged
        dtpAu.MinDate = dtpAu.Value
    End Sub
End Class