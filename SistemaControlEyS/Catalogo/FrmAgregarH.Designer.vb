﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgregarH
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextSalida = New System.Windows.Forms.TextBox()
        Me.TextEntrada = New System.Windows.Forms.TextBox()
        Me.TextDescrip = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvHorario = New System.Windows.Forms.DataGridView()
        Me.DSAyato = New SistemaControlEyS.DSAyato()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextDato = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAyato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.BtnGuardar, Me.BtnEditar, Me.BtnEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(853, 25)
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
        Me.GroupBox1.Controls.Add(Me.TextSalida)
        Me.GroupBox1.Controls.Add(Me.TextEntrada)
        Me.GroupBox1.Controls.Add(Me.TextDescrip)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 114)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TextSalida
        '
        Me.TextSalida.Location = New System.Drawing.Point(552, 28)
        Me.TextSalida.Name = "TextSalida"
        Me.TextSalida.Size = New System.Drawing.Size(100, 20)
        Me.TextSalida.TabIndex = 5
        '
        'TextEntrada
        '
        Me.TextEntrada.Location = New System.Drawing.Point(365, 27)
        Me.TextEntrada.Name = "TextEntrada"
        Me.TextEntrada.Size = New System.Drawing.Size(100, 20)
        Me.TextEntrada.TabIndex = 4
        '
        'TextDescrip
        '
        Me.TextDescrip.Location = New System.Drawing.Point(87, 19)
        Me.TextDescrip.Multiline = True
        Me.TextDescrip.Name = "TextDescrip"
        Me.TextDescrip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextDescrip.Size = New System.Drawing.Size(175, 84)
        Me.TextDescrip.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(471, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hora de salida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hora de entrada"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(24, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(63, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Descripción"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvHorario)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 130)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Horarios encontrados: 0"
        '
        'DgvHorario
        '
        Me.DgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHorario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvHorario.Location = New System.Drawing.Point(3, 16)
        Me.DgvHorario.Name = "DgvHorario"
        Me.DgvHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvHorario.Size = New System.Drawing.Size(770, 111)
        Me.DgvHorario.TabIndex = 0
        '
        'DSAyato
        '
        Me.DSAyato.DataSetName = "DSAyato"
        Me.DSAyato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Buscar por descripción"
        '
        'TextDato
        '
        Me.TextDato.Location = New System.Drawing.Point(231, 183)
        Me.TextDato.Name = "TextDato"
        Me.TextDato.Size = New System.Drawing.Size(100, 20)
        Me.TextDato.TabIndex = 4
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(337, 183)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 5
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FrmAgregarH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(853, 401)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TextDato)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmAgregarH"
        Me.Text = "Agregar horario"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvHorario, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextSalida As TextBox
    Friend WithEvents TextEntrada As TextBox
    Friend WithEvents TextDescrip As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvHorario As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TextDato As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents DSAyato As DSAyato
End Class
