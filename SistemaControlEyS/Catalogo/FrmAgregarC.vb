Public Class FrmAgregarC
    Private Sub FrmAgregarC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSAyato.Cargo' Puede moverla o quitarla según sea necesario.
        Me.CargoTableAdapter.Fill(Me.DSAyato.Cargo)

    End Sub
End Class