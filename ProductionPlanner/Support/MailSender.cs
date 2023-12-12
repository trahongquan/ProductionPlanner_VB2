using System.Net.Mail;
using System.Net;
using ProductionPlanner.Model;

namespace ProductionPlanner.Support
{
    internal class MailSender
    {
        string mailReceiver = "";
        const string mailSender = "85F7t2bJlAJUe6u1U=8fxCGW1HpEtvIdZhJmb2ef";
        const string mailSenderPass = "n2Pu5Fw==8m38Yg0SCtFJf";
        string verifyCode = "";

        Cryption crypt = new Cryption();

        public MailSender()
        {
        }

        public MailSender(string mailReceiver, string verifyCode)
        {
            this.mailReceiver = mailReceiver;
            this.verifyCode = verifyCode;
        }

        public void Sent()
        {
            MailMessage mess = new MailMessage(crypt.getDecrypt(mailSender), mailReceiver,"verify", verifyCode);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            client.EnableSsl = true;
            //client.Credentials = new NetworkCredential(crypt.getDecrypt(mailSender), crypt.getDecrypt(mailSenderPass));
            client.Credentials = new NetworkCredential("nguyentaihieuXXXX@gmail.com", "Mat_khau_ko_the_share");
            client.Send(mess);
        }
    }
}
