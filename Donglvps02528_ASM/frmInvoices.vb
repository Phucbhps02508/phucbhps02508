Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmInvoices
    Dim database As New DataTable
    Dim connectstring As String = "workstation id=Phucbhps02508.mssql.somee.com;packet size=4096;user id=phucbhps02508_SQLLogin_1;pwd=a6hi7bn771;data source=Phucbhps02508.mssql.somee.com;persist security info=False;initial catalog=Phucbhps02508"
    Dim connect As SqlConnection = New SqlConnection(connectstring)
    Private Sub frmInvoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(connectstring) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để lấy dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Invoices", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        dgvInfor.DataSource = database.DefaultView
    End Sub

    Private Sub dgvInfor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInfor.CellContentClick
        Dim index As Integer = dgvInfor.CurrentCell.RowIndex
        txtInvoiceID.Text = dgvInfor.Item(0, index).Value
        txtInvoiceDate.Text = dgvInfor.Item(1, index).Value
        txtTotal.Text = dgvInfor.Item(2, index).Value
        txtCusID.Text = dgvInfor.Item(3, index).Value
        txtProID.Text = dgvInfor.Item(4, index).Value
        txtCusSID.Text = dgvInfor.Item(5, index).Value
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(connectstring)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into Invoices values (@Invoice_ID,@Invoice_Date,@Total,@Customer_ID,@Product_ID,@Customers_Customer_ID)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@Invoice_ID", txtInvoiceID.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Invoice_Date", txtInvoiceDate.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Total", txtTotal.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Customer_ID", txtCusID.Text) 'Giá trị phải giống giá trị Customer ID thuộc bảng Customer
            ExecuteQuery1.Parameters.AddWithValue("@Product_ID", txtProID.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Customers_Customer_ID", txtCusSID.Text) 'Giá trị phải giống giá trị Customer ID thuộc bảng Customer
            'Exucute là ghi dữ liệu vào Database
            MessageBox.Show("Add Successful !")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Can't be Add!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from Invoices", connect)
        database.Clear()

        Query3.Fill(database)
        dgvInfor.DataSource = database.DefaultView
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim connectEdit As New SqlConnection(connectstring)
        connectEdit.Open()
        Dim StringAdd1 As String = "Update Invoices set Invoice_Date = @Invoice_Date, Total = @Total, Customer_ID = @Customer_ID, Product_ID = @Product_ID, Customers_Customer_ID = @Customers_Customer_ID where Invoice_ID = @Invoice_ID"
        Dim com As New SqlCommand(StringAdd1, connectEdit)
        Try
            com.Parameters.AddWithValue("@Invoice_ID", txtInvoiceID.Text)
            com.Parameters.AddWithValue("@Invoice_Date", txtInvoiceDate.Text)
            com.Parameters.AddWithValue("@Total", txtTotal.Text)
            com.Parameters.AddWithValue("@Customer_ID", txtCusID.Text)
            com.Parameters.AddWithValue("@Product_ID", txtProID.Text)
            com.Parameters.AddWithValue("@Customers_Customer_ID", txtCusSID.Text)
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
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Invoices", connect2)

        connect2.Open()
        Query1.Fill(database)
        dgvInfor.DataSource = database.DefaultView

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim connectDel As New SqlConnection(connectstring)
        connectDel.Open()
        Dim Del As String = "Delete from Invoices Where Invoice_ID = @Invoice_ID"
        Dim actionDel As New SqlCommand(Del, connectDel)
        Try
            actionDel.Parameters.AddWithValue("@Invoice_ID", txtInvoiceID.Text)
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
        txtInvoiceID.Clear()
        txtInvoiceDate.Clear()
        txtTotal.Clear()
        txtCusID.Clear()
        txtProID.Clear()
        txtCusSID.Clear()
    End Sub
End Class