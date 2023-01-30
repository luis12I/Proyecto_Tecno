Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Conexion
    Public con As SqlConnection = New SqlConnection(My.Settings.conexion)
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public cmd As SqlCommand

    Public Sub consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, con)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Function verificacion(ByVal sql)
        con.Open()
        cmd = New SqlCommand(sql, con)
        Dim i As Integer = cmd.ExecuteNonQuery
        con.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
