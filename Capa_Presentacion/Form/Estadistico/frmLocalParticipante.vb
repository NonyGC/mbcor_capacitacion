Imports Capa_Negocio
Public Class frmLocalParticipante
    Dim EstCN As New EstadisticaCN
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Sub FrmEtdLocalParticipante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLocalParticipante.DataSource = EstCN.Estadistica_PartiLocal()
    End Sub

End Class