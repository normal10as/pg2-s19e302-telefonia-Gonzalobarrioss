Public Class Linea
    Public Sub New(codigoArea As UShort, Numero As UInteger)
        Me.CodigoArea = codigoArea
        Me.Numero = Numero
    End Sub
    Private _equipo As Equipo
    Public Property Equipo As Equipo
        Get
            Return _equipo
        End Get
        Set(value As Equipo)
            _equipo = value
        End Set
    End Property
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

    Public ReadOnly Property Estado As String
        Get
            If LineaEstado = 0 Then
                Return "supendido"
            End If
            Return "activo"
        End Get
    End Property

    Private LineaEstado As Byte = 1
    Public Sub suspender()
        LineaEstado = 0
    End Sub

    Public Sub reactivar()
        LineaEstado = 1
    End Sub

    Public Overrides Function toString() As String
        If LineaEstado = 0 Then
            Return CodigoArea & " " & Numero & " suspendida"
        End If
        Return CodigoArea & " " & Numero
    End Function
End Class
