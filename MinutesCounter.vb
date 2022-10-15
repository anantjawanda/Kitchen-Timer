Public Class MinutesCounter
    Inherits Counter
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        maxValue = 99
        value = 0
    End Sub

    Public Sub decrement()
        If value <> 0 Then
            value = value - 1
        End If
    End Sub

    Public Sub increaseBy(ByVal increment As Integer, secondsRef As SecondsCounter)
        If (value + increment > maxValue) Then
            value = maxValue
            secondsRef.setValue(59)
        Else
            value = value + increment
        End If
    End Sub

End Class
