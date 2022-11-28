<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresupuestos_Repuestos
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
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvPresupuestos = New System.Windows.Forms.DataGridView()
        Me.btn_ABM = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblConfirmacion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtbox3 = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 25
        '
        'dgvPresupuestos
        '
        Me.dgvPresupuestos.AllowUserToAddRows = False
        Me.dgvPresupuestos.AllowUserToDeleteRows = False
        Me.dgvPresupuestos.AllowUserToResizeColumns = False
        Me.dgvPresupuestos.AllowUserToResizeRows = False
        Me.dgvPresupuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvPresupuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvPresupuestos.BackgroundColor = System.Drawing.Color.Azure
        Me.dgvPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPresupuestos.Location = New System.Drawing.Point(13, 16)
        Me.dgvPresupuestos.Name = "dgvPresupuestos"
        Me.dgvPresupuestos.ReadOnly = True
        Me.dgvPresupuestos.RowHeadersVisible = False
        Me.dgvPresupuestos.Size = New System.Drawing.Size(311, 219)
        Me.dgvPresupuestos.TabIndex = 9
        '
        'btn_ABM
        '
        Me.btn_ABM.Location = New System.Drawing.Point(214, 248)
        Me.btn_ABM.Name = "btn_ABM"
        Me.btn_ABM.Size = New System.Drawing.Size(75, 23)
        Me.btn_ABM.TabIndex = 1
        Me.btn_ABM.Text = "ABM"
        Me.btn_ABM.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.SystemColors.Control
        Me.btnMain.Location = New System.Drawing.Point(48, 248)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(75, 23)
        Me.btnMain.TabIndex = 0
        Me.btnMain.Text = "Inicio"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(13, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(311, 48)
        Me.Panel2.TabIndex = 8
        '
        'lblConfirmacion
        '
        Me.lblConfirmacion.AutoSize = True
        Me.lblConfirmacion.Location = New System.Drawing.Point(141, 111)
        Me.lblConfirmacion.Name = "lblConfirmacion"
        Me.lblConfirmacion.Size = New System.Drawing.Size(19, 13)
        Me.lblConfirmacion.TabIndex = 25
        Me.lblConfirmacion.Text = "aa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Repuesto"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_insert)
        Me.Panel3.Controls.Add(Me.btn_delete)
        Me.Panel3.Controls.Add(Me.btn_update)
        Me.Panel3.Location = New System.Drawing.Point(341, 219)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(243, 48)
        Me.Panel3.TabIndex = 24
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
        'txtbox2
        '
        Me.txtbox2.BackColor = System.Drawing.Color.Khaki
        Me.txtbox2.Location = New System.Drawing.Point(138, 88)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(100, 20)
        Me.txtbox2.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Cantidad"
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
        'txtbox3
        '
        Me.txtbox3.Location = New System.Drawing.Point(71, 145)
        Me.txtbox3.Name = "txtbox3"
        Me.txtbox3.Size = New System.Drawing.Size(100, 20)
        Me.txtbox3.TabIndex = 2
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(7, 11)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(101, 13)
        Me.lblID.TabIndex = 14
        Me.lblID.Text = "Código presupuesto"
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(10, 230)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(311, 48)
        Me.Panel5.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtbox1)
        Me.Panel4.Controls.Add(Me.lblConfirmacion)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtbox2)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.txtbox3)
        Me.Panel4.Controls.Add(Me.lblID)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(341, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(243, 212)
        Me.Panel4.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "aa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Presupuesto"
        '
        'txtbox1
        '
        Me.txtbox1.BackColor = System.Drawing.Color.Khaki
        Me.txtbox1.Location = New System.Drawing.Point(20, 88)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(100, 20)
        Me.txtbox1.TabIndex = 26
        '
        'frmPresupuestos_Repuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(586, 281)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmPresupuestos_Repuestos"
        Me.Text = "frmPresupuestos_Repuestos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_update As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvPresupuestos As DataGridView
    Friend WithEvents btn_ABM As Button
    Friend WithEvents btnMain As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblConfirmacion As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txtbox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtbox3 As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbox1 As TextBox
End Class
