Imports System.Text.RegularExpressions
Public Class Validation_Traitement









    '==========================================================================
    'AUTEUR:

    '   Code: Yanick Chrétien


    '==========================================================================

    Dim RgxNoTel As New Regex("^(\s*)?([1](\s*|\-|\.)?)?(\(\d{3}\)|(\d{3}))(\s*|\-|\.)?(\d{3})(\s*|\-|\.)?(\d{4})(\s*)?$")
    Dim RgxCodepostal As New Regex("^((\s*)?([AMBNCPERGSHTJVKXLY|ambncpergshtjvkxly)])([0-9][A-Z|a-z])(\s*)?([0-9][A-Z|a-z][0-9]))(\s*)?$")
    '=== Le RegexCourriel pourrait-être amélioré =============================
    Dim RgxCourriel As New Regex("^((\s*)?([^\.])([^(@(),:;<>\\\[\])?].*)*([^\.])@).+\.([A-Z|a-z|0-9|\-]+)+(\s*)?$")
    Dim RgxNomPrenom As New Regex("^(\s*)?([A-Za-z\-áÁàÀâÂäÄéÉèÈëËêÊíÍîÎïÏóÓôÔòÒöÖúÚùÙûÛüÜçÇ])+(\s*)?$")
    Dim RgxNombre As New Regex("^(\s*)?(\d)*([\.|\,]*)?(\d{1,2})?(\s*)?$")
    Dim RgxNAS As New Regex("^(\s*)?(\d{3})(\s*)?(\d{3})(\s*)?(\d{3})(\s*)?$")
    Dim RgxChaineTexte As New Regex("^(.|\n|\s)+?$")
    Dim RgxMotDePasse As New Regex("^((\s|\d|\w|\W)+?)$")

    Dim rgxCrtInvalide_1 As New Regex("[#!/$%?&*()_+^¨>`:.,»«°¯­~{}][¶¾½¼³²¦¬¤¢£@±\|<;]µ§")
    Dim rgxCrtInvalide_2 As New Regex("")

    Function ValidNoTel(ByVal noTel As String)
        Dim noTelValide As Boolean = False
        Try
            If Not String.IsNullOrEmpty(noTel) Then
                noTelValide = RgxNoTel.IsMatch(noTel)
            Else
                noTelValide = False
            End If
            If Not String.IsNullOrEmpty(noTel) Then
                If noTel = rgxCrtInvalide_1.IsMatch(noTel) Then
                    MsgBox("Les caractères spéciaux et les lettres ne sont pas acceptés", vbOKOnly + 48, "Gestion théatre")
                End If
            End If
        Catch
        End Try
        If noTelValide = False Then
            MsgBox("Le numéro de téléphone n'est pas valide.", vbOKOnly + 48, "Gestion théatre")
        End If
        Return noTelValide

    End Function

    Function ValidCodepostal(ByVal Codepostal As String)
        Dim CodPostValide As Boolean = False
        Try
            If Not String.IsNullOrEmpty(Codepostal) Then
                CodPostValide = RgxCodepostal.IsMatch(Codepostal)
                If CodPostValide = False Then
                    CodPostValide = RgxCodepostal.IsMatch(Codepostal)
                End If
            End If
            If Not String.IsNullOrEmpty(Codepostal) Then
                If Codepostal = rgxCrtInvalide_1.IsMatch(Codepostal) Then
                    MsgBox("Les caractères spéciaux ne sont pas acceptés", vbOKOnly + 48, "Gestion théatre")
                End If
            End If
        Catch
        End Try
        If CodPostValide = False Then
            MsgBox("Le code postal n'est pas valide.", vbOKOnly + 48, "Gestion théatre")
        End If
        Return CodPostValide

    End Function


    Function ValidNomPrenom(ByVal nomPrenom As String)
        Dim nomPrenomValide As Boolean = False
        Try
            If Not String.IsNullOrEmpty(nomPrenom) Then
                nomPrenomValide = RgxNomPrenom.IsMatch(nomPrenom)
            Else
                nomPrenomValide = False
            End If
        Catch
        End Try
        Return nomPrenomValide
    End Function

    Function ValidNombre(ByVal nombre As String)
        Dim nombreValide As Boolean = False
        Try
            If Not String.IsNullOrEmpty(nombre) Then
                nombreValide = RgxNombre.IsMatch(nombre)
            Else
                nombreValide = False
                MsgBox("Veuillez entrer uniquement des caratères numériques svp.", vbOKCancel + 48, "Gestion théatre")
            End If
        Catch
        End Try
        Return nombreValide
    End Function


    Function ValidCourriel(ByVal courriel As String)
        Dim courrielValide As Boolean = False
        Try
            If Not String.IsNullOrEmpty(courriel) Then
                courrielValide = RgxCourriel.IsMatch(courriel)
                If courrielValide = False Then
                    courrielValide = RgxCourriel.IsMatch(courriel)
                End If
            End If
        Catch
        End Try
        If courrielValide = False Then
            MsgBox("L'adresse courriel n'est pas valide.", vbOKOnly + 48, "Gestion théatre")
        End If
        Return courrielValide
    End Function

    Function ValidNAS(ByVal NoAssSoc As String)
        Dim NASValide As Boolean = False
        Dim nbPair, nbPairAdd, nbTot, nbControle, nbImp, nbImpAdd As Integer
        Dim nasTemp As String

        nasTemp = Trim(NoAssSoc)
        nasTemp = NoAssSoc.Replace(" ", " ")
        Try
            If Not String.IsNullOrEmpty(NoAssSoc) Then
                NASValide = RgxNAS.IsMatch(NoAssSoc)
                If NASValide = False Then
                    NASValide = RgxNAS.IsMatch(NoAssSoc)
                End If
            End If

            For i = 1 To 9
                nbImp = CInt(Mid(nasTemp, i, 1))
                nbPair = CInt(Mid(nasTemp, i + 1, 1)) * 2
                If nbPair > 9 Then
                    nbPair = (nbPair - 10) + 1
                End If
                nbImpAdd = nbImpAdd + nbImp
                nbPairAdd = nbPairAdd + nbPair
                i += 1
                nbTot = nbPairAdd + nbImpAdd
                nbControle = (10 - (nbTot Mod 10))
                If nbControle <> CInt(Mid(nasTemp, 9, 1)) Then
                    NASValide = False
                Else
                    NASValide = True
                End If
            Next
        Catch
        End Try
        Try
            If Not String.IsNullOrEmpty(NoAssSoc) Then
                If NoAssSoc = rgxCrtInvalide_1.IsMatch(NoAssSoc) Then
                End If
            End If
        Catch
            MsgBox("Les caractères spéciaux ne sont pas acceptés")
        End Try
        If NASValide = False Then
            MsgBox("Le numéro d'assurance sociale n'est pas valide.", vbOKOnly + 48, "Gestion théatre")
        End If
        Return NASValide
    End Function

    Function ValidTexteCourt(ByVal txtCourt As String)
        Dim chaineTexteValide As Boolean = False
        Try
            If Not String.IsNullOrEmpty(txtCourt) Then
                chaineTexteValide = RgxChaineTexte.IsMatch(txtCourt)
            Else
                chaineTexteValide = False
            End If
        Catch
        End Try
        Return chaineTexteValide
    End Function

    Function ValidTexteLong(ByVal txtLong As String)
        Dim chaineTexteValide As Boolean = False
        Try
            If Not String.IsNullOrEmpty(txtLong) Then
                chaineTexteValide = RgxChaineTexte.IsMatch(txtLong)
            Else
                chaineTexteValide = False
            End If
        Catch
        End Try
        Return chaineTexteValide
    End Function

    Function ValidMDP(ByVal mdpUtil As String)
        Dim mdpUtilValide As Boolean = False
        Try
            If Not String.IsNullOrEmpty(mdpUtil) Then
                mdpUtilValide = RgxNoTel.IsMatch(mdpUtil)
            Else
                mdpUtilValide = False
            End If

            If Not String.IsNullOrEmpty(mdpUtil) Then
                If mdpUtil = rgxCrtInvalide_1.IsMatch(CStr(mdpUtil)) Then
                End If
            End If
        Catch
            MsgBox("Le mot de passe n'est pas accepté")

        End Try
        Return mdpUtilValide

    End Function


End Class


