<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoKamar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoKamar))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.GbKamar = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.LblNamaKamar = New System.Windows.Forms.Label()
        Me.LblJenis = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.GbKamar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel6.Location = New System.Drawing.Point(19, 603)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(499, 98)
        Me.Panel6.TabIndex = 89
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.Location = New System.Drawing.Point(19, 25)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(499, 98)
        Me.Panel5.TabIndex = 88
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Location = New System.Drawing.Point(19, 148)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(497, 127)
        Me.Panel3.TabIndex = 90
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.Color.Black
        Me.BtnKembali.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnKembali.ForeColor = System.Drawing.Color.White
        Me.BtnKembali.Location = New System.Drawing.Point(19, 523)
        Me.BtnKembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(169, 50)
        Me.BtnKembali.TabIndex = 92
        Me.BtnKembali.Text = "<< Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'GbKamar
        '
        Me.GbKamar.Controls.Add(Me.LblStatus)
        Me.GbKamar.Controls.Add(Me.LblNamaKamar)
        Me.GbKamar.Controls.Add(Me.Label3)
        Me.GbKamar.Controls.Add(Me.LblJenis)
        Me.GbKamar.Controls.Add(Me.Label10)
        Me.GbKamar.Controls.Add(Me.Label5)
        Me.GbKamar.Controls.Add(Me.Label6)
        Me.GbKamar.Controls.Add(Me.Label7)
        Me.GbKamar.Controls.Add(Me.Label13)
        Me.GbKamar.ForeColor = System.Drawing.Color.White
        Me.GbKamar.Location = New System.Drawing.Point(19, 288)
        Me.GbKamar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GbKamar.Name = "GbKamar"
        Me.GbKamar.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GbKamar.Size = New System.Drawing.Size(499, 215)
        Me.GbKamar.TabIndex = 91
        Me.GbKamar.TabStop = False
        Me.GbKamar.Text = "Informasi Kamar"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Variable Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(77, 37)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(326, 43)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "INFORMASI KAMAR"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblStatus.ForeColor = System.Drawing.Color.White
        Me.LblStatus.Location = New System.Drawing.Point(267, 139)
        Me.LblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(65, 25)
        Me.LblStatus.TabIndex = 101
        Me.LblStatus.Text = "Status"
        '
        'LblNamaKamar
        '
        Me.LblNamaKamar.AutoSize = True
        Me.LblNamaKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNamaKamar.ForeColor = System.Drawing.Color.White
        Me.LblNamaKamar.Location = New System.Drawing.Point(267, 57)
        Me.LblNamaKamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNamaKamar.Name = "LblNamaKamar"
        Me.LblNamaKamar.Size = New System.Drawing.Size(122, 25)
        Me.LblNamaKamar.TabIndex = 100
        Me.LblNamaKamar.Text = "Nama Kamar"
        '
        'LblJenis
        '
        Me.LblJenis.AutoSize = True
        Me.LblJenis.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblJenis.ForeColor = System.Drawing.Color.White
        Me.LblJenis.Location = New System.Drawing.Point(267, 99)
        Me.LblJenis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJenis.Name = "LblJenis"
        Me.LblJenis.Size = New System.Drawing.Size(114, 25)
        Me.LblJenis.TabIndex = 99
        Me.LblJenis.Text = "Jenis Kamar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(240, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 25)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(87, 57)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 25)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Nama Kamar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(240, 139)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 25)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(87, 144)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 25)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Status"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(240, 99)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 25)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(87, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Jenis Kamar"
        '
        'InfoKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(537, 727)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.GbKamar)
        Me.Name = "InfoKamar"
        Me.Text = "InfoKamar"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GbKamar.ResumeLayout(False)
        Me.GbKamar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnKembali As Button
    Friend WithEvents GbKamar As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents LblNamaKamar As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblJenis As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
End Class
