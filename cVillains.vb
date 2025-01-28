Option Strict On
Option Explicit On
Option Infer Off
Public Class cVillains
    <VBFixedString(4)> Private _IDNumber As Integer
    Private _Name As String
    Private _Loot1 As Integer
    Private _loot2 As Integer
    Private _Caught As Integer
    Private _Category As String
    'created own varible
    Private _NumVillians As Integer
    Private TotalLoot As Integer

    'Constructors
    Public Sub New(ID As Integer, Name As String, loot1 As Integer, loot2 As Integer, caught As Integer)
        _IDNumber = ID
        _Name = Name
        _Loot1 = loot1
        _loot2 = loot2
        _Caught = caught
    End Sub

    'Property methods
    Public Property IDNumber As Integer
        Get
            Return _IDNumber
        End Get
        Set(value As Integer)
            _IDNumber = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Loot1 As Integer
        Get
            Return _Loot1
        End Get
        Set(value As Integer)
            _Loot1 = value
        End Set
    End Property

    Public Property Loot2 As Integer
        Get
            Return _loot2
        End Get
        Set(value As Integer)
            _loot2 = value
        End Set
    End Property

    Public Property Caugth As Integer
        Get
            Return _Caught
        End Get
        Set(value As Integer)
            _Caught = value
        End Set
    End Property

    Public ReadOnly Property Catergory As String
        Get
            Return AssignCategory()
        End Get
    End Property

    Public Property NumVillians As Integer
        Get
            Return _NumVillians
        End Get
        Set(value As Integer)
            _NumVillians = value
        End Set
    End Property


    'Methods
    Public Function dis() As String
        Dim line As String
        line = "Name of Villian: " & _Name & Environment.NewLine &
            "Villain ID: " & _IDNumber & Environment.NewLine &
            "Total Loot: " & TotalLoot & Environment.NewLine &
            "Times Caught: " & _Caught & Environment.NewLine &
            "Catergory: " & Catergory & Environment.NewLine
        Return line
    End Function

    Public Function CalculateVillainry() As Double
        Return TotalLoot / _Caught
    End Function

    Public Function AssignCategory() As String
        If _Caught = 0 Then
            _Category = "A"
        Else
            If _Caught = 1 Or _Caught >= 5 Then
                _Category = "B"
            Else
                If _Caught <= 6 Then
                    _Category = "C"
                End If
            End If
        End If
        Return _Category
    End Function

End Class
