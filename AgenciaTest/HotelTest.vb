Imports AgenciaEntidades
Module HotelTest
    Sub Main()
        Try
            Dim ciudad1 As New Ciudad("cancun")
            Dim hotel1 As New Hotel("sheraton", #10/10/2017#, ciudad1, 7, 1500)
            Console.WriteLine("Descripcion: " & hotel1.Descripcion)
            Console.WriteLine("Fecha:" & hotel1.Fecha)
            Console.WriteLine("Monto diario: " & hotel1.MontoDiaria)
            Console.WriteLine("Hotel tostring = " & hotel1.ToString)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
    End Sub
End Module
