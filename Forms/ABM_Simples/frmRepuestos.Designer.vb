<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepuestos
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtbox_repuestos_importe = New System.Windows.Forms.TextBox()
        Me.txtbox_repuestos_desc_repuesto = New System.Windows.Forms.TextBox()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.dgvRepuestos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_insert_repuestos = New System.Windows.Forms.Button()
        Me.btn_update_repuestos = New System.Windows.Forms.Button()
        Me.btn_delete_repuestos = New System.Windows.Forms.Button()
        Me.btn_ABM_especialidades = New System.Windows.Forms.Button()
        CType(Me.dgvRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(472, 113)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(40, 13)
        Me.lblID.TabIndex = 27
        Me.lblID.Text = "Código"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(326, 136)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(42, 13)
        Me.lblCelular.TabIndex = 26
        Me.lblCelular.Text = "Importe"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(326, 99)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 25
        Me.lblDescripcion.Text = "Descripcion"
        '
        'txtbox_repuestos_importe
        '
        Me.txtbox_repuestos_importe.Location = New System.Drawing.Point(326, 152)
        Me.txtbox_repuestos_importe.Name = "txtbox_repuestos_importe"
        Me.txtbox_repuestos_importe.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_repuestos_importe.TabIndex = 23
        '
        'txtbox_repuestos_desc_repuesto
        '
        Me.txtbox_repuestos_desc_repuesto.Location = New System.Drawing.Point(326, 113)
        Me.txtbox_repuestos_desc_repuesto.Name = "txtbox_repuestos_desc_repuesto"
        Me.txtbox_repuestos_desc_repuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_repuestos_desc_repuesto.TabIndex = 22
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(55, 237)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(75, 23)
        Me.btnMain.TabIndex = 21
        Me.btnMain.Text = "Inicio"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'dgvRepuestos
        '
        Me.dgvRepuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.dgvRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRepuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Descripción, Me.Importe})
        Me.dgvRepuestos.Location = New System.Drawing.Point(12, 12)
        Me.dgvRepuestos.Name = "dgvRepuestos"
        Me.dgvRepuestos.ReadOnly = True
        Me.dgvRepuestos.Size = New System.Drawing.Size(269, 219)
        Me.dgvRepuestos.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_repuesto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 21
        '
        'Descripción
        '
        Me.Descripción.DataPropertyName = "desc_repuesto"
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        Me.Descripción.Width = 21
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "importe"
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Width = 21
        '
        'btn_insert_repuestos
        '
        Me.btn_insert_repuestos.Location = New System.Drawing.Point(290, 219)
        Me.btn_insert_repuestos.Name = "btn_insert_repuestos"
        Me.btn_insert_repuestos.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert_repuestos.TabIndex = 18
        Me.btn_insert_repuestos.Text = "Añadir"
        Me.btn_insert_repuestos.UseVisualStyleBackColor = True
        '
        'btn_update_repuestos
        '
        Me.btn_update_repuestos.Location = New System.Drawing.Point(452, 219)
        Me.btn_update_repuestos.Name = "btn_update_repuestos"
        Me.btn_update_repuestos.Size = New System.Drawing.Size(75, 23)
        Me.btn_update_repuestos.TabIndex = 17
        Me.btn_update_repuestos.Text = "Actualizar"
        Me.btn_update_repuestos.UseVisualStyleBackColor = True
        '
        'btn_delete_repuestos
        '
        Me.btn_delete_repuestos.Location = New System.Drawing.Point(371, 219)
        Me.btn_delete_repuestos.Name = "btn_delete_repuestos"
        Me.btn_delete_repuestos.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete_repuestos.TabIndex = 16
        Me.btn_delete_repuestos.Text = "Borrar"
        Me.btn_delete_repuestos.UseVisualStyleBackColor = True
        '
        'btn_ABM_especialidades
        '
        Me.btn_ABM_especialidades.Location = New System.Drawing.Point(162, 237)
        Me.btn_ABM_especialidades.Name = "btn_ABM_especialidades"
        Me.btn_ABM_especialidades.Size = New System.Drawing.Size(75, 23)
        Me.btn_ABM_especialidades.TabIndex = 15
        Me.btn_ABM_especialidades.Text = "ABM"
        Me.btn_ABM_especialidades.UseVisualStyleBackColor = True
        '
        'frmRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 278)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblCelular)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtbox_repuestos_importe)
        Me.Controls.Add(Me.txtbox_repuestos_desc_repuesto)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.dgvRepuestos)
        Me.Controls.Add(Me.btn_insert_repuestos)
        Me.Controls.Add(Me.btn_update_repuestos)
        Me.Controls.Add(Me.btn_delete_repuestos)
        Me.Controls.Add(Me.btn_ABM_especialidades)
        Me.Name = "frmRepuestos"
        Me.Text = "frmRepuestos"
        CType(Me.dgvRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblCelular As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtbox_repuestos_importe As TextBox
    Friend WithEvents txtbox_repuestos_desc_repuesto As TextBox
    Friend WithEvents btnMain As Button
    Friend WithEvents dgvRepuestos As DataGridView
    Friend WithEvents btn_insert_repuestos As Button
    Friend WithEvents btn_update_repuestos As Button
    Friend WithEvents btn_delete_repuestos As Button
    Friend WithEvents btn_ABM_especialidades As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
End Class
