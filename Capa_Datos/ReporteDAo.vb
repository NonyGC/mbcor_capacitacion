Imports System.Data.SqlClient

Public Class ReporteDAO
    Inherits BaseDao
    Public Function cargarAutocompletado_buscar(rbtSelected As String) As DataTable
        Dim cmd As New SqlCommand
        Dim data As New DataTable
        If rbtSelected = "LOCAL" Then
            cmd = CommandText("SELECT codigo,nombre FROM local")
        ElseIf rbtSelected = "ORIGEN" Then
            cmd = CommandText("SELECT DISTINCT CASE WHEN origen='Otros' THEN origen+' '+origOtro ELSE origen END AS nombre FROM capacitacion")
        End If
        data = GetDataTable(cmd)
        Return data
    End Function
End Class