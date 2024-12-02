Imports System.Threading

Public Class RobotControl
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Load("C:\Users\gowth\Documents\Project\Assets\Images\PNG\cancel Red.png")
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Load("C:\Users\gowth\Documents\Project\Assets\Images\PNG\cancel.png")
    End Sub

    Private Sub RobotControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RoundButton(ForwardBtn)
        RoundButton(BackwardBtn)
        RoundButton(LeftBtn)
        RoundButton(RightBtn)
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox1.Items.AddRange(myPort)
        Closebtn.Enabled = False
        InitializeBtn.Enabled = True

    End Sub
    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())

    End Sub
    Private Sub ReceivedText(ByVal [text] As String) 'input from ReadExisting
        If text = "0" Then
            SerialPort1.Write("2")
            Thread.Sleep(2000)
            SerialPort1.Write("5")
        End If
    End Sub


    Private Sub ForwardBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardBtn.Click
        SerialPort1.Write("1")
        '  RichTextBox2.Clear()
    End Sub

    Private Sub LeftBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftBtn.Click
        SerialPort1.Write("3")

    End Sub

    Private Sub BackwardBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackwardBtn.Click
        SerialPort1.Write("2")

    End Sub

    Private Sub RightBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightBtn.Click
        SerialPort1.Write("4")

    End Sub


    Private Sub InitializeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InitializeBtn.Click
        SerialPort1.PortName = ComboBox1.Text
        SerialPort1.BaudRate = ComboBox2.Text
        SerialPort1.Open()
        Closebtn.Enabled = True
        InitializeBtn.Enabled = False
    End Sub

    Private Sub Closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Closebtn.Click
        SerialPort1.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SerialPort1.Write("5")
    End Sub
End Class