Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Public Class FicheMateriel

    Dim GestionBd As New ConnectBd
    Private strRequete As String = ""
    Private bd As ConnectBd = New ConnectBd
    Dim dsEquipement As New DataSet
    Dim daEquipement As New MySqlDataAdapter
    Dim dsCondEmprunt As New DataSet
    Dim daCondEmprunt As New MySqlDataAdapter
    Dim dsEntRep As New DataSet
    Dim daEntRep As New MySqlDataAdapter
    Dim idEquipement As Integer
    Dim connectionBD As New MySqlConnection(bd.ConnectionString)
    Public row As DataRow


    Public Sub RemplirDatagridview_EnrMateriel()

        [dsEquipement].Tables.Clear()
        Dim reqAjoutMateriel As String
        reqAjoutMateriel = "SELECT id_equipement as idEq, marque as Marque, modele as Modele, fabricant as Fabricant FROM equipements"
        daEquipement = New MySqlDataAdapter(reqAjoutMateriel, bd.ConnectionString)
        daEquipement.Fill(dsEquipement, "equipements")
        dgvFicheMat.DataSource = dsEquipement.Tables("equipements")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvFicheMat.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgvFicheMat.Columns(0).Visible = False

    End Sub


    Public Sub ObtenirIdEquipement()
        If IsDBNull(dgvFicheMat.Rows(dgvFicheMat.CurrentCell.RowIndex).Cells(0).Value) = False Then
            idEquipement = dgvFicheMat.Rows(dgvFicheMat.CurrentCell.RowIndex).Cells(0).Value
        Else
            idEquipement = 0
        End If
        RemplirChampFormulaire()
    End Sub


    Public Sub RemplirChampFormulaire()
        Dim readerMateriel As MySqlDataReader
        Dim reqRemplirMateriel As String = "SELECT * FROM `equipements` WHERE `id_equipement` = '" & idEquipement & "';"

        connectionBD.Open()
        Dim cmdRechercheMateriel As New MySqlCommand(reqRemplirMateriel, connectionBD)
        readerMateriel = cmdRechercheMateriel.ExecuteReader
        If readerMateriel.HasRows Then
            readerMateriel.Read()


            lblFiche_HeadDescript.Text = readerMateriel("marque")
            lblFiche_HeadModele.Text = readerMateriel("modele")
            lblFiche_HeadMarque.Text = readerMateriel("fabricant")


            'txtEnrMat_Identifiant.Text = readerMateriel("nom_artiste")
            lblFiche_Marque.Text = readerMateriel("marque")
            lblFiche_Modele.Text = readerMateriel("modele")
            lblFiche_NoSerie.Text = readerMateriel("noSerie")

            lblFiche_Fabricant.Text = readerMateriel("fabricant")
            lblFiche_Categorie.Text = readerMateriel("categorie")
            lblFiche_Fournisseur.Text = readerMateriel("fournisseur")
            lblFiche_CoutAcquis.Text = readerMateriel("cout_achat")

            lblFiche_ValResd.Text = readerMateriel("valeur_residuelle")
            lblFiche_Antivol.Text = readerMateriel("no_antivol")


            lblFiche_Annee.Text = Convert.ToDateTime(readerMateriel("date_fabrication"))


        End If
        connectionBD.Close()
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
        dgvFicheMat_CondEmp.DataSource = dsCondEmprunt.Tables("conditions_equipements")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvFicheMat_CondEmp.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgvFicheMat_CondEmp.Columns(0).Width = 800

    End Sub

    Public Sub RemplirDatagridview_HistoriqueEntRep()

        [dsEntRep].Tables.Clear()
        Dim reqHistoriqueEntRep As String
        reqHistoriqueEntRep = "SELECT er1.`date` as Date, statut as Type, element as Element, montant as Montant
                                FROM `entretien_reparation` er1
                                WHERE er1.materiel =  " & idEquipement & " ;"



        daEntRep = New MySqlDataAdapter(reqHistoriqueEntRep, bd.ConnectionString)
        daEntRep.Fill(dsEntRep, "entretien_reparation")
        dgvFiche_Entretien.DataSource = dsEntRep.Tables("entretien_reparation")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvFiche_Entretien.ColumnHeadersDefaultCellStyle = columnHeaderStyle


    End Sub

    Private Sub FicheMateriel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplirDatagridview_EnrMateriel()
    End Sub

    Private Sub dgvFicheMat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFicheMat.CellClick
        ObtenirIdEquipement()
        RemplirDatagridview_ConditionMateriel()
        RemplirDatagridview_HistoriqueEntRep()
    End Sub

    Private Sub TabControl2_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl2.DrawItem
        Dim graphique As Graphics
        Dim Texte As String
        Dim x As Integer
        Dim y As Integer
        Dim tailleTexte As SizeF
        Dim ctrlTab As TabControl

        ctrlTab = CType(sender, TabControl)
        graphique = e.Graphics
        Texte = ctrlTab.TabPages(e.Index).Text
        tailleTexte = graphique.MeasureString(Texte, ctrlTab.Font)
        x = e.Bounds.Left + 6
        y = e.Bounds.Top + (e.Bounds.Height - tailleTexte.Height) / 2
        graphique.DrawString(Texte, ctrlTab.Font, Brushes.Black, x, y)

    End Sub
End Class
