Public Class Cliente
    Public Sub New()
        Cuenta = 1
    End Sub
    Private _cuenta As UInteger
    Public Property Cuenta As UInteger
        Get
            Return _cuenta
        End Get
        Set(value As UInteger)
            _cuenta = value
        End Set
    End Property
End Class
