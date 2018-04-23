Imports System.Data.Odbc
Public Class Consultor

    Dim datr As Odbc.OdbcDataReader
    Dim llenar As New Odbc.OdbcCommand
    Dim nom As Integer
    Dim texto As String
    Dim thisDay As DateTime = DateTime.Today
    Dim año As Integer
    Dim version As Integer


    Private Sub LLenar_datagrid(ByVal dgv As DataGridView)

        Dim a As Integer = 0


        dgv.DataSource = Nothing
        conexion.Close()
        conexion.Open()
        llenar.Connection = conexion
        llenar.CommandText = "select cod_salon from planilla where version=" & version & " AND year(fecha)='" & año & "' group by cod_salon"
        datr = llenar.ExecuteReader

        While datr.Read
            a = a + 1
        End While
        datr.Close()

        Dim cod_salon(a) As String
        Dim b As Integer = 0
        datr = llenar.ExecuteReader
        While datr.Read
            cod_salon(b) = datr.GetValue(0).ToString
            b = b + 1
        End While
        datr.Close()
        conexion.Close()

        Dim fila As Integer = 0
        Dim columna As Integer = 0
        Dim c As Integer = 0
        b = 0
        dgv.Columns.Add(0, "Turno")
        dgv.Columns.Add(1, "Dia")
        dgv.Columns.Add(2, "")
        dgv.Columns.Add(3, "Horario")

        While b <> a
            If b = 0 Then
                conexion.Open()
                llenar.Connection = conexion
                llenar.CommandText = "Select t.nombre turno, h.dia dia, h.numero_hora hora, h.hora_inicio inicio, hora_fin fin, s.descripcion, s.tipo,  g.descripcion, m.nombre, p.nombre, p.apellido from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and pl.version=" & version & " and pl.cod_salon=" & cod_salon(b) & " and year(fecha)='" & año & "' order by t.cod_turno, pl.cod_salon, h.dia, h.numero_hora"
                datr = llenar.ExecuteReader

                While datr.Read
                    If c = 0 Then
                        dgv.Columns.Add(4, datr.GetValue(5).ToString() & " " & datr.GetValue(6).ToString())
                        c = c + 1
                    End If
                    If datr.GetValue(0).ToString() = "Matutino" Then
                        dgv.RowTemplate.DefaultCellStyle.BackColor = Color.LightBlue
                    ElseIf datr.GetValue(0).ToString() = "Vespertino" Then
                        dgv.RowTemplate.DefaultCellStyle.BackColor = Color.GreenYellow
                    ElseIf datr.GetValue(0).ToString() = "Nocturno" Then
                        dgv.RowTemplate.DefaultCellStyle.BackColor = Color.IndianRed
                    End If
                    dgv.Rows.Add(datr.GetValue(0).ToString(), datr.GetValue(1).ToString(), datr.GetValue(2).ToString() & "°", datr.GetValue(3).ToString() & " - " & datr.GetValue(4).ToString(), datr.GetValue(7).ToString() & " - " & datr.GetValue(8).ToString() & " - " & datr.GetValue(9).ToString() & " " & datr.GetValue(10).ToString())

                End While

                datr.Close()
                conexion.Close()
                columna = 5

            Else
                conexion.Open()
                llenar.Connection = conexion
                llenar.CommandText = "Select s.descripcion, s.tipo,  g.descripcion, m.nombre, p.nombre, p.apellido from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and pl.version=" & version & " and pl.cod_salon=" & cod_salon(b) & " and year(fecha)='" & año & "' order by t.nombre, pl.cod_salon, h.dia, h.numero_hora"
                datr = llenar.ExecuteReader

                While datr.Read
                    c = c - 1
                    If c = 0 Then
                        dgv.Columns.Add(columna, datr.GetValue(0).ToString() & " " & datr.GetValue(1).ToString())
                        c = c + 99999
                    End If
                    dgv.Item(columna, fila).Value = (datr.GetValue(2).ToString() & " - " & datr.GetValue(3).ToString() & " - " & datr.GetValue(4).ToString() & " " & datr.GetValue(5).ToString())
                    fila = fila + 1

                End While
                columna = columna + 1
                datr.Close()
                conexion.Close()

            End If
            b = b + 1

        End While

        dgv.Columns(0).Visible = False
        dgv.Columns(1).Frozen = True
        dgv.Columns(2).Frozen = True
        dgv.Columns(3).Frozen = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Login.Show()
        Me.Close()
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_CONSULTOR.CellContentClick

    End Sub

    Private Sub btn_Atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Login.Show()
        Principal.mst_PRINCIPAL.Visible = False
        Principal.TS_secundario.Visible = False
        Me.Close()

    End Sub

    Private Sub Consultor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'esto lo hizo el pablo nº 1 negri 25/11/16


        If Planillador.tipo = "Administrador" Then

            tbp_CONSULTOR_BD.Parent = tbc_CONSULTOR
            tbp_HISTORIAL.Parent = tbc_CONSULTOR


        Else
            tbp_CONSULTOR_BD.Parent = Nothing
            tbp_HISTORIAL.Parent = Nothing
        End If









        Dim cm As New OdbcCommand
        conexion = New OdbcConnection(stringconexion)
        cm.Connection = conexion
        conexion.ConnectionString = stringconexion
        conexion.Open()







        'aca se carga el año

        Try

            llenar.Connection = conexion
            llenar.CommandText = "Select DISTINCT  YEAR (fecha) from planilla"
            datr = llenar.ExecuteReader

            'While datr.Read
            '    lbl_OCULTO.Text = (datr.GetValue(0).ToString)

            '    cmb_AÑO.Items.Add(Mid(lbl_OCULTO.Text, 7, 4))
            'End While



            While datr.Read
                cmb_AÑO.Items.Add(datr.GetValue(0).ToString)
            End While
            datr.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '**************************************************************

        CMB_HISTORIAL_FECHA.Items.Clear()

        Try



            llenar.Connection = conexion
            llenar.CommandText = "Select distinct DAY (FECHA), MONTH(FECHA),YEAR(FECHA) from HISTORIAL"

            datr = llenar.ExecuteReader

            While datr.Read
                CMB_HISTORIAL_FECHA.Items.Add(datr.GetValue(0) & "/" & (datr.GetValue(1) & "/" & (datr.GetValue(2).ToString)))
            End While
            datr.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try









        'Aca se carga el cmb de horarios  x grupo

        cmb_CONSULTOR_SELECCIONDEGRUPO.Items.Clear()

        Try

            llenar.Connection = conexion
            llenar.CommandText = "Select descripcion from grupo"

            datr = llenar.ExecuteReader

            While datr.Read
                cmb_CONSULTOR_SELECCIONDEGRUPO.Items.Add(datr.GetValue(0).ToString)
            End While
            datr.Close()











            'Aca se carga el cmb de profesores que dictan una materia




            cmb_PLANILLADOR_PROFESORESQUEDICTAN.Items.Clear()



            llenar.Connection = conexion
            llenar.CommandText = "select CI FROM DICTA"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_PLANILLADOR_PROFESORESQUEDICTAN.Items.Add(datr.GetValue(0).ToString)
            End While
            datr.Close()

            cmb_PROFESXMATERIAS.Items.Clear()



            llenar.Connection = conexion
            llenar.CommandText = "select nombre from materia"
            datr = llenar.ExecuteReader

            While datr.Read
                cmb_PROFESXMATERIAS.Items.Add(datr.GetValue(0).ToString)
            End While
            datr.Close()

            'aca se carga el cmb de las materias que duicta un profesor


            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            cmb_SALON.Items.Clear()



            llenar.Connection = conexion
            llenar.CommandText = "Select distinct  descripcion , tipo from salon "
            datr = llenar.ExecuteReader


            While datr.Read
                cmb_SALON.Items.Add(datr.GetValue(0) & " " & datr.GetValue(1).ToString)
            End While
            datr.Close()



        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
        conexion.Close()





    End Sub



   
    
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_CONSULTOR_SELECCIONDEGRUPO.Click

    End Sub

    Private Sub cmb_CONSULTOR_SELECCIONDEGRUPO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CONSULTOR_SELECCIONDEGRUPO.SelectedIndexChanged
        conexion.Open()



        Try
            llenar.Connection = conexion
            llenar.CommandText = "Select cod_grupo from grupo where descripcion='" & cmb_CONSULTOR_SELECCIONDEGRUPO.Text & "'"



            nom = llenar.ExecuteScalar

            datr.Close()


            dgv_CONSULTOR.ReadOnly = True
            Dim da As New Odbc.OdbcDataAdapter("SELECT h.dia, h.hora_inicio, h.hora_fin,g.descripcion grupo, m.nombre materia, s.descripcion salon, p.nombre profesor FROM horario h, salon s, materia m, persona p, dicta d, planilla plan, grupo g WHERE(plan.cod_horario = h.cod_horario And plan.cod_salon = s.cod_salon)AND plan.cod_grupo=g.cod_grupo AND plan.ci=d.ci AND plan.cod_materia=d.cod_materia AND d.ci=p.ci AND d.cod_materia=m.cod_materia AND plan.cod_grupo=" & nom, conexion)
            Dim ds As New DataSet
            da.Fill(ds)
            dgv_CONSULTOR.DataSource = ds.Tables(0)




            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

   



    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    
    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PROFESXMATERIAS.SelectedIndexChanged
        conexion.Open()

        Try
            llenar.Connection = conexion
            llenar.CommandText = "Select cod_materia from materia  where nombre='" & cmb_PROFESXMATERIAS.Text & "'"



            nom = llenar.ExecuteScalar

            datr.Close()

            dgv_CONSULTOR.ReadOnly = True
            Dim da As New Odbc.OdbcDataAdapter("SELECT p.nombre , p.apellido FROM persona p, dicta d, materia m WHERE p.ci = d.ci And d.cod_materia = m.cod_materia And d.cod_materia = " & nom, conexion)
            Dim ds As New DataSet
            da.Fill(ds)
            dgv_CONSULTOR.DataSource = ds.Tables(0)




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Try
            '  Guardar en historial - CONSULTOR - ADMINISTRADOR
            Dim descripcion As String
            descripcion = "Consulto listado de profesores por materia: "
            Dim tab As String = "historial"
            Dim atr As String = "ci,fecha,hora,descripcion,accion"
            Dim inser As String = "('" & Modulos.user & "','" & thisDay & "','" & BAM.hora & ":" & BAM.min & " ','" & descripcion & cmb_PROFESXMATERIAS.Text & ",'Consulto')"
            'MsgBox(Today)
            inshistorial(tab, atr, inser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        datr.Close()


       



        conexion.Close()
    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_LISTAR.Click

    End Sub

    Private Sub cmb_PLANILLADOR_PROFESORESQUEDICTAN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PLANILLADOR_PROFESORESQUEDICTAN.SelectedIndexChanged

        conexion.Open()
        Try



            'aca se obtiene el nombre y apellido del profesor 
            llenar.Connection = conexion
            llenar.CommandText = "Select nombre, apellido from persona where ci = " & cmb_PLANILLADOR_PROFESORESQUEDICTAN.Text
            datr = llenar.ExecuteReader



            datr.Read()
            'aca se carga el label con el nombre y apellido

            lbl_PROFESORSELECCIONADO.Text = datr.GetValue(0).ToString & " " & datr.GetValue(1).ToString
            lbl_PROFESORSELECCIONADO.Visible = True
            lbl_profesor.Visible = True



            'aca se carga el dgv

            dgv_CONSULTOR.ReadOnly = True
            Dim da As New Odbc.OdbcDataAdapter("SELECT m.nombre FROM persona p, dicta d, materia m WHERE p.ci = d.ci And d.cod_materia = m.cod_materia And p.ci = " & cmb_PLANILLADOR_PROFESORESQUEDICTAN.Text, conexion)
            Dim ds As New DataSet
            da.Fill(ds)
            dgv_CONSULTOR.DataSource = ds.Tables(0)



            datr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Try
            '  Guardar en historial - CONSULTOR - ADMINISTRADOR
            Dim descripcion As String
            descripcion = "Consulto listado de materias por profesores: "
            Dim tab As String = "historial"
            Dim atr As String = "ci,fecha,hora,descripcion,accion"
            Dim inser As String = "('" & Modulos.user & "','" & thisDay & "','" & BAM.hora & ":" & BAM.min & " ','" & descripcion & cmb_PLANILLADOR_PROFESORESQUEDICTAN.Text & ",'Consulto')"
            'MsgBox(Today)
            inshistorial(tab, atr, inser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conexion.Close()


    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CONSULTOR_CONSULTARSALON.SelectedIndexChanged

        conexion.Open()
        Try

        


            'aca se obtiene el nombre del salon
            llenar.Connection = conexion
            llenar.CommandText = "Select descripcion from salon where cod_salon = " & cmb_CONSULTOR_CONSULTARSALON.Text
            datr = llenar.ExecuteReader



            datr.Read()
            'aca se carga el label con el nombre y apellido

            lbl_CONSULTOR_CONSULTARSALON.Text = datr.GetValue(0).ToString
            lbl_CONSULTOR_CONSULTARSALON.Visible = True






            'aca cargamos el dgv con los horarios del salon disponible




            cmb_CONSULTOR_CONSULTARSALON.Visible = False




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conexion.Close()

    End Sub

    Private Sub tbp_CONSULTOR_BD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_CONSULTOR_BD.Click

    End Sub

    Private Sub cmb_CONSULTOR_BD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CONSULTOR_BD.SelectedIndexChanged

        conexion.Open()
        Try

            'aca cargamos el dgv con la que se selecciona en el cmb
            dgv_CONSULTOR.ReadOnly = True
            Dim da As New Odbc.OdbcDataAdapter("Select * from " & cmb_CONSULTOR_BD.Text, conexion)
            Dim ds As New DataSet

            da.Fill(ds)
            dgv_CONSULTOR.DataSource = ds.Tables(0)


            





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conexion.Close()




    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmb_BD_SELECCIONE_CI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   

    Private Sub tbp_CONSULTOR_BD_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_CONSULTOR_BD.Leave
        Try

            cmb_FILTRO_HISTORIAL.Text = ""
            '  dgv_CONSULTOR.DataSource = Nothing



        Catch ex As Exception

            MsgBox(ex.Message)

        End Try



    End Sub

    Private Sub tbp_CONSULTOR_DISPONIBILIDADSALONES_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_CONSULTOR_DISPONIBILIDADSALONES.Leave
        lbl_CONSULTOR_CONSULTARSALON.Visible = False
        cmb_CONSULTOR_CONSULTARSALON.Text = ""
        dgv_CONSULTOR.DataSource = Nothing

    End Sub

    Private Sub tbc_CONSULTOR_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbc_CONSULTOR.Leave

    End Sub

    Private Sub tbp_PLANILLADOR_PROFESORESXMATERIA_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_PLANILLADOR_PROFESORESXMATERIA.Leave
        cmb_PLANILLADOR_PROFESORESQUEDICTAN.Text = ""
        cmb_PROFESXMATERIAS.Text = ""
        lbl_PROFESORSELECCIONADO.Visible = False
        dgv_CONSULTOR.DataSource = Nothing

    End Sub

    Private Sub tbp_HORARIOSSEGUNGRUPOS_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_HORARIOSSEGUNGRUPOS.Leave
        dgv_CONSULTOR.DataSource = Nothing

    End Sub

    Private Sub cmb_BD_SELECCIONE_CI_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_FILTRO_HISTORIAL.SelectedIndexChanged

        conexion.Open()

        Try

        
            If cmb_FILTRO_HISTORIAL.Text = "Historial de una persona" Then

                cmb_historial_seleccionar_ci.Items.Clear()



                llenar.Connection = conexion
                llenar.CommandText = "select ci from persona"
                datr = llenar.ExecuteReader

                While datr.Read
                    cmb_historial_seleccionar_ci.Items.Add(datr.GetValue(0).ToString)
                End While
                datr.Close()
                lbl_HISTORIAL_SELECCIONE_CI.Visible = True
                cmb_historial_seleccionar_ci.Visible = True
            Else

                lbl_HISTORIAL_SELECCIONE_CI.Visible = False
                cmb_historial_seleccionar_ci.Visible = False
                lbl_HISTORIAL_NOMBRE.Visible = False
            End If


            If cmb_FILTRO_HISTORIAL.Text = "Todo el historial" Then



                dgv_CONSULTOR.ReadOnly = True
                Dim da As New Odbc.OdbcDataAdapter("Select * from historial ", conexion)
                Dim ds As New DataSet

                da.Fill(ds)
                dgv_CONSULTOR.DataSource = ds.Tables(0)

            End If


            If cmb_FILTRO_HISTORIAL.Text = "Historial por accion" Then



                cmb_SELECCION_DE_SCCION.Visible = True
                lbl_SELECCIONE_ACCION.Visible = True
                cmb_historial_seleccionar_ci.Items.Clear()



                llenar.Connection = conexion
                llenar.CommandText = "select distinct  accion from historial"
                datr = llenar.ExecuteReader
                While datr.Read
                    cmb_SELECCION_DE_SCCION.Items.Add(datr.GetValue(0).ToString)
                End While
                datr.Close()








            Else

                cmb_SELECCION_DE_SCCION.Visible = False
                lbl_SELECCIONE_ACCION.Visible = False
            End If






            If cmb_FILTRO_HISTORIAL.Text = "Historial de una fecha" Then
                CMB_HISTORIAL_FECHA.Visible = True
                lbl_HISTORIAL_SELECCIONE_FECHA.Visible = True
            Else
                CMB_HISTORIAL_FECHA.Visible = False
                lbl_HISTORIAL_SELECCIONE_FECHA.Visible = False
            End If


















        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        conexion.Close()

    End Sub

   
    
    Private Sub tbp_HISTORIAL_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_HISTORIAL.Leave
        dgv_CONSULTOR.DataSource = Nothing

    End Sub

    Private Sub tbp_HISTORIAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_HISTORIAL.Click

    End Sub

    Private Sub cmb_historial_seleccionar_ci_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_historial_seleccionar_ci.SelectedIndexChanged

        conexion.Open()
        Try

        


            If cmb_FILTRO_HISTORIAL.Text = "Historial de una persona" Then



                'aca se obtiene el nombre y apellido de LA PERSONA
                llenar.Connection = conexion
                llenar.CommandText = "Select nombre, apellido from persona where ci = " & cmb_historial_seleccionar_ci.Text
                datr = llenar.ExecuteReader



                datr.Read()

                'aca se carga el label con el nombre y apellido

                lbl_HISTORIAL_NOMBRE.Text = datr.GetValue(0).ToString & " " & datr.GetValue(1).ToString


                lbl_HISTORIAL_NOMBRE.Visible = True

                dgv_CONSULTOR.ReadOnly = True
                Dim da As New Odbc.OdbcDataAdapter("Select * from historial where ci =" & cmb_historial_seleccionar_ci.Text, conexion)
                Dim ds As New DataSet

                da.Fill(ds)
                dgv_CONSULTOR.DataSource = ds.Tables(0)




            Else
                lbl_HISTORIAL_NOMBRE.Visible = False





            End If








          


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


        conexion.Close()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        conexion.Close()
    End Sub

   
    Private Sub cmb_SALON_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_SALON.SelectedIndexChanged
        conexion.Open()

        Try

       

            'aca cargo el cmb cosulta de salon disponibilidad

            'cmb_CONSULTOR_CONSULTARSALON.Items.Clear()
            'cmb_CONSULTOR_CONSULTARSALON.Visible = True
            'lbl_sect_codigo.Visible = True




            'llenar.Connection = conexion
            'llenar.CommandText = "Select  cod_salon from salon where descripcion = '" & cmb_SALON.Text & "'"
            ''"SELECT h.dia, h.hora_inicio, h.hora_fin FROM horario h, salon s, planilla plan WHERE plan.cod_horario= h.cod_horario AND plan.cod_salon=s.cod_salon  AND s.cod_salon=4 "


            'datr = llenar.ExecuteReader

            'While datr.Read
            '    cmb_CONSULTOR_CONSULTARSALON.Items.Add(datr.GetValue(0).ToString)
            'End While
            'datr.Close()
            MsgBox(Split(cmb_SALON.Text, " ")(0))

            dgv_CONSULTOR.ReadOnly = True
            Dim da As New Odbc.OdbcDataAdapter("SELECT h.dia, h.hora_inicio, h.hora_fin FROM horario h, salon s, planilla plan WHERE plan.cod_horario = h.cod_horario And plan.cod_salon = s.cod_salon AND s.cod_salon=" & Split(cmb_SALON.Text, " ")(0), conexion)
            Dim ds As New DataSet

            da.Fill(ds)
            dgv_CONSULTOR.DataSource = ds.Tables(0)



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


        conexion.Close()

    End Sub

    Private Sub cmb_SELECCION_DE_SCCION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_SELECCION_DE_SCCION.SelectedIndexChanged

        conexion.Open()
        Try

       



            dgv_CONSULTOR.ReadOnly = True
            Dim da As New Odbc.OdbcDataAdapter("Select * from historial where accion ='" & cmb_SELECCION_DE_SCCION.Text & "'", conexion)
            Dim ds As New DataSet

            da.Fill(ds)
            dgv_CONSULTOR.DataSource = ds.Tables(0)


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conexion.Close()
    End Sub


  

   
    Private Sub cmb_AÑO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_AÑO.SelectedIndexChanged
        Try

            conexion.Open()
            CmBxVersion_CONSULTOR.Items.Clear()

            llenar.Connection = conexion
            llenar.CommandText = "Select distinct VERSION from planilla where YEAR (FECHA) = '" & cmb_AÑO.Text & "'"

            datr = llenar.ExecuteReader

            While datr.Read
                CmBxVersion_CONSULTOR.Items.Add(datr.GetValue(0).ToString)
            End While
            datr.Close()
            año = cmb_AÑO.Text

            CmBxVersion_CONSULTOR.Enabled = True




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        conexion.Close()

    End Sub

    Private Sub CmBxVersion_CONSULTOR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmBxVersion_CONSULTOR.SelectedIndexChanged
        'Try




        'aca cargamos el dgv con la version que se selecciona en el cmb
        version = CmBxVersion_CONSULTOR.Text
        LLenar_datagrid(dgv_CONSULTOR)
        'dgv_CONSULTOR.ReadOnly = True
        'Dim da As New Odbc.OdbcDataAdapter("Select YEAR(PL.FECHA), h.dia Dia,t.nombre Turno,h.hora_inicio De,h.hora_fin Hasta,s.descripcion Salon,m.nombre Materia,p.nombre Pro,p.apellido fesor,g.descripcion Grupo from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and version= " & CmBxVersion_CONSULTOR.Text & " and fecha>= '01/01/" & cmb_AÑO.Text & "' and fecha <= '30/12/" & cmb_AÑO.Text & "'", conexion)
        'Dim ds As New DataSet

        'da.Fill(ds)
        'dgv_CONSULTOR.DataSource = ds.Tables(0)

        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try

        Try
            '  Guardar en historial - CONSULTOR - ADMINISTRADOR
            Dim descripcion As String
            descripcion = "Consulto planilla: "
            Dim tab As String = "historial"
            Dim atr As String = "ci,fecha,hora,descripcion,accion"
            Dim inser As String = "('" & Modulos.user & "','" & thisDay & "','" & BAM.hora & ":" & BAM.min & " ','" & descripcion & " version Nro" & CmBxVersion_CONSULTOR.Text & ",'Consulto')"
            'MsgBox(Today)
            inshistorial(tab, atr, inser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conexion.Close()
    End Sub

    Private Sub tbp_CONDULTOR_PLANILLA_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbp_CONDULTOR_PLANILLA.Leave
        dgv_CONSULTOR.DataSource = Nothing

    End Sub

    Private Sub CMB_HISTORIAL_FECHA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_HISTORIAL_FECHA.SelectedIndexChanged

        Try

            dgv_CONSULTOR.ReadOnly = True
            Dim da As New Odbc.OdbcDataAdapter("Select DISTINCT fecha, hora, accion,descripcion  from historial where DAY (fecha) = '" & Mid(CMB_HISTORIAL_FECHA.Text, 1, 2) & "' AND MONTH (FECHA) = '" & Mid(CMB_HISTORIAL_FECHA.Text, 4, 2) & "' AND YEAR(FECHA)= '" & Mid(CMB_HISTORIAL_FECHA.Text, 7, 4) & "'", conexion)

          
            Dim ds As New DataSet

            da.Fill(ds)
            dgv_CONSULTOR.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub dgv_CONSULTOR_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgv_CONSULTOR.CellPainting

        Dim z As Integer = 0
        While z <> dgv_CONSULTOR.Columns.Count
            If e.ColumnIndex = z Then
                If e.RowIndex + 1 < dgv_CONSULTOR.Rows.Count Then
                    If z = 0 Then
                    End If
                    If e.Value = dgv_CONSULTOR.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value Then
                        e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None 'borra las rallita
                    End If
                    If e.RowIndex >= 1 Then
                        If e.Value = dgv_CONSULTOR.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value Then
                            e.Graphics.FillRectangle(New SolidBrush(e.CellStyle.BackColor), e.CellBounds)
                            e.PaintBackground(e.CellBounds, False) 'deja aparecer el fondo blanco
                            e.Handled = True
                        End If
                    End If
                End If
            End If
            z = z + 1
        End While
    End Sub
End Class

