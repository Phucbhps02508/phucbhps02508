Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmyesno.ShowDialog()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click, btnLogin.Enter
        Dim connectstring As String = "workstation id=Phucbhps02508.mssql.somee.com;packet size=4096;user id=phucbhps02508_SQLLogin_1;pwd=a6hi7bn771;data source=Phucbhps02508.mssql.somee.com;persist security info=False;initial catalog=Phucbhps02508"
        Dim connect As SqlConnection = New SqlConnection(connectstring)
        Dim sqlAdapter As New SqlDataAdapter("Select * from Account where ID='" & txtID.Text & "' and Pass='" & txtPass.Text & "' ", connect)

        Dim tb As New DataTable

        Try
            connect.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Welcome !")
                frmMain.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show("Wrong ID Or Password")
        End Try
    End Sub
End Class