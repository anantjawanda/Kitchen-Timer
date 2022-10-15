<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SingleTimer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RadioButton = New System.Windows.Forms.RadioButton()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MinutesCounter = New Kitchen_Stove_Timer.MinutesCounter()
        Me.SecondsCounter = New Kitchen_Stove_Timer.SecondsCounter()
        Me.SuspendLayout()
        '
        'RadioButton
        '
        Me.RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RadioButton.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton.Name = "RadioButton"
        Me.RadioButton.Padding = New System.Windows.Forms.Padding(30, 30, 0, 0)
        Me.RadioButton.Size = New System.Drawing.Size(571, 334)
        Me.RadioButton.TabIndex = 1
        Me.RadioButton.Text = "Timer Name"
        Me.RadioButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RadioButton.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StartButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StartButton.Location = New System.Drawing.Point(40, 255)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(150, 46)
        Me.StartButton.TabIndex = 2
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StopButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StopButton.Location = New System.Drawing.Point(212, 255)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(150, 46)
        Me.StopButton.TabIndex = 3
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.Location = New System.Drawing.Point(387, 255)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(150, 46)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(264, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 65)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = ":"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'MinutesCounter
        '
        Me.MinutesCounter.AutoSize = True
        Me.MinutesCounter.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinutesCounter.Location = New System.Drawing.Point(182, 131)
        Me.MinutesCounter.Name = "MinutesCounter"
        Me.MinutesCounter.Size = New System.Drawing.Size(80, 65)
        Me.MinutesCounter.TabIndex = 6
        Me.MinutesCounter.Text = "00"
        '
        'SecondsCounter
        '
        Me.SecondsCounter.AutoSize = True
        Me.SecondsCounter.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SecondsCounter.Location = New System.Drawing.Point(295, 131)
        Me.SecondsCounter.Name = "SecondsCounter"
        Me.SecondsCounter.Size = New System.Drawing.Size(80, 65)
        Me.SecondsCounter.TabIndex = 7
        Me.SecondsCounter.Text = "00"
        '
        'SingleTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Controls.Add(Me.SecondsCounter)
        Me.Controls.Add(Me.MinutesCounter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.RadioButton)
        Me.Name = "SingleTimer"
        Me.Size = New System.Drawing.Size(577, 340)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButton As RadioButton
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents MinutesCounter As MinutesCounter
    Friend WithEvents SecondsCounter As SecondsCounter
End Class
