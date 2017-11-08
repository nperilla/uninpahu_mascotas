<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnimal
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNomMas = New System.Windows.Forms.TextBox()
        Me.txtCol = New System.Windows.Forms.TextBox()
        Me.txtEsp = New System.Windows.Forms.TextBox()
        Me.txtRaza = New System.Windows.Forms.TextBox()
        Me.txtFecPer = New System.Windows.Forms.TextBox()
        Me.txtRutIma = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGuardarAnimal = New System.Windows.Forms.Button()
        Me.CbxEstado = New System.Windows.Forms.ComboBox()
        Me.DGTList = New System.Windows.Forms.DataGridView()
        CType(Me.DGTList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "* Nombre mascota:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "* Color:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "* Especie:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "* Raza:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "* Estado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "* Fecha perdida:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "* Ruta Imagen:"
        '
        'txtNomMas
        '
        Me.txtNomMas.Location = New System.Drawing.Point(154, 54)
        Me.txtNomMas.Name = "txtNomMas"
        Me.txtNomMas.Size = New System.Drawing.Size(354, 20)
        Me.txtNomMas.TabIndex = 7
        '
        'txtCol
        '
        Me.txtCol.Location = New System.Drawing.Point(154, 86)
        Me.txtCol.Name = "txtCol"
        Me.txtCol.Size = New System.Drawing.Size(354, 20)
        Me.txtCol.TabIndex = 8
        '
        'txtEsp
        '
        Me.txtEsp.Location = New System.Drawing.Point(154, 120)
        Me.txtEsp.Name = "txtEsp"
        Me.txtEsp.Size = New System.Drawing.Size(354, 20)
        Me.txtEsp.TabIndex = 9
        '
        'txtRaza
        '
        Me.txtRaza.Location = New System.Drawing.Point(154, 150)
        Me.txtRaza.Name = "txtRaza"
        Me.txtRaza.Size = New System.Drawing.Size(354, 20)
        Me.txtRaza.TabIndex = 10
        '
        'txtFecPer
        '
        Me.txtFecPer.Location = New System.Drawing.Point(154, 208)
        Me.txtFecPer.Name = "txtFecPer"
        Me.txtFecPer.Size = New System.Drawing.Size(354, 20)
        Me.txtFecPer.TabIndex = 12
        '
        'txtRutIma
        '
        Me.txtRutIma.Location = New System.Drawing.Point(154, 245)
        Me.txtRutIma.Name = "txtRutIma"
        Me.txtRutIma.Size = New System.Drawing.Size(354, 20)
        Me.txtRutIma.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(134, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "DATOS ANIMAL"
        '
        'btnGuardarAnimal
        '
        Me.btnGuardarAnimal.Location = New System.Drawing.Point(54, 289)
        Me.btnGuardarAnimal.Name = "btnGuardarAnimal"
        Me.btnGuardarAnimal.Size = New System.Drawing.Size(142, 23)
        Me.btnGuardarAnimal.TabIndex = 16
        Me.btnGuardarAnimal.Text = "Guardar"
        Me.btnGuardarAnimal.UseVisualStyleBackColor = True
        '
        'CbxEstado
        '
        Me.CbxEstado.FormattingEnabled = True
        Me.CbxEstado.Items.AddRange(New Object() {"Perdido", "Recuperado"})
        Me.CbxEstado.Location = New System.Drawing.Point(154, 174)
        Me.CbxEstado.Name = "CbxEstado"
        Me.CbxEstado.Size = New System.Drawing.Size(354, 21)
        Me.CbxEstado.TabIndex = 17
        '
        'DGTList
        '
        Me.DGTList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTList.Location = New System.Drawing.Point(54, 319)
        Me.DGTList.Name = "DGTList"
        Me.DGTList.Size = New System.Drawing.Size(454, 150)
        Me.DGTList.TabIndex = 18
        '
        'FrmAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 494)
        Me.Controls.Add(Me.DGTList)
        Me.Controls.Add(Me.CbxEstado)
        Me.Controls.Add(Me.btnGuardarAnimal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRutIma)
        Me.Controls.Add(Me.txtFecPer)
        Me.Controls.Add(Me.txtRaza)
        Me.Controls.Add(Me.txtEsp)
        Me.Controls.Add(Me.txtCol)
        Me.Controls.Add(Me.txtNomMas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAnimal"
        CType(Me.DGTList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNomMas As System.Windows.Forms.TextBox
    Friend WithEvents txtCol As System.Windows.Forms.TextBox
    Friend WithEvents txtEsp As System.Windows.Forms.TextBox
    Friend WithEvents txtRaza As System.Windows.Forms.TextBox
    Friend WithEvents txtFecPer As System.Windows.Forms.TextBox
    Friend WithEvents txtRutIma As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnGuardarAnimal As System.Windows.Forms.Button
    Friend WithEvents CbxEstado As System.Windows.Forms.ComboBox
    Friend WithEvents DGTList As System.Windows.Forms.DataGridView
End Class
