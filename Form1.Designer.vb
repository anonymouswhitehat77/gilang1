<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.hitung = New System.Windows.Forms.Button()
        Me.keliling_lingkaran = New System.Windows.Forms.TextBox()
        Me.luas_lingakran = New System.Windows.Forms.TextBox()
        Me.jari_jari = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.hit_tabung = New System.Windows.Forms.Button()
        Me.jarijari = New System.Windows.Forms.TextBox()
        Me.volume_tabung = New System.Windows.Forms.TextBox()
        Me.Tinggi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.hitung)
        Me.GroupBox1.Controls.Add(Me.keliling_lingkaran)
        Me.GroupBox1.Controls.Add(Me.luas_lingakran)
        Me.GroupBox1.Controls.Add(Me.jari_jari)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 229)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Keliling"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'hitung
        '
        Me.hitung.Location = New System.Drawing.Point(21, 151)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(75, 23)
        Me.hitung.TabIndex = 1
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'keliling_lingkaran
        '
        Me.keliling_lingkaran.Location = New System.Drawing.Point(168, 108)
        Me.keliling_lingkaran.Name = "keliling_lingkaran"
        Me.keliling_lingkaran.Size = New System.Drawing.Size(100, 23)
        Me.keliling_lingkaran.TabIndex = 4
        '
        'luas_lingakran
        '
        Me.luas_lingakran.Location = New System.Drawing.Point(168, 67)
        Me.luas_lingakran.Name = "luas_lingakran"
        Me.luas_lingakran.Size = New System.Drawing.Size(100, 23)
        Me.luas_lingakran.TabIndex = 3
        '
        'jari_jari
        '
        Me.jari_jari.Location = New System.Drawing.Point(168, 27)
        Me.jari_jari.Name = "jari_jari"
        Me.jari_jari.Size = New System.Drawing.Size(100, 23)
        Me.jari_jari.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Keliling Lingkaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Luas Lingkaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jari-jari"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.hit_tabung)
        Me.GroupBox2.Controls.Add(Me.jarijari)
        Me.GroupBox2.Controls.Add(Me.volume_tabung)
        Me.GroupBox2.Controls.Add(Me.Tinggi)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label)
        Me.GroupBox2.Location = New System.Drawing.Point(361, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 229)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "tabung"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(21, 180)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'hit_tabung
        '
        Me.hit_tabung.Location = New System.Drawing.Point(21, 151)
        Me.hit_tabung.Name = "hit_tabung"
        Me.hit_tabung.Size = New System.Drawing.Size(75, 23)
        Me.hit_tabung.TabIndex = 1
        Me.hit_tabung.Text = "Hitung"
        Me.hit_tabung.UseVisualStyleBackColor = True
        '
        'jarijari
        '
        Me.jarijari.Location = New System.Drawing.Point(168, 108)
        Me.jarijari.Name = "jarijari"
        Me.jarijari.Size = New System.Drawing.Size(100, 23)
        Me.jarijari.TabIndex = 4
        '
        'volume_tabung
        '
        Me.volume_tabung.Location = New System.Drawing.Point(168, 67)
        Me.volume_tabung.Name = "volume_tabung"
        Me.volume_tabung.Size = New System.Drawing.Size(100, 23)
        Me.volume_tabung.TabIndex = 3
        '
        'Tinggi
        '
        Me.Tinggi.Location = New System.Drawing.Point(168, 27)
        Me.Tinggi.Name = "Tinggi"
        Me.Tinggi.Size = New System.Drawing.Size(100, 23)
        Me.Tinggi.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "jari-jari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Volume Tabung"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(21, 33)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(38, 15)
        Me.Label.TabIndex = 0
        Me.Label.Text = "tinggi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents hitung As Button
    Friend WithEvents keliling_lingkaran As TextBox
    Friend WithEvents luas_lingakran As TextBox
    Friend WithEvents jari_jari As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents hit_tabung As Button
    Friend WithEvents jarijari As TextBox
    Friend WithEvents volume_tabung As TextBox
    Friend WithEvents Tinggi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label As Label
End Class
