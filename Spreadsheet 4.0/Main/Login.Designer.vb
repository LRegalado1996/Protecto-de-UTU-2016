<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.lbl_CI = New System.Windows.Forms.Label
        Me.lbl_CONTRASEÑA = New System.Windows.Forms.Label
        Me.txt_CI = New System.Windows.Forms.TextBox
        Me.txt_CONTRASEÑA = New System.Windows.Forms.TextBox
        Me.btn_INGRESAR = New System.Windows.Forms.Button
        Me.pbx_LOGIN = New System.Windows.Forms.PictureBox
        Me.pbx_LOGO = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txt_Veri = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.pbx_LOGIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_CI
        '
        Me.lbl_CI.AutoSize = True
        Me.lbl_CI.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CI.Location = New System.Drawing.Point(410, 126)
        Me.lbl_CI.Name = "lbl_CI"
        Me.lbl_CI.Size = New System.Drawing.Size(25, 20)
        Me.lbl_CI.TabIndex = 1
        Me.lbl_CI.Text = "CI"
        '
        'lbl_CONTRASEÑA
        '
        Me.lbl_CONTRASEÑA.AutoSize = True
        Me.lbl_CONTRASEÑA.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CONTRASEÑA.Location = New System.Drawing.Point(410, 161)
        Me.lbl_CONTRASEÑA.Name = "lbl_CONTRASEÑA"
        Me.lbl_CONTRASEÑA.Size = New System.Drawing.Size(92, 20)
        Me.lbl_CONTRASEÑA.TabIndex = 2
        Me.lbl_CONTRASEÑA.Text = "Contraseña"
        '
        'txt_CI
        '
        Me.txt_CI.Location = New System.Drawing.Point(571, 123)
        Me.txt_CI.MaxLength = 7
        Me.txt_CI.Name = "txt_CI"
        Me.txt_CI.Size = New System.Drawing.Size(103, 26)
        Me.txt_CI.TabIndex = 1
        '
        'txt_CONTRASEÑA
        '
        Me.txt_CONTRASEÑA.Location = New System.Drawing.Point(571, 155)
        Me.txt_CONTRASEÑA.Name = "txt_CONTRASEÑA"
        Me.txt_CONTRASEÑA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_CONTRASEÑA.Size = New System.Drawing.Size(138, 26)
        Me.txt_CONTRASEÑA.TabIndex = 3
        '
        'btn_INGRESAR
        '
        Me.btn_INGRESAR.Location = New System.Drawing.Point(610, 239)
        Me.btn_INGRESAR.Name = "btn_INGRESAR"
        Me.btn_INGRESAR.Size = New System.Drawing.Size(99, 34)
        Me.btn_INGRESAR.TabIndex = 4
        Me.btn_INGRESAR.Text = "Ingresar"
        Me.btn_INGRESAR.UseVisualStyleBackColor = True
        '
        'pbx_LOGIN
        '
        Me.pbx_LOGIN.BackColor = System.Drawing.Color.Transparent
        Me.pbx_LOGIN.Image = CType(resources.GetObject("pbx_LOGIN.Image"), System.Drawing.Image)
        Me.pbx_LOGIN.Location = New System.Drawing.Point(384, -9)
        Me.pbx_LOGIN.Name = "pbx_LOGIN"
        Me.pbx_LOGIN.Size = New System.Drawing.Size(340, 117)
        Me.pbx_LOGIN.TabIndex = 8
        Me.pbx_LOGIN.TabStop = False
        '
        'pbx_LOGO
        '
        Me.pbx_LOGO.BackColor = System.Drawing.Color.Transparent
        Me.pbx_LOGO.Image = CType(resources.GetObject("pbx_LOGO.Image"), System.Drawing.Image)
        Me.pbx_LOGO.Location = New System.Drawing.Point(43, 14)
        Me.pbx_LOGO.Name = "pbx_LOGO"
        Me.pbx_LOGO.Size = New System.Drawing.Size(291, 259)
        Me.pbx_LOGO.TabIndex = 9
        Me.pbx_LOGO.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(414, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Veri
        '
        Me.txt_Veri.Location = New System.Drawing.Point(680, 123)
        Me.txt_Veri.MaxLength = 1
        Me.txt_Veri.Name = "txt_Veri"
        Me.txt_Veri.Size = New System.Drawing.Size(29, 26)
        Me.txt_Veri.TabIndex = 2
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(736, 306)
        Me.Controls.Add(Me.txt_Veri)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pbx_LOGO)
        Me.Controls.Add(Me.pbx_LOGIN)
        Me.Controls.Add(Me.btn_INGRESAR)
        Me.Controls.Add(Me.txt_CONTRASEÑA)
        Me.Controls.Add(Me.txt_CI)
        Me.Controls.Add(Me.lbl_CONTRASEÑA)
        Me.Controls.Add(Me.lbl_CI)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        CType(Me.pbx_LOGIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_CI As System.Windows.Forms.Label
    Friend WithEvents lbl_CONTRASEÑA As System.Windows.Forms.Label
    Friend WithEvents txt_CI As System.Windows.Forms.TextBox
    Friend WithEvents txt_CONTRASEÑA As System.Windows.Forms.TextBox
    Friend WithEvents btn_INGRESAR As System.Windows.Forms.Button
    Friend WithEvents pbx_LOGIN As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_Veri As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
