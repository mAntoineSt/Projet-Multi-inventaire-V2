Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Public Class GestionMateriel

    Dim ctrlEnregistrement As New EnregistrementMateriel()
    Dim ctrlFiche As New FicheMateriel()
    Dim ctrlEntretien As New EntretienReparation()
    Dim ctrlEtat As New EtatMateriel()
    Dim ctrlConditions As New ConditionsEmprunt()

    Dim GestionBd As New ConnectBd
    Private strRequete As String = ""
    Private table As String = ""
    Private bd As ConnectBd = New ConnectBd
    Private dataTable As DataTable = New DataTable
    Private dataAdapter As MySqlDataAdapter
    Private dataset As DataSet


    Private Sub GestionMateriel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.pnlControle.Controls.Add(ctrlFiche)
        Me.pnlControle.Controls.Add(ctrlEnregistrement)
        Me.pnlControle.Controls.Add(ctrlEntretien)
        Me.pnlControle.Controls.Add(ctrlEtat)
        Me.pnlControle.Controls.Add(ctrlConditions)


        bd.ConnectionString = "Server=localhost; DataBase=pret_materiel; Uid=root; Pwd=root;Convert Zero Datetime=true; Allow Zero DateTime=true;"

    End Sub



    Private Sub BtnEnregistrement_Click(sender As Object, e As EventArgs) Handles btnEnregistrement.Click
        If Me.Enabled Then
            ctrlEnregistrement.Show()
            ctrlFiche.Hide()
            ctrlEntretien.Hide()
            ctrlEtat.Hide()
            ctrlConditions.Hide()
        End If
    End Sub

    Private Sub BtnConditions_Click(sender As Object, e As EventArgs) Handles btnConditions.Click
        If Me.Enabled Then
            ctrlEnregistrement.Hide()
            ctrlFiche.Hide()
            ctrlEntretien.Hide()
            ctrlEtat.Hide()
            ctrlConditions.Show()
        End If
    End Sub

    Private Sub BtnFiche_Click(sender As Object, e As EventArgs) Handles btnFiche.Click
        If Me.Enabled Then
            ctrlEnregistrement.Hide()
            ctrlFiche.Show()
            ctrlEntretien.Hide()
            ctrlEtat.Hide()
            ctrlConditions.Hide()
        End If
    End Sub

    Private Sub BtnEntretienReparations_Click(sender As Object, e As EventArgs) Handles btnEntretienReparations.Click
        If Me.Enabled Then
            ctrlEnregistrement.Hide()
            ctrlFiche.Hide()
            ctrlEntretien.Show()
            ctrlEtat.Hide()
            ctrlConditions.Hide()
        End If
    End Sub

    Private Sub BtnEtat_Click(sender As Object, e As EventArgs) Handles btnEtat.Click
        If Me.Enabled Then
            ctrlEnregistrement.Hide()
            ctrlFiche.Hide()
            ctrlEntretien.Hide()
            ctrlEtat.Show()
            ctrlConditions.Hide()
        End If
    End Sub
End Class