Module Module1

    Sub Main()
        Dim a As Integer
        Dim opcion As String
        Dim canti_datos As Integer
        Console.WriteLine("INDIQUE LA CANTIDAD DE DATOS QUE VA A INGRESAR")
        canti_datos = Console.ReadLine()
        Dim l(canti_datos) As String
        'PROCEDIMIENTO QUE AGREGA VALORES ALA LISTA
        agregar(l, canti_datos)
        Console.WriteLine("ELIJA COMO SE VA A MOSTRAR LA LISTA EN ASCENDENTE 'A' O EN DESCENDENTE 'D' O SOLO ENTER")
        'VARIABLE QUE TE PERMITE ELEGIR LA OPCION PARA QUE SE MUESTRE LA LISTA
        opcion = Console.ReadLine
        'FUNCION QUE ORDENE LA LISTA Y USS DATOS
        l = ordenar(l, opcion, canti_datos)
        'PROCEDIMIENTO QUE MUESTRA LA LISTA
        mostrar(l, canti_datos)
        Console.ReadLine()
    End Sub

End Module
