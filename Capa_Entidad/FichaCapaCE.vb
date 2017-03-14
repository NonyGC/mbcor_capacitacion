Public Class FichaCapaCE
    Private _codcap As String
    Private _codpart As String

    Public Property codcap As String
        Get
            Return _codcap
        End Get
        Set(ByVal value As String)
            _codcap = value
        End Set
    End Property

    Public Property codpart As String
        Get
            Return _codpart
        End Get
        Set(value As String)
            _codpart = value
        End Set
    End Property
End Class