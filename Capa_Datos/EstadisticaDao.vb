Imports System.Data.SqlClient
Public Class EstadisticaDao
    Inherits BaseDao
    Public Function Estadistica_PartiLocal() As DataTable
        Dim cmd As SqlCommand = CommandText("Select f.codcap codcap,l.nombre nombre,c.fecha fecha,count(*) cantidad from ficha_capacitacion f inner join capacitacion c On f.codcap=c.codigo inner join local l On c.local=l.codigo group by codcap,fecha,nombre")
        Dim dt As New DataTable
        dt = GetDataTable(cmd)
        Return dt
    End Function
End Class
