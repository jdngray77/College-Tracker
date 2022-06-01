<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Index
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents RadCom As RadioButton
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents WebBrowser2 As WebBrowser

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCriteria = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.RadStart = New System.Windows.Forms.RadioButton()
        Me.RadUn = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DisplayTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNewUnit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCriteriaAdd = New System.Windows.Forms.TextBox()
        Me.btnCriteriaAdd = New System.Windows.Forms.Button()
        Me.SubjectCombo = New System.Windows.Forms.ComboBox()
        Me.UnitSel = New System.Windows.Forms.ComboBox()
        Me.CriteriaCombo = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InitialiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReopenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CinemaModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullscreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lesson = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNoteBox = New System.Windows.Forms.TextBox()
        Me.HistoryDomain = New System.Windows.Forms.ListBox()
        Me.RadCom = New System.Windows.Forms.RadioButton()
        Me.RadTurnIn = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ToggleSuppressWarnings = New MetroFramework.Controls.MetroToggle()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCriteria)
        Me.GroupBox3.Location = New System.Drawing.Point(106, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(289, 102)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Criteria"
        '
        'txtCriteria
        '
        Me.txtCriteria.Location = New System.Drawing.Point(8, 19)
        Me.txtCriteria.Multiline = True
        Me.txtCriteria.Name = "txtCriteria"
        Me.txtCriteria.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCriteria.Size = New System.Drawing.Size(275, 77)
        Me.txtCriteria.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNotes)
        Me.GroupBox2.Location = New System.Drawing.Point(106, 246)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 208)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Notes"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(8, 19)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotes.Size = New System.Drawing.Size(275, 199)
        Me.txtNotes.TabIndex = 1
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(8, 29)
        Me.txtLoc.Multiline = True
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLoc.Size = New System.Drawing.Size(74, 41)
        Me.txtLoc.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.Blue
        Me.btnSave.Location = New System.Drawing.Point(18, 312)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 142)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save the following items:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Criteria" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Criteria Notes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TurnIn Location" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DOES NO" &
        "T SAVE:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lesson notes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lesson Subject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lesson Room" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lesson LO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'RadStart
        '
        Me.RadStart.AutoSize = True
        Me.RadStart.Location = New System.Drawing.Point(18, 163)
        Me.RadStart.Name = "RadStart"
        Me.RadStart.Size = New System.Drawing.Size(59, 17)
        Me.RadStart.TabIndex = 13
        Me.RadStart.Text = "Started"
        Me.RadStart.UseVisualStyleBackColor = True
        '
        'RadUn
        '
        Me.RadUn.AutoSize = True
        Me.RadUn.Checked = True
        Me.RadUn.Location = New System.Drawing.Point(18, 140)
        Me.RadUn.Name = "RadUn"
        Me.RadUn.Size = New System.Drawing.Size(71, 17)
        Me.RadUn.TabIndex = 2
        Me.RadUn.TabStop = True
        Me.RadUn.Text = "Unstarted"
        Me.RadUn.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtLoc)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(88, 79)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TurnIn Location"
        '
        'DisplayTitle
        '
        Me.DisplayTitle.AutoSize = True
        Me.DisplayTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayTitle.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.DisplayTitle.Location = New System.Drawing.Point(15, 119)
        Me.DisplayTitle.Name = "DisplayTitle"
        Me.DisplayTitle.Size = New System.Drawing.Size(28, 18)
        Me.DisplayTitle.TabIndex = 8
        Me.DisplayTitle.Text = "P1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNewUnit)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCriteriaAdd)
        Me.GroupBox1.Controls.Add(Me.btnCriteriaAdd)
        Me.GroupBox1.Controls.Add(Me.SubjectCombo)
        Me.GroupBox1.Controls.Add(Me.UnitSel)
        Me.GroupBox1.Controls.Add(Me.CriteriaCombo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 89)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subject"
        '
        'btnNewUnit
        '
        Me.btnNewUnit.Location = New System.Drawing.Point(169, 59)
        Me.btnNewUnit.Name = "btnNewUnit"
        Me.btnNewUnit.Size = New System.Drawing.Size(87, 21)
        Me.btnNewUnit.TabIndex = 14
        Me.btnNewUnit.Text = "Add new unit"
        Me.btnNewUnit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(392, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 21)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Add Lesson"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(392, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Lesson"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Criteria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Unit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Course"
        '
        'txtCriteriaAdd
        '
        Me.txtCriteriaAdd.Location = New System.Drawing.Point(262, 60)
        Me.txtCriteriaAdd.Name = "txtCriteriaAdd"
        Me.txtCriteriaAdd.Size = New System.Drawing.Size(44, 20)
        Me.txtCriteriaAdd.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtCriteriaAdd, "Name of new criteia")
        '
        'btnCriteriaAdd
        '
        Me.btnCriteriaAdd.Location = New System.Drawing.Point(312, 60)
        Me.btnCriteriaAdd.Name = "btnCriteriaAdd"
        Me.btnCriteriaAdd.Size = New System.Drawing.Size(71, 21)
        Me.btnCriteriaAdd.TabIndex = 5
        Me.btnCriteriaAdd.Text = "Add Criteria"
        Me.ToolTip1.SetToolTip(Me.btnCriteriaAdd, "Create a new study or coursework criteria")
        Me.btnCriteriaAdd.UseVisualStyleBackColor = True
        '
        'SubjectCombo
        '
        Me.SubjectCombo.FormattingEnabled = True
        Me.SubjectCombo.Location = New System.Drawing.Point(6, 32)
        Me.SubjectCombo.Name = "SubjectCombo"
        Me.SubjectCombo.Size = New System.Drawing.Size(121, 21)
        Me.SubjectCombo.TabIndex = 3
        '
        'UnitSel
        '
        Me.UnitSel.FormattingEnabled = True
        Me.UnitSel.Location = New System.Drawing.Point(133, 32)
        Me.UnitSel.Name = "UnitSel"
        Me.UnitSel.Size = New System.Drawing.Size(121, 21)
        Me.UnitSel.TabIndex = 0
        '
        'CriteriaCombo
        '
        Me.CriteriaCombo.FormattingEnabled = True
        Me.CriteriaCombo.Location = New System.Drawing.Point(262, 32)
        Me.CriteriaCombo.Name = "CriteriaCombo"
        Me.CriteriaCombo.Size = New System.Drawing.Size(121, 21)
        Me.CriteriaCombo.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CinemaModeToolStripMenuItem, Me.FullscreenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1369, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoutToolStripMenuItem, Me.AdvancedToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BoutToolStripMenuItem
        '
        Me.BoutToolStripMenuItem.Name = "BoutToolStripMenuItem"
        Me.BoutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.BoutToolStripMenuItem.Text = "About"
        '
        'AdvancedToolStripMenuItem
        '
        Me.AdvancedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InitialiseToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem"
        Me.AdvancedToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AdvancedToolStripMenuItem.Text = "Advanced"
        '
        'InitialiseToolStripMenuItem
        '
        Me.InitialiseToolStripMenuItem.Name = "InitialiseToolStripMenuItem"
        Me.InitialiseToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.InitialiseToolStripMenuItem.Text = "Initialise"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1, Me.ReopenToolStripMenuItem, Me.ShutdownToolStripMenuItem, Me.RestartToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ExitToolStripMenuItem.Text = "Power"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'ReopenToolStripMenuItem
        '
        Me.ReopenToolStripMenuItem.Name = "ReopenToolStripMenuItem"
        Me.ReopenToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ReopenToolStripMenuItem.Text = "Reopen"
        '
        'ShutdownToolStripMenuItem
        '
        Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
        Me.ShutdownToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ShutdownToolStripMenuItem.Text = "Shutdown"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'CinemaModeToolStripMenuItem
        '
        Me.CinemaModeToolStripMenuItem.Name = "CinemaModeToolStripMenuItem"
        Me.CinemaModeToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.CinemaModeToolStripMenuItem.Text = "Cinema Mode"
        '
        'FullscreenToolStripMenuItem
        '
        Me.FullscreenToolStripMenuItem.Name = "FullscreenToolStripMenuItem"
        Me.FullscreenToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.FullscreenToolStripMenuItem.Text = "Fullscreen"
        '
        'Lesson
        '
        Me.Lesson.AutoSize = True
        Me.Lesson.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lesson.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Lesson.Location = New System.Drawing.Point(402, 121)
        Me.Lesson.Name = "Lesson"
        Me.Lesson.Size = New System.Drawing.Size(63, 18)
        Me.Lesson.TabIndex = 17
        Me.Lesson.Text = "Lesson"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(462, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(403, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Subject"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(403, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Room"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(462, 170)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(74, 20)
        Me.TextBox2.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(403, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Tutor"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(462, 196)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(74, 20)
        Me.TextBox3.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(404, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Learning Objective"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(401, 236)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(130, 61)
        Me.TextBox4.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label10.Location = New System.Drawing.Point(401, 300)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 18)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Browser"
        '
        'btnBack
        '
        Me.btnBack.ForeColor = System.Drawing.Color.Blue
        Me.btnBack.Location = New System.Drawing.Point(406, 389)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 21)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "<"
        Me.ToolTip1.SetToolTip(Me.btnBack, "Browser 1 Back")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.ForeColor = System.Drawing.Color.Red
        Me.btnRefresh.Location = New System.Drawing.Point(431, 389)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(25, 21)
        Me.btnRefresh.TabIndex = 25
        Me.btnRefresh.Text = "R"
        Me.ToolTip1.SetToolTip(Me.btnRefresh, "Refresh both browsers")
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Location = New System.Drawing.Point(506, 389)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 21)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = ">"
        Me.ToolTip1.SetToolTip(Me.Button4, "Browser 1 Forward")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.ForeColor = System.Drawing.Color.Blue
        Me.btnBackup.Location = New System.Drawing.Point(481, 389)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(25, 21)
        Me.btnBackup.TabIndex = 27
        Me.btnBackup.Text = "B"
        Me.ToolTip1.SetToolTip(Me.btnBackup, "Backup browser 1 to browser 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use this to put a page aside for viewing whilst " &
        "you carry on researching." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.ForeColor = System.Drawing.Color.Green
        Me.btnHome.Location = New System.Drawing.Point(456, 389)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(25, 21)
        Me.btnHome.TabIndex = 28
        Me.btnHome.Text = "G"
        Me.ToolTip1.SetToolTip(Me.btnHome, "Take browser 1 to Google")
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label12.Location = New System.Drawing.Point(17, 457)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(162, 18)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Lesson Quick Notes"
        '
        'txtNoteBox
        '
        Me.txtNoteBox.Location = New System.Drawing.Point(20, 478)
        Me.txtNoteBox.Multiline = True
        Me.txtNoteBox.Name = "txtNoteBox"
        Me.txtNoteBox.Size = New System.Drawing.Size(515, 365)
        Me.txtNoteBox.TabIndex = 34
        Me.txtNoteBox.Text = "Lessons and notes are not yet functional, but this rich text notepad is. try doub" &
    "le clicking it!"
        '
        'HistoryDomain
        '
        Me.HistoryDomain.FormattingEnabled = True
        Me.HistoryDomain.Location = New System.Drawing.Point(401, 416)
        Me.HistoryDomain.Name = "HistoryDomain"
        Me.HistoryDomain.Size = New System.Drawing.Size(134, 56)
        Me.HistoryDomain.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.HistoryDomain, "Retains URL's visited by browser 1. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click on one to navigate to it." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Browsi" &
        "ng data is never saved.")
        '
        'RadCom
        '
        Me.RadCom.AutoSize = True
        Me.RadCom.Location = New System.Drawing.Point(18, 186)
        Me.RadCom.Name = "RadCom"
        Me.RadCom.Size = New System.Drawing.Size(75, 17)
        Me.RadCom.TabIndex = 37
        Me.RadCom.Text = "Completed"
        Me.RadCom.UseVisualStyleBackColor = True
        '
        'RadTurnIn
        '
        Me.RadTurnIn.AutoSize = True
        Me.RadTurnIn.Location = New System.Drawing.Point(18, 209)
        Me.RadTurnIn.Name = "RadTurnIn"
        Me.RadTurnIn.Size = New System.Drawing.Size(70, 17)
        Me.RadTurnIn.TabIndex = 38
        Me.RadTurnIn.Text = "Turned in"
        Me.RadTurnIn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(125, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 18)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "DID YOU REMEBER TO SAVE?"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(407, 363)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(124, 20)
        Me.TextBox5.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.TextBox5, "Use this to search google. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The search is called as you type, and replaces you" &
        "r current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "page on the primary browser." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It also fucks up the history, so have" &
        " fun with that.")
        '
        'ToggleSuppressWarnings
        '
        Me.ToggleSuppressWarnings.AutoSize = True
        Me.ToggleSuppressWarnings.Location = New System.Drawing.Point(351, 4)
        Me.ToggleSuppressWarnings.Name = "ToggleSuppressWarnings"
        Me.ToggleSuppressWarnings.Size = New System.Drawing.Size(80, 17)
        Me.ToggleSuppressWarnings.TabIndex = 43
        Me.ToggleSuppressWarnings.Text = "Off"
        Me.ToolTip1.SetToolTip(Me.ToggleSuppressWarnings, "This toggle suppresses warnings provided by the web browsers." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Turn off to igno" &
        "re general warnings" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Turn on for websites that require you to accept a certifi" &
        "cate to view")
        Me.ToggleSuppressWarnings.UseStyleColors = True
        Me.ToggleSuppressWarnings.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(407, 347)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Quick search"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(212, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Supress browser warnings:"
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Nothing
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Black
        Me.MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(542, 43)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(250, 250)
        Me.WebBrowser1.TabIndex = 45
        Me.WebBrowser1.Url = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(541, 299)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(250, 250)
        Me.WebBrowser2.TabIndex = 46
        Me.WebBrowser2.Url = New System.Uri("http://www.wikipedia.com", System.UriKind.Absolute)
        '
        'Index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1369, 855)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ToggleSuppressWarnings)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadTurnIn)
        Me.Controls.Add(Me.RadCom)
        Me.Controls.Add(Me.HistoryDomain)
        Me.Controls.Add(Me.txtNoteBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Lesson)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RadStart)
        Me.Controls.Add(Me.DisplayTitle)
        Me.Controls.Add(Me.RadUn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.MaximizeBox = False
        Me.Name = "Index"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coursework Tracker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCriteria As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents RadStart As RadioButton
    Friend WithEvents RadUn As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DisplayTitle As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCriteriaAdd As TextBox
    Friend WithEvents btnCriteriaAdd As Button
    Friend WithEvents SubjectCombo As ComboBox
    Friend WithEvents UnitSel As ComboBox
    Friend WithEvents CriteriaCombo As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InitialiseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lesson As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNoteBox As TextBox
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CinemaModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullscreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnNewUnit As Button
    Friend WithEvents HistoryDomain As ListBox
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReopenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShutdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadTurnIn As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ToggleSuppressWarnings As MetroFramework.Controls.MetroToggle
    Friend WithEvents Label11 As Label
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
End Class
