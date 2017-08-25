Module Module1

    Sub Main()


        Dim aa, dd, mm, tipo As Integer
        Console.WriteLine("PROGRAMA QUE NOS DA LA FECHA EN TRES DIFERENTES TIPOS")
        Console.WriteLine("---------------------------------------------------------------------")
        Console.Write("INGRESE EL DIA EN DOS DIGITO: ")
        dd = Console.ReadLine()
        Console.Write("INGRESE EL MES EN DOS DIGITO: ")
        mm = Console.ReadLine()
        Console.Write("INGRESE EL AÑO EN DOS DIGITO: ")
        aa = Console.ReadLine()
        Console.WriteLine("INGRESE EL TIPO DE FECHA QUE QUIERE VER")
        Console.WriteLine("TIPO 1 ===> 25 DE AGOSTO DE 2017")
        Console.WriteLine("TIPO 2 ===> AGOSTO 25, 2017")
        Console.WriteLine("TIPO 3 ===> VIERNES 25 DE AGOSTO")
        tipo = Console.ReadLine()
        Console.WriteLine("LA FECHA ACTUAL ES : " + fechas(dd, mm, aa, tipo))
        Console.ReadLine()
    End Sub

End Module
