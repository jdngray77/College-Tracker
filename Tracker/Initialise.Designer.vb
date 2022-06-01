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
        Me.txtUnitsCount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubName = New System.Windows.Forms.TextBox()
        Me.btnInitialiseStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of units"
        '
        'txtUnitsCount
        '
        Me.txtUnitsCount.Location = New System.Drawing.Point(89, 36)
        Me.txtUnitsCount.Name = "txtUnitsCount"
        Me.txtUnitsCount.Size = New System.Drawing.Size(100, 20)
        Me.txtUnitsCount.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Subject Name"
        '
        'txtSubName
        '
        Me.txtSubName.Location = New System.Drawing.Point(89, 13)
        Me.txtSubName.Name = "txtSubName"
        Me.txtSubName.Size = New System.Drawing.Size(100, 20)
        Me.txtSubName.TabIndex = 1
        '
        'btnInitialiseStart
        '
        Me.btnInitialiseStart.Location = New System.Drawing.Point(12, 68)
        Me.btnInitialiseStart.Name = "btnInitialiseStart"
        Me.btnInitialiseStart.Size = New System.Drawing.Size(175, 23)
        Me.btnInitialiseStart.TabIndex = 3
        Me.btnInitialiseStart.Text = "Initialise"
        Me.btnInitialiseStart.UseVisualStyleBackColor = True
        '
        'Initialise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 103)
        Me.Controls.Add(Me.btnInitialiseStart)
        Me.Controls.Add(Me.txtSubName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUnitsCount)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Initialise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Initialise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUnitsCount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSubName As TextBox
    Friend WithEvents btnInitialiseStart As Button
End Class
