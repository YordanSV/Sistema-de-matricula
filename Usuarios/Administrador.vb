Imports System.IO
Imports System.Collections.Generic
Imports System.Data
Imports System.Xml
Imports System.Windows.Forms.AxHost


Public Class Administrador
    Inherits Usuario

    Private _contrasena As String

    Public Sub New(ByVal carne As Integer, ByVal identificacion As String, ByVal nombreCompleto As String, ByVal telefono As String, ByVal correoElectronico As String, ByVal fechaNacimiento As DateTime, ByVal direccion As String, ByVal contrasena As String)
        MyBase.New(carne, identificacion, nombreCompleto, telefono, correoElectronico, fechaNacimiento, direccion)
        _contrasena = contrasena
    End Sub

    Public Property Contrasena As String
        Get
            Return _contrasena
        End Get
        Set(ByVal value As String)
            _contrasena = value
        End Set
    End Property

    Public Sub Register(route As String)
        ' Código para registrar el administrador en el archivo XML
        Dim stmData As New MemoryStream()

        Dim xmlAdministrador As New XmlTextWriter(stmData, System.Text.Encoding.UTF8)

        With xmlAdministrador
            .Formatting = Formatting.Indented  ' Establecer formato automático

            .WriteStartDocument(True)

            .WriteStartElement("administradores")

            .WriteStartElement("administrador")

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

            .WriteStartElement("contrasena")
            .WriteString(Me.Contrasena)
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