Imports System.IO
Imports System.Collections.Generic
Imports System.Data
Imports System.Xml
Imports System.Windows.Forms.AxHost

Public Class Carrera
    Public _code As String
    Private _name As String
    Private _active As Boolean
    Private _courses As List(Of Curso)
    Private _degrees As List(Of String) 'Grado


    Public Sub New(code As String, name As String, active As Boolean, courses As List(Of Curso), degrees As List(Of String))
        _code = code
        _name = name
        _active = active
        _courses = courses
        _degrees = degrees
    End Sub

    Public Sub Register(route As String)
        ' Crea un nuevo documento XML
        Dim xmlDoc As New XmlDocument()

        ' Intenta cargar el contenido del archivo XML existente
        Try
            xmlDoc.Load(route)
        Catch ex As Exception
            ' Si el archivo no existe o no se puede cargar, crea un nuevo documento
            Dim declaration As XmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            xmlDoc.AppendChild(declaration)

            Dim rootElement As XmlElement = xmlDoc.CreateElement("carrers")
            xmlDoc.AppendChild(rootElement)
        End Try

        ' Obtiene la referencia al elemento raíz
        Dim root As XmlElement = xmlDoc.DocumentElement

        ' Crea el elemento para la nueva carrera
        Dim carreraElement As XmlElement = xmlDoc.CreateElement("carrer")
        root.AppendChild(carreraElement)

        ' Agrega los elementos de datos de la carrera
        AddXmlElement(xmlDoc, carreraElement, "code", Me._code)
        AddXmlElement(xmlDoc, carreraElement, "name", Me._name)
        AddXmlElement(xmlDoc, carreraElement, "active", Me._active.ToString())

        ' Agrega los grados
        Dim degreesElement As XmlElement = xmlDoc.CreateElement("degrees")
        carreraElement.AppendChild(degreesElement)
        For Each degree As String In Me._degrees
            AddXmlElement(xmlDoc, degreesElement, "degree", degree)
        Next

        ' Agrega los semestres y cursos
        Dim semestersElement As XmlElement = xmlDoc.CreateElement("semesters")
        carreraElement.AppendChild(semestersElement)
        For i As Integer = 1 To 6
            Dim semesterElement As XmlElement = xmlDoc.CreateElement("semester")
            semesterElement.SetAttribute("number", i.ToString())
            semestersElement.AppendChild(semesterElement)

            Dim coursesElement As XmlElement = xmlDoc.CreateElement("courses")
            semesterElement.AppendChild(coursesElement)

            For Each course As Curso In Me._courses
                If course.Semester = i Then
                    Dim courseElement As XmlElement = xmlDoc.CreateElement("course")
                    coursesElement.AppendChild(courseElement)

                    AddXmlElement(xmlDoc, courseElement, "code", course.Code)
                    AddXmlElement(xmlDoc, courseElement, "name", course.Name)
                    AddXmlElement(xmlDoc, courseElement, "amountCredits", course.AmountCredits.ToString())
                    AddXmlElement(xmlDoc, courseElement, "minimumNote", course.MinimumNote.ToString())
                    AddXmlElement(xmlDoc, courseElement, "minimumNumberStudents", course.MinimumNumberStudents.ToString())
                    AddXmlElement(xmlDoc, courseElement, "maxNumberStudents", course.MaxNumberStudents.ToString())

                    Dim courseDegreesElement As XmlElement = xmlDoc.CreateElement("degrees")
                    courseElement.AppendChild(courseDegreesElement)
                    For Each degree As String In course.Degrees
                        AddXmlElement(xmlDoc, courseDegreesElement, "degree", degree)
                    Next

                    AddXmlElement(xmlDoc, courseElement, "state", course.State.ToString())
                    AddXmlElement(xmlDoc, courseElement, "courseCost", course.CourseCost.ToString())
                End If
            Next
        Next

        ' Guarda el documento XML en el archivo
        xmlDoc.Save(route)
    End Sub

    Private Sub AddXmlElement(xmlDoc As XmlDocument, parentElement As XmlElement, elementName As String, elementValue As String)
        Dim element As XmlElement = xmlDoc.CreateElement(elementName)
        element.InnerText = elementValue
        parentElement.AppendChild(element)
    End Sub

    Private Function AddCarreraXML(rout As String)
        Dim iXmlCarrera As New Datos.ArchivosXML
        ' Dim xmlClientes As XmlDocument = iXmlCarrera.AddCarreraXML(rout)

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
