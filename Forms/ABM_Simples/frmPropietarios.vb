Imports System.ComponentModel

Public Class frmPropietarios

    Private Sub frmPropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = 300
        ocultarID(dgvPropietarios, 0)
        llenar("select *from propietarios", dgvPropietarios) ', "propietarios")
        If wfrm = 1 Then
            dgvPropietarios.Select()
        End If
    End Sub

    Private Sub btn_ABM_especialidades_Click(sender As Object, e As EventArgs) Handles btn_ABM_especialidades.Click
        Me.Width = 550
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Cambio(frm_Main, Me)
    End Sub

    Private Sub btn_insert_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_insert_proprietarios.Click
        If (txtbox_proprietarios_dni.Text <> "") Then
            crear(
            $"insert into propietarios
            values('{txtbox_proprietarios_dni.Text}','{txtbox_proprietarios_nombre.Text}','{txtbox_proprietarios_celular.Text}')",
            "select *from propietarios", dgvPropietarios)
            Me.Width = 300

            borrartxtbox(Me)
        Else
            MsgBox("Ingrese el/los campo/s")
        End If
    End Sub

    Private Sub btn_delete_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_delete_proprietarios.Click
        If (lblID.Text <> "Código") Then
            borrar(
            $"DELETE FROM propietarios WHERE id_propietario={dgvPropietarios.CurrentRow.Cells(0).Value};",
            "select *from propietarios", dgvPropietarios)
            Me.Width = 300
            borrartxtbox(Me)
            lblID.Text = "Código"


        Else
            MsgBox("Seleccione el campo a eliminar")
        End If
    End Sub

    Private Sub btn_update_proprietarios_Click(sender As Object, e As EventArgs) Handles btn_update_proprietarios.Click
        If (lblID.Text <> "Código") Then
            actualizar($"Update propietarios
            SET DNI = '{txtbox_proprietarios_dni.Text}',nombre_propietario='{txtbox_proprietarios_nombre.Text}',celular='{txtbox_proprietarios_celular.Text}'
            WHERE id_propietario = {dgvPropietarios.CurrentRow.Cells(0).Value};",
            "select *from propietarios", dgvPropietarios)
            Me.Width = 300
            borrartxtbox(Me)
            lblID.Text = "Código"


        Else
            MsgBox("Seleccione el campo a actualizar")
        End If
    End Sub

    Private Sub dgvPropietarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPropietarios.CellClick
        If $"{dgvPropietarios.CurrentRow.Cells(0).Value}" <> "" Then
            lblID.Text = $"{dgvPropietarios.CurrentRow.Cells(0).Value}"

        Else
            lblID.Text = "Código"
        End If
        If wfrm = 1 And Not IsDBNull(dgvPropietarios.CurrentRow) Then
            Dim frm As frmAutomoviles = CType(Owner, frmAutomoviles)
            frm.txtboxAutomoviles_IdPropietario.Text = dgvPropietarios.CurrentRow.Cells(0).Value
            frm.lblConfirmacion.Text = dgvPropietarios.CurrentRow.Cells(2).Value
        End If
        If wfrm = 2 And Not IsDBNull(dgvPropietarios.CurrentRow) Then
            Dim frm As frmPresupuestos = CType(Owner, frmPresupuestos)
            frm.txtboxID_Propietario.Text = dgvPropietarios.CurrentRow.Cells(0).Value
            frm.lblConfirmacion2.Text = dgvPropietarios.CurrentRow.Cells(2).Value
        End If
    End Sub

    Private Sub dgvPropietarios_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvPropietarios.KeyDown
        If wfrm = 1 Then
            If e.KeyData = Keys.Enter Then
                wfrm = 0
                Me.Close()
            End If

        End If
        If wfrm = 2 Then
            If e.KeyData = Keys.Enter Then
                wfrm = 0
                Me.Close()
            End If

        End If
    End Sub


End Class