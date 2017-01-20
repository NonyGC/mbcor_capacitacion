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
    End Sub

    Private Sub cboDepartamento_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDepartamento.SelectedValueChanged
        Try
            idDep = cboDepartamento.SelectedValue.ToString
            If (idDep <> "System.Data.DataRowView") Then
                cboProvincia.DataSource = localCN.ubigeo_Provincia(idDep)
                cboProvincia.ValueMember = "idProv"
                cboProvincia.DisplayMember = "Provincia"
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cboProvincia.SelectedIndexChanged
        Try
            idProv = cboProvincia.SelectedValue.ToString
            If (idProv <> "System.Data.DataRowView") Then
                idDep = cboDepartamento.SelectedValue.ToString
                cboDistrito.DataSource = localCN.ubigeo_Distrito(idDep, idProv)
                cboDistrito.ValueMember = "idDist"
                cboDistrito.DisplayMember = "Distrito"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim codUbi As String = cboDepartamento.SelectedValue & cboProvincia.SelectedValue & cboDistrito.SelectedValue
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
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub



    Sub Limpiar()
        txtCodigo.Text = localCN.Local_CodAutogenerado()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtAforo.Value = 0
        cboDepartamento.SelectedIndex = 0
    End Sub


End Class
