Module Module1

    Sub Main()
        Dim a As Integer
        Dim l(100), opcion As String
        'Console.WriteLine("INGRESE LOS VALORES A ORDENAR")
        'a = 1
        'Do While a < 101 'INGRESO DE DATOS
        '    Console.Write(Str(a) + "-----> ")
        '    l(a) = Console.ReadLine
        '    If l(a) = "" Then
        '        a = 100
        '    End If
        '    a = a + 1
        'Loop
        agregar(l)
        Console.WriteLine("ELIJA COMO SE VA A MOSTRAR LA LISTA EN ASCENDENTE 'A' O EN DESCENDENTE 'D' O SOLO ENTER")
        opcion = Console.ReadLine
        ordenar(l, opcion)
        mostrar(l)
        Console.ReadLine()
    End Sub

End Module
