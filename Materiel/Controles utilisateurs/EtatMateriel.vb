Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types



Public Class EtatMateriel

    Dim GestionBd As New ConnectBd
    Private strRequete As String = ""
    Private bd As ConnectBd = New ConnectBd
    Dim dsEquipement As New DataSet
    Dim daEquipement As New MySqlDataAdapter
    Dim dsEtatMateriel As New DataSet
    Dim daEtatMateriel As New MySqlDataAdapter

    Dim connectionBD As New MySqlConnection(bd.ConnectionString)

    Dim idEquipement As String
    Dim dateEtatMat As Date
    Public row As DataRow



    Public Sub EnrEtatMateriel()


        Dim cmdInsertEtatMateriel As New MySqlCommand(strRequete, connectionBD)
        Dim reqEtatMateriel As String

        reqEtatMateriel = "INSERT INTO `etat_materiel`( `id_materiel`,
                                                        `date_inspection`,
                                                        `id_emprunt`,
                                                        `itemCout_EtatGeneral`,
                                                        `itemCout_Boitier`,
                                                        `itemCout_Electronique`,
                                                        `itemCout_Moteur`,
                                                        `itemCout_Cablage`,
                                                        `itemCout_Logiciel`,
                                                        `itemCout_Eau`,
                                                        `note`)
                                              VALUES (  @id_materiel,
                                                        @date_inspection,
                                                        @id_emprunt,
                                                        @itemCout_EtatGeneral,
                                                        @itemCout_Boitier,
                                                        @itemCout_Electronique,
                                                        @itemCout_Moteur,
                                                        @itemCout_Cablage,
                                                        @itemCout_Logiciel,
                                                        @itemCout_Eau,
                                                        @note);"


        cmdInsertEtatMateriel.Parameters.Add("@id_materiel", MySqlDbType.Int24).Value = txtEtatMat_Materiel.Text
        cmdInsertEtatMateriel.Parameters.Add("@date_inspection", MySqlDbType.Date).Value = dtpEtatMat_Date.Value
        cmdInsertEtatMateriel.Parameters.Add("@id_emprunt", MySqlDbType.Int24).Value = txtEtatMat_Emprunt.Text
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_EtatGeneral", MySqlDbType.NewDecimal).Value = txtEtatMat_EtatGen.Text
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_Boitier", MySqlDbType.NewDecimal).Value = txtEtatMat_Boitier.Text
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_Electronique", MySqlDbType.NewDecimal).Value = txtEtatMat_Electro.Text
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_Moteur", MySqlDbType.NewDecimal).Value = txtEtatMat_Moteur.Text
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_Cablage", MySqlDbType.NewDecimal).Value = txtEtatMat_Cablage.Text
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_Logiciel", MySqlDbType.NewDecimal).Value = txtEtatMat_Logiciel.Text
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_Eau", MySqlDbType.NewDecimal).Value = txtEtatMat_Eau.Text
        cmdInsertEtatMateriel.Parameters.Add("@note", MySqlDbType.String).Value = rtxEtatMat_Notes.Text


        cmdInsertEtatMateriel.CommandText = reqEtatMateriel
        bd.Prepare_InsDelUpd(reqEtatMateriel, cmdInsertEtatMateriel, connectionBD)

    End Sub


    Public Sub ModifEtatMateriel()

        Dim cmdModifEtatMateriel As New MySqlCommand(strRequete, connectionBD)
        Dim reqModifEtatMateriel As String
        Dim dateJour As Date
        dateJour = Date.Today

        reqModifEtatMateriel = "UPDATE `etat_materiel`          
                               SET  `id_materiel` =  @id_materiel,
                                     `date_inspection` =  @date_inspection,
                                     `id_emprunt` = @id_emprunt,
                                     `itemCout_EtatGeneral` =  @itemCout_EtatGeneral,
                                     `itemCout_Boitier` = @itemCout_Boitier,
                                     `itemCout_Electronique` =  @itemCout_Electronique,
                                     `itemCout_Moteur` = @itemCout_Moteur,
                                     `itemCout_Cablage` = @itemCout_Cablage,
                                     `itemCout_Logiciel` =  @itemCout_Logiciel,
                                     `itemCout_Eau` = @itemCout_Eau,
                                     `note` =  @note
                           WHERE `id_equipement` = " & idEquipement & ";"

        cmdModifEtatMateriel.Parameters.Add("@id_materiel", MySqlDbType.Int24).Value = txtEtatMat_Materiel.Text
        cmdModifEtatMateriel.Parameters.Add("@date_inspection", MySqlDbType.Date).Value = dtpEtatMat_Date.Value
        cmdModifEtatMateriel.Parameters.Add("@id_emprunt", MySqlDbType.Int24).Value = txtEtatMat_Emprunt.Text
        cmdModifEtatMateriel.Parameters.Add("@itemCout_EtatGeneral", MySqlDbType.NewDecimal).Value = txtEtatMat_EtatGen.Text
        cmdModifEtatMateriel.Parameters.Add("@itemCout_Boitier", MySqlDbType.NewDecimal).Value = txtEtatMat_Boitier.Text
        cmdModifEtatMateriel.Parameters.Add("@itemCout_Electronique", MySqlDbType.NewDecimal).Value = txtEtatMat_Electro.Text
        cmdModifEtatMateriel.Parameters.Add("@itemCout_Moteur", MySqlDbType.NewDecimal).Value = txtEtatMat_Moteur.Text
        cmdModifEtatMateriel.Parameters.Add("@itemCout_Cablage", MySqlDbType.NewDecimal).Value = txtEtatMat_Cablage.Text
        cmdModifEtatMateriel.Parameters.Add("@itemCout_Logiciel", MySqlDbType.NewDecimal).Value = txtEtatMat_Logiciel.Text
        cmdModifEtatMateriel.Parameters.Add("@itemCout_Eau", MySqlDbType.NewDecimal).Value = txtEtatMat_Eau.Text
        cmdModifEtatMateriel.Parameters.Add("@note", MySqlDbType.String).Value = rtxEtatMat_Notes.Text

        cmdModifEtatMateriel.CommandText = reqModifEtatMateriel
        bd.Prepare_InsDelUpd(reqModifEtatMateriel, cmdModifEtatMateriel, connectionBD)

    End Sub

    Public Sub RemplirDatagridview_EnrMateriel()

        [dsEquipement].Tables.Clear()
        Dim reqAjoutMateriel As String
        reqAjoutMateriel = "SELECT id_equipement as idEq, marque as Marque, modele as Modele, fabricant as Fabricant FROM equipements"
        daEquipement = New MySqlDataAdapter(reqAjoutMateriel, bd.ConnectionString)
        daEquipement.Fill(dsEquipement, "equipements")
        dgvEtatMat_ListeMat.DataSource = dsEquipement.Tables("equipements")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvEtatMat_ListeMat.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgvEtatMat_ListeMat.Columns(0).Visible = False

    End Sub

    Public Sub RemplirDatagridview_HistoriqueEtatMat()

        [dsEtatMateriel].Tables.Clear()
        Dim reqHistoriqueEtatMat As String
        reqHistoriqueEtatMat = "SELECT `id_inspection` as idInspection, `id_materiel` as Materiel, `date_inspection` as Date 
                                  FROM `etat_materiel`
                                  WHERE id_materiel =  " & idEquipement & " ;"

        daEtatMateriel = New MySqlDataAdapter(reqHistoriqueEtatMat, bd.ConnectionString)
        daEtatMateriel.Fill(dsEtatMateriel, "etat_materiel")
        dgvEtatMat_ListeEval.DataSource = dsEtatMateriel.Tables("etat_materiel")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvEtatMat_ListeEval.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgvEtatMat_ListeEval.Columns(0).Visible = False

    End Sub


    Public Sub RemplirChampFormulaire()
        Dim readerMateriel As MySqlDataReader
        Dim reqRemplirMateriel As String = "SELECT concat(marque, ' ', modele) as marqueModele FROM `equipements`  WHERE `id_equipement` = '" & idEquipement & "';"


        connectionBD.Open()
        Dim cmdRechercheMateriel As New MySqlCommand(reqRemplirMateriel, connectionBD)
        readerMateriel = cmdRechercheMateriel.ExecuteReader
        If readerMateriel.HasRows Then
            readerMateriel.Read()
            txtEtatMat_Materiel.Text = readerMateriel("marqueModele")
        End If
        connectionBD.Close()
    End Sub


    Public Sub RemplirChampFormulaireHisto()
        Dim readerMateriel As MySqlDataReader
        Dim reqRemplirMateriel As String = "SELECT  id_materiel,
                                                    date_inspection,
                                                    id_emprunt,
                                                    itemCout_EtatGeneral,
                                                    itemCout_Boitier,
                                                    itemCout_Electronique,
                                                    itemCout_Moteur,
                                                    itemCout_Cablage,
                                                    itemCout_Logiciel,
                                                    itemCout_Eau,
                                                    note
                                                FROM `etat_materiel`  
                                                WHERE `id_materiel` = '" & idEquipement & "'
                                                AND `date_inspection` = '" & dateEtatMat & "';"

        connectionBD.Open()
        Dim cmdRechercheMateriel As New MySqlCommand(reqRemplirMateriel, connectionBD)
        readerMateriel = cmdRechercheMateriel.ExecuteReader
        If readerMateriel.HasRows Then
            readerMateriel.Read()


            txtEtatMat_Materiel.Text = readerMateriel("id_materiel")
            dtpEtatMat_Date.Value = Convert.ToDateTime(readerMateriel("date_inspection"))
            txtEtatMat_Emprunt.Text = readerMateriel("id_emprunt")
            txtEtatMat_EtatGen.Text = readerMateriel("itemCout_EtatGeneral")
            txtEtatMat_Boitier.Text = readerMateriel("itemCout_Boitier")
            txtEtatMat_Electro.Text = readerMateriel("itemCout_Electronique")
            txtEtatMat_Moteur.Text = readerMateriel("itemCout_Moteur")
            txtEtatMat_Cablage.Text = readerMateriel("itemCout_Cablage")
            txtEtatMat_Logiciel.Text = readerMateriel("itemCout_Logiciel")
            txtEtatMat_Eau.Text = readerMateriel("itemCout_Eau")
            rtxEtatMat_Notes.Text = readerMateriel("note")

        End If
        connectionBD.Close()
    End Sub

    Public Sub ViderChamps()
        txtEtatMat_Materiel.Text = ""
        dtpEtatMat_Date.Value = Date.Today
        txtEtatMat_Emprunt.Text = ""
        txtEtatMat_EtatGen.Text = ""
        txtEtatMat_Boitier.Text = ""
        txtEtatMat_Electro.Text = ""
        txtEtatMat_Moteur.Text = ""
        txtEtatMat_Cablage.Text = ""
        txtEtatMat_Logiciel.Text = ""
        txtEtatMat_Eau.Text = ""
        rtxEtatMat_Notes.Text = ""
    End Sub

    Public Sub InactiverChamps()
        txtEtatMat_Materiel.Enabled = False
        dtpEtatMat_Date.Enabled = False
        txtEtatMat_Emprunt.Enabled = False
        txtEtatMat_EtatGen.Enabled = False
        txtEtatMat_Boitier.Enabled = False
        txtEtatMat_Electro.Enabled = False
        txtEtatMat_Moteur.Enabled = False
        txtEtatMat_Cablage.Enabled = False
        txtEtatMat_Logiciel.Enabled = False
        txtEtatMat_Eau.Enabled = False
        rtxEtatMat_Notes.Enabled = False
    End Sub

    Public Sub ActiverChamps()
        txtEtatMat_Materiel.Enabled = True
        dtpEtatMat_Date.Enabled = True
        txtEtatMat_Emprunt.Enabled = True
        txtEtatMat_EtatGen.Enabled = True
        txtEtatMat_Boitier.Enabled = True
        txtEtatMat_Electro.Enabled = True
        txtEtatMat_Moteur.Enabled = True
        txtEtatMat_Cablage.Enabled = True
        txtEtatMat_Logiciel.Enabled = True
        txtEtatMat_Eau.Enabled = True
        rtxEtatMat_Notes.Enabled = True
    End Sub




    Public Sub ObtenirIdEquipement()
        If IsDBNull(dgvEtatMat_ListeMat.Rows(dgvEtatMat_ListeMat.CurrentCell.RowIndex).Cells(0).Value) = False Then
            idEquipement = CInt(dgvEtatMat_ListeMat.Rows(dgvEtatMat_ListeMat.CurrentCell.RowIndex).Cells(0).Value)
        Else
            idEquipement = 0
        End If
        RemplirChampFormulaire()
    End Sub

    Public Sub ObtenirDateEtatMat()
        If IsDBNull(dgvEtatMat_ListeEval.Rows(dgvEtatMat_ListeEval.CurrentCell.RowIndex).Cells(2).Value) = False Then
            idEquipement = Convert.ToDateTime(dgvEtatMat_ListeEval.Rows(dgvEtatMat_ListeEval.CurrentCell.RowIndex).Cells(2).Value)
        Else
            idEquipement = 0
        End If
        RemplirChampFormulaireHisto()
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        RemplirDatagridview_EnrMateriel()
        InactiverChamps()
    End Sub

    Private Sub BtnEtatMat_Annuler_Click(sender As Object, e As EventArgs) Handles btnEtatMat_Annuler.Click
        ViderChamps()
        InactiverChamps()
        btnEtatMat_Ajout.Text = "Ajouter"
        btnEtatMat_Modif.Enabled = True
        btnEtatMat_Modif.Text = "Modifier"
        btnEtatMat_Ajout.Enabled = True
    End Sub

    Private Sub BtnEtatMat_Ajout_Click(sender As Object, e As EventArgs) Handles btnEtatMat_Ajout.Click
        If btnEtatMat_Ajout.Enabled = True And String.Compare(btnEtatMat_Ajout.Text, "Ajouter") = 0 Then
            ActiverChamps()
            btnEtatMat_Ajout.Text = "Enregistrer"
            btnEtatMat_Modif.Enabled = False
        ElseIf btnEtatMat_Ajout.Enabled = True And String.Compare(btnEtatMat_Ajout.Text, "Enregistrer") = 0 Then
            'EnrEtatMateriel()
            InactiverChamps()
            btnEtatMat_Ajout.Text = "Ajouter"
            btnEtatMat_Modif.Enabled = True
        End If
    End Sub

    Private Sub BtnEtatMat_Modif_Click(sender As Object, e As EventArgs) Handles btnEtatMat_Modif.Click
        If btnEtatMat_Modif.Enabled = True And String.Compare(btnEtatMat_Modif.Text, "Modifier") = 0 Then
            ActiverChamps()
            btnEtatMat_Modif.Text = "Enregistrer"
            btnEtatMat_Ajout.Enabled = False
        ElseIf btnEtatMat_Modif.Enabled = True And String.Compare(btnEtatMat_Modif.Text, "Enregistrer") = 0 Then
            'EnregistrerMateriel()
            InactiverChamps()
            btnEtatMat_Modif.Text = "Modifier"
            btnEtatMat_Ajout.Enabled = True
        End If
    End Sub

    Private Sub dgvEtatMat_ListeMat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEtatMat_ListeMat.CellClick
        ObtenirIdEquipement()
        RemplirDatagridview_HistoriqueEtatMat()
    End Sub

    Private Sub dgvEtatMat_ListeEval_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEtatMat_ListeEval.CellClick
        ObtenirDateEtatMat()
    End Sub
End Class
