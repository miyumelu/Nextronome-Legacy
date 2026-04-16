Public Class Settings

    Dim xblue As Color = Color.FromArgb(255, 97, 180, 241)
    Dim xgreen As Color = Color.FromArgb(255, 102, 246, 159)
    Dim xorange As Color = Color.FromArgb(255, 244, 136, 30)
    Dim xdarkgray As Color = Color.FromArgb(255, 38, 38, 38)

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Hide()
        Form1.TabLabel.Text = "MAIN"
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(0, 55)
        Me.Height = My.Computer.Screen.Bounds.Height - 55
        Me.Width = My.Computer.Screen.Bounds.Width
        Me.TopMost = True

        If My.Settings.FKey Then
            Fkeyswitch.Text = "Enabled"
            Fkeyswitch.ForeColor = xgreen
        End If

        If My.Settings.Lightbulb Then
            Label7.Text = "Enabled"
            Label7.ForeColor = xgreen
        End If


        If My.Settings.Fof Then
            Label10.Text = "Enabled"
            Label10.ForeColor = xgreen
        End If

        If Form1.LightEffect = 1 Then
            Fkeyalternate.Text = "Enabled"
            Fkeyalternate.ForeColor = xgreen
        Else
            Fkeyalternate.Text = "Disabled"
            Fkeyalternate.ForeColor = xorange
        End If
    End Sub

    Private Sub Settings_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            Form1.TabLabel.Text = "SETTINGS"
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If Label7.Text = "Disabled" Then
            Label7.Text = "Enabled"
            Label7.ForeColor = xgreen
            My.Settings.Lightbulb = True
        Else
            Label7.Text = "Disabled"
            Label7.ForeColor = xorange
            My.Settings.Lightbulb = False
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        If Label10.Text = "Disabled" Then
            Label10.Text = "Enabled"
            Label10.ForeColor = xgreen
            My.Settings.Fof = True
        Else
            Label10.Text = "Disabled"
            Label10.ForeColor = xorange
            My.Settings.Fof = False
        End If
    End Sub

    Private Sub Fkeyswitch_Click(sender As Object, e As EventArgs) Handles Fkeyswitch.Click
        If Fkeyswitch.Text = "Disabled" Then
            Fkeyswitch.Text = "Enabled"
            Fkeyswitch.ForeColor = xgreen
            My.Settings.FKey = True
        Else
            Fkeyswitch.Text = "Disabled"
            Fkeyswitch.ForeColor = xorange
            My.Settings.FKey = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Fkeyalternate.Click
        If Fkeyalternate.Text = "Disabled" Then
            Fkeyalternate.Text = "Enabled"
            Fkeyalternate.ForeColor = xgreen
            Form1.LightEffect = 1
        Else
            Fkeyalternate.Text = "Disabled"
            Fkeyalternate.ForeColor = xorange
            Form1.LightEffect = 0
        End If
    End Sub
End Class