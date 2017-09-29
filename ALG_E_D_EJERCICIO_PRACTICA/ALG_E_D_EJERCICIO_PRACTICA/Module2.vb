Module Module2
    Function borrar_repetidos(lista, tamano) As Array
        Dim burbuja As String
        Dim x, y, c As Integer
        x = 1
        y = 2
        c = 1
        Do Until x = tamano
            Do Until y = tamano + 1 Or lista(x) = ""
                If lista(x) = lista(y) Then
                    lista(y) = ""
                    c = y
                    Do While c <> tamano
                        burbuja = lista(c)
                        lista(c) = lista(c + 1)
                        lista(c + 1) = burbuja
                        c = c + 1
                    Loop
                End If
                If lista(x) <> lista(y) Then
                    y = y + 1
                End If
            Loop
            x = x + 1
            y = x + 1
        Loop
        Return lista
    End Function
End Module
