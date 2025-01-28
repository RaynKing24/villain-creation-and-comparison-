Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
' **************************************************************************************************
' Surname, Initials: Chisinahama MRC
' Student Number: 222074617
' Practical: P2023-09
' **************************************************************************************************
Public Class Form1
    Private Villains() As VillainRec
    Private NumVillains As Integer
    Private FS As FileStream
    Private BW As BinaryWriter
    Private BR As BinaryReader
    Private Const FileName As String = "CUA.ifm"
    Private Const rec_size As Integer = 60
    Private Const num_rec As Integer = 15
    Private blankrec As VillainRec
    Private CUATS() As cCUATeam
    Private NumItem As Integer
    'A creating a villains rec
    Private Structure VillainRec
        Public VillainID As Integer
        <VBFixedString(20)> Public Name As String
        Public loot1 As Integer
        Public loot2 As Integer
        Public Caught As Integer
    End Structure

    Private Function HashRecPostion(key As Integer) As Integer
        Return key Mod 13
    End Function

    Private Sub createblank()
        Dim rec As VillainRec
        rec.VillainID = -1
        rec.Name = " "
        rec.Loot1 = 0
        rec.Loot2 = 0
        rec.Caught = -1
    End Sub

    Private Sub RCT(r As Integer, c As Integer, t As String)
        mygrid.Row = r
        mygrid.Col = c
        mygrid.Text = t
    End Sub

    Private Sub setupgrid()
        mygrid.Rows = num_rec + 1
        mygrid.Cols = 7

        For i As Integer = 1 To NumVillains
            RCT(i, 0, "Villain " & CStr(i))
        Next i

        RCT(0, 1, "Name")
        RCT(0, 2, "Villain ID")
        RCT(0, 3, "Loot 1")
        RCT(0, 4, "loot 2")
        RCT(0, 5, "Caught")
    End Sub

    Private Sub createRAF()
        FS = New FileStream(FileName, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        FS.SetLength(num_rec * rec_size)

        For i As Integer = 0 To num_rec - 1
            FS.Seek(i * rec_size, SeekOrigin.Begin)
            BW.Write(blankrec.VillainID)
            BW.Write(blankrec.Name)
            BW.Write(blankrec.loot1)
            BW.Write(blankrec.loot2)
            BW.Write(blankrec.Caught)
        Next i
        FS.Flush()
        FS.Close()
        FS = Nothing
        BW = Nothing
    End Sub

    'write
    Private Function writerec(rec As VillainRec) As Boolean
        FS = New FileStream(FileName, FileMode.Open, FileAccess.Write)
        BW = New BinaryWriter(FS)

        FS.Seek(HashRecPostion(rec.VillainID) * rec_size, SeekOrigin.Begin)
        BW.Write(blankrec.VillainID)
        BW.Write(blankrec.Name)
        BW.Write(blankrec.loot1)
        BW.Write(blankrec.loot2)
        BW.Write(blankrec.Caught)

        FS.Flush()
        FS.Close()
        FS = Nothing
        BW = Nothing
        Return True
    End Function

    Private Function readrec(key As Integer, musthas As Boolean) As VillainRec
        Dim rec As VillainRec

        FS = New FileStream(FileName, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)

        FS.Seek(HashRecPostion(key) * rec_size, SeekOrigin.Begin)
        rec.VillainID = BR.ReadInt32
        rec.Name = BR.ReadString
        rec.loot1 = BR.ReadInt32
        rec.loot2 = BR.ReadInt32
        rec.loot2 = BR.ReadInt32

        FS.Close()
        FS = Nothing
        BR = Nothing
        Return rec
    End Function

    Private Sub refreshgrid()
        Dim rec As VillainRec
        For i As Integer = 1 To num_rec - 1
            rec = readrec(i, False)
            RCT(i, 2, CStr(rec.VillainID))
            RCT(i, 1, rec.Name)
            RCT(i, 3, CStr(rec.loot1))
            RCT(i, 4, CStr(rec.loot2))
            RCT(i, 5, CStr(rec.Caught))
        Next i
    End Sub

    Private Sub loadmain()
        Dim rec1 As VillainRec
        rec1.VillainID = 6546
        rec1.Name = "AVON"
        rec1.loot1 = 1478
        rec1.loot1 = 9000
        rec1.Caught = 6
        writerec(rec1)

        rec1.VillainID = 1234
        rec1.Name = "A"
        rec1.loot1 = 147
        rec1.loot1 = 900
        rec1.Caught = 60
        writerec(rec1)

        rec1.VillainID = 1478
        rec1.Name = "Death Sipder"
        rec1.loot1 = 10000
        rec1.loot1 = 10000000
        rec1.Caught = 1
        writerec(rec1)

        rec1.VillainID = 6999
        rec1.Name = "Vee"
        rec1.loot1 = 1478
        rec1.loot1 = 9000
        rec1.Caught = 0
        writerec(rec1)

        rec1.VillainID = 2132
        rec1.Name = "Mommy's candy"
        rec1.loot1 = 1500
        rec1.loot1 = 9000
        rec1.Caught = 100
        writerec(rec1)

        rec1.VillainID = 1777
        rec1.Name = "Lost"
        rec1.loot1 = 1478
        rec1.loot1 = 0
        rec1.Caught = 0
        writerec(rec1)

        rec1.VillainID = 5555
        rec1.Name = "Doom"
        rec1.loot1 = 14780
        rec1.loot1 = 90000
        rec1.Caught = 3
        writerec(rec1)

        rec1.VillainID = 6666
        rec1.Name = "Diva"
        rec1.loot1 = 147
        rec1.loot1 = 90
        rec1.Caught = 8
        writerec(rec1)

        rec1.VillainID = 4444
        rec1.Name = "Luke"
        rec1.loot1 = 123456
        rec1.loot1 = 78910
        rec1.Caught = 4
        writerec(rec1)

        rec1.VillainID = 3333
        rec1.Name = "Death Vader"
        rec1.loot1 = 7896
        rec1.loot1 = 9000
        rec1.Caught = 6
        writerec(rec1)

        rec1.VillainID = 3233
        rec1.Name = "Protection"
        rec1.loot1 = 100
        rec1.loot1 = 9000
        rec1.Caught = 2
        writerec(rec1)

        rec1.VillainID = 4343
        rec1.Name = "Killers"
        rec1.loot1 = 147844
        rec1.loot1 = 900010
        rec1.Caught = 6
        writerec(rec1)

        rec1.VillainID = 6123
        rec1.Name = "Goku Black"
        rec1.loot1 = 1000000000
        rec1.loot1 = 1000000000
        rec1.Caught = 0
        writerec(rec1)

        rec1.VillainID = 1986
        rec1.Name = "What Happened"
        rec1.loot1 = 0
        rec1.loot1 = 0
        rec1.Caught = 0
        writerec(rec1)

        rec1.VillainID = 1929
        rec1.Name = "Hero Killer"
        rec1.loot1 = 750000
        rec1.loot1 = 250000
        rec1.Caught = 1
        writerec(rec1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        blankrec.VillainID = -1
        blankrec.Name = " "
        blankrec.loot1 = -1
        blankrec.loot2 = -1
        blankrec.Caught = 0

        setupgrid()
        createRAF()
        loadmain()
        refreshgrid()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim rec As VillainRec

        Dim cuat As cCUATeam = New cCUATeam(NumItem)
        NumItem = CInt(InputBox("Number of villain you want to create"))
        Dim ID As Integer

        For i As Integer = 1 To NumItem
            ID = CInt(InputBox("Enter Villain ID"))
            rec = readrec(ID, True)
            cuat.Villians(1) = New cVillains(rec.VillainID, rec.Name, rec.loot1, rec.loot2, rec.Caught)
        Next i
        NumItem += 1

        ReDim Preserve CUATS(NumItem)
        refreshvillain()
    End Sub

    Private Sub refreshvillain()
        Dim output As String = " "
        For o As Integer = 1 To NumItem
            output &= CUATS(o).Display & Environment.NewLine & Environment.NewLine
        Next o


    End Sub

    Private Sub btnDis_Click(sender As Object, e As EventArgs) Handles btnDis.Click
        Dim ListA As cCUATeam = CUATS(1)
        For i As Integer = 2 To NumItem
            If CUATS(i).PowerValue < ListA.PowerValue Then
                ListA = CUATS(i)
            End If
        Next i

        txtDisplay.Text = ListA.Display
    End Sub

End Class
