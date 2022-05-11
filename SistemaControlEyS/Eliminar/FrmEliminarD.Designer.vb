<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarD
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Departamento"
        '
        'Button1
        '
        Me.Button1.Image = Global.SistemaControlEyS.My.Resources.Resources._1814090_delete_garbage_trash_icon
        Me.Button1.Location = New System.Drawing.Point(228, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 57)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(154, 49)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 33)
        Me.TextBox1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Image = Global.SistemaControlEyS.My.Resources.Resources._1814084_arrow_back_left_previous_icon
        Me.Button2.Location = New System.Drawing.Point(330, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 29)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.SistemaControlEyS.My.Resources.Resources._1814086_arrow_forward_next_right_icon
        Me.Button3.Location = New System.Drawing.Point(411, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 29)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FrmEliminarD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 355)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmEliminarD"
        Me.Text = "FrmEliminarD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
