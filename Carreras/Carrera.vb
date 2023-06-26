Imports System.Collections.Generic
Imports System.Data
Imports System.Xml

Public Class Carrera
    Private _code As String
    Private _name As String
    Private _careers As List(Of Curso)()
    Private _degrees As List(Of String)()




    Private Function AddCarreraXML(rout As String)
        Dim iXmlCarrera = Datos.
    End Function

    Private Function CreateCarreraTable()

        Dim tableCarrera As New DataTable

        Dim column As New DataColumn With {
            .ColumnName = "colCode",
            .Caption = "code",
            .DataType = Type.GetType("System.Int32"),
            .AllowDBNull = False
        }
        tableCarrera.Columns.Add(column)

        column = New DataColumn With {
            .ColumnName = "colName",
            .Caption = "code",
            .DataType = Type.GetType("System.Int32"),
            .AllowDBNull = False
        }


        column = New DataColumn With {
            .ColumnName = "colCareers",
            .Caption = "carrers",
            .DataType = Type.GetType("String"),
            .AllowDBNull = False
        }


        column = New DataColumn With {
        .ColumnName = "colDegrees",
        .Caption = "degrees",
        .DataType = Type.GetType("String"),
        .AllowDBNull = False
        }

    End Function

End Class
