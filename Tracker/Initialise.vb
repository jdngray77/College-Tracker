Public Class Initialise

    Private Sub btnInitialiseStart_Click(sender As Object, e As EventArgs) Handles btnInitialiseStart.Click
        If txtSubName.Text = "" Then
            Return
        End If

        If Not System.IO.Directory.Exists("./Tracker") Then
            System.IO.Directory.CreateDirectory("./Tracker/")
        End If
        If Not System.IO.Directory.Exists("./Tracker/AppData") Then
            System.IO.Directory.CreateDirectory("./Tracker/AppData")
        End If
        If Not System.IO.Directory.Exists("./Tracker/UnitData") Then
            System.IO.Directory.CreateDirectory("./Tracker/UnitData")
        End If
        Dim UnitCheck As Double = txtUnitsCount.Value
        Dim UnitData = "./Tracker/Appdata/" & txtSubName.Text & "/"
        Dim file As System.IO.StreamWriter

        Try
            System.IO.Directory.CreateDirectory("./Tracker/UnitData/" & txtSubName.Text & "/")
            UnitData = "./Tracker/UnitData/" & txtSubName.Text & "/"
            For i = 1 To CDbl(txtUnitsCount.Value) Step 1
                System.IO.Directory.CreateDirectory("./Tracker/UnitData/" & txtSubName.Text & "/Unit " & i)
                System.IO.File.Create("./Tracker/UnitData/" & txtSubName.Text & "/Unit " & i & "/CriteriaList.txt").Dispose()
            Next
            UnitData = "./Tracker/UnitData/" & txtSubName.Text & "/UnitCount.txt"
            System.IO.File.CreateText(UnitData).Dispose()

            file = My.Computer.FileSystem.OpenTextFileWriter(UnitData, False)
            file.WriteLine(txtUnitsCount.Value)
            file.Close()

            System.IO.File.Create("./Tracker/AppData/Initialised.true")
            System.IO.File.Create("./Tracker/AppData/SubjectList.txt").Dispose()
            file = My.Computer.FileSystem.OpenTextFileWriter("./Tracker/AppData/SubjectList.txt", False)
            file.Write(txtSubName.Text)
            file.Close()
            Me.Hide()
            Index.Show()
            Index.initialised(txtSubName.Text)
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Initialise_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtUnitsCount.Enabled = True
        Else
            txtUnitsCount.Enabled = False
        End If
    End Sub
End Class