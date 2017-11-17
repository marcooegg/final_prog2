Imports AgenciaEntidades
Module PaqueteTest
    Sub main()
        Try
            Dim paquete1 As New Paquete("viajecito", #12/10/2017#, #12/17/2017#)
            Dim pasajero1 As New Pasajero(11111111, "fulano")
            Dim pasajero2 As New Pasajero(11111112, "mengana")
            Dim cliente1 As New Cliente(pasajero1, "20-11111111-7")
            Dim Cancun As New Ciudad("Cancun")
            Dim BuenosAires As New Ciudad("Buenos Aires")
            Dim viaje1 As New Pasaje("Vuelos", #10/10/2017#, 2500, BuenosAires, Cancun)
            Dim hotel1 As New Hotel("Sheraton", #10/10/2017#, Cancun, 7, 1500)
            Console.WriteLine(paquete1.NumeroDias)
            paquete1.addPasajero(pasajero1)
            paquete1.addPasajero(pasajero2)
            Console.WriteLine(paquete1.NumeroPasajeros)
            For Each pasajero As Pasajero In paquete1.getAllPasajeros
                Console.WriteLine(pasajero.ToString)
            Next
            paquete1.removePasajero(pasajero2)
            For Each pasajero As Pasajero In paquete1.getAllPasajeros
                Console.WriteLine(pasajero.ToString)
            Next
            paquete1.addProducto(viaje1)
            paquete1.addProducto(hotel1)
            For Each producto As Producto In paquete1.getAllProductos
                Console.WriteLine(producto.ToString)
            Next

            Console.WriteLine("costo total: $" & paquete1.costo)
            Console.WriteLine(paquete1.ToString)
            'Console.WriteLine("primera excepcion")
            'Dim paquete2 As New Paquete("viaje en el tiempo", #01/15/2018#, #01/01/2018#)
            'Console.WriteLine("segunda excepcion")
            'Dim paquete3 As New Paquete("viaje rush", Date.Today, #11/20/2017#)
            'Console.WriteLine("tercer excepcion")
            'Dim paquete4 As New Paquete("viajecito", #10/10/2017#, #10/17/2017#)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
        Try
            Console.WriteLine("fecha ida 15/01/2018, fecha vuelta 01/01/2018")
            Dim paquete2 As New Paquete("viaje en el tiempo", #01/15/2018#, #01/01/2018#)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Console.WriteLine("fecha de ida: hoy")
            Dim paquete3 As New Paquete("viaje rush", Date.Today, #11/20/2017#)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Console.WriteLine("fecha ida 10/10/2017, fecha vuelta 17/10/2017")
            Dim paquete4 As New Paquete("viajecito", #10/10/2017#, #10/17/2017#)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
