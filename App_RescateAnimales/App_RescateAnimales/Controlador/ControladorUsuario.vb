Imports System.Data.SqlClient

Module ControllerUser

    Dim ruta As String = "data source=EQUIPO\SQLEXPRESS;initial catalog=mascotas;user=nperilla;password=nperilla;"
    Public Conn As New SqlConnection
    Public Query As String
    Public DSet As DataSet
    Public Function ValidarUsuario(ByVal correo As String, ByVal pass As String)

        If correo.Length().Equals(0) Or pass.Length().Equals(0) Then
            MsgBox("El correo o la clave no pueden estar vacios")
        Else
            Try
                Using c As New SqlConnection(ruta)
                    Dim comando As New SqlCommand("SELECT Correo, Clave FROM PERSONA WHERE correo='" + correo + "'and clave='" + pass + "';", c)
                    c.Open()
                    Dim DAdapter As SqlDataReader = comando.ExecuteReader()
                    If DAdapter.HasRows = True Then
                        While DAdapter.Read
                            If correo.Equals(Trim(DAdapter(0))) And pass.Equals(Trim(DAdapter(1))) Then
                                MsgBox("Bienvenido")
                            Else
                                MsgBox("Usuario o clave incorrecta")
                            End If
                        End While
                    Else
                        MsgBox("No esta registrado el usuario")
                    End If
                End Using

            Catch ex As Exception
                MsgBox("Fallo la consulta login" + Err.Description)
            End Try
        End If
    End Function

End Module
