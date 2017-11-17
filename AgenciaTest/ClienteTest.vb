Imports AgenciaEntidades
Module ClienteTest
    Sub main()
        Try
            Dim Pasajero1 As New Pasajero(11111111, "Fulano")
            Dim Cliente1 As New Cliente(Pasajero1, "20-11111111-7")
            Console.WriteLine(Cliente1.Dni)
            Console.WriteLine(Cliente1.Nombre)
            Console.WriteLine(Cliente1.Cuit_cuil)
            Console.WriteLine(Cliente1.ToString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
    End Sub
End Module
