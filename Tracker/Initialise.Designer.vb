<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Initialise
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubName = New System.Windows.Forms.TextBox()
        Me.btnInitialiseStart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtUnitsCount = New System.Windows.Forms.NumericUpDown()
        CType(Me.txtUnitsCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of units:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Subject Name:"
        '
        'txtSubName
        '
        Me.txtSubName.Location = New System.Drawing.Point(77, 78)
        Me.txtSubName.Name = "txtSubName"
        Me.txtSubName.Size = New System.Drawing.Size(100, 20)
        Me.txtSubName.TabIndex = 1
        '
        'btnInitialiseStart
        '
        Me.btnInitialiseStart.Location = New System.Drawing.Point(35, 158)
        Me.btnInitialiseStart.Name = "btnInitialiseStart"
        Me.btnInitialiseStart.Size = New System.Drawing.Size(184, 23)
        Me.btnInitialiseStart.TabIndex = 3
        Me.btnInitialiseStart.Text = "Initialise"
        Me.btnInitialiseStart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Welcome to Tracker!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "As produced by Jordan Gray."
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(77, 109)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Auto add units?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtUnitsCount
        '
        Me.txtUnitsCount.Enabled = False
        Me.txtUnitsCount.Location = New System.Drawing.Point(125, 132)
        Me.txtUnitsCount.Name = "txtUnitsCount"
        Me.txtUnitsCount.Size = New System.Drawing.Size(97, 20)
        Me.txtUnitsCount.TabIndex = 7
        '
        'Initialise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 202)
        Me.Controls.Add(Me.txtUnitsCount)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnInitialiseStart)
        Me.Controls.Add(Me.txtSubName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Initialise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Initialise"
        CType(Me.txtUnitsCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSubName As TextBox
    Friend WithEvents btnInitialiseStart As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtUnitsCount As NumericUpDown
End Class
