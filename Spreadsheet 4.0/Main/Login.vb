Imports System.Data.Odbc
Public Class Login
    Public tipopu As String

    Dim thisDay As DateTime = DateTime.Today


    Private Sub Login_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

        txt_CI.Clear()
        txt_Veri.Clear()
        txt_CONTRASEÑA.Clear()


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_INGRESAR.Click

        'bruno

        conexion.ConnectionString = stringconexion
        conexion.Open()

        ErrorProvider1.Clear()
        If Verificar(txt_CI.Text, txt_Veri.Text) = 1 Then
            'MsgBox("Cedula correcta")

            Try
                'No esta reciclado

                
                ' MsgBox("Conexion exitosa")
                Dim query As String = String.Empty


                query = "Select tipo FROM persona WHERE ci='" & txt_CI.Text & txt_Veri.Text & "' AND contrasena= '" & txt_CONTRASEÑA.Text & "'"


                Dim comando As OdbcCommand
                comando = New OdbcCommand(query, conexion)

                Dim tipo As String = comando.ExecuteScalar
                tipopu = tipo
               

                Dim tabla As OdbcDataReader
                tabla = comando.ExecuteReader
                Dim cantidad As Integer = 0
                While tabla.Read
                    cantidad += 1


                End While


                If cantidad = 1 Then

                    MessageBox.Show("Usuario y contraseña correctos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Bruno

                    query = "Select nombre from persona WHERE ci=" & txt_CI.Text & txt_Veri.Text

                    comando = New OdbcCommand(query, conexion)

                    Dim nombre As String = comando.ExecuteScalar
                    conectadonom = nombre
                    conexion.Close()
                    conexion.Open()


                    query = "Select apellido from persona WHERE ci=" & txt_CI.Text & txt_Veri.Text

                    comando = New OdbcCommand(query, conexion)

                    Dim apellido As String = comando.ExecuteScalar
                    conectadoape = apellido
                    

                    Principal.tsl_conectadonom.Text = conectadonom
                    Principal.tsl_conectadoape.Text = conectadoape

                    'Bruno
                    If tipo = "Administrador" Then
                        Modulos.user = txt_CI.Text & txt_Veri.Text
                        Principal.mst_PRINCIPAL.Visible = True
                        Principal.TS_secundario.Visible = True
                        Planillador.Visible = True
                        'Planillador.StartPosition.CenterScreen()
                        Planillador.MdiParent = Principal
                        Principal.StMeItmPlanillador.Enabled = True
                        Principal.StMeItmBAM.Enabled = True

                        Me.Hide()
                        MessageBox.Show("Bienvenido " & tipopu, "Creador de Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Try
                            '  Guardar en historial - LOGIN - ADMINISTRADOR
                            Dim descripcion As String
                            descripcion = "El usuario: "
                            Dim tab As String = "historial"
                            Dim atr As String = "ci,fecha,hora,descripcion,accion"
                            Dim inser As String = "('" & Modulos.user & "','" & BAM.mes & "-" & BAM.dia & "-" & BAM.año & "','" & BAM.hora & ":" & BAM.min & " ','" & descripcion & " " & conectadonom & " " & conectadoape & " logueo al sistema como administrador','Login')"
                            MsgBox(BAM.mes & "-" & BAM.dia & "-" & BAM.año)

                            inshistorial(tab, atr, inser)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try



                    ElseIf tipo = "Profesor" Then
                        Modulos.user = txt_CI.Text & txt_Veri.Text
                        Principal.mst_PRINCIPAL.Visible = True
                        Principal.TS_secundario.Visible = True
                        Consultor.Show()
                        Consultor.MdiParent = Principal
                        Principal.StMeItmPlanillador.Enabled = False
                        Principal.StMeItmBAM.Enabled = False

                        Me.Hide()
                        MessageBox.Show("Bienvenido " & tipopu, "Creador de Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Try
                            '  Guardar en historial - LOGIN - PROFESOR
                            Dim descripcion As String
                            descripcion = "El usuario: "
                            Dim tab As String = "historial"
                            Dim atr As String = "ci,fecha,hora,descripcion,accion"
                            Dim inser As String = "('" & Modulos.user & "','" & BAM.mes & "-" & BAM.dia & "-" & BAM.año & "','" & BAM.hora & ":" & BAM.min & " ','" & descripcion & " " & conectadonom & " " & conectadoape & " logueo al sistema como profesor','Login')"

                            inshistorial(tab, atr, inser)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try


                    ElseIf tipo = "Administrativo" Then
                        MsgBox(thisDay)
                        Modulos.user = txt_CI.Text & txt_Veri.Text
                        Principal.mst_PRINCIPAL.Visible = True
                        Principal.TS_secundario.Visible = True
                        Planillador.Show()
                        Planillador.MdiParent = Principal
                        Principal.StMeItmPlanillador.Enabled = True
                        Principal.StMeItmBAM.Enabled = True
                        BAM.tbp_ALTAS_CARRERA.Hide()
                        BAM.tbp_ALTAS_TURNOS.Hide()
                        BAM.tbp_ALTAS_MAT.Hide()

                        Me.Hide()
                        MessageBox.Show("Bienvenido " & tipopu, "Creador de planilla", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Try
                            '  Guardar en historial - LOGIN - ADMINISTRATIVO
                            Dim descripcion As String
                            descripcion = "El usuario: "
                            Dim tab As String = "historial"
                            Dim atr As String = "ci,fecha,hora,descripcion,accion"
                            Dim inser As String = "('" & Modulos.user & "','" & BAM.mes & "-" & BAM.dia & "-" & BAM.año & "','" & BAM.hora & ":" & BAM.min & " ','" & descripcion & " " & conectadonom & " " & conectadoape & " logueo al sistema como administrativo','Login')"
                            inshistorial(tab, atr, inser)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    ElseIf tipo = "Invitado" Then
                        Modulos.user = txt_CI.Text & txt_Veri.Text
                        Principal.mst_PRINCIPAL.Visible = True
                        Principal.TS_secundario.Visible = True
                        Consultor.Show()
                        Consultor.MdiParent = Principal
                        Principal.StMeItmPlanillador.Enabled = False
                        Principal.StMeItmBAM.Enabled = False

                        Me.Hide()
                        MessageBox.Show("Bienvenido " & tipopu, "Creador de Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Try
                            '  Guardar en historial - LOGIN - INVITADO
                            Dim descripcion As String
                            descripcion = "El usuario: "
                            Dim tab As String = "historial"
                            Dim atr As String = "ci,fecha,hora,descripcion,accion"
                            Dim inser As String = "('" & Modulos.user & "','" & BAM.mes & "-" & BAM.dia & "-" & BAM.año & "','" & BAM.hora & ":" & BAM.min & " ','" & descripcion & " " & conectadonom & " " & conectadoape & " logueo al sistema como invitado','Login')"
                            inshistorial(tab, atr, inser)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    End If


                ElseIf cantidad > 1 Then
                    MsgBox("Duplicado en la base de datos")
                    Principal.mst_PRINCIPAL.Visible = False
                    Principal.TS_secundario.Visible = False
                Else
                    'ErrorProvider1.SetError(txt_CONTRASEÑA, "Error de usuario y contraseña")
                    'MsgBox("Usuario y/o contrasña no validos")
                    'MessageBox.Show("Usted escribio mal usuario y/o contraseña o ingreso cedula que no esta en la base de datos, para registrar usuario invitado haga click en si, para volver a ingresar usuario click en no", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


                    Dim result As DialogResult

                    result = MessageBox.Show("Usted ingreso mal usuario y/o contraseña o ingreso cedula que no esta registrado en la base de datos, para registrar usuario invitado haga click en 'Si', para volver a ingresar usuario clicka en 'no'", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


                    If result = System.Windows.Forms.DialogResult.Yes Then
                        Modulos.user = txt_CI.Text & txt_Veri.Text
                        Registro.Visible = True
                        'Planillador.StartPosition.CenterScreen()
                        Registro.MdiParent = Principal
                        Principal.StMeItmPlanillador.Enabled = False
                        Principal.StMeItmBAM.Enabled = False
                        Principal.mst_PRINCIPAL.Visible = False
                        Principal.TS_secundario.Visible = True
                        Registro.txb_REGISTRO_CI.Text = txt_CI.Text
                        Registro.txb_REGISTRO_CI2.Text = txt_Veri.Text
                        Me.Hide()

                    Else

                        Principal.mst_PRINCIPAL.Visible = False
                        Principal.TS_secundario.Visible = False
                        txt_CI.Clear()
                        txt_CONTRASEÑA.Clear()
                        txt_Veri.Clear()


                    End If




                End If
                'MsgBox("Usted se ha logeado como " & tipopu)



            Catch ex As OdbcException
                MsgBox(ex.Message)

            End Try

        Else
            'MsgBox("La cedula no existe")
            ErrorProvider1.SetError(txt_Veri, "Cedula incorrecta")
        End If
        conexion.Close()

        'bruno

       
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_LOGO.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Principal.Close()


    End Sub

    Private Sub txt_CI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CI.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_Veri.Select()
        End If

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If



    End Sub

    Private Sub txt_Veri_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Veri.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_CONTRASEÑA.Select()
        End If

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If


    End Sub

    Private Sub txt_CONTRASEÑA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CONTRASEÑA.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            btn_INGRESAR.Select()
        End If

    End Sub

    Private Sub txt_Veri_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Veri.Leave
        If Verificar(txt_CI.Text, txt_Veri.Text) = 1 Then

            'MsgBox("Cedula correcta")


        Else
            MsgBox("La cedula es invalida")
            txt_Veri.Text = ""
            txt_Veri.Select()

            'ErrorProvider1.SetError(txt_Veri, "Cedula incorrecta"


        End If
    End Sub
End Class
