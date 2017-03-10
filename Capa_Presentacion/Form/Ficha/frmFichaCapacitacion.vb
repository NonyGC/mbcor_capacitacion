Imports System.Windows.Forms
Imports Capa_Negocio
Imports Capa_Presentacion.Base
Imports Capa_Entidad
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports System.Text

Public Class frmFichaCapacitacion
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        RadMessageBox.SetThemeName("VisualStudio2012Light")
    End Sub

    Dim LocalCN As New LocalCN, FichCN As New FichaCapaCN, FichaCE As New FichaCapaCE
    Dim idDep As String, idProv As String
    Dim PartCE As New ParticipanteCE

    Private Sub frmFichaCapacitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboParticipanteSearch_AutoComparer()
        cboCapacitacion_filter()
    End Sub

    Public Sub cboCapacitacion_filter()
        cboCapacitacion.AutoFilter = True
        cboCapacitacion.DisplayMember = "local"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = cboCapacitacion.DisplayMember
        filter.Operator = FilterOperator.Contains
        cboCapacitacion.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
    End Sub
    Public Sub cboParticipanteSearch_AutoComparer()
        cboParticipanteSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboParticipanteSearch.DropDownListElement.AutoCompleteSuggest = New CustomAutoCompleteSuggestHelper(cboParticipanteSearch.DropDownListElement)
        cboParticipanteSearch.DropDownListElement.AutoCompleteSuggest.SuggestMode = UI.SuggestMode.Contains
    End Sub
    Public Class CustomAutoCompleteSuggestHelper
        Inherits AutoCompleteSuggestHelper
        Public Sub New(owner As RadDropDownListElement)
            MyBase.New(owner)
        End Sub
        Public Overrides Sub ApplyFilterToDropDown(filter As String)
            MyBase.ApplyFilterToDropDown(filter)
            DropDownList.ListElement.DataLayer.DataView.Comparer = New CustomComparer()
        End Sub
    End Class
    Public Class CustomComparer
        Implements IComparer(Of RadListDataItem)
        Public Function [Compare](x As RadListDataItem, y As RadListDataItem) As Integer Implements IComparer(Of RadListDataItem).[Compare]
            Return x.Text.Length.CompareTo(y.Text.Length)
        End Function
    End Class

    Sub Limpiar()
        'txtProfeCarrera.Clear() : txtNivelEst.Clear()
        'txtNomInstitu.Clear() : txtRuc.Clear() : txtEmpresa.Clear() : txtCargo.Clear()
        'txtTelFijoEmp.Clear() : cboOperadorempresa.SelectedIndex = -1
        'CheckBoxclear(grbRubro)
        CheckBoxclear(grpCharla)
        RadioButtonclear(grpRessin1) : RadioButtonclear(grpRessin2) : RadioButtonclear(grpRessin3)
        RadioButtonclear(grpRessin4) : RadioButtonclear(grpRessin5) : RadioButtonclear(grpTajetacredito)
        'RadioButtonclear(grpInstitucion)
        txtTematratar.Clear()
        'txtTelMovEmp.Clear()
        'txtEspeSPE.Clear() : txtEspOtros.Clear()
        txtEspeCharla.Clear()
        cboParticipanteSearch.SelectedIndex = -1
        txtCodigop.Clear()
        'txtCodtel.Text = "(___)" : txtCodtelM.Text = "(___)"
    End Sub

    Private Sub txtRuc_KeyPress(sender As Object, e As KeyPressEventArgs)
        Solo_numeros(e)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub
    Sub bloquear()
        grp5.Enabled = False
        grpCharla.Enabled = False
        btnRegistrar.Enabled = False : btnLimpiar.Enabled = False
        grpTajetacredito.Enabled = False
    End Sub
    Dim FormProcedencias As String
    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles btnParticipanteNuevo.Click
        Dim Frm As New FrmParticipante_vb()
        If Frm.ShowDialog(Me) = DialogResult.OK And Frm.Opgave() Then
            cboParticipanteSearch.DataSource = FichCN.fichaCapacitacion_ParticipanteAutocomplete()
            cboParticipanteSearch.ValueMember = "codigo"
            cboParticipanteSearch.DisplayMember = "participante"
            cboParticipanteSearch.SelectedValue = Frm.codeParticipante
            FormProcedencias = "Agregar"
            cboParticipanteSearch_Leave()
        End If
    End Sub
    Sub cboParticipanteSearch_Leave()
        txtCodigop.Text = cboParticipanteSearch.SelectedValue
        If Trim(txtCodigop.Text) IsNot String.Empty Then

            If FormProcedencias <> "Agregar" Then
                Dim data As DataTable = FichCN.fichaCapacitacion_ParticipanteCargar(Trim(txtCodigop.Text))
                With data
                    PartCE.codpart = .Rows(0)(0).ToString()
                    PartCE.apePat = .Rows(0)(1).ToString()
                    PartCE.apeMat = .Rows(0)(2).ToString()
                    PartCE.nombres = .Rows(0)(3).ToString()
                    PartCE.sexo = .Rows(0)(4).ToString()
                    PartCE.fechaNaci = .Rows(0)(5).ToString()
                    PartCE.dnice = .Rows(0)(6).ToString()
                    PartCE.direccion = .Rows(0)(7).ToString()
                    PartCE.ubigeo = .Rows(0)(8).ToString()
                    PartCE.telFijo = .Rows(0)(9).ToString()
                    PartCE.telMovil = .Rows(0)(10).ToString()
                    PartCE.opeMovil = .Rows(0)(11).ToString()
                    PartCE.telFijo2 = .Rows(0)(12).ToString()
                    PartCE.telMovil2 = .Rows(0)(13).ToString()
                    PartCE.opeMovil2 = .Rows(0)(14).ToString()
                    PartCE.correo = .Rows(0)(15).ToString()
                    PartCE.EstadoCiv = .Rows(0)(16).ToString()
                    PartCE.profeOcupa = .Rows(0)(17).ToString()
                    PartCE.procarre = .Rows(0)(18).ToString()
                    PartCE.nivestudio = .Rows(0)(19).ToString()
                    PartCE.nomInstitucion = .Rows(0)(20).ToString()
                    PartCE.instEducativa = .Rows(0)(21).ToString()
                    PartCE.ruc = .Rows(0)(22).ToString()
                    PartCE.empresa = .Rows(0)(23).ToString()
                    PartCE.cargo = .Rows(0)(24).ToString()
                    PartCE.telFijoEmp = .Rows(0)(25).ToString()
                    PartCE.telMovEmp = .Rows(0)(26).ToString()
                    PartCE.opeMovEmp = .Rows(0)(27).ToString()
                    PartCE.rubro = .Rows(0)(28).ToString()
                    PartCE.espRubro = .Rows(0)(29).ToString()
                    PartCE.origen = .Rows(0)(30).ToString()
                End With

                Dim Frm As New FrmParticipante_vb(PartCE)
                Frm.ShowDialog(Me)
                Frm.Dispose()
            End If
            FormProcedencias = ""

            grp5.Enabled = True
            grpCharla.Enabled = True
            btnRegistrar.Enabled = True : btnLimpiar.Enabled = True
            grpTajetacredito.Enabled = True
        Else
            bloquear()
        End If
    End Sub

    Private Sub cboParticipanteSearch_Leave(sender As Object, e As EventArgs) Handles cboParticipanteSearch.Leave
        cboParticipanteSearch_Leave()
    End Sub

    Private Sub cboParticipanteSearch_Enter(sender As Object, e As EventArgs) Handles cboParticipanteSearch.Enter
        cboParticipanteSearch.DataSource = FichCN.fichaCapacitacion_ParticipanteAutocomplete()
        cboParticipanteSearch.ValueMember = "codigo"
        cboParticipanteSearch.DisplayMember = "participante"
        cboParticipanteSearch.SelectedIndex = -1
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles btnCapacitacionNuevo.Click
        frmCapacitacion.Show()
    End Sub

    Private Sub rbtVer_Click(sender As Object, e As EventArgs) Handles btnCapacitacionVer.Click
        If cboCapacitacion.SelectedIndex <> -1 Then
            Dim codcap As String = Trim(cboCapacitacion.SelectedValue)
            Dim Frm As New frmFiltParticipante(codcap)
            Frm.ShowDialog(Me)
            Frm.Dispose()
        End If
    End Sub

    Private Sub cboCapacitacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCapacitacion.SelectedIndexChanged
    End Sub

    Private Sub cboParticipanteSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboParticipanteSearch.KeyPress, cboCapacitacion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub cboCapacitacion_Enter(sender As Object, e As EventArgs) Handles cboCapacitacion.Enter
        cboCapacitacion.DataSource = FichCN.fichaCapacitacion_Capacitacion()
        cboCapacitacion.ValueMember = "codigo"
    End Sub

#Region "Funciones"
    'obtiene valores de los checkbox seleccionado destro de un GroupBox
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
    'obtiene valores de los RadioButton seleccionado destro de un GroupBox
    Private Function GetGrpBxCheckedBbt(grpb As GroupBox) As RadioButton
        Dim rButton As RadioButton = grpb.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()
        Return rButton
    End Function


#End Region


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If cboCapacitacion.SelectedIndex <> -1 Then

            With FichaCE
                .codcap = Trim(cboCapacitacion.SelectedValue)
                .codpart = Trim(txtCodigop.Text)
                .charla = getCheckboxVal(grpCharla)
                .espCharla = txtEspeCharla.Text
                .dominioTem = If(Not IsNothing(GetGrpBxCheckedBbt(grpRessin1)), GetGrpBxCheckedBbt(grpRessin1).Text, String.Empty)
                .dejaEntender = If(Not IsNothing(GetGrpBxCheckedBbt(grpRessin2)), GetGrpBxCheckedBbt(grpRessin2).Text, String.Empty)
                .fueInteresante = If(Not IsNothing(GetGrpBxCheckedBbt(grpRessin3)), GetGrpBxCheckedBbt(grpRessin3).Text, String.Empty)
                .extCharla = If(Not IsNothing(GetGrpBxCheckedBbt(grpRessin4)), GetGrpBxCheckedBbt(grpRessin4).Text, String.Empty)
                .visitaPagina = If(Not IsNothing(GetGrpBxCheckedBbt(grpRessin5)), GetGrpBxCheckedBbt(grpRessin5).Text, String.Empty)
                .otroTema = txtTematratar.Text
                .targeta = If(Not IsNothing(GetGrpBxCheckedBbt(grpTajetacredito)), GetGrpBxCheckedBbt(grpTajetacredito).Text, String.Empty)
            End With

            Dim fichtEst As Boolean = If(FichCN.fichaCapacitacion_Registrar(FichaCE), True, False)

            If fichtEst Then
                RadMessageBox.Show("SE REGISTRO CORRECTAMENTE", "", MessageBoxButtons.OK, RadMessageIcon.Info)
                Limpiar()
                bloquear()
            Else
                RadMessageBox.Show("OCURRIO UN ERROR,VUELVA A REGISTRAR", "", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If
        Else
            RadMessageBox.Show("FALTA SELECCIONAR CAPACITACIÓN", "", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub


End Class

