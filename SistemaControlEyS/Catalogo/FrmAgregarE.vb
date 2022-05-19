Public Class FrmAgregarE
    Dim emplea As New DSAyatoTableAdapters.EmpleadoTableAdapter
    Dim Idempleado As Integer



    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmAgregarE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSAyato.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.DSAyato.Empleado)
        llenarGrid()

    End Sub

    Sub llenarGrid()
        DgvEmpleado.DataSource = emplea.GetData
        DgvEmpleado.Refresh()
        GroupBox2.Text = "Empleados guardados: " & DgvEmpleado.Rows.Count.ToString
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TextPersonal.Text = ""
        TextLaboral.Clear()
        TextTelefono.Clear()
        TextNombre.Clear()
        TextCiudad.Clear()
        TextApellidos.Clear()
        TextCedula.Clear()
        TextDireccion.Clear()
        TextIDCargo.Clear()
        TextIDHorario.Clear()
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        TextPersonal.Focus()


    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If (String.IsNullOrEmpty(TextPersonal.Text)) Then
            MsgBox("No puede quedar vacio el Correo Personal ", MsgBoxStyle.Critical, "ERROR")
            TextPersonal.Focus()
            Exit Sub
        End If

        If (String.IsNullOrEmpty(TextLaboral.Text)) Then
            MsgBox("No se puede quedar vacio el Correo Laboral", MsgBoxStyle.Critical, "ERROR")
            TextLaboral.Focus()
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextTelefono.Text)) Then
            MsgBox("No se puede quedar vacio el Teléfono", MsgBoxStyle.Critical, "ERROR")
            TextTelefono.Focus()
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextNombre.Text)) Then
            MsgBox("No se puede quedar vacio el Nombre", MsgBoxStyle.Critical, "ERROR")
            TextNombre.Focus()
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextCiudad.Text)) Then
            MsgBox("No se puede quedar vacio la Ciudad", MsgBoxStyle.Critical, "ERROR")
            TextCiudad.Focus()
            Exit Sub

        End If


        If (String.IsNullOrEmpty(TextApellidos.Text)) Then
            MsgBox("No se puede quedar vacio el Apellido", MsgBoxStyle.Critical, "ERROR")
            TextApellidos.Focus()
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextCedula.Text)) Then
            MsgBox("No se puede quedar vacio la Cédula", MsgBoxStyle.Critical, "ERROR")
            TextCedula.Focus()
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextDireccion.Text)) Then
            MsgBox("No se puede quedar vacio la Dirrección", MsgBoxStyle.Critical, "ERROR")
            TextDireccion.Focus()
            Exit Sub

        End If


        If (String.IsNullOrEmpty(TextIDCargo.Text)) Then
            MsgBox("Digite el ID del Cargo, porfavor...", MsgBoxStyle.Critical, "ERROR")
            TextIDCargo.Focus()
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextIDHorario.Text)) Then
            MsgBox("Digite el ID del horario, porfavor...", MsgBoxStyle.Critical, "ERROR")
            TextIDHorario.Focus()
            Exit Sub

        End If

        Dim correoPersona As String = TextPersonal.Text.Trim
        Dim correoLaboral As String = TextLaboral.Text.Trim
        Dim telefono As Integer = CInt(TextTelefono.Text.Trim)
        Dim nombre As String = TextNombre.Text.Trim
        Dim ciudad As String = TextCiudad.Text.Trim
        Dim apellido As String = TextApellidos.Text.Trim
        Dim cedula As String = TextCedula.Text.Trim
        Dim direccion As String = TextDireccion.Text.Trim
        Dim idCargo As Integer = CInt(TextIDCargo.Text.Trim)
        Dim idHorario As Integer = CInt(TextIDHorario.Text.Trim)

        If (emplea.InsertarEmpleado(correoPersona, correoLaboral, telefono, nombre, ciudad, apellido, cedula, direccion,
        idCargo, idHorario)) Then
            MsgBox("Se guardó con éxito el empleado", MsgBoxStyle.Information, "CORRECTO")
            llenarGrid()
        End If


    End Sub

    Private Sub DgvEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmpleado.CellContentClick

    End Sub

    Private Sub DtEmpleadoBindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If (String.IsNullOrEmpty(TextPersonal.Text)) Then

            MsgBox("No se puede quedar vacio el correo Personal", MsgBoxStyle.Critical, "ERROR")
            TextPersonal.Focus()
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextLaboral.Text)) Then
            MsgBox("No se puede quedar vacio el correo Laboral", MsgBoxStyle.Critical, "ERROR")
            TextLaboral.Focus()
            Exit Sub

        End If

        If (Not IsNumeric(TextTelefono.Text)) Then
            MsgBox("No se permiten caracteres, sólo valor númerico", MsgBoxStyle.Critical, "ERROR")
            TextTelefono.Focus()
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextNombre.Text)) Then
            MsgBox("No se puede quedar vacio el Nombre", MsgBoxStyle.Critical, "ERROR")
            TextNombre.Focus()
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextCiudad.Text)) Then
            MsgBox("No se puede quedar vacio la Ciudad", MsgBoxStyle.Critical, "ERROR")
            TextCiudad.Focus()
            Exit Sub

        End If


        If (String.IsNullOrEmpty(TextApellidos.Text)) Then
            MsgBox("No se puede quedar vacio el Apellido", MsgBoxStyle.Critical, "ERROR")
            TextApellidos.Focus()
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextCedula.Text)) Then
            MsgBox("No se puede quedar vacio la Cédula", MsgBoxStyle.Critical, "ERROR")
            TextCedula.Focus()
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextDireccion.Text)) Then
            MsgBox("No se puede quedar vacio la Dirrección", MsgBoxStyle.Critical, "ERROR")
            TextDireccion.Focus()
            Exit Sub

        End If


        If (String.IsNullOrEmpty(TextIDCargo.Text)) Then
            MsgBox("Digite el ID del Cargo, porfavor...", MsgBoxStyle.Critical, "ERROR")
            TextIDCargo.Focus()
            Exit Sub

        End If

        If (String.IsNullOrEmpty(TextIDHorario.Text)) Then
            MsgBox("Digite el ID del horario, porfavor...", MsgBoxStyle.Critical, "ERROR")
            TextIDHorario.Focus()
            Exit Sub

        End If

        Dim correoPersona As String = TextPersonal.Text.Trim
        Dim correoLaboral As String = TextLaboral.Text.Trim
        Dim telefono As Integer = CInt(TextTelefono.Text.Trim)
        Dim nombre As String = TextNombre.Text.Trim
        Dim ciudad As String = TextCiudad.Text.Trim
        Dim apellido As String = TextApellidos.Text.Trim
        Dim cedula As String = TextCedula.Text.Trim
        Dim direccion As String = TextDireccion.Text.Trim
        Dim idCargo As Integer = CInt(TextIDCargo.Text.Trim)
        Dim idHorario As Integer = CInt(TextIDHorario.Text.Trim)

        If (emplea.ActualizarEmpleado(correoPersona, correoLaboral, telefono, nombre, ciudad, apellido, cedula, direccion,
        idCargo, idHorario, Idempleado)) Then
            MsgBox("Se actualizo correctamente empleado...", MsgBoxStyle.Information, "ÉXITO")
            Exit Sub
            llenarGrid()
        End If
    End Sub

    Private Sub DgvEmpleado_DoubleClick(sender As Object, e As EventArgs) Handles DgvEmpleado.DoubleClick
        Try
            Dim fila As Integer = DgvEmpleado.CurrentRow.Index
            Idempleado = DgvEmpleado.Item(0, fila).Value
            TextPersonal.Text = DgvEmpleado.Item(1, fila).Value
            TextLaboral.Text = DgvEmpleado.Item(2, fila).Value
            TextTelefono.Text = DgvEmpleado.Item(3, fila).Value
            TextNombre.Text = DgvEmpleado.Item(4, fila).Value
            TextCiudad.Text = DgvEmpleado.Item(5, fila).Value
            TextApellidos.Text = DgvEmpleado.Item(6, fila).Value
            TextCedula.Text = DgvEmpleado.Item(7, fila).Value
            TextDireccion.Text = DgvEmpleado.Item(8, fila).Value
            TextIDCargo.Text = DgvEmpleado.Item(9, fila).Value
            TextIDHorario.Text = DgvEmpleado.Item(10, fila).Value
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
            resp = (MsgBox("¿Está seguro que desea eliminar al empleado?", vbQuestion + vbYesNo, "Eliminar"))

            If (resp = vbYes) Then
                emplea.EliminarEmpleado(Idempleado)
                llenarGrid()
                BtnNuevo.PerformClick()

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim dato As String = TxtDato.Text & "%"
            DgvEmpleado.DataSource = emplea.BuscarPorNombre(dato)
            DgvEmpleado.Refresh()

            GroupBox2.Text = "Empleados encontrados: " & DgvEmpleado.Rows.Count.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class