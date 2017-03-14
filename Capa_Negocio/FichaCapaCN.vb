Imports Capa_Datos
Imports Capa_Entidad
Public Class FichaCapaCN
    Dim FichDAO As New FichaCapaDAO
    Public Function fichaCapacitacion_Capacitacion() As DataTable
        Return FichDAO.fichaCapacitacion_Capacitacion()
    End Function
    Public Function fichaCapacitacion_Registrar(fich As FichaCapaCE) As Boolean
        Return FichDAO.fichaRegistrar(fich)
    End Function

    Public Function fichaCapacitacion_ParticipanteAutocomplete() As DataTable
        Return FichDAO.fichaCapacitacion_ParticipanteAutocomplete()
    End Function

    Public Function fichaCapacitacion_ParticipanteCargar(v As String) As DataTable
        Return FichDAO.fichaCapacitacion_ParticipanteCargar(v)
    End Function
End Class