Imports System

Module Program
    Structure RPS
        Dim Sr As Integer
        Dim Show As String
    End Structure

    Dim Outcomes(3) As RPS

    Function Ai() As String
        Dim Temp As Integer = 0
        Dim generator As New Random
        Temp = generator.Next(0, 3)

        If Temp = Outcomes(1).Sr Then
            Return Outcomes(1).Show
        Else
            If Temp = Outcomes(2).Sr Then
                Return Outcomes(2).Show
            Else
                If Temp = Outcomes(3).Sr Then
                    Return Outcomes(3).Show
                End If
            End If
        End If
        Return "Error in Code"
    End Function
    Sub Main(args As String())
        Dim User_Input As String
        Dim Result As Integer = -1
        Dim Temp As String
        'Rock
        Outcomes(1).Sr = 1
        Outcomes(1).Show = "R"
        'Paper
        Outcomes(2).Sr = 2
        Outcomes(2).Show = "P"
        'Scissor
        Outcomes(3).Sr = 3
        Outcomes(3).Show = "S"

        Console.WriteLine("Rock Paper Scissor !")
        Console.WriteLine("(R/P/S)")

        User_Input = Console.ReadLine
        Temp = Ai()

        While Temp = User_Input
            Console.WriteLine("Draw")
            User_Input = Console.ReadLine
        End While

        If User_Input = "R" Then
            If Temp = "P" Then
                Result = 1
            Else
                Result = -1
            End If
        End If

        If User_Input = "P" Then
            If Temp = "S" Then
                Result = -1
            Else
                Result = 1
            End If
        End If

        If User_Input = "S" Then
            If Temp = "R" Then
                Result = -1
            Else
                Result = 1
            End If
        End If

        Console.WriteLine("Ai Selection was " & Temp)

        If Result = 1 Then
            Console.WriteLine("User Winss")
        Else
            Console.WriteLine("Ai Winss")
        End If
    End Sub
End Module
