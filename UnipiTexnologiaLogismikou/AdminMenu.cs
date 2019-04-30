using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiTexnologiaLogismikou
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }



        private void dbbutton_Click_1(object sender, EventArgs e)
        {
            DbForm dbform = new DbForm();
            dbform.Show(this);
            this.Hide();
        }

        private void finalgradebutton_Click(object sender, EventArgs e)
        {
            FinalGradeForm finalgradeform = new FinalGradeForm();
            finalgradeform.Show(this);
            this.Hide();
        }

        private void reportbutton_Click(object sender, EventArgs e)
        {
            ReportingForm reportingform = new ReportingForm();
            reportingform.Show(this);
            this.Hide();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void commentbutton_Click(object sender, EventArgs e)
        {
            CommentForm commentform = new CommentForm();
            commentform.Show(this);
            this.Hide();
        }

        private void progressbutton_Click(object sender, EventArgs e)
        {
            ProgressForm progressForm = new ProgressForm();
            progressForm.Show(this);
            this.Hide();
        }

        private void AdminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
