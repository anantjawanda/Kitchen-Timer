Public Class Center

    Dim secondsButtonValue As String
    Dim minutesButtonValue As String
    Dim SelectedTimer As New SingleTimer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        SingleTimer1.selectTimer()
        SelectedTimer = SingleTimer1
        SelectedTimer.BackColor = Color.LightGray

    End Sub

    Private Sub Seconds_Click(sender As Object, e As EventArgs) _
        Handles Sec1.Click, Sec3.Click, Sec10.Click

        'declare the sender'
        Dim currentButton As Button = sender
        secondsButtonValue = currentButton.Tag
        SelectedTimer.addSeconds(CInt(secondsButtonValue))

    End Sub

    Private Sub Minutes_Click(sender As Object, e As EventArgs) _
        Handles Min1.Click, Min3.Click, Min10.Click

        'declare the sender'
        Dim currentButton As Button = sender
        minutesButtonValue = currentButton.Tag
        SelectedTimer.addMinutes(CInt(minutesButtonValue))

    End Sub

    Private Sub SingleTimer_Click(sender As SingleTimer, e As EventArgs) _
       Handles SingleTimer1.Click, SingleTimer2.Click, SingleTimer3.Click, SingleTimer4.Click


        If sender IsNot SelectedTimer And SelectedTimer.beeping = False Then
            SelectedTimer.BackColor = Color.WhiteSmoke
            SelectedTimer.deselectTimer()
            sender.selectTimer()
            SelectedTimer = sender
            SelectedTimer.BackColor = Color.LightGray
        ElseIf sender IsNot SelectedTimer And SelectedTimer.beeping = True Then
            SelectedTimer.ColorChangeRed()
            sender.BackColor = Color.LightGray
            SelectedTimer.deselectTimer()
            sender.selectTimer()
            SelectedTimer = sender
        ElseIf sender IsNot SelectedTimer And sender.beeping = True Then
            SelectedTimer.deselectTimer()
            sender.selectTimer()
            SelectedTimer = sender
        Else
            SelectedTimer.BackColor = Color.WhiteSmoke
            SelectedTimer.deselectTimer()
            sender.selectTimer()
            SelectedTimer = sender
            SelectedTimer.BackColor = Color.LightGray
        End If

    End Sub

End Class
