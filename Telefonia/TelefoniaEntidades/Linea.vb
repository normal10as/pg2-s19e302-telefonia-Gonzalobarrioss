Public Class Linea
    Public Sub New(codigoArea As UShort, Numero As UInteger, equipo As Equipo)
        Me.CodigoArea = codigoArea
        Me.Numero = Numero
        Me.Equipo = equipo
    End Sub

    Public Property Plan As IPlan

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
            If LineaEstadoActivo Then
                Return "activo"
            Else
                Return "suspendido"
            End If
        End Get
    End Property

    Private _clientes As List(Of Cliente)

    Friend Sub addCliente(cliente As Cliente)
        _clientes.Add(cliente)
    End Sub

    Public Function getAllClientes() As List(Of Cliente)
        Return _clientes
    End Function

    Friend Sub removeCliente(cliente As Cliente)
        _clientes.Remove(cliente)
    End Sub

    Private LineaEstadoActivo As Boolean = True
    Public Sub suspender()
        LineaEstadoActivo = False
    End Sub
    Public Sub reactivar()
        LineaEstadoActivo = True
    End Sub
    Public Overrides Function toString() As String
        Dim resultado As String
        resultado = CodigoArea & " " & Numero
        If Not LineaEstadoActivo Then
            resultado += " suspendida"
        End If
        Return resultado
    End Function
End Class
