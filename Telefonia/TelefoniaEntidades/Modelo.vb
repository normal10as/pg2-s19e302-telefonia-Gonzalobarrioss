﻿Public Class Modelo

    Public Sub New(nombreModelo)
        Me.NombreModelo = nombreModelo
    End Sub
    Private _nombreModelo As String
    Public Property NombreModelo As String
        Get
            Return _nombreModelo
        End Get
        Set(value As String)
            If value.Length <= 50 And value.Length > 0 Then
                _nombreModelo = value
            End If
        End Set
    End Property
End Class
