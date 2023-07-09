Imports System.Xml

Public Class Usuario
    Protected _carne As Integer
    Protected _identificacion As String
    Protected _nombreCompleto As String
    Protected _telefono As String
    Protected _correoElectronico As String
    Protected _fechaNacimiento As DateTime
    Protected _direccion As String

    Public Sub New(ByVal carne As Integer, ByVal identificacion As String, ByVal nombreCompleto As String, ByVal telefono As String, ByVal correoElectronico As String, ByVal fechaNacimiento As DateTime, ByVal direccion As String)
        _carne = carne
        _identificacion = identificacion
        _nombreCompleto = nombreCompleto
        _telefono = telefono
        _correoElectronico = correoElectronico
        _fechaNacimiento = fechaNacimiento
        _direccion = direccion
    End Sub

    Public Property Carne As Integer
        Get
            Return _carne
        End Get
        Set(ByVal value As Integer)
            _carne = value
        End Set
    End Property

    Public Property Identificacion As String
        Get
            Return _identificacion
        End Get
        Set(ByVal value As String)
            _identificacion = value
        End Set
    End Property

    Public Property NombreCompleto As String
        Get
            Return _nombreCompleto
        End Get
        Set(ByVal value As String)
            _nombreCompleto = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property CorreoElectronico As String
        Get
            Return _correoElectronico
        End Get
        Set(ByVal value As String)
            _correoElectronico = value
        End Set
    End Property

    Public Property FechaNacimiento As DateTime
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As DateTime)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Public Sub AddXmlElement(xmlDoc As XmlDocument, parentElement As XmlElement, elementName As String, elementValue As String)
        Dim element As XmlElement = xmlDoc.CreateElement(elementName)
        element.InnerText = elementValue
        parentElement.AppendChild(element)
    End Sub
End Class
