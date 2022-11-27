<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutomoviles
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvAutomoviles = New System.Windows.Forms.DataGridView()
        Me.btn_ABM = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxAutomoviles_IdPropietario = New System.Windows.Forms.TextBox()
        Me.txtboxColor = New System.Windows.Forms.TextBox()
        Me.txtboxMarca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lbl_operario_Importe_hora = New System.Windows.Forms.Label()
        Me.lblConfirmacion = New System.Windows.Forms.Label()
        Me.txtboxTipo = New System.Windows.Forms.TextBox()
        Me.txtboxModelo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtbox_patente = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_operario_idespecialidad = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_patente = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvAutomoviles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_insert)
        Me.Panel3.Controls.Add(Me.btn_delete)
        Me.Panel3.Controls.Add(Me.btn_update)
        Me.Panel3.Location = New System.Drawing.Point(343, 222)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(243, 48)
        Me.Panel3.TabIndex = 18
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dgvAutomoviles)
        Me.Panel1.Controls.Add(Me.btn_ABM)
        Me.Panel1.Controls.Add(Me.btnMain)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 284)
        Me.Panel1.TabIndex = 19
        '
        'dgvAutomoviles
        '
        Me.dgvAutomoviles.AllowUserToAddRows = False
        Me.dgvAutomoviles.AllowUserToDeleteRows = False
        Me.dgvAutomoviles.AllowUserToResizeColumns = False
        Me.dgvAutomoviles.AllowUserToResizeRows = False
        Me.dgvAutomoviles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvAutomoviles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvAutomoviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAutomoviles.Location = New System.Drawing.Point(12, 15)
        Me.dgvAutomoviles.Name = "dgvAutomoviles"
        Me.dgvAutomoviles.ReadOnly = True
        Me.dgvAutomoviles.Size = New System.Drawing.Size(311, 219)
        Me.dgvAutomoviles.TabIndex = 9
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtboxAutomoviles_IdPropietario)
        Me.Panel4.Controls.Add(Me.txtboxColor)
        Me.Panel4.Controls.Add(Me.txtboxMarca)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.lblMarca)
        Me.Panel4.Controls.Add(Me.lbl_operario_Importe_hora)
        Me.Panel4.Controls.Add(Me.lblConfirmacion)
        Me.Panel4.Controls.Add(Me.txtboxTipo)
        Me.Panel4.Controls.Add(Me.txtboxModelo)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.txtbox_patente)
        Me.Panel4.Controls.Add(Me.lblID)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.lbl_operario_idespecialidad)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.lbl_patente)
        Me.Panel4.Location = New System.Drawing.Point(343, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(243, 212)
        Me.Panel4.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Color"
        '
        'txtboxAutomoviles_IdPropietario
        '
        Me.txtboxAutomoviles_IdPropietario.BackColor = System.Drawing.Color.Khaki
        Me.txtboxAutomoviles_IdPropietario.Location = New System.Drawing.Point(127, 142)
        Me.txtboxAutomoviles_IdPropietario.Name = "txtboxAutomoviles_IdPropietario"
        Me.txtboxAutomoviles_IdPropietario.Size = New System.Drawing.Size(100, 20)
        Me.txtboxAutomoviles_IdPropietario.TabIndex = 18
        '
        'txtboxColor
        '
        Me.txtboxColor.Location = New System.Drawing.Point(127, 103)
        Me.txtboxColor.Name = "txtboxColor"
        Me.txtboxColor.Size = New System.Drawing.Size(100, 20)
        Me.txtboxColor.TabIndex = 17
        '
        'txtboxMarca
        '
        Me.txtboxMarca.Location = New System.Drawing.Point(127, 66)
        Me.txtboxMarca.Name = "txtboxMarca"
        Me.txtboxMarca.Size = New System.Drawing.Size(100, 20)
        Me.txtboxMarca.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Propietario"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(130, 50)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(37, 13)
        Me.lblMarca.TabIndex = 19
        Me.lblMarca.Text = "Marca"
        '
        'lbl_operario_Importe_hora
        '
        Me.lbl_operario_Importe_hora.AutoSize = True
        Me.lbl_operario_Importe_hora.Location = New System.Drawing.Point(24, 89)
        Me.lbl_operario_Importe_hora.Name = "lbl_operario_Importe_hora"
        Me.lbl_operario_Importe_hora.Size = New System.Drawing.Size(42, 13)
        Me.lbl_operario_Importe_hora.TabIndex = 12
        Me.lbl_operario_Importe_hora.Text = "Modelo"
        '
        'lblConfirmacion
        '
        Me.lblConfirmacion.AutoSize = True
        Me.lblConfirmacion.Location = New System.Drawing.Point(130, 165)
        Me.lblConfirmacion.Name = "lblConfirmacion"
        Me.lblConfirmacion.Size = New System.Drawing.Size(19, 13)
        Me.lblConfirmacion.TabIndex = 15
        Me.lblConfirmacion.Text = "aa"
        '
        'txtboxTipo
        '
        Me.txtboxTipo.BackColor = System.Drawing.SystemColors.Control
        Me.txtboxTipo.Location = New System.Drawing.Point(21, 142)
        Me.txtboxTipo.Name = "txtboxTipo"
        Me.txtboxTipo.Size = New System.Drawing.Size(100, 20)
        Me.txtboxTipo.TabIndex = 4
        '
        'txtboxModelo
        '
        Me.txtboxModelo.Location = New System.Drawing.Point(21, 103)
        Me.txtboxModelo.Name = "txtboxModelo"
        Me.txtboxModelo.Size = New System.Drawing.Size(100, 20)
        Me.txtboxModelo.TabIndex = 3
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
        'txtbox_patente
        '
        Me.txtbox_patente.Location = New System.Drawing.Point(21, 66)
        Me.txtbox_patente.Name = "txtbox_patente"
        Me.txtbox_patente.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_patente.TabIndex = 2
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
        'lbl_operario_idespecialidad
        '
        Me.lbl_operario_idespecialidad.AutoSize = True
        Me.lbl_operario_idespecialidad.Location = New System.Drawing.Point(24, 126)
        Me.lbl_operario_idespecialidad.Name = "lbl_operario_idespecialidad"
        Me.lbl_operario_idespecialidad.Size = New System.Drawing.Size(28, 13)
        Me.lbl_operario_idespecialidad.TabIndex = 13
        Me.lbl_operario_idespecialidad.Text = "Tipo"
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
        Me.lbl_patente.Location = New System.Drawing.Point(24, 50)
        Me.lbl_patente.Name = "lbl_patente"
        Me.lbl_patente.Size = New System.Drawing.Size(44, 13)
        Me.lbl_patente.TabIndex = 11
        Me.lbl_patente.Text = "Patente"
        '
        'frmAutomoviles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(597, 279)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmAutomoviles"
        Me.Text = "frmAutomoviles"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvAutomoviles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvAutomoviles As DataGridView
    Friend WithEvents btn_ABM As Button
    Friend WithEvents btnMain As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_operario_Importe_hora As Label
    Friend WithEvents lblConfirmacion As Label
    Friend WithEvents txtboxTipo As TextBox
    Friend WithEvents txtboxModelo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtbox_patente As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl_operario_idespecialidad As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_patente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxAutomoviles_IdPropietario As TextBox
    Friend WithEvents txtboxColor As TextBox
    Friend WithEvents txtboxMarca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMarca As Label
End Class
