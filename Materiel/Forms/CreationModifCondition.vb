Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports Projet_Multi_inventaire_V2.Validation_Traitement

Public Class CreationModifCondition

    Dim GestionBd As New ConnectBd
    Private strRequete As String = ""
    Private table As String = ""
    Private bd As ConnectBd = New ConnectBd
    Private dataTable As DataTable = New DataTable
    Private dataAdapter As MySqlDataAdapter
    Private dataset As DataSet
    Dim connectionBD As New MySqlConnection(bd.ConnectionString)

    Dim dsCondition As New DataSet
    Dim daCondition As New MySqlDataAdapter
    Dim positEquipement As Integer

    Dim idCondition As String
    Dim Cond_Description, Cond_Notes As String

    Dim validation As New Validation_Traitement()

    'TODO-->Permettre la suppression définitive d'une condition? 
    'Nécessite de supprimer les entrées dans la table condition_equipement.
    'CASCADE.

    Public Sub EnrCondition()
        Dim cmdInsertCond As New MySqlCommand(strRequete, connectionBD)
        Dim reqCond As String
        Dim condActive As Boolean

        If cbxCond_Desactiver.Checked = True Then
            condActive = False
        ElseIf cbxCond_Desactiver.Checked = False Then
            condActive = True
        End If

        reqCond = "INSERT INTO `conditions`(`description`,
                                            `notes`,
                                            `ConditionActive`)
                                    VALUES (@description,
                                            @notes,
                                            @ConditionActive);"

        cmdInsertCond.Parameters.Add("@description", MySqlDbType.String).Value = Cond_Description
        cmdInsertCond.Parameters.Add("@notes", MySqlDbType.String).Value = Cond_Notes
        cmdInsertCond.Parameters.Add("@ConditionActive", MySqlDbType.Int16).Value = condActive

        cmdInsertCond.CommandText = reqCond
        bd.Prepare_InsDelUpd(reqCond, cmdInsertCond, connectionBD)
    End Sub

    Public Sub ModifCond()
        Dim cmdModifCond As New MySqlCommand(strRequete, connectionBD)
        Dim reqModifCond As String
        Dim condActive As Boolean

        If cbxCond_Desactiver.Checked = True Then
            condActive = False
        ElseIf cbxCond_Desactiver.Checked = False Then
            condActive = True
        End If

        reqModifCond = "UPDATE `conditions`
                            SET  `description` = @description, 
                                    `notes` = @notes,
                                    `ConditionActive` = @ConditionActive
                            WHERE `id_condition` = " & idCondition & ";"

        cmdModifCond.Parameters.Add("@description", MySqlDbType.String).Value = Cond_Description
        cmdModifCond.Parameters.Add("@notes", MySqlDbType.String).Value = Cond_Notes
        cmdModifCond.Parameters.Add("@ConditionActive", MySqlDbType.Int16).Value = condActive

        cmdModifCond.CommandText = reqModifCond
        bd.Prepare_InsDelUpd(reqModifCond, cmdModifCond, connectionBD)

    End Sub


    Public Sub RemplirLsvCondition()
        Dim reqLsbCondition As String = "Select * FROM `conditions`;"
        Dim cmd As New MySqlCommand(reqLsbCondition, connectionBD)
        Dim daCondEmprunt As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable("conditions")
        daCondEmprunt.Fill(dt)

        Dim newrow As DataRow
        For Each newrow In dt.Rows
            lsvCond_ListeCond.Items.Add(newrow.Item(0).ToString)
            lsvCond_ListeCond.Items(lsvCond_ListeCond.Items.Count - 1).SubItems.Add(newrow.Item(1).ToString)
            lsvCond_ListeCond.Items(lsvCond_ListeCond.Items.Count - 1).SubItems.Add(newrow.Item(2).ToString)
        Next
    End Sub


    Public Sub RemplirChampFormulaire()
        Dim readerCond As MySqlDataReader
        Dim reqCond As String = "SELECT * FROM `conditions` 
                                  WHERE `id_condition` = '" & idCondition & "';"

        connectionBD.Open()
        Dim cmdRempCond As New MySqlCommand(reqCond, connectionBD)
        readerCond = cmdRempCond.ExecuteReader
        If readerCond.HasRows Then
            readerCond.Read()
            txtCond_Description.Text = readerCond("description")
            rtxCond_Notes.Text = readerCond("notes")
            If readerCond("ConditionActive") = True Then
                cbxCond_Desactiver.Checked = False
            ElseIf readerCond("ConditionActive") = False Then
                cbxCond_Desactiver.Checked = True
            End If
        End If
        connectionBD.Close()
    End Sub


    Public Function ValidationEntree() As Boolean
        Dim valideTotal As Boolean = False
        Dim valide_1 As Boolean = False
        Dim valide_2 As Boolean = False

        If validation.ValidStringTousCaractere(txtCond_Description.Text) = True Then
            Cond_Description = txtCond_Description.Text
            valide_1 = True
        Else
            txtCond_Description.Text = "Entrée invalide"
            txtCond_Description.ForeColor = Color.Red
        End If
        If validation.ValidStringTousCaractere(rtxCond_Notes.Text) = True Then
            Cond_Notes = rtxCond_Notes.Text
            valide_2 = True
        Else
            rtxCond_Notes.Text = "Entrée invalide"
            rtxCond_Notes.ForeColor = Color.Red
        End If

        If valide_1 = False Or valide_2 = False Then
            valideTotal = False
        Else
            valideTotal = True
        End If

        Return valideTotal
    End Function


    Public Sub reinitCouleur()
        txtCond_Description.ForeColor = Color.Black
        rtxCond_Notes.ForeColor = Color.Black
    End Sub



    Public Sub MessageBox_Enregistrer(e As EventArgs)

        Dim resultat = MessageBox.Show("Voulez-vous ajouter cette condition?", "Prêt Équipement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (resultat = DialogResult.Yes) Then
            If ValidationEntree() = True Then
                EnrCondition()
                ViderChamps()
                InactiverChamps()
                MsgBox("Cette condition à été enregistrée avec succès", vbOKOnly + 64, "Prêt Équipement")
            End If
        End If
    End Sub

    Public Sub MessageBox_Modifier(e As EventArgs)
        Dim resultat = MessageBox.Show("Voulez-vous vraiment modifier cette condition?", "Prêt Équipement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (resultat = DialogResult.Yes) Then
            ModifCond()
            InactiverChamps()
            MsgBox("Cette condition à été modifiée avec succès", vbOKOnly + 64, "Prêt Équipement")
        End If
    End Sub



    Public Sub ViderChamps()
        txtCond_Description.Text = ""
        rtxCond_Notes.Text = ""
        cbxCond_Desactiver.Checked = False
    End Sub

    Public Sub InactiverChamps()
        txtCond_Description.Enabled = False
        rtxCond_Notes.Enabled = False
        cbxCond_Desactiver.Enabled = False
    End Sub

    Public Sub ActiverChamps()
        txtCond_Description.Enabled = True
        rtxCond_Notes.Enabled = True
        cbxCond_Desactiver.Enabled = True
    End Sub

    Public Sub ObtenirIdCondition()
        idCondition = CInt(lsvCond_ListeCond.Items(lsvCond_ListeCond.FocusedItem.Index).SubItems(0).Text)
        'txtCond_Description.Text = lsvCond_ListeCond.Items(lsvCond_ListeCond.FocusedItem.Index).SubItems(1).Text
    End Sub

    Private Sub CreationModifCondition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsvCond_ListeCond.Items.Clear()
        InactiverChamps()
        RemplirLsvCondition()
    End Sub

    Private Sub BtnCond_Annuler_Click(sender As Object, e As EventArgs) Handles btnCond_Annuler.Click
        ViderChamps()
        InactiverChamps()
        btnCond_Ajout.Text = "Ajouter"
        btnCond_Modif.Enabled = True
        btnCond_Modif.Text = "Modifier"
        btnCond_Ajout.Enabled = True
    End Sub

    Private Sub BtnCond_Ajout_Click(sender As Object, e As EventArgs) Handles btnCond_Ajout.Click
        If btnCond_Ajout.Enabled = True And String.Compare(btnCond_Ajout.Text, "Ajouter") = 0 Then
            ActiverChamps()
            ViderChamps()
            btnCond_Ajout.Text = "Enregistrer"
            btnCond_Modif.Enabled = False
        ElseIf btnCond_Ajout.Enabled = True And String.Compare(btnCond_Ajout.Text, "Enregistrer") = 0 Then
            If (ValidationEntree() = True) Then
                MessageBox_Enregistrer(e)
            End If
            reinitCouleur()
            btnCond_Ajout.Text = "Ajouter"
            btnCond_Modif.Enabled = True
        End If
    End Sub

    Private Sub BtnCond_Modif_Click(sender As Object, e As EventArgs) Handles btnCond_Modif.Click
        If btnCond_Modif.Enabled = True And String.Compare(btnCond_Modif.Text, "Modifier") = 0 Then
            ActiverChamps()
            btnCond_Modif.Text = "Enregistrer"
            btnCond_Ajout.Enabled = False
        ElseIf btnCond_Modif.Enabled = True And String.Compare(btnCond_Modif.Text, "Enregistrer") = 0 Then
            If (ValidationEntree() = True) Then
                MessageBox_Modifier(e)
            End If
            reinitCouleur()
            btnCond_Modif.Text = "Modifier"
            btnCond_Ajout.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.Enabled Then
            Me.Close()
        End If
    End Sub

    Private Sub lsvCond_ListeCond_Click(sender As Object, e As EventArgs) Handles lsvCond_ListeCond.Click
        ObtenirIdCondition()
        RemplirChampFormulaire()
    End Sub


End Class

