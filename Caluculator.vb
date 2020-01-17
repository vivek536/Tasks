Imports System.IO
Imports System

Class Program
    Public Function add(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a + b
    End Function

    Public Function subract(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a - b
    End Function

    Public Function mul(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a * b
    End Function

    Public Function divide(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a / b
    End Function

    Private Shared Sub Main()
        Console.WriteLine("Enter the number1")
        Dim a As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the operator(+ or - or * or /)")
        Dim op As Char = Char.Parse(Console.ReadLine())
        Console.WriteLine("Enter the number2")
        Dim b As Integer = Convert.ToInt32(Console.ReadLine())
        Dim p As Program = New Program()

        Select Case op
            Case "+"c
                Console.WriteLine(p.add(a, b))
            Case "-"c
                Console.WriteLine(p.subract(a, b))
            Case "*"c
                Console.WriteLine(p.mul(a, b))
            Case "/"c
                Console.WriteLine(p.divide(a, b))
            Case Else
        End Select
    End Sub
End Class
