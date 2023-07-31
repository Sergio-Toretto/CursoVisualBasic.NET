Module Module1

    Sub Main()

        'EJEMPLO: Elaborar un programa de consola en Visual Basic.NET, que nos permita realizar una operacion
        '         matematica basica entre dos numeros, estos dos numeros los debe de introducir el usuario
        '         y diciendole al usuario que tipo de operacion matematica desea realizar, siendo:
        '           - 1 -> SUMAR
        '           - 2 -> RESTAR
        '           - 3 -> MULTIPLICAR
        '           - 4 -> DIVIDIR
        '           - 5 -> PORCENTAJE

        Console.Write("Selecciona el tipo de operación que deseas hace: 1 -> SUMAR, 2 -> RESTAR,
        3 -> MULTIPLICAR, 4 -> DIVIDIR, 5 -> PORCENTAJE")
        Dim opcion As Integer = Console.ReadLine()

        Dim num1, num2 As Double

        Select Case opcion
            Case 1  'SUMA

                Console.Write("Teclea el primer numero: ")
                num1 = Console.ReadLine()
                Console.Write("Teclea el segundo numero: ")
                num2 = Console.ReadLine()

                Console.WriteLine("La suma de tus dos numeros es: " & (num1 + num2))

            Case 2  'RESTA

                Console.Write("Teclea el primer numero: ")
                num1 = Console.ReadLine()
                Console.Write("Teclea el segundo numero: ")
                num2 = Console.ReadLine()

                Console.WriteLine("La resta de tus dos numeros es: " & (num1 - num2))

            Case 3  'MULTIPLICAR

                Console.Write("Teclea el primer numero: ")
                num1 = Console.ReadLine()
                Console.Write("Teclea el segundo numero: ")
                num2 = Console.ReadLine()

                Console.WriteLine("La multiplicación de tus dos numeros es: " & (num1 * num2))

            Case 4  'DIVISION

                Console.Write("Teclea el primer numero: ")
                num1 = Console.ReadLine()
                Console.Write("Teclea el segundo numero: ")
                num2 = Console.ReadLine()

                Console.WriteLine("La division de tus dos numeros es: " & (num1 / num2))

            Case 5  'OBTENER PORCENTAJE

                Console.Write("Teclea el primer numero: ")
                num1 = Console.ReadLine()
                Console.Write("Teclea el segundo numero: ")
                num2 = Console.ReadLine()

                Console.WriteLine("La suma de tus dos numeros es: " & ((num1 * num2) / 100))

            Case Else   'CASO EN EL QUE NO SE ESCOJA ALGUNA DE LAS OPCIONES

                Console.WriteLine("La opción seleccionada no es valida, adios")

        End Select


    End Sub

End Module
