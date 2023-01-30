
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class conexion
    Public conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Sub abrir()
        Try
            conexion = New SqlConnection(" ")
            conexion.Open()
            MsgBox("Conectado")
        Catch ex As Exception
            MsgBox("no se puede conectar" + ex.ToString)
        End Try
    End Sub

    Function USUARIO(ByVal USUuARIO As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from USUARIO where LOgA1 =" & USUARIO & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            Else
                respuesta.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado

    End Function

    Function CONTRASEÑA(ByVal USUARIO As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("'Select CONTRASEÑA from USUARIO WHERE LOgA1='" & USUARIO & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("CONTRASEÑA")
            Else
                respuesta.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado

    End Function

End Class
