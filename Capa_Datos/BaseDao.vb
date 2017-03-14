Imports System.Configuration
Imports System.Data.SqlClient

Public Class BaseDao

    Dim conexion As SqlConnection
    Public Function conectar() As SqlConnection
        conexion = New SqlConnection
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
        ConfigurationManager.RefreshSection("connectionStrings")
        conexion.ConnectionString = ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Try
            conexion.Open()
        Catch ex As Exception
            conexion = Nothing
            MsgBox("SIN CONEXION A LA DB")
        End Try
        Return conexion
    End Function

    Protected Function Parameters(cmd As SqlCommand, env() As String) As SqlCommand
        Dim procedure As String = cmd.CommandText
        Try
            SqlCommandBuilder.DeriveParameters(cmd)
            Dim c As Integer = 0

            For Each prm As SqlParameter In cmd.Parameters
                If prm.ParameterName <> "@RETURN_VALUE" Then
                    prm.Value = env(c)
                    c += 1
                    Debug.WriteLine(prm.Value)
                End If
            Next
            Return cmd
        Catch ex As Exception
            Return Nothing
            Debug.WriteLine(procedure & "- " & ex.ToString)
        End Try

    End Function
    Protected Function CommandProcedure(name As String) As SqlCommand
        Dim cmd As New SqlCommand(name, conectar)
        cmd.CommandType = CommandType.StoredProcedure
        Return cmd
    End Function
    Protected Function CommandText(text As String) As SqlCommand
        Dim cmd As New SqlCommand(text, conectar)
        cmd.CommandType = CommandType.Text
        Return cmd
    End Function
    Protected Function GetDataTable(cmd As SqlCommand) As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(dt)
        CloseDB()
        Return dt
    End Function
    Protected Sub CloseDB()
        If conexion Is Nothing Then Exit Sub
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
End Class