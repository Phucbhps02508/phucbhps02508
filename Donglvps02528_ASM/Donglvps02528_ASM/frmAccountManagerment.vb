Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmAccountManagerment
    Dim database As New DataTable
    Dim connectstring As String = "workstation id=Phucbhps02508.mssql.somee.com;packet size=4096;user id=phucbhps02508_SQLLogin_1;pwd=a6hi7bn771;data source=Phucbhps02508.mssql.somee.com;persist security info=False;initial catalog=Phucbhps02508"
    Dim connect As SqlConnection = New SqlConnection(connectstring)
    Private Sub frmAccountManagerment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(connectstring) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để lấy dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Login", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        dgvInfor.DataSource = database.DefaultView
    End Sub
    'Hiển thị dữ liệu ra Datagrid

    Private Sub dgvInfor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInfor.CellContentClick
        Dim index As Integer = dgvInfor.CurrentCell.RowIndex
        txtID.Text = dgvInfor.Item(0, index).Value
        txtPass.Text = dgvInfor.Item(1, index).Value
        txtName.Text = dgvInfor.Item(2, index).Value
        txtEmail.Text = dgvInfor.Item(3, index).Value
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(connectstring)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into Login values (@ID,@Pass,@Name,@Email)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@ID", txtID.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Pass", txtPass.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Name", txtName.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Email", txtEmail.Text)

            'Exucute là ghi dữ liệu vào Database
            MessageBox.Show("Add Successful !")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Can't be Add!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from Login", connect)
        database.Clear()

        Query3.Fill(database)
        dgvInfor.DataSource = database.DefaultView

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim connectEdit As New SqlConnection(connectstring)
        connectEdit.Open()
        Dim StringAdd1 As String = "Update Login set Pass = @Pass, Name = @Name, Email = @Email where ID = @ID"
        Dim com As New SqlCommand(StringAdd1, connectEdit)
        Try
            com.Parameters.AddWithValue("@ID", txtID.Text)
            com.Parameters.AddWithValue("@Pass", txtPass.Text)
            com.Parameters.AddWithValue("@Name", txtName.Text)
            com.Parameters.AddWithValue("@Email", txtEmail.Text)
            com.ExecuteNonQuery()
            connectEdit.Close()
            MessageBox.Show("Edit Successfull !")
        Catch ex As Exception
            MessageBox.Show("Can't be Edit !")
        End Try
        database.Clear()
        dgvInfor.DataSource = database
        dgvInfor.DataSource = Nothing
        Loaddata()
    End Sub

    Private Sub Loaddata()
        Dim connect2 As SqlConnection = New SqlConnection(connectstring)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Login", connect2)

        connect2.Open()
        Query1.Fill(database)
        dgvInfor.DataSource = database.DefaultView

    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim connectDel As New SqlConnection(connectstring)
        connectDel.Open()
        Dim Del As String = "Delete from Login Where ID = @ID"
        Dim actionDel As New SqlCommand(Del, connectDel)
        Try
            actionDel.Parameters.AddWithValue("@ID", txtID.Text)
            actionDel.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Can't be Delete !")
        End Try
        database.Clear()
        dgvInfor.DataSource = database
        dgvInfor.DataSource = Nothing
        Loaddata()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Clear()
        txtPass.Clear()
        txtName.Clear()
        txtEmail.Clear()
    End Sub
End Class