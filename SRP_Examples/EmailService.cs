using System;
using System.Net.Mail;


namespace SRP_Examples
{
    class EmailService
    {
        public void Send(...)
        {
            SmtpClient client = new SmtpClient("smtp.myhost.com");
            client.Send(new MailMessage()); //Send a welcome email.
        }
    }
}
