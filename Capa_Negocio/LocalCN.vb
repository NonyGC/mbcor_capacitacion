Imports Capa_Datos
Imports Capa_Entidad
Public Class LocalCN

    Dim LDAO As New LocalDAO
    Public Function Local_CodAutogenerado() As String
        Return LDAO.Local_CodAutogenerado()
    End Function
    Public Function ubigeo_Departamento() As DataTable
        Return LDAO.ubigeo_Depatamento()
    End Function
    Public Function ubigeo_Provincia(idDep As String) As DataTable
        Return LDAO.ubigeo_Provincia(idDep)
    End Function
    Public Function ubigeo_Distrito(idDep As String, idProv As String) As DataTable
        Return LDAO.ubigeo_Distrito(idDep, idProv)
    End Function
    Public Function Registrar(Loc As LocalCE) As Boolean
        Return LDAO.Registrar(Loc)
    End Function
End Class