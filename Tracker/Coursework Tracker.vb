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

    Private Sub UpdateWindowSize() Handles MyBase.Resize
        'Panel1.Size = Me.Size
        txtNoteBox.Height = Me.Height - txtNoteBox.Top - 50
        WebBrowser1.Height = Me.Height / 2 - 20
        WebBrowser1.Width = Me.Width - WebBrowser1.Left
        WebBrowser2.Location = New Point(WebBrowser2.Left, WebBrowser1.Height + 30)
        WebBrowser2.Height = Me.Height / 2 - 50
        WebBrowser2.Width = Me.Width - WebBrowser2.Left
    End Sub

    Private Sub Index_Load(sender As Object, e As EventArgs) Handles Me.Load


        UpdateWindowSize()

        If Not System.IO.File.Exists("./Tracker/AppData/Initialised.true") Then
            Initialise.ShowDialog()
            Exit Sub
        End If
        Dim subjects() As String = IO.File.ReadAllLines("./Tracker/AppData/SubjectList.txt")
        SubjectCombo.Items.AddRange(subjects)
        SubjectCombo.SelectedIndex = SubjectCombo.Items.Count - 1


        Dim StepCount As Double = My.Computer.FileSystem.ReadAllText("./Tracker/UnitData/" & subjects(0) & "/UnitCount.txt")
        UnitSel.Items.Clear()
        For i = 1 To StepCount Step 1
            UnitSel.Items.Add("Unit " & i)
        Next
        My.Computer.FileSystem.CopyDirectory("./Tracker/UnitData/", "./Tracker/AppData/Backup/" & DateAndTime.DateString & "/", True)
        '     UnitSel.SelectedIndex = 0

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Public unitCom
    Private Sub UnitCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitSel.SelectedIndexChanged

        Me.unitCom = Me.UnitSel.Text
        Me.CriteriaCombo.ResetText()
        Try
            Dim array1 As String() = System.IO.File.ReadAllLines("./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/" + Me.unitCom + "/CriteriaList.txt")
            Me.CriteriaCombo.Items.Clear()
            Me.CriteriaCombo.Items.AddRange(array1)

        Catch exception1 As Exception
        End Try
        If (Me.CriteriaCombo.Items.Count >= 1) Then
            Me.CriteriaCombo.SelectedIndex = (Me.CriteriaCombo.Items.Count - 1)
            Me.CriteriaCombo.Enabled = True
            Me.CriteriaCombo.Enabled = True
            Me.txtCriteria.Enabled = True
            Me.txtNotes.Enabled = True
            Me.txtLoc.Enabled = True
        Else
            Me.CriteriaCombo.Text = "No Criteria"
            Me.CriteriaCombo.Enabled = False
            Me.txtCriteria.Enabled = False
            Me.txtNotes.Enabled = False
            Me.txtLoc.Enabled = False
            Me.txtCriteria.Text = ""
            Me.txtNotes.Text = ""
            Me.txtLoc.Text = ""
        End If

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs)
        txtCriteria.Enabled = True
        txtNotes.Enabled = True
        txtLoc.Enabled = True
        Try
            DisplayTitle.Text = unitCom & " - " & CriteriaCombo.SelectedItem
            Dim dir As String = "./Tracker/UnitData/" & SubjectCombo.SelectedItem & "/" & unitCom & "/" & CriteriaCombo.SelectedItem
            txtNotes.Text = IO.File.ReadAllText(dir & "/Notes.txt")
            txtCriteria.Text = IO.File.ReadAllText(dir & "/Criteria.txt")
            txtLoc.Text = IO.File.ReadAllText(dir & "/TurnInLoc.txt")
            Dim intent As String = IO.File.ReadAllText(dir & "/Status.txt")
            Select Case intent
                Case "1"
                    RadUn.Checked = True
                Case "2"
                    RadStart.Checked = True
                Case "3"
                    RadCom.Checked = True
                Case "4"
                    RadTurnIn.Checked = True
            End Select
            Me.Text = "Tracker - " & CriteriaCombo.SelectedItem
        Catch ex As Exception

        End Try

        'stat = 4
        'End If
        'file = My.Computer.FileSystem.OpenTextFileWriter("./Tracker/UnitData/" & SubjectCombo.SelectedItem & "/" & unitCom & "/" & CriteriaCombo.SelectedItem & "/Status.txt", False)
        'file.Write(stat)
        'file.Close()

    End Sub

    Private Sub InitialiseToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles InitialiseToolStripMenuItem.Click
        Me.Hide()
        Initialise.Show()
    End Sub

    Private Sub Course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubjectCombo.SelectedIndexChanged
        UnitSel.SelectedIndex = UnitSel.Items.Count - 1
    End Sub

    Private Sub ResetTrackerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Try
            System.IO.Directory.Delete("./Tracker/AppData", True)
            System.IO.Directory.Delete("./Tracker/UnitData", True)
        Catch ex As Exception

        End Try


        Application.Restart()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        WebBrowser1.Refresh()
        WebBrowser2.Refresh()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        WebBrowser2.Navigate(WebBrowser1.Url)
    End Sub

    Private Sub ResizeEmd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        If Me.Width < 1385 Then
            Me.Width = 1385
        End If

        If Me.Height < 894 Then
            Me.Height = 894
        End If
    End Sub

    Private Sub CinemaModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CinemaModeToolStripMenuItem.Click
        Cinema.open()
    End Sub

    Private Sub NotesDoubleClick(sender As Object, e As EventArgs) Handles txtNoteBox.DoubleClick
        Cinema.open()
    End Sub

    Private Sub FullscreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullscreenToolStripMenuItem.Click
        Me.Size = My.Computer.Screen.Bounds.Size
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub PageNavigated(sender As Object, e As WebBrowserNavigatedEventArgs)
        HistoryDomain.Items.Add(WebBrowser1.URL)
    End Sub

    Private Sub HistoryDomain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HistoryDomain.SelectedIndexChanged

        If Not HistoryDomain.SelectedItem = Nothing Then
            WebBrowser1.Navigate(HistoryDomain.SelectedItem)
        End If
    End Sub

    Private Sub ReopenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReopenToolStripMenuItem.Click
        Application.Restart()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        WebBrowser1.Navigate("www.google.com")
    End Sub

    Private Sub btnNewUnit_Click(sender As Object, e As EventArgs) Handles btnNewUnit.Click
        Dim str1 As String = "./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/UnitCount.txt"
        System.IO.File.CreateText(str1).Dispose()
        System.IO.Directory.CreateDirectory("./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/Unit " + CStr(Me.UnitSel.Items.Count + 1))
        System.IO.File.Create("./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/Unit " + CStr(Me.UnitSel.Items.Count + 1) + "/CriteriaList.txt").Dispose()
        Dim streamwriter1 As System.IO.StreamWriter = Tracker.My.MyProject.Computer.FileSystem.OpenTextFileWriter(str1, False)
        streamwriter1.WriteLine(Me.UnitSel.Items.Count + 1)
        streamwriter1.Close()
        Me.Index_Load(Me, System.EventArgs.Empty)
        Me.UnitSel.SelectedIndex = (Me.UnitSel.Items.Count - 1)
    End Sub


    Private Sub btnCriteriaAdd_Click(sender As Object, e As EventArgs) Handles btnCriteriaAdd.Click
        Try
            Dim str1 As String = System.IO.File.ReadAllText("./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/" + Me.UnitSel.SelectedItem + "/CriteriaList.txt")
            Dim str2 As String = Me.txtCriteriaAdd.Text
            If (Not str1.Contains(str2)) Then
                System.IO.Directory.CreateDirectory("./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/" + Me.UnitSel.SelectedItem + "/" + str2 + "/")
                Dim str3 As String = "./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/" + Me.UnitSel.SelectedItem + "/" + str2
                System.IO.File.CreateText(str3 & "/Name.txt").Dispose()
                System.IO.File.CreateText(str3 & "/Notes.txt").Dispose()
                System.IO.File.CreateText(str3 & "/Status.txt").Dispose()
                System.IO.File.CreateText(str3 & "/Criteria.txt").Dispose()
                System.IO.File.CreateText(str3 & "/TurnInLoc.txt").Dispose()
                System.IO.File.CreateText(str3 & "/HandInDate.txt").Dispose()
                System.IO.File.CreateText(str3 & "/CompletionDate.txt").Dispose()
                Me.CriteriaCombo.Items.Clear()
                Dim streamwriter1 As System.IO.StreamWriter = Tracker.My.MyProject.Computer.FileSystem.OpenTextFileWriter("./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/" + Me.UnitSel.SelectedItem + "/" + "/CriteriaList.txt", True)
                streamwriter1.WriteLine(str2)
                streamwriter1.Close()
                Dim array1 As String() = System.IO.File.ReadAllLines("./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/" + Me.UnitSel.SelectedItem + "/CriteriaList.txt")
                Me.CriteriaCombo.Items.AddRange(array1)
                Dim unittemp As Integer = UnitSel.SelectedIndex
                Me.Index_Load(Me, System.EventArgs.Empty)
                UnitSel.SelectedIndex = unittemp
            End If
        Catch exception1 As Exception

        End Try

        CriteriaCombo.SelectedIndex = CriteriaCombo.Items.Count - 1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim streamwriter1 As System.IO.StreamWriter = Tracker.My.MyProject.Computer.FileSystem.OpenTextFileWriter("./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/" + Me.unitCom + "/" + Me.CriteriaCombo.SelectedItem + "/Notes.txt", False)
        streamwriter1.Write(Me.txtNotes.Text)
        streamwriter1.Close()
        streamwriter1 = Tracker.My.MyProject.Computer.FileSystem.OpenTextFileWriter("./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/" + Me.unitCom + "/" + Me.CriteriaCombo.SelectedItem + "/TurnInLoc.txt", False)
        streamwriter1.Write(Me.txtLoc.Text)
        streamwriter1.Close()
        streamwriter1 = Tracker.My.MyProject.Computer.FileSystem.OpenTextFileWriter("./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/" + Me.unitCom + "/" + Me.CriteriaCombo.SelectedItem + "/Criteria.txt", False)
        streamwriter1.Write(Me.txtCriteria.Text)
        streamwriter1.Close()

        Dim object1 As Integer
        If (Me.RadUn.Checked) Then
            object1 = 1
        ElseIf (Me.RadStart.Checked) Then
            object1 = 2
        ElseIf (Me.Radcom.Checked) Then
            object1 = 3
        ElseIf (Me.RadTurnIn.Checked) Then
            object1 = 4
        End If
        streamwriter1 = Tracker.My.MyProject.Computer.FileSystem.OpenTextFileWriter("./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/" + Me.unitCom + "/" + Me.CriteriaCombo.SelectedItem + "/Status.txt", False)
        streamwriter1.Write(object1)
        streamwriter1.Close()

    End Sub

    Private Sub CriteriaCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CriteriaCombo.SelectedIndexChanged
        Me.txtCriteria.Enabled = True
        Me.txtNotes.Enabled = True
        Me.txtLoc.Enabled = True

        Try
            Me.DisplayTitle.Text = Me.UnitSel.Text + " - " + CriteriaCombo.Text
            Dim str1 As String = "./Tracker/UnitData/" + Me.SubjectCombo.SelectedItem + "/" + Me.unitCom + "/" + Me.CriteriaCombo.SelectedItem
            Me.txtNotes.Text = System.IO.File.ReadAllText(str1 & "/Notes.txt")
            Me.txtCriteria.Text = System.IO.File.ReadAllText(str1 & "/Criteria.txt")
            Me.txtLoc.Text = System.IO.File.ReadAllText(str1 & "/TurnInLoc.txt")
            Dim str2 As String = System.IO.File.ReadAllText(str1 & "/Status.txt")
            If (str2 = "1") Then
                RadUn.Select()
            ElseIf (str2 = "2") Then
                RadStart.Select()
            ElseIf (str2 = "3") Then
                RadCom.Select()
            ElseIf (str2 = "4") Then
                RadTurnIn.Select()
            End If
        Catch exception1 As Exception
        End Try

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        WebBrowser1.Navigate("https://www.google.com/search?q=" + TextBox5.Text)

    End Sub

    Private Sub BoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub ToggleSuppressWarnings_CheckedChanged(sender As Object, e As EventArgs) Handles ToggleSuppressWarnings.CheckedChanged
        WebBrowser1.ScriptErrorsSuppressed = ToggleSuppressWarnings.Checked
        WebBrowser2.ScriptErrorsSuppressed = ToggleSuppressWarnings.Checked
    End Sub
End Class
