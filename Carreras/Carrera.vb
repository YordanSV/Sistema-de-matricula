Imports System.IO
Imports System.Collections.Generic
Imports System.Data
Imports System.Xml
Imports System.Windows.Forms.AxHost

Public Class Carrera
    Private _code As String
    Private _name As String
    Private _active As Boolean
    Private _courses As List(Of Curso)
    Private _degrees As List(Of String) 'Grado





    Private Function Register(route As String)
        Dim stmData As New MemoryStream

        Dim xmlCarrera As New XmlTextWriter(stmData, System.Text.Encoding.UTF8)

        With xmlCarrera

            .WriteStartDocument(True)

            .WriteStartElement("Carreras")

            .WriteStartElement("Carrera")


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


            .WriteStartElement("courses")
            'Recorremos 6 semestres
            For i As Integer = 1 To 6
                .WriteStartElement("semestre")
                'Le agregamos como atributo el numero de semestre
                .WriteAttributeString("number", i.ToString())
                For Each course As Curso In Me._courses
                    'Si el curso tiene el semestre correspondiente(i) agregalo si no continue
                    If course.Semester = i Then
                        .WriteStartElement("Code")
                        .WriteString(course.Code)
                        .WriteEndElement()

                        ' Escribir el atributo "Name"
                        .WriteStartElement("Name")
                        .WriteString(course.Name)
                        .WriteEndElement()

                        ' Escribir el atributo "AmountCredits"
                        .WriteStartElement("AmountCredits")
                        .WriteString(course.AmountCredits.ToString())
                        .WriteEndElement()

                        ' Escribir el atributo "MinimumNote"
                        .WriteStartElement("MinimumNote")
                        .WriteString(course.MinimumNote.ToString())
                        .WriteEndElement()

                        ' Escribir el atributo "MinimumNumberStudents"
                        .WriteStartElement("MinimumNumberStudents")
                        .WriteString(course.MinimumNumberStudents.ToString())
                        .WriteEndElement()

                        ' Escribir el atributo "MaxNumberStudents"
                        .WriteStartElement("MaxNumberStudents")
                        .WriteString(course.MaxNumberStudents.ToString())
                        .WriteEndElement()

                        ' Escribir el atributo "Degrees"
                        .WriteStartElement("Degrees")
                        For Each degree As String In course.Degrees
                            .WriteStartElement("Degree")
                            .WriteString(degree)
                            .WriteEndElement()
                        Next
                        .WriteEndElement()

                        ' Escribir el atributo "State"
                        .WriteStartElement("State")
                        .WriteString(course.State.ToString())
                        .WriteEndElement()

                        ' Escribir el atributo "CourseCost"
                        .WriteStartElement("CourseCost")
                        .WriteString(course.CourseCost.ToString())
                        .WriteEndElement()
                    Else
                        Continue For
                    End If
                Next
                .WriteEndElement()
            Next
            .WriteEndElement()

            'confirma el xml
            .Flush()

            'Graba en la ruta indicada
            Dim iData As New Datos.ArchivosXML
            iData.Grabar(route, stmData)

            'cerramos el xml
            .Close()
        End With
    End Function

    Private Function AddCarreraXML(rout As String)
        Dim iXmlCarrera As New Datos.ArchivosXML
        Dim xmlClientes As XmlDocument = iXmlCarrera.AddCarreraXML(rout)

    End Function

    Private Function CreateCarreraTable()

        Dim tableCarrera As New DataTable

        Dim column As New DataColumn With {
            .ColumnName = "colCode",
            .Caption = "code",
            .DataType = Type.GetType("System.Int32"),
            .AllowDBNull = False
        }
        tableCarrera.Columns.Add(column)

        column = New DataColumn With {
            .ColumnName = "colName",
            .Caption = "code",
            .DataType = Type.GetType("System.Int32"),
            .AllowDBNull = False
        }


        column = New DataColumn With {
            .ColumnName = "colCareers",
            .Caption = "carrers",
            .DataType = Type.GetType("String"),
            .AllowDBNull = False
        }


        column = New DataColumn With {
        .ColumnName = "colDegrees",
        .Caption = "degrees",
        .DataType = Type.GetType("String"),
        .AllowDBNull = False
        }

    End Function

End Class
