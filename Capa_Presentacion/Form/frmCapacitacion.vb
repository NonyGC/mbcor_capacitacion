Imports System.Windows.Forms
Imports Capa_Entidad
Imports Capa_Negocio
Imports Telerik.WinControls

Public Class frmCapacitacion
    Dim capCN As New CapacitacionCN
    Dim capCE As New CapacitacionCE
    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles btnNewLocal.Click
        frmLocal.Show()
    End Sub

    Private Sub frmCapacitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadMessageBox.SetThemeName("VisualStudio2012Light")
        CargarForm()
    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        With capCE
            .codigo = txtCodigo.Text
            .organizador = txtOrganizador.Text
            .local = cboLocal.SelectedValue
            .cantMasisa = txtCantMasisa.Value
            .cantIngresada = txtCantIngresado.Value
            .fecha = (dtmFecha.Value).ToString("yyyy-MM-dd")
            .tema = txtTema.Text
            .expositor=txtEspositor.Text
        End With
        If (capCN.registrar(capCE)) Then
            RadMessageBox.Show("SE REGISTRO CORRECTAMENTE", "", MessageBoxButtons.OK, RadMessageIcon.Info)
            Limpiar()
        Else
            RadMessageBox.Show("OCURRIO UN ERROR,VUELVA A REGISTRAR", "", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If
    End Sub
    Sub CargarForm()
        txtCodigo.Text = capCN.capacitacion_CodAutogenerado()
        cboLocal.DataSource = capCN.obtenerLocal()
        cboLocal.DisplayMember = "nombre"
        cboLocal.ValueMember = "codigo"
        dtmFecha.Value = Now
    End Sub
    Sub Limpiar()
        CargarForm()
        txtOrganizador.Clear()
        txtCantMasisa.Value = 0
        txtCantIngresado.Value = 0
        dtmFecha.Value = Now
        txtTema.Clear()
        txtEspositor.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

End Class
