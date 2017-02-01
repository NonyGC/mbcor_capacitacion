Imports Capa_Datos
Imports Capa_Entidad
Public Class ParticipanteCN
    Dim partDAO As New ParticipanteDAO
    Public Function participante_upsert(part As ParticipanteCE) As Boolean
        Return partDAO.participanteUpsert(part)
    End Function

    Public Function CargarParticipante() As DataTable
        Return partDAO.participante_table()
    End Function

    Public Function participante_CodAutogenerado() As String
        Return partDAO.participante_CodAutogenerado()
    End Function

    Public Function participante_cargarCapacitacion() As Object
        Return partDAO.participante_cargarCapacitacion()
    End Function

    Public Function participante_update(part As ParticipanteCE) As Boolean
        Return partDAO.participanteUpdate(part)
    End Function
End Class
