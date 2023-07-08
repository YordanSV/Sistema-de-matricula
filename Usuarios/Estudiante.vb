Imports System.IO
Imports System.Xml

Public Class Estudiante
    Inherits Usuario

    Private _carrerasMatriculadas As List(Of String)

    Public Sub New(ByVal carne As Integer, ByVal identificacion As String, ByVal nombreCompleto As String, ByVal telefono As String, ByVal correoElectronico As String, ByVal fechaNacimiento As DateTime, ByVal direccion As String, ByVal carrerasMatriculadas As List(Of String))
        MyBase.New(carne, identificacion, nombreCompleto, telefono, correoElectronico, fechaNacimiento, direccion)
        _carrerasMatriculadas = carrerasMatriculadas
    End Sub

    Public Property CarrerasMatriculadas As List(Of String)
        Get
            Return _carrerasMatriculadas
        End Get
        Set(ByVal value As List(Of String))
            _carrerasMatriculadas = value
        End Set
    End Property


    Public Sub Register(route As String)
        ' Código para registrar el estudiante en el archivo XML
        Dim stmData As New MemoryStream()

        Dim xmlEstudiante As New XmlTextWriter(stmData, System.Text.Encoding.UTF8)

        With xmlEstudiante
            .Formatting = Formatting.Indented  ' Establecer formato automático

            .WriteStartDocument(True)

            .WriteStartElement("estudiantes")

            .WriteStartElement("estudiante")

            .WriteStartElement("carne")
            .WriteString(Me.Carne.ToString())
            .WriteEndElement()

            .WriteStartElement("identificacion")
            .WriteString(Me.Identificacion)
            .WriteEndElement()

            .WriteStartElement("nombreCompleto")
            .WriteString(Me.NombreCompleto)
            .WriteEndElement()

            .WriteStartElement("telefono")
            .WriteString(Me.Telefono)
            .WriteEndElement()

            .WriteStartElement("correoElectronico")
            .WriteString(Me.CorreoElectronico)
            .WriteEndElement()

            .WriteStartElement("fechaNacimiento")
            .WriteString(Me.FechaNacimiento.ToString("yyyy-MM-dd"))
            .WriteEndElement()

            .WriteStartElement("direccion")
            .WriteString(Me.Direccion)
            .WriteEndElement()

            .WriteStartElement("carrerasMatriculadas")
            For Each carrera As String In Me.CarrerasMatriculadas
                .WriteStartElement("carrera")
                .WriteString(carrera)
                .WriteEndElement()
            Next
            .WriteEndElement()

            .WriteEndElement()
            .WriteEndElement()
            .WriteEndElement()

            .Flush()

            ' Graba en la ruta indicada
            Dim iData As New Datos.ArchivosXML
            iData.Grabar(route, stmData)

            .Close()
        End With
    End Sub
End Class
