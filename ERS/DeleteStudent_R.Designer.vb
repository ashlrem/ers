﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteStudent_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteStudent_R))
        Me.SearchStudent_btn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.con = New System.Windows.Forms.TextBox()
        Me.sy = New System.Windows.Forms.TextBox()
        Me.ag = New System.Windows.Forms.TextBox()
        Me.gl = New System.Windows.Forms.TextBox()
        Me.bd = New System.Windows.Forms.TextBox()
        Me.nam = New System.Windows.Forms.TextBox()
        Me.add = New System.Windows.Forms.TextBox()
        Me.sn = New System.Windows.Forms.TextBox()
        Me.DeleteButton_a_Student = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchStudent_btn
        '
        Me.SearchStudent_btn.Location = New System.Drawing.Point(512, 122)
        Me.SearchStudent_btn.Name = "SearchStudent_btn"
        Me.SearchStudent_btn.Size = New System.Drawing.Size(75, 23)
        Me.SearchStudent_btn.TabIndex = 63
        Me.SearchStudent_btn.Text = "Search"
        Me.SearchStudent_btn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(520, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Contact:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(520, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Birthday:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(210, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(520, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Age:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(210, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "School Year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(210, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Grade Level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(210, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Student Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(204, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Student Number"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(779, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 46)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(53, 119)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(151, 130)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'con
        '
        Me.con.Enabled = False
        Me.con.Location = New System.Drawing.Point(611, 211)
        Me.con.Name = "con"
        Me.con.Size = New System.Drawing.Size(158, 20)
        Me.con.TabIndex = 51
        '
        'sy
        '
        Me.sy.Enabled = False
        Me.sy.Location = New System.Drawing.Point(310, 207)
        Me.sy.Name = "sy"
        Me.sy.Size = New System.Drawing.Size(176, 20)
        Me.sy.TabIndex = 50
        '
        'ag
        '
        Me.ag.Enabled = False
        Me.ag.Location = New System.Drawing.Point(610, 184)
        Me.ag.Name = "ag"
        Me.ag.Size = New System.Drawing.Size(159, 20)
        Me.ag.TabIndex = 53
        '
        'gl
        '
        Me.gl.Enabled = False
        Me.gl.Location = New System.Drawing.Point(310, 181)
        Me.gl.Name = "gl"
        Me.gl.Size = New System.Drawing.Size(176, 20)
        Me.gl.TabIndex = 52
        '
        'bd
        '
        Me.bd.Enabled = False
        Me.bd.Location = New System.Drawing.Point(610, 155)
        Me.bd.Name = "bd"
        Me.bd.Size = New System.Drawing.Size(159, 20)
        Me.bd.TabIndex = 47
        '
        'nam
        '
        Me.nam.Enabled = False
        Me.nam.Location = New System.Drawing.Point(310, 155)
        Me.nam.Name = "nam"
        Me.nam.Size = New System.Drawing.Size(176, 20)
        Me.nam.TabIndex = 46
        '
        'add
        '
        Me.add.Enabled = False
        Me.add.Location = New System.Drawing.Point(310, 233)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(176, 20)
        Me.add.TabIndex = 49
        '
        'sn
        '
        Me.sn.Location = New System.Drawing.Point(310, 124)
        Me.sn.Name = "sn"
        Me.sn.Size = New System.Drawing.Size(176, 20)
        Me.sn.TabIndex = 48
        '
        'DeleteButton_a_Student
        '
        Me.DeleteButton_a_Student.BackColor = System.Drawing.Color.White
        Me.DeleteButton_a_Student.Enabled = False
        Me.DeleteButton_a_Student.Location = New System.Drawing.Point(764, 244)
        Me.DeleteButton_a_Student.Name = "DeleteButton_a_Student"
        Me.DeleteButton_a_Student.Size = New System.Drawing.Size(105, 97)
        Me.DeleteButton_a_Student.TabIndex = 45
        Me.DeleteButton_a_Student.Text = "Delete"
        Me.DeleteButton_a_Student.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DeleteStudent_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(904, 378)
        Me.ControlBox = False
        Me.Controls.Add(Me.SearchStudent_btn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.con)
        Me.Controls.Add(Me.sy)
        Me.Controls.Add(Me.ag)
        Me.Controls.Add(Me.gl)
        Me.Controls.Add(Me.bd)
        Me.Controls.Add(Me.nam)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.sn)
        Me.Controls.Add(Me.DeleteButton_a_Student)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "DeleteStudent_R"
        Me.Text = "DeleteStudent_R"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchStudent_btn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents con As System.Windows.Forms.TextBox
    Friend WithEvents sy As System.Windows.Forms.TextBox
    Friend WithEvents ag As System.Windows.Forms.TextBox
    Friend WithEvents gl As System.Windows.Forms.TextBox
    Friend WithEvents bd As System.Windows.Forms.TextBox
    Friend WithEvents nam As System.Windows.Forms.TextBox
    Friend WithEvents add As System.Windows.Forms.TextBox
    Friend WithEvents sn As System.Windows.Forms.TextBox
    Friend WithEvents DeleteButton_a_Student As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
