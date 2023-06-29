Imports System.Collections.Generic

Public Class Curso
    Private _code As String
    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property

    Private _semester As Integer
    Public Property Semester() As Integer
        Get
            Return _semester
        End Get
        Set(ByVal value As Integer)
            _semester = value
        End Set
    End Property

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _amountCredits As Integer
    Public Property AmountCredits() As Integer
        Get
            Return _amountCredits
        End Get
        Set(ByVal value As Integer)
            _amountCredits = value
        End Set
    End Property

    Private _minimumNote As Integer
    Public Property MinimumNote() As Integer
        Get
            Return _minimumNote
        End Get
        Set(ByVal value As Integer)
            _minimumNote = value
        End Set
    End Property

    Private _minimumNumberStudens As Integer
    Public Property MinimumNumberStudents() As Integer
        Get
            Return _minimumNumberStudens
        End Get
        Set(ByVal value As Integer)
            _minimumNumberStudens = value
        End Set
    End Property

    Private _maxNumberStudents As Integer
    Public Property MaxNumberStudents() As Integer
        Get
            Return _maxNumberStudents
        End Get
        Set(ByVal value As Integer)
            _maxNumberStudents = value
        End Set
    End Property

    Private _degrees As List(Of String)
    Public Property Degrees() As List(Of String)
        Get
            Return _degrees
        End Get
        Set(ByVal value As List(Of String))
            _degrees = value
        End Set
    End Property

    Private _state As String
    Public Property State() As String
        Get
            Return _state
        End Get
        Set(ByVal value As String)
            _state = value
        End Set
    End Property

    Private _courseCost As Integer
    Public Property CourseCost() As Integer
        Get
            Return _courseCost
        End Get
        Set(ByVal value As Integer)
            _courseCost = value
        End Set
    End Property





End Class
