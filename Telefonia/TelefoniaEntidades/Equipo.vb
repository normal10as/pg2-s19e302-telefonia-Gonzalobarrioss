Public Class Equipo
    Public Sub New(marca As Marca, modelo As Modelo, serie As String)
        Me.Serie = serie
        modelo.Marca = marca
        _modelo = modelo
    End Sub
    Private _modelo As Modelo
    Public Property Modelo As Modelo
        Get
            Return _modelo
        End Get
        Set(value As Modelo)
            _modelo = value
        End Set
    End Property
    Private _serie As String
    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If value.Length <= 15 And value.Length > 0 Then
                _serie = value
            End If

        End Set
    End Property

    Public ReadOnly Property FechaVenta As Date
        Get
            Return vender()
        End Get
    End Property

    Public Function vender() As Date
        Return Date.Now
    End Function

    Public Overrides Function toString() As String
        Return Serie
    End Function

End Class
