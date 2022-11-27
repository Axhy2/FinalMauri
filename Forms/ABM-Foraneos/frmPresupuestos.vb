Public Class frmPresupuestos
    Dim join As String = "propietarios"
    Private Sub frmPropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 352

        query_read = $"
                SELECT id_presupuesto,pro.id_propietario,pro.nombre_propietario as [Nombre dueño],patente as Patente,desc_presupuesto as Descripcion,fecha_ingreso as Ingreso,fecha_prometida as [Egreso esperado],dias_atraso as Atraso,importe_total As [Importe total]
                FROM presupuestos as pre
                INNER JOIN propietarios as pro
                ON pre.id_propietario = pro.id_propietario"
        llenar(query_read, dgvPresupuestos)
        ocultarID(dgvPresupuestos, 0)
        ocultarID(dgvPresupuestos, 1)

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
             insert into {dgv}(patente,id_propietario,desc_presupuesto,fecha_ingreso,fecha_prometida,dias_atraso,importe_total)
             values({txtboxPatente.Text},{txtboxID_Propietario.Text},'{txtboxDesc.Text}','{datepicker.Text}','{datepicker2.Text}',{txtboxAtraso.Text},{txtboxImp.Text.Replace(",", ".")})"
            crear(query_create, query_read, dgvPresupuestos)
            Me.Width = 352
            borrartxtbox(Me)
        Else
            MsgBox("Ingrese el/los campo/s")
        End If
    End Sub

    Private Sub btn_delete_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        'Inicio delete
        If (lblID.Text <> "Código") Then
            query_delete = $"
            DELETE FROM {dgv} WHERE id_presupuesto={dgvPresupuestos.CurrentRow.Cells(0).Value};"
            borrar(query_delete, query_read, dgvPresupuestos)
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
            SET importe_total={txtboxImp.Text},id_propietario={txtboxID_Propietario.Text},dias_atraso={txtboxAtraso.Text},fecha_ingreso='{datepicker.Text}',fecha_prometida='{datepicker2.Text}',patente='{txtboxPatente.Text}'
            WHERE patente = {dgvPresupuestos.CurrentRow.Cells(0).Value};"
        'Inicio update
        If (lblID.Text <> "Código") Then
            actualizar(query_update, query_read, dgvPresupuestos)
            Me.Width = 352
            borrartxtbox(Me)
            lblID.Text = "Código"
        ElseIf txtboxID_Propietario.Text = "" Then
            MsgBox($"Para autoseleccionar {join}, presione enter sobre el campo VACÍO")
        Else
            MsgBox("Seleccione el campo a actualizar")
        End If
    End Sub








    Private Sub lblMarca_Click(sender As Object, e As EventArgs) Handles lblMarca.Click

    End Sub

    Private Sub dgvPresupuestos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPresupuestos.CellClick
        If dgvPresupuestos.RowCount <> 0 Then
            lblID.Text = $"{dgvPresupuestos.CurrentRow.Cells(0).Value}"
            txtboxID_Propietario.Text = $"{dgvPresupuestos.CurrentRow.Cells(1).Value}"
            lblConfirmacion2.Text = $"{dgvPresupuestos.CurrentRow.Cells(2).Value}"
            txtboxPatente.Text = $"{dgvPresupuestos.CurrentRow.Cells(3).Value}"
            txtboxDesc.Text = $"{dgvPresupuestos.CurrentRow.Cells(4).Value}"
            txtboxIngreso.Text = $"{dgvPresupuestos.CurrentRow.Cells(5).Value}"
            txtboxEgreso.Text = $"{dgvPresupuestos.CurrentRow.Cells(6).Value}"
            txtboxAtraso.Text = $"{dgvPresupuestos.CurrentRow.Cells(7).Value}"
            txtboxImp.Text = $"{dgvPresupuestos.CurrentRow.Cells(8).Value}"
        End If
    End Sub

    Private Sub datepicker_ValueChanged(sender As Object, e As EventArgs) Handles datepicker.ValueChanged
        datepicker2.Value = datepicker.Value

    End Sub

    Private Sub txtboxPatente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxPatente.KeyDown
        If txtboxPatente.Text = "" Then
            If e.KeyData = Keys.Enter Then
                wfrm = 1
                Dim frm As New frmAutomoviles
                AddOwnedForm(frm)
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub txtboxAutomoviles_IdPropietario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxID_Propietario.KeyDown
        If txtboxID_Propietario.Text = "" Then
            If e.KeyData = Keys.Enter Then
                wfrm = 2
                Dim frm As New frmPropietarios
                AddOwnedForm(frm)
                frm.ShowDialog()
            End If
        End If
    End Sub


End Class
