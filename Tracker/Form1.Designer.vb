<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Index
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim RadTurnIn As System.Windows.Forms.RadioButton
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InitialiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DisplayTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCriteriaAdd = New System.Windows.Forms.TextBox()
        Me.btnCriteriaAdd = New System.Windows.Forms.Button()
        Me.SubjectCombo = New System.Windows.Forms.ComboBox()
        Me.UnitSel = New System.Windows.Forms.ComboBox()
        Me.CriteriaCombo = New System.Windows.Forms.ComboBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.RadCom = New System.Windows.Forms.RadioButton()
        Me.RadStart = New System.Windows.Forms.RadioButton()
        Me.RadUn = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCriteria = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        RadTurnIn = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadTurnIn
        '
        RadTurnIn.AutoSize = True
        RadTurnIn.Location = New System.Drawing.Point(9, 212)
        RadTurnIn.Name = "RadTurnIn"
        RadTurnIn.Size = New System.Drawing.Size(71, 17)
        RadTurnIn.TabIndex = 15
        RadTurnIn.TabStop = True
        RadTurnIn.Text = "Turned In"
        RadTurnIn.UseVisualStyleBackColor = True
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'InitialiseToolStripMenuItem
        '
        Me.InitialiseToolStripMenuItem.Name = "InitialiseToolStripMenuItem"
        Me.InitialiseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InitialiseToolStripMenuItem.Text = "Initialise"
        '
        'AdvancedToolStripMenuItem
        '
        Me.AdvancedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InitialiseToolStripMenuItem})
        Me.AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem"
        Me.AdvancedToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdvancedToolStripMenuItem.Text = "Advanced"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoutToolStripMenuItem, Me.AdvancedToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BoutToolStripMenuItem
        '
        Me.BoutToolStripMenuItem.Name = "BoutToolStripMenuItem"
        Me.BoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BoutToolStripMenuItem.Text = "About"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(397, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DisplayTitle
        '
        Me.DisplayTitle.AutoSize = True
        Me.DisplayTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayTitle.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.DisplayTitle.Location = New System.Drawing.Point(6, 122)
        Me.DisplayTitle.Name = "DisplayTitle"
        Me.DisplayTitle.Size = New System.Drawing.Size(28, 18)
        Me.DisplayTitle.TabIndex = 8
        Me.DisplayTitle.Text = "P1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLoad)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCriteriaAdd)
        Me.GroupBox1.Controls.Add(Me.btnCriteriaAdd)
        Me.GroupBox1.Controls.Add(Me.SubjectCombo)
        Me.GroupBox1.Controls.Add(Me.UnitSel)
        Me.GroupBox1.Controls.Add(Me.CriteriaCombo)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 89)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subject"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(262, 59)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(121, 21)
        Me.btnLoad.TabIndex = 10
        Me.btnLoad.Text = "Load Selected"
        Me.btnLoad.UseVisualStyleBackColor = True
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
        Me.txtCriteriaAdd.Location = New System.Drawing.Point(6, 60)
        Me.txtCriteriaAdd.Name = "txtCriteriaAdd"
        Me.txtCriteriaAdd.Size = New System.Drawing.Size(121, 20)
        Me.txtCriteriaAdd.TabIndex = 6
        '
        'btnCriteriaAdd
        '
        Me.btnCriteriaAdd.Location = New System.Drawing.Point(133, 59)
        Me.btnCriteriaAdd.Name = "btnCriteriaAdd"
        Me.btnCriteriaAdd.Size = New System.Drawing.Size(121, 21)
        Me.btnCriteriaAdd.TabIndex = 5
        Me.btnCriteriaAdd.Text = "Add Criteria"
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
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(8, 19)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotes.Size = New System.Drawing.Size(275, 199)
        Me.txtNotes.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(RadTurnIn)
        Me.Panel1.Controls.Add(Me.RadCom)
        Me.Panel1.Controls.Add(Me.RadStart)
        Me.Panel1.Controls.Add(Me.RadUn)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.DisplayTitle)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 465)
        Me.Panel1.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(9, 315)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 142)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'RadCom
        '
        Me.RadCom.AutoSize = True
        Me.RadCom.Location = New System.Drawing.Point(9, 189)
        Me.RadCom.Name = "RadCom"
        Me.RadCom.Size = New System.Drawing.Size(75, 17)
        Me.RadCom.TabIndex = 14
        Me.RadCom.TabStop = True
        Me.RadCom.Text = "Completed"
        Me.RadCom.UseVisualStyleBackColor = True
        '
        'RadStart
        '
        Me.RadStart.AutoSize = True
        Me.RadStart.Location = New System.Drawing.Point(9, 166)
        Me.RadStart.Name = "RadStart"
        Me.RadStart.Size = New System.Drawing.Size(59, 17)
        Me.RadStart.TabIndex = 13
        Me.RadStart.TabStop = True
        Me.RadStart.Text = "Started"
        Me.RadStart.UseVisualStyleBackColor = True
        '
        'RadUn
        '
        Me.RadUn.AutoSize = True
        Me.RadUn.Location = New System.Drawing.Point(9, 143)
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
        Me.GroupBox4.Location = New System.Drawing.Point(3, 230)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(88, 79)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TurnIn Location"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCriteria)
        Me.GroupBox3.Location = New System.Drawing.Point(97, 122)
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
        Me.GroupBox2.Location = New System.Drawing.Point(97, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 227)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Notes"
        '
        'Index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 469)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Index"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tracker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InitialiseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DisplayTitle As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCriteriaAdd As TextBox
    Friend WithEvents btnCriteriaAdd As Button
    Friend WithEvents SubjectCombo As ComboBox
    Friend WithEvents UnitSel As ComboBox
    Friend WithEvents CriteriaCombo As ComboBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents RadCom As RadioButton
    Friend WithEvents RadStart As RadioButton
    Friend WithEvents RadUn As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCriteria As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BoutToolStripMenuItem As ToolStripMenuItem
End Class
