Imports System.Data.SqlClient
Imports Capa_Entidad
Public Class ParticipanteDAO
    Inherits BaseDao
    Public Function participante_codauto(codini As String) As String
        Dim cmd As SqlCommand = CommandProcedure("sp_codigoauto_parti")
        cmd.Parameters.AddWithValue("@ini", codini)
        Dim codigo As String
        codigo = cmd.ExecuteScalar
        Return codigo
    End Function

    Public Function participante_table() As DataTable
        Dim cmd As SqlCommand = CommandText("SELECT *  FROM participante")
        Dim data As New DataTable
        data = GetDataTable(cmd)
        Return data
    End Function

    Public Function cargarAutocompletado_buscar(rbtSelected As String) As Object
        Dim cmd As New SqlCommand
        Dim data As New DataTable
        If rbtSelected = "Apellidos y Nombres" Then
            cmd = CommandText("SELECT codigo,CONCAT(apellido_pat,' ',apellido_mat,' ',nombres) nombre FROM [dbo].[participante]")
        ElseIf rbtSelected = "Local" Then
            cmd = CommandText("SELECT codigo,nombre FROM local")
        ElseIf rbtSelected = "Origen" Then
            cmd = CommandText("SELECT DISTINCT CASE WHEN origen='Otros' THEN origen+' '+origOtro ELSE origen END AS nombre FROM capacitacion")
        End If
        data = GetDataTable(cmd)
        Return data
    End Function

    Public Function FiltarParticipanteApeNom(text As String) As DataTable
        Dim cmd As SqlCommand =
            CommandText("SELECT * FROM [dbo].[participante] where codigo=@codigo")
        cmd.Parameters.AddWithValue("@codigo", text)
        Dim data As New DataTable
        data = GetDataTable(cmd)
        Return data
    End Function

    Public Function FiltarParticipanteLocalFecha(selectedValue As Object, dateini As String, datefin As String) As Object
        Dim cmd As SqlCommand = CommandText("SELECT P.codigo,apellido_pat,apellido_mat,nombres,sexo,fecha_nacimiento,dni_ce,direccion,ubigeo,tel_fijo,tel_mol,ope_movil,tel_fijo2,tel_mol2,ope_movil2,email,estado_civ,profe_ocupa FROM [dbo].[participante] P INNER JOIN [dbo].[ficha_capacitacion] FC ON P.codigo=FC.codpar INNER JOIN [dbo].[capacitacion] C ON FC.codcap=C.codigo WHERE c.local=@local AND C.fecha BETWEEN @ini AND @fin")
        cmd.Parameters.AddWithValue("@local", selectedValue)
        cmd.Parameters.AddWithValue("@ini", dateini)
        cmd.Parameters.AddWithValue("@fin", datefin)
        Dim data As New DataTable
        data = GetDataTable(cmd)
        Return data
    End Function

    Public Function Participante_AutocompleteProfeOcu() As DataTable
        Dim cmd As SqlCommand =
            CommandText("Select DISTINCT [profe_ocupa] FROM [dbmass].[dbo].[participante] WHERE [profe_ocupa]<>''")
        Dim data As New DataTable
        data = GetDataTable(cmd)
        Return data
    End Function

    Public Function FiltarParticipanteLocal(selectedValue As Object) As DataTable
        Dim cmd As SqlCommand =
            CommandText("SELECT P.codigo,apellido_pat,apellido_mat,nombres,sexo,fecha_nacimiento,dni_ce,direccion,ubigeo,tel_fijo,tel_mol,ope_movil,tel_fijo2,tel_mol2,ope_movil2,email,estado_civ,profe_ocupa FROM [dbo].[participante] P INNER JOIN [dbo].[ficha_capacitacion] FC ON P.codigo=FC.codpar INNER JOIN [dbo].[capacitacion] C ON FC.codcap=C.codigo WHERE c.local=@local")
        cmd.Parameters.AddWithValue("@local", selectedValue)
        Dim data As New DataTable
        data = GetDataTable(cmd)
        Return data
    End Function

    Public Function FiltarParticipanteOrigenFecha(selectedValue As Object, dateini As String, datefin As String) As Object
        Dim cmd As SqlCommand = CommandText("SELECT P.codigo,apellido_pat,apellido_mat,nombres,sexo,fecha_nacimiento,dni_ce,direccion,ubigeo,tel_fijo,tel_mol,ope_movil,tel_fijo2,tel_mol2,ope_movil2,email,estado_civ,profe_ocupa FROM [dbo].[participante] P INNER JOIN [dbo].[ficha_capacitacion] FC ON P.codigo=FC.codpar INNER JOIN [dbo].[capacitacion] C ON FC.codcap=C.codigo WHERE CASE WHEN C.origen='OTROS' THEN C.origen+' '+origOtro ELSE C.origen END=@origen  AND C.fecha BETWEEN @ini AND @fin")
        cmd.Parameters.AddWithValue("@origen", selectedValue)
        cmd.Parameters.AddWithValue("@ini", dateini)
        cmd.Parameters.AddWithValue("@fin", datefin)
        Dim data As New DataTable
        data = GetDataTable(cmd)
        Return data
    End Function

    Public Function FiltarParticipanteOrigen(SelectedText As Object) As DataTable
        Dim cmd As SqlCommand = CommandText("SELECT P.codigo,apellido_pat,apellido_mat,nombres,sexo,fecha_nacimiento,dni_ce,direccion,ubigeo,tel_fijo,tel_mol,ope_movil,tel_fijo2,tel_mol2,ope_movil2,email,estado_civ,profe_ocupa FROM [dbo].[participante] P INNER JOIN [dbo].[ficha_capacitacion] FC ON P.codigo=FC.codpar INNER JOIN [dbo].[capacitacion] C ON FC.codcap=C.codigo WHERE CASE WHEN C.origen='OTROS' THEN C.origen+' '+origOtro ELSE C.origen END=@origen")
        cmd.Parameters.AddWithValue("@origen", SelectedText)
        Dim data As New DataTable
        data = GetDataTable(cmd)
        Return data
    End Function

    Public Function participante_insert(part As ParticipanteCE) As Boolean
        Try
            Dim i As Integer
            Dim cmd As SqlCommand = CommandProcedure("spParticipante_insert")
            With part
                cmd = Parameters(cmd, { .codpart, .apePat, .apeMat, .nombres, .sexo, .fechaNaci, .dnice, .direccion, .ubigeo, .telFijo, .telMovil, .opeMovil, .telFijo2, .telMovil2, .opeMovil2, .correo, .EstadoCiv, .profeOcupa, .procarre, .nivestudio, .nomInstitucion, .instEducativa, .empresa, .ruc, .cargo, .telFijoEmp, .telMovEmp, .opeMovEmp, .rubro, .espRubroOtros, .espRubroSectorPE, "NEW DB"})
            End With
            i = cmd.ExecuteNonQuery
            Return If(i > 0, True, False)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            CloseDB()
        End Try
    End Function

    Public Function participanteUpdate(part As ParticipanteCE) As Boolean
        Try
            Dim i As Integer
            Dim cmd As SqlCommand = CommandProcedure("spParticipante_update")
            With part
                cmd = Parameters(cmd, { .codpart, .apePat, .apeMat, .nombres, .sexo, .fechaNaci, .dnice, .direccion, .ubigeo, .telFijo, .telMovil, .opeMovil, .telFijo2, .telMovil2, .opeMovil2, .correo, .EstadoCiv, .profeOcupa, .procarre, .nivestudio, .nomInstitucion, .instEducativa, .empresa, .ruc, .cargo, .telFijoEmp, .telMovEmp, .opeMovEmp, .rubro, .espRubroOtros, .espRubroSectorPE})
            End With
            i = cmd.ExecuteNonQuery
            Return If(i > 0, True, False)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            CloseDB()
        End Try
    End Function

#Region "frm filter participante"
    Public Function CargarParticipante_tabla_codcapacitacion(cod As String) As DataTable
        Dim cmd As SqlCommand = CommandProcedure("uspGetPartiByCapacitacion")
        cmd = Parameters(cmd, {cod})
        Dim data As New DataTable
        data = GetDataTable(cmd)
        Return data
    End Function
#End Region
End Class