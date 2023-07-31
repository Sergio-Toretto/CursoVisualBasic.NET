Module Module1

    Sub Main()

        'Ejemplo 1. Realizar un programa que muestre por consola si un estudiante con el dinero que tiene
        '           ahorrado puede pagar la universidad y estudiar, teniendo en cuenta que el semestre
        '           del programa que estudia tiene un valor de 600 €

        Dim estudia As Boolean = False

        Console.Write("Tecleame tus ahorros: ")

        Dim dineroAhorrado As Double = Console.ReadLine()

        ' CREAMOS LAS SENTENCIAS IF
        If dineroAhorrado >= 600 Then
            estudia = True
        End If

        If estudia = True Then

            Console.WriteLine("El dinero ahorrado te permitira estudiar y pagar la universidad")

        Else

            Console.WriteLine("El dinero ahorra no te permitira estudiar y pagar la universidad")

        End If

        'Ejemplo 2. Elaborar un programa de consola en Visual Basic.NET, que ingresando el valor total
        '           por teclado de una compra, realice un descuento a lo siguiente:
        '               - Si el valor de compra es entre 50€ y 100€ el descuento sera del 5%
        '               - Si el valor de compra es entre 101€ y 150€ el descuento sera del 10%
        '               - Si el valor es mayor a 150€ el descuento sera del 15%
        '       
        '           El programa debe mostrar el total de la compra y por otro lado el total de la compra
        '           con el descuento incluido

        Console.Write("Teclee el valor total de su compra: ")
        Dim valorCompra As Double = Console.ReadLine()
        Dim descuento As Double = 0

        ' CREAMOS LA SENTENCIA IF - IF ELSE - ELSE
        If valorCompra >= 50 And valorCompra <= 100 Then

            'Aplicamos el 5% de descuento
            descuento = valorCompra * 0.05

        ElseIf valorCompra > 100 And valorCompra <= 150 Then

            'Aplicamos el 10% de descuento
            descuento = valorCompra * 0.1

        ElseIf valorCompra > 150 Then

            'Aplicamos el 15% de descuento
            descuento = valorCompra * 0.15

        End If

        Console.WriteLine("La compra total sin descuento es de " & valorCompra & "€")
        Console.WriteLine("La compra total con descuento seria de " & valorCompra - descuento & "€")
        Console.WriteLine("La compra con descuento seria de " & descuento & "€")

    End Sub

End Module
