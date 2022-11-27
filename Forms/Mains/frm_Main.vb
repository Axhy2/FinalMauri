Public Class frm_Main

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbox_Entry.SelectedIndexChanged
        Select Case cmbox_Entry.SelectedIndex
            Case 0
                Cambio(frmEspecialidades, Me)
            Case 1
                Cambio(frmPropietarios, Me)

            Case 2
                Cambio(frmRepuestos, Me)
            Case 3
                Cambio(frmOperarios, Me)
            Case 4
                Cambio(frmAutomoviles, Me)
            Case 5
                Cambio(frmPresupuestos, Me)
            Case 6
                '    Cambio(frmPresupuestos_Tareas, Me)
            Case 7
                Cambio(frmPresupuestos_Repuestos, Me)
            Case 8
                Cambio(frmTareas, Me)
        End Select
    End Sub


End Class