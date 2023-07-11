Imports System.Xml

Public Class IniciarSesion
    Private route As String = "C:\Users\yorda\OneDrive\Documentos\CUC\II Cuatrimestre 2023\Programación II\Sistema de matricula\Datos\Administradores.xml"
    Private xmlDoc As New XmlDocument()


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim administradorNode As XmlNodeList = xmlDoc.SelectNodes("/administradores/administrador")
        For Each administrador As XmlNode In administradorNode
            If administrador Is Nothing Then
                MessageBox.Show("El administrador no existe intente de nuevo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim carnet As String = administrador.SelectSingleNode("carnet").InnerText
            Dim identificacion As String = administrador.SelectSingleNode("identificacion").InnerText
            Dim nombreCompleto As String = administrador.SelectSingleNode("nombreCompleto").InnerText
            Dim telefono As String = administrador.SelectSingleNode("telefono").InnerText
            Dim correoElectronico As String = administrador.SelectSingleNode("correoElectronico").InnerText
            Dim fechaNacimiento As String = administrador.SelectSingleNode("fechaNacimiento").InnerText
            Dim direccion As String = administrador.SelectSingleNode("direccion").InnerText
            Dim contrasena As String = administrador.SelectSingleNode("contrasena").InnerText
            Dim activo As String = administrador.SelectSingleNode("activo").InnerText

            Dim usuario As Administrador = New Administrador(carnet, identificacion, nombreCompleto, telefono, correoElectronico, fechaNacimiento, direccion, contrasena)
            If Not Boolean.Parse(activo) Then
                MessageBox.Show("El administrador se encuantra inactivo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf txtCarnet.ToString = carnet And txtContrasena.ToString = contrasena Then
                Dim formPrincipal As New Form1()
                formPrincipal.Show()
            End If
        Next
    End Sub
End Class