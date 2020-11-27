Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Public Class EntretienReparation


    Dim GestionBd As New ConnectBd
    Private strRequete As String = ""
    Private bd As ConnectBd = New ConnectBd
    Dim dsEquipement As New DataSet
    Dim daEquipement As New MySqlDataAdapter
    Dim dsEntRep As New DataSet
    Dim daEntRep As New MySqlDataAdapter
    Dim positEntRep As Integer

    Dim connectionBD As New MySqlConnection(bd.ConnectionString)

    Dim idEquipement As String
    Dim dateEntRep As Date
    Public row As DataRow



    Public Sub EnrEntretienReparation()

        Dim cmdInsertEntRep As New MySqlCommand(strRequete, connectionBD)
        Dim reqEntRep As String
        Dim valStatut As String
        Dim emprunt As Integer

        If rbtEntRep_Statut_Ent.Checked = True Then
            valStatut = "Entretien"
        ElseIf rbtEntRep_Statut_Rep.Checked = True Then
            valStatut = "Reparation"
        Else
            valStatut = "null"
        End If

        If String.IsNullOrEmpty(txtEntRep_Emprunt.Text) Then
            emprunt = 0

        Else
            emprunt = CInt(txtEntRep_Emprunt.Text)
        End If

        reqEntRep = "INSERT INTO `entretien_reparation`(`materiel`,
                                                        `date`,
                                                        `element`,
                                                        `montant`,
                                                        `statut`,
                                                        `emprunt`,
                                                        `note`)
                                                VALUES (@materiel,
                                                        @date,
                                                        @element,
                                                        @montant,
                                                        @statut,
                                                        @emprunt,
                                                        @note);"

        cmdInsertEntRep.Parameters.Add("@materiel", MySqlDbType.Int24).Value = idEquipement
        cmdInsertEntRep.Parameters.Add("@date", MySqlDbType.Date).Value = dtpEntRep_Date.Value
        cmdInsertEntRep.Parameters.Add("@element", MySqlDbType.String).Value = txtEntRep_Element.Text
        cmdInsertEntRep.Parameters.Add("@montant", MySqlDbType.NewDecimal).Value = txtEntRep_Montant.Text
        cmdInsertEntRep.Parameters.Add("@statut", MySqlDbType.String).Value = valStatut
        cmdInsertEntRep.Parameters.Add("@emprunt", MySqlDbType.Int24).Value = emprunt
        cmdInsertEntRep.Parameters.Add("@note", MySqlDbType.String).Value = rtxEntRep_Note.Text

        cmdInsertEntRep.CommandText = reqEntRep
        bd.Prepare_InsDelUpd(reqEntRep, cmdInsertEntRep, connectionBD)
        ViderChamps()
    End Sub

    Public Sub ModifEntRep()

        Dim cmdModifEntRep As New MySqlCommand(strRequete, connectionBD)
        Dim reqModifEntRep As String
        Dim valStatut As String
        Dim emprunt As Integer

        If rbtEntRep_Statut_Ent.Checked = True Then
            valStatut = "Entretien"
        ElseIf rbtEntRep_Statut_Rep.Checked = True Then
            valStatut = "Reparation"
        Else
            valStatut = "null"
        End If

        If String.IsNullOrEmpty(txtEntRep_Emprunt.Text) Then
            emprunt = 0

        Else
            emprunt = CInt(txtEntRep_Emprunt.Text)
        End If

        reqModifEntRep = "UPDATE `entretien_reparation`
                                SET  `materiel` =  @materiel,
                                     `date` =  @date,
                                     `element` = @element,
                                     `montant` =  @montant,
                                     `statut` =  @statut,
                                     `emprunt` =  @emprunt,
                                     `note` =  @note
                               WHERE `id_entretienReparation` = '@marque';"

        cmdModifEntRep.Parameters.Add("@materiel", MySqlDbType.Int24).Value = idEquipement
        cmdModifEntRep.Parameters.Add("@date", MySqlDbType.Date).Value = dtpEntRep_Date.Value
        cmdModifEntRep.Parameters.Add("@element", MySqlDbType.String).Value = txtEntRep_Element.Text
        cmdModifEntRep.Parameters.Add("@montant", MySqlDbType.NewDecimal).Value = txtEntRep_Montant.Text
        cmdModifEntRep.Parameters.Add("@statut", MySqlDbType.String).Value = valStatut
        cmdModifEntRep.Parameters.Add("@emprunt", MySqlDbType.Int24).Value = emprunt
        cmdModifEntRep.Parameters.Add("@note", MySqlDbType.String).Value = rtxEntRep_Note.Text


        cmdModifEntRep.CommandText = reqModifEntRep
        bd.Prepare_InsDelUpd(reqModifEntRep, cmdModifEntRep, connectionBD)

    End Sub

    Public Sub RemplirDatagridview_EnrMateriel()

        [dsEquipement].Tables.Clear()
        Dim reqAjoutMateriel As String
        reqAjoutMateriel = "SELECT `id_equipement` as idEq, `marque` as Marque, `modele` as Modele, `fabricant` as Fabricant FROM equipements;"
        daEquipement = New MySqlDataAdapter(reqAjoutMateriel, bd.ConnectionString)
        daEquipement.Fill(dsEquipement, "equipements")
        dgvEntRep_ListeMat.DataSource = dsEquipement.Tables("equipements")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvEntRep_ListeMat.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgvEntRep_ListeMat.Columns(0).Visible = False

    End Sub


    Public Sub RemplirDatagridview_HistoriqueEntRep()

        [dsEntRep].Tables.Clear()
        Dim reqHistoriqueEntRep As String
        reqHistoriqueEntRep = "SELECT er1.`id_entretienReparation` as idEntRep, ( SELECT distinct concat(marque, ' ', modele)
    											   FROM `equipements` eq
                                                   INNER JOIN `entretien_reparation` er2
                                                   ON eq.id_equipement = er2.materiel
                                                   WHERE er2.materiel = er1.materiel) as Materiel, 
                                er1.`date` as Date, statut as Type 
                                FROM `entretien_reparation` er1
                                WHERE er1.materiel =  " & idEquipement & " ;"



        daEntRep = New MySqlDataAdapter(reqHistoriqueEntRep, bd.ConnectionString)
        daEntRep.Fill(dsEntRep, "entretien_reparation")
        dgvEntRep_ListeRepEnt.DataSource = dsEntRep.Tables("entretien_reparation")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvEntRep_ListeRepEnt.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgvEntRep_ListeRepEnt.Columns(0).Visible = False

    End Sub



    Public Sub RemplirChampFormulaire()
        Dim readerMateriel As MySqlDataReader
        Dim reqRemplirMateriel As String = "SELECT concat(marque, ' ', modele) as marqueModele
                                              FROM `equipements`  
                                             WHERE `id_equipement` = '" & idEquipement & "';"

        connectionBD.Open()
        Dim cmdRechercheMateriel As New MySqlCommand(reqRemplirMateriel, connectionBD)
        readerMateriel = cmdRechercheMateriel.ExecuteReader
        If readerMateriel.HasRows Then
            readerMateriel.Read()
            txtEntRep_Materiel.Text = readerMateriel("marqueModele")
        End If
        connectionBD.Close()
    End Sub


    Public Sub RemplirChampFormulaireHisto()
        Dim readerMateriel As MySqlDataReader
        Dim reqRemplirMateriel As String = "SELECT  materiel,
                                                    date,
                                                    element,
                                                    montant,
                                                    statut,
                                                    emprunt,
                                                    note
                                                FROM `entretien_reparation`  
                                                WHERE `materiel` = '" & idEquipement & "'
                                                AND `date` = '" & dateEntRep & "';"

        connectionBD.Open()
        Dim cmdRechercheMateriel As New MySqlCommand(reqRemplirMateriel, connectionBD)
        readerMateriel = cmdRechercheMateriel.ExecuteReader
        If readerMateriel.HasRows Then
            readerMateriel.Read()


            txtEntRep_Materiel.Text = readerMateriel("materiel")
            dtpEntRep_Date.Value = Convert.ToDateTime(readerMateriel("date"))
            txtEntRep_Element.Text = readerMateriel("element")
            txtEntRep_Montant.Text = readerMateriel("montant")
            txtEntRep_Emprunt.Text = readerMateriel("emprunt")
            rtxEntRep_Note.Text = readerMateriel("note")


            If String.Compare(readerMateriel("statut"), "Reparation") = 0 Then
                rbtEntRep_Statut_Rep.Checked = True
            ElseIf String.Compare(readerMateriel("statut"), "Entretien") = 0 Then
                rbtEntRep_Statut_Ent.Checked = True
            End If
        End If
        connectionBD.Close()
    End Sub



    Public Sub ObtenirIdEquipement()
        If IsDBNull(dgvEntRep_ListeMat.Rows(dgvEntRep_ListeMat.CurrentCell.RowIndex).Cells(0).Value) = False Then
            idEquipement = dgvEntRep_ListeMat.Rows(dgvEntRep_ListeMat.CurrentCell.RowIndex).Cells(0).Value
        Else
            idEquipement = 0
        End If

        RemplirChampFormulaire()
    End Sub

    Public Sub ObtenirDateEntRep()
        If IsDBNull(dgvEntRep_ListeRepEnt.Rows(dgvEntRep_ListeRepEnt.CurrentCell.RowIndex).Cells(2).Value) = False Then
            idEquipement = Convert.ToDateTime(dgvEntRep_ListeRepEnt.Rows(dgvEntRep_ListeRepEnt.CurrentCell.RowIndex).Cells(2).Value)
        Else
            idEquipement = 0
        End If

        RemplirChampFormulaireHisto()
    End Sub


    Public Sub ViderChamps()

        txtEntRep_Materiel.Text = ""
        dtpEntRep_Date.Value = Date.Today
        txtEntRep_Element.Text = ""
        txtEntRep_Montant.Text = ""
        txtEntRep_Emprunt.Text = ""
        rtxEntRep_Note.Text = ""
        rbtEntRep_Statut_Rep.Checked = False
        rbtEntRep_Statut_Ent.Checked = False

    End Sub

    Public Sub InactiverChamps()
        txtEntRep_Materiel.Enabled = False
        dtpEntRep_Date.Enabled = False
        txtEntRep_Element.Enabled = False
        txtEntRep_Montant.Enabled = False
        txtEntRep_Emprunt.Enabled = False
        rtxEntRep_Note.Enabled = False
        rbtEntRep_Statut_Rep.Enabled = False
        rbtEntRep_Statut_Ent.Enabled = False
    End Sub

    Public Sub ActiverChamps()
        txtEntRep_Materiel.Enabled = True
        dtpEntRep_Date.Enabled = True
        txtEntRep_Element.Enabled = True
        txtEntRep_Montant.Enabled = True
        txtEntRep_Emprunt.Enabled = True
        rtxEntRep_Note.Enabled = True
        rbtEntRep_Statut_Rep.Enabled = True
        rbtEntRep_Statut_Ent.Enabled = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        RemplirDatagridview_EnrMateriel()
        InactiverChamps()
    End Sub

    Private Sub BtnEntRep_Modif_Click(sender As Object, e As EventArgs) Handles btnEntRep_Modif.Click
        If btnEntRep_Modif.Enabled = True And String.Compare(btnEntRep_Modif.Text, "Modifier") = 0 Then
            ActiverChamps()
            btnEntRep_Modif.Text = "Enregistrer"
            btnEntRep_Ajout.Enabled = False
        ElseIf btnEntRep_Modif.Enabled = True And String.Compare(btnEntRep_Modif.Text, "Enregistrer") = 0 Then
            'EnregistrerMateriel()
            InactiverChamps()
            btnEntRep_Modif.Text = "Modifier"
            btnEntRep_Ajout.Enabled = True
        End If
    End Sub

    Private Sub BtnEntRep_Ajout_Click(sender As Object, e As EventArgs) Handles btnEntRep_Ajout.Click
        If btnEntRep_Ajout.Enabled = True And String.Compare(btnEntRep_Ajout.Text, "Ajouter") = 0 Then
            ActiverChamps()
            btnEntRep_Ajout.Text = "Enregistrer"
            btnEntRep_Modif.Enabled = False
        ElseIf btnEntRep_Ajout.Enabled = True And String.Compare(btnEntRep_Ajout.Text, "Enregistrer") = 0 Then
            EnrEntretienReparation()
            InactiverChamps()
            btnEntRep_Ajout.Text = "Ajouter"
            btnEntRep_Modif.Enabled = True
        End If
    End Sub

    Private Sub BtnEntRep_Annuler_Click(sender As Object, e As EventArgs) Handles btnEntRep_Annuler.Click
        ViderChamps()
        InactiverChamps()
        btnEntRep_Ajout.Text = "Ajouter"
        btnEntRep_Modif.Enabled = True
        btnEntRep_Modif.Text = "Modifier"
        btnEntRep_Ajout.Enabled = True
    End Sub

    Private Sub dgvEntRep_ListeMat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntRep_ListeMat.CellClick
        ObtenirIdEquipement()
        RemplirDatagridview_HistoriqueEntRep()
    End Sub

    Private Sub dgvEntRep_ListeRepEnt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntRep_ListeRepEnt.CellClick
        ObtenirDateEntRep()
    End Sub
End Class
