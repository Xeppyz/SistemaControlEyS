<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Contraseña = New System.Windows.Forms.Label()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.TextContraseña = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Thistle
        Me.Label1.Location = New System.Drawing.Point(304, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Contraseña
        '
        Me.Contraseña.AutoSize = True
        Me.Contraseña.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contraseña.ForeColor = System.Drawing.Color.Thistle
        Me.Contraseña.Location = New System.Drawing.Point(304, 114)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(103, 21)
        Me.Contraseña.TabIndex = 2
        Me.Contraseña.Text = "Contraseña"
        '
        'TextUsuario
        '
        Me.TextUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUsuario.Location = New System.Drawing.Point(308, 64)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.Size = New System.Drawing.Size(231, 26)
        Me.TextUsuario.TabIndex = 1
        '
        'TextContraseña
        '
        Me.TextContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextContraseña.Location = New System.Drawing.Point(308, 151)
        Me.TextContraseña.Name = "TextContraseña"
        Me.TextContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextContraseña.Size = New System.Drawing.Size(231, 26)
        Me.TextContraseña.TabIndex = 3
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(308, 226)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(109, 51)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 325)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(624, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Registrar asistencia"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(807, 323)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TextContraseña)
        Me.Controls.Add(Me.TextUsuario)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Contraseña As Label
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents TextContraseña As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
