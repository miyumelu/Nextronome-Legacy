Public Class BPMValueSetting
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        My.Settings.BPMCalcVal = My.Settings.BPMCalcVal + 10
        Label1.Text = My.Settings.BPMCalcVal
        Form1.BPMValue_Label.Text = My.Settings.BPMCalcVal & " ms"
    End Sub

    Private Sub BPMValueSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = My.Settings.BPMCalcVal
        Me.TopMost = True
        Form1.TabLabel.Text = "BPM Calc"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        My.Settings.BPMCalcVal = My.Settings.BPMCalcVal - 10
        Label1.Text = My.Settings.BPMCalcVal
        Form1.BPMValue_Label.Text = My.Settings.BPMCalcVal & " ms"
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        My.Settings.BPMCalcVal = 60000
        Label1.Text = My.Settings.BPMCalcVal
        Form1.BPMValue_Label.Text = My.Settings.BPMCalcVal & " ms"
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        My.Settings.Save()
        Me.Close()
        Form1.TabLabel.Text = "MAIN"
    End Sub

    Private Sub BPMValueSetting_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            My.Settings.BPMCalcVal = My.Settings.BPMCalcVal - 10
            Label1.Text = My.Settings.BPMCalcVal
            Form1.BPMValue_Label.Text = My.Settings.BPMCalcVal & " ms"
        ElseIf e.KeyCode = Keys.Right Then
            My.Settings.BPMCalcVal = My.Settings.BPMCalcVal + 10
            Label1.Text = My.Settings.BPMCalcVal
            Form1.BPMValue_Label.Text = My.Settings.BPMCalcVal & " ms"
        ElseIf e.KeyCode = Keys.Delete Then
            My.Settings.BPMCalcVal = 60000
            Label1.Text = My.Settings.BPMCalcVal
            Form1.BPMValue_Label.Text = My.Settings.BPMCalcVal & " ms"
        ElseIf e.KeyCode = Keys.Escape Then
            My.Settings.Save()
            Me.Close()
            Form1.TabLabel.Text = "MAIN"
        End If
    End Sub
End Class