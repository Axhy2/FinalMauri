<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTareas
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
        Me.txtboxEspecialidades = New System.Windows.Forms.TextBox()
        Me.txtboxHsStdr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblConfirmacion = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtboxDesc = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_patente = New System.Windows.Forms.Label()
        Me.btn_ABM = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvTareas = New System.Windows.Forms.DataGridView()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtboxEspecialidades
        '
        Me.txtboxEspecialidades.BackColor = System.Drawing.Color.Khaki
        Me.txtboxEspecialidades.Location = New System.Drawing.Point(76, 127)
        Me.txtboxEspecialidades.Name = "txtboxEspecialidades"
        Me.txtboxEspecialidades.Size = New System.Drawing.Size(100, 20)
        Me.txtboxEspecialidades.TabIndex = 18
        '
        'txtboxHsStdr
        '
        Me.txtboxHsStdr.Location = New System.Drawing.Point(128, 90)
        Me.txtboxHsStdr.Name = "txtboxHsStdr"
        Me.txtboxHsStdr.Size = New System.Drawing.Size(100, 20)
        Me.txtboxHsStdr.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Especialidad"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(131, 74)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(79, 13)
        Me.lblMarca.TabIndex = 19
        Me.lblMarca.Text = "Horas estándar"
        '
        'lblConfirmacion
        '
        Me.lblConfirmacion.AutoSize = True
        Me.lblConfirmacion.Location = New System.Drawing.Point(73, 150)
        Me.lblConfirmacion.Name = "lblConfirmacion"
        Me.lblConfirmacion.Size = New System.Drawing.Size(19, 13)
        Me.lblConfirmacion.TabIndex = 15
        Me.lblConfirmacion.Text = "aa"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(213, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ABM"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtboxDesc
        '
        Me.txtboxDesc.Location = New System.Drawing.Point(22, 90)
        Me.txtboxDesc.Name = "txtboxDesc"
        Me.txtboxDesc.Size = New System.Drawing.Size(100, 20)
        Me.txtboxDesc.TabIndex = 2
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(9, 14)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(40, 13)
        Me.lblID.TabIndex = 14
        Me.lblID.Text = "Código"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(47, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Inicio"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(12, 233)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(311, 48)
        Me.Panel5.TabIndex = 8
        '
        'lbl_patente
        '
        Me.lbl_patente.AutoSize = True
        Me.lbl_patente.Location = New System.Drawing.Point(25, 74)
        Me.lbl_patente.Name = "lbl_patente"
        Me.lbl_patente.Size = New System.Drawing.Size(63, 13)
        Me.lbl_patente.TabIndex = 11
        Me.lbl_patente.Text = "Descripción"
        '
        'btn_ABM
        '
        Me.btn_ABM.Location = New System.Drawing.Point(213, 247)
        Me.btn_ABM.Name = "btn_ABM"
        Me.btn_ABM.Size = New System.Drawing.Size(75, 23)
        Me.btn_ABM.TabIndex = 1
        Me.btn_ABM.Text = "ABM"
        Me.btn_ABM.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.SystemColors.Control
        Me.btnMain.Location = New System.Drawing.Point(47, 247)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(75, 23)
        Me.btnMain.TabIndex = 0
        Me.btnMain.Text = "Inicio"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(12, 233)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(311, 48)
        Me.Panel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dgvTareas)
        Me.Panel1.Controls.Add(Me.btn_ABM)
        Me.Panel1.Controls.Add(Me.btnMain)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 284)
        Me.Panel1.TabIndex = 22
        '
        'dgvTareas
        '
        Me.dgvTareas.AllowUserToAddRows = False
        Me.dgvTareas.AllowUserToDeleteRows = False
        Me.dgvTareas.AllowUserToResizeColumns = False
        Me.dgvTareas.AllowUserToResizeRows = False
        Me.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvTareas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTareas.Location = New System.Drawing.Point(12, 15)
        Me.dgvTareas.Name = "dgvTareas"
        Me.dgvTareas.ReadOnly = True
        Me.dgvTareas.Size = New System.Drawing.Size(311, 219)
        Me.dgvTareas.TabIndex = 9
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(5, 13)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert.TabIndex = 5
        Me.btn_insert.Text = "Añadir"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(91, 13)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(64, 23)
        Me.btn_delete.TabIndex = 6
        Me.btn_delete.Text = "Borrar"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(167, 13)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(73, 23)
        Me.btn_update.TabIndex = 7
        Me.btn_update.Text = "Actualizar"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_insert)
        Me.Panel3.Controls.Add(Me.btn_delete)
        Me.Panel3.Controls.Add(Me.btn_update)
        Me.Panel3.Location = New System.Drawing.Point(342, 222)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(243, 48)
        Me.Panel3.TabIndex = 21
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtboxEspecialidades)
        Me.Panel4.Controls.Add(Me.txtboxHsStdr)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.lblMarca)
        Me.Panel4.Controls.Add(Me.lblConfirmacion)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.txtboxDesc)
        Me.Panel4.Controls.Add(Me.lblID)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.lbl_patente)
        Me.Panel4.Location = New System.Drawing.Point(342, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(243, 212)
        Me.Panel4.TabIndex = 23
        '
        'frmTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(587, 284)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmTareas"
        Me.Text = "frmTareas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvTareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtboxEspecialidades As TextBox
    Friend WithEvents txtboxHsStdr As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblConfirmacion As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtboxDesc As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_patente As Label
    Friend WithEvents btn_ABM As Button
    Friend WithEvents btnMain As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvTareas As DataGridView
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
