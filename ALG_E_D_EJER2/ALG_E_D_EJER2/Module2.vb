Module Module2
    Function ordenar(l, opcion) As Array 'FUNCION QUE ORDENA DESCENDENTEMENTE o ASCENDENTEMENTE UNA LISTA DE NOMBRES

        Dim a, b As Integer
        Dim t As String
        a = 1
        b = 2

        Do Until a = 100 Or l(a) = ""
            Do Until b = 101 Or l(b) = ""
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
    Public Sub mostrar(l()) 'PROCEDIMIENTO QUE MUESTRA LA LISTA DE NOMBRES  
        Dim a As Integer
        a = 1
        Do While a < 101

            If l(a) = "" Then
                a = 100
            Else
                Console.WriteLine(Str(a) + "------->" + l(a))
            End If

            a = a + 1
        Loop
    End Sub
    Public Sub agregar(l())
        Dim a As Integer = 1
        Console.WriteLine("INGRESE LOS VALORES A ORDENAR")
        Do While a < 101
            Console.Write(Str(a) + "-----> ")
            l(a) = Console.ReadLine
            If l(a) = "" Then
                a = 100
            End If
            a = a + 1
        Loop
    End Sub
End Module
