<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.mst_PRINCIPAL = New System.Windows.Forms.MenuStrip
        Me.StMeItmPlanillador = New System.Windows.Forms.ToolStripMenuItem
        Me.StMeItmBAM = New System.Windows.Forms.ToolStripMenuItem
        Me.StMeItmconsultor = New System.Windows.Forms.ToolStripMenuItem
        Me.TS_secundario = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.tsl_conectadoape = New System.Windows.Forms.ToolStripLabel
        Me.tsl_conectadonom = New System.Windows.Forms.ToolStripLabel
        Me.tsl_usuario = New System.Windows.Forms.ToolStripLabel
        Me.mst_PRINCIPAL.SuspendLayout()
        Me.TS_secundario.SuspendLayout()
        Me.SuspendLayout()
        '
        'mst_PRINCIPAL
        '
        Me.mst_PRINCIPAL.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.mst_PRINCIPAL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mst_PRINCIPAL.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mst_PRINCIPAL.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StMeItmPlanillador, Me.StMeItmBAM, Me.StMeItmconsultor})
        Me.mst_PRINCIPAL.Location = New System.Drawing.Point(0, 0)
        Me.mst_PRINCIPAL.Name = "mst_PRINCIPAL"
        Me.mst_PRINCIPAL.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mst_PRINCIPAL.Size = New System.Drawing.Size(632, 29)
        Me.mst_PRINCIPAL.TabIndex = 5
        Me.mst_PRINCIPAL.Text = "MenuStrip"
        Me.mst_PRINCIPAL.Visible = False
        '
        'StMeItmPlanillador
        '
        Me.StMeItmPlanillador.ForeColor = System.Drawing.Color.White
        Me.StMeItmPlanillador.Name = "StMeItmPlanillador"
        Me.StMeItmPlanillador.Size = New System.Drawing.Size(96, 25)
        Me.StMeItmPlanillador.Text = "Planillador"
        Me.StMeItmPlanillador.ToolTipText = "Acceder al planillador"
        '
        'StMeItmBAM
        '
        Me.StMeItmBAM.ForeColor = System.Drawing.Color.White
        Me.StMeItmBAM.Name = "StMeItmBAM"
        Me.StMeItmBAM.Size = New System.Drawing.Size(55, 25)
        Me.StMeItmBAM.Text = "BAM"
        '
        'StMeItmconsultor
        '
        Me.StMeItmconsultor.ForeColor = System.Drawing.Color.White
        Me.StMeItmconsultor.Name = "StMeItmconsultor"
        Me.StMeItmconsultor.Size = New System.Drawing.Size(90, 25)
        Me.StMeItmconsultor.Text = "Consultor"
        '
        'TS_secundario
        '
        Me.TS_secundario.AutoSize = False
        Me.TS_secundario.BackColor = System.Drawing.Color.Coral
        Me.TS_secundario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TS_secundario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.tsl_conectadoape, Me.tsl_conectadonom, Me.tsl_usuario})
        Me.TS_secundario.Location = New System.Drawing.Point(0, 425)
        Me.TS_secundario.Name = "TS_secundario"
        Me.TS_secundario.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.TS_secundario.Size = New System.Drawing.Size(635, 30)
        Me.TS_secundario.TabIndex = 11
        Me.TS_secundario.Text = "ToolStrip"
        Me.TS_secundario.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsl_conectadoape
        '
        Me.tsl_conectadoape.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsl_conectadoape.Name = "tsl_conectadoape"
        Me.tsl_conectadoape.Size = New System.Drawing.Size(51, 27)
        Me.tsl_conectadoape.Text = "Apellido"
        '
        'tsl_conectadonom
        '
        Me.tsl_conectadonom.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsl_conectadonom.Name = "tsl_conectadonom"
        Me.tsl_conectadonom.Size = New System.Drawing.Size(51, 27)
        Me.tsl_conectadonom.Text = "Nombre"
        '
        'tsl_usuario
        '
        Me.tsl_usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsl_usuario.Name = "tsl_usuario"
        Me.tsl_usuario.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.tsl_usuario.Size = New System.Drawing.Size(70, 27)
        Me.tsl_usuario.Text = "Usuario:"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(635, 455)
        Me.Controls.Add(Me.TS_secundario)
        Me.Controls.Add(Me.mst_PRINCIPAL)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mst_PRINCIPAL
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spreadsheet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mst_PRINCIPAL.ResumeLayout(False)
        Me.mst_PRINCIPAL.PerformLayout()
        Me.TS_secundario.ResumeLayout(False)
        Me.TS_secundario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mst_PRINCIPAL As System.Windows.Forms.MenuStrip
    Friend WithEvents StMeItmPlanillador As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StMeItmBAM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StMeItmconsultor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TS_secundario As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsl_usuario As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsl_conectadonom As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsl_conectadoape As System.Windows.Forms.ToolStripLabel

End Class
