Imports Capa_Entidad
Imports Capa_Negocio

Public Class FrmListParticipante
    Dim ParticipanteCN As New ParticipanteCN
    Dim PartCE As New ParticipanteCE

    Private Sub FrmListParticipante_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgParticipantes.DataSource = ParticipanteCN.participante_table()
        cboFilterP.DataSource = ParticipanteCN.participante_cargarCapacitacion()
        'lvLocal.ValueMember = "codigo"
        'lvLocal.DisplayMember = "nombre"
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmParticipante_vb.Show()
        'Debug.WriteLine(result)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        With dtgParticipantes.CurrentRow
            PartCE.codpart = .Cells("codigo").Value
            PartCE.apePat = .Cells("apellido_pat").Value
            PartCE.apeMat = .Cells("apellido_mat").Value
            PartCE.nombres = .Cells("nombres").Value
            PartCE.sexo = .Cells("sexo").Value
            PartCE.fechaNaci = .Cells("fecha_nacimiento").Value
            PartCE.dnice = .Cells("dni_ce").Value
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

            ',createat
            ',updateat
        End With

        Dim Frm As New FrmParticipante_vb(PartCE)
        Frm.Show()
        'FrmParticipante_vb.ShowDialog()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        dtgParticipantes.DataSource = ParticipanteCN.participante_table()
    End Sub

    Private Sub dtgParticipantes_Click(sender As Object, e As EventArgs) Handles dtgParticipantes.Click

    End Sub
End Class
