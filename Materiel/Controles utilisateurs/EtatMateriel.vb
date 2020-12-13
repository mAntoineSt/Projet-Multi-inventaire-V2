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


    Dim validation As New Validation_Traitement()
    Dim etatGen As String
    Dim moteur As String
    Dim cablage As String
    Dim logiciel As String
    Dim notes As String
    Dim electro As Decimal
    Dim eau As Decimal
    Dim boitier As Decimal

    Public Sub EnrEtatMateriel()
        Dim cmdInsertEtatMateriel As New MySqlCommand(strRequete, connectionBD)
        Dim reqEtatMateriel As String

        If txtEtatMat_Emprunt.Text = "" Then
            txtEtatMat_Emprunt.Text = "0"
        End If


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


        cmdInsertEtatMateriel.Parameters.Add("@id_materiel", MySqlDbType.Int24).Value = idEquipement
        cmdInsertEtatMateriel.Parameters.Add("@date_inspection", MySqlDbType.Date).Value = dtpEtatMat_Date.Value
        cmdInsertEtatMateriel.Parameters.Add("@id_emprunt", MySqlDbType.Int24).Value = txtEtatMat_Emprunt.Text
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_EtatGeneral", MySqlDbType.String).Value = Replace(etatGen, ",", ".")
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_Boitier", MySqlDbType.String).Value = Replace(boitier, ",", ".")
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_Electronique", MySqlDbType.String).Value = Replace(electro, ",", ".")
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_Moteur", MySqlDbType.String).Value = Replace(moteur, ",", ".")
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_Cablage", MySqlDbType.String).Value = Replace(cablage, ",", ".")
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_Logiciel", MySqlDbType.String).Value = Replace(logiciel, ",", ".")
        cmdInsertEtatMateriel.Parameters.Add("@itemCout_Eau", MySqlDbType.String).Value = Replace(eau, ",", ".")
        cmdInsertEtatMateriel.Parameters.Add("@note", MySqlDbType.String).Value = notes


        cmdInsertEtatMateriel.CommandText = reqEtatMateriel
        bd.Prepare_InsDelUpd(reqEtatMateriel, cmdInsertEtatMateriel, connectionBD)

    End Sub


    Public Sub ModifEtatMateriel()
        Dim cmdModifEtatMateriel As New MySqlCommand(strRequete, connectionBD)
        Dim reqModifEtatMateriel As String

        reqModifEtatMateriel = "UPDATE `etat_materiel`          
                               SET   `date_inspection` =  @date_inspection,
                                     `id_emprunt` = @id_emprunt,
                                     `itemCout_EtatGeneral` =  @itemCout_EtatGeneral,
                                     `itemCout_Boitier` = @itemCout_Boitier,
                                     `itemCout_Electronique` =  @itemCout_Electronique,
                                     `itemCout_Moteur` = @itemCout_Moteur,
                                     `itemCout_Cablage` = @itemCout_Cablage,
                                     `itemCout_Logiciel` =  @itemCout_Logiciel,
                                     `itemCout_Eau` = @itemCout_Eau,
                                     `note` =  @note
                           WHERE `id_materiel` = " & idEquipement & ";"

        cmdModifEtatMateriel.Parameters.Add("@date_inspection", MySqlDbType.Date).Value = dtpEtatMat_Date.Value
        cmdModifEtatMateriel.Parameters.Add("@id_emprunt", MySqlDbType.Int24).Value = txtEtatMat_Emprunt.Text
        cmdModifEtatMateriel.Parameters.Add("@itemCout_EtatGeneral", MySqlDbType.String).Value = Replace(etatGen, ",", ".")
        cmdModifEtatMateriel.Parameters.Add("@itemCout_Boitier", MySqlDbType.String).Value = Replace(boitier, ",", ".")
        cmdModifEtatMateriel.Parameters.Add("@itemCout_Electronique", MySqlDbType.String).Value = Replace(electro, ",", ".")
        cmdModifEtatMateriel.Parameters.Add("@itemCout_Moteur", MySqlDbType.String).Value = Replace(moteur, ",", ".")
        cmdModifEtatMateriel.Parameters.Add("@itemCout_Cablage", MySqlDbType.String).Value = Replace(cablage, ",", ".")
        cmdModifEtatMateriel.Parameters.Add("@itemCout_Logiciel", MySqlDbType.String).Value = Replace(logiciel, ",", ".")
        cmdModifEtatMateriel.Parameters.Add("@itemCout_Eau", MySqlDbType.String).Value = Replace(eau, ",", ".")
        cmdModifEtatMateriel.Parameters.Add("@note", MySqlDbType.String).Value = notes


        cmdModifEtatMateriel.CommandText = reqModifEtatMateriel
        bd.Prepare_InsDelUpd(reqModifEtatMateriel, cmdModifEtatMateriel, connectionBD)

    End Sub

    Public Sub RemplirDatagridview_EnrMateriel()

        [dsEquipement].Tables.Clear()
        Dim reqAjoutMateriel As String
        reqAjoutMateriel = "SELECT id_equipement as idEq,
                                    marque as Marque,
                                    modele as Modele,
                                    fabricant as Fabricant
                            FROM equipements"

        daEquipement = New MySqlDataAdapter(reqAjoutMateriel, bd.ConnectionString)
        daEquipement.Fill(dsEquipement, "equipements")
        dgvEtatMat_ListeMat.DataSource = dsEquipement.Tables("equipements")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvEtatMat_ListeMat.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgvEtatMat_ListeMat.Columns(0).Visible = False
        dgvEtatMat_ListeMat.Columns(1).Width = 120
        dgvEtatMat_ListeMat.Columns(2).Width = 120
        dgvEtatMat_ListeMat.Columns(3).Width = 120
    End Sub

    Public Sub RemplirDatagridview_HistoriqueEtatMat()

        [dsEtatMateriel].Tables.Clear()
        Dim reqHistoriqueEtatMat As String
        'reqHistoriqueEtatMat = "SELECT `id_inspection` as idInspection,
        '                                `id_materiel` as Materiel,
        '                                `date_inspection` as Date 
        '                          FROM `etat_materiel`
        '                          WHERE id_materiel =  " & idEquipement & " ;"

        reqHistoriqueEtatMat = "SELECT et1.`id_inspection` as idInspection,( SELECT distinct concat(marque, ' ', modele)
    											   FROM `equipements` eq
                                                   INNER JOIN `etat_materiel` et2
                                                   ON eq.id_equipement = et2.id_materiel
                                                   WHERE et2.id_materiel = et1.id_materiel) as Materiel,
                                        et1.`date_inspection` as Date 
                                  FROM `etat_materiel` et1
                                  WHERE et1.id_materiel =" & idEquipement & " ;"

        daEtatMateriel = New MySqlDataAdapter(reqHistoriqueEtatMat, bd.ConnectionString)
        daEtatMateriel.Fill(dsEtatMateriel, "etat_materiel")
        dgvEtatMat_ListeEval.DataSource = dsEtatMateriel.Tables("etat_materiel")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvEtatMat_ListeEval.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgvEtatMat_ListeEval.Columns(0).Visible = False
        dgvEtatMat_ListeEval.Columns(1).Width = 240
        dgvEtatMat_ListeEval.Columns(2).Width = 240
    End Sub


    Public Sub RemplirChampFormulaire()
        ViderChamps()
        Dim readerMateriel As MySqlDataReader
        Dim reqRemplirMateriel As String = "SELECT concat(marque, ' ', modele) as marqueModele 
                                            FROM `equipements`  
                                            WHERE `id_equipement` = '" & idEquipement & "';"


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
        Dim reqRemplirMateriel As String = "SELECT concat(marque, ' ', modele) as marqueModele ,
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
                                                    FROM `etat_materiel` em
                                                    INNER JOIN `equipements` e
                                                    ON e.id_equipement = em.id_materiel
                                                WHERE `id_materiel` = '" & idEquipement & "'
                                                AND `date_inspection` = '" & dateEtatMat & "';"

        connectionBD.Open()
        Dim cmdRechercheMateriel As New MySqlCommand(reqRemplirMateriel, connectionBD)
        readerMateriel = cmdRechercheMateriel.ExecuteReader
        If readerMateriel.HasRows Then
            readerMateriel.Read()

            'BUG--> iF DBNull, ca plante, il faut s'assurer que les readers ne sont pas null;
            txtEtatMat_Materiel.Text = readerMateriel("marqueModele")
            dtpEtatMat_Date.Value = Convert.ToDateTime(readerMateriel("date_inspection"))
            txtEtatMat_Emprunt.Text = readerMateriel("id_emprunt")
            txtEtatMat_EtatGen.Text = readerMateriel("itemCout_EtatGeneral")
            txtEtatMat_Boitier.Text = readerMateriel("itemCout_Boitier") 'BUG-->: 'La conversion du type 'DBNull' en type 'String' n'est pas valide.'
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


    Public Function ValidationEtatMat() As Boolean
        Dim validForm As Boolean = False

        Dim validEtatGen As Boolean = False
        Dim validMoteur As Boolean = False
        Dim validCablage As Boolean = False
        Dim validLogiciel As Boolean = False
        Dim validNotes As Boolean = False
        Dim validElectro As Boolean = False
        Dim validEau As Boolean = False
        Dim validBoitier As Boolean = False


        If (validation.ValidNombreDecimal(txtEtatMat_EtatGen.Text) = True) Then
            etatGen = txtEtatMat_EtatGen.Text
            validEtatGen = True
        Else
            txtEtatMat_EtatGen.Text = "* Entrée non-valide."
            txtEtatMat_EtatGen.ForeColor = Color.Red
            validEtatGen = False
        End If

        If (validation.ValidNombreDecimal(txtEtatMat_Moteur.Text) = True) Then
            moteur = txtEtatMat_Moteur.Text
            validMoteur = True
        Else
            txtEtatMat_Moteur.Text = "* Entrée non-valide."
            txtEtatMat_Moteur.ForeColor = Color.Red
            validMoteur = False
        End If

        If (validation.ValidNombreDecimal(txtEtatMat_Cablage.Text) = True) Then
            cablage = txtEtatMat_Cablage.Text
            validCablage = True
        Else
            txtEtatMat_Cablage.Text = "* Entrée non-valide."
            txtEtatMat_Cablage.ForeColor = Color.Red
            validCablage = False
        End If


        If (validation.ValidNombreDecimal(txtEtatMat_Logiciel.Text) = True) Then
            logiciel = txtEtatMat_Logiciel.Text
            validLogiciel = True
        Else
            txtEtatMat_Logiciel.Text = "* Entrée non-valide."
            txtEtatMat_Logiciel.ForeColor = Color.Red
            validLogiciel = False
        End If

        If (validation.ValidNombreDecimal(txtEtatMat_Electro.Text) = True) Then
            electro = txtEtatMat_Electro.Text
            validElectro = True
        Else
            txtEtatMat_Electro.Text = "* Entrée non-valide."
            txtEtatMat_Electro.ForeColor = Color.Red
            validElectro = False
        End If

        If (validation.ValidNombreDecimal(txtEtatMat_Eau.Text) = True) Then
            eau = txtEtatMat_Eau.Text
            validEau = True
        Else
            txtEtatMat_Eau.Text = "* Entrée non-valide."
            txtEtatMat_Eau.ForeColor = Color.Red
            validEau = False
        End If

        If (validation.ValidNombreDecimal(txtEtatMat_Boitier.Text) = True) Then
            boitier = txtEtatMat_Boitier.Text
            validBoitier = True
        Else
            txtEtatMat_Boitier.Text = "* Entrée non-valide."
            txtEtatMat_Boitier.ForeColor = Color.Red
            validBoitier = False
        End If

        If (validation.ValidStringTousCaractere(rtxEtatMat_Notes.Text) = True) Then
            notes = rtxEtatMat_Notes.Text
            validNotes = True
        Else
            rtxEtatMat_Notes.Text = "* Entrée non-valide."
            rtxEtatMat_Notes.ForeColor = Color.Red
            validNotes = False
        End If



        If (validEtatGen = True And
            validMoteur = True And
            validCablage = True And
            validLogiciel = True And
            validNotes = True And
            validElectro = True And
            validEau = True And
            validBoitier = True) Then

            validForm = True
        Else
            validForm = False
        End If
        Return validForm
    End Function


    Public Sub reinitCouleur()
        txtEtatMat_Materiel.ForeColor = Color.Black
        dtpEtatMat_Date.ForeColor = Color.Black
        txtEtatMat_Emprunt.ForeColor = Color.Black
        txtEtatMat_EtatGen.ForeColor = Color.Black
        txtEtatMat_Boitier.ForeColor = Color.Black
        txtEtatMat_Electro.ForeColor = Color.Black
        txtEtatMat_Moteur.ForeColor = Color.Black
        txtEtatMat_Cablage.ForeColor = Color.Black
        txtEtatMat_Logiciel.ForeColor = Color.Black
        txtEtatMat_Eau.ForeColor = Color.Black
        rtxEtatMat_Notes.ForeColor = Color.Black
    End Sub



    Public Sub MessageBox_Enregistrer(e As EventArgs)
        Dim resultat = MessageBox.Show("Voulez-vous ajouter cette vérification?", "Prêt Équipement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (resultat = DialogResult.Yes) Then
            EnrEtatMateriel()
        End If
    End Sub

    Public Sub MessageBox_Modifier(e As EventArgs)
        Dim resultat = MessageBox.Show("Voulez-vous vraiment modifier cette vérification?", "Prêt Équipement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (resultat = DialogResult.Yes) Then
            ModifEtatMateriel()
        End If
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
            dateEtatMat = Convert.ToDateTime(dgvEtatMat_ListeEval.Rows(dgvEtatMat_ListeEval.CurrentCell.RowIndex).Cells(2).Value)
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
            If (ValidationEtatMat() = True) Then
                MessageBox_Enregistrer(e)
            End If
            reinitCouleur()
            InactiverChamps()
            ViderChamps()
            btnEtatMat_Ajout.Text = "Ajouter"
            btnEtatMat_Modif.Enabled = True
        End If
    End Sub

    Private Sub BtnEtatMat_Modif_Click(sender As Object, e As EventArgs) Handles btnEtatMat_Modif.Click
        If btnEtatMat_Modif.Enabled = True And String.Compare(btnEtatMat_Modif.Text, "Modifier") = 0 Then
            ActiverChamps()
            ViderChamps()
            btnEtatMat_Modif.Text = "Enregistrer"
            btnEtatMat_Ajout.Enabled = False
        ElseIf btnEtatMat_Modif.Enabled = True And String.Compare(btnEtatMat_Modif.Text, "Enregistrer") = 0 Then
            If (ValidationEtatMat() = True) Then
                MessageBox_Modifier(e)
            End If
            reinitCouleur()
            InactiverChamps()
            ViderChamps()
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
