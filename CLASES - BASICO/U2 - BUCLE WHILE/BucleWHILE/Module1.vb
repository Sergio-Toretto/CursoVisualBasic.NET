Module Module1

    Sub Main()

        'EJEMPLO: Crear un programa que lea un número N entero positivo de cualquier número de digitos
        '         se pide calcular la suma de sus digitos y que imprima por pantalla el numero leído y
        '         la suma de sus dígitos.
        '           EXPLICACION  ->  N = 89563 SUMA = 31

        Console.Write("Escribe un número: ")
        Dim numero As Integer = Console.ReadLine()

        Dim sumaNumero As Integer = 0

        'USAMOS EL BUCLE WHILE
        While numero > 0

            sumaNumero = sumaNumero + numero Mod 10

            numero = numero / 10

        End While

        Console.WriteLine("La suma de los numeros es " & sumaNumero)

    End Sub

End Module
