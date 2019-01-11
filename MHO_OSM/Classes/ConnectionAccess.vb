Imports System.Data.OleDb

Public Class ConnectionAccess
    Dim conn As New OleDb.OleDbConnection()
    Public _Database As String = "OSM.mdb"
    Public _ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\" & _Database & ";Persist Security Info=False;"
    Dim ds As New DataSet
    Dim sql_DataReader As String = ""
    Dim sql_DataTable As String = ""
    Dim sql_ExecuteQuery As String = ""

    Private Sub Access_connector()
        conn = New OleDb.OleDbConnection
        conn.ConnectionString = _ConnectionString
        conn.Open()
    End Sub

    Sub Options(ByVal Sql As String, ByVal cbo As ComboBox, ByVal val As String, ByVal disp As String)
        Try
            Me.sql_DataTable = Sql
            Access_connector()
            Dim cmd As New OleDbCommand(Sql, conn)

            Dim da As New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)

            cbo.DataSource = ds.Tables(0)
            cbo.ValueMember = val
            cbo.DisplayMember = disp
            cbo.SelectedIndex = 0
            conn.Close()

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub View(ByVal SQL As String, ByVal dgv As DataGridView)

        Try
            Me.sql_DataTable = SQL
            Access_connector()
            Dim cmd As New OleDbCommand(SQL, conn)

            Dim da As New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)
            dgv.DataSource = ds.Tables(0)

            cmd.Connection.Close()
            cmd.Connection.Dispose()
            cmd.Connection = Nothing
            cmd.Parameters.Clear()
            cmd.Dispose()
            cmd = Nothing
            Access_disconnect()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (conn.State = System.Data.ConnectionState.Open) Then
                Access_disconnect()
            End If
        End Try

    End Sub
    Public Function ManualView(ByVal SQL As String) As DataSet

        Try
            Me.sql_DataTable = SQL
            Access_connector()
            Dim cmd As New OleDbCommand(SQL, conn)

            Dim da As New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)


            cmd.Connection.Close()
            cmd.Connection.Dispose()
            cmd.Connection = Nothing
            cmd.Parameters.Clear()
            cmd.Dispose()
            cmd = Nothing
            Access_disconnect()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (conn.State = System.Data.ConnectionState.Open) Then
                Access_disconnect()
            End If
        End Try
        Return ds
    End Function
    

    Public Function Search(ByVal SQL As String) As String
        Dim table As New DataTable

        Try
            Me.sql_DataReader = SQL
            Access_connector()
            Dim cmd As New OleDbCommand(SQL, conn)
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(table)
            cmd.Connection.Close()
            cmd.Connection.Dispose()
            cmd.Connection = Nothing
            cmd.Parameters.Clear()
            cmd.Dispose()
            cmd = Nothing
            Access_disconnect()
            Return table.Rows(0)(0).ToString
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        Finally
            If (conn.State = System.Data.ConnectionState.Open) Then
                Access_disconnect()
            End If
        End Try
    End Function







    Private Sub Access_disconnect()
        conn.Close()
        conn.Dispose()
    End Sub

    Public Function getDataReader(ByVal SQL As String) As OleDbDataReader
        Dim dr As OleDbDataReader

        Try
            Me.sql_DataReader = SQL
            Access_connector()
            Dim cmd As New OleDbCommand(SQL, conn)
            dr = cmd.ExecuteReader
            cmd.Connection.Close()
            cmd.Connection.Dispose()
            cmd.Connection = Nothing
            cmd.Parameters.Clear()
            cmd.Dispose()
            cmd = Nothing
            Access_disconnect()
            Return dr
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (conn.State = System.Data.ConnectionState.Open) Then
                Access_disconnect()
            End If
        End Try
        dr = Nothing
        Return dr
    End Function


    Public Function getDataTable(ByVal SQL As String) As DataTable
        Dim table As New DataTable

        Try
            Me.sql_DataTable = SQL
            Access_connector()
            Dim cmd As New OleDbCommand(SQL, conn)

            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(table)
            cmd.Connection.Close()
            cmd.Connection.Dispose()
            cmd.Connection = Nothing
            cmd.Parameters.Clear()
            cmd.Dispose()
            cmd = Nothing
            Access_disconnect()
            Return table
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (conn.State = System.Data.ConnectionState.Open) Then
                Access_disconnect()
            End If
        End Try
        Return table
    End Function

    Public Sub ExecuteQuery(ByVal SQL As String)
        Try
            'MsgBox(SQL)
            Access_connector()
            Me.sql_ExecuteQuery = SQL
            Dim cmd As New OleDbCommand(SQL, conn)
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            cmd.Connection.Dispose()
            cmd.Connection = Nothing
            cmd.Parameters.Clear()
            cmd.Dispose()
            cmd = Nothing
            conn.Close()
            conn.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (conn.State = System.Data.ConnectionState.Open) Then
                Access_disconnect()
            End If
        End Try
    End Sub

    Public Sub getMsgSqlDataReader()
        MsgBox(sql_DataReader)
    End Sub
    Public Function getSqlDataReader() As String
        Return sql_DataReader
    End Function

    Public Sub getMsgSqlDataTable()
        MsgBox(sql_DataTable)
    End Sub
    Public Function getSqlDataTable() As String
        Return sql_DataTable
    End Function

    Public Sub getMsgSqlExecuteQuery()
        MsgBox(sql_ExecuteQuery)
    End Sub
    Public Function getSqlExecuteQuery() As String
        Return sql_ExecuteQuery
    End Function

End Class