Module Module1

    'Para instanciar una variable y asignarle un valor  -> VARIABLE AMBITO GLOBAL
    Dim numero As Integer = 12

    Sub Main()

        'Para instancia una variable sin asignarle valor y asignarle valor despues de instanciarla  -> VARIABLE AMBITO LOCAL
        Dim numero1 As Integer

        numero1 = 15

        'Instanciamos una constante (siempre en mayusculas) y asignarle un valor
        Const PULGADA As Double = 2.54

        'La diferencia entre las variables y las constantes, es que las variables pueden ser modificado su valor
        '   mientras que las constantes hay que asignarlas un valor cuando se instancia y no se puede modificar su valor
        '   a lo largo de la ejecucion del codigo

        'Tipos de variables y de datos

        Dim numero2 As Integer = 13                             'NUMERO ENTERO
        Dim pulgadas As Double = 2.5                            'NUMERO DECIMAL
        Dim letra As Char = "a"                                 'CARACTER
        Dim cadena As String = "Esto es una cadena de tecto"    'CADENA DE TEXTO
        Dim condicion As Boolean = True                         'CONDICIONAL VERDADERO O FALSO

        'Las variables pueden tener ambio local o global  ->  Diferencia Local, solo se usan en determinados bloques del codigo
        '   Ya sea en metodos de los objetos, funciones, arrays, bucles, etc... Solo se estancia dentro de los mismo. Mientras
        '   las variables de ambito global se declaran al principio del codigo o fuera de cualquier bloque de codigo y estas
        '   se pueden usar y/o modificar su valor.

    End Sub

    Sub otroMetodo()

        numero = 50

    End Sub

End Module
