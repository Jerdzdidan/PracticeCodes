
Imports MySql.Data.MySqlClient     ' mysql library
Imports System.Data
Imports System.IO
Public Class Class1
    Public Shared connection As New MySqlConnection 'database connection
    Public Shared DSRec As New DataTable 'storage for the query result (select)
    Public Shared DARec As New MySqlDataAdapter 'filling of query result into the dataset
    Public Shared cb As New MySqlCommandBuilder 'building the sql statement
    Public Shared successID, rowAffected As Integer
    Public Shared loginuser, logintype, action As String

    'function for the select statement
    Public Shared Function GetDataTable(ByVal strsql As String) As DataTable
        Dim ds As New DataSet
        Try
            'connecting into the database
            'server = server name
            'database = db name
            'Uid (username)
            'Pwd (password)
            Dim sqlcon As New MySqlConnection("Server = localhost; Database = itc124cs2a2024; Uid = Jerdan; Pwd = Gondayao; CharSet = utf8;")
            'build the sql statement to the sql connection
            Dim sqlCom As New MySqlCommand(strsql, sqlcon)
            ''get the data from the sqlcommand and place it to the sqladapter
            Dim sqLadap As New MySqlDataAdapter(sqlCom)
            ds.Clear() 'clear the dataset
            'fill the data on the sqladapter to the dataset
            sqLadap.Fill(ds, "data")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Message")
        End Try
        Return ds.Tables(0)
    End Function

    'adding,updating,deleting
    Public Shared Sub executeSQL(ByVal strsql As String)
        Try
            Dim sqlcon As New MySqlConnection("Server = localhost; Database = itc124cs2a2024; Uid = Jerdan; Pwd = Gondayao; CharSet = utf8;")
            Dim sqlcom As New MySqlCommand(strsql, sqlcon)
            sqlcon.Open() 'open the database connection
            rowAffected = sqlcom.ExecuteNonQuery() 'execute insert,update,or delete
            sqlcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Message")
        End Try
    End Sub
End Class
