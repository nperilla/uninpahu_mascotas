<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.TextBoxClave = New System.Windows.Forms.TextBox()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblRegistrarse = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Location = New System.Drawing.Point(38, 55)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(201, 20)
        Me.TextBoxUser.TabIndex = 0
        '
        'TextBoxClave
        '
        Me.TextBoxClave.Location = New System.Drawing.Point(38, 110)
        Me.TextBoxClave.Name = "TextBoxClave"
        Me.TextBoxClave.Size = New System.Drawing.Size(201, 20)
        Me.TextBoxClave.TabIndex = 1
        Me.TextBoxClave.UseSystemPasswordChar = True
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(38, 145)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(201, 23)
        Me.ButtonAceptar.TabIndex = 2
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Location = New System.Drawing.Point(35, 37)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(48, 13)
        Me.LblUser.TabIndex = 3
        Me.LblUser.Text = "* Correo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "* Clave:"
        '
        'LblRegistrarse
        '
        Me.LblRegistrarse.AutoSize = True
        Me.LblRegistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistrarse.Location = New System.Drawing.Point(40, 183)
        Me.LblRegistrarse.Name = "LblRegistrarse"
        Me.LblRegistrarse.Size = New System.Drawing.Size(71, 13)
        Me.LblRegistrarse.TabIndex = 5
        Me.LblRegistrarse.Text = "Registrarse"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 228)
        Me.Controls.Add(Me.LblRegistrarse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.TextBoxClave)
        Me.Controls.Add(Me.TextBoxUser)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxUser As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxClave As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAceptar As System.Windows.Forms.Button
    Friend WithEvents LblUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblRegistrarse As System.Windows.Forms.Label

End Class
