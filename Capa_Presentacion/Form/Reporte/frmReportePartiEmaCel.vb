Imports Capa_Negocio
Imports Capa_Presentacion.Base

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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim ubigeo As String = obtenerUbigeoCbo()
        Dim chbChecked As String = getCheckboxVal(gbCorreoCelular)

        FiltrarParitipantes(ubigeo, chbChecked)

    End Sub
    Sub FiltrarParitipantes(ByVal ubigeo As String, Optional ByVal CorreoCel As String = Nothing)
        If ubigeo = String.Empty And CorreoCel Is Nothing Then Return

        If ubigeo IsNot String.Empty And CorreoCel.Contains("CORREO") Then
            dtgParticipante.DataSource = rptCN.getParticipanteByUbigeoCorreCel(ubigeo, "CORREO")
        ElseIf ubigeo IsNot String.Empty And CorreoCel.Contains("CELULAR") Then
            dtgParticipante.DataSource = rptCN.getParticipanteByUbigeoCorreCel(ubigeo, "CELULAR")
        ElseIf ubigeo IsNot String.Empty Then
            dtgParticipante.DataSource = rptCN.getParticipanteByUbigeo(ubigeo)
        ElseIf CorreoCel.Contains("CORREO") Then
            dtgParticipante.DataSource = rptCN.getParticipanteByCorreo()
        ElseIf CorreoCel.Contains("CELULAR") Then
            dtgParticipante.DataSource = rptCN.getParticipanteByCelular()
        End If
    End Sub
    Function obtenerUbigeoCbo() As String
        Dim ubigeo As String
        ubigeo = cboDepartamento.SelectedValue & cboProvincia.SelectedValue & cboDistrito.SelectedValue
        Return ubigeo
    End Function
End Class