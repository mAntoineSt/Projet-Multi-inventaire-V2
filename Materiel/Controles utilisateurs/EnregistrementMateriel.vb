Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Public Class EnregistrementMateriel

    Dim GestionBd As New ConnectBd
    Private strRequete As String = ""
    Private bd As ConnectBd = New ConnectBd
    Dim dsEquipement As New DataSet
    Dim daEquipement As New MySqlDataAdapter
    Dim idEquipement As Integer
    Dim connectionBD As New MySqlConnection(bd.ConnectionString)
    Public row As DataRow

    Dim imageMat As Image
    Dim urlImage As String
    Dim urlDestination As String

    Dim validation As New Validation_Traitement()
    Dim marque As String
    Dim modele As String
    Dim noSerie As String
    Dim fabricant As String
    Dim categorie As String
    Dim date_fabrication As String
    Dim date_enregistrement As String
    Dim fournisseur As String
    Dim date_acquisition As String
    Dim cout_achat As String
    Dim valeur_residuelle As String
    Dim no_antivol As String
    Dim info_complement As String






    Public Sub EnregistrerMateriel()

        TelechargerPhoto()
        Dim cmdInsertMateriel As New MySqlCommand(strRequete, connectionBD)
        Dim reqAjoutMateriel As String
        Dim dateJour As Date
        dateJour = Date.Today


        reqAjoutMateriel = "INSERT INTO `equipements`(  `marque`,
                                                        `modele`,
                                                        `noSerie`,
                                                        `fabricant`,
                                                        `categorie`,
                                                        `date_fabrication`,
                                                        `date_enregistrement`,
                                                        `fournisseur`,
                                                        `date_acquisition`,
                                                        `cout_achat`,
                                                        `valeur_residuelle`,
                                                        `no_antivol`,
                                                        `info_complement`,
                                                        `url_photo`)
                                                VALUES (@marque,
                                                        @modele,
                                                        @noSerie,
                                                        @fabricant,
                                                        @categorie,
                                                        @date_fabrication,
                                                        @date_enregistrement,
                                                        @fournisseur,
                                                        @date_acquisition, 
                                                        @cout_achat,
                                                        @valeur_residuelle,
                                                        @no_antivol,
                                                        @info_complement,
                                                        @url_photo);"





        cmdInsertMateriel.Parameters.Add("@marque", MySqlDbType.String).Value = marque
        cmdInsertMateriel.Parameters.Add("@modele", MySqlDbType.String).Value = modele
        cmdInsertMateriel.Parameters.Add("@noSerie", MySqlDbType.String).Value = noSerie
        cmdInsertMateriel.Parameters.Add("@fabricant", MySqlDbType.String).Value = fabricant
        cmdInsertMateriel.Parameters.Add("@categorie", MySqlDbType.String).Value = categorie
        cmdInsertMateriel.Parameters.Add("@date_fabrication", MySqlDbType.Date).Value = date_fabrication
        cmdInsertMateriel.Parameters.Add("@date_enregistrement", MySqlDbType.Date).Value = dateJour
        cmdInsertMateriel.Parameters.Add("@fournisseur", MySqlDbType.String).Value = fournisseur
        cmdInsertMateriel.Parameters.Add("@date_acquisition", MySqlDbType.Date).Value = date_acquisition
        cmdInsertMateriel.Parameters.Add("@cout_achat", MySqlDbType.String).Value = Replace(cout_achat, ",", ".") 'C'est valide comme façon de faire 
        cmdInsertMateriel.Parameters.Add("@valeur_residuelle", MySqlDbType.String).Value = Replace(valeur_residuelle, ",", ".") 'Plante pas.!!!!
        cmdInsertMateriel.Parameters.Add("@no_antivol", MySqlDbType.String).Value = no_antivol
        cmdInsertMateriel.Parameters.Add("@info_complement", MySqlDbType.String).Value = info_complement
        cmdInsertMateriel.Parameters.Add("@url_photo", MySqlDbType.String).Value = urlDestination


        cmdInsertMateriel.CommandText = reqAjoutMateriel
        bd.Prepare_InsDelUpd(reqAjoutMateriel, cmdInsertMateriel, connectionBD)
    End Sub


    Public Sub ModifMateriel()

        TelechargerPhoto()
        Dim cmdModifMateriel As New MySqlCommand(strRequete, connectionBD)
        Dim reqModifMateriel As String
        Dim dateJour As Date
        dateJour = Date.Today



        reqModifMateriel = "UPDATE `equipements`
                            SET  `marque` = @marque, 
                                 `modele` = @modele, 
                                 `noSerie` = @noSerie,
                                 `fabricant` = @fabricant,
                                 `categorie` = @categorie, 
                                 `date_fabrication` = @date_fabrication, 
                                 `date_enregistrement` = @date_enregistrement,
                                 `fournisseur` = @fournisseur,
                                 `date_acquisition` = @date_acquisition, 
                                 `cout_achat` = @cout_achat, 
                                 `valeur_residuelle` = @valeur_residuelle,
                                 `no_antivol` = @no_antivol,
                                 `info_complement` = @info_complement                    
                           WHERE `id_equipement` = " & idEquipement & ";"

        cmdModifMateriel.Parameters.Add("@marque", MySqlDbType.String).Value = marque
        cmdModifMateriel.Parameters.Add("@modele", MySqlDbType.String).Value = modele
        cmdModifMateriel.Parameters.Add("@noSerie", MySqlDbType.String).Value = noSerie
        cmdModifMateriel.Parameters.Add("@fabricant", MySqlDbType.String).Value = fabricant
        cmdModifMateriel.Parameters.Add("@categorie", MySqlDbType.String).Value = categorie
        cmdModifMateriel.Parameters.Add("@date_fabrication", MySqlDbType.Date).Value = date_fabrication
        cmdModifMateriel.Parameters.Add("@date_enregistrement", MySqlDbType.Date).Value = dateJour
        cmdModifMateriel.Parameters.Add("@fournisseur", MySqlDbType.String).Value = fournisseur
        cmdModifMateriel.Parameters.Add("@date_acquisition", MySqlDbType.Date).Value = date_acquisition
        cmdModifMateriel.Parameters.Add("@cout_achat", MySqlDbType.String).Value = Replace(cout_achat, ",", ".")
        cmdModifMateriel.Parameters.Add("@valeur_residuelle", MySqlDbType.String).Value = Replace(valeur_residuelle, ",", ".")
        cmdModifMateriel.Parameters.Add("@no_antivol", MySqlDbType.String).Value = no_antivol
        cmdModifMateriel.Parameters.Add("@info_complement", MySqlDbType.String).Value = info_complement

        cmdModifMateriel.CommandText = reqModifMateriel
        bd.Prepare_InsDelUpd(reqModifMateriel, cmdModifMateriel, connectionBD)
    End Sub



    Public Sub RemplirDatagridview_EnrMateriel()

        [dsEquipement].Tables.Clear()
        Dim reqAjoutMateriel As String
        reqAjoutMateriel = "SELECT id_equipement as idEq,
                                   marque as Marque,
                                   modele as Modele,
                                  fabricant as Fabricant
                            FROM equipements;"

        daEquipement = New MySqlDataAdapter(reqAjoutMateriel, bd.ConnectionString)
        daEquipement.Fill(dsEquipement, "equipements")
        dgvEnrMat.DataSource = dsEquipement.Tables("equipements")


        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        dgvEnrMat.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgvEnrMat.Columns(0).Visible = False
        dgvEnrMat.Columns(1).Width = 120
        dgvEnrMat.Columns(2).Width = 120
        dgvEnrMat.Columns(3).Width = 120
    End Sub

    Public Sub RemplirCboCategorie()
        Dim reqCategorie As String = "SELECT `categorie` FROM `equipements`;"
        Dim da As New MySqlDataAdapter(reqCategorie, bd.ConnectionString)
        Dim dt As New DataTable("artiste")

        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            cboEnrMat_Categorie.DataSource = dt
            cboEnrMat_Categorie.DisplayMember = "categorie"
        End If



    End Sub

    Public Sub RemplirChampFormulaire()
        Dim readerMateriel As MySqlDataReader
        Dim reqRemplirMateriel As String = "SELECT * FROM `equipements`
                                            WHERE `id_equipement` = '" & idEquipement & "';"


        connectionBD.Open()
        Dim cmdRechercheMateriel As New MySqlCommand(reqRemplirMateriel, connectionBD)
        readerMateriel = cmdRechercheMateriel.ExecuteReader
        If readerMateriel.HasRows Then
            readerMateriel.Read()

            txtEnrMat_Marque.Text = readerMateriel("marque")
            txtEnrMat_Modele.Text = readerMateriel("modele")
            txtEnrMat_NoSerie.Text = readerMateriel("noSerie")
            txtEnrMat_Fabricant.Text = readerMateriel("fabricant")
            cboEnrMat_Categorie.Text = readerMateriel("categorie")
            txtEnrMat_Fournisseur.Text = readerMateriel("fournisseur")
            txtEnrMat_CoutAchat.Text = readerMateriel("cout_achat")
            txtEnrMat_Valeur.Text = readerMateriel("valeur_residuelle")
            txtEnrMat_NoAntivol.Text = readerMateriel("no_antivol")
            rtxEnrMat_Notes.Text = readerMateriel("info_complement")
            dtpEnrMat_DateFabrict.Value = Convert.ToDateTime(readerMateriel("date_fabrication"))
            dtpEnrMat_DateAcquis.Value = Convert.ToDateTime(readerMateriel("date_enregistrement"))

        End If
        connectionBD.Close()
    End Sub




    Public Sub ObtenirIdEquipement()

        If IsDBNull(dgvEnrMat.Rows(dgvEnrMat.CurrentCell.RowIndex).Cells(0).Value) = False Then
            idEquipement = dgvEnrMat.Rows(dgvEnrMat.CurrentCell.RowIndex).Cells(0).Value
        Else
            idEquipement = 0
        End If
        RemplirChampFormulaire()
    End Sub


    Public Sub ChoisirPhoto()
        Dim dialogueFichier As New OpenFileDialog

        With dialogueFichier
            .Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpg *.jpeg)|*.jpg|GIF Files (*.gif)|*.gif|BMP Files (*.bmp)|*.bmp|WMF Files (*.wmf)|*.wmf|SVG Files (*.svg)|*.svg"
            .Title = "Choisissez une photo du matériel"
        End With
        Try
            If dialogueFichier.ShowDialog = Windows.Forms.DialogResult.OK Then
                imageMat = Image.FromFile(dialogueFichier.FileName)
                urlImage = dialogueFichier.FileName

            End If
        Catch ex As Exception
        End Try
        lblEnrMat_UrlPhoto.Text = urlImage
    End Sub





    Public Sub TelechargerPhoto()
        Dim nomImage As String = ""
        Dim fichier As String = "C:\UwAmp\www\SERVEUR_YANICK\Dossier Images"

        If IsNothing(nomImage) = False Then
            nomImage = Mid(urlImage, InStrRev(urlImage, "\", Len(urlImage)) + 1)
            urlDestination = System.IO.Path.Combine(fichier, nomImage)
            imageMat.Save(urlDestination)
        End If

    End Sub


    Public Sub ViderChamps()
        txtEnrMat_Marque.Text = ""
        txtEnrMat_Modele.Text = ""
        txtEnrMat_NoSerie.Text = ""
        txtEnrMat_Fabricant.Text = ""
        cboEnrMat_Categorie.Text = ""
        txtEnrMat_Fournisseur.Text = ""
        txtEnrMat_CoutAchat.Text = ""
        txtEnrMat_Valeur.Text = ""
        txtEnrMat_NoAntivol.Text = ""
        rtxEnrMat_Notes.Text = ""
        dtpEnrMat_DateFabrict.Value = Date.Today
        dtpEnrMat_DateAcquis.Value = Date.Today
        lblEnrMat_UrlPhoto.Text = ""
    End Sub

    Public Sub InactiverChamps()
        txtEnrMat_Marque.Enabled = False
        txtEnrMat_Modele.Enabled = False
        txtEnrMat_NoSerie.Enabled = False
        txtEnrMat_Fabricant.Enabled = False
        cboEnrMat_Categorie.Enabled = False
        txtEnrMat_Fournisseur.Enabled = False
        txtEnrMat_CoutAchat.Enabled = False
        txtEnrMat_Valeur.Enabled = False
        txtEnrMat_NoAntivol.Enabled = False
        rtxEnrMat_Notes.Enabled = False
        dtpEnrMat_DateFabrict.Enabled = False
        dtpEnrMat_DateAcquis.Enabled = False
        btnEnrMat_Photo.Enabled = False
    End Sub

    Public Sub ActiverChamps()
        txtEnrMat_Marque.Enabled = True
        txtEnrMat_Modele.Enabled = True
        txtEnrMat_NoSerie.Enabled = True
        txtEnrMat_Fabricant.Enabled = True
        cboEnrMat_Categorie.Enabled = True
        txtEnrMat_Fournisseur.Enabled = True
        txtEnrMat_CoutAchat.Enabled = True
        txtEnrMat_Valeur.Enabled = True
        txtEnrMat_NoAntivol.Enabled = True
        rtxEnrMat_Notes.Enabled = True
        dtpEnrMat_DateFabrict.Enabled = True
        dtpEnrMat_DateAcquis.Enabled = True
        btnEnrMat_Photo.Enabled = True
    End Sub

    Public Function ValidationEnrgMateriel() As Boolean
        Dim validForm As Boolean = False

        Dim validMarque As Boolean = False
        Dim validModele As Boolean = False
        Dim validNoSerie As Boolean = False
        Dim validFabricant As Boolean = False
        Dim validCategorie As Boolean = False
        Dim validFournisseur As Boolean = False
        Dim validCout_achat As Boolean = False
        Dim validValeur_residuelle As Boolean = False
        Dim validNo_antivol As Boolean = False
        Dim validInfo_complement As Boolean = False


        If (validation.ValidStringTousCaractere(txtEnrMat_Marque.Text) = True) Then
            marque = txtEnrMat_Marque.Text
            validMarque = True
        Else
            txtEnrMat_Marque.Text = "* Entrée non-valide."
            txtEnrMat_Marque.ForeColor = Color.Red
            validMarque = False
        End If

        If (validation.ValidStringTousCaractere(txtEnrMat_Modele.Text) = True) Then
            modele = txtEnrMat_Modele.Text
            validModele = True
        Else
            txtEnrMat_Modele.Text = "* Entrée non-valide."
            txtEnrMat_Modele.ForeColor = Color.Red
            validModele = False
        End If

        If (validation.ValidStringTousCaractere(txtEnrMat_NoSerie.Text) = True) Then
            noSerie = txtEnrMat_NoSerie.Text
            validNoSerie = True
        Else
            txtEnrMat_NoSerie.Text = "* Entrée non-valide."
            txtEnrMat_NoSerie.ForeColor = Color.Red
            validNoSerie = False
        End If


        If (validation.ValidStringTousCaractere(txtEnrMat_Fabricant.Text) = True) Then
            fabricant = txtEnrMat_Fabricant.Text
            validFabricant = True
        Else
            txtEnrMat_Fabricant.Text = "* Entrée non-valide."
            txtEnrMat_Fabricant.ForeColor = Color.Red
            validFabricant = False
        End If

        If (validation.ValidStringTousCaractere(cboEnrMat_Categorie.Text) = True) Then
            categorie = cboEnrMat_Categorie.Text
            validCategorie = True
        Else
            cboEnrMat_Categorie.Text = "* Entrée non-valide."
            cboEnrMat_Categorie.ForeColor = Color.Red
            validCategorie = False
        End If

        If (validation.ValidStringTousCaractere(txtEnrMat_Fournisseur.Text) = True) Then
            fournisseur = txtEnrMat_Fournisseur.Text
            validFournisseur = True
        Else
            txtEnrMat_Fournisseur.Text = "* Entrée non-valide."
            txtEnrMat_Fournisseur.ForeColor = Color.Red
            validFournisseur = False
        End If

        If (validation.ValidNombreDecimal(txtEnrMat_CoutAchat.Text) = True) Then
            cout_achat = txtEnrMat_CoutAchat.Text
            validCout_achat = True
        Else
            txtEnrMat_CoutAchat.Text = "* Entrée non-valide."
            txtEnrMat_CoutAchat.ForeColor = Color.Red
            validCout_achat = False
        End If

        If (validation.ValidNombreDecimal(txtEnrMat_Valeur.Text) = True) Then
            valeur_residuelle = txtEnrMat_Valeur.Text
            validValeur_residuelle = True
        Else
            txtEnrMat_Valeur.Text = "* Entrée non-valide."
            txtEnrMat_Valeur.ForeColor = Color.Red
            validValeur_residuelle = False
        End If

        If (validation.ValidStringTousCaractere_Null(txtEnrMat_NoAntivol.Text) = True) Then
            no_antivol = txtEnrMat_NoAntivol.Text
            validNo_antivol = True
        Else
            txtEnrMat_NoAntivol.Text = "* Entrée non-valide."
            txtEnrMat_NoAntivol.ForeColor = Color.Red
            validNo_antivol = False
        End If

        If (validation.ValidStringTousCaractere_Null(rtxEnrMat_Notes.Text) = True) Then
            info_complement = rtxEnrMat_Notes.Text
            validInfo_complement = True
        Else
            rtxEnrMat_Notes.Text = "* Entrée non-valide."
            rtxEnrMat_Notes.ForeColor = Color.Red
            validInfo_complement = False
        End If


        If (validMarque = True And
            validModele = True And
            validNoSerie = True And
            validFabricant = True And
            validCategorie = True And
            validFournisseur = True And
            validCout_achat = True And
            validValeur_residuelle = True And
            validNo_antivol = True And
            validInfo_complement = True) Then

            validForm = True
        Else
            validForm = False
        End If


        Return validForm
    End Function

    Public Sub reinitCouleur()
        txtEnrMat_Marque.ForeColor = Color.Black
        txtEnrMat_Modele.ForeColor = Color.Black
        txtEnrMat_NoSerie.ForeColor = Color.Black
        txtEnrMat_Fabricant.ForeColor = Color.Black
        cboEnrMat_Categorie.ForeColor = Color.Black
        txtEnrMat_Fournisseur.ForeColor = Color.Black
        txtEnrMat_CoutAchat.ForeColor = Color.Black
        txtEnrMat_Valeur.ForeColor = Color.Black
        txtEnrMat_NoAntivol.ForeColor = Color.Black
        rtxEnrMat_Notes.ForeColor = Color.Black
    End Sub

    Public Sub MessageBox_Enregistrer(e As EventArgs)
        Dim resultat = MessageBox.Show("Voulez-vous inscrire ce nouveau matériel?", "Prêt Équipement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (resultat = DialogResult.Yes) Then
            EnregistrerMateriel()
            InactiverChamps()
            ViderChamps()
            MsgBox("Ce matériel à été enregistrée avec succès", vbOKOnly + 64, "Prêt Équipement")
        End If
    End Sub

    Public Sub MessageBox_Modifier(e As EventArgs)
        Dim resultat = MessageBox.Show("Voulez-vous vraiment modifier ce matériel?", "Prêt Équipement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (resultat = DialogResult.Yes) Then
            ModifMateriel()
            InactiverChamps()
            ViderChamps()
            MsgBox("Ce matériel à été modifié avec succès", vbOKOnly + 64, "Prêt Équipement")
        End If
    End Sub

    Private Sub BtnEnrMat_Annuler_Click(sender As Object, e As EventArgs) Handles btnEnrMat_Annuler.Click
        ViderChamps()
        InactiverChamps()
        btnEnrMat_Ajout.Text = "Ajouter"
        btnEnrMat_Modif.Enabled = True
        btnEnrMat_Modif.Text = "Modifier"
        btnEnrMat_Ajout.Enabled = True
        RemplirCboCategorie()
    End Sub

    Private Sub BtnEnrMat_Ajout_Click(sender As Object, e As EventArgs) Handles btnEnrMat_Ajout.Click
        If btnEnrMat_Ajout.Enabled = True And String.Compare(btnEnrMat_Ajout.Text, "Ajouter") = 0 Then
            ActiverChamps()
            ViderChamps()
            btnEnrMat_Ajout.Text = "Enregistrer"
            btnEnrMat_Modif.Enabled = False
        ElseIf btnEnrMat_Ajout.Enabled = True And String.Compare(btnEnrMat_Ajout.Text, "Enregistrer") = 0 Then
            If (ValidationEnrgMateriel() = True) Then
                MessageBox_Enregistrer(e)
            End If

            reinitCouleur()
            btnEnrMat_Ajout.Text = "Ajouter"
            btnEnrMat_Modif.Enabled = True
        End If

    End Sub

    Private Sub BtnEnrMat_Modif_Click(sender As Object, e As EventArgs) Handles btnEnrMat_Modif.Click
        If btnEnrMat_Modif.Enabled = True And String.Compare(btnEnrMat_Modif.Text, "Modifier") = 0 Then
            ActiverChamps()
            btnEnrMat_Modif.Text = "Enregistrer"
            btnEnrMat_Ajout.Enabled = False
        ElseIf btnEnrMat_Modif.Enabled = True And String.Compare(btnEnrMat_Modif.Text, "Enregistrer") = 0 Then
            If (ValidationEnrgMateriel() = True) Then
                MessageBox_Modifier(e)
            End If
            InactiverChamps()
            ViderChamps()
            btnEnrMat_Modif.Text = "Modifier"
            btnEnrMat_Ajout.Enabled = True
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        RemplirDatagridview_EnrMateriel()
        InactiverChamps()
        RemplirCboCategorie()
    End Sub

    Private Sub dgvEnrMat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnrMat.CellClick
        ObtenirIdEquipement()
    End Sub

    Private Sub BtnEnrMat_Photo_Click(sender As Object, e As EventArgs) Handles btnEnrMat_Photo.Click
        ChoisirPhoto()
    End Sub


End Class
