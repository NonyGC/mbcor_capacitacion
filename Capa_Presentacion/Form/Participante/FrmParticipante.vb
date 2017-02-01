Imports Capa_Negocio
Imports Capa_Entidad
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Capa_Presentacion.Base
Public Class FrmParticipante_vb
    Dim LocalCN As New LocalCN, ParticipanteCE As New ParticipanteCE
    Dim ParticipanteCN As New ParticipanteCN
    Dim datadep As DataTable
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
            cboDepartamento.SelectedValue = (partCE.ubigeo).Substring(0, 2) : loadProvincia()
            cboProvincia.SelectedValue = (partCE.ubigeo).Substring(2, 2) : loadDistrito()
            cboDistrito.SelectedValue = (partCE.ubigeo).Substring(4, 2)
            Dim telFijo As String = (partCE.telFijo).Substring(5, (partCE.telFijo).Length - 5)
            Dim telMovil As String = (partCE.telMovil).Substring(5, (partCE.telMovil).Length - 5)
            Dim telFijo2 As String = (partCE.telFijo2).Substring(5, (partCE.telFijo2).Length - 5)
            Dim telMovil2 As String = (partCE.telMovil2).Substring(5, (partCE.telMovil2).Length - 5)
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim codUbi As String = cboDepartamento.SelectedValue & cboProvincia.SelectedValue & cboDistrito.SelectedValue
        Dim fechaN As String
        fechaN = If(txtFechaN.Value = "__/__/____", String.Empty, txtFechaN.Value)

        With ParticipanteCE
            If btnGuardar.Text = "GUARDAR" Then
                .codpart = CodigoAuto(txtApePat.Text, txtApeMat.Text)
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
        End With
        If btnGuardar.Text = "GUARDAR" Then
            Dim partEst As Boolean = If(ParticipanteCN.participante_upsert(ParticipanteCE), True, False)
            If partEst Then
                RadMessageBox.Show("SE REGISTRO CORRECTAMENTE", "", MessageBoxButtons.OK, RadMessageIcon.Info)
                limpiar()
            Else
                RadMessageBox.Show("OCURRIO UN ERROR,VUELVA A REGISTRAR", "", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If
        ElseIf btnGuardar.Text = "ACTUALIZAR" Then
            Dim partEst As Boolean = If(ParticipanteCN.participante_update(ParticipanteCE), True, False)
            If partEst Then
                RadMessageBox.Show("SE ACTUALIZO CORRECTAMENTE", "", MessageBoxButtons.OK, RadMessageIcon.Info)
                limpiar()
            Else
                RadMessageBox.Show("OCURRIO UN ERROR,VUELVA A INTENTAR", "", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If
        End If

    End Sub
End Class
