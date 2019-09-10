Public Class Empresa
    Inherits Cliente
    Public Sub New(RazonSocial As String, Cuit As String)
        Me.RazonSocial = RazonSocial
        Me.Cuit = Cuit
    End Sub
    Private _razonSocial As String
    Public Property RazonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            If value.Length <= 80 And value.Length > 0 Then
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
            If value.Length <= 13 And value.Length > 0 Then
                _cuit = value
            End If
        End Set
    End Property

    Public Function toString() As String
        Return RazonSocial & " " & Cuenta
    End Function
End Class
