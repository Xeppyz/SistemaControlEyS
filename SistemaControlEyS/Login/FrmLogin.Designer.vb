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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Contraseña = New System.Windows.Forms.Label()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.TextContraseña = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Contraseña
        '
        Me.Contraseña.AutoSize = True
        Me.Contraseña.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contraseña.Location = New System.Drawing.Point(78, 123)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(101, 22)
        Me.Contraseña.TabIndex = 2
        Me.Contraseña.Text = "Contraseña"
        '
        'TextUsuario
        '
        Me.TextUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUsuario.Location = New System.Drawing.Point(185, 76)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.Size = New System.Drawing.Size(231, 26)
        Me.TextUsuario.TabIndex = 1
        '
        'TextContraseña
        '
        Me.TextContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextContraseña.Location = New System.Drawing.Point(185, 119)
        Me.TextContraseña.Name = "TextContraseña"
        Me.TextContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextContraseña.Size = New System.Drawing.Size(231, 26)
        Me.TextContraseña.TabIndex = 3
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(252, 172)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(109, 51)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.SistemaControlEyS.My.Resources.Resources._9102311_login_user_profile_account_password_icon
        Me.Button2.Location = New System.Drawing.Point(446, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 44)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.SistemaControlEyS.My.Resources.Resources._285655_user_icon
        Me.Button1.Location = New System.Drawing.Point(446, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 50)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 284)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TextContraseña)
        Me.Controls.Add(Me.TextUsuario)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Contraseña As Label
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents TextContraseña As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
