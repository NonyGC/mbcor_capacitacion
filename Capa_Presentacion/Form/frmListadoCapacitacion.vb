Imports Capa_Negocio

Public Class FrmListadoCapacitacion
    Dim capCN As New CapacitacionCN

    Private Sub FrmListadoCapacitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCapacitacion.DataSource = capCN.Capacitacion_table()
    End Sub

    Private Sub dgvCapacitacion_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvCapacitacion.CellClick
        With dgvCapacitacion.CurrentRow
            lblCodigo.Text = .Cells("Cod").Value
            txtOrigen.Text = .Cells("origen").Value
            txtOrigenOtro.Text = .Cells("origOtro").Value
            txtOrganizador.Text = .Cells("organizador").Value
            txtLocal.Text = .Cells("local").Value
            txtFecha.Text = .Cells("fecha").Value
            txtCantMasisa.Text = .Cells("cantMasisa").Value
            txtCantIngresada.Text = .Cells("cantIngresada").Value
            txtTema.Text = .Cells("tema").Value
            txtExpositor.Text = .Cells("expositor").Value
        End With
    End Sub

End Class
