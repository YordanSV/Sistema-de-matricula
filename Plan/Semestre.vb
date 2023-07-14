
Imports Carreras

Public Class Semestre
    Public Property Numero As Integer
    Public Property Cursos As List(Of Curso)

    Public Sub New(numero As Integer)
        Me.Numero = numero
        Cursos = New List(Of Curso)()
    End Sub
End Class
