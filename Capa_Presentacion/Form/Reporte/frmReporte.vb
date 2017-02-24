Imports System.Windows.Forms
Imports Capa_Negocio
Imports Capa_Presentacion.Base

Public Class frmReporte
    Dim rptCN As New ReporteCN
    Dim LocalCN As New LocalCN
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDepartamento.DataSource = LocalCN.ubigeo_Departamento()
        cboDepartamento.DisplayMember = "Departamento"
        cboDepartamento.ValueMember = "idDep"
        cboDepartamento.SelectedIndex = -1
    End Sub

    Private Sub rbtLocal_CheckedChanged(sender As Object, e As EventArgs) Handles rbtLocal.CheckedChanged, rbtOrigen.CheckedChanged, rbtRubro.CheckedChanged
        cboBuscar.Enabled = True
    End Sub


    Private Sub cboBuscar_Enter(sender As Object, e As EventArgs) Handles cboBuscar.Enter
        Dim rbtSelected As String = If(Not IsNothing(GetGrpBxCheckedBbt(gpbTipBusqueda)), GetGrpBxCheckedBbt(gpbTipBusqueda).Text, "")
        If rbtSelected IsNot String.Empty Then
            cboBuscar.DataSource = rptCN.cargarAutocompletado_buscar(rbtSelected)
            cboBuscar.DisplayMember = "nombre"
            If GetGrpBxCheckedBbt(gpbTipBusqueda).Text <> "ORIGEN" Then cboBuscar.ValueMember = "codigo"
            cboBuscar.SelectedIndex = -1
        End If
    End Sub

    Sub cargarUbigeoProvincia()
        Dim idDep As String = Trim(cboDepartamento.SelectedValue)
        If idDep IsNot String.Empty Then
            cboProvincia.DataSource = LocalCN.ubigeo_Provincia(idDep)
            cboProvincia.ValueMember = "idProv"
            cboProvincia.DisplayMember = "Provincia"
        End If
    End Sub
    Sub cargarUbigeoDistrito()
        Dim idDep As String = Trim(cboDepartamento.SelectedValue)
        Dim idProv As String = Trim(cboProvincia.SelectedValue)
        If idDep IsNot String.Empty And idProv IsNot String.Empty Then
            idDep = cboDepartamento.SelectedValue
            cboDistrito.DataSource = LocalCN.ubigeo_Distrito(idDep, idProv)
            cboDistrito.ValueMember = "idDist"
            cboDistrito.DisplayMember = "Distrito"
        End If
    End Sub

    Private Sub cboProvincia_Enter(sender As Object, e As EventArgs) Handles cboProvincia.Enter
        cargarUbigeoProvincia()
    End Sub

    Private Sub cboDistrito_Enter(sender As Object, e As EventArgs) Handles cboDistrito.Enter
        cargarUbigeoDistrito()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click


    End Sub

    Dim now = Date.Now
    Dim startOfMonth = New DateTime(now.Year, now.Month, 1)
    Dim DaysInMonth = Date.DaysInMonth(now.Year, now.Month)
    Dim lastDay = New DateTime(now.Year, now.Month, DaysInMonth)

    Private Sub cboFecha_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cboFecha.SelectedIndexChanged
        If cboFecha.SelectedIndex = 3 Then
            txtFechaini.Value = CDate(startOfMonth).ToString("dd/MM/yyyy")
            txtFechafin.Value = CDate(lastDay).ToString("dd/MM/yyyy")
        End If
        If cboFecha.SelectedIndex = 1 Then
            txtFechaini.Value = CDate(now).ToString("dd/MM/yyyy")
            txtFechafin.Value = CDate(now).ToString("dd/MM/yyyy")
        End If
    End Sub
End Class
