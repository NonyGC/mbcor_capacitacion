Imports Capa_Negocio
Imports Capa_Entidad
Imports System.Windows.Forms
Public Class FrmLocalListado
    Dim LocalCN As New LocalCN
    Dim LocalEN As New LocalCE
    Private Sub FrmLocalListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgLocalFill()
    End Sub
    Sub dtgLocalFill()
        dtgLocal.DataSource = LocalCN.getTableLocal()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm As New frmLocal()

        If frm.ShowDialog = DialogResult.OK Then
            dtgLocalFill()
        End If
        frm.Dispose()
    End Sub

    Private Sub dtgLocal_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgLocal.CellDoubleClick
        With dtgLocal.CurrentRow
            LocalEN.codigo = .Cells("codigo").Value
            LocalEN.nombre = .Cells("nombre").Value
            LocalEN.direccion = .Cells("direccion").Value
            LocalEN.aforo = .Cells("aforo").Value
            LocalEN.codUbigeo = .Cells("ubigeo").Value
        End With
        Dim frm As New frmLocal(LocalEN)
        If frm.ShowDialog = DialogResult.OK Then
            dtgLocalFill()
        End If
        frm.Dispose()

    End Sub
End Class
