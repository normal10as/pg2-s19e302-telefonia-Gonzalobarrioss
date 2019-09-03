Public Class Equipo
    Private _serieEquipo As String
    Public Property SerieEquipo As String
        Get
            Return _serieEquipo
        End Get
        Set(value As String)
            If value.Length <= 15 Then
                _serieEquipo = value
            End If

        End Set
    End Property

    Private _fechaVenta As Date
    Public ReadOnly Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property
End Class
