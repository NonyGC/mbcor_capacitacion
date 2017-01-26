Imports Capa_Entidad
Imports System.Data.SqlClient
Public Class CapacitacionDAO
    Inherits BaseDao

    Dim conn As New SqlConnection

    Public Function capacitacion_CodAutogenerado() As String
        conn = conectar()
        Dim cmd As SqlCommand = CommandProcedure("sp_codigoautogenerado_capacitacion")
        Dim codigo As String
        codigo = cmd.ExecuteScalar
        Return codigo
    End Function

    Public Function Capacitacion_table() As DataTable
        Dim cmd As SqlCommand = CommandText("SELECT C.codigo,origen,origOtro,organizador,L.nombre local,cantMasisa,cantIngresada,fecha,tema,expositor,estado FROM capacitacion C INNER JOIN local L ON C.local=L.codigo")
        Dim data As New DataTable
        data = GetDataTable(cmd)
        Return data
    End Function

    Public Function obtenerLocal() As DataTable
        Dim cmd As SqlCommand = CommandText("SELECT codigo,nombre FROM local")
        Dim data As New DataTable
        data = GetDataTable(cmd)
        Return data
    End Function
    Public Function Registrar(cap As CapacitacionCE) As Boolean
        Try
            Dim i As Integer
            Dim cmd As SqlCommand = CommandText("INSERT INTO capacitacion (codigo, origen, origOtro, organizador, local, cantMasisa, cantIngresada, fecha, tema, expositor, estado) VALUES (@cod, @ori, @oriotro, @org, @loc, @cantMa, @cantIngr, @fec, @tma, @exp, '')")
            With cmd.Parameters
                .AddWithValue("@cod", cap.codigo) : .AddWithValue("@ori", cap.origen)
                .AddWithValue("@oriotro", cap.origenOtro) : .AddWithValue("@org", cap.organizador)
                .AddWithValue("@loc", cap.local) : .AddWithValue("@cantMa", cap.cantMasisa)
                .AddWithValue("@cantIngr", cap.cantIngresada) : .AddWithValue("@fec", cap.fecha)
                .AddWithValue("@tma", cap.tema) : .AddWithValue("@exp", cap.expositor)
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
