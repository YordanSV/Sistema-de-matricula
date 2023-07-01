Imports System.Xml

Public Class FormModificacionCursos
    Private Sub FormModificacionCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LeerDatosXML("C:\Users\Estudiante\source\repos\YordanSV\Sistema-de-matricula\Datos\Carreras.xml", TablaCursos)
        MessageBox.Show("¡Atención!", "Mensaje de atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub



    ' Leer datos de un archivo XML y mostrarlos en un DataGridView
    Sub LeerDatosXML(rutaArchivo As String, dataGridView As DataGridView)
        ' Crear una tabla para almacenar los datos
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("Código")
        dataTable.Columns.Add("Nombre")
        dataTable.Columns.Add("Créditos")
        dataTable.Columns.Add("Nota Mínima")
        dataTable.Columns.Add("Núm. Mín. Estudiantes")
        dataTable.Columns.Add("Núm. Máx. Estudiantes")
        dataTable.Columns.Add("Grados")
        dataTable.Columns.Add("Estado")
        dataTable.Columns.Add("Costo")

        ' Cargar el archivo XML
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(rutaArchivo)

        ' Obtener el nodo de la carrera
        Dim carreraNode As XmlNode = xmlDoc.SelectSingleNode("/Carrers/Carrer")

        ' Recorrer los nodos de los semestres
        Dim semestresNode As XmlNode = carreraNode.SelectSingleNode("semesters")
        For Each semestreNode As XmlNode In semestresNode.SelectNodes("semester")
            ' Obtener el número de semestre
            Dim numeroSemestre As Integer = Integer.Parse(semestreNode.Attributes("number").Value)

            ' Obtener los nodos de los cursos
            Dim cursosNode As XmlNode = semestreNode.SelectSingleNode("courses")
            For Each cursoNode As XmlNode In cursosNode.SelectNodes("course")
                ' Obtener los datos del curso
                MessageBox.Show("¡Atención!", "Mensaje de atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Dim codigo As String = cursoNode.SelectSingleNode("Code").InnerText
                Dim nombre As String = cursoNode.SelectSingleNode("Name").InnerText
                Dim creditos As Integer = Integer.Parse(cursoNode.SelectSingleNode("AmountCredits").InnerText)
                Dim notaMinima As Integer = Integer.Parse(cursoNode.SelectSingleNode("MinimumNote").InnerText)
                Dim numMinEstudiantes As Integer = Integer.Parse(cursoNode.SelectSingleNode("MinimumNumberStudents").InnerText)
                Dim numMaxEstudiantes As Integer = Integer.Parse(cursoNode.SelectSingleNode("MaxNumberStudents").InnerText)

                ' Obtener los grados del curso
                Dim gradosNode As XmlNode = cursoNode.SelectSingleNode("Degrees")
                Dim grados As String = ""
                For Each gradoNode As XmlNode In gradosNode.SelectNodes("Degree")
                    grados += gradoNode.InnerText & ", "
                Next
                grados = grados.TrimEnd(", ")

                Dim estado As Boolean = Boolean.Parse(cursoNode.SelectSingleNode("State").InnerText)
                Dim costo As Decimal = Decimal.Parse(cursoNode.SelectSingleNode("CourseCost").InnerText)

                ' Agregar los datos del curso a la tabla
                dataTable.Rows.Add(codigo, nombre, creditos, notaMinima, numMinEstudiantes, numMaxEstudiantes, grados, estado, costo)
            Next
        Next
        GuardarCambiosXML(rutaArchivo, dataGridView)
        ' Asignar la tabla al DataGridView
        dataGridView.DataSource = dataTable
    End Sub

    ' Guardar los cambios realizados en un DataGridView en un archivo XML
    Sub GuardarCambiosXML(rutaArchivo As String, dataGridView As DataGridView)
        ' Cargar el archivo XML existente
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(rutaArchivo)

        ' Obtener el nodo de la carrera
        Dim carreraNode As XmlNode = xmlDoc.SelectSingleNode("/Carrers/Carrer")

        ' Eliminar los nodos de cursos existentes
        Dim cursosNode As XmlNode = carreraNode.SelectSingleNode("semesters/semester/courses")
        cursosNode.RemoveAll()

        ' Recorrer las filas del DataGridView y agregar los cursos actualizados
        For Each row As DataGridViewRow In dataGridView.Rows
            Dim cursoNode As XmlNode = xmlDoc.CreateElement("course")

            Dim codigoNode As XmlNode = xmlDoc.CreateElement("Code")
            codigoNode.InnerText = row.Cells("Código").Value.ToString()
            cursoNode.AppendChild(codigoNode)

            Dim nombreNode As XmlNode = xmlDoc.CreateElement("Name")
            nombreNode.InnerText = row.Cells("Nombre").Value.ToString()
            cursoNode.AppendChild(nombreNode)

            ' Agregar el resto de los elementos del curso...

            cursosNode.AppendChild(cursoNode)
        Next

        ' Guardar el documento XML actualizado en el archivo
        xmlDoc.Save(rutaArchivo)
    End Sub





    Private Sub TablaCursos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaCursos.CellContentClick

    End Sub
End Class