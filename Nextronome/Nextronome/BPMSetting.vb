Public Class BPMSetting
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form1.bpm = Form1.bpm + 1
        Label1.Text = Form1.bpm
        Form1.Label8.Text = Form1.bpm
    End Sub

    Private Sub BPMValueSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = Form1.bpm
        Me.TopMost = True
        Form1.TabLabel.Text = "BPM Sett"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form1.bpm = Form1.bpm - 1
        Label1.Text = Form1.bpm
        Form1.Label8.Text = Form1.bpm
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Form1.bpm = 120
        Label1.Text = Form1.bpm
        Form1.Label8.Text = Form1.bpm
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        Form1.TabLabel.Text = "MAIN"
    End Sub

    Private Sub BPMValueSetting_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            Form1.bpm = Form1.bpm - 1
            Label1.Text = Form1.bpm
            Form1.Label8.Text = Form1.bpm
        ElseIf e.KeyCode = Keys.Right Then
            Form1.bpm = Form1.bpm + 1
            Label1.Text = Form1.bpm
            Form1.Label8.Text = Form1.bpm
        ElseIf e.KeyCode = Keys.Delete Then
            Form1.bpm = 120
            Label1.Text = Form1.bpm
            Form1.Label8.Text = Form1.bpm
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
            Form1.TabLabel.Text = "MAIN"
        End If
    End Sub
End Class