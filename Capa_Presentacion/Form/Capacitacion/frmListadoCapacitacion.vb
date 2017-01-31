Imports Capa_Negocio
Imports Capa_Entidad

Public Class FrmListadoCapacitacion
    Dim capCN As New CapacitacionCN
    Dim capEN As New CapacitacionCE
    Private Sub FrmListadoCapacitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCapacitacion.DataSource = capCN.Capacitacion_table()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmCapacitacion.Show()
    End Sub

    'Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    'End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        dgvCapacitacion.DataSource = capCN.Capacitacion_table()
    End Sub

    Private Sub dgvCapacitacion_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs)

    End Sub

    Private Sub dgvCapacitacion_CellDoubleClick_1(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvCapacitacion.CellDoubleClick
        With dgvCapacitacion.CurrentRow
            capEN.codigo = .Cells("codigo").Value
            capEN.origen = .Cells("origen").Value
            capEN.origenOtro = .Cells("origOtro").Value
            capEN.organizador = .Cells("organizador").Value
            capEN.local = .Cells("local").Value
            capEN.fecha = .Cells("fecha").Value
            capEN.cantMasisa = .Cells("cantMasisa").Value
            capEN.cantIngresada = .Cells("cantIngresada").Value
            capEN.tema = .Cells("tema").Value
            capEN.expositor = .Cells("expositor").Value
        End With
        Dim frm As New frmCapacitacion(capEN)
        frm.Show()
    End Sub

    'Private Sub dgvCapacitacion_DoubleClick(sender As Object, e As EventArgs) Handles dgvCapacitacion.DoubleClick
    '    With dgvCapacitacion.CurrentRow
    '        capEN.codigo = .Cells("Cod").Value
    '        capEN.origen = .Cells("origen").Value
    '        capEN.origenOtro = .Cells("origOtro").Value
    '        capEN.organizador = .Cells("organizador").Value
    '        capEN.local = .Cells("local").Value
    '        capEN.fecha = .Cells("fecha").Value
    '        capEN.cantMasisa = .Cells("cantMasisa").Value
    '        capEN.cantIngresada = .Cells("cantIngresada").Value
    '        capEN.tema = .Cells("tema").Value
    '        capEN.expositor = .Cells("expositor").Value
    '    End With
    '    Dim frm As New frmCapacitacion(capEN)
    '    frm.Show()
    'End Sub
End Class
