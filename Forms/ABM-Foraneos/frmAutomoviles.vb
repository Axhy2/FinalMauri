Public Class frmAutomoviles
    Dim join As String = "propietarios"
    Private Sub frmPropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 352
        If wfrm = 1 Then
            dgv = $"{Me.Name.Replace("frm", "")}"
        End If
        query_read = $"
                SELECT patente as Patente, pr.nombre_propietario as [Nombre propietario],marca as Marca, modelo as Modelo, color as Color, tipo as Tipo,pr.id_propietario
                FROM {dgv} as au
                INNER JOIN {join} as pr
                ON au.id_propietario = pr.id_propietario"
        llenar(query_read, dgvAutomoviles)
        ocultarID(dgvAutomoviles, 6)
        'ocultarID(dgvAutomoviles, 1)

    End Sub

    Private Sub btn_ABM_especialidades_Click(sender As Object, e As EventArgs) Handles btn_ABM.Click
        Me.Width = 613

    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Cambio(frm_Main, Me)
    End Sub

    Private Sub btn_insert_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If (txtbox_patente.Text <> "") Then
            query_create = $"
             insert into {dgv}
             values({txtbox_patente.Text},{txtboxAutomoviles_IdPropietario.Text},'{txtboxMarca.Text}','{txtboxModelo.Text}','{txtboxColor.Text}','{txtboxTipo.Text}')"
            crear(query_create, query_read, dgvAutomoviles)
            Me.Width = 352
            borrartxtbox(Me)
        Else
            MsgBox("Ingrese el/los campo/s")
        End If
    End Sub

    Private Sub btn_delete_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_delete.Click


        If (lblID.Text <> "Código") Then
            query_delete = $"
            DELETE FROM {dgv} WHERE patente={dgvAutomoviles.CurrentRow.Cells(0).Value};"
            borrar(query_delete, query_read, dgvAutomoviles)
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
            SET patente={txtbox_patente.Text},id_propietario={txtboxAutomoviles_IdPropietario.Text},marca='{txtboxMarca.Text}',modelo='{txtboxModelo.Text}',color='{txtboxColor.Text}',tipo='{txtboxTipo.Text}'
            WHERE patente = {dgvAutomoviles.CurrentRow.Cells(0).Value};"
        If (lblID.Text <> "Código") Then
            actualizar(query_update, query_read, dgvAutomoviles)
            Me.Width = 352
            borrartxtbox(Me)
            lblID.Text = "Código"
        ElseIf txtboxAutomoviles_IdPropietario.Text = "" Then
            MsgBox($"Para autoseleccionar {join}, presione enter sobre el campo VACÍO")
        Else
            MsgBox("Seleccione el campo a actualizar")
            txtboxAutomoviles_IdPropietario.Text = $"{dgvAutomoviles.CurrentRow.Cells(0).Value}"

            txtboxMarca.Text = $"{dgvAutomoviles.CurrentRow.Cells(2).Value}"
            txtboxModelo.Text = $"{dgvAutomoviles.CurrentRow.Cells(3).Value}"
            txtboxColor.Text = $"{dgvAutomoviles.CurrentRow.Cells(4).Value}"
            txtboxTipo.Text = $"{dgvAutomoviles.CurrentRow.Cells(5).Value}"
        End If
    End Sub




    Private Sub dgvOperarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAutomoviles.CellClick
        If dgvAutomoviles.RowCount <> 0 Then
            lblID.Text = $"{dgvAutomoviles.CurrentRow.Cells(0).Value}"

            txtboxColor.Text = $"{dgvAutomoviles.CurrentRow.Cells(4).Value}"
            txtboxMarca.Text = $"{dgvAutomoviles.CurrentRow.Cells(2).Value}"
            txtboxModelo.Text = $"{dgvAutomoviles.CurrentRow.Cells(3).Value}"
            txtboxTipo.Text = $"{dgvAutomoviles.CurrentRow.Cells(5).Value}"
            txtbox_patente.Text = $"{dgvAutomoviles.CurrentRow.Cells(0).Value}"
            txtboxAutomoviles_IdPropietario.Text = $"{dgvAutomoviles.CurrentRow.Cells(6).Value}"
            lblConfirmacion.Text = $"{dgvAutomoviles.CurrentRow.Cells(1).Value}"
        End If
    End Sub

    Private Sub txtboxAutomoviles_IdPropietario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxAutomoviles_IdPropietario.KeyDown
        If txtbox_patente.Text <> "" Then
            If e.KeyData = Keys.Enter Then
                wfrm = 1
                Dim frm As New frmPropietarios
                AddOwnedForm(frm)
                frm.ShowDialog()

            End If
        End If
    End Sub

    Private Sub dgvAutomoviles_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAutomoviles.SelectionChanged
        If wfrm = 1 Then
            Dim frm As frmPresupuestos = CType(Owner, frmPresupuestos)
            frm.txtboxPatente.Text = dgvAutomoviles.CurrentRow.Cells(0).Value
            frm.lblConfirmacion.Text = dgvAutomoviles.CurrentRow.Cells(1).Value
            frm.txtboxID_Propietario.Text = dgvAutomoviles.CurrentRow.Cells(6).Value
        End If
    End Sub

    Private Sub dgvAutomoviles_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvAutomoviles.KeyDown
        If wfrm = 1 Then
            wfrm = 0
            dgv = $"{frmPresupuestos.Name.Replace("frm", "")}"
            query_read = $"
                SELECT id_presupuesto,pro.id_propietario,pro.nombre_propietario as [Nombre dueño],patente as Patente,desc_presupuesto as Descripcion,fecha_ingreso as Ingreso,fecha_prometida as [Egreso esperado],dias_atraso as Atraso,importe_total As [Importe total]
                FROM presupuestos as pre
                INNER JOIN propietarios as pro
                ON pre.id_propietario = pro.id_propietario"
            Me.Close()

        End If
    End Sub
End Class
