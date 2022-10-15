Public Class SecondsCounter
    Inherits Counter

    Public SecondsRemainder As Integer
    Dim currentMinutes As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        maxValue = 59
        value = 0
    End Sub

    Public Sub decrement(minutesRef As MinutesCounter)
        If (minutesRef.value > 0 And value = 0) Then
            currentMinutes = minutesRef.getValue()
            minutesRef.setValue(currentMinutes - 1)
            value = maxValue
        Else
            value = value - 1
        End If
    End Sub

    Public Sub increaseBy(ByVal increment As Integer, minutesRef As MinutesCounter)
        If minutesRef.value = 99 Then
            value = value
        ElseIf (value + increment > maxValue) Then
            SecondsRemainder = (value + increment) - 60
            value = SecondsRemainder
            currentMinutes = minutesRef.getValue()
            minutesRef.setValue(currentMinutes + 1)
        Else
            value = value + increment
        End If
    End Sub


End Class
