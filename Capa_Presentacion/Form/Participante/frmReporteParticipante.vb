Imports Capa_Entidad
Imports Capa_Negocio

Public Class FrmReporteParticipante
    Dim ParticipanteCN As New ParticipanteCN
    Dim PartCE As New ParticipanteCE
    Private Sub FrmReporteParticipante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgParticipante.DataSource = ParticipanteCN.CargarParticipante()
        dtgParticipante.MasterTemplate.ShowFilterCellOperatorText = False
        cboFiltrar.DataSource = LoadCboFiltrar()
        cboFiltrar.ValueMember = "ID"
        cboFiltrar.DisplayMember = "DESCRIPCION"
    End Sub
    Function LoadCboFiltrar() As DataTable
        Dim tbl As New DataTable
        ' Define columns
        tbl.Columns.Add("ID", GetType(String))
        tbl.Columns.Add("DESCRIPCION", GetType(String))
        ' Add a row of data
        tbl.Rows.Add("01", "Apellidos")
        tbl.Rows.Add("02", "Nombres")
        tbl.Rows.Add("03", "Local")
        tbl.Rows.Add("04", "Origen")
        Return tbl
    End Function

End Class
