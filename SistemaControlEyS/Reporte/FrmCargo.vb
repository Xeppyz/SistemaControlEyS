Public Class ReportViewer3

    Private Sub FmrCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer3.RefreshReport()


    End Sub

    Private Sub ReportViewer3_Load(sender As Object, e As EventArgs) Handles ReportViewer3.Load

    End Sub

    Private Sub DtCargoBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles DtEmpleadoBindingSource.CurrentChanged

    End Sub

End Class