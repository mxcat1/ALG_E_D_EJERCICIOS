Module Module1

    Sub Main()
        Dim tamanio, a, c As Integer
        Console.Write("INDIQUE EL TAMAÑO DE LA VARIABLE INDEXADA A VERIFICAR ====> ")
        tamanio = Console.ReadLine
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
        lista = borrar_duplicados(lista, tamanio)
        a = 1
        Do While a < tamanio + 1
            Console.WriteLine("ELEMENTO " + Str(a) + " ----> " + lista(a))
            a = a + 1
        Loop
        Console.ReadLine()
    End Sub

End Module
