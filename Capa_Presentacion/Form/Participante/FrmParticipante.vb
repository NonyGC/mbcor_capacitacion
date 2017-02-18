Imports Capa_Negocio
Imports Capa_Entidad
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Capa_Presentacion.Base
Public Class FrmParticipante_vb
    Dim LocalCN As New LocalCN, ParticipanteCE As New ParticipanteCE
    Dim ParticipanteCN As New ParticipanteCN
    Dim datadep As DataTable
    Dim partEst As Boolean
    Private partCE As ParticipanteCE
    Private Value As Integer

    Enum Initialize
        ini = 0
        upd = 1
    End Enum
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        RadMessageBox.SetThemeName("VisualStudio2012Light")
        Value = 0
        btnGuardar.DialogResult = DialogResult.OK
    End Sub

    Public Sub New(partCE As ParticipanteCE)
        InitializeComponent()
        RadMessageBox.SetThemeName("VisualStudio2012Light")
        Me.partCE = partCE
        Value = 1
        btnGuardar.DialogResult = DialogResult.OK
    End Sub

    Private Sub FrmParticipante_vb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datadep = New DataTable
        datadep = LocalCN.ubigeo_Departamento()
        cboDepartamento.DataSource = datadep
        cboDepartamento.DisplayMember = "Departamento"
        cboDepartamento.ValueMember = "idDep"
        Select Case Value
            Case Initialize.ini
                cboDepartamento.SelectedIndex = -1
            Case Initialize.upd
                cargarDat_Actualizacion()
        End Select
        limitarLista_Autocompletado()
    End Sub
    Sub limitarLista_Autocompletado()
        cboOperadorM.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboEstadoCivil.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboDepartamento.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboProvincia.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboDistrito.DropDownListElement.AutoCompleteAppend.LimitToList = True
    End Sub
    Sub cargarDat_Actualizacion()

        With partCE
            txtApePat.Text = .apePat
            txtApeMat.Text = .apeMat
            txtNombres.Text = .nombres
            txtDNICE.Text = .dnice
            If (M.Name = .sexo) Then M.Checked = True
            If (F.Name = .sexo) Then F.Checked = True
            txtDireccion.Text = .direccion
            'LOAD CBO UBIGEO
            Dim dep As String = (partCE.ubigeo).Substring(0, 2)
            If Trim(dep).Length > 0 Then cboDepartamento.SelectedValue = dep Else cboDepartamento.SelectedIndex = -1
            loadProvincia()
            Dim pro As String = (partCE.ubigeo).Substring(2, 2)
            If Trim(pro).Length > 0 Then cboProvincia.SelectedValue = pro Else cboProvincia.SelectedIndex = -1
            loadDistrito()
            Dim dis As String = (partCE.ubigeo).Substring(4, 2)
            If Trim(dis).Length > 0 Then cboDistrito.SelectedValue = dis Else cboDistrito.SelectedIndex = -1
            If cboDepartamento.SelectedValue <> "15" Then
                txtTelFijo.Mask = "000-000"
                txtTelFijo2.Mask = "000-000"
            End If
            Dim telFijo As String = If(partCE.telFijo.Trim = "", "", (partCE.telFijo).Substring(5, (partCE.telFijo).Length - 5))
            Dim telMovil As String = If(partCE.telMovil.Trim = "", "", (partCE.telMovil).Substring(5, (partCE.telMovil).Length - 5))
            Dim telFijo2 As String = If(partCE.telFijo2.Trim = "", "", (partCE.telFijo2).Substring(5, (partCE.telFijo2).Length - 5))
            Dim telMovil2 As String = If(partCE.telMovil2.Trim = "", "", (partCE.telMovil2).Substring(5, (partCE.telMovil2).Length - 5))
            txtTelFijo.Text = telFijo
            txtTelMovil.Text = telMovil
            cboOperadorM.SelectedText = Trim(partCE.opeMovil)
            txtTelFijo2.Text = telFijo2
            txtTelMovil2.Text = telMovil2
            cboOperadorM2.SelectedText = Trim(partCE.opeMovil2)
            txtCorreo.Text = .correo
            cboEstadoCivil.SelectedValue = Trim(.EstadoCiv)
            txtProfesionOcupacion.Text = .profeOcupa
            txtFechaN.Text = Trim(.fechaNaci)

            txtProfeCarrera.Text = .procarre
            txtNivelEst.Text = .nivestudio
            txtNomInstitu.Text = .nomInstitucion
            If (rbtUniversidad.Text = .instEducativa) Then rbtUniversidad.Checked = True
            If (rbtInstituto.Text = .instEducativa) Then rbtInstituto.Checked = True
            If (rbtOtros.Text = .instEducativa) Then rbtOtros.Checked = True

            txtRuc.Text = Trim(.ruc)
            txtEmpresa.Text = .empresa
            txtCargo.Text = .cargo
            Dim telFijoempresa As String = If(partCE.telFijoEmp.Trim = "", "", (partCE.telFijoEmp).Substring(5, (partCE.telFijoEmp).Length - 5))
            Dim telMovilempresa As String = If(partCE.telMovEmp.Trim = "", "", (partCE.telMovEmp).Substring(5, (partCE.telMovEmp).Length - 5))
            cboOperadorempresa.SelectedText = Trim(partCE.opeMovEmp)

            Dim rubro() As String = .rubro.Split("-"c)

            For Each element As Control In grbRubro.Controls
                If TypeOf element Is CheckBox Then
                    For Each rb As String In rubro
                        If DirectCast(element, CheckBox).Text = rb Then
                            DirectCast(element, CheckBox).Checked = True
                        End If
                    Next
                End If
            Next
            lblTitulo.Text = "ACTUALIZAR PARTICIPANTE"
            btnGuardar.Text = "ACTUALIZAR"
            btnLimpiar.Enabled = False
        End With
    End Sub

    Private Sub cboProvincia_Leave(sender As Object, e As EventArgs) Handles cboProvincia.Leave
        loadDistrito()
    End Sub
    Sub loadDistrito()
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
        loadProvincia()
    End Sub
    Sub loadProvincia()
        Dim idDep As String = Trim(cboDepartamento.SelectedValue)
        If idDep IsNot String.Empty Then
            Dim codTel As String = datadep.Select("idDep=" & idDep)(0).ItemArray(2)
            txtCodtel1.Text = "(" & codTel & ")"
            txtCodtel2.Text = "(" & codTel & ")"
            txtCodtelM1.Text = "(" & codTel & ")"
            txtCodtelM2.Text = "(" & codTel & ")"
            txtCodtel.Text = "(" & codTel & ")"
            txtCodtelM.Text = "(" & codTel & ")"
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
        limpiar()
    End Sub

    Sub limpiar()
        cboDepartamento.SelectedIndex = -1
        RadioButtonclear(grpSexo)
        txtCodtel1.Text = "(___)" : txtCodtelM1.Text = "(___)"
        txtCodtel2.Text = "(___)" : txtCodtelM2.Text = "(___)"
        txtTelFijo.Clear() : txtTelFijo2.Clear()
        txtTelMovil.Clear() : txtTelMovil2.Clear()
        cboOperadorM.SelectedIndex = -1 : cboOperadorM2.SelectedIndex = -1
        txtDireccion.Clear()
        txtApeMat.Clear() : txtApePat.Clear()
        txtNombres.Clear() : cboEstadoCivil.SelectedIndex = -1
        txtDNICE.Clear()
        txtCorreo.Clear()
        txtProfesionOcupacion.Clear()
        txtFechaN.Clear()
    End Sub
    Function CodigoAuto(ap As String, am As String) As String
        Dim cod As String = If(Trim(ap) = String.Empty, "_", Trim(ap).Substring(0, 1)) & If(Trim(am) = String.Empty, "_", Trim(am).Substring(0, 1))
        Return cod
    End Function
    Dim codigo As String


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim codUbi As String = cboDepartamento.SelectedValue & cboProvincia.SelectedValue & cboDistrito.SelectedValue
        Dim fechaN As String
        fechaN = If(IsDate(txtFechaN.Value), txtFechaN.Value, String.Empty)

        Dim espRubro As String = Trim(txtEspeSPE.Text) & "-" & Trim(txtEspOtros.Text)
        If InStr(espRubro, "-") = 1 Or Trim(txtEspeSPE.Text).Length = espRubro.Length - 1 Then
            espRubro = espRubro.Replace("-", String.Empty)
        End If

        With ParticipanteCE
            If btnGuardar.Text = "GUARDAR" Then
                .codpart = CodigoAuto(txtApePat.Text, txtApeMat.Text)
                codigo = .codpart
            Else
                .codpart = partCE.codpart
            End If
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
            .procarre = txtProfeCarrera.Text
            .nivestudio = txtNivelEst.Text
            .nomInstitucion = txtNomInstitu.Text
            .instEducativa = If(Not IsNothing(GetGrpBxCheckedBbt(grpInstitucion)), GetGrpBxCheckedBbt(grpInstitucion).Text, "")
            .ruc = txtRuc.Text
            .empresa = txtEmpresa.Text
            .cargo = txtCargo.Text
            .telFijoEmp = txtCodtel.Text & txtTelFijoEmp.Text
            .telMovEmp = txtCodtelM.Text & txtTelMovEmp.Text
            .opeMovEmp = cboOperadorempresa.Text
            .rubro = getCheckboxVal(grbRubro)
            .espRubro = espRubro
        End With
        If btnGuardar.Text = "GUARDAR" Then
            partEst = If(ParticipanteCN.participante_insert(ParticipanteCE), True, False)
            If partEst Then
                RadMessageBox.Show("SE REGISTRO CORRECTAMENTE", "", MessageBoxButtons.OK, RadMessageIcon.Info)
                limpiar()
            Else
                RadMessageBox.Show("OCURRIO UN ERROR,VUELVA A REGISTRAR", "", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If
        ElseIf btnGuardar.Text = "ACTUALIZAR" Then
            partEst = If(ParticipanteCN.participante_update(ParticipanteCE), True, False)
            If partEst Then
                RadMessageBox.Show("SE ACTUALIZO CORRECTAMENTE", "", MessageBoxButtons.OK, RadMessageIcon.Info)
                limpiar()
            Else
                RadMessageBox.Show("OCURRIO UN ERROR,VUELVA A INTENTAR", "", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If

        End If

    End Sub
    Function getCheckboxVal(grpbx As GroupBox) As String
        Dim value As String = String.Empty
        For Each element As Control In grpbx.Controls
            If TypeOf element Is CheckBox Then
                If DirectCast(element, CheckBox).Checked Then
                    value &= DirectCast(element, CheckBox).Text & "-"
                End If
            End If
        Next
        value = If(value Is String.Empty, value, value.Substring(0, value.Length - 1))
        Return value
    End Function

    Private Sub txtDNICE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNICE.KeyPress
        Solo_numeros(e)
    End Sub

    Public ReadOnly Property Opgave() As String
        Get
            Return partEst
        End Get
    End Property

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        txtEspeSPE.Enabled = If(CheckBox3.Checked, True, False)
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        txtEspOtros.Enabled = If(CheckBox5.Checked, True, False)
    End Sub

    Private Sub grp_Enter(sender As Object, e As EventArgs) Handles grp.Enter

    End Sub

    Public ReadOnly Property codeParticipante() As String
        Get
            Return ParticipanteCN.obtUltimoCodigoPart(codigo)
        End Get
    End Property
End Class
