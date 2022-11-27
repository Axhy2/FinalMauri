<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPropietarios
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
        Me.btn_ABM_especialidades = New System.Windows.Forms.Button()
        Me.btn_delete_proprietarios = New System.Windows.Forms.Button()
        Me.btn_update_proprietarios = New System.Windows.Forms.Button()
        Me.btn_insert_proprietarios = New System.Windows.Forms.Button()
        Me.txtbox_proprietarios_dni = New System.Windows.Forms.TextBox()
        Me.dgvPropietarios = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.txtbox_proprietarios_nombre = New System.Windows.Forms.TextBox()
        Me.txtbox_proprietarios_celular = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        CType(Me.dgvPropietarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ABM_especialidades
        '
        Me.btn_ABM_especialidades.Location = New System.Drawing.Point(162, 226)
        Me.btn_ABM_especialidades.Name = "btn_ABM_especialidades"
        Me.btn_ABM_especialidades.Size = New System.Drawing.Size(75, 23)
        Me.btn_ABM_especialidades.TabIndex = 1
        Me.btn_ABM_especialidades.Text = "ABM"
        Me.btn_ABM_especialidades.UseVisualStyleBackColor = True
        '
        'btn_delete_proprietarios
        '
        Me.btn_delete_proprietarios.Location = New System.Drawing.Point(371, 208)
        Me.btn_delete_proprietarios.Name = "btn_delete_proprietarios"
        Me.btn_delete_proprietarios.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete_proprietarios.TabIndex = 2
        Me.btn_delete_proprietarios.Text = "Borrar"
        Me.btn_delete_proprietarios.UseVisualStyleBackColor = True
        '
        'btn_update_proprietarios
        '
        Me.btn_update_proprietarios.Location = New System.Drawing.Point(452, 208)
        Me.btn_update_proprietarios.Name = "btn_update_proprietarios"
        Me.btn_update_proprietarios.Size = New System.Drawing.Size(75, 23)
        Me.btn_update_proprietarios.TabIndex = 3
        Me.btn_update_proprietarios.Text = "Actualizar"
        Me.btn_update_proprietarios.UseVisualStyleBackColor = True
        '
        'btn_insert_proprietarios
        '
        Me.btn_insert_proprietarios.Location = New System.Drawing.Point(290, 208)
        Me.btn_insert_proprietarios.Name = "btn_insert_proprietarios"
        Me.btn_insert_proprietarios.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert_proprietarios.TabIndex = 4
        Me.btn_insert_proprietarios.Text = "Añadir"
        Me.btn_insert_proprietarios.UseVisualStyleBackColor = True
        '
        'txtbox_proprietarios_dni
        '
        Me.txtbox_proprietarios_dni.Location = New System.Drawing.Point(326, 65)
        Me.txtbox_proprietarios_dni.Name = "txtbox_proprietarios_dni"
        Me.txtbox_proprietarios_dni.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_proprietarios_dni.TabIndex = 5
        '
        'dgvPropietarios
        '
        Me.dgvPropietarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.dgvPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPropietarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DNI, Me.Nombre, Me.Celular})
        Me.dgvPropietarios.Location = New System.Drawing.Point(12, 1)
        Me.dgvPropietarios.Name = "dgvPropietarios"
        Me.dgvPropietarios.ReadOnly = True
        Me.dgvPropietarios.Size = New System.Drawing.Size(269, 219)
        Me.dgvPropietarios.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_propietario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 21
        '
        'DNI
        '
        Me.DNI.DataPropertyName = "DNI"
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        Me.DNI.Width = 21
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nombre_propietario"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 21
        '
        'Celular
        '
        Me.Celular.DataPropertyName = "celular"
        Me.Celular.HeaderText = "Celular"
        Me.Celular.Name = "Celular"
        Me.Celular.ReadOnly = True
        Me.Celular.Width = 21
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(55, 226)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(75, 23)
        Me.btnMain.TabIndex = 8
        Me.btnMain.Text = "Inicio"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'txtbox_proprietarios_nombre
        '
        Me.txtbox_proprietarios_nombre.Location = New System.Drawing.Point(326, 102)
        Me.txtbox_proprietarios_nombre.Name = "txtbox_proprietarios_nombre"
        Me.txtbox_proprietarios_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_proprietarios_nombre.TabIndex = 9
        '
        'txtbox_proprietarios_celular
        '
        Me.txtbox_proprietarios_celular.Location = New System.Drawing.Point(326, 141)
        Me.txtbox_proprietarios_celular.Name = "txtbox_proprietarios_celular"
        Me.txtbox_proprietarios_celular.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_proprietarios_celular.TabIndex = 10
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(326, 49)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblDNI.TabIndex = 11
        Me.lblDNI.Text = "DNI"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(326, 88)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(326, 125)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(39, 13)
        Me.lblCelular.TabIndex = 13
        Me.lblCelular.Text = "Celular"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(472, 102)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(40, 13)
        Me.lblID.TabIndex = 14
        Me.lblID.Text = "Código"
        '
        'frmPropietarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 261)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblCelular)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.txtbox_proprietarios_celular)
        Me.Controls.Add(Me.txtbox_proprietarios_nombre)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.dgvPropietarios)
        Me.Controls.Add(Me.txtbox_proprietarios_dni)
        Me.Controls.Add(Me.btn_insert_proprietarios)
        Me.Controls.Add(Me.btn_update_proprietarios)
        Me.Controls.Add(Me.btn_delete_proprietarios)
        Me.Controls.Add(Me.btn_ABM_especialidades)
        Me.Name = "frmPropietarios"
        Me.Text = "Propietarios"
        CType(Me.dgvPropietarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ABM_especialidades As Button
    Friend WithEvents btn_delete_proprietarios As Button
    Friend WithEvents btn_update_proprietarios As Button
    Friend WithEvents btn_insert_proprietarios As Button
    Friend WithEvents txtbox_proprietarios_dni As TextBox
    Friend WithEvents dgvPropietarios As DataGridView
    Friend WithEvents btnMain As Button
    Friend WithEvents txtbox_proprietarios_nombre As TextBox
    Friend WithEvents txtbox_proprietarios_celular As TextBox
    Friend WithEvents lblDNI As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCelular As Label
    Friend WithEvents lblID As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Celular As DataGridViewTextBoxColumn
End Class
