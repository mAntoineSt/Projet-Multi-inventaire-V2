Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Public Class EnregistrementMateriel

    Dim GestionBd As New ConnectBd
    Private strRequete As String = ""
    Private bd As ConnectBd = New ConnectBd
    Dim dsEquipement As New DataSet
    Dim daEquipement As New MySqlDataAdapter
    Dim idEquipement As Integer
    Dim connectionBD As New MySqlConnection(bd.ConnectionString)
    Public row As DataRow

    Public Sub EnregistrerMateriel()

        Dim cmdInsertMateriel As New MySqlCommand(strRequete, connectionBD)
        Dim reqAjoutMateriel As String
        Dim dateJour As Date
        dateJour = Date.Today


        reqAjoutMateriel = "INSERT INTO `equipements`(`marque`,
                                                        `modele`,
                                                        `noSerie`,
                                                        `fabricant`,
                                                        `categorie`,
                                                        `date_fabrication`,
                                                        `date_enregistrement`,
                                                        `fournisseur`,
                                                        `date_acquisition`,
                                                        `cout_achat`,
                                                        `valeur_residuelle`,
                                                        `no_antivol`,
                                                        `info_complement`)
                                                VALUES (@marque,
                                                        @modele,
                                                        @noSerie,
                                                        @fabricant,
                                                        @categorie,
                                                        @date_fabrication,
                                                        @date_enregistrement,
                                                        @fournisseur,
                                                        @date_acquisition, 
                                                        @cout_achat,
                                                        @valeur_residuelle,
                                                        @no_antivol,
                                                        @info_complement);"


        cmdInsertMateriel.Parameters.Add("@marque", MySqlDbType.String).Value = txtEnrMat_Marque.Text
        cmdInsertMateriel.Parameters.Add("@modele", MySqlDbType.String).Value = txtEnrMat_Modele.Text
        cmdInsertMateriel.Parameters.Add("@noSerie", MySqlDbType.String).Value = txtEnrMat_NoSerie.Text
        cmdInsertMateriel.Parameters.Add("@fabricant", MySqlDbType.String).Value = txtEnrMat_Fabricant.Text
        cmdInsertMateriel.Parameters.Add("@categorie", MySqlDbType.String).Value = cboEnrMat_Categorie.Text
        cmdInsertMateriel.Parameters.Add("@date_fabrication", MySqlDbType.Date).Value = dtpEnrMat_DateFabrict.Value
        cmdInsertMateriel.Parameters.Add("@date_enregistrement", MySqlDbType.Date).Value = dateJour
        cmdInsertMateriel.Parameters.Add("@fournisseur", MySqlDbType.String).Value = txtEnrMat_Fournisseur.Text
        cmdInsertMateriel.Parameters.Add("@date_acquisition", MySqlDbType.Date).Value = dtpEnrMat_DateAcquis.Value
        cmdInsertMateriel.Parameters.Add("@cout_achat", MySqlDbType.String).Value = txtEnrMat_CoutAchat.Text
        cmdInsertMateriel.Parameters.Add("@valeur_residuelle", MySqlDbType.String).Value = txtEnrMat_Valeur.Text
        cmdInsertMateriel.Parameters.Add("@no_antivol", MySqlDbType.String).Value = txtEnrMat_NoAntivol.Text
        cmdInsertMateriel.Parameters.Add("@info_complement", MySqlDbType.String).Value = rtxEnrMat_Notes.Text


        cmdInsertMateriel.CommandText = reqAjoutMateriel
        bd.Prepare_InsDelUpd(reqAjoutMateriel, cmdInsertMateriel, connectionBD)


        ViderChamps()

    End Sub


    Public Sub ModifMateriel()

        Dim cmdModifMateriel As New MySqlCommand(strRequete, connectionBD)
        Dim reqModifMateriel As String
        Dim dateJour As Date
        dateJour = Date.Today

        reqModifMateriel = "UPDATE `equipements`
                            SET  `marque` = '@marque', 
                                 `modele` = '@modele', 
                                 `noSerie` = '@noSerie',
                                 `fabricant` = '@fabricant'
                                 `categorie` = '@categorie', 
                                 `date_fabrication` = '@date_fabrication', 
                                 `date_enregistrement` = '@date_enregistrement',
                                 `fournisseur` = '@fournisseur'
                                 `date_acquisition` = '@date_acquisition', 
                                 `cout_achat` = '@cout_achat', 
                                 `valeur_residuelle` = '@valeur_residuelle',
                                 `no_antivol` = '@no_antivol',
                                 `info_complement` = '@info_complement'                    
                           WHERE `id_equipement` = " & idEquipement & ";"

        cmdModifMateriel.Parameters.Add("@marque", MySqlDbType.String).Value = txtEnrMat_Marque.Text
        cmdModifMateriel.Parameters.Add("@modele", MySqlDbType.String).Value = txtEnrMat_Modele.Text
        cmdModifMateriel.Parameters.Add("@noSerie", MySqlDbType.String).Value = txtEnrMat_NoSerie.Text
        cmdModifMateriel.Parameters.Add("@fabricant", MySqlDbType.String).Value = txtEnrMat_Fabricant.Text
        cmdModifMateriel.Parameters.Add("@categorie", MySqlDbType.String).Value = cboEnrMat_Categorie.Text
        cmdModifMateriel.Parameters.Add("@date_fabrication", MySqlDbType.Date).Value = dtpEnrMat_DateFabrict.Value
        cmdModifMateriel.Parameters.Add("@date_enregistrement", MySqlDbType.Date).Value = dateJour
        cmdModifMateriel.Parameters.Add("@fournisseur", MySqlDbType.String).Value = txtEnrMat_Fournisseur.Text
        cmdModifMateriel.Parameters.Add("@date_acquisition", MySqlDbType.Date).Value = dtpEnrMat_DateAcquis.Value
        cmdModifMateriel.Parameters.Add("@cout_achat", MySqlDbType.String).Value = txtEnrMat_CoutAchat.Text
        cmdModifMateriel.Parameters.Add("@valeur_residuelle", MySqlDbType.String).Value = txtEnrMat_Valeur.Text
        cmdModifMateriel.Parameters.Add("@no_antivol", MySqlDbType.String).Value = txtEnrMat_NoAntivol.Text
        cmdModifMateriel.Parameters.Add("@info_complement", MySqlDbType.String).Value = rtxEnrMat_Notes.Text


        cmdModifMateriel.CommandText = reqModifMateriel
        bd.Prepare_InsDelUpd(reqModifMateriel, cmdModifMateriel, connectionBD)

    End Sub



    Public Sub RemplirDatagridview_EnrMateriel()

        [dsEquipement].Tables.Clear()
        Dim reqAjoutMateriel As String
        reqAjoutMateriel = "SELECT id_equipement as idEq, marque as Marque, modele as Modele, fabricant as Fabricant FROM equipements"
        daEquipement = New MySqlDataAdapter(reqAjoutMateriel, bd.ConnectionString)
        daEquipement.Fill(dsEquipement, "equipements")
        dgvEnrMat.DataSource = dsEquipement.Tables("equipements")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvEnrMat.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgvEnrMat.Columns(0).Visible = False

    End Sub


    Public Sub RemplirChampFormulaire()
        Dim readerMateriel As MySqlDataReader
        Dim reqRemplirMateriel As String = "SELECT * FROM `equipements` WHERE `id_equipement` = '" & idEquipement & "';"


        connectionBD.Open()
        Dim cmdRechercheMateriel As New MySqlCommand(reqRemplirMateriel, connectionBD)
        readerMateriel = cmdRechercheMateriel.ExecuteReader
        If readerMateriel.HasRows Then
            readerMateriel.Read()


            'txtEnrMat_Identifiant.Text = readerMateriel("nom_artiste")
            txtEnrMat_Marque.Text = readerMateriel("marque")
            txtEnrMat_Modele.Text = readerMateriel("modele")
            txtEnrMat_NoSerie.Text = readerMateriel("noSerie")
            txtEnrMat_Fabricant.Text = readerMateriel("fabricant")
            cboEnrMat_Categorie.Text = readerMateriel("categorie")
            txtEnrMat_Fournisseur.Text = readerMateriel("fournisseur")
            txtEnrMat_CoutAchat.Text = readerMateriel("cout_achat")
            txtEnrMat_Valeur.Text = readerMateriel("valeur_residuelle")
            txtEnrMat_NoAntivol.Text = readerMateriel("no_antivol")
            rtxEnrMat_Notes.Text = readerMateriel("info_complement")
            dtpEnrMat_DateFabrict.Value = Convert.ToDateTime(readerMateriel("date_fabrication"))
            dtpEnrMat_DateAcquis.Value = Convert.ToDateTime(readerMateriel("date_enregistrement"))

        End If
        connectionBD.Close()
    End Sub

    Public Sub ObtenirIdEquipement()
        idEquipement = dgvEnrMat.Rows(dgvEnrMat.CurrentCell.RowIndex).Cells(0).Value
        RemplirChampFormulaire()
    End Sub



    Sub MiseAJourEquipement()
        bd.miseAjourDS(dsEquipement, daEquipement, "SELECT * FROM `equipements`", "equipements")
        bd.miseAjourBD(dsEquipement, daEquipement, "equipements")
    End Sub


    Public Sub ViderChamps()
        txtEnrMat_Marque.Text = ""
        txtEnrMat_Modele.Text = ""
        txtEnrMat_NoSerie.Text = ""

        txtEnrMat_Fabricant.Text = ""
        cboEnrMat_Categorie.Text = ""
        txtEnrMat_Fournisseur.Text = ""
        txtEnrMat_CoutAchat.Text = ""

        txtEnrMat_Valeur.Text = ""
        txtEnrMat_NoAntivol.Text = ""
        rtxEnrMat_Notes.Text = ""

        dtpEnrMat_DateFabrict.Value = Date.Today
        dtpEnrMat_DateAcquis.Value = Date.Today
    End Sub

    Public Sub InactiverChamps()
        txtEnrMat_Marque.Enabled = False
        txtEnrMat_Modele.Enabled = False
        txtEnrMat_NoSerie.Enabled = False

        txtEnrMat_Fabricant.Enabled = False
        cboEnrMat_Categorie.Enabled = False
        txtEnrMat_Fournisseur.Enabled = False
        txtEnrMat_CoutAchat.Enabled = False

        txtEnrMat_Valeur.Enabled = False
        txtEnrMat_NoAntivol.Enabled = False
        rtxEnrMat_Notes.Enabled = False

        dtpEnrMat_DateFabrict.Enabled = False
        dtpEnrMat_DateAcquis.Enabled = False
    End Sub

    Public Sub ActiverChamps()
        txtEnrMat_Marque.Enabled = True
        txtEnrMat_Modele.Enabled = True
        txtEnrMat_NoSerie.Enabled = True

        txtEnrMat_Fabricant.Enabled = True
        cboEnrMat_Categorie.Enabled = True
        txtEnrMat_Fournisseur.Enabled = True
        txtEnrMat_CoutAchat.Enabled = True

        txtEnrMat_Valeur.Enabled = True
        txtEnrMat_NoAntivol.Enabled = True
        rtxEnrMat_Notes.Enabled = True

        dtpEnrMat_DateFabrict.Enabled = True
        dtpEnrMat_DateAcquis.Enabled = True
    End Sub


    Private Sub BtnEnrMat_Annuler_Click(sender As Object, e As EventArgs) Handles btnEnrMat_Annuler.Click
        ViderChamps()
        InactiverChamps()
        btnEnrMat_Ajout.Text = "Ajouter"
        btnEnrMat_Modif.Enabled = True
        btnEnrMat_Modif.Text = "Modifier"
        btnEnrMat_Ajout.Enabled = True
    End Sub

    Private Sub BtnEnrMat_Ajout_Click(sender As Object, e As EventArgs) Handles btnEnrMat_Ajout.Click
        If btnEnrMat_Ajout.Enabled = True And String.Compare(btnEnrMat_Ajout.Text, "Ajouter") = 0 Then
            ActiverChamps()
            btnEnrMat_Ajout.Text = "Enregistrer"
            btnEnrMat_Modif.Enabled = False
        ElseIf btnEnrMat_Ajout.Enabled = True And String.Compare(btnEnrMat_Ajout.Text, "Enregistrer") = 0 Then
            'EnregistrerMateriel()
            InactiverChamps()
            btnEnrMat_Ajout.Text = "Ajouter"
            btnEnrMat_Modif.Enabled = True
        End If

    End Sub

    Private Sub BtnEnrMat_Modif_Click(sender As Object, e As EventArgs) Handles btnEnrMat_Modif.Click
        If btnEnrMat_Modif.Enabled = True And String.Compare(btnEnrMat_Modif.Text, "Modifier") = 0 Then
            ActiverChamps()
            btnEnrMat_Modif.Text = "Enregistrer"
            btnEnrMat_Ajout.Enabled = False
        ElseIf btnEnrMat_Modif.Enabled = True And String.Compare(btnEnrMat_Modif.Text, "Enregistrer") = 0 Then
            'EnregistrerMateriel()
            InactiverChamps()
            btnEnrMat_Modif.Text = "Modifier"
            btnEnrMat_Ajout.Enabled = True
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        RemplirDatagridview_EnrMateriel()
        InactiverChamps()
    End Sub

    Private Sub dgvEnrMat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnrMat.CellClick
        ObtenirIdEquipement()
    End Sub
End Class
