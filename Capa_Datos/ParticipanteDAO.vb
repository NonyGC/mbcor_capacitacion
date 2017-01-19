Imports System.Data.SqlClient
Imports Capa_Entidad
Public Class ParticipanteDAO
    Inherits BaseDao
    Public Function participante_CodAutogenerado() As String
        Dim cmd As SqlCommand = CommandProcedure("sp_codigoautogenerado_participante")
        Dim codigo As String
        codigo = cmd.ExecuteScalar
        Return codigo
    End Function

    Public Function participanteUpsert(part As ParticipanteCE) As Boolean
        Try
            Dim i As Integer
            Dim cmd As SqlCommand = CommandProcedure("spParticipante_upsert")
            With part
                cmd = Parameters(cmd, { .codpart, .apePat, .apeMat, .nombres, .sexo, .fechaNaci, .dnice, .direccion, .ubigeo, .telFijo, .telMovil, .opeMovil, .correo, .EstadoCiv})
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
