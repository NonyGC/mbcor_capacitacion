﻿Public Class Menu
    Private Sub RadButton3_Click(sender As Object, e As EventArgs)
        frmCapacitacion.Show()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        frmFicha.Show()
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        FrmLocalListado.Show()
        'frmLocal.Show()
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        FrmListadoCapacitacion.Show()
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        FrmListParticipante.Show()
    End Sub

    Private Sub RadButton3_Click_1(sender As Object, e As EventArgs) Handles RadButton3.Click
        frmReportePartCatFech.Show()
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click

    End Sub

    Private Sub RadButton7_Click(sender As Object, e As EventArgs) Handles RadButton7.Click
        FrmReporte_Parti_EmaCel.Show()
    End Sub
End Class