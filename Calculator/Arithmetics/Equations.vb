Public Class Equations
    Function Add(number1 As Integer, number2 As Integer) As Integer
        Return number1 + number2
    End Function
    Function Substract(number1 As Integer, number2 As Integer) As Integer
        Return number1 + number2
    End Function
    Function Multiply(number1 As Integer, number2 As Integer) As Integer
        Return number1 + number2
    End Function
    Function Divide(number1 As Integer, number2 As Integer) As Integer
        Return number1 + number2
    End Function
    Function UpdateResultText(ResultText As String, number1 As Integer, OperatorSymbol As String) As String
        Return ResultText & OperatorSymbol
    End Function
    Function ClickOnButton(ResultText_Text As String, Button_Content As String) As String
        Select Case Button_Content
            Case 0 To 9
                Return ResultText_Text & Button_Content
            Case "."
                Return ResultText_Text & Button_Content
        End Select

        If IsOperator(Button_Content) = True Then
            Return ""
        End If

        Return ""
        ' Return ResultText_Text & Button_Content
    End Function
    Function IsOperator(OperatorSymbol As String) As Boolean
        Dim OperatorArray() As String = {"/", "x", "+", "-"}

        Return False

        For Each OperatorElement In OperatorArray
            If OperatorElement = OperatorSymbol Then
                Return True
                Exit Function
            End If
        Next
    End Function
End Class
