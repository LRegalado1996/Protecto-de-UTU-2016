Imports System.Data.Odbc
Public Class Planillador
    Dim datr As Odbc.OdbcDataReader
    Dim llenar As New Odbc.OdbcCommand
    Dim turno As New Integer
    Dim carrera As New Integer

    'Datos para dar de alta
    Dim a_dia As String
    Dim a_turno As Integer
    Dim a_horario As Integer
    Dim a_carrera As Integer
    Dim a_grupo As Integer
    Dim a_materia As Integer
    Dim a_salon As Integer
    Dim a_profesor As Integer
    Dim c_turno As Integer
    Dim c_horario As Integer
    Dim c_carrera As Integer
    Dim c_grupo As Integer
    Dim c_materia As Integer
    Dim c_salon As Integer
    Dim c_profesor As Integer
    Dim nom As Integer
    Public tipo As String
    Dim prefe As String
    Dim tiposa As String
    Dim priori As Integer
    Dim carga As Integer
    Dim total As Integer
    Dim thisDay As DateTime = DateTime.Today





    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_PLANILLADOR_ALTAS.Click
        Panel_Altas.Visible = True
        Panel_Bajas.Visible = False

        Panel_modificaciones.Visible = False

        pbx_PLANILLADOR_ALTAS.BackColor = Color.Black
        pbx_PLANILLADOR_MODI.BackColor = Color.Transparent
        pbx_PLANILLADOR_BAJAS.BackColor = Color.Transparent

        Try
            Dim cm As New OdbcCommand
            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.Open()

            cmb_ALTAS_PLANI_GRUPO.Items.Clear()
            cmb_ALTAS_PLANI_SALON.Items.Clear()
            cmb_ALTAS_PLANI_PROFESOR.Items.Clear()
            cmb_ALTAS_PLANI_HORARIO.Items.Clear()
            cmb_ALTAS_PLANI_MATERIA.Items.Clear()

            'llenar.Connection = conexion
            'llenar.CommandText = "Select * from persona where tipo='Profesor'"
            'datr = llenar.ExecuteReader

            'While datr.Read
            '    cmb_ALTAS_PLANI_PROFESOR.Items.Add((datr.GetValue(3).ToString) & " " & (datr.GetValue(4).ToString))
            'End While
            'datr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()



        



    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_PLANILLADOR_MODI.Click
        Panel_Altas.Visible = False
        Panel_Bajas.Visible = False

        Panel_modificaciones.Visible = True

        pbx_PLANILLADOR_ALTAS.BackColor = Color.Transparent
        pbx_PLANILLADOR_MODI.BackColor = Color.Black
        pbx_PLANILLADOR_BAJAS.BackColor = Color.Transparent


        Try
            conexion.Open()

            llenar.Connection = conexion
            llenar.CommandText = "Select DISTINCT  YEAR (fecha) from planilla"
            datr = llenar.ExecuteReader


            While datr.Read
                cmb_PLANILLA_MODIFICAR_AÑO.Items.Add(datr.GetValue(0).ToString)
            End While
            datr.Close()
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_PLANILLADOR_BAJAS.Click
        Panel_Altas.Visible = False
        Panel_Bajas.Visible = True

        Panel_modificaciones.Visible = False
        

        pbx_PLANILLADOR_ALTAS.BackColor = Color.Transparent
        pbx_PLANILLADOR_MODI.BackColor = Color.Transparent
        pbx_PLANILLADOR_BAJAS.BackColor = Color.Black
        conexion.Close()

        conexion.Open()

        Try
            cmb_PLANI_BAJAS_VERSION.Items.Clear()
            llenar.Connection = conexion
            llenar.CommandText = "Select distinct version from planilla"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_PLANI_BAJAS_VERSION.Items.Add(datr.GetValue(0).ToString)
            End While
            datr.Close()


            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub Button75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_DESACTIVAR.Click

        Try

            Dim result As DialogResult

            result = MessageBox.Show("Desea desactivar esta planilla", "Bajas Planilla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


            If result = System.Windows.Forms.DialogResult.Yes Then

                conexion.Open()
                Dim elegido As Integer

                elegido = dgv_PLANI_BAJAS.CurrentRow.Index

                llenar.Connection = conexion
                llenar.CommandText = "select cod_materia from materia where nombre='" & dgv_PLANI_BAJAS.Item(5, elegido).Value() & "'"
                a_materia = llenar.ExecuteScalar
                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "select cod_grupo from grupo where descripcion ='" & dgv_PLANI_BAJAS.Item(8, elegido).Value() & "' "
                a_grupo = llenar.ExecuteScalar

                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "select cod_salon from salon where descripcion ='" & dgv_PLANI_BAJAS.Item(4, elegido).Value() & "'"
                a_salon = llenar.ExecuteScalar

                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_turno from turno where nombre='" & dgv_PLANI_BAJAS.Item(1, elegido).Value() & "'"
                a_turno = llenar.ExecuteScalar
                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_horario from horario where dia='" & dgv_PLANI_BAJAS.Item(0, elegido).Value() & "' AND cod_turno=" & a_turno & " AND hora_inicio='" & dgv_PLANI_BAJAS.Item(2, elegido).Value() & "'"
                a_horario = llenar.ExecuteScalar
                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "Select ci from persona where nombre = '" & dgv_PLANI_BAJAS.Item(6, elegido).Value() & "' and apellido='" & dgv_PLANI_BAJAS.Item(7, elegido).Value() & "'"
                a_profesor = llenar.ExecuteScalar

                datr.Close()

                Dim ta As String = "planilla"
                Dim at As String = "baja"
                Dim ins As String = "'si'"
                Dim fila As String = "cod_salon=" & a_salon & " and cod_horario=" & a_horario & " and cod_materia=" & a_materia & " and ci=" & a_profesor & " and cod_grupo=" & a_grupo & ""
                'Dim clave As String = "" & txb_MODIFICAR_USU_CI.Text & txb_MODIFICAR_USU_CI2.Text & ""

                modificacionesplani(ta, at, ins, fila)
                MessageBox.Show("Planilla desactivada", "Baja de Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information)


                dgv_PLANI_ALTAS.ReadOnly = True
                Dim da As New Odbc.OdbcDataAdapter("Select h.dia Dia,t.nombre Turno,h.hora_inicio De,h.hora_fin Hasta,s.descripcion Salon,m.nombre Materia,p.nombre Pro,p.apellido fesor,g.descripcion Grupo from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and version=" & cmb_PLANI_BAJAS_VERSION.Text & "and pl.baja='no'", conexion)
                Dim ds As New DataSet

                da.Fill(ds)
                dgv_PLANI_BAJAS.DataSource = ds.Tables(0)


            Else




            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BAJAS_BORRAR.Click

        Try
            conexion.Open()

            Dim result As DialogResult

            result = MessageBox.Show("Desea borrar esta planilla", "Bajas Planilla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


            If result = System.Windows.Forms.DialogResult.Yes Then

                Dim elegido As Integer

                elegido = dgv_PLANI_BAJAS.CurrentRow.Index

                llenar.Connection = conexion
                llenar.CommandText = "select cod_materia from materia where nombre='" & dgv_PLANI_BAJAS.Item(5, elegido).Value() & "'"
                a_materia = llenar.ExecuteScalar
                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "select cod_grupo from grupo where descripcion ='" & dgv_PLANI_BAJAS.Item(8, elegido).Value() & "' "
                a_grupo = llenar.ExecuteScalar

                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "select cod_salon from salon where descripcion ='" & dgv_PLANI_BAJAS.Item(4, elegido).Value() & "'"
                a_salon = llenar.ExecuteScalar

                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_turno from turno where nombre='" & dgv_PLANI_BAJAS.Item(1, elegido).Value() & "'"
                a_turno = llenar.ExecuteScalar
                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_horario from horario where dia='" & dgv_PLANI_BAJAS.Item(0, elegido).Value() & "' AND cod_turno=" & a_turno & " AND hora_inicio='" & dgv_PLANI_BAJAS.Item(2, elegido).Value() & "'"
                a_horario = llenar.ExecuteScalar
                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "Select ci from persona where nombre = '" & dgv_PLANI_BAJAS.Item(6, elegido).Value() & "' and apellido='" & dgv_PLANI_BAJAS.Item(7, elegido).Value() & "'"
                a_profesor = llenar.ExecuteScalar

                datr.Close()



                Dim ta As String = "planilla"
                Dim co As String = "cod_salon=" & a_salon & " and cod_horario=" & a_horario & " and cod_materia=" & a_materia & " and ci=" & a_profesor & " and cod_grupo=" & a_grupo & ""

                borrarplani(ta, co)
                MessageBox.Show("Planilla borrada", "Baja de Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgv_PLANI_ALTAS.ReadOnly = True
                Dim da As New Odbc.OdbcDataAdapter("Select h.dia Dia,t.nombre Turno,h.hora_inicio De,h.hora_fin Hasta,s.descripcion Salon,m.nombre Materia,p.nombre Pro,p.apellido fesor,g.descripcion Grupo from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and version=" & cmb_PLANI_BAJAS_VERSION.Text & "and pl.baja='no'", conexion)
                Dim ds As New DataSet

                da.Fill(ds)
                dgv_PLANI_BAJAS.DataSource = ds.Tables(0)
            Else




            End If

            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Login.Show()
        Principal.mst_PRINCIPAL.Visible = False
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BAM.Show()
        Me.Close()

    End Sub


    Private Sub ProfesoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consultor.Show()
        Me.Close()
    End Sub

    Private Sub AltasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BAM.Show()
        BAM.tbc_ALTAS.Visible = True
        Me.Close()
    End Sub

    Private Sub ModificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BAM.Show()
        BAM.tbc_MODIFICACIONES.Visible = True
        Me.Close()
    End Sub

    Private Sub BajasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BAM.Show()
        BAM.tbc_BAJA.Visible = True
        Me.Close()

    End Sub

    Private Sub ListarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BAM.Show()
        'BAM.tbc_LISTAR.Visible = True
        Me.Close()

    End Sub

    Private Sub Planillador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tipo = Login.tipopu
        'MsgBox(tipo)
        Dim cm As New OdbcCommand

        conexion = New OdbcConnection(stringconexion)
        cm.Connection = conexion
        conexion.ConnectionString = stringconexion
        conexion.Open()

        nom = Nothing

        'llenar.Connection = conexion
        'llenar.CommandText = "select version from planilla group by version, fecha order by fecha desc, version desc"
        'nom = llenar.ExecuteScalar
        ''& nom

        dgv_PLANI_ALTAS.ReadOnly = True
        Dim da As New Odbc.OdbcDataAdapter("Select h.dia Dia,t.nombre Turno,h.hora_inicio De,h.hora_fin Hasta,s.descripcion Salon,m.nombre Materia,p.nombre Pro,p.apellido fesor,g.descripcion Grupo from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and version=3", conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        dgv_PLANI_ALTAS.DataSource = ds.Tables(0)

        cmb_ALTAS_PLANI_GRUPO.Enabled = False
        cmb_ALTAS_PLANI_SALON.Enabled = False
        cmb_ALTAS_PLANI_PROFESOR.Enabled = False



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Login.Close()

    End Sub

    Private Sub Panel_Bajas_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel_Bajas.Leave
        

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PLANI_MODI_BUSCAR.Click
        conexion.Close()

        conexion.Open()
        Try
            If Me.ValidateChildren And txb_PLANI_MODI_VERSION.Text <> String.Empty Then


                Dim cm As New OdbcCommand


                dgv_PLANI_MODI.ReadOnly = True
                Dim da As New Odbc.OdbcDataAdapter("Select h.dia Dia,t.nombre Turno,h.hora_inicio De,h.hora_fin Hasta,s.descripcion Salon,m.nombre Materia,p.nombre Pro,p.apellido fesor,g.descripcion Grupo,pl.baja Baja,pl.descripcion Descripcion from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and version=" & cmb_PLANILLA_MODIFICAR_VERSION.Text & "", conexion)
                Dim ds As New DataSet

                da.Fill(ds)
                dgv_PLANI_MODI.DataSource = ds.Tables(0)


                cmb_PLANILLA_MODIFICAR_TURNO.Items.Clear()


                llenar.Connection = conexion
                llenar.CommandText = "Select nombre from turno where baja='no'"
                datr = llenar.ExecuteReader

                While datr.Read
                    cmb_PLANILLA_MODIFICAR_TURNO.Items.Add(datr.GetValue(0).ToString)
                End While
                datr.Close()




                cmb_PLANILLA_MODIFICAR_GRUPO.Items.Clear()

                llenar.Connection = conexion
                llenar.CommandText = "Select descripcion from grupo where baja='no'"
                datr = llenar.ExecuteReader

                While datr.Read
                    cmb_PLANILLA_MODIFICAR_GRUPO.Items.Add(datr.GetValue(0).ToString)
                End While
                datr.Close()




                llenar.Connection = conexion
                llenar.CommandText = "Select nombre from materia where baja='no'"
                datr = llenar.ExecuteReader

                While datr.Read
                    cmb_PLANILLA_MODIFICAR_MATERIA.Items.Add(datr.GetValue(0).ToString)
                End While
                datr.Close()
            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificaciones de Planilla", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()

    End Sub

    Private Sub cmb_ALTAS_PLANI_HORARIO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ALTAS_PLANI_HORARIO.SelectedIndexChanged
        datr.Close()
        conexion.Open()

        Try
            cmb_ALTA_PLANI_CARRERA.Select()
            cmb_ALTA_PLANI_CARRERA.Enabled = True
            cmb_ALTA_PLANI_CARRERA.Items.Clear()

            llenar.Connection = conexion
            llenar.CommandText = "Select * from carrera "
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_ALTA_PLANI_CARRERA.Items.Add(datr.GetValue(1).ToString)
            End While
            datr.Close()

            llenar.Connection = conexion
            llenar.CommandText = "Select cod_horario from horario where dia='" & a_dia & "' AND cod_turno=" & a_turno & " AND hora_inicio='" & Mid(cmb_ALTAS_PLANI_HORARIO.SelectedItem, 1, 5) & "'"
            a_horario = llenar.ExecuteScalar
            datr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
        conexion.Close()

    End Sub

    
    Private Sub cmb_ALTAS_PLANI_TURNO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ALTAS_PLANI_TURNO.SelectedIndexChanged

        datr.Close()

        cmb_ALTAS_PLANI_HORARIO.Select()
        cmb_ALTAS_PLANI_HORARIO.Enabled = True
        cmb_ALTAS_PLANI_HORARIO.Items.Clear()
        Try
            conexion.Open()

            llenar.Connection = conexion
            llenar.CommandText = "Select cod_turno from turno where nombre= '" & cmb_ALTAS_PLANI_TURNO.Text & "'"
            turno = llenar.ExecuteScalar

            datr.Close()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from horario where dia= '" & cmb_ALTAS_PLANI_DIA.Text & "' and cod_turno= " & turno

            datr = llenar.ExecuteReader

            While datr.Read
                cmb_ALTAS_PLANI_HORARIO.Items.Add((datr.GetValue(4).ToString) & " - " & (datr.GetValue(5).ToString))
            End While
            datr.Close()

            llenar.Connection = conexion
            llenar.CommandText = "select cod_turno from turno where nombre='" & cmb_ALTAS_PLANI_TURNO.SelectedItem & "'"
            a_turno = llenar.ExecuteScalar
            datr.Close()

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Sub


    Private Sub cmb_ALTAS_PLANI_DIA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ALTAS_PLANI_DIA.SelectedIndexChanged
        cmb_ALTAS_PLANI_TURNO.Select()
        cmb_ALTAS_PLANI_TURNO.Enabled = True
        cmb_ALTAS_PLANI_TURNO.Items.Clear()
        conexion.Open()

        Try

            llenar.Connection = conexion
            llenar.CommandText = "Select * from turno"

            datr = llenar.ExecuteReader
            'turno = llenar.ExecuteScalar
            While datr.Read
                cmb_ALTAS_PLANI_TURNO.Items.Add((datr.GetValue(1).ToString))
            End While
            datr.Close()

            a_dia = cmb_ALTAS_PLANI_DIA.SelectedItem
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conexion.Close()


    End Sub

    Private Sub cmb_ALTA_PLANI_CARRERA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ALTA_PLANI_CARRERA.SelectedIndexChanged
        conexion.Open()
        Try
            cmb_ALTAS_PLANI_GRUPO.Select()
            cmb_ALTAS_PLANI_GRUPO.Enabled = True
            cmb_ALTAS_PLANI_GRUPO.Items.Clear()

            llenar.Connection = conexion
            llenar.CommandText = "Select * from carrera where nombre= '" & cmb_ALTA_PLANI_CARRERA.Text & "'"
            carrera = llenar.ExecuteScalar
            datr.Close()


            llenar.Connection = conexion
            llenar.CommandText = "Select * from grupo where cod_carrera=" & carrera

            datr = llenar.ExecuteReader

            While datr.Read
                cmb_ALTAS_PLANI_GRUPO.Items.Add((datr.GetValue(1).ToString))
            End While
            datr.Close()


            llenar.Connection = conexion
            llenar.CommandText = "select cod_carrera from carrera where nombre='" & cmb_ALTA_PLANI_CARRERA.SelectedItem & "'"
            a_carrera = llenar.ExecuteScalar
            datr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

       
        conexion.Close()



    End Sub

    Private Sub cmb_ALTAS_PLANI_GRUPO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ALTAS_PLANI_GRUPO.SelectedIndexChanged
        conexion.Open()
        Try


            cmb_ALTAS_PLANI_MATERIA.Select()
            cmb_ALTAS_PLANI_MATERIA.Enabled = True
            cmb_ALTAS_PLANI_MATERIA.Items.Clear()

            llenar.Connection = conexion
            llenar.CommandText = "Select * from materia "

            datr = llenar.ExecuteReader

            While datr.Read
                cmb_ALTAS_PLANI_MATERIA.Items.Add((datr.GetValue(1).ToString))
            End While
            datr.Close()

            llenar.Connection = conexion
            llenar.CommandText = "select cod_grupo from grupo where descripcion ='" & cmb_ALTAS_PLANI_GRUPO.SelectedItem & "' AND cod_carrera=" & a_carrera
            a_grupo = llenar.ExecuteScalar
            datr.Close()

            cmb_ALTAS_PLANI_SALON.Items.Clear()
            nom = Nothing

            llenar.Connection = conexion
            llenar.CommandText = "select cantidad from grupo where descripcion='" & cmb_ALTAS_PLANI_GRUPO.SelectedItem & "'"
            nom = llenar.ExecuteScalar
            datr.Close()


            llenar.Connection = conexion
            llenar.CommandText = "Select distinct s.descripcion from salon s,grupo g where s.capacidad >=" & nom
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_ALTAS_PLANI_SALON.Items.Add(datr.GetValue(0).ToString)

            End While
            datr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()


    End Sub

    Private Sub cmb_ALTAS_PLANI_MATERIA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ALTAS_PLANI_MATERIA.SelectedIndexChanged

        conexion.Open()

        Try
            cmb_ALTAS_PLANI_SALON.Select()
            cmb_ALTAS_PLANI_SALON.Enabled = True
            cmb_ALTAS_PLANI_PROFESOR.Enabled = True


          



            cmb_ALTAS_PLANI_PROFESOR.Items.Clear()
            llenar.Connection = conexion
            llenar.CommandText = "select distinct p.ci from persona p, dicta d, materia m where m.cod_materia = d.cod_materia And p.ci = d.ci And m.nombre ='" & cmb_ALTAS_PLANI_MATERIA.Text & "'"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_ALTAS_PLANI_PROFESOR.Items.Add((datr.GetValue(0).ToString))
            End While
            datr.Close()

            llenar.Connection = conexion
            llenar.CommandText = "select cod_materia from materia where nombre='" & cmb_ALTAS_PLANI_MATERIA.SelectedItem & "'"
            a_materia = llenar.ExecuteScalar
            datr.Close()
            

            llenar.Connection = conexion
            llenar.CommandText = "select carga_horaria from materia where nombre='" & cmb_ALTAS_PLANI_MATERIA.SelectedItem & "'"
            carga = llenar.ExecuteScalar
            datr.Close()

            llenar.Connection = conexion
            llenar.CommandText = "select count(*) from planilla where cod_materia=" & a_materia & "and cod_grupo=" & a_grupo & " and version=3"
            total = llenar.ExecuteScalar
            datr.Close()

            If carga > total Then

                cmb_ALTAS_PLANI_SALON.Select()
                'ElseIf carga = total Then
                '    cmb_ALTAS_PLANI_SALON.Select()

            Else
                MessageBox.Show("La meteria alcanzo su limite horario para este grupo", "Altas de planilla", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                cmb_ALTAS_PLANI_MATERIA.Text = " "
                cmb_ALTAS_PLANI_GRUPO.Select()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conexion.Close()
        
    End Sub

    Private Sub cmb_ALTAS_PLANI_SALON_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ALTAS_PLANI_SALON.SelectedIndexChanged


        conexion.Open()
        Try

            llenar.Connection = conexion
            llenar.CommandText = "select cod_salon from salon where descripcion='" & cmb_ALTAS_PLANI_SALON.SelectedItem & "'"
            a_salon = llenar.ExecuteScalar
            datr.Close()

            nom = Nothing

            llenar.Connection = conexion
            llenar.CommandText = "select version from planilla group by version, fecha order by fecha desc, version desc"
            nom = llenar.ExecuteScalar
            datr.Close()

            Dim query As String = String.Empty

            '& nom
            query = "select * from planilla where cod_horario= " & a_horario & " and cod_salon=" & a_salon & " and version=1"


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

                nom = Nothing
                nom = tabla.GetValue(1).ToString
            End While

            If cantidad = 1 Then

                'llenar.Connection = conexion
                'llenar.CommandText = "select prioridad from materia where cod_salon=" & nom
                'priori = llenar.ExecuteScalar
                'datr.Close()




                MessageBox.Show("Ya existe hora asignada para este salon", "Alta Planilla", MessageBoxButtons.OK, MessageBoxIcon.Warning)



            ElseIf cantidad > 1 Then
                MsgBox("Duplicado en la base de datos")

            Else


                llenar.Connection = conexion
                llenar.CommandText = "select preferencia from materia where nombre='" & cmb_ALTAS_PLANI_MATERIA.SelectedItem & "'"
                prefe = llenar.ExecuteScalar
                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "select tipo from salon where descripcion='" & cmb_ALTAS_PLANI_SALON.SelectedItem & "'"
                tiposa = llenar.ExecuteScalar
                datr.Close()

                If prefe = tiposa Then
                    cmb_ALTAS_PLANI_PROFESOR.Select()
                Else
                    Dim result As DialogResult

                    result = MessageBox.Show("La materia designada tiene como preferencia : " & prefe & " y no coincide con el tipo de salon, desea igual asignarle este salon.", "Alta Planilla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


                    If result = System.Windows.Forms.DialogResult.No Then

                        cmb_ALTAS_PLANI_SALON.Text = " "
                        cmb_ALTAS_PLANI_SALON.Select()

                    Else
                        cmb_ALTAS_PLANI_PROFESOR.Select()

                    End If

                End If



            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()

    End Sub

    Private Sub chk_ALTAS_PLANI_GRUPO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmb_ALTAS_PLANI_GRUPO.Enabled = True
    End Sub

    Private Sub chk_ALTAS_PLANI_SALON_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmb_ALTAS_PLANI_SALON.Enabled = True
    End Sub

    Private Sub chk_ALTAS_PLANI_PROFESOR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmb_ALTAS_PLANI_PROFESOR.Enabled = True
    End Sub

    Private Sub cmb_ALTAS_PLANI_PROFESOR_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_ALTAS_PLANI_PROFESOR.Leave


    End Sub

    Private Sub cmb_ALTAS_PLANI_PROFESOR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ALTAS_PLANI_PROFESOR.SelectedIndexChanged

        conexion.Open()
        Try

            nom = Nothing

            llenar.Connection = conexion
            llenar.CommandText = "select version from planilla group by version, fecha order by fecha desc, version desc"
            nom = llenar.ExecuteScalar
            datr.Close()
            

            Dim query As String = String.Empty

            '& nom
            query = "Select * FROM planilla WHERE ci=" & cmb_ALTAS_PLANI_PROFESOR.Text & " and cod_horario=" & a_horario & "and version=3"


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

                MessageBox.Show("Este profesor ya tiene asignada materia en este horario", "Altas Planilla", MessageBoxButtons.OK, MessageBoxIcon.Warning)



            ElseIf cantidad > 1 Then
                MsgBox("Duplicado en la base de datos")

            Else
                llenar.Connection = conexion
                llenar.CommandText = "select p.ci from persona p, dicta d where p.ci='" & cmb_ALTAS_PLANI_PROFESOR.SelectedItem & "'"
                a_profesor = llenar.ExecuteScalar
                datr.Close()

                Lbl_ALTA_nombre.Visible = True
                llenar.Connection = conexion
                llenar.CommandText = "Select nombre, apellido from persona where ci=" & cmb_ALTAS_PLANI_PROFESOR.Text
                datr = llenar.ExecuteReader
                datr.Read()
                Lbl_ALTA_nombre.Text = datr.GetValue(0).ToString & " " & datr.GetValue(1).ToString
                datr.Close()
                'MessageBox.Show(a_profesor)
                a_profesor = cmb_ALTAS_PLANI_PROFESOR.Text
                txb_ALTAS_PLANILLADOR_DESCRIPCION.Select()


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()

        
    End Sub

    Private Sub btn_PLANI_ALTAS_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PLANI_ALTAS_GUARDAR.Click
        Try
            conexion.Open()


            If Me.ValidateChildren And cmb_ALTA_PLANI_CARRERA.Text <> String.Empty And cmb_ALTAS_PLANI_DIA.Text <> String.Empty And cmb_ALTAS_PLANI_GRUPO.Text <> String.Empty And cmb_ALTAS_PLANI_HORARIO.Text <> String.Empty And cmb_ALTAS_PLANI_MATERIA.Text <> String.Empty And cmb_ALTAS_PLANI_PROFESOR.Text <> String.Empty And cmb_ALTAS_PLANI_SALON.Text <> String.Empty And cmb_ALTAS_PLANI_TURNO.Text <> String.Empty And txb_ALTAS_PLANILLADOR_DESCRIPCION.Text <> String.Empty Then



                nom = Nothing

                llenar.Connection = conexion
                llenar.CommandText = "select version from planilla group by version, fecha order by fecha desc, version desc"
                nom = llenar.ExecuteScalar
                datr.Close()
                '& nom &
                Dim ta As String = "planilla"
                Dim at As String = "fecha,cod_salon,cod_horario,cod_materia,ci,cod_grupo,descripcion,version,baja,hora"
                Dim ins As String = "('11/22/2016'," & a_salon & "," & a_horario & "," & a_materia & "," & a_profesor & "," & a_grupo & ",'" & txb_ALTAS_PLANILLADOR_DESCRIPCION.Text & "',3,'no','16:52')"
                altas(ta, at, ins)

                MessageBox.Show("Alta realizada", "Creador de Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmb_ALTAS_PLANI_DIA.Text = ""
                cmb_ALTA_PLANI_CARRERA.Text = ""
                cmb_ALTAS_PLANI_GRUPO.Text = ""
                cmb_ALTAS_PLANI_HORARIO.Text = ""
                cmb_ALTAS_PLANI_PROFESOR.Text = ""
                cmb_ALTAS_PLANI_SALON.Text = ""
                cmb_ALTAS_PLANI_MATERIA.Text = ""
                cmb_ALTAS_PLANI_TURNO.Text = ""
                txb_ALTAS_PLANILLADOR_DESCRIPCION.Text = ""
                Lbl_ALTA_nombre.Text = ""
                Lbl_ALTA_nombre.Visible = False

                Dim cm As New OdbcCommand

                conexion = New OdbcConnection(stringconexion)
                cm.Connection = conexion
                conexion.ConnectionString = stringconexion
                conexion.Open()

                '& nom
                dgv_PLANI_ALTAS.ReadOnly = True
                Dim da As New Odbc.OdbcDataAdapter("Select h.dia Dia,t.nombre Turno,h.hora_inicio De,h.hora_fin Hasta,s.descripcion Salon,m.nombre Materia,p.nombre Pro,p.apellido fesor,g.descripcion Grupo from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and version=3", conexion)
                Dim ds As New DataSet

                da.Fill(ds)
                dgv_PLANI_ALTAS.DataSource = ds.Tables(0)


                'End If
            Else
                MessageBox.Show("Ingrese los datos requeridos", "Altas de Planilla", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        
        conexion.Close()

    End Sub

    
    Private Sub dgv_PLANI_MODI_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_PLANI_MODI.CellClick


        Try

            conexion.Open()

            Dim elegido As Integer

            elegido = dgv_PLANI_MODI.CurrentRow.Index

            cmb_PLANILLA_MODIFICAR_DIA.Text = dgv_PLANI_MODI.Item(0, elegido).Value()
            cmb_PLANILLA_MODIFICAR_BAJA.Text = dgv_PLANI_MODI.Item(9, elegido).Value()
            txb_PLANILLA_MODI_DESCRI.Text = dgv_PLANI_MODI.Item(10, elegido).Value()

            cmb_PLANILLA_MODIFICAR_TURNO.Text = dgv_PLANI_MODI.Item(1, elegido).Value()



            datr.Close()


            llenar.Connection = conexion
            llenar.CommandText = "Select cod_turno from turno where nombre = '" & dgv_PLANI_MODI.Item(1, elegido).Value() & "'"
            conexion.Close()

            conexion.Open()
            c_turno = llenar.ExecuteScalar


            datr.Close()



            llenar.Connection = conexion
            llenar.CommandText = "Select hora_inicio,hora_fin from horario where hora_inicio = '" & dgv_PLANI_MODI.Item(2, elegido).Value() & "'"
            datr = llenar.ExecuteReader

            datr.Read()
            cmb_PLANILLA_MODIFICAR_HORA.Text = datr.GetValue(0) & " hasta " & datr.GetValue(1)

            datr.Close()



            llenar.Connection = conexion
            llenar.CommandText = "Select cod_horario from horario where hora_inicio = '" & dgv_PLANI_MODI.Item(2, elegido).Value() & "' and dia='" & dgv_PLANI_MODI.Item(0, elegido).Value() & "'"
            conexion.Close()

            conexion.Open()

            c_horario = llenar.ExecuteScalar


            datr.Close()


            cmb_PLANILLA_MODIFICAR_GRUPO.Text = dgv_PLANI_MODI.Item(8, elegido).Value()

            llenar.Connection = conexion
            llenar.CommandText = "Select cod_grupo from grupo where descripcion = '" & dgv_PLANI_MODI.Item(8, elegido).Value() & "'"
            'conexion.Open()

            c_grupo = llenar.ExecuteScalar


            datr.Close()


            cmb_PLANILLA_MODIFICAR_SALON.Text = dgv_PLANI_MODI.Item(4, elegido).Value()


            llenar.Connection = conexion
            llenar.CommandText = "Select cod_salon from salon where descripcion = '" & dgv_PLANI_MODI.Item(4, elegido).Value() & "'"
            c_salon = llenar.ExecuteScalar


            datr.Close()


            llenar.Connection = conexion
            llenar.CommandText = "Select ci from persona where nombre = '" & dgv_PLANI_MODI.Item(6, elegido).Value() & "' and apellido='" & dgv_PLANI_MODI.Item(7, elegido).Value() & "'"
            c_profesor = llenar.ExecuteScalar
            datr = llenar.ExecuteReader

            datr.Read()
            cmb_PLANILLA_MODIFICAR_PROFESOR.Text = datr.GetValue(0)

            datr.Close()

            lbl_PLANI_MODI_NOMBRE.Text = dgv_PLANI_MODI.Item(6, elegido).Value() & " " & dgv_PLANI_MODI.Item(7, elegido).Value()
            lbl_PLANI_MODI_NOMBRE.Visible = True

            conexion.Close()

            llenar.Connection = conexion
            llenar.CommandText = "Select hora_inicio,hora_fin from horario where hora_inicio = '" & dgv_PLANI_MODI.Item(2, elegido).Value() & "'"
            conexion.Open()

            datr = llenar.ExecuteReader

            datr.Read()

            'cmb_PLANILLA_MODIFICAR_MATERIA.Text = dgv_PLANI_MODI.Item(5, elegido).Value()

            'llenar.Connection = conexion
            'llenar.CommandText = "Select cod_materia from materia where nombre = '" & dgv_PLANI_MODI.Item(5, elegido).Value() & "'"
            'c_materia = llenar.ExecuteScalar


            datr.Close()



            cmb_PLANILLA_MODIFICAR_MATERIA.Text = dgv_PLANI_MODI.Item(5, elegido).Value

            llenar.Connection = conexion
            llenar.CommandText = "Select cod_materia from materia where nombre = '" & dgv_PLANI_MODI.Item(5, elegido).Value() & "'"
            conexion.Close()
            conexion.Open()

            c_materia = llenar.ExecuteScalar

            datr.Close()




            'conexion.Open()
            'Dim cod_turno As Integer
            'llenar.Connection = conexion
            'llenar.CommandText = "Select cod_turno from turno where nombre= '" & dgv_PLANI_MODI.Item(1, elegido).Value() & "'"
            'cod_turno = llenar.ExecuteScalar

            'datr.Close()
            'conexion.Close()


            'conexion.Open()

            'llenar.Connection = conexion
            'llenar.CommandText = "Select hora_inicio,hora_fin from horario where dia= '" & dgv_PLANI_MODI.Item(0, elegido).Value() & "' and cod_turno=" & cod_turno & ""
            'datr = llenar.ExecuteReader

            'While datr.Read
            '    cmb_PLANILLA_MODIFICAR_HORA.Items.Add((datr.GetValue(0).ToString) & " hasta " & (datr.GetValue(1).ToString))
            'End While
            'datr.Close()






        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



        conexion.Close()


    End Sub

   
    Private Sub cmb_PLANILLA_MODIFICAR_TURNO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PLANILLA_MODIFICAR_TURNO.SelectedIndexChanged

        conexion.Close()
        cmb_PLANILLA_MODIFICAR_HORA.Items.Clear()


        Try

            conexion.Open()
            Dim cod_turno As Integer
            llenar.Connection = conexion
            llenar.CommandText = "Select cod_turno from turno where nombre= '" & cmb_PLANILLA_MODIFICAR_TURNO.Text & "'"
            cod_turno = llenar.ExecuteScalar

            datr.Close()
            conexion.Close()


            conexion.Open()

            llenar.Connection = conexion
            llenar.CommandText = "Select hora_inicio,hora_fin from horario where dia= '" & cmb_PLANILLA_MODIFICAR_DIA.Text & "' and cod_turno=" & cod_turno & ""
            datr = llenar.ExecuteReader



            While datr.Read
                cmb_PLANILLA_MODIFICAR_HORA.Items.Add((datr.GetValue(0).ToString) & " hasta " & (datr.GetValue(1).ToString))
            End While
            datr.Close()




            llenar.Connection = conexion
            llenar.CommandText = "select cod_turno from turno where nombre='" & cmb_PLANILLA_MODIFICAR_TURNO.SelectedItem & "'"
            a_turno = llenar.ExecuteScalar
            datr.Close()

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmb_PLANILLA_MODIFICAR_MATERIA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PLANILLA_MODIFICAR_MATERIA.SelectedIndexChanged
        conexion.Close()

        Try
            conexion.Open()

            cmb_PLANILLA_MODIFICAR_PROFESOR.Items.Clear()
            llenar.Connection = conexion
            llenar.CommandText = "select distinct p.ci from persona p, dicta d, materia m where m.cod_materia = d.cod_materia And p.ci = d.ci And m.nombre ='" & cmb_PLANILLA_MODIFICAR_MATERIA.Text & "'"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_PLANILLA_MODIFICAR_PROFESOR.Items.Add((datr.GetValue(0).ToString))
            End While
            datr.Close()

            cmb_PLANILLA_MODIFICAR_SALON.Items.Clear()
            llenar.Connection = conexion
            llenar.CommandText = "select descripcion,tipo from salon where baja='no'"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_PLANILLA_MODIFICAR_SALON.Items.Add((datr.GetValue(0).ToString) & " Tipo " & (datr.GetValue(1).ToString))
            End While
            datr.Close()

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmb_PLANILLA_MODIFICAR_PROFESOR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PLANILLA_MODIFICAR_PROFESOR.SelectedIndexChanged
        conexion.Close()

        conexion.Open()
        Try

            Dim query As String = String.Empty

            '& nom
            query = "Select * FROM planilla WHERE ci=" & cmb_PLANILLA_MODIFICAR_PROFESOR.Text & " and cod_horario=" & a_horario & "and version=" & txb_PLANI_MODI_VERSION.Text


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

                MessageBox.Show("Este profesor ya tiene asignada materia en este horario", "Altas Planilla", MessageBoxButtons.OK, MessageBoxIcon.Warning)



            ElseIf cantidad > 1 Then
                MsgBox("Duplicado en la base de datos")

            Else
                llenar.Connection = conexion
                llenar.CommandText = "Select nombre,apellido from persona where ci = '" & cmb_PLANILLA_MODIFICAR_PROFESOR.Text & "'"
                datr = llenar.ExecuteReader

                datr.Read()
                lbl_PLANI_MODI_NOMBRE.Text = datr.GetValue(0).ToString & " " & datr.GetValue(1).ToString

                datr.Close()
                a_profesor = cmb_PLANILLA_MODIFICAR_PROFESOR.Text
                txb_PLANILLA_MODI_DESCRI.Select()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Try

            If Me.ValidateChildren And txb_PLANILLA_MODI_DESCRI.Text <> String.Empty And cmb_PLANILLA_MODIFICAR_BAJA.Text <> String.Empty And cmb_PLANILLA_MODIFICAR_DIA.Text <> String.Empty And cmb_PLANILLA_MODIFICAR_DIA.Text <> String.Empty And cmb_PLANILLA_MODIFICAR_GRUPO.Text <> String.Empty And cmb_PLANILLA_MODIFICAR_HORA.Text <> String.Empty And cmb_PLANILLA_MODIFICAR_MATERIA.Text <> String.Empty And cmb_PLANILLA_MODIFICAR_PROFESOR.Text <> String.Empty Then

                conexion.Open()


                llenar.Connection = conexion
                llenar.CommandText = "select cod_materia from materia where nombre='" & cmb_PLANILLA_MODIFICAR_MATERIA.Text & "'"
                a_materia = llenar.ExecuteScalar
                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "select cod_grupo from grupo where descripcion ='" & cmb_PLANILLA_MODIFICAR_GRUPO.Text & "' "
                a_grupo = llenar.ExecuteScalar

                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "select cod_salon from salon where descripcion ='" & Split(cmb_PLANILLA_MODIFICAR_SALON.Text, " ")(0) & "'"
                a_salon = llenar.ExecuteScalar

                datr.Close()

                'llenar.Connection = conexion
                'llenar.CommandText = "select ci from persona where nombre ='" & cmb_ALTAS_PLANI_GRUPO.SelectedItem & "' AND cod_carrera=" & a_carrera
                'a_profesor = llenar.ExecuteScalar

                'datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_turno from turno where nombre='" & cmb_PLANILLA_MODIFICAR_TURNO.Text & "'"
                a_turno = llenar.ExecuteScalar
                datr.Close()


                llenar.Connection = conexion
                llenar.CommandText = "Select cod_horario from horario where dia='" & cmb_PLANILLA_MODIFICAR_DIA.Text & "' AND cod_turno=" & a_turno & " AND hora_inicio='" & Mid(cmb_PLANILLA_MODIFICAR_HORA.SelectedItem, 1, 5) & "'"
                a_horario = llenar.ExecuteScalar
                datr.Close()



                Dim ta As String = "planilla"
                Dim at As String = "fecha,cod_salon,cod_horario,cod_materia,ci,cod_grupo,descripcion,version,baja"
                Dim ins As String = "'11/24/2016'," & a_salon & "," & a_horario & "," & a_materia & "," & cmb_PLANILLA_MODIFICAR_PROFESOR.Text & ", " & a_grupo & ", '" & txb_PLANILLA_MODI_DESCRI.Text & "'," & txb_PLANI_MODI_VERSION.Text & ",'" & cmb_PLANILLA_MODIFICAR_BAJA.Text & "'"
                Dim fila As String = "cod_salon=" & c_salon & " and cod_horario=" & c_horario & " and cod_materia=" & c_materia & " and ci=" & c_profesor & " and cod_grupo=" & c_grupo & " and version=" & txb_PLANI_MODI_VERSION.Text
                'Dim clave As String = "" & txb_MODIFICAR_USU_CI.Text & txb_MODIFICAR_USU_CI2.Text & ""

                modificacionesplani(ta, at, ins, fila)

                MessageBox.Show("Planilla actualizada correctamente", "Planillador", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cmb_PLANILLA_MODIFICAR_DIA.Text = ""
                cmb_PLANILLA_MODIFICAR_GRUPO.Text = ""
                cmb_PLANILLA_MODIFICAR_HORA.Text = ""
                cmb_PLANILLA_MODIFICAR_MATERIA.Text = ""
                cmb_PLANILLA_MODIFICAR_PROFESOR.Text = ""
                cmb_PLANILLA_MODIFICAR_SALON.Text = ""
                cmb_PLANILLA_MODIFICAR_TURNO.Text = ""
                txb_PLANILLA_MODI_DESCRI.Text = ""
                lbl_PLANI_MODI_NOMBRE.Text = ""
                lbl_PLANI_MODI_NOMBRE.Visible = False
                cmb_PLANILLA_MODIFICAR_BAJA.Text = ""


                dgv_PLANI_MODI.ReadOnly = True
                Dim da As New Odbc.OdbcDataAdapter("Select h.dia Dia,t.nombre Turno,h.hora_inicio De,h.hora_fin Hasta,s.descripcion Salon,m.nombre Materia,p.nombre Pro,p.apellido fesor,g.descripcion Grupo,pl.baja Baja,pl.descripcion Descripcion from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and version=" & txb_PLANI_MODI_VERSION.Text & "", conexion)
                Dim ds As New DataSet

                da.Fill(ds)
                dgv_PLANI_MODI.DataSource = ds.Tables(0)
            Else
                MessageBox.Show("Ingrese los datos requeridos", "Modificaciones de Planilla", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmb_PLANILLA_MODIFICAR_DIA.Text = ""
        cmb_PLANILLA_MODIFICAR_GRUPO.Text = ""
        cmb_PLANILLA_MODIFICAR_HORA.Text = ""
        cmb_PLANILLA_MODIFICAR_MATERIA.Text = ""
        cmb_PLANILLA_MODIFICAR_PROFESOR.Text = ""
        cmb_PLANILLA_MODIFICAR_SALON.Text = ""
        cmb_PLANILLA_MODIFICAR_TURNO.Text = ""
        txb_PLANILLA_MODI_DESCRI.Text = ""
        lbl_PLANI_MODI_NOMBRE.Text = ""
        lbl_PLANI_MODI_NOMBRE.Visible = False
        cmb_PLANILLA_MODIFICAR_BAJA.Text = ""
        txb_PLANI_MODI_VERSION.Text = ""

        'dgv_PLANI_MODI.Rows.Clear()

    End Sub


    Private Sub cmb_PLANI_BAJAS_VERSION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PLANI_BAJAS_VERSION.SelectedIndexChanged
        Try
            conexion.Open()
            'Dim cm As New OdbcCommand

            'conexion = New OdbcConnection(stringconexion)
            'cm.Connection = conexion
            'conexion.ConnectionString = stringconexion
            'conexion.Open()

            dgv_PLANI_ALTAS.ReadOnly = True
            Dim da As New Odbc.OdbcDataAdapter("Select h.dia Dia,t.nombre Turno,h.hora_inicio De,h.hora_fin Hasta,s.descripcion Salon,m.nombre Materia,p.nombre Pro,p.apellido fesor,g.descripcion Grupo from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and version=" & cmb_PLANI_BAJAS_VERSION.Text & "and pl.baja='no'", conexion)
            Dim ds As New DataSet

            da.Fill(ds)
            dgv_PLANI_BAJAS.DataSource = ds.Tables(0)

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_ALTAS_PLANI_ASIGNAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ALTAS_PLANI_ASIGNAR.Click
        Version.Visible = True
        'Planillador.StartPosition.CenterScreen()
        Version.MdiParent = Principal
        Principal.StMeItmPlanillador.Enabled = True
        Principal.StMeItmBAM.Enabled = True
        Principal.mst_PRINCIPAL.Visible = True
        Principal.TS_secundario.Visible = True
        Me.Hide()

    End Sub

    Private Sub cmb_PLANILLA_MODIFICAR_SALON_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PLANILLA_MODIFICAR_SALON.SelectedIndexChanged
        conexion.Open()


        Try


            llenar.Connection = conexion
            llenar.CommandText = "select cod_turno from turno where nombre='" & cmb_PLANILLA_MODIFICAR_TURNO.SelectedItem & "'"
            a_turno = llenar.ExecuteScalar
            datr.Close()

            llenar.Connection = conexion
            llenar.CommandText = "select cod_salon from salon where descripcion ='" & Split(cmb_PLANILLA_MODIFICAR_SALON.Text, " ")(0) & "'"
            a_salon = llenar.ExecuteScalar

            datr.Close()

            Dim query As String = String.Empty

            '& nom
            query = "select * from planilla where cod_horario= " & a_horario & " and cod_salon=" & a_salon & " and version=" & txb_PLANI_MODI_VERSION.Text


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

                nom = Nothing
                nom = tabla.GetValue(1).ToString
            End While

            If cantidad = 1 Then

                'llenar.Connection = conexion
                'llenar.CommandText = "select prioridad from materia where cod_salon=" & nom
                'priori = llenar.ExecuteScalar
                'datr.Close()




                MessageBox.Show("Ya existe hora asignada para este salon", "Modificar Planilla", MessageBoxButtons.OK, MessageBoxIcon.Warning)



            ElseIf cantidad > 1 Then
                MsgBox("Duplicado en la base de datos")

            Else


                llenar.Connection = conexion
                llenar.CommandText = "select preferencia from materia where nombre='" & cmb_PLANILLA_MODIFICAR_MATERIA.SelectedItem & "'"
                prefe = llenar.ExecuteScalar
                datr.Close()

                llenar.Connection = conexion
                llenar.CommandText = "select tipo from salon where descripcion='" & Split(cmb_PLANILLA_MODIFICAR_SALON.Text, " ")(0) & "'"
                tiposa = llenar.ExecuteScalar
                datr.Close()

                If prefe = tiposa Then
                    cmb_ALTAS_PLANI_PROFESOR.Select()
                Else
                    Dim result As DialogResult

                    result = MessageBox.Show("La materia designada tiene como preferencia : " & prefe & " y no coincide con el tipo de salon, desea igual asignarle este salon.", "Modificar Planilla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


                    If result = System.Windows.Forms.DialogResult.No Then

                        cmb_PLANILLA_MODIFICAR_SALON.Text = " "
                        cmb_PLANILLA_MODIFICAR_SALON.Select()

                    Else
                        cmb_PLANILLA_MODIFICAR_PROFESOR.Select()

                    End If

                End If



            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()
    End Sub

    Private Sub cmb_PLANILLA_MODIFICAR_HORA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PLANILLA_MODIFICAR_HORA.SelectedIndexChanged

        Try
            conexion.Close()
            conexion.Open()

            llenar.Connection = conexion
            llenar.CommandText = "Select cod_horario from horario where dia='" & cmb_PLANILLA_MODIFICAR_DIA.Text & "' AND cod_turno=" & a_turno & " AND hora_inicio='" & Mid(cmb_PLANILLA_MODIFICAR_HORA.SelectedItem, 1, 5) & "'"
            a_horario = llenar.ExecuteScalar
            datr.Close()
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cmb_PLANILLA_MODIFICAR_AÑO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PLANILLA_MODIFICAR_AÑO.SelectedIndexChanged
        Try

            conexion.Open()
            cmb_PLANILLA_MODIFICAR_VERSION.Items.Clear()

            llenar.Connection = conexion
            llenar.CommandText = "Select distinct VERSION from planilla where YEAR (FECHA) = '" & cmb_PLANILLA_MODIFICAR_AÑO.Text & "'"

            datr = llenar.ExecuteReader

            While datr.Read
                cmb_PLANILLA_MODIFICAR_VERSION.Items.Add(datr.GetValue(0).ToString)
            End While
            datr.Close()




            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmb_PLANILLA_MODIFICAR_VERSION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PLANILLA_MODIFICAR_VERSION.SelectedIndexChanged

    End Sub
End Class