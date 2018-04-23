<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultor))
        Me.dgv_CONSULTOR = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.tbc_CONSULTOR = New System.Windows.Forms.TabControl
        Me.tbp_CONDULTOR_PLANILLA = New System.Windows.Forms.TabPage
        Me.PanelVersionNueva = New System.Windows.Forms.Panel
        Me.cmb_AÑO = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmBxVersion_CONSULTOR = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA = New System.Windows.Forms.TabPage
        Me.lbl_profesor = New System.Windows.Forms.Label
        Me.lbl_PROFESORSELECCIONADO = New System.Windows.Forms.Label
        Me.lbl_planillador_PROFESORESQUEDICTAN = New System.Windows.Forms.Label
        Me.cmb_PLANILLADOR_PROFESORESQUEDICTAN = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbl_LISTAR = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_PROFESXMATERIAS = New System.Windows.Forms.ComboBox
        Me.tbp_HORARIOSSEGUNGRUPOS = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbl_CONSULTOR_SELECCIONDEGRUPO = New System.Windows.Forms.Label
        Me.cmb_CONSULTOR_SELECCIONDEGRUPO = New System.Windows.Forms.ComboBox
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES = New System.Windows.Forms.TabPage
        Me.cmb_SALON = New System.Windows.Forms.ComboBox
        Me.lbl_sect_codigo = New System.Windows.Forms.Label
        Me.lbl_CONSULTOR_CONSULTARSALON = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmb_CONSULTOR_CONSULTARSALON = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.tbp_CONSULTOR_BD = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_CONSULTOR_BD = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tbp_HISTORIAL = New System.Windows.Forms.TabPage
        Me.CMB_HISTORIAL_FECHA = New System.Windows.Forms.ComboBox
        Me.cmb_SELECCION_DE_SCCION = New System.Windows.Forms.ComboBox
        Me.lbl_SELECCIONE_ACCION = New System.Windows.Forms.Label
        Me.lbl_HISTORIAL_SELECCIONE_FECHA = New System.Windows.Forms.Label
        Me.lbl_HISTORIAL_NOMBRE = New System.Windows.Forms.Label
        Me.cmb_historial_seleccionar_ci = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_FILTRO_HISTORIAL = New System.Windows.Forms.ComboBox
        Me.lbl_HISTORIAL_SELECCIONE_CI = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.dgv_CONSULTOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbc_CONSULTOR.SuspendLayout()
        Me.tbp_CONDULTOR_PLANILLA.SuspendLayout()
        Me.PanelVersionNueva.SuspendLayout()
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.SuspendLayout()
        Me.tbp_HORARIOSSEGUNGRUPOS.SuspendLayout()
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.SuspendLayout()
        Me.tbp_CONSULTOR_BD.SuspendLayout()
        Me.tbp_HISTORIAL.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_CONSULTOR
        '
        Me.dgv_CONSULTOR.AllowUserToOrderColumns = True
        Me.dgv_CONSULTOR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_CONSULTOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CONSULTOR.Location = New System.Drawing.Point(16, 351)
        Me.dgv_CONSULTOR.Name = "dgv_CONSULTOR"
        Me.dgv_CONSULTOR.Size = New System.Drawing.Size(776, 257)
        Me.dgv_CONSULTOR.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(-248, -117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese su cedula"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(814, 600)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 34)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Atras"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbc_CONSULTOR
        '
        Me.tbc_CONSULTOR.Controls.Add(Me.tbp_CONDULTOR_PLANILLA)
        Me.tbc_CONSULTOR.Controls.Add(Me.tbp_PLANILLADOR_PROFESORESXMATERIA)
        Me.tbc_CONSULTOR.Controls.Add(Me.tbp_HORARIOSSEGUNGRUPOS)
        Me.tbc_CONSULTOR.Controls.Add(Me.tbp_CONSULTOR_DISPONIBILIDADSALONES)
        Me.tbc_CONSULTOR.Controls.Add(Me.tbp_CONSULTOR_BD)
        Me.tbc_CONSULTOR.Controls.Add(Me.tbp_HISTORIAL)
        Me.tbc_CONSULTOR.Location = New System.Drawing.Point(16, 78)
        Me.tbc_CONSULTOR.Name = "tbc_CONSULTOR"
        Me.tbc_CONSULTOR.SelectedIndex = 0
        Me.tbc_CONSULTOR.Size = New System.Drawing.Size(776, 267)
        Me.tbc_CONSULTOR.TabIndex = 0
        '
        'tbp_CONDULTOR_PLANILLA
        '
        Me.tbp_CONDULTOR_PLANILLA.Controls.Add(Me.PanelVersionNueva)
        Me.tbp_CONDULTOR_PLANILLA.Controls.Add(Me.Label8)
        Me.tbp_CONDULTOR_PLANILLA.Location = New System.Drawing.Point(4, 29)
        Me.tbp_CONDULTOR_PLANILLA.Name = "tbp_CONDULTOR_PLANILLA"
        Me.tbp_CONDULTOR_PLANILLA.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_CONDULTOR_PLANILLA.Size = New System.Drawing.Size(768, 234)
        Me.tbp_CONDULTOR_PLANILLA.TabIndex = 2
        Me.tbp_CONDULTOR_PLANILLA.Text = "Planilla"
        Me.tbp_CONDULTOR_PLANILLA.UseVisualStyleBackColor = True
        '
        'PanelVersionNueva
        '
        Me.PanelVersionNueva.BackColor = System.Drawing.Color.Transparent
        Me.PanelVersionNueva.Controls.Add(Me.cmb_AÑO)
        Me.PanelVersionNueva.Controls.Add(Me.Label5)
        Me.PanelVersionNueva.Controls.Add(Me.CmBxVersion_CONSULTOR)
        Me.PanelVersionNueva.Controls.Add(Me.Label15)
        Me.PanelVersionNueva.Location = New System.Drawing.Point(30, 87)
        Me.PanelVersionNueva.Name = "PanelVersionNueva"
        Me.PanelVersionNueva.Size = New System.Drawing.Size(708, 93)
        Me.PanelVersionNueva.TabIndex = 9
        '
        'cmb_AÑO
        '
        Me.cmb_AÑO.FormattingEnabled = True
        Me.cmb_AÑO.Location = New System.Drawing.Point(76, 17)
        Me.cmb_AÑO.Name = "cmb_AÑO"
        Me.cmb_AÑO.Size = New System.Drawing.Size(100, 28)
        Me.cmb_AÑO.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Año"
        '
        'CmBxVersion_CONSULTOR
        '
        Me.CmBxVersion_CONSULTOR.Enabled = False
        Me.CmBxVersion_CONSULTOR.FormattingEnabled = True
        Me.CmBxVersion_CONSULTOR.Location = New System.Drawing.Point(426, 17)
        Me.CmBxVersion_CONSULTOR.Name = "CmBxVersion_CONSULTOR"
        Me.CmBxVersion_CONSULTOR.Size = New System.Drawing.Size(176, 28)
        Me.CmBxVersion_CONSULTOR.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(339, 23)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 16)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Version"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(289, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Listar planillas"
        '
        'tbp_PLANILLADOR_PROFESORESXMATERIA
        '
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.Controls.Add(Me.lbl_profesor)
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.Controls.Add(Me.lbl_PROFESORSELECCIONADO)
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.Controls.Add(Me.lbl_planillador_PROFESORESQUEDICTAN)
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.Controls.Add(Me.cmb_PLANILLADOR_PROFESORESQUEDICTAN)
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.Controls.Add(Me.Label6)
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.Controls.Add(Me.lbl_LISTAR)
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.Controls.Add(Me.Label3)
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.Controls.Add(Me.cmb_PROFESXMATERIAS)
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.Location = New System.Drawing.Point(4, 29)
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.Name = "tbp_PLANILLADOR_PROFESORESXMATERIA"
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.Size = New System.Drawing.Size(768, 234)
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.TabIndex = 1
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.Text = "Prof. X Materias"
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.UseVisualStyleBackColor = True
        '
        'lbl_profesor
        '
        Me.lbl_profesor.AutoSize = True
        Me.lbl_profesor.Location = New System.Drawing.Point(376, 125)
        Me.lbl_profesor.Name = "lbl_profesor"
        Me.lbl_profesor.Size = New System.Drawing.Size(73, 20)
        Me.lbl_profesor.TabIndex = 9
        Me.lbl_profesor.Text = "Profesor:"
        Me.lbl_profesor.Visible = False
        '
        'lbl_PROFESORSELECCIONADO
        '
        Me.lbl_PROFESORSELECCIONADO.AutoSize = True
        Me.lbl_PROFESORSELECCIONADO.Location = New System.Drawing.Point(589, 125)
        Me.lbl_PROFESORSELECCIONADO.Name = "lbl_PROFESORSELECCIONADO"
        Me.lbl_PROFESORSELECCIONADO.Size = New System.Drawing.Size(57, 20)
        Me.lbl_PROFESORSELECCIONADO.TabIndex = 8
        Me.lbl_PROFESORSELECCIONADO.Text = "Label7"
        Me.lbl_PROFESORSELECCIONADO.Visible = False
        '
        'lbl_planillador_PROFESORESQUEDICTAN
        '
        Me.lbl_planillador_PROFESORESQUEDICTAN.AutoSize = True
        Me.lbl_planillador_PROFESORESQUEDICTAN.Location = New System.Drawing.Point(376, 78)
        Me.lbl_planillador_PROFESORESQUEDICTAN.Name = "lbl_planillador_PROFESORESQUEDICTAN"
        Me.lbl_planillador_PROFESORESQUEDICTAN.Size = New System.Drawing.Size(211, 20)
        Me.lbl_planillador_PROFESORESQUEDICTAN.TabIndex = 7
        Me.lbl_planillador_PROFESORESQUEDICTAN.Text = "Seleccione la CI del profesor"
        '
        'cmb_PLANILLADOR_PROFESORESQUEDICTAN
        '
        Me.cmb_PLANILLADOR_PROFESORESQUEDICTAN.FormattingEnabled = True
        Me.cmb_PLANILLADOR_PROFESORESQUEDICTAN.Location = New System.Drawing.Point(593, 78)
        Me.cmb_PLANILLADOR_PROFESORESQUEDICTAN.Name = "cmb_PLANILLADOR_PROFESORESQUEDICTAN"
        Me.cmb_PLANILLADOR_PROFESORESQUEDICTAN.Size = New System.Drawing.Size(121, 28)
        Me.cmb_PLANILLADOR_PROFESORESQUEDICTAN.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(401, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(325, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Listar materias que dicta un profesor"
        '
        'lbl_LISTAR
        '
        Me.lbl_LISTAR.AutoSize = True
        Me.lbl_LISTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LISTAR.ForeColor = System.Drawing.Color.Black
        Me.lbl_LISTAR.Location = New System.Drawing.Point(3, 18)
        Me.lbl_LISTAR.Name = "lbl_LISTAR"
        Me.lbl_LISTAR.Size = New System.Drawing.Size(358, 25)
        Me.lbl_LISTAR.TabIndex = 4
        Me.lbl_LISTAR.Text = "Listar profesores que dictan una matería"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Seleccione la materia"
        '
        'cmb_PROFESXMATERIAS
        '
        Me.cmb_PROFESXMATERIAS.FormattingEnabled = True
        Me.cmb_PROFESXMATERIAS.Location = New System.Drawing.Point(195, 77)
        Me.cmb_PROFESXMATERIAS.Name = "cmb_PROFESXMATERIAS"
        Me.cmb_PROFESXMATERIAS.Size = New System.Drawing.Size(121, 28)
        Me.cmb_PROFESXMATERIAS.TabIndex = 2
        '
        'tbp_HORARIOSSEGUNGRUPOS
        '
        Me.tbp_HORARIOSSEGUNGRUPOS.Controls.Add(Me.Label7)
        Me.tbp_HORARIOSSEGUNGRUPOS.Controls.Add(Me.lbl_CONSULTOR_SELECCIONDEGRUPO)
        Me.tbp_HORARIOSSEGUNGRUPOS.Controls.Add(Me.cmb_CONSULTOR_SELECCIONDEGRUPO)
        Me.tbp_HORARIOSSEGUNGRUPOS.Location = New System.Drawing.Point(4, 29)
        Me.tbp_HORARIOSSEGUNGRUPOS.Name = "tbp_HORARIOSSEGUNGRUPOS"
        Me.tbp_HORARIOSSEGUNGRUPOS.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_HORARIOSSEGUNGRUPOS.Size = New System.Drawing.Size(768, 234)
        Me.tbp_HORARIOSSEGUNGRUPOS.TabIndex = 0
        Me.tbp_HORARIOSSEGUNGRUPOS.Text = "Horario X Grupo"
        Me.tbp_HORARIOSSEGUNGRUPOS.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(158, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(394, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Listar los horarios para un grupo en especial"
        '
        'lbl_CONSULTOR_SELECCIONDEGRUPO
        '
        Me.lbl_CONSULTOR_SELECCIONDEGRUPO.AutoSize = True
        Me.lbl_CONSULTOR_SELECCIONDEGRUPO.Location = New System.Drawing.Point(144, 77)
        Me.lbl_CONSULTOR_SELECCIONDEGRUPO.Name = "lbl_CONSULTOR_SELECCIONDEGRUPO"
        Me.lbl_CONSULTOR_SELECCIONDEGRUPO.Size = New System.Drawing.Size(148, 20)
        Me.lbl_CONSULTOR_SELECCIONDEGRUPO.TabIndex = 1
        Me.lbl_CONSULTOR_SELECCIONDEGRUPO.Text = "Seleccione el grupo"
        '
        'cmb_CONSULTOR_SELECCIONDEGRUPO
        '
        Me.cmb_CONSULTOR_SELECCIONDEGRUPO.FormattingEnabled = True
        Me.cmb_CONSULTOR_SELECCIONDEGRUPO.Location = New System.Drawing.Point(333, 77)
        Me.cmb_CONSULTOR_SELECCIONDEGRUPO.Name = "cmb_CONSULTOR_SELECCIONDEGRUPO"
        Me.cmb_CONSULTOR_SELECCIONDEGRUPO.Size = New System.Drawing.Size(121, 28)
        Me.cmb_CONSULTOR_SELECCIONDEGRUPO.TabIndex = 0
        '
        'tbp_CONSULTOR_DISPONIBILIDADSALONES
        '
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.Controls.Add(Me.cmb_SALON)
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.Controls.Add(Me.lbl_sect_codigo)
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.Controls.Add(Me.lbl_CONSULTOR_CONSULTARSALON)
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.Controls.Add(Me.Label12)
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.Controls.Add(Me.cmb_CONSULTOR_CONSULTARSALON)
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.Controls.Add(Me.Label11)
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.Controls.Add(Me.Label10)
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.Location = New System.Drawing.Point(4, 29)
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.Name = "tbp_CONSULTOR_DISPONIBILIDADSALONES"
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.Size = New System.Drawing.Size(768, 234)
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.TabIndex = 3
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.Text = "Disponibilidad de salones"
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.UseVisualStyleBackColor = True
        '
        'cmb_SALON
        '
        Me.cmb_SALON.FormattingEnabled = True
        Me.cmb_SALON.Location = New System.Drawing.Point(431, 66)
        Me.cmb_SALON.Name = "cmb_SALON"
        Me.cmb_SALON.Size = New System.Drawing.Size(223, 28)
        Me.cmb_SALON.TabIndex = 13
        '
        'lbl_sect_codigo
        '
        Me.lbl_sect_codigo.AutoSize = True
        Me.lbl_sect_codigo.Location = New System.Drawing.Point(185, 110)
        Me.lbl_sect_codigo.Name = "lbl_sect_codigo"
        Me.lbl_sect_codigo.Size = New System.Drawing.Size(230, 20)
        Me.lbl_sect_codigo.TabIndex = 12
        Me.lbl_sect_codigo.Text = "Seleccionar  el codigo del salon"
        Me.lbl_sect_codigo.Visible = False
        '
        'lbl_CONSULTOR_CONSULTARSALON
        '
        Me.lbl_CONSULTOR_CONSULTARSALON.AutoSize = True
        Me.lbl_CONSULTOR_CONSULTARSALON.Location = New System.Drawing.Point(437, 151)
        Me.lbl_CONSULTOR_CONSULTARSALON.Name = "lbl_CONSULTOR_CONSULTARSALON"
        Me.lbl_CONSULTOR_CONSULTARSALON.Size = New System.Drawing.Size(21, 20)
        Me.lbl_CONSULTOR_CONSULTARSALON.TabIndex = 11
        Me.lbl_CONSULTOR_CONSULTARSALON.Text = "..."
        Me.lbl_CONSULTOR_CONSULTARSALON.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(181, 151)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 20)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Salon:"
        '
        'cmb_CONSULTOR_CONSULTARSALON
        '
        Me.cmb_CONSULTOR_CONSULTARSALON.FormattingEnabled = True
        Me.cmb_CONSULTOR_CONSULTARSALON.Location = New System.Drawing.Point(431, 107)
        Me.cmb_CONSULTOR_CONSULTARSALON.Name = "cmb_CONSULTOR_CONSULTARSALON"
        Me.cmb_CONSULTOR_CONSULTARSALON.Size = New System.Drawing.Size(223, 28)
        Me.cmb_CONSULTOR_CONSULTARSALON.TabIndex = 9
        Me.cmb_CONSULTOR_CONSULTARSALON.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(181, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Seleccionar  el salon"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(184, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(325, 25)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Consultar disponibilidad de un salón"
        '
        'tbp_CONSULTOR_BD
        '
        Me.tbp_CONSULTOR_BD.Controls.Add(Me.Label2)
        Me.tbp_CONSULTOR_BD.Controls.Add(Me.cmb_CONSULTOR_BD)
        Me.tbp_CONSULTOR_BD.Controls.Add(Me.Label13)
        Me.tbp_CONSULTOR_BD.Location = New System.Drawing.Point(4, 29)
        Me.tbp_CONSULTOR_BD.Name = "tbp_CONSULTOR_BD"
        Me.tbp_CONSULTOR_BD.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_CONSULTOR_BD.Size = New System.Drawing.Size(768, 234)
        Me.tbp_CONSULTOR_BD.TabIndex = 4
        Me.tbp_CONSULTOR_BD.Text = "base de datos"
        Me.tbp_CONSULTOR_BD.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Seleccione la tabla a consultar"
        '
        'cmb_CONSULTOR_BD
        '
        Me.cmb_CONSULTOR_BD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CONSULTOR_BD.FormattingEnabled = True
        Me.cmb_CONSULTOR_BD.Items.AddRange(New Object() {"Carrera", "Dicta", "Errores", "Grupo", "Historial", "Horario", "Materia", "Persona", "Planilla", "Salon", "Tiene", "Turno"})
        Me.cmb_CONSULTOR_BD.Location = New System.Drawing.Point(429, 97)
        Me.cmb_CONSULTOR_BD.Name = "cmb_CONSULTOR_BD"
        Me.cmb_CONSULTOR_BD.Size = New System.Drawing.Size(105, 28)
        Me.cmb_CONSULTOR_BD.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(163, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(411, 25)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Consultar todas las tablas de la base de datos"
        '
        'tbp_HISTORIAL
        '
        Me.tbp_HISTORIAL.Controls.Add(Me.CMB_HISTORIAL_FECHA)
        Me.tbp_HISTORIAL.Controls.Add(Me.cmb_SELECCION_DE_SCCION)
        Me.tbp_HISTORIAL.Controls.Add(Me.lbl_SELECCIONE_ACCION)
        Me.tbp_HISTORIAL.Controls.Add(Me.lbl_HISTORIAL_SELECCIONE_FECHA)
        Me.tbp_HISTORIAL.Controls.Add(Me.lbl_HISTORIAL_NOMBRE)
        Me.tbp_HISTORIAL.Controls.Add(Me.cmb_historial_seleccionar_ci)
        Me.tbp_HISTORIAL.Controls.Add(Me.Label14)
        Me.tbp_HISTORIAL.Controls.Add(Me.Label4)
        Me.tbp_HISTORIAL.Controls.Add(Me.cmb_FILTRO_HISTORIAL)
        Me.tbp_HISTORIAL.Controls.Add(Me.lbl_HISTORIAL_SELECCIONE_CI)
        Me.tbp_HISTORIAL.Location = New System.Drawing.Point(4, 29)
        Me.tbp_HISTORIAL.Name = "tbp_HISTORIAL"
        Me.tbp_HISTORIAL.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_HISTORIAL.Size = New System.Drawing.Size(768, 234)
        Me.tbp_HISTORIAL.TabIndex = 5
        Me.tbp_HISTORIAL.Text = "Historial"
        Me.tbp_HISTORIAL.UseVisualStyleBackColor = True
        '
        'CMB_HISTORIAL_FECHA
        '
        Me.CMB_HISTORIAL_FECHA.FormattingEnabled = True
        Me.CMB_HISTORIAL_FECHA.Location = New System.Drawing.Point(395, 82)
        Me.CMB_HISTORIAL_FECHA.Name = "CMB_HISTORIAL_FECHA"
        Me.CMB_HISTORIAL_FECHA.Size = New System.Drawing.Size(181, 28)
        Me.CMB_HISTORIAL_FECHA.TabIndex = 21
        Me.CMB_HISTORIAL_FECHA.Visible = False
        '
        'cmb_SELECCION_DE_SCCION
        '
        Me.cmb_SELECCION_DE_SCCION.FormattingEnabled = True
        Me.cmb_SELECCION_DE_SCCION.Location = New System.Drawing.Point(395, 82)
        Me.cmb_SELECCION_DE_SCCION.Name = "cmb_SELECCION_DE_SCCION"
        Me.cmb_SELECCION_DE_SCCION.Size = New System.Drawing.Size(181, 28)
        Me.cmb_SELECCION_DE_SCCION.TabIndex = 20
        Me.cmb_SELECCION_DE_SCCION.Visible = False
        '
        'lbl_SELECCIONE_ACCION
        '
        Me.lbl_SELECCIONE_ACCION.AutoSize = True
        Me.lbl_SELECCIONE_ACCION.Location = New System.Drawing.Point(233, 82)
        Me.lbl_SELECCIONE_ACCION.Name = "lbl_SELECCIONE_ACCION"
        Me.lbl_SELECCIONE_ACCION.Size = New System.Drawing.Size(153, 20)
        Me.lbl_SELECCIONE_ACCION.TabIndex = 19
        Me.lbl_SELECCIONE_ACCION.Text = "Seleccione la accion"
        Me.lbl_SELECCIONE_ACCION.Visible = False
        '
        'lbl_HISTORIAL_SELECCIONE_FECHA
        '
        Me.lbl_HISTORIAL_SELECCIONE_FECHA.AutoSize = True
        Me.lbl_HISTORIAL_SELECCIONE_FECHA.Location = New System.Drawing.Point(233, 85)
        Me.lbl_HISTORIAL_SELECCIONE_FECHA.Name = "lbl_HISTORIAL_SELECCIONE_FECHA"
        Me.lbl_HISTORIAL_SELECCIONE_FECHA.Size = New System.Drawing.Size(147, 20)
        Me.lbl_HISTORIAL_SELECCIONE_FECHA.TabIndex = 17
        Me.lbl_HISTORIAL_SELECCIONE_FECHA.Text = "Seleccione la fecha"
        Me.lbl_HISTORIAL_SELECCIONE_FECHA.Visible = False
        '
        'lbl_HISTORIAL_NOMBRE
        '
        Me.lbl_HISTORIAL_NOMBRE.AutoSize = True
        Me.lbl_HISTORIAL_NOMBRE.Location = New System.Drawing.Point(391, 128)
        Me.lbl_HISTORIAL_NOMBRE.Name = "lbl_HISTORIAL_NOMBRE"
        Me.lbl_HISTORIAL_NOMBRE.Size = New System.Drawing.Size(17, 20)
        Me.lbl_HISTORIAL_NOMBRE.TabIndex = 16
        Me.lbl_HISTORIAL_NOMBRE.Text = ".."
        Me.lbl_HISTORIAL_NOMBRE.Visible = False
        '
        'cmb_historial_seleccionar_ci
        '
        Me.cmb_historial_seleccionar_ci.FormattingEnabled = True
        Me.cmb_historial_seleccionar_ci.Location = New System.Drawing.Point(395, 82)
        Me.cmb_historial_seleccionar_ci.Name = "cmb_historial_seleccionar_ci"
        Me.cmb_historial_seleccionar_ci.Size = New System.Drawing.Size(181, 28)
        Me.cmb_historial_seleccionar_ci.TabIndex = 15
        Me.cmb_historial_seleccionar_ci.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(233, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(143, 20)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Seleccione un filtro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(297, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Consultar historial"
        '
        'cmb_FILTRO_HISTORIAL
        '
        Me.cmb_FILTRO_HISTORIAL.FormattingEnabled = True
        Me.cmb_FILTRO_HISTORIAL.Items.AddRange(New Object() {"Historial de una persona", "Historial de una fecha", "Historial por accion", "Todo el historial"})
        Me.cmb_FILTRO_HISTORIAL.Location = New System.Drawing.Point(395, 39)
        Me.cmb_FILTRO_HISTORIAL.Name = "cmb_FILTRO_HISTORIAL"
        Me.cmb_FILTRO_HISTORIAL.Size = New System.Drawing.Size(181, 28)
        Me.cmb_FILTRO_HISTORIAL.TabIndex = 11
        '
        'lbl_HISTORIAL_SELECCIONE_CI
        '
        Me.lbl_HISTORIAL_SELECCIONE_CI.AutoSize = True
        Me.lbl_HISTORIAL_SELECCIONE_CI.Location = New System.Drawing.Point(86, 85)
        Me.lbl_HISTORIAL_SELECCIONE_CI.Name = "lbl_HISTORIAL_SELECCIONE_CI"
        Me.lbl_HISTORIAL_SELECCIONE_CI.Size = New System.Drawing.Size(290, 20)
        Me.lbl_HISTORIAL_SELECCIONE_CI.TabIndex = 14
        Me.lbl_HISTORIAL_SELECCIONE_CI.Text = "Seleccione una CI para listar su historial"
        Me.lbl_HISTORIAL_SELECCIONE_CI.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(83, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(547, 60)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Consultor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(804, 620)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbc_CONSULTOR)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_CONSULTOR)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Consultor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profesor"
        CType(Me.dgv_CONSULTOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbc_CONSULTOR.ResumeLayout(False)
        Me.tbp_CONDULTOR_PLANILLA.ResumeLayout(False)
        Me.tbp_CONDULTOR_PLANILLA.PerformLayout()
        Me.PanelVersionNueva.ResumeLayout(False)
        Me.PanelVersionNueva.PerformLayout()
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.ResumeLayout(False)
        Me.tbp_PLANILLADOR_PROFESORESXMATERIA.PerformLayout()
        Me.tbp_HORARIOSSEGUNGRUPOS.ResumeLayout(False)
        Me.tbp_HORARIOSSEGUNGRUPOS.PerformLayout()
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.ResumeLayout(False)
        Me.tbp_CONSULTOR_DISPONIBILIDADSALONES.PerformLayout()
        Me.tbp_CONSULTOR_BD.ResumeLayout(False)
        Me.tbp_CONSULTOR_BD.PerformLayout()
        Me.tbp_HISTORIAL.ResumeLayout(False)
        Me.tbp_HISTORIAL.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_CONSULTOR As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbc_CONSULTOR As System.Windows.Forms.TabControl
    Friend WithEvents tbp_HORARIOSSEGUNGRUPOS As System.Windows.Forms.TabPage
    Friend WithEvents lbl_CONSULTOR_SELECCIONDEGRUPO As System.Windows.Forms.Label
    Friend WithEvents cmb_CONSULTOR_SELECCIONDEGRUPO As System.Windows.Forms.ComboBox
    Friend WithEvents tbp_PLANILLADOR_PROFESORESXMATERIA As System.Windows.Forms.TabPage
    Friend WithEvents tbp_CONDULTOR_PLANILLA As System.Windows.Forms.TabPage
    Friend WithEvents tbp_CONSULTOR_DISPONIBILIDADSALONES As System.Windows.Forms.TabPage
    Friend WithEvents tbp_CONSULTOR_BD As System.Windows.Forms.TabPage
    Friend WithEvents tbp_HISTORIAL As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_PROFESXMATERIAS As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_LISTAR As System.Windows.Forms.Label
    Friend WithEvents lbl_planillador_PROFESORESQUEDICTAN As System.Windows.Forms.Label
    Friend WithEvents cmb_PLANILLADOR_PROFESORESQUEDICTAN As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_PROFESORSELECCIONADO As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_CONSULTOR_CONSULTARSALON As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_CONSULTOR_CONSULTARSALON As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_CONSULTOR_BD As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_FILTRO_HISTORIAL As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_HISTORIAL_SELECCIONE_CI As System.Windows.Forms.Label
    Friend WithEvents cmb_historial_seleccionar_ci As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_HISTORIAL_NOMBRE As System.Windows.Forms.Label
    Friend WithEvents lbl_HISTORIAL_SELECCIONE_FECHA As System.Windows.Forms.Label
    Friend WithEvents cmb_SALON As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_sect_codigo As System.Windows.Forms.Label
    Friend WithEvents cmb_SELECCION_DE_SCCION As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_SELECCIONE_ACCION As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelVersionNueva As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmBxVersion_CONSULTOR As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_AÑO As System.Windows.Forms.ComboBox
    Friend WithEvents CMB_HISTORIAL_FECHA As System.Windows.Forms.ComboBox
End Class
