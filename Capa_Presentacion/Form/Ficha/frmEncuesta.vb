Imports System.Windows.Forms
Imports Capa_Entidad
Imports Capa_Negocio
Imports Capa_Presentacion.Base
Imports Telerik.WinControls

Public Class FrmEncuesta
    Private codcap As String
    Dim EncCE As New EncuestaCE
    Dim EncCN As New EncuestaCN
    Public Sub New(codcap As String)
        InitializeComponent()
        RadMessageBox.SetThemeName("VisualStudio2012Light")
        Me.codcap = codcap
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        With EncCE
            .codcap = codcap
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
        Dim ExexEncu As Boolean = If(EncCN.Encuesta_Registrar(EncCE), True, False)

        If ExexEncu Then
            RadMessageBox.Show("SE REGISTRO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else
            RadMessageBox.Show("OCURRIO UN ERROR,VUELVA A REGISTRAR", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If
        Close()
    End Sub

    Private Sub FrmEncuesta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub
End Class