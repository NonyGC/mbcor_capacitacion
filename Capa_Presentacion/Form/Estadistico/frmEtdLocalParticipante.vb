Public Class FrmEtdLocalParticipante
    Private Sub FrmEtdLocalParticipante_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
'Select Case f.codcap codcap,l.nombre nombre,c.fecha fecha,count(*) cantidad from ficha_capacitacion f
'inner join capacitacion c On f.codcap=c.codigo
'inner join local l On c.local=l.codigo group by codcap,fecha,nombre