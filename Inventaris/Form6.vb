Public Class Form6
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseMove

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Module1.TitikKoma(e, TextBox1)
    End Sub
End Class