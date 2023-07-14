Imports System.Xml
Imports Usuarios

Public Class IniciarSesion
    Private route As String = "C:\Users\yorda\OneDrive\Documentos\CUC\II Cuatrimestre 2023\Programación II\Sistema de matricula\Datos\Administradores.xml"
    Private xmlDoc As New XmlDocument()


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtCarnet.Text = "" Or txtContrasena.Text = "" Then
            MessageBox.Show("Ingrese un valor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        xmlDoc.Load(route)

        ' Obtener la raíz del documento
        Dim rootAdministradores As XmlElement = xmlDoc.DocumentElement
        Dim administradores As XmlNodeList = rootAdministradores.SelectNodes("administrador")



        Dim totalAdministradores As Integer = administradores.Count
        Dim contador As Integer = 0
        For Each administrador As XmlNode In administradores

            Dim carnet As String = administrador.SelectSingleNode("carnet").InnerText
            Dim identificacion As String = administrador.SelectSingleNode("identificacion").InnerText
            Dim nombreCompleto As String = administrador.SelectSingleNode("nombreCompleto").InnerText
            Dim telefono As String = administrador.SelectSingleNode("telefono").InnerText
            Dim correoElectronico As String = administrador.SelectSingleNode("correoElectronico").InnerText
            Dim fechaNacimiento As String = administrador.SelectSingleNode("fechaNacimiento").InnerText
            Dim direccion As String = administrador.SelectSingleNode("direccion").InnerText
            Dim contrasena As String = administrador.SelectSingleNode("contrasena").InnerText
            Dim activo As String = administrador.SelectSingleNode("activo").InnerText

            Dim usuario As Administrador = New Administrador(carnet, identificacion, nombreCompleto, telefono, correoElectronico, fechaNacimiento, direccion, contrasena, activo)


            If txtCarnet.Text = carnet And txtContrasena.Text <> contrasena Then
                MessageBox.Show("Contrasena incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtContrasena.Text = ""
                Return
            ElseIf txtCarnet.Text = carnet And txtContrasena.Text = contrasena Then
                If Not (Boolean.Parse(activo)) Then
                    MessageBox.Show("El administrador se encuentra inactivo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                Dim formPrincipal As New Principal()
                formPrincipal.Show()
                Return
            End If


            contador += 1
            If contador = totalAdministradores Then
                MessageBox.Show("No existe el usuario indicado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCarnet.Text = ""
                txtContrasena.Text = ""
                Return
            End If
        Next

    End Sub

    Private Sub IniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class