Public Class FrmLogin


    'Esto es un campo
    Private user As String = "admin"
    Private pw As String = "123"

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextContraseña.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click


        EvauluarUser()
    End Sub

    Private Sub TexUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextUsuario.TextChanged

    End Sub

    Sub EvauluarUser()
        If (TextUsuario.Text.Equals(user) And TextContraseña.Text.Equals(pw)) Then

            Form1.Show()
            Me.Close()

        Else
            MsgBox("Usuario o contraseña incorrecta. Verifica y vuelva a intentar...", MsgBoxStyle.Critical, "Error")

        End If

    End Sub

    Private Sub TextContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextContraseña.KeyPress
        If Asc(e.KeyChar()) = 13 Then
            EvauluarUser()
        End If

    End Sub

    Private Sub TextUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextUsuario.KeyPress
        If Asc(e.KeyChar()) = 13 Then
            TextContraseña.Focus()
            EvauluarUser()
        End If
    End Sub
End Class