Public Class FrmLogin


    'Esto es un campo
    ' Private user As String = "admin"
    ' Private pw As String = "123"

    Dim login As New DSAyatoTableAdapters.LoginTableAdapter

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextContraseña.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Try

            Dim x As DataTable = login.BuscarLogin(TextUsuario.Text, TextContraseña.Text)
            If (x.Rows.Count() <= 0) Then
                MsgBox("Usuario no encontrado", MsgBoxStyle.Critical, "ERROR")
            Else
                MsgBox("Usuario encontrado", MsgBoxStyle.Information, "Correcto")
                Form1.Show()

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TexUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextUsuario.TextChanged

    End Sub




    Private Sub TextContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextContraseña.KeyPress
        If Asc(e.KeyChar()) = 13 Then

        End If

    End Sub

    Private Sub TextUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextUsuario.KeyPress
        If Asc(e.KeyChar()) = 13 Then
            TextContraseña.Focus()

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FrmAsistencia.Show()

        Me.Close()
    End Sub
End Class