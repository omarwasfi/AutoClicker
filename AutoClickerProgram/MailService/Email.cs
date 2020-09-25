using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailService
{
    public class Email
    {
        private SmtpClient client { get; set; }
        public Email()
        {
            this.client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("wasfireports@gmail.com", "wasfi87879"),
                EnableSsl = true
            };

        }
        public void Send(string to, string subject, string body)
        {
            client.Send("wasfireports@gmail.com", to, subject, body);

        }


    }
}