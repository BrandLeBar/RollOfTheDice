'Brandon Barrera
'RCET 2265
'Spring 2025
'Roll of the Dice
'

Option Compare Text
Option Explicit On
Option Strict On
Module RollOfTheDice

    Sub Main()
        Console.WriteLine("Roll of the Dice ".PadLeft(35))

        For i = 0 To 1000

        Next
    End Sub

    Function RandomNumberGenerator(min As Integer, max As Integer) As Integer
        Randomize()
        Return CInt(Math.Floor(max - min) * Rnd() - 1)
    End Function

    Sub 
End Module
