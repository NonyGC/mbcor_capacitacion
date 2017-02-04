Imports Capa_Entidad
Imports Capa_Negocio

Public Class FrmReporteParticipante
    Dim ParticipanteCN As New ParticipanteCN
    Dim PartCE As New ParticipanteCE
    Private Sub FrmReporteParticipante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgParticipante.DataSource = ParticipanteCN.CargarParticipante()
        dtgParticipante.MasterTemplate.ShowFilterCellOperatorText = False
    End Sub

    Private Sub rbtBuscar_Click(sender As Object, e As EventArgs) Handles rbtBuscar.Click

    End Sub
End Class
