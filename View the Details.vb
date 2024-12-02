Imports System.Data.SqlClient

Public Class View_the_Details

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Load("C:\Users\gowth\Documents\Project\Assets\Images\PNG\cancel Red.png")
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Load("C:\Users\gowth\Documents\Project\Assets\Images\PNG\cancel.png")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListComboBox.SelectedIndexChanged
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select * from " & ListComboBox.Text & "", Conn)
        adp.Fill(DS1)
        DataGridView1.DataSource = DS1.Tables(0)
    End Sub

    Private Sub View_the_Details_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridDesign(DataGridView1)
    End Sub
End Class