Imports System.Data.Odbc
Public Class BAM

    Dim datr As Odbc.OdbcDataReader
    Dim llenar As New Odbc.OdbcCommand
    Dim nom As Integer
    Dim cm As New OdbcCommand
    Dim codigo As New Integer
    Dim oro As New Integer
    Public hora As Integer = Now.Hour()
    Public min As Integer = Now.Minute()
    Public dia As Integer = Now.Day()
    Public mes As Integer = Now.Month()
    Public año As Integer = Now.Year()
    Dim thisDay As DateTime = DateTime.Today



    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_ADMINISTRADOR_ALTAS.Click
        tbc_ALTAS.Visible = True
        tbc_BAJA.Visible = False
        tbc_MODIFICACIONES.Visible = False
        cmb_ALTAS_GRUPO_CARRERA.Items.Clear()
        cmb_ALTAS_HORA_TURNO.Items.Clear()
        clb_ALTAS_USU_MATERIA.Items.Clear()
        pbx_ADMINISTRADOR_ALTAS.BackColor = Color.Black
        pbx_ADMINISTRADOR_MODIFI.BackColor = Color.Transparent
        pbx_ADMINISTRADOR_BAJAS.BackColor = Color.Transparent
        dtp_ALTAS_HORARIO_FIN.Text = "00:00"
        dtp_ALTAS_HORARIO_INICIO.Text = "00:00"
        ep_VACIOS.Clear()
        ep_VACIOS2.Clear()
        ep_VACIOS3.Clear()

        


        conexion = New OdbcConnection(stringconexion)
        cm.Connection = conexion
        conexion.ConnectionString = stringconexion
        conexion.Open()


        llenar.Connection = conexion
        llenar.CommandText = "Select * from carrera"
        datr = llenar.ExecuteReader

        While datr.Read
            cmb_ALTAS_GRUPO_CARRERA.Items.Add(datr.GetValue(1).ToString)

        End While
        datr.Close()

        llenar.CommandText = "Select * from turno"
        datr = llenar.ExecuteReader
        While datr.Read
            cmb_ALTAS_HORA_TURNO.Items.Add(datr.GetValue(1).ToString)
        End While
        datr.Close()



        llenar.CommandText = "Select nombre from materia order by cod_materia"
        datr = llenar.ExecuteReader

        While datr.Read
            clb_ALTAS_USU_MATERIA.Items.Add(datr.GetValue(0).ToString)
        End While
        datr.Close()




        conexion.Close()




    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_ADMINISTRADOR_MODIFI.Click
        pbx_ADMINISTRADOR_ALTAS.BackColor = Color.Transparent
        pbx_ADMINISTRADOR_MODIFI.BackColor = Color.Black
        pbx_ADMINISTRADOR_BAJAS.BackColor = Color.Transparent

        cmb_MODIFICAR_GRUPO_CODIGO.Items.Clear()
        cmb_MODIFICAR_MAT_CODIGO.Items.Clear()
        cmb_MODIFICAR_SALON_CODIGO.Items.Clear()
        clb_MODIFICAR_USU_MATERIA.Items.Clear()
        cmb_MODIFICACIONES_TURNOS_CODIGO.Items.Clear()
        cmb_MODIFICACIONES_CARRERA_CODIGO.Items.Clear()
        cmb_MODIFICAR_HORA_TURNO.Items.Clear()


        tbc_ALTAS.Visible = False
        tbc_BAJA.Visible = False
        tbc_MODIFICACIONES.Visible = True
        'tbc_LISTAR.Visible = False
        clb_MODIFICAR_USU_MATERIA.Items.Clear()
        cmb_MODIFICAR_GRUPO_CODIGO.Items.Clear()




        conexion = New OdbcConnection(stringconexion)
        cm.Connection = conexion
        conexion.ConnectionString = stringconexion
        conexion.Open()

        llenar.Connection = conexion

        llenar.CommandText = "Select nombre from materia"
        datr = llenar.ExecuteReader

        While datr.Read
            clb_MODIFICAR_USU_MATERIA.Items.Add(datr.GetValue(0).ToString)
            cmb_MODIFICAR_MAT_CODIGO.Items.Add(datr.GetValue(0).ToString)
        End While
        datr.Close()


        llenar.Connection = conexion
        llenar.CommandText = "Select * from grupo"
        datr = llenar.ExecuteReader

        While datr.Read
            cmb_MODIFICAR_GRUPO_CODIGO.Items.Add(datr.GetValue(1).ToString)
        End While

        'datr.Read()


        'llenar.Connection = conexion
        'llenar.CommandText = "Select * from grupo"
        'datr = llenar.ExecuteReader

        'While datr.Read
        '    cmb_MODIFICAR_GRUPO_CODIGO.Items.Add(datr.GetValue(1).ToString)
        'End While

        'datr.Read()
        datr.Close()


        llenar.Connection = conexion
        llenar.CommandText = "Select * from Salon"
        datr = llenar.ExecuteReader

        While datr.Read
            cmb_MODIFICAR_SALON_CODIGO.Items.Add((datr.GetValue(1).ToString) & " " & (datr.GetValue(2).ToString))
        End While
        datr.Close()

        llenar.Connection = conexion
        llenar.CommandText = "Select * from turno"
        datr = llenar.ExecuteReader

        While datr.Read
            cmb_MODIFICACIONES_TURNOS_CODIGO.Items.Add(datr.GetValue(1).ToString)
            cmb_MODIFICAR_HORA_TURNO.Items.Add(datr.GetValue(1).ToString)
        End While
        datr.Close()

        llenar.Connection = conexion
        llenar.CommandText = "Select * from carrera"
        datr = llenar.ExecuteReader

        While datr.Read
            cmb_MODIFICACIONES_CARRERA_CODIGO.Items.Add(datr.GetValue(1).ToString)
        End While
        datr.Close()

        'datr.Read()
        conexion.Close()


    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_ADMINISTRADOR_BAJAS.Click

        pbx_ADMINISTRADOR_ALTAS.BackColor = Color.Transparent
        pbx_ADMINISTRADOR_MODIFI.BackColor = Color.Transparent
        pbx_ADMINISTRADOR_BAJAS.BackColor = Color.Black
        tbc_ALTAS.Visible = False
        tbc_BAJA.Visible = True
        tbc_MODIFICACIONES.Visible = False
        'tbc_LISTAR.Visible = False
        pnl_BAJAS_USU_DESACTIVAR.Visible = False
        pnl_BAJAS_USU_BORRAR.Visible = False



        'conexion = New OdbcConnection(stringconexion)
        'cm.Connection = conexion
        'conexion.ConnectionString = stringconexion

        'conexion.Open()


        'llenar.Connection = conexion
        'llenar.CommandText = "Select * from turno"
        'datr = llenar.ExecuteReader

        'While datr.Read
        '    cmb_BAJAS_HORA_DESACTIVAR_TURNO.Items.Add((datr.GetValue(0).ToString) & "-" & (datr.GetValue(1).ToString))
        'End While
        'datr.Close()

        'llenar.CommandText = "Select * from turno"
        'datr = llenar.ExecuteReader

        'While datr.Read
        '    cmb_BAJAS_HORA_BORRAR_TURNO.Items.Add((datr.GetValue(0).ToString) & "-" & (datr.GetValue(1).ToString))
        'End While
        'datr.Close()






    End Sub

    Private Sub PictureBox_Listar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbc_ALTAS.Visible = False
        tbc_BAJA.Visible = False
        tbc_MODIFICACIONES.Visible = False
        'tbc_LISTAR.Visible = True
    End Sub

    Private Sub Button78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Planillador.Show()
        Me.Close()
    End Sub

    Private Sub BAM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ' Format(Now.Hour, "HH")
        'Format(Now.Minute, "mm")



        'conexion = New OdbcConnection(stringconexion)
        'cm.Connection = conexion
        'conexion.ConnectionString = stringconexion

        'MsgBox(Planillador.tipo)


        If (Planillador.tipo = "Administrativo") Then

            'tbp_ALTAS_MAT.
            'txb_ALTAS_MAT_NOMBRE.Enabled = False
            'nud_ALTAS_MAT_CARGA.Enabled = False
            'cmb_ALTAS_MAT_PREFERENCIA.Enabled = False
            'cmb_ALTAS_MAT_PRIORIDAD.Enabled = False
            'btn_ALTAS_MAT_CANCELAR.Enabled = False
            'btn_ALTAS_MAT_GUARDAR.Enabled = False
            'cmb_ALTAS_HORA_DIA.Enabled = False
            'cmb_ALTAS_HORA_TURNO.Enabled = False
            'cmb_ALTAS_HORARIO_NUMEROHORA.Enabled = False
            'dtp_ALTAS_HORARIO_INICIO.Enabled = False
            'dtp_ALTAS_HORARIO_FIN.Enabled = False
            'btn_ALTAS_HORA_CANCELAR.Enabled = False
            'btn_ALTAS_HORA_GUARDAR.Enabled = False
            'txb_ALTAS_TURNOS_NOMBRE.Enabled = False
            'btn_ALTAS_TURNO_GUARDAR.Enabled = False
            'btn_ALTAS_TURNOS_CANCELAR.Enabled = False
            tbp_ALTAS_MAT.Parent = Nothing
            tbp_ALTAS_HORA.Parent = Nothing
            tbp_ALTAS_TURNOS.Parent = Nothing



            ' tbp_ALTAS_MAT.Visible = False
            'tbp_ALTAS_HORA.Visible = False
            'tbp_ALTAS_TURNOS.Visible = False

        End If

        pnl_BAJAS_GRUPO_BORRAR.Visible = False
        pnl_BAJAS_GRUPO_DESACTIVAR.Visible = False
        pnl_BAJAS_HORA_BORRAR.Visible = False
        pnl_BAJAS_HORA_DESACTIVAR.Visible = False
        pnl_BAJAS_MAT_BORRAR.Visible = False
        pnl_BAJAS_MAT_DESACTIVAR.Visible = False
        pnl_BAJAS_SALON_BORRAR.Visible = False
        pnl_BAJAS_SALON_DESACTIVAR.Visible = False
        pnl_BAJAS_TURNOS_BORRAR.Visible = False
        pnl_BAJAS_TURNOS_DESACTIVAR.Visible = False
        pnl_BAJAS_USU_BORRAR.Visible = False
        pnl_BAJAS_USU_DESACTIVAR.Visible = False
        pnl_BAJAS_CARRERA_BORRAR.Visible = False
        pnl_BAJAS_CARRERA_DESACTIVAR.Visible = False
        tbc_ALTAS.Visible = False
        tbc_BAJA.Visible = False
        tbc_MODIFICACIONES.Visible = False




    End Sub

    Private Sub btn_ALTAS_TURNO_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_TURNO_GUARDAR.Click

        Try

            conexion.Open()
            If Me.ValidateChildren And txb_ALTAS_TURNOS_NOMBRE.Text <> String.Empty Then

                Dim query As String = String.Empty

                query = "Select nombre FROM turno WHERE nombre='" & txb_ALTAS_TURNOS_NOMBRE.Text & "'"

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

                    MsgBox("Ya existe")
                    txb_ALTAS_TURNOS_NOMBRE.Clear()

                ElseIf cantidad > 1 Then
                    MsgBox("Duplicado en la base de datos")

                Else

                    Dim ta As String = "Turno"
                    Dim at As String = "nombre,baja"
                    Dim ins As String = "('" & txb_ALTAS_TURNOS_NOMBRE.Text & "','no')"

                    altas(ta, at, ins)
                    MessageBox.Show("Alta realizada correctamente", "Altas de turno", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Altas de turno", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conexion.Close()

        Catch ex As OdbcException
            MsgBox(ex.Message)

        End Try

        Try
            '' Guardar en historial - ALTAS-TURNO
            Dim descripcion As String
            descripcion = "Ingreso de turno:"
            Dim tab As String = "historial"
            Dim atr As String = "ci,fecha,hora,descripcion,accion"
            Dim inser As String = "('" & Modulos.user & "','" & dia & "-" & mes & "-" & año & "','" & hora & ":" & min & " ','" & descripcion & " " & txb_ALTAS_TURNOS_NOMBRE.Text & "','Altas')"
            inshistorial(tab, atr, inser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txb_ALTAS_TURNOS_NOMBRE.Clear()

    End Sub

    Private Sub btn_BAJAS_USU_DESACTIVAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_USU_DESACTIVAR.Click

        pnl_BAJAS_USU_DESACTIVAR.Visible = True
        pnl_BAJAS_USU_BORRAR.Visible = False
        pnl_BAJAS_GRUPO_BORRAR.Visible = False
        pnl_BAJAS_GRUPO_DESACTIVAR.Visible = False
        pnl_BAJAS_HORA_BORRAR.Visible = False
        pnl_BAJAS_HORA_DESACTIVAR.Visible = False
        pnl_BAJAS_MAT_BORRAR.Visible = False
        pnl_BAJAS_MAT_DESACTIVAR.Visible = False
        pnl_BAJAS_SALON_BORRAR.Visible = False
        pnl_BAJAS_SALON_DESACTIVAR.Visible = False
        pnl_BAJAS_TURNOS_BORRAR.Visible = False
        pnl_BAJAS_TURNOS_DESACTIVAR.Visible = False
        cmb_BAJAS_USU_DES_CI.Items.Clear()
        cmb_BAJAS_USU_DES_CI.Text = ""



        conexion = New OdbcConnection(stringconexion)
        cm.Connection = conexion
        conexion.ConnectionString = stringconexion

        conexion.Open()


        llenar.Connection = conexion
        llenar.CommandText = "Select * from persona where baja='no'"
        datr = llenar.ExecuteReader

        While datr.Read
            cmb_BAJAS_USU_DES_CI.Items.Add((datr.GetValue(0).ToString) & " " & (datr.GetValue(3).ToString) & " " & (datr.GetValue(4).ToString))
        End While
        datr.Close()

        conexion.Close()



    End Sub

    Private Sub btn_BAJAS_USU_BORRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_USU_BORRAR.Click
        Try
            pnl_BAJAS_USU_DESACTIVAR.Visible = False
            pnl_BAJAS_USU_BORRAR.Visible = True
            cmb_BAJAS_USU_BORRAR.Items.Clear()
            cmb_BAJAS_USU_BORRAR.Text = ""




            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from persona"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_USU_BORRAR.Items.Add((datr.GetValue(0).ToString) & " " & (datr.GetValue(3).ToString) & " " & (datr.GetValue(4).ToString))
            End While
            datr.Close()

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub



    Private Sub tbp_BAJAS_USU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_BAJAS_USU.Click


    End Sub

    Private Sub tbp_BAJAS_MAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_BAJAS_MAT.Click



    End Sub

    Private Sub btn_BAJAS_MAT_DESACTIVAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_MAT_DESACTIVAR.Click
        Try
            pnl_BAJAS_MAT_DESACTIVAR.Visible = True
            pnl_BAJAS_MAT_BORRAR.Visible = False
            cmb_BAJAS_MAT_DESACTIVAR.Items.Clear()
            cmb_BAJAS_MAT_DESACTIVAR.Text = ""

            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from Materia where baja='no'"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_MAT_DESACTIVAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btn_BAJAS_MAT_BORRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_MAT_BORRAR.Click


        pnl_BAJAS_MAT_DESACTIVAR.Visible = False
        pnl_BAJAS_MAT_BORRAR.Visible = True
        cmb_BAJAS_MAT_BORRAR.Items.Clear()
        cmb_BAJAS_MAT_BORRAR.Text = ""
        Try
            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from Materia"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_MAT_BORRAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btn_BAM_ATRAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Planillador.Show()
        Planillador.MdiParent = Principal
        Principal.StMeItmPlanillador.Enabled = True
        Principal.StMeItmBAM.Enabled = True
        Me.Close()
    End Sub

    Private Sub tbp_BAJAS_HORA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_BAJAS_HORA.Click

    End Sub

    Private Sub btn_BAJAS_HORA_DESACTIVAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_HORA_DESACTIVAR.Click
        cmb_BAJAS_HORA_DESACTIVAR.Text = ""
        cmb_BAJAS_HORA_DESACTIVAR_DIA.Text = ""
        cmb_BAJAS_HORA_DESACTIVAR_TURNO.Text = ""

        cmb_BAJAS_HORA_DESACTIVAR.Enabled = False
        cmb_BAJAS_HORA_DESACTIVAR_DIA.Enabled = False
        pnl_BAJAS_HORA_DESACTIVAR.Visible = True
        pnl_BAJAS_HORA_BORRAR.Visible = False

        cmb_BAJAS_HORA_DESACTIVAR_TURNO.Items.Clear()

        Try
            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from turno"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_HORA_DESACTIVAR_TURNO.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btn_BAJAS_HORA_BORRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_HORA_BORRAR.Click

        cmb_BAJAS_HORA_BORRAR.Text = ""
        cmb_BAJAS_HORA_BORRAR_DIA.Text = ""
        cmb_BAJAS_HORA_BORRAR_TURNO.Text = ""

        cmb_BAJAS_HORA_BORRAR.Enabled = False
        cmb_BAJAS_HORA_BORRAR_DIA.Enabled = False
        pnl_BAJAS_HORA_DESACTIVAR.Visible = False
        pnl_BAJAS_HORA_BORRAR.Visible = True

        cmb_BAJAS_HORA_BORRAR_TURNO.Items.Clear()
        Try
            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from turno"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_HORA_BORRAR_TURNO.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()
            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub tbp_BAJAS_GRUPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_BAJAS_GRUPO.Click

    End Sub

    Private Sub btn_BAJAS_GRUPO_DESACTIVAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_GRUPO_DESACTIVAR.Click
        Try

            pnl_BAJAS_GRUPO_DESACTIVAR.Visible = True
            pnl_BAJAS_GRUPO_BORRAR.Visible = False

            cmb_BAJAS_GRUPO_DESACTIVAR.Items.Clear()

            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from Grupo where baja='no'"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_GRUPO_DESACTIVAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub btn_BAJAS_GRUPO_BORRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_GRUPO_BORRAR.Click
        pnl_BAJAS_GRUPO_DESACTIVAR.Visible = False
        pnl_BAJAS_GRUPO_BORRAR.Visible = True

        cmb_BAJAS_GRUPO_BORRAR.Items.Clear()

        Try

            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from Grupo"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_GRUPO_BORRAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub tbp_BAJAS_SALON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_BAJAS_SALON.Click

    End Sub

    Private Sub btn_BAJAS_SALON_DESACTIVAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_SALON_DESACTIVAR.Click

        Try

            pnl_BAJAS_SALON_DESACTIVAR.Visible = True
            pnl_BAJAS_SALON_BORRAR.Visible = False

            cmb_BAJAS_SALON_DESACTIVAR.Items.Clear()

            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from salon where baja='no'"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_SALON_DESACTIVAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btn_BAJAS_SALON_BORRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_SALON_BORRAR.Click


        Try

            pnl_BAJAS_SALON_DESACTIVAR.Visible = False
            pnl_BAJAS_SALON_BORRAR.Visible = True

            cmb_BAJAS_SALON_BORRAR.Items.Clear()

            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from salon"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_SALON_BORRAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub btn_BAJAS_TURNOS_DESACTIVAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_TURNOS_DESACTIVAR.Click

        Try

            pnl_BAJAS_TURNOS_DESACTIVAR.Visible = True
            pnl_BAJAS_TURNOS_BORRAR.Visible = False

            cmb_BAJAS_TURNOS_DESACTIVAR.Items.Clear()

            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from turno where baja='no'"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_TURNOS_DESACTIVAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub btn_BAJAS_TURNOS_BORRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_TURNOS_BORRAR.Click

        Try

            pnl_BAJAS_TURNOS_DESACTIVAR.Visible = False
            pnl_BAJAS_TURNOS_BORRAR.Visible = True

            cmb_BAJAS_TURNOS_BORRAR.Items.Clear()

            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from turno"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_TURNOS_BORRAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tbp_BAJAS_TURNOS_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp_BAJAS_TURNOS.Leave
        pnl_BAJAS_TURNOS_BORRAR.Visible = False
        pnl_BAJAS_TURNOS_DESACTIVAR.Visible = False
    End Sub

    Private Sub tbp_BAJAS_USU_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp_BAJAS_USU.Leave
        pnl_BAJAS_USU_BORRAR.Visible = False
        pnl_BAJAS_USU_DESACTIVAR.Visible = False

    End Sub

    Private Sub tbp_BAJAS_MAT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp_BAJAS_MAT.Leave
        pnl_BAJAS_MAT_BORRAR.Visible = False
        pnl_BAJAS_MAT_DESACTIVAR.Visible = False

    End Sub

    Private Sub tbp_BAJAS_HORA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp_BAJAS_HORA.Leave
        pnl_BAJAS_HORA_BORRAR.Visible = False
        pnl_BAJAS_HORA_DESACTIVAR.Visible = False
    End Sub

    Private Sub tbp_BAJAS_GRUPO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp_BAJAS_GRUPO.Leave
        pnl_BAJAS_GRUPO_BORRAR.Visible = False
        pnl_BAJAS_GRUPO_DESACTIVAR.Visible = False
    End Sub

    Private Sub tbp_BAJAS_SALON_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp_BAJAS_SALON.Leave
        pnl_BAJAS_SALON_BORRAR.Visible = False
        pnl_BAJAS_SALON_DESACTIVAR.Visible = False
    End Sub

    Private Sub tbp_BAJAS_TURNOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_BAJAS_TURNOS.Click

    End Sub

    Private Sub btn_ALTAS_USU_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_USU_GUARDAR.Click


        Try


            If Me.ValidateChildren And txb_ALTAS_USU_CI.Text <> String.Empty And txb_ALTAS_USU_CI2.Text <> String.Empty And txb_ALTAS_USU_NOMBRE.Text <> String.Empty And txb_ALTAS_USU_APELLIDO.Text <> String.Empty And txb_ALTAS_USU_TELEFONO.Text <> String.Empty And txb_ALTAS_USUARIOS_CONTRASEÑA.Text <> String.Empty And cmb_ALTAS_USU_TIPOUSU.Text <> String.Empty Then


                Dim query As String = String.Empty

                'BRUNO: Aca agregue estas 3 lineas
                conexion = New OdbcConnection(stringconexion)
                cm.Connection = conexion
                conexion.ConnectionString = stringconexion

                conexion.Open()

                query = "Select ci FROM persona WHERE ci='" & txb_ALTAS_USU_CI.Text & txb_ALTAS_USU_CI2.Text & "' "


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

                    MsgBox("Ya existe")

                    txb_ALTAS_USU_APELLIDO.Clear()
                    txb_ALTAS_USU_CELULAR.Clear()
                    txb_ALTAS_USU_CI.Clear()
                    txb_ALTAS_USU_CI2.Clear()
                    txb_ALTAS_USU_NOMBRE.Clear()
                    txb_ALTAS_USUARIOS_CONTRASEÑA.Clear()
                    txb_ALTAS_USU_TELEFONO.Clear()
                    lbl_ALTAS_USU_MATERIA.Visible = False
                    clb_ALTAS_USU_MATERIA.Visible = False
                    cmb_ALTAS_USU_TIPOUSU.Text = ""

                ElseIf cantidad > 1 Then
                    MsgBox("Duplicado en la base de datos")

                Else


                    Dim ta As String = "persona"
                    Dim at As String = "ci,contrasena,tipo,nombre,apellido,telefono,baja,celular"
                    Dim ins As String = "(" & txb_ALTAS_USU_CI.Text & txb_ALTAS_USU_CI2.Text & ",'" & txb_ALTAS_USUARIOS_CONTRASEÑA.Text & "','" & cmb_ALTAS_USU_TIPOUSU.Text & "','" & txb_ALTAS_USU_NOMBRE.Text & "','" & txb_ALTAS_USU_APELLIDO.Text & "'," & txb_ALTAS_USU_TELEFONO.Text & ",'no'," & txb_ALTAS_USU_CELULAR.Text & ")"
                    altas(ta, at, ins)




                    datr.Close()

                    Dim tu As String = "dicta"
                    Dim ra As String = "ci,cod_materia"
                    For Each lista In clb_ALTAS_USU_MATERIA.CheckedItems


                        nom = Nothing
                        llenar.Connection = conexion
                        llenar.CommandText = "Select cod_materia from materia where nombre= '" & lista & "'" 'clb_ALTAS_USU_MATERIA.SelectedItem' 
                        nom = llenar.ExecuteScalar
                        Dim ca As String = "('" & txb_ALTAS_USU_CI.Text & txb_ALTAS_USU_CI2.Text & "'," & nom & ")"
                        altas(tu, ra, ca)
                    Next



                    MessageBox.Show("Alta realizada correctamente", "Altas de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)



                    'ErrorProvider1.SetError(txt_Veri, "Cedula incorrecta")
                End If

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Altas de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conexion.Close()

        Catch ex As OdbcException
            MsgBox(ex.Message)

        End Try

        ''Else
        'MsgBox("La cedula es invalida")
        ''ErrorProvider1.SetError(txt_Veri, "Cedula incorrecta"

        'txb_ALTAS_USU_APELLIDO.Clear()
        'txb_ALTAS_USU_CELULAR.Clear()
        'txb_ALTAS_USU_CI.Clear()
        'txb_ALTAS_USU_CI2.Clear()
        'txb_ALTAS_USU_NOMBRE.Clear()
        'txb_ALTAS_USUARIOS_CONTRASEÑA.Clear()
        'txb_ALTAS_USU_TELEFONO.Clear()
        'lbl_ALTAS_USU_MATERIA.Visible = False
        'clb_ALTAS_USU_MATERIA.Visible = False
        'cmb_ALTAS_USU_TIPOUSU.Text = ""
        'End If



        Try
            '  Guardar en historial - ALTAS-USUARIO
            Dim descripcion As String
            descripcion = "Ingreso de usuario:"
            Dim tab As String = "historial"
            Dim atr As String = "ci,fecha,hora,descripcion,accion"
            Dim inser As String = "('" & Modulos.user & "','" & mes & "-" & dia & "-" & año & "','" & hora & ":" & min & " ','" & descripcion & " " & txb_ALTAS_USU_NOMBRE.Text & " " & txb_ALTAS_USU_APELLIDO.Text & " " & txb_ALTAS_USU_CI.Text & "-" & txb_ALTAS_USU_CI2.Text & "','Altas')"
            ' MsgBox("('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & "" & txb_ALTAS_USU_NOMBRE.Text & " " & txb_ALTAS_USU_APELLIDO.Text & " " & txb_ALTAS_USU_CI.Text & "-" & txb_ALTAS_USU_CI2.Text & "','Altas')")
            inshistorial(tab, atr, inser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txb_ALTAS_USU_APELLIDO.Clear()
        txb_ALTAS_USU_CELULAR.Clear()
        txb_ALTAS_USU_CI.Clear()
        txb_ALTAS_USU_CI2.Clear()
        txb_ALTAS_USU_NOMBRE.Clear()
        txb_ALTAS_USUARIOS_CONTRASEÑA.Clear()
        txb_ALTAS_USU_TELEFONO.Clear()
        lbl_ALTAS_USU_MATERIA.Visible = False
        clb_ALTAS_USU_MATERIA.Visible = False
        cmb_ALTAS_USU_TIPOUSU.Text = ""

    End Sub

    Private Sub btn_ALTAS_MAT_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_MAT_GUARDAR.Click



        Try
            conexion.Open()
            If Me.ValidateChildren And txb_ALTAS_MAT_NOMBRE.Text <> String.Empty And nud_ALTAS_MAT_CARGA.Value <> 0 And cmb_ALTAS_MAT_PREFERENCIA.Text <> String.Empty And cmb_ALTAS_MAT_PRIORIDAD.Text <> String.Empty Then

                'conexion.ConnectionString = stringconexion
                'conexion.Open()

                ' MsgBox("Conexion exitosa")


                Dim query As String = String.Empty


                query = "Select nombre FROM materia WHERE nombre='" & txb_ALTAS_MAT_NOMBRE.Text & "'"


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

                    MsgBox("Ya existe")

                    txb_ALTAS_MAT_NOMBRE.Clear()
                    nud_ALTAS_MAT_CARGA.Value = 0

                ElseIf cantidad > 1 Then
                    MsgBox("Duplicado en la base de datos")

                Else



                    Dim ta As String = "Materia"
                    Dim at As String = "nombre,carga_horaria,prioridad,preferencia,baja"
                    Dim ins As String = "('" & txb_ALTAS_MAT_NOMBRE.Text & "'," & nud_ALTAS_MAT_CARGA.Value & "," & cmb_ALTAS_MAT_PRIORIDAD.Text & ",'" & cmb_ALTAS_MAT_PREFERENCIA.Text & "','no')"

                    altas(ta, at, ins)
                    MessageBox.Show("Alta realizada correctamente", "Altas de Materias", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Altas de Materia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conexion.Close()
        Catch ex As OdbcException
            MsgBox(ex.Message)

        End Try


        Try
            '' Guardar en historial - ALTAS-MATERIA
            Dim descripcion As String
            descripcion = "Ingreso la materia: "
            Dim tab As String = "historial"
            Dim atr As String = "ci,fecha,hora,descripcion,accion"
            Dim inser As String = "('" & Modulos.user & "','" & dia & "-" & mes & "-" & año & "','" & hora & ":" & min & " ','" & descripcion & " " & txb_ALTAS_MAT_NOMBRE.Text & "','Altas')"
            inshistorial(tab, atr, inser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txb_ALTAS_MAT_NOMBRE.Clear()
        nud_ALTAS_MAT_CARGA.Value = 0
        cmb_ALTAS_MAT_PREFERENCIA.Text = ""
        cmb_ALTAS_MAT_PRIORIDAD.Text = ""


    End Sub

    Private Sub btn_ALTAS_GRUPO_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_GRUPO_GUARDAR.Click

        Try

            conexion.Open()
            If Me.ValidateChildren And txb_ALTAS_GRUPOS_DESCRIPCION.Text <> String.Empty And cmb_ALTAS_GRUPO_CARRERA.Text <> String.Empty Then


                'conexion.ConnectionString = stringconexion
                'conexion.Open()

                ' MsgBox("Conexion exitosa")


                Dim query As String = String.Empty


                query = "Select descripcion FROM grupo WHERE descripcion='" & txb_ALTAS_GRUPOS_DESCRIPCION.Text & "'"


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

                    MsgBox("Ya existe")

                    txb_ALTAS_GRUPOS_DESCRIPCION.Clear()
                    nud_ALTAS_GRUPO_CANTIDAD.Value = 0
                    cmb_ALTAS_GRUPO_CARRERA.Text = ""

                ElseIf cantidad > 1 Then
                    MsgBox("Duplicado en la base de datos")

                Else


                    'Dim codigo As String = Mid(cmb_ALTAS_GRUPO_CARRERA.Text, 1, 1)
                    nom = Nothing

                    'conexion = New OdbcConnection(stringconexion)
                    'cm.Connection = conexion
                    'conexion.ConnectionString = stringconexion

                    'conexion.Open()

                    llenar.Connection = conexion
                    llenar.CommandText = "Select cod_carrera from carrera where nombre= '" & cmb_ALTAS_GRUPO_CARRERA.Text & "'"
                    nom = llenar.ExecuteScalar

                    datr.Close()


                    Dim ta As String = "grupo"
                    Dim at As String = "descripcion,cod_carrera,baja,cantidad"
                    Dim ins As String = "('" & txb_ALTAS_GRUPOS_DESCRIPCION.Text & "'," & nom & ",'no'," & nud_ALTAS_GRUPO_CANTIDAD.Value & ")"

                    altas(ta, at, ins)

                    MessageBox.Show("Alta realizada correctamente", "Altas de Grupo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    


                End If






            Else
                MessageBox.Show("Ingrese los datos requeridos", "Altas de Grupo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conexion.Close()

        Catch ex As OdbcException
            MsgBox(ex.Message)

        End Try

        Try
            '' Guardar en historial - ALTAS-GRUPO
            Dim descripcion As String
            descripcion = "Ingreso el grupo:"
            Dim tab As String = "historial"
            Dim atr As String = "ci,fecha,hora,descripcion,accion"
            Dim inser As String = "('" & Modulos.user & "','" & mes & "-" & dia & "-" & año & "','" & hora & ":" & min & " ','" & descripcion & " " & txb_ALTAS_GRUPOS_DESCRIPCION.Text & " Cantidad de alumnos: " & nud_ALTAS_GRUPO_CANTIDAD.Value & " Carrera: " & cmb_ALTAS_GRUPO_CARRERA.Text & " ','Altas')"
            inshistorial(tab, atr, inser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        txb_ALTAS_GRUPOS_DESCRIPCION.Clear()
        nud_ALTAS_GRUPO_CANTIDAD.Value = 0
        cmb_ALTAS_GRUPO_CARRERA.Text = ""
    End Sub

    Private Sub btn_ALTAS_SALON_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_SALON_GUARDAR.Click

        Try

            conexion.Open()
            If Me.ValidateChildren And txb_ALTAS_SALON_DESCRIPCION.Text <> String.Empty And nud_ALTAS_SALON_CAPACIDAD.Value <> 0 Then


                Dim query As String = String.Empty

                query = "Select descripcion FROM salon WHERE descripcion='" & txb_ALTAS_SALON_DESCRIPCION.Text & "'"

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

                    MsgBox("Ya existe")
                    txb_ALTAS_SALON_DESCRIPCION.Clear()
                    nud_ALTAS_SALON_CAPACIDAD.Value = 0

                ElseIf cantidad > 1 Then
                    MsgBox("Duplicado en la base de datos")

                Else

                    Dim ta As String = "salon"
                    Dim at As String = "descripcion,baja,tipo,capacidad"
                    Dim ins As String = "('" & txb_ALTAS_SALON_DESCRIPCION.Text & "','no','" & cmb_ALTAS_SALON_TIPO.Text & "'," & nud_ALTAS_SALON_CAPACIDAD.Value & ")"
                    MsgBox("('" & txb_ALTAS_SALON_DESCRIPCION.Text & "','no'," & nud_ALTAS_SALON_CAPACIDAD.Value & ")")
                    altas(ta, at, ins)

                    MessageBox.Show("Alta realizada correctamente", "Altas de salon", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Altas de Salon", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conexion.Close()
        Catch ex As OdbcException
            MsgBox(ex.Message)

        End Try


        Try
            '' Guardar en historial - ALTAS-SALON
            Dim descripcion As String
            descripcion = "Ingreso de salon:"
            Dim tab As String = "historial"
            Dim atr As String = "ci,fecha,hora,descripcion,accion"
            Dim inser As String = "('" & Modulos.user & "','" & dia & "-" & mes & "-" & año & "','" & hora & ":" & min & " ','" & descripcion & " " & txb_ALTAS_SALON_DESCRIPCION.Text & " Tipo: " & cmb_ALTAS_SALON_TIPO.Text & " Capacidad: " & nud_ALTAS_SALON_CAPACIDAD.Value & "','Altas')"
            inshistorial(tab, atr, inser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        txb_ALTAS_SALON_DESCRIPCION.Clear()
        nud_ALTAS_SALON_CAPACIDAD.Value = 0
        cmb_ALTAS_SALON_TIPO.Text = ""

        ep_VACIOS.Clear()

    End Sub

    Private Sub btn_ALTAS_CARRERA_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_CARRERA_GUARDAR.Click

        Try

            conexion.Open()
            If Me.ValidateChildren And txb_ALTAS_CARREARA_NOMBRE.Text <> String.Empty Then


                Dim query As String = String.Empty

                query = "Select nombre FROM carrera WHERE nombre='" & txb_ALTAS_CARREARA_NOMBRE.Text & "'"

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

                    MsgBox("Ya existe")
                    txb_ALTAS_CARREARA_NOMBRE.Clear()

                ElseIf cantidad > 1 Then
                    MsgBox("Duplicado en la base de datos")

                Else



                    Dim ta As String = "carrera"
                    Dim at As String = "nombre,baja"
                    Dim ins As String = "('" & txb_ALTAS_CARREARA_NOMBRE.Text & "','no')"
                    altas(ta, at, ins)
                    MessageBox.Show("Alta realizada correctamente", "Altas de carrera", MessageBoxButtons.OK, MessageBoxIcon.Information)



                End If
            Else
                MessageBox.Show("Ingrese los datos requeridos", "Altas de carrera", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conexion.Close()

        Catch ex As OdbcException
            MsgBox(ex.Message)

        End Try

        Try
            '' Guardar en historial - ALTAS-CARRERA
            Dim descripcion As String
            descripcion = "Ingreso de carrera:"
            Dim tab As String = "historial"
            Dim atr As String = "ci,fecha,hora,descripcion,accion"
            Dim inser As String = "('" & Modulos.user & "','" & dia & "-" & mes & "-" & año & "','" & hora & ":" & min & " ','" & descripcion & " " & txb_ALTAS_CARREARA_NOMBRE.Text & "','Altas')"
            inshistorial(tab, atr, inser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txb_ALTAS_CARREARA_NOMBRE.Clear()

    End Sub

    Private Sub btn_ALTAS_CARREARA_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_CARREARA_CANCELAR.Click
        txb_ALTAS_CARREARA_NOMBRE.Clear()
    End Sub


    Private Sub btn_BAJAS_USU_BORRARSIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_USU_BORRARSIS.Click
        

        Try
            conexion.Open()
            If Me.ValidateChildren And cmb_BAJAS_USU_BORRAR.Text <> String.Empty Then
                Dim codigo As String = Mid(cmb_BAJAS_USU_BORRAR.Text, 1, 8)
                Dim ta As String = "persona"
                Dim co As String = "ci"
                Dim re As String = "'" & codigo & "'"

                borrar(ta, co, re)
                MessageBox.Show("Usuario borrado", "Baja de Ususario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conexion.Open()


                Try
                    '  Guardar en historial - BAJA - BORRAR-USUARIO
                    Dim descripcion As String
                    descripcion = "Borro el usuario:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_USU_BORRAR.Text & "','Baja')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try



                cmb_BAJAS_USU_BORRAR.Text = ""


                cmb_BAJAS_USU_BORRAR.Items.Clear()


                conexion.Open()

                llenar.Connection = conexion
                llenar.CommandText = "Select * from persona"
                datr = llenar.ExecuteReader

                While datr.Read
                    cmb_BAJAS_USU_BORRAR.Items.Add((datr.GetValue(0).ToString) & " " & (datr.GetValue(3).ToString) & " " & (datr.GetValue(4).ToString))
                End While
                datr.Close()


            Else
                MessageBox.Show("Ingrese los datos requeridos", "Baja de Ususario", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub btn_BAJAS_MAT_BORRAR_BORARSIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_MAT_BORRAR_BORARSIS.Click
        conexion.Open()

        Try
            If Me.ValidateChildren And cmb_BAJAS_MAT_BORRAR.Text <> String.Empty Then
                conexion = New OdbcConnection(stringconexion)
                cm.Connection = conexion
                conexion.ConnectionString = stringconexion


                nom = Nothing


                conexion.Open()
                llenar.Connection = conexion
                llenar.CommandText = "Select cod_materia from materia where nombre= '" & cmb_BAJAS_MAT_BORRAR.Text & "'"
                nom = llenar.ExecuteScalar

                datr.Close()



                Dim ta As String = "materia"
                Dim co As String = "cod_materia"
                Dim re As String = "'" & nom & "'"

                borrar(ta, co, re)
                MessageBox.Show("Materia borrada", "Baja de Materia", MessageBoxButtons.OK, MessageBoxIcon.Information)

                conexion.Open()


                Try
                    '  Guardar en historial - BAJA - BORRAR-MATERIA
                    Dim descripcion As String
                    descripcion = "Borro la materia:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_MAT_BORRAR.Text & "','Baja')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try







                cmb_BAJAS_MAT_BORRAR.Items.Clear()



                conexion.Open()

                llenar.Connection = conexion
                llenar.CommandText = "Select * from Materia"
                datr = llenar.ExecuteReader

                While datr.Read
                    cmb_BAJAS_MAT_BORRAR.Items.Add(datr.GetValue(1).ToString)
                End While
                datr.Close()

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Baja de Materia", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_BAJAS_GRUPO_BORRAR_BORRARSIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_GRUPO_BORRAR_BORRARSIS.Click

        Try


            If Me.ValidateChildren And cmb_BAJAS_GRUPO_BORRAR.Text <> String.Empty Then
                conexion.Open()

                llenar.Connection = conexion
                llenar.CommandText = "Select cod_grupo from grupo where descripcion= '" & cmb_BAJAS_GRUPO_BORRAR.Text & "'"
                nom = llenar.ExecuteScalar

                datr.Close()


                Dim ta As String = "grupo"
                Dim co As String = "cod_grupo"
                Dim re As String = "'" & nom & "'"

                borrar(ta, co, re)
                MessageBox.Show("Grupo borrado", "Baja de Grupo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                conexion.Open()

                Try
                    '  Guardar en historial - BAJA - BORRAR-GRUPO
                    Dim descripcion As String
                    descripcion = "Borro la grupo:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_GRUPO_BORRAR.Text & "','Baja')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try





                cmb_BAJAS_GRUPO_BORRAR.Text = ""

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Baja de Grupo", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            cmb_BAJAS_GRUPO_BORRAR.Items.Clear()



            conexion.Open()

            llenar.Connection = conexion
            llenar.CommandText = "Select * from Grupo"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_GRUPO_BORRAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_BAJAS_SALON_BORRAR_BORRARSIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_SALON_BORRAR_BORRARSIS.Click

        Try


            If Me.ValidateChildren And cmb_BAJAS_SALON_BORRAR.Text <> String.Empty Then
                conexion.Open()
                llenar.Connection = conexion
                llenar.CommandText = "Select cod_salon from salon where descripcion= '" & cmb_BAJAS_SALON_BORRAR.Text & "'"
                nom = llenar.ExecuteScalar

                datr.Close()


                Dim ta As String = "salon"
                Dim co As String = "cod_salon"
                Dim re As String = "'" & nom & "'"

                borrar(ta, co, re)
                MsgBox("Salon borrado")
                MessageBox.Show("Salon borrado", "Baja de Salon", MessageBoxButtons.OK, MessageBoxIcon.Information)

                conexion.Open()

                Try
                    '  Guardar en historial - BAJA - BORRAR-SALON
                    Dim descripcion As String
                    descripcion = "Borro el salon:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_SALON_BORRAR.Text & "','Baja')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                cmb_BAJAS_SALON_BORRAR.Text = ""

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Baja de Salon", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            cmb_BAJAS_SALON_BORRAR.Items.Clear()

            conexion.Open()

            llenar.Connection = conexion
            llenar.CommandText = "Select * from salon"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_SALON_BORRAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_BAJAS_TURNOS_BORRAR_BORRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_TURNOS_BORRAR_BORRAR.Click
        Try


            If Me.ValidateChildren And cmb_BAJAS_TURNOS_BORRAR.Text <> String.Empty Then
                conexion.Open()

                llenar.Connection = conexion
                llenar.CommandText = "Select cod_turno from turno where nombre= '" & cmb_BAJAS_TURNOS_BORRAR.Text & "'"
                nom = llenar.ExecuteScalar

                datr.Close()


                Dim ta As String = "turno"
                Dim co As String = "cod_turno"
                Dim re As String = "'" & nom & "'"

                borrar(ta, co, re)
                MessageBox.Show("Turno borrado", "Baja de Turno", MessageBoxButtons.OK, MessageBoxIcon.Information)

                conexion.Open()

                Try
                    '  Guardar en historial - BAJA - BORRAR-TURNOS
                    Dim descripcion As String
                    descripcion = "Borro el turno"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_TURNOS_BORRAR.Text & "','Baja')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try









                cmb_BAJAS_TURNOS_BORRAR.Text = ""

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Baja de Turno", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            cmb_BAJAS_TURNOS_BORRAR.Items.Clear()

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from turno"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_TURNOS_BORRAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_BAJAS_CARRERA_BORRAR_BORRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_CARRERA_BORRAR_BORRAR.Click

        Try


            If Me.ValidateChildren And cmb_BAJAS_CARRERA_BORRAR.Text <> String.Empty Then
                conexion.Open()
                llenar.Connection = conexion
                llenar.CommandText = "Select cod_carrera from carrera where nombre= '" & cmb_BAJAS_CARRERA_BORRAR.Text & "'"
                nom = llenar.ExecuteScalar

                datr.Close()


                Dim ta As String = "carrera"
                Dim co As String = "cod_carrera"
                Dim re As String = "'" & nom & "'"

                borrar(ta, co, re)
                MessageBox.Show("Carrera borrada", "Baja de Carrera", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conexion.Open()

                Try
                    '  Guardar en historial - BAJA - BORRAR-CARRERA
                    Dim descripcion As String
                    descripcion = "Borro la carrera"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_CARRERA_BORRAR.Text & "','Baja')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try








                cmb_BAJAS_CARRERA_BORRAR.Text = ""

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Baja de Carrera", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            cmb_BAJAS_CARRERA_BORRAR.Items.Clear()
            conexion.Open()

            llenar.Connection = conexion
            llenar.CommandText = "Select * from carrera"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_CARRERA_BORRAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_BAJAS_USU_DESACTIVARSIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_USU_DESACTIVARSIS.Click
        Try
            conexion.Open()
            If Me.ValidateChildren And cmb_BAJAS_USU_DES_CI.Text <> String.Empty Then
                Dim codigo As String = Mid(cmb_BAJAS_USU_DES_CI.Text, 1, 8)
                Dim ta As String = "persona"
                Dim co As String = "ci"
                Dim re As String = "'" & codigo & "'"

                desactivar(ta, co, re)
                MessageBox.Show("Usuario desactivado", "Baja de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Movi el conexion.open() para aca, estaba debajo de cmb_bajas_usu_des_ci.items.clear() - Bruno

                conexion.Open()
                Try
                    '  Guardar en historial - BAJA - DESACTIVAR-USUARIO
                    Dim descripcion As String
                    descripcion = "Desactivo el usuario:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_USU_DES_CI.Text & " ','Desactivar')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                cmb_BAJAS_USU_DES_CI.Text = ""
                cmb_BAJAS_USU_DES_CI.Items.Clear()

                conexion.Open()
                llenar.Connection = conexion
                llenar.CommandText = "Select * from persona where baja='no'"
                datr = llenar.ExecuteReader

                While datr.Read
                    cmb_BAJAS_USU_DES_CI.Items.Add((datr.GetValue(0).ToString) & " " & (datr.GetValue(3).ToString) & " " & (datr.GetValue(4).ToString))
                End While
                datr.Close()
            Else
                MessageBox.Show("Ingrese los datos requeridos", "Baja de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btn_MODIFICAR_USU_MODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SELECCIONAR_USU_MODIFICAR.Click

        Try

            conexion.Open()
            If Me.ValidateChildren And txb_MODIFICAR_USU_CI.Text <> String.Empty And txb_MODIFICAR_USU_CI2.Text <> String.Empty Then

                Dim query As String = String.Empty

                query = "Select ci FROM persona WHERE ci='" & txb_MODIFICAR_USU_CI.Text & txb_MODIFICAR_USU_CI2.Text & "'"

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

                    datr.Close()




                    llenar.Connection = conexion
                    llenar.CommandText = "Select * from persona where ci = " & txb_MODIFICAR_USU_CI.Text & txb_MODIFICAR_USU_CI2.Text
                    datr = llenar.ExecuteReader

                    datr.Read()
                    txb_MODIFICAR_USU_NOMBRE.Text = datr.GetValue(3).ToString
                    txb_MODIFICAR_USU_APELLIDO.Text = datr.GetValue(4).ToString
                    txb_MODIFICAR_USU_TELEFONO.Text = datr.GetValue(5).ToString
                    txb_MODI_USU_CELULAR.Text = datr.GetValue(6).ToString
                    txb_MODI_USU_CONTRASEÑA.Text = datr.GetValue(1).ToString
                    cmb_MODIFICAR_USU_TIPOUSU.Text = datr.GetValue(2).ToString

                    If cmb_MODIFICAR_USU_TIPOUSU.Text = "Profesor" Then
                        lbl_MODIFICAR_USU_MATERIA.Visible = True
                        clb_MODIFICAR_USU_MATERIA.Visible = True


                    End If
                    datr.Close()
                    'llenar.Connection = conexion

                    llenar.CommandText = "Select m.cod_materia, m.nombre, d.ci from dicta d, materia m Where d.cod_materia=m.cod_materia"
                    datr = llenar.ExecuteReader

                    While datr.Read()
                        If datr.GetValue(2).ToString = txb_MODIFICAR_USU_CI.Text & txb_MODIFICAR_USU_CI2.Text Then
                            clb_MODIFICAR_USU_MATERIA.Items.Remove((datr.GetValue(1).ToString))
                            clb_MODIFICAR_USU_MATERIA.Items.Add((datr.GetValue(1).ToString), True)
                        End If
                    End While

                    datr.Close()

                ElseIf cantidad > 1 Then
                    MsgBox("Duplicado en la base de datos")

                Else

                    MessageBox.Show("Esta cedula no existe en la base de datos", "Modificar Usuario")
                    txb_MODIFICAR_USU_CI.Clear()
                    txb_MODIFICAR_USU_CI2.Clear()





                End If

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conexion.Close()
        Catch ex As OdbcException
            MsgBox(ex.Message)
            conexion.Close()
        End Try

    End Sub


    Private Sub btn_BAJAS_MAT_DESACTIVAR_DESACTIVARSIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_MAT_DESACTIVAR_DESACTIVARSIS.Click

        Try
            conexion.Open()
            If Me.ValidateChildren And cmb_BAJAS_MAT_DESACTIVAR.Text <> String.Empty Then

                llenar.Connection = conexion
                llenar.CommandText = "Select cod_materia from materia where nombre= '" & cmb_BAJAS_MAT_DESACTIVAR.Text & "'"
                nom = llenar.ExecuteScalar

                datr.Close()



                Dim ta As String = "materia"
                Dim co As String = "cod_materia"
                Dim re As String = "'" & nom & "'"

                desactivar(ta, co, re)
                MessageBox.Show("Materia desactivada", "Baja de Materia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conexion.Open()

                Try
                    '  Guardar en historial - BAJA - DESACTIVAR-MATERIA
                    Dim descripcion As String
                    descripcion = "Desactivo la materia:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_MAT_DESACTIVAR.Text & " ','Desactivar')"
                    inshistorial(tab, atr, inser)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try



                cmb_BAJAS_MAT_DESACTIVAR.Items.Clear()

                conexion.Open()
                llenar.Connection = conexion
                llenar.CommandText = "Select * from Materia where baja='no'"
                datr = llenar.ExecuteReader

                While datr.Read
                    cmb_BAJAS_MAT_DESACTIVAR.Items.Add(datr.GetValue(1).ToString)
                End While
                datr.Close()

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Baja de Materia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_BAJAS_GRUPO_DESACTIVAR_DESACTIVARSIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_GRUPO_DESACTIVAR_DESACTIVARSIS.Click
        Try


            If Me.ValidateChildren And cmb_BAJAS_GRUPO_DESACTIVAR.Text <> String.Empty Then
                conexion.Open()

                llenar.Connection = conexion
                llenar.CommandText = "Select cod_grupo from grupo where descripcion= '" & cmb_BAJAS_GRUPO_DESACTIVAR.Text & "'"
                nom = llenar.ExecuteScalar

                datr.Close()

                Dim ta As String = "grupo"
                Dim co As String = "cod_grupo"
                Dim re As String = "'" & nom & "'"

                desactivar(ta, co, re)

                MessageBox.Show("Grupo desactivado", "Baja de Grupo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conexion.Open()
                Try
                    '  Guardar en historial - BAJA - DESACTIVAR-GRUPO
                    Dim descripcion As String
                    descripcion = "Desactivo el grupo:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_GRUPO_DESACTIVAR.Text & " ','Desactivar')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                cmb_BAJAS_GRUPO_DESACTIVAR.Text = " "

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Baja de Grupo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            cmb_BAJAS_GRUPO_DESACTIVAR.Items.Clear()



            conexion.Open()

            llenar.Connection = conexion
            llenar.CommandText = "Select * from Grupo where baja='no'"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_GRUPO_DESACTIVAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_BAJAS_SALON_DESACTIVAR_DESACTIVARSIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_SALON_DESACTIVAR_DESACTIVARSIS.Click
        Try


            If Me.ValidateChildren And cmb_BAJAS_SALON_DESACTIVAR.Text <> String.Empty Then
                conexion.Open()

                llenar.Connection = conexion
                llenar.CommandText = "Select cod_salon from salon where descripcion= '" & cmb_BAJAS_SALON_DESACTIVAR.Text & "'"
                nom = llenar.ExecuteScalar

                datr.Close()


                Dim ta As String = "salon"
                Dim co As String = "cod_salon"
                Dim re As String = "'" & nom & "'"

                desactivar(ta, co, re)
                MessageBox.Show("Salon desactivado", "Baja de Salon", MessageBoxButtons.OK, MessageBoxIcon.Information)

                conexion.Open()
                Try
                    '  Guardar en historial - BAJA - DESACTIVAR-SALON
                    Dim descripcion As String
                    descripcion = "Desactivo el salon:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_SALON_DESACTIVAR.Text & " ','Desactivar')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try




                cmb_BAJAS_SALON_DESACTIVAR.Text = ""

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Baja de Salon", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            cmb_BAJAS_SALON_DESACTIVAR.Items.Clear()


            conexion.Open()

            llenar.Connection = conexion
            llenar.CommandText = "Select * from salon where baja='no'"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_SALON_DESACTIVAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_BAJAS_TURNOS_DESACTIVAR_DESACTIVAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_TURNOS_DESACTIVAR_DESACTIVAR.Click

        Try


            If Me.ValidateChildren And cmb_BAJAS_TURNOS_DESACTIVAR.Text <> String.Empty Then
                conexion.Open()

                llenar.Connection = conexion
                llenar.CommandText = "Select cod_turno from turno where nombre= '" & cmb_BAJAS_TURNOS_DESACTIVAR.Text & "'"
                nom = llenar.ExecuteScalar

                datr.Close()

                Dim ta As String = "turno"
                Dim co As String = "cod_turno"
                Dim re As String = "'" & nom & "'"

                desactivar(ta, co, re)
                MessageBox.Show("Turno desactivado", "Baja de Turno", MessageBoxButtons.OK, MessageBoxIcon.Information)

                conexion.Open()
                Try
                    '  Guardar en historial - BAJA - DESACTIVAR-TURNOS  
                    Dim descripcion As String
                    descripcion = "Desactivo el turno"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_TURNOS_DESACTIVAR.Text & " ','Desactivar')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try



                cmb_BAJAS_TURNOS_DESACTIVAR.Text = ""


            Else
                MessageBox.Show("Ingrese los datos requeridos", "Baja de Turno", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            cmb_BAJAS_TURNOS_DESACTIVAR.Items.Clear()

            conexion.Open()

            llenar.Connection = conexion
            llenar.CommandText = "Select * from turno where baja='no'"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_TURNOS_DESACTIVAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_BAJAS_CARRERA_DESACTIVAR_DESACTIVAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_CARRERA_DESACTIVAR_DESACTIVAR.Click
        Try


            If Me.ValidateChildren And cmb_BAJAS_CARRERA_DESACTIVAR.Text <> String.Empty Then
                conexion.Open()
                llenar.Connection = conexion
                llenar.CommandText = "Select cod_carrera from carrera where nombre= '" & cmb_BAJAS_CARRERA_DESACTIVAR.Text & "'"
                nom = llenar.ExecuteScalar

                datr.Close()


                Dim ta As String = "carrera"
                Dim co As String = "cod_carrera"
                Dim re As String = "'" & nom & "'"

                desactivar(ta, co, re)
                MessageBox.Show("Carrera desactivada", "Baja de Carrera", MessageBoxButtons.OK, MessageBoxIcon.Information)

                conexion.Open()
                Try
                    '  Guardar en historial - BAJA - DESACTIVAR-CARRERA  
                    Dim descripcion As String
                    descripcion = "Desactivo el carrera"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_CARRERA_DESACTIVAR.Text & " ','Desactivar')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try



                cmb_BAJAS_CARRERA_DESACTIVAR.Text = ""

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Baja de Carrera", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_ALTAS_HORA_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_HORA_GUARDAR.Click
        Try


            conexion.Open()
            If Me.ValidateChildren And cmb_ALTAS_HORA_DIA.Text <> String.Empty And cmb_ALTAS_HORA_TURNO.Text <> String.Empty And cmb_ALTAS_HORARIO_NUMEROHORA.Text <> String.Empty Then




                nom = Nothing

                llenar.Connection = conexion
                llenar.CommandText = "Select cod_turno from turno where nombre= '" & cmb_ALTAS_HORA_TURNO.Text & "'"
                nom = llenar.ExecuteScalar

                datr.Close()


                Dim ta As String = "horario"
                Dim at As String = "cod_turno,dia,numero_hora,hora_inicio,hora_fin,baja"
                Dim ins As String = "('" & nom & "','" & cmb_ALTAS_HORA_DIA.Text & "','" & cmb_ALTAS_HORARIO_NUMEROHORA.Text & "','" & dtp_ALTAS_HORARIO_INICIO.Text & "','" & dtp_ALTAS_HORARIO_FIN.Text & "','no')"

                'MsgBox("('" & codigo & "','" & cmb_ALTAS_HORA_DIA.Text & "'," & txb_ALTAS_HORARIO_NUMEROHORA.Text & ",'" & dtp_ALTAS_HORARIO_INICIO.Text & "','" & dtp_ALTAS_HORARIO_FIN.Text & "','no')")

                altas(ta, at, ins)
                MsgBox("Alta realizada correctamente")

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Altas de Horario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        

        Try
            '' Guardar en historial - ALTAS-HORARIO
            Dim descripcion As String
            descripcion = "Ingreso el horario:"
            Dim tab As String = "historial"
            Dim atr As String = "ci,fecha,hora,descripcion,accion"
            Dim inser As String = "('" & Modulos.user & "','" & dia & "-" & mes & "-" & año & "','" & hora & ":" & min & " ','" & descripcion & " " & cmb_ALTAS_HORA_DIA.Text & " " & cmb_ALTAS_HORA_TURNO.Text & "','Altas')"
            'MsgBox("(" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & "" & txb_ALTAS_MAT_NOMBRE.Text & "','Altas')")
            inshistorial(tab, atr, inser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        cmb_ALTAS_HORARIO_NUMEROHORA.Text = ""
        dtp_ALTAS_HORARIO_FIN.Text = "00:00"
        dtp_ALTAS_HORARIO_INICIO.Text = "00:00"
        cmb_ALTAS_HORA_TURNO.Text = ""
        cmb_ALTAS_HORA_DIA.Text = ""



    End Sub

    Private Sub cmb_BAJAS_HORA_DESACTIVAR_TURNO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_BAJAS_HORA_DESACTIVAR_TURNO.SelectedIndexChanged
        cmb_BAJAS_HORA_DESACTIVAR_DIA.Enabled = True



    End Sub

    Private Sub btn_BAJAS_HORA_DESACTIVAR_DESACTIVARSIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_HORA_DESACTIVAR_DESACTIVARSIS.Click
        Try
            conexion.Open()


            If Me.ValidateChildren And cmb_BAJAS_HORA_DESACTIVAR_DIA.Text <> String.Empty And cmb_BAJAS_HORA_DESACTIVAR_TURNO.Text <> String.Empty And cmb_BAJAS_HORA_DESACTIVAR.Text <> String.Empty Then
                codigo = Nothing
                nom = Nothing


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_turno from turno where nombre= '" & cmb_BAJAS_HORA_DESACTIVAR_TURNO.Text & "'"
                codigo = llenar.ExecuteScalar

                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_horario from horario where hora_inicio= '" & Mid(cmb_BAJAS_HORA_DESACTIVAR.Text, 1, 5) & "' and dia='" & cmb_BAJAS_HORA_DESACTIVAR_DIA.Text & "' and cod_turno='" & codigo & "'"
                nom = llenar.ExecuteScalar

                datr.Close()

                Dim ta As String = "horario"
                Dim co As String = "cod_horario"
                Dim re As String = "'" & nom & "'"
                desactivar(ta, co, re)
                MessageBox.Show("Horario desactivado", "Bajas de Horario", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Bruno

                conexion.Open()

                Try
                    '  Guardar en historial - BAJA - DESACTIVAR-HORARIO
                    Dim descripcion As String
                    descripcion = "Desactivo la hora:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_HORA_DESACTIVAR.Text & " Dia: " & cmb_BAJAS_HORA_DESACTIVAR_DIA.Text & " Turno: " & cmb_BAJAS_HORA_DESACTIVAR_TURNO.Text & " ','Desactivar')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                conexion.Open()

                cmb_BAJAS_HORA_DESACTIVAR.Text = ""
                cmb_BAJAS_HORA_DESACTIVAR_DIA.Text = ""
                cmb_BAJAS_HORA_DESACTIVAR_TURNO.Text = ""
                cmb_BAJAS_HORA_DESACTIVAR_DIA.Enabled = False
                cmb_BAJAS_HORA_DESACTIVAR.Enabled = False


            Else
                MessageBox.Show("Ingrese los datos requeridos", "Bajas de Horario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()
    End Sub

    Private Sub cmb_BAJAS_HORA_BORRAR_TURNO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim codigo As String = Mid(cmb_BAJAS_HORA_BORRAR_TURNO.Text, 1, 1)


        conexion = New OdbcConnection(stringconexion)
        cm.Connection = conexion
        conexion.ConnectionString = stringconexion

        conexion.Open()


        llenar.Connection = conexion

        llenar.CommandText = "Select * from horario where cod_turno = " & codigo
        datr = llenar.ExecuteReader

        While datr.Read
            'clb_BAJAS_HORA_BORRAR.Items.Add((datr.GetValue(0).ToString) & " - " & (datr.GetValue(2).ToString) & " desde " & Mid((datr.GetValue(4).ToString), 12, 5) & " hasta " & Mid((datr.GetValue(5).ToString), 12, 5))
        End While
        datr.Close()

        'clb_BAJAS_HORA_DESACTIVAR.ClearSelected()
    End Sub

    Private Sub btn_MODIFICAR_USU_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_USU_GUARDAR.Click
        Try

            conexion.Open()
            If Me.ValidateChildren And txb_MODIFICAR_USU_CI.Text <> String.Empty And txb_MODIFICAR_USU_CI2.Text <> String.Empty And txb_MODIFICAR_USU_NOMBRE.Text <> String.Empty And txb_MODI_USU_CONTRASEÑA.Text <> String.Empty And txb_MODIFICAR_USU_APELLIDO.Text <> String.Empty And txb_MODIFICAR_USU_TELEFONO.Text <> String.Empty And cmb_MODIFICAR_USU_TIPOUSU.Text <> String.Empty Then

                Dim ta As String = "persona"
                Dim at As String = "nombre, apellido, contrasena, telefono, celular, tipo"
                Dim ins As String = "'" & txb_MODIFICAR_USU_NOMBRE.Text & "', '" & txb_MODIFICAR_USU_APELLIDO.Text & "', '" & txb_MODI_USU_CONTRASEÑA.Text & "', " & txb_MODIFICAR_USU_TELEFONO.Text & ", " & txb_MODI_USU_CELULAR.Text & ", '" & cmb_MODIFICAR_USU_TIPOUSU.Text & "' "
                Dim fila As String = "CI"
                Dim clave As String = "" & txb_MODIFICAR_USU_CI.Text & txb_MODIFICAR_USU_CI2.Text & ""

                modificaciones(ta, at, ins, fila, clave)
                'Dim datr As Odbc.OdbcDataReader



                ta = "dicta"
                at = "ci, cod_materia"


                borrar(ta, Mid(at, 1, 2), clave)
                For Each lista In clb_MODIFICAR_USU_MATERIA.CheckedItems
                    'llenar.Connection = conexion
                    'llenar.CommandText = "SELECT * FROM dicta WHERE ci = " & txb_SELECCIONAR_USU_CI.Text & " AND  cod_materia = " & Mid(lista, 1, 1)
                    'datr = llenar.ExecuteScalar
                    'datr.Read()
                    'If llenar.ExecuteScalar = Nothing Then
                    nom = Nothing
                    llenar.Connection = conexion
                    llenar.CommandText = "Select cod_materia from materia where nombre= '" & lista & "'" 'clb_ALTAS_USU_MATERIA.SelectedItem' 
                    conexion.Open()
                    nom = llenar.ExecuteScalar

                    Dim insa As String = "('" & txb_MODIFICAR_USU_CI.Text & txb_MODIFICAR_USU_CI2.Text & "'," & nom & ")"


                    ' ins = "(" & txb_MODIFICAR_USU_CI.Text & txb_MODIFICAR_USU_CI2.Text & ", " & Mid(lista, 1, 1) & " )"
                    altas(ta, at, insa)
                    'End If
                    'datr.Close()
                Next
                MessageBox.Show("Usuario Modificado", "Modificacion de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)




                

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            '  Guardar en historial - MODIFICACION-USUARIO
            Dim descripcion As String
            descripcion = "Modificacion de usuario:"
            Dim tab As String = "historial"
            Dim atr As String = "ci,fecha,hora,descripcion,accion"
            Dim inser As String = "('" & Modulos.user & "'," & Today & ",'" & hora & ":" & min & " ','" & descripcion & " " & txb_MODIFICAR_USU_CI.Text & "-" & txb_MODIFICAR_USU_CI2.Text & " ','Modificacion')"
            inshistorial(tab, atr, inser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        txb_MODIFICAR_USU_CI.Clear()
        txb_MODIFICAR_USU_CI2.Clear()
        txb_MODI_USU_CELULAR.Clear()
        txb_MODI_USU_CONTRASEÑA.Clear()
        txb_MODIFICAR_USU_APELLIDO.Clear()
        txb_MODIFICAR_USU_NOMBRE.Clear()
        txb_MODIFICAR_USU_TELEFONO.Clear()
        cmb_MODIFICAR_USU_TIPOUSU.Text = ""
        clb_MODIFICAR_USU_MATERIA.Visible = False
        lbl_MODIFICAR_USU_MATERIA.Visible = False
        ep_VACIOS.Clear()


    End Sub


    Private Sub cmb_ALTAS_USU_TIPOUSU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ALTAS_USU_TIPOUSU.SelectedIndexChanged
        If cmb_ALTAS_USU_TIPOUSU.Text = "Profesor" Then
            lbl_ALTAS_USU_MATERIA.Visible = True
            clb_ALTAS_USU_MATERIA.Visible = True
        Else
            lbl_ALTAS_USU_MATERIA.Visible = False
            clb_ALTAS_USU_MATERIA.Visible = False

        End If
    End Sub

    Private Sub tbp_MODIFICAR_USU_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp_MODIFICAR_USU.Leave


        txb_MODIFICAR_USU_CI.Clear()
        txb_MODIFICAR_USU_CI2.Clear()
        txb_MODI_USU_CELULAR.Clear()
        txb_MODI_USU_CONTRASEÑA.Clear()
        txb_MODIFICAR_USU_APELLIDO.Clear()
        txb_MODIFICAR_USU_NOMBRE.Clear()
        txb_MODIFICAR_USU_TELEFONO.Clear()
        cmb_MODIFICAR_USU_TIPOUSU.Text = ""
        lbl_MODIFICAR_USU_MATERIA.Visible = False
        clb_MODIFICAR_USU_MATERIA.Visible = False
        ep_VACIOS.Clear()


    End Sub

    Private Sub tbp_ALTAS_USU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_ALTAS_USU.Click

    End Sub

    Private Sub tbp_ALTAS_USU_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp_ALTAS_USU.Leave
        ep_VACIOS.Clear()
        ep_VACIOS2.Clear()
        ep_VACIOS3.Clear()
    End Sub

    Private Sub btn_BAJAS_CARRERA_DESACTIVAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_CARRERA_DESACTIVAR.Click
        pnl_BAJAS_CARRERA_BORRAR.Visible = False
        pnl_BAJAS_CARRERA_DESACTIVAR.Visible = True

        cmb_BAJAS_CARRERA_DESACTIVAR.Items.Clear()

        Try

            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from carrera where baja='no'"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_CARRERA_DESACTIVAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btn_BAJAS_CARRERA_BORRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_CARRERA_BORRAR.Click

        Try

            pnl_BAJAS_CARRERA_BORRAR.Visible = True
            pnl_BAJAS_CARRERA_DESACTIVAR.Visible = False

            cmb_BAJAS_CARRERA_BORRAR.Items.Clear()

            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from carrera"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_CARRERA_BORRAR.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub



    Private Sub tbp_BAJAS_CARRERA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp_BAJAS_CARRERA.Leave
        pnl_BAJAS_CARRERA_BORRAR.Visible = False
        pnl_BAJAS_CARRERA_DESACTIVAR.Visible = False
    End Sub

    Private Sub btn_MODIFICAR_MAT_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_MAT_BUSCAR.Click
        Try

            conexion.Open()


            If Me.ValidateChildren And cmb_MODIFICAR_MAT_CODIGO.Text <> String.Empty Then


                nom = Nothing
                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_materia from materia where nombre = '" & cmb_MODIFICAR_MAT_CODIGO.Text & "'"
                nom = llenar.ExecuteScalar


                datr.Close()





                llenar.Connection = conexion
                llenar.CommandText = "Select * from materia where cod_materia = " & nom
                datr = llenar.ExecuteReader

                datr.Read()
                txb_MODIFICAR_MAT_NOMBRE.Text = datr.GetValue(1).ToString
                txb_MODI_MATERIA_CARGA.Text = datr.GetValue(2).ToString
                cmb_MODIFICAR_MATERIA_BAJA.Text = datr.GetValue(5).ToString
                cmb_MODIFICAR_MATERIA_PRIORIDAD.Text = datr.GetValue(4).ToString
                cmb_MODIFICAR_MATERIA_PREFERENCIA.Text = datr.GetValue(3).ToString


                datr.Close()


            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        ep_VACIOS.Clear()

    End Sub

    Private Sub btn_MODIFICAR_MAT_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_MAT_GUARDAR.Click
        conexion.Open()
        Try


            If Me.ValidateChildren And txb_MODIFICAR_MAT_NOMBRE.Text <> String.Empty And txb_MODI_MATERIA_CARGA.Text <> String.Empty And cmb_MODIFICAR_MATERIA_BAJA.Text <> String.Empty Then

                nom = Nothing
                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_materia from materia where nombre = '" & cmb_MODIFICAR_MAT_CODIGO.Text & "'"
                nom = llenar.ExecuteScalar


                datr.Close()

                Dim ta As String = "materia"
                Dim at As String = "nombre,carga_horaria,prioridad,preferencia,baja"
                Dim ins As String = "'" & txb_MODIFICAR_MAT_NOMBRE.Text & "', " & txb_MODI_MATERIA_CARGA.Text & "," & cmb_MODIFICAR_MATERIA_PRIORIDAD.Text & ",'" & cmb_MODIFICAR_MATERIA_PREFERENCIA.Text & "','" & cmb_MODIFICAR_MATERIA_BAJA.Text & "'"
                Dim fila As String = "cod_materia"
                Dim clave As String = "" & nom & ""



                modificaciones(ta, at, ins, fila, clave)

                MessageBox.Show("Materia Modificada", "Modificar Materia", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As OdbcException
            MsgBox(ex.Message)

        End Try

        datr.Close()

        cmb_MODIFICAR_MAT_CODIGO.Items.Clear()


        llenar.Connection = conexion

        llenar.CommandText = "Select * from materia"
        conexion.Open()

        datr = llenar.ExecuteReader

        While datr.Read
            'clb_MODIFICAR_USU_MATERIA.Items.Add((datr.GetValue(0).ToString) & " - " & (datr.GetValue(1).ToString))
            cmb_MODIFICAR_MAT_CODIGO.Items.Add(datr.GetValue(1).ToString)
        End While
        datr.Close()



        Try
            '  Guardar en historial - MODIFICACION-MATERIA
            Dim descripcion As String
            descripcion = "Modificacion de materia:"
            Dim tab As String = "historial"
            Dim atr As String = "ci,fecha,hora,descripcion,accion"
            Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_MODIFICAR_MAT_CODIGO.Text & " ','Modificacion')"
            inshistorial(tab, atr, inser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        txb_MODI_MATERIA_CARGA.Clear()
        cmb_MODIFICAR_MAT_CODIGO.Text = ""
        txb_MODIFICAR_MAT_NOMBRE.Clear()
        cmb_MODIFICAR_MATERIA_BAJA.Text = ""
        cmb_MODIFICAR_MATERIA_PRIORIDAD.Text = ""
        cmb_MODIFICAR_MATERIA_PREFERENCIA.Text = ""





        conexion.Close()



    End Sub

    Private Sub btn_MODIFICAR_MAT_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_MAT_CANCELAR.Click
        txb_MODI_MATERIA_CARGA.Clear()
        cmb_MODIFICAR_MAT_CODIGO.Text = ""
        txb_MODIFICACIONES_TURNOS_NOMBRE.Clear()
        txb_MODIFICAR_MAT_NOMBRE.Clear()
        cmb_MODIFICAR_MATERIA_BAJA.Text = ""
        cmb_MODIFICAR_MATERIA_PRIORIDAD.Text = ""
        cmb_MODIFICAR_MATERIA_PREFERENCIA.Text = ""
        ep_VACIOS.Clear()

    End Sub

    Private Sub btn_MODIFICAR_GRUPO_MODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_GRUPO_MODIFICAR.Click

        cmb_MODI_GRUPO_CARRERA.Items.Clear()

        Try

            conexion.Open()

            If Me.ValidateChildren And cmb_MODIFICAR_GRUPO_CODIGO.Text <> String.Empty Then



                datr.Close()
                llenar.Connection = conexion
                llenar.CommandText = "Select cod_grupo from grupo where descripcion= '" & cmb_MODIFICAR_GRUPO_CODIGO.Text & "'"
                codigo = llenar.ExecuteScalar
                ' MsgBox(codigo)


                datr.Close()


                Dim codicarrera As Integer
                Dim nomcarrera As String



                llenar.Connection = conexion
                llenar.CommandText = "Select * from grupo where cod_grupo = " & codigo
                datr = llenar.ExecuteReader
                'MsgBox(codigo)
                datr.Read()
                txb_MODIFICAR_GRUPO_DESCRIPCION.Text = datr.GetValue(1).ToString
                codicarrera = datr.GetValue(3)
                nud_MODIFICAR_GRUPO_CANTIDAD.Value = datr.GetValue(2)
                cmb_MODIFICAR_GRUPO_BAJA.Text = datr.GetValue(4).ToString

                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "Select nombre from carrera where cod_carrera = '" & codicarrera & "'"
                nomcarrera = llenar.ExecuteScalar


                cmb_MODI_GRUPO_CARRERA.Text = nomcarrera
                datr.Close()



                llenar.Connection = conexion
                llenar.CommandText = "Select * from carrera"
                datr = llenar.ExecuteReader

                While datr.Read
                    cmb_MODI_GRUPO_CARRERA.Items.Add(datr.GetValue(1).ToString)

                End While
                datr.Close()
                '((datr.GetValue(0).ToString) & " - " &
            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btn_MODIFICAR_GRUPO_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_GRUPO_GUARDAR.Click


        conexion.Open()
        Try

            If Me.ValidateChildren And cmb_MODIFICAR_GRUPO_BAJA.Text <> String.Empty And cmb_MODI_GRUPO_CARRERA.Text <> String.Empty And txb_MODIFICAR_GRUPO_DESCRIPCION.Text <> String.Empty And nud_MODIFICAR_GRUPO_CANTIDAD.Value <> 0 Then

                codigo = Nothing


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_carrera from carrera where nombre = '" & cmb_MODI_GRUPO_CARRERA.Text & "'"
                nom = llenar.ExecuteScalar



                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "Select cod_grupo from grupo where descripcion = '" & cmb_MODIFICAR_GRUPO_CODIGO.Text & "'"
                codigo = llenar.ExecuteScalar



                datr.Close()


                Dim ta As String = "grupo"
                Dim at As String = "descripcion,cod_carrera,cantidad,baja"
                Dim ins As String = "'" & txb_MODIFICAR_GRUPO_DESCRIPCION.Text & "', " & nom & "," & nud_MODIFICAR_GRUPO_CANTIDAD.Value & ",'" & cmb_MODIFICAR_GRUPO_BAJA.Text & "'"
                Dim fila As String = "cod_grupo"
                Dim clave As String = "" & codigo & ""



                modificaciones(ta, at, ins, fila, clave)

                MessageBox.Show("Grupo Modificado", "Modificacion de Grupo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                conexion.Open()

                Try
                    '  Guardar en historial - MODIFICACION-GRUPO
                    Dim descripcion As String
                    descripcion = "Modificacion de grupo:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_MODIFICAR_GRUPO_CODIGO.Text & " ','Modificacion')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                txb_MODIFICAR_GRUPO_DESCRIPCION.Clear()
                nud_MODIFICAR_GRUPO_CANTIDAD.Value = Nothing
                cmb_MODI_GRUPO_CARRERA.Text = Nothing
                cmb_MODIFICAR_GRUPO_CODIGO.Text = ""
                cmb_MODIFICAR_GRUPO_BAJA.Text = ""


                'End If



            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Grupo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



        Catch ex As OdbcException
            MsgBox(ex.Message)

        End Try

        datr.Close()



        conexion.Open()

        llenar.Connection = conexion
        llenar.CommandText = "Select * from grupo"
        datr = llenar.ExecuteReader

        While datr.Read
            cmb_MODIFICAR_GRUPO_CODIGO.Items.Add(datr.GetValue(1).ToString)
        End While

        datr.Close()



       

        cmb_MODIFICAR_GRUPO_CODIGO.Items.Clear()

        conexion.Close()


    End Sub

    Private Sub btn_MODIFICAR_GRUPO_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_GRUPO_CANCELAR.Click
        cmb_MODIFICAR_GRUPO_CODIGO.Text = ""
        txb_MODIFICAR_GRUPO_DESCRIPCION.Clear()
        nud_MODIFICAR_GRUPO_CANTIDAD.Value = Nothing
        cmb_MODI_GRUPO_CARRERA.Text = Nothing
        cmb_MODIFICAR_GRUPO_BAJA.Text = ""
        ep_VACIOS.Clear()

    End Sub

    Private Sub btn_MODIFICAR_SALON_MODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_SALON_MODIFICAR.Click
        Try

            conexion.Open()

            If Me.ValidateChildren And cmb_MODIFICAR_SALON_CODIGO.Text <> String.Empty Then


                nom = Nothing
                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_salon from salon where descripcion= '" & Split(cmb_MODIFICAR_SALON_CODIGO.Text, " ")(0) & "'"
                nom = llenar.ExecuteScalar

                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select * from salon where cod_salon = " & nom
                datr = llenar.ExecuteReader

                datr.Read()
                txb_MODIFICAR_SALON_DESCRIPCION.Text = datr.GetValue(1).ToString
                nud_MODIFICAR_SALON_CAPACIDAD.Value = datr.GetValue(3)
                cmb_MODIFICAR_SALON_BAJA.Text = datr.GetValue(4).ToString
                cmb_MODIFICAR_SALON_TIPO.Text = datr.GetValue(2).ToString

                datr.Close()

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Salon", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub btn_MODIFICAR_SALON_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_SALON_GUARDAR.Click
        conexion.Open()
        Try

            If Me.ValidateChildren And cmb_MODIFICAR_SALON_CODIGO.Text <> String.Empty Then

                nom = Nothing
                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_salon from salon where descripcion = '" & cmb_MODIFICAR_SALON_CODIGO.Text & "'"
                nom = llenar.ExecuteScalar


                datr.Close()



                Dim ta As String = "salon"
                Dim at As String = "descripcion,capacidad,tipo,baja"
                Dim ins As String = "'" & txb_MODIFICAR_SALON_DESCRIPCION.Text & "'," & nud_MODIFICAR_SALON_CAPACIDAD.Value & ",'" & cmb_MODIFICAR_SALON_TIPO.Text & "','" & cmb_MODIFICAR_SALON_BAJA.Text & "'"
                Dim fila As String = "cod_salon"
                Dim clave As String = "" & nom & ""



                modificaciones(ta, at, ins, fila, clave)

                MessageBox.Show("Salon modificado", "Modificacion de Salon", MessageBoxButtons.OK, MessageBoxIcon.Information)

                conexion.Open()
                Try
                    '  Guardar en historial - MODIFICACION-SALON
                    Dim descripcion As String
                    descripcion = "Modificacion de salon:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_MODIFICAR_SALON_CODIGO.Text & " ','Modificacion')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                conexion.Open()

                cmb_MODIFICAR_SALON_CODIGO.Text = ""
                txb_MODIFICAR_SALON_DESCRIPCION.Clear()
                nud_MODIFICAR_SALON_CAPACIDAD.Value = Nothing
                cmb_MODIFICAR_SALON_BAJA.Text = ""
                cmb_MODIFICAR_SALON_TIPO.Text = ""

                ep_VACIOS.Clear()

                conexion.Close()

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Salon", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As OdbcException
            MsgBox(ex.Message)
            conexion.Close()
        End Try

        datr.Close()



        cmb_MODIFICAR_SALON_CODIGO.Items.Clear()



        llenar.Connection = conexion
        llenar.CommandText = "Select * from salon"
        conexion.Open()

        datr = llenar.ExecuteReader

        While datr.Read
            cmb_MODIFICAR_SALON_CODIGO.Items.Add((datr.GetValue(1).ToString) & " " & (datr.GetValue(2).ToString))
        End While

        datr.Close()
        conexion.Close()

    End Sub

    Private Sub btn_MODIFICAR_SALON_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_SALON_CANCELAR.Click
        cmb_MODIFICAR_SALON_CODIGO.Text = ""
        txb_MODIFICAR_SALON_DESCRIPCION.Clear()
        nud_MODIFICAR_SALON_CAPACIDAD.Value = Nothing
        cmb_MODIFICAR_SALON_BAJA.Text = ""
        cmb_MODIFICAR_SALON_TIPO.Text = ""
        ep_VACIOS.Clear()

    End Sub

    Private Sub btn_MODIFICACIONES_CARRERA_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICACIONES_CARRERA_BUSCAR.Click
        Try
            conexion.Open()

            If Me.ValidateChildren And cmb_MODIFICACIONES_CARRERA_CODIGO.Text <> String.Empty Then

                nom = Nothing

                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_carrera from carrera where nombre = '" & cmb_MODIFICACIONES_CARRERA_CODIGO.Text & "'"
                nom = llenar.ExecuteScalar


                datr.Close()





                llenar.Connection = conexion
                llenar.CommandText = "Select * from carrera where cod_carrera = " & nom
                datr = llenar.ExecuteReader

                datr.Read()
                txb_MODIFICACIONES_CARRERA_NOMBRE.Text = datr.GetValue(1).ToString
                cmb_MODIFICAR_CARRERA_BAJA.Text = datr.GetValue(2).ToString


                datr.Close()
            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Carrera", MessageBoxButtons.OK, MessageBoxIcon.Error)

                conexion.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'conexion = New OdbcConnection(stringconexion)
        'cm.Connection = conexion
        'conexion.ConnectionString = stringconexion
        'conexion.Open()


        'llenar.Connection = conexion
        'llenar.CommandText = "Select * from carrera where cod_carrera = " & txb_MODIFICACIONES_CARRERA_CODIGO.Text
        'datr = llenar.ExecuteReader

        'datr.Read()
        'txb_MODIFICACIONES_CARRERA_NOMBRE.Text = datr.GetValue(1).ToString


        'datr.Close()

        ep_VACIOS.Clear()


    End Sub

    Private Sub btn_MODIFICACIONES_CARRERA_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICACIONES_CARRERA_GUARDAR.Click
        conexion.Open()
        Try
            If Me.ValidateChildren And cmb_MODIFICACIONES_CARRERA_CODIGO.Text <> String.Empty And cmb_MODIFICAR_CARRERA_BAJA.Text <> String.Empty And txb_MODIFICACIONES_CARRERA_NOMBRE.Text <> String.Empty Then
                

                nom = Nothing
                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_carrera from carrera where nombre = '" & cmb_MODIFICACIONES_CARRERA_CODIGO.Text & "'"
                nom = llenar.ExecuteScalar


                datr.Close()

                Dim ta As String = "carrera"
                Dim at As String = "nombre,baja"
                Dim ins As String = "'" & txb_MODIFICACIONES_CARRERA_NOMBRE.Text & "','" & cmb_MODIFICAR_CARRERA_BAJA.Text & "'"
                Dim fila As String = "cod_carrera"
                Dim clave As String = "" & nom & ""



                modificaciones(ta, at, ins, fila, clave)

                MessageBox.Show("Carrera modificacda", "Modificacion de Carrera", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conexion.Open()
                Try
                    '  Guardar en historial - MODIFICACION-TURNO
                    Dim descripcion As String
                    descripcion = "Modificacion de carrera:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_MODIFICACIONES_CARRERA_CODIGO.Text & " ','Modificacion')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conexion.Open()
                cmb_MODIFICACIONES_CARRERA_CODIGO.Text = ""
                txb_MODIFICACIONES_CARRERA_NOMBRE.Clear()
                cmb_MODIFICAR_CARRERA_BAJA.Text = ""
                ep_VACIOS.Clear()

                'End If
                conexion.Close()
            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Carrera", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If


        Catch ex As OdbcException
            MsgBox(ex.Message)
            conexion.Close()
        End Try

        datr.Close()



        cmb_MODIFICACIONES_CARRERA_CODIGO.Items.Clear()

        conexion.Open()

        llenar.Connection = conexion
        llenar.CommandText = "Select * from carrera"
        datr = llenar.ExecuteReader

        While datr.Read
            cmb_MODIFICACIONES_CARRERA_CODIGO.Items.Add(datr.GetValue(1).ToString)
        End While

        datr.Close()

        conexion.Close()

    End Sub

    Private Sub btn_MODIFICACIONES_CARRERA_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICACIONES_CARRERA_CANCELAR.Click
        cmb_MODIFICACIONES_CARRERA_CODIGO.Text = ""
        txb_MODIFICACIONES_CARRERA_NOMBRE.Clear()
        cmb_MODIFICAR_CARRERA_BAJA.Text = ""
        ep_VACIOS.Clear()
    End Sub

    Private Sub tbp_MODIFICAR_USU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_MODIFICAR_USU.Click

    End Sub

    Private Sub cmb_BAJAS_HORA_DESACTIVAR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_BAJAS_HORA_DESACTIVAR.SelectedIndexChanged

    End Sub

    Private Sub tbp_MODIFICAR_GRUPO_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp_MODIFICAR_GRUPO.GotFocus



    End Sub

    Private Sub cmb_MODIFICAR_GRUPO_CODIGO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_MODIFICAR_GRUPO_CODIGO.SelectedIndexChanged


    End Sub

    Private Sub btn_MODIFICACIONES_TURNOS_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICACIONES_TURNOS_BUSCAR.Click
        Try
            conexion.Open()


            If Me.ValidateChildren And cmb_MODIFICACIONES_TURNOS_CODIGO.Text <> String.Empty Then

                nom = Nothing
                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_turno from turno where nombre = '" & cmb_MODIFICACIONES_TURNOS_CODIGO.Text & "'"
                nom = llenar.ExecuteScalar
                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "Select * from turno where cod_turno = " & nom
                datr = llenar.ExecuteReader

                datr.Read()
                txb_MODIFICACIONES_TURNOS_NOMBRE.Text = datr.GetValue(1).ToString
                cmb_MODIFICAR_TURNOS_BAJA.Text = datr.GetValue(2).ToString

                datr.Close()
            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Turnos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btn_MODIFICACIONES_TURNOS_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICACIONES_TURNOS_GUARDAR.Click
        conexion.Open()
        Try


            If Me.ValidateChildren And cmb_MODIFICAR_TURNOS_BAJA.Text <> String.Empty And txb_MODIFICACIONES_TURNOS_NOMBRE.Text <> String.Empty Then

                nom = Nothing
                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_turno from turno where nombre = '" & cmb_MODIFICACIONES_TURNOS_CODIGO.Text & "'"
                nom = llenar.ExecuteScalar


                datr.Close()

                Dim ta As String = "turno"
                Dim at As String = "nombre,baja"
                Dim ins As String = "'" & txb_MODIFICACIONES_TURNOS_NOMBRE.Text & "','" & cmb_MODIFICAR_TURNOS_BAJA.Text & "'"
                Dim fila As String = "cod_turno"
                Dim clave As String = "" & nom & ""



                modificaciones(ta, at, ins, fila, clave)

                MessageBox.Show("Turno modificado", "Modificacion de Turnos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conexion.Open()
                Try
                    '  Guardar en historial - MODIFICACION-TURNO
                    Dim descripcion As String
                    descripcion = "Modificacion de turno:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_MODIFICACIONES_TURNOS_CODIGO.Text & " ','Modificacion')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conexion.Open()
                cmb_MODIFICACIONES_TURNOS_CODIGO.Text = ""
                txb_MODIFICACIONES_TURNOS_NOMBRE.Clear()
                cmb_MODIFICAR_TURNOS_BAJA.Text = ""
                ep_VACIOS.Clear()

                conexion.Close()

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Turnos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As OdbcException
            MsgBox(ex.Message)

        End Try

        datr.Close()

        cmb_MODIFICACIONES_TURNOS_CODIGO.Items.Clear()

        conexion.Open()

        llenar.Connection = conexion
        llenar.CommandText = "Select * from turno"
        datr = llenar.ExecuteReader

        While datr.Read
            cmb_MODIFICACIONES_TURNOS_CODIGO.Items.Add(datr.GetValue(1).ToString)
        End While

        datr.Close()

        conexion.Close()

    End Sub

    Private Sub btn_MODIFICACIONES_TURNOS_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICACIONES_TURNOS_CANCELAR.Click
        cmb_MODIFICACIONES_TURNOS_CODIGO.Text = ""
        txb_MODIFICACIONES_TURNOS_NOMBRE.Clear()
        cmb_MODIFICAR_TURNOS_BAJA.Text = ""
    End Sub

    Private Sub btn_MODIFICAR_HORA_MODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_HORA_MODIFICAR.Click
        Try
            cmb_MODIFICAR_HORA_BAJA.Text = ""
            'cmb_MODIFICAR_HORA_DIA.Text = ""
            'cmb_MODIFICAR_HORA_TURNO.Text = ""
            txb_MODIFICAR_HORA_HORAFIN.Text = ""
            txb_MODIFICAR_HORA_HORAINI.Text = ""
            cmb_MODIFICACIONES_HORA_NUMERO.Text = ""
            ltb_MODIFICAR_HORA_HORARIOS.Items.Clear()
            conexion.Open()


            If Me.ValidateChildren And cmb_MODIFICAR_HORA_DIA.Text <> String.Empty And cmb_MODIFICAR_HORA_TURNO.Text <> String.Empty Then



                conexion = New OdbcConnection(stringconexion)
                cm.Connection = conexion
                conexion.ConnectionString = stringconexion
                conexion.Open()

                nom = Nothing

                llenar.Connection = conexion
                llenar.CommandText = "Select cod_turno from turno where nombre='" & cmb_MODIFICAR_HORA_TURNO.Text & "'"
                nom = llenar.ExecuteScalar



                datr.Close()
                llenar.Connection = conexion
                llenar.CommandText = "Select * from horario where dia='" & cmb_MODIFICAR_HORA_DIA.Text & "' and cod_turno=" & nom
                datr = llenar.ExecuteReader

                While datr.Read
                    ltb_MODIFICAR_HORA_HORARIOS.Items.Add((datr.GetValue(4).ToString) & " hasta " & (datr.GetValue(5).ToString))


                End While
                datr.Close()

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ltb_MODIFICAR_HORA_HORARIOS_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ltb_MODIFICAR_HORA_HORARIOS.MouseDoubleClick

    End Sub

    Private Sub ltb_MODIFICAR_HORA_HORARIOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltb_MODIFICAR_HORA_HORARIOS.SelectedIndexChanged

    End Sub

    Private Sub btn_MODIFICAR_HORA_AGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_HORA_AGREGAR.Click
        'MsgBox(Mid(ltb_MODIFICAR_HORA_HORARIOS.SelectedItem.ToString, 1, 5))

        Try
            conexion.Open()

            If Me.ValidateChildren And ltb_MODIFICAR_HORA_HORARIOS.SelectedItem <> Nothing Then
                datr.Close()

                'ComboBoxStyle.DropDown(cmb_MODIFICACIONES_HORA_NUMERO)

                llenar.Connection = conexion
                llenar.CommandText = "Select hora_inicio,hora_fin,baja,numero_hora from horario where hora_inicio = '" & Mid(ltb_MODIFICAR_HORA_HORARIOS.SelectedItem.ToString, 1, 5) & "' and dia ='" & cmb_MODIFICAR_HORA_DIA.Text & "'"
                datr = llenar.ExecuteReader

                datr.Read()
                txb_MODIFICAR_HORA_HORAINI.Text = datr.GetValue(0).ToString
                txb_MODIFICAR_HORA_HORAFIN.Text = datr.GetValue(1).ToString
                cmb_MODIFICAR_HORA_BAJA.Text = datr.GetValue(2).ToString
                'txb_MODIFICACIONES_HORA_NUMERO.Text = datr.GetValue(3).ToString
                cmb_MODIFICACIONES_HORA_NUMERO.Text = datr.GetValue(3).ToString



                datr.Close()

                'MsgBox(Mid(ltb_MODIFICAR_HORA_HORARIOS.SelectedItem.ToString, 1, 5))
            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_MODIFICAR_HORA_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_HORA_GUARDAR.Click
        Try


            conexion.Open()
            If Me.ValidateChildren And cmb_MODIFICAR_HORA_BAJA.Text <> String.Empty And cmb_MODIFICACIONES_HORA_NUMERO.Text <> String.Empty And txb_MODIFICAR_HORA_HORAINI.Text <> String.Empty And txb_MODIFICAR_HORA_HORAFIN.Text <> String.Empty Then




                nom = Nothing
                codigo = Nothing
                llenar.Connection = conexion
                llenar.CommandText = "Select cod_turno from turno where nombre='" & cmb_MODIFICAR_HORA_TURNO.Text & "'"
                nom = llenar.ExecuteScalar

                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "Select cod_horario from horario where cod_turno=" & nom & " and dia='" & cmb_MODIFICAR_HORA_DIA.Text & "' and hora_inicio='" & Mid(ltb_MODIFICAR_HORA_HORARIOS.SelectedItem.ToString, 1, 5) & "'"
                codigo = llenar.ExecuteScalar

                datr.Close()

                Dim ta As String = "horario"
                Dim at As String = "numero_hora,hora_inicio,hora_fin,baja"
                Dim ins As String = "'" & cmb_MODIFICACIONES_HORA_NUMERO.Text & "','" & txb_MODIFICAR_HORA_HORAINI.Text & "','" & txb_MODIFICAR_HORA_HORAFIN.Text & "','" & cmb_MODIFICAR_HORA_BAJA.Text & "'"
                Dim fila As String = "cod_horario"
                Dim clave As String = "" & codigo & ""



                modificaciones(ta, at, ins, fila, clave)

                MessageBox.Show("Horario Modificado", "Modificacion de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Information)


              

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificacion de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            '  Guardar en historial - MODIFICACION-HORARIO
            Dim descripcion As String
            descripcion = "Modificacion de horario:"
            Dim tab As String = "historial"
            Dim atr As String = "ci,fecha,hora,descripcion,accion"
            Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " Dia: " & cmb_MODIFICAR_HORA_DIA.Text & " - Turno: " & cmb_MODIFICAR_HORA_TURNO.Text & " ','Modificacion')"
            inshistorial(tab, atr, inser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cmb_MODIFICAR_HORA_BAJA.Text = ""
        cmb_MODIFICAR_HORA_DIA.Text = ""
        cmb_MODIFICAR_HORA_TURNO.Text = ""
        txb_MODIFICAR_HORA_HORAFIN.Text = ""
        txb_MODIFICAR_HORA_HORAINI.Text = ""
        cmb_MODIFICACIONES_HORA_NUMERO.Text = ""
        ltb_MODIFICAR_HORA_HORARIOS.Items.Clear()
        cmb_MODIFICAR_HORA_BAJA.Text = ""

    End Sub

    Private Sub btn_ALTAS_HORA_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_HORA_CANCELAR.Click
        cmb_ALTAS_HORARIO_NUMEROHORA.Text = ""
        dtp_ALTAS_HORARIO_FIN.Text = "00:00"
        dtp_ALTAS_HORARIO_INICIO.Text = "00:00"
        cmb_ALTAS_HORA_TURNO.Text = ""
        cmb_ALTAS_HORA_DIA.Text = ""

    End Sub


    Private Sub tbp_ALTAS_HORA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp_ALTAS_HORA.Leave

        cmb_ALTAS_HORARIO_NUMEROHORA.Text = ""
        dtp_ALTAS_HORARIO_FIN.Text = "00:00"
        dtp_ALTAS_HORARIO_INICIO.Text = "00:00"
        cmb_ALTAS_HORA_TURNO.Text = ""
        cmb_ALTAS_HORA_DIA.Text = ""
    End Sub

    Private Sub btn_ALTAS_GRUPO_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_GRUPO_CANCELAR.Click
        txb_ALTAS_GRUPOS_DESCRIPCION.Clear()
        nud_ALTAS_GRUPO_CANTIDAD.Value = 0
        cmb_ALTAS_GRUPO_CARRERA.Text = ""
        ep_VACIOS2.Clear()
        ep_VACIOS.Clear()
    End Sub

    Private Sub tbp_ALTAS_GRUPO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp_ALTAS_GRUPO.Leave
        txb_ALTAS_GRUPOS_DESCRIPCION.Clear()
        nud_ALTAS_GRUPO_CANTIDAD.Value = 0
        cmb_ALTAS_GRUPO_CARRERA.Text = ""

        ep_VACIOS.Clear()
        ep_VACIOS2.Clear()
        ep_VACIOS3.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_BAJAS_HORA_DESACTIVAR_DIA.SelectedIndexChanged
        Try


            cmb_BAJAS_HORA_DESACTIVAR.Items.Clear()
            conexion.Open()

            llenar.Connection = conexion
            llenar.CommandText = "Select cod_turno from turno where nombre= '" & cmb_BAJAS_HORA_DESACTIVAR_TURNO.Text & "'"
            nom = llenar.ExecuteScalar

            datr.Close()


            llenar.Connection = conexion

            llenar.CommandText = "Select hora_inicio, hora_fin from horario where cod_turno = " & nom & " and baja='no' and dia='" & cmb_BAJAS_HORA_DESACTIVAR_DIA.Text & "'"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_HORA_DESACTIVAR.Items.Add((datr.GetValue(0).ToString) & " hasta " & (datr.GetValue(1).ToString))
            End While
            datr.Close()

            cmb_BAJAS_HORA_DESACTIVAR.Enabled = True

            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cmb_BAJAS_HORA_BORRAR_TURNO_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_BAJAS_HORA_BORRAR_TURNO.SelectedIndexChanged
        cmb_BAJAS_HORA_BORRAR_DIA.Enabled = True
    End Sub

    Private Sub cmb_BAJAS_HORA_BORRAR_DIA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_BAJAS_HORA_BORRAR_DIA.SelectedIndexChanged

        Try


            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion

            conexion.Open()

            nom = Nothing
            cmb_BAJAS_HORA_BORRAR.Items.Clear()

            llenar.Connection = conexion
            llenar.CommandText = "Select cod_turno from turno where nombre= '" & cmb_BAJAS_HORA_BORRAR_TURNO.Text & "'"
            nom = llenar.ExecuteScalar

            datr.Close()




            llenar.Connection = conexion

            llenar.CommandText = "Select hora_inicio, hora_fin from horario where cod_turno = " & nom & " and dia='" & cmb_BAJAS_HORA_BORRAR_DIA.Text & "'"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_BAJAS_HORA_BORRAR.Items.Add((datr.GetValue(0).ToString) & " hasta " & (datr.GetValue(1).ToString))
            End While
            datr.Close()

            cmb_BAJAS_HORA_BORRAR.Enabled = True

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btn_BAJAS_HORA_BORRAR_BORRARSIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_HORA_BORRAR_BORRARSIS.Click
        Try
            conexion.Open()


            If Me.ValidateChildren And cmb_BAJAS_HORA_BORRAR_DIA.Text <> String.Empty And cmb_BAJAS_HORA_BORRAR_TURNO.Text <> String.Empty And cmb_BAJAS_HORA_BORRAR.Text <> String.Empty Then

                codigo = Nothing
                nom = Nothing


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_turno from turno where nombre= '" & cmb_BAJAS_HORA_BORRAR_TURNO.Text & "'"
                codigo = llenar.ExecuteScalar

                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_horario from horario where hora_inicio= '" & Mid(cmb_BAJAS_HORA_BORRAR.Text, 1, 5) & "' and dia='" & cmb_BAJAS_HORA_BORRAR_DIA.Text & "' and cod_turno='" & codigo & "'"
                nom = llenar.ExecuteScalar

                datr.Close()

                Dim ta As String = "horario"
                Dim co As String = "cod_horario"
                Dim re As String = "'" & nom & "'"

                borrar(ta, co, re)

                MessageBox.Show("Horario borrado", "Bajas de Horario", MessageBoxButtons.OK, MessageBoxIcon.Information)

                conexion.Open()

                Try
                    '  Guardar en historial - BAJA - BORRAR-HORARIO
                    Dim descripcion As String
                    descripcion = "Borro la hora:"
                    Dim tab As String = "historial"
                    Dim atr As String = "ci,fecha,hora,descripcion,accion"
                    Dim inser As String = "('" & Modulos.user & "','11/25/2016','" & hora & ":" & min & " ','" & descripcion & " " & cmb_BAJAS_HORA_BORRAR.Text & " Dia: " & cmb_BAJAS_HORA_BORRAR_DIA.Text & " Turno: " & cmb_BAJAS_HORA_BORRAR_TURNO.Text & "','Baja')"
                    inshistorial(tab, atr, inser)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try





                cmb_BAJAS_HORA_BORRAR_TURNO.Text = ""
                cmb_BAJAS_HORA_BORRAR_DIA.Text = ""
                cmb_BAJAS_HORA_BORRAR.Text = ""

                cmb_BAJAS_HORA_BORRAR_DIA.Enabled = False
                cmb_BAJAS_HORA_BORRAR.Enabled = False

            Else
                MessageBox.Show("Ingrese los datos requeridos", "Bajas de Horario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_MODIFICAR_HORA_BAJA.SelectedIndexChanged

    End Sub

    Private Sub btn_MODIFICAR_HORA_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_HORA_CANCELAR.Click
        cmb_MODIFICAR_HORA_BAJA.Text = ""
        cmb_MODIFICAR_HORA_DIA.Text = ""
        cmb_MODIFICAR_HORA_TURNO.Text = ""
        txb_MODIFICAR_HORA_HORAFIN.Text = ""
        txb_MODIFICAR_HORA_HORAINI.Text = ""
        cmb_MODIFICACIONES_HORA_NUMERO.Text = ""
        ltb_MODIFICAR_HORA_HORARIOS.Items.Clear()
    End Sub

    Private Sub txb_ALTAS_USU_CI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_ALTAS_USU_CI.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If

    End Sub


    Private Sub txb_ALTAS_USU_NOMBRE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_ALTAS_USU_NOMBRE.KeyPress

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

    Private Sub txb_ALTAS_USU_APELLIDO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_ALTAS_USU_APELLIDO.KeyPress

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


    Private Sub txb_ALTAS_USU_CI2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_ALTAS_USU_CI2.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If

    End Sub

    Private Sub txb_ALTAS_USU_TELEFONO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_ALTAS_USU_TELEFONO.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If

    End Sub

    Private Sub txb_ALTAS_USU_CELULAR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_ALTAS_USU_CELULAR.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txb_ALTAS_USU_CI2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txb_ALTAS_USU_CI2.Leave
        Try


            If Verificar(txb_ALTAS_USU_CI.Text, txb_ALTAS_USU_CI2.Text) = 1 Then

                'MsgBox("Cedula correcta")

            Else
                MsgBox("La cedula es invalida")
                'ErrorProvider1.SetError(txt_Veri, "Cedula incorrecta"

                txb_ALTAS_USU_APELLIDO.Clear()
                txb_ALTAS_USU_CELULAR.Clear()
                txb_ALTAS_USU_CI.Clear()
                txb_ALTAS_USU_CI2.Clear()
                txb_ALTAS_USU_NOMBRE.Clear()
                txb_ALTAS_USUARIOS_CONTRASEÑA.Clear()
                txb_ALTAS_USU_TELEFONO.Clear()
                lbl_ALTAS_USU_MATERIA.Visible = False
                clb_ALTAS_USU_MATERIA.Visible = False
                cmb_ALTAS_USU_TIPOUSU.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_MODIFICAR_USU_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MODIFICAR_USU_CANCELAR.Click

    End Sub

    Private Sub cmb_MODIFICAR_USU_TIPOUSU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_MODIFICAR_USU_TIPOUSU.SelectedIndexChanged
        If cmb_MODIFICAR_USU_TIPOUSU.Text = "Profesor" Then
            clb_MODIFICAR_USU_MATERIA.Visible = True

        Else
            clb_MODIFICAR_USU_MATERIA.Visible = False
            lbl_MODIFICAR_USU_MATERIA.Visible = False


        End If
    End Sub

    Private Sub txb_MODI_MATERIA_CARGA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txb_MODI_MATERIA_CARGA_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_MODI_MATERIA_CARGA.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub nud_ALTAS_MAT_CARGA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nud_ALTAS_MAT_CARGA.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txb_ALTAS_MAT_NOMBRE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_ALTAS_MAT_NOMBRE.KeyPress
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

    Private Sub btn_ALTAS_MAT_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_MAT_CANCELAR.Click
        txb_ALTAS_MAT_NOMBRE.Clear()
        nud_ALTAS_MAT_CARGA.Value = 0
        cmb_ALTAS_MAT_PREFERENCIA.Text = ""
        cmb_ALTAS_MAT_PRIORIDAD.Text = ""
    End Sub

    Private Sub txb_ALTAS_GRUPOS_DESCRIPCION_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_ALTAS_GRUPOS_DESCRIPCION.KeyPress
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

    Private Sub nud_ALTAS_GRUPO_CANTIDAD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nud_ALTAS_GRUPO_CANTIDAD.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If

    End Sub

    Private Sub btn_ALTAS_USU_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_USU_CANCELAR.Click
        txb_ALTAS_USU_APELLIDO.Clear()
        txb_ALTAS_USU_CELULAR.Clear()
        txb_ALTAS_USU_CI.Clear()
        txb_ALTAS_USU_CI2.Clear()
        txb_ALTAS_USU_NOMBRE.Clear()
        txb_ALTAS_USUARIOS_CONTRASEÑA.Clear()
        txb_ALTAS_USU_TELEFONO.Clear()
        lbl_ALTAS_USU_MATERIA.Visible = False
        clb_ALTAS_USU_MATERIA.Visible = False
        cmb_ALTAS_USU_TIPOUSU.Text = ""
    End Sub

    Private Sub btn_ALTAS_USU_CANCELAR_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_USU_CANCELAR.Leave
        txb_ALTAS_USU_APELLIDO.Clear()
        txb_ALTAS_USU_CELULAR.Clear()
        txb_ALTAS_USU_CI.Clear()
        txb_ALTAS_USU_CI2.Clear()
        txb_ALTAS_USU_NOMBRE.Clear()
        txb_ALTAS_USUARIOS_CONTRASEÑA.Clear()
        txb_ALTAS_USU_TELEFONO.Clear()
        lbl_ALTAS_USU_MATERIA.Visible = False
        clb_ALTAS_USU_MATERIA.Visible = False
        cmb_ALTAS_USU_TIPOUSU.Text = ""
    End Sub

    Private Sub btn_ALTAS_MAT_CANCELAR_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_MAT_CANCELAR.Leave
        txb_ALTAS_MAT_NOMBRE.Clear()
        nud_ALTAS_MAT_CARGA.Value = 0
    End Sub

    Private Sub txb_ALTAS_SALON_DESCRIPCION_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_ALTAS_SALON_DESCRIPCION.KeyPress
        'If Char.IsLetter(e.KeyChar) Then
        '    e.Handled = False

        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsSeparator(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If
    End Sub

    Private Sub nud_ALTAS_SALON_CAPACIDAD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nud_ALTAS_SALON_CAPACIDAD.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If

    End Sub

    Private Sub btn_ALTAS_SALON_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_SALON_CANCELAR.Click
        txb_ALTAS_SALON_DESCRIPCION.Clear()
        nud_ALTAS_SALON_CAPACIDAD.Value = 0
        cmb_ALTAS_SALON_TIPO.Text = ""
    End Sub

    Private Sub txb_ALTAS_TURNOS_NOMBRE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_ALTAS_TURNOS_NOMBRE.KeyPress

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

    Private Sub btn_ALTAS_TURNOS_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_TURNOS_CANCELAR.Click
        txb_ALTAS_TURNOS_NOMBRE.Clear()
    End Sub

    Private Sub txb_MODIFICAR_USU_NOMBRE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_MODIFICAR_USU_NOMBRE.KeyPress
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

    Private Sub txb_MODIFICAR_USU_APELLIDO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_MODIFICAR_USU_APELLIDO.KeyPress
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

    Private Sub txb_MODIFICAR_USU_CI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_MODIFICAR_USU_CI.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txb_MODIFICAR_USU_CI2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_MODIFICAR_USU_CI2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txb_MODIFICAR_USU_TELEFONO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_MODIFICAR_USU_TELEFONO.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txb_MODI_USU_CELULAR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_MODI_USU_CELULAR.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub nud_MODIFICAR_GRUPO_CANTIDAD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nud_MODIFICAR_GRUPO_CANTIDAD.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub nud_MODIFICAR_SALON_CAPACIDAD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nud_MODIFICAR_SALON_CAPACIDAD.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txb_MODIFICACIONES_TURNOS_NOMBRE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_MODIFICACIONES_TURNOS_NOMBRE.KeyPress
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

    Private Sub txb_MODIFICACIONES_CARRERA_NOMBRE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_MODIFICACIONES_CARRERA_NOMBRE.KeyPress
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

    Private Sub txb_ALTAS_GRUPOS_DESCRIPCION_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_ALTAS_GRUPOS_DESCRIPCION.Validating

        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese descripcion. Campo obligatorio.")
        End If

    End Sub

    Private Sub cmb_ALTAS_GRUPO_CARRERA_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_ALTAS_GRUPO_CARRERA.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            'Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS2.Clear()
        Else
            Me.ep_VACIOS2.SetError(sender, "Seleccione carrera. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_ALTAS_SALON_DESCRIPCION_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_ALTAS_SALON_DESCRIPCION.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese descripcion. Campo obligatorio.")
        End If
    End Sub

    Private Sub nud_ALTAS_SALON_CAPACIDAD_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles nud_ALTAS_SALON_CAPACIDAD.Validating
        If DirectCast(sender, NumericUpDown).Value = 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS2.SetError(sender, "Ingrese descripcion. Campo obligatorio.")
        Else
            Me.ep_VACIOS2.Clear()

        End If
    End Sub

    Private Sub txb_ALTAS_TURNOS_NOMBRE_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_ALTAS_TURNOS_NOMBRE.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese nombre. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_ALTAS_CARREARA_NOMBRE_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_ALTAS_CARREARA_NOMBRE.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese nombre. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_ALTAS_MAT_NOMBRE_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_ALTAS_MAT_NOMBRE.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese nombre. Campo obligatorio.")
        End If
    End Sub

    Private Sub nud_ALTAS_MAT_CARGA_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles nud_ALTAS_MAT_CARGA.Validating
        If DirectCast(sender, NumericUpDown).Value = 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS2.SetError(sender, "Ingrese carga horaria. Campo obligatorio.")
        Else
            Me.ep_VACIOS2.Clear()

        End If
    End Sub

    Private Sub nud_ALTAS_GRUPO_CANTIDAD_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles nud_ALTAS_GRUPO_CANTIDAD.Validating
        If DirectCast(sender, NumericUpDown).Value = 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS3.SetError(sender, "Ingrese cantidad. Campo obligatorio.")
        Else
            Me.ep_VACIOS3.Clear()

        End If
    End Sub

    Private Sub tbc_ALTAS_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbc_ALTAS.Leave
        ep_VACIOS.Clear()
        ep_VACIOS2.Clear()
        ep_VACIOS3.Clear()
    End Sub

    Private Sub tbp_ALTAS_MAT_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_ALTAS_MAT.Leave
        ep_VACIOS.Clear()
        ep_VACIOS2.Clear()
        ep_VACIOS3.Clear()
    End Sub

    Private Sub tbp_ALTAS_SALON_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_ALTAS_SALON.Leave
        ep_VACIOS.Clear()
        ep_VACIOS2.Clear()
        ep_VACIOS3.Clear()
    End Sub

    Private Sub tbp_ALTAS_TURNOS_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_ALTAS_TURNOS.Leave
        ep_VACIOS.Clear()
        ep_VACIOS2.Clear()
        ep_VACIOS3.Clear()
    End Sub

    Private Sub tbp_ALTAS_CARRERA_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_ALTAS_CARRERA.Leave
        ep_VACIOS.Clear()
        ep_VACIOS2.Clear()
        ep_VACIOS3.Clear()
    End Sub

    Private Sub txb_ALTAS_USU_CI2_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_ALTAS_USU_CI2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese codigo verificador. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_ALTAS_USU_CI_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_ALTAS_USU_CI.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese cedula. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_ALTAS_USUARIOS_CONTRASEÑA_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_ALTAS_USUARIOS_CONTRASEÑA.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese contraseña. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_ALTAS_USU_NOMBRE_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_ALTAS_USU_NOMBRE.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese nombre. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_ALTAS_USU_APELLIDO_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_ALTAS_USU_APELLIDO.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese apellido. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_ALTAS_USU_TELEFONO_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_ALTAS_USU_TELEFONO.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese telefono. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_ALTAS_USU_CELULAR_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_ALTAS_USU_CELULAR.Validating
        'If DirectCast(sender, TextBox).Text.Length > 0 Then
        '    ' Me.ep_VACIOS.SetError(sender, " ")
        '    Me.ep_VACIOS.Clear()
        'Else
        '    Me.ep_VACIOS.SetError(sender, "Ingrese celular. Campo obligatorio.")
        'End If
    End Sub

    Private Sub cmb_ALTAS_USU_TIPOUSU_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_ALTAS_USU_TIPOUSU.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Seleccione tipo. Campo obligatorio.")
        End If
    End Sub

    Private Sub cmb_MODIFICAR_MAT_CODIGO_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_MODIFICAR_MAT_CODIGO.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Seleccione materia. Campo obligatorio.")
        End If
    End Sub

    Private Sub tbp_MODIFICAR_MAT_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_MODIFICAR_MAT.Leave
        txb_MODI_MATERIA_CARGA.Clear()
        cmb_MODIFICAR_MAT_CODIGO.Text = ""
        txb_MODIFICACIONES_TURNOS_NOMBRE.Clear()
        txb_MODIFICAR_MAT_NOMBRE.Clear()
        cmb_MODIFICAR_MATERIA_BAJA.Text = ""
        ep_VACIOS.Clear()
    End Sub

    Private Sub cmb_MODIFICAR_GRUPO_CODIGO_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_MODIFICAR_GRUPO_CODIGO.Leave
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Seleccione grupo. Campo obligatorio.")
        End If
    End Sub

    Private Sub tbp_MODIFICAR_GRUPO_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_MODIFICAR_GRUPO.Leave
        cmb_MODIFICAR_GRUPO_CODIGO.Text = ""
        txb_MODIFICAR_GRUPO_DESCRIPCION.Clear()
        nud_MODIFICAR_GRUPO_CANTIDAD.Value = Nothing
        cmb_MODI_GRUPO_CARRERA.Text = Nothing
        cmb_MODIFICAR_GRUPO_BAJA.Text = ""
        ep_VACIOS.Clear()
    End Sub

    Private Sub cmb_MODIFICAR_SALON_CODIGO_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_MODIFICAR_SALON_CODIGO.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Seleccione salon. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_MODIFICAR_SALON_DESCRIPCION_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_MODIFICAR_SALON_DESCRIPCION.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese descripcion. Campo obligatorio.")
        End If
    End Sub

    Private Sub cmb_MODIFICAR_SALON_BAJA_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_MODIFICAR_SALON_BAJA.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Seleccione opcion. Campo obligatorio.")
        End If
    End Sub

    Private Sub nud_MODIFICAR_SALON_CAPACIDAD_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles nud_MODIFICAR_SALON_CAPACIDAD.Validating
        If DirectCast(sender, NumericUpDown).Value = 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.SetError(sender, "Ingrese cantidad. Campo obligatorio.")
        Else
            Me.ep_VACIOS.Clear()

        End If
    End Sub

    Private Sub cmb_MODIFICACIONES_TURNOS_CODIGO_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_MODIFICACIONES_TURNOS_CODIGO.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Seleccione turno. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_MODIFICACIONES_TURNOS_NOMBRE_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_MODIFICACIONES_TURNOS_NOMBRE.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese nombre. Campo obligatorio.")
        End If
    End Sub

    Private Sub cmb_MODIFICAR_TURNOS_BAJA_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_MODIFICAR_TURNOS_BAJA.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Seleccione opcion. Campo obligatorio.")
        End If
    End Sub

    Private Sub cmb_MODIFICACIONES_CARRERA_CODIGO_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_MODIFICACIONES_CARRERA_CODIGO.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Seleccione carrera. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_MODIFICACIONES_CARRERA_NOMBRE_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_MODIFICACIONES_CARRERA_NOMBRE.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese nombre. Campo obligatorio.")
        End If
    End Sub

    Private Sub cmb_MODIFICAR_CARRERA_BAJA_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_MODIFICAR_CARRERA_BAJA.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Seleccione opcion. Campo obligatorio.")
        End If
    End Sub

    Private Sub cmb_MODIFICAR_MATERIA_BAJA_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_MODIFICAR_MATERIA_BAJA.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Seleccione opcion. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_MODIFICAR_MAT_NOMBRE_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_MODIFICAR_MAT_NOMBRE.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese nombre. Campo obligatorio.")
        End If
    End Sub

    Private Sub txb_MODI_MATERIA_CARGA_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txb_MODI_MATERIA_CARGA.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ' Me.ep_VACIOS.SetError(sender, " ")
            Me.ep_VACIOS.Clear()
        Else
            Me.ep_VACIOS.SetError(sender, "Ingrese carga horaria. Campo obligatorio.")
        End If
    End Sub

    Private Sub tbp_MODIFICAR_HORA_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_MODIFICAR_HORA.Leave
        ep_VACIOS.Clear()
        cmb_MODIFICAR_HORA_BAJA.Text = ""
        cmb_MODIFICAR_HORA_DIA.Text = ""
        cmb_MODIFICAR_HORA_TURNO.Text = ""
        txb_MODIFICAR_HORA_HORAFIN.Text = ""
        txb_MODIFICAR_HORA_HORAINI.Text = ""
        cmb_MODIFICACIONES_HORA_NUMERO.Text = ""
        ltb_MODIFICAR_HORA_HORARIOS.Items.Clear()
    End Sub

    Private Sub tbp_MODIFICAR_SALON_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_MODIFICAR_SALON.Leave
        cmb_MODIFICAR_SALON_CODIGO.Text = ""
        txb_MODIFICAR_SALON_DESCRIPCION.Clear()
        nud_MODIFICAR_SALON_CAPACIDAD.Value = Nothing
        cmb_MODIFICAR_SALON_BAJA.Text = ""
        ep_VACIOS.Clear()
    End Sub

    Private Sub tbp_MODIFICACIONES_TURNOS_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_MODIFICACIONES_TURNOS.Leave
        cmb_MODIFICACIONES_TURNOS_CODIGO.Text = ""
        txb_MODIFICACIONES_TURNOS_NOMBRE.Clear()
        cmb_MODIFICAR_TURNOS_BAJA.Text = ""
        ep_VACIOS.Clear()
    End Sub

    Private Sub tbp_MODIFICACIONES_CARRERA_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_MODIFICACIONES_CARRERA.Leave
        cmb_MODIFICACIONES_CARRERA_CODIGO.Text = ""
        txb_MODIFICACIONES_CARRERA_NOMBRE.Clear()
        cmb_MODIFICAR_CARRERA_BAJA.Text = ""
        ep_VACIOS.Clear()
    End Sub

    Private Sub cmb_ALTAS_HORARIO_NUMEROHORA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ALTAS_HORARIO_NUMEROHORA.SelectedIndexChanged
        Try

            If (cmb_ALTAS_HORA_DIA.Text = "Lunes" Or cmb_ALTAS_HORA_DIA.Text = "Martes" Or cmb_ALTAS_HORA_DIA.Text = "Miercoles" Or cmb_ALTAS_HORA_DIA.Text = "Jueves" Or cmb_ALTAS_HORA_DIA.Text = "Viernes") Then

                If cmb_ALTAS_HORA_TURNO.Text = "Matutino" Then


                    If cmb_ALTAS_HORARIO_NUMEROHORA.Text = "1" Then

                        dtp_ALTAS_HORARIO_INICIO.Text = "07:00"
                        dtp_ALTAS_HORARIO_FIN.Text = "07:45"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "2" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "07:45"
                        dtp_ALTAS_HORARIO_FIN.Text = "08:30"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "3" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "08:30"
                        dtp_ALTAS_HORARIO_FIN.Text = "09:15"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "4" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "09:15"
                        dtp_ALTAS_HORARIO_FIN.Text = "10:00"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "5" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "10:20"
                        dtp_ALTAS_HORARIO_FIN.Text = "11:05"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "6" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "11:05"
                        dtp_ALTAS_HORARIO_FIN.Text = "11:50"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "7" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "11:50"
                        dtp_ALTAS_HORARIO_FIN.Text = "12:35"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "8" Then

                        dtp_ALTAS_HORARIO_INICIO.Text = "00:00"
                        dtp_ALTAS_HORARIO_FIN.Text = "00:00"

                        MessageBox.Show("8a Hora en matutino no existe", "Altas de Horario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                ElseIf cmb_ALTAS_HORA_TURNO.Text = "Vespertino" Then
                    If cmb_ALTAS_HORARIO_NUMEROHORA.Text = "1" Then

                        dtp_ALTAS_HORARIO_INICIO.Text = "12:35"
                        dtp_ALTAS_HORARIO_FIN.Text = "13:20"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "2" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "13:20"
                        dtp_ALTAS_HORARIO_FIN.Text = "14:05"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "3" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "14:05"
                        dtp_ALTAS_HORARIO_FIN.Text = "14:50"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "4" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "14:50"
                        dtp_ALTAS_HORARIO_FIN.Text = "15:35"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "5" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "15:55"
                        dtp_ALTAS_HORARIO_FIN.Text = "16:40"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "6" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "16:40"
                        dtp_ALTAS_HORARIO_FIN.Text = "17:25"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "7" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "17:25"
                        dtp_ALTAS_HORARIO_FIN.Text = "18:10"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "8" Then

                        dtp_ALTAS_HORARIO_INICIO.Text = "18:10"
                        dtp_ALTAS_HORARIO_FIN.Text = "18:55"

                        ' MessageBox.Show("8a en matutino no existe", "Altas de Horario", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                ElseIf cmb_ALTAS_HORA_TURNO.Text = "Nocturno" Then
                    If cmb_ALTAS_HORARIO_NUMEROHORA.Text = "1" Then

                        dtp_ALTAS_HORARIO_INICIO.Text = "18:55"
                        dtp_ALTAS_HORARIO_FIN.Text = "19:35"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "2" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "19:35"
                        dtp_ALTAS_HORARIO_FIN.Text = "20:15"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "3" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "20:15"
                        dtp_ALTAS_HORARIO_FIN.Text = "20:55"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "4" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "21:05"
                        dtp_ALTAS_HORARIO_FIN.Text = "21:45"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "5" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "21:45"
                        dtp_ALTAS_HORARIO_FIN.Text = "22:25"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "6" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "22:25"
                        dtp_ALTAS_HORARIO_FIN.Text = "23:05"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "7" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "23:05"
                        dtp_ALTAS_HORARIO_FIN.Text = "23:45"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "8" Then

                        dtp_ALTAS_HORARIO_INICIO.Text = "00:00"
                        dtp_ALTAS_HORARIO_FIN.Text = "00:00"

                        MessageBox.Show("8a Hora en nocturno no existe", "Altas de Horario", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                End If
            ElseIf cmb_ALTAS_HORA_DIA.Text = "Sabado" Then

                If cmb_ALTAS_HORA_TURNO.Text = "Matutino" Then


                    If cmb_ALTAS_HORARIO_NUMEROHORA.Text = "1" Then

                        dtp_ALTAS_HORARIO_INICIO.Text = "07:00"
                        dtp_ALTAS_HORARIO_FIN.Text = "07:45"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "2" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "07:45"
                        dtp_ALTAS_HORARIO_FIN.Text = "08:30"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "3" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "08:30"
                        dtp_ALTAS_HORARIO_FIN.Text = "09:15"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "4" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "09:15"
                        dtp_ALTAS_HORARIO_FIN.Text = "10:00"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "5a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "10:20"
                        dtp_ALTAS_HORARIO_FIN.Text = "11:05"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "6a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "11:05"
                        dtp_ALTAS_HORARIO_FIN.Text = "11:50"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "7a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "11:50"
                        dtp_ALTAS_HORARIO_FIN.Text = "12:35"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "8a" Then

                        dtp_ALTAS_HORARIO_INICIO.Text = "00:00"
                        dtp_ALTAS_HORARIO_FIN.Text = "00:00"

                        MessageBox.Show("8a Hora en matutino no existe", "Altas de Horario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                ElseIf cmb_ALTAS_HORA_TURNO.Text = "Vespertino" Then
                    If cmb_ALTAS_HORARIO_NUMEROHORA.Text = "1a" Then

                        dtp_ALTAS_HORARIO_INICIO.Text = "12:35"
                        dtp_ALTAS_HORARIO_FIN.Text = "13:20"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "2a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "13:20"
                        dtp_ALTAS_HORARIO_FIN.Text = "14:05"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "3a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "14:05"
                        dtp_ALTAS_HORARIO_FIN.Text = "14:50"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "4a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "14:50"
                        dtp_ALTAS_HORARIO_FIN.Text = "15:35"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "5a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "15:55"
                        dtp_ALTAS_HORARIO_FIN.Text = "16:40"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "6a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "16:40"
                        dtp_ALTAS_HORARIO_FIN.Text = "17:25"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "7a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "17:25"
                        dtp_ALTAS_HORARIO_FIN.Text = "18:10"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "8a" Then

                        dtp_ALTAS_HORARIO_INICIO.Text = "18:10"
                        dtp_ALTAS_HORARIO_FIN.Text = "18:55"

                        ' MessageBox.Show("8a en matutino no existe", "Altas de Horario", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                ElseIf cmb_ALTAS_HORA_TURNO.Text = "Nocturno" Then
                    If cmb_ALTAS_HORARIO_NUMEROHORA.Text = "1a" Then

                        dtp_ALTAS_HORARIO_INICIO.Text = "13:20"
                        dtp_ALTAS_HORARIO_FIN.Text = "14:05"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "2a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "14:05"
                        dtp_ALTAS_HORARIO_FIN.Text = "14:45"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "3a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "14:45"
                        dtp_ALTAS_HORARIO_FIN.Text = "15:25"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "4a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "16:15"
                        dtp_ALTAS_HORARIO_FIN.Text = "16:55"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "5a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "16:55"
                        dtp_ALTAS_HORARIO_FIN.Text = "17:35"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "6a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "17:35"
                        dtp_ALTAS_HORARIO_FIN.Text = "18:15"
                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "7a" Then

                        'dtp_ALTAS_HORARIO_INICIO.Text = ""
                        'dtp_ALTAS_HORARIO_FIN.Text = ""

                        dtp_ALTAS_HORARIO_INICIO.Text = "18:15"
                        dtp_ALTAS_HORARIO_FIN.Text = "18:55"

                    ElseIf cmb_ALTAS_HORARIO_NUMEROHORA.Text = "8a" Then

                        dtp_ALTAS_HORARIO_INICIO.Text = "00:00"
                        dtp_ALTAS_HORARIO_FIN.Text = "00:00"

                        MessageBox.Show("8a Hora en nocturno no existe", "Altas de Horario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

            End If




            'ElseIf (cmb_ALTAS_HORA_DIA.Text = "Lunes" Or cmb_ALTAS_HORA_DIA.Text = "Martes" Or cmb_ALTAS_HORA_DIA.Text = "Miercoles" Or cmb_ALTAS_HORA_DIA.Text = "Jueves" Or cmb_ALTAS_HORA_DIA.Text = "Viernes") Then
            '    If cmb_ALTAS_HORA_TURNO.Text = "Matutino" Then
            '            If
            '        End If
            '    End If

            'ElseIf (cmb_ALTAS_HORA_DIA.Text = "Lunes" Or cmb_ALTAS_HORA_DIA.Text = "Martes" Or cmb_ALTAS_HORA_DIA.Text = "Miercoles" Or cmb_ALTAS_HORA_DIA.Text = "Jueves" Or cmb_ALTAS_HORA_DIA.Text = "Viernes") Then

            '    If cmb_ALTAS_HORA_TURNO.Text = "Matutino" Then
            '            If 



            'End If
            '    End If
            'End If

            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    
End Class