<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbox_Entry = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbox_Entry
        '
        Me.cmbox_Entry.FormattingEnabled = True
        Me.cmbox_Entry.Items.AddRange(New Object() {"Especialidades", "Propietarios", "Repuestos", "Operarios", "Automoviles", "Presupuestos", "Presupuestos__Tareas", "Presupuestos__Repuestos", "Tareas"})
        Me.cmbox_Entry.Location = New System.Drawing.Point(78, 78)
        Me.cmbox_Entry.Name = "cmbox_Entry"
        Me.cmbox_Entry.Size = New System.Drawing.Size(121, 21)
        Me.cmbox_Entry.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(75, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione una opción:"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbox_Entry)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Name = "frm_Main"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbox_Entry As ComboBox
    Friend WithEvents Label1 As Label
End Class
