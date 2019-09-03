Public Class Empresa
    Private _razonSocial As String
    Public Property RazonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            If value.Length <= 80 Then
                _razonSocial = value
            End If

        End Set
    End Property

    Private _cuit As String
    Public Property Cuit As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            If value.Length <= 13 Then
                _cuit = value
            End If
        End Set
    End Property
End Class
