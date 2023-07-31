Module Module1

    Sub Main()

        'EJEMPLO: Respresentar en una matriz los siguientes valores numericos: 25, 13, 84, 6, 22, 39.

        'FORMA 1
        Dim numeros = New Integer(,) {{25, 13, 84}, {6, 22, 39}}

        'FORMA 2 - BUCLES ANIDADOS "FOR"
        Dim numeros2(2, 3) As Integer

        For filas = 0 To 1 Step 1

            For columnas = 0 To 1 Step 1

                Console.Write("Teclea un número para la posicion " & filas & " , " & columnas & " : ")
                numeros2(filas, columnas) = Console.ReadLine()

            Next

        Next

        'FORMA 3
        Dim numeros3(2, 3) As Integer

        numeros3(0, 0) = 25
        numeros3(0, 1) = 13
        numeros3(0, 2) = 84
        numeros3(1, 0) = 6
        numeros3(1, 1) = 22
        numeros3(1, 2) = 39

        For i = 0 To 1 Step 1

            For j = 0 To 1 Step 1

                Console.WriteLine(numeros3(i, j))

            Next

        Next

        For Each num As Integer In numeros3

            Console.WriteLine(num)

        Next

        For i = 0 To numeros3.GetUpperBound(0) - 1 Step 1

            For j = 0 To numeros3.GetUpperBound(1) - 1 Step 1

                Console.WriteLine(numeros3(i, j))

            Next

        Next


    End Sub

End Module
