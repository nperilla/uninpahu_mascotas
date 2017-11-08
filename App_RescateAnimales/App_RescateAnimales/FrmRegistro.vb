Public Class FrmRegistro

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            create("INSERT INTO Persona (nombres, apellidos, correo, clave, direccion, numeroContacto) VALUES ('" & TxtNombre.Text & "','" _
                   & txtApe.Text & "','" & txtCorreo.Text & "','" & txtCla.Text & "','" & txtDir.Text & "','" & txtNumCon.Text & "')")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtNombre.Clear()
        txtApe.Clear()
        txtCorreo.Clear()
        txtCla.Clear()
        txtDir.Clear()
        txtNumCon.Clear()
        txtRepCla.Clear()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        FrmAnimal.Show()
    End Sub
    Private Sub FrmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT * FROM Persona", DTGLISTPersonas)
    End Sub

    Private Sub DTGLISTPersonas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGLISTPersonas.DoubleClick
        TxtNombre.Text = DTGLISTPersonas.CurrentRow.Cells(0).Value
    End Sub

 
 

End Class