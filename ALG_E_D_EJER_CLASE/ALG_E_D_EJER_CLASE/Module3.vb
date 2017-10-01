Module Module3
    Function ordenar(l, opcion, n_datos) As Array 'FUNCION QUE ORDENA DESCENDENTEMENTE o ASCENDENTEMENTE UNA LISTA DE NOMBRES

        Dim a, b As Integer
        Dim t As String
        a = 1
        b = 2

        Do Until a = n_datos
            Do Until b = n_datos + 1
                If opcion = "A" Or opcion = "a" Then
                    If (l(a) > l(b) And l(b) <> "") Or l(a) = "" Then
                        t = l(a)
                        l(a) = l(b)
                        l(b) = t
                    End If
                Else
                    If l(a) < l(b) Then
                        t = l(a)
                        l(a) = l(b)
                        l(b) = t
                    End If

                End If
                b = b + 1
            Loop
            a = a + 1
            b = a + 1
        Loop

        Return l
    End Function
End Module
