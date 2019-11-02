Public MustInherit Class Cliente
    Public Sub New()
        Cuenta = 1
    End Sub
    Private _linea As Linea
    Public Property linea As Linea
        Set(value As Linea)
            If _linea Is Nothing Then
                value.addCliente(Me)
                _linea = value
            End If
        End Set
        Get
            Return _linea
        End Get
    End Property

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
