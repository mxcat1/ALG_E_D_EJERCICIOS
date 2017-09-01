Module Module2
    Function fechas(dd, mm, aa, tipo) As String
        Dim aux1, aux2, conta, resto As Integer
        Dim ultimeses(12) As Integer
        Dim meses(12), lafecha, dias(7) As String
        conta = 1
        ultimeses(1) = 31
        ultimeses(2) = 28
        ultimeses(3) = 31
        ultimeses(4) = 30
        ultimeses(5) = 31
        ultimeses(6) = 30
        ultimeses(7) = 31
        ultimeses(8) = 31
        ultimeses(9) = 30
        ultimeses(10) = 31
        ultimeses(11) = 30
        ultimeses(12) = 31
        meses(1) = "Enero"
        meses(2) = "Febrero"
        meses(3) = "Marzo"
        meses(4) = "Abril"
        meses(5) = "Mayo"
        meses(6) = "Junio"
        meses(7) = "Julio"
        meses(8) = "Agosto"
        meses(9) = "Setiembre"
        meses(10) = "Octubre"
        meses(11) = "Noviembre"
        meses(12) = "Diciembre"
        dias(1) = "Domingo"
        dias(2) = "Lunes"
        dias(3) = "Martes"
        dias(4) = "Miercoles"
        dias(5) = "Jueves"
        dias(6) = "Viernes"
        dias(7) = "Sabado"
        aux1 = (aa / 4)
        aux2 = aux1 * 4
        If aux2 = aa Then
            ultimeses(2) = 29
        Else
            ultimeses(2) = 28
        End If

        If tipo = 1 Then
            lafecha = Str(dd) + " de " + meses(mm) + " de" + Str(aa + 2000)
        Else
            If tipo = 2 Then
                lafecha = meses(mm) + Str(dd) + ", " + Str(aa + 2000)
            Else
                If tipo = 3 Then
                    aux1 = ((aa - 1) * 365)
                    aux1 = aux1 + Int((aa - 1) / 4)
                    Do Until conta = mm
                        aux1 = aux1 + ultimeses(conta)
                        conta = conta + 1
                    Loop
                    aux1 = aux1 + dd
                    aux2 = Int(aux1 / 7)
                    resto = (aux1 - (aux2 * 7)) + 1
                    lafecha = dias(resto) + Str(dd) + " de " + meses(mm)
                End If
            End If
        End If
        Return lafecha

    End Function
    Function validardia(dd, mm, aa) As Boolean
        Dim ultimeses(12), aux1, aux2 As Integer
        ultimeses(1) = 31
        ultimeses(2) = 28
        ultimeses(3) = 31
        ultimeses(4) = 30
        ultimeses(5) = 31
        ultimeses(6) = 30
        ultimeses(7) = 31
        ultimeses(8) = 31
        ultimeses(9) = 30
        ultimeses(10) = 31
        ultimeses(11) = 30
        ultimeses(12) = 31
        aux1 = (aa / 4)
        aux2 = aux1 * 4

        If (aa = aux2) Then
            ultimeses(2) = 29
        Else
            ultimeses(2) = 28
        End If
        If (dd > 0 And dd <= ultimeses(mm)) Then
            Return True
        Else
            Return False
        End If

    End Function
End Module
