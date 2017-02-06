Imports Capa_Entidad
Imports Capa_Negocio
Imports Capa_Presentacion.Base

Public Class FrmReporteParticipante
    Dim ParticipanteCN As New ParticipanteCN
    Dim PartCE As New ParticipanteCE
    Private Sub FrmReporteParticipante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgParticipante.DataSource = ParticipanteCN.CargarParticipante()
        dtgParticipante.MasterTemplate.ShowFilterCellOperatorText = False
    End Sub

    Private Sub cboBuscar_Enter(sender As Object, e As EventArgs) Handles cboBuscar.Enter
        Dim rbtSelected As String = If(Not IsNothing(GetGrpBxCheckedBbt(gpbTipBusqueda)), GetGrpBxCheckedBbt(gpbTipBusqueda).Text, "")
        If rbtSelected IsNot String.Empty Then
            cboBuscar.DataSource = ParticipanteCN.cargarAutocompletado_buscar(rbtSelected)
        End If
    End Sub

    Private Sub rbtApeNom_CheckedChanged(sender As Object, e As EventArgs) Handles rbtApeNom.CheckedChanged
        txtFechaini.Value = "__/__/____"
        txtFechafin.Value = "__/__/____"
    End Sub

    Private Sub rbtLocal_CheckedChanged(sender As Object, e As EventArgs) Handles rbtLocal.CheckedChanged
        gpbFecha.Enabled = If(rbtLocal.Checked, True, False)
    End Sub

    Private Sub rbtOrigen_CheckedChanged(sender As Object, e As EventArgs) Handles rbtOrigen.CheckedChanged
        gpbFecha.Enabled = If(rbtOrigen.Checked, True, False)
    End Sub
End Class
