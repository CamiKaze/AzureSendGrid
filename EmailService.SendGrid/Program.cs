using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;

namespace EmailService
{
    internal class EmailService
    {
        private static void Main()
        {
            Execute().Wait();
        }

        static async Task Execute()
        {
            var apiKey = System.Environment.GetEnvironmentVariable("EmailServiceAPIKey");
            var client = new SendGridClient(apiKey);

            var msg = new SendGridMessage()
            {
                From = new EmailAddress("sendgrid@test.com", "Test Name"),
                Subject = "This is the Subject line",
                PlainTextContent = "This is the context",
                HtmlContent = "<strong>This is the email body in HTML format</strong>"
            };

            msg.AddTo(new EmailAddress("Your email address here", "Test Recipient"));
            var response = await client.SendEmailAsync(msg);
            Console.WriteLine(response.StatusCode);
        }
    }
}