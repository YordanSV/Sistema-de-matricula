Imports Carreras

Public Class Matricula
    Public Property CarnetEstudiante As Integer
    Public Property CodigoCarrera As String
    Public Property CursosMatriculados As List(Of Curso)

    Public Sub New(carnetEstudiante As Integer, codigoCarrera As String)
        Me.CarnetEstudiante = carnetEstudiante
        Me.CodigoCarrera = codigoCarrera
        CursosMatriculados = New List(Of Curso)()
    End Sub

    Public Sub AgregarCurso(curso As Curso)
        CursosMatriculados.Add(curso)
    End Sub
End Class
