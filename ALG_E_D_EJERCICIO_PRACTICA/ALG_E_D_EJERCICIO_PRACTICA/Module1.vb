﻿Module Module1

    Sub Main()
        Dim tamanio, a, x As Integer
        Console.Write("INDIQUE EL TAMAÑO DE LA VARIABLE INDEXADA A VERIFICAR ====> ")
        tamanio = Console.ReadLine()

        Dim lista(tamanio) As String
        a = 1
        Do While a < tamanio + 1
            Console.Write("INGRESE EL VALOR " + Str(a) + " DE LA LISTA : ")
            lista(a) = Console.ReadLine
            If lista(a) = "" Then
                a = 21

            End If
            a = a + 1
        Loop

        borrar_repetidos(lista, tamanio)

        x = 1
        Do While x < 11
            Console.WriteLine(lista(x))
            x = x + 1
        Loop

        '*******CODIGO BASE
        ', valorre, burbuja As String
        'Dim x, y, c As Integer

        'lista(1) = "bb"
        'lista(2) = "bb"
        'lista(3) = "aa"
        'lista(4) = "cc"
        'lista(5) = "dd"
        'lista(6) = "gg"
        'lista(7) = "aa"
        'lista(8) = "aa"
        'lista(9) = "aa"
        'lista(10) = "ff"
        'x = 1
        'y = 2
        'c = 1
        'Do Until x = 10
        '    Do Until y = 11 Or lista(x) = ""
        '        If lista(x) = lista(y) Then
        '            lista(y) = ""
        '            c = y
        '            Do While c <> 10
        '                burbuja = lista(c)
        '                lista(c) = lista(c + 1)
        '                lista(c + 1) = burbuja
        '                c = c + 1
        '            Loop
        '        End If
        '        If lista(x) <> lista(y) Then
        '            y = y + 1
        '        End If
        '    Loop
        '    x = x + 1
        '    y = x + 1
        'Loop
        'x = 1
        'Do While x < 11
        '    Console.WriteLine(lista(x))
        '    x = x + 1
        'Loop
        'CODIGO BASE FIN ********
        Console.ReadLine()
    End Sub

End Module
