Imports Capa_Datos

Public Class ReporteCN
    Dim repDao As New ReporteDAO
    Public Function cargarAutocompletado_buscar(rbtSelected As String) As DataTable
        Return repDao.cargarAutocompletado_buscar(rbtSelected)
    End Function
End Class
