Public Class Equipo
    Public Sub New()

    End Sub
    Private _serieEquipo As String
    Public Property SerieEquipo As String
        Get
            Return _serieEquipo
        End Get
        Set(value As String)
            If value.Length <= 15 And value.Length > 0 Then
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

    Sub vender(fecha As Date)
        Console.WriteLine("fecha de venta: " & Date.Now)
    End Sub

End Class
