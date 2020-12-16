
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class ConnectBd


    Private _position As Integer = 0
    Public _ConnectionString As String

    Private _conn As New MySqlConnection
    Private _cmd As MySqlCommand
    Private _PrepCmd As New MySqlCommand
    Dim gestionOperation As New MySqlCommandBuilder

    'Constructeur par défault
    Sub New()
        _ConnectionString = "Server=localhost;DataBase=pret_materiel; Uid=root; Pwd='';Port=3308;"
    End Sub




    '- Permet de set ou get la position actuel de la personne sélectionner
    Public Property position() As Integer
        Get
            Return _position
        End Get
        Set(ByVal value As Integer)
            _position = value
        End Set
    End Property

    '- Permet de get ou set la connection string de la bd
    Public Property ConnectionString() As String
        Get
            Return _ConnectionString
        End Get
        Set(ByVal value As String)
            _ConnectionString = value
        End Set
    End Property


    '- Remplie mon dataset des données de ma bd en fonction de la requête envoyée.
    Sub Requete(ByVal req As String, ByVal ds As DataSet, ByVal da As MySqlDataAdapter, ByVal table As String)
        _conn.Close()
        _conn.ConnectionString = _ConnectionString




        Try
            If _conn.State <> ConnectionState.Open Then
                _conn.Open()
            End If
        Catch ae As SqlException
            MessageBox.Show(ae.Message.ToString())
        End Try



        _cmd = New MySqlCommand
        _cmd.Connection = _conn
        _cmd.CommandText = req
        da.SelectCommand = _cmd



        Try
            ' _cmd.ExecuteNonQuery()
            da = New MySqlDataAdapter(_cmd)
            da.Fill(ds, table)

        Catch ae As SqlException
            MessageBox.Show(ae.Message.ToString())

        End Try

        _conn.Close()
    End Sub


    '- Met à jour la bd selon la requete que je suis envoie. Elle sert pour les inserts, les updates, et les deletes.
    Sub InsDelUpd(ByVal req As String)

        _conn.ConnectionString = _ConnectionString

        Try
            If _conn.State <> ConnectionState.Open Then
                _conn.Open()
            End If
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())
        End Try



        _cmd = New MySqlCommand(req, _conn)



        Try
            _cmd.ExecuteNonQuery()
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())

        End Try

        _conn.Close()


    End Sub



    Sub Prepare_InsDelUpd(ByVal req As String, ByVal _PrepCmd As MySqlCommand, ByVal _PrepConn As MySqlConnection)

        _PrepConn.ConnectionString = _ConnectionString
        _PrepCmd.CommandText = req

        Try
            If _PrepConn.State <> ConnectionState.Open Then
                _PrepConn.Open()
            End If
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())
        End Try

        _PrepCmd.Prepare()


        Try
            _PrepCmd.ExecuteNonQuery()
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())

        End Try

        _PrepConn.Close()


    End Sub





    '- Met à jour la bd en fonction du dataset que je lui passe en paramètre
    Sub miseAjourBD(ByVal ds As DataSet, ByVal da As MySqlDataAdapter, tbl As String)

        _conn.ConnectionString = _ConnectionString

        Try
            If _conn.State <> ConnectionState.Open Then
                _conn.Open()
            End If
        Catch ae As SqlException
            MessageBox.Show(ae.Message.ToString())
        End Try



        Try
            gestionOperation = New MySqlCommandBuilder(da)
            da.Update(ds, tbl)
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())
        End Try

        _conn.Close()
    End Sub



    '- Met à jour un dataset avec les informations de la bd.
    Sub miseAjourDS(ByRef ds As DataSet, ByRef da As MySqlDataAdapter, req As String, table As String)
        ds = New DataSet
        da = New MySqlDataAdapter
        Requete(req, ds, da, table)
    End Sub

End Class

