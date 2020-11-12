Public Class PretAjout
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PretAjout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim search = RechercheTB.Text
        'EquipmentDGV.DataSource = New dbmultiEntities().equipements.Where(Function(equip) equip.etat.Equals("ok")).Where(Function(equip) equip.nom.Contains(search))
    End Sub

    Private Sub SauvegarderBtn_Click(sender As Object, e As EventArgs) Handles SauvegarderBtn.Click
        Dim eId = IdTb.Text
        Dim eNom = equipNomTb.Text
        Dim eDesc = equipDescTb.Text
        Dim eCat = equipCatTb.Text

        Dim iNom = indNomTb.Text
        Dim iPrenom = indPrenomTb.Text
        Dim iAddresse = indAddresseTb.Text
        Dim iDepartement = indDepartementTb.Text
        Dim iTel = indTelephoneTb.Text
        Dim iCourriel = indCourrielTb.Text

        Dim dEmprunt = dateEmprunt.Value
        Dim dRetour = dateRetour.Value

        'Dim pret = New pret()
        'pret.date_emprunt = Date.Now
        'pret.date_retour = dRetour
        'pret.id_equipement = eId
        'pret.id_emprunteur = 0
        'pret.id_preteur = 0


        'Dim prets = New dbmultiEntities().prets
        'Prets.Add(pret)
    End Sub
End Class
