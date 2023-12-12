using ProductionPlanner.Model;
using ProductionPlanner.Support;
using MailKit.Net.Smtp;
//using MailKit;
using MimeKit;


namespace ProductionPlanner.View
{
    public partial class FormVerify : Form
    {
        private int sec = 90;
        private bool is_verify = false;
        private MimeMessage email = new MimeMessage();
        private string verify_code;
        private Cryption cryption = new Cryption();
        private string receiver;
        public FormVerify(string receiver)
        {
            InitializeComponent();
            this.receiver = receiver;
        }

        private void FormVerify_Load(object sender, EventArgs e)
        {
            Cryption cryption = new Cryption();
            const string mailSender = "85F7t2bJlAJkwwUe6u1U=8fxCGW1HpEtvIdOLYZhJmb2ef";
            const string mailSenderPass = "********";
            verify_code = genPass();

            try
            {
                email.From.Add(new MailboxAddress("Production Planner", "****@gmail.com"));
                email.To.Add(new MailboxAddress(receiver, "**********@gmail.com"));
                email.Subject = "Modify Capacity info";
                email.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
                {
                    Text = "This is verify code (90s):    " + verify_code
                };

                using (var smtp = new SmtpClient())
                {
                    smtp.Connect("smtp.gmail.com", 587, false);

                    // Note: only needed if the SMTP server requires authentication
                    smtp.Authenticate(cryption.getDecrypt(mailSender), mailSenderPass);

                    smtp.Send(email);
                    smtp.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            verify_code = cryption.getMD5(verify_code);
            timer1.Start();
        }

        private string genPass()
        {
            string st = "";
            Random random = new Random();

            st += random.Next(0, 9).ToString();
            st += random.Next(0, 9).ToString();
            st += random.Next(0, 9).ToString();
            st += random.Next(0, 9).ToString();
            st += random.Next(0, 9).ToString();
            st += random.Next(0, 9).ToString();

            return st;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            --sec;
            lab_countdown.Text = sec.ToString();

            if (sec <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Time out. Not verify");
                is_verify = false;
                btn_esc_Click(sender, e);
            }
        }

        private void btn_esc_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            is_verify = false;
            this.Close();
        }

        private void FormVerify_FormClosed(object sender, FormClosedEventArgs e)
        {
            soundSupport sound = new soundSupport();
            timer1.Stop();
            if (is_verify)
            {
                sound.sayYes();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                sound.sayNo();
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (cryption.getMD5(txt_code.Text).Equals(verify_code))
            {
                is_verify = true;
                timer1.Stop();
                this.Close();
            }
        }

        private void txt_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_ok_Click(sender, e);
            }
        }
    }
}
