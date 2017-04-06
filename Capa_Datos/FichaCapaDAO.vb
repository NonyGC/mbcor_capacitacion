Imports System.Data.SqlClient
Imports Capa_Entidad
Public Class FichaCapaDAO
    Inherits BaseDao

    Dim conn As New SqlConnection

    Public Function fichaCapacitacion_Capacitacion() As DataTable
        Dim tbl As New DataTable
        Dim cmd As SqlCommand = CommandProcedure("uspCapacitacion_getRegisteredLocal")
        tbl = GetDataTable(cmd)
        Return tbl
    End Function

    Public Function fichaCapacitacion_ParticipanteAutocomplete() As DataTable
        Dim tbl As New DataTable
        Dim cmd As SqlCommand = CommandProcedure("spParticipante_getSearch")
        tbl = GetDataTable(cmd)
        Return tbl
    End Function

    Public Function fichaRegistrar(fch As FichaCapaCE) As Boolean
        Try
            Dim i As Integer
            Dim cmd As SqlCommand = CommandProcedure("spfichaCapacitacion_create")
            With fch
                cmd = Parameters(cmd, { .codcap, .codpart})
            End With
            i = cmd.ExecuteNonQuery
            Return If(i > 0, True, False)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            CloseDB()
        End Try
    End Function

    Public Function fichaCapacitacion_ParticipanteCargar(v As String) As DataTable
        Dim tbl As New DataTable
        Dim cmd As SqlCommand = CommandText("SELECT * FROM participante WHERE codigo=@cod")
        cmd.Parameters.AddWithValue("@cod", v)
        tbl = GetDataTable(cmd)
        Return tbl
    End Function

End Class