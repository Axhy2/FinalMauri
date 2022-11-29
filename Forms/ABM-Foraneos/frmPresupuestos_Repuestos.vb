Public Class frmPresupuestos_Repuestos
    Dim join As String = "repuestos"
    'Load
    Private Sub frmPropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 352

        query_read = $"
                 SELECT id_presupuesto,r.id_repuesto,r.importe ,r.desc_repuesto as [Nombre repuesto], cant_repuestos as Cantidad,importe_final as [Importe total]
                FROM presupuestos_Repuestos as pr
                INNER JOIN repuestos as r
                ON  pr.id_repuesto=r.id_repuesto"
        llenar(query_read, dgvPresupuestos)
        ocultarID(dgvPresupuestos, 0)
        ocultarID(dgvPresupuestos, 1)
        ocultarID(dgvPresupuestos, 2)

    End Sub

    'frm Controls buttons
    Private Sub btn_ABM_especialidades_Click(sender As Object, e As EventArgs) Handles btn_ABM.Click
        Me.Width = 613

    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Cambio(frm_Main, Me)
    End Sub

    'ABM buttons
    Private Sub btn_insert_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If (txtbox2.Text <> "") Then
            query_create = $"
				INSERT INTO presupuestos_Repuestos  
				SELECT  {txtbox1.Text},{txtbox2.Text},{txtbox3.Text}, {txtbox3.Text}*r.importe
				FROM repuestos as r 
				where id_repuesto={txtbox2.Text}"
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
            DELETE FROM {dgv} WHERE id_presupuesto={dgvPresupuestos.CurrentRow.Cells(0).Value} and id_repuesto={dgvPresupuestos.CurrentRow.Cells(1).Value};"
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
update presupuestos_Repuestos
SET cant_repuestos={txtbox3.Text},presupuestos_Repuestos.importe_final={txtbox3.Text}*r.importe

FROM
    repuestos as r
WHERE
    r.id_repuesto ={dgvPresupuestos.CurrentRow.Cells(1).Value} and id_presupuesto={dgvPresupuestos.CurrentRow.Cells(0).Value} And presupuestos_Repuestos.id_repuesto={dgvPresupuestos.CurrentRow.Cells(1).Value}"
        'Inicio update
        If (lblID.Text <> "Código") Then
            If dgvPresupuestos.CurrentRow.Cells(0).Value <> txtbox1.Text And dgvPresupuestos.CurrentRow.Cells(1).Value <> txtbox2.Text Then
                query_update = $"
update presupuestos_Repuestos
SET id_presupuesto={txtbox1.Text},id_repuesto{txtbox2.Text},cant_repuestos={txtbox3.Text},presupuestos_Repuestos.importe_final={txtbox3.Text}*r.importe

FROM
    repuestos as r
WHERE
    r.id_repuesto ={dgvPresupuestos.CurrentRow.Cells(1).Value} and id_presupuesto={dgvPresupuestos.CurrentRow.Cells(0).Value} And presupuestos_Repuestos.id_repuesto={dgvPresupuestos.CurrentRow.Cells(1).Value}"

            ElseIf dgvPresupuestos.CurrentRow.Cells(0).Value <> txtbox1.Text Then
                query_update = $"
update presupuestos_Repuestos
SET id_presupuesto={txtbox1.Text},cant_repuestos={txtbox3.Text},presupuestos_Repuestos.importe_final={txtbox3.Text}*r.importe

FROM
    repuestos as r
WHERE
    r.id_repuesto ={dgvPresupuestos.CurrentRow.Cells(1).Value} and id_presupuesto={dgvPresupuestos.CurrentRow.Cells(0).Value} And presupuestos_Repuestos.id_repuesto={dgvPresupuestos.CurrentRow.Cells(1).Value}"


            ElseIf dgvPresupuestos.CurrentRow.Cells(1).Value <> txtbox2.Text Then
                query_update = $"
update presupuestos_Repuestos
SET id_repuesto{txtbox2.Text},cant_repuestos={txtbox3.Text},presupuestos_Repuestos.importe_final={txtbox3.Text}*r.importe

FROM
    repuestos as r
WHERE
    r.id_repuesto ={dgvPresupuestos.CurrentRow.Cells(1).Value} and id_presupuesto={dgvPresupuestos.CurrentRow.Cells(0).Value} And presupuestos_Repuestos.id_repuesto={dgvPresupuestos.CurrentRow.Cells(1).Value}"


            End If
            actualizar(query_update, query_read, dgvPresupuestos)
            Me.Width = 352
            borrartxtbox(Me)
            lblID.Text = "Código"

            If txtbox1.Text = "" Then
                MsgBox("Seleccione el campo a actualizar")
            End If
        End If
    End Sub

    'dgv related
    Private Sub dgvPresupuestos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPresupuestos.CellClick
        If dgvPresupuestos.RowCount <> 0 Then
            lblID.Text = $"{dgvPresupuestos.CurrentRow.Cells(0).Value}"
            txtbox1.Text = $"{dgvPresupuestos.CurrentRow.Cells(0).Value}"
            txtbox2.Text = $"{dgvPresupuestos.CurrentRow.Cells(1).Value}"
            lblConfirmacion.Text = $"{dgvPresupuestos.CurrentRow.Cells(3).Value}"
            txtbox3.Text = $"{dgvPresupuestos.CurrentRow.Cells(4).Value}"
        End If
    End Sub

    'txtbox to FK forms
    Private Sub txtboxAutomoviles_IdPropietario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox2.KeyDown
        If txtbox2.Text = "" Then
            If e.KeyData = Keys.Enter Then
                wfrm = 1
                Dim frm As New frmRepuestos
                AddOwnedForm(frm)
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox1.KeyDown
        If txtbox1.Text = "" Then
            If e.KeyData = Keys.Enter Then
                wfrm = 1
                Dim frm As New frmPresupuestos
                AddOwnedForm(frm)
                frm.ShowDialog()
            End If
        End If
    End Sub

End Class
