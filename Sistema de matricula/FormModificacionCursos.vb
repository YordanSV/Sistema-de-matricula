Imports System.Xml

Public Class FormModificacionCursos
    Private xmlFilePath As String = "C:\Users\Usuario\Source\Repos\YordanSV\Sistema-de-matricula\Datos\Carreras.xml"
    Private xmlDoc As New XmlDocument()

    Private Sub FormModificacionCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar el archivo XML
        xmlDoc.Load(xmlFilePath)

        ' Mostrar los datos en el DataGridView
        MostrarDatosEnDataGridView()
    End Sub

    Private Sub MostrarDatosEnDataGridView()
        Dim cursosNode As XmlNode = xmlDoc.SelectSingleNode("/carrers/carrer/semesters")
        Dim semesters As XmlNodeList = cursosNode.ChildNodes

        ' Configurar las columnas del DataGridView
        TablaCursos.Columns.Add("Semester", "Semestre")
        TablaCursos.Columns.Add("CourseCode", "Código del curso")
        TablaCursos.Columns.Add("CourseName", "Nombre del curso")
        TablaCursos.Columns.Add("Credits", "Créditos")
        TablaCursos.Columns.Add("MinNote", "Nota mínima")
        TablaCursos.Columns.Add("MinStudents", "Estudiantes mínimos")
        TablaCursos.Columns.Add("MaxStudents", "Estudiantes máximos")
        TablaCursos.Columns.Add("Degrees", "Grados")
        TablaCursos.Columns.Add("Active", "Activo")
        TablaCursos.Columns.Add("CourseCost", "Costo del curso")

        ' Agregar filas al DataGridView con los datos del XML
        For Each semester As XmlNode In semesters
            Dim semesterNumber As String = semester.Attributes("number").Value

            For Each course As XmlNode In semester.SelectSingleNode("courses").ChildNodes
                Dim courseCode As String = course.SelectSingleNode("code").InnerText
                Dim courseName As String = course.SelectSingleNode("name").InnerText
                Dim credits As String = course.SelectSingleNode("amountCredits").InnerText
                Dim minNote As String = course.SelectSingleNode("minimumNote").InnerText
                Dim minStudents As String = course.SelectSingleNode("minimumNumberStudents").InnerText
                Dim maxStudents As String = course.SelectSingleNode("maxNumberStudents").InnerText
                Dim degrees As String = String.Join(", ", course.SelectNodes("degrees/degree").Cast(Of XmlNode)().Select(Function(d) d.InnerText))
                Dim active As String = course.SelectSingleNode("State").InnerText
                Dim courseCost As String = course.SelectSingleNode("courseCost").InnerText

                TablaCursos.Rows.Add(semesterNumber, courseCode, courseName, credits, minNote, minStudents, maxStudents, degrees, active, courseCost)
            Next
        Next
    End Sub

    Private Sub GuardarCambios()
        ' Actualizar los datos modificados en el DataGridView al archivo XML
        Dim cursosNode As XmlNode = xmlDoc.SelectSingleNode("/carrers/carrer/semesters")
        Dim semesters As XmlNodeList = cursosNode.ChildNodes

        ' Eliminar los cursos existentes en el XML
        For Each semester As XmlNode In semesters
            semester.SelectSingleNode("courses").RemoveAll()
        Next

        ' Agregar los cursos desde el DataGridView al XML
        For Each row As DataGridViewRow In TablaCursos.Rows
            If Not row.IsNewRow Then
                Dim semesterCellValue As Object = row.Cells("Semester").Value
                Dim semesterNumber As String = If(semesterCellValue IsNot Nothing, semesterCellValue.ToString(), "")
                Dim courseCode As String = row.Cells("CourseCode").Value.ToString()
                Dim courseName As String = row.Cells("CourseName").Value.ToString()
                Dim credits As String = row.Cells("Credits").Value.ToString()
                Dim minNote As String = row.Cells("MinNote").Value.ToString()
                Dim minStudents As String = row.Cells("MinStudents").Value.ToString()
                Dim maxStudents As String = row.Cells("MaxStudents").Value.ToString()
                Dim degrees As String = row.Cells("Degrees").Value.ToString()
                Dim active As String = row.Cells("Active").Value.ToString()
                Dim courseCost As String = row.Cells("CourseCost").Value.ToString()

                Dim semesterNode As XmlNode = semesters.Item(Int32.Parse(semesterNumber) - 1)
                Dim coursesNode As XmlNode = semesterNode.SelectSingleNode("courses")

                Dim newCourse As XmlNode = xmlDoc.CreateElement("course")

                Dim codeNode As XmlNode = xmlDoc.CreateElement("code")
                codeNode.InnerText = courseCode
                newCourse.AppendChild(codeNode)

                Dim nameNode As XmlNode = xmlDoc.CreateElement("name")
                nameNode.InnerText = courseName
                newCourse.AppendChild(nameNode)

                Dim creditsNode As XmlNode = xmlDoc.CreateElement("amountCredits")
                creditsNode.InnerText = credits
                newCourse.AppendChild(creditsNode)

                Dim minNoteNode As XmlNode = xmlDoc.CreateElement("minimumNote")
                minNoteNode.InnerText = minNote
                newCourse.AppendChild(minNoteNode)

                Dim minStudentsNode As XmlNode = xmlDoc.CreateElement("minimumNumberStudents")
                minStudentsNode.InnerText = minStudents
                newCourse.AppendChild(minStudentsNode)

                Dim maxStudentsNode As XmlNode = xmlDoc.CreateElement("maxNumberStudents")
                maxStudentsNode.InnerText = maxStudents
                newCourse.AppendChild(maxStudentsNode)

                Dim degreesNode As XmlNode = xmlDoc.CreateElement("degrees")
                degreesNode.InnerText = degrees
                newCourse.AppendChild(degreesNode)

                Dim activeNode As XmlNode = xmlDoc.CreateElement("State")
                activeNode.InnerText = active
                newCourse.AppendChild(activeNode)

                Dim courseCostNode As XmlNode = xmlDoc.CreateElement("courseCost")
                courseCostNode.InnerText = courseCost
                newCourse.AppendChild(courseCostNode)

                coursesNode.AppendChild(newCourse)
            End If
        Next

        ' Guardar los cambios en el archivo XML
        xmlDoc.Save(xmlFilePath)
    End Sub




    Private Sub TablaCursos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles TablaCursos.CellEndEdit
        ' Llamar al método GuardarCambios cuando se finaliza la edición de una celda en el DataGridView
        GuardarCambios()
    End Sub

    Private Sub btnRegistrarCurso_Click(sender As Object, e As EventArgs) Handles btnRegistrarCurso.Click
        ' Obtener el código de la carrera
        Dim carreraCode As String = txtCarreraCode.Text

        ' Obtener los datos de entrada del usuario
        Dim semester As String = cmbSemester.Text
        Dim courseCode As String = txtCourseCode.Text
        Dim courseName As String = txtCourseName.Text
        Dim credits As String = txtCredits.Text
        Dim minNote As String = txtMinNote.Text
        Dim minStudents As String = txtMinStudents.Text
        Dim maxStudents As String = txtMaxStudents.Text
        Dim degrees As String = txtDegrees.Text
        Dim active As String = cmbActive.Text
        Dim courseCost As String = txtCourseCost.Text

        ' Agregar los datos al DataGridView
        Dim newRow As DataGridViewRow = New DataGridViewRow()
        newRow.CreateCells(TablaCursos, semester, courseCode, courseName, credits, minNote, minStudents, maxStudents, degrees, active, courseCost)
        TablaCursos.Rows.Add(newRow)

        ' Agregar los datos al archivo XML
        Dim carrerasNode As XmlNode = xmlDoc.SelectSingleNode("/carrers")
        Dim carreraNode As XmlNode = carrerasNode.SelectSingleNode($"carrer[code='{carreraCode}']")
        Dim cursosNode As XmlNode = carreraNode.SelectSingleNode("semesters")
        Dim semesterNode As XmlNode = cursosNode.ChildNodes.Item(Int32.Parse(semester) - 1)
        Dim coursesNode As XmlNode = semesterNode.SelectSingleNode("courses")

        Dim newCourse As XmlNode = xmlDoc.CreateElement("course")

        Dim codeNode As XmlNode = xmlDoc.CreateElement("code")
        codeNode.InnerText = courseCode
        newCourse.AppendChild(codeNode)

        Dim nameNode As XmlNode = xmlDoc.CreateElement("name")
        nameNode.InnerText = courseName
        newCourse.AppendChild(nameNode)

        ' Resto del código para agregar los demás elementos...

        coursesNode.AppendChild(newCourse)

        ' Guardar los cambios en el archivo XML
        xmlDoc.Save(xmlFilePath)

        ' Limpiar los campos de entrada
        LimpiarCamposEntrada()
    End Sub

    Private Sub LimpiarCamposEntrada()
        cmbSemester.SelectedIndex = -1
        txtCourseCode.Text = ""
        txtCourseName.Text = ""
        txtCredits.Text = ""
        txtMinNote.Text = ""
        txtMinStudents.Text = ""
        txtMaxStudents.Text = ""
        txtDegrees.Text = ""
        cmbActive.SelectedIndex = -1
        txtCourseCost.Text = ""
    End Sub


End Class
