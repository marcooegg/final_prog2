Imports AgenciaEntidades
Module PasajeroTest
    Sub Main()

        Try
            Dim Pasajero1 As New Pasajero(35004017, "Fulano")
            Console.WriteLine(Pasajero1.Nombre)
            Console.WriteLine(Pasajero1.Dni)
            Console.WriteLine(Pasajero1.ToString)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
    End Sub
End Module
