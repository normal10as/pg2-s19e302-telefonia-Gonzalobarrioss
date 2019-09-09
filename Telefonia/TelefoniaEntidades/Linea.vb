Public Class Linea
    Public Sub New(codigoArea, Numero)
        Me.CodigoArea = codigoArea
        Me.Numero = Numero
    End Sub
    Private _codigoArea As UShort
    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            If value >= 100 And value <= 9999 Then
                _codigoArea = value
            End If
        End Set
    End Property

    Private _numero As UInteger
    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            If value >= 100000 And value <= 9999999 Then
                _numero = value
            End If

        End Set
    End Property

    Private _estado As String
    Public ReadOnly Property Estado As String
        Get
            Return _estado
        End Get
    End Property

    Sub suspender()
        _estado = 0
    End Sub

    Sub reactivar()
        _estado = 1
    End Sub

End Class
