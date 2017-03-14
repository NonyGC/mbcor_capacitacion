Imports Capa_Negocio
Imports Capa_Entidad
Imports Telerik.WinControls
Imports System.Windows.Forms

Public Class frmLocal
    Dim localCN As New LocalCN
    Dim LocalCE As New LocalCE
    Dim idDep As String, idProv As String
    Private Sub frmLocal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadMessageBox.SetThemeName("VisualStudio2012Light")
        txtCodigo.Text = localCN.Local_CodAutogenerado()
        cboDepartamento.DataSource = localCN.ubigeo_Departamento()
        cboDepartamento.DisplayMember = "Departamento"
        cboDepartamento.ValueMember = "idDep"
        ubigeoPredeterminado()

        cboDepartamento.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboProvincia.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboDistrito.DropDownListElement.AutoCompleteAppend.LimitToList = True
    End Sub

    Private Sub cboProvincia_Leave(sender As Object, e As EventArgs) Handles cboProvincia.Leave
        cargarUbigeoDistrito()
    End Sub
    Sub ubigeoPredeterminado()
        cboDepartamento.SelectedValue = "15"
        cargarUbigeoProvincia()
        cargarUbigeoDistrito()
        cboDistrito.SelectedIndex = -1
    End Sub
    Sub cargarUbigeoProvincia()
        Dim idDep As String = Trim(cboDepartamento.SelectedValue)
        If idDep IsNot String.Empty Then
            cboProvincia.DataSource = localCN.ubigeo_Provincia(idDep)
            cboProvincia.ValueMember = "idProv"
            cboProvincia.DisplayMember = "Provincia"
        End If
    End Sub
    Sub cargarUbigeoDistrito()
        Dim idDep As String = Trim(cboDepartamento.SelectedValue)
        Dim idProv As String = Trim(cboProvincia.SelectedValue)
        If idDep IsNot String.Empty And idProv IsNot String.Empty Then
            idDep = cboDepartamento.SelectedValue
            cboDistrito.DataSource = localCN.ubigeo_Distrito(idDep, idProv)
            cboDistrito.ValueMember = "idDist"
            cboDistrito.DisplayMember = "Distrito"
        End If
    End Sub
    Private Sub cboDepartamento_Leave(sender As Object, e As EventArgs) Handles cboDepartamento.Leave
        cargarUbigeoProvincia()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If Trim(txtNombre.Text).Length > 0 Then
            Dim dep As String = If(cboDepartamento.SelectedValue Is Nothing, "00", cboDepartamento.SelectedValue)
            Dim pro As String = If(cboProvincia.SelectedValue Is Nothing, "00", cboProvincia.SelectedValue)
            Dim dis As String = If(cboDistrito.SelectedValue Is Nothing, "00", cboDistrito.SelectedValue)
            Dim codUbi As String = dep & pro & dis
            With LocalCE
                .codigo = txtCodigo.Text
                .nombre = txtNombre.Text
                .direccion = txtDireccion.Text
                .codUbigeo = codUbi
                .aforo = txtAforo.Value
            End With
            If (localCN.Registrar(LocalCE)) Then
                RadMessageBox.Show("SE REGISTRO CORRECTAMENTE", "", MessageBoxButtons.OK, RadMessageIcon.Info)
                Limpiar()
            Else
                RadMessageBox.Show("OCURRIO UN ERROR,VUELVA A REGISTRAR", "", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If
        Else
            RadMessageBox.Show("DATOS INCOMPLETOS", "", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub cboDepartamento_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDepartamento.SelectedValueChanged
        cboProvincia.DataSource = Nothing
        cboDistrito.DataSource = Nothing
    End Sub

    Private Sub cboProvincia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedValueChanged
        cboDistrito.DataSource = Nothing
    End Sub

    Sub Limpiar()
        txtCodigo.Text = localCN.Local_CodAutogenerado()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtAforo.Value = 0
        cboDepartamento.SelectedIndex = -1
    End Sub

End Class