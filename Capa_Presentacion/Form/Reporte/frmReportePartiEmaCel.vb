Imports Capa_Negocio

Public Class FrmReporte_Parti_EmaCel
    Dim rptCN As New ReporteCN
    Dim LocalCN As New LocalCN
    Private Sub FrmReporte_Parti_EmaCel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDepartamento.DataSource = LocalCN.ubigeo_Departamento()
        cboDepartamento.DisplayMember = "Departamento"
        cboDepartamento.ValueMember = "idDep"
        cboDepartamento.SelectedIndex = -1
    End Sub
    Sub cargarUbigeoProvincia()
        Dim idDep As String = Trim(cboDepartamento.SelectedValue)
        If idDep IsNot String.Empty Then
            cboProvincia.DataSource = LocalCN.ubigeo_Provincia(idDep)
            cboProvincia.ValueMember = "idProv"
            cboProvincia.DisplayMember = "Provincia"
        End If
    End Sub
    Sub cargarUbigeoDistrito()
        Dim idDep As String = Trim(cboDepartamento.SelectedValue)
        Dim idProv As String = Trim(cboProvincia.SelectedValue)
        If idDep IsNot String.Empty And idProv IsNot String.Empty Then
            idDep = cboDepartamento.SelectedValue
            cboDistrito.DataSource = LocalCN.ubigeo_Distrito(idDep, idProv)
            cboDistrito.ValueMember = "idDist"
            cboDistrito.DisplayMember = "Distrito"
        End If
    End Sub

    Private Sub cboProvincia_Enter(sender As Object, e As EventArgs) Handles cboProvincia.Enter
        cargarUbigeoProvincia()
    End Sub

    Private Sub cboDistrito_Enter(sender As Object, e As EventArgs) Handles cboDistrito.Enter
        cargarUbigeoDistrito()
    End Sub
    Private Sub cboDepartamento_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDepartamento.SelectedValueChanged
        cboProvincia.DataSource = Nothing
        cboDistrito.DataSource = Nothing
    End Sub

    Private Sub cboProvincia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedValueChanged
        cboDistrito.DataSource = Nothing
    End Sub
End Class
