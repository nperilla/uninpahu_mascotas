Public Class FrmAnimal

    Private Sub btnGuardarAnimal_Click(sender As Object, e As EventArgs) Handles btnGuardarAnimal.Click
        Try
            Dim a As New Integer
            a = 1
            create("INSERT INTO mascota(color, nombreMascota, imagen, especie, raza, estado, fechaPerdida, idPersona) VALUES ('" & txtCol.Text & "','" _
                   & txtNomMas.Text & "','" & txtRutIma.Text & "','" & txtEsp.Text & "','" & txtRaza.Text & "','" & CbxEstado.SelectedItem(0).ToString() & "','" & txtFecPer.Text & "','" & a & "')")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT * FROM mascota", DGTList)

    End Sub

    Private Sub DGTList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTList.DoubleClick
        txtNomMas.Text = DGTList.CurrentRow.Cells(0).Value


    End Sub
End Class