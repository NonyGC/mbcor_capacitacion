Imports System.Windows.Forms
Imports Capa_Negocio
Imports Capa_Presentacion.Base
Imports Capa_Entidad
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class frmFichaCapacitacion
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        RadMessageBox.SetThemeName("VisualStudio2012Light")
    End Sub
    Dim LocalCN As New LocalCN, FichCN As New FichaCapaCN, FichaCE As New FichaCapaCE
    Dim idDep As String, idProv As String

    Private Function GetGrpBxCheckedBbt(grpb As GroupBox) As RadioButton
        Dim rButton As RadioButton = grpb.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()
        Return rButton
    End Function
    Private Sub frmFichaCapacitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboParticipanteSearch_AutoComparer()
        cboOperadorempresa.DropDownListElement.AutoCompleteAppend.LimitToList = True
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
        txtProfeCarrera.Clear() : txtNivelEst.Clear()
        txtNomInstitu.Clear() : txtRuc.Clear() : txtEmpresa.Clear() : txtCargo.Clear()
        txtTelFijoEmp.Clear() : cboOperadorempresa.SelectedIndex = -1
        CheckBoxclear(grbRubro)
        CheckBoxclear(grpCharla)
        RadioButtonclear(grpRessin1) : RadioButtonclear(grpRessin2) : RadioButtonclear(grpRessin3)
        RadioButtonclear(grpRessin4) : RadioButtonclear(grpRessin5) : RadioButtonclear(grpTajetacredito)
        RadioButtonclear(grpInstitucion)
        txtTematratar.Clear()
        txtTelMovEmp.Clear()
        txtEspeSPE.Clear() : txtEspOtros.Clear()
        txtEspeCharla.Clear()
        cboParticipanteSearch.SelectedIndex = -1
        txtCodigop.Clear() : lblApeNom.Text = Nothing
    End Sub
    Sub CheckBoxclear(grpbx As GroupBox)
        For Each element As Control In grpbx.Controls
            If TypeOf element Is CheckBox Then
                If DirectCast(element, CheckBox).Checked Then
                    DirectCast(element, CheckBox).Checked = False
                End If
            End If
        Next
    End Sub
    Sub RadioButtonclear(grpbx As GroupBox)
        For Each element As Control In grpbx.Controls
            If TypeOf element Is RadioButton Then
                If DirectCast(element, RadioButton).Checked Then
                    DirectCast(element, RadioButton).Checked = False
                End If
            End If
        Next
    End Sub

    Private Sub txtRuc_KeyPress(sender As Object, e As KeyPressEventArgs)
        Solo_numeros(e)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        FrmParticipante_vb.Show()
    End Sub

    Private Sub cboParticipanteSearch_Leave(sender As Object, e As EventArgs) Handles cboParticipanteSearch.Leave
        txtCodigop.Text = cboParticipanteSearch.SelectedValue
        If Trim(txtCodigop.Text) IsNot String.Empty Then
            lblApeNom.Text = FichCN.fichaCapacitacion_getPartiCod(txtCodigop.Text)
            grbRubro.Enabled = True
            grp1.Enabled = True
            grp2.Enabled = True
            grp5.Enabled = True
            grpCharla.Enabled = True
            btnRegistrar.Enabled = True : btnLimpiar.Enabled = True
            grpTajetacredito.Enabled = True
        Else
            lblApeNom.Text = "Apellidos y Nombres"
            grbRubro.Enabled = False
            grp1.Enabled = False
            grp2.Enabled = False
            grp5.Enabled = False
            grpCharla.Enabled = False
            btnRegistrar.Enabled = False : btnLimpiar.Enabled = False
            grpTajetacredito.Enabled = False
        End If

    End Sub

    Private Sub cboParticipanteSearch_Enter(sender As Object, e As EventArgs) Handles cboParticipanteSearch.Enter
        cboParticipanteSearch.DataSource = FichCN.fichaCapacitacion_ParticipanteAutocomplete()
        cboParticipanteSearch.ValueMember = "codigo"
        cboParticipanteSearch.DisplayMember = "participante"
        cboParticipanteSearch.SelectedIndex = -1
    End Sub

    Private Sub cboCapacitacion_Enter(sender As Object, e As EventArgs) Handles cboCapacitacion.Enter
        cboCapacitacion.DataSource = FichCN.fichaCapacitacion_Capacitacion()
        cboCapacitacion.ValueMember = "codigo"
        cboCapacitacion.SelectedIndex = -1
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




    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim espRubro As String = Trim(txtEspeSPE.Text) & "-" & Trim(txtEspOtros.Text)
        If InStr(espRubro, "-") = 1 Or Trim(txtEspeSPE.Text).Length = espRubro.Length - 1 Then
            espRubro = espRubro.Replace("-", String.Empty)
        End If

        With FichaCE
            .codcap = Trim(cboCapacitacion.SelectedValue)
            .codpart = Trim(txtCodigop.Text)
            .procarre = txtProfeCarrera.Text
            .nivestudio = txtNivelEst.Text
            .nomInstitucion = txtNomInstitu.Text
            .instEducativa = If(Not IsNothing(GetGrpBxCheckedBbt(grpInstitucion)), GetGrpBxCheckedBbt(grpInstitucion).Text, "")
            .ruc = txtRuc.Text
            .empresa = txtEmpresa.Text
            .cargo = txtCargo.Text
            .telFijoEmp = txtTelFijoEmp.Text
            .telMovEmp = txtTelMovEmp.Text
            .opeMovEmp = cboOperadorempresa.Text
            .rubro = getCheckboxVal(grbRubro)
            .espRubro = espRubro
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
        Else
            RadMessageBox.Show("OCURRIO UN ERROR,VUELVA A REGISTRAR", "", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If
    End Sub


End Class
