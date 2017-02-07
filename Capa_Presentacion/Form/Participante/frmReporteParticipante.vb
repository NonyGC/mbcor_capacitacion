Imports System.Windows.Forms
Imports Capa_Entidad
Imports Capa_Negocio
Imports Capa_Presentacion.Base
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmReporteParticipante
    Dim ParticipanteCN As New ParticipanteCN
    Dim PartCE As New ParticipanteCE
    Private Sub FrmReporteParticipante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgParticipante.DataSource = ParticipanteCN.CargarParticipante()
        dtgParticipante.MasterTemplate.ShowFilterCellOperatorText = False
        cboBuscar_AutoComparer()
    End Sub
    Public Sub cboBuscar_AutoComparer()
        cboBuscar.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboBuscar.DropDownListElement.AutoCompleteSuggest = New CustomAutoCompleteSuggestHelper(cboBuscar.DropDownListElement)
        cboBuscar.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains
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

    Private Sub cboBuscar_Enter(sender As Object, e As EventArgs) Handles cboBuscar.Enter
        Dim rbtSelected As String = If(Not IsNothing(GetGrpBxCheckedBbt(gpbTipBusqueda)), GetGrpBxCheckedBbt(gpbTipBusqueda).Text, "")
        'Dim dateIni As String
        If rbtSelected IsNot String.Empty Then
            cboBuscar.DataSource = ParticipanteCN.cargarAutocompletado_buscar(rbtSelected)
            cboBuscar.ValueMember = "codigo"
            cboBuscar.DisplayMember = "nombre"
            cboBuscar.SelectedIndex = -1
        End If
    End Sub

    Private Sub rbtApeNom_CheckedChanged(sender As Object, e As EventArgs) Handles rbtApeNom.CheckedChanged
        txtFechaini.Value = "__/__/____"
        txtFechafin.Value = "__/__/____"
        cboBuscar.Enabled = True : btnBuscar.Enabled = True
    End Sub

    Private Sub rbtLocal_CheckedChanged(sender As Object, e As EventArgs) Handles rbtLocal.CheckedChanged
        gpbFecha.Enabled = If(rbtLocal.Checked, True, False)
        cboBuscar.Enabled = True : btnBuscar.Enabled = True
    End Sub

    Private Sub rbtOrigen_CheckedChanged(sender As Object, e As EventArgs) Handles rbtOrigen.CheckedChanged
        gpbFecha.Enabled = If(rbtOrigen.Checked, True, False)
        cboBuscar.Enabled = True : btnBuscar.Enabled = True
    End Sub

    Private Sub rbtBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cadenaBusqueda As String = cboBuscar.Text
        Dim rbtSelected As String = If(Not IsNothing(GetGrpBxCheckedBbt(gpbTipBusqueda)), GetGrpBxCheckedBbt(gpbTipBusqueda).Text, "")
        Dim dateini As String = If((txtFechaini.Text).Contains("_"), String.Empty, txtFechaini.Value)
        Dim datefin As String = If((txtFechafin.Text).Contains("_"), String.Empty, txtFechafin.Value)
        If rbtSelected IsNot String.Empty Then
            If rbtSelected = "Apellidos y Nombres" Then

                dtgParticipante.DataSource = ParticipanteCN.FiltarParticipanteApeNom(cboBuscar.Text)

            ElseIf rbtSelected = "Local" Then
                If IsDate(dateini) And IsDate(datefin) Then
                    dateini = CDate(dateini).ToString("yyyy-MM-dd")
                    datefin = CDate(datefin).ToString("yyyy-MM-dd")
                    dtgParticipante.DataSource = ParticipanteCN.FiltarParticipanteLocalFecha(cboBuscar.SelectedValue, dateini, datefin)
                Else
                    dtgParticipante.DataSource = ParticipanteCN.FiltarParticipanteLocal(cboBuscar.SelectedValue)
                    txtFechaini.Value = "__/__/____"
                    txtFechafin.Value = "__/__/____"
                End If
            ElseIf rbtSelected = "Origen" Then

                If IsDate(dateini) And IsDate(datefin) Then
                    dtgParticipante.DataSource = ParticipanteCN.FiltarParticipanteOrigenFecha(cboBuscar.SelectedText, dateini, datefin)
                Else
                    dtgParticipante.DataSource = ParticipanteCN.FiltarParticipanteOrigen(cboBuscar.Text)
                End If

            End If
        End If

    End Sub
End Class
