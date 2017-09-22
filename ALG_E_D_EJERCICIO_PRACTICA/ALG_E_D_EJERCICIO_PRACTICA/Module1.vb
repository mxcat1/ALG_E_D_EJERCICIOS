Module Module1

    Sub Main()
        Dim lista(10), valorre As String
        Dim listalimpia(10) As String

        Dim x, y, c, g As Integer

        lista(1) = "bb"
        lista(2) = "bb"
        lista(3) = "aa"
        lista(4) = "cc"
        lista(5) = "dd"
        lista(6) = "gg"
        lista(7) = "aa"
        lista(8) = "aa"
        lista(9) = "aa"
        lista(10) = "ff"
        x = 1
        y = 2
        c = 1
        g = 1
        Do Until x = 11
            Do Until y = 11
                If lista(x) = lista(y) And lista(y) <> "" Then
                    valorre = lista(y)
                    lista(y) = ""

                End If
                y = y + 1
            Loop
            x = x + 1
            y = x + 1
        Loop
        c = 1

        Do Until c = 11
            If lista(c) <> "" Then
                listalimpia(g) = lista(c)
                g = g + 1
            End If
            c = c + 1
        Loop
        x = 1
        Do While x < 11
            Console.WriteLine(listalimpia(x))
            x = x + 1
        Loop
        Console.ReadLine()
    End Sub

End Module
