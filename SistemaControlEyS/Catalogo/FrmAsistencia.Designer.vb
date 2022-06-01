<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsistencia
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvRegistros = New System.Windows.Forms.DataGridView()
        Me.TextCedula = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvBusqueda = New System.Windows.Forms.DataGridView()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSAyato = New SistemaControlEyS.DSAyato()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEntrada = New System.Windows.Forms.Button()
        Me.BtnSalida = New System.Windows.Forms.Button()
        Me.LblTiempo = New System.Windows.Forms.Label()
        Me.EmpleadoTableAdapter = New SistemaControlEyS.DSAyatoTableAdapters.EmpleadoTableAdapter()
        Me.IdEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAyato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvRegistros)
        Me.GroupBox1.Location = New System.Drawing.Point(262, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 273)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registros "
        '
        'DgvRegistros
        '
        Me.DgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRegistros.Location = New System.Drawing.Point(3, 16)
        Me.DgvRegistros.Name = "DgvRegistros"
        Me.DgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRegistros.Size = New System.Drawing.Size(340, 254)
        Me.DgvRegistros.TabIndex = 0
        '
        'TextCedula
        '
        Me.TextCedula.Location = New System.Drawing.Point(22, 60)
        Me.TextCedula.Name = "TextCedula"
        Me.TextCedula.Size = New System.Drawing.Size(226, 20)
        Me.TextCedula.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvBusqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 161)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busquedas similares"
        '
        'DgvBusqueda
        '
        Me.DgvBusqueda.AutoGenerateColumns = False
        Me.DgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleadoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn})
        Me.DgvBusqueda.DataSource = Me.EmpleadoBindingSource
        Me.DgvBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvBusqueda.Location = New System.Drawing.Point(3, 16)
        Me.DgvBusqueda.Name = "DgvBusqueda"
        Me.DgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBusqueda.Size = New System.Drawing.Size(230, 142)
        Me.DgvBusqueda.TabIndex = 0
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.DSAyato
        '
        'DSAyato
        '
        Me.DSAyato.DataSetName = "DSAyato"
        Me.DSAyato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "[Digitar su cédula]"
        '
        'BtnEntrada
        '
        Me.BtnEntrada.Location = New System.Drawing.Point(22, 114)
        Me.BtnEntrada.Name = "BtnEntrada"
        Me.BtnEntrada.Size = New System.Drawing.Size(75, 23)
        Me.BtnEntrada.TabIndex = 5
        Me.BtnEntrada.Text = "ENTRADA"
        Me.BtnEntrada.UseVisualStyleBackColor = True
        '
        'BtnSalida
        '
        Me.BtnSalida.Location = New System.Drawing.Point(173, 114)
        Me.BtnSalida.Name = "BtnSalida"
        Me.BtnSalida.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalida.TabIndex = 6
        Me.BtnSalida.Text = "SALIDA"
        Me.BtnSalida.UseVisualStyleBackColor = True
        '
        'LblTiempo
        '
        Me.LblTiempo.AutoSize = True
        Me.LblTiempo.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTiempo.Location = New System.Drawing.Point(109, 325)
        Me.LblTiempo.Name = "LblTiempo"
        Me.LblTiempo.Size = New System.Drawing.Size(90, 28)
        Me.LblTiempo.TabIndex = 7
        Me.LblTiempo.Text = "Label2"
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'IdEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.Name = "IdEmpleadoDataGridViewTextBoxColumn"
        Me.IdEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        '
        'FrmAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(696, 369)
        Me.Controls.Add(Me.LblTiempo)
        Me.Controls.Add(Me.BtnSalida)
        Me.Controls.Add(Me.BtnEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TextCedula)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAsistencia"
        Me.Text = "Registrar Asistencia"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAyato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DSAyato As DSAyato
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvRegistros As DataGridView
    Friend WithEvents TextCedula As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvBusqueda As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEntrada As Button
    Friend WithEvents BtnSalida As Button
    Friend WithEvents LblTiempo As Label
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As DSAyatoTableAdapters.EmpleadoTableAdapter
    Friend WithEvents IdEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
