Imports System.Data.SqlClient
Public Class Form1
    Dim conexion As Conexion = New Conexion
    Dim sentencia, mensaje As String

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Application.Exit()
    End Sub
    Public Sub Ejecutarsql(ByVal sql As String, ByVal msg As String)



    End Sub

    Private Sub btn_siguiente_Click(sender As Object, e As EventArgs) Handles btn_siguiente.Click

        Dim f2 = Form2
        Dim verificar As String = "update LOgA1 set ROLL=ROLL where USUARIO='" + txt_usuario.Text + "' and CONTRASEÑA='" + txt_contraseña.Text + "' and ROLL='Administrador'"
        Dim verificar2 As String = "update LOgA1 set ROLL=ROLL where USUARIO='" + txt_usuario.Text + "' and CONTRASEÑA='" + txt_contraseña.Text + "' and ROLL='Cliente'"
        Dim verificar3 As String = "update LOgA1 set ROLL=ROLL where USUARIO='" + txt_usuario.Text + "' and CONTRASEÑA='" + txt_contraseña.Text + "' and ROLL='Secretaria'"
        If conexion.verificacion(verificar) Then
            Me.Hide()
            Form2.Show()
            f2.lbl_administrador.Visible = True
            f2.lbl_administrador.Text = "Bienvenida Administrador"
        ElseIf conexion.verificacion(verificar2) Then
            Me.Hide()
            Form2.Show()
            f2.btn_borrar.Visible = False
            f2.btn_editar.Visible = False
            f2.btn_insertar.Visible = False
            f2.btn_cargar.Visible = False
            f2.Label1.Visible = False
            f2.Label3.Visible = False
            f2.Label4.Visible = False
            f2.txt_id.Visible = False
            f2.txt_correo.Visible = False
            f2.txt_pais.Visible = False
            f2.btn_borrar.Location = New Point(123, 123)
            f2.lbl_administrador.Visible = True
            f2.lbl_administrador.Text = "Bienvenida usuario"
        ElseIf conexion.verificacion(verificar3) Then
            Me.Hide()
            Form2.Show()
            f2.lbl_administrador.Visible = True
            f2.lbl_administrador.Text = "Bienvenida Secretaria"
        Else
            MsgBox("Error")
        End If
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
