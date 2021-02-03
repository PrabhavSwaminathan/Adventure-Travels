using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AdventureTravelsVer1.Utils
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "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";

        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@localhost.com", "Adventure Travels");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }

    }
}