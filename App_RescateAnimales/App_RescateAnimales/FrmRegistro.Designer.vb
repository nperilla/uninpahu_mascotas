<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistro
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
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.LblApellidos = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNumeroContacto = New System.Windows.Forms.Label()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.lblRepClave = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtNumCon = New System.Windows.Forms.TextBox()
        Me.txtCla = New System.Windows.Forms.TextBox()
        Me.txtRepCla = New System.Windows.Forms.TextBox()
        Me.lblTituloRegistro = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTGLISTPersonas = New System.Windows.Forms.DataGridView()
        CType(Me.DTGLISTPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(29, 68)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(59, 13)
        Me.lblNombres.TabIndex = 0
        Me.lblNombres.Text = "* Nombres:"
        '
        'LblApellidos
        '
        Me.LblApellidos.AutoSize = True
        Me.LblApellidos.Location = New System.Drawing.Point(29, 97)
        Me.LblApellidos.Name = "LblApellidos"
        Me.LblApellidos.Size = New System.Drawing.Size(59, 13)
        Me.LblApellidos.TabIndex = 1
        Me.LblApellidos.Text = "* Apellidos:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(29, 133)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(48, 13)
        Me.lblCorreo.TabIndex = 2
        Me.lblCorreo.Text = "* Correo:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(29, 162)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(59, 13)
        Me.lblDireccion.TabIndex = 3
        Me.lblDireccion.Text = "*Direcciòn:"
        '
        'lblNumeroContacto
        '
        Me.lblNumeroContacto.AutoSize = True
        Me.lblNumeroContacto.Location = New System.Drawing.Point(29, 194)
        Me.lblNumeroContacto.Name = "lblNumeroContacto"
        Me.lblNumeroContacto.Size = New System.Drawing.Size(100, 13)
        Me.lblNumeroContacto.TabIndex = 4
        Me.lblNumeroContacto.Text = "* Numero Contacto:"
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New System.Drawing.Point(29, 225)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(44, 13)
        Me.lblClave.TabIndex = 5
        Me.lblClave.Text = "* Clave:"
        '
        'lblRepClave
        '
        Me.lblRepClave.AutoSize = True
        Me.lblRepClave.Location = New System.Drawing.Point(29, 256)
        Me.lblRepClave.Name = "lblRepClave"
        Me.lblRepClave.Size = New System.Drawing.Size(74, 13)
        Me.lblRepClave.TabIndex = 6
        Me.lblRepClave.Text = "Repetir Clave:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(139, 68)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(257, 20)
        Me.TxtNombre.TabIndex = 7
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(139, 97)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(257, 20)
        Me.txtApe.TabIndex = 8
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(139, 126)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(257, 20)
        Me.txtCorreo.TabIndex = 9
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(139, 155)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(257, 20)
        Me.txtDir.TabIndex = 10
        '
        'txtNumCon
        '
        Me.txtNumCon.Location = New System.Drawing.Point(139, 187)
        Me.txtNumCon.Name = "txtNumCon"
        Me.txtNumCon.Size = New System.Drawing.Size(257, 20)
        Me.txtNumCon.TabIndex = 11
        '
        'txtCla
        '
        Me.txtCla.Location = New System.Drawing.Point(139, 218)
        Me.txtCla.Name = "txtCla"
        Me.txtCla.Size = New System.Drawing.Size(257, 20)
        Me.txtCla.TabIndex = 12
        '
        'txtRepCla
        '
        Me.txtRepCla.Location = New System.Drawing.Point(139, 249)
        Me.txtRepCla.Name = "txtRepCla"
        Me.txtRepCla.Size = New System.Drawing.Size(257, 20)
        Me.txtRepCla.TabIndex = 13
        '
        'lblTituloRegistro
        '
        Me.lblTituloRegistro.AutoSize = True
        Me.lblTituloRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloRegistro.Location = New System.Drawing.Point(119, 20)
        Me.lblTituloRegistro.Name = "lblTituloRegistro"
        Me.lblTituloRegistro.Size = New System.Drawing.Size(222, 29)
        Me.lblTituloRegistro.TabIndex = 14
        Me.lblTituloRegistro.Text = "DATOS USUARIO"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(237, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Adicionar mascota:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "+"
        '
        'DTGLISTPersonas
        '
        Me.DTGLISTPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGLISTPersonas.Location = New System.Drawing.Point(32, 352)
        Me.DTGLISTPersonas.Name = "DTGLISTPersonas"
        Me.DTGLISTPersonas.Size = New System.Drawing.Size(364, 150)
        Me.DTGLISTPersonas.TabIndex = 20
        '
        'FrmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 525)
        Me.Controls.Add(Me.DTGLISTPersonas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTituloRegistro)
        Me.Controls.Add(Me.txtRepCla)
        Me.Controls.Add(Me.txtCla)
        Me.Controls.Add(Me.txtNumCon)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtApe)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.lblRepClave)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.lblNumeroContacto)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.LblApellidos)
        Me.Controls.Add(Me.lblNombres)
        Me.Name = "FrmRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistro"
        CType(Me.DTGLISTPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents LblApellidos As System.Windows.Forms.Label
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblNumeroContacto As System.Windows.Forms.Label
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents lblRepClave As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApe As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents txtNumCon As System.Windows.Forms.TextBox
    Friend WithEvents txtCla As System.Windows.Forms.TextBox
    Friend WithEvents txtRepCla As System.Windows.Forms.TextBox
    Friend WithEvents lblTituloRegistro As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTGLISTPersonas As System.Windows.Forms.DataGridView
End Class
