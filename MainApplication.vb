Imports System.Data.OleDb

Module MdlKoneksi
    Public CONN As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As New DataSet
    Public DA As OleDbDataAdapter
    Public RD As OleDbDataReader
    Public lokasiData As String

    Public Sub konek()
        'Sesuaikan path dengan path di laptop/pc masing-masing
        Dim dbPath As String = ".\SampleAdoDb.mdb;"
        lokasiData = "Provider=microsoft.Jet.oledb.4.0;Data Source=" & dbPath & "user id=admin;password=;"

        CONN = New OleDbConnection(lokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
End Module


Public Class MainApplication
    Public isLoggedIn As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not isLoggedIn) Then
            mn_modules.Available = False
            mn_logout.Available = False
            mn_login_Click(sender, e)
        End If

    End Sub

    Private Sub mn_quit_Click(sender As Object, e As EventArgs) Handles mn_quit.Click
        Me.Close()
    End Sub

    Private Sub mn_login_Click(sender As Object, e As EventArgs) Handles mn_login.Click
        LoginForm.MdiParent = Me
        LoginForm.Show()
    End Sub

    Public Sub login_success()
        mn_login.Available = False
        mn_logout.Available = True
        mn_modules.Available = True
    End Sub

    Public Sub logout_success()
        mn_login.Available = True
        mn_logout.Available = False
        mn_modules.Available = False
    End Sub

    Private Sub mn_logout_Click(sender As Object, e As EventArgs) Handles mn_logout.Click
        logout_success()

    End Sub

    Private Sub mn_users_Click(sender As Object, e As EventArgs) Handles mn_users.Click
        UsersForm.MdiParent = Me
        UsersForm.Show()
    End Sub
End Class
