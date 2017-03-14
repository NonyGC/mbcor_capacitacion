Imports Capa_Datos
Imports Capa_Entidad

Public Class EncuestaCN
    Dim EstDao As New EncuestaDao

    Public Function Encuesta_Registrar(encCE As EncuestaCE) As Boolean
        Return EstDao.Encuesta_Registrar(encCE)
    End Function
End Class