Imports Capa_Negocio

Public Class frmFiltParticipante
    Private codcap As String
    Dim PartCN As New ParticipanteCN
    Private Value As Integer

    Enum Initialize
        ini = 0
        ext = 1
    End Enum
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Value = 0
    End Sub

    Public Sub New(codcap As String)
        Me.codcap = codcap
        InitializeComponent()
        Value = 1
    End Sub

    Private Sub FrmListParticipanteCapa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtParticipanteCapacitacion As New DataTable
        Select Case Value
            Case Initialize.ini
            Case Initialize.ext
                dtParticipanteCapacitacion = PartCN.CargarParticipante_tabla_codcapacitacion(codcap)
                dtgParticipante.DataSource = dtParticipanteCapacitacion
                lblTotalPaticipante.Text = dtParticipanteCapacitacion.Rows.Count()
        End Select

    End Sub
End Class