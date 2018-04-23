<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Version
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Version))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmBxVersion = New System.Windows.Forms.ComboBox
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxBxAño = New System.Windows.Forms.TextBox
        Me.CMSp_opciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Modificar = New System.Windows.Forms.ToolStripMenuItem
        Me.Borrar = New System.Windows.Forms.ToolStripMenuItem
        Me.Desagrupar = New System.Windows.Forms.ToolStripMenuItem
        Me.Btn_Agregar = New System.Windows.Forms.Button
        Me.PanelVersionNueva = New System.Windows.Forms.Panel
        Me.ChkdLtBxCodigos = New System.Windows.Forms.CheckedListBox
        Me.ChkLBxFilas = New System.Windows.Forms.CheckedListBox
        Me.DGVPlanilla = New System.Windows.Forms.DataGridView
        Me.CMSp_opciones.SuspendLayout()
        Me.PanelVersionNueva.SuspendLayout()
        CType(Me.DGVPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 74)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Versionado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Version"
        '
        'CmBxVersion
        '
        Me.CmBxVersion.FormattingEnabled = True
        Me.CmBxVersion.Location = New System.Drawing.Point(339, 17)
        Me.CmBxVersion.Name = "CmBxVersion"
        Me.CmBxVersion.Size = New System.Drawing.Size(176, 28)
        Me.CmBxVersion.TabIndex = 2
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(588, 11)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(98, 38)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Año"
        '
        'TxBxAño
        '
        Me.TxBxAño.Location = New System.Drawing.Point(76, 17)
        Me.TxBxAño.Name = "TxBxAño"
        Me.TxBxAño.Size = New System.Drawing.Size(100, 26)
        Me.TxBxAño.TabIndex = 1
        '
        'CMSp_opciones
        '
        Me.CMSp_opciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Modificar, Me.Borrar, Me.Desagrupar})
        Me.CMSp_opciones.Name = "CMSp_opciones"
        Me.CMSp_opciones.Size = New System.Drawing.Size(153, 92)
        '
        'Modificar
        '
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(152, 22)
        Me.Modificar.Text = "Modificar"
        '
        'Borrar
        '
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(152, 22)
        Me.Borrar.Text = "Borrar"
        '
        'Desagrupar
        '
        Me.Desagrupar.Name = "Desagrupar"
        Me.Desagrupar.Size = New System.Drawing.Size(152, 22)
        Me.Desagrupar.Text = "Desagrupar"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(656, 349)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(98, 38)
        Me.Btn_Agregar.TabIndex = 7
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'PanelVersionNueva
        '
        Me.PanelVersionNueva.BackColor = System.Drawing.Color.Transparent
        Me.PanelVersionNueva.Controls.Add(Me.TxBxAño)
        Me.PanelVersionNueva.Controls.Add(Me.Label3)
        Me.PanelVersionNueva.Controls.Add(Me.BtnBuscar)
        Me.PanelVersionNueva.Controls.Add(Me.CmBxVersion)
        Me.PanelVersionNueva.Controls.Add(Me.Label2)
        Me.PanelVersionNueva.Location = New System.Drawing.Point(68, 108)
        Me.PanelVersionNueva.Name = "PanelVersionNueva"
        Me.PanelVersionNueva.Size = New System.Drawing.Size(708, 60)
        Me.PanelVersionNueva.TabIndex = 8
        '
        'ChkdLtBxCodigos
        '
        Me.ChkdLtBxCodigos.FormattingEnabled = True
        Me.ChkdLtBxCodigos.Location = New System.Drawing.Point(12, 780)
        Me.ChkdLtBxCodigos.Name = "ChkdLtBxCodigos"
        Me.ChkdLtBxCodigos.Size = New System.Drawing.Size(780, 172)
        Me.ChkdLtBxCodigos.TabIndex = 9
        Me.ChkdLtBxCodigos.Visible = False
        '
        'ChkLBxFilas
        '
        Me.ChkLBxFilas.FormattingEnabled = True
        Me.ChkLBxFilas.Location = New System.Drawing.Point(13, 192)
        Me.ChkLBxFilas.Name = "ChkLBxFilas"
        Me.ChkLBxFilas.Size = New System.Drawing.Size(780, 151)
        Me.ChkLBxFilas.TabIndex = 10
        '
        'DGVPlanilla
        '
        Me.DGVPlanilla.AllowUserToAddRows = False
        Me.DGVPlanilla.AllowUserToDeleteRows = False
        Me.DGVPlanilla.AllowUserToResizeColumns = False
        Me.DGVPlanilla.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPlanilla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVPlanilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVPlanilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPlanilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPlanilla.ContextMenuStrip = Me.CMSp_opciones
        Me.DGVPlanilla.Location = New System.Drawing.Point(13, 409)
        Me.DGVPlanilla.Name = "DGVPlanilla"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPlanilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVPlanilla.RowHeadersVisible = False
        Me.DGVPlanilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPlanilla.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVPlanilla.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGVPlanilla.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPlanilla.Size = New System.Drawing.Size(780, 198)
        Me.DGVPlanilla.StandardTab = True
        Me.DGVPlanilla.TabIndex = 6
        '
        'Version
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(804, 620)
        Me.Controls.Add(Me.ChkdLtBxCodigos)
        Me.Controls.Add(Me.ChkLBxFilas)
        Me.Controls.Add(Me.PanelVersionNueva)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.DGVPlanilla)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Version"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Version"
        Me.CMSp_opciones.ResumeLayout(False)
        Me.PanelVersionNueva.ResumeLayout(False)
        Me.PanelVersionNueva.PerformLayout()
        CType(Me.DGVPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmBxVersion As System.Windows.Forms.ComboBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxBxAño As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents PanelVersionNueva As System.Windows.Forms.Panel
    Friend WithEvents ChkdLtBxCodigos As System.Windows.Forms.CheckedListBox
    Friend WithEvents ChkLBxFilas As System.Windows.Forms.CheckedListBox
    Friend WithEvents CMSp_opciones As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Modificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Borrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Desagrupar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DGVPlanilla As System.Windows.Forms.DataGridView
End Class
