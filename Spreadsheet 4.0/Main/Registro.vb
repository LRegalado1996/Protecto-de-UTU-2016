Imports System.Data.Odbc



Public Class Registro


    Public hora As Integer = Now.Hour()
    Public min As Integer = Now.Minute()

    Private Sub txb_REGISTRO_NOMBRE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_REGISTRO_NOMBRE.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txb_REGISTRO_APELLIDO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_REGISTRO_APELLIDO.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txb_REGISTRO_CI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_REGISTRO_CI.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txb_REGISTRO_CI2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_REGISTRO_CI2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txb_REGISTRO_TELEFONO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_REGISTRO_TELEFONO.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txb_REGISTRO_CI2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txb_REGISTRO_CI2.Leave
        Try


            If Verificar(txb_REGISTRO_CI.Text, txb_REGISTRO_CI2.Text) = 1 Then

                'MsgBox("Cedula correcta")

                txb_REGISTRO_CONTRASEÑA.Text = txb_REGISTRO_CI.Text & txb_REGISTRO_CI2.Text

            Else
                MsgBox("La cedula es invalida")
                'ErrorProvider1.SetError(txt_Veri, "Cedula incorrecta"


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_REGISTRO_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_REGISTRO_GUARDAR.Click

        conexion.Open()


        Try
            If Me.ValidateChildren And txb_REGISTRO_CI.Text <> String.Empty And txb_REGISTRO_CI2.Text <> String.Empty And txb_REGISTRO_NOMBRE.Text <> String.Empty And txb_REGISTRO_APELLIDO.Text <> String.Empty And txb_REGISTRO_TELEFONO.Text <> String.Empty And txb_REGISTRO_CONTRASEÑA.Text <> String.Empty Then


                Dim query As String = String.Empty


                query = "Select ci FROM persona WHERE ci='" & txb_REGISTRO_CI.Text & txb_REGISTRO_CI2.Text & "' "


                Dim comando As OdbcCommand
                comando = New OdbcCommand(query, conexion)

                Dim cid As String
                Dim cid2 As String = comando.ExecuteScalar
                cid = cid2

                Dim tabla As OdbcDataReader
                tabla = comando.ExecuteReader
                Dim cantidad As Integer = 0
                While tabla.Read
                    cantidad += 1


                End While

                If cantidad = 1 Then

                    MessageBox.Show("Usuario ya registrado en Base de Datos", "Registrio de Invitado", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    txb_REGISTRO_APELLIDO.Clear()
                    txb_REGISTRO_CI.Clear()
                    txb_REGISTRO_CI2.Clear()
                    txb_REGISTRO_NOMBRE.Clear()
                    txb_REGISTRO_CONTRASEÑA.Clear()
                    txb_REGISTRO_TELEFONO.Clear()
                    txb_REGISTRO_DESCRIPCION.Clear()


                ElseIf cantidad > 1 Then
                    MsgBox("Duplicado en la base de datos")

                Else


                    Dim ta As String = "persona"
                    Dim at As String = "ci,contrasena,tipo,nombre,apellido,telefono,baja"
                    Dim ins As String = "(" & txb_REGISTRO_CI.Text & txb_REGISTRO_CI2.Text & ",'" & txb_REGISTRO_CONTRASEÑA.Text & "','Invitado','" & txb_REGISTRO_NOMBRE.Text & "','" & txb_REGISTRO_APELLIDO.Text & "'," & txb_REGISTRO_TELEFONO.Text & ",'no')"
                    altas(ta, at, ins)
                    MessageBox.Show("Alta realizada correctamente", "Altas de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    conexion.Open()

                    Try
                        '' Guardar en historial - ALTAS-MATERIA
                        Dim descripcion As String
                        descripcion = "Registro al invitado: "
                        Dim tab As String = "historial"
                        Dim atr As String = "ci,fecha,hora,descripcion,accion"
                        Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & txb_REGISTRO_CI.Text & txb_REGISTRO_CI2.Text & " como " & txb_REGISTRO_DESCRIPCION.Text & "','Altas')"
                        inshistorial(tab, atr, inser)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


                    conexion.Open()

                    query = "Select nombre from persona WHERE ci=" & txb_REGISTRO_CI.Text & txb_REGISTRO_CI2.Text

                    comando = New OdbcCommand(query, conexion)

                    Dim nombre As String = comando.ExecuteScalar
                    conectadonom = nombre



                    query = "Select apellido from persona WHERE ci=" & txb_REGISTRO_CI.Text & txb_REGISTRO_CI2.Text

                    comando = New OdbcCommand(query, conexion)

                    Dim apellido As String = comando.ExecuteScalar
                    conectadoape = apellido




                    Principal.tsl_conectadonom.Text = conectadonom
                    Principal.tsl_conectadoape.Text = conectadoape

                    txb_REGISTRO_APELLIDO.Clear()
                    txb_REGISTRO_CI.Clear()
                    txb_REGISTRO_CI2.Clear()
                    txb_REGISTRO_NOMBRE.Clear()
                    txb_REGISTRO_CONTRASEÑA.Clear()
                    txb_REGISTRO_TELEFONO.Clear()
                    txb_REGISTRO_DESCRIPCION.Clear()
                    Consultor.Show()
                    Consultor.MdiParent = Principal
                    Principal.StMeItmPlanillador.Enabled = False
                    Principal.StMeItmBAM.Enabled = False
                    Principal.mst_PRINCIPAL.Visible = True
                    Principal.TS_secundario.Visible = True
                    Me.Hide()
                    MessageBox.Show("Bienvenido Invitado", "Consultor", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    'ErrorProvider1.SetError(txt_Veri, "Cedula incorrecta")
                End If

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Registro de Invitado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As OdbcException
            MsgBox(ex.Message)

        End Try
        conexion.Close()

    End Sub
End Class