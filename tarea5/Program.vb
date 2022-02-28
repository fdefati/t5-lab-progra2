Imports System

Module Program
    Sub Main(args As String())
        'Calculo del factorial
        Dim n, a, x As Double
        a = 1
        Console.WriteLine("Ingrese el numero:")
        n = Console.ReadLine()

        For y = 1 To n
            a = a * y
        Next
        Console.WriteLine("El factorial es: " + a.ToString)

        'Multiplo
        For u = 0 To a
            If (u Mod 4) Then
                x = x + 1
            End If
        Next
        Console.WriteLine("Existen " + x.ToString + " numeros multiplos de 4 en " + a.ToString)
    End Sub
End Module
