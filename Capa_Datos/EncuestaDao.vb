Imports System.Data.SqlClient
Imports Capa_Entidad

Public Class EncuestaDao
    Inherits BaseDao
    Public Function Encuesta_Registrar(encCE As EncuestaCE) As Boolean
        Try
            Dim i As Integer
            Dim cmd As SqlCommand = CommandProcedure("spEncuesta_insert")
            With encCE
                cmd = Parameters(cmd, { .codcap, .charla, .espCharla, .dominioTem, .dejaEntender, .fueInteresante, .extCharla, .visitaPagina, .otroTema, .targeta})
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
End Class