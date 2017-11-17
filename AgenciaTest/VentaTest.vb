Imports AgenciaEntidades
Module VentaTest
    Sub main()
        Try
            Dim venta1 As New Venta()
            Dim pasajero1 As New Pasajero(11111111, "fulano")
            Dim cliente1 As New Cliente(pasajero1, "20-11111111-7")
            venta1.Fecha = #10/10/2017#
            venta1.Cliente = cliente1
            Console.WriteLine(venta1.ToString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
    End Sub
End Module
