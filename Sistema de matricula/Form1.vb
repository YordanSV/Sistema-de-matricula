Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formIniciarSesion As New Usuarios.IniciarSesion
        formIniciarSesion.Show()

        'Dim form2 As New FormModificacionCursos()
        'form2.Show()
    End Sub
End Class
