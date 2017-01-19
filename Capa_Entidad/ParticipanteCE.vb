Public Class ParticipanteCE
    Private _codpart As String
    Private _dnice As String
    Private _apePat As String
    Private _apeMat As String
    Private _nombres As String
    Private _fechaNaci As String
    Private _estadoCiv As String
    Private _sexo As String
    Private _direccion As String
    Private _ubigeo As String
    Private _telFijo As String
    Private _telMovil As String
    Private _opeMovil As String
    Private _correo As String
    Public Property codpart As String
        Get
            Return _codpart
        End Get
        Set(value As String)
            _codpart = value
        End Set
    End Property

    Public Property dnice As String
        Get
            Return _dnice
        End Get
        Set(value As String)
            _dnice = value
        End Set
    End Property
    Public Property correo As String
        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set
    End Property
    Public Property opeMovil As String
        Get
            Return _opeMovil
        End Get
        Set(ByVal value As String)
            _opeMovil = value
        End Set
    End Property
    Public Property telMovil As String
        Get
            Return _telMovil
        End Get
        Set(ByVal value As String)
            _telMovil = value
        End Set
    End Property
    Public Property telFijo As String
        Get
            Return _telFijo
        End Get
        Set(ByVal value As String)
            _telFijo = value
        End Set
    End Property
    Public Property ubigeo As String
        Get
            Return _ubigeo
        End Get
        Set(ByVal value As String)
            _ubigeo = value
        End Set
    End Property
    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property
    Public Property sexo As String
        Get
            Return _sexo
        End Get
        Set(ByVal value As String)
            _sexo = value
        End Set
    End Property
    Public Property EstadoCiv As String
        Get
            Return _estadoCiv
        End Get
        Set(ByVal value As String)
            _estadoCiv = value
        End Set
    End Property
    Public Property fechaNaci As String
        Get
            Return _fechaNaci
        End Get
        Set(ByVal value As String)
            _fechaNaci = value
        End Set
    End Property
    Public Property nombres As String
        Get
            Return _nombres
        End Get
        Set(ByVal value As String)
            _nombres = value
        End Set
    End Property
    Public Property apeMat As String
        Get
            Return _apeMat
        End Get
        Set(ByVal value As String)
            _apeMat = value
        End Set
    End Property
    Public Property apePat As String
        Get
            Return _apePat
        End Get
        Set(ByVal value As String)
            _apePat = value
        End Set
    End Property
End Class
