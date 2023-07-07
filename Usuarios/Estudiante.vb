﻿
Imports System.IO
Imports System.Xml

Public Class Estudiante
    Inherits Usuario
    Public Property NumeroEstudiante As Integer
    Public Property AnioIngreso As Integer
    Public Property ProgramaEstudios As String




    Public Sub Register(route As String)

        Dim stmData As New MemoryStream

        Dim xmlCarrera As New XmlTextWriter(stmData, System.Text.Encoding.UTF8)

        With xmlCarrera
            .Formatting = Formatting.Indented  ' Establecer formato automático

            .WriteStartDocument(True)

            .WriteStartElement("carrers")

            .WriteStartElement("carrer")


            .WriteStartElement("code")
            .WriteString(Me._code)
            .WriteEndElement()


            .WriteStartElement("name")
            .WriteString(Me._name)
            .WriteEndElement()


            .WriteStartElement("active")
            .WriteString(Me._active)
            .WriteEndElement()

            .WriteStartElement("degrees")
            For Each degree As String In Me._degrees
                .WriteStartElement("degree")
                .WriteString(degree)
                .WriteEndElement()
            Next
            .WriteEndElement()


            .WriteStartElement("semesters")
            'Recorremos 6 semestres
            For i As Integer = 1 To 6
                .WriteStartElement("semester")
                'Le agregamos como atributo el numero de semestre
                .WriteAttributeString("number", i.ToString())
                .WriteStartElement("courses")

                For Each course As Curso In Me._courses
                    'Si el curso tiene el semestre correspondiente(i) agregalo si no continue
                    If course.Semester = i Then

                        .WriteStartElement("course")

                        .WriteStartElement("code")
                        .WriteString(course.Code)
                        .WriteEndElement()

                        ' Escribir el atributo "Name"
                        .WriteStartElement("name")
                        .WriteString(course.Name)
                        .WriteEndElement()

                        ' Escribir el atributo "AmountCredits"
                        .WriteStartElement("amountCredits")
                        .WriteString(course.AmountCredits.ToString())
                        .WriteEndElement()

                        ' Escribir el atributo "MinimumNote"
                        .WriteStartElement("minimumNote")
                        .WriteString(course.MinimumNote.ToString())
                        .WriteEndElement()

                        ' Escribir el atributo "MinimumNumberStudents"
                        .WriteStartElement("minimumNumberStudents")
                        .WriteString(course.MinimumNumberStudents.ToString())
                        .WriteEndElement()

                        ' Escribir el atributo "MaxNumberStudents"
                        .WriteStartElement("maxNumberStudents")
                        .WriteString(course.MaxNumberStudents.ToString())
                        .WriteEndElement()

                        ' Escribir el atributo "Degrees"
                        .WriteStartElement("degrees")
                        For Each degree As String In course.Degrees
                            .WriteStartElement("degree")
                            .WriteString(degree)
                            .WriteEndElement()
                        Next
                        .WriteEndElement()

                        ' Escribir el atributo "State"
                        .WriteStartElement("State")
                        .WriteString(course.State.ToString())
                        .WriteEndElement()

                        ' Escribir el atributo "CourseCost"
                        .WriteStartElement("courseCost")
                        .WriteString(course.CourseCost.ToString())
                        .WriteEndElement()

                        .WriteEndElement()
                    Else
                        Continue For
                    End If
                Next
                .WriteEndElement()
                .WriteEndElement()

            Next
            .WriteEndElement()
            .WriteEndElement()
            .WriteEndElement()

            'confirma el xml
            .Flush()

            'Graba en la ruta indicada
            Dim iData As New Datos.ArchivosXML
            iData.Grabar(route, stmData)

            'cerramos el xml
            .Close()
        End With
    End Sub

End Class