Imports MySql.Data.MySqlClient
Public Class Form1
    Dim con As MySqlConnection = New MySqlConnection("Server=localhost;Database=projet_multi;Uid=root;Pwd='';Port=3308;")
    Dim reader As MySqlDataReader
    Dim commande As New MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            commande.Connection = con
            commande.CommandText = "Select * from individus;"
            con.Open()
            reader = commande.ExecuteReader
            While (reader.Read)
                MessageBox.Show(reader(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub
End Class
