Module Module1

    Sub Main()


        Dim r As String = "s"
        Dim aa, dd, mm, tipo As Integer
        Console.ForegroundColor = 10
        Console.WriteLine("PROGRAMA QUE NOS DA LA FECHA EN TRES DIFERENTES TIPOS")
        Console.WriteLine("---------------------------------------------------------------------")
        Do While r = "s" Or r = "S"
            Console.Write("INGRESE EL AÑO EN DOS DIGITO: ")
            aa = Console.ReadLine()
            Do While aa < 0 Or aa > 99
                Console.WriteLine("ERROR VUELVA A INGRESAR UN AÑO VALIDO DEL 1 AL 99")
                aa = Console.ReadLine()
            Loop
            Console.Write("INGRESE EL MES EN DOS DIGITO: ")
            mm = Console.ReadLine()
            Do While mm < 1 Or mm > 12
                Console.WriteLine("ERROR VUELVA A INGRESAR UN MES VALIDO DEL 1 AL 12")
                mm = Console.ReadLine()
            Loop
            Console.Write("INGRESE EL DIA EN DOS DIGITO: ")
            dd = Console.ReadLine()
            Do While Not validardia(dd, mm, aa)
                Console.WriteLine("ERROR VUELVA A INGRESAR UN DIA VALIDO")
                dd = Console.ReadLine()
            Loop

            Console.WriteLine("INGRESE EL TIPO DE FECHA QUE QUIERE VER")
            Console.WriteLine(" -----------------------------------")
            Console.WriteLine("|TIPO 1 ===> 25 DE AGOSTO DE 2017   |")
            Console.WriteLine("|TIPO 2 ===> AGOSTO 25, 2017        |")
            Console.WriteLine("|TIPO 3 ===> VIERNES 25 DE AGOSTO   |")
            Console.WriteLine(" -----------------------------------")
            tipo = Console.ReadLine()
            Console.WriteLine("LA FECHA ACTUAL ES : " + fechas(dd, mm, aa, tipo))
            Console.WriteLine("-----------------------------------------")
            Console.WriteLine("-----------------------------------------")
            Console.WriteLine("-----------------------------------------")

            Console.WriteLine("DESEA INGRESAR OTRA FECHA ESCRIBA S EN MAYUSCULAS?")
            Console.WriteLine("O MINUSCULAS")
            r = Console.ReadLine()
        Loop

    End Sub

End Module
