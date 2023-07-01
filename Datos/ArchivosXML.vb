Imports System.Data
Imports System.IO
Imports System.Xml




Public Class ArchivosXML



    'xmlData es la informacion del xml que se desea escribir
    Public Sub Grabar(ByVal route As String, xmlData As MemoryStream)
        Dim fileXML As FileStream = New FileStream(route, FileMode.Create, FileAccess.Write)
        xmlData.WriteTo(fileXML)
        fileXML.Close()
        xmlData.Close()

    End Sub

    Public Function read(ByVal route As String) As XmlDocument
        Dim xmlArchivo As New XmlDocument
        xmlArchivo.Load(route)

        Return xmlArchivo
    End Function


End Class
