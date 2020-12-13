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

    Dim condRecherche As String
    Dim validation As New Validation_Traitement()

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

        If VerificationCondition_Existe(idEquipement, idCondEmprunt) = True Then
            MsgBox("Cette condition existe déjà pour cet appareil, impossible de l'ajouter à nouveau.", 48, "Erreur, Ajout de Condition")
        ElseIf VerificationCondition_Existe(idEquipement, idCondEmprunt) = False Then
            cmdInsertCondEmprunt.CommandText = reqCondEmprunt
            bd.Prepare_InsDelUpd(reqCondEmprunt, cmdInsertCondEmprunt, connectionBD)
        End If

        ViderChamps()
    End Sub


    Public Function VerificationCondition_Existe(ByVal equipement As Integer, ByVal condition As Integer) As Boolean

        Dim nbCondition As Integer
        Dim condExiste As Boolean
        Dim reqVerifCond As String = "SELECT COUNT(*)
                                        FROM `conditions_equipements`
                                        WHERE `id_equipement` = " & equipement & "
                                        AND id_condition = " & condition & ";"

        Dim cmd As New MySqlCommand(reqVerifCond, connectionBD)
        Dim daCondEmprunt As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable("conditions")
        daCondEmprunt.Fill(dt)


        Dim newrow As DataRow
        For Each newrow In dt.Rows
            nbCondition = newrow.Item(0).ToString
        Next

        If nbCondition > 0 Then
            condExiste = True
        Else
            condExiste = False
        End If

        Return condExiste
    End Function


    Public Sub RetirerCondEmprunt()
        Dim cmdRetraitCondEmprunt As New MySqlCommand(strRequete, connectionBD)
        Dim reqRetraitCondEmprunt As String

        reqRetraitCondEmprunt = "DELETE FROM `conditions_equipements`                                                                  
                                   WHERE `id_condition` = " & idCondEmprunt & "
                                   AND `id_equipement` = " & idEquipement & ";"

        cmdRetraitCondEmprunt.CommandText = reqRetraitCondEmprunt
        bd.Prepare_InsDelUpd(reqRetraitCondEmprunt, cmdRetraitCondEmprunt, connectionBD)

    End Sub


    Public Sub RemplirDatagridview_Materiel()

        [dsEquipement].Tables.Clear()
        Dim reqMateriel As String
        reqMateriel = "SELECT id_equipement as idEq,
                                marque as Marque,
                                modele as Modele,
                                fabricant as Fabricant
                        FROM equipements"

        daEquipement = New MySqlDataAdapter(reqMateriel, bd.ConnectionString)
        daEquipement.Fill(dsEquipement, "equipements")
        dgvCondEmp_ListeMat.DataSource = dsEquipement.Tables("equipements")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvCondEmp_ListeMat.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgvCondEmp_ListeMat.Columns(0).Width = 120
        dgvCondEmp_ListeMat.Columns(1).Width = 120
        dgvCondEmp_ListeMat.Columns(2).Width = 120
        dgvCondEmp_ListeMat.Columns(0).Visible = False

    End Sub

    Public Sub RemplirDatagridview_ConditionMateriel()

        [dsCondEmprunt].Tables.Clear()
        Dim reqConditionMat As String
        reqConditionMat = " SELECT  distinct description as Conditions_du_Pret, c.id_condition
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
        dgvCondEmp_ListeCond.Columns(0).Width = 350
        dgvCondEmp_ListeCond.Columns(1).Visible = False

    End Sub

    Public Sub RemplirChampConditionLstCond()
        Dim readerCondition As MySqlDataReader
        Dim reqCondition As String = "SELECT description
                                       FROM `conditions` 
                                       WHERE `id_condition` = '" & idCondEmprunt & "';"

        connectionBD.Open()
        Dim cmdCondition As New MySqlCommand(reqCondition, connectionBD)
        readerCondition = cmdCondition.ExecuteReader
        If readerCondition.HasRows Then
            readerCondition.Read()
            txtCondEmp_Condition.Text = readerCondition("description")
        End If
        connectionBD.Close()
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
            txtCondEmp_Materiel.Text = readerMateriel("marqueModele")
        End If
        connectionBD.Close()
    End Sub

    Public Sub RechercheCondition()

        Dim reqLsbConditionRecherche As String = "SELECT * FROM `conditions`
                                                  WHERE `description` LIKE '%" & condRecherche & "%' ;"

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


    Public Function ValidationCondition() As Boolean
        Dim rechValide As Boolean = False
        If (validation.ValidStringSimple(txtCondEmp_RechCond.Text) = True) Then
            condRecherche = txtCondEmp_RechCond.Text
            rechValide = True
        Else
            txtCondEmp_RechCond.Text = "* Entrée non-valide."
            txtCondEmp_RechCond.ForeColor = Color.Red
            rechValide = False
        End If
        Return rechValide
    End Function

    Public Sub MessageBox_Enregistrer(e As EventArgs)
        Dim resultat = MessageBox.Show("Voulez-vous ajouter cette condition à ce matériel?", "Prêt Équipement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (resultat = DialogResult.Yes) Then
            EnrCondEmprunt()
        End If
    End Sub

    Public Sub MessageBox_Modifier(e As EventArgs)
        Dim resultat = MessageBox.Show("Voulez-vous vraiment retirer cette condition à ce matériel?", "Prêt Équipement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (resultat = DialogResult.Yes) Then
            RetirerCondEmprunt()
        End If
    End Sub


    Public Sub ObtenirIdCondition()
        idCondEmprunt = CInt(lsvCondEmp_RechCond.Items(lsvCondEmp_RechCond.FocusedItem.Index).SubItems(0).Text)
        txtCondEmp_Condition.Text = lsvCondEmp_RechCond.Items(lsvCondEmp_RechCond.FocusedItem.Index).SubItems(1).Text
    End Sub

    Public Sub ObtenirIdCondition_DgvListeCondition()
        If IsDBNull(dgvCondEmp_ListeCond.Rows(dgvCondEmp_ListeCond.CurrentCell.RowIndex).Cells(1).Value) = False Then
            idCondEmprunt = CInt(dgvCondEmp_ListeCond.Rows(dgvCondEmp_ListeCond.CurrentCell.RowIndex).Cells(1).Value)
        Else
            idCondEmprunt = 0
        End If
        'RemplirChampFormulaire()
        RemplirChampConditionLstCond()
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

    Public Sub ViderChampsCondition()
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

    Private Sub btnCondEmp_Retrait_Click(sender As Object, e As EventArgs) Handles btnCondEmp_Retrait.Click
        If btnCondEmp_Retrait.Enabled = True And String.Compare(btnCondEmp_Retrait.Text, "Retirer") = 0 Then
            ActiverChamps()
            btnCondEmp_Retrait.Text = "Enregistrer"
            btnCondEmp_Ajout.Enabled = False
        ElseIf btnCondEmp_Retrait.Enabled = True And String.Compare(btnCondEmp_Retrait.Text, "Enregistrer") = 0 Then
            MessageBox_Modifier(e)
            InactiverChamps()
            ViderChamps()
            btnCondEmp_Retrait.Text = "Retirer"
            btnCondEmp_Ajout.Enabled = True
        End If
    End Sub

    Private Sub BtnCondEmp_Ajout_Click(sender As Object, e As EventArgs) Handles btnCondEmp_Ajout.Click
        If btnCondEmp_Ajout.Enabled = True And String.Compare(btnCondEmp_Ajout.Text, "Ajouter") = 0 Then
            ActiverChamps()
            ViderChampsCondition()
            btnCondEmp_Ajout.Text = "Enregistrer"
            btnCondEmp_Retrait.Enabled = False
        ElseIf btnCondEmp_Ajout.Enabled = True And String.Compare(btnCondEmp_Ajout.Text, "Enregistrer") = 0 Then
            MessageBox_Enregistrer(e)
            InactiverChamps()
            ViderChamps()
            btnCondEmp_Ajout.Text = "Ajouter"
            btnCondEmp_Retrait.Enabled = True
        End If
    End Sub

    Private Sub BtnCondEmp_Annuler_Click(sender As Object, e As EventArgs) Handles btnCondEmp_Annuler.Click
        ViderChamps()
        InactiverChamps()
        btnCondEmp_Ajout.Text = "Ajouter"
        btnCondEmp_Retrait.Enabled = True
        btnCondEmp_Retrait.Text = "Modifier"
        btnCondEmp_Ajout.Enabled = True
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
            If (ValidationCondition() = True) Then
                RechercheCondition()
            End If
            btnCondEmp_RechCond.Text = "Renouveler"
        ElseIf btnCondEmp_RechCond.Enabled = True And String.Compare(btnCondEmp_RechCond.Text, "Renouveler") = 0 Then
            lsvCondEmp_RechCond.Items.Clear()
            RemplirLsvCondition()
            txtCondEmp_RechCond.ForeColor = Color.Black
            txtCondEmp_RechCond.Text = ""
            btnCondEmp_RechCond.Text = "Recherche"
        End If
    End Sub

    Private Sub dgvCondEmp_ListeCond_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCondEmp_ListeCond.CellClick
        ObtenirIdCondition_DgvListeCondition()
    End Sub










    'Transert de données entre 2 forms:
    'label1.Text = Form1.SetValueForText1

End Class

