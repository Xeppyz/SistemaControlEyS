Public Class FrmAsistencia

    Dim Eys As New DSAyatoTableAdapters.RegistroEntradaySalidaTableAdapter
    Dim Ideys As New DSAyato.RegistroEntradaySalidaDataTable
    Dim Emp As New DSAyatoTableAdapters.EmpleadoTableAdapter





    Private Sub FrmAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSAyato.RegistroEntradaySalida' Puede moverla o quitarla según sea necesario.

        Eys.Fill(Ideys)


        llenarGrid()
        Timer1.Enabled = True

    End Sub

    Sub llenarGrid()



    End Sub

    Private Sub CmbEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LblTiempo.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        LblTiempo.Text = DateTime.Now.ToString("HH:mm:ss")

    End Sub
End Class