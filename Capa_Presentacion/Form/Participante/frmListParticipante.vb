Imports System.Windows.Forms
Imports Capa_Entidad
Imports Capa_Negocio
Imports Capa_Presentacion.Base
Imports Telerik.WinControls.UI

Public Class FrmListParticipante
    Dim ParticipanteCN As New ParticipanteCN
    Dim PartCE As New ParticipanteCE

    Private Sub FrmListParticipante_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgParticipante.MasterTemplate.ShowFilterCellOperatorText = False
        dtgParticipante.DataSource = ParticipanteCN.CargarParticipante()

        dtgParticipante.DataSource = ParticipanteCN.CargarParticipante()
        dtgParticipante.MasterTemplate.ShowFilterCellOperatorText = False
        cboBuscar_AutoComparer()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim Frm As New FrmParticipante_vb()

        If Frm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            dtgParticipante.DataSource = ParticipanteCN.CargarParticipante()
        End If
        Frm.Dispose()

    End Sub

    Private Sub dtgParticipantes_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgParticipante.CellDoubleClick

        With dtgParticipante.CurrentRow
            PartCE.codpart = .Cells("codigo").Value
            PartCE.apePat = .Cells("apellido_pat").Value
            PartCE.apeMat = .Cells("apellido_mat").Value
            PartCE.nombres = .Cells("nombres").Value
            PartCE.sexo = .Cells("sexo").Value
            PartCE.fechaNaci = .Cells("fecha_nacimiento").Value
            PartCE.dnice = If(IsDBNull(.Cells("dni_ce").Value), String.Empty, .Cells("dni_ce").Value)
            PartCE.direccion = .Cells("direccion").Value
            PartCE.ubigeo = .Cells("ubigeo").Value
            PartCE.telFijo = .Cells("tel_fijo").Value
            PartCE.telMovil = .Cells("tel_mol").Value
            PartCE.opeMovil = .Cells("ope_movil").Value
            PartCE.telFijo2 = .Cells("tel_fijo2").Value
            PartCE.telMovil2 = .Cells("tel_mol2").Value
            PartCE.opeMovil2 = .Cells("ope_movil2").Value
            PartCE.correo = .Cells("email").Value
            PartCE.EstadoCiv = .Cells("estado_civ").Value
            PartCE.profeOcupa = .Cells("profe_ocupa").Value
            PartCE.procarre = .Cells("profesion_carrera").Value
            PartCE.nivestudio = .Cells("nivel").Value
            PartCE.nomInstitucion = .Cells("institucion").Value
            PartCE.instEducativa = .Cells("tip_institucion").Value
            PartCE.ruc = .Cells("ruc").Value
            PartCE.empresa = .Cells("empresa").Value
            PartCE.cargo = .Cells("cargo").Value
            PartCE.telFijoEmp = .Cells("tel_fijo_emp").Value
            PartCE.telMovEmp = .Cells("tel_movil_emp").Value
            PartCE.opeMovEmp = .Cells("ope_movil_emp").Value
            PartCE.rubro = .Cells("rubro").Value
            PartCE.espRubroOtros = .Cells("esp_rubr_otros").Value
            PartCE.espRubroSectorPE = .Cells("esp_rubro_sector").Value
        End With

        Dim Frm As New FrmParticipante_vb(PartCE)
        If Frm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            dtgParticipante.DataSource = ParticipanteCN.CargarParticipante()
        End If

        Frm.Dispose()

    End Sub

    Private Sub rbtApeNom_CheckedChanged(sender As Object, e As EventArgs) Handles rbtApeNom.CheckedChanged
        txtFechaini.Value = "__/__/____"
        txtFechafin.Value = "__/__/____"
        cboBuscar.Enabled = True : btnBuscar.Enabled = True
        cboBuscar.DataSource = Nothing
    End Sub

    Private Sub rbtLocal_CheckedChanged(sender As Object, e As EventArgs) Handles rbtLocal.CheckedChanged
        gpbFecha.Enabled = If(rbtLocal.Checked, True, False)
        cboBuscar.Enabled = True : btnBuscar.Enabled = True
        cboBuscar.DataSource = Nothing
    End Sub

    Private Sub rbtOrigen_CheckedChanged(sender As Object, e As EventArgs) Handles rbtOrigen.CheckedChanged
        gpbFecha.Enabled = If(rbtOrigen.Checked, True, False)
        cboBuscar.Enabled = True : btnBuscar.Enabled = True
        cboBuscar.DataSource = Nothing
    End Sub

    Private Sub rbtBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cboBuscar.SelectedValue IsNot Nothing Then
            Dim cadenaBusqueda As String = cboBuscar.Text
            Dim rbtSelected As String = If(Not IsNothing(GetRbtChekedInGroupbx(gpbTipBusqueda)), GetRbtChekedInGroupbx(gpbTipBusqueda).Text, "")
            Dim dateini As String = If((txtFechaini.Text).Contains("_"), String.Empty, txtFechaini.Value)
            Dim datefin As String = If((txtFechafin.Text).Contains("_"), String.Empty, txtFechafin.Value)
            If rbtSelected IsNot String.Empty Then
                If rbtSelected = "Apellidos y Nombres" Then

                    dtgParticipante.DataSource = ParticipanteCN.FiltarParticipanteApeNom(cboBuscar.SelectedValue)

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
                        dateini = CDate(dateini).ToString("yyyy-MM-dd")
                        datefin = CDate(datefin).ToString("yyyy-MM-dd")
                        dtgParticipante.DataSource = ParticipanteCN.FiltarParticipanteOrigenFecha(cboBuscar.Text, dateini, datefin)
                    Else
                        dtgParticipante.DataSource = ParticipanteCN.FiltarParticipanteOrigen(cboBuscar.Text)
                        txtFechaini.Value = "__/__/____"
                        txtFechafin.Value = "__/__/____"
                    End If

                End If
            End If
        End If
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
        'Dim rdb
        Dim rbtSelected As String = If(Not IsNothing(GetRbtChekedInGroupbx(gpbTipBusqueda)), GetRbtChekedInGroupbx(gpbTipBusqueda).Text, "")
        'Dim dateIni As String
        If rbtSelected IsNot String.Empty Then
            cboBuscar.DataSource = ParticipanteCN.cargarAutocompletado_buscar(rbtSelected)
            If GetRbtChekedInGroupbx(gpbTipBusqueda).Text <> "Origen" Then cboBuscar.ValueMember = "codigo"
            cboBuscar.DisplayMember = "nombre"
            cboBuscar.SelectedIndex = -1
        End If
    End Sub
End Class