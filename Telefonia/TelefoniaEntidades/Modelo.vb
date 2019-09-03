Public Class Modelo
    Private _nombreModelo As String
    Public Property NombreModelo As String
        Get
            Return _nombreModelo
        End Get
        Set(value As String)
            If value.Length <= 50 Then
                _nombreModelo = value
            End If
        End Set
    End Property
End Class
