Public Class Form1

    Dim empleado As New DSAyatoTableAdapters.RptEmpleadoTableAdapter
    Dim tblemp As New DSAyato.RptEmpleadoDataTable

    Dim carg As New DSAyatoTableAdapters.RptCargoTableAdapter
    Dim tblcarg As New DSAyato.RptCargoDataTable

    Dim depart As New DSAyatoTableAdapters.RptDepartamentoTableAdapter
    Dim tbldepart As New DSAyato.RptDepartamentoDataTable

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
        depart.Fill(tbldepart)
        VerReporte(tbldepart, "DsDepartamento", "C:\Users\alexa\OneDrive\Escritorio\SistemaControlEyS\SistemaControlEyS\Reporte\RptDepartamento.rdlc")



    End Sub

    Private Sub CargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem.Click


        carg.Fill(tblcarg)
        VerReporte(tblcarg, "DsCargo", "C:\Users\alexa\OneDrive\Escritorio\SistemaControlEyS\SistemaControlEyS\Reporte\RptCargo.rdlc")


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

    Private Sub EntradaySalidaToolStripMenuItem1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormularioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormularioToolStripMenuItem.Click

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click

    End Sub

    Private Sub RegistrarEntradaYSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarEntradaYSalidaToolStripMenuItem.Click
        FrmLogin.Show()
        Me.Close()


    End Sub
End Class
