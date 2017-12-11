Public Class frmyesno

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Application.Exit()
    End Sub
End Class