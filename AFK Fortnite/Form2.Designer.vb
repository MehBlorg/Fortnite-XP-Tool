<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ButtonOtherStuff = New System.Windows.Forms.Button()
        Me.ButtonDonate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.TextBoxBy = New System.Windows.Forms.TextBox()
        Me.TextBoxVersion = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonOtherStuff
        '
        Me.ButtonOtherStuff.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonOtherStuff.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonOtherStuff.Location = New System.Drawing.Point(184, 168)
        Me.ButtonOtherStuff.Name = "ButtonOtherStuff"
        Me.ButtonOtherStuff.Size = New System.Drawing.Size(180, 23)
        Me.ButtonOtherStuff.TabIndex = 27
        Me.ButtonOtherStuff.Text = "Other Projects"
        Me.ButtonOtherStuff.UseVisualStyleBackColor = True
        '
        'ButtonDonate
        '
        Me.ButtonDonate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDonate.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonDonate.Location = New System.Drawing.Point(12, 170)
        Me.ButtonDonate.Name = "ButtonDonate"
        Me.ButtonDonate.Size = New System.Drawing.Size(166, 23)
        Me.ButtonDonate.TabIndex = 26
        Me.ButtonDonate.Text = "Donate!"
        Me.ButtonDonate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "By:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Version:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Program Name:"
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxDate.Location = New System.Drawing.Point(184, 142)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.ReadOnly = True
        Me.TextBoxDate.Size = New System.Drawing.Size(221, 21)
        Me.TextBoxDate.TabIndex = 21
        Me.TextBoxDate.Text = "Sep 2025"
        '
        'TextBoxBy
        '
        Me.TextBoxBy.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxBy.Location = New System.Drawing.Point(184, 103)
        Me.TextBoxBy.Name = "TextBoxBy"
        Me.TextBoxBy.ReadOnly = True
        Me.TextBoxBy.Size = New System.Drawing.Size(221, 21)
        Me.TextBoxBy.TabIndex = 20
        Me.TextBoxBy.Text = "Aidan Macgregor (Fork by MehBlorg"
        '
        'TextBoxVersion
        '
        Me.TextBoxVersion.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxVersion.Location = New System.Drawing.Point(184, 64)
        Me.TextBoxVersion.Name = "TextBoxVersion"
        Me.TextBoxVersion.ReadOnly = True
        Me.TextBoxVersion.Size = New System.Drawing.Size(221, 21)
        Me.TextBoxVersion.TabIndex = 19
        Me.TextBoxVersion.Text = "1.2.0.0"
        '
        'TextBoxName
        '
        Me.TextBoxName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(184, 25)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(221, 21)
        Me.TextBoxName.TabIndex = 18
        Me.TextBoxName.Text = "Aidan's Fortnite XP+ Tool"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-17, -23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 185)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 197)
        Me.Controls.Add(Me.ButtonOtherStuff)
        Me.Controls.Add(Me.ButtonDonate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxDate)
        Me.Controls.Add(Me.TextBoxBy)
        Me.Controls.Add(Me.TextBoxVersion)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "About Box"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonOtherStuff As Button
    Friend WithEvents ButtonDonate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents TextBoxBy As TextBox
    Friend WithEvents TextBoxVersion As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
