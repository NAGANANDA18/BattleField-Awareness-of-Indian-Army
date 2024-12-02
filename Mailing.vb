Imports System.Net.Mail

Module Mailing

    Public Sub SendMail(ByVal ToMail As String, ByVal MailSubject As String, ByVal isBodyHTML As Boolean, ByVal MailBody As String)
        Try
            Dim Server As New SmtpClient
            Dim mail As New MailMessage()
            Server.UseDefaultCredentials = False
            Server.Credentials = New Net.NetworkCredential("battlefieldindianarmy1@gmail.com", "jhxamoleajgflxtf")
            Server.Port = 587
            Server.EnableSsl = True
            Server.Host = "smtp.gmail.com"
            mail = New MailMessage()
            mail.From = New MailAddress("battlefieldindianarmy1@gmail.com")
            mail.To.Add(ToMail)
            mail.Subject = MailSubject
            mail.IsBodyHtml = isBodyHTML
            mail.Body = MailBody
            Server.Send(mail)
        Catch Ex As Exception
            MsgBox(Ex.ToString)
        End Try
    End Sub

    Public Function BodyofHTMLMail(ByVal otp As String) As String
        Dim stringbuilder As New System.Text.StringBuilder
        stringbuilder.Append("<!DOCTYPE Html>")
        stringbuilder.Append("<Html Lang='EN'>")
        stringbuilder.Append("<Head>")
        stringbuilder.Append("<Meta Charset='UTF-8'>")
        stringbuilder.Append("<Meta Name='Viewport' Content='Width=Device-Width, Initial-Scale=1.0'>")
        stringbuilder.Append("<Title>OTP For BattleField Awareness of Indian Army</Title>")
        stringbuilder.Append("<Style>")
        stringbuilder.Append("Body {")
        stringbuilder.Append("Margin: 0;")
        stringbuilder.Append("Padding: 0;")
        stringbuilder.Append("Background: #000000;")
        stringbuilder.Append("Background: -Webkit-Linear-Gradient(")
        stringbuilder.Append("To Right,")
        stringbuilder.Append("#434343,")
        stringbuilder.Append("#000000")
        stringbuilder.Append(");")
        stringbuilder.Append("Background: Linear-Gradient(")
        stringbuilder.Append("To Right,")
        stringbuilder.Append("#434343,")
        stringbuilder.Append("#000000")
        stringbuilder.Append(");")
        stringbuilder.Append("}")
        stringbuilder.Append(".Container{")
        stringbuilder.Append("Display: Flex;")
        stringbuilder.Append("Flex-Flow: Column;")
        stringbuilder.Append("Height: 100%;")
        stringbuilder.Append("Align-Items: Space-Around;")
        stringbuilder.Append("Justify-Content: Center;")
        stringbuilder.Append("}")
        stringbuilder.Append(".UserInput{")
        stringbuilder.Append(" Display: Flex;")
        stringbuilder.Append("Justify-Content: Center;")
        stringbuilder.Append("}")
        stringbuilder.Append("Input{")
        stringbuilder.Append("Margin: 10px;")
        stringbuilder.Append("Height: 35px;")
        stringbuilder.Append("Width: 65px;")
        stringbuilder.Append("Border: None;")
        stringbuilder.Append("Border-Radius: 5px;")
        stringbuilder.Append("Text-Align: Center;")
        stringbuilder.Append("Font-Family: Arimo;")
        stringbuilder.Append("Font-Size: 1.2rem;")
        stringbuilder.Append("Background: #Eef2f3;")
        stringbuilder.Append("}")
        stringbuilder.Append("H1{")
        stringbuilder.Append("Text-Align: Center;")
        stringbuilder.Append("Font-Family: Arimo;")
        stringbuilder.Append("Color: Honeydew;")
        stringbuilder.Append("}")
        stringbuilder.Append("Button{")
        stringbuilder.Append("Width: 150px;")
        stringbuilder.Append("Height: 40px;")
        stringbuilder.Append("Margin: 25px Auto 0px Auto;")
        stringbuilder.Append("Font-Family: Arimo;")
        stringbuilder.Append("Font-Size: 1.1rem;")
        stringbuilder.Append("Border: None;")
        stringbuilder.Append("Border-Radius: 5px;")
        stringbuilder.Append("Letter-Spacing: 2px;")
        stringbuilder.Append("Cursor: Pointer;")
        stringbuilder.Append("Background: #616161;")
        stringbuilder.Append("Background: -Webkit-Linear-Gradient(")
        stringbuilder.Append("To Right,")
        stringbuilder.Append("#9bc5c3,")
        stringbuilder.Append("#616161")
        stringbuilder.Append(");")
        stringbuilder.Append("Background: Linear-Gradient(")
        stringbuilder.Append("To Right,")
        stringbuilder.Append("#9bc5c3,")
        stringbuilder.Append("#616161")
        stringbuilder.Append(");")
        stringbuilder.Append("}")
        stringbuilder.Append("</Style></Head>")
        stringbuilder.Append("<Body>")
        stringbuilder.Append("<Div Class='Container'><font color='black'>")
        stringbuilder.Append("<h4>Dear Sir/Madam,</h4>")
        stringbuilder.Append("<center>Your OTP for <B>BattleField of Indian Army</b></center>")
        stringbuilder.Append("<Font color='Black'><Div Class='UserInput'>")
        stringbuilder.Append("<Input Type='Text' value='" & otp.Chars(0) & "' readonly>")
        stringbuilder.Append("<Input Type='Text' value='" & otp.Chars(1) & "' readonly>")
        stringbuilder.Append("<Input Type='Text' value='" & otp.Chars(2) & "' readonly>")
        stringbuilder.Append("<Input Type='Text' value='" & otp.Chars(3) & "' readonly>")
        stringbuilder.Append("<Input Type='Text' value='" & otp.Chars(4) & "' readonly>")
        stringbuilder.Append("</Div></Font>")
        stringbuilder.Append("</Div>")
        stringbuilder.Append("<h6>DISCLAIMER:</h6>")
        stringbuilder.Append("This email may contain privileged information and is intended solely for the addressee, and any disclosure of this information is strictly prohibited, and may be unlawful. If you have received this mail by mistake, please inform the sender immediately and delete this mail. Any information expressed in this mail does not necessarily reflect the views of INDIAN ARMY.</font>")
        stringbuilder.Append("</Body>")
        stringbuilder.Append("</Html>")
        Return stringbuilder.ToString
    End Function

End Module
