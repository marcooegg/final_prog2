Imports AgenciaEntidades

Public Class Hotel
    Implements Producto
    Private _descripcion As String
    Private _fecha As Date
    Private _habitaciones As Byte
    Private _noches As Byte
    Private _montoDiaria As Single
    Private _ciudad As Ciudad
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
            _fecha = value
        End Set
    End Property
    Public Property Habitaciones As Byte
        Get
            Return _habitaciones
        End Get
        Set(value As Byte)
            _habitaciones = value
        End Set
    End Property
    Public Property Noches As Byte
        Get
            Return _noches
        End Get
        Set(value As Byte)
            _noches = value
        End Set
    End Property
    Public Property MontoDiaria As Single
        Get
            Return _montoDiaria
        End Get
        Set(value As Single)
            _montoDiaria = value
        End Set
    End Property
    Sub New(Descripcion As String, Fecha As Date, Ciudad As Ciudad, Noches As Byte, MontoDiaria As Single)
        Me.Descripcion = Descripcion
        Me.Fecha = Fecha
        _ciudad = Ciudad
        Me.Noches = Noches
        Me.MontoDiaria = MontoDiaria
        _habitaciones = 0
    End Sub
    Public Function costo() As Single Implements Producto.costo
        Return MontoDiaria * Noches
    End Function
    Public Overrides Function ToString() As String
        Return Descripcion
    End Function
End Class
