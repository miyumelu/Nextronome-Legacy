<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.HomeButton = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.MetMo = New System.Windows.Forms.TabPage()
        Me.UpdateFlash = New System.Windows.Forms.TabPage()
        Me.SysInf = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Family2_Name = New System.Windows.Forms.Label()
        Me.KeyCon = New System.Windows.Forms.TabPage()
        Me.Fkeyswitch = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BeatLED = New System.Windows.Forms.TabPage()
        Me.Fkeyalternate = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SysInf.SuspendLayout()
        Me.KeyCon.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.BeatLED.SuspendLayout()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Font = New System.Drawing.Font("SF UI Display Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.ForeColor = System.Drawing.Color.White
        Me.HomeButton.Location = New System.Drawing.Point(3, 770)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(1437, 65)
        Me.HomeButton.TabIndex = 44
        Me.HomeButton.Text = "Back"
        Me.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PictureBox5.Location = New System.Drawing.Point(0, 754)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1440, 3)
        Me.PictureBox5.TabIndex = 43
        Me.PictureBox5.TabStop = False
        '
        'MetMo
        '
        Me.MetMo.BackColor = System.Drawing.Color.Black
        Me.MetMo.Location = New System.Drawing.Point(4, 74)
        Me.MetMo.Name = "MetMo"
        Me.MetMo.Size = New System.Drawing.Size(1420, 678)
        Me.MetMo.TabIndex = 5
        Me.MetMo.Text = "Metronome Mode"
        '
        'UpdateFlash
        '
        Me.UpdateFlash.BackColor = System.Drawing.Color.Black
        Me.UpdateFlash.Location = New System.Drawing.Point(4, 74)
        Me.UpdateFlash.Name = "UpdateFlash"
        Me.UpdateFlash.Padding = New System.Windows.Forms.Padding(3)
        Me.UpdateFlash.Size = New System.Drawing.Size(1420, 678)
        Me.UpdateFlash.TabIndex = 0
        Me.UpdateFlash.Text = "Update/Flash"
        '
        'SysInf
        '
        Me.SysInf.BackColor = System.Drawing.Color.Black
        Me.SysInf.Controls.Add(Me.Label4)
        Me.SysInf.Controls.Add(Me.Label3)
        Me.SysInf.Controls.Add(Me.Label2)
        Me.SysInf.Controls.Add(Me.Label1)
        Me.SysInf.Controls.Add(Me.Family2_Name)
        Me.SysInf.Location = New System.Drawing.Point(4, 74)
        Me.SysInf.Name = "SysInf"
        Me.SysInf.Size = New System.Drawing.Size(1420, 678)
        Me.SysInf.TabIndex = 3
        Me.SysInf.Text = "System Information"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Adam Medium", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(-2, 624)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1440, 40)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "KAVN | future to people | 2025"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("SF UI Display Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-2, 417)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1440, 35)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ACUnit 0.06.25"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("SF UI Display Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-2, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1440, 35)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Build 1025RTNX"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("SF UI Display Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-2, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1440, 35)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Version 24.10.25"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Family2_Name
        '
        Me.Family2_Name.BackColor = System.Drawing.Color.Transparent
        Me.Family2_Name.Font = New System.Drawing.Font("Adam Medium", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Family2_Name.ForeColor = System.Drawing.Color.White
        Me.Family2_Name.Location = New System.Drawing.Point(-2, 177)
        Me.Family2_Name.Name = "Family2_Name"
        Me.Family2_Name.Size = New System.Drawing.Size(1440, 70)
        Me.Family2_Name.TabIndex = 6
        Me.Family2_Name.Text = "KAVN Rhytmos"
        Me.Family2_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KeyCon
        '
        Me.KeyCon.BackColor = System.Drawing.Color.Black
        Me.KeyCon.Controls.Add(Me.Fkeyswitch)
        Me.KeyCon.Controls.Add(Me.Label6)
        Me.KeyCon.Controls.Add(Me.Label5)
        Me.KeyCon.Location = New System.Drawing.Point(4, 74)
        Me.KeyCon.Name = "KeyCon"
        Me.KeyCon.Size = New System.Drawing.Size(1420, 678)
        Me.KeyCon.TabIndex = 2
        Me.KeyCon.Text = "Keyboard Control"
        '
        'Fkeyswitch
        '
        Me.Fkeyswitch.BackColor = System.Drawing.Color.Transparent
        Me.Fkeyswitch.Font = New System.Drawing.Font("SF UI Display Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fkeyswitch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Fkeyswitch.Location = New System.Drawing.Point(1038, 151)
        Me.Fkeyswitch.Name = "Fkeyswitch"
        Me.Fkeyswitch.Size = New System.Drawing.Size(350, 50)
        Me.Fkeyswitch.TabIndex = 49
        Me.Fkeyswitch.Text = "Disabled"
        Me.Fkeyswitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("SF UI Display Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(77, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(857, 79)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "This function allows you to select variations using the F1 to F12 keys. This func" &
    "tion is intended for remote control."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("SF UI Display Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(29, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1074, 70)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Use F1-F12 keys"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.MetMo)
        Me.TabControl1.Controls.Add(Me.KeyCon)
        Me.TabControl1.Controls.Add(Me.BeatLED)
        Me.TabControl1.Controls.Add(Me.SysInf)
        Me.TabControl1.Controls.Add(Me.UpdateFlash)
        Me.TabControl1.Font = New System.Drawing.Font("SF UI Display Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(500, 70)
        Me.TabControl1.Location = New System.Drawing.Point(0, -2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1440, 756)
        Me.TabControl1.TabIndex = 47
        '
        'BeatLED
        '
        Me.BeatLED.BackColor = System.Drawing.Color.Black
        Me.BeatLED.Controls.Add(Me.Fkeyalternate)
        Me.BeatLED.Controls.Add(Me.Label13)
        Me.BeatLED.Controls.Add(Me.Label10)
        Me.BeatLED.Controls.Add(Me.Label11)
        Me.BeatLED.Controls.Add(Me.Label12)
        Me.BeatLED.Controls.Add(Me.Label7)
        Me.BeatLED.Controls.Add(Me.Label8)
        Me.BeatLED.Controls.Add(Me.Label9)
        Me.BeatLED.Location = New System.Drawing.Point(4, 74)
        Me.BeatLED.Name = "BeatLED"
        Me.BeatLED.Padding = New System.Windows.Forms.Padding(3)
        Me.BeatLED.Size = New System.Drawing.Size(1432, 678)
        Me.BeatLED.TabIndex = 1
        Me.BeatLED.Text = "Beat LED"
        '
        'Fkeyalternate
        '
        Me.Fkeyalternate.BackColor = System.Drawing.Color.Transparent
        Me.Fkeyalternate.Font = New System.Drawing.Font("SF UI Display Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fkeyalternate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Fkeyalternate.Location = New System.Drawing.Point(1038, 574)
        Me.Fkeyalternate.Name = "Fkeyalternate"
        Me.Fkeyalternate.Size = New System.Drawing.Size(350, 50)
        Me.Fkeyalternate.TabIndex = 57
        Me.Fkeyalternate.Text = "Disabled"
        Me.Fkeyalternate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("SF UI Display Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(29, 564)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(1074, 70)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Alternate"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("SF UI Display Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(1038, 428)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(350, 50)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Disabled"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("SF UI Display Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(77, 416)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(857, 79)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Allows the Beat LEDs to flash on every first beat fully white, instead of only sh" &
    "owing a different color."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("SF UI Display Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(29, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(1074, 70)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Flash on first"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("SF UI Display Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(1038, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(350, 50)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Disabled"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("SF UI Display Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(77, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(857, 79)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "This activates a fading effect on every Beat LED. Like a lightbulb. This is howev" &
    "er pretty flawed."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("SF UI Display Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(29, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1074, 70)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Lightbulb effect"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1440, 847)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.PictureBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SysInf.ResumeLayout(False)
        Me.KeyCon.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.BeatLED.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeButton As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents MetMo As TabPage
    Friend WithEvents UpdateFlash As TabPage
    Friend WithEvents SysInf As TabPage
    Friend WithEvents KeyCon As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BeatLED As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Family2_Name As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Fkeyswitch As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Fkeyalternate As Label
    Friend WithEvents Label13 As Label
End Class
