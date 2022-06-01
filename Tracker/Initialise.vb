Public Class Initialise

    Private Sub btnInitialiseStart_Click(sender As Object, e As EventArgs) Handles btnInitialiseStart.Click
        If Not System.IO.Directory.Exists("./Tracker") Then
            System.IO.Directory.CreateDirectory("./Tracker/" & "/AppData/")
        End If
        Try
            Dim UnitCheck As Double = txtUnitsCount.Text
            Dim UnitData = "./Tracker/Appdata/" & txtSubName.Text & "/"

            System.IO.Directory.CreateDirectory("./Tracker/UnitData/" & txtSubName.Text & "/")
            UnitData = "./Tracker/UnitData/" & txtSubName.Text & "/"
            For i = 1 To CDbl(txtUnitsCount.Text) Step 1
                System.IO.Directory.CreateDirectory("./Tracker/UnitData/" & txtSubName.Text & "/Unit " & i)
                System.IO.File.Create("./Tracker/UnitData/" & txtSubName.Text & "/Unit " & i & "/CriteriaList.txt").Dispose()
            Next
            UnitData = "./Tracker/UnitData/" & txtSubName.Text & "/UnitCount.txt"
            System.IO.File.CreateText(UnitData).Dispose()
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(UnitData, False)
            file.WriteLine(txtUnitsCount.Text)
            file.Close()

            System.IO.File.Create("./Tracker/AppData/Initialised.true")
            System.IO.File.Create("./Tracker/AppData/SubjectList.txt").Dispose()
            file = My.Computer.FileSystem.OpenTextFileWriter("./Tracker/AppData/SubjectList.txt", False)
            file.Write(txtSubName)
            file.Close()
            Index.Show()
            Index.initialised(txtSubName.Text)
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Initialise_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class