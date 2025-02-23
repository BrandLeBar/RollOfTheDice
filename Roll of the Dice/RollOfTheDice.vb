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
        Dim Rolls(12) As Integer

        Console.WriteLine("Roll of the Dice ".PadLeft(53))
        Console.WriteLine(StrDup(88, "_"))

        For i = 1 To 1000
            Rolls(RandomNumberGenerator(1, 12)) += 1
        Next

        Console.WriteLine()

        For i = 2 To UBound(Rolls)
            Console.Write($"{CStr(i),4}   |")
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(88, "_"))
        Console.WriteLine()

        For i = 2 To UBound(Rolls)
            Console.Write($"{CStr(Rolls(i)),4}   |")
        Next

    End Sub

    Function RandomNumberGenerator(min As Integer, max As Integer) As Integer
        Randomize()
        Return CInt(Math.Ceiling((max - min) * Rnd() + min))
    End Function

End Module
