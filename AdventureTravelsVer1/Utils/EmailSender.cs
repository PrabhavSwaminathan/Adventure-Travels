using AdventureTravelsVer1.Models;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using Attachment = SendGrid.Helpers.Mail.Attachment;

namespace AdventureTravelsVer1.Utils
{
    public class EmailSender
    {
        private const String API_KEY = "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";

        public void Send(String toEmail, String subject, String contents, System.Net.Mail.Attachment attachment)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@localhost.com", "Adventure Travels");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
            //msg.AddAttachment(Server.MapPath(@"~\img\logo.png"));
            //Attachment newAttach = new Attachment(Server.MapPath(@"~\img\logo.png"));
            //msg.Attachments.Add(newAttach);
        }

        internal void Send(string toEmail, string subject, string contents)
        {
            throw new NotImplementedException();
        }
    }
}