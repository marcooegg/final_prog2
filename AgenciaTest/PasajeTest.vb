Imports AgenciaEntidades
Module PasajeTest
    Sub main()
        Try
            Dim ciudad1 As New Ciudad("buenos aires")
            Dim ciudad2 As New Ciudad("cancun")
            Dim pasaje1 As New Pasaje("vuelo copado", #10/10/2017#, 10000, ciudad1, ciudad2)
            Console.WriteLine("valor: " & pasaje1.Valor)
            Console.WriteLine("pasaje tostring = " & pasaje1.ToString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
    End Sub
End Module
