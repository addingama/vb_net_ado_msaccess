Imports System.Data.OleDb

Public Class UsersForm
    Dim dataBaru As Boolean
    Dim userId As String

    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataBaru = True
        isiGrid()

    End Sub

    Private Sub isiTextBox()
        Dim i As Integer
        i = dgv_users.CurrentRow.Index
        dataBaru = False
        userId = dgv_users.Item(0, i).Value
        txt_name.Text = dgv_users.Item(1, i).Value
        txt_email.Text = dgv_users.Item(2, i).Value
        txt_username.Text = dgv_users.Item(3, i).Value
        txt_password.Text = dgv_users.Item(4, i).Value
    End Sub

    Private Sub bersihkanForm()
        dataBaru = False
        userId = ""
        txt_name.Text = ""
        txt_email.Text = ""
        txt_username.Text = ""
        txt_password.Text = ""
        txt_name.Focus()
    End Sub

    Private Sub isiGrid()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM users", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "users")
        dgv_users.DataSource = DS.Tables("users")
        dgv_users.Enabled = True
        txt_name.Focus()
    End Sub

    Private Sub jalankanSql(ByVal sql As String)
        CMD = New OleDbCommand
        konek()
        Try
            CMD.Connection = CONN
            CMD.CommandType = CommandType.Text
            CMD.CommandText = sql
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            MsgBox("Data Sudah Disimpan", vbInformation)
        Catch ex As Exception
            MessageBox.Show("Tidak bisa menyimpan data ke Database " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_users_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_users.CellClick
        isiTextBox()
    End Sub

    Private Sub btn_bersih_Click(sender As Object, e As EventArgs) Handles btn_bersih.Click
        bersihkanForm()
    End Sub

    Private Sub btn_baru_Click(sender As Object, e As EventArgs) Handles btn_baru.Click
        bersihkanForm()
        dataBaru = True
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim sql As String

        Me.Cursor = Cursors.WaitCursor

        If dataBaru Then
            sql = "INSERT INTO [users] ([nama], [email], [username], [password]) VALUES('" & txt_name.Text & "', '" & txt_email.Text & "', '" & txt_username.Text & "', '" & txt_password.Text & "')"
        Else
            sql = "UPDATE [users] SET [nama]='" & txt_name.Text &
                "', [email]='" & txt_email.Text &
                "', [username]='" & txt_username.Text &
                "', [password]='" & txt_password.Text &
                 "' WHERE ID =" & userId & " "
        End If

        jalankanSql(sql)
        bersihkanForm()
        isiGrid()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If userId <> "" Then
            Dim sql As String
            Dim pesan As Integer

            pesan = MsgBox("Apakah anda yakin akan menghapus Data ID " & userId, vbExclamation + vbYesNo, "Perhatian")
            If pesan = vbNo Then Exit Sub

            sql = "DELETE FROM [users] WHERE ID = " & userId

            jalankanSql(sql)
            Me.Cursor = Cursors.WaitCursor
            bersihkanForm()
            isiGrid()
            Me.Cursor = Cursors.Default

        End If

    End Sub
End Class