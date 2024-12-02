Module FormInterface
    Public Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(93, 46, 140)
        btn.ForeColor = Color.FromArgb(254, 254, 254)
        btn.Cursor = Cursors.Hand
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 90, 230)
        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()
        btn.Region = New Region(Raduis)
    End Sub

    Public Sub DataGridDesign(DG As DataGridView)
        DG.EnableHeadersVisualStyles = False
        DG.BorderStyle = BorderStyle.None
        DG.DefaultCellStyle.ForeColor = Color.Black
        DG.DefaultCellStyle.SelectionForeColor = Color.White
        DG.BackgroundColor = Color.FromArgb(254, 254, 254)
        DG.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(93, 46, 140)
        DG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DG.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(93, 46, 140)
        DG.RowsDefaultCellStyle.BackColor = Color.White
        DG.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(160, 90, 230)
        DG.AlternatingRowsDefaultCellStyle.ForeColor = Color.White
    End Sub
End Module
