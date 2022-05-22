<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarC
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarC))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextIdDepart = New System.Windows.Forms.TextBox()
        Me.TextDescrip = New System.Windows.Forms.TextBox()
        Me.TextCargo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvCargo = New System.Windows.Forms.DataGridView()
        Me.TextDato = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.IdCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSAyato = New SistemaControlEyS.DSAyato()
        Me.CargoTableAdapter = New SistemaControlEyS.DSAyatoTableAdapters.CargoTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAyato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextIdDepart)
        Me.GroupBox1.Controls.Add(Me.TextDescrip)
        Me.GroupBox1.Controls.Add(Me.TextCargo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(713, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextIdDepart
        '
        Me.TextIdDepart.Location = New System.Drawing.Point(608, 30)
        Me.TextIdDepart.Name = "TextIdDepart"
        Me.TextIdDepart.Size = New System.Drawing.Size(98, 20)
        Me.TextIdDepart.TabIndex = 5
        '
        'TextDescrip
        '
        Me.TextDescrip.Location = New System.Drawing.Point(328, 30)
        Me.TextDescrip.Multiline = True
        Me.TextDescrip.Name = "TextDescrip"
        Me.TextDescrip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextDescrip.Size = New System.Drawing.Size(162, 78)
        Me.TextDescrip.TabIndex = 4
        '
        'TextCargo
        '
        Me.TextCargo.Location = New System.Drawing.Point(71, 30)
        Me.TextCargo.Name = "TextCargo"
        Me.TextCargo.Size = New System.Drawing.Size(162, 20)
        Me.TextCargo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(506, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvCargo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(474, 94)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cargos encontrados: 0"
        '
        'DgvCargo
        '
        Me.DgvCargo.AutoGenerateColumns = False
        Me.DgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCargo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCargoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.IdDepartamentoDataGridViewTextBoxColumn})
        Me.DgvCargo.DataSource = Me.CargoBindingSource
        Me.DgvCargo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCargo.Location = New System.Drawing.Point(3, 16)
        Me.DgvCargo.Name = "DgvCargo"
        Me.DgvCargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCargo.Size = New System.Drawing.Size(468, 75)
        Me.DgvCargo.TabIndex = 0
        '
        'TextDato
        '
        Me.TextDato.Location = New System.Drawing.Point(89, 163)
        Me.TextDato.Name = "TextDato"
        Me.TextDato.Size = New System.Drawing.Size(196, 20)
        Me.TextDato.TabIndex = 2
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(304, 163)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Buscar cargo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.BtnGuardar, Me.BtnEditar, Me.BtnEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(790, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(23, 22)
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(23, 22)
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnEditar
        '
        Me.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(23, 22)
        Me.BtnEditar.Text = "Editar"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(23, 22)
        Me.BtnEliminar.Text = "Eliminar"
        '
        'IdCargoDataGridViewTextBoxColumn
        '
        Me.IdCargoDataGridViewTextBoxColumn.DataPropertyName = "idCargo"
        Me.IdCargoDataGridViewTextBoxColumn.HeaderText = "idCargo"
        Me.IdCargoDataGridViewTextBoxColumn.Name = "IdCargoDataGridViewTextBoxColumn"
        Me.IdCargoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'IdDepartamentoDataGridViewTextBoxColumn
        '
        Me.IdDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "idDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.HeaderText = "idDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.Name = "IdDepartamentoDataGridViewTextBoxColumn"
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "Cargo"
        Me.CargoBindingSource.DataSource = Me.DSAyato
        '
        'DSAyato
        '
        Me.DSAyato.DataSetName = "DSAyato"
        Me.DSAyato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'FrmAgregarC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(790, 295)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TextDato)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAgregarC"
        Me.Text = "Agregar Cargo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvCargo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAyato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextIdDepart As TextBox
    Friend WithEvents TextDescrip As TextBox
    Friend WithEvents TextCargo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvCargo As DataGridView
    Friend WithEvents TextDato As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DSAyato As DSAyato
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As DSAyatoTableAdapters.CargoTableAdapter
    Friend WithEvents IdCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnEliminar As ToolStripButton
End Class
