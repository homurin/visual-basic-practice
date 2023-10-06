Module Module1
    Public Function menghitungluas(ByRef panjang As Integer, ByVal lebar As Integer)
        panjang += 1
        lebar += 1
        Return panjang * lebar
    End Function

    Public Function total(ByVal x As Integer)
        Dim y, var As Integer
        y = x
        var = x + y
        total = var
    End Function

    Sub hitungv(ByVal a As Decimal)
        a += 1
        a = a * 2
    End Sub

    Sub hitungr(ByRef a As Decimal)
        a += 1
        a = a * 2
    End Sub
End Module
