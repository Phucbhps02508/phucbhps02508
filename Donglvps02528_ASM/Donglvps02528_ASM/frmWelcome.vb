Public Class frmWelcome

    Private Sub TimeLoad_Tick(sender As Object, e As EventArgs) Handles TimeLoad.Tick
        prbLoad.Increment(2)
        If prbLoad.Value = prbLoad.Maximum Then
            Me.Close()
        End If
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub prbLoad_Click(sender As Object, e As EventArgs) Handles prbLoad.Click

    End Sub
End Class
