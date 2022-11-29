Imports System.ComponentModel

Public Class frm_login
    Private Sub Login(query)
        cmd.Connection = Functions.conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = query
        dr = cmd.ExecuteReader
        Try

            If dr.HasRows Then
                Dim frm As New frm_Main
                frm.Show()
                dr.Close()
                Me.Close()
            Else
                dr.Close()
                MsgBox("Usuario o contraseña incorrectos - Intentalo nuevamente", MsgBoxStyle.Critical, "Error al Ingresar")
                txtbox_User.Clear()
                txtbox_Password.Clear()
                txtbox_User.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Confirm_Click(sender As Object, e As EventArgs) Handles btn_Confirm.Click
        Login($"select *from usuarios where usuario='{txtbox_User.Text}' and pass='{txtbox_Password.Text}'")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        desconectar()
        Cambio(frmPresupuestos_Tareas, Me)
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
    End Sub

    Private Sub frm_login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        desconectar()
    End Sub

    Private Sub btnFisu_Click(sender As Object, e As EventArgs) Handles btnFisu.Click
        Cambio(frm_Main, Me)
    End Sub
End Class
