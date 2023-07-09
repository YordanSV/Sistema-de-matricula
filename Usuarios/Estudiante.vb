Imports System.IO
Imports System.Xml
Imports Carreras.Carrera


Public Class Estudiante
    Inherits Usuario

    Private _carrerasMatriculadas As List(Of Carreras.Carrera)

    Public Sub New(ByVal carne As Integer, ByVal identificacion As String, ByVal nombreCompleto As String, ByVal telefono As String, ByVal correoElectronico As String, ByVal fechaNacimiento As DateTime, ByVal direccion As String, ByVal carrerasMatriculadas As List(Of Carreras.Carrera))
        MyBase.New(carne, identificacion, nombreCompleto, telefono, correoElectronico, fechaNacimiento, direccion)
        _carrerasMatriculadas = carrerasMatriculadas
    End Sub

    Public Property CarrerasMatriculadas As List(Of Carreras.Carrera)
        Get
            Return _carrerasMatriculadas
        End Get
        Set(ByVal value As List(Of Carreras.Carrera))
            _carrerasMatriculadas = value
        End Set
    End Property



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

            Dim rootElement As XmlElement = xmlDoc.CreateElement("estudiantes")
            xmlDoc.AppendChild(rootElement)
        End Try

        ' Obtiene la referencia al elemento raíz
        Dim root As XmlElement = xmlDoc.DocumentElement

        ' Crea el elemento para el nuevo estudiante
        Dim estudianteElement As XmlElement = xmlDoc.CreateElement("estudiante")
        root.AppendChild(estudianteElement)

        ' Agrega los elementos de datos del estudiante
        AddXmlElement(xmlDoc, estudianteElement, "carne", Me.Carne.ToString())
        AddXmlElement(xmlDoc, estudianteElement, "identificacion", Me.Identificacion)
        AddXmlElement(xmlDoc, estudianteElement, "nombreCompleto", Me.NombreCompleto)
        AddXmlElement(xmlDoc, estudianteElement, "telefono", Me.Telefono)
        AddXmlElement(xmlDoc, estudianteElement, "correoElectronico", Me.CorreoElectronico)
        AddXmlElement(xmlDoc, estudianteElement, "fechaNacimiento", Me.FechaNacimiento.ToString())
        AddXmlElement(xmlDoc, estudianteElement, "direccion", Me.Direccion)

        ' Agrega las carreras matriculadas
        Dim carrerasMatriculadasElement As XmlElement = xmlDoc.CreateElement("carrerasMatriculadas")
        estudianteElement.AppendChild(carrerasMatriculadasElement)
        For Each carrera As Carreras.Carrera In Me._carrerasMatriculadas
            AddXmlElement(xmlDoc, carrerasMatriculadasElement, "CodigoCarrera", carrera._code)
        Next

        ' Guarda el documento XML en el archivo
        xmlDoc.Save(route)
    End Sub


End Class
