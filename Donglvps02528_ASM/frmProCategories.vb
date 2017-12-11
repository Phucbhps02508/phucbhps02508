Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmProCategories
    Dim database As New DataTable
    Dim connectstring As String = "workstation id=donglvps02528ASM.mssql.somee.com;packet size=4096;user id=donglvps02528_SQLLogin_1;pwd=wysmi3kki7;data source=donglvps02528ASM.mssql.somee.com;persist security info=False;initial catalog=donglvps02528ASM"
    Dim connect As SqlConnection = New SqlConnection(connectstring)
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmProCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(connectstring) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để lấy dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Product_Categories", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        dgvInfor.DataSource = database.DefaultView
    End Sub

    Private Sub dgvInfor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInfor.CellContentClick
        Dim index As Integer = dgvInfor.CurrentCell.RowIndex
        txtProCatID.Text = dgvInfor.Item(0, index).Value
        txtProCat.Text = dgvInfor.Item(1, index).Value
        txtProSID.Text = dgvInfor.Item(2, index).Value
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(connectstring)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into Product_Categories values (@Product_Categorie_ID,@Product_Categorie,@Products_Product_ID)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@Product_Categorie_ID", txtProCatID.Text) 'Giá trị này phải phù hợp với giá trị Product_Categorie_ID thuộc bảng Product
            ExecuteQuery1.Parameters.AddWithValue("@Product_Categorie", txtProCat.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Products_Product_ID", txtProSID.Text) 'Giá trị này phải phù hợp với giá trị Products_Product_ID thuộc bảng Product
            'Exucute là ghi dữ liệu vào Database
            MessageBox.Show("Add Successful !")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Can't be Add!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from Product_Categories", connect)
        database.Clear()

        Query3.Fill(database)
        dgvInfor.DataSource = database.DefaultView
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim connectEdit As New SqlConnection(connectstring)
        connectEdit.Open()
        Dim StringAdd1 As String = "Update Product_Categories set Product_Categorie = @Product_Categorie, Products_Product_ID = @Products_Product_ID where Product_Categorie_ID = @Product_Categorie_ID"
        Dim com As New SqlCommand(StringAdd1, connectEdit)
        Try
            com.Parameters.AddWithValue("@Product_Categorie_ID", txtProCatID.Text)
            com.Parameters.AddWithValue("@Product_Categorie", txtProCat.Text)
            com.Parameters.AddWithValue("@Products_Product_ID", txtProSID.Text)
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
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Product_Categories", connect2)

        connect2.Open()
        Query1.Fill(database)
        dgvInfor.DataSource = database.DefaultView

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim connectDel As New SqlConnection(connectstring)
        connectDel.Open()
        Dim Del As String = "Delete from Product_Categories Where Product_Categorie_ID = @Product_Categorie_ID"
        Dim actionDel As New SqlCommand(Del, connectDel)
        Try
            actionDel.Parameters.AddWithValue("@Product_Categorie_ID", txtProCatID.Text)
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
        txtProCatID.Clear()
        txtProCat.Clear()
        txtProSID.Clear()
    End Sub
End Class