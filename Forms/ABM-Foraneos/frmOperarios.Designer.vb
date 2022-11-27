<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOperarios
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
        Me.btn_ABM = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.txtbox_nombre_operario = New System.Windows.Forms.TextBox()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.txtbox_operario_importe_hora = New System.Windows.Forms.TextBox()
        Me.txtbox_operario_ID_especialidad = New System.Windows.Forms.TextBox()
        Me.lbl_operario_nombre = New System.Windows.Forms.Label()
        Me.lbl_operario_Importe_hora = New System.Windows.Forms.Label()
        Me.lbl_operario_idespecialidad = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblConfirmacion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvOperarios = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvOperarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
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
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(5, 13)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert.TabIndex = 5
        Me.btn_insert.Text = "Añadir"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'txtbox_nombre_operario
        '
        Me.txtbox_nombre_operario.Location = New System.Drawing.Point(69, 66)
        Me.txtbox_nombre_operario.Name = "txtbox_nombre_operario"
        Me.txtbox_nombre_operario.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_nombre_operario.TabIndex = 2
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
        'txtbox_operario_importe_hora
        '
        Me.txtbox_operario_importe_hora.Location = New System.Drawing.Point(69, 103)
        Me.txtbox_operario_importe_hora.Name = "txtbox_operario_importe_hora"
        Me.txtbox_operario_importe_hora.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_operario_importe_hora.TabIndex = 3
        '
        'txtbox_operario_ID_especialidad
        '
        Me.txtbox_operario_ID_especialidad.BackColor = System.Drawing.Color.Khaki
        Me.txtbox_operario_ID_especialidad.Location = New System.Drawing.Point(69, 142)
        Me.txtbox_operario_ID_especialidad.Name = "txtbox_operario_ID_especialidad"
        Me.txtbox_operario_ID_especialidad.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_operario_ID_especialidad.TabIndex = 4
        '
        'lbl_operario_nombre
        '
        Me.lbl_operario_nombre.AutoSize = True
        Me.lbl_operario_nombre.Location = New System.Drawing.Point(72, 50)
        Me.lbl_operario_nombre.Name = "lbl_operario_nombre"
        Me.lbl_operario_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_operario_nombre.TabIndex = 11
        Me.lbl_operario_nombre.Text = "Nombre"
        '
        'lbl_operario_Importe_hora
        '
        Me.lbl_operario_Importe_hora.AutoSize = True
        Me.lbl_operario_Importe_hora.Location = New System.Drawing.Point(72, 89)
        Me.lbl_operario_Importe_hora.Name = "lbl_operario_Importe_hora"
        Me.lbl_operario_Importe_hora.Size = New System.Drawing.Size(74, 13)
        Me.lbl_operario_Importe_hora.TabIndex = 12
        Me.lbl_operario_Importe_hora.Text = "Importe x hora"
        '
        'lbl_operario_idespecialidad
        '
        Me.lbl_operario_idespecialidad.AutoSize = True
        Me.lbl_operario_idespecialidad.Location = New System.Drawing.Point(72, 126)
        Me.lbl_operario_idespecialidad.Name = "lbl_operario_idespecialidad"
        Me.lbl_operario_idespecialidad.Size = New System.Drawing.Size(67, 13)
        Me.lbl_operario_idespecialidad.TabIndex = 13
        Me.lbl_operario_idespecialidad.Text = "Especialidad"
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
        'lblConfirmacion
        '
        Me.lblConfirmacion.AutoSize = True
        Me.lblConfirmacion.Location = New System.Drawing.Point(72, 165)
        Me.lblConfirmacion.Name = "lblConfirmacion"
        Me.lblConfirmacion.Size = New System.Drawing.Size(19, 13)
        Me.lblConfirmacion.TabIndex = 15
        Me.lblConfirmacion.Text = "aa"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dgvOperarios)
        Me.Panel1.Controls.Add(Me.btn_ABM)
        Me.Panel1.Controls.Add(Me.btnMain)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 284)
        Me.Panel1.TabIndex = 16
        '
        'dgvOperarios
        '
        Me.dgvOperarios.AllowUserToAddRows = False
        Me.dgvOperarios.AllowUserToDeleteRows = False
        Me.dgvOperarios.AllowUserToResizeColumns = False
        Me.dgvOperarios.AllowUserToResizeRows = False
        Me.dgvOperarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvOperarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvOperarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperarios.Location = New System.Drawing.Point(12, 15)
        Me.dgvOperarios.Name = "dgvOperarios"
        Me.dgvOperarios.ReadOnly = True
        Me.dgvOperarios.Size = New System.Drawing.Size(311, 219)
        Me.dgvOperarios.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(12, 233)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(311, 48)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_insert)
        Me.Panel3.Controls.Add(Me.btn_delete)
        Me.Panel3.Controls.Add(Me.btn_update)
        Me.Panel3.Location = New System.Drawing.Point(342, 219)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(243, 48)
        Me.Panel3.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lbl_operario_Importe_hora)
        Me.Panel4.Controls.Add(Me.lblConfirmacion)
        Me.Panel4.Controls.Add(Me.txtbox_operario_ID_especialidad)
        Me.Panel4.Controls.Add(Me.txtbox_operario_importe_hora)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.txtbox_nombre_operario)
        Me.Panel4.Controls.Add(Me.lblID)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.lbl_operario_idespecialidad)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.lbl_operario_nombre)
        Me.Panel4.Location = New System.Drawing.Point(342, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(243, 212)
        Me.Panel4.TabIndex = 17
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
        'frmOperarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(597, 279)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmOperarios"
        Me.Text = "Operarios"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvOperarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ABM As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents txtbox_nombre_operario As TextBox
    Friend WithEvents btnMain As Button
    Friend WithEvents txtbox_operario_importe_hora As TextBox
    Friend WithEvents txtbox_operario_ID_especialidad As TextBox
    Friend WithEvents lbl_operario_nombre As Label
    Friend WithEvents lbl_operario_Importe_hora As Label
    Friend WithEvents lbl_operario_idespecialidad As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblConfirmacion As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgvOperarios As DataGridView
End Class
