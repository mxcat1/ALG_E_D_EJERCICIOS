Module Module2
    Function borrar_duplicados(lista, tamanio) As Array
        Dim a, b, c As Integer
        a = 1
        b = 2
        Do While a < tamanio + 1
            If lista(a) = "" Then
                a = 21
            Else
                c = c + 1
            End If
            a = a + 1
        Loop
        a = 1
        Do Until a = tamanio Or a = c
            Do Until b = tamanio + 1 Or b = c + 1
                If lista(a) = lista(b) Then
                    lista(b) = ""
                End If
                b = b + 1
            Loop
            a = a + 1
            b = a + 1
        Loop
        lista = ordenar(lista, "D", tamanio)
        Return lista
    End Function
End Module
