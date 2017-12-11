Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmProduct
    Dim database As New DataTable
    Dim connectstring As String = "workstation id=Phucbhps02508.mssql.somee.com;packet size=4096;user id=phucbhps02508_SQLLogin_1;pwd=a6hi7bn771;data source=Phucbhps02508.mssql.somee.com;persist security info=False;initial catalog=Phucbhps02508"
    Dim connect As SqlConnection = New SqlConnection(connectstring)
    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(connectstring) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để lấy dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Products", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        dgvInfor.DataSource = database.DefaultView
    End Sub

    Private Sub dgvInfor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInfor.CellContentClick
        Dim index As Integer = dgvInfor.CurrentCell.RowIndex
        txtProID.Text = dgvInfor.Item(0, index).Value
        txtProCID.Text = dgvInfor.Item(1, index).Value
        txtProDate.Text = dgvInfor.Item(2, index).Value
        txtExDate.Text = dgvInfor.Item(3, index).Value
        txtQuantity.Text = dgvInfor.Item(4, index).Value
        txtOOID.Text = dgvInfor.Item(5, index).Value
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(connectstring)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into Products values (@Product_ID,@Product_Categorie_ID,@Product_Date,@Expire_Date,@Product_Quantity,@Orders_Order_ID)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@Product_ID", txtProID.Text) 'Giá trị phải giống bên bảng Order
            ExecuteQuery1.Parameters.AddWithValue("@Product_Categorie_ID", txtProCID.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Product_Date", txtProDate.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Expire_Date", txtExDate.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Product_Quantity", txtQuantity.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Orders_Order_ID", txtOOID.Text) 'Giá trị phải giống bên bảng Order
            'Exucute là ghi dữ liệu vào Database
            MessageBox.Show("Add Successful !")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Can't be Add!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from Products", connect)
        database.Clear()

        Query3.Fill(database)
        dgvInfor.DataSource = database.DefaultView
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim connectEdit As New SqlConnection(connectstring)
        connectEdit.Open()
        Dim StringAdd1 As String = "Update Products set Product_Categorie_ID = @Product_Categorie_ID, Product_Date = @Product_Date, Expire_Date = @Expire_Date, Product_Quantity = @Product_Quantity, Oders_Order_ID = @Orders_Order_ID where Product_ID = @Product_ID"
        Dim com As New SqlCommand(StringAdd1, connectEdit)
        Try
            com.Parameters.AddWithValue("@Product_ID", txtProID.Text)
            com.Parameters.AddWithValue("@Product_Categorie_ID", txtProCID.Text)
            com.Parameters.AddWithValue("@Product_Date", txtProDate.Text)
            com.Parameters.AddWithValue("@Expire_Date", txtExDate.Text)
            com.Parameters.AddWithValue("@Product_Quantity", txtQuantity.Text)
            com.Parameters.AddWithValue("@Orders_Order_ID", txtOOID.Text)
            com.ExecuteNonQuery()
            connectEdit.Close()
            MessageBox.Show("Edit Successfull !")
        Catch ex As Exception
            MessageBox.Show("Can't be Edit !")
        End Try
        database.Clear()
        dgvInfor.DataSource = database
        Loaddata()
    End Sub
    Private Sub Loaddata()
        Dim connect2 As SqlConnection = New SqlConnection(connectstring)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Products", connect2)

        connect2.Open()
        Query1.Fill(database)
        dgvInfor.DataSource = database.DefaultView

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim connectDel As New SqlConnection(connectstring)
        connectDel.Open()
        Dim Del As String = "Delete from Products Where Product_ID = @Product_ID"
        Dim actionDel As New SqlCommand(Del, connectDel)
        Try
            actionDel.Parameters.AddWithValue("@Product_ID", txtProID.Text)
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
        txtProID.Clear()
        txtProDate.Clear()
        txtExDate.Clear()
        txtProCID.Clear()
        txtOOID.Clear()
        txtQuantity.Clear()
    End Sub
End Class