Public Class Accueil
    Private Sub FaireUnEmpruntToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaireUnEmpruntToolStripMenuItem.Click
        'Dim emprunt As New PretAjout()
        'emprunt.Show()
    End Sub

    Private Sub buttonFaireEmprunt_Click(sender As Object, e As EventArgs) Handles buttonFaireEmprunt.Click
        'Dim emprunt As New PretAjout()
        'emprunt.Show()
    End Sub

    Private Sub HistoriqueDesEmpruntsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoriqueDesEmpruntsToolStripMenuItem.Click
        'Dim hist As New Prets()
        'hist.Show()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        End
    End Sub

    Private Sub FaireUnRetourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaireUnRetourToolStripMenuItem.Click
        Dim retour As New RetourAjout()
        retour.Show()
    End Sub

    Private Sub buttonFaireRetour_Click(sender As Object, e As EventArgs) Handles buttonFaireRetour.Click
        Dim retour As New RetourAjout()
        retour.Show()
    End Sub

    Private Sub HistoriqueDesRetoursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoriqueDesRetoursToolStripMenuItem.Click
        Dim hist As New Retours()
        hist.Show()
    End Sub

    Private Sub EmprunteurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmprunteurToolStripMenuItem.Click

    End Sub

    Private Sub buttonHistEmprunt_Click(sender As Object, e As EventArgs) Handles buttonHistEmprunt.Click
        Dim hist As New Prets()
        hist.Show()
    End Sub

    Private Sub buttonHistRetours_Click(sender As Object, e As EventArgs) Handles buttonHistRetours.Click
        Dim hist As New Retours()
        hist.ShowDialog()
    End Sub


    'FONCTIONS-------------------------------------------------------------------------------------------------------
    Public Sub role(role As String)
        MessageBox.Show("Un " & role & " vient de se connecter")
    End Sub
End Class