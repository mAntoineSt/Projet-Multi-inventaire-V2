Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types


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



    Public Sub EnrCondition()
        Dim cmdInsertCond As New MySqlCommand(strRequete, connectionBD)
        Dim reqCond As String


        reqCond = "INSERT INTO `conditions`(`description`,
                                            `notes`)
                                    VALUES (@description,
                                            @notes);"

        cmdInsertCond.Parameters.Add("@description", MySqlDbType.String).Value = txtCond_Description.Text
        cmdInsertCond.Parameters.Add("@notes", MySqlDbType.String).Value = rtxCond_Notes.Text

        cmdInsertCond.CommandText = reqCond
        bd.Prepare_InsDelUpd(reqCond, cmdInsertCond, connectionBD)
        ViderChamps()
    End Sub

    Public Sub ModifCond()
        Dim cmdModifCond As New MySqlCommand(strRequete, connectionBD)
        Dim reqModifCond As String


        reqModifCond = "UPDATE `conditions`
                                    SET  `description` = '@description', 
                                         `notes` = '@notes',            
                                   WHERE `id_condition` = '@id_condition';"

        cmdModifCond.Parameters.Add("@description", MySqlDbType.String).Value = txtCond_Description.Text
        cmdModifCond.Parameters.Add("@notes", MySqlDbType.String).Value = rtxCond_Notes.Text


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





    Public Sub ViderChamps()
        txtCond_Description.Text = ""
        rtxCond_Notes.Text = ""
    End Sub

    Public Sub InactiverChamps()
        txtCond_Description.Enabled = False
        rtxCond_Notes.Enabled = False
    End Sub

    Public Sub ActiverChamps()
        txtCond_Description.Enabled = True
        rtxCond_Notes.Enabled = True
    End Sub

    Public Sub ObtenirIdCondition()
        idCondition = CInt(lsvCond_ListeCond.Items(lsvCond_ListeCond.FocusedItem.Index).SubItems(0).Text)
        txtCond_Description.Text = lsvCond_ListeCond.Items(lsvCond_ListeCond.FocusedItem.Index).SubItems(1).Text
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
            ViderChamps()
            ActiverChamps()
            btnCond_Ajout.Text = "Enregistrer"
            btnCond_Modif.Enabled = False
        ElseIf btnCond_Ajout.Enabled = True And String.Compare(btnCond_Ajout.Text, "Enregistrer") = 0 Then
            EnrCondition()
            InactiverChamps()
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
            ModifCond()
            InactiverChamps()
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
    End Sub


End Class