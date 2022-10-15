Imports System.Threading

Public Class SingleTimer

    Public beeping As Boolean
    Dim AlarmNote As Integer = 50

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        StartButton.Enabled = False
        ClearButton.Enabled = False
        StopButton.Enabled = False
        StartButton.BackColor = Color.White
        ClearButton.BackColor = Color.White
        StopButton.BackColor = Color.White

    End Sub

    Public Property Title As String
        Get
            Return RadioButton.Text
        End Get
        Set(value As String)
            RadioButton.Text = value
        End Set
    End Property

    Public Property Alarm As Integer
        Get
            Return AlarmNote
        End Get
        Set(value As Integer)
            AlarmNote = value
        End Set
    End Property


    Public Sub addSeconds(extraSecs As Integer)
        ClearButton.Enabled = True
        StartButton.Enabled = True
        SecondsCounter.increaseBy(extraSecs, MinutesCounter)
        SecondsCounter.Text = SecondsCounter.value.ToString("00")
        MinutesCounter.Text = MinutesCounter.value.ToString("00")
    End Sub

    Public Sub addMinutes(extraMins As Integer)
        ClearButton.Enabled = True
        StartButton.Enabled = True
        MinutesCounter.increaseBy(extraMins, SecondsCounter)
        MinutesCounter.Text = MinutesCounter.value.ToString("00")
        SecondsCounter.Text = SecondsCounter.value.ToString("00")
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Timer.Start()
        ClearButton.Enabled = True
        StopButton.Enabled = True
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        Timer.Stop()
        ClearButton.Enabled = True

        If beeping = True Then
            ColorChangeDefault()
            beeping = False
        End If

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        MinutesCounter.value = 0
        SecondsCounter.value = 0
        MinutesCounter.Text = MinutesCounter.value.ToString("00")
        SecondsCounter.Text = SecondsCounter.value.ToString("00")
        Timer.Stop()
        StartButton.Enabled = False
        ColorChangeDefault()

    End Sub

    Private Sub DeselectChildElements(sender As Object, e As EventArgs) Handles RadioButton.Click
        Me.OnClick(e.Empty)
    End Sub

    Public Sub selectTimer()
        RadioButton.Checked = True
    End Sub

    Public Sub deselectTimer()
        RadioButton.Checked = False
    End Sub

    Public Function createThread()
        Dim thread As Thread = New Thread(New ThreadStart(AddressOf Beep))
        Return thread
    End Function

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        If (MinutesCounter.value = 0 And SecondsCounter.value = 0) Then
            ColorChangeRed()
            Timer.Stop()
            createThread().Start()
            StartButton.Enabled = False
            ClearButton.Enabled = False
        Else
            beeping = False
            StartButton.Enabled = True
            SecondsCounter.decrement(MinutesCounter)
            SecondsCounter.Text = SecondsCounter.value.ToString("00")
            MinutesCounter.Text = MinutesCounter.value.ToString("00")
        End If

    End Sub

    Public Sub ColorChangeRed()
        Me.BackColor = Color.Red
    End Sub

    Public Sub ColorChangeDefault()
        Me.BackColor = Color.WhiteSmoke
    End Sub

    Public Sub Beep()
        ColorChangeRed()
        beeping = True

        While beeping = True
            System.Console.Beep(AlarmNote, 400)
        End While

    End Sub

    Private Sub enableChanged(sender As Object, e As EventArgs) _
        Handles ClearButton.EnabledChanged, StartButton.EnabledChanged, ClearButton.EnabledChanged

        Dim currentButton As Button = sender

        If currentButton.Enabled = True Then
            currentButton.BackColor = Color.White
            currentButton.ForeColor = Color.Black
        Else
            currentButton.BackColor = Color.LightGray
            currentButton.ForeColor = Color.White
        End If

        If currentButton.Enabled = True And currentButton Is StartButton Then
            currentButton.ForeColor = Color.Green
        End If

        If currentButton.Enabled = True And currentButton Is StopButton Then
            currentButton.ForeColor = Color.Red
        End If

    End Sub

End Class
