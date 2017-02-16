Imports Capa_Entidad
Imports Capa_Negocio

Public Class FrmListParticipante
    Dim ParticipanteCN As New ParticipanteCN
    Dim PartCE As New ParticipanteCE

    Private Sub FrmListParticipante_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgParticipante.MasterTemplate.ShowFilterCellOperatorText = False
        dtgParticipante.DataSource = ParticipanteCN.CargarParticipante()
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
            PartCE.espRubro = .Cells("cargo").Value
            PartCE.origen = .Cells("espec_rubro").Value
        End With

        Dim Frm As New FrmParticipante_vb(PartCE)
        If Frm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            dtgParticipante.DataSource = ParticipanteCN.CargarParticipante()
        End If

        Frm.Dispose()

    End Sub
End Class
