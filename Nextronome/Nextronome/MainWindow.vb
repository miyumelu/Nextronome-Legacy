Imports System.Diagnostics
Imports System.IO
Imports System.Media
Imports System.Threading

Public Class Form1
    ' Farbdefinitionen
    Dim xblue As Color = Color.FromArgb(255, 97, 180, 241)
    Dim xgreen As Color = Color.FromArgb(255, 102, 246, 159)
    Dim xorange As Color = Color.FromArgb(255, 244, 136, 30)
    Dim xdarkgray As Color = Color.FromArgb(255, 38, 38, 38)
    Public LightEffect As Integer = 0

    ' Audio-Handling
    Dim soundPlayers As New Dictionary(Of String, SoundPlayer)
    Private audioLock As New Object()

    ' Pfade und Einstellungen
    Public MainPath As String = "C:\KAVN\Applications\Accompaniment\Styles\"
    Public Style As String = ""
    Public Active As Integer = 1
    Private Accompaniment As String = "Full"
    Private Changemode As String = "Ending"

    ' Timing-Variablen
    Private bpm As Integer = 119
    Private beatsProTakt As Integer = 4
    Private beatCount As Integer = 0
    Private beatInterval As Integer
    Private metronomRunning As Boolean = False
    Private metronomThread As Thread
    Private stopMetronome As Boolean = False

    ' Zustandsvariablen
    Private selectintro As Integer = 1
    Private ritim As Integer = 0
    Private selectoutro As Integer = 1
    Private break As Boolean = False
    Private intro As Boolean = False
    Private outro As Boolean = False

    ' Beat-Längen und Tempi
    Public Intro1beats As Integer = 32
    Public Intro2beats As Integer
    Public Intro3beats As Integer

    Public Main1beats As Integer = 8
    Public Main2beats As Integer = 16
    Public Main3beats As Integer
    Public Main4beats As Integer

    Public Auto1beats As Integer = 4
    Public Auto2beats As Integer = 4
    Public Auto3beats As Integer
    Public Auto4beats As Integer

    Public Outro1beats As Integer = 16
    Public Outro2beats As Integer
    Public Outro3beats As Integer

    Public Sub LoadSample()

        'Style BPM lesen.
        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style) Then
            Try
                Dim StyleBPM As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\bpm.val")
                bpm = StyleBPM
                Label8.Text = StyleBPM
            Catch ex As Exception

            End Try
        End If

        'Intro Beats lesen.
        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Intro1") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Intro1\beats.val")
            Intro1beats = Beats
            Button10.Enabled = True
            IntroLED1.BackColor = xblue
        Else
            Button10.Enabled = False
            IntroLED1.BackColor = xdarkgray
        End If

        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Intro2") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Intro2\beats.val")
            Intro2beats = Beats
            Button9.Enabled = True
            IntroLED2.BackColor = xblue
        Else
            Button9.Enabled = False
            IntroLED2.BackColor = xdarkgray
        End If

        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Intro3") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Intro3\beats.val")
            Intro3beats = Beats
            Button8.Enabled = True
            IntroLED3.BackColor = xblue
        Else
            Button8.Enabled = False
            IntroLED3.BackColor = xdarkgray
        End If

        'Main Beats lesen.
        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Main1") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Main1\beats.val")
            Main1beats = Beats
            Button3.Enabled = True
            MainLED1.BackColor = xblue
        Else
            Button3.Enabled = False
            MainLED1.BackColor = xdarkgray
        End If

        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Main2") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Main2\beats.val")
            Main2beats = Beats
            Button4.Enabled = True
            MainLED2.BackColor = xblue
        Else
            Button4.Enabled = False
            MainLED2.BackColor = xdarkgray
        End If

        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Main3") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Main3\beats.val")
            Main3beats = Beats
            Button5.Enabled = True
            MainLED3.BackColor = xblue
        Else
            Button5.Enabled = False
            MainLED3.BackColor = xdarkgray
        End If

        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Main4") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Main4\beats.val")
            Main4beats = Beats
            Button6.Enabled = True
            MainLED4.BackColor = xblue
        Else
            Button6.Enabled = False
            MainLED4.BackColor = xdarkgray
        End If

        'Fill Beats lesen.
        'WICHTIG - ÜBERPRÜFUNG FÜR BREAK AVAILABILITY HINZUFÜGEN
        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Auto1") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Auto1\beats.val")
            Auto1beats = Beats
        End If

        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Auto2") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Auto2\beats.val")
            Auto2beats = Beats

        End If

        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Auto3") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Auto3\beats.val")
            Auto3beats = Beats

            End If

        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Auto4") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Auto4\beats.val")
            Auto4beats = Beats
        End If


        'Outro Beats lesen.
        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Outro1") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Outro1\beats.val")
            Outro1beats = Beats
            Button11.Enabled = True
            OutroLED1.BackColor = xblue
        Else
            Button11.Enabled = False
            OutroLED1.BackColor = xdarkgray
        End If

        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Outro2") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Outro2\beats.val")
            Outro2beats = Beats
            Button12.Enabled = True
            OutroLED2.BackColor = xblue
        Else
            Button12.Enabled = False
            OutroLED2.BackColor = xdarkgray
        End If

        If IO.Directory.Exists("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Outro3") Then
            Dim Beats As Integer = IO.File.ReadAllText("C:\KAVN\Applications\Accompaniment\Styles\" + Style + "\Outro3\beats.val")
            Intro3beats = Beats
            Button13.Enabled = True
            OutroLED3.BackColor = xblue
        Else
            Button13.Enabled = False
            OutroLED3.BackColor = xdarkgray
        End If



        'Korrektur
        If break Then
            BreakLED.BackColor = xgreen
        ElseIf intro Then
            If intro = 1 Then
                IntroLED1.BackColor = xgreen
            ElseIf intro = 2 Then
                IntroLED2.BackColor = xgreen
            ElseIf intro = 3 Then
                IntroLED3.BackColor = xgreen
            End If
        ElseIf outro Then
            If outro = 1 Then
                OutroLED1.BackColor = xgreen
            ElseIf outro = 2 Then
                OutroLED2.BackColor = xgreen
            ElseIf outro = 3 Then
                OutroLED3.BackColor = xgreen
            End If
        Else
            If ritim = 1 Then
                MainLED1.BackColor = xgreen
            ElseIf ritim = 2 Then
                MainLED2.BackColor = xgreen
            ElseIf ritim = 3 Then
                MainLED3.BackColor = xgreen
            ElseIf ritim = 4 Then
                MainLED4.BackColor = xgreen
            End If
            BreakLED.BackColor = xblue
        End If

    End Sub


    ' ========== INITIALISIERUNG ==========
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Screen.AllScreens.Length > 1 Then
                Dim startLocation As New Point((Screen.AllScreens(1).WorkingArea.Left + 0), (Screen.AllScreens(1).WorkingArea.Top + 0))
                Me.Location = startLocation
            End If
            Me.WindowState = FormWindowState.Maximized

            PreloadAllAudioFiles()
        Catch ex As Exception
            MessageBox.Show("Initialisierungsfehler: " & ex.Message)
        End Try
        DasLabel.Text = "-"
        Beat1.BackColor = xdarkgray
        Beat2.BackColor = xdarkgray
        Beat3.BackColor = xdarkgray
        Beat4.BackColor = xdarkgray
        IntroLED1.BackColor = xblue
        IntroLED2.BackColor = xblue
        IntroLED3.BackColor = xblue
        BreakLED.BackColor = xblue
        OutroLED1.BackColor = xblue
        OutroLED2.BackColor = xblue
        OutroLED3.BackColor = xblue
        LoadSample()
        BPMValue_Label.Text = My.Settings.BPMCalcVal & " ms"
        MetronomeBeats_Label.Text = beatsProTakt
    End Sub

    ' ========== AUDIO-HANDLING ==========
    Public Sub PreloadAllAudioFiles()
        Dim wasRunning As Boolean = metronomRunning
        If wasRunning Then
            StopMetronom()
        End If
        ClearAllAudioBuffers()
        Try
            ' Main Sounds
            LoadAndBufferAudio(MainPath & Style & "\Main1\" & Accompaniment & "\audio.wav", "Main1")
            LoadAndBufferAudio(MainPath & Style & "\Main2\" & Accompaniment & "\audio.wav", "Main2")
            LoadAndBufferAudio(MainPath & Style & "\Main3\" & Accompaniment & "\audio.wav", "Main3")
            LoadAndBufferAudio(MainPath & Style & "\Main4\" & Accompaniment & "\audio.wav", "Main4")

            ' Intro Sounds
            LoadAndBufferAudio(MainPath & Style & "\Intro1\" & Accompaniment & "\audio.wav", "Intro1")
            LoadAndBufferAudio(MainPath & Style & "\Intro2\" & Accompaniment & "\audio.wav", "Intro2")
            LoadAndBufferAudio(MainPath & Style & "\Intro3\" & Accompaniment & "\audio.wav", "Intro3")

            ' Outro Sounds
            LoadAndBufferAudio(MainPath & Style & "\Outro1\" & Accompaniment & "\audio.wav", "Outro1")
            LoadAndBufferAudio(MainPath & Style & "\Outro2\" & Accompaniment & "\audio.wav", "Outro2")
            LoadAndBufferAudio(MainPath & Style & "\Outro3\" & Accompaniment & "\audio.wav", "Outro3")

            ' Auto/Break Sounds
            LoadAndBufferAudio(MainPath & Style & "\Auto1\" & Accompaniment & "\audio.wav", "Auto1")
            LoadAndBufferAudio(MainPath & Style & "\Auto2\" & Accompaniment & "\audio.wav", "Auto2")
            LoadAndBufferAudio(MainPath & Style & "\Auto3\" & Accompaniment & "\audio.wav", "Auto3")
            LoadAndBufferAudio(MainPath & Style & "\Auto4\" & Accompaniment & "\audio.wav", "Auto4")
        Catch ex As Exception
            MessageBox.Show("Fehler beim Laden der Audiodateien: " & ex.Message)
        End Try
        If wasRunning Then
            beatCount = 0 ' Wichtig: Zähler zurücksetzen
            StartMetronom()
        End If
    End Sub

    Public Sub ClearAllAudioBuffers()
        SyncLock audioLock
            Try
                ' Alle Sounds stoppen und freigeben
                For Each kvp In soundPlayers
                    kvp.Value.Stop()
                    kvp.Value.Dispose()
                Next
                soundPlayers.Clear()
            Catch ex As Exception
                MessageBox.Show("Fehler beim Freigeben der Audio-Ressourcen: " & ex.Message)
            End Try
        End SyncLock
    End Sub

    Private Sub LoadAndBufferAudio(filePath As String, soundName As String)
        SyncLock audioLock
            Try
                If File.Exists(filePath) Then
                    ' Falls Sound bereits existiert, zuerst freigeben
                    If soundPlayers.ContainsKey(soundName) Then
                        soundPlayers(soundName).Dispose()
                        soundPlayers.Remove(soundName)
                    End If

                    Dim player As New SoundPlayer(filePath)
                    player.Load() ' Synchrones Laden (für sofortige Verfügbarkeit)
                    soundPlayers.Add(soundName, player)
                Else
                    Debug.WriteLine($"Datei nicht gefunden: {filePath}")
                End If
            Catch ex As Exception
                MessageBox.Show($"Fehler beim Laden von {soundName}: {ex.Message}")
            End Try
        End SyncLock
    End Sub

    Private Sub PlayBufferedAudio(soundName As String)
        SyncLock audioLock
            If soundPlayers.ContainsKey(soundName) Then
                Try
                    soundPlayers(soundName).Play() ' Nicht-blockierende Wiedergabe
                Catch ex As Exception
                    MessageBox.Show($"Fehler beim Abspielen von {soundName}: {ex.Message}")
                End Try
            End If
        End SyncLock
    End Sub


    ' ========== METRONOM-LOGIK ==========
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not metronomRunning Then
            StartMetronom()
            Button1.Text = "Stop"
        Else
            StopMetronom()
            Button1.Text = "Start"
        End If
    End Sub

    Private Sub StartMetronom()
        metronomRunning = True
        stopMetronome = False
        beatCount = 0
        beatInterval = CInt(My.Settings.BPMCalcVal / bpm) ' ms per beat

        metronomThread = New Thread(AddressOf RunMetronom)
        metronomThread.Priority = ThreadPriority.Highest
        metronomThread.IsBackground = True
        metronomThread.Start()
    End Sub

    Private Sub StopMetronom()
        DasLabel.Text = "-"
        metronomRunning = False
        stopMetronome = True

        ' Alle Sounds sofort stoppen
        SyncLock audioLock
            For Each player As KeyValuePair(Of String, SoundPlayer) In soundPlayers
                player.Value.Stop()
            Next
        End SyncLock

        If metronomThread IsNot Nothing AndAlso metronomThread.IsAlive Then
            metronomThread.Join(100)
            If metronomThread.IsAlive Then
                metronomThread.Abort()
            End If
        End If

        ' Reset UI
        Me.Invoke(Sub()
                      Beat1.BackColor = xdarkgray
                      Beat2.BackColor = xdarkgray
                      Beat3.BackColor = xdarkgray
                      Beat4.BackColor = xdarkgray
                      LoadSample()
                      Button1.Text = "Start"
                  End Sub)
    End Sub

    Private Sub RunMetronom()
        Dim sw As New Stopwatch()
        sw.Start()
        Dim nextBeatTime As Long = sw.ElapsedMilliseconds
        Dim taktMeter As Integer = 0
        Dim currentSection As String = ""

        While Not stopMetronome
            ' Absolute Zeitberechnung für perfektes Timing
            nextBeatTime += beatInterval

            ' Beat-Logik
            beatCount += 1
            If beatCount > beatsProTakt Then
                beatCount = 1
                Me.Invoke(Sub()
                              LoadSample()
                              BreakLED.BackColor = xblue
                          End Sub)


            End If

            ' Section-Wechsel erzwingen
            If beatCount = 1 Then
                taktMeter = 0
                Dim newSection As String = GetCurrentSection()
                If newSection <> currentSection Then
                    beatCount = 1
                    currentSection = newSection
                End If
            End If


            ' Audio abspielen (nur bei Beat 1 oder bei Section-Wechsel)
            If beatCount = 1 Then
                If intro Then
                    PlayIntro()
                ElseIf break Then
                    PlayBreak()
                ElseIf outro Then
                    PlayOutro()
                Else
                    PlayRitim()
                End If
            End If

            ' UI-Update
            taktMeter = If(taktMeter >= 4, 1, taktMeter + 1)
            UpdateBeatDisplay(taktMeter)


            ' Präzises Warten
            Dim remainingTime = nextBeatTime - sw.ElapsedMilliseconds
            If remainingTime > 0 Then
                Thread.Sleep(CInt(Math.Min(remainingTime, 1)))
                ' Feinjustierung
                Dim fineTuneSW As New Stopwatch()
                fineTuneSW.Start()
                While fineTuneSW.ElapsedMilliseconds < remainingTime AndAlso Not stopMetronome
                    Thread.SpinWait(100)
                End While
            End If
        End While
        sw.Stop()
    End Sub

    Private Sub UpdateBeatDisplay(beat As Integer)
        Me.Invoke(Sub()
                      ' Zuerst alle auf schwarz setzen
                      Beat1.BackColor = xdarkgray
                      Beat2.BackColor = xdarkgray
                      Beat3.BackColor = xdarkgray
                      Beat4.BackColor = xdarkgray
                      StartStopLED.BackColor = xdarkgray
                      DasLabel.Text = beat.ToString

                      ' Aktuellen Beat anzeigen
                      Select Case beat
                          Case 1
                              Beat1.BackColor = xorange
                              StartStopLED.BackColor = xorange
                          Case 2
                              Beat2.BackColor = xgreen
                              StartStopLED.BackColor = xgreen
                          Case 3
                              Beat3.BackColor = xgreen
                              StartStopLED.BackColor = xgreen
                          Case 4
                              Beat4.BackColor = xgreen
                              StartStopLED.BackColor = xgreen
                      End Select

                      ' Timer für das Zurücksetzen starten
                      If LightEffect = 0 Then
                          Dim blinkTimer As New System.Windows.Forms.Timer()
                          blinkTimer.Interval = 120 ' 150ms Blinkdauer
                          blinkTimer.Tag = beat ' Aktuellen Beat speichern
                          AddHandler blinkTimer.Tick, AddressOf ResetButtonDisplay
                          blinkTimer.Start()
                      ElseIf LightEffect = 1 Then
                          Dim blinkTimer As New System.Windows.Forms.Timer()
                          blinkTimer.Interval = 120 ' 150ms Blinkdauer
                          blinkTimer.Tag = beat ' Aktuellen Beat speichern
                          AddHandler blinkTimer.Tick, AddressOf ResetBeatDisplay
                          blinkTimer.Start()
                      End If

                  End Sub)
    End Sub

    Private Sub ResetBeatDisplay(sender As Object, e As EventArgs)
        Dim timer As System.Windows.Forms.Timer = DirectCast(sender, System.Windows.Forms.Timer)
        Dim beat As Integer = CInt(timer.Tag)

        Me.Invoke(Sub()
                      ' Nur den aktuellen Beat zurücksetzen
                      Select Case beat
                          Case 1
                              Beat1.BackColor = xdarkgray
                              StartStopLED.BackColor = xdarkgray
                          Case 2
                              Beat2.BackColor = xdarkgray
                              StartStopLED.BackColor = xdarkgray
                          Case 3
                              Beat3.BackColor = xdarkgray
                              StartStopLED.BackColor = xdarkgray
                          Case 4
                              Beat4.BackColor = xdarkgray
                              StartStopLED.BackColor = xdarkgray
                      End Select

                      ' Timer aufräumen
                      timer.Stop()
                      RemoveHandler timer.Tick, AddressOf ResetBeatDisplay
                      timer.Dispose()
                  End Sub)
    End Sub

    Private Sub ResetButtonDisplay(sender As Object, e As EventArgs)
        Dim timer As System.Windows.Forms.Timer = DirectCast(sender, System.Windows.Forms.Timer)
        Dim beat As Integer = CInt(timer.Tag)

        Me.Invoke(Sub()
                      ' Nur den aktuellen Beat zurücksetzen
                      Select Case beat
                          Case 1
                              StartStopLED.BackColor = xdarkgray
                          Case 2
                              StartStopLED.BackColor = xdarkgray
                          Case 3
                              StartStopLED.BackColor = xdarkgray
                          Case 4
                              StartStopLED.BackColor = xdarkgray
                      End Select

                      ' Timer aufräumen
                      timer.Stop()
                      RemoveHandler timer.Tick, AddressOf ResetButtonDisplay
                      timer.Dispose()
                  End Sub)
    End Sub

    Private Function GetCurrentSection() As String
        If intro Then
            Return "Intro" & selectintro
        ElseIf break Then
            Return "Break" & ritim
        ElseIf outro Then
            Return "Outro" & selectoutro
        Else
            Return "Main" & ritim
        End If

    End Function

    ' ========== PLAYBACK-FUNKTIONEN ==========
    Private Sub PlayIntro()
        Select Case selectintro
            Case 1
                PlayBufferedAudio("Intro1")
                beatsProTakt = Intro1beats
            Case 2
                PlayBufferedAudio("Intro2")
                beatsProTakt = Intro2beats
            Case 3
                PlayBufferedAudio("Intro3")
                beatsProTakt = Intro3beats
        End Select
        intro = False
    End Sub

    Private Sub PlayRitim()
        Select Case ritim
            Case 1
                PlayBufferedAudio("Main1")
                beatsProTakt = Main1beats
            Case 2
                PlayBufferedAudio("Main2")
                beatsProTakt = Main2beats
            Case 3
                PlayBufferedAudio("Main3")
                beatsProTakt = Main3beats
            Case 4
                PlayBufferedAudio("Main4")
                beatsProTakt = Main4beats
        End Select
    End Sub

    Private Sub PlayBreak()
        Select Case ritim
            Case 1
                PlayBufferedAudio("Auto1")
                beatsProTakt = Auto1beats
            Case 2
                PlayBufferedAudio("Auto2")
                beatsProTakt = Auto2beats
            Case 3
                PlayBufferedAudio("Auto3")
                beatsProTakt = Auto3beats
            Case 4
                PlayBufferedAudio("Auto4")
                beatsProTakt = Auto4beats
        End Select
        break = False
    End Sub

    Private Sub PlayOutro()
        Select Case selectoutro
            Case 1
                PlayBufferedAudio("Outro1")
                beatsProTakt = Outro1beats
            Case 2
                PlayBufferedAudio("Outro2")
                beatsProTakt = Outro2beats
            Case 3
                PlayBufferedAudio("Outro3")
                beatsProTakt = Outro3beats
        End Select
        outro = False
    End Sub

    ' ========== UI-HANDLER ==========
    ' (Die restlichen Event-Handler bleiben weitgehend gleich, 
    '  aber verwenden nun die neuen Methodennamen)

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ResetLEDs()
        If Changemode = "Direct" Then
            beatCount = 0
        End If
        ritim = 1
        LoadSample()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ResetLEDs()
        If Changemode = "Direct" Then
            beatCount = 0
        End If
        ritim = 2
        LoadSample()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Changemode = "Direct" Then
            beatCount = 0
        End If
        ritim = 3
        LoadSample()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Changemode = "Direct" Then
            beatCount = 0
        End If
        ritim = 4
        LoadSample()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim currentSection As String = ""
        Dim newSection As String = GetCurrentSection()
        If newSection <> currentSection Then
            beatCount = 1
            currentSection = newSection
        End If

        intro = True
        selectintro = 1
        If Changemode = "Direct" Then
            beatCount = 0
        End If
        LoadSample()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        intro = True
        selectintro = 2
        If Changemode = "Direct" Then
            beatCount = 0
        End If
        LoadSample()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        intro = True
        selectintro = 3
        If Changemode = "Direct" Then
            beatCount = 0
        End If
        LoadSample()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        break = True
        If Changemode = "Direct" Then
            beatCount = 0
        End If
        LoadSample()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        outro = True
        intro = False
        selectoutro = 1
        If Changemode = "Direct" Then
            beatCount = 0
        End If
        LoadSample()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        outro = True
        intro = False
        selectoutro = 2
        If Changemode = "Direct" Then
            beatCount = 0
        End If
        LoadSample()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        outro = True
        intro = False
        selectoutro = 1
        If Changemode = "Direct" Then
            beatCount = 0
        End If
        LoadSample()
    End Sub

    Private Sub ResetLEDs()
        LoadSample()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        StopMetronom()
        StartDisplay.Close()
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Style1_Panel.Click
        Form2.Show()
    End Sub

    Private Sub Style2_Label_Click(sender As Object, e As EventArgs) Handles Style2_Label.Click
        Active = 2
        'Panel1 UI Change
        Style1_Panel.BackgroundImage = My.Resources.BTN_Untoggled
        Style1_Label.ForeColor = xdarkgray
        Style_Name.ForeColor = xdarkgray
        Family_Name.ForeColor = xdarkgray
        BPM_Label.ForeColor = xdarkgray
        DataType_Label.ForeColor = xdarkgray
        'Panel2 UI Change
        Style2_Panel.BackgroundImage = My.Resources.BTN_Toggled
        Style2_Label.ForeColor = Color.Black
        Style2_Name.ForeColor = xblue
        Family2_Name.ForeColor = xblue
        BPM2_Label.ForeColor = xblue
        DataType2_Label.ForeColor = xblue
        Style = Style2_Name.Text
        LoadSample()
        ClearAllAudioBuffers()
        PreloadAllAudioFiles()
    End Sub

    Private Sub Style1_Label_Click(sender As Object, e As EventArgs) Handles Style1_Label.Click
        Active = 1
        'Panel2 UI Change
        Style2_Panel.BackgroundImage = My.Resources.BTN_Untoggled
        Style2_Label.ForeColor = xdarkgray
        Style2_Name.ForeColor = xdarkgray
        Family2_Name.ForeColor = xdarkgray
        BPM2_Label.ForeColor = xdarkgray
        DataType2_Label.ForeColor = xdarkgray
        Style = Style2_Name.Text
        'Panel1 UI Change
        Style1_Panel.BackgroundImage = My.Resources.BTN_Toggled
        Style1_Label.ForeColor = Color.Black
        Style_Name.ForeColor = xblue
        Family_Name.ForeColor = xblue
        BPM_Label.ForeColor = xblue
        DataType_Label.ForeColor = xblue
        Style = Style_Name.Text
        LoadSample()
        ClearAllAudioBuffers()
        PreloadAllAudioFiles()
    End Sub

    Private Sub Family_Name_Click(sender As Object, e As EventArgs) Handles Family_Name.Click
        Form2.Show()
    End Sub

    Private Sub Style_Name_Click(sender As Object, e As EventArgs) Handles Style_Name.Click
        Form2.Show()
    End Sub

    Private Sub BPM_Label_Click(sender As Object, e As EventArgs) Handles BPM_Label.Click
        Form2.Show()
    End Sub

    Private Sub DataType_Label_Click(sender As Object, e As EventArgs) Handles DataType_Label.Click
        Form2.Show()
    End Sub

    Private Sub Family2_Name_Click(sender As Object, e As EventArgs) Handles Family2_Name.Click
        Form2.Show()
    End Sub

    Private Sub Style2_Name_Click(sender As Object, e As EventArgs) Handles Style2_Name.Click
        Form2.Show()
    End Sub

    Private Sub BPM2_Label_Click(sender As Object, e As EventArgs) Handles BPM2_Label.Click
        Form2.Show()
    End Sub

    Private Sub DataType2_Label_Click(sender As Object, e As EventArgs) Handles DataType2_Label.Click
        Form2.Show()
    End Sub

    Private Sub Style2_Panel_Click(sender As Object, e As EventArgs) Handles Style2_Panel.Click
        Form2.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles AutoAssist_Label.Click
        Rhythmonly_Label.ForeColor = xdarkgray
        AutoAssist_Label.ForeColor = xgreen
        AutoPlay_Label.ForeColor = xdarkgray
        Accompaniment = "Assist"
        LoadSample()
        ClearAllAudioBuffers()
        PreloadAllAudioFiles()
    End Sub

    Private Sub Rhythmonly_Label_Click(sender As Object, e As EventArgs) Handles Rhythmonly_Label.Click
        Rhythmonly_Label.ForeColor = xgreen
        AutoAssist_Label.ForeColor = xdarkgray
        AutoPlay_Label.ForeColor = xdarkgray
        Accompaniment = "Off"
        LoadSample()
        ClearAllAudioBuffers()
        PreloadAllAudioFiles()
    End Sub

    Private Sub AutoPlay_Label_Click(sender As Object, e As EventArgs) Handles AutoPlay_Label.Click
        Rhythmonly_Label.ForeColor = xdarkgray
        AutoAssist_Label.ForeColor = xdarkgray
        AutoPlay_Label.ForeColor = xgreen
        Accompaniment = "Full"
        LoadSample()
        ClearAllAudioBuffers()
        PreloadAllAudioFiles()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Changemode_Label.Click
        If Changemode = "Direct" Then
            Changemode_Label.Text = "Ending"
            Changemode = "Ending"
        ElseIf Changemode = "Ending" Then
            Changemode_Label.Text = "Direct"
            Changemode = "Direct"
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        BPMValueSetting.Show()
    End Sub

    Private Sub BPMValue_Label_Click(sender As Object, e As EventArgs) Handles BPMValue_Label.Click
        BPMValueSetting.Show()
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        If My.Settings.FKey Then
            If e.KeyCode = Keys.F1 Then
                If Changemode = "Direct" Then
                    Changemode_Label.Text = "Ending"
                    Changemode = "Ending"
                ElseIf Changemode = "Ending" Then
                    Changemode_Label.Text = "Direct"
                    Changemode = "Direct"
                End If
            ElseIf e.KeyCode = Keys.F2 Then
                intro = True
                selectintro = 1
                If Changemode = "Direct" Then
                    beatCount = 0
                End If
                LoadSample()
            ElseIf e.KeyCode = Keys.F3 Then
                intro = True
                selectintro = 2
                If Changemode = "Direct" Then
                    beatCount = 0
                End If
                LoadSample()
            ElseIf e.KeyCode = Keys.F4 Then
                intro = True
                selectintro = 3
                If Changemode = "Direct" Then
                    beatCount = 0
                End If
                LoadSample()
            ElseIf e.KeyCode = Keys.F5 Then
                ResetLEDs()
                If Changemode = "Direct" Then
                    beatCount = 0
                End If
                ritim = 1
                LoadSample()
            ElseIf e.KeyCode = Keys.F6 Then
                ResetLEDs()
                If Changemode = "Direct" Then
                    beatCount = 0
                End If
                ritim = 2
                LoadSample()
            ElseIf e.KeyCode = Keys.F7 Then
                ResetLEDs()
                If Changemode = "Direct" Then
                    beatCount = 0
                End If
                ritim = 3
                LoadSample()
            ElseIf e.KeyCode = Keys.F8 Then
                ResetLEDs()
                If Changemode = "Direct" Then
                    beatCount = 0
                End If
                ritim = 4
                LoadSample()
            ElseIf e.KeyCode = Keys.F9 Then
                break = True
                If Changemode = "Direct" Then
                    beatCount = 0
                End If
                LoadSample()
            ElseIf e.KeyCode = Keys.F10 Then
                outro = True
                intro = False
                selectoutro = 1
                If Changemode = "Direct" Then
                    beatCount = 0
                End If
                LoadSample()
            ElseIf e.KeyCode = Keys.F11 Then
                outro = True
                intro = False
                selectoutro = 2
                If Changemode = "Direct" Then
                    beatCount = 0
                End If
                LoadSample()
            ElseIf e.KeyCode = Keys.F12 Then
                outro = True
                intro = False
                selectoutro = 3
                If Changemode = "Direct" Then
                    beatCount = 0
                End If
                LoadSample()
            ElseIf e.KeyCode = Keys.Escape Then
                If Not metronomRunning Then
                    StartMetronom()
                    Button1.Text = "Stop"
                Else
                    StopMetronom()
                    Button1.Text = "Start"
                End If
                'Mechanismus zum wechseln zwischen Style 1 und Style 2
            ElseIf e.KeyCode = Keys.PageUp Then
                Active = 1
                'Panel2 UI Change
                Style2_Panel.BackgroundImage = My.Resources.BTN_Untoggled
                Style2_Label.ForeColor = xdarkgray
                Style2_Name.ForeColor = xdarkgray
                Family2_Name.ForeColor = xdarkgray
                BPM2_Label.ForeColor = xdarkgray
                DataType2_Label.ForeColor = xdarkgray
                Style = Style2_Name.Text
                'Panel1 UI Change
                Style1_Panel.BackgroundImage = My.Resources.BTN_Toggled
                Style1_Label.ForeColor = Color.Black
                Style_Name.ForeColor = xblue
                Family_Name.ForeColor = xblue
                BPM_Label.ForeColor = xblue
                DataType_Label.ForeColor = xblue
                Style = Style_Name.Text
                LoadSample()
                ClearAllAudioBuffers()
                PreloadAllAudioFiles()
            ElseIf e.KeyCode = Keys.PageDown Then
                Active = 2
                'Panel1 UI Change
                Style1_Panel.BackgroundImage = My.Resources.BTN_Untoggled
                Style1_Label.ForeColor = xdarkgray
                Style_Name.ForeColor = xdarkgray
                Family_Name.ForeColor = xdarkgray
                BPM_Label.ForeColor = xdarkgray
                DataType_Label.ForeColor = xdarkgray
                'Panel2 UI Change
                Style2_Panel.BackgroundImage = My.Resources.BTN_Toggled
                Style2_Label.ForeColor = Color.Black
                Style2_Name.ForeColor = xblue
                Family2_Name.ForeColor = xblue
                BPM2_Label.ForeColor = xblue
                DataType2_Label.ForeColor = xblue
                Style = Style2_Name.Text
                LoadSample()
                ClearAllAudioBuffers()
                PreloadAllAudioFiles()
            ElseIf e.KeyCode = Keys.ControlKey Then
                BPMValueSetting.Show()
            ElseIf e.KeyCode = Keys.Alt Then
                LightEffect = 1
            ElseIf e.KeyCode = Keys.D1 Then
                Rhythmonly_Label.ForeColor = xgreen
                AutoAssist_Label.ForeColor = xdarkgray
                AutoPlay_Label.ForeColor = xdarkgray
                Accompaniment = "Off"
                LoadSample()
                ClearAllAudioBuffers()
                PreloadAllAudioFiles()
            ElseIf e.KeyCode = Keys.D2 Then
                Rhythmonly_Label.ForeColor = xdarkgray
                AutoAssist_Label.ForeColor = xgreen
                AutoPlay_Label.ForeColor = xdarkgray
                Accompaniment = "Assist"
                LoadSample()
                ClearAllAudioBuffers()
                PreloadAllAudioFiles()
            ElseIf e.KeyCode = Keys.D3 Then
                Rhythmonly_Label.ForeColor = xdarkgray
                AutoAssist_Label.ForeColor = xdarkgray
                AutoPlay_Label.ForeColor = xgreen
                Accompaniment = "Full"
                LoadSample()
                ClearAllAudioBuffers()
                PreloadAllAudioFiles()
            End If
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Settings.Show()
    End Sub
End Class