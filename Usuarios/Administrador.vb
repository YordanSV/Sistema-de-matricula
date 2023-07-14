Imports System.IO
Imports System.Collections.Generic
Imports System.Data
Imports System.Xml
Imports System.Windows.Forms.AxHost
Imports System.CodeDom.Compiler


Public Class Administrador
    Inherits Usuario

    Private _contrasena As String
    Private _activo As Boolean

    Private route As String = "C:\Users\yorda\OneDrive\Documentos\CUC\II Cuatrimestre 2023\Programación II\Sistema de matricula\Datos\Administradores.xml"
    Private xmlDoc As New XmlDocument()

    Public Sub New(ByVal carne As Integer, ByVal identificacion As String, ByVal nombreCompleto As String, ByVal telefono As String, ByVal correoElectronico As String, ByVal fechaNacimiento As DateTime, ByVal direccion As String, ByVal contrasena As String, activo As Boolean)
        MyBase.New(carne, identificacion, nombreCompleto, telefono, correoElectronico, fechaNacimiento, direccion)
        _contrasena = contrasena
        _activo = activo
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
        ' Crea un nuevo documento XML
        Dim xmlDoc As New XmlDocument()

        Try
            xmlDoc.Load(route)
        Catch ex As Exception
            ' Si el archivo no existe o no se puede cargar, crea un nuevo documento
            Dim declaration As XmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            xmlDoc.AppendChild(declaration)

            Dim rootElement As XmlElement = xmlDoc.CreateElement("administradores")
            xmlDoc.AppendChild(rootElement)
        End Try

        ' Obtiene la referencia al elemento raíz
        Dim root As XmlElement = xmlDoc.DocumentElement

        ' Crea el elemento para el nuevo administrador
        Dim administradorElement As XmlElement = xmlDoc.CreateElement("administrador")
        root.AppendChild(administradorElement)

        AddXmlElement(xmlDoc, administradorElement, "carnet", Me.Carne.ToString())
        AddXmlElement(xmlDoc, administradorElement, "identificacion", Me.Identificacion)
        AddXmlElement(xmlDoc, administradorElement, "nombreCompleto", Me.NombreCompleto)
        AddXmlElement(xmlDoc, administradorElement, "telefono", Me.Telefono)
        AddXmlElement(xmlDoc, administradorElement, "correoElectronico", Me.CorreoElectronico)
        AddXmlElement(xmlDoc, administradorElement, "fechaNacimiento", Me.FechaNacimiento.ToString())
        AddXmlElement(xmlDoc, administradorElement, "direccion", Me.Direccion)
        AddXmlElement(xmlDoc, administradorElement, "contrasena", Me._contrasena)
        AddXmlElement(xmlDoc, administradorElement, "activo", Me._activo)

        ' Guarda el documento XML en el archivo
        xmlDoc.Save(route)
    End Sub


End Class