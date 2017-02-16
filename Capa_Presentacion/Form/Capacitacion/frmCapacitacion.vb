Imports System.Windows.Forms
Imports Capa_Entidad
Imports Capa_Negocio
Imports Telerik.WinControls

Public Class frmCapacitacion
    Dim capCN As New CapacitacionCN
    Dim capNewCE As New CapacitacionCE

    Private capEN As CapacitacionCE
    Private value As Integer
    Enum Initialize
        ini = 0
        upd = 1
    End Enum

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        RadMessageBox.SetThemeName("VisualStudio2012Light")
        value = 0
    End Sub

    Public Sub New(capEN As CapacitacionCE)

        InitializeComponent()
        RadMessageBox.SetThemeName("VisualStudio2012Light")
        btnRegistar.DialogResult = DialogResult.OK
        Me.capEN = capEN
        value = 1
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles btnNewLocal.Click
        Dim Frm As New frmLocal()
        Frm.btnRegistrar.DialogResult = DialogResult.OK
        If Frm.ShowDialog(Me) = DialogResult.OK Then
            cboLocal.DataSource = capCN.obtenerLocal()
            cboLocal.DisplayMember = "nombre"
            cboLocal.ValueMember = "codigo"
            cboLocal.SelectedIndex = -1
        End If
    End Sub

    Private Sub frmCapacitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboLocal.DataSource = capCN.obtenerLocal()
        cboLocal.DisplayMember = "nombre"
        cboLocal.ValueMember = "codigo"
        cboOrigen.DropDownListElement.AutoCompleteAppend.LimitToList = True
        Select Case value
            Case Initialize.ini
                LoadDataIni()
            Case Initialize.upd
                loadDataUpdate()
        End Select
    End Sub

    Private Sub loadDataUpdate()
        With capEN
            txtCodigo.Text = .codigo
            cboOrigen.SelectedText = .origen
            txtOrigenOtro.Text = .origenOtro
            txtOrganizador.Text = .organizador
            cboLocal.SelectedValue = .local
            dtmFecha.Value = .fecha
            txtCantMasisa.Value = .cantMasisa
            txtCantIngresado.Value = .cantIngresada
            txtTema.Text = .tema
            txtEspositor.Text = .expositor
        End With
        btnRegistar.Text = "ACTUALIZAR"
        btnLimpiar.Enabled = False
    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        With capNewCE
            .codigo = txtCodigo.Text
            .origen = cboOrigen.Text
            .origenOtro = txtOrigenOtro.Text
            .organizador = txtOrganizador.Text
            .local = cboLocal.SelectedValue
            .cantMasisa = txtCantMasisa.Value
            .cantIngresada = txtCantIngresado.Value
            .fecha = (dtmFecha.Value).ToString("yyyy-MM-dd")
            .tema = txtTema.Text
            .expositor = txtEspositor.Text
        End With
        Select Case value
            Case Initialize.ini
                Dim est As Boolean = If(capCN.registrar(capNewCE), True, False)
                Dim mssj As String = If(est, "SE REGISTRO CORRECTAMENTE", "OCURRIO UN ERROR,VUELVA A REGISTRAR")
                mssje(est, mssj) : Limpiar()
            Case Initialize.upd
                Dim est As Boolean = If(capCN.actualizar(capNewCE), True, False)
                Dim mssj As String = If(est, "SE ACTUALIZO CORRECTAMENTE", "OCURRIO UN ERROR,VUELVA A INTENTAR")
                mssje(est, mssj)
        End Select

    End Sub
    Sub mssje(est As Boolean, mssj As String)
        If est Then
            RadMessageBox.Show(mssj, "", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else
            RadMessageBox.Show(mssj, "", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If
    End Sub
    Sub LoadDataIni()
        txtCodigo.Text = capCN.capacitacion_CodAutogenerado()
        dtmFecha.Value = Now
        cboLocal.SelectedIndex = -1
    End Sub
    Sub Limpiar()
        LoadDataIni()
        txtOrganizador.Clear()
        txtCantMasisa.Value = 0
        txtCantIngresado.Value = 0
        cboOrigen.SelectedIndex = -1
        dtmFecha.Value = Now
        txtTema.Clear()
        txtEspositor.Clear()
        cboLocal.SelectedIndex = -1
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub cboOrigen_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cboOrigen.SelectedIndexChanged
        If cboOrigen.SelectedIndex = 3 Then
            txtOrigenOtro.Visible = True
            txtOrigenOtro.Clear()
        Else
            txtOrigenOtro.Visible = False
            txtOrigenOtro.Clear()
        End If
    End Sub

    Private Sub cboLocal_Enter(sender As Object, e As EventArgs) Handles cboLocal.Enter
        'cboLocal.DataSource = capCN.obtenerLocal()
        'cboLocal.DisplayMember = "nombre"
        'cboLocal.ValueMember = "codigo"
    End Sub
End Class
