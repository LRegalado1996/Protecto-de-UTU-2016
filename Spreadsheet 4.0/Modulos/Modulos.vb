Imports System.Data.Odbc

Module Modulos
    Public tipo As String
    Public ci As Integer
    Public consulta As String
    Dim cm As New OdbcCommand
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Public conectadonom As String
    Public conectadoape As String
    Public user As String

    'gallego
    Public stringconexion As String = "Filedsn=C:\miodbc.dsn;UID=informix;PWD=nano0492"

    'Regalado
    'Public stringconexion As String = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};UID=informix;PWD=Abc123...;DATABASE=tercero_ih_grupo_6;HOST=*DESKTOP-VG2ROSA;SERVER=ol_informix1170_1;SERVICE=ol_informix1170_1;PROTOCOL=olsoctcp;CLIENT_LOCALE=en_US.CP1252;DB_LOCALE=en_US.819"

    'UTU
    'Public stringconexion As String = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};UID=lregalado;PWD=Abc123...;DATABASE=spreadsheet_us;HOST=10.0.29.6;SERVER=ol_informix1;SERVICE=1526;PROTOCOL=olsoctcp;CLIENT_LOCALE=en_US.CP1252;DB_LOCALE=en_US.819"

    Public conexion As New OdbcConnection

    Public Function altas(ByVal tabla As String, ByVal atributos As String, ByVal insertados As String)
        'Modulo de altas
        Try

            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion
            conexion.Open()

            consulta = "INSERT INTO " & tabla & " (" & atributos & ") Values " & insertados
            cm.CommandText = consulta
            cm.ExecuteReader()
            conexion.Close()
            Return cm

        Catch ex As Odbc.OdbcException
            MsgBox(ex.Message)
            Return ex.Message

        End Try

    End Function

    Public Function modificaciones(ByVal tabla As String, ByVal atributos As String, ByVal insert As String, ByVal fila As String, ByVal pk As String)
        'Modulo Modificaciones
        Try
            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion
            conexion.Open()

            consulta = "UPDATE " & tabla & " SET ( " & atributos & " ) = ( " & insert & " ) WHERE " & fila & " = " & pk
            cm.CommandText = consulta

            cm.ExecuteReader()

            'Return

        Catch ex As Odbc.OdbcException
            MsgBox(ex.Message)

        End Try
        conexion.Close()
        Return 1
    End Function

   

    Public Function modificacionesplani(ByVal tabla As String, ByVal atributos As String, ByVal insert As String, ByVal fila As String)
        'Modulo Modificaciones
        Try
            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion
            conexion.Open()

            consulta = "UPDATE " & tabla & " SET ( " & atributos & " ) = ( " & insert & " ) WHERE " & fila
            cm.CommandText = consulta

            cm.ExecuteReader()

            'Return

        Catch ex As Odbc.OdbcException
            MsgBox(ex.Message)

        End Try
        conexion.Close()
        Return 1
    End Function

    Public Function listar(ByVal tabla As String)

        Try

            Dim cm As New OdbcCommand

            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion
            conexion.Open()
            Dim datr As Odbc.OdbcDataReader
            Dim llenar As New Odbc.OdbcCommand

            llenar.Connection = conexion
            llenar.CommandText = tabla
            datr = llenar.ExecuteReader
            datr.Read()


                Return 0




        Catch ex As Odbc.OdbcException
            Return ex.Message

        End Try
        conexion.Close()
    End Function

    Public Function borrar(ByVal tabla As String, ByVal codigo As String, ByVal ingreso As String)
        Try
            'Modulos de eliminar
            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion
            conexion.Open()

            cm.CommandText = "DELETE " & tabla & " WHERE " & codigo & " = " & ingreso
            cm.ExecuteReader()
            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()


        End Try

        Return 1
    End Function

    Public Function desactivar(ByVal tabla As String, ByVal codigo As String, ByVal ingreso As String)

        Try
            'Modulo de baja logica
            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion
            conexion.Open()

            cm.CommandText = "UPDATE " & tabla & " SET baja = 'si' WHERE " & codigo & " = " & ingreso
            cm.ExecuteReader()
            conexion.Close()

            Return cm
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ex.Message
        End Try

    End Function


    'Modulo Verificar Cedula
    Public Function Verificar(ByVal ci As String, ByVal verificador As String)
        Dim SumaVerificarCi As Integer
        Dim ResultadoVerificarCi As Integer
        Dim Algoritmo() As Integer = {2, 9, 8, 7, 6, 3, 4}

        For i As Integer = 0 To 6
            SumaVerificarCi += CInt(ci.Substring(i, 1)) * Algoritmo(i)
        Next
        ResultadoVerificarCi = SumaVerificarCi + CInt(verificador)
        If Mid(ResultadoVerificarCi.ToString, 3, 1) = "0" Then
            Return 1
        Else
            Return 2
        End If

    End Function


    Public Function borrarplani(ByVal tabla As String, ByVal codigo As String)
        Try
            'Modulos de eliminar
            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion
            conexion.Open()

            cm.CommandText = "DELETE " & tabla & " WHERE " & codigo
            cm.ExecuteReader()
            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Return 1
    End Function


    Public Function inshistorial(ByVal tabla As String, ByVal atributos As String, ByVal insertados As String)
        'Modulo insert Historial
        Try

            conexion = New OdbcConnection(stringconexion)
            cm.Connection = conexion
            conexion.ConnectionString = stringconexion
            conexion.Open()

            consulta = "INSERT INTO " & tabla & " (" & atributos & ") Values " & insertados
            cm.CommandText = consulta
            cm.ExecuteReader()
            conexion.Close()
            Return cm

        Catch ex As Odbc.OdbcException
            MsgBox(ex.Message)
            Return ex.Message

        End Try

    End Function





End Module
