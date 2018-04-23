<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.pnl_REGISTRO = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_REGISTRO_CANCELAR = New System.Windows.Forms.Button
        Me.btn_REGISTRO_GUARDAR = New System.Windows.Forms.Button
        Me.txb_REGISTRO_CI2 = New System.Windows.Forms.TextBox
        Me.txb_REGISTRO_CI = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txb_REGISTRO_TELEFONO = New System.Windows.Forms.TextBox
        Me.txb_REGISTRO_APELLIDO = New System.Windows.Forms.TextBox
        Me.txb_REGISTRO_CONTRASEÑA = New System.Windows.Forms.TextBox
        Me.txb_REGISTRO_NOMBRE = New System.Windows.Forms.TextBox
        Me.txb_REGISTRO_DESCRIPCION = New System.Windows.Forms.TextBox
        Me.lbl_REGISTRO_TELEFONO = New System.Windows.Forms.Label
        Me.lbl_REGISTRO_CI = New System.Windows.Forms.Label
        Me.lbl_REGISTRO_CONTRASEÑA = New System.Windows.Forms.Label
        Me.lbl_REGISTRO_APELLIDO = New System.Windows.Forms.Label
        Me.lbl_REGISTRO_NOMBRE = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl_REGISTRO.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_REGISTRO
        '
        Me.pnl_REGISTRO.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnl_REGISTRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_REGISTRO.Controls.Add(Me.Label1)
        Me.pnl_REGISTRO.Controls.Add(Me.btn_REGISTRO_CANCELAR)
        Me.pnl_REGISTRO.Controls.Add(Me.btn_REGISTRO_GUARDAR)
        Me.pnl_REGISTRO.Controls.Add(Me.txb_REGISTRO_CI2)
        Me.pnl_REGISTRO.Controls.Add(Me.txb_REGISTRO_CI)
        Me.pnl_REGISTRO.Controls.Add(Me.Label38)
        Me.pnl_REGISTRO.Controls.Add(Me.txb_REGISTRO_TELEFONO)
        Me.pnl_REGISTRO.Controls.Add(Me.txb_REGISTRO_APELLIDO)
        Me.pnl_REGISTRO.Controls.Add(Me.txb_REGISTRO_CONTRASEÑA)
        Me.pnl_REGISTRO.Controls.Add(Me.txb_REGISTRO_NOMBRE)
        Me.pnl_REGISTRO.Controls.Add(Me.txb_REGISTRO_DESCRIPCION)
        Me.pnl_REGISTRO.Controls.Add(Me.lbl_REGISTRO_TELEFONO)
        Me.pnl_REGISTRO.Controls.Add(Me.lbl_REGISTRO_CI)
        Me.pnl_REGISTRO.Controls.Add(Me.lbl_REGISTRO_CONTRASEÑA)
        Me.pnl_REGISTRO.Controls.Add(Me.lbl_REGISTRO_APELLIDO)
        Me.pnl_REGISTRO.Controls.Add(Me.lbl_REGISTRO_NOMBRE)
        Me.pnl_REGISTRO.Location = New System.Drawing.Point(111, 127)
        Me.pnl_REGISTRO.Name = "pnl_REGISTRO"
        Me.pnl_REGISTRO.Size = New System.Drawing.Size(587, 427)
        Me.pnl_REGISTRO.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Descripcion"
        '
        'btn_REGISTRO_CANCELAR
        '
        Me.btn_REGISTRO_CANCELAR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_REGISTRO_CANCELAR.Location = New System.Drawing.Point(270, 320)
        Me.btn_REGISTRO_CANCELAR.Name = "btn_REGISTRO_CANCELAR"
        Me.btn_REGISTRO_CANCELAR.Size = New System.Drawing.Size(96, 35)
        Me.btn_REGISTRO_CANCELAR.TabIndex = 9
        Me.btn_REGISTRO_CANCELAR.Text = "Cancelar"
        Me.btn_REGISTRO_CANCELAR.UseVisualStyleBackColor = True
        '
        'btn_REGISTRO_GUARDAR
        '
        Me.btn_REGISTRO_GUARDAR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_REGISTRO_GUARDAR.Location = New System.Drawing.Point(387, 320)
        Me.btn_REGISTRO_GUARDAR.Name = "btn_REGISTRO_GUARDAR"
        Me.btn_REGISTRO_GUARDAR.Size = New System.Drawing.Size(96, 35)
        Me.btn_REGISTRO_GUARDAR.TabIndex = 8
        Me.btn_REGISTRO_GUARDAR.Text = "Guardar"
        Me.btn_REGISTRO_GUARDAR.UseVisualStyleBackColor = True
        '
        'txb_REGISTRO_CI2
        '
        Me.txb_REGISTRO_CI2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_REGISTRO_CI2.Location = New System.Drawing.Point(454, 52)
        Me.txb_REGISTRO_CI2.MaxLength = 1
        Me.txb_REGISTRO_CI2.Name = "txb_REGISTRO_CI2"
        Me.txb_REGISTRO_CI2.Size = New System.Drawing.Size(29, 26)
        Me.txb_REGISTRO_CI2.TabIndex = 2
        '
        'txb_REGISTRO_CI
        '
        Me.txb_REGISTRO_CI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_REGISTRO_CI.Location = New System.Drawing.Point(270, 52)
        Me.txb_REGISTRO_CI.MaxLength = 7
        Me.txb_REGISTRO_CI.Name = "txb_REGISTRO_CI"
        Me.txb_REGISTRO_CI.Size = New System.Drawing.Size(159, 26)
        Me.txb_REGISTRO_CI.TabIndex = 1
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label38.Location = New System.Drawing.Point(435, 53)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(10, 13)
        Me.Label38.TabIndex = 38
        Me.Label38.Text = "-"
        '
        'txb_REGISTRO_TELEFONO
        '
        Me.txb_REGISTRO_TELEFONO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_REGISTRO_TELEFONO.Location = New System.Drawing.Point(270, 229)
        Me.txb_REGISTRO_TELEFONO.MaxLength = 8
        Me.txb_REGISTRO_TELEFONO.Name = "txb_REGISTRO_TELEFONO"
        Me.txb_REGISTRO_TELEFONO.Size = New System.Drawing.Size(213, 26)
        Me.txb_REGISTRO_TELEFONO.TabIndex = 6
        '
        'txb_REGISTRO_APELLIDO
        '
        Me.txb_REGISTRO_APELLIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_REGISTRO_APELLIDO.Location = New System.Drawing.Point(270, 185)
        Me.txb_REGISTRO_APELLIDO.MaxLength = 20
        Me.txb_REGISTRO_APELLIDO.Name = "txb_REGISTRO_APELLIDO"
        Me.txb_REGISTRO_APELLIDO.Size = New System.Drawing.Size(213, 26)
        Me.txb_REGISTRO_APELLIDO.TabIndex = 5
        '
        'txb_REGISTRO_CONTRASEÑA
        '
        Me.txb_REGISTRO_CONTRASEÑA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_REGISTRO_CONTRASEÑA.Location = New System.Drawing.Point(270, 97)
        Me.txb_REGISTRO_CONTRASEÑA.MaxLength = 20
        Me.txb_REGISTRO_CONTRASEÑA.Name = "txb_REGISTRO_CONTRASEÑA"
        Me.txb_REGISTRO_CONTRASEÑA.Size = New System.Drawing.Size(213, 26)
        Me.txb_REGISTRO_CONTRASEÑA.TabIndex = 3
        '
        'txb_REGISTRO_NOMBRE
        '
        Me.txb_REGISTRO_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_REGISTRO_NOMBRE.Location = New System.Drawing.Point(270, 140)
        Me.txb_REGISTRO_NOMBRE.MaxLength = 20
        Me.txb_REGISTRO_NOMBRE.Name = "txb_REGISTRO_NOMBRE"
        Me.txb_REGISTRO_NOMBRE.Size = New System.Drawing.Size(213, 26)
        Me.txb_REGISTRO_NOMBRE.TabIndex = 4
        '
        'txb_REGISTRO_DESCRIPCION
        '
        Me.txb_REGISTRO_DESCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_REGISTRO_DESCRIPCION.Location = New System.Drawing.Point(270, 266)
        Me.txb_REGISTRO_DESCRIPCION.MaxLength = 20
        Me.txb_REGISTRO_DESCRIPCION.Name = "txb_REGISTRO_DESCRIPCION"
        Me.txb_REGISTRO_DESCRIPCION.Size = New System.Drawing.Size(213, 26)
        Me.txb_REGISTRO_DESCRIPCION.TabIndex = 7
        '
        'lbl_REGISTRO_TELEFONO
        '
        Me.lbl_REGISTRO_TELEFONO.AutoSize = True
        Me.lbl_REGISTRO_TELEFONO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_REGISTRO_TELEFONO.Location = New System.Drawing.Point(89, 232)
        Me.lbl_REGISTRO_TELEFONO.Name = "lbl_REGISTRO_TELEFONO"
        Me.lbl_REGISTRO_TELEFONO.Size = New System.Drawing.Size(71, 20)
        Me.lbl_REGISTRO_TELEFONO.TabIndex = 4
        Me.lbl_REGISTRO_TELEFONO.Text = "Telefono"
        '
        'lbl_REGISTRO_CI
        '
        Me.lbl_REGISTRO_CI.AutoSize = True
        Me.lbl_REGISTRO_CI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_REGISTRO_CI.Location = New System.Drawing.Point(89, 55)
        Me.lbl_REGISTRO_CI.Name = "lbl_REGISTRO_CI"
        Me.lbl_REGISTRO_CI.Size = New System.Drawing.Size(29, 20)
        Me.lbl_REGISTRO_CI.TabIndex = 3
        Me.lbl_REGISTRO_CI.Text = "C.I"
        '
        'lbl_REGISTRO_CONTRASEÑA
        '
        Me.lbl_REGISTRO_CONTRASEÑA.AutoSize = True
        Me.lbl_REGISTRO_CONTRASEÑA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_REGISTRO_CONTRASEÑA.Location = New System.Drawing.Point(89, 100)
        Me.lbl_REGISTRO_CONTRASEÑA.Name = "lbl_REGISTRO_CONTRASEÑA"
        Me.lbl_REGISTRO_CONTRASEÑA.Size = New System.Drawing.Size(92, 20)
        Me.lbl_REGISTRO_CONTRASEÑA.TabIndex = 2
        Me.lbl_REGISTRO_CONTRASEÑA.Text = "Contraseña"
        '
        'lbl_REGISTRO_APELLIDO
        '
        Me.lbl_REGISTRO_APELLIDO.AutoSize = True
        Me.lbl_REGISTRO_APELLIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_REGISTRO_APELLIDO.Location = New System.Drawing.Point(89, 188)
        Me.lbl_REGISTRO_APELLIDO.Name = "lbl_REGISTRO_APELLIDO"
        Me.lbl_REGISTRO_APELLIDO.Size = New System.Drawing.Size(65, 20)
        Me.lbl_REGISTRO_APELLIDO.TabIndex = 1
        Me.lbl_REGISTRO_APELLIDO.Text = "Apellido"
        '
        'lbl_REGISTRO_NOMBRE
        '
        Me.lbl_REGISTRO_NOMBRE.AutoSize = True
        Me.lbl_REGISTRO_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_REGISTRO_NOMBRE.Location = New System.Drawing.Point(89, 143)
        Me.lbl_REGISTRO_NOMBRE.Name = "lbl_REGISTRO_NOMBRE"
        Me.lbl_REGISTRO_NOMBRE.Size = New System.Drawing.Size(65, 20)
        Me.lbl_REGISTRO_NOMBRE.TabIndex = 0
        Me.lbl_REGISTRO_NOMBRE.Text = "Nombre"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(87, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(670, 77)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(804, 620)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnl_REGISTRO)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        Me.pnl_REGISTRO.ResumeLayout(False)
        Me.pnl_REGISTRO.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_REGISTRO As System.Windows.Forms.Panel
    Friend WithEvents txb_REGISTRO_TELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents txb_REGISTRO_APELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents txb_REGISTRO_CONTRASEÑA As System.Windows.Forms.TextBox
    Friend WithEvents txb_REGISTRO_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents txb_REGISTRO_DESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents lbl_REGISTRO_TELEFONO As System.Windows.Forms.Label
    Friend WithEvents lbl_REGISTRO_CI As System.Windows.Forms.Label
    Friend WithEvents lbl_REGISTRO_CONTRASEÑA As System.Windows.Forms.Label
    Friend WithEvents lbl_REGISTRO_APELLIDO As System.Windows.Forms.Label
    Friend WithEvents lbl_REGISTRO_NOMBRE As System.Windows.Forms.Label
    Friend WithEvents txb_REGISTRO_CI2 As System.Windows.Forms.TextBox
    Friend WithEvents txb_REGISTRO_CI As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents btn_REGISTRO_CANCELAR As System.Windows.Forms.Button
    Friend WithEvents btn_REGISTRO_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
