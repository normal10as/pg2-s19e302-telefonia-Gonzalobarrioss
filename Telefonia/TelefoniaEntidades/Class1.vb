Public Class Marca
    Private _nombreMarca As String
    Public Property NombreMarca As String
        Get
            Return _nombreMarca
        End Get
        Set(value As String)
            _nombreMarca = value
        End Set
    End Property
End Class

Public Class Modelo
    Private _nombreModelo As String
    Public Property NombreModelo As String
        Get
            Return _nombreModelo
        End Get
        Set(value As String)
            _nombreModelo = value
        End Set
    End Property
End Class

Public Class Equipo
    Private _serieEquipo As String
    Public Property SerieEquipo As String
        Get
            Return _serieEquipo
        End Get
        Set(value As String)
            _serieEquipo = value
        End Set
    End Property

    Private _fechaVenta As Date
    Public ReadOnly Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property
End Class

Class Linea
    Private _codigoArea As UShort
    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            _codigoArea = value
        End Set
    End Property

    Private _numero As UInteger
    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            _numero = value
        End Set
    End Property

    Private _estado As String
    Public ReadOnly Property Estado As String
        Get
            Return _estado
        End Get
    End Property
End Class

Class cliente
    Private _cuenta As UInteger
    Public Property Cuenta As UInteger
        Get
            Return _cuenta
        End Get
        Set(value As UInteger)
            _cuenta = value
        End Set
    End Property
End Class

Class persona
    Private _apellido As String
    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Private _documento As UInteger
    Public Property Documento As UInteger
        Get
            Return _documento
        End Get
        Set(value As UInteger)
            _documento = value
        End Set
    End Property
End Class

Class empresa
    Private _razonSocial As String
    Public Property RazonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            _razonSocial = value
        End Set
    End Property

    Private _cuit As String
    Public Property Cuit As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            _cuit = value
        End Set
    End Property
End Class