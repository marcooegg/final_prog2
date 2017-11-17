Public Class Pasajero
    Private _dni As UInteger
    Private _nombre As String
    Public Property Dni As UInteger
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            _dni = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Sub New(Dni As UInteger, Nombre As String)
        Me.Dni = Dni
        Me.Nombre = Nombre
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre & ": " & Dni
    End Function
End Class
