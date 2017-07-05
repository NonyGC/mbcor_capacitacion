Imports System.Windows.Forms
Imports Capa_Negocio
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports Capa_Entidad
Imports Capa_Presentacion.Base

Public Class frmFicha
    Dim idDep As String, idProv As String
    Dim LocalCN As New LocalCN, FichCN As New FichaCapaCN, partCN As New ParticipanteCN, EncCN As New EncuestaCN
    Dim PartCE As New ParticipanteCE, FichCE As New FichaCapaCE, EncCE As New EncuestaCE
    Dim datadep As DataTable
    Dim _codigoPart As String
    Dim Action As String = "GUARDAR"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        RadMessageBox.SetThemeName("VisualStudio2012Light")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
#Region "metodos"
#Region "eventos"

    Private Sub cboCapacitacion_Enter(sender As Object, e As EventArgs) Handles cboCapacitacion.Enter
        cboCapacitacion.DataSource = FichCN.fichaCapacitacion_Capacitacion()
        cboCapacitacion.ValueMember = "codigo"
        cboCapacitacion.SelectedIndex = -1
    End Sub

    Private Sub cboDepartamento_Leave(sender As Object, e As EventArgs) Handles cboDepartamento.Leave
        Dim idDepartamentonew As String = If(String.IsNullOrEmpty(cboDepartamento.SelectedValue), String.Empty, cboDepartamento.SelectedValue)
        If idDepartamento <> idDepartamentonew Then
            loadProvincia()
        End If
    End Sub

    Private Sub cboDepartamento_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDepartamento.SelectedValueChanged
        cboProvincia.DataSource = Nothing
        cboDistrito.DataSource = Nothing
    End Sub

    Private Sub cboParticipanteSearch_Enter(sender As Object, e As EventArgs) Handles cboParticipanteSearch.Enter
        cboParticipanteSearch.DataSource = FichCN.fichaCapacitacion_ParticipanteAutocomplete()
        cboParticipanteSearch.ValueMember = "codigo"
        cboParticipanteSearch.DisplayMember = "participante"
        cboParticipanteSearch.SelectedIndex = -1
        form_Clear()
    End Sub

    Private Sub cboParticipanteSearch_Leave(sender As Object, e As EventArgs) Handles cboParticipanteSearch.Leave
        cboParticipanteSearch_Leave()
    End Sub

    Private Sub btnParticipanteNue_Click(sender As Object, e As EventArgs) Handles btnParticipanteNue.Click
        form_Clear()

        grp.Enabled = True : grp1.Enabled = True : grp2.Enabled = True : grpInstitucion.Enabled = True : grbRubro.Enabled = True
        btnLimpiar.Enabled = True : btnGuardarP.Enabled = True
        Dim datoPart As String() = Split(Trim(cboParticipanteSearch.Text), " ")
        Select Case datoPart.Length
            Case 1 : txtApePat.Text = datoPart(0)
            Case 2 : txtApePat.Text = datoPart(0) : txtApeMat.Text = datoPart(1)
            Case 3 To datoPart.Length
                txtApePat.Text = datoPart(0) : txtApeMat.Text = datoPart(1) : Dim nom As String = String.Empty
                For i = 2 To datoPart.Length - 1
                    nom += datoPart(i) & " "
                Next
                txtNombres.Text = Trim(nom)
        End Select
        cboParticipanteSearch.Text = String.Empty
    End Sub

    Private Sub cboProvincia_Leave(sender As Object, e As EventArgs) Handles cboProvincia.Leave
        Dim idProvincianew As String = If(String.IsNullOrEmpty(cboProvincia.SelectedValue), String.Empty, cboProvincia.SelectedValue)
        If idProvincia <> idProvincianew Then
            loadDistrito()
        End If
    End Sub

    Private Sub cboProvincia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedValueChanged
        cboDistrito.DataSource = Nothing
    End Sub
    Private Sub FrmFC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboParticipanteSearch.Focus()
        cboParticipanteSearch_AutoComparer()
        cboCapacitacion_filter()
        datadep = New DataTable
        datadep = LocalCN.ubigeo_Departamento()
        cboDepartamento.DataSource = datadep
        cboDepartamento.DisplayMember = "Departamento"
        cboDepartamento.ValueMember = "idDep"
        ubigeoPredeterminado()
        Autocomplete_LimitToList()

        txtProfesionOcupacion.AutoCompleteDataSource = partCN.Participante_AutocompleteProfeOcu()
        txtProfesionOcupacion.AutoCompleteDisplayMember = "profe_ocupa"

    End Sub

    Private Sub btnEncuesta_Click(sender As Object, e As EventArgs) Handles btnEncuesta.Click
        If cboCapacitacion.SelectedIndex <> -1 Then
            Dim codcap As String = Trim(cboCapacitacion.SelectedValue)

            If EncuestaSharedCE.codcap IsNot Nothing Then
                Dim Frm As New FrmEncuesta()
                Frm.ShowDialog(Me)
                Frm.Dispose()
            Else
                Dim Frm As New FrmEncuesta(codcap)
                Frm.ShowDialog(Me)
                Frm.Dispose()
            End If
        Else
            RadMessageBox.Show("PRIMERO DEBE SELECCIONAR CAPACITACIÓN", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        form_Clear()
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            txtEspOtros.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            txtEspeSPE.Enabled = True
        End If
    End Sub

    Private Sub rbtVer_Click(sender As Object, e As EventArgs) Handles rbtVer.Click
        If cboCapacitacion.SelectedIndex <> -1 Then
            Dim codcap As String = Trim(cboCapacitacion.SelectedValue)
            Dim Frm As New frmFiltParticipante(codcap)
            Frm.ShowDialog(Me)
            Frm.Dispose()
        End If
    End Sub

    Private Sub btnCapacitacionNueva_Click(sender As Object, e As EventArgs) Handles btnCapacitacionNueva.Click
        Dim Frm As New frmCapacitacion()
        Frm.ShowDialog(Me)
        Frm.Dispose()
    End Sub

    Private Sub cboCapacitacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCapacitacion.KeyPress, cboParticipanteSearch.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
#End Region
#Region "subprocesos"
    Public Sub cboCapacitacion_filter()
        cboCapacitacion.AutoFilter = True
        cboCapacitacion.DisplayMember = "localfecha"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = cboCapacitacion.DisplayMember
        filter.Operator = FilterOperator.Contains
        cboCapacitacion.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
    End Sub

    Public Sub cboParticipanteSearch_AutoComparer()
        cboParticipanteSearch.AutoCompleteMode = AutoCompleteMode.Suggest
        'cboParticipanteSearch.DropDownListElement.AutoCompleteSuggest = New CustomAutoCompleteSuggestHelper(cboParticipanteSearch.DropDownListElement)
        cboParticipanteSearch.DropDownListElement.AutoCompleteSuggest.SuggestMode = UI.SuggestMode.Contains
    End Sub
    Sub cboParticipanteSearch_Leave()
        _codigoPart = String.Empty
        If cboParticipanteSearch.SelectedIndex <> -1 Then Action = "ACTUALIZAR" Else Action = "GUARDAR"
        Dim codigo As String = cboParticipanteSearch.SelectedValue
        codigo = Trim(codigo)
        If codigo IsNot String.Empty Then
            grp.Enabled = True : grp1.Enabled = True : grp2.Enabled = True : grpInstitucion.Enabled = True : grbRubro.Enabled = True
            btnLimpiar.Enabled = True : btnGuardarP.Enabled = True
            Dim data As DataTable = FichCN.fichaCapacitacion_ParticipanteCargar(codigo)
            With data

                _codigoPart = .Rows(0)(0).ToString().Trim()
                txtApePat.Text = .Rows(0)(1).ToString()
                txtApeMat.Text = .Rows(0)(2).ToString()
                txtNombres.Text = .Rows(0)(3).ToString()
                cboSexo.SelectedValue = .Rows(0)(4).ToString().Trim()
                txtFechaN.Text = .Rows(0)(5).ToString()
                txtDNICE.Text = .Rows(0)(6).ToString()
                txtDireccion.Text = .Rows(0)(7).ToString()


                'carga ubigeo
                Dim codubigeo As String = .Rows(0)(8).ToString().Trim
                Dim len = 2
                Dim arr = Enumerable.Range(0, codubigeo.Length / len).Select(Function(x) codubigeo.Substring(x * len, len)).ToArray()

                Select Case arr.Length
                    Case 3
                        cboDepartamento.SelectedValue = arr(0) : loadProvincia()
                        cboProvincia.SelectedValue = arr(1) : loadDistrito()
                        cboDistrito.SelectedValue = arr(2)
                    Case 2
                        cboDepartamento.SelectedValue = arr(0) : loadProvincia()
                        cboProvincia.SelectedValue = arr(1) : loadDistrito()
                    Case 1
                        cboDepartamento.SelectedValue = arr(0) : loadProvincia()
                End Select

                Dim telFij As String = .Rows(0)(9).ToString().Trim
                Dim telMov As String = .Rows(0)(10).ToString().Trim
                txtTelFijo.Text = If(telFij = "", "", telFij.Substring(5, telFij.Length - 5))
                txtTelMovil.Text = If(telMov = "", "", telMov.Substring(5, telMov.Length - 5))
                cboOperadorM.SelectedValue = .Rows(0)(11).ToString().Trim

                Dim telFij2 As String = .Rows(0)(12).ToString().Trim
                Dim telMov2 As String = .Rows(0)(13).ToString().Trim
                txtTelFijo2.Text = If(telFij2 = "", "", telFij2.Substring(5, telFij2.Length - 5))
                txtTelMovil2.Text = If(telMov2 = "", "", telMov2.Substring(5, telMov2.Length - 5))
                cboOperadorM2.SelectedValue = .Rows(0)(14).ToString().Trim

                txtCorreo.Text = .Rows(0)(15).ToString()
                cboEstadoCivil.SelectedValue = .Rows(0)(16).ToString().Trim
                txtProfesionOcupacion.Text = .Rows(0)(17).ToString()
                txtProfeCarrera.Text = .Rows(0)(18).ToString()
                txtNivelEst.Text = .Rows(0)(19).ToString()
                txtNomInstitu.Text = .Rows(0)(20).ToString()
                Dim TipInstitucion As String = .Rows(0)(21).ToString()
                Select Case TipInstitucion
                    Case "UNIVERSIDAD" : rbtUniversidad.Checked = True
                    Case "INSTITUTO" : rbtInstituto.Checked = True
                    Case "OTROS" : rbtOtros.Checked = True
                End Select
                txtRuc.Text = .Rows(0)(22).ToString()
                txtEmpresa.Text = .Rows(0)(23).ToString()
                txtCargo.Text = .Rows(0)(24).ToString()
                Dim telfijemp As String = .Rows(0)(25).ToString().Trim
                Dim telmovemp As String = .Rows(0)(26).ToString().Trim
                txtTelFijoEmp.Text = If(telfijemp = "", "", telfijemp.Substring(5, telfijemp.Length - 5))
                txtTelMovEmp.Text = If(telmovemp = "", "", telmovemp.Substring(5, telmovemp.Length - 5))
                cboOperadorempresa.SelectedValue = .Rows(0)(27).ToString().Trim
                Dim rubro() As String = .Rows(0)(28).ToString().Split("-"c)
                For Each element As Control In grbRubro.Controls
                    If TypeOf element Is CheckBox Then
                        For Each rb As String In rubro
                            If DirectCast(element, CheckBox).Text = rb Then
                                DirectCast(element, CheckBox).Checked = True
                            End If
                        Next
                    End If
                Next
                txtEspOtros.Text = .Rows(0)(29).ToString()
                txtEspeSPE.Text = .Rows(0)(38).ToString()
            End With
        End If
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

            If idDep = "15" Then
                txtTelFijo.Mask = "000-0000"
                txtTelFijo2.Mask = "000-0000"
                txtTelFijoEmp.Mask = "000-0000"
            Else
                txtTelFijo.Mask = "000-000"
                txtTelFijo2.Mask = "000-000"
                txtTelFijoEmp.Mask = "000-000"
                cboProvincia.SelectedIndex = -1
            End If

        End If
    End Sub
    Sub ubigeoPredeterminado()
        cboDepartamento.SelectedValue = "15"
        loadProvincia()
        loadDistrito()
        cboDistrito.SelectedIndex = -1
    End Sub

    Sub Autocomplete_LimitToList()
        cboOperadorM.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboEstadoCivil.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboDepartamento.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboProvincia.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboDistrito.DropDownListElement.AutoCompleteAppend.LimitToList = True
        cboSexo.DropDownListElement.AutoCompleteAppend.LimitToList = True
    End Sub
    Dim idDepartamento As String, idProvincia As String
    Private Sub cboDepartamento_Enter(sender As Object, e As EventArgs) Handles cboDepartamento.Enter
        idDepartamento = String.Empty
        idDepartamento = If(String.IsNullOrEmpty(cboDepartamento.SelectedValue), String.Empty, cboDepartamento.SelectedValue)
    End Sub

    Private Sub cboDistrito_Enter(sender As Object, e As EventArgs) Handles cboDistrito.Enter
        If cboDistrito.Items.Count = 0 Then
            loadDistrito()
        End If
    End Sub

    Private Sub cboProvincia_Enter(sender As Object, e As EventArgs) Handles cboProvincia.Enter
        idProvincia = String.Empty
        idProvincia = If(String.IsNullOrEmpty(cboProvincia.SelectedValue), String.Empty, cboProvincia.SelectedValue)
    End Sub

    Private Sub txtApePat_Enter(sender As Object, e As EventArgs) Handles txtApePat.Enter
        If cboCapacitacion.SelectedIndex = -1 Then
            RadMessageBox.Show("PRIMERO DEBE SELECCIONAR CAPACITACIÓN", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Sub setValueEncuestaCE()
        With EncCE
            .codcap = EncuestaSharedCE.codcap
            .charla = EncuestaSharedCE.charla
            .espCharla = EncuestaSharedCE.espCharla
            .dominioTem = EncuestaSharedCE.dominioTem
            .dejaEntender = EncuestaSharedCE.dejaEntender
            .fueInteresante = EncuestaSharedCE.fueInteresante
            .extCharla = EncuestaSharedCE.extCharla
            .visitaPagina = EncuestaSharedCE.visitaPagina
            .otroTema = EncuestaSharedCE.otroTema
            .targeta = EncuestaSharedCE.targeta
        End With 'PASA LOS VALORES DEL SHARE ENCUESTA A ENTIDAD ENCUESTA
        EncuestaSharedCE.resetEncuestaSharedCE()
    End Sub

    Private Sub btnGuardarP_Click(sender As Object, e As EventArgs) Handles btnGuardarP.Click

        If cboCapacitacion.SelectedIndex <> -1 Then
            Dim codUbi As String = cboDepartamento.SelectedValue & cboProvincia.SelectedValue & cboDistrito.SelectedValue
            Dim fechaN As String
            fechaN = If(IsDate(txtFechaN.Value), txtFechaN.Value, String.Empty)

            With PartCE

                If Action = "GUARDAR" Then
                    Dim iniCod = CodigoAuto(txtApePat.Text, txtApeMat.Text)
                    _codigoPart = partCN.participante_codauto(iniCod)
                End If

                .codpart = _codigoPart
                .dnice = Trim(txtDNICE.Text)
                .apePat = txtApePat.Text
                .apeMat = txtApeMat.Text
                .nombres = txtNombres.Text
                .fechaNaci = fechaN
                .EstadoCiv = cboEstadoCivil.Text
                .sexo = cboSexo.Text
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
                .instEducativa = If(Not IsNothing(GetRbtChekedInGroupbx(grpInstitucion)), GetRbtChekedInGroupbx(grpInstitucion).Text, "")
                .ruc = txtRuc.Text
                .empresa = txtEmpresa.Text
                .cargo = txtCargo.Text
                .telFijoEmp = txtCodtel.Text & txtTelFijoEmp.Text
                .telMovEmp = txtCodtelM.Text & txtTelMovEmp.Text
                .opeMovEmp = cboOperadorempresa.Text
                .rubro = getCheckboxVal(grbRubro)
                .espRubroOtros = txtEspOtros.Text
                .espRubroSectorPE = txtEspeSPE.Text
            End With
            With FichCE
                .codcap = cboCapacitacion.SelectedValue
                .codpart = _codigoPart
            End With
            'VERIFICAR SI LOS DATOS DEL FRM SE HAN GUARDADO
            If EncuestaSharedCE.codcap IsNot Nothing Then
                setValueEncuestaCE()
            End If

            Dim ExecPart As Boolean = False
            Dim ExecFichaCapa As Boolean = False
            Dim ExecEncuesta As Boolean = False
            If Action = "GUARDAR" Then
                ExecPart = If(partCN.participante_insert(PartCE), True, False)

                If ExecPart Then
                    Dim mssg As String = String.Format("Participante : {0} :REGISTRADO", PartCE.codpart)
                    ExecFichaCapa = If(FichCN.fichaCapacitacion_Registrar(FichCE), True, False)
                    If ExecFichaCapa Then
                        mssg += vbCrLf & String.Format("Capacitación : {0} :REGISTRADO", FichCE.codcap)
                    Else
                        mssg = vbCrLf & "Capacitación : ERROR, NO REGISTRADO"
                    End If
                    ExecEncuesta = If(EncCN.Encuesta_Registrar(EncCE), True, False)

                    If ExecEncuesta Then
                        mssg += vbCrLf & "Encuesta : REGISTRADO"
                    Else
                        mssg += vbCrLf & "Encuesta : ERROR, NO REGISTRADO"
                    End If

                    RadMessageBox.Show(mssg, "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info)
                    form_Clear()
                Else
                    RadMessageBox.Show("OCURRIO UN ERROR,VUELVA A INTENTAR", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Error)
                End If

            ElseIf Action = "ACTUALIZAR" Then
                ExecPart = If(partCN.participante_update(PartCE), True, False)
                If ExecPart Then
                    Dim mssg As String = String.Format("Participante : {0} :REGISTRADO", PartCE.codpart)
                    ExecFichaCapa = If(FichCN.fichaCapacitacion_Registrar(FichCE), True, False)
                    If ExecFichaCapa Then mssg = mssg & vbCrLf & String.Format("Capacitación : {0} :REGISTRADO", FichCE.codcap) Else mssg = mssg & "Capacitación : ERROR, NO REGISTRADO"
                    RadMessageBox.Show(mssg, "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info)
                    form_Clear()
                Else
                    RadMessageBox.Show("OCURRIO UN ERROR,VUELVA A INTENTAR", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Error)
                End If
            End If
        Else
            RadMessageBox.Show("PRIMERO DEBE SELECCIONAR CAPACITACIÓN", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Sub form_Clear()
        grp.Enabled = False : grp1.Enabled = False : grp2.Enabled = False : grpInstitucion.Enabled = False : grbRubro.Enabled = False
        btnLimpiar.Enabled = False
        btnGuardarP.Enabled = False
        cboParticipanteSearch.SelectedIndex = -1
        ubigeoPredeterminado()
        cboSexo.SelectedIndex = -1
        'txtCodtel1.Text = "(___)" : txtCodtelM1.Text = "(___)"
        'txtCodtel2.Text = "(___)" : txtCodtelM2.Text = "(___)"
        txtTelFijo.Clear() : txtTelFijo2.Clear()
        txtTelMovil.Clear() : txtTelMovil2.Clear()
        cboOperadorM.SelectedIndex = -1 : cboOperadorM2.SelectedIndex = -1
        txtDireccion.Clear()
        txtApeMat.Clear() : txtApePat.Clear()
        txtNombres.Clear() : cboEstadoCivil.SelectedIndex = -1
        txtDNICE.Clear()
        txtCorreo.Clear()
        txtProfesionOcupacion.Clear()
        txtFechaN.Mask = "00/00/0000"
        txtFechaN.Text = "__/__/____"

        txtProfeCarrera.Clear()
        txtNivelEst.Clear()
        txtNomInstitu.Clear()
        RadioButtonclear(grpInstitucion)

        txtRuc.Clear()
        txtEmpresa.Clear()
        txtCargo.Clear()
        'txtCodtel.Text = "(___)" : txtCodtelM.Text = "(___)"
        txtTelFijoEmp.Clear()
        txtTelMovEmp.Clear()
        cboOperadorempresa.SelectedIndex = -1
        CheckBoxclear(grbRubro)
        txtEspOtros.Clear()
        txtEspeSPE.Clear()
        Action = "GUARDAR"
    End Sub
#End Region

#Region "Funciones"
    Function CodigoAuto(ap As String, am As String) As String
        Dim cod As String = If(Trim(ap) = String.Empty, "_", Trim(ap).Substring(0, 1)) & If(Trim(am) = String.Empty, "_", Trim(am).Substring(0, 1))
        Return cod
    End Function
#End Region
#End Region
#Region "Class"
    'Public Class CustomAutoCompleteSuggestHelper
    '    Inherits AutoCompleteSuggestHelper
    '    Public Sub New(owner As RadDropDownListElement)
    '        MyBase.New(owner)
    '    End Sub
    '    Public Overrides Sub ApplyFilterToDropDown(filter As String)
    '        MyBase.ApplyFilterToDropDown(filter)
    '        DropDownList.ListElement.DataLayer.DataView.Comparer = New CustomComparer()
    '    End Sub
    'End Class

    'Public Class CustomComparer
    '    Implements IComparer(Of RadListDataItem)
    '    Public Function [Compare](x As RadListDataItem, y As RadListDataItem) As Integer Implements IComparer(Of RadListDataItem).[Compare]
    '        Return x.Text.Length.CompareTo(y.Text.Length)
    '    End Function
    'End Class

#End Region
End Class