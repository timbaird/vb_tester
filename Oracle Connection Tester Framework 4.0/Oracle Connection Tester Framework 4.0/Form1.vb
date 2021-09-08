Public Class Form1


    Private Sub TestConnectionBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestConnectionBtn.Click
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        rvConn = CreateConnection1()
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction = Nothing
        Try

            rvConn.Open()
            MessageBox.Show("Oracle Connection OK")
        Catch ex As Exception
            MessageBox.Show("No Connection")
        Finally
            rvConn.Close()
        End Try
    End Sub
    Public Function CreateConnection1() As Oracle.DataAccess.Client.OracleConnection
        Dim rvConn As New Oracle.DataAccess.Client.OracleConnection
        rvConn.ConnectionString = GetConnectionString()
        Return rvConn
    End Function
    Function GetConnectionString() As String
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=ictoraclesvm1.ict.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=" & TB_User.Text & ";"
        vConnStr = vConnStr & "Password=" & TB_Pass.Text & ";"
        MessageBox.Show(vConnStr)

        Return vConnStr
    End Function

End Class
