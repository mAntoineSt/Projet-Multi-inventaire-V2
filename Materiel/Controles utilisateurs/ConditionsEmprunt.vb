Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Public Class ConditionsEmprunt

    Private strRequete As String = ""
    Private bd As ConnectBd = New ConnectBd
    Dim connectionBD As New MySqlConnection(bd.ConnectionString)

    Dim dsCondEmprunt As New DataSet
    Dim daCondEmprunt As New MySqlDataAdapter
    Dim dsEquipement As New DataSet
    Dim daEquipement As New MySqlDataAdapter

    Dim idCondEmprunt As Integer
    Dim idEquipement As Integer

    Public row As DataRow



    Public Sub EnrCondEmprunt()
        Dim cmdInsertCondEmprunt As New MySqlCommand(strRequete, connectionBD)
        Dim reqCondEmprunt As String

        reqCondEmprunt = "INSERT INTO `conditions_equipements`(`id_equipement`,
                                                                `id_condition`)
                                                        VALUES (@id_equipement,
                                                                @id_condition);"

        cmdInsertCondEmprunt.Parameters.Add("@id_equipement", MySqlDbType.Int24).Value = idEquipement
        cmdInsertCondEmprunt.Parameters.Add("@id_condition", MySqlDbType.Int24).Value = idCondEmprunt

        cmdInsertCondEmprunt.CommandText = reqCondEmprunt
        bd.Prepare_InsDelUpd(reqCondEmprunt, cmdInsertCondEmprunt, connectionBD)
        ViderChamps()
    End Sub


    Public Sub ModifCondEmprunt()
        Dim cmdModifCondEmprunt As New MySqlCommand(strRequete, connectionBD)
        Dim reqModifCondEmprunt As String

        reqModifCondEmprunt = "UPDATE `conditions_equipements`
                                    SET  `id_equipement` = '@id_equipement', 
                                         `id_condition` = '@id_condition',            
                                   WHERE `id_condition` = '@id_condition';"

        cmdModifCondEmprunt.Parameters.Add("@id_equipement", MySqlDbType.String).Value = idEquipement
        cmdModifCondEmprunt.Parameters.Add("@id_condition", MySqlDbType.String).Value = idCondEmprunt

        cmdModifCondEmprunt.CommandText = reqModifCondEmprunt
        bd.Prepare_InsDelUpd(reqModifCondEmprunt, cmdModifCondEmprunt, connectionBD)

    End Sub


    Public Sub RemplirDatagridview_Materiel()

        [dsEquipement].Tables.Clear()
        Dim reqMateriel As String
        reqMateriel = "SELECT id_equipement as idEq, marque as Marque, modele as Modele, fabricant as Fabricant FROM equipements"
        daEquipement = New MySqlDataAdapter(reqMateriel, bd.ConnectionString)
        daEquipement.Fill(dsEquipement, "equipements")
        dgvCondEmp_ListeMat.DataSource = dsEquipement.Tables("equipements")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvCondEmp_ListeMat.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgvCondEmp_ListeMat.Columns(0).Visible = False

    End Sub

    Public Sub RemplirDatagridview_ConditionMateriel()

        [dsCondEmprunt].Tables.Clear()
        Dim reqConditionMat As String
        reqConditionMat = " SELECT distinct description as Conditions_du_Pret
                                    FROM conditions c
                                    INNER JOIN conditions_equipements ce
                                    ON c.id_condition = ce.id_condition
                                    WHERE c.id_condition IN (SELECT ce.id_condition
                                                             FROM conditions_equipements ce
                                                             WHERE ce.id_equipement = " & idEquipement & ");"


        daCondEmprunt = New MySqlDataAdapter(reqConditionMat, bd.ConnectionString)
        daCondEmprunt.Fill(dsCondEmprunt, "conditions_equipements")
        dgvCondEmp_ListeCond.DataSource = dsCondEmprunt.Tables("conditions_equipements")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvCondEmp_ListeCond.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgvCondEmp_ListeCond.Columns(0).Width = 800

    End Sub





    Public Sub RemplirLsvCondition()

        Dim reqLsbCondition As String = "Select * FROM `conditions`;"
        Dim cmd As New MySqlCommand(reqLsbCondition, connectionBD)
        Dim daCondEmprunt As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable("conditions")
        daCondEmprunt.Fill(dt)


        Dim newrow As DataRow
        For Each newrow In dt.Rows
            lsvCondEmp_RechCond.Items.Add(newrow.Item(0).ToString)
            lsvCondEmp_RechCond.Items(lsvCondEmp_RechCond.Items.Count - 1).SubItems.Add(newrow.Item(1).ToString)
            lsvCondEmp_RechCond.Items(lsvCondEmp_RechCond.Items.Count - 1).SubItems.Add(newrow.Item(2).ToString)
        Next

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
            txtCondEmp_Materiel.Text = readerMateriel("marqueModele")
        End If
        connectionBD.Close()
    End Sub

    Public Sub RechercheCondition()

        Dim reqLsbConditionRecherche As String = "SELECT * FROM `conditions`
                                                  WHERE `description` LIKE '%" & txtCondEmp_RechCond.Text & "%' ;"

        Dim cmd As New MySqlCommand(reqLsbConditionRecherche, connectionBD)
        Dim daCondEmprunt As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable("conditions")
        daCondEmprunt.Fill(dt)

        Dim newrow As DataRow
        For Each newrow In dt.Rows
            lsvCondEmp_RechCond.Items.Add(newrow.Item(0).ToString)
            lsvCondEmp_RechCond.Items(lsvCondEmp_RechCond.Items.Count - 1).SubItems.Add(newrow.Item(1).ToString)
            lsvCondEmp_RechCond.Items(lsvCondEmp_RechCond.Items.Count - 1).SubItems.Add(newrow.Item(2).ToString)
        Next
    End Sub





    Public Sub ObtenirIdCondition()
        idCondEmprunt = CInt(lsvCondEmp_RechCond.Items(lsvCondEmp_RechCond.FocusedItem.Index).SubItems(0).Text)
        txtCondEmp_Condition.Text = lsvCondEmp_RechCond.Items(lsvCondEmp_RechCond.FocusedItem.Index).SubItems(1).Text
    End Sub

    Public Sub ObtenirIdEquipement()
        If IsDBNull(dgvCondEmp_ListeMat.Rows(dgvCondEmp_ListeMat.CurrentCell.RowIndex).Cells(0).Value) = False Then
            idEquipement = CInt(dgvCondEmp_ListeMat.Rows(dgvCondEmp_ListeMat.CurrentCell.RowIndex).Cells(0).Value)
        Else
            idEquipement = 0
        End If

        RemplirChampFormulaire()
        RemplirDatagridview_ConditionMateriel()
    End Sub


    Public Sub ViderChamps()
        txtCondEmp_Materiel.Text = ""
        txtCondEmp_Condition.Text = ""
    End Sub

    Public Sub InactiverChamps()
        txtCondEmp_Materiel.Enabled = False
        txtCondEmp_Condition.Enabled = False
        lsvCondEmp_RechCond.Enabled = False
        txtCondEmp_RechCond.Enabled = False
        btnCondEmp_RechCond.Enabled = False
    End Sub

    Public Sub ActiverChamps()
        txtCondEmp_Materiel.Enabled = True
        txtCondEmp_Condition.Enabled = True
        lsvCondEmp_RechCond.Enabled = True
        txtCondEmp_RechCond.Enabled = True
        btnCondEmp_RechCond.Enabled = True
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        lsvCondEmp_RechCond.Items.Clear()
        RemplirLsvCondition()
        RemplirDatagridview_Materiel()
        InactiverChamps()
    End Sub


    Private Sub BtnCondEmp_CreerCond_Click(sender As Object, e As EventArgs) Handles btnCondEmp_CreerCond.Click
        If Me.Enabled Then
            CreationModifCondition.Show()
        End If
    End Sub

    Private Sub BtnCondEmp_Modif_Click(sender As Object, e As EventArgs) Handles btnCondEmp_Modif.Click
        If btnCondEmp_Modif.Enabled = True And String.Compare(btnCondEmp_Modif.Text, "Modifier") = 0 Then
            ActiverChamps()
            btnCondEmp_Modif.Text = "Enregistrer"
            btnCondEmp_Ajout.Enabled = False
        ElseIf btnCondEmp_Modif.Enabled = True And String.Compare(btnCondEmp_Modif.Text, "Enregistrer") = 0 Then
            ModifCondEmprunt()
            InactiverChamps()
            btnCondEmp_Modif.Text = "Modifier"
            btnCondEmp_Ajout.Enabled = True
        End If
    End Sub

    Private Sub BtnCondEmp_Ajout_Click(sender As Object, e As EventArgs) Handles btnCondEmp_Ajout.Click
        If btnCondEmp_Ajout.Enabled = True And String.Compare(btnCondEmp_Ajout.Text, "Ajouter") = 0 Then
            ActiverChamps()
            btnCondEmp_Ajout.Text = "Enregistrer"
            btnCondEmp_Modif.Enabled = False
        ElseIf btnCondEmp_Ajout.Enabled = True And String.Compare(btnCondEmp_Ajout.Text, "Enregistrer") = 0 Then
            EnrCondEmprunt()
            InactiverChamps()
            btnCondEmp_Ajout.Text = "Ajouter"
            btnCondEmp_Modif.Enabled = True
        End If
    End Sub

    Private Sub BtnCondEmp_Annuler_Click(sender As Object, e As EventArgs) Handles btnCondEmp_Annuler.Click
        ViderChamps()
        InactiverChamps()
        btnCondEmp_Ajout.Text = "Ajouter"
        btnCondEmp_Modif.Enabled = True
        btnCondEmp_Modif.Text = "Modifier"
        btnCondEmp_Ajout.Enabled = True
    End Sub


    Private Sub lsvCondEmp_RechCond_MouseClick(sender As Object, e As MouseEventArgs) Handles lsvCondEmp_RechCond.MouseClick

    End Sub

    Private Sub lsvCondEmp_RechCond_Click(sender As Object, e As EventArgs) Handles lsvCondEmp_RechCond.Click
        ObtenirIdCondition()
    End Sub

    Private Sub dgvCondEmp_ListeMat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCondEmp_ListeMat.CellClick
        ObtenirIdEquipement()
    End Sub

    Private Sub BtnCondEmp_RechCond_Click(sender As Object, e As EventArgs) Handles btnCondEmp_RechCond.Click
        If btnCondEmp_RechCond.Enabled = True And String.Compare(btnCondEmp_RechCond.Text, "Recherche") = 0 Then
            lsvCondEmp_RechCond.Items.Clear()
            RechercheCondition()
            btnCondEmp_RechCond.Text = "Renouveler"
        ElseIf btnCondEmp_RechCond.Enabled = True And String.Compare(btnCondEmp_RechCond.Text, "Renouveler") = 0 Then
            lsvCondEmp_RechCond.Items.Clear()
            RemplirLsvCondition()
            txtCondEmp_RechCond.Text = ""
            btnCondEmp_RechCond.Text = "Recherche"
        End If
    End Sub










    'Transert de données entre 2 forms:
    'label1.Text = Form1.SetValueForText1

End Class

