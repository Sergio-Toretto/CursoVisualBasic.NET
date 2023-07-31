Module Module1

    Sub Main()

        'OPERADORES  ->  Los operadores nos permiten establecer operaciones matematicas, de comparacion
        '                y de condiciones, siendo los mas importantes:
        '                   - Aritmeticos   ( + , -, *, /, MOD, +=, -= )
        '                   - Relacionales  ( >, <, >=, <=, <>, = )
        '                   - Logicos       ( AND, OR, NOT )

        'EXPRESION  ->  Una expresión es la union de valores, variables, funciones, etc... Separadas por OPERADORES

        'EXPRESION CON OPERADOR SUMA
        Dim aritmeticoSuma As Double = 8 + 3

        Console.WriteLine(aritmeticoSuma)

        'EXPRESION CON OPERADOR RESTA
        Dim aritmeticoResta As Double = 8 - 3

        Console.WriteLine(aritmeticoResta)

        'EXPRESION CON OPERADOR MULTIPLICACION
        Dim aritmeticoMultiplicar As Double = 8 * 3

        Console.WriteLine(aritmeticoMultiplicar)

        'EXPRESION CON OPERADOR DIVIDIR
        Dim aritmeticoDividir As Double = 8 / 3

        Console.WriteLine(aritmeticoDividir)

        'EXPRESION CON OPERADOR MOD o RESTO DE LA DIVISION
        Dim aritmeticoMOD As Double = 8 Mod 3

        Console.WriteLine(aritmeticoMOD)

        'EXPRESION CON OPERADOR INCREMENTO
        Dim aritmeticoIncremento As Double = 8
        aritmeticoIncremento += 3

        Console.WriteLine(aritmeticoIncremento)

        'EXPRESION CON OPERADOR DECREMENTO
        Dim aritmeticoDecremento As Double = 8
        aritmeticoDecremento -= 3

        Console.WriteLine(aritmeticoDecremento)

        'EXPRESION CON OPERADOR MAYOR QUE
        Dim condicionMayorQue As Boolean = -14 > 2

        Console.WriteLine(condicionMayorQue)

        'EXPRESION CON OPERADOR MENOR QUE
        Dim condicionMenorQue As Boolean = -14 < 2

        Console.WriteLine(condicionMenorQue)

        'EXPRESION CON OPERADOR MENOR O IGUAL QUE
        Dim condicionMenorIgualQue As Boolean = 2 <= 2

        Console.WriteLine(condicionMenorIgualQue)

        'EXPRESION CON OPERADOR IGUAL QUE
        Dim condicionIgualQue As Boolean = (2 = 2)

        Console.WriteLine(condicionIgualQue)

        'EXPRESION CON OPERADOR MAYOR O IGUAL QUE
        Dim condicionMayorIgualQue As Boolean = 2 >= 2

        Console.WriteLine(condicionMayorIgualQue)

        'EXPRESION CON OPERADOR LOGICO Y (AND)
        Dim condicionY As Boolean = (7 > 4 And 3 > 6)

        Console.WriteLine(condicionY)

        'EXPRESION CON OPERADOR LOGICO O (OR)
        Dim condicionO As Boolean = (7 > 4 Or 3 > 6)

        Console.WriteLine(condicionO)

        'EXPRESION CON OPERADOR LOGICO NEGACION (NOT)
        Dim condicionNot As Boolean = Not (14 > 8)

        Console.WriteLine(condicionNot)

    End Sub

End Module
