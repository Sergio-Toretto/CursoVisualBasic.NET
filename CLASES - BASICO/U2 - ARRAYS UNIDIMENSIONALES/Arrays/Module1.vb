Module Module1

    Sub Main()

        'EJEMPLO: Imprima por pantalla los valores de los siguientes nombres: María, Guillermo, Sergio, Juan, Daniela, Camila

        'FORMA 1
        Dim nombres(6) As String

        For i = 0 To nombres.Length - 1 Step 1
            Console.Write("Teclea el nombre que va ha ir en la posicion " & i & ": ")
            nombres(i) = Console.ReadLine()
        Next

        'FORMA 2
        Dim nombres2 = New String() {"María", "Guillermo", "Sergio", "Juan", "Daniela", "Camila"}

        'FORMA 3
        Dim nombres3(6) As String

        nombres3(0) = "María"
        nombres3(1) = "Guillermo"
        nombres3(2) = "Sergio"
        nombres3(3) = "Juan"
        nombres3(4) = "Daniela"
        nombres3(5) = "Camila"

        For j = 0 To nombres3.Length - 1 Step 1
            Console.WriteLine(nombres3(j))
        Next

        'EJEMPLO 2: Ordenar los elementos de un array desordenados
        Dim numeros4 = New Integer() {233, 301, 192, 169, 215}
        Dim menor As Integer = numeros4(0)
        Dim posMenor As Integer = 0

        For i = 0 To numeros4.Length - 1 Step 1

            If numeros4(i) < menor Then

                menor = numeros4(i + 1)
                posMenor = 1

            End If

        Next

        Dim aux As Integer = numeros4(0)
        numeros4(0) = numeros4(posMenor)
        numeros4(posMenor) = aux

        For Each num As Integer In numeros4
            Console.Write(num & " ")
        Next


    End Sub

End Module
