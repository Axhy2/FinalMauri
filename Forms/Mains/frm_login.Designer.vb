<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Confirm = New System.Windows.Forms.Button()
        Me.txtbox_User = New System.Windows.Forms.TextBox()
        Me.txtbox_Password = New System.Windows.Forms.TextBox()
        Me.lbl_User = New System.Windows.Forms.Label()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.btnFisu = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final2022.My.Resources.Resources.frm_login_Users
        Me.PictureBox1.Location = New System.Drawing.Point(32, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 202)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_Confirm
        '
        Me.btn_Confirm.Location = New System.Drawing.Point(397, 226)
        Me.btn_Confirm.Name = "btn_Confirm"
        Me.btn_Confirm.Size = New System.Drawing.Size(75, 23)
        Me.btn_Confirm.TabIndex = 1
        Me.btn_Confirm.Text = "Confirmar"
        Me.btn_Confirm.UseVisualStyleBackColor = True
        '
        'txtbox_User
        '
        Me.txtbox_User.Location = New System.Drawing.Point(271, 87)
        Me.txtbox_User.Name = "txtbox_User"
        Me.txtbox_User.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_User.TabIndex = 2
        '
        'txtbox_Password
        '
        Me.txtbox_Password.Location = New System.Drawing.Point(271, 150)
        Me.txtbox_Password.Name = "txtbox_Password"
        Me.txtbox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtbox_Password.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_Password.TabIndex = 3
        '
        'lbl_User
        '
        Me.lbl_User.AutoSize = True
        Me.lbl_User.Location = New System.Drawing.Point(271, 71)
        Me.lbl_User.Name = "lbl_User"
        Me.lbl_User.Size = New System.Drawing.Size(43, 13)
        Me.lbl_User.TabIndex = 4
        Me.lbl_User.Text = "Usuario"
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Location = New System.Drawing.Point(271, 134)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Password.TabIndex = 5
        Me.lbl_Password.Text = "Contraseña"
        '
        'btnFisu
        '
        Me.btnFisu.Location = New System.Drawing.Point(397, 109)
        Me.btnFisu.Name = "btnFisu"
        Me.btnFisu.Size = New System.Drawing.Size(75, 23)
        Me.btnFisu.TabIndex = 6
        Me.btnFisu.Text = "Continuar"
        Me.btnFisu.UseVisualStyleBackColor = True
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.btnFisu)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_User)
        Me.Controls.Add(Me.txtbox_Password)
        Me.Controls.Add(Me.txtbox_User)
        Me.Controls.Add(Me.btn_Confirm)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_Confirm As Button
    Friend WithEvents txtbox_User As TextBox
    Friend WithEvents txtbox_Password As TextBox
    Friend WithEvents lbl_User As Label
    Friend WithEvents lbl_Password As Label
    Friend WithEvents btnFisu As Button
End Class
