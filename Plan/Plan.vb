Imports Carreras

Public Class Plan
    Public Property Semestres As List(Of Semestre)

    Public Sub New()
        Semestres = New List(Of Semestre)()
    End Sub

    Public Sub AgregarCurso(curso As Curso, semestre As Integer)
        Dim semestreExistente As Semestre = Semestres.FirstOrDefault(Function(s) s.Numero = semestre)
        If semestreExistente Is Nothing Then
            semestreExistente = New Semestre(semestre)
            Semestres.Add(semestreExistente)
        End If

        semestreExistente.Cursos.Add(curso)
    End Sub
End Class
