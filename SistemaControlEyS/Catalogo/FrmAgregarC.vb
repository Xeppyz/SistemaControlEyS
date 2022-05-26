Public Class FrmAgregarC

    Dim carg As New DSAyatoTableAdapters.CargoTableAdapter
    Dim idcargo As Integer
    Dim depart As New DSAyatoTableAdapters.DepartamentoTableAdapter

    Dim Tacargo As New DSAyatoTableAdapters.DatosCargosTableAdapter
    Dim Dtcargo As New DSAyato.DatosCargosDataTable


    Private Sub FrmAgregarC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarGrid()
        llenarDepart()

    End Sub

    Sub llenarDepart()

        CmbDepart.DataSource = depart.GetData
        CmbDepart.DisplayMember = "Nombre"
        CmbDepart.ValueMember = "idDepartamento"
        CmbDepart.Refresh()

    End Sub

    Sub llenarGrid()

        Tacargo.Fill(Dtcargo)
        DgvCargo.DataSource = Dtcargo
        DgvCargo.Refresh()
        DgvCargo.Columns.Item("ID Departamento").Visible = False
        DgvCargo.Columns.Item("ID Cargo").Visible = False
        Dim contador As Integer = CInt(DgvCargo.Rows.Count) - 1
        GroupBox2.Text = "Cargos encontrados: " & contador.ToString



    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TextCargo.Text = ""
        TextDescrip.Clear()
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



        Dim cargo As String = TextCargo.Text.Trim
        Dim descripcion As String = TextDescrip.Text.Trim
        Dim iddepartamento As Integer = CInt(CmbDepart.SelectedValue)


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



        Dim cargo As String = TextCargo.Text.Trim
        Dim descripcion As String = TextDescrip.Text.Trim
        Dim iddepartamento As Integer = CInt(CmbDepart.SelectedValue)

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
            CmbDepart.SelectedValue = DgvCargo.Item(3, fila).Value
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

        If (TextDato.Text.Equals("")) Then
            llenarGrid()


        Else
            Try
                Dim dato As String = TextDato.Text & "%"
                DgvCargo.DataSource = carg.BuscarPorNombre(dato)
                DgvCargo.Refresh()


                Dim contador As Integer = CInt(DgvCargo.Rows.Count) - 1
                GroupBox2.Text = "Cargos encontrados: " & contador.ToString

            Catch ex As Exception

            End Try


        End If



    End Sub

    Private Sub CmbDepart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDepart.SelectedIndexChanged

    End Sub
End Class