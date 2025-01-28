Option Strict On
Option Explicit On
Option Infer Off

Public Class cCUATeam
    Private _TeamID As Integer
    Private _PowerValue As Integer
    Public _Villains() As cVillains
    Private _TeamMembers As Integer
    'created you
    Private _NumTeams As Integer

    'constructor
    Public Sub New(NumVillains As Integer)
        ReDim _Villains(NumVillains)
    End Sub

    Public Property TeamID As Integer
        Get
            Return _TeamID
        End Get
        Set(value As Integer)
            _TeamID = value
        End Set
    End Property

    Public Property Villians(index As Integer) As cVillains
        Get
            Return _Villains(index)
        End Get
        Set(value As cVillains)
            For i As Integer = 1 To index
                _Villains(i) = value
            Next i
        End Set
    End Property

    Public ReadOnly Property PowerValue As Integer
        Get
            Dim counter As String = "A"
            For i As Integer = 1 To _Villains.Length - 1
                counter = _Villains(i).AssignCategory
                If counter = "A" Then
                    _PowerValue += 1
                End If
            Next i
            Return _PowerValue
        End Get
    End Property

    Public Property NumTeams As Integer
        Get
            Return _NumTeams
        End Get
        Set(value As Integer)
            _NumTeams = value
        End Set
    End Property

    Public ReadOnly Property TeamMembers As Integer
        Get
            _TeamMembers = CInt(_Villains(1).NumVillians / NumTeams)
            Return _TeamMembers
        End Get
    End Property

    Public Function Display() As String
        Dim line As String
        For i As Integer = 1 To _Villains.Length - 1
            line = _Villains(i).dis
        Next i
        line += "TeamId: " & TeamID & Environment.NewLine
        Return line
    End Function


End Class
