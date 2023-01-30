Imports System.Data.SqlClient
Public Class Form2
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim mensaje, sentencia As String

    Sub Ejecutarsql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        Try
            Dim da As New SqlDataAdapter("Select * from GA1", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        sentencia = "Delete GA1 where ID='" + txt_id.Text + "'"
        mensaje = "Usuario eliminado"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from GA1", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        sentencia = "Update GA1 set ID=" + txt_id.Text + ", NOMBRE='" + txt_nombre.Text + "', CORREO='" + txt_correo.Text + "', PAIS='" + txt_pais.Text + "', OCUPACION='" + txt_ocupacion.Text + "'"
        mensaje = "Usuario Actualizado"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from GA1", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim da As New SqlDataAdapter("Select * from GA1 Where NOMBRE='" + txt_nombre.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DGV.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Application.Exit()
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        sentencia = "Insert into GA1 values(" + txt_id.Text + ",'" + txt_nombre.Text + "','" + txt_correo.Text + "','" + txt_pais.Text + "','" + txt_ocupacion.Text + "')"
        mensaje = "Usuario registrado"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from GA1", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class