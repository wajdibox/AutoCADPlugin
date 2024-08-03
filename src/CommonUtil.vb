Namespace AutoCADPlugin.Utilities

    Public Class CommonUtil
        ' A simple function to add two numbers
        Public Function AddNumbers(a As Integer, b As Integer) As Integer
            Return a + b
        End Function

        ' A class with a method to print a message
        Public Class MessagePrinter
            Public Sub PrintMessage()
                Console.WriteLine("Hello, this is a test message from CommonUtil!")
            End Sub
        End Class
    End Class

End Namespace