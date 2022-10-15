Public MustInherit Class Counter

    Public value As Integer
    Public maxValue As Integer

    Public Function getValue() As Integer
        Return Me.value
    End Function

    Public Function isMax() As Boolean
        If Me.maxValue = Me.value Then Return True Else Return False
    End Function

    Public Function isZero() As Boolean
        If Me.value = 0 Then Return True Else Return False
    End Function

    Public Sub reset()
        Me.value = 0
    End Sub

    Public Sub setToMax()
        Me.value = Me.maxValue
    End Sub

    Public Sub setValue(ByVal newvalue As Integer)
        Me.value = newvalue
    End Sub

End Class
