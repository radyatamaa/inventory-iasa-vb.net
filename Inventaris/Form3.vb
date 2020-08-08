Public Class Form3
    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drop1.Size = drop1.MinimumSize
        drop2.Size = drop2.MinimumSize
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed Then
            dropbutton1.Image = My.Resources.icons8_expand_arrow_26
            drop1.Height += 10
            If drop1.Size = drop1.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            dropbutton1.Image = My.Resources.icons8_chevron_left_26
            drop1.Height -= 10
            If drop1.Size = drop1.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If isCollapsed2 Then
            dropbutton2.Image = My.Resources.icons8_expand_arrow_26
            drop2.Height += 10
            If drop2.Size = drop2.MaximumSize Then
                Timer2.Stop()
                isCollapsed2 = False
            End If
        Else
            dropbutton2.Image = My.Resources.icons8_chevron_left_26
            drop2.Height -= 10
            If drop2.Size = drop2.MinimumSize Then
                Timer2.Stop()
                isCollapsed2 = True
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles dropbutton1.Click
        isCollapsed2 = False
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles dropbutton2.Click
        isCollapsed = False
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub HaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HaToolStripMenuItem.Click

    End Sub

    Private Sub JaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JaToolStripMenuItem.Click
        MasterAlasan.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class