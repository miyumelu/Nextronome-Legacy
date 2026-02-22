Public Class StartDisplay
    Private Sub StartDisplay_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Opacity = 0
        Do Until Me.Opacity = 1
            Me.Opacity += 0.1
            Me.Refresh()
            System.Threading.Thread.Sleep(300)
        Loop
        Waitress.Start()
    End Sub

    Private Sub Waitress_Tick(sender As Object, e As EventArgs) Handles Waitress.Tick
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class