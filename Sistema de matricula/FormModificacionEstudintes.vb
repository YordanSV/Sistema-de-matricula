Imports System.Reflection.Emit
Imports System.Text.Json
Imports System.Xml

Public Class FormModificacionEstudintes

    Private route As String = "C:\Users\yorda\OneDrive\Documentos\CUC\II Cuatrimestre 2023\Programación II\Sistema de matricula\Datos\Estudiantes.xml"
    Private xmlDoc As New XmlDocument()

    Private Sub FormModificacionEstudintes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xmlDoc.Load(route)
        MostrarDatosEnDataGridView()

    End Sub


    Private Sub MostrarDatosEnDataGridView()
        xmlDoc.Load(route)
        ' Obtener la raíz del documento
        Dim rootEstudiantes As XmlElement = xmlDoc.DocumentElement
        Dim estudiantes As XmlNodeList = rootEstudiantes.SelectNodes("estudiante")

        ' Configurar las columnas del DataGridView
        TablaEstudiantes.Columns.Add("carnet", "Carnet")
        TablaEstudiantes.Columns.Add("identificacion", "Identificacion")
        TablaEstudiantes.Columns.Add("nombreCompleto", "Nombre Completo")
        TablaEstudiantes.Columns.Add("telefono", "Telefono")
        TablaEstudiantes.Columns.Add("correoElectronico", "Correo Electronico")
        TablaEstudiantes.Columns.Add("fechaNacimiento", "Fecha Nacimiento")
        TablaEstudiantes.Columns.Add("direccion", "Direccion")
        TablaEstudiantes.Columns.Add("carrerasMatriculadas", "Carreras Matriculadas")


        ' Agregar filas al DataGridView con los datos del XML

        For Each estudiante As XmlNode In estudiantes
            Dim carnet As String = estudiante.SelectSingleNode("carnet").InnerText
            Dim identificacion As String = estudiante.SelectSingleNode("identificacion").InnerText
            Dim nombreCompleto As String = estudiante.SelectSingleNode("nombreCompleto").InnerText
            Dim telefono As String = estudiante.SelectSingleNode("telefono").InnerText
            Dim correoElectronico As String = estudiante.SelectSingleNode("correoElectronico").InnerText
            Dim fechaNacimiento As String = estudiante.SelectSingleNode("fechaNacimiento").InnerText
            Dim direccion As String = estudiante.SelectSingleNode("direccion").InnerText
            Dim carrerasMatriculadas As String = String.Join(", ", estudiante.SelectNodes("carrerasMatriculadas/CodigoCarrera").Cast(Of XmlNode)().Select(Function(d) d.InnerText))

            TablaEstudiantes.Rows.Add(carnet, identificacion, nombreCompleto, telefono, correoElectronico, fechaNacimiento, direccion, carrerasMatriculadas)
        Next
    End Sub



    Private Sub GuardarCambios()
        xmlDoc.Load(route)
        Dim Node As XmlNode = xmlDoc.SelectSingleNode("/estudiantes")
        Node.RemoveAll() 'reiniciamos el xml

        For Each row As DataGridViewRow In TablaEstudiantes.Rows
            If Not row.IsNewRow Then

                'If carnet = row.Cells("carnet").Value.ToString() Or row.Cells("identificacion").Value = identificacion Then
                Dim carnet As String = row.Cells("carnet").Value.ToString()
                Dim identificacion As String = row.Cells("identificacion").Value.ToString()
                Dim nombreCompleto As String = row.Cells("nombreCompleto").Value.ToString()
                Dim telefono As String = row.Cells("telefono").Value.ToString()
                Dim correoElectronico As String = row.Cells("correoElectronico").Value.ToString()
                Dim fechaNacimiento As String = row.Cells("fechaNacimiento").Value.ToString()
                Dim direccion As String = row.Cells("direccion").Value.ToString()
                Dim carrerasMatriculadas As String = row.Cells("carrerasMatriculadas").Value.ToString()
                Dim nuevoEstudiante As XmlNode = xmlDoc.CreateElement("estudiante")

                Dim codeNode As XmlNode = xmlDoc.CreateElement("carnet")
                codeNode.InnerText = carnet
                nuevoEstudiante.AppendChild(codeNode)
                Dim nameNode As XmlNode = xmlDoc.CreateElement("identificacion")
                nameNode.InnerText = identificacion
                nuevoEstudiante.AppendChild(nameNode)
                Dim nombreCompletoNode As XmlNode = xmlDoc.CreateElement("nombreCompleto")
                nombreCompletoNode.InnerText = nombreCompleto
                nuevoEstudiante.AppendChild(nombreCompletoNode)
                Dim telefonoNode As XmlNode = xmlDoc.CreateElement("telefono")
                telefonoNode.InnerText = telefono
                nuevoEstudiante.AppendChild(telefonoNode)

                Dim correoElectronicoNode As XmlNode = xmlDoc.CreateElement("correoElectronico")
                correoElectronicoNode.InnerText = correoElectronico
                nuevoEstudiante.AppendChild(correoElectronicoNode)

                Dim fechaNacimientoNode As XmlNode = xmlDoc.CreateElement("fechaNacimiento")
                fechaNacimientoNode.InnerText = fechaNacimiento
                nuevoEstudiante.AppendChild(fechaNacimientoNode)

                Dim direccionNode As XmlNode = xmlDoc.CreateElement("direccion")
                direccionNode.InnerText = direccion
                nuevoEstudiante.AppendChild(direccionNode)


                Dim carrerasMatriculadasNode As XmlNode = xmlDoc.CreateElement("carrerasMatriculadas")
                carrerasMatriculadasNode.InnerText = carrerasMatriculadas
                nuevoEstudiante.AppendChild(carrerasMatriculadasNode)


                Node.AppendChild(nuevoEstudiante)
            End If
            ''For Each estudiante As XmlNode In estudiantes

        Next
        xmlDoc.Save(route)

    End Sub

    Private Sub TablaEstudiantes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaEstudiantes.CellContentClick
        GuardarCambios()
        TablaEstudiantes.Rows.Clear() ' Borra todas las filas 
        TablaEstudiantes.Columns.Clear() ' Borra todas las columnas 
        MostrarDatosEnDataGridView() 'La creamos de nuevo actualizada
    End Sub

    Private Sub btnRegistrarCurso_Click(sender As Object, e As EventArgs) Handles btnRegistrarCurso.Click

        Dim carnet As String = txtCarnet.Text
        Dim identificacion As String = txtIdentificacion.Text
        Dim nombreCompleto As String = txtNombreCompleto.Text
        Dim telefono As String = txtTelefono.Text
        Dim correoElectronico As String = txtCorreoElectronico.Text
        Dim fechaNacimiento As String = txtFechaNacimiento.Text
        Dim direccion As String = txtDireccion.Text
        Dim carrerasMatriculadas As String = txtCarreras.Text

        ' Agregar los datos al DataGridView
        Dim newRow As DataGridViewRow = New DataGridViewRow()
        newRow.CreateCells(TablaEstudiantes, carnet, identificacion, nombreCompleto, telefono, correoElectronico, fechaNacimiento, direccion, carrerasMatriculadas)
        TablaEstudiantes.Rows.Add(newRow)

        ' Agregar los datos al archivo XML
        xmlDoc.Load(route)
        Dim Node As XmlNode = xmlDoc.SelectSingleNode("/estudiantes")

        Dim nuevoEstudiante As XmlNode = xmlDoc.CreateElement("estudiante")

        Dim codeNode As XmlNode = xmlDoc.CreateElement("carnet")
        codeNode.InnerText = carnet
        nuevoEstudiante.AppendChild(codeNode)
        Dim nameNode As XmlNode = xmlDoc.CreateElement("identificacion")
        nameNode.InnerText = identificacion
        nuevoEstudiante.AppendChild(nameNode)
        Dim nombreCompletoNode As XmlNode = xmlDoc.CreateElement("nombreCompleto")
        nombreCompletoNode.InnerText = nombreCompleto
        nuevoEstudiante.AppendChild(nombreCompletoNode)
        Dim telefonoNode As XmlNode = xmlDoc.CreateElement("telefono")
        telefonoNode.InnerText = telefono
        nuevoEstudiante.AppendChild(telefonoNode)

        Dim correoElectronicoNode As XmlNode = xmlDoc.CreateElement("correoElectronico")
        correoElectronicoNode.InnerText = correoElectronico
        nuevoEstudiante.AppendChild(correoElectronicoNode)

        Dim fechaNacimientoNode As XmlNode = xmlDoc.CreateElement("fechaNacimiento")
        fechaNacimientoNode.InnerText = fechaNacimiento
        nuevoEstudiante.AppendChild(fechaNacimientoNode)

        Dim direccionNode As XmlNode = xmlDoc.CreateElement("direccion")
        direccionNode.InnerText = direccion
        nuevoEstudiante.AppendChild(direccionNode)

        Dim carrerasMatriculadasNode As XmlNode = xmlDoc.CreateElement("carrerasMatriculadas")
        nuevoEstudiante.AppendChild(carrerasMatriculadasNode)

        Dim carreras As String() = carrerasMatriculadas.Split(","c)

        For Each carrera As String In carreras
            Dim CodigoCarrera As XmlNode = xmlDoc.CreateElement("CodigoCarrera")
            CodigoCarrera.InnerText = carrera.Trim()
            carrerasMatriculadasNode.AppendChild(CodigoCarrera)
        Next
        LimpiarCamposEntrada()

        Node.AppendChild(nuevoEstudiante)
        xmlDoc.Save(route)

    End Sub

    Private Sub LimpiarCamposEntrada()
        txtCarnet.Text = ""
        txtIdentificacion.Text = ""
        txtNombreCompleto.Text = ""
        txtTelefono.Text = ""
        txtCorreoElectronico.Text = ""
        txtFechaNacimiento.Text = ""
        txtDireccion.Text = ""
        txtDireccion.Text = ""
    End Sub

End Class