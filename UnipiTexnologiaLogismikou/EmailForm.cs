using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace UnipiTexnologiaLogismikou
{
    public partial class EmailForm : Form
    {
        //δηλωνουμε μια αναφορα τυπου MailMessage
        MailMessage msg;
        public EmailForm()
        {
            InitializeComponent();
        }

        private void senmailbutton_Click(object sender, EventArgs e)
        {
            //για τις αναγκες της παρουσας εργασιας φτιαξαμε ενα mail projectsunipi@gmail.com.
            //για λογους ασφαλειας επιλεξαμε μην βαζει ακποιος το κανονικο μεηλ του και τους κωδικους του
            //ετσι λοιπον οτι μεηλ και να γραψει στο textbox θα φυγει και θα παραληφθει απο το παραπανω μεηλ

            MailSender msender = new MailSender();

            msender.Sendmail(mailtextBox, messagetextBox);
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            UserMenu Form1 = new UserMenu();
            Form1.Show(this);
            this.Hide();
        }

        private void EmailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EmailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
