Public Class EncuestaSharedCE

    Shared _codcap As String
    Shared _charla As String
    Shared _espCharla As String
    Shared _dominioTem As String
    Shared _dejaEntender As String
    Shared _fueInterezante As String
    Shared _extCharla As String
    Shared _visitaPagina As String
    Shared _otroTema As String
    Shared _targeta As String

    Shared Property codcap As String
        Get
            Return _codcap
        End Get
        Set(ByVal value As String)
            _codcap = value
        End Set
    End Property
    Shared Property espCharla As String
        Get
            Return _espCharla
        End Get
        Set(ByVal value As String)
            _espCharla = value
        End Set
    End Property
    Shared Property charla As String
        Get
            Return _charla
        End Get
        Set(ByVal value As String)
            _charla = value
        End Set
    End Property
    Shared Property dominioTem As String
        Get
            Return _dominioTem
        End Get
        Set(ByVal value As String)
            _dominioTem = value
        End Set
    End Property
    Shared Property dejaEntender As String
        Get
            Return _dejaEntender
        End Get
        Set(ByVal value As String)
            _dejaEntender = value
        End Set
    End Property
    Shared Property fueInteresante As String
        Get
            Return _fueInterezante
        End Get
        Set(ByVal value As String)
            _fueInterezante = value
        End Set
    End Property
    Shared Property extCharla As String
        Get
            Return _extCharla
        End Get
        Set(ByVal value As String)
            _extCharla = value
        End Set
    End Property
    Shared Property visitaPagina As String
        Get
            Return _visitaPagina
        End Get
        Set(ByVal value As String)
            _visitaPagina = value
        End Set
    End Property
    Shared Property otroTema As String
        Get
            Return _otroTema
        End Get
        Set(ByVal value As String)
            _otroTema = value
        End Set
    End Property
    Shared Property targeta As String
        Get
            Return _targeta
        End Get
        Set(ByVal value As String)
            _targeta = value
        End Set
    End Property

    Shared Sub resetEncuestaSharedCE()
        _codcap = Nothing
        _charla = Nothing
        _espCharla = Nothing
        _dominioTem = Nothing
        _dejaEntender = Nothing
        _fueInterezante = Nothing
        _extCharla = Nothing
        _visitaPagina = Nothing
        _otroTema = Nothing
        _targeta = Nothing
    End Sub



End Class

