Imports AgenciaEntidades

Public Class Pasaje
    Implements Producto
    Private _descripcion As String
    Private _fecha As Date
    Private _valor As Single
    Private _origen As Ciudad
    Private _destino As Ciudad
    Public Property Origen As Ciudad
        Get
            Return _origen
        End Get
        Set(value As Ciudad)
            _origen = value
        End Set
    End Property
    Public Property Destino As Ciudad
        Get
            Return _destino
        End Get
        Set(value As Ciudad)
            _destino = value
        End Set
    End Property
    Public Property Valor As Single
        Get
            Return _valor
        End Get
        Set(value As Single)
            _valor = value
        End Set
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
            _fecha = value
        End Set
    End Property
    Sub New(Descripcion As String, Fecha As Date, Valor As Single, Origen As Ciudad, Destino As Ciudad)
        Me.Descripcion = Descripcion
        Me.Fecha = Fecha
        Me.Valor = Valor
        Me.Origen = Origen
        Me.Destino = Destino
    End Sub
    Public Function costo() As Single Implements Producto.costo
        Return Valor
    End Function
    Public Overrides Function ToString() As String
        Return Descripcion
    End Function
End Class
