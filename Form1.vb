Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNConfig.Click
        frmConfig.Show()

    End Sub

    Private Sub BTNExit_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        Application.Exit()
    End Sub
End Class
