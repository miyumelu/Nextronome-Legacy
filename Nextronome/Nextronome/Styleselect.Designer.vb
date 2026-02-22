<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Dance = New System.Windows.Forms.TabPage()
        Me.Pianist = New System.Windows.Forms.TabPage()
        Me.World = New System.Windows.Forms.TabPage()
        Me.ExpansionUser = New System.Windows.Forms.TabPage()
        Me.iQPlay = New System.Windows.Forms.TabPage()
        Me.Songs = New System.Windows.Forms.TabPage()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.ExpansionUser.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Font = New System.Drawing.Font("SF UI Display Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.ForeColor = System.Drawing.Color.White
        Me.HomeButton.Location = New System.Drawing.Point(3, 770)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(1437, 65)
        Me.HomeButton.TabIndex = 42
        Me.HomeButton.Text = "Back"
        Me.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Black
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Font = New System.Drawing.Font("SF UI Display Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1432, 570)
        Me.ListView1.TabIndex = 43
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("SF UI Display Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(8, 650)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(708, 100)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Set Style 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("SF UI Display Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(724, 650)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(708, 100)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Set Style 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.Dance)
        Me.TabControl1.Controls.Add(Me.Pianist)
        Me.TabControl1.Controls.Add(Me.World)
        Me.TabControl1.Controls.Add(Me.ExpansionUser)
        Me.TabControl1.Controls.Add(Me.iQPlay)
        Me.TabControl1.Controls.Add(Me.Songs)
        Me.TabControl1.Font = New System.Drawing.Font("SF UI Display Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(500, 70)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1440, 644)
        Me.TabControl1.TabIndex = 46
        '
        'Dance
        '
        Me.Dance.BackColor = System.Drawing.Color.Black
        Me.Dance.Location = New System.Drawing.Point(4, 74)
        Me.Dance.Name = "Dance"
        Me.Dance.Padding = New System.Windows.Forms.Padding(3)
        Me.Dance.Size = New System.Drawing.Size(1432, 566)
        Me.Dance.TabIndex = 1
        Me.Dance.Text = "Dance"
        '
        'Pianist
        '
        Me.Pianist.BackColor = System.Drawing.Color.Black
        Me.Pianist.Location = New System.Drawing.Point(4, 74)
        Me.Pianist.Name = "Pianist"
        Me.Pianist.Size = New System.Drawing.Size(1432, 566)
        Me.Pianist.TabIndex = 2
        Me.Pianist.Text = "Pianist"
        '
        'World
        '
        Me.World.BackColor = System.Drawing.Color.Black
        Me.World.Location = New System.Drawing.Point(4, 74)
        Me.World.Name = "World"
        Me.World.Size = New System.Drawing.Size(1432, 566)
        Me.World.TabIndex = 3
        Me.World.Text = "World"
        '
        'ExpansionUser
        '
        Me.ExpansionUser.Controls.Add(Me.ListView1)
        Me.ExpansionUser.Location = New System.Drawing.Point(4, 74)
        Me.ExpansionUser.Name = "ExpansionUser"
        Me.ExpansionUser.Padding = New System.Windows.Forms.Padding(3)
        Me.ExpansionUser.Size = New System.Drawing.Size(1432, 566)
        Me.ExpansionUser.TabIndex = 0
        Me.ExpansionUser.Text = "Expansion/User"
        Me.ExpansionUser.UseVisualStyleBackColor = True
        '
        'iQPlay
        '
        Me.iQPlay.BackColor = System.Drawing.Color.Black
        Me.iQPlay.Location = New System.Drawing.Point(4, 74)
        Me.iQPlay.Name = "iQPlay"
        Me.iQPlay.Size = New System.Drawing.Size(1432, 566)
        Me.iQPlay.TabIndex = 5
        Me.iQPlay.Text = "iQPlay"
        '
        'Songs
        '
        Me.Songs.BackColor = System.Drawing.Color.Black
        Me.Songs.Location = New System.Drawing.Point(4, 74)
        Me.Songs.Name = "Songs"
        Me.Songs.Size = New System.Drawing.Size(1432, 566)
        Me.Songs.TabIndex = 4
        Me.Songs.Text = "Songs"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PictureBox5.Location = New System.Drawing.Point(0, 754)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1440, 3)
        Me.PictureBox5.TabIndex = 41
        Me.PictureBox5.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1440, 847)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.PictureBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Styleselect"
        Me.TabControl1.ResumeLayout(False)
        Me.ExpansionUser.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeButton As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ExpansionUser As TabPage
    Friend WithEvents Dance As TabPage
    Friend WithEvents Pianist As TabPage
    Friend WithEvents World As TabPage
    Friend WithEvents iQPlay As TabPage
    Friend WithEvents Songs As TabPage
End Class
