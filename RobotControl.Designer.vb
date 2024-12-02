<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RobotControl
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RobotControl))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ForwardBtn = New System.Windows.Forms.Button()
        Me.BackwardBtn = New System.Windows.Forms.Button()
        Me.LeftBtn = New System.Windows.Forms.Button()
        Me.RightBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.InitializeBtn = New System.Windows.Forms.Button()
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1454, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        '
        'ForwardBtn
        '
        Me.ForwardBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForwardBtn.Location = New System.Drawing.Point(593, 291)
        Me.ForwardBtn.Name = "ForwardBtn"
        Me.ForwardBtn.Size = New System.Drawing.Size(204, 64)
        Me.ForwardBtn.TabIndex = 52
        Me.ForwardBtn.Text = "Forward"
        Me.ForwardBtn.UseVisualStyleBackColor = True
        '
        'BackwardBtn
        '
        Me.BackwardBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackwardBtn.Location = New System.Drawing.Point(593, 480)
        Me.BackwardBtn.Name = "BackwardBtn"
        Me.BackwardBtn.Size = New System.Drawing.Size(204, 64)
        Me.BackwardBtn.TabIndex = 53
        Me.BackwardBtn.Text = "Backward"
        Me.BackwardBtn.UseVisualStyleBackColor = True
        '
        'LeftBtn
        '
        Me.LeftBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeftBtn.Location = New System.Drawing.Point(373, 373)
        Me.LeftBtn.Name = "LeftBtn"
        Me.LeftBtn.Size = New System.Drawing.Size(204, 64)
        Me.LeftBtn.TabIndex = 54
        Me.LeftBtn.Text = "Left"
        Me.LeftBtn.UseVisualStyleBackColor = True
        '
        'RightBtn
        '
        Me.RightBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RightBtn.Location = New System.Drawing.Point(816, 373)
        Me.RightBtn.Name = "RightBtn"
        Me.RightBtn.Size = New System.Drawing.Size(204, 64)
        Me.RightBtn.TabIndex = 55
        Me.RightBtn.Text = "Right"
        Me.RightBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 27)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(123, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 27)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Not Connected"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(647, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 36)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Robot Control"
        '
        'SerialPort1
        '
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(35, 226)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox1.TabIndex = 59
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"9600"})
        Me.ComboBox2.Location = New System.Drawing.Point(35, 291)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox2.TabIndex = 60
        '
        'InitializeBtn
        '
        Me.InitializeBtn.Location = New System.Drawing.Point(30, 357)
        Me.InitializeBtn.Name = "InitializeBtn"
        Me.InitializeBtn.Size = New System.Drawing.Size(225, 51)
        Me.InitializeBtn.TabIndex = 61
        Me.InitializeBtn.Text = "Intialize"
        Me.InitializeBtn.UseVisualStyleBackColor = True
        '
        'Closebtn
        '
        Me.Closebtn.Location = New System.Drawing.Point(30, 435)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(225, 52)
        Me.Closebtn.TabIndex = 62
        Me.Closebtn.Text = "Close"
        Me.Closebtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(583, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 64)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Stop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RobotControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1492, 905)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Closebtn)
        Me.Controls.Add(Me.InitializeBtn)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RightBtn)
        Me.Controls.Add(Me.LeftBtn)
        Me.Controls.Add(Me.BackwardBtn)
        Me.Controls.Add(Me.ForwardBtn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RobotControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ForwardBtn As System.Windows.Forms.Button
    Friend WithEvents BackwardBtn As System.Windows.Forms.Button
    Friend WithEvents LeftBtn As System.Windows.Forms.Button
    Friend WithEvents RightBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents InitializeBtn As System.Windows.Forms.Button
    Friend WithEvents Closebtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
