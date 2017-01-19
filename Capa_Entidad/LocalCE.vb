Public Class LocalCE

    Private _codigo As String
    Private _nombre As String
    Private _direccion As String
    Private _codUbigeo As String
    Private _aforo As Integer

    Public Property codigo As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property
    Public Property codUbigeo As String
        Get
            Return _codUbigeo
        End Get
        Set(value As String)
            _codUbigeo = value
        End Set
    End Property
    Public Property aforo As Integer
        Get
            Return _aforo
        End Get
        Set(value As Integer)
            _aforo = value
        End Set
    End Property

End Class
