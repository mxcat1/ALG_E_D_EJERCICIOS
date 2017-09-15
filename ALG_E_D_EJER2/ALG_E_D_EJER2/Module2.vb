Module Module2
    Dim a As Integer = 1
    Function ordenar(l, opcion, n_datos) As Array 'FUNCION QUE ORDENA DESCENDENTEMENTE o ASCENDENTEMENTE UNA LISTA DE NOMBRES

        Dim a, b As Integer
        Dim t As String
        a = 1
        b = 2

        Do Until a = n_datos Or l(a) = ""
            Do Until b = n_datos Or l(b) = ""
                If opcion = "A" Or opcion = "a" Then
                    If l(a) < l(b) And (l(a) <> "" Or l(b) <> "") Then
                        t = l(a)
                        l(a) = l(b)
                        l(b) = t
                    End If
                Else
                    If l(a) > l(b) Then
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
    Public Sub mostrar(l, n_datos) 'PROCEDIMIENTO QUE MUESTRA LA LISTA DE NOMBRES  
        a = 1
        Do While a < n_datos + 1

            If l(a) = "" Then
                a = n_datos
            Else
                Console.WriteLine(Str(a) + "------->" + l(a))
            End If

            a = a + 1
        Loop
    End Sub
    Public Sub agregar(l(), n_datos)
        a = 1
        Console.WriteLine("INGRESE LOS VALORES A ORDENAR")
        Do While a < n_datos + 1
            Console.Write(Str(a) + "-----> ")
            l(a) = Console.ReadLine
            If l(a) = "" Then
                a = n_datos
            End If
            a = a + 1
        Loop
    End Sub
End Module
