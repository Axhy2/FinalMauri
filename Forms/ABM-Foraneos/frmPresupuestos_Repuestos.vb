Public Class frmPresupuestos_Repuestos
    Dim join As String = "repuestos"
    Private Sub frmPropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 352

        query_read = $"
                 SELECT id_presupuesto,r.id_repuesto,r.importe ,r.desc_repuesto as [Nombre repuesto], cant_repuestos as Cantidad,importe_final as [Importe total]
                FROM {dgv} as pr
                INNER JOIN {join} as r
                ON  pr.id_repuesto=r.id_repuesto"
        llenar(query_read, dgvPresupuestos)
        ocultarID(dgvPresupuestos, 0)
        ocultarID(dgvPresupuestos, 1)
        ocultarID(dgvPresupuestos, 2)

    End Sub

    Private Sub btn_ABM_especialidades_Click(sender As Object, e As EventArgs) Handles btn_ABM.Click
        Me.Width = 613

    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Cambio(frm_Main, Me)
    End Sub

    Private Sub btn_insert_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If (txtbox1.Text <> "") Then
            query_create = $"
				INSERT INTO presupuestos_Repuestos  
				SELECT  {txtbox1.Text},{txtbox2.Text}, {txtbox2.Text}*r.importe
				FROM repuestos as r 
				where id_repuesto={txtbox1.Text}" ''' Error encontrado ID PRESUPUESTO DEBE ESTAR no es AUTOINCREMENTAL.
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

    'Private Sub btn_update_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_update.Click
    '    query_update = $"
    '        Update {dgv}
    '        SET importe_total={txtbox2.Text},id_propietario={txtbox1.Text},dias_atraso={txtboxAtraso.Text},fecha_ingreso='{datepicker.Text}',fecha_prometida='{datepicker2.Text}',patente='{txtboxPatente.Text}'
    '        WHERE patente = {dgvPresupuestos.CurrentRow.Cells(0).Value};"
    '    'Inicio update
    '    If (lblID.Text <> "Código") Then
    '        actualizar(query_update, query_read, dgvPresupuestos)
    '        Me.Width = 352
    '        borrartxtbox(Me)
    '        lblID.Text = "Código"
    '    ElseIf txtbox1.Text = "" Then
    '        MsgBox($"Para autoseleccionar {join}, presione enter sobre el campo VACÍO")
    '    Else
    '        MsgBox("Seleccione el campo a actualizar")
    '    End If
    'End Sub








    Private Sub lblMarca_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvPresupuestos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPresupuestos.CellClick
        If dgvPresupuestos.RowCount <> 0 Then
            lblID.Text = $"{dgvPresupuestos.CurrentRow.Cells(0).Value}"
            txtbox1.Text = $"{dgvPresupuestos.CurrentRow.Cells(1).Value}"
            lblConfirmacion.Text = $"{dgvPresupuestos.CurrentRow.Cells(3).Value}"
            txtbox2.Text = $"{dgvPresupuestos.CurrentRow.Cells(4).Value}"
        End If
    End Sub


    Private Sub txtboxAutomoviles_IdPropietario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox1.KeyDown
        If txtbox1.Text = "" Then
            If e.KeyData = Keys.Enter Then
                wfrm = 1
                Dim frm As New frmRepuestos
                AddOwnedForm(frm)
                frm.ShowDialog()
            End If
        End If
    End Sub
End Class
