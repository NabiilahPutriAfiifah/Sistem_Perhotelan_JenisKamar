<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditKamar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditKamar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TxtNamaKamar = New System.Windows.Forms.TextBox()
        Me.BtnBatalKamar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GBStatus = New System.Windows.Forms.GroupBox()
        Me.RdBtnKosong = New System.Windows.Forms.RadioButton()
        Me.RdBtnTerisi = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CbJenisKamar = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnEditKamar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBStatus.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(29, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 66)
        Me.Panel1.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(338, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 45)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "EDIT KAMAR"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(29, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(875, 115)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 79
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(417, 72)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(422, 430)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 86
        Me.PictureBox2.TabStop = False
        '
        'TxtNamaKamar
        '
        Me.TxtNamaKamar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNamaKamar.Location = New System.Drawing.Point(473, 142)
        Me.TxtNamaKamar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNamaKamar.Name = "TxtNamaKamar"
        Me.TxtNamaKamar.Size = New System.Drawing.Size(320, 31)
        Me.TxtNamaKamar.TabIndex = 13
        '
        'BtnBatalKamar
        '
        Me.BtnBatalKamar.BackColor = System.Drawing.Color.Black
        Me.BtnBatalKamar.ForeColor = System.Drawing.Color.White
        Me.BtnBatalKamar.Location = New System.Drawing.Point(473, 393)
        Me.BtnBatalKamar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBatalKamar.Name = "BtnBatalKamar"
        Me.BtnBatalKamar.Size = New System.Drawing.Size(156, 53)
        Me.BtnBatalKamar.TabIndex = 18
        Me.BtnBatalKamar.Text = "Batal"
        Me.BtnBatalKamar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(473, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 24)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Nama Kamar *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(473, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 24)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Jenis Kamar *"
        '
        'GBStatus
        '
        Me.GBStatus.BackColor = System.Drawing.Color.Transparent
        Me.GBStatus.Controls.Add(Me.RdBtnKosong)
        Me.GBStatus.Controls.Add(Me.RdBtnTerisi)
        Me.GBStatus.ForeColor = System.Drawing.Color.White
        Me.GBStatus.Location = New System.Drawing.Point(473, 293)
        Me.GBStatus.Name = "GBStatus"
        Me.GBStatus.Size = New System.Drawing.Size(320, 78)
        Me.GBStatus.TabIndex = 83
        Me.GBStatus.TabStop = False
        Me.GBStatus.Text = "Status Kamar *"
        '
        'RdBtnKosong
        '
        Me.RdBtnKosong.AutoSize = True
        Me.RdBtnKosong.Location = New System.Drawing.Point(150, 35)
        Me.RdBtnKosong.Name = "RdBtnKosong"
        Me.RdBtnKosong.Size = New System.Drawing.Size(98, 29)
        Me.RdBtnKosong.TabIndex = 1
        Me.RdBtnKosong.TabStop = True
        Me.RdBtnKosong.Text = "Kosong"
        Me.RdBtnKosong.UseVisualStyleBackColor = True
        '
        'RdBtnTerisi
        '
        Me.RdBtnTerisi.AutoSize = True
        Me.RdBtnTerisi.Location = New System.Drawing.Point(13, 35)
        Me.RdBtnTerisi.Name = "RdBtnTerisi"
        Me.RdBtnTerisi.Size = New System.Drawing.Size(75, 29)
        Me.RdBtnTerisi.TabIndex = 0
        Me.RdBtnTerisi.TabStop = True
        Me.RdBtnTerisi.Text = "Terisi"
        Me.RdBtnTerisi.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(398, 413)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'CbJenisKamar
        '
        Me.CbJenisKamar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbJenisKamar.FormattingEnabled = True
        Me.CbJenisKamar.Location = New System.Drawing.Point(473, 229)
        Me.CbJenisKamar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CbJenisKamar.Name = "CbJenisKamar"
        Me.CbJenisKamar.Size = New System.Drawing.Size(320, 33)
        Me.CbJenisKamar.TabIndex = 85
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.BtnEditKamar)
        Me.Panel2.Controls.Add(Me.CbJenisKamar)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.GBStatus)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.BtnBatalKamar)
        Me.Panel2.Controls.Add(Me.TxtNamaKamar)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(29, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(875, 521)
        Me.Panel2.TabIndex = 78
        '
        'BtnEditKamar
        '
        Me.BtnEditKamar.BackColor = System.Drawing.Color.Black
        Me.BtnEditKamar.ForeColor = System.Drawing.Color.White
        Me.BtnEditKamar.Location = New System.Drawing.Point(637, 393)
        Me.BtnEditKamar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEditKamar.Name = "BtnEditKamar"
        Me.BtnEditKamar.Size = New System.Drawing.Size(156, 53)
        Me.BtnEditKamar.TabIndex = 87
        Me.BtnEditKamar.Text = "Edit"
        Me.BtnEditKamar.UseVisualStyleBackColor = False
        '
        'EditKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(932, 621)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "EditKamar"
        Me.Text = "EditKamarvb"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBStatus.ResumeLayout(False)
        Me.GBStatus.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TxtNamaKamar As TextBox
    Friend WithEvents BtnBatalKamar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GBStatus As GroupBox
    Friend WithEvents RdBtnKosong As RadioButton
    Friend WithEvents RdBtnTerisi As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CbJenisKamar As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnEditKamar As Button
End Class
