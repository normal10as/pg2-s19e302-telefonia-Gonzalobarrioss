Public Class Equipo
    ' Public Sub New(marca As Marca, modelo As Modelo, serieEquipo As String)
    ' Me.Serie = Serie
    '     marca = marca
    '     modelo = modelo
    ' End Sub
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
