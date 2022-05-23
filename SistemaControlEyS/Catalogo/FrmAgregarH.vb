Public Class FrmAgregarH
    Dim horario As New DSAyatoTableAdapters.HorarioTableAdapter
    Dim idHorario As Integer


    Private Sub FrmAgregarH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSAyato.Horario' Puede moverla o quitarla según sea necesario.
        Me.HorarioTableAdapter.Fill(Me.DSAyato.Horario)
        llenarGrid()

    End Sub

    Sub llenarGrid()

        DgvHorario.DataSource = horario.GetData
        DgvHorario.Refresh()
        DgvHorario.Columns().Item(0).Visible = False
        Dim contador As Integer = CInt(DgvHorario.Rows.Count) - 1
        GroupBox2.Text = "Horarios encontrados: " & contador.ToString

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TextDescrip.Text = ""
        TextEntrada.Clear()
        TextSalida.Clear()
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        TextDescrip.Focus()



    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If (String.IsNullOrEmpty(TextDescrip.Text)) Then
            MsgBox("No se puede dejar en blanco la descripción", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If

        If (String.IsNullOrEmpty(TextEntrada.Text)) Then
            MsgBox("No se puede dejar en blanco la entrada", MsgBoxStyle.Critical, "ERROR")
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextSalida.Text)) Then
            MsgBox("No se puede dejar en blanco la salida", MsgBoxStyle.Critical, "ERROR")
            Exit Sub

        End If
        Dim descripcion As String = TextDescrip.Text.Trim
        Dim entrada As String = TextEntrada.Text.Trim
        Dim salida As String = TextSalida.Text.Trim

        If (horario.InsertarHorario(descripcion, entrada, salida)) Then
            MsgBox("Se guardó con correctamente", MsgBoxStyle.Information, "Correcto")
            llenarGrid()

        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If (String.IsNullOrEmpty(TextDescrip.Text)) Then
            MsgBox("No se puede dejar en blanco la descripción", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If

        If (String.IsNullOrEmpty(TextEntrada.Text)) Then
            MsgBox("No se puede dejar en blanco la entrada", MsgBoxStyle.Critical, "ERROR")
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextSalida.Text)) Then
            MsgBox("No se puede dejar en blanco la salida", MsgBoxStyle.Critical, "ERROR")
            Exit Sub

        End If

        Dim descripcion As String = TextDescrip.Text.Trim
        Dim entrada As String = TextEntrada.Text.Trim
        Dim salida As String = TextSalida.Text.Trim

        If (horario.ActualizarHorario(descripcion, entrada, salida, idHorario)) Then
            MsgBox("Se actualizó correctamente", MsgBoxStyle.Information, "Correcto")
            llenarGrid()

        End If



    End Sub

    Private Sub DgvHorario_DoubleClick(sender As Object, e As EventArgs) Handles DgvHorario.DoubleClick
        Try
            Dim fila As Integer = DgvHorario.CurrentRow.Index
            idHorario = DgvHorario.Item(0, fila).Value
            TextDescrip.Text = DgvHorario.Item(1, fila).Value
            TextEntrada.Text = DgvHorario.Item(2, fila).Value
            TextSalida.Text = DgvHorario.Item(3, fila).Value
            BtnGuardar.Enabled = False
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True


        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim resp As VariantType
            resp = MsgBox("¿Desea eliminar este horario?", vbQuestion + vbYesNo)
            If (resp = vbYes) Then
                horario.EliminarHorario(IdHorario)
                llenarGrid()
                BtnNuevo.PerformClick()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click


        If (TextDato.Text.Equals("")) Then
            llenarGrid()

        Else
            Try
                Dim dato As String = TextDato.Text & "%"

                DgvHorario.DataSource = horario.BuscarPorID(dato)
                DgvHorario.Refresh()
                Dim contador As Integer = CInt(DgvHorario.Rows.Count) - 1
                GroupBox2.Text = "Horarios encontrados: " & contador.ToString


            Catch ex As Exception

            End Try
        End If



    End Sub
End Class