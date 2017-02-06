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

    Public Function participante_table() As DataTable
        Dim cmd As SqlCommand = CommandText("SELECT *  FROM participante")
        Dim data As New DataTable
        data = GetDataTable(cmd)
        Return data
    End Function

    Public Function participante_cargarCapacitacion() As Object
        Dim cmd As SqlCommand = CommandText("SELECT c.codigo,l.nombre,fecha,c.origen,c.origOtro,organizador FROM	capacitacion c inner join local l on c.local=l.codigo")
        Dim data As New DataTable
        data = GetDataTable(cmd)
        Return data
    End Function

    Public Function cargarAutocompletado_buscar(rbtSelected As String) As Object
        Throw New NotImplementedException()
    End Function

    Public Function obtUltimoCodigoPart(codpart As String) As String
        Dim cmd As SqlCommand = CommandProcedure("sp_codigoauto_partul")
        cmd = Parameters(cmd, {codpart})
        Return cmd.ExecuteScalar
    End Function

    Public Function participante_insert(part As ParticipanteCE) As Boolean
        'Try
        Dim i As Integer
        Dim cmd As SqlCommand = CommandProcedure("spParticipante_insert")
        With part
            cmd = Parameters(cmd, { .codpart, .apePat, .apeMat, .nombres, .sexo, .fechaNaci, .dnice, .direccion, .ubigeo, .telFijo, .telMovil, .opeMovil, .telFijo2, .telMovil2, .opeMovil2, .correo, .EstadoCiv, .profeOcupa})
        End With
        i = cmd.ExecuteNonQuery
        Return If(i > 0, True, False)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Return False
        'Finally
        '    CloseDB()
        'End Try
    End Function

    Public Function participanteUpdate(part As ParticipanteCE) As Boolean
        Try
            Dim i As Integer
            Dim cmd As SqlCommand = CommandProcedure("spParticipante_update")
            With part
                cmd = Parameters(cmd, { .codpart, .apePat, .apeMat, .nombres, .sexo, .fechaNaci, .dnice, .direccion, .ubigeo, .telFijo, .telMovil, .opeMovil, .telFijo2, .telMovil2, .opeMovil2, .correo, .EstadoCiv, .profeOcupa})
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
