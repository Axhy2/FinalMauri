
Public Class frmTareas
    Dim join As String = "especialidades"
    Private Sub frmPropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 352

        query_read = $"
               SELECT id_tarea, esp.desc_esp as Especialidad,desc_tarea as Descripcion,horas_estandar_tarea as [Horas estándar] 
               FROM tareas
               INNER JOIN especialidades as esp
               ON tareas.id_especialidad = esp.id_especialidad"
        llenar(query_read, dgvTareas)
        ocultarID(dgvTareas, 0)


    End Sub

    Private Sub btn_ABM_especialidades_Click(sender As Object, e As EventArgs) Handles btn_ABM.Click
        Me.Width = 613

    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Cambio(frm_Main, Me)
    End Sub

    Private Sub btn_insert_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If (txtboxDesc.Text <> "") Then
            query_create = $"
             insert into {dgv}
             values({txtboxEspecialidades.Text},'{txtboxDesc.Text}',{txtboxHsStdr.Text})"
            crear(query_create, query_read, dgvTareas)
            Me.Width = 352
            borrartxtbox(Me)
        Else
            MsgBox("Ingrese el/los campo/s")
        End If
    End Sub

    Private Sub btn_delete_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_delete.Click


        If (lblID.Text <> "Código") Then
            query_delete = $"
            DELETE FROM {dgv} WHERE id_tarea={dgvTareas.CurrentRow.Cells(0).Value};"
            borrar(query_delete, query_read, dgvTareas)
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
            SET desc_tarea={txtboxDesc.Text},id_especialidad={txtboxEspecialidades.Text},hs_estandar_tarea='{txtboxHsStdr.Text}'
            WHERE id_tarea = {dgvTareas.CurrentRow.Cells(0).Value};"
        If (lblID.Text <> "Código") Then
            actualizar(query_update, query_read, dgvTareas)
            Me.Width = 352
            borrartxtbox(Me)
            lblID.Text = "Código"
        Else
            MsgBox("Seleccione el campo a actualizar")
            txtboxEspecialidades.Text = $"{dgvTareas.CurrentRow.Cells(0).Value}"


        End If
    End Sub




    Private Sub dgvOperarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTareas.CellClick
        If dgvTareas.RowCount <> 0 Then
            lblID.Text = $"{dgvTareas.CurrentRow.Cells(0).Value}"
            txtboxDesc.Text = $"{dgvTareas.CurrentRow.Cells(2).Value}"
            txtboxHsStdr.Text = $"{dgvTareas.CurrentRow.Cells(3).Value}"

        End If
    End Sub

    Private Sub txtboxAutomoviles_IdPropietario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxEspecialidades.KeyDown

        If txtboxEspecialidades.Text = "" Then
            If e.KeyData = Keys.Enter Then
                wfrm = 2
                Dim frm As New frmEspecialidades
                AddOwnedForm(frm)
                frm.ShowDialog()

            End If
        End If
    End Sub

    Private Sub dgvTareas_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvTareas.KeyDown
        If wfrm = 1 Then
            wfrm = 0
            query_read = $"
                SELECT id_presupuesto,pt.id_tarea,nombre_operario [Nombre operario],t.desc_tarea [Descripción tarea],horas_reales [Horas finales],importe_final [Importe],o.id_especialidad
				FROM presupuestos_Tareas as pt
                INNER JOIN tareas as t
                ON  pt.id_tarea = t.id_tarea
				INNER JOIN operarios as o
                ON  pt.id_operario = o.id_operario"
            Me.Close()

        End If
    End Sub

    Private Sub dgvTareas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTareas.SelectionChanged
        If dgvTareas.RowCount > 0 Then
            If wfrm = 1 Then
                Dim frm As frmPresupuestos_Tareas = CType(Owner, frmPresupuestos_Tareas)
                frm.txtbox2.Text = dgvTareas.CurrentRow.Cells(0).Value

            End If
        End If
    End Sub

End Class

