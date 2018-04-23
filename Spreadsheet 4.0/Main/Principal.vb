Imports System.Windows.Forms

Public Class Principal

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub PlanilladorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StMeItmPlanillador.Click
        Login.Close()
        Planillador.MdiParent = Me
        Planillador.Show()
        BAM.Close()
        Version.Close()
        Consultor.Close()
        Version.Close()

    End Sub

    Private Sub BAMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StMeItmBAM.Click
        Version.Close()
        BAM.MdiParent = Me
        Login.Close()
        Version.Close()
        BAM.Show()
        Consultor.Close()
        Planillador.Close()

        'MsgBox(Login.tipopu)
    End Sub

    Private Sub ConsultorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StMeItmconsultor.Click
        Version.Close()
        Consultor.MdiParent = Me
        Login.Close()
        Version.Close()
        Consultor.Show()
        BAM.Close()
        Planillador.Close()
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login.MdiParent = Me
        Login.Show()
        Consultor.Close()
        BAM.Close()
        Planillador.Close()
    End Sub


    
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        BAM.Close()
        Consultor.Close()
        Planillador.Close()
        mst_PRINCIPAL.Visible = False
        TS_secundario.Visible = False
        Registro.Close()
        Version.Close()




        Login.MdiParent = Me
        Login.Show()
        tsl_conectadoape.Text = ""
        tsl_conectadonom.Text = ""
        conectadoape = Nothing
        conectadonom = Nothing



        conexion.Close()

    End Sub

    
    Private Sub TS_secundario_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles TS_secundario.ItemClicked

    End Sub
End Class
