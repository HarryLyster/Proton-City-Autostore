Public Class frmConfig
    Private Sub pbNewClient_MouseHover(sender As Object, e As EventArgs) Handles pbNewClient.MouseHover

    End Sub

    Private Sub pbNewInvoice_MouseHover(sender As Object, e As EventArgs) Handles pbNewInvoice.MouseHover
        pbNewInvoice.Image = WindowsApplication1.My.Resources.invoice2
    End Sub

    Private Sub pdNewClient_Click(sender As Object, e As EventArgs) Handles pbNewClient.Click

    End Sub

    Private Sub pdNewClient_MouseUp(sender As Object, e As MouseEventArgs) Handles pbNewClient.MouseUp
        pbNewInvoice.Image = WindowsApplication1.My.Resources.clients2
    End Sub

    Private Sub pdNewInvoice_Click(sender As Object, e As EventArgs) Handles pbNewInvoice.Click

    End Sub

    Private Sub pbNewOrder_Click(sender As Object, e As EventArgs) Handles pbNewOrder.Click

    End Sub

    Private Sub pbNewOrder_MouseHover(sender As Object, e As EventArgs) Handles pbNewOrder.MouseHover

    End Sub

    Private Sub pbUpdateUser_Click(sender As Object, e As EventArgs) Handles pbUpdateUser.Click

    End Sub

    Private Sub pbUpdateUser_MouseHover(sender As Object, e As EventArgs) Handles pbUpdateUser.MouseHover

    End Sub

    Private Sub pbNewUser_Click(sender As Object, e As EventArgs) Handles pbNewUser.Click

    End Sub

    Private Sub pbNewUser_MouseHover(sender As Object, e As EventArgs) Handles pbNewUser.MouseHover

    End Sub

    Private Sub pbYearlySales_Click(sender As Object, e As EventArgs) Handles pbYearlySales.Click

    End Sub

    Private Sub pbYearlySales_MouseHover(sender As Object, e As EventArgs) Handles pbYearlySales.MouseHover

    End Sub
End Class