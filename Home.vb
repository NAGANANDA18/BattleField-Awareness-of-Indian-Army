Imports System.Data.SqlClient
Imports System.IO

Public Class Home

    Private Sub Home_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        LoadingScreen.Close()
    End Sub

    Public Sub Home_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If SessionUserRole = "Administrator" Then
            IsAdminGrade(True)
        Else
            IsAdminGrade(False)
        End If
        lblsessionname.Text = SessionName
        lblsessionrole.Text = SessionUserRole
        UpdatePicture()
    End Sub

    Sub UpdatePicture()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("Select * From Account where Username='" & SessionUsername & "'", Conn)
        Dim da As New SqlDataAdapter(Cmd0)
        Dim ds As New DataSet()
        da.Fill(ds, "ProfileImage")
        Dim c As Integer = ds.Tables(0).Rows.Count
        If c > 0 Then
            Dim bytBLOBData() As Byte = _
                ds.Tables(0).Rows(c - 1)("ProfileImage")
            Dim stmBLOBData As New MemoryStream(bytBLOBData)
            PictureBox1.Image = Image.FromStream(stmBLOBData)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Sub IsAdminGrade(ByVal value)
        ViewArmyStaffToolStripMenuItem.Visible = value
        AddRegimentToolStripMenuItem.Visible = value
        AddRankToolStripMenuItem.Visible = value
        AddCriminalToolStripMenuItem.Visible = value
        AddStoclToolStripMenuItem.Visible = value
        AddTrainedDogToolStripMenuItem.Visible = value
        ReportorFeedbackBtn.Visible = value
        RobotControlToolStripMenuItem.Visible = value
        RobotControlBtn.Visible = value
        AddCriminalToolStripMenuItem.Visible = value
        TreatSoldierToolStripMenuItem.Visible = value
        UpdateSoldierInjuredToolStripMenuItem.Visible = value
    End Sub

    Private Sub AccountSettingBtn_Click(sender As System.Object, e As System.EventArgs) Handles AccountSettingBtn.Click
        RemoveForms()
        AccountSettings.TopLevel = False
        AccountSettings.TopMost = False
        Panel4.Controls.Add(AccountSettings)
        AccountSettings.Show()
    End Sub

    Private Sub ViewArmyStaffToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewArmyStaffToolStripMenuItem.Click
        RemoveForms()
        AddSoldier.TopLevel = False
        AddSoldier.TopMost = False
        Panel4.Controls.Add(AddSoldier)
        AddSoldier.Show()
    End Sub

    Private Sub ViewArmyStaffToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ViewArmyStaffToolStripMenuItem1.Click
        RemoveForms()
        ViewSoldier.TopLevel = False
        ViewSoldier.TopMost = False
        Panel4.Controls.Add(ViewSoldier)
        ViewSoldier.Show()
    End Sub

    Private Sub AddRegimentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddRegimentToolStripMenuItem.Click
        RemoveForms()
        AddRegiment.TopLevel = False
        AddRegiment.TopMost = False
        Panel4.Controls.Add(AddRegiment)
        AddRegiment.Show()
    End Sub

    Private Sub ViewRegimentsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewRegimentsToolStripMenuItem.Click
        RemoveForms()
        ViewRegiment.TopLevel = False
        ViewRegiment.TopMost = False
        Panel4.Controls.Add(ViewRegiment)
        ViewRegiment.Show()
    End Sub

    Private Sub AddRankToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddRankToolStripMenuItem.Click
        RemoveForms()
        AddRank.TopLevel = False
        AddRank.TopMost = False
        Panel4.Controls.Add(AddRank)
        AddRank.Show()
    End Sub

    Private Sub ViewSoldierRankToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewSoldierRankToolStripMenuItem.Click
        RemoveForms()
        ViewSoldierRank.TopLevel = False
        ViewSoldierRank.TopMost = False
        Panel4.Controls.Add(ViewSoldierRank)
        ViewSoldierRank.Show()
    End Sub

    Private Sub AddCriminalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddCriminalToolStripMenuItem.Click
        RemoveForms()
        AddCriminal.TopLevel = False
        AddCriminal.TopMost = False
        Panel4.Controls.Add(AddCriminal)
        AddCriminal.Show()
    End Sub

    Private Sub ViewCriminalsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewCriminalsToolStripMenuItem.Click
        Panel4.Controls.Clear()
        ViewCriminals.TopLevel = False
        ViewCriminals.TopMost = False
        Panel4.Controls.Add(ViewCriminals)
        ViewCriminals.Show()
    End Sub

    Private Sub AddStockToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddStoclToolStripMenuItem.Click
        RemoveForms()
        AddStock.TopLevel = False
        AddStock.TopMost = False
        Panel4.Controls.Add(AddStock)
        AddStock.Show()
    End Sub

    Private Sub ViewStocksToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewStocksToolStripMenuItem.Click
        RemoveForms()
        ViewStock.TopLevel = False
        ViewStock.TopMost = False
        Panel4.Controls.Add(ViewStock)
        ViewStock.Show()
    End Sub

    Private Sub AddTrainedDogToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddTrainedDogToolStripMenuItem.Click
        RemoveForms()
        AddTrainedDog.TopLevel = False
        AddTrainedDog.TopMost = False
        Panel4.Controls.Add(AddTrainedDog)
        AddTrainedDog.Show()
    End Sub

    Private Sub ViewTrainedDogsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewTrainedDogsToolStripMenuItem.Click
        RemoveForms()
        ViewTrainedDog.TopLevel = False
        ViewTrainedDog.TopMost = False
        Panel4.Controls.Add(ViewTrainedDog)
        ViewTrainedDog.Show()
    End Sub

    Private Sub ViewDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewDetailsToolStripMenuItem.Click
        RemoveForms()
        View_the_Details.TopLevel = False
        View_the_Details.TopMost = False
        Panel4.Controls.Add(View_the_Details)
        View_the_Details.Show()
    End Sub

    Private Sub ReportFeedbackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReportFeedbackToolStripMenuItem.Click
        RemoveForms()
        ReportorFeedback.TopLevel = False
        ReportorFeedback.TopMost = False
        Panel4.Controls.Add(ReportorFeedback)
        ReportorFeedback.Show()
    End Sub



    Sub RemoveForms()
        AddSoldier.Close()
        ViewSoldier.Close()
        AddCriminal.Close()
        ViewCriminals.Close()
        AddRank.Close()
        ViewSoldierRank.Close()
        AddRegiment.Close()
        ViewRegiment.Close()
        AddStock.Close()
        ViewStock.Close()
        AddTrainedDog.Close()
        ViewTrainedDog.Close()
        RobotControl.Close()
        AccountSettings.Close()
        View_the_Details.Close()
        ReportorFeedback.Close()
        RobotControl.Close()
        ViewReportorFeedback.Close()
        UpdateSoldierInjured.Close()
        AddDoctor.Close()
        ViewDoctor.Close()
        TreatSoldier.Close()
        ViewTreatSoldier.Close()
        ViewSoldierWithinRegiment.Close()
    End Sub

    Private Sub LogoutBtn_Click(sender As System.Object, e As System.EventArgs) Handles LogoutBtn.Click
        SessionUsername = ""
        SessionName = ""
        SessionEmail = ""
        SessionUserRole = ""
        Login.Show()
        Me.Close()
    End Sub

    Private Sub ReportorFeedbackBtn_Click(sender As System.Object, e As System.EventArgs) Handles ReportorFeedbackBtn.Click
        RemoveForms()
        ViewReportorFeedback.TopLevel = False
        ViewReportorFeedback.TopMost = False
        Panel4.Controls.Add(ViewReportorFeedback)
        ViewReportorFeedback.Show()
    End Sub

    Private Sub RobotControlBtn_Click(sender As System.Object, e As System.EventArgs) Handles RobotControlBtn.Click
        RemoveForms()
        RobotControl.TopLevel = False
        RobotControl.TopMost = False
        Panel4.Controls.Add(RobotControl)
        RobotControl.Show()
    End Sub

    Private Sub UpdateSoldierInjuredToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdateSoldierInjuredToolStripMenuItem.Click
        RemoveForms()
        UpdateSoldierInjured.TopLevel = False
        UpdateSoldierInjured.TopMost = False
        Panel4.Controls.Add(UpdateSoldierInjured)
        UpdateSoldierInjured.Show()
    End Sub

    Private Sub ViewSoldierInRegimentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewSoldierInRegimentToolStripMenuItem.Click
        RemoveForms()
        ViewSoldierWithinRegiment.TopLevel = False
        ViewSoldierWithinRegiment.TopMost = False
        Panel4.Controls.Add(ViewSoldierWithinRegiment)
        ViewSoldierWithinRegiment.Show()
    End Sub

    Private Sub AddDoctorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddDoctorToolStripMenuItem.Click
        RemoveForms()
        AddDoctor.TopLevel = False
        AddDoctor.TopMost = False
        Panel4.Controls.Add(AddDoctor)
        AddDoctor.Show()
    End Sub

    Private Sub ViewDoctorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewDoctorToolStripMenuItem.Click
        RemoveForms()
        ViewDoctor.TopLevel = False
        ViewDoctor.TopMost = False
        Panel4.Controls.Add(ViewDoctor)
        ViewDoctor.Show()
    End Sub

    Private Sub TreatSoldierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TreatSoldierToolStripMenuItem.Click
        RemoveForms()
        TreatSoldier.TopLevel = False
        TreatSoldier.TopMost = False
        Panel4.Controls.Add(TreatSoldier)
        TreatSoldier.Show()
    End Sub

    Private Sub ViewTreatSoldierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewTreatSoldierToolStripMenuItem.Click
        RemoveForms()
        ViewTreatSoldier.TopLevel = False
        ViewTreatSoldier.TopMost = False
        Panel4.Controls.Add(TreatSoldier)
        ViewTreatSoldier.Show()
    End Sub
End Class