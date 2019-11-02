Imports TelefoniaEntidades

Public Class Paquete
    Implements IPlan

    Public Property nombre As String

    Public Property precio As Decimal Implements IPlan.precio
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Decimal)
            Throw New NotImplementedException()
        End Set
    End Property

    Private _servicios As List(Of Servicio)
    Public Sub addServicio(servicio As Servicio)
        _servicios.Add(servicio)
    End Sub

    Public Sub removeServicio(servicio As Servicio)
        _servicios.Remove(servicio)
    End Sub

    Public Function getAllServicios() As List(Of Servicio)
        Return _servicios
    End Function

    Public Function getDisponibleToString() As String Implements IPlan.getDisponibleToString
        Throw New NotImplementedException()
    End Function

    Public Function getConsumosToString() As String Implements IPlan.getConsumosToString
        Throw New NotImplementedException()
    End Function
End Class
