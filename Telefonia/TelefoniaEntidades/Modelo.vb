Public Class Modelo

    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length <= 50 And value.Length > 0 Then
                _nombre = value
            End If
        End Set
    End Property

    Public Overrides Function toString() As String
        Return Nombre
    End Function
End Class
