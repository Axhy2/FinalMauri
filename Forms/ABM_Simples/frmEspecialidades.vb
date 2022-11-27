Public Class frmEspecialidades
    Private Sub frmEspecialidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 300
        ocultarID(dgvEspecialidades, 0)
        llenar("select *from especialidades", dgvEspecialidades) ', "especialidades")
        If wfrm = 1 Or wfrm = 2 Then
            dgvEspecialidades.Select()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ABM_Propietarios.Click
        Me.Width = 550

    End Sub

    Private Sub dgvEspecialidades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEspecialidades.CellClick
        txtbox_especialidad.Text = $"{dgvEspecialidades.CurrentRow.Cells(0).Value}"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rnd As New Random()
        Panel1.BackColor = Color.FromArgb(255, rnd.Next(0, 255), 255, rnd.Next(0, 255)) 'Transparencia, rojo, verde, azul'
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Cambio(frm_Main, Me)
    End Sub

    Private Sub btn_insert_Propietarios_Click(sender As Object, e As EventArgs) Handles btn_insert_Propietarios.Click
        If (txtbox_especialidad.Text <> "") Then
            crear($"insert into especialidades
                values('{txtbox_especialidad.Text}')",
                "select *from especialidades", dgvEspecialidades)
            Me.Width = 300
            borrartxtbox(Me)
        Else
            MsgBox("Ingrese el campo")
        End If
    End Sub

    Private Sub btn_delete_Propietarios_Click(sender As Object, e As EventArgs) Handles btn_delete_Propietarios.Click
        If (txtbox_especialidad.Text <> "") Then
            borrar(
            $"DELETE FROM especialidades WHERE id_especialidad={dgvEspecialidades.CurrentRow.Cells(0).Value};",
            "select *from especialidades", dgvEspecialidades)
            Me.Width = 300
            borrartxtbox(Me)


        Else
            MsgBox("Ingrese el campo")
        End If
    End Sub

    Private Sub btn_update_Propietarios_Click(sender As Object, e As EventArgs) Handles btn_update_Propietarios.Click
        If (txtbox_especialidad.Text <> "") Then
            actualizar($"Update especialidades
            SET desc_esp = '{txtbox_especialidad.Text}'
            WHERE id_especialidad = {dgvEspecialidades.CurrentRow.Cells(0).Value};",
            "select *from especialidades", dgvEspecialidades)
            Me.Width = 300
            borrartxtbox(Me)


        Else
            MsgBox("Ingrese el campo")
        End If
    End Sub

    Private Sub dgvEspecialidades_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvEspecialidades.KeyDown
        If wfrm = 1 Then
            If e.KeyData = Keys.Enter Then
                wfrm = 0
                Me.Close()
            End If
        ElseIf wfrm = 2 Then
            If e.KeyData = Keys.Enter Then
                wfrm = 0
                Me.Close()
            End If
        End If
    End Sub
    Private Sub dgvEspecialidades_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEspecialidades.SelectionChanged
        If wfrm = 1 Then
            Dim frm As frmOperarios = CType(Owner, frmOperarios)
            frm.txtbox_operario_ID_especialidad.Text = dgvEspecialidades.CurrentRow.Cells(0).Value
            frm.lblConfirmacion.Text = dgvEspecialidades.CurrentRow.Cells(1).Value
        ElseIf wfrm = 2 Then
            Dim frm As frmTareas = CType(Owner, frmTareas)
            frm.txtboxEspecialidades.Text = dgvEspecialidades.CurrentRow.Cells(0).Value
            frm.lblConfirmacion.Text = dgvEspecialidades.CurrentRow.Cells(1).Value
        End If
    End Sub


End Class