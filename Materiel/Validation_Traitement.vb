Imports System.Text.RegularExpressions
Public Class Validation_Traitement

    '==========================================================================
    'AUTEUR:

    '   Code: Yanick Chrétien


    '==========================================================================


    Dim RgxVide As New Regex("((^([\s\t\0]?)$){1})")
    Dim RgxString_Unique As New Regex("((^[A-Z a-z áÁàÀâÂäÄéÉèÈëËêÊíÍîÎïÏóÓôÔòÒöÖúÚùÙûÛüÜçÇ\\s\- ]+$){1})")
    Dim RgxNumerique_Int As New Regex("((^[0-9]+$){1})")
    Dim RgxNumerique_Decimal As New Regex("(^(([0-9]+)([,.]?)([0-9]+)){1}$)")
    Dim RgxCodePostal As New Regex("((^([a-zA-z]{1})([0-9]{1})([a-zA-z]{1})([ ]*)([0-9]{1})([a-zA-z]{1})([0-9]{1})$){1})")
    Dim RgxNoTel As New Regex("((^([(]*)(([0-9]{3}){1})([)]*)([ -]*)(([0-9]{3}){1})([ -]*)(([0-9]{4}){1})$){1})")
    Dim RgxCourriel As New Regex("#^(.+)(@)((.+)([\.]{1})(.+))+$#")
    Dim RgxMotDePasse As New Regex("((^(?=.*?[0-9])(?=.*?[A-Z])(?=.*?[a-z]).{8,}$))")
    Dim RgxStringTousCaracteres As New Regex("((^[A-Z a-z 0-9 |><(){}\[\]#!%?&*-+\/=,.;:`''\""«»°_\ áÁàÀâÂäÄéÉèÈëËêÊíÍîÎïÏóÓôÔòÒöÖúÚùÙûÛüÜçÇ\\s\-]+$){1})")
    Dim rgxCrtInvalide_1 As New Regex("[#!/$%?&*()_+^¨>`:.,»«°¯­~{}][¶¾½¼³²¦¬¤¢£@±\|<;]µ§")
    Dim rgxCrtInvalide_2 As New Regex("")



    Function ValidStringTousCaractere(ByVal stringUtilisateur As String) As Boolean
        Dim entreeValide As Boolean = False
        Try
            If Not String.IsNullOrEmpty(stringUtilisateur) Then
                entreeValide = RgxStringTousCaracteres.IsMatch(stringUtilisateur)
            Else
                entreeValide = False
                MsgBox("Veuillez entrer uniquement des caratères svp.", vbOKCancel + 48, "Prêt Équipement")
            End If
        Catch
        End Try
        Return entreeValide
    End Function

    Function ValidStringSimple(ByVal stringUtilisateur As String) As Boolean
        Dim entreeValide As Boolean = False
        Try
            If Not String.IsNullOrEmpty(stringUtilisateur) Then
                entreeValide = RgxString_Unique.IsMatch(stringUtilisateur)
            Else
                entreeValide = False
                MsgBox("Veuillez entrer uniquement des caratères svp.", vbOKCancel + 48, "Prêt Équipement")
            End If
        Catch
        End Try
        Return entreeValide
    End Function



    Function ValidNombreInt(ByVal nombre As String) As Boolean
        Dim nombreValide As Boolean = False
        Try
            If Not String.IsNullOrEmpty(nombre) Then
                nombreValide = RgxNumerique_Int.IsMatch(nombre)
            Else
                nombreValide = False
                MsgBox("Veuillez entrer uniquement des caratères numériques svp.", vbOKCancel + 48, "Prêt Équipement")
            End If
        Catch
        End Try
        Return nombreValide
    End Function

    Function ValidNombreDouble(ByVal nombre As String) As Boolean
        Dim nombreValide As Boolean = False
        Try
            If Not String.IsNullOrEmpty(nombre) Then
                nombreValide = RgxNumerique_Decimal.IsMatch(nombre)
            Else
                nombreValide = False
                MsgBox("Veuillez entrer uniquement des caratères numériques svp.", vbOKCancel + 48, "Prêt Équipement")
            End If
        Catch
        End Try
        Return nombreValide
    End Function

    Function ValidNombreDecimal(ByVal nombre As String) As Boolean
        Dim nombreValide As Boolean = False
        Try
            If Not String.IsNullOrEmpty(nombre) Then
                nombreValide = RgxNumerique_Decimal.IsMatch(nombre)
            Else
                nombreValide = False
                MsgBox("Veuillez entrer uniquement des caratères numériques svp.", vbOKCancel + 48, "Prêt Équipement")
            End If
        Catch
        End Try
        Return nombreValide
    End Function


    Function Validation_EntreeUtilisateur(ByVal entreeUtilisateur As String) As String
        Dim valide As Boolean = False
        If ValidStringSimple(entreeUtilisateur) = False Then
            valide = True
        End If
        Return valide
    End Function

    Function Validation_EntreeUtilisateur(ByVal entreeUtilisateur As Integer) As String
        Dim valide As Boolean = False
        If ValidNombreInt(entreeUtilisateur) = False Then
            valide = True
        End If
        Return valide
    End Function

    Function Validation_EntreeUtilisateur(ByVal entreeUtilisateur As Double) As String
        Dim valide As Boolean = False
        If ValidNombreDouble(entreeUtilisateur) = False Then
            valide = True
        End If
        Return valide
    End Function

End Class


