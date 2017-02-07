Imports Capa_Datos
Imports Capa_Entidad
Public Class ParticipanteCN
    Dim partDAO As New ParticipanteDAO
    Public Function participante_insert(part As ParticipanteCE) As Boolean
        Return partDAO.participante_insert(part)
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

    Public Function cargarAutocompletado_buscar(rbtSelected As String) As Object
        Return partDAO.cargarAutocompletado_buscar(rbtSelected)
    End Function

    Public Function obtUltimoCodigoPart(codpart As String) As String
        Return partDAO.obtUltimoCodigoPart(codpart)
    End Function

    'Public Function FiltarParticipante(rbtSelected As String) As DataTable
    '    Return partDAO.FiltarParticipante(rbtSelected)
    'End Function

    Public Function FiltarParticipanteApeNom(text As String) As DataTable
        Return partDAO.FiltarParticipanteApeNom(text)
    End Function

    Public Function FiltarParticipanteLocal(selectedValue As Object) As DataTable
        Return partDAO.FiltarParticipanteLocal(selectedValue)
    End Function

    Public Function FiltarParticipanteOrigen(SelectedText As Object) As DataTable
        Return partDAO.FiltarParticipanteOrigen(SelectedText)
    End Function

    Public Function FiltarParticipanteLocalFecha(selectedValue As Object, dateini As String, datefin As String) As Object
        Return partDAO.FiltarParticipanteLocalFecha(selectedValue, dateini, datefin)
    End Function

    Public Function FiltarParticipanteOrigenFecha(selectedValue As Object, dateini As String, datefin As String) As Object
        Return partDAO.FiltarParticipanteOrigenFecha(selectedValue, dateini, datefin)
    End Function
End Class
