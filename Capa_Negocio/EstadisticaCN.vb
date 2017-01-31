Imports Capa_Datos
Public Class EstadisticaCN
    Dim EstDao As New EstadisticaDao
    Public Function Estadistica_PartiLocal() As DataTable
        Return EstDao.Estadistica_PartiLocal()
    End Function
End Class
