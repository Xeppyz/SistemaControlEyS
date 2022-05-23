Public Class Form1

    Dim empleado As New DSAyatoTableAdapters.EmpleadoTableAdapter
    Dim tblemp As New DSAyato.EmpleadoDataTable

    Private Sub btnReporte_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub ArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivoToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End


    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click


    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click

        empleado.Fill(tblemp)
        VerReporte(tblemp, "DsEmpleado", "C:\Users\alexa\OneDrive\Escritorio\SistemaControlEyS\SistemaControlEyS\Reporte\RptEmpleado.rdlc")



    End Sub

    Private Sub DepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem.Click



    End Sub

    Private Sub CargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem.Click





    End Sub

    Private Sub EmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem1.Click
        FrmAgregarC.Show()


    End Sub

    Private Sub EntradaYSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaYSalidaToolStripMenuItem.Click



    End Sub

    Private Sub EmpleadoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem2.Click
        FrmAgregarE.Show()


    End Sub

    Private Sub CargoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem1.Click
        FrmAgregarD.Show()



    End Sub

    Private Sub HorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorarioToolStripMenuItem.Click
        FrmAgregarH.Show()



    End Sub

    Private Sub EmpleadoToolStripMenuItem3_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub HorarioToolStripMenuItem1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub DepartamentoToolStripMenuItem1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub CargoToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmpleadoToolStripMenuItem4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub HorarioToolStripMenuItem2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub EntradaySalidaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EntradaySalidaToolStripMenuItem1.Click
        FrmEntradaYSalida.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormularioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormularioToolStripMenuItem.Click

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click

    End Sub
End Class
