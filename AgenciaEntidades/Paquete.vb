Imports AgenciaEntidades

Public Class Paquete
    Implements Producto
    Private _descripcion As String
    Private _fecha As Date
    Private _fechaFinal As Date
    'Private _numeroDias As UShort
    'Private _numeroPasajeros As UShort
    Private _productos As List(Of Producto)
    Private _pasajeros As List(Of Pasajero)
    Public Property FechaFinal As Date
        Get
            Return _fechaFinal
        End Get
        Set(value As Date)
            If Fecha >= value Then Throw New Exception("La fecha de vuelta debe ser posterior a la de ida")
            _fechaFinal = value
        End Set
    End Property
    Public ReadOnly Property NumeroDias As UShort
        Get
            Return DateDiff(DateInterval.Day, Fecha, FechaFinal)
        End Get
    End Property
    Public ReadOnly Property NumeroPasajeros As UShort
        Get
            Return _pasajeros.Count
        End Get
    End Property

    Public Property Descripcion As String Implements Producto.Descripcion
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Fecha As Date Implements Producto.Fecha
        Get
            Return _fecha
        End Get
        Set(value As Date)
            If value < Date.Today Then Throw New Exception("La reserva no puede ser para antes de hoy")
            If value = Date.Today Then Throw New Exception("La reserva no puede ser para hoy")
            _fecha = value
        End Set
    End Property

    Sub New(Descripcion As String, Fecha As Date, FechaFinal As Date)
        'Me.Fecha = Nothing
        'Me.FechaFinal = Nothing
        Me.Descripcion = Descripcion
        Me.Fecha = Fecha
        Me.FechaFinal = FechaFinal
        _productos = New List(Of Producto)
        _pasajeros = New List(Of Pasajero)
    End Sub
    Public Sub addPasajero(pasajero As Pasajero)
        _pasajeros.Add(pasajero)
    End Sub
    Public Sub removePasajero(pasajero As Pasajero)
        _pasajeros.Remove(pasajero)
    End Sub
    Public Function getAllPasajeros() As List(Of Pasajero)
        Return _pasajeros
    End Function
    Public Sub addProducto(producto As Producto)
        _productos.Add(producto)
    End Sub
    Public Sub removeProducto(producto As Producto)
        _productos.Remove(producto)
    End Sub
    Public Function getAllProductos() As List(Of Producto)
        Return _productos
    End Function
    Public Overrides Function ToString() As String
        Dim linea As String
        linea = ""
        For Each producto As Producto In getAllProductos()
            linea &= producto.ToString() & ", "
        Next
        Return linea
    End Function

    Public Function costo() As Single Implements Producto.costo
        Dim total As Single
        For Each producto As Producto In getAllProductos()
            total += producto.costo
        Next
        Return total
    End Function
End Class
