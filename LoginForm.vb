Imports System.Data.OleDb

Public Class LoginForm
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dataset As DataSet = New DataSet()

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

        Try
            Using cnn As New OleDbConnection(MainApplication.connectionString)
                cnn.Open()

                Dim dbSelect As String = "SELECT * FROM [users] WHERE [username]='" & txt_username.Text & "' AND [password]='" & txt_password.Text & "'"
                Using cmd As New OleDbCommand(dbSelect, cnn)

                    Dim sdr As OleDbDataReader = cmd.ExecuteReader()
                    If (sdr.Read() = True) Then
                        MainApplication.login_success()
                        Me.Close()
                    Else
                        MessageBox.Show("Login Failed", "Error")
                    End If

                    sdr.Close()
                End Using
                cnn.Close()
                cnn.Dispose()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "OleDb Exception")
        End Try


    End Sub
End Class