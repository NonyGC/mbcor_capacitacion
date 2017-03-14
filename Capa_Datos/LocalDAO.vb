Imports System.Data.SqlClient
Imports System.Drawing
Imports Capa_Entidad

Public Class LocalDAO
    Inherits BaseDao
    Public Function Local_CodAutogenerado() As String
        Dim cmd As SqlCommand = CommandProcedure("sp_codigoautogenerado_local")
        Dim codigo As String
        codigo = cmd.ExecuteScalar
        Return codigo
    End Function
    Public Function ubigeo_Depatamento() As DataTable
        Dim dtDepartamento As New DataTable
        Dim cmd As SqlCommand = CommandText("SELECT idDep,Departamento,codTelef FROM ubDepartamento")
        dtDepartamento = GetDataTable(cmd)
        Return dtDepartamento
    End Function
    Public Function ubigeo_Provincia(idDep As String) As DataTable
        Dim dtProvincia As New DataTable
        Dim cmd As SqlCommand = CommandText("SELECT idProv,idDep,Provincia FROM ubProvincia where idDep=@idDep")
        cmd.Parameters.AddWithValue("@idDep", idDep)
        dtProvincia = GetDataTable(cmd)
        Return dtProvincia
    End Function
    Public Function ubigeo_Distrito(idDep As String, idProv As String) As DataTable
        Dim dtDistrito As New DataTable
        Dim cmd As SqlCommand = CommandText("SELECT idDist,idProv,idDep,Distrito FROM ubDistrito WHERE idDep=@idDep and idProv=@idPro")
        cmd.Parameters.AddWithValue("@idDep", idDep)
        cmd.Parameters.AddWithValue("@idPro", idProv)
        dtDistrito = GetDataTable(cmd)
        Return dtDistrito
    End Function
    Public Function Registrar(Loc As LocalCE) As Boolean
        Try
            Dim i As Integer
            Dim cmd As SqlCommand = CommandText("INSERT INTO local (codigo, nombre, direccion, aforo, ubigeo) VALUES (@cod, @nom, @dir, @afo, @ubi)")
            With cmd.Parameters
                .AddWithValue("@cod", Loc.codigo) : .AddWithValue("@nom", Loc.nombre)
                .AddWithValue("@dir", Loc.direccion) : .AddWithValue("@afo", Loc.aforo)
                .AddWithValue("@ubi", Loc.codUbigeo)
            End With
            i = cmd.ExecuteNonQuery
            Return If(i > 0, True, False)
        Catch ex As Exception
            Return False
        Finally
            CloseDB()
        End Try
    End Function

End Class