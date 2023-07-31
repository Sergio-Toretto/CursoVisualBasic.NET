Module Module1

    Sub Main()

        'EJEMPLO: Realizar un algoritmo que imprima los primeros 20 terminos de la siguiente serie:
        '         1, 3, 6, 10, 15, 21, 28, ...

        Dim suma As Integer = 1

        'USO DEL BUCLE FOR
        For i = 2 To 20 Step 1

            If i <> 20 Then

                Console.Write(suma & " ,")

            Else

                Console.Write(suma)

            End If

            suma = suma + i

        Next

    End Sub

End Module
