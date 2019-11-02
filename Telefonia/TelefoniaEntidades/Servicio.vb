Imports TelefoniaEntidades

Public MustInherit Class Servicio
    Implements IPlan

    Public Property credito As UInteger

    Public Property precio As Decimal Implements IPlan.precio
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Decimal)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overridable Sub NuevoConsumo(valor As UInteger)

    End Sub

    Public Function getDisponible() As UInteger

    End Function

    Public Function getDisponibleToString() As String Implements IPlan.getDisponibleToString
        Throw New NotImplementedException()
    End Function

    Public Function getConsumosToString() As String Implements IPlan.getConsumosToString
        Throw New NotImplementedException()
    End Function
End Class
