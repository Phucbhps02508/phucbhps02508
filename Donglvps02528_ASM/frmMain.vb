Imports System.Data.SqlClient

Public Class frmMain


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmWelcome.ShowDialog()
        frmLogin.ShowDialog()

    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        frmCustomer.ShowDialog()

    End Sub

    Private Sub lblID_Click(sender As Object, e As EventArgs) Handles lblID.Click


    End Sub

    Private Sub grbAccountInfo_Enter(sender As Object, e As EventArgs) Handles grbAccountInfo.Enter

    End Sub



    Private Sub lblPass_Click(sender As Object, e As EventArgs) Handles lblPass.Click

    End Sub

 

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        frmAccountManagerment.ShowDialog()
    End Sub

    Private Sub ProductCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductCategoriesToolStripMenuItem.Click
        frmOrders.ShowDialog()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click

    End Sub

    Private Sub ProductToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem1.Click
        frmProduct.ShowDialog()
    End Sub

    Private Sub InvoicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoicesToolStripMenuItem.Click
        frmInvoices.ShowDialog()
    End Sub

    Private Sub ProductCategoriesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductCategoriesToolStripMenuItem1.Click
        frmProCategories.ShowDialog()
    End Sub
End Class