Public Class FrmAgregarC

    Dim carg As New DSAyatoTableAdapters.CargoTableAdapter
    Dim idcargo As Integer


    Private Sub FrmAgregarC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSAyato.Cargo' Puede moverla o quitarla según sea necesario.
        Me.CargoTableAdapter.Fill(Me.DSAyato.Cargo)
        llenarGrid()
    End Sub

    Sub llenarGrid()
        DgvCargo.DataSource = carg.GetData
        DgvCargo.Refresh()
        GroupBox2.Text = "Cargos encontrados: " & DgvCargo.Rows.Count.ToString

    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TextCargo.Text = ""
        TextDescrip.Clear()
        TextIdDepart.Clear()
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        TextCargo.Focus()


    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If (String.IsNullOrEmpty(TextCargo.Text)) Then
            MsgBox("No se puede dejar en blanco el nombre", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If


        If (String.IsNullOrEmpty(TextDescrip.Text)) Then
            MsgBox("No se puede dejar en blanco la descripción", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If

        If (Not IsNumeric(TextIdDepart.Text)) Then
            MsgBox("No se puede dejar en blanco el ID", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If

        Dim cargo As String = TextCargo.Text.Trim
        Dim descripcion As String = TextDescrip.Text.Trim
        Dim iddepartamento As Integer = CInt(TextIdDepart.Text.Trim)

        If (carg.InsertarCargo(cargo, descripcion, iddepartamento)) Then
            MsgBox("Se guardó exitosamente", MsgBoxStyle.Information, "CORRECTO")
            llenarGrid()
        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If (String.IsNullOrEmpty(TextCargo.Text)) Then
            MsgBox("No se puede dejar en blanco el nombre", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If


        If (String.IsNullOrEmpty(TextDescrip.Text)) Then
            MsgBox("No se puede dejar en blanco la descripción", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If

        If (Not IsNumeric(TextIdDepart.Text)) Then
            MsgBox("No se puede dejar en blanco el ID", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If

        Dim cargo As String = TextCargo.Text.Trim
        Dim descripcion As String = TextDescrip.Text.Trim
        Dim iddepartamento As Integer = CInt(TextIdDepart.Text.Trim)

        If (carg.ActualizarCargo(cargo, descripcion, iddepartamento, idcargo)) Then
            MsgBox("Se actualizó correctamente el cargo", MsgBoxStyle.Information, "Correcto")
            llenarGrid()

            Exit Sub

        End If


    End Sub

    Private Sub DgvCargo_DoubleClick(sender As Object, e As EventArgs) Handles DgvCargo.DoubleClick
        Try

            Dim fila As Integer = DgvCargo.CurrentRow.Index
            idcargo = DgvCargo.Item(0, fila).Value
            TextCargo.Text = DgvCargo.Item(1, fila).Value
            TextDescrip.Text = DgvCargo.Item(2, fila).Value
            TextIdDepart.Text = DgvCargo.Item(3, fila).Value
            BtnGuardar.Enabled = False
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim resp As VariantType

            resp = MsgBox("¿Seguro que desea eliminar este cargo?", vbQuestion + vbYesNo)
            If (resp = vbYes) Then
                carg.EliminarCargo(idcargo)
                llenarGrid()
                BtnNuevo.PerformClick()


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim dato As String = TextDato.Text & "%"
            DgvCargo.DataSource = carg.BuscarPorNombre(dato)
            DgvCargo.Refresh()



            GroupBox2.Text = "Cargos encontrados: " & DgvCargo.Rows.Count.ToString

        Catch ex As Exception

        End Try
    End Sub
End Class