<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kamar_
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kamar_))
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStripBtnKamar = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnInfo = New System.Windows.Forms.Button()
        Me.ToolStripKamar_ = New System.Windows.Forms.ToolStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewKamar = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ToolStripKamar_.SuspendLayout()
        CType(Me.DataGridViewKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.DimGray
        Me.BtnTambah.BackgroundImage = CType(resources.GetObject("BtnTambah.BackgroundImage"), System.Drawing.Image)
        Me.BtnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnTambah.Location = New System.Drawing.Point(984, 21)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(38, 38)
        Me.BtnTambah.TabIndex = 103
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblEmail.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblEmail.ForeColor = System.Drawing.Color.Black
        Me.LblEmail.Location = New System.Drawing.Point(230, 110)
        Me.LblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(208, 32)
        Me.LblEmail.TabIndex = 99
        Me.LblEmail.Text = "User@gmail.com"
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.BackColor = System.Drawing.Color.Transparent
        Me.LblUser.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblUser.ForeColor = System.Drawing.Color.Black
        Me.LblUser.Location = New System.Drawing.Point(297, 76)
        Me.LblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(65, 32)
        Me.LblUser.TabIndex = 98
        Me.LblUser.Text = "User"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.LblEmail)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.LblUser)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(13, 194)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(668, 217)
        Me.Panel3.TabIndex = 111
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(61, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 167)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(230, 76)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 32)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Hello,"
        '
        'ToolStripBtnKamar
        '
        Me.ToolStripBtnKamar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtnKamar.Image = CType(resources.GetObject("ToolStripBtnKamar.Image"), System.Drawing.Image)
        Me.ToolStripBtnKamar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnKamar.Name = "ToolStripBtnKamar"
        Me.ToolStripBtnKamar.Size = New System.Drawing.Size(30, 28)
        Me.ToolStripBtnKamar.Text = "ToolStripButton1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.BtnTambah)
        Me.Panel2.Controls.Add(Me.BtnHapus)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.BtnInfo)
        Me.Panel2.Location = New System.Drawing.Point(13, 109)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1172, 75)
        Me.Panel2.TabIndex = 115
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.DimGray
        Me.BtnHapus.BackgroundImage = CType(resources.GetObject("BtnHapus.BackgroundImage"), System.Drawing.Image)
        Me.BtnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHapus.Location = New System.Drawing.Point(1118, 21)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(38, 39)
        Me.BtnHapus.TabIndex = 99
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Papyrus", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(62, 4)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(413, 65)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "HOTEL AYO'S"
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.DimGray
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEdit.Location = New System.Drawing.Point(1029, 21)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(38, 39)
        Me.BtnEdit.TabIndex = 98
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnInfo
        '
        Me.BtnInfo.BackColor = System.Drawing.Color.DimGray
        Me.BtnInfo.BackgroundImage = CType(resources.GetObject("BtnInfo.BackgroundImage"), System.Drawing.Image)
        Me.BtnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnInfo.Location = New System.Drawing.Point(1074, 21)
        Me.BtnInfo.Name = "BtnInfo"
        Me.BtnInfo.Size = New System.Drawing.Size(38, 39)
        Me.BtnInfo.TabIndex = 100
        Me.BtnInfo.UseVisualStyleBackColor = False
        '
        'ToolStripKamar_
        '
        Me.ToolStripKamar_.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStripKamar_.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStripKamar_.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnKamar})
        Me.ToolStripKamar_.Location = New System.Drawing.Point(1199, 0)
        Me.ToolStripKamar_.Name = "ToolStripKamar_"
        Me.ToolStripKamar_.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStripKamar_.Size = New System.Drawing.Size(37, 852)
        Me.ToolStripKamar_.TabIndex = 113
        Me.ToolStripKamar_.Text = "ToolStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(61, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KAMAR"
        '
        'DataGridViewKamar
        '
        Me.DataGridViewKamar.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridViewKamar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKamar.Location = New System.Drawing.Point(13, 433)
        Me.DataGridViewKamar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridViewKamar.Name = "DataGridViewKamar"
        Me.DataGridViewKamar.RowHeadersWidth = 62
        Me.DataGridViewKamar.RowTemplate.Height = 25
        Me.DataGridViewKamar.Size = New System.Drawing.Size(1172, 389)
        Me.DataGridViewKamar.TabIndex = 116
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 14)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1172, 85)
        Me.Panel1.TabIndex = 114
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Black
        Me.BtnLogout.BackgroundImage = CType(resources.GetObject("BtnLogout.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnLogout.Location = New System.Drawing.Point(1114, 22)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(41, 39)
        Me.BtnLogout.TabIndex = 82
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Location = New System.Drawing.Point(706, 194)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(479, 217)
        Me.Panel4.TabIndex = 112
        '
        'Kamar_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1236, 852)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStripKamar_)
        Me.Controls.Add(Me.DataGridViewKamar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Kamar_"
        Me.Text = "Kamar_"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStripKamar_.ResumeLayout(False)
        Me.ToolStripKamar_.PerformLayout()
        CType(Me.DataGridViewKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTambah As Button
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblUser As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolStripBtnKamar As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnHapus As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnInfo As Button
    Friend WithEvents ToolStripKamar_ As ToolStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewKamar As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Panel4 As Panel
End Class
