Imports System.Data.SqlClient
Public Class FrmLogin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Dim correo As String = TextBoxUser.Text
        Dim clave As String = TextBoxClave.Text
        ValidarUsuario(correo, clave)

    End Sub

    Private Sub LblRegistrarse_Click(sender As Object, e As EventArgs) Handles LblRegistrarse.Click
        FrmRegistro.Show()
        Me.Hide()
    End Sub
End Class
