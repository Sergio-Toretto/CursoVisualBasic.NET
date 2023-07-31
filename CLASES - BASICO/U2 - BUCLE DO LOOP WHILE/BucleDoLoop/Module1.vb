Module Module1

    Sub Main()

        'EJEMPLO USANDO EL BUCLE DO LOOP UNTIL

        Dim numero As Integer

        Do

            Console.Write("Teclea un número: ")
            numero = Console.ReadLine()

            Console.WriteLine("Ejecutando bucle do loop until")

        Loop Until numero <> 0

        'EJEMPLO USANDO EL BUCLE DO LOOP WHILE

        Do

            Console.Write("Teclea un número: ")
            numero = Console.ReadLine()

            Console.WriteLine("Ejecutando bucle do loop until")

        Loop While numero <> 0

        'Diferencias entre un bucle do loop y otro, con until, examina si la variable es distinta de 0, al escribir
        '   cualquier numero distinto de 0, dara true y ejecutara el codigo saliendose del bucle, sin volver a ejecutarlo
        '   mientras que con while, hasta que no se escribe la condicion, que en este caso seria 0, ahi es cuando
        '   el bucle ejecutara todas sus instrucciones sin volver a repetirse.

    End Sub

End Module
