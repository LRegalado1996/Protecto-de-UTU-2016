<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Planillador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Planillador))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pbx_PLANILLADOR_MODI = New System.Windows.Forms.PictureBox
        Me.pbx_PLANILLADOR_BAJAS = New System.Windows.Forms.PictureBox
        Me.pbx_PLANILLADOR_ALTAS = New System.Windows.Forms.PictureBox
        Me.Panel_Altas = New System.Windows.Forms.Panel
        Me.btn_ALTAS_PLANI_ASIGNAR = New System.Windows.Forms.Button
        Me.Lbl_ALTA_nombre = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmb_ALTA_PLANI_CARRERA = New System.Windows.Forms.ComboBox
        Me.cmb_ALTAS_PLANI_DIA = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txb_ALTAS_PLANILLADOR_DESCRIPCION = New System.Windows.Forms.TextBox
        Me.lbl_ALTAS_PLANILLA_DESCRI = New System.Windows.Forms.Label
        Me.cmb_ALTAS_PLANI_SALON = New System.Windows.Forms.ComboBox
        Me.cmb_ALTAS_PLANI_HORARIO = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.dgv_PLANI_ALTAS = New System.Windows.Forms.DataGridView
        Me.Button7 = New System.Windows.Forms.Button
        Me.btn_PLANI_ALTAS_GUARDAR = New System.Windows.Forms.Button
        Me.cmb_ALTAS_PLANI_PROFESOR = New System.Windows.Forms.ComboBox
        Me.cmb_ALTAS_PLANI_MATERIA = New System.Windows.Forms.ComboBox
        Me.cmb_ALTAS_PLANI_GRUPO = New System.Windows.Forms.ComboBox
        Me.cmb_ALTAS_PLANI_TURNO = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel_Bajas = New System.Windows.Forms.Panel
        Me.lbl_VERSION = New System.Windows.Forms.Label
        Me.cmb_PLANI_BAJAS_VERSION = New System.Windows.Forms.ComboBox
        Me.dgv_PLANI_BAJAS = New System.Windows.Forms.DataGridView
        Me.btn_BAJAS_BORRAR = New System.Windows.Forms.Button
        Me.btn_BAJAS_DESACTIVAR = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.cmb_PLANILLA_MODIFICAR_TURNO = New System.Windows.Forms.ComboBox
        Me.cmb_PLANILLA_MODIFICAR_HORA = New System.Windows.Forms.ComboBox
        Me.cmb_PLANILLA_MODIFICAR_GRUPO = New System.Windows.Forms.ComboBox
        Me.cmb_PLANILLA_MODIFICAR_MATERIA = New System.Windows.Forms.ComboBox
        Me.cmb_PLANILLA_MODIFICAR_PROFESOR = New System.Windows.Forms.ComboBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.txb_PLANI_MODI_VERSION = New System.Windows.Forms.TextBox
        Me.btn_PLANI_MODI_BUSCAR = New System.Windows.Forms.Button
        Me.dgv_PLANI_MODI = New System.Windows.Forms.DataGridView
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmb_PLANILLA_MODIFICAR_DIA = New System.Windows.Forms.ComboBox
        Me.lbl_PLANI_MODI_NOMBRE = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmb_PLANILLA_MODIFICAR_SALON = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txb_PLANILLA_MODI_DESCRI = New System.Windows.Forms.TextBox
        Me.Panel_modificaciones = New System.Windows.Forms.Panel
        Me.cmb_PLANILLA_MODIFICAR_BAJA = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_PLANILLA_MODIFICAR_AÑO = New System.Windows.Forms.ComboBox
        Me.cmb_PLANILLA_MODIFICAR_VERSION = New System.Windows.Forms.ComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_PLANILLADOR_MODI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_PLANILLADOR_BAJAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_PLANILLADOR_ALTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Altas.SuspendLayout()
        CType(Me.dgv_PLANI_ALTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Bajas.SuspendLayout()
        CType(Me.dgv_PLANI_BAJAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_PLANI_MODI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_modificaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(105, 44)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(598, 72)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pbx_PLANILLADOR_MODI
        '
        Me.pbx_PLANILLADOR_MODI.BackColor = System.Drawing.Color.Transparent
        Me.pbx_PLANILLADOR_MODI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbx_PLANILLADOR_MODI.Image = CType(resources.GetObject("pbx_PLANILLADOR_MODI.Image"), System.Drawing.Image)
        Me.pbx_PLANILLADOR_MODI.Location = New System.Drawing.Point(10, 303)
        Me.pbx_PLANILLADOR_MODI.Name = "pbx_PLANILLADOR_MODI"
        Me.pbx_PLANILLADOR_MODI.Size = New System.Drawing.Size(144, 120)
        Me.pbx_PLANILLADOR_MODI.TabIndex = 12
        Me.pbx_PLANILLADOR_MODI.TabStop = False
        '
        'pbx_PLANILLADOR_BAJAS
        '
        Me.pbx_PLANILLADOR_BAJAS.BackColor = System.Drawing.Color.Transparent
        Me.pbx_PLANILLADOR_BAJAS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbx_PLANILLADOR_BAJAS.Image = CType(resources.GetObject("pbx_PLANILLADOR_BAJAS.Image"), System.Drawing.Image)
        Me.pbx_PLANILLADOR_BAJAS.Location = New System.Drawing.Point(8, 453)
        Me.pbx_PLANILLADOR_BAJAS.Name = "pbx_PLANILLADOR_BAJAS"
        Me.pbx_PLANILLADOR_BAJAS.Size = New System.Drawing.Size(144, 120)
        Me.pbx_PLANILLADOR_BAJAS.TabIndex = 11
        Me.pbx_PLANILLADOR_BAJAS.TabStop = False
        '
        'pbx_PLANILLADOR_ALTAS
        '
        Me.pbx_PLANILLADOR_ALTAS.BackColor = System.Drawing.Color.Transparent
        Me.pbx_PLANILLADOR_ALTAS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbx_PLANILLADOR_ALTAS.Image = CType(resources.GetObject("pbx_PLANILLADOR_ALTAS.Image"), System.Drawing.Image)
        Me.pbx_PLANILLADOR_ALTAS.Location = New System.Drawing.Point(10, 153)
        Me.pbx_PLANILLADOR_ALTAS.Name = "pbx_PLANILLADOR_ALTAS"
        Me.pbx_PLANILLADOR_ALTAS.Size = New System.Drawing.Size(144, 120)
        Me.pbx_PLANILLADOR_ALTAS.TabIndex = 10
        Me.pbx_PLANILLADOR_ALTAS.TabStop = False
        '
        'Panel_Altas
        '
        Me.Panel_Altas.BackColor = System.Drawing.Color.White
        Me.Panel_Altas.Controls.Add(Me.btn_ALTAS_PLANI_ASIGNAR)
        Me.Panel_Altas.Controls.Add(Me.Lbl_ALTA_nombre)
        Me.Panel_Altas.Controls.Add(Me.Label15)
        Me.Panel_Altas.Controls.Add(Me.cmb_ALTA_PLANI_CARRERA)
        Me.Panel_Altas.Controls.Add(Me.cmb_ALTAS_PLANI_DIA)
        Me.Panel_Altas.Controls.Add(Me.Label17)
        Me.Panel_Altas.Controls.Add(Me.txb_ALTAS_PLANILLADOR_DESCRIPCION)
        Me.Panel_Altas.Controls.Add(Me.lbl_ALTAS_PLANILLA_DESCRI)
        Me.Panel_Altas.Controls.Add(Me.cmb_ALTAS_PLANI_SALON)
        Me.Panel_Altas.Controls.Add(Me.cmb_ALTAS_PLANI_HORARIO)
        Me.Panel_Altas.Controls.Add(Me.Label14)
        Me.Panel_Altas.Controls.Add(Me.dgv_PLANI_ALTAS)
        Me.Panel_Altas.Controls.Add(Me.Button7)
        Me.Panel_Altas.Controls.Add(Me.btn_PLANI_ALTAS_GUARDAR)
        Me.Panel_Altas.Controls.Add(Me.cmb_ALTAS_PLANI_PROFESOR)
        Me.Panel_Altas.Controls.Add(Me.cmb_ALTAS_PLANI_MATERIA)
        Me.Panel_Altas.Controls.Add(Me.cmb_ALTAS_PLANI_GRUPO)
        Me.Panel_Altas.Controls.Add(Me.cmb_ALTAS_PLANI_TURNO)
        Me.Panel_Altas.Controls.Add(Me.Label2)
        Me.Panel_Altas.Controls.Add(Me.Label3)
        Me.Panel_Altas.Controls.Add(Me.Label4)
        Me.Panel_Altas.Controls.Add(Me.Label5)
        Me.Panel_Altas.Controls.Add(Me.Label12)
        Me.Panel_Altas.Location = New System.Drawing.Point(181, 153)
        Me.Panel_Altas.Name = "Panel_Altas"
        Me.Panel_Altas.Size = New System.Drawing.Size(586, 420)
        Me.Panel_Altas.TabIndex = 16
        Me.Panel_Altas.Visible = False
        '
        'btn_ALTAS_PLANI_ASIGNAR
        '
        Me.btn_ALTAS_PLANI_ASIGNAR.Location = New System.Drawing.Point(220, 369)
        Me.btn_ALTAS_PLANI_ASIGNAR.Name = "btn_ALTAS_PLANI_ASIGNAR"
        Me.btn_ALTAS_PLANI_ASIGNAR.Size = New System.Drawing.Size(148, 32)
        Me.btn_ALTAS_PLANI_ASIGNAR.TabIndex = 11
        Me.btn_ALTAS_PLANI_ASIGNAR.Text = "Asignar Version"
        Me.btn_ALTAS_PLANI_ASIGNAR.UseVisualStyleBackColor = True
        '
        'Lbl_ALTA_nombre
        '
        Me.Lbl_ALTA_nombre.AutoSize = True
        Me.Lbl_ALTA_nombre.Location = New System.Drawing.Point(371, 216)
        Me.Lbl_ALTA_nombre.Name = "Lbl_ALTA_nombre"
        Me.Lbl_ALTA_nombre.Size = New System.Drawing.Size(66, 20)
        Me.Lbl_ALTA_nombre.TabIndex = 52
        Me.Lbl_ALTA_nombre.Text = "Label16"
        Me.Lbl_ALTA_nombre.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(294, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 20)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Carrera"
        '
        'cmb_ALTA_PLANI_CARRERA
        '
        Me.cmb_ALTA_PLANI_CARRERA.Enabled = False
        Me.cmb_ALTA_PLANI_CARRERA.FormattingEnabled = True
        Me.cmb_ALTA_PLANI_CARRERA.Location = New System.Drawing.Point(369, 78)
        Me.cmb_ALTA_PLANI_CARRERA.Name = "cmb_ALTA_PLANI_CARRERA"
        Me.cmb_ALTA_PLANI_CARRERA.Size = New System.Drawing.Size(185, 28)
        Me.cmb_ALTA_PLANI_CARRERA.TabIndex = 4
        '
        'cmb_ALTAS_PLANI_DIA
        '
        Me.cmb_ALTAS_PLANI_DIA.FormattingEnabled = True
        Me.cmb_ALTAS_PLANI_DIA.Items.AddRange(New Object() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado"})
        Me.cmb_ALTAS_PLANI_DIA.Location = New System.Drawing.Point(85, 20)
        Me.cmb_ALTAS_PLANI_DIA.Name = "cmb_ALTAS_PLANI_DIA"
        Me.cmb_ALTAS_PLANI_DIA.Size = New System.Drawing.Size(187, 28)
        Me.cmb_ALTAS_PLANI_DIA.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 20)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Dia"
        '
        'txb_ALTAS_PLANILLADOR_DESCRIPCION
        '
        Me.txb_ALTAS_PLANILLADOR_DESCRIPCION.Location = New System.Drawing.Point(86, 216)
        Me.txb_ALTAS_PLANILLADOR_DESCRIPCION.Name = "txb_ALTAS_PLANILLADOR_DESCRIPCION"
        Me.txb_ALTAS_PLANILLADOR_DESCRIPCION.Size = New System.Drawing.Size(186, 26)
        Me.txb_ALTAS_PLANILLADOR_DESCRIPCION.TabIndex = 9
        '
        'lbl_ALTAS_PLANILLA_DESCRI
        '
        Me.lbl_ALTAS_PLANILLA_DESCRI.AutoSize = True
        Me.lbl_ALTAS_PLANILLA_DESCRI.Location = New System.Drawing.Point(-1, 219)
        Me.lbl_ALTAS_PLANILLA_DESCRI.Name = "lbl_ALTAS_PLANILLA_DESCRI"
        Me.lbl_ALTAS_PLANILLA_DESCRI.Size = New System.Drawing.Size(92, 20)
        Me.lbl_ALTAS_PLANILLA_DESCRI.TabIndex = 43
        Me.lbl_ALTAS_PLANILLA_DESCRI.Text = "Descripción"
        '
        'cmb_ALTAS_PLANI_SALON
        '
        Me.cmb_ALTAS_PLANI_SALON.Enabled = False
        Me.cmb_ALTAS_PLANI_SALON.FormattingEnabled = True
        Me.cmb_ALTAS_PLANI_SALON.Location = New System.Drawing.Point(86, 175)
        Me.cmb_ALTAS_PLANI_SALON.Name = "cmb_ALTAS_PLANI_SALON"
        Me.cmb_ALTAS_PLANI_SALON.Size = New System.Drawing.Size(186, 28)
        Me.cmb_ALTAS_PLANI_SALON.TabIndex = 7
        '
        'cmb_ALTAS_PLANI_HORARIO
        '
        Me.cmb_ALTAS_PLANI_HORARIO.Enabled = False
        Me.cmb_ALTAS_PLANI_HORARIO.FormattingEnabled = True
        Me.cmb_ALTAS_PLANI_HORARIO.Location = New System.Drawing.Point(85, 79)
        Me.cmb_ALTAS_PLANI_HORARIO.Name = "cmb_ALTAS_PLANI_HORARIO"
        Me.cmb_ALTAS_PLANI_HORARIO.Size = New System.Drawing.Size(187, 28)
        Me.cmb_ALTAS_PLANI_HORARIO.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 178)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 20)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Salon"
        '
        'dgv_PLANI_ALTAS
        '
        Me.dgv_PLANI_ALTAS.AllowUserToAddRows = False
        Me.dgv_PLANI_ALTAS.AllowUserToDeleteRows = False
        Me.dgv_PLANI_ALTAS.AllowUserToResizeColumns = False
        Me.dgv_PLANI_ALTAS.AllowUserToResizeRows = False
        Me.dgv_PLANI_ALTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_PLANI_ALTAS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_PLANI_ALTAS.Location = New System.Drawing.Point(18, 253)
        Me.dgv_PLANI_ALTAS.MultiSelect = False
        Me.dgv_PLANI_ALTAS.Name = "dgv_PLANI_ALTAS"
        Me.dgv_PLANI_ALTAS.RowHeadersVisible = False
        Me.dgv_PLANI_ALTAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_PLANI_ALTAS.Size = New System.Drawing.Size(551, 110)
        Me.dgv_PLANI_ALTAS.TabIndex = 38
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(20, 369)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(128, 32)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Cancelar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btn_PLANI_ALTAS_GUARDAR
        '
        Me.btn_PLANI_ALTAS_GUARDAR.Location = New System.Drawing.Point(426, 369)
        Me.btn_PLANI_ALTAS_GUARDAR.Name = "btn_PLANI_ALTAS_GUARDAR"
        Me.btn_PLANI_ALTAS_GUARDAR.Size = New System.Drawing.Size(128, 32)
        Me.btn_PLANI_ALTAS_GUARDAR.TabIndex = 10
        Me.btn_PLANI_ALTAS_GUARDAR.Text = "Guardar"
        Me.btn_PLANI_ALTAS_GUARDAR.UseVisualStyleBackColor = True
        '
        'cmb_ALTAS_PLANI_PROFESOR
        '
        Me.cmb_ALTAS_PLANI_PROFESOR.Enabled = False
        Me.cmb_ALTAS_PLANI_PROFESOR.FormattingEnabled = True
        Me.cmb_ALTAS_PLANI_PROFESOR.Location = New System.Drawing.Point(369, 175)
        Me.cmb_ALTAS_PLANI_PROFESOR.Name = "cmb_ALTAS_PLANI_PROFESOR"
        Me.cmb_ALTAS_PLANI_PROFESOR.Size = New System.Drawing.Size(185, 28)
        Me.cmb_ALTAS_PLANI_PROFESOR.TabIndex = 8
        '
        'cmb_ALTAS_PLANI_MATERIA
        '
        Me.cmb_ALTAS_PLANI_MATERIA.Enabled = False
        Me.cmb_ALTAS_PLANI_MATERIA.FormattingEnabled = True
        Me.cmb_ALTAS_PLANI_MATERIA.Location = New System.Drawing.Point(369, 132)
        Me.cmb_ALTAS_PLANI_MATERIA.Name = "cmb_ALTAS_PLANI_MATERIA"
        Me.cmb_ALTAS_PLANI_MATERIA.Size = New System.Drawing.Size(185, 28)
        Me.cmb_ALTAS_PLANI_MATERIA.TabIndex = 6
        '
        'cmb_ALTAS_PLANI_GRUPO
        '
        Me.cmb_ALTAS_PLANI_GRUPO.Enabled = False
        Me.cmb_ALTAS_PLANI_GRUPO.FormattingEnabled = True
        Me.cmb_ALTAS_PLANI_GRUPO.Location = New System.Drawing.Point(86, 135)
        Me.cmb_ALTAS_PLANI_GRUPO.Name = "cmb_ALTAS_PLANI_GRUPO"
        Me.cmb_ALTAS_PLANI_GRUPO.Size = New System.Drawing.Size(186, 28)
        Me.cmb_ALTAS_PLANI_GRUPO.TabIndex = 5
        '
        'cmb_ALTAS_PLANI_TURNO
        '
        Me.cmb_ALTAS_PLANI_TURNO.Enabled = False
        Me.cmb_ALTAS_PLANI_TURNO.FormattingEnabled = True
        Me.cmb_ALTAS_PLANI_TURNO.Location = New System.Drawing.Point(369, 20)
        Me.cmb_ALTAS_PLANI_TURNO.Name = "cmb_ALTAS_PLANI_TURNO"
        Me.cmb_ALTAS_PLANI_TURNO.Size = New System.Drawing.Size(185, 28)
        Me.cmb_ALTAS_PLANI_TURNO.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Profesor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Materia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Grupo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Horario"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(294, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 20)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Turno"
        '
        'Panel_Bajas
        '
        Me.Panel_Bajas.BackColor = System.Drawing.Color.White
        Me.Panel_Bajas.Controls.Add(Me.lbl_VERSION)
        Me.Panel_Bajas.Controls.Add(Me.cmb_PLANI_BAJAS_VERSION)
        Me.Panel_Bajas.Controls.Add(Me.dgv_PLANI_BAJAS)
        Me.Panel_Bajas.Controls.Add(Me.btn_BAJAS_BORRAR)
        Me.Panel_Bajas.Controls.Add(Me.btn_BAJAS_DESACTIVAR)
        Me.Panel_Bajas.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel_Bajas.Location = New System.Drawing.Point(181, 153)
        Me.Panel_Bajas.Name = "Panel_Bajas"
        Me.Panel_Bajas.Size = New System.Drawing.Size(586, 420)
        Me.Panel_Bajas.TabIndex = 39
        Me.Panel_Bajas.Visible = False
        '
        'lbl_VERSION
        '
        Me.lbl_VERSION.AutoSize = True
        Me.lbl_VERSION.Location = New System.Drawing.Point(267, 28)
        Me.lbl_VERSION.Name = "lbl_VERSION"
        Me.lbl_VERSION.Size = New System.Drawing.Size(63, 20)
        Me.lbl_VERSION.TabIndex = 30
        Me.lbl_VERSION.Text = "Version"
        '
        'cmb_PLANI_BAJAS_VERSION
        '
        Me.cmb_PLANI_BAJAS_VERSION.FormattingEnabled = True
        Me.cmb_PLANI_BAJAS_VERSION.Location = New System.Drawing.Point(230, 55)
        Me.cmb_PLANI_BAJAS_VERSION.Name = "cmb_PLANI_BAJAS_VERSION"
        Me.cmb_PLANI_BAJAS_VERSION.Size = New System.Drawing.Size(138, 28)
        Me.cmb_PLANI_BAJAS_VERSION.TabIndex = 1
        '
        'dgv_PLANI_BAJAS
        '
        Me.dgv_PLANI_BAJAS.AllowUserToAddRows = False
        Me.dgv_PLANI_BAJAS.AllowUserToDeleteRows = False
        Me.dgv_PLANI_BAJAS.AllowUserToResizeColumns = False
        Me.dgv_PLANI_BAJAS.AllowUserToResizeRows = False
        Me.dgv_PLANI_BAJAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_PLANI_BAJAS.Location = New System.Drawing.Point(30, 105)
        Me.dgv_PLANI_BAJAS.MultiSelect = False
        Me.dgv_PLANI_BAJAS.Name = "dgv_PLANI_BAJAS"
        Me.dgv_PLANI_BAJAS.RowHeadersVisible = False
        Me.dgv_PLANI_BAJAS.Size = New System.Drawing.Size(524, 275)
        Me.dgv_PLANI_BAJAS.TabIndex = 2
        '
        'btn_BAJAS_BORRAR
        '
        Me.btn_BAJAS_BORRAR.Location = New System.Drawing.Point(458, 51)
        Me.btn_BAJAS_BORRAR.Name = "btn_BAJAS_BORRAR"
        Me.btn_BAJAS_BORRAR.Size = New System.Drawing.Size(96, 35)
        Me.btn_BAJAS_BORRAR.TabIndex = 4
        Me.btn_BAJAS_BORRAR.Text = "Borrar"
        Me.btn_BAJAS_BORRAR.UseVisualStyleBackColor = True
        '
        'btn_BAJAS_DESACTIVAR
        '
        Me.btn_BAJAS_DESACTIVAR.Location = New System.Drawing.Point(30, 51)
        Me.btn_BAJAS_DESACTIVAR.Name = "btn_BAJAS_DESACTIVAR"
        Me.btn_BAJAS_DESACTIVAR.Size = New System.Drawing.Size(96, 35)
        Me.btn_BAJAS_DESACTIVAR.TabIndex = 3
        Me.btn_BAJAS_DESACTIVAR.Text = "Desactivar"
        Me.btn_BAJAS_DESACTIVAR.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(326, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Turno"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Horario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(326, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Grupo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Materia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(326, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Profesor"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(-20, 148)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox5.TabIndex = 6
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'cmb_PLANILLA_MODIFICAR_TURNO
        '
        Me.cmb_PLANILLA_MODIFICAR_TURNO.FormattingEnabled = True
        Me.cmb_PLANILLA_MODIFICAR_TURNO.Location = New System.Drawing.Point(401, 51)
        Me.cmb_PLANILLA_MODIFICAR_TURNO.Name = "cmb_PLANILLA_MODIFICAR_TURNO"
        Me.cmb_PLANILLA_MODIFICAR_TURNO.Size = New System.Drawing.Size(153, 28)
        Me.cmb_PLANILLA_MODIFICAR_TURNO.TabIndex = 5
        '
        'cmb_PLANILLA_MODIFICAR_HORA
        '
        Me.cmb_PLANILLA_MODIFICAR_HORA.FormattingEnabled = True
        Me.cmb_PLANILLA_MODIFICAR_HORA.Location = New System.Drawing.Point(104, 89)
        Me.cmb_PLANILLA_MODIFICAR_HORA.Name = "cmb_PLANILLA_MODIFICAR_HORA"
        Me.cmb_PLANILLA_MODIFICAR_HORA.Size = New System.Drawing.Size(200, 28)
        Me.cmb_PLANILLA_MODIFICAR_HORA.TabIndex = 6
        '
        'cmb_PLANILLA_MODIFICAR_GRUPO
        '
        Me.cmb_PLANILLA_MODIFICAR_GRUPO.FormattingEnabled = True
        Me.cmb_PLANILLA_MODIFICAR_GRUPO.Location = New System.Drawing.Point(401, 89)
        Me.cmb_PLANILLA_MODIFICAR_GRUPO.Name = "cmb_PLANILLA_MODIFICAR_GRUPO"
        Me.cmb_PLANILLA_MODIFICAR_GRUPO.Size = New System.Drawing.Size(153, 28)
        Me.cmb_PLANILLA_MODIFICAR_GRUPO.TabIndex = 7
        '
        'cmb_PLANILLA_MODIFICAR_MATERIA
        '
        Me.cmb_PLANILLA_MODIFICAR_MATERIA.FormattingEnabled = True
        Me.cmb_PLANILLA_MODIFICAR_MATERIA.Location = New System.Drawing.Point(104, 124)
        Me.cmb_PLANILLA_MODIFICAR_MATERIA.Name = "cmb_PLANILLA_MODIFICAR_MATERIA"
        Me.cmb_PLANILLA_MODIFICAR_MATERIA.Size = New System.Drawing.Size(200, 28)
        Me.cmb_PLANILLA_MODIFICAR_MATERIA.TabIndex = 8
        '
        'cmb_PLANILLA_MODIFICAR_PROFESOR
        '
        Me.cmb_PLANILLA_MODIFICAR_PROFESOR.FormattingEnabled = True
        Me.cmb_PLANILLA_MODIFICAR_PROFESOR.Location = New System.Drawing.Point(401, 166)
        Me.cmb_PLANILLA_MODIFICAR_PROFESOR.Name = "cmb_PLANILLA_MODIFICAR_PROFESOR"
        Me.cmb_PLANILLA_MODIFICAR_PROFESOR.Size = New System.Drawing.Size(154, 28)
        Me.cmb_PLANILLA_MODIFICAR_PROFESOR.TabIndex = 11
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(427, 369)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 32)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(34, 369)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 32)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Version"
        '
        'txb_PLANI_MODI_VERSION
        '
        Me.txb_PLANI_MODI_VERSION.Location = New System.Drawing.Point(104, 12)
        Me.txb_PLANI_MODI_VERSION.Name = "txb_PLANI_MODI_VERSION"
        Me.txb_PLANI_MODI_VERSION.Size = New System.Drawing.Size(200, 26)
        Me.txb_PLANI_MODI_VERSION.TabIndex = 1
        '
        'btn_PLANI_MODI_BUSCAR
        '
        Me.btn_PLANI_MODI_BUSCAR.Location = New System.Drawing.Point(144, 48)
        Me.btn_PLANI_MODI_BUSCAR.Name = "btn_PLANI_MODI_BUSCAR"
        Me.btn_PLANI_MODI_BUSCAR.Size = New System.Drawing.Size(128, 32)
        Me.btn_PLANI_MODI_BUSCAR.TabIndex = 2
        Me.btn_PLANI_MODI_BUSCAR.Text = "Buscar"
        Me.btn_PLANI_MODI_BUSCAR.UseVisualStyleBackColor = True
        '
        'dgv_PLANI_MODI
        '
        Me.dgv_PLANI_MODI.AllowUserToAddRows = False
        Me.dgv_PLANI_MODI.AllowUserToDeleteRows = False
        Me.dgv_PLANI_MODI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_PLANI_MODI.Location = New System.Drawing.Point(34, 239)
        Me.dgv_PLANI_MODI.MultiSelect = False
        Me.dgv_PLANI_MODI.Name = "dgv_PLANI_MODI"
        Me.dgv_PLANI_MODI.RowHeadersVisible = False
        Me.dgv_PLANI_MODI.Size = New System.Drawing.Size(521, 124)
        Me.dgv_PLANI_MODI.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(326, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 20)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Dia"
        '
        'cmb_PLANILLA_MODIFICAR_DIA
        '
        Me.cmb_PLANILLA_MODIFICAR_DIA.FormattingEnabled = True
        Me.cmb_PLANILLA_MODIFICAR_DIA.Items.AddRange(New Object() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado"})
        Me.cmb_PLANILLA_MODIFICAR_DIA.Location = New System.Drawing.Point(401, 10)
        Me.cmb_PLANILLA_MODIFICAR_DIA.Name = "cmb_PLANILLA_MODIFICAR_DIA"
        Me.cmb_PLANILLA_MODIFICAR_DIA.Size = New System.Drawing.Size(153, 28)
        Me.cmb_PLANILLA_MODIFICAR_DIA.TabIndex = 4
        '
        'lbl_PLANI_MODI_NOMBRE
        '
        Me.lbl_PLANI_MODI_NOMBRE.AutoSize = True
        Me.lbl_PLANI_MODI_NOMBRE.Location = New System.Drawing.Point(412, 200)
        Me.lbl_PLANI_MODI_NOMBRE.Name = "lbl_PLANI_MODI_NOMBRE"
        Me.lbl_PLANI_MODI_NOMBRE.Size = New System.Drawing.Size(66, 20)
        Me.lbl_PLANI_MODI_NOMBRE.TabIndex = 22
        Me.lbl_PLANI_MODI_NOMBRE.Text = "Label18"
        Me.lbl_PLANI_MODI_NOMBRE.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(28, 164)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 20)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Salon"
        '
        'cmb_PLANILLA_MODIFICAR_SALON
        '
        Me.cmb_PLANILLA_MODIFICAR_SALON.FormattingEnabled = True
        Me.cmb_PLANILLA_MODIFICAR_SALON.Location = New System.Drawing.Point(104, 161)
        Me.cmb_PLANILLA_MODIFICAR_SALON.Name = "cmb_PLANILLA_MODIFICAR_SALON"
        Me.cmb_PLANILLA_MODIFICAR_SALON.Size = New System.Drawing.Size(200, 28)
        Me.cmb_PLANILLA_MODIFICAR_SALON.TabIndex = 10
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(14, 200)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 20)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Descripcion"
        '
        'txb_PLANILLA_MODI_DESCRI
        '
        Me.txb_PLANILLA_MODI_DESCRI.Location = New System.Drawing.Point(104, 197)
        Me.txb_PLANILLA_MODI_DESCRI.Name = "txb_PLANILLA_MODI_DESCRI"
        Me.txb_PLANILLA_MODI_DESCRI.Size = New System.Drawing.Size(200, 26)
        Me.txb_PLANILLA_MODI_DESCRI.TabIndex = 12
        '
        'Panel_modificaciones
        '
        Me.Panel_modificaciones.BackColor = System.Drawing.Color.White
        Me.Panel_modificaciones.Controls.Add(Me.cmb_PLANILLA_MODIFICAR_BAJA)
        Me.Panel_modificaciones.Controls.Add(Me.Label1)
        Me.Panel_modificaciones.Controls.Add(Me.txb_PLANILLA_MODI_DESCRI)
        Me.Panel_modificaciones.Controls.Add(Me.Label19)
        Me.Panel_modificaciones.Controls.Add(Me.cmb_PLANILLA_MODIFICAR_SALON)
        Me.Panel_modificaciones.Controls.Add(Me.Label18)
        Me.Panel_modificaciones.Controls.Add(Me.lbl_PLANI_MODI_NOMBRE)
        Me.Panel_modificaciones.Controls.Add(Me.cmb_PLANILLA_MODIFICAR_DIA)
        Me.Panel_modificaciones.Controls.Add(Me.Label16)
        Me.Panel_modificaciones.Controls.Add(Me.dgv_PLANI_MODI)
        Me.Panel_modificaciones.Controls.Add(Me.btn_PLANI_MODI_BUSCAR)
        Me.Panel_modificaciones.Controls.Add(Me.txb_PLANI_MODI_VERSION)
        Me.Panel_modificaciones.Controls.Add(Me.Label11)
        Me.Panel_modificaciones.Controls.Add(Me.Button3)
        Me.Panel_modificaciones.Controls.Add(Me.Button4)
        Me.Panel_modificaciones.Controls.Add(Me.cmb_PLANILLA_MODIFICAR_PROFESOR)
        Me.Panel_modificaciones.Controls.Add(Me.cmb_PLANILLA_MODIFICAR_MATERIA)
        Me.Panel_modificaciones.Controls.Add(Me.cmb_PLANILLA_MODIFICAR_GRUPO)
        Me.Panel_modificaciones.Controls.Add(Me.cmb_PLANILLA_MODIFICAR_HORA)
        Me.Panel_modificaciones.Controls.Add(Me.cmb_PLANILLA_MODIFICAR_TURNO)
        Me.Panel_modificaciones.Controls.Add(Me.CheckBox5)
        Me.Panel_modificaciones.Controls.Add(Me.Label6)
        Me.Panel_modificaciones.Controls.Add(Me.Label7)
        Me.Panel_modificaciones.Controls.Add(Me.Label8)
        Me.Panel_modificaciones.Controls.Add(Me.Label9)
        Me.Panel_modificaciones.Controls.Add(Me.Label10)
        Me.Panel_modificaciones.Location = New System.Drawing.Point(181, 153)
        Me.Panel_modificaciones.Name = "Panel_modificaciones"
        Me.Panel_modificaciones.Size = New System.Drawing.Size(586, 420)
        Me.Panel_modificaciones.TabIndex = 17
        Me.Panel_modificaciones.Visible = False
        '
        'cmb_PLANILLA_MODIFICAR_BAJA
        '
        Me.cmb_PLANILLA_MODIFICAR_BAJA.FormattingEnabled = True
        Me.cmb_PLANILLA_MODIFICAR_BAJA.Items.AddRange(New Object() {"si", "no"})
        Me.cmb_PLANILLA_MODIFICAR_BAJA.Location = New System.Drawing.Point(401, 129)
        Me.cmb_PLANILLA_MODIFICAR_BAJA.Name = "cmb_PLANILLA_MODIFICAR_BAJA"
        Me.cmb_PLANILLA_MODIFICAR_BAJA.Size = New System.Drawing.Size(153, 28)
        Me.cmb_PLANILLA_MODIFICAR_BAJA.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Baja"
        '
        'cmb_PLANILLA_MODIFICAR_AÑO
        '
        Me.cmb_PLANILLA_MODIFICAR_AÑO.FormattingEnabled = True
        Me.cmb_PLANILLA_MODIFICAR_AÑO.Location = New System.Drawing.Point(267, 119)
        Me.cmb_PLANILLA_MODIFICAR_AÑO.Name = "cmb_PLANILLA_MODIFICAR_AÑO"
        Me.cmb_PLANILLA_MODIFICAR_AÑO.Size = New System.Drawing.Size(121, 28)
        Me.cmb_PLANILLA_MODIFICAR_AÑO.TabIndex = 28
        '
        'cmb_PLANILLA_MODIFICAR_VERSION
        '
        Me.cmb_PLANILLA_MODIFICAR_VERSION.FormattingEnabled = True
        Me.cmb_PLANILLA_MODIFICAR_VERSION.Location = New System.Drawing.Point(419, 119)
        Me.cmb_PLANILLA_MODIFICAR_VERSION.Name = "cmb_PLANILLA_MODIFICAR_VERSION"
        Me.cmb_PLANILLA_MODIFICAR_VERSION.Size = New System.Drawing.Size(121, 28)
        Me.cmb_PLANILLA_MODIFICAR_VERSION.TabIndex = 40
        '
        'Planillador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(804, 620)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmb_PLANILLA_MODIFICAR_VERSION)
        Me.Controls.Add(Me.cmb_PLANILLA_MODIFICAR_AÑO)
        Me.Controls.Add(Me.pbx_PLANILLADOR_MODI)
        Me.Controls.Add(Me.pbx_PLANILLADOR_BAJAS)
        Me.Controls.Add(Me.pbx_PLANILLADOR_ALTAS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel_modificaciones)
        Me.Controls.Add(Me.Panel_Bajas)
        Me.Controls.Add(Me.Panel_Altas)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Planillador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planillador"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_PLANILLADOR_MODI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_PLANILLADOR_BAJAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_PLANILLADOR_ALTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Altas.ResumeLayout(False)
        Me.Panel_Altas.PerformLayout()
        CType(Me.dgv_PLANI_ALTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Bajas.ResumeLayout(False)
        Me.Panel_Bajas.PerformLayout()
        CType(Me.dgv_PLANI_BAJAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_PLANI_MODI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_modificaciones.ResumeLayout(False)
        Me.Panel_modificaciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_PLANILLADOR_MODI As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_PLANILLADOR_BAJAS As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_PLANILLADOR_ALTAS As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_Altas As System.Windows.Forms.Panel
    Friend WithEvents dgv_PLANI_ALTAS As System.Windows.Forms.DataGridView
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btn_PLANI_ALTAS_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents cmb_ALTAS_PLANI_PROFESOR As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ALTAS_PLANI_MATERIA As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ALTAS_PLANI_GRUPO As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ALTAS_PLANI_HORARIO As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ALTAS_PLANI_TURNO As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel_Bajas As System.Windows.Forms.Panel
    Friend WithEvents btn_BAJAS_BORRAR As System.Windows.Forms.Button
    Friend WithEvents btn_BAJAS_DESACTIVAR As System.Windows.Forms.Button
    Friend WithEvents cmb_ALTAS_PLANI_SALON As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txb_ALTAS_PLANILLADOR_DESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ALTAS_PLANILLA_DESCRI As System.Windows.Forms.Label
    Friend WithEvents cmb_ALTAS_PLANI_DIA As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_ALTA_PLANI_CARRERA As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_ALTA_nombre As System.Windows.Forms.Label
    Friend WithEvents btn_ALTAS_PLANI_ASIGNAR As System.Windows.Forms.Button
    Friend WithEvents cmb_PLANI_BAJAS_VERSION As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_PLANI_BAJAS As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_VERSION As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_PLANILLA_MODIFICAR_TURNO As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_PLANILLA_MODIFICAR_HORA As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_PLANILLA_MODIFICAR_GRUPO As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_PLANILLA_MODIFICAR_MATERIA As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_PLANILLA_MODIFICAR_PROFESOR As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txb_PLANI_MODI_VERSION As System.Windows.Forms.TextBox
    Friend WithEvents btn_PLANI_MODI_BUSCAR As System.Windows.Forms.Button
    Friend WithEvents dgv_PLANI_MODI As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmb_PLANILLA_MODIFICAR_DIA As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_PLANI_MODI_NOMBRE As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmb_PLANILLA_MODIFICAR_SALON As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txb_PLANILLA_MODI_DESCRI As System.Windows.Forms.TextBox
    Friend WithEvents Panel_modificaciones As System.Windows.Forms.Panel
    Friend WithEvents cmb_PLANILLA_MODIFICAR_BAJA As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_PLANILLA_MODIFICAR_AÑO As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_PLANILLA_MODIFICAR_VERSION As System.Windows.Forms.ComboBox
End Class
