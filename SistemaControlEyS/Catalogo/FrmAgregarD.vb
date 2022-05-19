Public Class FrmAgregarD

    Dim Depart As New DSAyatoTableAdapters.DepartamentoTableAdapter
    Dim IdDepart As Integer

    Private Sub FrmAgregarD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSAyato.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.DSAyato.Departamento)
        llenarGrid()
    End Sub

    Sub llenarGrid()
        DgvDepartamento.DataSource = Depart.GetData
        DgvDepartamento.Refresh()
        GroupBox2.Text = "Departamentos encontrados: " & DgvDepartamento.Rows.Count.ToString
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TextDepart.Text = ""
        TextCant.Clear()
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
        If (String.IsNullOrEmpty(TextCant.Text)) Then
            MsgBox("No se puede dejar en blanco la cantidad de empleados", MsgBoxStyle.Critical, "ERROR")
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
            MsgBox("No se puede dejar en blanco el Email", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If


        Dim nombreDepartamento As String = TextDepart.Text.Trim
        Dim cantidadEmpleados As Integer = CInt(TextCant.Text.Trim)
        Dim extension As String = TextExt.Text.Trim
        Dim jefeDepartamento As String = TextJefe.Text.Trim
        Dim email As String = TextEmail.Text.Trim

        If (Depart.InsertarDepartamento(nombreDepartamento, cantidadEmpleados, extension, jefeDepartamento, email)) Then
            MsgBox("Se guardó correctamente el departamento", MsgBoxStyle.Information, "Correcto")
            llenarGrid()
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If (String.IsNullOrEmpty(TextDepart.Text)) Then
            MsgBox("No se puede dejar en blanco el nombre", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TextCant.Text)) Then
            MsgBox("No se puede dejar en blanco la cantidad de empleados", MsgBoxStyle.Critical, "ERROR")
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
        Dim cantidadEmpleados As Integer = CInt(TextCant.Text.Trim)
        Dim extension As String = TextExt.Text.Trim
        Dim jefeDepartamento As String = TextJefe.Text.Trim
        Dim email As String = TextEmail.Text.Trim

        If (Depart.ActualizarDepartamento(nombreDepartamento, cantidadEmpleados, extension, jefeDepartamento, email, IdDepart)) Then
            MsgBox("Se actualizó correctamente el departamento", MsgBoxStyle.Information, "Correcto")
            llenarGrid()
        End If
    End Sub

    Private Sub DgvDepartamento_DoubleClick(sender As Object, e As EventArgs) Handles DgvDepartamento.DoubleClick

        Try
            Dim fila As Integer = DgvDepartamento.CurrentRow.Index
            IdDepart = DgvDepartamento.Item(0, fila).Value
            TextDepart.Text = DgvDepartamento.Item(1, fila).Value
            TextCant.Text = DgvDepartamento.Item(2, fila).Value
            TextExt.Text = DgvDepartamento.Item(3, fila).Value
            TextJefe.Text = DgvDepartamento.Item(4, fila).Value
            TextEmail.Text = DgvDepartamento.Item(5, fila).Value
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
        Try

            Dim dato As String = TextDato.Text & "%"
            DgvDepartamento.DataSource = Depart.BuscarPorNombre(IdDepart)
            DgvDepartamento.Refresh()


            GroupBox2.Text = "Departamentos encontrados: " & DgvDepartamento.Rows.Count.ToString



        Catch ex As Exception

        End Try
    End Sub
End Class