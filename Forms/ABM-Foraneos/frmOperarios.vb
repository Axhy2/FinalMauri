
Public Class frmOperarios
    Dim join As String = "especialidades"
    Private Sub frmPropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 352

        query_read = $"
                SELECT id_operario, es.id_especialidad,nombre_operario as Operario,es.desc_esp as Especialidad,importe_hora as [Importe x hora]
                FROM {dgv} as op
                INNER JOIN {join} as es
                ON op.id_especialidad = es.id_especialidad;"
        llenar(query_read, dgvOperarios)
        ocultarID(dgvOperarios, 0)
        ocultarID(dgvOperarios, 1)

    End Sub

    Private Sub btn_ABM_especialidades_Click(sender As Object, e As EventArgs) Handles btn_ABM.Click
        Me.Width = 613
        borrartxtbox(Me)
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Cambio(frm_Main, Me)
    End Sub

    Private Sub btn_insert_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If (txtbox_nombre_operario.Text <> "") Then
            query_create = $"insert into operarios(id_especialidad,nombre_operario,importe_hora)
             values({txtbox_operario_ID_especialidad.Text},'{txtbox_nombre_operario.Text}',{txtbox_operario_importe_hora.Text.Replace(",", ".")})"
            crear(query_create, query_read, dgvOperarios)
            Me.Width = 352
            borrartxtbox(Me)
        Else
            MsgBox("Ingrese el/los campo/s")
        End If
    End Sub

    Private Sub btn_delete_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_delete.Click


        If (lblID.Text <> "Código") Then
            query_delete = $"
            DELETE FROM {dgv} WHERE id_operario={dgvOperarios.CurrentRow.Cells(0).Value};"
            borrar(query_delete, query_read, dgvOperarios)
            Me.Width = 352
            borrartxtbox(Me)
            lblID.Text = "Código"
        Else
            MsgBox("Seleccione el campo a eliminar")
        End If
    End Sub

    Private Sub btn_update_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        query_update = $"
            Update {dgv}
            SET nombre_operario = '{txtbox_nombre_operario.Text}',importe_hora='{txtbox_operario_importe_hora.Text.Replace(",", ".")}',ID_especialidad='{txtbox_operario_ID_especialidad.Text}'
            WHERE id_operario = {dgvOperarios.CurrentRow.Cells(0).Value};"
        If (lblID.Text <> "Código") Then
            actualizar(query_update, query_read, dgvOperarios)
            Me.Width = 352
            borrartxtbox(Me)
            lblID.Text = "Código"
        ElseIf txtbox_operario_ID_especialidad.Text = "" Then
            MsgBox($"Para autoseleccionar {join}, presione enter sobre el campo VACÍO")
        Else
            MsgBox("Seleccione el campo a actualizar")
        End If
    End Sub


    Private Sub txtbox_operario_ID_especialidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_operario_ID_especialidad.KeyDown

        If txtbox_operario_ID_especialidad.Text = "" Then
            If e.KeyData = Keys.Enter Then
                wfrm = 1
                Dim frm As New frmEspecialidades
                AddOwnedForm(frm)
                frm.ShowDialog()

            End If
        End If

    End Sub

    Private Sub dgvOperarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOperarios.CellClick
        If dgvOperarios.RowCount <> 0 Then
            lblID.Text = $"{dgvOperarios.CurrentRow.Cells(0).Value}"
            txtbox_operario_ID_especialidad.Text = $"{dgvOperarios.CurrentRow.Cells(1).Value}"
            txtbox_nombre_operario.Text = $"{dgvOperarios.CurrentRow.Cells(2).Value}"
            lblConfirmacion.Text = $"{dgvOperarios.CurrentRow.Cells(3).Value}"
            txtbox_operario_importe_hora.Text = $"{dgvOperarios.CurrentRow.Cells(4).Value}"

        End If
    End Sub
End Class