Imports Capa_Entidad
Imports Capa_Negocio

Public Class FrmListParticipante
    Dim ParticipanteCN As New ParticipanteCN
    Dim ParticipanteCE As New ParticipanteCE

    Private Sub FrmListParticipante_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgParticipantes.DataSource = ParticipanteCN.participante_table()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmParticipante_vb.Show()
        'Debug.WriteLine(result)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        FrmParticipante_vb.ShowDialog()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        dtgParticipantes.DataSource = ParticipanteCN.participante_table()
    End Sub
End Class
