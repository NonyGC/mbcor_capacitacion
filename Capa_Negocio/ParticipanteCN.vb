Imports Capa_Datos
Imports Capa_Entidad
Public Class ParticipanteCN
    Dim partDAO As New ParticipanteDAO
    Public Function participante_upsert(part As ParticipanteCE) As Boolean
        Return partDAO.participanteUpsert(part)
    End Function
    Public Function participante_CodAutogenerado() As String
        Return partDAO.participante_CodAutogenerado()
    End Function
End Class
