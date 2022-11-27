
Public Class frmRepuestos

    Dim tabla As String = "repuestos"
    Private Sub frmPropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 300
        ocultarID(dgvRepuestos, 0)
        llenar($"select *from {tabla}", dgvRepuestos) ', "propietarios")
    End Sub

    Private Sub btn_ABM_especialidades_Click(sender As Object, e As EventArgs) Handles btn_ABM_especialidades.Click
        Me.Width = 550
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Cambio(frm_Main, Me)
    End Sub

    Private Sub btn_insert_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_insert_repuestos.Click
        If (txtbox_repuestos_desc_repuesto.Text <> "") Then
            crear(
            $"insert into repuestos
            values('{txtbox_repuestos_desc_repuesto.Text}',{txtbox_repuestos_importe.Text})",
            "select *from repuestos", dgvRepuestos)
            Me.Width = 300


            borrartxtbox(Me)
        Else
            MsgBox("Ingrese el/los campo/s")
        End If
    End Sub

    Private Sub btn_delete_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_delete_repuestos.Click
        If (lblID.Text <> "Código") Then
            borrar(
            $"DELETE FROM repuestos WHERE id_repuesto={dgvRepuestos.CurrentRow.Cells(0).Value};",
            "select *from repuestos", dgvRepuestos)
            Me.Width = 300

            borrartxtbox(Me)
            lblID.Text = "Código"


        Else
            MsgBox("Seleccione el campo a eliminar")
        End If
    End Sub

    Private Sub btn_update_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_update_repuestos.Click
        If (lblID.Text <> "Código") Then
            actualizar($"Update repuestos
            SET desc_repuesto='{txtbox_repuestos_desc_repuesto.Text}',importe='{txtbox_repuestos_importe.Text}'
            WHERE id_repuesto = {dgvRepuestos.CurrentRow.Cells(0).Value};",
            "select *from repuestos", dgvRepuestos)
            Me.Width = 300

            borrartxtbox(Me)
            lblID.Text = "Código"


        Else
            MsgBox("Seleccione el campo a actualizar")
        End If
    End Sub

    Private Sub dgvPropietarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRepuestos.CellClick
        If $"{dgvRepuestos.CurrentRow.Cells(0).Value}" <> "" Then
            lblID.Text = $"{dgvRepuestos.CurrentRow.Cells(0).Value}"
            txtbox_repuestos_desc_repuesto.Text = $"{dgvRepuestos.CurrentRow.Cells(1).Value}"
            txtbox_repuestos_importe.Text = $"{dgvRepuestos.CurrentRow.Cells(2).Value}".Replace(",", ".")

        Else
            lblID.Text = "Código"
        End If
        If wfrm = 1 And Not IsDBNull(dgvRepuestos.CurrentRow) Then
            Dim frm As frmPresupuestos_Repuestos = CType(Owner, frmPresupuestos_Repuestos)
            frm.txtbox1.Text = dgvRepuestos.CurrentRow.Cells(0).Value
            frm.lblConfirmacion.Text = dgvRepuestos.CurrentRow.Cells(1).Value
        End If
    End Sub

    Private Sub dgvRepuestos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvRepuestos.KeyDown
        If wfrm = 1 Then
            If e.KeyData = Keys.Enter Then
                wfrm = 0
                Me.Close()
            End If
        End If
    End Sub
End Class