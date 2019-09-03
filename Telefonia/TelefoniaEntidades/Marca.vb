Public Class Marca
    Private _nombreMarca As String
    Public Property NombreMarca As String
        Get
            Return _nombreMarca
        End Get
        Set(value As String)
            If value.Length <= 30 Then
                _nombreMarca = value
            End If
        End Set
    End Property
End Class
