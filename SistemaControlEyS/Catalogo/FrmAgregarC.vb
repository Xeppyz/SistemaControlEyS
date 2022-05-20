Public Class FrmAgregarC

    Dim carg As New DSAyatoTableAdapters.CargoTableAdapter


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



End Class