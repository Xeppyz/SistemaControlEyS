Public Class FrmAgregarD

    Dim Depart As New DSAyatoTableAdapters.DepartamentoTableAdapter
    Dim IdDepart As Integer
    Dim Tadepart As New DSAyatoTableAdapters.DatosDepartamentosTableAdapter
    Dim Dtdepart As New DSAyato.DatosDepartamentosDataTable


    Private Sub FrmAgregarD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarGrid()

    End Sub

    Sub llenarGrid()

        Tadepart.Fill(Dtdepart)
        DgvDepartamento.DataSource = Dtdepart
        DgvDepartamento.Refresh()

        Dim contador As Integer = CInt(DgvDepartamento.Rows.Count) - 1
        GroupBox2.Text = "Departamento encontrados: " & contador.ToString

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TextDepart.Text = ""

        TextExt.Clear()
        TextJefe.Clear()
        TextEmail.Clear()
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        TextDepart.Focus()


    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If (String.IsNullOrEmpty(TextDepart.Text)) Then
            MsgBox("No se puede dejar en blanco el nombre", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If

        If (String.IsNullOrEmpty(TextExt.Text)) Then
            MsgBox("No se puede dejar en blanco la extensión", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TextJefe.Text)) Then
            MsgBox("No se puede dejar en blanco el jefe", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TextEmail.Text)) Then
            MsgBox("No se permite dejar en blanco el Email", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If



        Dim nombreDepartamento As String = TextDepart.Text.Trim
        Dim extension As String = TextExt.Text.Trim
        Dim jefeDepartamento As String = TextJefe.Text.Trim
        Dim email As String = TextEmail.Text.Trim

        If (Depart.InsertarDepartamento(nombreDepartamento, extension, jefeDepartamento, email)) Then
            MsgBox("Se guardó correctamente el departamento", MsgBoxStyle.Information, "Correcto")
            llenarGrid()
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If (String.IsNullOrEmpty(TextDepart.Text)) Then
            MsgBox("No se puede dejar en blanco el nombre", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If

        If (String.IsNullOrEmpty(TextExt.Text)) Then
            MsgBox("No se puede dejar en blanco la extensión", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TextJefe.Text)) Then
            MsgBox("No se permiten caracteres, sólo números", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TextEmail.Text)) Then
            MsgBox("No se puede dejar en blanco el Email", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If

        Dim nombreDepartamento As String = TextDepart.Text.Trim

        Dim extension As String = TextExt.Text.Trim
        Dim jefeDepartamento As String = TextJefe.Text.Trim
        Dim email As String = TextEmail.Text.Trim

        If (Depart.ActualizarDepartamento(nombreDepartamento, extension, jefeDepartamento, email, IdDepart)) Then
            MsgBox("Se actualizó con éxito el departamento...", MsgBoxStyle.Information, "CORRECTO")
            llenarGrid()
        End If
    End Sub

    Private Sub DgvDepartamento_DoubleClick(sender As Object, e As EventArgs) Handles DgvDepartamento.DoubleClick

        Try
            Dim fila As Integer = DgvDepartamento.CurrentRow.Index
            IdDepart = DgvDepartamento.Item(0, fila).Value
            TextDepart.Text = DgvDepartamento.Item(1, fila).Value
            TextExt.Text = DgvDepartamento.Item(2, fila).Value
            TextJefe.Text = DgvDepartamento.Item(3, fila).Value
            TextEmail.Text = DgvDepartamento.Item(4, fila).Value
            BtnGuardar.Enabled = False
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try


            Dim resp As VariantType
            resp = MsgBox("¿Estás seguro que deseas eliminar este departamento?", vbQuestion + vbYesNo)
            If (resp = vbYes) Then
                Depart.EliminarDepartamento(IdDepart)
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
                DgvDepartamento.DataSource = Depart.BuscarPorNombre(dato)
                DgvDepartamento.Refresh()

                Dim contador As Integer = CInt(DgvDepartamento.Rows.Count) - 1
                GroupBox2.Text = "Departamentos encontrados: " & contador.ToString




            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub TextExt_TextChanged(sender As Object, e As EventArgs) Handles TextExt.TextChanged

    End Sub
End Class