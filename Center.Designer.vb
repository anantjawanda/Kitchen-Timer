<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Center
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Sec1 = New System.Windows.Forms.Button()
        Me.Sec3 = New System.Windows.Forms.Button()
        Me.Sec10 = New System.Windows.Forms.Button()
        Me.Min10 = New System.Windows.Forms.Button()
        Me.Min3 = New System.Windows.Forms.Button()
        Me.Min1 = New System.Windows.Forms.Button()
        Me.SingleTimer2 = New Kitchen_Stove_Timer.SingleTimer()
        Me.SingleTimer1 = New Kitchen_Stove_Timer.SingleTimer()
        Me.SingleTimer4 = New Kitchen_Stove_Timer.SingleTimer()
        Me.SingleTimer3 = New Kitchen_Stove_Timer.SingleTimer()
        Me.SuspendLayout()
        '
        'Sec1
        '
        Me.Sec1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Sec1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Sec1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sec1.ForeColor = System.Drawing.Color.Black
        Me.Sec1.Location = New System.Drawing.Point(26, 728)
        Me.Sec1.Name = "Sec1"
        Me.Sec1.Size = New System.Drawing.Size(347, 86)
        Me.Sec1.TabIndex = 1
        Me.Sec1.Tag = "1"
        Me.Sec1.Text = "1 Second"
        Me.Sec1.UseVisualStyleBackColor = False
        '
        'Sec3
        '
        Me.Sec3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Sec3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Sec3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sec3.ForeColor = System.Drawing.Color.Black
        Me.Sec3.Location = New System.Drawing.Point(431, 728)
        Me.Sec3.Name = "Sec3"
        Me.Sec3.Size = New System.Drawing.Size(347, 86)
        Me.Sec3.TabIndex = 2
        Me.Sec3.Tag = "3"
        Me.Sec3.Text = "3 Seconds"
        Me.Sec3.UseVisualStyleBackColor = False
        '
        'Sec10
        '
        Me.Sec10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Sec10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Sec10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sec10.ForeColor = System.Drawing.Color.Black
        Me.Sec10.Location = New System.Drawing.Point(836, 728)
        Me.Sec10.Name = "Sec10"
        Me.Sec10.Size = New System.Drawing.Size(347, 86)
        Me.Sec10.TabIndex = 3
        Me.Sec10.Tag = "10"
        Me.Sec10.Text = "10 Seconds"
        Me.Sec10.UseVisualStyleBackColor = False
        '
        'Min10
        '
        Me.Min10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Min10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Min10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Min10.ForeColor = System.Drawing.Color.Black
        Me.Min10.Location = New System.Drawing.Point(836, 845)
        Me.Min10.Name = "Min10"
        Me.Min10.Size = New System.Drawing.Size(347, 86)
        Me.Min10.TabIndex = 6
        Me.Min10.Tag = "10"
        Me.Min10.Text = "10 Minutes"
        Me.Min10.UseVisualStyleBackColor = False
        '
        'Min3
        '
        Me.Min3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Min3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Min3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Min3.ForeColor = System.Drawing.Color.Black
        Me.Min3.Location = New System.Drawing.Point(431, 845)
        Me.Min3.Name = "Min3"
        Me.Min3.Size = New System.Drawing.Size(347, 86)
        Me.Min3.TabIndex = 5
        Me.Min3.Tag = "3"
        Me.Min3.Text = "3 Minutes"
        Me.Min3.UseVisualStyleBackColor = False
        '
        'Min1
        '
        Me.Min1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Min1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Min1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Min1.ForeColor = System.Drawing.Color.Black
        Me.Min1.Location = New System.Drawing.Point(26, 845)
        Me.Min1.Name = "Min1"
        Me.Min1.Size = New System.Drawing.Size(347, 86)
        Me.Min1.TabIndex = 4
        Me.Min1.Tag = "1"
        Me.Min1.Text = "1 Minute"
        Me.Min1.UseVisualStyleBackColor = False
        '
        'SingleTimer2
        '
        Me.SingleTimer2.Alarm = 400
        Me.SingleTimer2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SingleTimer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SingleTimer2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SingleTimer2.Location = New System.Drawing.Point(623, 32)
        Me.SingleTimer2.Name = "SingleTimer2"
        Me.SingleTimer2.Size = New System.Drawing.Size(560, 323)
        Me.SingleTimer2.TabIndex = 8
        Me.SingleTimer2.Title = "Back Right"
        '
        'SingleTimer1
        '
        Me.SingleTimer1.Alarm = 200
        Me.SingleTimer1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SingleTimer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SingleTimer1.Location = New System.Drawing.Point(26, 32)
        Me.SingleTimer1.Name = "SingleTimer1"
        Me.SingleTimer1.Size = New System.Drawing.Size(577, 323)
        Me.SingleTimer1.TabIndex = 7
        Me.SingleTimer1.Title = "Back Left"
        '
        'SingleTimer4
        '
        Me.SingleTimer4.Alarm = 800
        Me.SingleTimer4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SingleTimer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SingleTimer4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SingleTimer4.Location = New System.Drawing.Point(623, 373)
        Me.SingleTimer4.Name = "SingleTimer4"
        Me.SingleTimer4.Size = New System.Drawing.Size(560, 323)
        Me.SingleTimer4.TabIndex = 10
        Me.SingleTimer4.Title = "Front Right"
        '
        'SingleTimer3
        '
        Me.SingleTimer3.Alarm = 600
        Me.SingleTimer3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SingleTimer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SingleTimer3.Location = New System.Drawing.Point(26, 373)
        Me.SingleTimer3.Name = "SingleTimer3"
        Me.SingleTimer3.Size = New System.Drawing.Size(577, 323)
        Me.SingleTimer3.TabIndex = 9
        Me.SingleTimer3.Title = "Front Left"
        '
        'Center
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1208, 958)
        Me.Controls.Add(Me.SingleTimer4)
        Me.Controls.Add(Me.SingleTimer3)
        Me.Controls.Add(Me.SingleTimer2)
        Me.Controls.Add(Me.SingleTimer1)
        Me.Controls.Add(Me.Min10)
        Me.Controls.Add(Me.Min3)
        Me.Controls.Add(Me.Min1)
        Me.Controls.Add(Me.Sec10)
        Me.Controls.Add(Me.Sec3)
        Me.Controls.Add(Me.Sec1)
        Me.Name = "Center"
        Me.Text = "Anant's Kitchen Timer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Sec1 As Button
    Friend WithEvents Sec3 As Button
    Friend WithEvents Sec10 As Button
    Friend WithEvents Min10 As Button
    Friend WithEvents Min3 As Button
    Friend WithEvents Min1 As Button
    Friend WithEvents SingleTimer2 As SingleTimer
    Friend WithEvents SingleTimer1 As SingleTimer
    Friend WithEvents SingleTimer4 As SingleTimer
    Friend WithEvents SingleTimer3 As SingleTimer
End Class
