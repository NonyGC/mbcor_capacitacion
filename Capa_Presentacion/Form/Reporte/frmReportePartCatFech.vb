Imports System.Windows.Forms
Imports Capa_Negocio
Imports Capa_Presentacion.Base

Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI.Export

Public Class frmReportePartCatFech
    Dim rptCN As New ReporteCN
    Dim LocalCN As New LocalCN
    Dim ParticipanteCN As New ParticipanteCN
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFecha.SelectedIndex = 0
        dtgParticipante.MasterTemplate.ShowFilterCellOperatorText = False
    End Sub

    Private Sub rbtLocal_CheckedChanged(sender As Object, e As EventArgs) Handles rbtLocal.CheckedChanged, rbtOrigen.CheckedChanged, rbtRubro.CheckedChanged
        cboBuscar.Enabled = True
        cboBuscar.DataSource = Nothing
    End Sub

    Private Sub cboBuscar_Enter(sender As Object, e As EventArgs) Handles cboBuscar.Enter
        Dim rbtSelected As String = If(Not IsNothing(GetRbtChekedInGroupbx(gpbTipBusqueda)), GetRbtChekedInGroupbx(gpbTipBusqueda).Text, "")
        If rbtSelected IsNot String.Empty Then
            cboBuscar.DataSource = rptCN.cargarAutocompletado_buscar(rbtSelected)
            cboBuscar.DisplayMember = "nombre"
            If GetRbtChekedInGroupbx(gpbTipBusqueda).Text <> "ORIGEN" Then cboBuscar.ValueMember = "codigo"
            cboBuscar.SelectedIndex = -1
        End If
    End Sub

    Dim now = Date.Now
    Function stardate(fecha As Date) As Date
        Dim startOfMonth = New Date(fecha.Year, fecha.Month, 1)
        Return startOfMonth
    End Function
    Function enddate(fecha As Date) As Date
        Dim DaysInMonth = Date.DaysInMonth(fecha.Year, fecha.Month)
        Dim lastDay = New Date(fecha.Year, fecha.Month, DaysInMonth)
        Return lastDay
    End Function

    'Dim startOfMonth = New Date(now.Year, now.Month, 1)
    'Dim DaysInMonth = Date.DaysInMonth(now.Year, now.Month)
    'Dim lastDay = New Date(now.Year, now.Month, DaysInMonth)

    Private Sub cboFecha_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cboFecha.SelectedIndexChanged
        txtFechaini.Enabled = True
        txtFechafin.Enabled = True

        If cboFecha.SelectedIndex = 0 Then
            txtFechaini.Value = "__/__/____"
            txtFechafin.Value = "__/__/____"
        End If
        If cboFecha.SelectedIndex = 1 Then
            txtFechaini.Value = CDate(now).ToString("dd/MM/yyyy")
            txtFechafin.Value = CDate(now).ToString("dd/MM/yyyy")
            txtFechaini.Enabled = False
            txtFechafin.Enabled = False
        End If
        If cboFecha.SelectedIndex = 2 Then
            txtFechaini.Value = CDate(now).AddDays(-1).ToString("dd/MM/yyyy")
            txtFechafin.Value = CDate(now).AddDays(-1).ToString("dd/MM/yyyy")
            txtFechaini.Enabled = False
            txtFechafin.Enabled = False
        End If
        If cboFecha.SelectedIndex = 3 Then
            txtFechaini.Value = stardate(Date.Now).ToString("dd/MM/yyyy")
            txtFechafin.Value = enddate(Date.Now).ToString("dd/MM/yyyy")
            txtFechaini.Enabled = False
            txtFechafin.Enabled = False
        End If
        If cboFecha.SelectedIndex = 4 Then
            txtFechaini.Value = stardate(Date.Now.AddMonths(-1)).ToString("dd/MM/yyyy")
            txtFechafin.Value = enddate(Date.Now.AddMonths(-1)).ToString("dd/MM/yyyy")
            txtFechaini.Enabled = False
            txtFechafin.Enabled = False
        End If
        If cboFecha.SelectedIndex = 5 Then
            txtFechaini.Value = Date.Now.AddDays(-29).ToString("dd/MM/yyyy")
            txtFechafin.Value = Date.Now.ToString("dd/MM/yyyy")
            txtFechaini.Enabled = False
            txtFechafin.Enabled = False
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cboBuscar.SelectedValue IsNot Nothing Then
            Dim cadenaBusqueda As String = cboBuscar.Text
            Dim rbtSelected As String = If(Not IsNothing(GetRbtChekedInGroupbx(gpbTipBusqueda)), GetRbtChekedInGroupbx(gpbTipBusqueda).Text, "")
            Dim dateini As String = If((txtFechaini.Text).Contains("_"), String.Empty, txtFechaini.Value)
            Dim datefin As String = If((txtFechafin.Text).Contains("_"), String.Empty, txtFechafin.Value)
            If rbtSelected IsNot String.Empty Then

                If rbtSelected = "LOCAL" Then
                    If IsDate(dateini) And IsDate(datefin) Then
                        dateini = CDate(dateini).ToString("yyyy-MM-dd")
                        datefin = CDate(datefin).ToString("yyyy-MM-dd")
                        dtgParticipante.DataSource = ParticipanteCN.FiltarParticipanteLocalFecha(cboBuscar.SelectedValue, dateini, datefin)
                    Else
                        dtgParticipante.DataSource = ParticipanteCN.FiltarParticipanteLocal(cboBuscar.SelectedValue)
                        txtFechaini.Value = "__/__/____"
                        txtFechafin.Value = "__/__/____"
                    End If
                ElseIf rbtSelected = "ORIGEN" Then

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

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim dialog As New SaveFileDialog()
        dialog.FileName = ""
        dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        If dialog.ShowDialog() = DialogResult.OK Then
            ExportData(dialog.FileName)
        End If
    End Sub

    Private Sub ExportData(fileName As String)
        Dim renderer As New SpreadExportRenderer()
        Dim spreadExporter As New GridViewSpreadExport(dtgParticipante)
        spreadExporter.FreezeHeaderRow = True
        spreadExporter.FreezePinnedColumns = True
        spreadExporter.FreezePinnedRows = True
        spreadExporter.ExportVisualSettings = True
        spreadExporter.SheetMaxRows = ExcelMaxRows._1048576
        spreadExporter.ExportFormat = SpreadExportFormat.Xlsx
        spreadExporter.FileExportMode = FileExportMode.CreateOrOverrideFile
        spreadExporter.RunExport(fileName, renderer)
    End Sub
End Class