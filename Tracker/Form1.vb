Public Class Index
    Public Sub initialised(Subject)
        Dim StepCount As Double = My.Computer.FileSystem.ReadAllText("./Tracker/UnitData/" & Subject & "/UnitCount.txt")

        System.IO.File.Create("./Tracker/AppData/LastSubject.txt").Dispose()
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("./Tracker/AppData/LastSubject.txt", False)
            file.Write(Subject)
            file.Close()
        Index_Load(Me, EventArgs.Empty)
    End Sub

    Private Sub InitialiseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Initialise.ShowDialog()
    End Sub

    Private Sub Index_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not System.IO.File.Exists("./Tracker/AppData/Initialised.true") Then
            Initialise.ShowDialog()
            Exit Sub
        End If
        Dim subject = My.Computer.FileSystem.ReadAllText("./Tracker/AppData/LastSubject.txt")
        SubjectCombo.Items.Add(subject)
        Dim StepCount As Double = My.Computer.FileSystem.ReadAllText("./Tracker/UnitData/" & subject & "/UnitCount.txt")
        UnitSel.Items.Clear()
        For i = 1 To StepCount Step 1
            UnitSel.Items.Add("Unit " & i)
        Next
        My.Computer.FileSystem.CopyDirectory("./Tracker/UnitData/", "./Tracker/AppData/Backup/" & DateAndTime.DateString & "/", True)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles btnCriteriaAdd.Click
        Dim check As String = System.IO.File.ReadAllText("./Tracker/UnitData/" & SubjectCombo.SelectedItem & "/" & unitCom & "/CriteriaList.txt")
        Dim CriteriaName = txtCriteriaAdd.Text
        If check.Contains(criterianame) Then
            Exit Sub
        End If
        System.IO.Directory.CreateDirectory("./Tracker/UnitData/" & SubjectCombo.SelectedItem & "/" & unitCom & "/" & CriteriaName & "/")
        Dim dir As String = "./Tracker/UnitData/" & SubjectCombo.SelectedItem & "/" & unitCom & "/" & CriteriaName
        System.IO.File.CreateText(dir & "/Name.txt").Dispose()
        System.IO.File.CreateText(dir & "/Notes.txt").Dispose()
        System.IO.File.CreateText(dir & "/Status.txt").Dispose()
        System.IO.File.CreateText(dir & "/Criteria.txt").Dispose()
        System.IO.File.CreateText(dir & "/TurnInLoc.txt").Dispose()
        System.IO.File.CreateText(dir & "/HandInDate.txt").Dispose()
        System.IO.File.CreateText(dir & "/CompletionDate.txt").Dispose()
        Dim file As System.IO.StreamWriter
        CriteriaCombo.Items.Clear()
        file = My.Computer.FileSystem.OpenTextFileWriter("./Tracker/UnitData/" & SubjectCombo.SelectedItem & "/" & unitCom & "/" & "/CriteriaList.txt", True)
        file.WriteLine(CriteriaName)
        file.Close()
        Dim lines() As String = IO.File.ReadAllLines("./Tracker/UnitData/" & SubjectCombo.SelectedItem & "/" & unitCom & "/CriteriaList.txt")
        CriteriaCombo.Items.AddRange(lines)
        Index_Load(Me, EventArgs.Empty)
    End Sub

    Public unitCom
    Private Sub UnitCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitSel.SelectedIndexChanged
        unitCom = UnitSel.Text
        CriteriaCombo.ResetText()

        Try
            Dim lines() As String = IO.File.ReadAllLines("./Tracker/UnitData/" & SubjectCombo.SelectedItem & "/" & unitCom & "/CriteriaList.txt")
            CriteriaCombo.Items.Clear()
            CriteriaCombo.Items.AddRange(lines)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            DisplayTitle.Text = unitCom & " - " & CriteriaCombo.SelectedItem
            Dim dir As String = "./Tracker/UnitData/" & SubjectCombo.SelectedItem & "/" & unitCom & "/" & CriteriaCombo.SelectedItem
            txtNotes.Text = IO.File.ReadAllText(dir & "/Notes.txt")
            txtCriteria.Text = IO.File.ReadAllText(dir & "/Criteria.txt")
            txtLoc.Text = IO.File.ReadAllText(dir & "/TurnInLoc.txt")
            Dim intent As String = IO.File.ReadAllText(dir & "/Status.txt")
            Select Case intent
                Case "1"
                    RadCom.Checked = True
                Case "2"
                    RadStart.Checked = True
                Case "3"
                    RadCom.Checked = True
                Case "4"
                    RadCom.Checked = True
            End Select
            Me.Text = "Tracker - " & CriteriaCombo.SelectedItem
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("./Tracker/UnitData/" & SubjectCombo.SelectedItem & "/" & unitCom & "/" & CriteriaCombo.SelectedItem & "/Notes.txt", False)
        file.Write(txtNotes.Text)
        file.Close()

        file = My.Computer.FileSystem.OpenTextFileWriter("./Tracker/UnitData/" & SubjectCombo.SelectedItem & "/" & unitCom & "/" & CriteriaCombo.SelectedItem & "/TurnInLoc.txt", False)
        file.Write(txtLoc.Text)
        file.Close()

        file = My.Computer.FileSystem.OpenTextFileWriter("./Tracker/UnitData/" & SubjectCombo.SelectedItem & "/" & unitCom & "/" & CriteriaCombo.SelectedItem & "/Criteria.txt", False)
        file.Write(txtCriteria.Text)
        file.Close()
        Dim stat
        If RadCom.Checked Then
            stat = 1
        ElseIf RadStart.Checked Then
            stat = 2
        ElseIf RadCom.Checked Then
            stat = 3
        ElseIf RadCom.Checked Then
            stat = 4
        End If
        file = My.Computer.FileSystem.OpenTextFileWriter("./Tracker/UnitData/" & SubjectCombo.SelectedItem & "/" & unitCom & "/" & CriteriaCombo.SelectedItem & "/Status.txt", False)
        file.Write(stat)
        file.Close()
    End Sub

    Private Sub InitialiseToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles InitialiseToolStripMenuItem.Click
        Me.Hide()
        Initialise.Show()
    End Sub
End Class
