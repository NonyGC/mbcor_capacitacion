Imports Capa_Datos

Public Class ReporteCN
    Dim repDao As New ReporteDAO
    Public Function cargarAutocompletado_buscar(rbtSelected As String) As DataTable
        Return repDao.cargarAutocompletado_buscar(rbtSelected)
    End Function

    Public Function getParticipanteByUbigeoCorreCel(ubigeo As String, correoCel As String) As DataTable
        Throw New NotImplementedException()
    End Function

    Public Function getParticipanteByUbigeo(ubigeo As String) As DataTable
        Throw New NotImplementedException()
    End Function

    Public Function getParticipanteByCorreo() As DataTable
        Throw New NotImplementedException()
    End Function

    Public Function getParticipanteByCelular() As DataTable
        Throw New NotImplementedException()
    End Function
End Class