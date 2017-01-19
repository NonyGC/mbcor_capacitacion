Imports Capa_Datos
Imports Capa_Entidad

Public Class CapacitacionCN
    Dim CDAO As New CapacitacionDAO
    Public Function capacitacion_CodAutogenerado() As String
        Return CDAO.capacitacion_CodAutogenerado()
    End Function
    Public Function obtenerLocal() As DataTable
        Return CDAO.obtenerLocal()
    End Function
    Public Function registrar(cap As CapacitacionCE) As Boolean
        Return CDAO.Registrar(cap)
    End Function
End Class
