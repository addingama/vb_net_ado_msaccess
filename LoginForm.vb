Imports System.Data.OleDb

Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If (txt_username.Text = "") Then
            MessageBox.Show("Isi username anda")
            Exit Sub
        End If

        If (txt_password.Text = "") Then
            MessageBox.Show("Isi password anda")
            Exit Sub
        End If

        konek()

        Dim dbSelect As String = "SELECT count(nama) as jumlah FROM [users] WHERE [username]='" & txt_username.Text & "' AND [password]='" & txt_password.Text & "'"
        CMD = New OleDb.OleDbCommand(dbSelect, CONN)

        Dim jumlah As Int16 = CMD.ExecuteScalar()
        If (jumlah = 1) Then
            MainApplication.login_success()
            Me.Close()
        Else
            MessageBox.Show("Login Failed", "Error")
        End If


    End Sub
End Class