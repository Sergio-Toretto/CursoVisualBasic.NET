Module Module1

    Sub Main()

        'EJEMPLO DE USO DE BUCLES FOR ANIDADOS
        For i = 1 To 2 Step 1

            Console.WriteLine("Ejecutando el primer bucle FOR")

            For j = 1 To 3 Step 1

                Console.WriteLine("Ejecutando el segundo bucle FOR")

            Next

        Next

        'POR NORMA GENERAL, LOS BUCLES ANIDADOS SE USAN SOLAMENTE PARA LOS BUCLES FOR, SE PUEDEN UTILIZAR PARA EL
        '   RESTO DE BUCLES, PERO NO ES LO NORMAL, LO NORMAL ES QUE SI NECESITAMOS ANIDAR BUCLES, USAREMOS BUCLES
        '   DE TIPO "FOR"

    End Sub

End Module
