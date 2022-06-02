Public Class FrmAsistencia

    Dim Eys As New DSAyatoTableAdapters.RegistroEntradaySalidaTableAdapter
    Dim Ideys As New DSAyato.RegistroEntradaySalidaDataTable
    Dim Emp As New DSAyatoTableAdapters.EmpleadoTableAdapter

    Dim TblAsis As New DSAyatoTableAdapters.DatosAsistenciaTableAdapter
    Dim DtAsis As New DSAyato.DatosAsistenciaDataTable




    Dim fecha As String
    Dim horaEntrada As String
    Dim horaSalida As String
    Dim IdEmp As Integer = 0
    Dim cedula As String

    Private Sub FrmAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSAyato.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.DSAyato.Empleado)
        llenarGrid()
        BtnSalida.Enabled = False

        Timer1.Enabled = True

    End Sub

    Sub llenarGrid()

        TblAsis.Fill(DtAsis)
        DgvRegistros.DataSource = DtAsis
        DgvRegistros.Columns.Item("ID Registro").Visible = False
        DgvRegistros.Columns.Item("ID Empleado").Visible = False

        If (TextCedula.Text.Equals("")) Then
            DgvBusqueda.Columns.Item(0).Visible = False
            DgvBusqueda.Columns.Item(1).Visible = False
            DgvBusqueda.Columns.Item(2).Visible = False

        Else
            DgvBusqueda.DataSource = Emp.GetData
            DgvBusqueda.Refresh()
        End If





    End Sub

    Private Sub CmbEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LblTiempo.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        LblTiempo.Text = DateTime.Now.ToString("HH:mm:ss")

    End Sub

    Private Sub TextCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCedula.KeyPress
        If Asc(e.KeyChar()) = 13 Then
            If (TextCedula.Text.Equals("")) Then
                llenarGrid()

            Else
                llenarGrid()
                DgvBusqueda.Columns.Item(0).Visible = False
                DgvBusqueda.Columns.Item(1).Visible = True
                DgvBusqueda.Columns.Item(2).Visible = True

                Try
                    Dim dato As String = TextCedula.Text
                    DgvBusqueda.DataSource = Emp.BuscarPorCedula(dato)

                    DgvBusqueda.Refresh()
                    GroupBox2.Text = "Busquedas similares: " & DgvBusqueda.Rows.Count.ToString - 1
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                End Try
            End If
        End If
    End Sub

    Private Sub DgvBusqueda_DoubleClick(sender As Object, e As EventArgs) Handles DgvBusqueda.DoubleClick
        Try
            Dim fila As Integer = DgvBusqueda.CurrentRow.Index

            IdEmp = DgvBusqueda.Item(0, fila).Value
            TextCedula.Text = DgvBusqueda.Item(2, fila).Value

            cedula = TextCedula.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try

    End Sub

    Private Sub BtnEntrada_Click(sender As Object, e As EventArgs) Handles BtnEntrada.Click
        If (IdEmp.Equals(0)) Then
            MsgBox("No hay ningun empleado seleccionado", MsgBoxStyle.Critical, "Error")
        Else
            BtnSalida.Enabled = True
            BtnEntrada.Enabled = False
            fecha = DateTime.Now.ToString("yyyy-MM-dd")
            horaEntrada = LblTiempo.Text.ToString
            MsgBox(fecha & " " & horaEntrada, MsgBoxStyle.Information, "Marca aceptada")
        End If



    End Sub

    Private Sub BtnSalida_Click(sender As Object, e As EventArgs) Handles BtnSalida.Click
        BtnEntrada.Enabled = True
        BtnSalida.Enabled = False

        horaSalida = LblTiempo.Text.ToString



        If (IdEmp.Equals(0)) Then
            MsgBox("No hay ningun empleado seleccionado", MsgBoxStyle.Critical, "Error")
        Else
            MsgBox(fecha & " " & horaEntrada, MsgBoxStyle.Information, "Marca Aceptada.")
            Try
                Eys.InsertarMarca(IdEmp, horaEntrada, horaSalida, cedula, fecha)
                llenarGrid()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmLogin.Show()
        Me.Close()

    End Sub
End Class