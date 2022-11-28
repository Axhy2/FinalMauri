<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPresupuestos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxEgreso = New System.Windows.Forms.TextBox()
        Me.txtboxAtraso = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lbl_operario_Importe_hora = New System.Windows.Forms.Label()
        Me.lblConfirmacion = New System.Windows.Forms.Label()
        Me.txtboxPatente = New System.Windows.Forms.TextBox()
        Me.txtboxIngreso = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtboxImp = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_operario_idespecialidad = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_patente = New System.Windows.Forms.Label()
        Me.dgvPresupuestos = New System.Windows.Forms.DataGridView()
        Me.btn_ABM = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.datepicker2 = New System.Windows.Forms.DateTimePicker()
        Me.datepicker = New System.Windows.Forms.DateTimePicker()
        Me.lblConfirmacion2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxDesc = New System.Windows.Forms.TextBox()
        Me.txtboxID_Propietario = New System.Windows.Forms.TextBox()
        CType(Me.dgvPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Egreso esperado"
        '
        'txtboxEgreso
        '
        Me.txtboxEgreso.Location = New System.Drawing.Point(131, 121)
        Me.txtboxEgreso.Name = "txtboxEgreso"
        Me.txtboxEgreso.Size = New System.Drawing.Size(100, 20)
        Me.txtboxEgreso.TabIndex = 17
        '
        'txtboxAtraso
        '
        Me.txtboxAtraso.Location = New System.Drawing.Point(131, 84)
        Me.txtboxAtraso.Name = "txtboxAtraso"
        Me.txtboxAtraso.Size = New System.Drawing.Size(100, 20)
        Me.txtboxAtraso.TabIndex = 16
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(134, 68)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(37, 13)
        Me.lblMarca.TabIndex = 19
        Me.lblMarca.Text = "Atraso"
        '
        'lbl_operario_Importe_hora
        '
        Me.lbl_operario_Importe_hora.AutoSize = True
        Me.lbl_operario_Importe_hora.Location = New System.Drawing.Point(28, 107)
        Me.lbl_operario_Importe_hora.Name = "lbl_operario_Importe_hora"
        Me.lbl_operario_Importe_hora.Size = New System.Drawing.Size(42, 13)
        Me.lbl_operario_Importe_hora.TabIndex = 12
        Me.lbl_operario_Importe_hora.Text = "Ingreso"
        '
        'lblConfirmacion
        '
        Me.lblConfirmacion.AutoSize = True
        Me.lblConfirmacion.Location = New System.Drawing.Point(106, 182)
        Me.lblConfirmacion.Name = "lblConfirmacion"
        Me.lblConfirmacion.Size = New System.Drawing.Size(19, 13)
        Me.lblConfirmacion.TabIndex = 15
        Me.lblConfirmacion.Text = "aa"
        '
        'txtboxPatente
        '
        Me.txtboxPatente.BackColor = System.Drawing.Color.Khaki
        Me.txtboxPatente.Location = New System.Drawing.Point(71, 159)
        Me.txtboxPatente.Name = "txtboxPatente"
        Me.txtboxPatente.Size = New System.Drawing.Size(100, 20)
        Me.txtboxPatente.TabIndex = 4
        '
        'txtboxIngreso
        '
        Me.txtboxIngreso.Location = New System.Drawing.Point(25, 121)
        Me.txtboxIngreso.Name = "txtboxIngreso"
        Me.txtboxIngreso.Size = New System.Drawing.Size(100, 20)
        Me.txtboxIngreso.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(211, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ABM"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtboxImp
        '
        Me.txtboxImp.Location = New System.Drawing.Point(25, 84)
        Me.txtboxImp.Name = "txtboxImp"
        Me.txtboxImp.Size = New System.Drawing.Size(100, 20)
        Me.txtboxImp.TabIndex = 2
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(7, 11)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(40, 13)
        Me.lblID.TabIndex = 14
        Me.lblID.Text = "Código"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(45, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Inicio"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lbl_operario_idespecialidad
        '
        Me.lbl_operario_idespecialidad.AutoSize = True
        Me.lbl_operario_idespecialidad.Location = New System.Drawing.Point(22, 123)
        Me.lbl_operario_idespecialidad.Name = "lbl_operario_idespecialidad"
        Me.lbl_operario_idespecialidad.Size = New System.Drawing.Size(28, 13)
        Me.lbl_operario_idespecialidad.TabIndex = 13
        Me.lbl_operario_idespecialidad.Text = "Tipo"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(10, 230)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(311, 48)
        Me.Panel5.TabIndex = 8
        '
        'lbl_patente
        '
        Me.lbl_patente.AutoSize = True
        Me.lbl_patente.Location = New System.Drawing.Point(100, 144)
        Me.lbl_patente.Name = "lbl_patente"
        Me.lbl_patente.Size = New System.Drawing.Size(44, 13)
        Me.lbl_patente.TabIndex = 11
        Me.lbl_patente.Text = "Patente"
        '
        'dgvPresupuestos
        '
        Me.dgvPresupuestos.AllowUserToAddRows = False
        Me.dgvPresupuestos.AllowUserToDeleteRows = False
        Me.dgvPresupuestos.AllowUserToResizeColumns = False
        Me.dgvPresupuestos.AllowUserToResizeRows = False
        Me.dgvPresupuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvPresupuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPresupuestos.Location = New System.Drawing.Point(10, 12)
        Me.dgvPresupuestos.Name = "dgvPresupuestos"
        Me.dgvPresupuestos.ReadOnly = True
        Me.dgvPresupuestos.RowHeadersVisible = False
        Me.dgvPresupuestos.Size = New System.Drawing.Size(311, 219)
        Me.dgvPresupuestos.TabIndex = 9
        '
        'btn_ABM
        '
        Me.btn_ABM.Location = New System.Drawing.Point(211, 244)
        Me.btn_ABM.Name = "btn_ABM"
        Me.btn_ABM.Size = New System.Drawing.Size(75, 23)
        Me.btn_ABM.TabIndex = 1
        Me.btn_ABM.Text = "ABM"
        Me.btn_ABM.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.SystemColors.Control
        Me.btnMain.Location = New System.Drawing.Point(45, 244)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(75, 23)
        Me.btnMain.TabIndex = 0
        Me.btnMain.Text = "Inicio"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(10, 230)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(311, 48)
        Me.Panel2.TabIndex = 8
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(3, 10)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert.TabIndex = 5
        Me.btn_insert.Text = "Añadir"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(89, 10)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(64, 23)
        Me.btn_delete.TabIndex = 6
        Me.btn_delete.Text = "Borrar"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(165, 10)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dgvPresupuestos)
        Me.Panel1.Controls.Add(Me.btn_ABM)
        Me.Panel1.Controls.Add(Me.btnMain)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 284)
        Me.Panel1.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel4.Controls.Add(Me.datepicker2)
        Me.Panel4.Controls.Add(Me.datepicker)
        Me.Panel4.Controls.Add(Me.lblConfirmacion2)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtboxDesc)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtboxEgreso)
        Me.Panel4.Controls.Add(Me.txtboxAtraso)
        Me.Panel4.Controls.Add(Me.lblMarca)
        Me.Panel4.Controls.Add(Me.lbl_operario_Importe_hora)
        Me.Panel4.Controls.Add(Me.lblConfirmacion)
        Me.Panel4.Controls.Add(Me.txtboxPatente)
        Me.Panel4.Controls.Add(Me.txtboxIngreso)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.txtboxImp)
        Me.Panel4.Controls.Add(Me.lblID)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.lbl_operario_idespecialidad)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.lbl_patente)
        Me.Panel4.Location = New System.Drawing.Point(342, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(243, 212)
        Me.Panel4.TabIndex = 23
        '
        'datepicker2
        '
        Me.datepicker2.CustomFormat = "dd/MM/yyyy"
        Me.datepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datepicker2.Location = New System.Drawing.Point(131, 121)
        Me.datepicker2.Name = "datepicker2"
        Me.datepicker2.Size = New System.Drawing.Size(100, 20)
        Me.datepicker2.TabIndex = 27
        '
        'datepicker
        '
        Me.datepicker.CustomFormat = "dd/MM/yyyy"
        Me.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datepicker.Location = New System.Drawing.Point(25, 121)
        Me.datepicker.Name = "datepicker"
        Me.datepicker.Size = New System.Drawing.Size(100, 20)
        Me.datepicker.TabIndex = 26
        '
        'lblConfirmacion2
        '
        Me.lblConfirmacion2.AutoSize = True
        Me.lblConfirmacion2.Location = New System.Drawing.Point(56, 20)
        Me.lblConfirmacion2.Name = "lblConfirmacion2"
        Me.lblConfirmacion2.Size = New System.Drawing.Size(19, 13)
        Me.lblConfirmacion2.TabIndex = 25
        Me.lblConfirmacion2.Text = "aa"
        Me.lblConfirmacion2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Importe total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Descripción"
        '
        'txtboxDesc
        '
        Me.txtboxDesc.Location = New System.Drawing.Point(78, 45)
        Me.txtboxDesc.Name = "txtboxDesc"
        Me.txtboxDesc.Size = New System.Drawing.Size(100, 20)
        Me.txtboxDesc.TabIndex = 22
        '
        'txtboxID_Propietario
        '
        Me.txtboxID_Propietario.BackColor = System.Drawing.Color.Khaki
        Me.txtboxID_Propietario.Location = New System.Drawing.Point(373, -11)
        Me.txtboxID_Propietario.Name = "txtboxID_Propietario"
        Me.txtboxID_Propietario.Size = New System.Drawing.Size(100, 20)
        Me.txtboxID_Propietario.TabIndex = 18
        Me.txtboxID_Propietario.Visible = False
        '
        'frmPresupuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(585, 284)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txtboxID_Propietario)
        Me.Name = "frmPresupuestos"
        Me.Text = "frmPresupuestos"
        CType(Me.dgvPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxEgreso As TextBox
    Friend WithEvents txtboxAtraso As TextBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents lbl_operario_Importe_hora As Label
    Friend WithEvents lblConfirmacion As Label
    Friend WithEvents txtboxPatente As TextBox
    Friend WithEvents txtboxIngreso As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtboxImp As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl_operario_idespecialidad As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_patente As Label
    Friend WithEvents dgvPresupuestos As DataGridView
    Friend WithEvents btn_ABM As Button
    Friend WithEvents btnMain As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtboxDesc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents datepicker2 As DateTimePicker
    Friend WithEvents datepicker As DateTimePicker
    Friend WithEvents lblConfirmacion2 As Label
    Friend WithEvents txtboxID_Propietario As TextBox
End Class
