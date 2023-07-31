Module Module1

    Sub Main()

        'Entrada de datos, mediante la instanciacion de una variable y asignando un valor
        Dim miNombre As String = "Guillermo"

        Console.WriteLine(miNombre)

        'Entrada de datos, mediante la instanciacion de una variable y pidiendole al usuario
        '   que ingrese el valor por consola
        Dim miNombre2 As String = Console.ReadLine()

        Console.WriteLine(miNombre2)

        'EJEMPLO, pedirle al usuario que ingrese su nombre usando la consola
        Dim miNombre3 As String

        Console.Write("Escribe su nombre: ")
        miNombre3 = Console.ReadLine()

        Console.WriteLine("Mi nombre es " & miNombre3)

    End Sub

End Module
