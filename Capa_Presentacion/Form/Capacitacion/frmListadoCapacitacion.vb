Imports Capa_Negocio
Imports Capa_Entidad

Public Class FrmListadoCapacitacion
    Dim capCN As New CapacitacionCN
    Dim capEN As New CapacitacionCE
    Private Sub FrmListadoCapacitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCapacitacion.DataSource = capCN.Capacitacion_table()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim frm As New frmCapacitacion()
        If frm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            dgvCapacitacion.DataSource = capCN.Capacitacion_table()
        End If
        frm.Dispose()

    End Sub

    Private Sub dgvCapacitacion_CellDoubleClick_1(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvCapacitacion.CellDoubleClick

        With dgvCapacitacion.CurrentRow
            capEN.codigo = .Cells("codigo").Value
            capEN.origen = .Cells("origen").Value
            capEN.origenOtro = .Cells("origOtro").Value
            capEN.organizador = .Cells("organizador").Value
            capEN.local = .Cells("lcod").Value
            capEN.fecha = .Cells("fecha").Value
            capEN.cantMasisa = .Cells("cantMasisa").Value
            capEN.cantIngresada = .Cells("cantIngresada").Value
            capEN.tema = .Cells("tema").Value
            capEN.expositor = .Cells("expositor").Value
        End With

        Dim frm As New frmCapacitacion(capEN)

        If frm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            dgvCapacitacion.DataSource = capCN.Capacitacion_table()
        End If

        frm.Dispose()

    End Sub
End Class
