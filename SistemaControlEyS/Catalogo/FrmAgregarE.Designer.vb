<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgregarE
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbHorario = New System.Windows.Forms.ComboBox()
        Me.CmbCargo = New System.Windows.Forms.ComboBox()
        Me.TextDireccion = New System.Windows.Forms.TextBox()
        Me.TextCedula = New System.Windows.Forms.TextBox()
        Me.TextApellidos = New System.Windows.Forms.TextBox()
        Me.TextCiudad = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TextTelefono = New System.Windows.Forms.TextBox()
        Me.TextLaboral = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextPersonal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDato = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.DatosEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSAyato = New SistemaControlEyS.DSAyato()
        Me.DatosEmpleadosTableAdapter = New SistemaControlEyS.DSAyatoTableAdapters.DatosEmpleadosTableAdapter()
        Me.IdEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CédulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailPersonalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailLaboralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TélefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirecciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdHorarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAyato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.BtnGuardar, Me.BtnEditar, Me.BtnEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(985, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNuevo.Image = Global.SistemaControlEyS.My.Resources.Resources.cleaning
        Me.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(23, 22)
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnGuardar.Image = Global.SistemaControlEyS.My.Resources.Resources.disquete
        Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(23, 22)
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnEditar
        '
        Me.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEditar.Image = Global.SistemaControlEyS.My.Resources.Resources.editar
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(23, 22)
        Me.BtnEditar.Text = "Editar"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEliminar.Image = Global.SistemaControlEyS.My.Resources.Resources.boton_eliminar
        Me.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(23, 22)
        Me.BtnEliminar.Text = "Eliminar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbHorario)
        Me.GroupBox1.Controls.Add(Me.CmbCargo)
        Me.GroupBox1.Controls.Add(Me.TextDireccion)
        Me.GroupBox1.Controls.Add(Me.TextCedula)
        Me.GroupBox1.Controls.Add(Me.TextApellidos)
        Me.GroupBox1.Controls.Add(Me.TextCiudad)
        Me.GroupBox1.Controls.Add(Me.TextNombre)
        Me.GroupBox1.Controls.Add(Me.TextTelefono)
        Me.GroupBox1.Controls.Add(Me.TextLaboral)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextPersonal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(985, 151)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'CmbHorario
        '
        Me.CmbHorario.FormattingEnabled = True
        Me.CmbHorario.Location = New System.Drawing.Point(727, 60)
        Me.CmbHorario.Name = "CmbHorario"
        Me.CmbHorario.Size = New System.Drawing.Size(158, 21)
        Me.CmbHorario.TabIndex = 8
        '
        'CmbCargo
        '
        Me.CmbCargo.FormattingEnabled = True
        Me.CmbCargo.Location = New System.Drawing.Point(77, 117)
        Me.CmbCargo.Name = "CmbCargo"
        Me.CmbCargo.Size = New System.Drawing.Size(158, 21)
        Me.CmbCargo.TabIndex = 9
        '
        'TextDireccion
        '
        Me.TextDireccion.Location = New System.Drawing.Point(487, 60)
        Me.TextDireccion.Multiline = True
        Me.TextDireccion.Name = "TextDireccion"
        Me.TextDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextDireccion.Size = New System.Drawing.Size(166, 47)
        Me.TextDireccion.TabIndex = 7
        '
        'TextCedula
        '
        Me.TextCedula.Location = New System.Drawing.Point(77, 13)
        Me.TextCedula.Name = "TextCedula"
        Me.TextCedula.Size = New System.Drawing.Size(144, 20)
        Me.TextCedula.TabIndex = 1
        '
        'TextApellidos
        '
        Me.TextApellidos.Location = New System.Drawing.Point(487, 13)
        Me.TextApellidos.Name = "TextApellidos"
        Me.TextApellidos.Size = New System.Drawing.Size(135, 20)
        Me.TextApellidos.TabIndex = 3
        '
        'TextCiudad
        '
        Me.TextCiudad.Location = New System.Drawing.Point(337, 61)
        Me.TextCiudad.Name = "TextCiudad"
        Me.TextCiudad.Size = New System.Drawing.Size(89, 20)
        Me.TextCiudad.TabIndex = 6
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(282, 13)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(144, 20)
        Me.TextNombre.TabIndex = 2
        '
        'TextTelefono
        '
        Me.TextTelefono.Location = New System.Drawing.Point(77, 61)
        Me.TextTelefono.Name = "TextTelefono"
        Me.TextTelefono.Size = New System.Drawing.Size(199, 20)
        Me.TextTelefono.TabIndex = 5
        '
        'TextLaboral
        '
        Me.TextLaboral.Location = New System.Drawing.Point(727, 13)
        Me.TextLaboral.Name = "TextLaboral"
        Me.TextLaboral.Size = New System.Drawing.Size(199, 20)
        Me.TextLaboral.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(680, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Horario"
        '
        'TextPersonal
        '
        Me.TextPersonal.Location = New System.Drawing.Point(354, 120)
        Me.TextPersonal.Name = "TextPersonal"
        Me.TextPersonal.Size = New System.Drawing.Size(168, 20)
        Me.TextPersonal.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = " Cargo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(432, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Dirección"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Cédula"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(432, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Apellidos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(291, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Ciudad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nombres"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Télefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(645, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Correo Laboral"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Correo Personal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvEmpleado)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(962, 157)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empleados guardados: 0"
        '
        'DgvEmpleado
        '
        Me.DgvEmpleado.AutoGenerateColumns = False
        Me.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleadoDataGridViewTextBoxColumn, Me.CédulaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.EmailPersonalDataGridViewTextBoxColumn, Me.EmailLaboralDataGridViewTextBoxColumn, Me.TélefonoDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.DirecciónDataGridViewTextBoxColumn, Me.IdHorarioDataGridViewTextBoxColumn, Me.IdCargoDataGridViewTextBoxColumn, Me.HorarioDataGridViewTextBoxColumn, Me.CargoDataGridViewTextBoxColumn})
        Me.DgvEmpleado.DataSource = Me.DatosEmpleadosBindingSource
        Me.DgvEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvEmpleado.Location = New System.Drawing.Point(3, 16)
        Me.DgvEmpleado.Name = "DgvEmpleado"
        Me.DgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmpleado.Size = New System.Drawing.Size(956, 138)
        Me.DgvEmpleado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Escriba el empleadoa  buscar"
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(162, 185)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(242, 20)
        Me.TxtDato.TabIndex = 11
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(410, 185)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(81, 23)
        Me.BtnBuscar.TabIndex = 12
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'DatosEmpleadosBindingSource
        '
        Me.DatosEmpleadosBindingSource.DataMember = "DatosEmpleados"
        Me.DatosEmpleadosBindingSource.DataSource = Me.DSAyato
        '
        'DSAyato
        '
        Me.DSAyato.DataSetName = "DSAyato"
        Me.DSAyato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatosEmpleadosTableAdapter
        '
        Me.DatosEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'IdEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.Name = "IdEmpleadoDataGridViewTextBoxColumn"
        Me.IdEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEmpleadoDataGridViewTextBoxColumn.Visible = False
        '
        'CédulaDataGridViewTextBoxColumn
        '
        Me.CédulaDataGridViewTextBoxColumn.DataPropertyName = "Cédula"
        Me.CédulaDataGridViewTextBoxColumn.HeaderText = "Cédula"
        Me.CédulaDataGridViewTextBoxColumn.Name = "CédulaDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        '
        'EmailPersonalDataGridViewTextBoxColumn
        '
        Me.EmailPersonalDataGridViewTextBoxColumn.DataPropertyName = "Email Personal"
        Me.EmailPersonalDataGridViewTextBoxColumn.HeaderText = "Email Personal"
        Me.EmailPersonalDataGridViewTextBoxColumn.Name = "EmailPersonalDataGridViewTextBoxColumn"
        Me.EmailPersonalDataGridViewTextBoxColumn.Visible = False
        '
        'EmailLaboralDataGridViewTextBoxColumn
        '
        Me.EmailLaboralDataGridViewTextBoxColumn.DataPropertyName = "Email Laboral"
        Me.EmailLaboralDataGridViewTextBoxColumn.HeaderText = "Email Laboral"
        Me.EmailLaboralDataGridViewTextBoxColumn.Name = "EmailLaboralDataGridViewTextBoxColumn"
        '
        'TélefonoDataGridViewTextBoxColumn
        '
        Me.TélefonoDataGridViewTextBoxColumn.DataPropertyName = "Télefono"
        Me.TélefonoDataGridViewTextBoxColumn.HeaderText = "Télefono"
        Me.TélefonoDataGridViewTextBoxColumn.Name = "TélefonoDataGridViewTextBoxColumn"
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        '
        'DirecciónDataGridViewTextBoxColumn
        '
        Me.DirecciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.Name = "DirecciónDataGridViewTextBoxColumn"
        '
        'IdHorarioDataGridViewTextBoxColumn
        '
        Me.IdHorarioDataGridViewTextBoxColumn.DataPropertyName = "IdHorario"
        Me.IdHorarioDataGridViewTextBoxColumn.HeaderText = "IdHorario"
        Me.IdHorarioDataGridViewTextBoxColumn.Name = "IdHorarioDataGridViewTextBoxColumn"
        Me.IdHorarioDataGridViewTextBoxColumn.Visible = False
        '
        'IdCargoDataGridViewTextBoxColumn
        '
        Me.IdCargoDataGridViewTextBoxColumn.DataPropertyName = "IdCargo"
        Me.IdCargoDataGridViewTextBoxColumn.HeaderText = "IdCargo"
        Me.IdCargoDataGridViewTextBoxColumn.Name = "IdCargoDataGridViewTextBoxColumn"
        Me.IdCargoDataGridViewTextBoxColumn.Visible = False
        '
        'HorarioDataGridViewTextBoxColumn
        '
        Me.HorarioDataGridViewTextBoxColumn.DataPropertyName = "Horario"
        Me.HorarioDataGridViewTextBoxColumn.HeaderText = "Horario"
        Me.HorarioDataGridViewTextBoxColumn.Name = "HorarioDataGridViewTextBoxColumn"
        '
        'CargoDataGridViewTextBoxColumn
        '
        Me.CargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo"
        Me.CargoDataGridViewTextBoxColumn.HeaderText = "Cargo"
        Me.CargoDataGridViewTextBoxColumn.Name = "CargoDataGridViewTextBoxColumn"
        '
        'FrmAgregarE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(985, 376)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtDato)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "FrmAgregarE"
        Me.Text = "Agregar Empleado"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAyato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnEliminar As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvEmpleado As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDato As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextDireccion As TextBox
    Friend WithEvents TextCedula As TextBox
    Friend WithEvents TextApellidos As TextBox
    Friend WithEvents TextCiudad As TextBox
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextTelefono As TextBox
    Friend WithEvents TextLaboral As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextPersonal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CmbCargo As ComboBox
    Friend WithEvents CmbHorario As ComboBox
    Friend WithEvents DSAyato As DSAyato
    Friend WithEvents DatosEmpleadosBindingSource As BindingSource
    Friend WithEvents DatosEmpleadosTableAdapter As DSAyatoTableAdapters.DatosEmpleadosTableAdapter
    Friend WithEvents IdEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CédulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailPersonalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailLaboralDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TélefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirecciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdHorarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
