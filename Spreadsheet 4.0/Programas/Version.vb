Imports System.Data.Odbc
Public Class Version
    Dim datr As Odbc.OdbcDataReader
    Dim llenar As New Odbc.OdbcCommand
    Dim nom As Integer
    Dim cm As New OdbcCommand
    Dim version As Integer
    Dim result As DialogResult
    Dim elegido As Integer
    Dim año As Integer


    Private Sub LLenar_datagrid_chcklist(ByVal dgv As DataGridView)

        '########################################################33
        ''Colores y ordenados igual que la carpeta
        'Dim a As Integer = 0


        'dgv.DataSource = Nothing
        'conexion.Close()
        'conexion.Open()
        'llenar.Connection = conexion
        'llenar.CommandText = "select cod_salon from planilla where version=" & version & " group by cod_salon"
        'datr = llenar.ExecuteReader

        'While datr.Read
        '    a = a + 1
        'End While
        'datr.Close()

        'Dim cod_salon(a) As String
        'Dim b As Integer = 0
        'datr = llenar.ExecuteReader
        'While datr.Read
        '    cod_salon(b) = datr.GetValue(0).ToString
        '    b = b + 1
        'End While
        'datr.Close()
        'conexion.Close()

        'Dim fila As Integer = 0
        'Dim columna As Integer = 0
        'Dim c As Integer = 0
        'b = 0
        'dgv.Columns.Add(0, "Turno")
        'dgv.Columns.Add(1, "Dia")
        'dgv.Columns.Add(2, "")
        'dgv.Columns.Add(3, "Horario")

        'While b <> a
        '    If b = 0 Then
        '        conexion.Open()
        '        llenar.Connection = conexion
        '        llenar.CommandText = "Select t.nombre turno, h.dia dia, h.numero_hora hora, h.hora_inicio inicio, hora_fin fin, s.descripcion, s.tipo,  g.descripcion, m.nombre, p.nombre, p.apellido from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and pl.version=" & version & " and pl.cod_salon=" & cod_salon(b) & " order by t.cod_turno, pl.cod_salon, h.dia, h.numero_hora"
        '        datr = llenar.ExecuteReader

        '        While datr.Read
        '            If c = 0 Then
        '                dgv.Columns.Add(4, datr.GetValue(5).ToString() & " " & datr.GetValue(6).ToString())
        '                c = c + 1
        '            End If
        '            If datr.GetValue(0).ToString() = "Matutino" Then
        '                DGVPlanilla.RowTemplate.DefaultCellStyle.BackColor = Color.LightBlue
        '            ElseIf datr.GetValue(0).ToString() = "Vespertino" Then
        '                DGVPlanilla.RowTemplate.DefaultCellStyle.BackColor = Color.GreenYellow
        '            ElseIf datr.GetValue(0).ToString() = "Nocturno" Then
        '                DGVPlanilla.RowTemplate.DefaultCellStyle.BackColor = Color.IndianRed
        '            End If
        '            dgv.Rows.Add(datr.GetValue(0).ToString(), datr.GetValue(1).ToString(), datr.GetValue(2).ToString() & "°", datr.GetValue(3).ToString() & " - " & datr.GetValue(4).ToString(), datr.GetValue(7).ToString() & " - " & datr.GetValue(8).ToString() & " - " & datr.GetValue(9).ToString() & " " & datr.GetValue(10).ToString())

        '        End While

        '        datr.Close()
        '        conexion.Close()
        '        columna = 5

        '    Else
        '        conexion.Open()
        '        llenar.Connection = conexion
        '        llenar.CommandText = "Select s.descripcion, s.tipo,  g.descripcion, m.nombre, p.nombre, p.apellido from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and pl.version=" & version & " and pl.cod_salon=" & cod_salon(b) & " order by t.nombre, pl.cod_salon, h.dia, h.numero_hora"
        '        datr = llenar.ExecuteReader

        '        While datr.Read
        '            c = c - 1
        '            If c = 0 Then
        '                dgv.Columns.Add(columna, datr.GetValue(0).ToString() & " " & datr.GetValue(1).ToString())
        '                c = c + 99999
        '            End If
        '            dgv.Item(columna, fila).Value = (datr.GetValue(2).ToString() & " - " & datr.GetValue(3).ToString() & " - " & datr.GetValue(4).ToString() & " " & datr.GetValue(5).ToString())
        '            fila = fila + 1

        '        End While
        '        columna = columna + 1
        '        datr.Close()
        '        conexion.Close()

        '    End If
        '    b = b + 1

        'End While

        'dgv.Columns(0).Visible = False
        'dgv.Columns(1).Frozen = True
        'dgv.Columns(2).Frozen = True
        'dgv.Columns(3).Frozen = True




        '#############################################################################

        ''Llenar el check listbox


        'lleno denuevo las lineas
        ChkLBxFilas.Items.Clear()

        conexion.Close()

        conexion.Open()
        llenar.Connection = conexion
        llenar.CommandText = "Select h.dia Dia,t.nombre Turno,h.hora_inicio De,h.hora_fin Hasta,s.descripcion Salon, s.tipo Tipo_salon,m.nombre Materia,p.ci Profesor,g.descripcion Grupo from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and version=1 and fecha='1/1/2000' order by t.nombre, h.dia, h.numero_hora"

        datr = llenar.ExecuteReader

        While datr.Read
            ChkLBxFilas.Items.Add(datr.GetValue(0).ToString & " | " & datr.GetValue(1).ToString & " | " & datr.GetValue(2).ToString & " | " & datr.GetValue(3).ToString & " | " & datr.GetValue(4).ToString & " | " & datr.GetValue(5).ToString & " | " & datr.GetValue(6).ToString & " | " & datr.GetValue(7).ToString & " | " & datr.GetValue(8).ToString)
        End While
        datr.Close()
        conexion.Close()

        dgv.DataSource = Nothing

        'llenar dgv
        Dim cm As New OdbcCommand

        conexion = New OdbcConnection(stringconexion)
        cm.Connection = conexion
        conexion.ConnectionString = stringconexion
        conexion.Open()

        dgv.ReadOnly = True
        Dim da As New Odbc.OdbcDataAdapter("Select h.dia Dia,t.nombre Turno,h.hora_inicio De,h.hora_fin Hasta,s.descripcion Salon,m.nombre Materia,p.ci profesor,g.descripcion Grupo from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and version=" & version & "AND year(fecha)='" & año & "'", conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)

        Dim count As Integer = 0

        conexion.Close()

    End Sub

    'Private Sub DGVPlanilla_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DGVPlanilla.CellPainting

    '    ''agrupar planilla
    '    'Dim z As Integer = 0

    '    'While z <> DGVPlanilla.Columns.Count
    '    '    If e.ColumnIndex = z Then
    '    '        If e.RowIndex + 1 < DGVPlanilla.Rows.Count Then
    '    '            If z = 0 Then
    '    '            End If
    '    '            If e.Value = DGVPlanilla.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value Then
    '    '                e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None 'borra las rallita
    '    '            End If
    '    '            If e.RowIndex >= 1 Then
    '    '                If e.Value = DGVPlanilla.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value Then
    '    '                    e.Graphics.FillRectangle(New SolidBrush(e.CellStyle.BackColor), e.CellBounds)
    '    '                    e.PaintBackground(e.CellBounds, False) 'deja aparecer el fondo blanco
    '    '                    e.Handled = True
    '    '                End If
    '    '            End If
    '    '        End If
    '    '    End If
    '    '    z = z + 1
    '    'End While
    'End Sub


    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxBxAño.Leave

        conexion.Close()
        datr.Close()

        CmBxVersion.Items.Clear()
        conexion = New OdbcConnection(stringconexion)
        cm.Connection = conexion
        conexion.ConnectionString = stringconexion

        CmBxVersion.Items.Clear()
        conexion.Open()
        llenar.Connection = conexion
        If TxBxAño.Text <> "" Then
            año = TxBxAño.Text
        End If
        'cambiar para la utu
        'llenar.CommandText = "Select version from planilla where fecha>=year(fecha)='" & año & "' group by version"
        llenar.CommandText = "Select version from planilla where year(fecha)='" & año & "' group by version"
        datr = llenar.ExecuteReader

        While datr.Read
            CmBxVersion.Items.Add(datr.GetValue(0).ToString)
        End While
        datr.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click

        version = CmBxVersion.Text
        año = TxBxAño.Text
        LLenar_datagrid_chcklist(DGVPlanilla)
        CmBxVersion.Enabled = False
        TxBxAño.Enabled = False
        ChkLBxFilas.Enabled = True



    End Sub

    Private Sub Version_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.Close()
        año = Now.Year

        TxBxAño.Enabled = True
        TxBxAño.Select()
        CmBxVersion.Enabled = True
        ChkLBxFilas.Enabled = False


        conexion = New OdbcConnection(stringconexion)
        cm.Connection = conexion
        conexion.ConnectionString = stringconexion

        result = MessageBox.Show("Va crear una planilla completamente nueva(si) o va a usar otra como base(no) ", "Crear Versionado", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        conexion.Open()
        llenar.Connection = conexion
        llenar.CommandText = "Select h.dia Dia,t.nombre Turno,h.hora_inicio De,h.hora_fin Hasta,s.descripcion Salon, s.tipo Tipo_salon,m.nombre Materia,p.ci Profesor,g.descripcion Grupo from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and version=1 and fecha='1/1/2000'"
        datr = llenar.ExecuteReader

        While datr.Read
            ChkLBxFilas.Items.Add(datr.GetValue(0).ToString & " | " & datr.GetValue(1).ToString & " | " & datr.GetValue(2).ToString & " | " & datr.GetValue(3).ToString & " | " & datr.GetValue(4).ToString & " | " & datr.GetValue(5).ToString & " | " & datr.GetValue(6).ToString & " | " & datr.GetValue(7).ToString & " | " & datr.GetValue(8).ToString)
        End While
        datr.Close()
        conexion.Close()

        If result = System.Windows.Forms.DialogResult.Yes Then
            PanelVersionNueva.Visible = False
            conexion.Close()
            conexion.Open()
            llenar.Connection = conexion
            llenar.CommandText = "select version from planilla where year(fecha)='" & año & "' group by version order by version desc"
            datr = llenar.ExecuteReader
            datr.Read()


            version = datr.GetValue(0).ToString + 1

            MsgBox("Esta creando la version: " & version & " del año " & año)
            conexion.Close()
            ChkLBxFilas.Enabled = True

        ElseIf result = System.Windows.Forms.DialogResult.No Then
            PanelVersionNueva.Visible = True

        End If


    End Sub

    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        Dim ta As String = "planilla"
        Dim at As String = "fecha,cod_salon,cod_horario,cod_materia,ci,cod_grupo,version,baja,hora,descripcion"

        Dim a_grupo As Integer
        Dim a_turno As Integer
        Dim a_horario As Integer
        Dim a_salon As Integer
        Dim a_materia As Integer


        For Each lista In ChkLBxFilas.CheckedItems
            'grupo
            conexion.Close()
            conexion.Open()
            llenar.Connection = conexion
            llenar.CommandText = "select cod_grupo from grupo where descripcion ='" & Split(lista.ToString, " | ")(8) & "'"
            a_grupo = llenar.ExecuteScalar
            datr.Close()
            conexion.Close()

            'turno
            conexion.Open()
            llenar.Connection = conexion
            llenar.CommandText = "select cod_turno from turno where nombre ='" & Split(lista.ToString, " | ")(1) & "'"
            a_turno = llenar.ExecuteScalar
            datr.Close()
            conexion.Close()

            'horario
            conexion.Open()
            llenar.Connection = conexion
            llenar.CommandText = "Select cod_horario from horario where dia='" & Split(lista.ToString, " | ")(0) & "' AND cod_turno=" & a_turno & " AND hora_inicio='" & Split(lista.ToString, " | ")(2) & "' AND hora_fin='" & Split(lista.ToString, " | ")(3) & "'"
            a_horario = llenar.ExecuteScalar
            datr.Close()
            conexion.Close()

            'Salon
            conexion.Open()
            llenar.Connection = conexion
            llenar.CommandText = "select cod_salon from salon where descripcion ='" & Split(lista.ToString, " | ")(4) & "'AND tipo ='" & Split(lista.ToString, " | ")(5) & "'"
            a_salon = llenar.ExecuteScalar
            datr.Close()
            conexion.Close()

            'materia
            conexion.Open()
            llenar.Connection = conexion
            llenar.CommandText = "select cod_materia from materia where nombre ='" & Split(lista.ToString, " | ")(6) & "'"
            a_materia = llenar.ExecuteScalar
            datr.Close()
            conexion.Close()

            'cambiar en UTU
            'Dim ins As String = "('" & Today & "', " & a_salon & ", " & a_horario & ", " & a_materia & "," & Split(lista.ToString, " | ")(7) & ", " & a_grupo & ", " & version & ", 'no' ,'" & Now.Hour & ":" & Now.Minute & "', ' " & Split(lista.ToString, " | ")(8) & " ')"
            Dim ins As String = "('01/01/" & Now.Year & "', " & a_salon & ", " & a_horario & ", " & a_materia & "," & Split(lista.ToString, " | ")(7) & ", " & a_grupo & ", " & version & ", 'no' ,'" & Now.Hour & ":" & Now.Minute & "', ' " & Split(lista.ToString, " | ")(8) & " ')"
            altas(ta, at, ins)
        Next
        LLenar_datagrid_chcklist(DGVPlanilla)
    End Sub

    Private Sub Desagrupar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Desagrupar.Click
        Dim ta As String = "planilla"
        Dim at1 As String = "version"
        Dim at2 As String = "1"

        Dim a_turno As Integer
        Dim a_horario As Integer
        Dim a_salon As Integer

        'turno
        conexion.Open()
        llenar.Connection = conexion
        llenar.CommandText = "select cod_turno from turno where nombre ='" & DGVPlanilla.Item(1, elegido).Value() & "'"
        a_turno = llenar.ExecuteScalar
        datr.Close()
        conexion.Close()

        'horario
        conexion.Open()
        llenar.Connection = conexion
        llenar.CommandText = "Select cod_horario from horario where dia='" & DGVPlanilla.Item(0, elegido).Value() & "' AND cod_turno=" & a_turno & " AND hora_inicio='" & DGVPlanilla.Item(2, elegido).Value() & "' AND hora_fin='" & DGVPlanilla.Item(3, elegido).Value() & "'"
        a_horario = llenar.ExecuteScalar
        datr.Close()
        conexion.Close()

        'Salon
        conexion.Open()
        llenar.Connection = conexion
        llenar.CommandText = "select s.cod_salon from salon s, planilla pl where s.descripcion ='" & DGVPlanilla.Item(4, elegido).Value() & "' and s.cod_salon=pl.cod_grupo and pl.version=" & version & " AND year(fecha)='" & año & "'"
        a_salon = llenar.ExecuteScalar
        datr.Close()
        conexion.Close()

        'cambiar en UTU
        'Dim ins As String = "('" & Today & "', " & a_salon & ", " & a_horario & ", " & a_materia & "," & Split(lista.ToString, " | ")(7) & ", " & a_grupo & ", " & version & ", 'no' ,'" & Now.Hour & ":" & Now.Minute & "', ' " & Split(lista.ToString, " | ")(8) & " ')"
        Dim con As String = "version=" & version & " and year(fecha)='" & año & "' and cod_horario=" & a_horario & " and cod_salon=" & a_salon
        modificacionesplani(ta, at1, at2, con)
        LLenar_datagrid_chcklist(DGVPlanilla)


    End Sub

    Private Sub DGVPlanilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVPlanilla.CellClick
        elegido = DGVPlanilla.CurrentRow.Index
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Borrar.Click
        Planillador.Show()
        Planillador.MdiParent = Principal
        Planillador.Panel_Bajas.Visible = True
        Planillador.cmb_PLANI_BAJAS_VERSION.Text = version
        Planillador.cmb_PLANI_BAJAS_VERSION.Enabled = True


        Planillador.dgv_PLANI_BAJAS.ReadOnly = True
        Dim da As New Odbc.OdbcDataAdapter("Select h.dia Dia,t.nombre Turno,h.hora_inicio De,h.hora_fin Hasta,s.descripcion Salon,m.nombre Materia,p.nombre Pro,p.apellido fesor,g.descripcion Grupo from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and version=" & Planillador.cmb_PLANI_BAJAS_VERSION.Text & "and pl.baja='no'", conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        Planillador.dgv_PLANI_BAJAS.DataSource = ds.Tables(0)

        conexion.Close()
        Planillador.dgv_PLANI_BAJAS.Rows(elegido).Selected = True
        Me.Close()



    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        Planillador.Show()
        Planillador.MdiParent = Principal
        Planillador.Panel_modificaciones.Visible = True
        Planillador.txb_PLANI_MODI_VERSION.Text = version
        Planillador.txb_PLANI_MODI_VERSION.Enabled = False


        conexion.Close()

        conexion.Open()


        Dim cm As New OdbcCommand


        Planillador.dgv_PLANI_MODI.ReadOnly = True
        Dim da As New Odbc.OdbcDataAdapter("Select h.dia Dia,t.nombre Turno,h.hora_inicio De,h.hora_fin Hasta,s.descripcion Salon,m.nombre Materia,p.nombre Pro,p.apellido fesor,g.descripcion Grupo,pl.baja Baja,pl.descripcion Descripcion from turno t,salon s,horario h,materia m, persona p,grupo g,planilla pl where p.ci=pl.ci and pl.cod_horario = h.cod_horario and pl.cod_salon=s.cod_salon and pl.cod_grupo=g.cod_grupo and pl.cod_materia=m.cod_materia and h.cod_turno=t.cod_turno and version=" & Planillador.txb_PLANI_MODI_VERSION.Text & "", conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        Planillador.dgv_PLANI_MODI.DataSource = ds.Tables(0)


        Planillador.cmb_PLANILLA_MODIFICAR_TURNO.Items.Clear()


        llenar.Connection = conexion
        llenar.CommandText = "Select nombre from turno where baja='no'"
        datr = llenar.ExecuteReader

        While datr.Read
            Planillador.cmb_PLANILLA_MODIFICAR_TURNO.Items.Add(datr.GetValue(0).ToString)
        End While
        datr.Close()

        Planillador.cmb_PLANILLA_MODIFICAR_GRUPO.Items.Clear()

        llenar.Connection = conexion
        llenar.CommandText = "Select descripcion from grupo where baja='no'"
        datr = llenar.ExecuteReader

        While datr.Read
            Planillador.cmb_PLANILLA_MODIFICAR_GRUPO.Items.Add(datr.GetValue(0).ToString)
        End While
        datr.Close()

        llenar.Connection = conexion
        llenar.CommandText = "Select nombre from materia where baja='no'"
        datr = llenar.ExecuteReader

        While datr.Read
            Planillador.cmb_PLANILLA_MODIFICAR_MATERIA.Items.Add(datr.GetValue(0).ToString)
        End While
        datr.Close()


        Planillador.dgv_PLANI_MODI.Rows(elegido).Selected = True

        Planillador.cmb_PLANILLA_MODIFICAR_HORA.Text = DGVPlanilla.Item(2, elegido).Value() & " hasta " & DGVPlanilla.Item(3, elegido).Value()
        Planillador.cmb_PLANILLA_MODIFICAR_MATERIA.Text = DGVPlanilla.Item(5, elegido).Value()
        Planillador.cmb_PLANILLA_MODIFICAR_SALON.Text = DGVPlanilla.Item(4, elegido).Value()
        Planillador.cmb_PLANILLA_MODIFICAR_DIA.Text = DGVPlanilla.Item(0, elegido).Value()
        Planillador.cmb_PLANILLA_MODIFICAR_TURNO.Text = DGVPlanilla.Item(1, elegido).Value()
        Planillador.cmb_PLANILLA_MODIFICAR_GRUPO.Text = DGVPlanilla.Item(7, elegido).Value()
        Planillador.cmb_PLANILLA_MODIFICAR_BAJA.Text = "No"
        Planillador.cmb_PLANILLA_MODIFICAR_PROFESOR.Text = DGVPlanilla.Item(7, elegido).Value()

        Me.Close()
    End Sub

End Class