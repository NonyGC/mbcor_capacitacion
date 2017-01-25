Imports Capa_Negocio
Imports Capa_Entidad
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Capa_Presentacion.Base
Public Class FrmParticipante_vb
    Dim LocalCN As New LocalCN, ParticipanteCE As New ParticipanteCE
    Dim ParticipanteCN As New ParticipanteCN
    Dim datadep As DataTable
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        RadMessageBox.SetThemeName("VisualStudio2012Light")
    End Sub
    Private Sub FrmParticipante_vb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datadep = New DataTable
        datadep = LocalCN.ubigeo_Departamento()
        cboDepartamento.DataSource = datadep
        cboDepartamento.DisplayMember = "Departamento"
        cboDepartamento.ValueMember = "idDep"
        cboDepartamento.SelectedIndex = -1

        'txtCodPart.Text = ParticipanteCN.participante_CodAutogenerado()

        cboOperadorM.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboEstadoCivil.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboDepartamento.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboProvincia.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboDistrito.DropDownListElement.AutoCompleteAppend.LimitToList = True
    End Sub
    Private Function GetGrpBxCheckedBbt(grpb As GroupBox) As RadioButton
        Dim rButton As RadioButton = grpb.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()
        Return rButton
    End Function

    Private Sub cboProvincia_Leave(sender As Object, e As EventArgs) Handles cboProvincia.Leave
        Dim idDep As String = Trim(cboDepartamento.SelectedValue)
        Dim idProv As String = Trim(cboProvincia.SelectedValue)
        If idDep IsNot String.Empty And idProv IsNot String.Empty Then
            idDep = cboDepartamento.SelectedValue
            cboDistrito.DataSource = LocalCN.ubigeo_Distrito(idDep, idProv)
            cboDistrito.ValueMember = "idDist"
            cboDistrito.DisplayMember = "Distrito"
        End If
    End Sub

    Private Sub cboDepartamento_Leave(sender As Object, e As EventArgs) Handles cboDepartamento.Leave
        Dim idDep As String = Trim(cboDepartamento.SelectedValue)
        If idDep IsNot String.Empty Then
            Dim codTel As String = datadep.Select("idDep=" & idDep)(0).ItemArray(2)
            txtCodtel1.Text = "(" & codTel & ")"
            txtCodtel2.Text = "(" & codTel & ")"
            txtCodtelM1.Text = "(" & codTel & ")"
            txtCodtelM2.Text = "(" & codTel & ")"
            cboProvincia.DataSource = LocalCN.ubigeo_Provincia(idDep)
            cboProvincia.ValueMember = "idProv"
            cboProvincia.DisplayMember = "Provincia"
        End If
    End Sub

    Private Sub txtTelFijo_KeyPress(sender As Object, e As KeyPressEventArgs)
        Solo_numeros(e)
    End Sub

    Private Sub cboDepartamento_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDepartamento.SelectedValueChanged
        cboProvincia.DataSource = Nothing
        cboDistrito.DataSource = Nothing
    End Sub

    Private Sub cboProvincia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedValueChanged
        cboDistrito.DataSource = Nothing
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

    End Sub


    'Sub limpiar()
    '    txtCodPart.Text = ParticipanteCN.participante_CodAutogenerado()
    '    cboDepartamento.SelectedIndex = -1
    'End Sub
    Function CodigoAuto(ap As String, am As String) As String
        Dim cod As String = If(Trim(ap) = String.Empty, "_", Trim(ap).Substring(0, 1)) & If(Trim(am) = String.Empty, "_", Trim(am).Substring(0, 1))
        Return cod
    End Function


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim codUbi As String = cboDepartamento.SelectedValue & cboProvincia.SelectedValue & cboDistrito.SelectedValue
        Dim fechaN As String
        fechaN = If(txtFechaN.Value = "__/__/____", String.Empty, txtFechaN.Value)

        With ParticipanteCE
            .codpart = CodigoAuto(txtApePat.Text, txtApeMat.Text)
            .dnice = Trim(txtDNICE.Text)
            .apePat = txtApePat.Text
            .apeMat = txtApeMat.Text
            .nombres = txtNombres.Text
            .fechaNaci = fechaN
            .EstadoCiv = cboEstadoCivil.Text
            .sexo = If(Not IsNothing(GetGrpBxCheckedBbt(grpSexo)), GetGrpBxCheckedBbt(grpSexo).Text, "")
            .direccion = txtDireccion.Text
            .ubigeo = codUbi
            .telFijo = txtCodtel1.Text & txtTelFijo.Text
            .telMovil = txtCodtelM1.Text & txtTelMovil.Text
            .opeMovil = cboOperadorM.Text
            .telFijo2 = txtCodtel2.Text & txtTelFijo2.Text
            .telMovil2 = txtCodtelM2.Text & txtTelMovil2.Text
            .opeMovil2 = cboOperadorM2.Text
            .correo = txtCorreo.Text
            .profeOcupa = txtProfesionOcupacion.Text
        End With

        Dim partEst As Boolean = If(ParticipanteCN.participante_upsert(ParticipanteCE), True, False)
        If partEst Then
            RadMessageBox.Show("SE REGISTRO CORRECTAMENTE", "", MessageBoxButtons.OK, RadMessageIcon.Info)
            Close()
        Else
            RadMessageBox.Show("OCURRIO UN ERROR,VUELVA A REGISTRAR", "", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If
    End Sub
End Class
