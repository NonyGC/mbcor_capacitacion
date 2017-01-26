Imports Capa_Negocio

Public Class FrmListadoCapacitacion
    Dim capCN As New CapacitacionCN

    Private Sub FrmListadoCapacitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCapacitacion.DataSource = capCN.Capacitacion_table()
    End Sub
End Class
