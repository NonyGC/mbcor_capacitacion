Imports Capa_Negocio

Public Class FrmListParticipante
    Dim ParticipanteCN As New ParticipanteCN

    Private Sub FrmListParticipante_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgParticipantes.DataSource = ParticipanteCN.participante_table()
    End Sub


End Class
