Imports System.IO
Imports System.Runtime.InteropServices ' Für Scroll-Funktion
Imports System.Drawing

Public Class Form2
    Dim xblue As Color = Color.FromArgb(255, 97, 180, 241)
    Dim xgreen As Color = Color.FromArgb(255, 102, 246, 159)
    Dim xorange As Color = Color.FromArgb(255, 244, 136, 30)
    Dim xdarkgray As Color = Color.FromArgb(255, 38, 38, 38)

    ' Win32-API für Scroll-Funktion
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    Private Const LVM_FIRST As Integer = &H1000
    Private Const LVM_ENSUREVISIBLE As Integer = LVM_FIRST + 19

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(0, 55)
        Me.Height = My.Computer.Screen.Bounds.Height - 55
        Me.Width = My.Computer.Screen.Bounds.Width
        Me.TopMost = True
        ConfigureListView()
        LoadFolders()

        ' Prüfen und Style markieren
        MarkAndScrollToStyle()
        Form1.TabLabel.Text = "STYLE"

    End Sub

    Private Sub ConfigureListView()
        ListView1.View = View.Details
        ListView1.MultiSelect = False
        ListView1.FullRowSelect = True
        ListView1.HideSelection = False
        ListView1.GridLines = True
        ListView1.Columns.Add("Style", 715, HorizontalAlignment.Center)
        ListView1.Columns.Add("Type", 715, HorizontalAlignment.Center)

    End Sub

    Private Sub LoadFolders()
        Dim path As String = "C:\KAVN\Applications\Accompaniment\Styles"
        If Not Directory.Exists(path) Then
            MessageBox.Show("Der Pfad existiert nicht: " & path)
            Return
        End If

        ListView1.Items.Clear()
        For Each folder As String In Directory.GetDirectories(path)
            Dim folderName As String = IO.Path.GetFileName(folder)
            Dim item As New ListViewItem(folderName)
            item.SubItems.Add("KAVN Style Package")
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub MarkAndScrollToStyle()
        If String.IsNullOrEmpty(Form1.Style) Then Return

        For Each item As ListViewItem In ListView1.Items
            If item.Text = Form1.Style Then
                ' Markiere das Item lila
                item.ForeColor = Color.Black
                item.BackColor = xorange ' Optional: Heller Hintergrund

                ' Scrolle zum Item
                item.Selected = True
                item.EnsureVisible()
                SendMessage(ListView1.Handle, LVM_ENSUREVISIBLE, item.Index, 0)
                Exit For
            End If
        Next
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then Return

        ' Zurücksetzen aller Markierungen
        For Each item In ListView1.Items
            item.ForeColor = Color.White
            item.BackColor = Color.Black
        Next

        ' Neues Selection-Item markieren
        ListView1.SelectedItems(0).BackColor = xorange
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Hide()
        Form1.TabLabel.Text = "MAIN"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Style_Name.Text = ListView1.SelectedItems(0).Text
        My.Settings.Style1 = ListView1.SelectedItems(0).Text
        Try
            Dim StyleBPM As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + ListView1.SelectedItems(0).Text + "\bpm.val")
            Form1.BPM_Label.Text = "BPM " & StyleBPM
        Catch ex As Exception
            Form1.BPM_Label.Text = "BPM -"
        End Try
        Try
            Dim FamilyName As String = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + ListView1.SelectedItems(0).Text + "\family.word")
            Form1.Family_Name.Text = FamilyName
        Catch ex As Exception
            Form1.Family_Name.Text = "Unknown family"
        End Try
        If Form1.Active = 1 Then
            Form1.Style = ListView1.SelectedItems(0).Text
            Form1.LoadSample()
            Form1.ClearAllAudioBuffers()
            Form1.PreloadAllAudioFiles()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Style2_Name.Text = ListView1.SelectedItems(0).Text
        My.Settings.Style2 = ListView1.SelectedItems(0).Text
        Try
            Dim StyleBPM As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + ListView1.SelectedItems(0).Text + "\bpm.val")
            Form1.BPM2_Label.Text = "BPM " & StyleBPM
        Catch ex As Exception
            Form1.BPM2_Label.Text = "BPM -"
        End Try
        Try
            Dim FamilyName As String = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + ListView1.SelectedItems(0).Text + "\family.word")
            Form1.Family2_Name.Text = FamilyName
        Catch ex As Exception
            Form1.Family2_Name.Text = "Unknown family"
        End Try
        If Form1.Active = 2 Then
            Form1.Style = ListView1.SelectedItems(0).Text
            Form1.LoadSample()
            Form1.ClearAllAudioBuffers()
            Form1.PreloadAllAudioFiles()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Form2_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Form1.TabLabel.Text = "STYLE"
    End Sub

    Private Sub Form2_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            Form1.TabLabel.Text = "STYLE"
        End If
    End Sub
End Class