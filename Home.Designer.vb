<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.RobotControlBtn = New System.Windows.Forms.Button()
        Me.ReportorFeedbackBtn = New System.Windows.Forms.Button()
        Me.AccountSettingBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblsessionrole = New System.Windows.Forms.Label()
        Me.lblsessionname = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HomeMenues = New System.Windows.Forms.MenuStrip()
        Me.ArmyStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewArmyStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewArmyStaffToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateSoldierInjuredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageRegimentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRegimentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRegimentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSoldierInRegimentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageRanksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSoldierRankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCriminalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCriminalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCriminalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageDoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreatSoldierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTreatSoldierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageTrainedDogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTrainedDogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTrainedDogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStoclToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RobotControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HomeMenues.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LogoutBtn)
        Me.Panel1.Controls.Add(Me.RobotControlBtn)
        Me.Panel1.Controls.Add(Me.ReportorFeedbackBtn)
        Me.Panel1.Controls.Add(Me.AccountSettingBtn)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 742)
        Me.Panel1.TabIndex = 10
        '
        'LogoutBtn
        '
        Me.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogoutBtn.FlatAppearance.BorderSize = 0
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn.Location = New System.Drawing.Point(0, 373)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(219, 56)
        Me.LogoutBtn.TabIndex = 16
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = False
        '
        'RobotControlBtn
        '
        Me.RobotControlBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RobotControlBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.RobotControlBtn.FlatAppearance.BorderSize = 0
        Me.RobotControlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RobotControlBtn.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RobotControlBtn.Location = New System.Drawing.Point(0, 317)
        Me.RobotControlBtn.Name = "RobotControlBtn"
        Me.RobotControlBtn.Size = New System.Drawing.Size(219, 56)
        Me.RobotControlBtn.TabIndex = 15
        Me.RobotControlBtn.Text = "RobotControl"
        Me.RobotControlBtn.UseVisualStyleBackColor = False
        '
        'ReportorFeedbackBtn
        '
        Me.ReportorFeedbackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ReportorFeedbackBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ReportorFeedbackBtn.FlatAppearance.BorderSize = 0
        Me.ReportorFeedbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReportorFeedbackBtn.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportorFeedbackBtn.Location = New System.Drawing.Point(0, 247)
        Me.ReportorFeedbackBtn.Name = "ReportorFeedbackBtn"
        Me.ReportorFeedbackBtn.Size = New System.Drawing.Size(219, 70)
        Me.ReportorFeedbackBtn.TabIndex = 5
        Me.ReportorFeedbackBtn.Text = "Report/Feedback"
        Me.ReportorFeedbackBtn.UseVisualStyleBackColor = False
        '
        'AccountSettingBtn
        '
        Me.AccountSettingBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AccountSettingBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AccountSettingBtn.FlatAppearance.BorderSize = 0
        Me.AccountSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccountSettingBtn.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountSettingBtn.Location = New System.Drawing.Point(0, 200)
        Me.AccountSettingBtn.Name = "AccountSettingBtn"
        Me.AccountSettingBtn.Size = New System.Drawing.Size(219, 47)
        Me.AccountSettingBtn.TabIndex = 1
        Me.AccountSettingBtn.Text = "Account Setting"
        Me.AccountSettingBtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblsessionrole)
        Me.Panel2.Controls.Add(Me.lblsessionname)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 200)
        Me.Panel2.TabIndex = 0
        '
        'lblsessionrole
        '
        Me.lblsessionrole.AutoSize = True
        Me.lblsessionrole.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsessionrole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblsessionrole.Location = New System.Drawing.Point(68, 159)
        Me.lblsessionrole.Name = "lblsessionrole"
        Me.lblsessionrole.Size = New System.Drawing.Size(120, 22)
        Me.lblsessionrole.TabIndex = 2
        Me.lblsessionrole.Text = "Administrator"
        '
        'lblsessionname
        '
        Me.lblsessionname.AutoSize = True
        Me.lblsessionname.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsessionname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblsessionname.Location = New System.Drawing.Point(70, 130)
        Me.lblsessionname.Name = "lblsessionname"
        Me.lblsessionname.Size = New System.Drawing.Size(88, 22)
        Me.lblsessionname.TabIndex = 1
        Me.lblsessionname.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(61, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 91)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30
        '
        'HomeMenues
        '
        Me.HomeMenues.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeMenues.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArmyStaffToolStripMenuItem, Me.ManageRegimentToolStripMenuItem, Me.ManageRanksToolStripMenuItem, Me.ManageCriminalToolStripMenuItem, Me.ManageDoctorToolStripMenuItem, Me.ManageTrainedDogToolStripMenuItem, Me.ManageStockToolStripMenuItem, Me.WindowsToolStripMenuItem})
        Me.HomeMenues.Location = New System.Drawing.Point(0, 0)
        Me.HomeMenues.Name = "HomeMenues"
        Me.HomeMenues.Size = New System.Drawing.Size(1427, 30)
        Me.HomeMenues.TabIndex = 6
        Me.HomeMenues.Text = "Home-Menues"
        '
        'ArmyStaffToolStripMenuItem
        '
        Me.ArmyStaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewArmyStaffToolStripMenuItem, Me.ViewArmyStaffToolStripMenuItem1, Me.UpdateSoldierInjuredToolStripMenuItem})
        Me.ArmyStaffToolStripMenuItem.Name = "ArmyStaffToolStripMenuItem"
        Me.ArmyStaffToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.ArmyStaffToolStripMenuItem.Text = "Manage Soldier"
        '
        'ViewArmyStaffToolStripMenuItem
        '
        Me.ViewArmyStaffToolStripMenuItem.Name = "ViewArmyStaffToolStripMenuItem"
        Me.ViewArmyStaffToolStripMenuItem.Size = New System.Drawing.Size(261, 26)
        Me.ViewArmyStaffToolStripMenuItem.Text = "Add Soldier"
        '
        'ViewArmyStaffToolStripMenuItem1
        '
        Me.ViewArmyStaffToolStripMenuItem1.Name = "ViewArmyStaffToolStripMenuItem1"
        Me.ViewArmyStaffToolStripMenuItem1.Size = New System.Drawing.Size(261, 26)
        Me.ViewArmyStaffToolStripMenuItem1.Text = "View Soldier"
        '
        'UpdateSoldierInjuredToolStripMenuItem
        '
        Me.UpdateSoldierInjuredToolStripMenuItem.Name = "UpdateSoldierInjuredToolStripMenuItem"
        Me.UpdateSoldierInjuredToolStripMenuItem.Size = New System.Drawing.Size(261, 26)
        Me.UpdateSoldierInjuredToolStripMenuItem.Text = "Update Soldier Injured"
        '
        'ManageRegimentToolStripMenuItem
        '
        Me.ManageRegimentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRegimentToolStripMenuItem, Me.ViewRegimentsToolStripMenuItem, Me.ViewSoldierInRegimentToolStripMenuItem})
        Me.ManageRegimentToolStripMenuItem.Name = "ManageRegimentToolStripMenuItem"
        Me.ManageRegimentToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.ManageRegimentToolStripMenuItem.Text = "Manage Regiment"
        '
        'AddRegimentToolStripMenuItem
        '
        Me.AddRegimentToolStripMenuItem.Name = "AddRegimentToolStripMenuItem"
        Me.AddRegimentToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.AddRegimentToolStripMenuItem.Text = "Add Regiment"
        '
        'ViewRegimentsToolStripMenuItem
        '
        Me.ViewRegimentsToolStripMenuItem.Name = "ViewRegimentsToolStripMenuItem"
        Me.ViewRegimentsToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.ViewRegimentsToolStripMenuItem.Text = "View Regiments"
        '
        'ViewSoldierInRegimentToolStripMenuItem
        '
        Me.ViewSoldierInRegimentToolStripMenuItem.Name = "ViewSoldierInRegimentToolStripMenuItem"
        Me.ViewSoldierInRegimentToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.ViewSoldierInRegimentToolStripMenuItem.Text = "View Soldier in Regiment"
        '
        'ManageRanksToolStripMenuItem
        '
        Me.ManageRanksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRankToolStripMenuItem, Me.ViewSoldierRankToolStripMenuItem})
        Me.ManageRanksToolStripMenuItem.Name = "ManageRanksToolStripMenuItem"
        Me.ManageRanksToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.ManageRanksToolStripMenuItem.Text = "Manage Rank"
        '
        'AddRankToolStripMenuItem
        '
        Me.AddRankToolStripMenuItem.Name = "AddRankToolStripMenuItem"
        Me.AddRankToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.AddRankToolStripMenuItem.Text = "Add Rank"
        '
        'ViewSoldierRankToolStripMenuItem
        '
        Me.ViewSoldierRankToolStripMenuItem.Name = "ViewSoldierRankToolStripMenuItem"
        Me.ViewSoldierRankToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.ViewSoldierRankToolStripMenuItem.Text = "View Soldier Rank"
        '
        'ManageCriminalToolStripMenuItem
        '
        Me.ManageCriminalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCriminalToolStripMenuItem, Me.ViewCriminalsToolStripMenuItem})
        Me.ManageCriminalToolStripMenuItem.Name = "ManageCriminalToolStripMenuItem"
        Me.ManageCriminalToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.ManageCriminalToolStripMenuItem.Text = "Manage Criminal"
        '
        'AddCriminalToolStripMenuItem
        '
        Me.AddCriminalToolStripMenuItem.Name = "AddCriminalToolStripMenuItem"
        Me.AddCriminalToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.AddCriminalToolStripMenuItem.Text = "Add Criminal"
        '
        'ViewCriminalsToolStripMenuItem
        '
        Me.ViewCriminalsToolStripMenuItem.Name = "ViewCriminalsToolStripMenuItem"
        Me.ViewCriminalsToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.ViewCriminalsToolStripMenuItem.Text = "View Criminals"
        '
        'ManageDoctorToolStripMenuItem
        '
        Me.ManageDoctorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDoctorToolStripMenuItem, Me.ViewDoctorToolStripMenuItem, Me.TreatSoldierToolStripMenuItem, Me.ViewTreatSoldierToolStripMenuItem})
        Me.ManageDoctorToolStripMenuItem.Name = "ManageDoctorToolStripMenuItem"
        Me.ManageDoctorToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.ManageDoctorToolStripMenuItem.Text = "Manage Doctor"
        '
        'AddDoctorToolStripMenuItem
        '
        Me.AddDoctorToolStripMenuItem.Name = "AddDoctorToolStripMenuItem"
        Me.AddDoctorToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.AddDoctorToolStripMenuItem.Text = "Add Doctor"
        '
        'ViewDoctorToolStripMenuItem
        '
        Me.ViewDoctorToolStripMenuItem.Name = "ViewDoctorToolStripMenuItem"
        Me.ViewDoctorToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.ViewDoctorToolStripMenuItem.Text = "View Doctor"
        '
        'TreatSoldierToolStripMenuItem
        '
        Me.TreatSoldierToolStripMenuItem.Name = "TreatSoldierToolStripMenuItem"
        Me.TreatSoldierToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.TreatSoldierToolStripMenuItem.Text = "TreatSoldier"
        '
        'ViewTreatSoldierToolStripMenuItem
        '
        Me.ViewTreatSoldierToolStripMenuItem.Name = "ViewTreatSoldierToolStripMenuItem"
        Me.ViewTreatSoldierToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.ViewTreatSoldierToolStripMenuItem.Text = "View Treat Soldier"
        '
        'ManageTrainedDogToolStripMenuItem
        '
        Me.ManageTrainedDogToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTrainedDogToolStripMenuItem, Me.ViewTrainedDogsToolStripMenuItem})
        Me.ManageTrainedDogToolStripMenuItem.Name = "ManageTrainedDogToolStripMenuItem"
        Me.ManageTrainedDogToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.ManageTrainedDogToolStripMenuItem.Text = "Manage Trained Dog"
        '
        'AddTrainedDogToolStripMenuItem
        '
        Me.AddTrainedDogToolStripMenuItem.Name = "AddTrainedDogToolStripMenuItem"
        Me.AddTrainedDogToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.AddTrainedDogToolStripMenuItem.Text = "Add Trained Dog"
        '
        'ViewTrainedDogsToolStripMenuItem
        '
        Me.ViewTrainedDogsToolStripMenuItem.Name = "ViewTrainedDogsToolStripMenuItem"
        Me.ViewTrainedDogsToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.ViewTrainedDogsToolStripMenuItem.Text = "View Trained Dogs"
        '
        'ManageStockToolStripMenuItem
        '
        Me.ManageStockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStoclToolStripMenuItem, Me.ViewStocksToolStripMenuItem})
        Me.ManageStockToolStripMenuItem.Name = "ManageStockToolStripMenuItem"
        Me.ManageStockToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.ManageStockToolStripMenuItem.Text = "Manage Stocks"
        '
        'AddStoclToolStripMenuItem
        '
        Me.AddStoclToolStripMenuItem.Name = "AddStoclToolStripMenuItem"
        Me.AddStoclToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.AddStoclToolStripMenuItem.Text = "Add Stock"
        '
        'ViewStocksToolStripMenuItem
        '
        Me.ViewStocksToolStripMenuItem.Name = "ViewStocksToolStripMenuItem"
        Me.ViewStocksToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.ViewStocksToolStripMenuItem.Text = "View Stocks"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewDetailsToolStripMenuItem, Me.ReportFeedbackToolStripMenuItem, Me.RobotControlToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(97, 26)
        Me.WindowsToolStripMenuItem.Text = "Windows"
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.Name = "ViewDetailsToolStripMenuItem"
        Me.ViewDetailsToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ViewDetailsToolStripMenuItem.Text = "View Details"
        '
        'ReportFeedbackToolStripMenuItem
        '
        Me.ReportFeedbackToolStripMenuItem.Name = "ReportFeedbackToolStripMenuItem"
        Me.ReportFeedbackToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ReportFeedbackToolStripMenuItem.Text = "Report/Feedback"
        '
        'RobotControlToolStripMenuItem
        '
        Me.RobotControlToolStripMenuItem.Name = "RobotControlToolStripMenuItem"
        Me.RobotControlToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.RobotControlToolStripMenuItem.Text = "RobotControl"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.HomeMenues)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(219, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1427, 742)
        Me.Panel3.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1427, 712)
        Me.Panel4.TabIndex = 15
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1646, 742)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.HomeMenues
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HomeMenues.ResumeLayout(False)
        Me.HomeMenues.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AccountSettingBtn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblsessionrole As System.Windows.Forms.Label
    Friend WithEvents lblsessionname As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HomeMenues As System.Windows.Forms.MenuStrip
    Friend WithEvents ArmyStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewArmyStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewArmyStaffToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageRegimentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRegimentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRegimentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageRanksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRankToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageCriminalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCriminalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCriminalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStoclToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewStocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageTrainedDogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTrainedDogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTrainedDogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportorFeedbackBtn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ViewSoldierRankToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportFeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RobotControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RobotControlBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateSoldierInjuredToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSoldierInRegimentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageDoctorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddDoctorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDoctorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreatSoldierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTreatSoldierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutBtn As System.Windows.Forms.Button
End Class
