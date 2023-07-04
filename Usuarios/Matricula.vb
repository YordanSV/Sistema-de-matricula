Imports System.IO
Imports System.Security.Cryptography.Xml
Imports System.Xml


Public Class Matricula
    Public Property CodigoMatricula As String
    Public Property NombreEstudiante As String
    Public Property FechaMatriculacion As Date
    Public Property Asignaturas As List(Of String)

    Public Sub AgregarAsignatura(asignatura As String)
        Asignaturas.Add(asignatura)
    End Sub

    Public Sub EliminarAsignatura(asignatura As String)
        Asignaturas.Remove(asignatura)
    End Sub

    Public Function CalcularTotalCreditos() As Integer
        Dim totalCreditos As Integer = 0
        ' Lógica para calcular el total de créditos de las asignaturas matriculadas '
        Return totalCreditos
    End Function

    Public Sub Register(route As String)
        Dim stmData As New MemoryStream()
        Dim xmlMatricula As New XmlTextWriter(stmData, System.Text.Encoding.UTF8)

        With xmlMatricula
            .Formatting = Formatting.Indented  ' Establecer formato automático

            .WriteStartDocument(True)

            .WriteStartElement("Matricula")

            .WriteStartElement("CodigoMatricula")
            .WriteString(Me.CodigoMatricula)
            .WriteEndElement()

            .WriteStartElement("NombreEstudiante")
            .WriteString(Me.NombreEstudiante)
            .WriteEndElement()

            .WriteStartElement("FechaMatriculacion")
            .WriteString(Me.FechaMatriculacion.ToString("yyyy-MM-dd"))
            .WriteEndElement()

            .WriteStartElement("Asignaturas")
            For Each asignatura As Asignatura In Me.Asignaturas
                .WriteStartElement("Asignatura")

                .WriteStartElement("Codigo")
                .WriteString(asignatura.Codigo)
                .WriteEndElement()

                .WriteStartElement("Nombre")
                .WriteString(asignatura.Nombre)
                .WriteEndElement()

                .WriteEndElement()
            Next
            .WriteEndElement()

            .WriteEndElement()

            ' Confirma el XML
            .Flush()

            ' Graba en la ruta indicada
            Dim iData As New Datos.ArchivosXML
            iData.Grabar(route, stmData)

            ' Cierra el XML
            .Close()
        End With
    End Sub


End Class
