Imports System.Windows.Forms
Imports Capa_Entidad
Imports Capa_Negocio
Imports Capa_Presentacion.Base
Imports Telerik.WinControls

Public Class FrmEncuesta
    Private codcap As String
    Private encCE As EncuestaCE
    Dim EncCN As New EncuestaCN

    Private Value As Integer
    Enum Initialize
        inicio = 0
        reinicio = 1
    End Enum

    'Esta llamada ocurre cuadno se necesita actualizar la encuesta guardada anteriormente
    'Public Sub New(encCE As EncuestaCE)
    '    InitializeComponent()
    '    Me.encCE = encCE
    '    RadMessageBox.SetThemeName("VisualStudio2012Light")
    '    Value = 1
    'End Sub
    Public Sub New(codcap As String)
        InitializeComponent()
        RadMessageBox.SetThemeName("VisualStudio2012Light")
        Me.codcap = codcap
        Value = 0
    End Sub
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        RadMessageBox.SetThemeName("VisualStudio2012Light")
        If EncuestaSharedCE.codcap IsNot Nothing Then
            Value = 1
            codcap = EncuestaSharedCE.codcap
        End If
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim rbtDominioTem As RadioButton = GetRbtChekedInGroupbx(grpRessin1)
        Dim rbtDejaEntender As RadioButton = GetRbtChekedInGroupbx(grpRessin2)
        Dim rbtFueInteresante As RadioButton = GetRbtChekedInGroupbx(grpRessin3)
        Dim rbtExtCharla As RadioButton = GetRbtChekedInGroupbx(grpRessin4)
        Dim rbtvisitaPagina As RadioButton = GetRbtChekedInGroupbx(grpRessin5)
        Dim rbtTargeta As RadioButton = GetRbtChekedInGroupbx(grpTajetacredito)

        EncuestaSharedCE.resetEncuestaSharedCE()
        EncuestaSharedCE.codcap = codcap
        EncuestaSharedCE.charla = getCheckboxVal(grpCharla)
        EncuestaSharedCE.espCharla = txtEspeCharla.Text
        EncuestaSharedCE.dominioTem = If(Not IsNothing(rbtDominioTem), rbtDominioTem.Text, String.Empty)
        EncuestaSharedCE.dejaEntender = If(Not IsNothing(rbtDejaEntender), rbtDejaEntender.Text, String.Empty)
        EncuestaSharedCE.fueInteresante = If(Not IsNothing(rbtFueInteresante), rbtFueInteresante.Text, String.Empty)
        EncuestaSharedCE.extCharla = If(Not IsNothing(rbtExtCharla), rbtExtCharla.Text, String.Empty)
        EncuestaSharedCE.visitaPagina = If(Not IsNothing(rbtvisitaPagina), rbtvisitaPagina.Text, String.Empty)
        EncuestaSharedCE.otroTema = txtTematratar.Text
        EncuestaSharedCE.targeta = If(Not IsNothing(rbtTargeta), rbtTargeta.Text, String.Empty)
        Close()
        'Dim ExecEncu As Boolean = If(EncCN.Encuesta_Registrar(EncCE), True, False)

        'If ExecEncu Then
        '    RadMessageBox.Show("SE REGISTRO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info)
        'Else
        '    RadMessageBox.Show("OCURRIO UN ERROR,VUELVA A REGISTRAR", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Error)
        'End If
    End Sub

    Private Sub FrmEncuesta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Value
            Case Initialize.reinicio
                SetValueControls()
        End Select
    End Sub

    Private Sub SetValueControls()
        CheckboxCheckedInGroup(grpCharla, EncuestaSharedCE.charla)
        txtEspeCharla.Text = EncuestaSharedCE.espCharla
        RadioBtnCheckedInGroup(grpRessin1, EncuestaSharedCE.dominioTem)
        RadioBtnCheckedInGroup(grpRessin2, EncuestaSharedCE.dejaEntender)
        RadioBtnCheckedInGroup(grpRessin3, EncuestaSharedCE.fueInteresante)
        RadioBtnCheckedInGroup(grpRessin4, EncuestaSharedCE.extCharla)
        RadioBtnCheckedInGroup(grpRessin5, EncuestaSharedCE.visitaPagina)
        txtTematratar.Text = EncuestaSharedCE.otroTema
        RadioBtnCheckedInGroup(grpTajetacredito, EncuestaSharedCE.targeta)
    End Sub
    Sub CheckboxCheckedInGroup(grpBx As GroupBox, value As String)
        Dim chbxText() As String = value.Split("-"c)
        For Each element As Control In grpBx.Controls
            If TypeOf element Is CheckBox Then
                For Each text As String In chbxText
                    If DirectCast(element, CheckBox).Text = text Then
                        DirectCast(element, CheckBox).Checked = True
                    End If
                Next
            End If
        Next
    End Sub
    Sub RadioBtnCheckedInGroup(grpBx As GroupBox, value As String)
        Dim rButton As RadioButton = grpBx.Controls.OfType(Of RadioButton).Where(Function(r) r.Text = value).FirstOrDefault()
        rButton.Checked = True
    End Sub

End Class