Module Module1

    Sub Main()

        'EJEMPLO: Imprima por pantalla los valores de los siguientes nombres: María, Guillermo, Sergio, Juan, Daniela, Camila

        'ARRAY
        Dim nombres(6) As String

        nombres(0) = "María"
        nombres(1) = "Guillermo"
        nombres(2) = "Sergio"
        nombres(3) = "Juan"
        nombres(4) = "Daniela"
        nombres(5) = "Camila"

        'USAMOS EL BUCLE FOR EACH

        For Each nombre As String In nombres

            Console.WriteLine(nombre)

        Next

        'ACLARACION, NORMALMENTE EL BUCLE FOR EACH, SE USA PARA ARRAYS, AUNQUE TAMBIEN SE PUEDE USAR LOS DEMAS BUCLES
        '   PERO ES MAS EFICIENTE USAR ESTE TIPO DE BUCLE PARA LOS ARRAYS

    End Sub

End Module
