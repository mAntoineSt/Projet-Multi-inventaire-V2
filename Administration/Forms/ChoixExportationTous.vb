Public Class choixExportationTous
    'Variables nécessaires
    Dim emplacement As Point
    Dim visuel As Integer = 0
    Private Sub bCSV_Click(sender As Object, e As EventArgs) Handles bCSV.Click
        Administration.exportationTousStatistiques(1)
        Me.Close()
    End Sub

    Private Sub bDoc_Click(sender As Object, e As EventArgs) Handles bDoc.Click
        Administration.exportationTousStatistiques(2)
        Me.Close()
    End Sub

    Private Sub bPdf_Click(sender As Object, e As EventArgs) Handles bPdf.Click
        Administration.exportationTousStatistiques(3)
        Me.Close()
    End Sub

    Private Sub choixExportationTous_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If visuel = 0 Then
            pHaut.BackColor = ColorTranslator.FromHtml("#4b6584")
            pBas.BackColor = ColorTranslator.FromHtml("#4b6584")
            Me.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            lTitre.ForeColor = Color.Black
            bCSV.ForeColor = Color.Black
            bDoc.ForeColor = Color.Black
            bPdf.ForeColor = Color.Black
            bCSV.BackColor = ColorTranslator.FromHtml("#4d73a1")
            bDoc.BackColor = ColorTranslator.FromHtml("#4d73a1")
            bPdf.BackColor = ColorTranslator.FromHtml("#4d73a1")
        Else
            pHaut.BackColor = ColorTranslator.FromHtml("#252926")
            pBas.BackColor = ColorTranslator.FromHtml("#252926")
            Me.BackColor = ColorTranslator.FromHtml("#3c403d")
            lTitre.ForeColor = Color.White
            bCSV.ForeColor = Color.White
            bDoc.ForeColor = Color.White
            bPdf.ForeColor = Color.White
            bCSV.BackColor = ColorTranslator.FromHtml("#747d8c")
            bDoc.BackColor = ColorTranslator.FromHtml("#747d8c")
            bPdf.BackColor = ColorTranslator.FromHtml("#747d8c")
        End If
    End Sub

    Private Sub lQuitter_Click(sender As Object, e As EventArgs) Handles lQuitter.Click
        Me.Close()
    End Sub

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
End Class