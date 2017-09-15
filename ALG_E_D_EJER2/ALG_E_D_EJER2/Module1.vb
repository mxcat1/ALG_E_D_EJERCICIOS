Module Module1

    Sub Main()
        Dim a As Integer
        Dim l(100), opcion As String
        'PROCEDIMIENTO QUE AGREGA VALORES ALA LISTA
        agregar(l)
        Console.WriteLine("ELIJA COMO SE VA A MOSTRAR LA LISTA EN ASCENDENTE 'A' O EN DESCENDENTE 'D' O SOLO ENTER")
        'VARIABLE QUE TE PERMITE ELEGIR LA OPCION PARA QUE SE MUESTRE LA LISTA
        opcion = Console.ReadLine
        'FUNCION QUE ORDENE LA LISTA Y USS DATOS
        l = ordenar(l, opcion)
        'PROCEDIMIENTO QUE MUESTRA LA LISTA
        mostrar(l)
        Console.ReadLine()
    End Sub

End Module
