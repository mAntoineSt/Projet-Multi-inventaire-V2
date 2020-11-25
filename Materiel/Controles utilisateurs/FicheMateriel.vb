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
        idEquipement = dgvFicheMat.Rows(dgvFicheMat.CurrentCell.RowIndex).Cells(0).Value
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





    Private Sub FicheMateriel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplirDatagridview_EnrMateriel()
    End Sub

    Private Sub dgvFicheMat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFicheMat.CellClick
        ObtenirIdEquipement()
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
