<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEspecialidades
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_ABM_Propietarios = New System.Windows.Forms.Button()
        Me.btn_delete_Propietarios = New System.Windows.Forms.Button()
        Me.btn_update_Propietarios = New System.Windows.Forms.Button()
        Me.btn_insert_Propietarios = New System.Windows.Forms.Button()
        Me.txtbox_especialidad = New System.Windows.Forms.TextBox()
        Me.dgvEspecialidades = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnMain = New System.Windows.Forms.Button()
        CType(Me.dgvEspecialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ABM_Propietarios
        '
        Me.btn_ABM_Propietarios.Location = New System.Drawing.Point(178, 237)
        Me.btn_ABM_Propietarios.Name = "btn_ABM_Propietarios"
        Me.btn_ABM_Propietarios.Size = New System.Drawing.Size(75, 23)
        Me.btn_ABM_Propietarios.TabIndex = 1
        Me.btn_ABM_Propietarios.Text = "ABM"
        Me.btn_ABM_Propietarios.UseVisualStyleBackColor = True
        '
        'btn_delete_Propietarios
        '
        Me.btn_delete_Propietarios.Location = New System.Drawing.Point(371, 208)
        Me.btn_delete_Propietarios.Name = "btn_delete_Propietarios"
        Me.btn_delete_Propietarios.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete_Propietarios.TabIndex = 2
        Me.btn_delete_Propietarios.Text = "Borrar"
        Me.btn_delete_Propietarios.UseVisualStyleBackColor = True
        '
        'btn_update_Propietarios
        '
        Me.btn_update_Propietarios.Location = New System.Drawing.Point(452, 208)
        Me.btn_update_Propietarios.Name = "btn_update_Propietarios"
        Me.btn_update_Propietarios.Size = New System.Drawing.Size(75, 23)
        Me.btn_update_Propietarios.TabIndex = 3
        Me.btn_update_Propietarios.Text = "Actualizar"
        Me.btn_update_Propietarios.UseVisualStyleBackColor = True
        '
        'btn_insert_Propietarios
        '
        Me.btn_insert_Propietarios.Location = New System.Drawing.Point(290, 208)
        Me.btn_insert_Propietarios.Name = "btn_insert_Propietarios"
        Me.btn_insert_Propietarios.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert_Propietarios.TabIndex = 4
        Me.btn_insert_Propietarios.Text = "Añadir"
        Me.btn_insert_Propietarios.UseVisualStyleBackColor = True
        '
        'txtbox_especialidad
        '
        Me.txtbox_especialidad.Location = New System.Drawing.Point(360, 139)
        Me.txtbox_especialidad.Name = "txtbox_especialidad"
        Me.txtbox_especialidad.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_especialidad.TabIndex = 5
        '
        'dgvEspecialidades
        '
        Me.dgvEspecialidades.AllowUserToAddRows = False
        Me.dgvEspecialidades.AllowUserToDeleteRows = False
        Me.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEspecialidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Especialidad})
        Me.dgvEspecialidades.Location = New System.Drawing.Point(15, 12)
        Me.dgvEspecialidades.Name = "dgvEspecialidades"
        Me.dgvEspecialidades.ReadOnly = True
        Me.dgvEspecialidades.Size = New System.Drawing.Size(269, 219)
        Me.dgvEspecialidades.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_especialidad"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Especialidad
        '
        Me.Especialidad.DataPropertyName = "desc_esp"
        Me.Especialidad.HeaderText = "Especialidad"
        Me.Especialidad.Name = "Especialidad"
        Me.Especialidad.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(312, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1500
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(31, 237)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(75, 23)
        Me.btnMain.TabIndex = 9
        Me.btnMain.Text = "Inicio"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'frmEspecialidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 261)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvEspecialidades)
        Me.Controls.Add(Me.txtbox_especialidad)
        Me.Controls.Add(Me.btn_insert_Propietarios)
        Me.Controls.Add(Me.btn_update_Propietarios)
        Me.Controls.Add(Me.btn_delete_Propietarios)
        Me.Controls.Add(Me.btn_ABM_Propietarios)
        Me.Name = "frmEspecialidades"
        Me.Text = "Especialidades"
        CType(Me.dgvEspecialidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ABM_Propietarios As Button
    Friend WithEvents btn_delete_Propietarios As Button
    Friend WithEvents btn_update_Propietarios As Button
    Friend WithEvents btn_insert_Propietarios As Button
    Friend WithEvents txtbox_especialidad As TextBox
    Friend WithEvents dgvEspecialidades As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Especialidad As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnMain As Button
End Class
