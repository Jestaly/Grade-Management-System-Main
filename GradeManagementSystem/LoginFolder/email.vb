'Imports System.Net.Mail

Public Class email
    Public Sub emailReset(emailRecipient As String, emailSubject As String, emailName As String, code As String)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False

            ' Email setup
            'e_mail.From = New MailAddress("plp.unisystem@gmail.com")
            'e_mail.To.Add(emailRecipient)
            'e_mail.Subject = emailSubject
            ''e_mail.IsBodyHtml = True''

            ' Properly formatted HTML body
            'e_mail.Body = "
            '            <html>
            '           <head>
            '              <style>
            '                 body { margin:0; color:#333; font-family: Arial, sans-serif; }
            '                a { text-decoration:none; color:#006699; }
            '               p { margin:0; }
            '              img { border:0; margin:0; }
            '             #content { width:500px; margin:20px auto; }
            '#title p { font-size:26px; font-weight:bold; }
            '            .otp { font-size:24px; font-weight:bold; color:#FF0000; }
            '       </style>
            '  </head>
            ' <body>
            '    <div id='content'>
            '       <h1>Password Assistance</h1>
            '      <p>Dear " + emailName + " ,</p>
            '     <p>We received a request to reset the password for your account. Please follow the steps below:</p>
            '    <ol>
            '       <li>Enter the 6-digit verification code below:</li>
            '      <p class='otp'>" + code + "</p>
            '      <li>Choose a new password for your account.</li>
            '  </ol>
            '  <p style='color:gray;'>This verification code is valid for 15 minutes.</p>
            '   </div>
            ' </body>
            '</html>
            ' "


            ' Send email
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent", MsgBoxStyle.Information)

        Catch error_t As Exception
            MsgBox("Error: " & error_t.Message, MsgBoxStyle.Critical)
        End Try
        End Function
End Class
