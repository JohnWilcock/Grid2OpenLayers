'
' Created by SharpDevelop.
' User: John
' Date: 03/02/2013
' Time: 16:03
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Form1
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.progressBar2 = New System.Windows.Forms.ProgressBar()
        Me.label4 = New System.Windows.Forms.Label()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.label9 = New System.Windows.Forms.Label()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.tabPage4 = New System.Windows.Forms.TabPage()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.button9 = New System.Windows.Forms.Button()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.tabPage5 = New System.Windows.Forms.TabPage()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.checkBox3 = New System.Windows.Forms.CheckBox()
        Me.numericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.button13 = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.listBox2 = New System.Windows.Forms.ListBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.tabPage6 = New System.Windows.Forms.TabPage()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.button11 = New System.Windows.Forms.Button()
        Me.button10 = New System.Windows.Forms.Button()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage5.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage6.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(341, 63)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 30)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Run"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(12, 37)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(404, 20)
        Me.textBox1.TabIndex = 1
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(12, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 21)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Select Input ASCII File"
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(12, 63)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(323, 30)
        Me.progressBar1.TabIndex = 3
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(422, 37)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(30, 23)
        Me.button2.TabIndex = 4
        Me.button2.Text = "..."
        Me.button2.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(118, 8)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(49, 23)
        Me.button3.TabIndex = 5
        Me.button3.Text = "Help"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.BackgroundImage = CType(resources.GetObject("button4.BackgroundImage"), System.Drawing.Image)
        Me.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button4.Location = New System.Drawing.Point(422, 63)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(30, 30)
        Me.button4.TabIndex = 6
        Me.button4.UseVisualStyleBackColor = True
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Controls.Add(Me.tabPage4)
        Me.tabControl1.Controls.Add(Me.tabPage5)
        Me.tabControl1.Controls.Add(Me.tabPage6)
        Me.tabControl1.Location = New System.Drawing.Point(12, 113)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(440, 145)
        Me.tabControl1.TabIndex = 0
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.Button14)
        Me.tabPage1.Controls.Add(Me.Panel1)
        Me.tabPage1.Controls.Add(Me.progressBar2)
        Me.tabPage1.Controls.Add(Me.label4)
        Me.tabPage1.Controls.Add(Me.button8)
        Me.tabPage1.Controls.Add(Me.button7)
        Me.tabPage1.Controls.Add(Me.button6)
        Me.tabPage1.Controls.Add(Me.button5)
        Me.tabPage1.Controls.Add(Me.label3)
        Me.tabPage1.Controls.Add(Me.label2)
        Me.tabPage1.Controls.Add(Me.pictureBox1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(432, 119)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Colours"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(180, 86)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(65, 23)
        Me.Button14.TabIndex = 10
        Me.Button14.Text = "Show info"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Location = New System.Drawing.Point(7, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 386)
        Me.Panel1.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(3, 3)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(411, 154)
        Me.TextBox5.TabIndex = 0
        Me.TextBox5.Text = resources.GetString("TextBox5.Text")
        '
        'progressBar2
        '
        Me.progressBar2.Location = New System.Drawing.Point(7, 86)
        Me.progressBar2.Name = "progressBar2"
        Me.progressBar2.Size = New System.Drawing.Size(169, 23)
        Me.progressBar2.TabIndex = 8
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(3, 30)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(51, 23)
        Me.label4.TabIndex = 7
        Me.label4.Text = "Colour 2"
        '
        'button8
        '
        Me.button8.BackColor = System.Drawing.Color.Green
        Me.button8.Location = New System.Drawing.Point(76, 27)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(28, 23)
        Me.button8.TabIndex = 6
        Me.button8.UseVisualStyleBackColor = False
        '
        'button7
        '
        Me.button7.Location = New System.Drawing.Point(251, 86)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(63, 23)
        Me.button7.TabIndex = 5
        Me.button7.Text = "Preview"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.BackColor = System.Drawing.Color.Blue
        Me.button6.Location = New System.Drawing.Point(76, 51)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(28, 23)
        Me.button6.TabIndex = 4
        Me.button6.UseVisualStyleBackColor = False
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.Color.Red
        Me.button5.Location = New System.Drawing.Point(76, 3)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(28, 23)
        Me.button5.TabIndex = 3
        Me.button5.UseVisualStyleBackColor = False
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(4, 56)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 23)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Colour 3"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(3, 6)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 23)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Colour 1"
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Location = New System.Drawing.Point(320, 10)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(104, 103)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.Button15)
        Me.tabPage2.Controls.Add(Me.Panel2)
        Me.tabPage2.Controls.Add(Me.label6)
        Me.tabPage2.Controls.Add(Me.numericUpDown1)
        Me.tabPage2.Controls.Add(Me.label5)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(432, 119)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Grid"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(358, 93)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(65, 23)
        Me.Button15.TabIndex = 11
        Me.Button15.Text = "Show info"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox8)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.TextBox7)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Location = New System.Drawing.Point(6, 122)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(417, 383)
        Me.Panel2.TabIndex = 10
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Location = New System.Drawing.Point(3, 303)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(411, 77)
        Me.TextBox8.TabIndex = 5
        Me.TextBox8.Text = resources.GetString("TextBox8.Text")
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Location = New System.Drawing.Point(220, 172)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(173, 125)
        Me.TextBox6.TabIndex = 4
        Me.TextBox6.Text = resources.GetString("TextBox6.Text")
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Location = New System.Drawing.Point(16, 172)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(173, 125)
        Me.TextBox7.TabIndex = 3
        Me.TextBox7.Text = resources.GetString("TextBox7.Text")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(221, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(170, 163)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(16, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(170, 163)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(6, 38)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(358, 69)
        Me.label6.TabIndex = 3
        Me.label6.Text = resources.GetString("label6.Text")
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numericUpDown1.Location = New System.Drawing.Point(70, 11)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(68, 20)
        Me.numericUpDown1.TabIndex = 2
        Me.numericUpDown1.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(15, 11)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(49, 23)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Grid size"
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.Button16)
        Me.tabPage3.Controls.Add(Me.Panel3)
        Me.tabPage3.Controls.Add(Me.pictureBox3)
        Me.tabPage3.Controls.Add(Me.pictureBox2)
        Me.tabPage3.Controls.Add(Me.radioButton2)
        Me.tabPage3.Controls.Add(Me.radioButton1)
        Me.tabPage3.Controls.Add(Me.numericUpDown2)
        Me.tabPage3.Controls.Add(Me.label9)
        Me.tabPage3.Controls.Add(Me.textBox3)
        Me.tabPage3.Controls.Add(Me.textBox2)
        Me.tabPage3.Controls.Add(Me.label8)
        Me.tabPage3.Controls.Add(Me.label7)
        Me.tabPage3.Location = New System.Drawing.Point(4, 22)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage3.Size = New System.Drawing.Size(432, 119)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Cross Section"
        Me.tabPage3.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(358, 95)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(65, 23)
        Me.Button16.TabIndex = 11
        Me.Button16.Text = "Show info"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox11)
        Me.Panel3.Controls.Add(Me.TextBox10)
        Me.Panel3.Controls.Add(Me.PictureBox7)
        Me.Panel3.Controls.Add(Me.TextBox9)
        Me.Panel3.Location = New System.Drawing.Point(6, 121)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(417, 386)
        Me.Panel3.TabIndex = 10
        '
        'TextBox11
        '
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.Location = New System.Drawing.Point(204, 334)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(142, 30)
        Me.TextBox11.TabIndex = 5
        Me.TextBox11.Text = "Example of 10 sample points"
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.Location = New System.Drawing.Point(45, 334)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(142, 30)
        Me.TextBox10.TabIndex = 4
        Me.TextBox10.Text = "Example of 5 sample points"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(21, 81)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(354, 247)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 3
        Me.PictureBox7.TabStop = False
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Location = New System.Drawing.Point(3, 3)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(411, 73)
        Me.TextBox9.TabIndex = 0
        Me.TextBox9.Text = resources.GetString("TextBox9.Text")
        '
        'pictureBox3
        '
        Me.pictureBox3.BackgroundImage = CType(resources.GetObject("pictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox3.InitialImage = Nothing
        Me.pictureBox3.Location = New System.Drawing.Point(273, 82)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(79, 33)
        Me.pictureBox3.TabIndex = 9
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackgroundImage = CType(resources.GetObject("pictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox2.InitialImage = Nothing
        Me.pictureBox2.Location = New System.Drawing.Point(84, 82)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(79, 33)
        Me.pictureBox2.TabIndex = 8
        Me.pictureBox2.TabStop = False
        '
        'radioButton2
        '
        Me.radioButton2.Location = New System.Drawing.Point(192, 83)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(75, 30)
        Me.radioButton2.TabIndex = 7
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "Simple Sections"
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.Checked = True
        Me.radioButton1.Location = New System.Drawing.Point(6, 83)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(72, 32)
        Me.radioButton1.TabIndex = 6
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Complex Sections"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'numericUpDown2
        '
        Me.numericUpDown2.Location = New System.Drawing.Point(102, 57)
        Me.numericUpDown2.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(36, 20)
        Me.numericUpDown2.TabIndex = 5
        Me.numericUpDown2.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(6, 59)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(90, 20)
        Me.label9.TabIndex = 4
        Me.label9.Text = "Samples (Default)"
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(102, 31)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(165, 20)
        Me.textBox3.TabIndex = 3
        Me.textBox3.Text = "Elevation"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(102, 6)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(165, 20)
        Me.textBox2.TabIndex = 2
        Me.textBox2.Text = "Distance"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(6, 33)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(72, 20)
        Me.label8.TabIndex = 1
        Me.label8.Text = "Y Axis Label"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(6, 9)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(72, 20)
        Me.label7.TabIndex = 0
        Me.label7.Text = "X Axis Label"
        '
        'tabPage4
        '
        Me.tabPage4.Controls.Add(Me.Button17)
        Me.tabPage4.Controls.Add(Me.Panel4)
        Me.tabPage4.Controls.Add(Me.label10)
        Me.tabPage4.Controls.Add(Me.button9)
        Me.tabPage4.Controls.Add(Me.textBox4)
        Me.tabPage4.Location = New System.Drawing.Point(4, 22)
        Me.tabPage4.Name = "tabPage4"
        Me.tabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage4.Size = New System.Drawing.Size(432, 119)
        Me.tabPage4.TabIndex = 3
        Me.tabPage4.Text = "Background Image"
        Me.tabPage4.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(358, 95)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(65, 23)
        Me.Button17.TabIndex = 11
        Me.Button17.Text = "Show info"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TextBox13)
        Me.Panel4.Controls.Add(Me.PictureBox6)
        Me.Panel4.Controls.Add(Me.PictureBox8)
        Me.Panel4.Controls.Add(Me.TextBox12)
        Me.Panel4.Location = New System.Drawing.Point(6, 119)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(417, 386)
        Me.Panel4.TabIndex = 10
        '
        'TextBox13
        '
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox13.Location = New System.Drawing.Point(3, 281)
        Me.TextBox13.Multiline = True
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(411, 90)
        Me.TextBox13.TabIndex = 5
        Me.TextBox13.Text = "The selected image will be streched over the extent of the grid, the result will " &
    "look like the image on the right." & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The image formats supported are: PNG, JPG " &
    "and GIF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(226, 112)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(170, 163)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(21, 112)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(170, 163)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 3
        Me.PictureBox8.TabStop = False
        '
        'TextBox12
        '
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Location = New System.Drawing.Point(3, 3)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(411, 90)
        Me.TextBox12.TabIndex = 0
        Me.TextBox12.Text = resources.GetString("TextBox12.Text")
        '
        'label10
        '
        Me.label10.Location = New System.Drawing.Point(15, 10)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(375, 40)
        Me.label10.TabIndex = 9
        Me.label10.Text = "Select a image file to use as a background.  This must be exactly the same size a" &
    "s the ASCII grid as it will be streched to fit it."
        '
        'button9
        '
        Me.button9.Location = New System.Drawing.Point(396, 50)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(30, 23)
        Me.button9.TabIndex = 8
        Me.button9.Text = "..."
        Me.button9.UseVisualStyleBackColor = True
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(15, 53)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(377, 20)
        Me.textBox4.TabIndex = 0
        '
        'tabPage5
        '
        Me.tabPage5.Controls.Add(Me.Button18)
        Me.tabPage5.Controls.Add(Me.Panel5)
        Me.tabPage5.Controls.Add(Me.checkBox3)
        Me.tabPage5.Controls.Add(Me.numericUpDown3)
        Me.tabPage5.Controls.Add(Me.button13)
        Me.tabPage5.Controls.Add(Me.button12)
        Me.tabPage5.Controls.Add(Me.listBox2)
        Me.tabPage5.Controls.Add(Me.checkBox2)
        Me.tabPage5.Controls.Add(Me.checkBox1)
        Me.tabPage5.Location = New System.Drawing.Point(4, 22)
        Me.tabPage5.Name = "tabPage5"
        Me.tabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage5.Size = New System.Drawing.Size(432, 119)
        Me.tabPage5.TabIndex = 4
        Me.tabPage5.Text = "Options"
        Me.tabPage5.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(358, 95)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(65, 23)
        Me.Button18.TabIndex = 11
        Me.Button18.Text = "Show info"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TextBox14)
        Me.Panel5.Location = New System.Drawing.Point(6, 119)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(417, 386)
        Me.Panel5.TabIndex = 10
        '
        'TextBox14
        '
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox14.Location = New System.Drawing.Point(3, 3)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(411, 254)
        Me.TextBox14.TabIndex = 0
        Me.TextBox14.Text = resources.GetString("TextBox14.Text")
        '
        'checkBox3
        '
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.Location = New System.Drawing.Point(6, 95)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(359, 24)
        Me.checkBox3.TabIndex = 6
        Me.checkBox3.Text = "Allow cross section sample points to be plotted on the map"
        Me.checkBox3.UseVisualStyleBackColor = True
        '
        'numericUpDown3
        '
        Me.numericUpDown3.Location = New System.Drawing.Point(164, 48)
        Me.numericUpDown3.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numericUpDown3.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numericUpDown3.Name = "numericUpDown3"
        Me.numericUpDown3.Size = New System.Drawing.Size(44, 20)
        Me.numericUpDown3.TabIndex = 5
        Me.numericUpDown3.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'button13
        '
        Me.button13.Location = New System.Drawing.Point(103, 71)
        Me.button13.Name = "button13"
        Me.button13.Size = New System.Drawing.Size(55, 20)
        Me.button13.TabIndex = 4
        Me.button13.Text = "Clear"
        Me.button13.UseVisualStyleBackColor = True
        '
        'button12
        '
        Me.button12.Location = New System.Drawing.Point(103, 48)
        Me.button12.Name = "button12"
        Me.button12.Size = New System.Drawing.Size(55, 20)
        Me.button12.TabIndex = 3
        Me.button12.Text = "Add"
        Me.button12.UseVisualStyleBackColor = True
        '
        'listBox2
        '
        Me.listBox2.FormattingEnabled = True
        Me.listBox2.Items.AddRange(New Object() {"10", "20", "30", "40"})
        Me.listBox2.Location = New System.Drawing.Point(28, 48)
        Me.listBox2.Name = "listBox2"
        Me.listBox2.Size = New System.Drawing.Size(69, 43)
        Me.listBox2.TabIndex = 2
        '
        'checkBox2
        '
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.Location = New System.Drawing.Point(6, 24)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(295, 24)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Allow changes to number of samples (add to list below)"
        Me.checkBox2.UseVisualStyleBackColor = True
        '
        'checkBox1
        '
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(6, 4)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(276, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Display Table (allows copy/paste to Excel or similar)"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'tabPage6
        '
        Me.tabPage6.Controls.Add(Me.Button19)
        Me.tabPage6.Controls.Add(Me.Panel6)
        Me.tabPage6.Controls.Add(Me.label12)
        Me.tabPage6.Controls.Add(Me.button11)
        Me.tabPage6.Controls.Add(Me.button10)
        Me.tabPage6.Controls.Add(Me.listBox1)
        Me.tabPage6.Location = New System.Drawing.Point(4, 22)
        Me.tabPage6.Name = "tabPage6"
        Me.tabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage6.Size = New System.Drawing.Size(432, 119)
        Me.tabPage6.TabIndex = 5
        Me.tabPage6.Text = "Grids"
        Me.tabPage6.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(361, 7)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(65, 23)
        Me.Button19.TabIndex = 11
        Me.Button19.Text = "Show info"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TextBox17)
        Me.Panel6.Controls.Add(Me.PictureBox9)
        Me.Panel6.Controls.Add(Me.TextBox16)
        Me.Panel6.Controls.Add(Me.TextBox15)
        Me.Panel6.Location = New System.Drawing.Point(6, 119)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(417, 386)
        Me.Panel6.TabIndex = 10
        '
        'TextBox17
        '
        Me.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox17.Location = New System.Drawing.Point(290, 82)
        Me.TextBox17.Multiline = True
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(124, 180)
        Me.TextBox17.TabIndex = 3
        Me.TextBox17.Text = "Values are obtained for all overlapping grids" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grids added in this manner will" &
    " not show up on the interactive map, they will only be displayed in the cross se" &
    "ction."
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(3, 82)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(281, 180)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 2
        Me.PictureBox9.TabStop = False
        '
        'TextBox16
        '
        Me.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox16.Location = New System.Drawing.Point(3, 268)
        Me.TextBox16.Multiline = True
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(411, 115)
        Me.TextBox16.TabIndex = 1
        Me.TextBox16.Text = resources.GetString("TextBox16.Text")
        '
        'TextBox15
        '
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox15.Location = New System.Drawing.Point(3, 3)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(411, 73)
        Me.TextBox15.TabIndex = 0
        Me.TextBox15.Text = resources.GetString("TextBox15.Text")
        '
        'label12
        '
        Me.label12.Location = New System.Drawing.Point(133, 6)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(174, 23)
        Me.label12.TabIndex = 9
        Me.label12.Text = "Add multiple grids for comparisons.  "
        Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'button11
        '
        Me.button11.Location = New System.Drawing.Point(69, 7)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(58, 23)
        Me.button11.TabIndex = 8
        Me.button11.Text = "Clear"
        Me.button11.UseVisualStyleBackColor = True
        '
        'button10
        '
        Me.button10.Location = New System.Drawing.Point(4, 6)
        Me.button10.Name = "button10"
        Me.button10.Size = New System.Drawing.Size(59, 23)
        Me.button10.TabIndex = 7
        Me.button10.Text = "Add"
        Me.button10.UseVisualStyleBackColor = True
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Location = New System.Drawing.Point(3, 33)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(423, 82)
        Me.listBox1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 101)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 140)
        Me.Name = "Form1"
        Me.Text = "Grid2OpenLayers"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage3.ResumeLayout(False)
        Me.tabPage3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage4.ResumeLayout(False)
        Me.tabPage4.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage5.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage6.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private radioButton1 As System.Windows.Forms.RadioButton
	Private radioButton2 As System.Windows.Forms.RadioButton
	Private pictureBox2 As System.Windows.Forms.PictureBox
	Private pictureBox3 As System.Windows.Forms.PictureBox
	Private label12 As System.Windows.Forms.Label
    Private checkBox3 As System.Windows.Forms.CheckBox
	Private numericUpDown3 As System.Windows.Forms.NumericUpDown
	Private checkBox2 As System.Windows.Forms.CheckBox
	Private listBox2 As System.Windows.Forms.ListBox
    Private WithEvents button12 As System.Windows.Forms.Button
    Private WithEvents button13 As System.Windows.Forms.Button
    Private WithEvents button11 As System.Windows.Forms.Button
	Private listBox1 As System.Windows.Forms.ListBox
    Private WithEvents button10 As System.Windows.Forms.Button
	Private tabPage6 As System.Windows.Forms.TabPage
	Private checkBox1 As System.Windows.Forms.CheckBox
	Private label10 As System.Windows.Forms.Label
	Private textBox4 As System.Windows.Forms.TextBox
    Private WithEvents button9 As System.Windows.Forms.Button
	Private tabPage5 As System.Windows.Forms.TabPage
	Private tabPage4 As System.Windows.Forms.TabPage
	Private label9 As System.Windows.Forms.Label
	Private numericUpDown2 As System.Windows.Forms.NumericUpDown
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private textBox2 As System.Windows.Forms.TextBox
	Private textBox3 As System.Windows.Forms.TextBox
	Private tabPage3 As System.Windows.Forms.TabPage
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private numericUpDown1 As System.Windows.Forms.NumericUpDown
	Private progressBar2 As System.Windows.Forms.ProgressBar
    Private WithEvents button8 As System.Windows.Forms.Button
	Private label4 As System.Windows.Forms.Label
	Private colorDialog1 As System.Windows.Forms.ColorDialog
	Private tabPage2 As System.Windows.Forms.TabPage
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
    Private WithEvents button5 As System.Windows.Forms.Button
    Private WithEvents button6 As System.Windows.Forms.Button
    Private WithEvents button7 As System.Windows.Forms.Button
	Private tabPage1 As System.Windows.Forms.TabPage
	Private tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private progressBar1 As System.Windows.Forms.ProgressBar
	Private label1 As System.Windows.Forms.Label
	Private textBox1 As System.Windows.Forms.TextBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
End Class
