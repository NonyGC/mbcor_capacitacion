Public Class CapacitacionCE


    Private _codigo As String
    Private _organizador As String
    Private _local As String
    Private _cantMasisa As Integer
    Private _cantIngresada As Integer
    Private _fecha As String
    Private _tema As String
    Private _expositor As String
    Private _estado As String
    Private _origen As String
    Public Property codigo As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Public Property origen As String
        Get
            Return _origen
        End Get
        Set(ByVal value As String)
            _origen = value
        End Set
    End Property
    Private _origenOtro As String
    Public Property origenOtro As String
        Get
            Return _origenOtro
        End Get
        Set(ByVal value As String)
            _origenOtro = value
        End Set
    End Property
    Public Property organizador As String
        Get
            Return _organizador
        End Get
        Set(ByVal value As String)
            _organizador = value
        End Set
    End Property
    Public Property local As String
        Get
            Return _local
        End Get
        Set(value As String)
            _local = value
        End Set
    End Property
    Public Property cantMasisa As Integer
        Get
            Return _cantMasisa
        End Get
        Set(value As Integer)
            _cantMasisa = value
        End Set
    End Property
    Public Property cantIngresada As Integer
        Get
            Return _cantIngresada
        End Get
        Set(value As Integer)
            _cantIngresada = value
        End Set
    End Property
    Public Property fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property
    Public Property tema As String
        Get
            Return _tema
        End Get
        Set(value As String)
            _tema = value
        End Set
    End Property
    Public Property expositor As String
        Get
            Return _expositor
        End Get
        Set(value As String)
            _expositor = value
        End Set
    End Property
    Public Property estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property
End Class